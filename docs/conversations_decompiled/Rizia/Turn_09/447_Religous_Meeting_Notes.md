# Rizia/Turn 9/Religous Meeting Notes

- **ID konwersacji:** `447`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/447_Religous_Meeting_Notes.md`
- **Liczba węzłów dialogowych:** 122
- **Liczba wyborów gracza:** 25

---

## 1. Uczestnicy Sceny

- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_GrandVizier_Empty`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.Trait_RebelKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist`
- `RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Theocracy_None`
- `RiziaDLC.Theocracy_Partial`
- `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceAgnostic`
- `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceCouncil`
- `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGG`
- `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil`
- `RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""I know the position has opened up recently. But I have other candidates in mind.""** | `[8]` **Sal Ignacius**: ""Firstly, as I mentioned the nig..." | `Variable["RiziaDLC.Council_GrandVizier_Empty"] == true` | *Brak zmian stanu* | `[92]` **Sal Ignacius**: ""Very well. Moving on..."" |
| `[20]` | **""Yes, I remember. You'll be pleased to know I'm still open to such a proposal.""** | `[8]` **Sal Ignacius**: ""Firstly, as I mentioned the nig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Sal Ignacius**: ""I *am* pleased to hear it."" |
| `[21]` | **""I said it before and I'll say it again... I'm not replacing Hugo. What's your oth..."** | `[8]` **Sal Ignacius**: ""Firstly, as I mentioned the nig..." | `(Variable["RiziaDLC.Council_GrandVizier_Empty"] == true) == false` | *Brak zmian stanu* | `[92]` **Sal Ignacius**: ""Very well. Moving on..."" |
| `[22]` | **""Oh, yes. Right. You as Grand Vizier. What were you saying about that?""** | `[8]` **Sal Ignacius**: ""Firstly, as I mentioned the nig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Sal Ignacius**: ""That the advantages of appointi..." |
| `[30]` | **""Well, if we're talking about the role of Grand Vizier, consider the job yours." [..."** | `[29]` **Sal Ignacius**: ""So what do you say, Your Majest..." | `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false` | `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGran...` | `[42]` **Sal Ignacius**: ""Excellent! You have no idea how..." |
| `[31]` | **""I have no intention of supplanting Hugo for you.""** | `[29]` **Sal Ignacius**: ""So what do you say, Your Majest..." | `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false` | `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGra...` | `[40]` **Sal Ignacius**: ""I'm sorry to hear that."" |
| `[34]` | **""I'm open to taking such a journey, however, when it comes to replacing Hugo, as I..."** | `[29]` **Sal Ignacius**: ""So what do you say, Your Majest..." | `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false` | `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGra...` | `[40]` **Sal Ignacius**: ""I'm sorry to hear that."" |
| `[38]` | **""You already know my answer regarding the Grand Vizier position. It's yours.""** | `[29]` **Sal Ignacius**: ""So what do you say, Your Majest..." | `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true` | *Brak zmian stanu* | `[90]` **Sal Ignacius**: ""Thanks again, Your Majesty. You..." |
| `[44]` | **""If you're really keen on the position of Grand Vizier, you can submit a petition ..."** | `[29]` **Sal Ignacius**: ""So what do you say, Your Majest..." | `Variable["RiziaDLC.Council_GrandVizier_Empty"] == true`<br>`(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false` | `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGra...` | `[89]` **Sal Ignacius**: ""That's encouraging to hear. I'l..." |
| `[49]` | **""I'm not fond of either. While I'm usually open to bold moves, this feels like it'..."** | `[48]` **Sal Ignacius**: ""What of the Golden Guard's and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Sal Ignacius**: ""Yes, of course. Then I won't sp..." |
| `[50]` | **""I commend you for your vision of the future. I shall give your Royal Council repl..."** | `[48]` **Sal Ignacius**: ""What of the Golden Guard's and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Sal Ignacius**: ""Please do. There's untold possi..." |
| `[51]` | **""Both are complex proposals, and if approved, would necessitate a substantial amou..."** | `[48]` **Sal Ignacius**: ""What of the Golden Guard's and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Sal Ignacius**: ""Understandable, Your Majesty. P..." |
| `[55]` | **""I applaud your vision for the future. I will carefully consider the Golden Guard ..."** | `[48]` **Sal Ignacius**: ""What of the Golden Guard's and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Sal Ignacius**: ""Oh, please do. There's untold p..." |
| `[60]` | **""I see no reason why either of those proposals couldn't come to fruition, but that..."** | `[48]` **Sal Ignacius**: ""What of the Golden Guard's and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Sal Ignacius**: """That's excellent news! But yes..." |
| `[65]` | **""Rest assured, I am committed to implementing the required reforms to establish th..."** | `[64]` **Sal Ignacius**: ""Anyway, thanks for hearing me o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Theocracy_Full"] = true;` | `[73]` **Sal Ignacius**: ""Bless You, Your Majesty. This m..." |
| `[66]` | **"Just so we're clear, I have no intention of turning this kingdom into a divine rea..."** | `[64]` **Sal Ignacius**: ""Anyway, thanks for hearing me o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Theocracy_None"] = true; ;` | `[87]` **Sal Ignacius**: ""It pains me to hear you reject ..." |
| `[67]` | **""I can't commit to implementing all of your reforms, but I'm open to some. We need..."** | `[64]` **Sal Ignacius**: ""Anyway, thanks for hearing me o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Theocracy_Partial"] = true;` | `[74]` **Sal Ignacius**: ""Overall, I'm heartened to hear ..." |
| `[68]` | **""Committing to all your reforms just isn't possible, especially when it concerns i..."** | `[64]` **Sal Ignacius**: ""Anyway, thanks for hearing me o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Theocracy_Partial"] = true;` | `[86]` **Sal Ignacius**: ""Overall, it heartens me to hear..." |
| `[93]` | **""Well, it goes without saying that Titus wouldn't be happy about that. However, se..."** | `[122]` **Sal Ignacius**: ""That said, I would recommend th..." | `Variable["RiziaDLC.Council_Security_Titus"] == true` | *Brak zmian stanu* | `[107]` **Sal Ignacius**: ""I'm glad you brought that up, a..." |
| `[98]` | **""Makes sense. If this kingdom is to fully embrace the one true faith, then it need..."** | `[122]` **Sal Ignacius**: ""That said, I would recommend th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Sal Ignacius**: ""I'm glad you see it that way, a..." |
| `[99]` | **""The Golden Guard's history of protecting the monarchy dates back centuries. I won..."** | `[122]` **Sal Ignacius**: ""That said, I would recommend th..." | `(Variable["RiziaDLC.Trait_RebelKing"] == true) == false` | *Brak zmian stanu* | `[111]` **Sal Ignacius**: ""Of course. And I don't mean to ..." |
| `[100]` | **"Ah, throw tradition out the window. Sure! I'm open to the idea. The palace could c..."** | `[122]` **Sal Ignacius**: ""That said, I would recommend th..." | `Variable["RiziaDLC.Trait_RebelKing"] == true` | *Brak zmian stanu* | `[24]` **Sal Ignacius**: ""I'm very pleased you think so. ..." |
| `[101]` | **""Well, it goes without saying that Titus wouldn't be happy about that.""** | `[122]` **Sal Ignacius**: ""That said, I would recommend th..." | `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false` | *Brak zmian stanu* | `[109]` **Sal Ignacius**: ""Captain Gordion is one of the m..." |
| `[118]` | **""Of course! I was considering such a change myself.""** | `[122]` **Sal Ignacius**: ""That said, I would recommend th..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[32]` **Sal Ignacius**: ""That's wonderful! It's hearteni..." |
| `[120]` | **""Absolutely. Without question. Overseeing a religious government without your kind..."** | `[3]` **Sal Ignacius**: ""Firstly, I believe it pertinent..."<br>`[8]` **Sal Ignacius**: ""Firstly, as I mentioned the nig..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[106]` **Sal Ignacius**: ""Splendid! There's so much you a..." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Sal Ignacius**
> ""Firstly, I believe it pertinent that if we're to cement Rizian Wruhecistic principles, the role of Grand Vizier should be given to a religious figurehead -- myself, specifically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Empty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Empty == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Empty == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Empty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Empty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""I know the position has opened up recently. But I have o..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Empty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Empty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""I said it before and I'll say it again... I'm not replac..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know the position has opened up recently. But I have other candidates in mind.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_GrandVizier_Empty"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Sal Ignacius: ""Very well. Moving on...""*)

### Węzeł `[8]`
Mówca: **Sal Ignacius**
> ""Firstly, as I mentioned the night of the Alignment of the Six Stars, I believe it pertinent that if we're to cement Rizian Wruhecistic principles, the role of Grand Vizier should be given to a religious figurehead -- myself, specifically.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Empty == true"*)
  - -> `[20]` (*Player_Romus: ""Yes, I remember. You'll be pleased to know I'm still ope..."*)
  - -> `[22]` (*Player_Romus: ""Oh, yes. Right. You as Grand Vizier. What were you sayin..."*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist == t..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Sal Ignacius: ""Firstly, as I mentioned the night of the Alignment of th..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_Briefing_Religion_LeaningWruhecist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Sal Ignacius: ""Firstly, I believe it pertinent that if we're to cement ..."*)

### Węzeł `[12]`
Mówca: **Sal Ignacius**
> ""This will not only strengthen the bond between the monarchy and the divine but also foster a sense of righteousness and unity among our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Sal Ignacius: ""Furthermore, as a religious leader, I offer a profound c..."*)

### Węzeł `[13]`
Mówca: **Sal Ignacius**
> ""Furthermore, as a religious leader, I offer a profound comprehension of spiritual affairs and can provide invaluable guidance on both state and soul, guaranteeing the prosperity of our realm not just in worldly affairs but also in matters of the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy == true"*)

### Węzeł `[14]`
Mówca: **Sal Ignacius**
> ""My second proposal, in addition to the newly assigned duties given to the Wruhec's Guardians, is that they should take over the responsibilities currently bestowed upon the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Sal Ignacius: ""The Guardians, much like myself, would uphold the kingdo..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy == true )"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Sal Ignacius: ""My second proposal, in addition to the newly assigned du..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Sal Ignacius: ""My second proposal would be to take the responsibilities..."*)

### Węzeł `[18]`
Mówca: **Sal Ignacius**
> ""The Guardians, much like myself, would uphold the kingdom's laws with unwavering devotion to the divine principles of Wruhecism. They'd ensure justice free from personal bias or political motivations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Sal Ignacius: ""Their extensive spiritual training and commitment to eth..."*)

### Węzeł `[19]`
Mówca: **Sal Ignacius**
> ""Their extensive spiritual training and commitment to ethical conduct make them ideal for handling sensitive matters that require both discretion and moral integrity. I'd argue they would be more effective than the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Sal Ignacius: ""That said, I would recommend that Captain Gordion contin..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I remember. You'll be pleased to know I'm still open to such a proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Sal Ignacius: ""I *am* pleased to hear it.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I said it before and I'll say it again... I'm not replacing Hugo. What's your other idea?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Council_GrandVizier_Empty"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[8]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Sal Ignacius: ""Very well. Moving on...""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, yes. Right. You as Grand Vizier. What were you saying about that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Sal Ignacius: ""That the advantages of appointing me to such a position ..."*)

### Węzeł `[23]`
Mówca: **Sal Ignacius**
> ""I *am* pleased to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Sal Ignacius: ""This will not only strengthen the bond between the monar..."*)

### Węzeł `[24]`
Mówca: **Sal Ignacius**
> ""I'm very pleased you think so. And speaking of shakeups, I believe the royal council could be in line for such a change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Sal Ignacius: ""To put it simply, they ought to be supplanted by a relig..."*)

### Węzeł `[25]`
Mówca: **Sal Ignacius**
> ""Such a replacement, comprised of priests and clerics, would ensure that decisions align closely with divine principles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Sal Ignacius: ""Such a council would guide the kingdom toward a more fai..."*)

### Węzeł `[26]`
Mówca: **Sal Ignacius**
> ""Such a council would guide the kingdom toward a more faith-based governance, where moral integrity and spiritual guidance shape every aspect of our rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Sal Ignacius: ""This change would move us towards establishing a governm..."*)

### Węzeł `[27]`
Mówca: **Sal Ignacius**
> ""This change would move us towards establishing a government guided by spiritual principles, where divine law reigns supreme.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Sal Ignacius: ""So what do you say, Your Majesty, will you take my hand ..."*)

### Węzeł `[28]`
Mówca: **Sal Ignacius**
> ""Which brings me to my final proposal, this time involving the royal council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards = false;"*)

### Węzeł `[29]`
Mówca: **Sal Ignacius**
> ""So what do you say, Your Majesty, will you take my hand and embark on this righteous journey to establish God's heavenly kingdom on earth?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier ==..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, if we're talking about the role of Grand Vizier, consider the job yours." [Appoint Grand Vizier]"
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = ..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no intention of supplanting Hugo for you.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier =..."*)

### Węzeł `[32]`
Mówca: **Sal Ignacius**
> ""That's wonderful! It's heartening to know that we share the same vision and goals for the kingdom's future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Sal Ignacius: ""And speaking of visions, that brings me to the last topi..."*)

### Węzeł `[33]`
Mówca: **Sal Ignacius**
> ""And speaking of visions, that brings me to the last topic I wanted to discuss... the royal council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Sal Ignacius: ""To put it simply, they ought to be supplanted by a relig..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm open to taking such a journey, however, when it comes to replacing Hugo, as I previously said, that's a no-go.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier =..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier ==..."*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier ..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: ""You already know my answer regarding the Grand Vizier po..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""Well, if we're talking about the role of Grand Vizier, c..."*)
  - -> `[31]` (*Player_Romus: ""I have no intention of supplanting Hugo for you.""*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Empty == true"*)
  - -> `[34]` (*Player_Romus: ""I'm open to taking such a journey, however, when it come..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You already know my answer regarding the Grand Vizier position. It's yours.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Sal Ignacius: ""Thanks again, Your Majesty. You have no idea how much th..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier = false; RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] = false;
Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Sal Ignacius: ""I'm sorry to hear that.""*)

### Węzeł `[40]`
Mówca: **Sal Ignacius**
> ""I'm sorry to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Sal Ignacius: ""What of the Golden Guard's and the Royal Council's repla..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Sal Ignacius: ""Excellent! You have no idea how much this means for me, ..."*)

### Węzeł `[42]`
Mówca: **Sal Ignacius**
> ""Excellent! You have no idea how much this means for me, and for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Sal Ignacius: ""What of the Golden Guard's and the Royal Council's repla..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Sal Ignacius: ""To put it simply, they ought to be supplanted by a relig..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you're really keen on the position of Grand Vizier, you can submit a petition for it during the upcoming council reshuffle. I assure you that your consideration will be given *utmost attention*, if you get my meaning." [Promise Grand Vizier]"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_GrandVizier_Empty"] == true` AND `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier =..."*)

### Węzeł `[45]`
Mówca: **Sal Ignacius**
> ""Without it, we risk straying further from the path of righteousness and forsaking the will of the Divine.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
Mówca: **Sal Ignacius**
> ""Implementing these changes in part will still mark progress towards establishing divine governance. It's a promising start on our journey towards fulfilling the will of the Divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier =..."*)

### Węzeł `[47]`
Mówca: **Sal Ignacius**
> ""I see nothing but a bright future ahead of us. Rizia is blessed to have you as our sovereign king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier =..."*)

### Węzeł `[48]`
Mówca: **Sal Ignacius**
> ""What of the Golden Guard's and the Royal Council's replacement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""I see no reason why either of those proposals couldn't c..."*)
  - -> `[51]` (*Player_Romus: ""Both are complex proposals, and if approved, would neces..."*)
  - -> `[49]` (*Player_Romus: ""I'm not fond of either. While I'm usually open to bold m..."*)
  - -> `[50]` (*Player_Romus: ""I commend you for your vision of the future. I shall giv..."*)
  - -> `[55]` (*Player_Romus: ""I applaud your vision for the future. I will carefully c..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not fond of either. While I'm usually open to bold moves, this feels like it's crossing a line, and is a step too far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Sal Ignacius: ""Yes, of course. Then I won't speak of it any longer. Ano..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I commend you for your vision of the future. I shall give your Royal Council replacement proposal serious consideration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Sal Ignacius: ""Please do. There's untold possibilities that we could ac..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both are complex proposals, and if approved, would necessitate a substantial amount of time an planning.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Sal Ignacius: ""Understandable, Your Majesty. Perhaps, when you've hard ..."*)

### Węzeł `[52]`
Mówca: **Sal Ignacius**
> ""Understandable, Your Majesty. Perhaps, when you've hard more time to think about it, we can return to these proposals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceAgnostic..."*)

### Węzeł `[53]`
Mówca: **Sal Ignacius**
> ""Yes, of course. Then I won't speak of it any longer. Another time perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCou..."*)

### Węzeł `[54]`
Mówca: **Sal Ignacius**
> ""Please do. There's untold possibilities that we could accomplish if you initiated that reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceCouncil ..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I applaud your vision for the future. I will carefully consider the Golden Guard replacement proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Sal Ignacius: ""Oh, please do. There's untold possibilities that we coul..."*)

### Węzeł `[56]`
Mówca: **Sal Ignacius**
> ""Oh, please do. There's untold possibilities that we could accomplish if you initiated that reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGG = true;"*)

### Węzeł `[57]`
Mówca: **Sal Ignacius**
> """That's excellent news! But yes, of course. I'll bring this up again when timing is more suitable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCou..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGGAndCouncil"] = false;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see no reason why either of those proposals couldn't come to fruition, but that isn't something I wish to decide just now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Sal Ignacius: """That's excellent news! But yes, of course. I'll bring t..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceAgnostic = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceAgnostic"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceCouncil = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceCouncil"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGG = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_InterestedReplaceGG"] = true;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
Mówca: **Sal Ignacius**
> ""Anyway, thanks for hearing me out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""Committing to all your reforms just isn't possible, espe..."*)
  - -> `[67]` (*Player_Romus: ""I can't commit to implementing all of your reforms, but ..."*)
  - -> `[65]` (*Player_Romus: ""Rest assured, I am committed to implementing the require..."*)
  - -> `[66]` (*Player_Romus: "Just so we're clear, I have no intention of turning this ..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rest assured, I am committed to implementing the required reforms to establish the kingdom of Rizia as God's kingdom on earth." [Full Theocracy]"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full = true;"*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Just so we're clear, I have no intention of turning this kingdom into a divine realm governed by religious principles -- at least how you envision it." [No Theocracy]"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_None = true;"*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't commit to implementing all of your reforms, but I'm open to some. We need to maintain a level of autonomy for the state, separate from the influence of the Sanctuary." [Partial Theocracy]"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Partial = true;"*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Committing to all your reforms just isn't possible, especially when it concerns issues such as economic stability and diplomatic relations. However, I am open to some collaboration." [Partial Theocracy]"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Partial = true;"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Theocracy_Full"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Sal Ignacius: ""Bless You, Your Majesty. This momentous decision heralds..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Partial = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Theocracy_Partial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Sal Ignacius: ""Overall, I'm heartened to hear your acceptance of at lea..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Partial = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Theocracy_Partial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Sal Ignacius: ""Overall, it heartens me to hear your acceptance of at le..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_None = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Theocracy_None"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Sal Ignacius: ""It pains me to hear you reject all of my proposals. Enfo..."*)

### Węzeł `[73]`
Mówca: **Sal Ignacius**
> ""Bless You, Your Majesty. This momentous decision heralds a new era for our kingdom, one where divine guidance shall illuminate our path forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Sal Ignacius: ""I see nothing but a bright future ahead of us. Rizia is ..."*)

### Węzeł `[74]`
Mówca: **Sal Ignacius**
> ""Overall, I'm heartened to hear your acceptance of at least some of my proposals. Though it falls short of the full theocratic reformation I envisioned, it signifies a step forward nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Sal Ignacius: ""Implementing these changes in part will still mark progr..."*)

### Węzeł `[75]`
Mówca: **Sal Ignacius**
> ""As Grand Vizier, I vow to exceed the expectations placed upon me by both God and the king, ensuring that every task is carried out with utmost diligence and dedication.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true || RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier =..."*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true || RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] == true  or  Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier =..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true || RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] == true  or  Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier =..."*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Sal Ignacius: ""As your future Grand Vizier, I vow to exceed the expecta..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Sal Ignacius: ""As Grand Vizier, I vow to exceed the expectations placed..."*)

### Węzeł `[82]`
Mówca: **Sal Ignacius**
> ""As your future Grand Vizier, I vow to exceed the expectations placed upon me by both God and the king, ensuring that every task is carried out with utmost diligence and dedication.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Empty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Empty == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Empty == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Empty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Empty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Romus: ""If you're really keen on the position of Grand Vizier, y..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Empty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Empty"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
Mówca: **Sal Ignacius**
> ""Overall, it heartens me to hear your acceptance of at least some of my proposals. Though it falls short of the full theocratic reformation I envisioned, it signifies a step forward nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Sal Ignacius: ""Implementing these changes in part will still mark progr..."*)

### Węzeł `[87]`
Mówca: **Sal Ignacius**
> ""It pains me to hear you reject all of my proposals. Enforcing such measures would have been a pivotal step towards establishing divine governance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Sal Ignacius: ""Without it, we risk straying further from the path of ri..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Sal Ignacius: ""That's encouraging to hear. I'll most certainly put in a..."*)

### Węzeł `[89]`
Mówca: **Sal Ignacius**
> ""That's encouraging to hear. I'll most certainly put in a petition when the time comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Sal Ignacius: ""What of the Golden Guard's and the Royal Council's repla..."*)

### Węzeł `[90]`
Mówca: **Sal Ignacius**
> ""Thanks again, Your Majesty. You have no idea how much this means for me, and for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Sal Ignacius: ""What of the Golden Guard's and the Royal Council's repla..."*)

### Węzeł `[91]`
Mówca: **Sal Ignacius**
> ""That the advantages of appointing me to such a position would be immense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Sal Ignacius: ""This will not only strengthen the bond between the monar..."*)

### Węzeł `[92]`
Mówca: **Sal Ignacius**
> ""Very well. Moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = ..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, it goes without saying that Titus wouldn't be happy about that. However, seeing as how he's my security counselor, I don't see him putting up much of a fuss.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Kontekst wejściowy (poprzednik):** `[122]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Sal Ignacius: ""I'm glad you brought that up, actually. My final proposa..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player_Romus: ""Well, it goes without saying that Titus wouldn't be happ..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player_Romus: ""Well, it goes without saying that Titus wouldn't be happ..."*)

### Węzeł `[97]`
Mówca: **Sal Ignacius**
> ""My second proposal would be to take the responsibilities currently bestowed upon the Golden Guard, and give them to the Wruhec's Guardians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Sal Ignacius: ""The Guardians, much like myself, would uphold the kingdo..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Makes sense. If this kingdom is to fully embrace the one true faith, then it needs to in all matters of governance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Sal Ignacius: ""I'm glad you see it that way, as it aligns perfectly wit..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Golden Guard's history of protecting the monarchy dates back centuries. I won't be the ruler to discard such a longstanding tradition.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_RebelKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[122]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Sal Ignacius: ""Of course. And I don't mean to diminish or disparage any..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Ah, throw tradition out the window. Sure! I'm open to the idea. The palace could certainly use a shakeup.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_RebelKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[122]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Sal Ignacius: ""I'm very pleased you think so. And speaking of shakeups,..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, it goes without saying that Titus wouldn't be happy about that.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[122]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Sal Ignacius: ""Captain Gordion is one of the most honorable men in this..."*)

### Węzeł `[102]`
Mówca: **Sal Ignacius**
> ""Which brings me to the last topic I wanted to discuss... the royal council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Sal Ignacius: ""To put it simply, they ought to be supplanted by a relig..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""Absolutely. Without question. Overseeing a religious gov..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
Mówca: **Sal Ignacius**
> ""Splendid! There's so much you and I can do together to see this through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = ..."*)

### Węzeł `[107]`
Mówca: **Sal Ignacius**
> ""I'm glad you brought that up, actually. My final proposal is in regard to the royal council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Sal Ignacius: ""To put it simply, they ought to be supplanted by a relig..."*)

### Węzeł `[108]`
Mówca: **Sal Ignacius**
> ""To put it simply, they ought to be supplanted by a religious council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Sal Ignacius: ""Such a replacement, comprised of priests and clerics, wo..."*)

### Węzeł `[109]`
Mówca: **Sal Ignacius**
> ""Captain Gordion is one of the most honorable men in this kingdom. I'm sure we could arrange for him to serve in a similar capacity under the Guardians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Sal Ignacius: ""Which brings me to the last topic I wanted to discuss......"*)

### Węzeł `[110]`
Mówca: **Sal Ignacius**
> ""I'm glad you see it that way, as it aligns perfectly with my ultimate proposal for the royal council.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Sal Ignacius: ""To put it simply, they ought to be supplanted by a relig..."*)

### Węzeł `[111]`
Mówca: **Sal Ignacius**
> ""Of course. And I don't mean to diminish or disparage any of their past accomplishments. I only seek to ensure this kingdom reaches its full potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Sal Ignacius: ""Which brings me to my final proposal, this time involvin..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_RebelKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_RebelKing == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_RebelKing == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_RebelKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_RebelKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player_Romus: "Ah, throw tradition out the window. Sure! I'm open to the..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_RebelKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_RebelKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: ""The Golden Guard's history of protecting the monarchy da..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player_Romus: ""Of course! I was considering such a change myself.""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course! I was considering such a change myself.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[122]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Sal Ignacius: ""That's wonderful! It's heartening to know that we share ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Sal Ignacius: ""This will not only strengthen the bond between the monar..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely. Without question. Overseeing a religious government without your kind of spiritual leadership would be a sin in and of itself." [Appoint Grand Vizier]"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[3]` (Sal Ignacius), `[8]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Sal Ignacius: ""Splendid! There's so much you and I can do together to s..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = false; RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] = false;
Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy == true"*)

### Węzeł `[122]`
Mówca: **Sal Ignacius**
> ""That said, I would recommend that Captain Gordion continue his current duties, but oversee the Guardians instead, considering his unwavering dedication to Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_RebelKing == true"*)
  - -> `[98]` (*Player_Romus: ""Makes sense. If this kingdom is to fully embrace the one..."*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
