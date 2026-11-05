# Sordland/Turn01/A_Media

- **ID konwersacji:** `3`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/003_A_Media.md`
- **Liczba węzłów dialogowych:** 166
- **Liczba wyborów gracza:** 38

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Turn01_Admin_Meeting`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Democratic`
- `BaseGame.Public_Opinion`
- `BaseGame.Situation_Diplomacy_Energy_PriceBalanced`
- `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation`
- `BaseGame.Situation_Diplomacy_Energy_PriceSurge`
- `BaseGame.Turn01_Admin_Meeting`
- `BaseGame.Turn01_Admin_TalkedToMarcel`
- `BaseGameSupport.Codex_Characters_Business_KonrathKoronti`
- `BaseGameSupport.Codex_Characters_Business_KonrathKoronti_Dead`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti`
- `BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno`
- `BaseGameSupport.Codex_Organisations_Corporations_HOS`
- `BaseGameSupport.Codex_Organisations_Corporations_HOS_KonrathDead`
- `BaseGameSupport.CountryReport_Turn01_Kyrute_PraisesDemocracy`
- `BaseGameSupport.Journal_Turn01_AcceptedMarcelOfferToMeet`
- `BaseGameSupport.Journal_Turn01_RejectedMarcelOfferToMeet`
- `BaseGameSupport.News_Turn01_G_Relations`
- `BaseGameSupport.News_Turn01_LT_GasomFreezesHiring`
- `BaseGameSupport.News_Turn01_R_GlamorousBall`
- `BaseGameSupport.News_Turn01_ST_HSURavaged`
- `BaseGameSupport.News_Turn01_ST_KonrathPassed`
- `BaseGameSupport.Report_Turn01_Holsord_AutocratCommittee`
- `BaseGameSupport.Report_Turn01_Holsord_DictatorCommittee`
- `BaseGameSupport.Report_Turn01_Holsord_ReformistCommittee`
- `BaseGameSupport.Report_Turn01_Holsord_SIDFireReport`
- `BaseGameSupport.Report_Turn01_Ribery_TourismIndicator`
- `BaseGameSupport.Report_Turn01_Valgen_DamOutputReduces`
- `GameCondition.Turn01_A_Media`
- `GameCondition.Turn02_A_MediaDeal`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **"“The media must be independent.”"** | `[25]` **Lucian Galade**: "“There are two ways we can appro..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Lucian Galade**: "“Ideally, yes. But an unpopular ..." |
| `[6]` | **"“The media is a tool to be used.”"** | `[25]` **Lucian Galade**: "“There are two ways we can appro..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Democratic"] = Variable["BaseGame.Demo...` | `[7]` **Lucian Galade**: "“I agree. Media plays a huge rol..." |
| `[14]` | **"“Two wrongs don't make a right.”"** | `[10]` **Lucian Galade**: "“I must stress one thing, Mr. Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Petr Vectern**: "“Says the man who used the media..."<br>`[18]` **Petr Vectern**: "“Maybe, maybe not. It's hard to ..." |
| `[15]` | **"“I see what you are getting at.”"** | `[8]` **Lucian Galade**: "“While I do acknowledge that thi..."<br>`[10]` **Lucian Galade**: "“I must stress one thing, Mr. Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Petr Vectern**: "“I agree with Lucian, but why th..." |
| `[16]` | **"“That does sound harsh.”"** | `[8]` **Lucian Galade**: "“While I do acknowledge that thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Petr Vectern**: "“Yes, we shouldn't resort to the..." |
| `[17]` | **"“I share your opinion.”"** | `[8]` **Lucian Galade**: "“While I do acknowledge that thi..."<br>`[10]` **Lucian Galade**: "“I must stress one thing, Mr. Pr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Petr Vectern**: "“I concur. Even if we don't use ..." |
| `[28]` | **"“Please, come in.”"** | `[27]` **Narrator**: "Two knocks were heard on the door." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSu...` | `[31]` **Narrator**: "Livia Suno, my new secretary, en..." |
| `[29]` | **"“Who is it?”"** | `[27]` **Narrator**: "Two knocks were heard on the door." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSu...` | `[88]` **Livia Suno**: "“It's Livia, Mr. President.”" |
| `[33]` | **"“What does this *productive collaboration* entail?”"** | `[87]` **Lucian Galade**: "“Which means it would be wise to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Lucian Galade**: "“He did not wish to explain the ..." |
| `[34]` | **"“Let's consider our options first. No need to be hasty.”"** | `[87]` **Lucian Galade**: "“Which means it would be wise to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Lucian Galade**: "“I agree. We need to be careful.”" |
| `[43]` | **"“Arrange the meeting with Mr. Koronti.”"** | `[54]` **Lucian Galade**: "“He is going to offer a real dea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Lucian Galade**: "“I'll set things up right away. ..." |
| `[44]` | **"“I do not want to associate with a media mogul. Reject the offer.”"** | `[54]` **Lucian Galade**: "“He is going to offer a real dea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Lucian Galade**: "“That is a clear no. Very well. ..." |
| `[45]` | **"“I would like to hear your opinion, Petr.”"** | `[54]` **Lucian Galade**: "“He is going to offer a real dea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Petr Vectern**: "“I have to say I'm torn. If he h..." |
| `[47]` | **"“You go ahead. Connect the line to my office.”"** | `[90]` **Lucian Galade**: "“Would you like to talk to him, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Livia Suno**: "“Right away, sir. Connecting the..." |
| `[48]` | **"“I'll talk to him. Connect the line to my office.”"** | `[90]` **Lucian Galade**: "“Would you like to talk to him, ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn01_Admin_TalkedToMarcel"] = true;` | `[37]` **Livia Suno**: "“Right away, sir. Connecting the..." |
| `[51]` | **"“The President speaking.”"** | `[38]` **Narrator**: "Livia left the room and the phon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Marcel Koronti**: "“It's an honor, Mr. President.”" |
| `[52]` | **"“It's a pleasure, Mr. Koronti.”"** | `[38]` **Narrator**: "Livia left the room and the phon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Marcel Koronti**: "“The pleasure is all mine.”" |
| `[53]` | **"“Hello, Marcel.”"** | `[38]` **Narrator**: "Livia left the room and the phon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Marcel Koronti**: "“Greetings, Mr. Rayne.”" |
| `[59]` | **"“Thank you for the offer. I would be interested in a meeting.”"** | `[80]` **Marcel Koronti**: "“This is why I am offering a par..."<br>`[97]` **Marcel Koronti**: "“I will send you the details thr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Marcel Koronti**: "“You will not be disappointed, I..." |
| `[60]` | **"“Thank you for your offer, Mr. Koronti, but I have to refuse.”"** | `[80]` **Marcel Koronti**: "“This is why I am offering a par..."<br>`[97]` **Marcel Koronti**: "“I will send you the details thr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Marcel Koronti**: "“That is a shame. Thank you for ..." |
| `[67]` | **"“Arrange the meeting with Mr. Koronti.”"** | `[66]` **Lucian Galade**: "“The meeting would help us figur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Lucian Galade**: "“I'll set things up right away. ..." |
| `[68]` | **"“I do not want to associate with a media mogul. Reject the offer.”"** | `[66]` **Lucian Galade**: "“The meeting would help us figur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Lucian Galade**: "“That is a clear no. Very well. ..." |
| `[72]` | **"“Good work with Marcel. Keep it up.”"** | `[71]` **Lucian Galade**: "“It appears we're done for today..." | `Variable["BaseGame.Turn01_Admin_Meeting"] == true` | *Brak zmian stanu* | `[113]` **Narrator**: "Lucian and Petr nodded before ga..." |
| `[73]` | **"“See you soon, gentlemen.”"** | `[71]` **Lucian Galade**: "“It appears we're done for today..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "Lucian and Petr gathered their d..." |
| `[82]` | **"“What does he want?”"** | `[3]` **Lucian Galade**: "“He has offered to meet with you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Lucian Galade**: "“After the passing of his father..." |
| `[83]` | **"“Why is Konrath sending his son?”"** | `[3]` **Lucian Galade**: "“He has offered to meet with you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Petr Vectern**: "“He, uh, unfortunately passed aw..." |
| `[84]` | **"“Why should I meet with him?”"** | `[3]` **Lucian Galade**: "“He has offered to meet with you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Lucian Galade**: "“After the passing of his father..." |
| `[95]` | **"“What does that entail?”"** | `[80]` **Marcel Koronti**: "“This is why I am offering a par..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Marcel Koronti**: "“Our future as partners, Mr. Pre..." |
| `[98]` | **"“See you later, Mr. Koronti.”"** | `[64]` **Marcel Koronti**: "“Well then, I will let you retur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Narrator**: "I hung up the phone." |
| `[100]` | **"“Goodbye.”"** | `[64]` **Marcel Koronti**: "“Well then, I will let you retur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Narrator**: "I hung up the phone." |
| `[108]` | **"“Sounds like there is potential there.”"** | `[87]` **Lucian Galade**: "“Which means it would be wise to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Lucian Galade**: "“There is definitely potential. ..." |
| `[117]` | **"“I expect you to bring better allies to the table.”"** | `[71]` **Lucian Galade**: "“It appears we're done for today..." | `(Variable["BaseGame.Turn01_Admin_Meeting"] == true) == false` | *Brak zmian stanu* | `[113]` **Narrator**: "Lucian and Petr nodded before ga..." |
| `[141]` | **"“Was it put out quickly?”"** | `[139]` **Lucian Galade**: "“I have just received further in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Lucian Galade**: "“Our firefighters put out the fi..." |
| `[142]` | **"“Tell me more.”"** | `[139]` **Lucian Galade**: "“I have just received further in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Lucian Galade**: "“The initial reports from the Ho..." |
| `[145]` | **"“I'm not interested in the subject.”"** | `[139]` **Lucian Galade**: "“I have just received further in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Lucian Galade**: "“Excuse me. Let's just move on.”" |
| `[150]` | **"“It's a shame so much knowledge was lost.”"** | `[149]` **Lucian Galade**: "“It seems like the chief suspect..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Lucian Galade**: "“Luckily most originals have cop..." |
| `[151]` | **"“Back to Petr's point. If this was arson, what could the motive have been?""** | `[149]` **Lucian Galade**: "“It seems like the chief suspect..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Lucian Galade**: "“The fact that the employee reco..." |
| `[152]` | **"“We need to support our education system to make new discoveries for the future.”"** | `[149]` **Lucian Galade**: "“It seems like the chief suspect..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Lucian Galade**: "“Preserving our knowledge is as ..." |

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
  - -> `[79]` (*Narrator: "Lucian and Petr arrived at my office to talk about recent..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucian Galade**
> "“He has offered to meet with you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: "“What does he want?”"*)
  - -> `[83]` (*Player: "“Why is Konrath sending his son?”"*)
  - -> `[84]` (*Player: "“Why should I meet with him?”"*)

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“But let's not get ahead of ourselves. First, we need to determine our general approach to media.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Petr Vectern: "“I'm no media expert, but Lucian made some very interesti..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "“The media must be independent.”"]** — Mówca: **Player**
> "“The media must be independent.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: "“Ideally, yes. But an unpopular leader will not be able t..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“The media is a tool to be used.”"]** — Mówca: **Player**
> "“The media is a tool to be used.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic -= 1"*)

### Węzeł `[7]`
Mówca: **Lucian Galade**
> "“I agree. Media plays a huge role in adapting public opinion towards our views and policies, while helping us avoid damage from scandals or mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lucian Galade: "“While I do acknowledge that this will sound a bit harsh,..."*)

### Węzeł `[8]`
Mówca: **Lucian Galade**
> "“While I do acknowledge that this will sound a bit harsh, I certainly believe that our perspective, knowledge and experience allows us to have superior judgement compared to the average Sordish citizen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "“I see what you are getting at.”"*)
  - -> `[16]` (*Player: "“That does sound harsh.”"*)
  - -> `[17]` (*Player: "“I share your opinion.”"*)

### Węzeł `[9]`
Mówca: **Lucian Galade**
> "“Ideally, yes. But an unpopular leader will not be able to pass even the easiest reforms. It is of utmost importance to maintain public popularity and avoid any damaging scandals or mistakes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: "“I must stress one thing, Mr. President. The more people ..."*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> "“I must stress one thing, Mr. President. The more people we have supporting our agenda, the more we can accomplish. With someone on our side in an influential media organisation, we can do this very easily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "“I see what you are getting at.”"*)
  - -> `[14]` (*Player: "“Two wrongs don't make a right.”"*)
  - -> `[17]` (*Player: "“I share your opinion.”"*)

### Węzeł `[11]`
Mówca: **Petr Vectern**
> "“I agree with Lucian, but why the assumption there'll be scandals and mistakes?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucian Galade: "“We can always hope for the best. But do we really think ..."*)

### Węzeł `[12]`
Mówca: **Petr Vectern**
> "“They are a powerful and influential media conglomerate. To start with, they own the Sordland Today newspaper, the Sordish Broadcasting Corporation, the S-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: "“Which means it would be wise to have them by our side. S..."*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“After the passing of his father -- may he rest in peace -- Marcel aims to become the next CEO of the HOS Conglomerate. He mentioned a productive collaboration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Petr Vectern: "“They are a powerful and influential media conglomerate. ..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“Two wrongs don't make a right.”"]** — Mówca: **Player**
> "“Two wrongs don't make a right.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“I see what you are getting at.”"]** — Mówca: **Player**
> "“I see what you are getting at.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade), `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Petr Vectern: "“I agree with Lucian, but why the assumption there'll be ..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“That does sound harsh.”"]** — Mówca: **Player**
> "“That does sound harsh.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Petr Vectern: "“Yes, we shouldn't resort to these measures to solve our ..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“I share your opinion.”"]** — Mówca: **Player**
> "“I share your opinion.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lucian Galade), `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Petr Vectern: "“I concur. Even if we don't use it, we should be able to ..."*)

### Węzeł `[18]`
Mówca: **Petr Vectern**
> "“Maybe, maybe not. It's hard to forget what happened to President Alphonso last year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: "“Things got even worse after his cabinet resigned and the..."*)

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“Things got even worse after his cabinet resigned and the media started to slander him, but that was also a result of his own incompetence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Two knocks were heard on the door."*)

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“We can always hope for the best. But do we really think that nothing can go wrong? Especially considering the very recent history of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Two knocks were heard on the door."*)

### Węzeł `[21]`
Mówca: **Petr Vectern**
> "“Yes, we shouldn't resort to these measures to solve our potential political mistakes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: "“It isn't about that alone, Petr. There could be groups o..."*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> "“It isn't about that alone, Petr. There could be groups or people who would want to damage us even if we are in the right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Two knocks were heard on the door."*)

### Węzeł `[23]`
Mówca: **Petr Vectern**
> "“I concur. Even if we don't use it, we should be able to have control over it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: "“You both are aware of my certain expertise with public o..."*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“You both are aware of my certain expertise with public opinion swaying. I will make sure the media is on our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Two knocks were heard on the door."*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> "“There are two ways we can approach the media. One of them is by influencing it, which has clear advantages. The other one is keeping it independent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: "“The media must be independent.”"*)
  - -> `[6]` (*Player: "“The media is a tool to be used.”"*)

### Węzeł `[26]`
Mówca: **Petr Vectern**
> "“I'm no media expert, but Lucian made some very interesting arguments at the preparation meeting yesterday.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: "“There are two ways we can approach the media. One of the..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Two knocks were heard on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: "“Please, come in.”"*)
  - -> `[29]` (*Player: "“Who is it?”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Please, come in.”"]** — Mówca: **Player**
> "“Please, come in.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_LiviaSuno = true"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Who is it?”"]** — Mówca: **Player**
> "“Who is it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_LiviaSuno = true"*)

### Węzeł `[30]`
Mówca: **Livia Suno**
> "“Excuse me, Mr. President. Mr. Galade's secretary has been calling me and wanted me to relay a message.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Livia Suno: "“Marcel Koronti, the new CEO for HOS Conglomerate, is on ..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Livia Suno, my new secretary, entered the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Her dark curls bounced as she crossed the room to my desk..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "The Korontis had always been known as one of the richest and most influential families in Sordland. Marcel Koronti was no exception."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "He was the oldest son of Konrath Koronti, the industriali..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“What does this *productive collaboration* entail?”"]** — Mówca: **Player**
> "“What does this *productive collaboration* entail?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lucian Galade: "“He did not wish to explain the details over the phone bu..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Let's consider our options first. No need to be hasty.”"]** — Mówca: **Player**
> "“Let's consider our options first. No need to be hasty.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lucian Galade: "“I agree. We need to be careful.”"*)

### Węzeł `[35]`
Mówca: **Livia Suno**
> "“Marcel Koronti, the new CEO for HOS Conglomerate, is on the line for Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Petr Vectern: "“Well. The ball is in our court now.”"*)

### Węzeł `[36]`
Mówca: **Petr Vectern**
> "“Well. The ball is in our court now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: "“Would you like to talk to him, sir, or would you like me..."*)

### Węzeł `[37]`
Mówca: **Livia Suno**
> "“Right away, sir. Connecting the call to line one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PhoneRingPickUp");"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "Livia left the room and the phone started ringing. I picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“The President speaking.”"*)
  - -> `[52]` (*Player: "“It's a pleasure, Mr. Koronti.”"*)
  - -> `[53]` (*Player: "“Hello, Marcel.”"*)

### Węzeł `[39]`
Mówca: **Lucian Galade**
> "“Good news indeed. Congratulations, Mr. Koronti. Thank you for contacting me about this. We will talk later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Lucian put the phone down."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Lucian put the phone down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Petr Vectern: "“What was so important that it couldn't wait?”"*)

### Węzeł `[41]`
Mówca: **Petr Vectern**
> "“What was so important that it couldn't wait?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucian Galade: "“He was just elected CEO by the board of directors. He of..."*)

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“He was just elected CEO by the board of directors. He offered a partnership deal regarding his media branch. He is inviting us to his resort near Conriat for a meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Corporations_HOS = fa..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Arrange the meeting with Mr. Koronti.”"]** — Mówca: **Player**
> "“Arrange the meeting with Mr. Koronti.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: "“I'll set things up right away. Expect a worthwhile meeti..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“I do not want to associate with a media mogul. Reject the offer.”"]** — Mówca: **Player**
> "“I do not want to associate with a media mogul. Reject the offer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: "“That is a clear no. Very well. I hope we have made the r..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“I would like to hear your opinion, Petr.”"]** — Mówca: **Player**
> "“I would like to hear your opinion, Petr.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Petr Vectern: "“I have to say I'm torn. If he has become the CEO, then h..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_Admin_Meeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn01_Admin_Meeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_AcceptedMarcelOfferToMeet ..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“You go ahead. Connect the line to my office.”"]** — Mówca: **Player**
> "“You go ahead. Connect the line to my office.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Livia Suno: "“Right away, sir. Connecting the call to line one.”"*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "“I'll talk to him. Connect the line to my office.”"]** — Mówca: **Player**
> "“I'll talk to him. Connect the line to my office.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_Admin_TalkedToMarcel = true"*)

### Węzeł `[49]`
Mówca: **Narrator**
> "A few minutes passed as the two talked over the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lucian Galade: "“Good news indeed. Congratulations, Mr. Koronti. Thank yo..."*)

### Węzeł `[50]`
Mówca: **Marcel Koronti**
> "“The pleasure is all mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Marcel Koronti: "“I know your time is valuable, so I will not waste any of..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“The President speaking.”"]** — Mówca: **Player**
> "“The President speaking.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Marcel Koronti: "“It's an honor, Mr. President.”"*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“It's a pleasure, Mr. Koronti.”"]** — Mówca: **Player**
> "“It's a pleasure, Mr. Koronti.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Marcel Koronti: "“The pleasure is all mine.”"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Hello, Marcel.”"]** — Mówca: **Player**
> "“Hello, Marcel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Marcel Koronti: "“Greetings, Mr. Rayne.”"*)

### Węzeł `[54]`
Mówca: **Lucian Galade**
> "“He is going to offer a real deal and now has the power of the conglomerate too. The choice is up to you, Mr. President. I can set up the meeting soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: "“I would like to hear your opinion, Petr.”"*)
  - -> `[43]` (*Player: "“Arrange the meeting with Mr. Koronti.”"*)
  - -> `[44]` (*Player: "“I do not want to associate with a media mogul. Reject th..."*)

### Węzeł `[55]`
Mówca: **Marcel Koronti**
> "“Greetings, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Marcel Koronti: "“I know your time is valuable, so I will not waste any of..."*)

### Węzeł `[56]`
Mówca: **Marcel Koronti**
> "“It's an honor, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Marcel Koronti: "“I know your time is valuable, so I will not waste any of..."*)

### Węzeł `[57]`
Mówca: **Petr Vectern**
> "“The board has decided rather quickly. It seems that gave him the confidence to approach us again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lucian Galade: "“He is going to offer a real deal and now has the power o..."*)

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“I know your time is valuable, so I will not waste any of it. I was just elected CEO of HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Corporations_HOS = fa..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Thank you for the offer. I would be interested in a meeting.”"]** — Mówca: **Player**
> "“Thank you for the offer. I would be interested in a meeting.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Marcel Koronti), `[97]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Marcel Koronti: "“You will not be disappointed, I promise.”"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Thank you for your offer, Mr. Koronti, but I have to refuse.”"]** — Mówca: **Player**
> "“Thank you for your offer, Mr. Koronti, but I have to refuse.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Marcel Koronti), `[97]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Marcel Koronti: "“That is a shame. Thank you for your time nonetheless.”"*)

### Węzeł `[61]`
Mówca: **Marcel Koronti**
> "“You will not be disappointed, I promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Marcel Koronti: "“Well then, I will let you return to your packed schedule..."*)

### Węzeł `[62]`
Mówca: **Marcel Koronti**
> "“That is a shame. Thank you for your time nonetheless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Marcel Koronti: "“Good luck in the future.”"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Mr. Koronti hung up the phone without waiting for my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: "“That is a clear no. Very well. I hope we have made the r..."*)

### Węzeł `[64]`
Mówca: **Marcel Koronti**
> "“Well then, I will let you return to your packed schedule. See you later, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: "“Goodbye.”"*)
  - -> `[98]` (*Player: "“See you later, Mr. Koronti.”"*)

### Węzeł `[65]`
Mówca: **Petr Vectern**
> "“I have to say I'm torn. If he has become the CEO, then he has enormous influence now. On the other hand, do we want to privately meet with someone we don't fully know?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: "“The meeting would help us figure him out. We could still..."*)

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“The meeting would help us figure him out. We could still say no to whatever he offers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: "“Arrange the meeting with Mr. Koronti.”"*)
  - -> `[68]` (*Player: "“I do not want to associate with a media mogul. Reject th..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Arrange the meeting with Mr. Koronti.”"]** — Mówca: **Player**
> "“Arrange the meeting with Mr. Koronti.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: "“I'll set things up right away. Expect a worthwhile meeti..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I do not want to associate with a media mogul. Reject the offer.”"]** — Mówca: **Player**
> "“I do not want to associate with a media mogul. Reject the offer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: "“That is a clear no. Very well. I hope we have made the r..."*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> "“I'll set things up right away. Expect a worthwhile meeting next month.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_Admin_Meeting = true"*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“That is a clear no. Very well. I hope we have made the right call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_A_MediaDeal = true"*)

### Węzeł `[71]`
Mówca: **Lucian Galade**
> "“It appears we're done for today. We will continue where we left off later. Thank you for your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_Admin_Meeting == true"*)
  - -> `[73]` (*Player: "“See you soon, gentlemen.”"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“Good work with Marcel. Keep it up.”"]** — Mówca: **Player**
> "“Good work with Marcel. Keep it up.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_Admin_Meeting"] == true`
- **Kontekst wejściowy (poprzednik):** `[71]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Lucian and Petr nodded before gathering their documents a..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“See you soon, gentlemen.”"]** — Mówca: **Player**
> "“See you soon, gentlemen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Lucian and Petr gathered their documents and promptly lef..."*)

### Węzeł `[74]`
Mówca: **Petr Vectern**
> "“It's settled then. Looking forward to next month. I wonder if he has a pool?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Lucian looked at his watch."*)

### Węzeł `[75]`
Mówca: **Petr Vectern**
> "“Well, that makes things clear. We should focus on other things anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Lucian looked at his watch."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn01_A_Media = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn01_A_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[77]`
Mówca: **Marcel Koronti**
> "“Good luck in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Mr. Koronti hung up the phone without waiting for my resp..."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "We were already getting the attention of key figures -- and potentially dangerous ones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)

### Węzeł `[79]`
Mówca: **Narrator**
> "Lucian and Petr arrived at my office to talk about recent developments and the media strategy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_G_Relations = true"*)

### Węzeł `[80]`
Mówca: **Marcel Koronti**
> "“This is why I am offering a partnership deal regarding our media branch. I would like to formally invite you to my resort near Conriat for a meeting to discuss the details.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "“What does that entail?”"*)
  - -> `[59]` (*Player: "“Thank you for the offer. I would be interested in a meet..."*)
  - -> `[60]` (*Player: "“Thank you for your offer, Mr. Koronti, but I have to ref..."*)

### Węzeł `[81]`
Mówca: **Marcel Koronti**
> "“My strategy in the running of this conglomerate will be different than my father's approach.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Marcel Koronti: "“This is why I am offering a partnership deal regarding o..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“What does he want?”"]** — Mówca: **Player**
> "“What does he want?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: "“After the passing of his father -- may he rest in peace ..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Why is Konrath sending his son?”"]** — Mówca: **Player**
> "“Why is Konrath sending his son?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Petr Vectern: "“He, uh, unfortunately passed away today.”"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Why should I meet with him?”"]** — Mówca: **Player**
> "“Why should I meet with him?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: "“After the passing of his father -- may he rest in peace ..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "Lucian turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucian Galade: "“He has offered to meet with you, Mr. President.”"*)

### Węzeł `[86]`
Mówca: **Petr Vectern**
> "“He, uh, unfortunately passed away today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: "“After the passing of his father -- may he rest in peace ..."*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“Which means it would be wise to have them by our side. Sorry for interrupting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“What does this *productive collaboration* entail?”"*)
  - -> `[34]` (*Player: "“Let's consider our options first. No need to be hasty.”"*)
  - -> `[108]` (*Player: "“Sounds like there is potential there.”"*)

### Węzeł `[88]`
Mówca: **Livia Suno**
> "“It's Livia, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Livia Suno, my new secretary, entered the office."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Livia Suno, my new secretary, entered the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Her dark curls bounced as she crossed the room to my desk..."*)

### Węzeł `[90]`
Mówca: **Lucian Galade**
> "“Would you like to talk to him, sir, or would you like me to?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: "“I'll talk to him. Connect the line to my office.”"*)
  - -> `[47]` (*Player: "“You go ahead. Connect the line to my office.”"*)

### Węzeł `[91]`
Mówca: **Livia Suno**
> "“Right away, sir. Connecting the call to line one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PhoneRingPickUp");"*)

### Węzeł `[92]`
Mówca: **Narrator**
> "Livia left the room and the phone started ringing. Lucian picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "A few minutes passed as the two talked over the phone."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Lucian looked at his watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucian Galade: "“It appears we're done for today. We will continue where ..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Lucian and Petr gathered their documents and promptly left my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "We were already getting the attention of key figures -- a..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“What does that entail?”"]** — Mówca: **Player**
> "“What does that entail?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Marcel Koronti: "“Our future as partners, Mr. President. Surely, we can't ..."*)

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“Our future as partners, Mr. President. Surely, we can't talk about the details on the phone. I just wish to have a face to face conversation with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Marcel Koronti: "“I will send you the details through my secretary if you ..."*)

### Węzeł `[97]`
Mówca: **Marcel Koronti**
> "“I will send you the details through my secretary if you are interested.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“Thank you for the offer. I would be interested in a meet..."*)
  - -> `[60]` (*Player: "“Thank you for your offer, Mr. Koronti, but I have to ref..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "“See you later, Mr. Koronti.”"]** — Mówca: **Player**
> "“See you later, Mr. Koronti.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "I hung up the phone."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "I hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: "“I'll set things up right away. Expect a worthwhile meeti..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Goodbye.”"]** — Mówca: **Player**
> "“Goodbye.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "I hung up the phone."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Petr Vectern: "“Says the man who used the media to backstab President Al..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Petr Vectern: "“Maybe, maybe not. It's hard to forget what happened to P..."*)

### Węzeł `[104]`
Mówca: **Petr Vectern**
> "“Says the man who used the media to backstab President Alphonso last year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: "“Things got even worse after his cabinet resigned and the..."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "They both took their seats across from me. Lucian put on his reading glasses and quickly went over some documents. Petr turned to Lucian and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucian Galade: "“Greetings, gentlemen.”"*)

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“Greetings, gentlemen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucian Galade: "“I have just received further information from the Interi..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "He was the oldest son of Konrath Koronti, the industrialist and media mogul who founded HOS. The richest man in the entirety of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "Lucian turned to me."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Sounds like there is potential there.”"]** — Mówca: **Player**
> "“Sounds like there is potential there.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucian Galade: "“There is definitely potential. A potential that could go..."*)

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“However, as Petr said, they have substantial power over the content of media outlets. Headlines, radio shows. That is what he would be offering. What he wants in return is what we need to understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: "“But let's not get ahead of ourselves. First, we need to ..."*)

### Węzeł `[110]`
Mówca: **Lucian Galade**
> "“I agree. We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: "“But let's not get ahead of ourselves. First, we need to ..."*)

### Węzeł `[111]`
Mówca: **Lucian Galade**
> "“There is definitely potential. A potential that could go both ways.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: "“But let's not get ahead of ourselves. First, we need to ..."*)

### Węzeł `[112]`
Mówca: **Lucian Galade**
> "“He did not wish to explain the details over the phone but rather in person. I believe I will be receiving a call from him sometime soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucian Galade: "“However, as Petr said, they have substantial power over ..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Lucian and Petr nodded before gathering their documents and leaving my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "We were already getting the attention of key figures -- a..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_Admin_Meeting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_Admin_Meeting == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_Admin_Meeting == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_Admin_Meeting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_Admin_Meeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: "“Good work with Marcel. Keep it up.”"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_Admin_Meeting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_Admin_Meeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "“I expect you to bring better allies to the table.”"*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“I expect you to bring better allies to the table.”"]** — Mówca: **Player**
> "“I expect you to bring better allies to the table.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn01_Admin_Meeting"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[71]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Lucian and Petr nodded before gathering their documents a..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_R_GlamorousBall = true;
BaseGameSupport.News_Turn01_ST_KonrathPassed = true;
BaseGameSupport.News_Turn01_ST_HSURavaged = true;
BaseGameSupport.Report_Turn01_Holsord_SIDFireReport = true;
BaseGameSupport.CountryReport_Turn01_Kyrute_PraisesDemocracy = true;
BaseGameSupport.News_Turn01_LT_GasomFreezesHiring = true;
BaseGameSupport.Report_Turn01_Ribery_TourismIndicator = true;
BaseGameSupport.Report_Turn01_Valgen_DamOutputReduces = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_R_GlamorousBall"] = true;
Variable["BaseGameSupport.News_Turn01_ST_KonrathPassed"] = true;
Variable["BaseGameSupport.News_Turn01_ST_HSURavaged"] = true;
Variable["BaseGameSupport.Report_Turn01_Holsord_SIDFireReport"] = true;
Variable["BaseGameSupport.CountryReport_Turn01_Kyrute_PraisesDemocracy"] = true;
Variable["BaseGameSupport.News_Turn01_LT_GasomFreezesHiring"] = true;
Variable["BaseGameSupport.Report_Turn01_Ribery_TourismIndicator"] = true;
Variable["BaseGameSupport.Report_Turn01_Valgen_DamOutputReduces"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_GalmlandTension");"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn01_G_Relations = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn01_G_Relations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "They both took their seats across from me. Lucian put on ..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Holsord_AutocratCommittee = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_AutocratCommittee"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_R_GlamorousBall = true; BaseG..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Holsord_AutocratCommittee =..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Intention == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Holsord_DictatorCommittee =..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn01_Holsord_ReformistCommittee ..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Holsord_DictatorCommittee = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_DictatorCommittee"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_R_GlamorousBall = true; BaseG..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn01_Holsord_ReformistCommittee = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_ReformistCommittee"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn01_R_GlamorousBall = true; BaseG..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_LiviaSuno = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Livia Suno, my new secretary, entered the office."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_LiviaSuno = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Livia Suno: "“It's Livia, Mr. President.”"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Corporations_HOS = false; BaseGameSupport.Codex_Organisations_Corporations_HOS_KonrathDead = true;
BaseGameSupport.Codex_Characters_Business_MarcelKoronti = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead = true; BaseGameSupport.Codex_Characters_Business_KonrathKoronti = false; BaseGameSupport.Codex_Characters_Business_KonrathKoronti_Dead = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Corporations_HOS"] = false;
Variable["BaseGameSupport.Codex_Organisations_Corporations_HOS_KonrathDead"] = true;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead"] = true;
Variable["BaseGameSupport.Codex_Characters_Business_KonrathKoronti"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_KonrathKoronti_Dead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Marcel Koronti: "“My strategy in the running of this conglomerate will be ..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Corporations_HOS = false; BaseGameSupport.Codex_Organisations_Corporations_HOS_KonrathDead = true;
BaseGameSupport.Codex_Characters_Business_MarcelKoronti = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead = true; BaseGameSupport.Codex_Characters_Business_KonrathKoronti = false; BaseGameSupport.Codex_Characters_Business_KonrathKoronti_Dead = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Corporations_HOS"] = false;
Variable["BaseGameSupport.Codex_Organisations_Corporations_HOS_KonrathDead"] = true;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead"] = true;
Variable["BaseGameSupport.Codex_Characters_Business_KonrathKoronti"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_KonrathKoronti_Dead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Petr Vectern: "“The board has decided rather quickly. It seems that gave..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_AcceptedMarcelOfferToMeet = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_AcceptedMarcelOfferToMeet"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Petr Vectern: "“It's settled then. Looking forward to next month. I wond..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn01_RejectedMarcelOfferToMeet = true;
BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_RejectedMarcelOfferToMeet"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Petr Vectern: "“Well, that makes things clear. We should focus on other ..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn02_A_MediaDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn02_A_MediaDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn01_RejectedMarcelOfferToMeet ..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucian Galade: "“I agree. Media plays a huge role in adapting public opin..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_Admin_TalkedToMarcel = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn01_Admin_TalkedToMarcel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Livia Suno: "“Right away, sir. Connecting the call to line one.”"*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Her dark curls bounced as she crossed the room to my desk. She spoke with a slight lilt in her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Livia Suno: "“Excuse me, Mr. President. Mr. Galade's secretary has bee..."*)

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“I have just received further information from the Interior about the sudden fire that broke out at the Holsord State University archives nearby.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: "“Tell me more.”"*)
  - -> `[141]` (*Player: "“Was it put out quickly?”"*)
  - -> `[145]` (*Player: "“I'm not interested in the subject.”"*)

### Węzeł `[140]`
Mówca: **Petr Vectern**
> "“Is the SID really necessary for this? Why would anyone hit the archives of a university in the first place? I see no logical motive there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucian Galade: "“It seems like the chief suspects foreign sabotage. They ..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“Was it put out quickly?”"]** — Mówca: **Player**
> "“Was it put out quickly?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lucian Galade: "“Our firefighters put out the fire as soon as they could...."*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "“Tell me more.”"]** — Mówca: **Player**
> "“Tell me more.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucian Galade: "“The initial reports from the Holsord police chief indica..."*)

### Węzeł `[143]`
Mówca: **Lucian Galade**
> "“Our firefighters put out the fire as soon as they could. Yet it had been burning for six hours, so extensive damage was done to the archives and the building.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Petr Vectern: "“I will arrange medals to recognize their bravery for doi..."*)

### Węzeł `[144]`
Mówca: **Lucian Galade**
> "“The initial reports from the Holsord police chief indicate a potential arson case. In accordance with protocol, the Sordish Intelligence Directorate has been called.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Petr Vectern: "“Is the SID really necessary for this? Why would anyone h..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA: "“I'm not interested in the subject.”"]** — Mówca: **Player**
> "“I'm not interested in the subject.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lucian Galade: "“Excuse me. Let's just move on.”"*)

### Węzeł `[146]`
Mówca: **Lucian Galade**
> "“Excuse me. Let's just move on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Petr Vectern: "“More importantly, Lucian mentioned that Marcel Koronti c..."*)

### Węzeł `[147]`
Mówca: **Petr Vectern**
> "“More importantly, Lucian mentioned that Marcel Koronti contacted him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "The Korontis had always been known as one of the richest ..."*)

### Węzeł `[148]`
Mówca: **Petr Vectern**
> "“I will arrange medals to recognize their bravery for doing their best. The Holsord Fire Department is full of tough champs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Lucian Galade: "“The information we received raises some eyebrows.”"*)

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“It seems like the chief suspects foreign sabotage. They informed us that a large section of the archive has been destroyed. It included tens of thousands of globally recognized research documents in original by the great thinkers of our people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“It's a shame so much knowledge was lost.”"*)
  - -> `[151]` (*Player: "“Back to Petr's point. If this was arson, what could the ..."*)
  - -> `[152]` (*Player: "“We need to support our education system to make new disc..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“It's a shame so much knowledge was lost.”"]** — Mówca: **Player**
> "“It's a shame so much knowledge was lost.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lucian Galade: "“Luckily most originals have copies in the other universi..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Back to Petr's point. If this was arson, what could the motive have been?""]** — Mówca: **Player**
> "“Back to Petr's point. If this was arson, what could the motive have been?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: "“The fact that the employee records have been destroyed a..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“We need to support our education system to make new discoveries for the future.”"]** — Mówca: **Player**
> "“We need to support our education system to make new discoveries for the future.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Lucian Galade: "“Preserving our knowledge is as important as expanding on..."*)

### Węzeł `[153]`
Mówca: **Lucian Galade**
> "“Luckily most originals have copies in the other universities and some international libraries. The first edition of my favorite book, "The Geopolitics of Sordland" by Herman Equa, was destroyed too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Petr Vectern: "“Maybe it was just a freak accident. We do have the copie..."*)

### Węzeł `[154]`
Mówca: **Lucian Galade**
> "“The fact that the employee records have been destroyed along with the research documents raises further questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lucian Galade: "“Luckily most originals have copies in the other universi..."*)

### Węzeł `[155]`
Mówca: **Lucian Galade**
> "“Preserving our knowledge is as important as expanding on it. It's interesting that the employee records have been destroyed as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lucian Galade: "“Luckily most originals have copies in the other universi..."*)

### Węzeł `[156]`
Mówca: **Petr Vectern**
> "“Maybe it was just a freak accident. We do have the copies of most important works, so no single fire can eradicate our knowledge. I see no point in destroying employee records, either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Petr Vectern: "“More importantly, Lucian mentioned that Marcel Koronti c..."*)

### Węzeł `[157]`
Mówca: **Lucian Galade**
> "“The information we received raises some eyebrows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucian Galade: "“The initial reports from the Holsord police chief indica..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PhoneRingPickUp");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Livia left the room and the phone started ringing. I pick..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation = true;
BaseGame.Situation_Diplomacy_Energy_PriceSurge = false;
BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_A_Media = true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Deyr_History == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn01_A_Media = true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceFluctuation = tr..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PhoneRingPickUp");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "Livia left the room and the phone started ringing. Lucian..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_GalmlandTension");`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_GalmlandTension");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)
