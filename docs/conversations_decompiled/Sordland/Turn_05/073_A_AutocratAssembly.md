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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 13

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGameSupport.News_Turn05_G_WalkerWarnsNavy`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[142]` (Gloria Tory): `Variable["BaseGameSupport.Report_Turn05_Uziren_BorderReport"] = true;`
- Węzeł `[143]` (Gloria Tory): `Variable["GameCondition.Turn05_A_Speech"] = true;`
- Węzeł `[144]` (Gloria Tory): `Variable["BaseGameSupport.News_Turn05_R_EmergencyDebate"] = true; Variable["BaseGameSupport.News_...`
- Węzeł `[145]` (Gloria Tory): `Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded"] = true;`
- Węzeł `[146]` (Gloria Tory): `Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted"] = true;`
- Węzeł `[156]` (Gloria Tory): `Variable["BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Shout_NoDeal"] = true;`
- Węzeł `[157]` (Gloria Tory): `Variable["BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Respond_NoDeal"] = true;`
- Węzeł `[161]` (Gloria Tory): `Variable["BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy"] = true;`
- *...oraz 5 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Gloria Tory)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "A session of the Grand National Assembly was in order because of the continued discussion about the emergency. The opposition wanted to declare it null and void."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I was seated in one of the seats reserved for the council of ministers, which was positioned slightly higher than the rest of the seats and had an angle that made for a clear view of the whole place."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I glanced down at the USP seats and casually watched the people inside as Gloria announced the next speaker before the vote to revoke the decree."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Gloria Tory**
> ""Mr. Frens Ricter from the People's Freedom and Justice Party has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Frens Ricter**
> ""Ladies and Gentlemen! A devastating picture has often been painted of the state of affairs prevailing in Sordland today. As always in such cases, there is no lack of exaggeration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Frens Ricter**
> ""Considering the extreme measures being taken that completely sets aside our freedoms, no one can fairly demand or expect of us to accept this extension of the Emergency Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Frens Ricter**
> ""The elections of December have resulted in a majority for the USP and thus given Mr. Rayne the opportunity to govern, strictly as laid down in the intention of the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Frens Ricter**
> ""But where this opportunity is given, it is coupled with obligations. Respecting the laws and listening to criticism is necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Frens Ricter**
> ""Not only the Assembly's opinion was not asked, the reasons for the emergency nor its extension were not justified!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Frens Ricter**
> ""The President clearly has ideological intentions. This decree was an attempt to destroy the Socialist Movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Frens Ricter**
> ""This decree was a declaration of war against the Bludish people. The President does not even shy away from using divisive words. He has political intentions which will have grave consequences for our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Frens Ricter**
> ""Mr. Rayne is exploiting the shooting of Bernard Circas and using this to his advantage to give us all these lies about national security threats!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Frens Ricter**
> ""Ladies and Gentlemen of the United Sordland Party! You have claimed to have reformed the party and promised to bring the change people have been asking for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Frens Ricter**
> ""Yet while the workers, the peasants, the whitecollar employees, the civil servants, or the businessmen of Sordland have their own troubles and demands from us, you go about fighting wars with enemies that don't exist!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Frens Ricter**
> ""Everybody expected of you to rewrite the outdated Constitution of Tarquin Soll. Now we have an emergency on our hands, which is fabricated to create a justification for the lack of reforms of the government. And their apparent hunger for authority!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Loud applauses came from the opposition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`
  - -> `[30]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "Ask Gloria for a moment to respond."]** — Mówca: **Player_Italic**
> "I gestured at Gloria to ask for an opportunity to respond to Frens Ricter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I kept watching Frens Ricter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "Stand up and yell at him."]** — Mówca: **Player_Italic**
> "I stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "I shouted at him in protest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`
  - -> `[51]`
  - -> `[52]`

### Węzeł `[32]`
Mówca: **Frens Ricter**
> ""I ask for my honorable colleagues to support the PFJP in revoking this emergency, here and now!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[33]`
Mówca: **Gloria Tory**
> ""I'm sorry to interrupt, Mr. Ricter, but the President has asked for an opportunity to respond. You have directly addressed the President in your speech, so I shall give him the opportunity to give a brief response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Narrator**
> "Gloria looked at me and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[35]`
Mówca: **Gloria Tory**
> ""The President has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`
  - -> `[38]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Mr. Ricter, you speak of pure slander. There are no political intentions...""]** — Mówca: **Player**
> ""Mr. Ricter, you speak of pure slander. There are no political intentions behind this decree. It is a national emergency!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""Gentlemen, you're underestimating the threats!""]** — Mówca: **Player**
> ""Gentlemen, you're underestimating the threats!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""Mr. Ricter! Who are you to speak about such things?""]** — Mówca: **Player**
> ""Mr. Ricter! Who are you to speak about such things?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Frens laughed sarcastically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""We will be controlling the situation shortly. Be patient!""]** — Mówca: **Player**
> ""We will be controlling the situation shortly. Be patient!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""We know that Mr. Ricter himself has ties with foreign interests!""]** — Mówca: **Player**
> ""We know that Mr. Ricter himself has ties with foreign interests!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""The State is doing what's best for Sordland.""]** — Mówca: **Player**
> ""The State is doing what's best for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Gloria Tory**
> ""Mr. President, let's keep it brief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[44]`
  - -> `[136]`
  - -> `[45]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""The decree is completely legal.""]** — Mówca: **Player**
> ""The decree is completely legal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
**[WYBÓR GRACZA: ""Don't be fooled by Mr. Ricter's slander. We all know the truth.""]** — Mówca: **Player**
> ""Don't be fooled by Mr. Ricter's slander. We all know the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""This emergency will show us the real traitors among us.""]** — Mówca: **Player**
> ""This emergency will show us the real traitors among us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Gloria Tory**
> ""I have to let Mr. Ricter continue, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Gloria Tory**
> ""Mr. Frens Ricter has the floor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[49]`
**[WYBÓR GRACZA: ""PURE SLANDER!""]** — Mówca: **Player**
> ""PURE SLANDER!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""DON'T WASTE OUR TIME!""]** — Mówca: **Player**
> ""DON'T WASTE OUR TIME!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""WATCH WHAT YOU ARE SAYING!""]** — Mówca: **Player**
> ""WATCH WHAT YOU ARE SAYING!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""VERY CREATIVE!""]** — Mówca: **Player**
> ""VERY CREATIVE!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Frens first looked at me and then at Gloria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[54]`
Mówca: **Gloria Tory**
> ""Mr. President... Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Gloria Tory**
> ""Please continue, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[57]`
Mówca: **Frens Ricter**
> ""Thank you, Mrs. Speaker. I have to say, I deplore the reaction of the President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[59]`
Mówca: **Frens Ricter**
> ""I am talking to the members of the United Sordland Party as well! Do not act partisan in matters with such critical importance. We know that this emergency is a dangerous exaggeration and it can have very grim consequences on our democratic institutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Frens Ricter**
> ""I wish to trust in your judgement and ask for your help in reaching an absolute majority against this decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[61]`
Mówca: **Narrator**
> "One man from the USP seats yelled: "in your dreams!" It made the USP burst in laughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Frens Ricter**
> ""When in fact the Assembly fails to deliver its duties for the good of the Sordish people, I shall be personally making a case to the Supreme Court about the legality of this emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Frens Ricter**
> ""Ladies and Gentlemen! We all know that this emergency is unlawful!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Frens Ricter**
> ""It clearly breaches on the freedoms and rights of men defined in the Section 100 of the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[65]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[68]`
Mówca: **Frens Ricter**
> ""It breaches on the right for a fair trial by giving the State the right to detain anyone without a trial. This is a breach on democracy as well as the freedoms of men defined in the Section 100 of the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Frens Ricter**
> ""Sordland is being practically transformed into a police state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Frens Ricter**
> ""It also denies people's right to assemble in protest. This is a clear breach of freedom of expression and freedom of speech!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Frens Ricter**
> ""According to the Constitution, these rights can not be suspended under any other circumstances than being under invasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Frens Ricter**
> ""Do any of you see any Rumburgian tanks in Sordland? Are we under bombardment? There is nobody attacking but the State! They are persecuting thousands of innocents under national security threats! Who will stop the President from prosecuting all who oppose him tomorrow?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Frens Ricter**
> ""The State is acting illegally! I hereby invite the Supreme Court to duty and ask for them to subject this decree to a proper judicial review and revoke it before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
Mówca: **Frens Ricter**
> ""I hail those who are persecuted and in despair. We hail the strong Sordish opposition. Their steadfastness and loyalty are worthy of acclaim. The courage of their convictions, their unbroken faith - are the guarantees of a brighter future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[78]`
Mówca: **Frens Ricter**
> ""No decree can give you the power to destroy ideas which are eternal and indestructible!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[79]`
Mówca: **Frens Ricter**
> ""We must adhere to the basic principles of a constitutional state, to the equality of rights, and the concept of social legislation anchored therein. I ask everybody's support in the upcoming vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Frens Ricter**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "Mr. Ricter walked back to his seat among applauses from his party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Gloria Tory**
> ""Next, the Assembly will vote on PFJP's demand to revoke the validity of the emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Gloria Tory**
> ""According to the Constitution, the Assembly requires at least two-thirds majority to revoke an emergency declared by the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[84]`
Mówca: **Gloria Tory**
> ""We have 131 ayes and 119 nays.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[85]`
Mówca: **Frens Ricter**
> ""Mr. President spoke nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[86]`
Mówca: **Narrator**
> "People started to get up from their seats to take the envelopes and cast their votes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`
  - -> `[88]`

### Węzeł `[87]`
**[WYBÓR GRACZA: "Keep sitting."]** — Mówca: **Player_Italic**
> "I kept sitting and did not go out to cast a vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "Go to cast a vote."]** — Mówca: **Player_Italic**
> "I stood up to join the voting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Narrator**
> "I grabbed the envelope and prepared my vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "Vote aye for the fun of it."]** — Mówca: **Player_Italic**
> "I voted for it believing that it would not succeed anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "Vote no."]** — Mówca: **Player_Italic**
> "I casted my vote against it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Narrator**
> "I watched as everybody voted one by one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Some time has passed when the votes were counted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Suddenly Gloria's gavel echoed in the hall, which eliminated the carefree attitude that lurked after the voting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[95]`
Mówca: **Gloria Tory**
> ""Ayes does not exceed the two-third threshold, so the nays have it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Narrator**
> "PFJP members started making noises."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "Ask to speak."]** — Mówca: **Player_Italic**
> "I asked to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[98]`
Mówca: **Narrator**
> "A lot of people including Frens Ricter demanded to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Gloria Tory**
> ""Yes, Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Frens looked directly at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[101]`
Mówca: **Narrator**
> "He turned around and went back to his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[102]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "Leave the Assembly."]** — Mówca: **Player_Italic**
> "I stood up and walked towards the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Narrator**
> "The whole Assembly watched behind me as I walked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[104]`
Mówca: **Gloria Tory**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`
  - -> `[107]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""I want to thank the members of the Assembly...""]** — Mówca: **Player**
> ""I want to thank the members of the Assembly for their support in the State's measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Let us try to be more civil towards each other...""]** — Mówca: **Player**
> ""Let us try to be more civil towards each other in these difficult times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Mr. Ricter, you cannot stand against the USP.""]** — Mówca: **Player**
> ""Mr. Ricter, you cannot stand against the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Frens watched me with no emotions in his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""I condemn Mr. Ricter's empathy and support for the prosecuted.""]** — Mówca: **Player**
> ""I condemn Mr. Ricter's empathy and support for the prosecuted. They are prosecuted for their crimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""Let's put this behind us, we must not deviate from the real enemy!""]** — Mówca: **Player**
> ""Let's put this behind us, we must not deviate from the real enemy!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""Rest assured, we will handle all the problems.""]** — Mówca: **Player**
> ""Rest assured, we will handle all the problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Narrator**
> "Mansoun Leke interrupted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Mansoun Leke**
> ""You talk about difficult times, enemies and problems, yet all these are products of the Sordish State!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[114]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[116]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
Mówca: **Mansoun Leke**
> ""The Bludish people are refraining themselves from turning against those who tortured and humiliated them for decades! We only ask to be properly represented in the Assembly. You say the decree has nothing to do with political agenda. But all we have are fingers being pointed out again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[118]`
Mówca: **Mansoun Leke**
> ""Workers Party of Bludia is a completely legal and democratic party that's being supported by millions of Bludish people! I condemn this State for silencing another democratic party again!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Mansoun Leke**
> ""It seems Sordland has made its choice again. Any attempt to turn back the wheels of time will be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Mansoun Leke**
> ""We the Bludish people... and the democratic socialists are aware that one cannot eliminate the realities of power politics by the simple act of legal protests. We now see the reality of your present rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Mansoun Leke**
> ""But the people’s sense of justice also wields political power, Mr. President! And we will never stop appealing to this sense of justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Gloria Tory**
> ""Order, Mr. Leke! Try to refrain from speaking out of turn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`
  - -> `[126]`
  - -> `[125]`

### Węzeł `[123]`
**[WYBÓR GRACZA: ""You have it all wrong, Mr. Leke.""]** — Mówca: **Player**
> ""You have it all wrong, Mr. Leke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[124]`
**[WYBÓR GRACZA: ""Are you implying violence against the State!?""]** — Mówca: **Player**
> ""Are you implying violence against the State!?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[125]`
**[WYBÓR GRACZA: ""This has nothing to do with race.""]** — Mówca: **Player**
> ""This has nothing to do with race.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""Are you giving support to the separatists?""]** — Mówca: **Player**
> ""Are you giving support to the separatists?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Mansoun Leke**
> ""We know how you rule, Mr. President! God save us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Mansoun Leke**
> ""Go ahead, create any reason to prosecute me too!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Gloria Tory**
> ""Order! This issue has been settled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Gloria Tory**
> ""We will be moving on to the next topic...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[131]`
Mówca: **Mansoun Leke**
> ""The people’s sense of justice also wields political power, Mr. President! And we will never stop appealing to this sense of justice!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[132]`
Mówca: **Narrator**
> "I barely heard Mansoun Leke yelling behind me right when I walked out the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[133]`
Mówca: **Narrator**
> "It was a tough session but the opposition failed to revoke the emergency decree in the end, which worked perfectly for us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Narrator**
> "However, Frens was going to disrupt the decree by going to the Court. If Orso's promise could be trusted, that would not create issues for us, but I still couldn't keep myself from worrying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[135]`
Mówca: **Narrator**
> "I felt back at ease as soon as I left the Assembly's chaos behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[136]`
**[WYBÓR GRACZA: ""The emergency was a hard decision to make but it was needed.""]** — Mówca: **Player**
> ""The emergency was a hard decision to make but it was needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[137]`
Mówca: **Narrator**
> "Gloria did her best to bring order back to the Assembly and proceed with the schedule."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Narrator**
> "After the session, I finally felt at ease when I left the chaos of the Assembly behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[139]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_TradeDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_TradeDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_TradeDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_TradeDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[142]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Uziren_BorderReport = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_BorderReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[143]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_A_Speech = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_A_Speech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[144]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_R_EmergencyDebate = true;
BaseGameSupport.News_Turn05_HP_EmergencyDebate = true;
BaseGameSupport.News_Turn05_LT_EmergencyReview = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_R_EmergencyDebate"] = true;
Variable["BaseGameSupport.News_Turn05_HP_EmergencyDebate"] = true;
Variable["BaseGameSupport.News_Turn05_LT_EmergencyReview"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[145]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[146]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[147]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[149]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[152]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Shouted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[155]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_A_Autocrat_Ricter_Responded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[156]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Shout_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Shout_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[157]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Respond_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_RayneRicterDebate_Respond_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[158]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_HeljilandRecognised == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_HeljilandRecognised"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[160]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_HeljilandRecognised == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_HeljilandRecognised"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_AgnoliaRamsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[162]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_G_WalkerWarnsNavy = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_WalkerWarnsNavy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[163]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[164]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyLaughter");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyLaughter");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[165]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AssemblyApplause2");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AssemblyApplause2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[166]`
Mówca: **Gloria Tory**
*(Węzeł logiki narracyjnej: PlaySoundEffect("GavelBang");)*
- **Efekt (`userScript`):** `PlaySoundEffect("GavelBang");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
