# Sordland/Turn08/A_PressRelease

- **ID konwersacji:** `166`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/166_A_PressRelease.md`
- **Liczba węzłów dialogowych:** 344
- **Liczba wyborów gracza:** 91

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[57]** Reporter

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Relations_Marcel_Enemy`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn08_A_Petr_Protected`
- `BaseGame.Turn08_PressConference_PetrKnowsResigning`
- `BaseGame.Turn08_SecondScandal_BlamePetrForLeak`
- `BaseGame.Turn08_SecondScandal_DenyEverything`
- `BaseGame.Turn08_SecondScandal_LiviaTrialled`
- `BaseGame.Turn08_SecondScandal_PetrForcedResign`
- `BaseGame.Turn08_SecondScandal_PetrSelfResigned`
- `BaseGame.Turn08_SecondScandal_PetrTrialled`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Turn08_SecondScandal_ShareBlame`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Petr_Dead`
- `BaseGame.Petr_isVP`
- `BaseGame.Public_Opinion`
- `BaseGame.Turn08_SecondScandal_PetrForcedResign`
- `BaseGame.Turn08_SecondScandal_PetrSelfResigned`
- `BaseGame.Turn08_SecondScandal_PetrTrialled`
- `BaseGame.Turn08_SecondScandal_RumburgBlamed`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned`
- `BaseGameSupport.Codex_Characters_Others_EvelynVectern`
- `BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed`
- `BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing`
- `BaseGameSupport.Journal_Turn08_SecondScandal_PetrForcedResign`
- `BaseGameSupport.Journal_Turn08_SecondScandal_PetrSelfResigned`
- `BaseGameSupport.Journal_Turn08_SecondScandal_PetrTrialled`
- `BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed`
- `BaseGameSupport.News_Turn08_HP_Livia_Investigate_Trialled`
- `BaseGameSupport.News_Turn08_LT_Livia_Investigate_Trialled`
- `BaseGameSupport.News_Turn08_R_Livia_Investigate_Trialled`
- `BaseGameSupport.News_Turn08_R_Press_Conference_Blame_Petr`
- `BaseGameSupport.News_Turn08_R_Share_Blame_Petr_Resigns`
- `BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_Media`
- `BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_NoMedia`
- `BaseGameSupport.News_Turn08_ST_No_Blame_Media`
- `BaseGameSupport.News_Turn08_ST_No_Blame_NoMedia`
- `BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_Media`
- `BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_NoMedia`
- `GameCondition.Turn08_A_PressReleases`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[18]` | **""Thank you for coming.""** | `[17]` **Narrator**: "Together, we stepped behind the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Player**: ""As you are aware, Livia Suno, f..."<br>`[22]` **Player**: ""As you are aware, Ilana Vance, ..." |
| `[20]` | **""Please settle down.""** | `[17]` **Narrator**: "Together, we stepped behind the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Player**: ""As you are aware, Livia Suno, f..."<br>`[22]` **Player**: ""As you are aware, Ilana Vance, ..." |
| `[21]` | **""As you are aware, Livia Suno, former secretary to the President of Sordland, is c..."** | `[18]` **Player**: ""Thank you for coming.""<br>`[20]` **Player**: ""Please settle down."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Player**: ""Rest assured the traitor shall ..."<br>`[77]` **Player**: ""Rest assured Rumburg will be ma..."<br>*(oraz 7 innych odgałęzień)* |
| `[22]` | **""As you are aware, Ilana Vance, the Rumburg spy who posed as my secretary, is curr..."** | `[18]` **Player**: ""Thank you for coming.""<br>`[20]` **Player**: ""Please settle down."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] =...`<br>`Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Ru...` | `[76]` **Player**: ""Rest assured the traitor shall ..."<br>`[77]` **Player**: ""Rest assured Rumburg will be ma..."<br>*(oraz 7 innych odgałęzień)* |
| `[29]` | **""It is unknown exactly how this woman managed to infiltrate our administration.""** | `[21]` **Player**: ""As you are aware, Livia Suno, f..."<br>`[22]` **Player**: ""As you are aware, Ilana Vance, ..." | `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`<br>`(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false` | *Brak zmian stanu* | `[32]` **Player**: ""Please rest assured that the tr..."<br>`[33]` **Player**: ""Any further covert operations o..." |
| `[30]` | **""Using advanced document forging technology, this woman managed to pass our rigoro..."** | `[21]` **Player**: ""As you are aware, Livia Suno, f..."<br>`[22]` **Player**: ""As you are aware, Ilana Vance, ..." | `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`<br>`(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false` | *Brak zmian stanu* | `[32]` **Player**: ""Please rest assured that the tr..."<br>`[33]` **Player**: ""Any further covert operations o..." |
| `[31]` | **""Certain officials failed to conduct the necessary background checks that would ha..."** | `[21]` **Player**: ""As you are aware, Livia Suno, f..."<br>`[22]` **Player**: ""As you are aware, Ilana Vance, ..." | `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`<br>`(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false` | *Brak zmian stanu* | `[32]` **Player**: ""Please rest assured that the tr..."<br>`[33]` **Player**: ""Any further covert operations o..." |
| `[32]` | **""Please rest assured that the traitor will be brought to justice.""** | `[29]` **Player**: ""It is unknown exactly how this ..."<br>`[30]` **Player**: ""Using advanced document forging..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Player**: "“Despite the efforts to undermin..."<br>`[34]` **Player**: "“We remain vigilant against exte..."<br>*(oraz 1 innych odgałęzień)* |
| `[33]` | **""Any further covert operations on Rumburg's part shall be met with our full retali..."** | `[29]` **Player**: ""It is unknown exactly how this ..."<br>`[30]` **Player**: ""Using advanced document forging..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Ru...`<br>`Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] =...` | `[35]` **Player**: "“Despite the efforts to undermin..."<br>`[34]` **Player**: "“We remain vigilant against exte..."<br>*(oraz 1 innych odgałęzień)* |
| `[34]` | **"“We remain vigilant against external and internal enemies. We will not tolerate an..."** | `[32]` **Player**: ""Please rest assured that the tr..."<br>`[33]` **Player**: ""Any further covert operations o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Player**: "“Thank you.”" |
| `[35]` | **"“Despite the efforts to undermine the administration, we are strong, unified and c..."** | `[32]` **Player**: ""Please rest assured that the tr..."<br>`[33]` **Player**: ""Any further covert operations o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Player**: "“Thank you.”" |
| `[36]` | **""Both Mr. Vectern and I remain committed to keeping the great country of Sordland ..."** | `[32]` **Player**: ""Please rest assured that the tr..."<br>`[33]` **Player**: ""Any further covert operations o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Player**: "“Thank you.”" |
| `[37]` | **"“Thank you.”"** | `[34]` **Player**: "“We remain vigilant against exte..."<br>`[35]` **Player**: "“Despite the efforts to undermin..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("PressRelease");` | `[38]` **Narrator**: "Many camera flashes went off. A ..." |
| `[39]` | **""Yes? What is it?""** | `[38]` **Narrator**: "Many camera flashes went off. A ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Reporter**: ""Mr. President, have you chosen ..."<br>`[41]` **Reporter**: ""Mr. Vectern, I have credible so..." |
| `[40]` | **"Let the reporter ask a question."** | `[38]` **Narrator**: "Many camera flashes went off. A ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Reporter**: ""Mr. President, have you chosen ..."<br>`[41]` **Reporter**: ""Mr. Vectern, I have credible so..." |
| `[45]` | **""Mr. President, have you chosen your next secretary yet? Whoever she is, she's one..."** | `[39]` **Player**: ""Yes? What is it?""<br>`[40]` **Player_Italic**: "I gestured to the reporter." | `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false` | *Brak zmian stanu* | `[49]` **Player**: ""Would you like to submit an app..."<br>`[50]` **Player**: ""Not yet. But we'll make sure sh..."<br>*(oraz 1 innych odgałęzień)* |
| `[47]` | **""Attempts by our enemies to smear Mr. Vectern's reputation and further divide the ..."** | `[46]` **Narrator**: "I put a hand over Petr's mic." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Reporter**: ""My source comes from within the..." |
| `[48]` | **""Whoever these 'sources' are, they're lying. Mr. Vectern's conduct has been nothin..."** | `[46]` **Narrator**: "I put a hand over Petr's mic." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Reporter**: ""My source comes from within the..." |
| `[49]` | **""Would you like to submit an application?""** | `[45]` **Reporter**: ""Mr. President, have you chosen ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "The crowd of reporters all laugh..." |
| `[50]` | **""Not yet. But we'll make sure she's blonde this time.""** | `[45]` **Reporter**: ""Mr. President, have you chosen ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "The crowd of reporters all laugh..." |
| `[51]` | **""I have a few candidates in mind.""** | `[45]` **Reporter**: ""Mr. President, have you chosen ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "The crowd of reporters nodded se..." |
| `[57]` | **""Men will be men.""** | `[56]` **Reporter**: ""And are you going to disregard ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "Lucian interjected." |
| `[58]` | **""Lies. All lies.""** | `[56]` **Reporter**: ""And are you going to disregard ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "Lucian interjected." |
| `[59]` | **"Gesture to Lucian to end the press conference."** | `[56]` **Reporter**: ""And are you going to disregard ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "Lucian interjected." |
| `[64]` | **""A source within the palace? Who do you think she meant?""** | `[63]` **Petr Vectern**: ""Evelyn's still divorcing me, th..." | `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false` | *Brak zmian stanu* | `[70]` **Petr Vectern**: ""Eh, I'd wager anything she made..." |
| `[65]` | **""You should be thanking your lucky stars you're not in that courthouse with her.""** | `[63]` **Petr Vectern**: ""Evelyn's still divorcing me, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Petr Vectern**: ""I know, I know."" |
| `[66]` | **""We have Marcel to thank for that.""** | `[63]` **Petr Vectern**: ""Evelyn's still divorcing me, th..." | `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false` | *Brak zmian stanu* | `[68]` **Petr Vectern**: ""I know, I know."" |
| `[67]` | **""Sorry about Evelyn.""** | `[63]` **Petr Vectern**: ""Evelyn's still divorcing me, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Petr Vectern**: ""She was right. I don't deserve ..." |
| `[69]` | **""She was right. I don't deserve her.""** | `[67]` **Player**: ""Sorry about Evelyn."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Petr Vectern**: ""At least everything can go back..." |
| `[74]` | **""That she did can be directly traced to the carelessness of one man: Petr Vectern.""** | `[79]` **Player**: ""However, the fact remains that ..."<br>`[80]` **Player**: ""However, the fact remains that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "The journalists gasped and murmu..." |
| `[75]` | **""Therefore, the vice president shall be trialled for his shameful actions against ..."** | `[83]` **Player**: ""Mr. Vectern's willingness to pu..."<br>`[84]` **Player**: ""Mr. Vectern's recklessness, to ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] = ...`<br>`Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Pe...` | `[88]` **Petr Vectern**: ""Wait just a--"" |
| `[76]` | **""Rest assured the traitor shall be brought to justice.""** | `[21]` **Player**: ""As you are aware, Livia Suno, f..."<br>`[22]` **Player**: ""As you are aware, Ilana Vance, ..." | `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true` | *Brak zmian stanu* | `[79]` **Player**: ""However, the fact remains that ..."<br>`[80]` **Player**: ""However, the fact remains that ..." |
| `[77]` | **""Rest assured Rumburg will be made to answer for its latest affront to our great c..."** | `[21]` **Player**: ""As you are aware, Livia Suno, f..."<br>`[22]` **Player**: ""As you are aware, Ilana Vance, ..." | `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true` | `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Ru...`<br>`Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] =...` | `[79]` **Player**: ""However, the fact remains that ..."<br>`[80]` **Player**: ""However, the fact remains that ..." |
| `[78]` | **""Rest assured a security breach of this magnitude shall never happen again.""** | `[21]` **Player**: ""As you are aware, Livia Suno, f..."<br>`[22]` **Player**: ""As you are aware, Ilana Vance, ..." | `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true` | *Brak zmian stanu* | `[79]` **Player**: ""However, the fact remains that ..."<br>`[80]` **Player**: ""However, the fact remains that ..." |
| `[79]` | **""However, the fact remains that she should never have been allowed to infiltrate o..."** | `[76]` **Player**: ""Rest assured the traitor shall ..."<br>`[78]` **Player**: ""Rest assured a security breach ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Player**: ""That she did can be directly tr..."<br>`[81]` **Player**: ""She did so by exploiting the we..." |
| `[80]` | **""However, the fact remains that she should never have been allowed to access sensi..."** | `[76]` **Player**: ""Rest assured the traitor shall ..."<br>`[78]` **Player**: ""Rest assured a security breach ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Player**: ""That she did can be directly tr..."<br>`[81]` **Player**: ""She did so by exploiting the we..." |
| `[81]` | **""She did so by exploiting the weakness of Vice President Petr Vectern.""** | `[79]` **Player**: ""However, the fact remains that ..."<br>`[80]` **Player**: ""However, the fact remains that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "The journalists gasped and murmu..." |
| `[83]` | **""Mr. Vectern's willingness to put his own infantile desires over Sordland's securi..."** | `[82]` **Narrator**: "The journalists gasped and murmu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Player**: ""Therefore, the vice president s..."<br>`[85]` **Player**: ""Therefore, the vice president h..." |
| `[84]` | **""Mr. Vectern's recklessness, to say nothing of his betrayal of Sordish values, has..."** | `[82]` **Narrator**: "The journalists gasped and murmu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Player**: ""Therefore, the vice president s..."<br>`[85]` **Player**: ""Therefore, the vice president h..." |
| `[85]` | **""Therefore, the vice president has tendered his resignation. Effective immediately.""** | `[83]` **Player**: ""Mr. Vectern's willingness to pu..."<br>`[84]` **Player**: ""Mr. Vectern's recklessness, to ..." | *Brak (Dostępna bezwarunkowo)* | `-- Continue;`<br>`Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"...`<br>*(+3 skryptów)* | *Koniec sceny / Terminal* |
| `[91]` | **""Save it for the witness stand.""** | `[90]` **Petr Vectern**: ""How could you do this to me? I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "Karl and his men grabbed Petr's ..." |
| `[92]` | **""Sorry. Lucian made me.""** | `[90]` **Petr Vectern**: ""How could you do this to me? I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "Karl and his men grabbed Petr's ..." |
| `[93]` | **""Stop acting like this whole chain of events wasn't your fault.""** | `[90]` **Petr Vectern**: ""How could you do this to me? I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "Karl and his men grabbed Petr's ..." |
| `[94]` | **""This is for the good of Sordland. Trust me.""** | `[90]` **Petr Vectern**: ""How could you do this to me? I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "Karl and his men grabbed Petr's ..." |
| `[100]` | **""Rest assured the traitor shall be brought to justice.""** | `[21]` **Player**: ""As you are aware, Livia Suno, f..."<br>`[22]` **Player**: ""As you are aware, Ilana Vance, ..." | `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`<br>`(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false` | *Brak zmian stanu* | `[104]` **Player**: ""However, the fact remains that ..."<br>`[102]` **Player**: ""However, the fact remains that ..." |
| `[101]` | **""Rest assured Rumburg will be made to answer for its latest affront to our great c..."** | `[21]` **Player**: ""As you are aware, Livia Suno, f..."<br>`[22]` **Player**: ""As you are aware, Ilana Vance, ..." | `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`<br>`(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false` | `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_Ru...`<br>`Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] =...` | `[104]` **Player**: ""However, the fact remains that ..."<br>`[102]` **Player**: ""However, the fact remains that ..." |
| `[102]` | **""However, the fact remains that she should never have been allowed to access sensi..."** | `[100]` **Player**: ""Rest assured the traitor shall ..."<br>`[103]` **Player**: ""Rest assured a security breach ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Player**: ""That she was able to do so is s..."<br>`[106]` **Player**: ""I and Vice President Petr Vecte..." |
| `[103]` | **""Rest assured a security breach of this magnitude shall never happen again.""** | `[21]` **Player**: ""As you are aware, Livia Suno, f..."<br>`[22]` **Player**: ""As you are aware, Ilana Vance, ..." | `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`<br>`(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false` | *Brak zmian stanu* | `[104]` **Player**: ""However, the fact remains that ..."<br>`[102]` **Player**: ""However, the fact remains that ..." |
| `[104]` | **""However, the fact remains that she should never have been allowed to infiltrate o..."** | `[100]` **Player**: ""Rest assured the traitor shall ..."<br>`[103]` **Player**: ""Rest assured a security breach ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Player**: ""That she was able to do so is s..."<br>`[106]` **Player**: ""I and Vice President Petr Vecte..." |
| `[105]` | **""That she was able to do so is solely due to carelessness on the part of myself an..."** | `[102]` **Player**: ""However, the fact remains that ..."<br>`[104]` **Player**: ""However, the fact remains that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "The journalists gasps and murmur..." |
| `[106]` | **""I and Vice President Petr Vectern would like to take this opportunity to apologiz..."** | `[102]` **Player**: ""However, the fact remains that ..."<br>`[104]` **Player**: ""However, the fact remains that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "The journalists gasps and murmur..." |
| `[108]` | **""In his impulsive hiring practices, Mr. Vectern displayed a lapse in judgement. Bu..."** | `[107]` **Narrator**: "The journalists gasps and murmur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Player**: ""I have failed in my duty to kee..."<br>`[111]` **Player**: ""I failed to notice the enemy th..." |
| `[109]` | **""In falling victim to seduction, Mr. Vectern displayed a lapse in judgement. But a..."** | `[107]` **Narrator**: "The journalists gasps and murmur..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Player**: ""I have failed in my duty to kee..."<br>`[111]` **Player**: ""I failed to notice the enemy th..." |
| `[110]` | **""I have failed in my duty to keep this country safe and secure. I hope I can regai..."** | `[108]` **Player**: ""In his impulsive hiring practic..."<br>`[109]` **Player**: ""In falling victim to seduction,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Petr Vectern**: ""No! This isn't right!"" |
| `[111]` | **""I failed to notice the enemy that was right under my nose. I hope I can regain yo..."** | `[108]` **Player**: ""In his impulsive hiring practic..."<br>`[109]` **Player**: ""In falling victim to seduction,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Petr Vectern**: ""No! This isn't right!"" |
| `[118]` | **""You don't have to do this.""** | `[120]` **Narrator**: "The crowd became even louder. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Petr Vectern**: ""Yes, I do. You'd never survive ..."<br>`[125]` **Petr Vectern**: ""Yes, I do. You'd never survive ..." |
| `[119]` | **""Thank you.""** | `[120]` **Narrator**: "The crowd became even louder. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Petr Vectern**: ""I owe you this much, after what..." |
| `[130]` | **"Let Petr take the question."** | `[129]` **Reporter**: ""Mr. Vectern!"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame....` | `[132]` **Reporter**: ""Are you implying that you and t..." |
| `[131]` | **""I will be answering all questions on the vice president's behalf.""** | `[129]` **Reporter**: ""Mr. Vectern!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Reporter**: ""President Rayne, was Mr. Vecter..." |
| `[137]` | **""I had my suspicions...""** | `[136]` **Reporter**: ""Mr. President, were you aware o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "Lucian interjected." |
| `[138]` | **"Gesture to Lucian to end the press conference."** | `[136]` **Reporter**: ""Mr. President, were you aware o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Narrator**: "Lucian interjected." |
| `[142]` | **""No.""** | `[141]` **Reporter**: ""President Rayne, was Mr. Vecter..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Reporter**: ""No further questions.""<br>`[150]` **Reporter**: ""But when Mr. Vectern says he br..." |
| `[143]` | **""Yes.""** | `[141]` **Reporter**: ""President Rayne, was Mr. Vecter..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Reporter**: ""Can you elaborate, please?"" |
| `[144]` | **""Yes, and it wasn't the only such affair.""** | `[141]` **Reporter**: ""President Rayne, was Mr. Vecter..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Reporter**: ""Can you elaborate, please?"" |
| `[152]` | **""Sorry, Lucian made me do it.""** | `[151]` **Petr Vectern**: ""What the hell, Anton? We never ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "Petr looked at me in disbelief, ..." |
| `[153]` | **""What else did you think would happen?""** | `[151]` **Petr Vectern**: ""What the hell, Anton? We never ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "Petr looked at me in disbelief, ..." |
| `[154]` | **""It's for the good of Sordland. You'll understand someday.""** | `[151]` **Petr Vectern**: ""What the hell, Anton? We never ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "Petr looked at me in disbelief, ..." |
| `[155]` | **""Sorry. Someone has to take the fall.""** | `[151]` **Petr Vectern**: ""What the hell, Anton? We never ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "Petr looked at me in disbelief, ..." |
| `[161]` | **"Let Petr take the question."** | `[160]` **Reporter**: ""Mr. Vectern!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Reporter**: ""Can you give us a comment on yo..." |
| `[162]` | **""I will be answering all questions on the vice president's behalf.""** | `[160]` **Reporter**: ""Mr. Vectern!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Reporter**: ""President Rayne, were you imply..." |
| `[167]` | **""Yes.""** | `[169]` **Reporter**: ""President Rayne, were you imply..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Reporter**: ""Were you aware of this when it ..." |
| `[170]` | **""Yes, and it wasn't the only such affair.""** | `[169]` **Reporter**: ""President Rayne, were you imply..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Reporter**: ""Were you aware of those affairs..." |
| `[172]` | **"Gesture to Lucian to end the press conference."** | `[168]` **Reporter**: ""Were you aware of this when it ..."<br>`[171]` **Reporter**: ""Were you aware of those affairs..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Narrator**: "Lucian interjected." |
| `[173]` | **""I had my suspicions...""** | `[168]` **Reporter**: ""Were you aware of this when it ..."<br>`[171]` **Reporter**: ""Were you aware of those affairs..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Narrator**: "Lucian interjected." |
| `[176]` | **""I'm not taking any questions.""** | `[98]` **Reporter**: ""Mr. President!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Reporter**: ""Sir, you just had your vice pre..." |
| `[177]` | **""I will take exactly one question.""** | `[98]` **Reporter**: ""Mr. President!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Reporter**: ""President Rayne, were you imply..." |
| `[179]` | **""Yes.""** | `[178]` **Reporter**: ""President Rayne, were you imply..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Reporter**: ""Were you aware of this when it ..." |
| `[180]` | **""Yes, and it wasn't the only such affair.""** | `[178]` **Reporter**: ""President Rayne, were you imply..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Reporter**: ""Were you aware of those affairs..." |
| `[181]` | **""I had my suspicions...""** | `[183]` **Reporter**: ""Were you aware of this when it ..."<br>`[184]` **Reporter**: ""Were you aware of those affairs..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Narrator**: "Lucian interjected." |
| `[182]` | **"Gesture to Lucian to end the press conference."** | `[183]` **Reporter**: ""Were you aware of this when it ..."<br>`[184]` **Reporter**: ""Were you aware of those affairs..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Narrator**: "Lucian interjected." |
| `[189]` | **""Too soon.""** | `[191]` **Lucian Galade**: ""Of course, there's now the matt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Lucian Galade**: ""Very well. We shall discuss it ..." |
| `[192]` | **""I have a few candidates in mind.""** | `[191]` **Lucian Galade**: ""Of course, there's now the matt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Lucian Galade**: ""Very good, sir."" |
| `[193]` | **""You're a little old to be my secretary, Lucian.""** | `[191]` **Lucian Galade**: ""Of course, there's now the matt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Lucian Galade**: ""Very funny, sir."" |
| `[195]` | **""I'll come with you.""** | `[194]` **Petr Vectern**: ""I guess I'll go to the palace a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Narrator**: "Petr shook his head. I watched h..." |
| `[196]` | **""Goodbye, Petr.""** | `[194]` **Petr Vectern**: ""I guess I'll go to the palace a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Narrator**: "I watched Petr descend the court..." |
| `[197]` | **"Say nothing."** | `[194]` **Petr Vectern**: ""I guess I'll go to the palace a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[327]` **Lucian Galade**: ""A shame about your friend, Mr. ..."<br>`[190]` **Lucian Galade**: ""Mr. Vectern certainly made a sc..." |
| `[207]` | **"Say nothing."** | `[210]` **Petr Vectern**: ""I guess I'll go to the palace a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Lucian Galade**: ""Mr. Vectern certainly made a sc..." |
| `[208]` | **""I'll come with you.""** | `[210]` **Petr Vectern**: ""I guess I'll go to the palace a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Petr Vectern**: ""Thanks, but I think I need some..." |
| `[211]` | **""Goodbye, Petr.""** | `[210]` **Petr Vectern**: ""I guess I'll go to the palace a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Petr Vectern**: ""See you around, Anton."" |
| `[218]` | **""We won't be taking any questions. Thank you.""** | `[38]` **Narrator**: "Many camera flashes went off. A ..." | `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false` | *Brak zmian stanu* | `[219]` **Narrator**: "She stood up from her seat." |
| `[223]` | **""No.""** | `[168]` **Reporter**: ""Were you aware of this when it ..."<br>`[171]` **Reporter**: ""Were you aware of those affairs..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Narrator**: "Lucian interjected." |

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
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was the morning of Livia's trial, and hordes of reporters were gathered in front of the state courthouse. Petr, Lucian and I stood by the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Lucian had helped break the news of my secretary's arrest..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Lucian had helped break the news of my secretary's arrest. Now the media was beginning to question exactly how a Rumburg agent had been able to infiltrate the Maroon Palace. It was time for me to deliver an explanation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "A podium with a bank of microphones awaited us on the cou..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "A podium with a bank of microphones awaited us on the courthouse steps. Petr looked uncertain. I had told him I would be doing all the talking today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_A_PressReleases = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_A_PressReleases"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_A_Petr_Protected == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: ""Remember what we talked about, Mr. President.""*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Ac..."*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> ""Remember what we talked about, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_PressConference_PetrKnowsResigning == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true) && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false || (BaseGame.HeartOfSordland_Nationalization >3 || BaseGame.Media_Censored == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Ac..."*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Media_SordlandToday_Bias == true && BaseGame...."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true) && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false || (BaseGame.HeartOfSordland_Nationalization >3 || BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Accepted_MediaDeal"] == true)  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false  or  (Variable["BaseGame.HeartOfSordland_Nationalization"] >3  or  Variable["BaseGame.Media_Censored"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: ""Koronti's reporters will ask softball questions. But I'd..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true) && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false || (BaseGame.HeartOfSordland_Nationalization >3 || BaseGame.Media_Censored == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Accepted_MediaDeal"] == true)  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false  or  (Variable["BaseGame.HeartOfSordland_Nationalization"] >3  or  Variable["BaseGame.Media_Censored"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: ""You're on your own, Mr. President. I'd advise you to kee..."*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""Koronti's reporters will ask softball questions. But I'd still advise you to keep your responses as brief as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I nodded. Petr took a deep breath."*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""You're on your own, Mr. President. I'd advise you to keep your responses as brief as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I nodded. Petr took a deep breath."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "How could I forget? I was about to blame my best friend for a scandal that would otherwise shatter my administration. And Petr still had no idea."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Together, we stepped behind the podium. The reporters clu..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "Together, we stepped behind the podium. The reporters clustered around us and started shouting questions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: ""Thank you for coming.""*)
  - -> `[20]` (*Player: ""Please settle down.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Thank you for coming.""]** — Mówca: **Player**
> ""Thank you for coming.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""As you are aware, Livia Suno, former secretary to the Pr..."*)
  - -> `[22]` (*Player: ""As you are aware, Ilana Vance, the Rumburg spy who posed..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "I nodded. Petr took a deep breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Together, we stepped behind the podium. The reporters clu..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Please settle down.""]** — Mówca: **Player**
> ""Please settle down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""As you are aware, Livia Suno, former secretary to the Pr..."*)
  - -> `[22]` (*Player: ""As you are aware, Ilana Vance, the Rumburg spy who posed..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""As you are aware, Livia Suno, former secretary to the President of Sordland, is currently being tried for espionage.""]** — Mówca: **Player**
> ""As you are aware, Livia Suno, former secretary to the President of Sordland, is currently being tried for espionage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player), `[20]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""As you are aware, Ilana Vance, the Rumburg spy who posed as my secretary, is currently on trial for espionage.""]** — Mówca: **Player**
> ""As you are aware, Ilana Vance, the Rumburg spy who posed as my secretary, is currently on trial for espionage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Player), `[20]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_RumburgBlamed = true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: ""Rest assured the traitor shall be brought to justice.""*)
  - -> `[77]` (*Player: ""Rest assured Rumburg will be made to answer for its late..."*)
  - -> `[78]` (*Player: ""Rest assured a security breach of this magnitude shall n..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_ShareBlame == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_ShareBlame == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_ShareBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: ""Rest assured the traitor shall be brought to justice.""*)
  - -> `[101]` (*Player: ""Rest assured Rumburg will be made to answer for its late..."*)
  - -> `[103]` (*Player: ""Rest assured a security breach of this magnitude shall n..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_ShareBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""Certain officials failed to conduct the necessary backgr..."*)
  - -> `[30]` (*Player: ""Using advanced document forging technology, this woman m..."*)
  - -> `[29]` (*Player: ""It is unknown exactly how this woman managed to infiltra..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: ""It is unknown exactly how this woman managed to infiltrate our administration.""]** — Mówca: **Player**
> ""It is unknown exactly how this woman managed to infiltrate our administration.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false` AND `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""Please rest assured that the traitor will be brought to ..."*)
  - -> `[33]` (*Player: ""Any further covert operations on Rumburg's part shall be..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Using advanced document forging technology, this woman managed to pass our rigorous background checks and infiltrate our administration.""]** — Mówca: **Player**
> ""Using advanced document forging technology, this woman managed to pass our rigorous background checks and infiltrate our administration.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false` AND `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""Please rest assured that the traitor will be brought to ..."*)
  - -> `[33]` (*Player: ""Any further covert operations on Rumburg's part shall be..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Certain officials failed to conduct the necessary background checks that would have prevented her from infiltrating our administration. They are now under investigation.""]** — Mówca: **Player**
> ""Certain officials failed to conduct the necessary background checks that would have prevented this woman from infiltrating our administration. They are now under investigation.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true) == false` AND `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""Please rest assured that the traitor will be brought to ..."*)
  - -> `[33]` (*Player: ""Any further covert operations on Rumburg's part shall be..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""Please rest assured that the traitor will be brought to justice.""]** — Mówca: **Player**
> ""Please rest assured that the traitor will be brought to justice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[30]` (Player), `[31]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“Despite the efforts to undermine the administration, we ..."*)
  - -> `[34]` (*Player: "“We remain vigilant against external and internal enemies..."*)
  - -> `[36]` (*Player: ""Both Mr. Vectern and I remain committed to keeping the g..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Any further covert operations on Rumburg's part shall be met with our full retaliation.""]** — Mówca: **Player**
> ""Any further covert operations on Rumburg's part shall be met with our full retaliation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Player), `[30]` (Player), `[31]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlame..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“We remain vigilant against external and internal enemies. We will not tolerate any crimes against the state.”"]** — Mówca: **Player**
> "“We remain vigilant against external and internal enemies. We will not tolerate any crimes against the state.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Player), `[33]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "“Thank you.”"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“Despite the efforts to undermine the administration, we are strong, unified and capable as ever.”"]** — Mówca: **Player**
> "“Despite the efforts to undermine the administration, we are strong, unified and capable as ever.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Player), `[33]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "“Thank you.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""Both Mr. Vectern and I remain committed to keeping the great country of Sordland safe and secure.""]** — Mówca: **Player**
> ""Both Mr. Vectern and I remain committed to keeping the great country of Sordland safe and secure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Player), `[33]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "“Thank you.”"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Player), `[35]` (Player), `[36]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PressRelease");"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "Many camera flashes went off. A reporter raised her hand to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player_Italic: "Let the reporter ask a question."*)
  - -> `[39]` (*Player: ""Yes? What is it?""*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Yes? What is it?""]** — Mówca: **Player**
> ""Yes? What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "Let the reporter ask a question."]** — Mówca: **Player_Italic**
> "I gestured to the reporter."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)

### Węzeł `[41]`
Mówca: **Reporter**
> ""Mr. Vectern, I have credible sources saying you personally oversaw Miss Suno's hiring and may have even been carrying on an inappropriate relationship with her--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 3;"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Reporter: ""Mr. President, have you chosen your next secretary yet? ..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Reporter: ""Mr. Vectern, I have credible sources saying you personal..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""Mr. President, have you chosen your next secretary yet? Whoever she is, she's one lucky girl.""]** — Mówca: **Reporter**
> ""Mr. President, have you chosen your next secretary yet?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Kontekst wejściowy (poprzednik):** `[39]` (Player), `[40]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: ""Would you like to submit an application?""*)
  - -> `[50]` (*Player: ""Not yet. But we'll make sure she's blonde this time.""*)
  - -> `[51]` (*Player: ""I have a few candidates in mind.""*)

### Węzeł `[46]`
Mówca: **Narrator**
> "I put a hand over Petr's mic."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: ""Whoever these 'sources' are, they're lying. Mr. Vectern'..."*)
  - -> `[47]` (*Player: ""Attempts by our enemies to smear Mr. Vectern's reputatio..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""Attempts by our enemies to smear Mr. Vectern's reputation and further divide the administration. Nothing more.""]** — Mówca: **Player**
> ""Attempts by our enemies to smear Mr. Vectern's reputation and further divide the administration. Nothing more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Reporter: ""My source comes from within the Maroon Palace itself.""*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Whoever these 'sources' are, they're lying. Mr. Vectern's conduct has been nothing but honorable.""]** — Mówca: **Player**
> ""Whoever these 'sources' are, they're lying. Mr. Vectern's conduct has been nothing but honorable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Reporter: ""My source comes from within the Maroon Palace itself.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA: ""Would you like to submit an application?""]** — Mówca: **Player**
> ""Would you like to submit an application?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "The crowd of reporters all laughed. I sent a silent praye..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Not yet. But we'll make sure she's blonde this time.""]** — Mówca: **Player**
> ""Not yet. But we'll make sure she's blonde this time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "The crowd of reporters all laughed. I sent a silent praye..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""I have a few candidates in mind.""]** — Mówca: **Player**
> ""I have a few candidates in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The crowd of reporters nodded seriously. I sent a silent ..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "The crowd of reporters all laughed. I sent a silent prayer of thanks to Marcel Koronti."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Reporter: ""Well, whoever she is, she's one lucky girl.""*)

### Węzeł `[53]`
Mówca: **Narrator**
> "The crowd of reporters nodded seriously. I sent a silent prayer of thanks to Marcel Koronti."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Reporter: ""Well, whoever she is, she's one lucky girl.""*)

### Węzeł `[54]`
Mówca: **Reporter**
> ""Well, whoever she is, she's one lucky girl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Lucian interjected."*)

### Węzeł `[55]`
Mówca: **Reporter**
> ""My source comes from within the Maroon Palace itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Reporter: ""And are you going to disregard Mr. Vectern's established..."*)

### Węzeł `[56]`
Mówca: **Reporter**
> ""And are you going to disregard Mr. Vectern's established reputation as a serial philanderer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Italic: "Gesture to Lucian to end the press conference."*)
  - -> `[58]` (*Player: ""Lies. All lies.""*)
  - -> `[57]` (*Player: ""Men will be men.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""Men will be men.""]** — Mówca: **Player**
> ""Men will be men.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Lucian interjected."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""Lies. All lies.""]** — Mówca: **Player**
> ""Lies. All lies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Lucian interjected."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "Gesture to Lucian to end the press conference."]** — Mówca: **Player_Italic**
> "I silently gestured to Lucian to end the press conference."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "Lucian interjected."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "Lucian interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucian Galade: "“The President will not be taking any more questions. Tha..."*)

### Węzeł `[61]`
Mówca: **Lucian Galade**
> "“The President will not be taking any more questions. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "He, Petr and I began walking back to the courthouse. Petr..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "He, Petr and I began walking back to the courthouse. Petr and I hung behind to talk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Petr Vectern: ""Evelyn's still divorcing me, that can't be helped. But o..."*)

### Węzeł `[63]`
Mówca: **Petr Vectern**
> ""Evelyn's still divorcing me, that can't be helped. But overall, this was nowhere near as bad as it could've been.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""Sorry about Evelyn.""*)
  - -> `[65]` (*Player: ""You should be thanking your lucky stars you're not in th..."*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""A source within the palace? Who do you think she meant?""]** — Mówca: **Player**
> ""A source within the palace? Who do you think she meant?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[63]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Petr Vectern: ""Eh, I'd wager anything she made that up.""*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""You should be thanking your lucky stars you're not in that courthouse with her.""]** — Mówca: **Player**
> ""You should be thanking your lucky stars you're not in that courthouse with her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: ""I know, I know.""*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""We have Marcel to thank for that.""]** — Mówca: **Player**
> ""We have Marcel to thank for that.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Kontekst wejściowy (poprzednik):** `[63]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: ""I know, I know.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""Sorry about Evelyn.""]** — Mówca: **Player**
> ""Sorry about Evelyn.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Petr Vectern: ""She was right. I don't deserve her.""*)

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""I know, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Petr Vectern: ""At least everything can go back to normal now.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""She was right. I don't deserve her.""]** — Mówca: **Petr Vectern**
> ""She was right. I don't deserve her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Petr Vectern: ""At least everything can go back to normal now.""*)

### Węzeł `[70]`
Mówca: **Petr Vectern**
> ""Eh, I'd wager anything she made that up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Petr Vectern: ""At least everything can go back to normal now.""*)

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""At least everything can go back to normal now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "I stared at the back of Lucian's head as he disappeared i..."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "I stared at the back of Lucian's head as he disappeared inside the courthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Normal. We would see about that."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Normal. We would see about that."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_PressReleases = true"*)

### Węzeł `[74]`
**[WYBÓR GRACZA: ""That she did can be directly traced to the carelessness of one man: Petr Vectern.""]** — Mówca: **Player**
> ""That she did can be directly traced to the carelessness of one man: Petr Vectern.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Player), `[80]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "The journalists gasped and murmured. Petr turned to face ..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: ""Therefore, the vice president shall be trialled for his shameful actions against the state. If found guilty, he will be imprisoned. Take him.""]** — Mówca: **Player**
> ""Therefore, the vice president shall be trialled for his shameful actions against the state. If found guilty, he will be imprisoned. Take him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Player), `[84]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrTrialled = true; BaseGa..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Rest assured the traitor shall be brought to justice.""]** — Mówca: **Player**
> ""Rest assured the traitor shall be brought to justice.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""However, the fact remains that she should never have bee..."*)
  - -> `[80]` (*Player: ""However, the fact remains that she should never have bee..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Rest assured Rumburg will be made to answer for its latest affront to our great country.""]** — Mówca: **Player**
> ""Rest assured Rumburg will be made to answer for its latest affront to our great country.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlame..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""Rest assured a security breach of this magnitude shall never happen again.""]** — Mówca: **Player**
> ""Rest assured a security breach of this magnitude shall never happen again.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true`
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""However, the fact remains that she should never have bee..."*)
  - -> `[80]` (*Player: ""However, the fact remains that she should never have bee..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""However, the fact remains that she should never have been allowed to infiltrate our administration in the first place.""]** — Mówca: **Player**
> ""However, the fact remains that she should never have been allowed to infiltrate our administration in the first place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Player), `[78]` (Player), `[77]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: ""That she did can be directly traced to the carelessness ..."*)
  - -> `[81]` (*Player: ""She did so by exploiting the weakness of Vice President ..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA: ""However, the fact remains that she should never have been allowed to access sensitive government information.""]** — Mówca: **Player**
> ""However, the fact remains that she should never have been allowed to access sensitive government information.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Player), `[78]` (Player), `[77]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player: ""That she did can be directly traced to the carelessness ..."*)
  - -> `[81]` (*Player: ""She did so by exploiting the weakness of Vice President ..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""She did so by exploiting the weakness of Vice President Petr Vectern.""]** — Mówca: **Player**
> ""She did so by exploiting the weakness of Vice President Petr Vectern.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Player), `[80]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "The journalists gasped and murmured. Petr turned to face ..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "The journalists gasped and murmured. Petr turned to face me, his mouth hanging open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: ""Mr. Vectern's willingness to put his own infantile desir..."*)
  - -> `[84]` (*Player: ""Mr. Vectern's recklessness, to say nothing of his betray..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""Mr. Vectern's willingness to put his own infantile desires over Sordland's security has made him a threat to the state.""]** — Mówca: **Player**
> ""Mr. Vectern's willingness to put his own infantile desires over Sordland's security has made him a threat to the state.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: ""Therefore, the vice president shall be trialled for his ..."*)
  - -> `[85]` (*Player: ""Therefore, the vice president has tendered his resignati..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""Mr. Vectern's recklessness, to say nothing of his betrayal of Sordish values, has disgraced my administration.""]** — Mówca: **Player**
> ""Mr. Vectern's recklessness, to say nothing of his betrayal of Sordish values, has disgraced my administration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: ""Therefore, the vice president shall be trialled for his ..."*)
  - -> `[85]` (*Player: ""Therefore, the vice president has tendered his resignati..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: ""Therefore, the vice president has tendered his resignation. Effective immediately.""]** — Mówca: **Player**
> ""Therefore, the vice president has tendered his resignation. Effective immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Player), `[84]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrForcedResign = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_PetrForcedRe..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrTrialled = true;
BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_PetrTrialled..."*)

### Węzeł `[88]`
Mówca: **Petr Vectern**
> ""Wait just a--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "I put my hand over his mic and gestured to Karl Greiser, ..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "I put my hand over his mic and gestured to Karl Greiser, who was waiting offstage. He and his men approached Petr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Petr Vectern: ""How could you do this to me? I know I screwed up, but, A..."*)

### Węzeł `[90]`
Mówca: **Petr Vectern**
> ""How could you do this to me? I know I screwed up, but, Anton -- prison?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: ""This is for the good of Sordland. Trust me.""*)
  - -> `[93]` (*Player: ""Stop acting like this whole chain of events wasn't your ..."*)
  - -> `[92]` (*Player: ""Sorry. Lucian made me.""*)
  - -> `[91]` (*Player: ""Save it for the witness stand.""*)

### Węzeł `[91]`
**[WYBÓR GRACZA: ""Save it for the witness stand.""]** — Mówca: **Player**
> ""Save it for the witness stand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Karl and his men grabbed Petr's arms."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Sorry. Lucian made me.""]** — Mówca: **Player**
> ""Sorry. Lucian made me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Karl and his men grabbed Petr's arms."*)

### Węzeł `[93]`
**[WYBÓR GRACZA: ""Stop acting like this whole chain of events wasn't your fault.""]** — Mówca: **Player**
> ""Stop acting like this whole chain of events wasn't your fault.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Karl and his men grabbed Petr's arms."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: ""This is for the good of Sordland. Trust me.""]** — Mówca: **Player**
> ""This is for the good of Sordland. Trust me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Karl and his men grabbed Petr's arms."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Karl and his men grabbed Petr's arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Petr Vectern: ""Fuck you, Anton! You hear me? Fu--""*)

### Węzeł `[96]`
Mówca: **Petr Vectern**
> ""Fuck you, Anton! You hear me? Fu--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "The clamor of reporters drowned out his screams as he was..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "The clamor of reporters drowned out his screams as he was led away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Reporter: ""Mr. President!""*)

### Węzeł `[98]`
Mówca: **Reporter**
> ""Mr. President!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player: ""I'm not taking any questions.""*)
  - -> `[177]` (*Player: ""I will take exactly one question.""*)

### Węzeł `[99]`
Mówca: **Narrator**
> "The clamor of reporters was growing louder. Petr grabbed me by the collar and yanked me away from the microphones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Petr Vectern: ""What the hell, Anton? We never discussed this.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Rest assured the traitor shall be brought to justice.""]** — Mówca: **Player**
> ""Rest assured the traitor shall be brought to justice.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true` AND `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""However, the fact remains that she should never have bee..."*)
  - -> `[102]` (*Player: ""However, the fact remains that she should never have bee..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""Rest assured Rumburg will be made to answer for its latest affront to our great country.""]** — Mówca: **Player**
> ""Rest assured Rumburg will be made to answer for its latest affront to our great country.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true` AND `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlame..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""However, the fact remains that she should never have been allowed to access sensitive government information.""]** — Mówca: **Player**
> ""However, the fact remains that she should never have been allowed to access sensitive government information.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Player), `[103]` (Player), `[101]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""That she was able to do so is solely due to carelessness..."*)
  - -> `[106]` (*Player: ""I and Vice President Petr Vectern would like to take thi..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""Rest assured a security breach of this magnitude shall never happen again.""]** — Mówca: **Player**
> ""Rest assured a security breach of this magnitude shall never happen again.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SecondScandal_ShareBlame"] == true` AND `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[21]` (Player), `[22]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""However, the fact remains that she should never have bee..."*)
  - -> `[102]` (*Player: ""However, the fact remains that she should never have bee..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""However, the fact remains that she should never have been allowed to infiltrate our administration in the first place.""]** — Mówca: **Player**
> ""However, the fact remains that she should never have been allowed to infiltrate our administration in the first place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Player), `[103]` (Player), `[101]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""That she was able to do so is solely due to carelessness..."*)
  - -> `[106]` (*Player: ""I and Vice President Petr Vectern would like to take thi..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""That she was able to do so is solely due to carelessness on the part of myself and Vice President Petr Vectern.""]** — Mówca: **Player**
> ""That she was able to do so is solely due to carelessness on the part of myself and Vice President Petr Vectern.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Player), `[104]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "The journalists gasps and murmured. Petr turned to face m..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""I and Vice President Petr Vectern would like to take this opportunity to apologize for our disgraceful lack of oversight.""]** — Mówca: **Player**
> ""I and Vice President Petr Vectern would like to take this opportunity to apologize for our disgraceful lack of oversight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Player), `[104]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "The journalists gasps and murmured. Petr turned to face m..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "The journalists gasps and murmured. Petr turned to face me, his mouth hanging open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: ""In his impulsive hiring practices, Mr. Vectern displayed..."*)
  - -> `[109]` (*Player: ""In falling victim to seduction, Mr. Vectern displayed a ..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""In his impulsive hiring practices, Mr. Vectern displayed a lapse in judgement. But as your president, I bear the brunt of the responsibility.""]** — Mówca: **Player**
> ""In his impulsive hiring practices, Mr. Vectern displayed a lapse in judgement. But as your president, I bear the brunt of the responsibility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""I have failed in my duty to keep this country safe and s..."*)
  - -> `[111]` (*Player: ""I failed to notice the enemy that was right under my nos..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""In falling victim to seduction, Mr. Vectern displayed a lapse in judgement. But as your president, I bear the brunt of the responsibility.""]** — Mówca: **Player**
> ""In falling victim to seduction, Mr. Vectern displayed a lapse in judgement. But as your president, I bear the brunt of the responsibility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""I have failed in my duty to keep this country safe and s..."*)
  - -> `[111]` (*Player: ""I failed to notice the enemy that was right under my nos..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""I have failed in my duty to keep this country safe and secure. I hope I can regain your trust.""]** — Mówca: **Player**
> ""I have failed in my duty to keep this country safe and secure. I hope I can regain your trust.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Player), `[109]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Petr Vectern: ""No! This isn't right!""*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""I failed to notice the enemy that was right under my nose. I hope I can regain your trust.""]** — Mówca: **Player**
> ""I failed to notice the enemy that was right under my nose. I hope I can regain your trust.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Player), `[109]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Petr Vectern: ""No! This isn't right!""*)

### Węzeł `[112]`
Mówca: **Petr Vectern**
> ""No! This isn't right!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Sweat was beading on Petr's brow. He grabbed the closest ..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Sweat was beading on Petr's brow. He grabbed the closest microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Petr Vectern: ""Please, don't listen to President Rayne. This is all my ..."*)

### Węzeł `[114]`
Mówca: **Petr Vectern**
> ""Please, don't listen to President Rayne. This is all my fault.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Petr Vectern: ""I was drunk and reckless. I broke my marriage vows. My s..."*)

### Węzeł `[115]`
Mówca: **Petr Vectern**
> ""I was drunk and reckless. I broke my marriage vows. My selfishness compromised the Rayne administration and all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Tears began streaming down his face."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Tears began streaming down his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Petr Vectern: ""I've been a sorry excuse for a husband and a terrible vi..."*)

### Węzeł `[117]`
Mówca: **Petr Vectern**
> ""I've been a sorry excuse for a husband and a terrible vice president. I resign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned = true; Ba..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: ""You don't have to do this.""]** — Mówca: **Player**
> ""You don't have to do this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Ac..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Petr Vectern: ""I owe you this much, after what I did.""*)

### Węzeł `[120]`
Mówca: **Narrator**
> "The crowd became even louder. I turned away from the microphones and looked at Petr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Player: ""You don't have to do this.""*)
  - -> `[119]` (*Player: ""Thank you.""*)

### Węzeł `[121]`
Mówca: **Petr Vectern**
> ""Yes, I do. You'd never survive the term otherwise. Even with Marcel doing his best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Petr Vectern: ""And I owe you this much, after what I did.""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Ac..."*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Media_SordlandToday_Bias == true && BaseGame...."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Petr Vectern: ""Yes, I do. You'd never survive the term otherwise. Even ..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Media_SordlandToday_Bias == true && BaseGame.Accepted_MediaDeal == true && BaseGame.Relations_Marcel_Enemy == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Media_SordlandToday_Bias"] == true  and  Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Petr Vectern: ""Yes, I do. You'd never survive the term otherwise.""*)

### Węzeł `[125]`
Mówca: **Petr Vectern**
> ""Yes, I do. You'd never survive the term otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Petr Vectern: ""And I owe you this much, after what I did.""*)

### Węzeł `[126]`
Mówca: **Petr Vectern**
> ""And I owe you this much, after what I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "The reporters were now waving for us. One woman in the fr..."*)

### Węzeł `[127]`
Mówca: **Petr Vectern**
> ""I owe you this much, after what I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "The reporters were now waving for us. One woman in the fr..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "The reporters were now waving for us. One woman in the front row looked particularly insistent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Reporter: ""Mr. Vectern!""*)

### Węzeł `[129]`
Mówca: **Reporter**
> ""Mr. Vectern!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Italic: "Let Petr take the question."*)
  - -> `[131]` (*Player: ""I will be answering all questions on the vice president'..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "Let Petr take the question."]** — Mówca: **Player_Italic**
> "I nodded at Petr to take her question."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""I will be answering all questions on the vice president's behalf.""]** — Mówca: **Player**
> ""I will be answering all questions on the vice president's behalf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Reporter: ""President Rayne, was Mr. Vectern implying that he and th..."*)

### Węzeł `[132]`
Mówca: **Reporter**
> ""Are you implying that you and the covert agent posing as President Rayne's secretary were engaged in intimate relations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Petr Vectern: ""Yes. And it wasn't the only such affair.""*)

### Węzeł `[133]`
Mówca: **Petr Vectern**
> ""Yes. And it wasn't the only such affair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Petr Vectern: ""I abused my power as vice president to take advantage of..."*)

### Węzeł `[134]`
Mówca: **Petr Vectern**
> ""I abused my power as vice president to take advantage of multiple young women. I deeply regret my behavior, although I recognize that will never change what they went through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Petr Vectern: ""Evelyn, if you're watching this, I don't expect you to e..."*)

### Węzeł `[135]`
Mówca: **Petr Vectern**
> ""Evelyn, if you're watching this, I don't expect you to ever forgive me. Just know that I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Reporter: ""Mr. President, were you aware of these affairs as they w..."*)

### Węzeł `[136]`
Mówca: **Reporter**
> ""Mr. President, were you aware of these affairs as they were happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player_Italic: "Gesture to Lucian to end the press conference."*)
  - -> `[137]` (*Player: ""I had my suspicions...""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""I had my suspicions...""]** — Mówca: **Player**
> ""I had my suspicions...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Lucian interjected."*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "Gesture to Lucian to end the press conference."]** — Mówca: **Player_Italic**
> "I gestured to Lucian to end the press conference."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Lucian interjected."*)

### Węzeł `[139]`
Mówca: **Narrator**
> "Lucian interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lucian Galade: "“Neither the president nor the vice president will be tak..."*)

### Węzeł `[140]`
Mówca: **Lucian Galade**
> "“Neither the president nor the vice president will be taking any more questions. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "The reporters reluctantly dispersed. Lucian, Petr and I l..."*)

### Węzeł `[141]`
Mówca: **Reporter**
> ""President Rayne, was Mr. Vectern implying that he and the covert agent posing as President Rayne's secretary were engaged in intimate relations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: ""No.""*)
  - -> `[143]` (*Player: ""Yes.""*)
  - -> `[144]` (*Player: ""Yes, and it wasn't the only such affair.""*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""No.""]** — Mówca: **Player**
> ""No.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Reporter: ""Can you elaborate, please?""*)

### Węzeł `[144]`
**[WYBÓR GRACZA: ""Yes, and it wasn't the only such affair.""]** — Mówca: **Player**
> ""Yes, and it wasn't the only such affair.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Reporter: ""Can you elaborate, please?""*)

### Węzeł `[145]`
Mówca: **Reporter**
> ""Can you elaborate, please?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2;"*)

### Węzeł `[146]`
Mówca: **Reporter**
> ""No further questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Lucian interjected."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Reporter: ""No further questions.""*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Reporter: ""But when Mr. Vectern says he broke his marriage vows--""*)

### Węzeł `[150]`
Mówca: **Reporter**
> ""But when Mr. Vectern says he broke his marriage vows--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2;"*)

### Węzeł `[151]`
Mówca: **Petr Vectern**
> ""What the hell, Anton? We never discussed this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: ""Sorry, Lucian made me do it.""*)
  - -> `[154]` (*Player: ""It's for the good of Sordland. You'll understand someday.""*)
  - -> `[153]` (*Player: ""What else did you think would happen?""*)
  - -> `[155]` (*Player: ""Sorry. Someone has to take the fall.""*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Sorry, Lucian made me do it.""]** — Mówca: **Player**
> ""Sorry, Lucian made me do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Petr looked at me in disbelief, then shook his head."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: ""What else did you think would happen?""]** — Mówca: **Player**
> ""What else did you think would happen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Petr looked at me in disbelief, then shook his head."*)

### Węzeł `[154]`
**[WYBÓR GRACZA: ""It's for the good of Sordland. You'll understand someday.""]** — Mówca: **Player**
> ""It's for the good of Sordland. You'll understand someday.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Petr looked at me in disbelief, then shook his head."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: ""Sorry. Someone has to take the fall.""]** — Mówca: **Player**
> ""Sorry. Someone has to take the fall.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[151]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Petr looked at me in disbelief, then shook his head."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Petr looked at me in disbelief, then shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Petr Vectern: ""I guess I had this coming, the way I've been carrying on.""*)

### Węzeł `[157]`
Mówca: **Petr Vectern**
> ""I guess I had this coming, the way I've been carrying on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Petr Vectern: ""I just didn't think my best friend would be the one to s..."*)

### Węzeł `[158]`
Mówca: **Petr Vectern**
> ""I just didn't think my best friend would be the one to stick in the knife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "The reporters were becoming hard to ignore. One woman in ..."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "The reporters were becoming hard to ignore. One woman in the front row looked particularly insistent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Reporter: ""Mr. Vectern!""*)

### Węzeł `[160]`
Mówca: **Reporter**
> ""Mr. Vectern!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Italic: "Let Petr take the question."*)
  - -> `[162]` (*Player: ""I will be answering all questions on the vice president'..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "Let Petr take the question."]** — Mówca: **Player_Italic**
> "I nodded at Petr to take her question."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Reporter: ""Can you give us a comment on your resignation?""*)

### Węzeł `[162]`
**[WYBÓR GRACZA: ""I will be answering all questions on the vice president's behalf.""]** — Mówca: **Player**
> ""I will be answering all questions on the vice president's behalf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Reporter: ""President Rayne, were you implying that Mr. Vectern and ..."*)

### Węzeł `[163]`
Mówca: **Reporter**
> ""Can you give us a comment on your resignation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Petr Vectern: ""No, President Rayne just about covered it. I'm a terribl..."*)

### Węzeł `[164]`
Mówca: **Petr Vectern**
> ""No, President Rayne just about covered it. I'm a terrible vice president and a worse husband. And a... a sad old drunk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Reporter: ""Are you implying that you and the covert agent posing as..."*)

### Węzeł `[165]`
Mówca: **Reporter**
> ""Are you implying that you and the covert agent posing as President Rayne's secretary were engaged in intimate relations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Petr Vectern: ""Relations, yes. Intimate? I thought so at the time.""*)

### Węzeł `[166]`
Mówca: **Petr Vectern**
> ""Relations, yes. Intimate? I thought so at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Lucian interjected."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Reporter: ""Were you aware of this when it was happening?""*)

### Węzeł `[168]`
Mówca: **Reporter**
> ""Were you aware of this when it was happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player_Italic: "Gesture to Lucian to end the press conference."*)
  - -> `[173]` (*Player: ""I had my suspicions...""*)
  - -> `[223]` (*Player: ""No.""*)

### Węzeł `[169]`
Mówca: **Reporter**
> ""President Rayne, were you implying that Mr. Vectern and the covert agent posing as your secretary were engaged in intimate relations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player: ""Yes.""*)
  - -> `[170]` (*Player: ""Yes, and it wasn't the only such affair.""*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""Yes, and it wasn't the only such affair.""]** — Mówca: **Player**
> ""Yes, and it wasn't the only such affair.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Reporter: ""Were you aware of those affairs while they were happening?""*)

### Węzeł `[171]`
Mówca: **Reporter**
> ""Were you aware of those affairs while they were happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player_Italic: "Gesture to Lucian to end the press conference."*)
  - -> `[173]` (*Player: ""I had my suspicions...""*)
  - -> `[223]` (*Player: ""No.""*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "Gesture to Lucian to end the press conference."]** — Mówca: **Player_Italic**
> "I gestured to Lucian to end the press conference."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Reporter), `[171]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Lucian interjected."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""I had my suspicions...""]** — Mówca: **Player**
> ""I had my suspicions...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Reporter), `[171]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Lucian interjected."*)

### Węzeł `[174]`
Mówca: **Lucian Galade**
> "“Neither the President nor the Vice President will be taking any more questions. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "The reporters reluctantly dispersed. Lucian, Petr and I l..."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "Lucian interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucian Galade: "“Neither the President nor the Vice President will be tak..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: ""I'm not taking any questions.""]** — Mówca: **Player**
> ""I'm not taking any questions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Reporter: ""Sir, you just had your vice president arraigned in full ..."*)

### Węzeł `[177]`
**[WYBÓR GRACZA: ""I will take exactly one question.""]** — Mówca: **Player**
> ""I will take exactly one question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Reporter: ""President Rayne, were you implying that Mr. Vectern and ..."*)

### Węzeł `[178]`
Mówca: **Reporter**
> ""President Rayne, were you implying that Mr. Vectern and the covert agent posing as your secretary were engaged in intimate relations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: ""Yes.""*)
  - -> `[180]` (*Player: ""Yes, and it wasn't the only such affair.""*)

### Węzeł `[179]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Reporter: ""Were you aware of this when it was happening?""*)

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Yes, and it wasn't the only such affair.""]** — Mówca: **Player**
> ""Yes, and it wasn't the only such affair.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Reporter: ""Were you aware of those affairs while they were happening?""*)

### Węzeł `[181]`
**[WYBÓR GRACZA: ""I had my suspicions...""]** — Mówca: **Player**
> ""I had my suspicions...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Reporter), `[184]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Lucian interjected."*)

### Węzeł `[182]`
**[WYBÓR GRACZA: "Gesture to Lucian to end the press conference."]** — Mówca: **Player_Italic**
> "I gestured to Lucian to end the press conference."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Reporter), `[184]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Lucian interjected."*)

### Węzeł `[183]`
Mówca: **Reporter**
> ""Were you aware of this when it was happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Italic: "Gesture to Lucian to end the press conference."*)
  - -> `[181]` (*Player: ""I had my suspicions...""*)

### Węzeł `[184]`
Mówca: **Reporter**
> ""Were you aware of those affairs while they were happening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Italic: "Gesture to Lucian to end the press conference."*)
  - -> `[181]` (*Player: ""I had my suspicions...""*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Lucian interjected."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucian Galade: "“The president will not be taking any further questions. ..."*)

### Węzeł `[186]`
Mówca: **Lucian Galade**
> "“The president will not be taking any further questions. Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "The reporters reluctantly dispersed. Lucian and I looked ..."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "The reporters reluctantly dispersed. Lucian and I looked at each other for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Petr Vectern", "Former Vice Preside..."*)

### Węzeł `[188]`
Mówca: **Narrator**
> "The reporters reluctantly dispersed. Lucian, Petr and I looked at each other for what seemed like an eternity. Finally, Petr lowered his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead = true; BaseGame.Petr_isVP = false;"*)

### Węzeł `[189]`
**[WYBÓR GRACZA: ""Too soon.""]** — Mówca: **Player**
> ""Too soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Lucian Galade: ""Very well. We shall discuss it tomorrow.""*)

### Węzeł `[190]`
Mówca: **Lucian Galade**
> ""Mr. Vectern certainly made a scene, but it appears that you will make it out of this unscathed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lucian Galade: ""Of course, there's now the matter of replacing both your..."*)

### Węzeł `[191]`
Mówca: **Lucian Galade**
> ""Of course, there's now the matter of replacing both your secretary and your vice president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: ""Too soon.""*)
  - -> `[192]` (*Player: ""I have a few candidates in mind.""*)
  - -> `[193]` (*Player: ""You're a little old to be my secretary, Lucian.""*)

### Węzeł `[192]`
**[WYBÓR GRACZA: ""I have a few candidates in mind.""]** — Mówca: **Player**
> ""I have a few candidates in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Lucian Galade: ""Very good, sir.""*)

### Węzeł `[193]`
**[WYBÓR GRACZA: ""You're a little old to be my secretary, Lucian.""]** — Mówca: **Player**
> ""You're a little old to be my secretary, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lucian Galade: ""Very funny, sir.""*)

### Węzeł `[194]`
Mówca: **Petr Vectern**
> ""I guess I'll go to the palace and start packing my things, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player: ""I'll come with you.""*)
  - -> `[196]` (*Player: ""Goodbye, Petr.""*)
  - -> `[197]` (*Player_Italic: "Say nothing."*)

### Węzeł `[195]`
**[WYBÓR GRACZA: ""I'll come with you.""]** — Mówca: **Player**
> ""I'll come with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Petr shook his head. I watched him descend the courthouse..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA: ""Goodbye, Petr.""]** — Mówca: **Player**
> ""Goodbye, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "I watched Petr descend the courthouse stairs to his car, ..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing and watched Petr descend the courthouse steps to his car, alone."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_PressConference_PetrKnowsResigning == true"*)

### Węzeł `[198]`
Mówca: **Narrator**
> "I watched Petr descend the courthouse stairs to his car, alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_PressConference_PetrKnowsResigning == true"*)

### Węzeł `[199]`
Mówca: **Narrator**
> "Petr shook his head. I watched him descend the courthouse steps to his car, alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_PressConference_PetrKnowsResigning == true"*)

### Węzeł `[200]`
Mówca: **Reporter**
> ""Sir, you just had your vice president arraigned in full view of the public--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Lucian interjected."*)

### Węzeł `[201]`
Mówca: **Lucian Galade**
> ""Very good, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "We walked back up the stairs to the courthouse to watch t..."*)

### Węzeł `[202]`
Mówca: **Lucian Galade**
> ""Very well. We shall discuss it tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "We walked back up the stairs to the courthouse to watch t..."*)

### Węzeł `[203]`
Mówca: **Lucian Galade**
> ""Very funny, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "We walked back up the stairs to the courthouse to watch t..."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "We walked back up the stairs to the courthouse to watch the rest of the trial."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_PressReleases = true"*)

### Węzeł `[205]`
Mówca: **Narrator**
> "I watched him descend the courthouse steps to his car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lucian Galade: ""Mr. Vectern certainly made a scene, but it appears that ..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "I watched Petr descend the courthouse stairs to his car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lucian Galade: ""Mr. Vectern certainly made a scene, but it appears that ..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing and watched Petr descend the courthouse steps to his car."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lucian Galade: ""Mr. Vectern certainly made a scene, but it appears that ..."*)

### Węzeł `[208]`
**[WYBÓR GRACZA: ""I'll come with you.""]** — Mówca: **Player**
> ""I'll come with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Petr Vectern: ""Thanks, but I think I need some time alone.""*)

### Węzeł `[209]`
Mówca: **Narrator**
> "The reporters reluctantly dispersed. Lucian, Petr and I looked at each other for what seemed like an eternity. Finally, Petr lowered his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Petr Vectern", "Former Vice Preside..."*)

### Węzeł `[210]`
Mówca: **Petr Vectern**
> ""I guess I'll go to the palace and start packing my things, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player: ""I'll come with you.""*)
  - -> `[211]` (*Player: ""Goodbye, Petr.""*)
  - -> `[207]` (*Player_Italic: "Say nothing."*)

### Węzeł `[211]`
**[WYBÓR GRACZA: ""Goodbye, Petr.""]** — Mówca: **Player**
> ""Goodbye, Petr.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Petr Vectern: ""See you around, Anton.""*)

### Węzeł `[212]`
Mówca: **Petr Vectern**
> ""Thanks, but I think I need some time alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "I watched him descend the courthouse steps to his car."*)

### Węzeł `[213]`
Mówca: **Petr Vectern**
> ""See you around, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "I watched Petr descend the courthouse stairs to his car."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrSelfResigned = true; BaseGameSupport.Journal_Turn08_SecondScandal_PetrSelfResigned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] = true;
Variable["BaseGameSupport.Journal_Turn08_SecondScandal_PetrSelfResigned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "The crowd became even louder. I turned away from the micr..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Player: ""We won't be taking any questions. Thank you.""*)

### Węzeł `[218]`
**[WYBÓR GRACZA: ""We won't be taking any questions. Thank you.""]** — Mówca: **Player**
> ""We won't be taking any questions. Thank you.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "She stood up from her seat."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "She stood up from her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Reporter: ""Mr. Vectern, I have credible sources saying you personal..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_De..."*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: ""We have Marcel to thank for that.""*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true && BaseGame.Turn07_Detained_MarcelKoronti == false && BaseGame.Relations_Marcel_Enemy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  and  Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false  and  Variable["BaseGame.Relations_Marcel_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""A source within the palace? Who do you think she meant?""*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""No.""]** — Mówca: **Player**
> ""No.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Reporter), `[171]` (Reporter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Lucian interjected."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_RumburgBlamed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“Despite the efforts to undermine the administration, we ..."*)
  - -> `[34]` (*Player: "“We remain vigilant against external and internal enemies..."*)
  - -> `[36]` (*Player: ""Both Mr. Vectern and I remain committed to keeping the g..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_RumburgBlamed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""However, the fact remains that she should never have bee..."*)
  - -> `[102]` (*Player: ""However, the fact remains that she should never have bee..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_RumburgBlamed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: ""However, the fact remains that she should never have bee..."*)
  - -> `[80]` (*Player: ""However, the fact remains that she should never have bee..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_RumburgBlamed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlame..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_RumburgBlamed = true"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_RumburgBlamed = true"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed = true;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_RumburgBlamed"] = true;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_RumburgBlamed = true"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_PetrForcedResign = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_PetrForcedResign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_PressConference_PetrKnowsResigning == true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_SecondScandal_PetrTrialled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_PetrTrialled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Petr Vectern: ""Wait just a--""*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2;"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 3;"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "It was the morning of Livia's trial, and hordes of report..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 3;"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign = true;"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "I put a hand over Petr's mic."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Reporter: ""Are you implying that you and the covert agent posing as..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Lucian interjected."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaTrialled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_LiviaTrialled == true)"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaTrialled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Others_LiviaSuno = false..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_LiviaTrialled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_LT_Livia_Investigate_Trialled = true; BaseGameSupport.News_Turn08_HP_Livia_Investigate_Trialled = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_LT_Livia_Investigate_Trialled"] = true;
Variable["BaseGameSupport.News_Turn08_HP_Livia_Investigate_Trialled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrForcedResign == true)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrForcedResign == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned == true &&..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_Media = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Pet..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_Press_Conference_Blame_Petr = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Press_Conference_Blame_Petr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned == true &&..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrSelfResigned == true && BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned == true &&..."*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true ..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrSelfResigned == true && BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_Share_Blame_Petr_Resigns = ..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true && BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything == true"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_Share_Blame_Petr_Resigns = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Share_Blame_Petr_Resigns"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything == true"*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_DenyEverything == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything == true"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_DenyEverything == true)"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_DenyEverything == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_DenyEverything == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrTrialled == true"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_No_Blame_Media = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_No_Blame_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrTrialled == true"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_Livia_Investigate_Trialled ..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_Livia_Investigate_Trialled = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_Livia_Investigate_Trialled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrForcedResign == true"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_Press_Conference_Blame_Petr..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned == true &&..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_No_Blame_Media = true;"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_No_Blame_NoMedia = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_No_Blame_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrTrialled == true"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_No_Blame_NoMedia = true;"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrTrialled == true"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_A_Petr_Protected == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_A_Petr_Protected == true"*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_A_Petr_Protected == true)"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_A_Petr_Protected == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_A_Petr_Protected"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Kept..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_A_Petr_Protected == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_A_Petr_Protected"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrTrialled == true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrTrialled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrTrialled == true"*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrTrialled == true)"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrTrialled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arre..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrTrialled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ||..."*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true ..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dism..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_BlamePetrForLeak == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_BlamePetrForLeak"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned == true ||..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned == true ||..."*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true ..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resi..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_KeptAsVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Arrested"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaTrialled == true"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Petr_Dead = true;
BaseGame.Petr_isVP = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Petr_Dead"] = true;
Variable["BaseGame.Petr_isVP"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Petr Vectern", "Former Vice Preside..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_Others_LiviaSuno = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy = true; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed = false; BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_ArrestedAsSpy"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Dismissed"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_LiviaSuno_Missing"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_LT_Livia_Investigate_Trialled..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrTrialled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrTrialled == true"*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrTrialled == true)"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrTrialled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false && BaseGame.Me..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrTrialled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia ==..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false && BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false && BaseGame.Me..."*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == false && BaseGame...."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false && BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Pet..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == false && BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false  and  Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia ==..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_NoMedia = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Press_Conference_Blame_Petr_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia ==..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_PressConference_PetrKnowsResigning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_PressConference_PetrKnowsResigning == true"*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_PressConference_PetrKnowsResigning == t..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_PressConference_PetrKnowsResigning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "How could I forget? I was about to blame my best friend f..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_PressConference_PetrKnowsResigning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "How could I forget? I was about to blame my best friend f..."*)

### Węzeł `[318]`
Mówca: **Narrator**
> "How could I forget? I was about to blame my best friend for a scandal that would otherwise shatter my administration. Petr hadn't said a word to me since I broke the news to him in my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "Together, we stepped behind the podium. The reporters clu..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_PressConference_PetrKnowsResigning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_PressConference_PetrKnowsResigning == true"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_PressConference_PetrKnowsResigning == t..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_PressConference_PetrKnowsResigning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "The clamor of reporters was growing louder. Petr seemed t..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_PressConference_PetrKnowsResigning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "The clamor of reporters was growing louder. Petr grabbed ..."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "The clamor of reporters was growing louder. Petr seemed to shrink behind the podium, his charisma failing him at last."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Petr Vectern: ""That's it, then. No going back from this.""*)

### Węzeł `[323]`
Mówca: **Petr Vectern**
> ""That's it, then. No going back from this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "The reporters were becoming hard to ignore. One woman in ..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_PressConference_PetrKnowsResigning == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_PressConference_PetrKnowsResigning == true"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_PressConference_PetrKnowsResigning == t..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_PressConference_PetrKnowsResigning == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Lucian Galade: ""A shame about your friend, Mr. President. But it appears..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_PressConference_PetrKnowsResigning == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_PressConference_PetrKnowsResigning"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lucian Galade: ""Mr. Vectern certainly made a scene, but it appears that ..."*)

### Węzeł `[327]`
Mówca: **Lucian Galade**
> ""A shame about your friend, Mr. President. But it appears you will make it out of this unscathed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lucian Galade: ""Of course, there's now the matter of replacing both your..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_NoMedia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_NoMedia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia ==..."*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia ..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true && BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true) || (BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true && BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true)  or  (Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  and  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_Media = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed_Killed_Media"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_Livia_Petr_Secretly_Jailed..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Petr Vectern", "Former Vice President");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Petr Vectern","Former Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_PressConference_PetrKnowsResigning == true"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Petr Vectern", "Former Vice President");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Petr Vectern","Former Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Petr Vectern: ""I guess I'll go to the palace and start packing my thing..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Petr Vectern", "Former Vice President");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Petr Vectern","Former Vice President");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Petr Vectern: ""I guess I'll go to the palace and start packing my thing..."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PressRelease");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PressRelease");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Many camera flashes went off. A reporter raised her hand ..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
