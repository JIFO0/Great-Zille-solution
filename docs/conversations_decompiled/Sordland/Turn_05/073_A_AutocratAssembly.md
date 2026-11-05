# Sordland/Turn05/A_AutocratAssembly

- **ID konwersacji:** `73`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/073_A_AutocratAssembly.md`
- **Liczba węzłów dialogowych:** 167
- **Liczba wyborów gracza:** 33

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[15]** Mansoun Leke
- **[32]** Frens Ricter
- **[34]** Gloria Tory

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_HeljilandRecognised`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Wehlen_TradeDeal`
- `BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded`
- `BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded`
- `BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted`
- `BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy`
- `BaseGameSupport.News_Turn05_G_WalkerWarnsNavy`
- `BaseGameSupport.News_Turn05_HP_EmergencyDebate`
- `BaseGameSupport.News_Turn05_LT_EmergencyReview`
- `BaseGameSupport.News_Turn05_R_EmergencyDebate`
- `BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Respond_NoDeal`
- `BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Shout_NoDeal`
- `BaseGameSupport.Report_Turn05_Uziren_BorderReport`
- `GameCondition.Turn05_A_Speech`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[28]` | **"Ask Gloria for a moment to respond."** | `[27]` **Narrator**: "Loud applauses came from the opp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Gloria looked at me and nodded." |
| `[29]` | **"Stay silent."** | `[27]` **Narrator**: "Loud applauses came from the opp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Frens Ricter**: ""I ask for my honorable colleagu..." |
| `[30]` | **"Stand up and yell at him."** | `[27]` **Narrator**: "Loud applauses came from the opp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "I shouted at him in protest." |
| `[36]` | **""Mr. Ricter, you speak of pure slander. There are no political intentions...""** | `[35]` **Gloria Tory**: ""The President has the floor."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Frens laughed sarcastically." |
| `[37]` | **""Gentlemen, you're underestimating the threats!""** | `[35]` **Gloria Tory**: ""The President has the floor."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Frens laughed sarcastically." |
| `[38]` | **""Mr. Ricter! Who are you to speak about such things?""** | `[35]` **Gloria Tory**: ""The President has the floor."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Narrator**: "Frens laughed sarcastically." |
| `[40]` | **""We will be controlling the situation shortly. Be patient!""** | `[39]` **Narrator**: "Frens laughed sarcastically." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Gloria Tory**: ""Mr. President, let's keep it br..." |
| `[41]` | **""We know that Mr. Ricter himself has ties with foreign interests!""** | `[39]` **Narrator**: "Frens laughed sarcastically." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Gloria Tory**: ""Mr. President, let's keep it br..." |
| `[42]` | **""The State is doing what's best for Sordland.""** | `[39]` **Narrator**: "Frens laughed sarcastically." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Gloria Tory**: ""Mr. President, let's keep it br..." |
| `[44]` | **""The decree is completely legal.""** | `[43]` **Gloria Tory**: ""Mr. President, let's keep it br..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Gloria Tory**: ""I have to let Mr. Ricter contin..." |
| `[45]` | **""Don't be fooled by Mr. Ricter's slander. We all know the truth.""** | `[43]` **Gloria Tory**: ""Mr. President, let's keep it br..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Gloria Tory**: ""I have to let Mr. Ricter contin..." |
| `[46]` | **""This emergency will show us the real traitors among us.""** | `[43]` **Gloria Tory**: ""Mr. President, let's keep it br..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Gloria Tory**: ""I have to let Mr. Ricter contin..." |
| `[49]` | **""PURE SLANDER!""** | `[31]` **Narrator**: "I shouted at him in protest." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "Frens first looked at me and the..." |
| `[50]` | **""DON'T WASTE OUR TIME!""** | `[31]` **Narrator**: "I shouted at him in protest." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "Frens first looked at me and the..." |
| `[51]` | **""WATCH WHAT YOU ARE SAYING!""** | `[31]` **Narrator**: "I shouted at him in protest." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "Frens first looked at me and the..." |
| `[52]` | **""VERY CREATIVE!""** | `[31]` **Narrator**: "I shouted at him in protest." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "Frens first looked at me and the..." |
| `[87]` | **"Keep sitting."** | `[86]` **Narrator**: "People started to get up from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Narrator**: "I watched as everybody voted one..." |
| `[88]` | **"Go to cast a vote."** | `[86]` **Narrator**: "People started to get up from th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "I grabbed the envelope and prepa..." |
| `[90]` | **"Vote aye for the fun of it."** | `[89]` **Narrator**: "I grabbed the envelope and prepa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "Some time has passed when the vo..." |
| `[91]` | **"Vote no."** | `[89]` **Narrator**: "I grabbed the envelope and prepa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "Some time has passed when the vo..." |
| `[97]` | **"Ask to speak."** | `[101]` **Narrator**: "He turned around and went back t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Gloria Tory**: ""Yes, Mr. President."" |
| `[102]` | **"Leave the Assembly."** | `[101]` **Narrator**: "He turned around and went back t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Narrator**: "The whole Assembly watched behin..." |
| `[105]` | **""I want to thank the members of the Assembly...""** | `[104]` **Gloria Tory**: ""Yes, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Frens watched me with no emotion..." |
| `[106]` | **""Let us try to be more civil towards each other...""** | `[104]` **Gloria Tory**: ""Yes, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Frens watched me with no emotion..." |
| `[107]` | **""Mr. Ricter, you cannot stand against the USP.""** | `[104]` **Gloria Tory**: ""Yes, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Frens watched me with no emotion..." |
| `[109]` | **""I condemn Mr. Ricter's empathy and support for the prosecuted.""** | `[108]` **Narrator**: "Frens watched me with no emotion..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Narrator**: "Mansoun Leke interrupted me." |
| `[110]` | **""Let's put this behind us, we must not deviate from the real enemy!""** | `[108]` **Narrator**: "Frens watched me with no emotion..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Narrator**: "Mansoun Leke interrupted me." |
| `[111]` | **""Rest assured, we will handle all the problems.""** | `[108]` **Narrator**: "Frens watched me with no emotion..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Narrator**: "Mansoun Leke interrupted me." |
| `[123]` | **""You have it all wrong, Mr. Leke.""** | `[122]` **Gloria Tory**: ""Order, Mr. Leke! Try to refrain..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Mansoun Leke**: ""We know how you rule, Mr. Presi..." |
| `[124]` | **""Are you implying violence against the State!?""** | `[122]` **Gloria Tory**: ""Order, Mr. Leke! Try to refrain..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Mansoun Leke**: ""Go ahead, create any reason to ..." |
| `[125]` | **""This has nothing to do with race.""** | `[122]` **Gloria Tory**: ""Order, Mr. Leke! Try to refrain..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Mansoun Leke**: ""We know how you rule, Mr. Presi..." |
| `[126]` | **""Are you giving support to the separatists?""** | `[122]` **Gloria Tory**: ""Order, Mr. Leke! Try to refrain..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Mansoun Leke**: ""Go ahead, create any reason to ..." |
| `[136]` | **""The emergency was a hard decision to make but it was needed.""** | `[43]` **Gloria Tory**: ""Mr. President, let's keep it br..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Gloria Tory**: ""I have to let Mr. Ricter contin..." |

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
  - -> `[3]` (*Narrator: "A session of the Grand National Assembly was in order bec..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "A session of the Grand National Assembly was in order because of the continued discussion about the emergency. The opposition wanted to declare it null and void."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I was seated in one of the seats reserved for the council..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I was seated in one of the seats reserved for the council of ministers, which was positioned slightly higher than the rest of the seats and had an angle that made for a clear view of the whole place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "I glanced down at the USP seats and casually watched the ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "I glanced down at the USP seats and casually watched the people inside as Gloria announced the next speaker before the vote to revoke the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Gloria Tory: ""Mr. Frens Ricter from the People's Freedom and Justice P..."*)

### Węzeł `[6]`
Mówca: **Gloria Tory**
> ""Mr. Frens Ricter from the People's Freedom and Justice Party has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Frens Ricter: ""Ladies and Gentlemen! A devastating picture has often be..."*)

### Węzeł `[7]`
Mówca: **Frens Ricter**
> ""Ladies and Gentlemen! A devastating picture has often been painted of the state of affairs prevailing in Sordland today. As always in such cases, there is no lack of exaggeration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Frens Ricter: ""Considering the extreme measures being taken that comple..."*)

### Węzeł `[8]`
Mówca: **Frens Ricter**
> ""Considering the extreme measures being taken that completely sets aside our freedoms, no one can fairly demand or expect of us to accept this extension of the Emergency Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Frens Ricter: ""The elections of December have resulted in a majority fo..."*)

### Węzeł `[9]`
Mówca: **Frens Ricter**
> ""The elections of December have resulted in a majority for the USP and thus given Mr. Rayne the opportunity to govern, strictly as laid down in the intention of the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Frens Ricter: ""But where this opportunity is given, it is coupled with ..."*)

### Węzeł `[10]`
Mówca: **Frens Ricter**
> ""But where this opportunity is given, it is coupled with obligations. Respecting the laws and listening to criticism is necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Frens Ricter: ""Not only the Assembly's opinion was not asked, the reaso..."*)

### Węzeł `[11]`
Mówca: **Frens Ricter**
> ""Not only the Assembly's opinion was not asked, the reasons for the emergency nor its extension were not justified!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Frens Ricter: ""The President clearly has ideological intentions. This d..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[15]`
Mówca: **Frens Ricter**
> ""The President clearly has ideological intentions. This decree was an attempt to destroy the Socialist Movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Frens Ricter: ""This decree was a declaration of war against the Bludish..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[19]`
Mówca: **Frens Ricter**
> ""This decree was a declaration of war against the Bludish people. The President does not even shy away from using divisive words. He has political intentions which will have grave consequences for our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Frens Ricter: ""Mr. Rayne is exploiting the shooting of Bernard Circas a..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Frens Ricter: ""Ladies and Gentlemen of the United Sordland Party! You h..."*)

### Węzeł `[23]`
Mówca: **Frens Ricter**
> ""Mr. Rayne is exploiting the shooting of Bernard Circas and using this to his advantage to give us all these lies about national security threats!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Frens Ricter: ""Ladies and Gentlemen of the United Sordland Party! You h..."*)

### Węzeł `[24]`
Mówca: **Frens Ricter**
> ""Ladies and Gentlemen of the United Sordland Party! You have claimed to have reformed the party and promised to bring the change people have been asking for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Frens Ricter: ""Yet while the workers, the peasants, the whitecollar emp..."*)

### Węzeł `[25]`
Mówca: **Frens Ricter**
> ""Yet while the workers, the peasants, the whitecollar employees, the civil servants, or the businessmen of Sordland have their own troubles and demands from us, you go about fighting wars with enemies that don't exist!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Frens Ricter: ""Everybody expected of you to rewrite the outdated Consti..."*)

### Węzeł `[26]`
Mówca: **Frens Ricter**
> ""Everybody expected of you to rewrite the outdated Constitution of Tarquin Soll. Now we have an emergency on our hands, which is fabricated to create a justification for the lack of reforms of the government. And their apparent hunger for authority!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyApplause2");"*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Loud applauses came from the opposition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Italic: "Ask Gloria for a moment to respond."*)
  - -> `[29]` (*Player_Italic: "Stay silent."*)
  - -> `[30]` (*Player_Italic: "Stand up and yell at him."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "Ask Gloria for a moment to respond."]** — Mówca: **Player_Italic**
> "I gestured at Gloria to ask for an opportunity to respond to Frens Ricter."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Gloria looked at me and nodded."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I kept watching Frens Ricter."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Frens Ricter: ""I ask for my honorable colleagues to support the PFJP in..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "Stand up and yell at him."]** — Mówca: **Player_Italic**
> "I stood up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "I shouted at him in protest."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "I shouted at him in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: ""PURE SLANDER!""*)
  - -> `[50]` (*Player: ""DON'T WASTE OUR TIME!""*)
  - -> `[51]` (*Player: ""WATCH WHAT YOU ARE SAYING!""*)
  - -> `[52]` (*Player: ""VERY CREATIVE!""*)

### Węzeł `[32]`
Mówca: **Frens Ricter**
> ""I ask for my honorable colleagues to support the PFJP in revoking this emergency, here and now!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Frens Ricter: ""I am talking to the members of the United Sordland Party..."*)

### Węzeł `[33]`
Mówca: **Gloria Tory**
> ""I'm sorry to interrupt, Mr. Ricter, but the President has asked for an opportunity to respond. You have directly addressed the President in your speech, so I shall give him the opportunity to give a brief response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Gloria Tory: ""The President has the floor.""*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Gloria looked at me and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded = true"*)

### Węzeł `[35]`
Mówca: **Gloria Tory**
> ""The President has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""Mr. Ricter, you speak of pure slander. There are no poli..."*)
  - -> `[37]` (*Player: ""Gentlemen, you're underestimating the threats!""*)
  - -> `[38]` (*Player: ""Mr. Ricter! Who are you to speak about such things?""*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Mr. Ricter, you speak of pure slander. There are no political intentions...""]** — Mówca: **Player**
> ""Mr. Ricter, you speak of pure slander. There are no political intentions behind this decree. It is a national emergency!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Frens laughed sarcastically."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Gentlemen, you're underestimating the threats!""]** — Mówca: **Player**
> ""Gentlemen, you're underestimating the threats!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Frens laughed sarcastically."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Mr. Ricter! Who are you to speak about such things?""]** — Mówca: **Player**
> ""Mr. Ricter! Who are you to speak about such things?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Frens laughed sarcastically."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Frens laughed sarcastically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: ""We will be controlling the situation shortly. Be patient!""*)
  - -> `[41]` (*Player: ""We know that Mr. Ricter himself has ties with foreign in..."*)
  - -> `[42]` (*Player: ""The State is doing what's best for Sordland.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""We will be controlling the situation shortly. Be patient!""]** — Mówca: **Player**
> ""We will be controlling the situation shortly. Be patient!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Gloria Tory: ""Mr. President, let's keep it brief.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""We know that Mr. Ricter himself has ties with foreign interests!""]** — Mówca: **Player**
> ""We know that Mr. Ricter himself has ties with foreign interests!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Gloria Tory: ""Mr. President, let's keep it brief.""*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""The State is doing what's best for Sordland.""]** — Mówca: **Player**
> ""The State is doing what's best for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Gloria Tory: ""Mr. President, let's keep it brief.""*)

### Węzeł `[43]`
Mówca: **Gloria Tory**
> ""Mr. President, let's keep it brief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""This emergency will show us the real traitors among us.""*)
  - -> `[44]` (*Player: ""The decree is completely legal.""*)
  - -> `[136]` (*Player: ""The emergency was a hard decision to make but it was nee..."*)
  - -> `[45]` (*Player: ""Don't be fooled by Mr. Ricter's slander. We all know the..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""The decree is completely legal.""]** — Mówca: **Player**
> ""The decree is completely legal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gloria Tory: ""I have to let Mr. Ricter continue, Mr. President.""*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""Don't be fooled by Mr. Ricter's slander. We all know the truth.""]** — Mówca: **Player**
> ""Don't be fooled by Mr. Ricter's slander. We all know the truth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gloria Tory: ""I have to let Mr. Ricter continue, Mr. President.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""This emergency will show us the real traitors among us.""]** — Mówca: **Player**
> ""This emergency will show us the real traitors among us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gloria Tory: ""I have to let Mr. Ricter continue, Mr. President.""*)

### Węzeł `[47]`
Mówca: **Gloria Tory**
> ""I have to let Mr. Ricter continue, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Gloria Tory: ""Mr. Frens Ricter has the floor.""*)

### Węzeł `[48]`
Mówca: **Gloria Tory**
> ""Mr. Frens Ricter has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Frens Ricter: ""Thank you, Mrs. Speaker.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA: ""PURE SLANDER!""]** — Mówca: **Player**
> ""PURE SLANDER!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Frens first looked at me and then at Gloria."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""DON'T WASTE OUR TIME!""]** — Mówca: **Player**
> ""DON'T WASTE OUR TIME!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Frens first looked at me and then at Gloria."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""WATCH WHAT YOU ARE SAYING!""]** — Mówca: **Player**
> ""WATCH WHAT YOU ARE SAYING!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Frens first looked at me and then at Gloria."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""VERY CREATIVE!""]** — Mówca: **Player**
> ""VERY CREATIVE!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Frens first looked at me and then at Gloria."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Frens first looked at me and then at Gloria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted = true"*)

### Węzeł `[54]`
Mówca: **Gloria Tory**
> ""Mr. President... Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Gloria Tory: ""Please continue, Mr. Ricter.""*)

### Węzeł `[55]`
Mówca: **Gloria Tory**
> ""Please continue, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Frens Ricter: ""Thank you, Mrs. Speaker. I have to say, I deplore the re..."*)

### Węzeł `[56]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Frens Ricter: ""Mr. President spoke nonsense.""*)

### Węzeł `[57]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker. I have to say, I deplore the reaction of the President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "He cleared his throat."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Frens Ricter: ""I ask for my honorable colleagues to support the PFJP in..."*)

### Węzeł `[59]`
Mówca: **Frens Ricter**
> ""I am talking to the members of the United Sordland Party as well! Do not act partisan in matters with such critical importance. We know that this emergency is a dangerous exaggeration and it can have very grim consequences on our democratic institutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Frens Ricter: ""I wish to trust in your judgement and ask for your help ..."*)

### Węzeł `[60]`
Mówca: **Frens Ricter**
> ""I wish to trust in your judgement and ask for your help in reaching an absolute majority against this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("AssemblyLaughter");"*)

### Węzeł `[61]`
Mówca: **Narrator**
> "One man from the USP seats yelled: "in your dreams!" It made the USP burst in laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Frens Ricter: ""When in fact the Assembly fails to deliver its duties fo..."*)

### Węzeł `[62]`
Mówca: **Frens Ricter**
> ""When in fact the Assembly fails to deliver its duties for the good of the Sordish people, I shall be personally making a case to the Supreme Court about the legality of this emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Frens Ricter: ""Ladies and Gentlemen! We all know that this emergency is..."*)

### Węzeł `[63]`
Mówca: **Frens Ricter**
> ""Ladies and Gentlemen! We all know that this emergency is unlawful!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[64]`
Mówca: **Frens Ricter**
> ""It clearly breaches on the freedoms and rights of men defined in the Section 100 of the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Frens Ricter: ""It breaches on the right for a fair trial by giving the ..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Frens Ricter: ""It clearly breaches on the freedoms and rights of men de..."*)

### Węzeł `[68]`
Mówca: **Frens Ricter**
> ""It breaches on the right for a fair trial by giving the State the right to detain anyone without a trial. This is a breach on democracy as well as the freedoms of men defined in the Section 100 of the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Frens Ricter: ""It also denies people's right to assemble in protest. Th..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Frens Ricter: ""Sordland is being practically transformed into a police ..."*)

### Węzeł `[72]`
Mówca: **Frens Ricter**
> ""Sordland is being practically transformed into a police state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Frens Ricter: ""According to the Constitution, these rights can not be s..."*)

### Węzeł `[73]`
Mówca: **Frens Ricter**
> ""It also denies people's right to assemble in protest. This is a clear breach of freedom of expression and freedom of speech!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Frens Ricter: ""According to the Constitution, these rights can not be s..."*)

### Węzeł `[74]`
Mówca: **Frens Ricter**
> ""According to the Constitution, these rights can not be suspended under any other circumstances than being under invasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Frens Ricter: ""Do any of you see any Rumburgian tanks in Sordland? Are ..."*)

### Węzeł `[75]`
Mówca: **Frens Ricter**
> ""Do any of you see any Rumburgian tanks in Sordland? Are we under bombardment? There is nobody attacking but the State! They are persecuting thousands of innocents under national security threats! Who will stop the President from prosecuting all who oppose him tomorrow?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Frens Ricter: ""The State is acting illegally! I hereby invite the Supre..."*)

### Węzeł `[76]`
Mówca: **Frens Ricter**
> ""The State is acting illegally! I hereby invite the Supreme Court to duty and ask for them to subject this decree to a proper judicial review and revoke it before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Frens Ricter: ""We must adhere to the basic principles of a constitution..."*)

### Węzeł `[77]`
Mówca: **Frens Ricter**
> ""I hail those who are persecuted and in despair. We hail the strong Sordish opposition. Their steadfastness and loyalty are worthy of acclaim. The courage of their convictions, their unbroken faith - are the guarantees of a brighter future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "He turned around and went back to his seat."*)

### Węzeł `[78]`
Mówca: **Frens Ricter**
> ""No decree can give you the power to destroy ideas which are eternal and indestructible!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Frens Ricter: ""I hail those who are persecuted and in despair. We hail ..."*)

### Węzeł `[79]`
Mówca: **Frens Ricter**
> ""We must adhere to the basic principles of a constitutional state, to the equality of rights, and the concept of social legislation anchored therein. I ask everybody's support in the upcoming vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Frens Ricter: ""Thank you.""*)

### Węzeł `[80]`
Mówca: **Frens Ricter**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Mr. Ricter walked back to his seat among applauses from h..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Mr. Ricter walked back to his seat among applauses from his party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Gloria Tory: ""Next, the Assembly will vote on PFJP's demand to revoke ..."*)

### Węzeł `[82]`
Mówca: **Gloria Tory**
> ""Next, the Assembly will vote on PFJP's demand to revoke the validity of the emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Gloria Tory: ""According to the Constitution, the Assembly requires at ..."*)

### Węzeł `[83]`
Mówca: **Gloria Tory**
> ""According to the Constitution, the Assembly requires at least two-thirds majority to revoke an emergency declared by the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "People started to get up from their seats to take the env..."*)

### Węzeł `[84]`
Mówca: **Gloria Tory**
> ""We have 131 ayes and 119 nays.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Gloria Tory: ""Ayes does not exceed the two-third threshold, so the nay..."*)

### Węzeł `[85]`
Mówca: **Frens Ricter**
> ""Mr. President spoke nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Frens Ricter: ""I ask for my honorable colleagues to support the PFJP in..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "People started to get up from their seats to take the envelopes and cast their votes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Italic: "Keep sitting."*)
  - -> `[88]` (*Player_Italic: "Go to cast a vote."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: "Keep sitting."]** — Mówca: **Player_Italic**
> "I kept sitting and did not go out to cast a vote."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "I watched as everybody voted one by one."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "Go to cast a vote."]** — Mówca: **Player_Italic**
> "I stood up to join the voting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "I grabbed the envelope and prepared my vote."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "I grabbed the envelope and prepared my vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Italic: "Vote aye for the fun of it."*)
  - -> `[91]` (*Player_Italic: "Vote no."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "Vote aye for the fun of it."]** — Mówca: **Player_Italic**
> "I voted for it believing that it would not succeed anyway."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Some time has passed when the votes were counted."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "Vote no."]** — Mówca: **Player_Italic**
> "I casted my vote against it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Some time has passed when the votes were counted."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "I watched as everybody voted one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Some time has passed when the votes were counted."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Some time has passed when the votes were counted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("GavelBang");"*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Suddenly Gloria's gavel echoed in the hall, which eliminated the carefree attitude that lurked after the voting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Gloria Tory: ""We have 131 ayes and 119 nays.""*)

### Węzeł `[95]`
Mówca: **Gloria Tory**
> ""Ayes does not exceed the two-third threshold, so the nays have it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "PFJP members started making noises."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "PFJP members started making noises."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "A lot of people including Frens Ricter demanded to speak."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "Ask to speak."]** — Mówca: **Player_Italic**
> "I asked to speak."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Gloria Tory: ""Yes, Mr. President.""*)

### Węzeł `[98]`
Mówca: **Narrator**
> "A lot of people including Frens Ricter demanded to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Gloria Tory: ""Yes, Mr. Ricter.""*)

### Węzeł `[99]`
Mówca: **Gloria Tory**
> ""Yes, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Frens looked directly at me."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Frens looked directly at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Frens Ricter: ""No decree can give you the power to destroy ideas which ..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "He turned around and went back to his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Italic: "Ask to speak."*)
  - -> `[102]` (*Player_Italic: "Leave the Assembly."*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "Leave the Assembly."]** — Mówca: **Player_Italic**
> "I stood up and walked towards the exit."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "The whole Assembly watched behind me as I walked."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "The whole Assembly watched behind me as I walked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "I barely heard Mansoun Leke yelling behind me right when ..."*)

### Węzeł `[104]`
Mówca: **Gloria Tory**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""I want to thank the members of the Assembly...""*)
  - -> `[106]` (*Player: ""Let us try to be more civil towards each other...""*)
  - -> `[107]` (*Player: ""Mr. Ricter, you cannot stand against the USP.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""I want to thank the members of the Assembly...""]** — Mówca: **Player**
> ""I want to thank the members of the Assembly for their support in the State's measures.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Frens watched me with no emotions in his face."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Let us try to be more civil towards each other...""]** — Mówca: **Player**
> ""Let us try to be more civil towards each other in these difficult times.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Frens watched me with no emotions in his face."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Mr. Ricter, you cannot stand against the USP.""]** — Mówca: **Player**
> ""Mr. Ricter, you cannot stand against the USP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[104]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Frens watched me with no emotions in his face."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Frens watched me with no emotions in his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""I condemn Mr. Ricter's empathy and support for the prose..."*)
  - -> `[110]` (*Player: ""Let's put this behind us, we must not deviate from the r..."*)
  - -> `[111]` (*Player: ""Rest assured, we will handle all the problems.""*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""I condemn Mr. Ricter's empathy and support for the prosecuted.""]** — Mówca: **Player**
> ""I condemn Mr. Ricter's empathy and support for the prosecuted. They are prosecuted for their crimes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "Mansoun Leke interrupted me."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""Let's put this behind us, we must not deviate from the real enemy!""]** — Mówca: **Player**
> ""Let's put this behind us, we must not deviate from the real enemy!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "Mansoun Leke interrupted me."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""Rest assured, we will handle all the problems.""]** — Mówca: **Player**
> ""Rest assured, we will handle all the problems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "Mansoun Leke interrupted me."*)

### Węzeł `[112]`
Mówca: **Narrator**
> "Mansoun Leke interrupted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Mansoun Leke: ""You talk about difficult times, enemies and problems, ye..."*)

### Węzeł `[113]`
Mówca: **Mansoun Leke**
> ""You talk about difficult times, enemies and problems, yet all these are products of the Sordish State!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Mansoun Leke: ""The Bludish people are refraining themselves from turnin..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Mansoun Leke: ""Workers Party of Bludia is a completely legal and democr..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Mansoun Leke: ""It seems Sordland has made its choice again. Any attempt..."*)

### Węzeł `[117]`
Mówca: **Mansoun Leke**
> ""The Bludish people are refraining themselves from turning against those who tortured and humiliated them for decades! We only ask to be properly represented in the Assembly. You say the decree has nothing to do with political agenda. But all we have are fingers being pointed out again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[118]`
Mówca: **Mansoun Leke**
> ""Workers Party of Bludia is a completely legal and democratic party that's being supported by millions of Bludish people! I condemn this State for silencing another democratic party again!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Mansoun Leke: ""It seems Sordland has made its choice again. Any attempt..."*)

### Węzeł `[119]`
Mówca: **Mansoun Leke**
> ""It seems Sordland has made its choice again. Any attempt to turn back the wheels of time will be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Mansoun Leke: ""We the Bludish people... and the democratic socialists a..."*)

### Węzeł `[120]`
Mówca: **Mansoun Leke**
> ""We the Bludish people... and the democratic socialists are aware that one cannot eliminate the realities of power politics by the simple act of legal protests. We now see the reality of your present rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Mansoun Leke: ""But the people’s sense of justice also wields political ..."*)

### Węzeł `[121]`
Mówca: **Mansoun Leke**
> ""But the people’s sense of justice also wields political power, Mr. President! And we will never stop appealing to this sense of justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Gloria Tory: ""Order, Mr. Leke! Try to refrain from speaking out of turn.""*)

### Węzeł `[122]`
Mówca: **Gloria Tory**
> ""Order, Mr. Leke! Try to refrain from speaking out of turn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""You have it all wrong, Mr. Leke.""*)
  - -> `[124]` (*Player: ""Are you implying violence against the State!?""*)
  - -> `[126]` (*Player: ""Are you giving support to the separatists?""*)
  - -> `[125]` (*Player: ""This has nothing to do with race.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""You have it all wrong, Mr. Leke.""]** — Mówca: **Player**
> ""You have it all wrong, Mr. Leke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Mansoun Leke: ""We know how you rule, Mr. President! God save us all.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Are you implying violence against the State!?""]** — Mówca: **Player**
> ""Are you implying violence against the State!?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Mansoun Leke: ""Go ahead, create any reason to prosecute me too!""*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""This has nothing to do with race.""]** — Mówca: **Player**
> ""This has nothing to do with race.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Mansoun Leke: ""We know how you rule, Mr. President! God save us all.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""Are you giving support to the separatists?""]** — Mówca: **Player**
> ""Are you giving support to the separatists?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Mansoun Leke: ""Go ahead, create any reason to prosecute me too!""*)

### Węzeł `[127]`
Mówca: **Mansoun Leke**
> ""We know how you rule, Mr. President! God save us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Gloria Tory: ""Order! This issue has been settled.""*)

### Węzeł `[128]`
Mówca: **Mansoun Leke**
> ""Go ahead, create any reason to prosecute me too!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Gloria Tory: ""Order! This issue has been settled.""*)

### Węzeł `[129]`
Mówca: **Gloria Tory**
> ""Order! This issue has been settled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Gloria Tory: ""We will be moving on to the next topic...""*)

### Węzeł `[130]`
Mówca: **Gloria Tory**
> ""We will be moving on to the next topic...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Gloria did her best to bring order back to the Assembly a..."*)

### Węzeł `[131]`
Mówca: **Mansoun Leke**
> ""The people’s sense of justice also wields political power, Mr. President! And we will never stop appealing to this sense of justice!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "I felt back at ease as soon as I left the Assembly's chao..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "I barely heard Mansoun Leke yelling behind me right when I walked out the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Mansoun Leke: ""The people’s sense of justice also wields political powe..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "It was a tough session but the opposition failed to revoke the emergency decree in the end, which worked perfectly for us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "However, Frens was going to disrupt the decree by going t..."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "However, Frens was going to disrupt the decree by going to the Court. If Orso's promise could be trusted, that would not create issues for us, but I still couldn't keep myself from worrying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_R_EmergencyDebate = true; Bas..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "I felt back at ease as soon as I left the Assembly's chaos behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "It was a tough session but the opposition failed to revok..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""The emergency was a hard decision to make but it was needed.""]** — Mówca: **Player**
> ""The emergency was a hard decision to make but it was needed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gloria Tory: ""I have to let Mr. Ricter continue, Mr. President.""*)

### Węzeł `[137]`
Mówca: **Narrator**
> "Gloria did her best to bring order back to the Assembly and proceed with the schedule."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "After the session, I finally felt at ease when I left the..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "After the session, I finally felt at ease when I left the chaos of the Assembly behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "It was a tough session but the opposition failed to revok..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_TradeDeal == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_TradeDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Uziren_BorderReport = true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_TradeDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Uziren_BorderReport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_BorderReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_A_Speech = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_A_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_R_EmergencyDebate = true;
BaseGameSupport.News_Turn05_HP_EmergencyDebate = true;
BaseGameSupport.News_Turn05_LT_EmergencyReview = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_R_EmergencyDebate"] = true;
Variable["BaseGameSupport.News_Turn05_HP_EmergencyDebate"] = true;
Variable["BaseGameSupport.News_Turn05_LT_EmergencyReview"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gloria Tory: ""I'm sorry to interrupt, Mr. Ricter, but the President ha..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Gloria Tory: ""Mr. President... Please.""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted == true"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted == true)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Shout_No..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded == true"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded == ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Respond_..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Shout_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Shout_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Respond_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Respond_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_TradeDeal == true"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Agnolia_HeljilandRecognised == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Agnolia_HeljilandRecognised == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Agnolia_HeljilandRecognised == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy = true"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Agnolia_HeljilandRecognised == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn05_G_WalkerWarnsNavy = true"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_A_Speech = true"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn05_G_WalkerWarnsNavy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_WalkerWarnsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_A_Speech = true"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyLaughter");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyLaughter");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "One man from the USP seats yelled: "in your dreams!" It m..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("AssemblyApplause2");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("AssemblyApplause2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Loud applauses came from the opposition."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("GavelBang");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("GavelBang");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Suddenly Gloria's gavel echoed in the hall, which elimina..."*)
