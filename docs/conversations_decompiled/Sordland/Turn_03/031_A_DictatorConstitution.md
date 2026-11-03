# Sordland/Turn03/A_DictatorConstitution

- **ID konwersacji:** `31`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/031_A_DictatorConstitution.md`
- **Liczba węzłów dialogowych:** 157
- **Liczba wyborów gracza:** 52

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.ReformProposal_Open`
- `BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis`
- `BaseGameSupport.News_Turn03_LT_BenfiFestival`
- `GameCondition.Turn03_A_Pre_Constitution`

### Skoki między-konwersacyjne:
- Węzeł `[153]` -> **[32] Sordland/Turn03/Dictator Post Discussion** (../Turn_03/032_Dictator_Post_Discussion.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 7

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[128]` (Lucian Galade): `Variable["BaseGameSupport.News_Turn03_LT_BenfiFestival"] = true;`
- Węzeł `[151]` (Lucian Galade): `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- Węzeł `[152]` (Lucian Galade): `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- Węzeł `[153]` (Lucian Galade): `ShowPagedDecisionsPanel("Panel_DictatorConstitution");`
- Węzeł `[154]` (Lucian Galade): `Variable["BaseGame.ReformProposal_Open"] = true;`
- Węzeł `[155]` (Lucian Galade): `End();`
- Węzeł `[156]` (Lucian Galade): `Variable["BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis"] = true;`

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
  - -> `[9]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Petr Vectern**
> ""Good morning! Time to finally get this proposal going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Petr placed the draft in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""After your modifications, we will be starting the process, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Not long after, Petr and Lucian arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[13]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Greetings.”"]** — Mówca: **Player**
> "“Greetings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Finally!”"]** — Mówca: **Player**
> "“Finally!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[9]`
Mówca: **Narrator**
> "I was walking to my office, since today was the day to edit and make the final changes for the proposal to change the Constitution of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[10]`
Mówca: **Narrator**
> "The reform committee finally bore tangible results and the draft of the changes were about to be presented."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
Mówca: **Narrator**
> "I walked in the marble corridors of the Palace, thinking about the massive steps we were about to take."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "My secretary Livia greeted me at the entrance to my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Good morning everybody.”"]** — Mówca: **Player**
> "“Good morning everybody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[14]`
Mówca: **Narrator**
> "After placing the committee's report and my own notes in front of me, I buried myself in the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Maybe we shouldn't mess with the Court much to keep them on our side.""]** — Mówca: **Player**
> ""Maybe we shouldn't mess with the Court much to keep them on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""We could try to make the impeachment process more difficult or entirely get rid of it. A change like this would give you free reign. However, that might be going a little too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""We can start talking about Section 3. This is about the impeachment process of the President. Currently, in cases of high treason and breaking the Constitution, the Supreme Court may impeach and try the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[18]`
Mówca: **Petr Vectern**
> ""This law is particularly dangerous for you in this case. We will be going against the Old Guard, and if we prove to be successful in the Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""We could add the Assembly in the process but make impeachment possible only with an absolute majority.""]** — Mówca: **Player**
> ""We could add the Assembly in the process but make impeachment only possible with an absolute majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""...They will be looking for anything they can declare unconstitutional to tackle you. All they need is the Supreme Court to impeach you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[40]`
  - -> `[19]`
  - -> `[15]`

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""We could try to balance it with the reformists and make it dependent on an enabling act from the Assembly. Sure, it would make the whole process longer but as long as we have a majority, nothing really changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`
  - -> `[99]`
  - -> `[95]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""And the last one is the question about Soll's legacy. Basically his *Member of Honor* law. It gave him absolute immunity even when he's retired. He is a permanent member of the Assembly as well, but luckily he doesn't really attend anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""We will leave it to the President to decide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""That's a good idea. That'd make impeachment close to impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[25]`
Mówca: **Petr Vectern**
> ""You're right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""No, I think we should respect this law.""]** — Mówca: **Player**
> ""No, I think we should respect this law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[27]`
Mówca: **Petr Vectern**
> ""Hey, if people keep electing one person, that means they really are content. The masses are scared of change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""This is regarding the appointment of ministers. Currently, the President is free to appoint anyone from the members of the Assembly. Nobody else is involved with the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""But of course, I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[30]`
Mówca: **Petr Vectern**
> ""Yes, we'll need the help of some of the Judges in the process. Keeping some of their powers might make them more willing to get in dialogue with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""Now I'll move unto the 8th Section. We are reaching the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""I'll move on to Section 4.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""It's the question about the immunity of the Judges. While the Anti-Old Guard sentiment is increasing, there are talks that taking away their immunity would give us authority over judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Petr Vectern**
> ""Yeah, that's fair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[35]`
**[WYBÓR GRACZA: ""I don't aim to leave any time soon. We keep the unlimited terms.""]** — Mówca: **Player**
> ""I don't aim to leave any time soon. We keep the unlimited terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[36]`
Mówca: **Petr Vectern**
> ""Unlikely to have 100% vote to pass. But I hear you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[37]`
Mówca: **Petr Vectern**
> ""If we can remove their immunity or define an impeachment process, we could clean the Court from Orso and his gang.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`
  - -> `[96]`
  - -> `[97]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""Yes, they are already trying to hit you since they are expecting reforms. But we aim to cooperate with some of the judges to make sure that doesn't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""What if we don't succeed? The Court can have me impeached for this.""]** — Mówca: **Player**
> ""What if we don't succeed? The Court can have me impeached for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""We'll get rid of this law entirely.""]** — Mówca: **Player**
> ""We'll get rid of this law entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
> ""I agree, we could keep that in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""So there is no reason to change this unless you want to sell this to the opposition parties. Sharing the power with the Assembly may make them sympathetic to you. This might be important for the NFP as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[46]`
  - -> `[47]`

### Węzeł `[44]`
Mówca: **Petr Vectern**
> ""Yes, but this is a delicate matter. The party, and I mean, not even Albin wants us to change the threshold. They think that... this would destroy our party in the long term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[45]`
Mówca: **Petr Vectern**
> ""I'm sure some of the reformists may support that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[46]`
**[WYBÓR GRACZA: ""We could introduce a confidence vote.""]** — Mówca: **Player**
> ""We could introduce a confidence vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""I agree. We should involve the Assembly more in the process.""]** — Mówca: **Player**
> ""I agree. We should involve the Assembly more in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Lucian Galade**
> ""That is not bad idea. As long as we are the majority in the Assembly, that does not change too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Some reformists suggested that the Assembly should nominate the ministers before the President approves them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Petr Vectern**
> ""Of course, according to the ratio of the party's in government. In our case, it's only us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""Not wrong. The ten percent threshold is what that allowed us to control half of the Assembly with around one third of the majority in the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[58]`
  - -> `[59]`
  - -> `[60]`

### Węzeł `[52]`
Mówca: **Lucian Galade**
> ""The fifth section is about our infamous electoral threshold. Most reformists want to lower the threshold as much as possible. We could try working with them but it is simpler to keep the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""Yes. Tarquin Soll governed for twenty years. It seems his magic is slowly vanishing from the minds of the people, for they believe term limits are necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""Two major left parties; the Communist Party of Sordland and the Workers Party of Bludia both had close to ten percent vote in the last election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Term Limits?""]** — Mówca: **Player**
> ""Term Limits?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[56]`
Mówca: **Narrator**
> "Lucian continued with the next section."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""Because we could use it too.""]** — Mówca: **Player**
> ""Because we could use it too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""We should definitely work to decrease the threshold to some degree.""]** — Mówca: **Player**
> ""We should definitely work to decrease the threshold to some degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""Do you think it would really hurt the party?""]** — Mówca: **Player**
> ""Do you think it would really hurt the party?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""A decrease is out of the question.""]** — Mówca: **Player**
> ""A decrease is out of the question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Regardless of him, I see no problem with having a special title for great heroes.""]** — Mówca: **Player**
> ""Regardless of him, I see no problem with having a special title for great heroes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Yes, he is a hero for Sordland.""]** — Mówca: **Player**
> ""Yes, he is a hero for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""It's not unfair that former Presidents get some special treatment.""]** — Mówca: **Player**
> ""It's not unfair that former Presidents get some special treatment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""After pushing aggressive changes, I may need the same immunity.""]** — Mówca: **Player**
> ""After pushing aggressive changes, I may need the same immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[65]`
Mówca: **Petr Vectern**
> ""The reformists would like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
> ""That is pretty powerful, indeed. That may scare some of our ministers too if you decide to *rule by decree.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[67]`
Mówca: **Petr Vectern**
> ""But it would be tougher to persuade the judges with this. Mrs. Edmonds and Mr. Garaci may not want to cooperate with you if they believe you're going to get rid of them afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""Sure. You'll have some time before we start writing the final proposal together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""A decrease would definitely hurt our position in the future. If another party is elected to the Assembly, our projected vote would be closer to the real vote, which is significantly lesser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""That's a possibility. It might make the reformists more willing to consider the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""But if we keep the same voter base, say a 15% threshold, it would keep NFP out of the Assembly, leaving only two parties. Unless, Frens also falls back behind. But I doubt that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[72]`
Mówca: **Petr Vectern**
> ""I agree. This really has no importance for the new Constitution. Also, Soll was a hero for many Sords, whether we like it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[61]`

### Węzeł `[73]`
Mówca: **Petr Vectern**
> ""That would be enough to hold him accountable for his actions but why would you want to keep such the title then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[57]`

### Węzeł `[74]`
Mówca: **Petr Vectern**
> ""Yeah, it should be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[75]`
Mówca: **Petr Vectern**
> ""Oh, so you want to use the same privilege after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[63]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Every President should gain that title after their term.""]** — Mówca: **Player**
> ""Every President should gain that title after their term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""We could keep the title but take away the immunity clause.""]** — Mówca: **Player**
> ""We could keep the title but take away the immunity clause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""10% seems already too high for many, sir. An increase may bring too much attention on the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""I don't know how, but sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[80]`
Mówca: **Petr Vectern**
> ""But don't forget that the Communist Party of Sordland and the Worker's Party of Bludia both had close to ten percent vote in the last election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""We should abolish this position.""]** — Mówca: **Player**
> ""We should abolish this position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""We should respect their immunity.""]** — Mówca: **Player**
> ""We should respect their immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""I will instead give the President the ability to replace Judges as necessary.""]** — Mówca: **Player**
> ""I will instead give the President the ability to replace Judges as necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[84]`
Mówca: **Lucian Galade**
> ""We are at the 6th. This is about the presidential decrees. You already know that the reformists want them to be removed or limited. But I'm guessing you do not want any changes to your already powerful decrees, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[85]`
Mówca: **Lucian Galade**
> ""For now I'll move onto the next one: Term Limits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[55]`
  - -> `[35]`

### Węzeł `[86]`
Mówca: **Petr Vectern**
> ""Decreasing the threshold might mean opening their way into the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Petr Vectern**
> ""You would be opening their way into the parliament in the future if you were to decrease the threshold. It is important that you realize this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`
  - -> `[102]`
  - -> `[103]`

### Węzeł `[88]`
Mówca: **Petr Vectern**
> ""An increase on the other hand is more complex. NFP could be out of the Assembly but that would mean PFJP's seats would get higher too, if we're left with only two parties in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[101]`
  - -> `[102]`
  - -> `[103]`

### Węzeł `[89]`
Mówca: **Petr Vectern**
> ""I think some of the reformists really want to try him for his crimes during his terms. Especially against the Bludish. This law really has symbolic importance for both them and the Sollists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[26]`
  - -> `[77]`
  - -> `[76]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
> ""Me neither. I think it's important that the President can act quickly on matters of national importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[91]`
Mówca: **Petr Vectern**
> ""That's why only Tarquin Soll has it. He gave it to himself right after his military coup. This law is basically made to save the Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Uh-oh.""]** — Mówca: **Player**
> ""Uh-oh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""Mr. Ricter will probably demand that we remove them completely. I doubt that this would be enough to get him to sit down with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""According to the Constitution, the Member of Honor not only has legal immunity but the state also covers most of their expenses as well as providing security at all times. It can only be given to someone by an absolute majority vote in the Assembly and the approval of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I may need to think a bit longer about this.""]** — Mówca: **Player**
> ""I may need to think a bit longer about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""We should crush the Old Guards to clear ways for further reforms.""]** — Mówca: **Player**
> ""We should crush the Old Guards to clear ways for further reforms in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Maybe we shouldn't make the Supreme Court our enemies just yet.""]** — Mówca: **Player**
> ""Maybe we shouldn't make the Supreme Court our enemies just yet. Let's keep the reforms light.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""That might be the best thing to do for now. If we agitate the Court further, we might lose our chances with Mrs. Edmonds as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""We should strengthen the decrees further, so they have priority over statute law.""]** — Mówca: **Player**
> ""We should strengthen the decrees further, so they have priority over statute law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Don't worry. With these reforms, we will be even more popular.""]** — Mówca: **Player**
> ""Don't worry. With these reforms, we will be even more popular.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[101]`
**[WYBÓR GRACZA: ""We can't just give away our majority like that anyway.""]** — Mówca: **Player**
> ""We can't just give away our majority like that anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""We can't allow communists to enter the Assembly.""]** — Mówca: **Player**
> ""We can't allow communists to enter the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""We should open their way and unite the left.""]** — Mówca: **Player**
> ""We should open their way and unite the left.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""I agree, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""I guess so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Petr Vectern**
> ""Even Mr. Clavin and our party's reformist wing has no problems with the current law. USP would fully support that decision. I guess we could also persuade Mr. Kibener somehow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I don't think presidential decrees need any reforms.""]** — Mówca: **Player**
> ""I don't think presidential decrees need any reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Yes, we can make it dependent on enabling acts.""]** — Mówca: **Player**
> ""Yes, we can make it dependent on enabling acts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[109]`
Mówca: **Narrator**
> "Lucian couldn't hide the surprised look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""We should keep using the threshold to our advantage.""]** — Mówca: **Player**
> ""We should keep using the threshold to our advantage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""It's fine as it is.""]** — Mówca: **Player**
> ""It's fine as it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[112]`
Mówca: **Petr Vectern**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[113]`
Mówca: **Petr Vectern**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[114]`
Mówca: **Lucian Galade**
> ""Yes, it could be destabilizing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[115]`
Mówca: **Petr Vectern**
> ""Hell yes, we should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""We could simply increase it.""]** — Mówca: **Player**
> ""We could simply increase it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[117]`
Mówca: **Lucian Galade**
> ""Well, we can't know these for sure. In the last elections, the Communist Party of Sordland and the Workers Party of Bludia both had close to ten percent. One of them may very well increase their votes in the next years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[100]`
  - -> `[102]`
  - -> `[103]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
> ""You'll have some time to think about your decision, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""That's very bold, sir. But I like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[120]`
Mówca: **Lucian Galade**
> ""That is a fair concern. We'll need to sway some of their members to succeed after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "“Let's start.”"]** — Mówca: **Player**
> "“Let's start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[122]`
**[WYBÓR GRACZA: "“Can we go over each of the points that are in discussion for the draft?”"]** — Mówca: **Player**
> "“Can we go over each of the points that are in discussion for the draft?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
> ""Well, apart from the first two sections of decreasing the Supreme Court's authority and limiting the presidential vetoes... Other sections are up to debate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "“I thank you all for your input.”"]** — Mówca: **Player**
> "“I thank you all for your input.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[125]`
Mówca: **Petr Vectern**
> ""Well, regardless of what you decide, we will need to work together to push this agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[124]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“Let's start working on the draft.”"]** — Mówca: **Player**
> "“Let's start working on the draft.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[127]`
Mówca: **Narrator**
> "After placing the committee's report and my own notes in front of me, I buried myself in the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[128]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_BenfiFestival = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_BenfiFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[129]`
Mówca: **Livia Suno**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Good morning, Livia.”"]** — Mówca: **Player**
> "“Good morning, Livia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""How are you today?""]** — Mówca: **Player**
> ""How are you today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[132]`
Mówca: **Livia Suno**
> ""Sorry to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "“I'm perfectly fine.""]** — Mówca: **Player**
> "“I'm perfectly fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[134]`
Mówca: **Livia Suno**
> ""Fine, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[135]`
Mówca: **Narrator**
> "Livia left to hang up my coat. I entered my office and sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[136]`
Mówca: **Livia Suno**
> ""Mr. Rayne -- can you give me a hint about your reform plans? If you ask me, taking away the judges' immunity is long overdue, but it might anger a lot of people in these halls...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[143]`
  - -> `[138]`
  - -> `[146]`

### Węzeł `[137]`
Mówca: **Livia Suno**
> ""More importantly, how are you, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[145]`
  - -> `[147]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""Nothing's been decided yet.""]** — Mówca: **Player**
> ""Nothing's been decided yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Livia Suno**
> ""How are you today, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[145]`
  - -> `[147]`

### Węzeł `[140]`
Mówca: **Livia Suno**
> ""I hope you'll keep me informed. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[141]`
Mówca: **Livia Suno**
> ""Understood. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[142]`
Mówca: **Narrator**
> "She paused before taking my coat. It looked like she had something on her mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[143]`
**[WYBÓR GRACZA: "“I'll take that into consideration.""]** — Mówca: **Player**
> "“I'll take that into consideration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[144]`
Mówca: **Narrator**
> "She averted her eyes away from me and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[145]`
**[WYBÓR GRACZA: "“I'm about to make stressful decisions. So, not feeling that great.”"]** — Mówca: **Player**
> "“I'm about to make stressful decisions. So, not feeling that great.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[146]`
**[WYBÓR GRACZA: "“It's none of your business, Livia.""]** — Mówca: **Player**
> "“It's none of your business, Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[147]`
**[WYBÓR GRACZA: "“I feel better now that I've seen you, Livia.""]** — Mówca: **Player**
> "“I feel better now that I've seen you, Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[148]`
Mówca: **Livia Suno**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[149]`
Mówca: **Livia Suno**
> ""Good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“You'll find out along with the rest of Sordland, sweetheart.""]** — Mówca: **Player**
> "“You'll find out along with the rest of Sordland, sweetheart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[151]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_Pre_Constitution = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_Pre_Constitution = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[153]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_DictatorConstitution");)*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_DictatorConstitution");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `32` (*Sordland/Turn03/Dictator Post Discussion*), Węzeł `[1]`

### Węzeł `[154]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ReformProposal_Open = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.ReformProposal_Open"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[156]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
