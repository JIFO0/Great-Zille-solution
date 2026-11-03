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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 21

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Situation_Diplomacy_Energy_PriceBalanced`
- `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation`
- `BaseGame.Situation_Diplomacy_Energy_PriceSurge`
- `BaseGameSupport.News_Turn01_G_Relations`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[46]` (Lucian Galade): `Variable["BaseGame.Turn01_Admin_Meeting"] = true;`
- Węzeł `[76]` (Lucian Galade): `Variable["GameCondition.Turn01_A_Media"] = true;`
- Węzeł `[118]` (Lucian Galade): `Variable["BaseGameSupport.News_Turn01_R_GlamorousBall"] = true; Variable["BaseGameSupport.News_Tu...`
- Węzeł `[119]` (Lucian Galade): `Variable["BaseGameSupport.News_Turn01_G_Relations"] = true;`
- Węzeł `[120]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn01_Holsord_AutocratCommittee"] = true;`
- Węzeł `[127]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn01_Holsord_DictatorCommittee"] = true;`
- Węzeł `[128]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn01_Holsord_ReformistCommittee"] = true;`
- Węzeł `[129]` (Lucian Galade): `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = true;`
- *...oraz 13 innych węzłów ze skryptami.*

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
  - -> `[79]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucian Galade**
> "“He has offered to meet with you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`
  - -> `[84]`

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“But let's not get ahead of ourselves. First, we need to determine our general approach to media.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "“The media must be independent.”"]** — Mówca: **Player**
> "“The media must be independent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“The media is a tool to be used.”"]** — Mówca: **Player**
> "“The media is a tool to be used.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
> "“I agree. Media plays a huge role in adapting public opinion towards our views and policies, while helping us avoid damage from scandals or mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
> "“While I do acknowledge that this will sound a bit harsh, I certainly believe that our perspective, knowledge and experience allows us to have superior judgement compared to the average Sordish citizen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
> "“Ideally, yes. But an unpopular leader will not be able to pass even the easiest reforms. It is of utmost importance to maintain public popularity and avoid any damaging scandals or mistakes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Lucian Galade**
> "“I must stress one thing, Mr. President. The more people we have supporting our agenda, the more we can accomplish. With someone on our side in an influential media organisation, we can do this very easily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[14]`
  - -> `[17]`

### Węzeł `[11]`
Mówca: **Petr Vectern**
> "“I agree with Lucian, but why the assumption there'll be scandals and mistakes?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[12]`
Mówca: **Petr Vectern**
> "“They are a powerful and influential media conglomerate. To start with, they own the Sordland Today newspaper, the Sordish Broadcasting Corporation, the S-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“After the passing of his father -- may he rest in peace -- Marcel aims to become the next CEO of the HOS Conglomerate. He mentioned a productive collaboration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“Two wrongs don't make a right.”"]** — Mówca: **Player**
> "“Two wrongs don't make a right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“I see what you are getting at.”"]** — Mówca: **Player**
> "“I see what you are getting at.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“That does sound harsh.”"]** — Mówca: **Player**
> "“That does sound harsh.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“I share your opinion.”"]** — Mówca: **Player**
> "“I share your opinion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[18]`
Mówca: **Petr Vectern**
> "“Maybe, maybe not. It's hard to forget what happened to President Alphonso last year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“Things got even worse after his cabinet resigned and the media started to slander him, but that was also a result of his own incompetence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> "“We can always hope for the best. But do we really think that nothing can go wrong? Especially considering the very recent history of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[21]`
Mówca: **Petr Vectern**
> "“Yes, we shouldn't resort to these measures to solve our potential political mistakes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> "“It isn't about that alone, Petr. There could be groups or people who would want to damage us even if we are in the right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[23]`
Mówca: **Petr Vectern**
> "“I concur. Even if we don't use it, we should be able to have control over it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“You both are aware of my certain expertise with public opinion swaying. I will make sure the media is on our side.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
> "“There are two ways we can approach the media. One of them is by influencing it, which has clear advantages. The other one is keeping it independent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`

### Węzeł `[26]`
Mówca: **Petr Vectern**
> "“I'm no media expert, but Lucian made some very interesting arguments at the preparation meeting yesterday.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Two knocks were heard on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Please, come in.”"]** — Mówca: **Player**
> "“Please, come in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Who is it?”"]** — Mówca: **Player**
> "“Who is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[30]`
Mówca: **Livia Suno**
> "“Excuse me, Mr. President. Mr. Galade's secretary has been calling me and wanted me to relay a message.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Livia Suno, my new secretary, entered the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[32]`
Mówca: **Narrator**
> "The Korontis had always been known as one of the richest and most influential families in Sordland. Marcel Koronti was no exception."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“What does this *productive collaboration* entail?”"]** — Mówca: **Player**
> "“What does this *productive collaboration* entail?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Let's consider our options first. No need to be hasty.”"]** — Mówca: **Player**
> "“Let's consider our options first. No need to be hasty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[35]`
Mówca: **Livia Suno**
> "“Marcel Koronti, the new CEO for HOS Conglomerate, is on the line for Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Petr Vectern**
> "“Well. The ball is in our court now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[37]`
Mówca: **Livia Suno**
> "“Right away, sir. Connecting the call to line one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[38]`
Mówca: **Narrator**
> "Livia left the room and the phone started ringing. I picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`
  - -> `[53]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
> "“Good news indeed. Congratulations, Mr. Koronti. Thank you for contacting me about this. We will talk later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Lucian put the phone down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Petr Vectern**
> "“What was so important that it couldn't wait?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
> "“He was just elected CEO by the board of directors. He offered a partnership deal regarding his media branch. He is inviting us to his resort near Conriat for a meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Arrange the meeting with Mr. Koronti.”"]** — Mówca: **Player**
> "“Arrange the meeting with Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“I do not want to associate with a media mogul. Reject the offer.”"]** — Mówca: **Player**
> "“I do not want to associate with a media mogul. Reject the offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“I would like to hear your opinion, Petr.”"]** — Mówca: **Player**
> "“I would like to hear your opinion, Petr.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[46]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_Admin_Meeting = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn01_Admin_Meeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“You go ahead. Connect the line to my office.”"]** — Mówca: **Player**
> "“You go ahead. Connect the line to my office.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "“I'll talk to him. Connect the line to my office.”"]** — Mówca: **Player**
> "“I'll talk to him. Connect the line to my office.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[49]`
Mówca: **Narrator**
> "A few minutes passed as the two talked over the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[50]`
Mówca: **Marcel Koronti**
> "“The pleasure is all mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“The President speaking.”"]** — Mówca: **Player**
> "“The President speaking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“It's a pleasure, Mr. Koronti.”"]** — Mówca: **Player**
> "“It's a pleasure, Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Hello, Marcel.”"]** — Mówca: **Player**
> "“Hello, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
> "“He is going to offer a real deal and now has the power of the conglomerate too. The choice is up to you, Mr. President. I can set up the meeting soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[43]`
  - -> `[44]`

### Węzeł `[55]`
Mówca: **Marcel Koronti**
> "“Greetings, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[56]`
Mówca: **Marcel Koronti**
> "“It's an honor, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Petr Vectern**
> "“The board has decided rather quickly. It seems that gave him the confidence to approach us again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[58]`
Mówca: **Marcel Koronti**
> "“I know your time is valuable, so I will not waste any of it. I was just elected CEO of HOS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Thank you for the offer. I would be interested in a meeting.”"]** — Mówca: **Player**
> "“Thank you for the offer. I would be interested in a meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Thank you for your offer, Mr. Koronti, but I have to refuse.”"]** — Mówca: **Player**
> "“Thank you for your offer, Mr. Koronti, but I have to refuse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Marcel Koronti**
> "“You will not be disappointed, I promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
Mówca: **Marcel Koronti**
> "“That is a shame. Thank you for your time nonetheless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Mr. Koronti hung up the phone without waiting for my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[64]`
Mówca: **Marcel Koronti**
> "“Well then, I will let you return to your packed schedule. See you later, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[98]`

### Węzeł `[65]`
Mówca: **Petr Vectern**
> "“I have to say I'm torn. If he has become the CEO, then he has enormous influence now. On the other hand, do we want to privately meet with someone we don't fully know?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“The meeting would help us figure him out. We could still say no to whatever he offers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Arrange the meeting with Mr. Koronti.”"]** — Mówca: **Player**
> "“Arrange the meeting with Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I do not want to associate with a media mogul. Reject the offer.”"]** — Mówca: **Player**
> "“I do not want to associate with a media mogul. Reject the offer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
> "“I'll set things up right away. Expect a worthwhile meeting next month.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“That is a clear no. Very well. I hope we have made the right call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
> "“It appears we're done for today. We will continue where we left off later. Thank you for your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[73]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“Good work with Marcel. Keep it up.”"]** — Mówca: **Player**
> "“Good work with Marcel. Keep it up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“See you soon, gentlemen.”"]** — Mówca: **Player**
> "“See you soon, gentlemen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[74]`
Mówca: **Petr Vectern**
> "“It's settled then. Looking forward to next month. I wonder if he has a pool?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[75]`
Mówca: **Petr Vectern**
> "“Well, that makes things clear. We should focus on other things anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn01_A_Media = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn01_A_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[77]`
Mówca: **Marcel Koronti**
> "“Good luck in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[78]`
Mówca: **Narrator**
> "We were already getting the attention of key figures -- and potentially dangerous ones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[79]`
Mówca: **Narrator**
> "Lucian and Petr arrived at my office to talk about recent developments and the media strategy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[80]`
Mówca: **Marcel Koronti**
> "“This is why I am offering a partnership deal regarding our media branch. I would like to formally invite you to my resort near Conriat for a meeting to discuss the details.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[59]`
  - -> `[60]`

### Węzeł `[81]`
Mówca: **Marcel Koronti**
> "“My strategy in the running of this conglomerate will be different than my father's approach.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“What does he want?”"]** — Mówca: **Player**
> "“What does he want?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Why is Konrath sending his son?”"]** — Mówca: **Player**
> "“Why is Konrath sending his son?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Why should I meet with him?”"]** — Mówca: **Player**
> "“Why should I meet with him?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Lucian turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[86]`
Mówca: **Petr Vectern**
> "“He, uh, unfortunately passed away today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“Which means it would be wise to have them by our side. Sorry for interrupting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[34]`
  - -> `[108]`

### Węzeł `[88]`
Mówca: **Livia Suno**
> "“It's Livia, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Livia Suno, my new secretary, entered the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
> "“Would you like to talk to him, sir, or would you like me to?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[47]`

### Węzeł `[91]`
Mówca: **Livia Suno**
> "“Right away, sir. Connecting the call to line one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Livia left the room and the phone started ringing. Lucian picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Lucian looked at his watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Lucian and Petr gathered their documents and promptly left my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "“What does that entail?”"]** — Mówca: **Player**
> "“What does that entail?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Marcel Koronti**
> "“Our future as partners, Mr. President. Surely, we can't talk about the details on the phone. I just wish to have a face to face conversation with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Marcel Koronti**
> "“I will send you the details through my secretary if you are interested.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "“See you later, Mr. Koronti.”"]** — Mówca: **Player**
> "“See you later, Mr. Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Narrator**
> "I hung up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Goodbye.”"]** — Mówca: **Player**
> "“Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[101]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Takeover_Backstab == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[104]`
Mówca: **Petr Vectern**
> "“Says the man who used the media to backstab President Alphonso last year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[105]`
Mówca: **Narrator**
> "They both took their seats across from me. Lucian put on his reading glasses and quickly went over some documents. Petr turned to Lucian and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“Greetings, gentlemen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[107]`
Mówca: **Narrator**
> "He was the oldest son of Konrath Koronti, the industrialist and media mogul who founded HOS. The richest man in the entirety of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Sounds like there is potential there.”"]** — Mówca: **Player**
> "“Sounds like there is potential there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“However, as Petr said, they have substantial power over the content of media outlets. Headlines, radio shows. That is what he would be offering. What he wants in return is what we need to understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
> "“I agree. We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[111]`
Mówca: **Lucian Galade**
> "“There is definitely potential. A potential that could go both ways.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[112]`
Mówca: **Lucian Galade**
> "“He did not wish to explain the details over the phone but rather in person. I believe I will be receiving a call from him sometime soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Lucian and Petr nodded before gathering their documents and leaving my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[114]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_Admin_Meeting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_Admin_Meeting == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_Admin_Meeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[116]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_Admin_Meeting == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_Admin_Meeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
**[WYBÓR GRACZA: "“I expect you to bring better allies to the table.”"]** — Mówca: **Player**
> "“I expect you to bring better allies to the table.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_R_GlamorousBall = true;
BaseGameSupport.News_Turn01_ST_KonrathPassed = true;
BaseGameSupport.News_Turn01_ST_HSURavaged = true;
BaseGameSupport.Report_Turn01_Holsord_SIDFireReport = true;
BaseGameSupport.CountryReport_Turn01_Kyrute_PraisesDemocracy = true;
BaseGameSupport.News_Turn01_LT_GasomFreezesHiring = true;
BaseGameSupport.Report_Turn01_Ribery_TourismIndicator = true;
BaseGameSupport.Report_Turn01_Valgen_DamOutputReduces = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_R_GlamorousBall"] = true;
Variable["BaseGameSupport.News_Turn01_ST_KonrathPassed"] = true;
Variable["BaseGameSupport.News_Turn01_ST_HSURavaged"] = true;
Variable["BaseGameSupport.Report_Turn01_Holsord_SIDFireReport"] = true;
Variable["BaseGameSupport.CountryReport_Turn01_Kyrute_PraisesDemocracy"] = true;
Variable["BaseGameSupport.News_Turn01_LT_GasomFreezesHiring"] = true;
Variable["BaseGameSupport.Report_Turn01_Ribery_TourismIndicator"] = true;
Variable["BaseGameSupport.Report_Turn01_Valgen_DamOutputReduces"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_G_Relations = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_G_Relations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[120]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Holsord_AutocratCommittee = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_AutocratCommittee"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[121]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Holsord_DictatorCommittee = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_DictatorCommittee"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[128]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Holsord_ReformistCommittee = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_ReformistCommittee"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Others_LiviaSuno = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[130]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Others_LiviaSuno = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[131]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Corporations_HOS = false; BaseGameSupport.Codex_Organisations_Corporations_HOS_KonrathDead = true;
BaseGameSupport.Codex_Characters_Business_MarcelKoronti = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead = true; BaseGameSupport.Codex_Characters_Business_KonrathKoronti = false; BaseGameSupport.Codex_Characters_Business_KonrathKoronti_Dead = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Corporations_HOS"] = false;
Variable["BaseGameSupport.Codex_Organisations_Corporations_HOS_KonrathDead"] = true;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead"] = true;
Variable["BaseGameSupport.Codex_Characters_Business_KonrathKoronti"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_KonrathKoronti_Dead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[132]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Organisations_Corporations_HOS = false; BaseGameSupport.Codex_Organisations_Corporations_HOS_KonrathDead = true;
BaseGameSupport.Codex_Characters_Business_MarcelKoronti = false; BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead = true; BaseGameSupport.Codex_Characters_Business_KonrathKoronti = false; BaseGameSupport.Codex_Characters_Business_KonrathKoronti_Dead = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Corporations_HOS"] = false;
Variable["BaseGameSupport.Codex_Organisations_Corporations_HOS_KonrathDead"] = true;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_MarcelKoronti_KonrathDead"] = true;
Variable["BaseGameSupport.Codex_Characters_Business_KonrathKoronti"] = false;
Variable["BaseGameSupport.Codex_Characters_Business_KonrathKoronti_Dead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[133]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn01_AcceptedMarcelOfferToMeet = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_AcceptedMarcelOfferToMeet"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[134]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn01_RejectedMarcelOfferToMeet = true;
BaseGame.Public_Opinion -= 2;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn01_RejectedMarcelOfferToMeet"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[135]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn02_A_MediaDeal = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn02_A_MediaDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[136]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_Admin_TalkedToMarcel = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn01_Admin_TalkedToMarcel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Her dark curls bounced as she crossed the room to my desk. She spoke with a slight lilt in her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“I have just received further information from the Interior about the sudden fire that broke out at the Holsord State University archives nearby.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[141]`
  - -> `[145]`

### Węzeł `[140]`
Mówca: **Petr Vectern**
> "“Is the SID really necessary for this? Why would anyone hit the archives of a university in the first place? I see no logical motive there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“Was it put out quickly?”"]** — Mówca: **Player**
> "“Was it put out quickly?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "“Tell me more.”"]** — Mówca: **Player**
> "“Tell me more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[143]`
Mówca: **Lucian Galade**
> "“Our firefighters put out the fire as soon as they could. Yet it had been burning for six hours, so extensive damage was done to the archives and the building.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[144]`
Mówca: **Lucian Galade**
> "“The initial reports from the Holsord police chief indicate a potential arson case. In accordance with protocol, the Sordish Intelligence Directorate has been called.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[145]`
**[WYBÓR GRACZA: "“I'm not interested in the subject.”"]** — Mówca: **Player**
> "“I'm not interested in the subject.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Lucian Galade**
> "“Excuse me. Let's just move on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Petr Vectern**
> "“More importantly, Lucian mentioned that Marcel Koronti contacted him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[148]`
Mówca: **Petr Vectern**
> "“I will arrange medals to recognize their bravery for doing their best. The Holsord Fire Department is full of tough champs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[149]`
Mówca: **Lucian Galade**
> "“It seems like the chief suspects foreign sabotage. They informed us that a large section of the archive has been destroyed. It included tens of thousands of globally recognized research documents in original by the great thinkers of our people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`
  - -> `[152]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“It's a shame so much knowledge was lost.”"]** — Mówca: **Player**
> "“It's a shame so much knowledge was lost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "“Back to Petr's point. If this was arson, what could the motive have been?""]** — Mówca: **Player**
> "“Back to Petr's point. If this was arson, what could the motive have been?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
**[WYBÓR GRACZA: "“We need to support our education system to make new discoveries for the future.”"]** — Mówca: **Player**
> "“We need to support our education system to make new discoveries for the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[153]`
Mówca: **Lucian Galade**
> "“Luckily most originals have copies in the other universities and some international libraries. The first edition of my favorite book, "The Geopolitics of Sordland" by Herman Equa, was destroyed too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
Mówca: **Lucian Galade**
> "“The fact that the employee records have been destroyed along with the research documents raises further questions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[155]`
Mówca: **Lucian Galade**
> "“Preserving our knowledge is as important as expanding on it. It's interesting that the employee records have been destroyed as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[156]`
Mówca: **Petr Vectern**
> "“Maybe it was just a freak accident. We do have the copies of most important works, so no single fire can eradicate our knowledge. I see no point in destroying employee records, either.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[157]`
Mówca: **Lucian Galade**
> "“The information we received raises some eyebrows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[158]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PhoneRingPickUp");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[159]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceFluctuation = true;
BaseGame.Situation_Diplomacy_Energy_PriceSurge = false;
BaseGame.Situation_Diplomacy_Energy_PriceBalanced = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] = true;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceSurge"] = false;
Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Studyplace_Deyr_History == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[163]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Studyplace_Deyr_History == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[164]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("PhoneRingPickUp");)*
- **Efekt (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[165]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: EnableNews("G_GalmlandTension");)*
- **Efekt (`userScript`):** `EnableNews("G_GalmlandTension");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
