# Sordland/Turn06/A_DictatorConvinceNFP

- **ID konwersacji:** `82`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/082_A_DictatorConvinceNFP.md`
- **Liczba węzłów dialogowych:** 461
- **Liczba wyborów gracza:** 91

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[50]** Kesaro Kibener

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Decision_Turn03_StabilityOrder_BanBoth`
- `BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth`
- `BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.PersonalWealth`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.Turn06_A_Kesaro_Alliance`
- `BaseGameIsolated.Turn06_A_Kesaro_Ban_RY`
- `BaseGameIsolated.Turn06_A_Kesaro_Bill`
- `BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS`
- `BaseGameIsolated.Turn06_A_Kesaro_Threshold_10`
- `BaseGameIsolated.Turn06_A_Kesaro_Threshold_8`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Reform_Alliance_NFP`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Reform_NFP_Convinced`
- `BaseGame.Relations_Kesaro_Promise_Alliance`
- `BaseGame.Relations_Kesaro_Promise_Bill`
- `BaseGameIsolated.Turn06_A_Kesaro_Alliance`
- `BaseGameIsolated.Turn06_A_Kesaro_Ban_RY`
- `BaseGameIsolated.Turn06_A_Kesaro_Bill`
- `BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS`
- `BaseGameIsolated.Turn06_A_Kesaro_Threshold_10`
- `BaseGameIsolated.Turn06_A_Kesaro_Threshold_8`
- `BaseGameSupport.Journal_Turn06_Kesaro_Alliance`
- `BaseGameSupport.Journal_Turn06_Kesaro_BanRY`
- `BaseGameSupport.Journal_Turn06_Kesaro_Bill`
- `BaseGameSupport.Journal_Turn06_Kesaro_RevertYS`
- `BaseGameSupport.Journal_Turn06_Kesaro_Threshold10`
- `BaseGameSupport.Journal_Turn06_Kesaro_Threshold8`
- `BaseGameSupport.News_Turn06_LT_NFPConvinced`
- `BaseGameSupport.News_Turn06_LT_NFPNotConvinced`
- `BaseGameSupport.News_Turn06_ST_RayneMeetsKibener`
- `BaseGameSupport.News_Turn06_ST_VictoryDay`
- `BaseGameSupport.Report_Turn06_Holsord_NFP_NotConvinced`
- `GameCondition.Turn06_A_Reform`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 32

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Relations_Kesaro_Promise_Alliance`
- `BaseGame.Relations_Kesaro_Promise_Bill`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Kesaro Kibener): `Variable["GameCondition.Turn06_A_Reform"] = true; Variable["BaseGameSupport.News_Turn06_ST_RayneM...`
- Węzeł `[160]` (Kesaro Kibener): `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"] = true;`
- Węzeł `[181]` (Kesaro Kibener): `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_8"] = true;`
- Węzeł `[185]` (Kesaro Kibener): `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"] = true;`
- Węzeł `[293]` (Kesaro Kibener): `Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"] = true;`
- Węzeł `[301]` (Kesaro Kibener): `Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] = true;`
- Węzeł `[327]` (Kesaro Kibener): `Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] = true;`
- Węzeł `[333]` (Kesaro Kibener): `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] = true;`
- *...oraz 24 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Kesaro Kibener)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_A_Reform = true;
BaseGameSupport.News_Turn06_ST_RayneMeetsKibener = true;)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_A_Reform"] = true;
Variable["BaseGameSupport.News_Turn06_ST_RayneMeetsKibener"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The final preparations for Sordland's new Constitution were nearly complete. Soon, it would be presented in the Grand National Assembly; after that, it would be up to the Supreme Court to approve the changes. Including the ones that diminished the Justices' own power."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[5]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_President == true && BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[8]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true && BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Faction_Oligarchs_Content == true && BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[10]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Faction_Oligarchs_Content == true && BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true  and  Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[11]`
**[WYBÓR GRACZA: ""I've been looking forward to speaking with you in private, Mr. Kibener.""]** — Mówca: **Player**
> ""I've been looking forward to speaking with you in private, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Why the delay?""]** — Mówca: **Player**
> ""Why the delay?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[13]`
Mówca: **Narrator**
> "We had strong support in the party and the Assembly, but I wanted a landslide victory in order to force a yes out of the Court. So I had invited Kesaro Kibener, leader of the National Front Party, to have a private chat about my proposal. He was supposed to be in my office 20 minutes ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Good morning, Mr. Kibener.""]** — Mówca: **Player**
> ""Good morning, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
Mówca: **Narrator**
> "The final preparations for Sordland's new Constitution were nearly complete. Soon, it would be presented in the Grand National Assembly; a huge step for our administration. Then it would be on to the Supreme Court."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[16]`
Mówca: **Narrator**
> "I was halfway through my second coffee of the day when Kibener finally entered. He was wearing a brown suit with his party's pin neatly attached. After firmly shaking hands, he sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[11]`
  - -> `[12]`

### Węzeł `[17]`
Mówca: **Narrator**
> "I knew I was on shaky ground with the Assembly. I desperately needed more votes. So I had invited Kesaro Kibener, leader of the National Front Party, to have a private chat about my proposal. He was supposed to be in my office 20 minutes ago."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[18]`
Mówca: **Kesaro Kibener**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[19]`
Mówca: **Kesaro Kibener**
> ""Likewise, President Rayne. We have much to discuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[20]`
Mówca: **Kesaro Kibener**
> ""I was stopped by the police on my way here. I seem to be subject to more and more such 'random' checks these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[21]`
Mówca: **Kesaro Kibener**
> ""I hope you don't mind the slight delay. I was stopped by the police on my way here. I seem to be subject to more and more such 'random' checks these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[22]`
Mówca: **Kesaro Kibener**
> ""Some key figures in my party are also reporting obstructions from the state. It seems that your reforms aren't sitting well with certain members of the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "He pulled out a cigarette along with a Rippo lighter and lit it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`
  - -> `[24]`
  - -> `[25]`
  - -> `[26]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""You didn't even ask me if you could smoke in my office.""]** — Mówca: **Player**
> ""You didn't even ask me if you could smoke in my office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Have you forgotten common courtesy, Mr. Kibener? Are we not offering cigarettes to friends anymore?""]** — Mówca: **Player**
> ""Have you forgotten common courtesy, Mr. Kibener? Are we not offering cigarettes to friends anymore?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Let's get this over with.""]** — Mówca: **Player**
> ""Let's get this over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[27]`
Mówca: **Kesaro Kibener**
> ""Apologies. May I smoke in your office, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Go ahead.""]** — Mówca: **Player**
> ""Go ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[29]`
**[WYBÓR GRACZA: ""No, you may not.""]** — Mówca: **Player**
> ""No, you may not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[30]`
Mówca: **Kesaro Kibener**
> ""Apologies. Here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
Mówca: **Kesaro Kibener**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
Mówca: **Kesaro Kibener**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Our eyes locked. After trying to stare me down for a few moments, Kesaro finally gave in and extinguished his cigarette."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Narrator**
> "He passed a cigarette to me and lit it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "I took a look at his lighter as he put it down on the table. It was a regular Rippo, but the shape appeared to be malformed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Looking more closely, I could see a large circular dent in the chrome plating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[37]`
Mówca: **Kesaro Kibener**
> ""It's a bullet mark.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Kesaro Kibener**
> ""Believe it or not, this lighter is the reason I'm alive today. I should be thankful that the damn assassin was Bludish. No wonder he was incompetent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
Mówca: **Narrator**
> "He pulled on his collar to reveal the scar on his neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Kesaro Kibener**
> ""Maybe I'll tell you the full story some other time. For now, let's talk about our collaboration. I know why you called me here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Kesaro Kibener**
> ""But before we get into the proposal, I'd like to discuss a few topics that I believe to be of higher priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
Mówca: **Kesaro Kibener**
> ""The lighter took the first shot. The second one grazed me right here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[43]`
Mówca: **Kesaro Kibener**
> ""I may not be fond of President Smolak, but our joint operation with the Wehzeks was certainly successful in stamping out the BFF. I consider that a great success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[44]`
Mówca: **Kesaro Kibener**
> ""The Bludish independence movement, for example. Not only do the separatists pose an existential risk to us, they also threaten our neighbors in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[47]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[48]`
Mówca: **Kesaro Kibener**
> ""That brings me to the Religious Harmony Bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[49]`
Mówca: **Kesaro Kibener**
> ""Now, Rumburg will have a harder time trying to influence us from within. Let's not forget their caches of KA-74s in our country. You've done the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[68]`
  - -> `[64]`
  - -> `[61]`

### Węzeł `[50]`
Mówca: **Kesaro Kibener**
> ""That's right. They don't even know whom they are dealing with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[51]`
Mówca: **Kesaro Kibener**
> ""Closing the borders with Wehlen has helped, but the countryside of Nargis and Bergia continues to be plagued by the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[52]`
Mówca: **Kesaro Kibener**
> ""Wehlen continues to be plagued by the BFF. They use their secret bases in the mountains to launch infiltrations into Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[53]`
Mówca: **Kesaro Kibener**
> ""I doubt it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Thanks for the compliment.""]** — Mówca: **Player**
> ""Thanks for the compliment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[55]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[57]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[58]`
Mówca: **Kesaro Kibener**
> ""They are a weaker nation both in heart and might. They won't have the capacity to handle the Bludish threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[59]`
Mówca: **Kesaro Kibener**
> ""Rumburg is using them to weaken us, and they might succeed if we do nothing to stop them. Let's not forget their caches of KA-74s in our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`
  - -> `[66]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""The support President Smolak received from United Contana was a concern, but realpolitik was the victor.""]** — Mówca: **Player**
> ""The support President Smolak received from United Contana was a concern, but realpolitik was the victor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Rumburg and the BFF will both meet a bad end if they dare to divide Sordland.""]** — Mówca: **Player**
> ""Rumburg and the BFF will both meet a bad end if they dare to divide Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""We can't intervene in other countries. It would destabilize the region.""]** — Mówca: **Player**
> ""We can't intervene in other countries. It would destabilize the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Kesaro Kibener**
> ""A Sordish president has to do whatever is necessary to protect his people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Wehlen could be a valuable ally in the future, now that we have established a closer relationship.""]** — Mówca: **Player**
> ""Wehlen could be a valuable ally in the future, now that we have established a closer relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[65]`
Mówca: **Kesaro Kibener**
> ""Rumburg is using them to weaken us. Hopefully, our increased military funding will make sure their efforts won't bear fruit. But we need to stay vigilant. Let's not forget their caches of KA-74s in our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`
  - -> `[66]`

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Wehlen can take care of their own problems, and we will take care of ours.""]** — Mówca: **Player**
> ""Wehlen can take care of their own problems, and we will take care of ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[67]`
Mówca: **Kesaro Kibener**
> ""Their time will come too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[68]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[70]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Military_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[73]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Military_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[74]`
Mówca: **Kesaro Kibener**
> ""Thanks to your support, the BFF and other extremist groups won't be able to use religion to organise and gain support among the common folk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[88]`
  - -> `[85]`

### Węzeł `[75]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[77]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Kesaro Kibener**
> ""But you decided to veto it. Why are you ignoring the problem? The Bludish are using Nurity as a tool in their quest for independence. This is a direct threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[83]`
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Kesaro Kibener**
> ""If anything, we are not restrictive enough. But I will not dive into this further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[80]`
Mówca: **Kesaro Kibener**
> ""In this case, doing nothing is far worse. The BFF is actively using priests in majority-Bludish areas. But let's not get off track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""The bill was practically a recruitment flyer for the BFF. The more of these we pass, the more followers they get.""]** — Mówca: **Player**
> ""The bill was practically a recruitment flyer for the BFF. The more of these we pass, the more followers they get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[82]`
Mówca: **Kesaro Kibener**
> ""Thank you. I led the effort. I was happy but not surprised to receive so much support from my fellow MPs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""It was too restrictive on the Bludish people. I couldn't let it pass.""]** — Mówca: **Player**
> ""It was too restrictive on the Bludish people. I couldn't let it pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[84]`
Mówca: **Kesaro Kibener**
> ""In an ideal world, yes. But as long as the BFF exists, that is not the world we live in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""We need to find a way where we can coexist without violence.""]** — Mówca: **Player**
> ""We need to find a way where we can coexist without violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""The Bludish problem must be solved. We can't have an independence movement inside Sordland.""]** — Mówca: **Player**
> ""The Bludish problem must be solved. We can't have an independence movement inside Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Kesaro Kibener**
> ""I'm glad you and I agree on this issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""It was a well-written and strong bill. It would have been wrong to veto it.""]** — Mówca: **Player**
> ""It was a well-written and strong bill. It would have been wrong to veto it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[89]`
Mówca: **Kesaro Kibener**
> ""Our party and many members of parliament worked extremely hard on the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[90]`
Mówca: **Kesaro Kibener**
> ""Look. I went over your proposed constitutional changes...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Narrator**
> "Kesaro opened his suitcase, took out a folder and put the draft constitution papers on the table. I could see the scribbles he'd made in the margins."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[94]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[97]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[100]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_8 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[101]`
Mówca: **Kesaro Kibener**
> ""An election threshold increase to 15%? Exactly whom do you think you're dealing with here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Kesaro Kibener**
> ""You do realize the NFP's current share of the vote is under this threshold, don't you? You're attempting to get my party to participate in its own destruction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Kesaro Kibener**
> ""You know that I will fight this until my last breath if I have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Kesaro Kibener**
> ""So I am asking you now. What did you even call me here for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`
  - -> `[107]`
  - -> `[297]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""To find a middle ground. Scratch my back and I will scratch yours.""]** — Mówca: **Player**
> ""To find a middle ground. Scratch my back and I will scratch yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""]** — Mówca: **Player**
> ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Just to have a chat.""]** — Mówca: **Player**
> ""Just to have a chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[108]`
Mówca: **Kesaro Kibener**
> ""If you want me to even consider supporting you, you will change the draft and you will change it now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[109]`
  - -> `[111]`
  - -> `[297]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""What do you have in mind?""]** — Mówca: **Player**
> ""What do you have in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""I will not change anything in the draft. I have already decided on these points.""]** — Mówca: **Player**
> ""I will not change anything in the draft. I have already decided on these points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""Fine. I will change the election threshold in return for your support.""]** — Mówca: **Player**
> ""Fine. I will change the election threshold in return for your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Kesaro Kibener**
> ""You will keep the election threshold where it has always been, at 10%.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[113]`
Mówca: **Kesaro Kibener**
> ""Then there is no point in continuing this conversation, is there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[114]`
Mówca: **Kesaro Kibener**
> ""Before I go, I guarantee you this. That proposal will not pass the Assembly. I will make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[115]`
Mówca: **Kesaro Kibener**
> ""Good luck, Mr. President. You're bound to need it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""Very well. You will get what you want. The election threshold will remain the same.""]** — Mówca: **Player**
> ""Very well. You will get what you want. The election threshold will remain the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[117]`
Mówca: **Kesaro Kibener**
> ""Anything other than that, and you can kiss our support goodbye. In fact, the NFP will fight very hard to prevent this bill from passing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[118]`
  - -> `[116]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""Then try your best to fight the bill, Kesaro. You won't get far.""]** — Mówca: **Player**
> ""Then try your best to fight the bill, Kesaro. You won't get far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Kesaro Kibener**
> ""If you only knew how many times I've heard that. Yet look where I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[120]`
Mówca: **Kesaro Kibener**
> ""We are done here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[121]`
Mówca: **Kesaro Kibener**
> ""Very good. Now we are getting somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[122]`
Mówca: **Kesaro Kibener**
> ""An election threshold decrease to 3%? Exactly whom do you think you're dealing with here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Kesaro Kibener**
> ""Don't you understand what will happen when you decrease the threshold? Our Assembly will be overrun with Bludish and communist traitors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Kesaro Kibener**
> ""What is next? A Bludish quota in the Assembly? A Bludish revolution? Handing our country over to *them*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Kesaro Kibener**
> ""You know that I will fight this until my last breath if I have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Kesaro Kibener**
> ""So I am asking you now. What did you even call me here for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`
  - -> `[129]`

### Węzeł `[127]`
Mówca: **Narrator**
> "Kesaro stood up and looked down at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[128]`
Mówca: **Narrator**
> "Kesaro stood up and looked down at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Just to have a chat.""]** — Mówca: **Player**
> ""Just to have a chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""To find a middle ground. Scratch my back and I will scratch yours.""]** — Mówca: **Player**
> ""To find a middle ground. Scratch my back and I will scratch yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""]** — Mówca: **Player**
> ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Kesaro Kibener**
> ""If you want me to even *consider* supporting you, you will change the draft and you will change it now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[135]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Kesaro Kibener**
> ""From the looks of it, you want to do a lot more good for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Fine. I will change the election threshold in return for your support.""]** — Mówca: **Player**
> ""Fine. I will change the election threshold in return for your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
**[WYBÓR GRACZA: ""What do you have in mind?""]** — Mówca: **Player**
> ""What do you have in mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Kesaro Kibener**
> ""You will keep the election threshold where it has always been, at 10%.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Kesaro Kibener**
> ""Anything other than that, and you can kiss our support goodbye. In fact, the NFP will fight very hard to prevent this bill from passing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[166]`
  - -> `[139]`
  - -> `[140]`

### Węzeł `[138]`
Mówca: **Kesaro Kibener**
> ""Very good. Now we are getting somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[139]`
**[WYBÓR GRACZA: ""Very well. You will get what you want. The threshold will remain the same.""]** — Mówca: **Player**
> ""Very well. You will get what you want. The threshold will remain the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[140]`
**[WYBÓR GRACZA: ""I can go up to 8% and that is my final offer. Take it or get out of my office.""]** — Mówca: **Player**
> ""I can go up to 8% and that is my final offer. Take it or get out of my office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Narrator**
> "He stroked his chin and paused before answering."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Kesaro Kibener**
> ""I am fine with it as long as I get something else out of the deal. And that depends on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[143]`
Mówca: **Kesaro Kibener**
> ""An election threshold decrease to 8%? Exactly whom do you think you're dealing with here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Kesaro Kibener**
> ""Don't you understand what will happen when you decrease the threshold? Our Assembly will be overrun with Bludish and communist traitors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Kesaro Kibener**
> ""What is next? A Bludish quota in the Assembly? A Bludish revolution? Handing our country over to *them*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Kesaro Kibener**
> ""So I am asking you now. What did you even call me here for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[149]`
  - -> `[148]`

### Węzeł `[147]`
**[WYBÓR GRACZA: ""To find a middle ground. Scratch my back and I will scratch yours.""]** — Mówca: **Player**
> ""To find a middle ground. Scratch my back and I will scratch yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Just to have a chat.""]** — Mówca: **Player**
> ""Just to have a chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""]** — Mówca: **Player**
> ""I need you to help me, Kesaro. With your support, we can do a lot of good for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
Mówca: **Kesaro Kibener**
> ""I've heard that enough in my life to know that it doesn't work that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[151]`
Mówca: **Kesaro Kibener**
> ""Then let's have a chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[152]`
Mówca: **Kesaro Kibener**
> ""I've heard that enough in my life to know that it doesn't work that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[153]`
Mówca: **Kesaro Kibener**
> ""From the looks of it, you want to do a lot more good for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[154]`
Mówca: **Kesaro Kibener**
> ""Then let's have a chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[155]`
Mówca: **Kesaro Kibener**
> ""I've heard that enough in my life to know that it doesn't work that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[156]`
Mówca: **Kesaro Kibener**
> ""From the looks of it, you want to do a lot more good for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[157]`
Mówca: **Kesaro Kibener**
> ""Then let's have a chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[158]`
Mówca: **Kesaro Kibener**
> ""But fine. It's only 2%.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Kesaro Kibener**
> ""I am fine with it as long as I get something else out of the deal. And that depends on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[160]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[161]`
Mówca: **Kesaro Kibener**
> ""I am not that worried about the rest of the contents in the constitutional changes in principle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[162]`
**[WYBÓR GRACZA: ""Would a loaded check in your name change your mind, perhaps?" [Bribe]"]** — Mówca: **Player**
> ""Would a loaded check in your name change your mind, perhaps?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Kesaro Kibener**
> ""Who do you take me for? Frens Ricter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Kesaro Kibener**
> ""You are offending me if you think I can be bought with such a simple thing as money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Kesaro Kibener**
> ""Shame on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[139]`
  - -> `[140]`

### Węzeł `[166]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[168]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[169]`
**[WYBÓR GRACZA: ""Would a loaded check in your name change your mind, perhaps?" [Bribe]"]** — Mówca: **Player**
> ""Would a loaded check in your name change your mind, perhaps?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[170]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[172]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[173]`
Mówca: **Kesaro Kibener**
> ""Who do you take me for? Frens Ricter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Kesaro Kibener**
> ""You are offending me if you think I can be bought with such a simple thing as money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Kesaro Kibener**
> ""Shame on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[116]`

### Węzeł `[176]`
Mówca: **Kesaro Kibener**
> ""I don't see many problems with the draft, honestly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[177]`
Mówca: **Kesaro Kibener**
> ""As I mentioned, there are more pressing situations in Sordland right now. The BFF isn't even the half of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[180]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[181]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_8"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[182]`
Mówca: **Kesaro Kibener**
> ""Your outrageous decision to ban the Young Sords, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Kesaro Kibener**
> ""You have unfairly attacked a perfectly legal entity. One of the oldest organisations in this country, in fact, founded solely to defend pure Sordish values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Kesaro Kibener**
> ""How many patriots have been prosecuted while the communists and United Contanan moles get free rein?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[185]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[186]`
Mówca: **Kesaro Kibener**
> ""But let me put it simply. If you want my help, you will reverse the ban on the Young Sords immediately. Otherwise, we are done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[206]`
  - -> `[208]`

### Węzeł `[187]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[190]`
Mówca: **Kesaro Kibener**
> ""Your outrageous decision to ban the Young Sords, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Kesaro Kibener**
> ""You have unfairly attacked a perfectly legal entity. One of the oldest organisations in this country, in fact, founded solely to defend pure Sordish values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Kesaro Kibener**
> ""I don't know who put it in your mind that this would resolve the political violence. You ought to pick your advisors more carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[193]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[195]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[196]`
Mówca: **Kesaro Kibener**
> ""The nationalists did not start this violence. It was the reds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[197]`
Mówca: **Kesaro Kibener**
> ""I don't know who put it in your mind that this would resolve the political violence. You ought to pick your advisors more carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[198]`
Mówca: **Kesaro Kibener**
> ""The nationalists did not start this violence. It was the reds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[199]`
Mówca: **Kesaro Kibener**
> ""There's the matter of the communists. Those damn rats are everywhere I look, trying to sneak into Sordish society from the crevices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Kesaro Kibener**
> ""You get rid of one, ten more appear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[201]`
Mówca: **Kesaro Kibener**
> ""In the face of the political violence engulfing this country, your refusal to take action speaks multitudes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[202]`
Mówca: **Kesaro Kibener**
> ""The damn communist rats are everywhere I look, trying to sneak into Sordish society from the crevices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Kesaro Kibener**
> ""But I will say this. The Red Youth have done enough damage to Sordland. They must be stopped before they can do more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[204]`
Mówca: **Kesaro Kibener**
> ""You get rid of one, ten more appear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Kesaro Kibener**
> ""So if you want my help, you need to act. I want you to ban the Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`
  - -> `[325]`

### Węzeł `[206]`
**[WYBÓR GRACZA: ""Absolutely not. I made that decision for a reason. I can't risk violence on the streets again.""]** — Mówca: **Player**
> ""Absolutely not. I made that decision for a reason. I can't risk violence on the streets again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[207]`
**[WYBÓR GRACZA: ""If that is what it takes, then consider the Young Sords un-banned.""]** — Mówca: **Player**
> ""If that is what it takes, then consider the Young Sords un-banned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[208]`
**[WYBÓR GRACZA: ""Please, be reasonable. Is there anything else I can offer you? What else do you want?""]** — Mówca: **Player**
> ""Please, be reasonable. Is there anything else I can offer you? What else do you want?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[209]`
Mówca: **Kesaro Kibener**
> ""But I assure you, the rest of the Assembly will be worried. Very worried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Kesaro Kibener**
> ""If you don't have my backing, there is no way you can ever hope to pass this bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Kesaro Kibener**
> ""That's why I want you to listen to me very carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[212]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[214]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[218]`
Mówca: **Kesaro Kibener**
> ""But it's no wonder a decision like this came from an ex-Red Youth member. You must still have your sympathies for them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[219]`
Mówca: **Kesaro Kibener**
> ""What I am most surprised about is how an ex-Young Sords member can make a decision like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[220]`
**[WYBÓR GRACZA: ""His beliefs have not changed.""]** — Mówca: **Player**
> ""His beliefs have not changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[221]`
**[WYBÓR GRACZA: ""He has gotten wiser.""]** — Mówca: **Player**
> ""He has gotten wiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[222]`
**[WYBÓR GRACZA: ""I see the truth now.""]** — Mówca: **Player**
> ""I see the truth now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[223]`
Mówca: **Kesaro Kibener**
> ""Where is the man who once stood with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`
  - -> `[220]`

### Węzeł `[224]`
Mówca: **Kesaro Kibener**
> ""So you decided to actively undermine your own nation in favor of Malenyevism and other dangerous foreign exports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[226]`
  - -> `[227]`

### Węzeł `[225]`
**[WYBÓR GRACZA: ""Careful, Kesaro. Watch your words.""]** — Mówca: **Player**
> ""Careful, Kesaro. Watch your words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[226]`
**[WYBÓR GRACZA: ""I am not the man I once was. I know better now.""]** — Mówca: **Player**
> ""I am not the man I once was. I know better now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[227]`
**[WYBÓR GRACZA: ""We are not here to talk about our personal beliefs.""]** — Mówca: **Player**
> ""We are not here to talk about our personal beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[228]`
Mówca: **Narrator**
> "Kesaro clenched his fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[230]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[231]`
**[WYBÓR GRACZA: ""We are not here to talk about our personal beliefs.""]** — Mówca: **Player**
> ""We are not here to talk about our personal beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[232]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[234]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[237]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[238]`
Mówca: **Kesaro Kibener**
> ""You would sell out your own movement for your own good, wouldn't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[248]`
  - -> `[231]`

### Węzeł `[239]`
Mówca: **Kesaro Kibener**
> ""But it's no wonder a decision like this came from an ex-Red Youth member. You are all the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[240]`
**[WYBÓR GRACZA: ""Careful, Kesaro. Watch your words.""]** — Mówca: **Player**
> ""Careful, Kesaro. Watch your words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[241]`
Mówca: **Kesaro Kibener**
> ""What I am most surprised about is how an ex-Young Sords member can make a decision like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Kesaro Kibener**
> ""Where is the man who believed in our ideals back then? Where is the man who would fight for his brothers and sisters?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[244]`
  - -> `[247]`

### Węzeł `[243]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[244]`
**[WYBÓR GRACZA: ""I see the truth now.""]** — Mówca: **Player**
> ""I see the truth now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[245]`
Mówca: **Narrator**
> "Kesaro clenched his fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[246]`
**[WYBÓR GRACZA: ""He has gotten wiser.""]** — Mówca: **Player**
> ""He has gotten wiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[247]`
**[WYBÓR GRACZA: ""His beliefs have not changed.""]** — Mówca: **Player**
> ""His beliefs have not changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[248]`
**[WYBÓR GRACZA: ""I am not the man I once was. I know better now.""]** — Mówca: **Player**
> ""I am not the man I once was. I know better now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[249]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[250]`
**[WYBÓR GRACZA: ""I am not the man I once was. I know better now.""]** — Mówca: **Player**
> ""I am not the man I once was. I know better now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[251]`
**[WYBÓR GRACZA: ""We are not here to talk about our personal beliefs.""]** — Mówca: **Player**
> ""We are not here to talk about our personal beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[252]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[254]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[257]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[258]`
Mówca: **Kesaro Kibener**
> ""I suppose when a man gets older, he renounces the foolishness of his youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[250]`
  - -> `[251]`

### Węzeł `[259]`
Mówca: **Kesaro Kibener**
> ""The decision was quite a pleasant surprise for me, really. Knowing you used to support the reds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[260]`
**[WYBÓR GRACZA: ""Careful, Kesaro. Watch your words.""]** — Mówca: **Player**
> ""Careful, Kesaro. Watch your words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[261]`
Mówca: **Kesaro Kibener**
> ""It is no surprise, really. This sort of proactive move is exactly what I'd expect from a fellow former Young Sord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[262]`
  - -> `[264]`

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Anything for the movement.""]** — Mówca: **Player**
> ""Anything for the movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[263]`
**[WYBÓR GRACZA: ""Thank you, Kesaro.""]** — Mówca: **Player**
> ""Thank you, Kesaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[264]`
**[WYBÓR GRACZA: ""I did it for the Sordish citizens. Nothing else.""]** — Mówca: **Player**
> ""I did it for the Sordish citizens. Nothing else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[265]`
Mówca: **Kesaro Kibener**
> ""But we will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[266]`
Mówca: **Kesaro Kibener**
> ""I don't know who put it in your mind that this would resolve the political violence, but you sure ought to pick your advisors more carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[267]`
Mówca: **Kesaro Kibener**
> ""But I must give you credit. You have done well to curb the violence by banning the Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[268]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[269]`
**[WYBÓR GRACZA: ""We are not here to talk about our personal beliefs.""]** — Mówca: **Player**
> ""We are not here to talk about our personal beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[270]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Nationalist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[272]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Nationalist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_University_Political_Socialist == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_University_Political_Socialist == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[276]`
Mówca: **Kesaro Kibener**
> ""But it's no wonder a former Red Youth member would falter like this. You are all the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[283]`
  - -> `[269]`

### Węzeł `[277]`
**[WYBÓR GRACZA: ""Careful, Kesaro. Watch your words.""]** — Mówca: **Player**
> ""Careful, Kesaro. Watch your words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[278]`
Mówca: **Kesaro Kibener**
> ""What I am most surprised about is how an ex-Young Sords member can simply sit by like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Kesaro Kibener**
> ""Where is the man who once stood with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[280]`
  - -> `[282]`

### Węzeł `[280]`
**[WYBÓR GRACZA: ""I see the truth now.""]** — Mówca: **Player**
> ""I see the truth now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[281]`
**[WYBÓR GRACZA: ""He has gotten wiser.""]** — Mówca: **Player**
> ""He has gotten wiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[282]`
**[WYBÓR GRACZA: ""His beliefs have not changed.""]** — Mówca: **Player**
> ""His beliefs have not changed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[283]`
**[WYBÓR GRACZA: ""I am not the man I once was. I know better now.""]** — Mówca: **Player**
> ""I am not the man I once was. I know better now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[284]`
Mówca: **Narrator**
> "Kesaro clenched his fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[285]`
Mówca: **Kesaro Kibener**
> ""I don't know who put it in your mind that doing nothing would resolve the violence, but you sure ought to pick your advisors more carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Kesaro Kibener**
> ""We will continue this conversation later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[287]`
Mówca: **Kesaro Kibener**
> ""I told you, Mr. President. This is the least you can offer. If you can't do it, forget about my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[288]`
Mówca: **Kesaro Kibener**
> ""Then there's no point in continuing this conversation, is there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Narrator**
> "Kesaro stood up and looked down at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Kesaro Kibener**
> ""Before I go, I guarantee you this. That bill will not pass the Assembly. I will make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[291]`
**[WYBÓR GRACZA: ""All right. I will reverse the ban.""]** — Mówca: **Player**
> ""All right. I will reverse the ban.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
**[WYBÓR GRACZA: ""I'm afraid I have to decline.""]** — Mówca: **Player**
> ""I'm afraid I have to decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[293]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[294]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: KesaroLeaves)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[295]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: Jump to: [KesaroLeaves])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[296]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: Jump to: [KesaroLeaves])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[297]`
**[WYBÓR GRACZA: ""I'm offering an alliance between the USP and NFP. You will not be affected by the threshold.""]** — Mówca: **Player**
> ""I'm offering an alliance between the USP and NFP. You will not be affected by the threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Kesaro Kibener**
> ""I see. An alliance, you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Kesaro Kibener**
> ""You do know how to make a deal exciting, Mr. President. The new threshold would definitely keep the commies and the Bluds out of the Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Narrator**
> "He stroke his chin for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Alliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Kesaro Kibener**
> ""I can get behind it. But I will have to work hard to convince the NFP. I assume you will do the same with your party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Kesaro Kibener**
> ""Let's just say that it is on the table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[304]`
Mówca: **Kesaro Kibener**
> ""That's what I like to hear. Now...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[305]`
Mówca: **Kesaro Kibener**
> ""You're welcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[306]`
Mówca: **Kesaro Kibener**
> ""Good to see that the fire still burns inside you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[307]`
Mówca: **Kesaro Kibener**
> ""That's exactly what the Young Sords was founded for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[308]`
Mówca: **Kesaro Kibener**
> ""I mean no offense, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[309]`
Mówca: **Kesaro Kibener**
> ""Good. We all must continue learning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[310]`
Mówca: **Kesaro Kibener**
> ""I hope you don't mean that politics is separate from personal beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[311]`
Mówca: **Kesaro Kibener**
> ""If you did, I would have to take back my compliment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[312]`
Mówca: **Kesaro Kibener**
> ""There's the matter of the communists. Those damn rats are everywhere I look, trying to sneak into Sordish society from the crevices.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Kesaro Kibener**
> ""You get rid of one, ten more appear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Kesaro Kibener**
> ""To me, this is a problem that needs to be solved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Kesaro Kibener**
> ""I want you to ban the Red Youth. Sordland has suffered enough from the disease these rats bring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`
  - -> `[325]`

### Węzeł `[316]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[318]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_StabilityOrder_BanYoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[319]`
Mówca: **Kesaro Kibener**
> ""While you're in such an agreeable mood, I do have another suggestion...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[320]`
Mówca: **Kesaro Kibener**
> ""If you can't do either one, say goodbye to your reform package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[338]`
  - -> `[331]`
  - -> `[321]`

### Węzeł `[321]`
**[WYBÓR GRACZA: ""I've heard enough. You can't make such demands of the President of Sordland!""]** — Mówca: **Player**
> ""I've heard enough. You can't make such demands of the President of Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[322]`
Mówca: **Kesaro Kibener**
> ""I knew we could find some common ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[323]`
**[WYBÓR GRACZA: ""Message received. If that's what it takes, I will ban the Red Youth.""]** — Mówca: **Player**
> ""Message received. If that's what it takes, I will ban the Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[324]`
**[WYBÓR GRACZA: ""Absolutely not. I left them alone for a reason. I can't risk violence on the streets again.""]** — Mówca: **Player**
> ""Absolutely not. I left them alone for a reason. I can't risk violence on the streets again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[325]`
**[WYBÓR GRACZA: ""I'm sorry, but I can't do that. Surely there must be something else I can offer you?""]** — Mówca: **Player**
> ""I'm sorry, but I can't do that. Surely there must be something else I can offer you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Kesaro Kibener**
> ""Hmm. There is something I want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[327]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Ban_RY = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[328]`
Mówca: **Kesaro Kibener**
> ""You will either sign my bill or ban the Red Youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[329]`
Mówca: **Kesaro Kibener**
> ""See, that wasn't so hard, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[330]`
Mówca: **Kesaro Kibener**
> ""It makes sense, doesn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[331]`
**[WYBÓR GRACZA: ""I will sign the bill and also ban the Red Youth. You will help me in return.""]** — Mówca: **Player**
> ""I will sign the bill and also ban the Red Youth. You will help me in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[332]`
Mówca: **Kesaro Kibener**
> ""Maybe we can... come to an agreement, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[333]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Bill = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[334]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Ban_RY = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[335]`
Mówca: **Kesaro Kibener**
> ""I was in Bergia some time ago, and I visited one of their village schools.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[336]`
Mówca: **Kesaro Kibener**
> ""I went in to greet the students, and to my shock... none of these children knew how to speak Sordish! Can you believe it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Kesaro Kibener**
> ""They didn't understand me.... their own countryman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[338]`
**[WYBÓR GRACZA: ""I will ban the Red Youth in return for your support.""]** — Mówca: **Player**
> ""I will ban the Red Youth in return for your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[339]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Bill = true; BaseGameIsolated.Turn06_A_Kesaro_Ban_RY = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] = true;
Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[340]`
Mówca: **Kesaro Kibener**
> ""I want to be clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Kesaro Kibener**
> ""This was not a request for you to take a look.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[342]`
Mówca: **Kesaro Kibener**
> ""Excellent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[343]`
Mówca: **Kesaro Kibener**
> ""Then there is no use in continuing this conversation, is there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[344]`
Mówca: **Narrator**
> "Kesaro stood up and looked down at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[345]`
Mówca: **Kesaro Kibener**
> ""They can speak to each other in whatever language they want. But they must learn Sordish. That's it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[346]`
**[WYBÓR GRACZA: ""If they live in Sordland, they need to know how to speak in Sordish.""]** — Mówca: **Player**
> ""If they live in Sordland, they need to know how to speak in Sordish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[347]`
**[WYBÓR GRACZA: ""You will get your signature. I will sign the bill when I receive it.""]** — Mówca: **Player**
> ""You will get your signature. I will sign the bill when I receive it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[348]`
Mówca: **Kesaro Kibener**
> ""Before I go, I guarantee you this. That bill will not pass the Assembly. I will make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[349]`
**[WYBÓR GRACZA: ""So your answer is to ban them completely from speaking Bludish at school?""]** — Mówca: **Player**
> ""So your answer is to ban them completely from speaking Bludish at school?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[350]`
Mówca: **Kesaro Kibener**
> ""This bill, I call it the Unified Education Language Act, will enforce our language as the only one accepted in educational institutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`
  - -> `[349]`
  - -> `[351]`

### Węzeł `[351]`
**[WYBÓR GRACZA: ""I will decide when I see the bill. Not before.""]** — Mówca: **Player**
> ""I will decide when I see the bill. Not before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[352]`
Mówca: **Kesaro Kibener**
> ""I went to the nearby villages. All of them were the same! Not a single soul spoke Sordish! That put me on the path to draft a new bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[353]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: Jump to: [KesaroLeaves])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[354]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true || (BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true && BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true) || BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`
  - -> `[356]`

### Węzeł `[355]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true || (BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true && BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true) || BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] == true  or  (Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true  and  Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"] == true)  or  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true || (BaseGame.Decision_Turn03_StabilityOrder_BanBoth == true && BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true) || BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] == true  or  (Variable["BaseGame.Decision_Turn03_StabilityOrder_BanBoth"] == true  and  Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"] == true)  or  Variable["BaseGame.Decision_Turn03_StabilityOrder_BanRedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[357]`
Mówca: **Kesaro Kibener**
> ""Will you do the right thing for Sordland? What do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`

### Węzeł `[358]`
**[WYBÓR GRACZA: ""You will get your signature. I will sign the bill when I receive it.""]** — Mówca: **Player**
> ""You will get your signature. I will sign the bill when I receive it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[359]`
**[WYBÓR GRACZA: ""I don't think so. I won't go along with your scheme.""]** — Mówca: **Player**
> ""I don't think so. I won't go along with your scheme.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[360]`
Mówca: **Kesaro Kibener**
> ""There are no schemes here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Bill = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[362]`
Mówca: **Kesaro Kibener**
> ""But regardless, I think we have achieved much today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[363]`
Mówca: **Kesaro Kibener**
> ""Here is what I had in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[364]`
Mówca: **Kesaro Kibener**
> ""Very well. The NFP and I will support you in your reform package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Kesaro Kibener**
> ""Congratulations, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_NFP_Convinced = true;
BaseGameSupport.News_Turn06_LT_NFPConvinced = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Reform_NFP_Convinced"] = true;
Variable["BaseGameSupport.News_Turn06_LT_NFPConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[367]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[369]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_A_Kesaro_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Kesaro Kibener**
> ""One last thing before we shake hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Kesaro Kibener**
> ""I see your willingness to cooperate with me and I applaud it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Kesaro Kibener**
> ""What do you think about taking things a step further?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Kesaro Kibener**
> ""An alliance between our two parties. We would be extremely powerful in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[374]`
Mówca: **Kesaro Kibener**
> ""It would open many doors for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`
  - -> `[375]`

### Węzeł `[375]`
**[WYBÓR GRACZA: ""Apologies, but I have to refuse. It would close more doors than it would open.""]** — Mówca: **Player**
> ""Apologies, but I have to refuse. It would close more doors than it would open.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[376]`
**[WYBÓR GRACZA: ""I'm glad you asked. How better to cement our newfound partnership than with an alliance?""]** — Mówca: **Player**
> ""I'm glad you asked. How better to cement our newfound partnership than with an alliance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[377]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Alliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[378]`
Mówca: **Kesaro Kibener**
> ""What a historic day!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Kesaro Kibener**
> ""It will be tough to convince our respective parties, but I believe the good we'll do for Sordland together will be worth the hurdle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Kesaro Kibener**
> ""I understand. Just keep it in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[381]`
Mówca: **Kesaro Kibener**
> ""Well then, Mr. President. My respect for you has increased a hundredfold within the short span of this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[384]`
  - -> `[385]`

### Węzeł `[382]`
**[WYBÓR GRACZA: ""We will do great things together.""]** — Mówca: **Player**
> ""We will do great things together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
Mówca: **Kesaro Kibener**
> ""I am looking forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[384]`
**[WYBÓR GRACZA: ""Thank you for coming, Kesaro.""]** — Mówca: **Player**
> ""Thank you for coming, Kesaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]`

### Węzeł `[385]`
**[WYBÓR GRACZA: ""Make sure you deliver your end of the promise.""]** — Mówca: **Player**
> ""Make sure you deliver your end of the promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`

### Węzeł `[386]`
Mówca: **Kesaro Kibener**
> ""I have never broken my word in my life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Kesaro Kibener**
> ""Thank you for having me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[388]`
Mówca: **Narrator**
> "We shook hands and Kesaro turned around to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[389]`
Mówca: **Narrator**
> "Kesaro closed the door and left my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Narrator**
> "He closed the door and left my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]`

### Węzeł `[391]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
  - -> `[393]`

### Węzeł `[392]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`

### Węzeł `[393]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_A_Kesaro_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Alliance_NFP = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Alliance_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[395]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Bill == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`
  - -> `[397]`

### Węzeł `[396]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Bill == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_A_Kesaro_Bill == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Bill"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Bill = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Kesaro_Promise_Bill"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[399]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`
  - -> `[401]`

### Węzeł `[400]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_RevertBan_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[402]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS = false; BaseGame.Policy_Law_Ban_YoungSords = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] = false;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[403]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[405]`

### Węzeł `[404]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[405]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_A_Kesaro_Threshold_10 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_10"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[406]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_A_Kesaro_Threshold_8 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[409]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_15 = false; BaseGame.Reform_Law_Threshold_3 = false; BaseGame.Reform_Law_Threshold_8 = true; BaseGame.Reform_Law_Threshold_Default = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_15"] = false;
Variable["BaseGame.Reform_Law_Threshold_3"] = false;
Variable["BaseGame.Reform_Law_Threshold_8"] = true;
Variable["BaseGame.Reform_Law_Threshold_Default"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[410]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_15 = false; BaseGame.Reform_Law_Threshold_3 = false; BaseGame.Reform_Law_Threshold_8 = false; BaseGame.Reform_Law_Threshold_Default = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_15"] = false;
Variable["BaseGame.Reform_Law_Threshold_3"] = false;
Variable["BaseGame.Reform_Law_Threshold_8"] = false;
Variable["BaseGame.Reform_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[411]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`
  - -> `[413]`

### Węzeł `[412]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[413]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn06_A_Kesaro_Ban_RY == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_A_Kesaro_Ban_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[414]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY = true; BaseGame.Policy_Law_Ban_RedYouth = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] = true;
Variable["BaseGame.Policy_Law_Ban_RedYouth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[415]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Kesaro_Alliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[416]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Kesaro_Bill = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_Bill"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[417]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Kesaro_RevertYS = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_RevertYS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[418]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Kesaro_BanRY = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_BanRY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[419]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Kesaro_Threshold10 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_Threshold10"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[420]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn06_Kesaro_Threshold8 = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Kesaro_Threshold8"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[421]`
Mówca: **Narrator**
> "He grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[422]`
Mówca: **Kesaro Kibener**
> ""I think they have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[423]`
Mówca: **Kesaro Kibener**
> ""Give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[424]`
Mówca: **Kesaro Kibener**
> ""Oh, give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[425]`
Mówca: **Kesaro Kibener**
> ""Oh, give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[426]`
Mówca: **Kesaro Kibener**
> ""I think they have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[427]`
Mówca: **Kesaro Kibener**
> ""Give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[428]`
Mówca: **Kesaro Kibener**
> ""Oh, give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[429]`
Mówca: **Kesaro Kibener**
> ""I think they have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[430]`
Mówca: **Kesaro Kibener**
> ""Give me a break.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[431]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[433]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[434]`
Mówca: **Kesaro Kibener**
> ""I also wanted to talk about the aid you received from United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[435]`
Mówca: **Kesaro Kibener**
> ""Do you think that's just free money? Do you think they offered it out of sheer goodwill?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[436]`
Mówca: **Kesaro Kibener**
> ""You were fooled. They saw Sordland battling the recession and they pounced on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]`

### Węzeł `[437]`
Mówca: **Kesaro Kibener**
> ""You sold our national pride for money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`
  - -> `[439]`
  - -> `[440]`
  - -> `[441]`

### Węzeł `[438]`
**[WYBÓR GRACZA: ""It was a necessary evil. Don't expect me to sit by while my people suffer.""]** — Mówca: **Player**
> ""It was a necessary evil. Don't expect me to sit by while my people suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[439]`
**[WYBÓR GRACZA: ""I don't see anything wrong with accepting a helping hand.""]** — Mówca: **Player**
> ""I don't see anything wrong with accepting a helping hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[440]`
**[WYBÓR GRACZA: ""Is your national pride so fragile that this will destroy it? I don't think so.""]** — Mówca: **Player**
> ""Is your national pride so fragile that this will destroy it? I don't think so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[441]`
**[WYBÓR GRACZA: ""Kesaro. I am the President. I won't allow you to talk to me like this.""]** — Mówca: **Player**
> ""Kesaro. I am the President. I won't allow you to talk to me like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[442]`
Mówca: **Kesaro Kibener**
> ""Of course. My apologies. I'll get to the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[443]`
Mówca: **Kesaro Kibener**
> ""I fought for my country many times, and I have the scars to prove it. Can you say the same?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[444]`
Mówca: **Kesaro Kibener**
> ""You are naive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`

### Węzeł `[445]`
Mówca: **Kesaro Kibener**
> ""I won't waste my breath further on this matter, since you clearly don't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[446]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_LT_NFPNotConvinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_LT_NFPNotConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[447]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[449]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`

### Węzeł `[450]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn06_Holsord_NFP_NotConvinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn06_Holsord_NFP_NotConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[451]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: // Continue)*
- **Efekt (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[452]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Kesaro_Promise_Alliance = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Kesaro_Promise_Alliance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[453]`
Mówca: **Kesaro Kibener**
> ""In the end, it's only a 2% difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[454]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_KesaroLighter");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_KesaroLighter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that an original Rippo?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[456]`
Mówca: **Kesaro Kibener**
> ""You bet, Mr. President. It's one of the firsts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[457]`
Mówca: **Narrator**
> "He gave me the lighter. It was an original Rippo, but the shape appeared to be malformed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[458]`
Mówca: **Kesaro Kibener**
> ""Please. Keep it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[459]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn06_ST_VictoryDay = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_VictoryDay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[460]`
Mówca: **Kesaro Kibener**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
