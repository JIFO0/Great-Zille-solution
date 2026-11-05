# Sordland/Turn09/A_SollTrial

- **ID konwersacji:** `184`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/184_A_SollTrial.md`
- **Liczba węzłów dialogowych:** 553
- **Liczba wyborów gracza:** 64

---

## 1. Uczestnicy Sceny

- **[1]** Ovid Grecer
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[34]** Gloria Tory
- **[36]** Heron Garaci
- **[42]** Valken Kruger
- **[48]** Tarquin Soll
- **[56]** Karl Greiser
- **[59]** Isabel Edmonds

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Bergia_Governor_Ersen`
- `BaseGame.ChiefJustice_HeronGaraci`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.Confrontation_USP_EnergyAct_RevertedTo10`
- `BaseGame.Economy`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.Gasom_Bankrupt`
- `BaseGame.Gasom_Downsized`
- `BaseGame.Gasom_Ownership_ForeignOwned`
- `BaseGame.Joined_CSP`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Petr_Dead`
- `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent`
- `BaseGame.Policy_Law_Honorary_NoImmunity`
- `BaseGame.Policy_Law_SpecialZoneOfBergia`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_PublicBlame`
- `BaseGame.Reform_PresiPower_Strong_CapitalPunishment`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.Reform_Reform_Heron_Convinced`
- `BaseGame.Relations_Ewald_Friendly`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Security_Unrest_Police`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.Turn08_Action_Court_GloriaJustice`
- `BaseGame.Turn08_Action_Court_OldGuardReplaced`
- `BaseGame.Turn08_Action_Court_Shuffled`
- `BaseGame.Turn08_Dictator_Success`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGameIsolated.Turn09_SollTrial_Acquitted`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison`
- `BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Faction_OldGuard_Content`
- `BaseGame.Public_Opinion`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGameIsolated.Turn09_SollTrial_Acquitted`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison`
- `BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled`
- `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll`
- `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty`
- `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled`
- `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved`
- `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt`
- `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves`
- `BaseGameSupport.Journal_Turn09_SollTrial_Guilty_Death`
- `BaseGameSupport.Journal_Turn09_SollTrial_Guilty_Prison`
- `BaseGameSupport.Journal_Turn09_SollTrial_Intervention`
- `BaseGameSupport.Journal_Turn09_SollTrial_NotGuilty`
- `BaseGameSupport.News_Turn09_HP_SollTrial_Death`
- `BaseGameSupport.News_Turn09_HP_SollTrial_NotGuilty`
- `BaseGameSupport.News_Turn09_HP_SollTrial_Prison`
- `BaseGameSupport.News_Turn09_LT_SollTrial_NotGuilty`
- `BaseGameSupport.News_Turn09_R_SollTrial_Death`
- `BaseGameSupport.News_Turn09_R_SollTrial_Prison`
- `GameCondition.Turn09_A_SollTrial`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[14]` | **""Hell of a first case as Chief Justice, isn't it?""** | `[11]` **Narrator**: "In the hallway, I encountered Ov..." | `(Variable["BaseGame.Bergia_Governor_Ersen"] == true  and  Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == true) == false` | *Brak zmian stanu* | `[17]` **Ovid Grecer**: ""To say the least."" |
| `[15]` | **""We got him, right?""** | `[11]` **Narrator**: "In the hallway, I encountered Ov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Ovid Grecer**: ""Mr. President, as Chief Justice..." |
| `[16]` | **""I trust you've made the right choice?""** | `[11]` **Narrator**: "In the hallway, I encountered Ov..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Ovid Grecer**: ""Mr. President, as Chief Justice..." |
| `[21]` | **""Must be a shock seeing your man on the witness stand.""** | `[13]` **Narrator**: "In the hallway, I encountered Or..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Orso Hawker**: ""Fortunately, he won't be there ..." |
| `[22]` | **""I trust your personal loyalties to Soll won't get in the way of delivering justice.""** | `[13]` **Narrator**: "In the hallway, I encountered Or..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Orso Hawker**: ""Rest assured I have made the ri..." |
| `[23]` | **""I'm looking forward to hearing your verdict.""** | `[13]` **Narrator**: "In the hallway, I encountered Or..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Orso Hawker**: ""And I'm looking forward to your..." |
| `[24]` | **""I trust your personal loyalties to Soll won't get in the way of delivering justice.""** | `[12]` **Narrator**: "In the hallway, I encountered He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Heron Garaci**: ""I think you're mistaking me for..." |
| `[26]` | **""I'm counting on you, Mr. Grecer.""** | `[20]` **Ovid Grecer**: ""But I will say that justice sha..."<br>`[25]` **Ovid Grecer**: ""But I believe the history books..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Narrator**: "He nodded at me and went to chan..." |
| `[27]` | **""See you in the courtroom.""** | `[20]` **Ovid Grecer**: ""But I will say that justice sha..."<br>`[25]` **Ovid Grecer**: ""But I believe the history books..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Narrator**: "He nodded at me and went to chan..." |
| `[28]` | **""I'm glad to hear that.""** | `[20]` **Ovid Grecer**: ""But I will say that justice sha..."<br>`[25]` **Ovid Grecer**: ""But I believe the history books..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Narrator**: "He nodded at me and went to chan..." |
| `[32]` | **""Careful, Orso -- your strings are showing.""** | `[30]` **Orso Hawker**: ""Rest assured I have made the ri..."<br>`[31]` **Orso Hawker**: ""Fortunately, he won't be there ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "He gave an imperious sniff and w..." |
| `[33]` | **""Must be a shock seeing your man on the witness stand.""** | `[12]` **Narrator**: "In the hallway, I encountered He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Heron Garaci**: ""I think you're mistaking me for..." |
| `[34]` | **""Hell of a first case as Chief Justice, isn't it?""** | `[12]` **Narrator**: "In the hallway, I encountered He..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Heron Garaci**: ""To say the least.""<br>`[40]` **Heron Garaci**: ""Now is hardly the time for smal..." |
| `[41]` | **""I'll see you in the courtroom.""** | `[30]` **Orso Hawker**: ""Rest assured I have made the ri..."<br>`[31]` **Orso Hawker**: ""Fortunately, he won't be there ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "He gave an imperious sniff and w..." |
| `[43]` | **""I'm watching you, Mr. Hawker.""** | `[30]` **Orso Hawker**: ""Rest assured I have made the ri..."<br>`[31]` **Orso Hawker**: ""Fortunately, he won't be there ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "He gave an imperious sniff and w..." |
| `[45]` | **""So he is. It'd be a shame if anything happened to his replacement.""** | `[35]` **Heron Garaci**: ""I think you're mistaking me for..." | `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true` | *Brak zmian stanu* | `[53]` **Narrator**: "He abruptly turned his back on m..." |
| `[46]` | **""I'll see you in the courtroom.""** | `[39]` **Heron Garaci**: ""To say the least.""<br>`[40]` **Heron Garaci**: ""Now is hardly the time for smal..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true` | *Brak zmian stanu* | `[53]` **Narrator**: "He abruptly turned his back on m..." |
| `[50]` | **""Oh, right. Remind me who got rid of him?""** | `[35]` **Heron Garaci**: ""I think you're mistaking me for..." | `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true` | *Brak zmian stanu* | `[53]` **Narrator**: "He abruptly turned his back on m..." |
| `[51]` | **""How could I forget?""** | `[35]` **Heron Garaci**: ""I think you're mistaking me for..." | `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true) == false` | *Brak zmian stanu* | `[53]` **Narrator**: "He abruptly turned his back on m..." |
| `[52]` | **""I'm counting on you, Heron.""** | `[39]` **Heron Garaci**: ""To say the least.""<br>`[40]` **Heron Garaci**: ""Now is hardly the time for smal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "He abruptly turned his back on m..." |
| `[56]` | **"Go talk to him."** | `[61]` **Narrator**: "He looked happier than he had ba..."<br>`[449]` **Narrator**: "He looked more haggard than he h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Ewald Alphonso**: ""Anton! It's been a while.""<br>`[453]` **Ewald Alphonso**: ""Mr. Rayne. It's been a while."" |
| `[57]` | **"Pretend you don't notice him."** | `[61]` **Narrator**: "He looked happier than he had ba..."<br>`[449]` **Narrator**: "He looked more haggard than he h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Ewald Alphonso**: ""Anton! It's been a while.""<br>`[453]` **Ewald Alphonso**: ""Mr. Rayne. It's been a while."" |
| `[59]` | **""That's President Rayne to you.""** | `[58]` **Ewald Alphonso**: ""Anton! It's been a while.""<br>`[453]` **Ewald Alphonso**: ""Mr. Rayne. It's been a while."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[445]` **Ewald Alphonso**: ""After all we've been through to..." |
| `[60]` | **""Mr. Alphonso. To what do we owe this pleasure?""** | `[58]` **Ewald Alphonso**: ""Anton! It's been a while.""<br>`[453]` **Ewald Alphonso**: ""Mr. Rayne. It's been a while."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Ewald Alphonso**: ""It's the trial of the century, ..." |
| `[62]` | **""It has indeed, Ewald.""** | `[58]` **Ewald Alphonso**: ""Anton! It's been a while."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[466]` **Ewald Alphonso**: ""I couldn't stay home and miss t..." |
| `[67]` | **""'Alphonso' and 'Honor' don't belong in the same sentence.""** | `[66]` **Ewald Alphonso**: ""Although it would've been nice ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Ewald Alphonso**: ""No, you made sure of that when ..."<br>`[74]` **Ewald Alphonso**: ""No, you made sure of that when ..."<br>*(oraz 1 innych odgałęzień)* |
| `[69]` | **""No president, current or former, should be above the law.""** | `[66]` **Ewald Alphonso**: ""Although it would've been nice ..."<br>`[367]` **Ewald Alphonso**: ""I'm surprised you weren't tempt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Ewald Alphonso**: ""Says the man who bribed and ext..."<br>`[86]` **Ewald Alphonso**: ""Says the man who prevaricated h..."<br>*(oraz 1 innych odgałęzień)* |
| `[70]` | **""That was Soll's pet status. It should die with him.""** | `[66]` **Ewald Alphonso**: ""Although it would've been nice ..."<br>`[367]` **Ewald Alphonso**: ""I'm surprised you weren't tempt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Ewald Alphonso**: ""It's come down to that, has it?..." |
| `[134]` | **"Wait for the court's verdict."** | `[127]` **Isabel Edmonds**: ""You are also being accused of i..."<br>`[128]` **Heron Garaci**: ""You are also being accused of i..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Ovid Grecer**: ""We, the Supreme Court, have tho..."<br>`[155]` **Heron Garaci**: ""We, the Supreme Court, have tho..."<br>*(oraz 1 innych odgałęzień)* |
| `[135]` | **"Introduce new false evidence against Soll."** | `[127]` **Isabel Edmonds**: ""You are also being accused of i..."<br>`[128]` **Heron Garaci**: ""You are also being accused of i..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Ovid Grecer**: ""You have an objection, Mr. Pres..."<br>`[143]` **Heron Garaci**: ""You have an objection, Mr. Pres..."<br>*(oraz 1 innych odgałęzień)* |
| `[145]` | **""No, never mind. Carry on.""** | `[142]` **Ovid Grecer**: ""You have an objection, Mr. Pres..."<br>`[143]` **Heron Garaci**: ""You have an objection, Mr. Pres..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Ovid Grecer**: ""We, the Supreme Court, have tho..."<br>`[155]` **Heron Garaci**: ""We, the Supreme Court, have tho..."<br>*(oraz 1 innych odgałęzień)* |
| `[146]` | **""Yes. You're forgetting about the millions that Colonel Soll embezzled from the st..."** | `[142]` **Ovid Grecer**: ""You have an objection, Mr. Pres..."<br>`[143]` **Heron Garaci**: ""You have an objection, Mr. Pres..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("Chatter"); ;` | `[147]` **Narrator**: "The courtroom came alive with ch..." |
| `[186]` | **""That isn't what I meant.""** | `[185]` **Valken Kruger**: ""President Rayne has given the m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Valken Kruger**: ""My apologies, Mr. President. Fr..." |
| `[187]` | **""General Kruger, I order you and your men to leave the courtroom. Now.""** | `[185]` **Valken Kruger**: ""President Rayne has given the m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Valken Kruger**: ""My apologies, Mr. President. Fr..." |
| `[188]` | **""Soll *is* a criminal. He's not your goddamn daddy.""** | `[185]` **Valken Kruger**: ""President Rayne has given the m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Valken Kruger**: ""My apologies, Mr. President. Fr..." |
| `[203]` | **""All right. Uncuff him.""** | `[196]` **Narrator**: "I glanced at Ovid. He looked bac..."<br>`[197]` **Narrator**: "I glanced at Heron. He looked ba..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Narrator**: "Without taking their eyes off Va..."<br>`[211]` **Narrator**: "Without taking his eyes off Valk..." |
| `[204]` | **""You win again, Colonel.""** | `[196]` **Narrator**: "I glanced at Ovid. He looked bac..."<br>`[197]` **Narrator**: "I glanced at Heron. He looked ba..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Narrator**: "Without taking their eyes off Va..."<br>`[211]` **Narrator**: "Without taking his eyes off Valk..." |
| `[205]` | **""You... did you plan this?""** | `[201]` **Narrator**: "I glanced at Heron. He looked li..."<br>`[202]` **Narrator**: "I glanced at Orso. He smirked ba..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Narrator**: "Heron merely shrugged."<br>`[210]` **Narrator**: "Orso merely shrugged." |
| `[213]` | **""A boy can dream.""** | `[212]` **Tarquin Soll**: ""Did you really think you could ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Tarquin Soll**: ""Show some respect. Without me, ..." |
| `[214]` | **""The military won't always be your lapdog, you know.""** | `[212]` **Tarquin Soll**: ""Did you really think you could ..." | `(Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true) == false` | *Brak zmian stanu* | `[281]` **Tarquin Soll**: ""No. Just long enough to let me ..." |
| `[215]` | **""You'll pay for everything you've done, Soll.""** | `[212]` **Tarquin Soll**: ""Did you really think you could ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Tarquin Soll**: ""Everything **I've** done? Oh, A..." |
| `[270]` | **""You don't deserve peace after everything you've done.""** | `[269]` **Tarquin Soll**: ""Well, are you happy? You've rob..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Tarquin Soll**: ""Everything **I've** done? Oh, A..." |
| `[271]` | **""You can find peace in your cell.""** | `[269]` **Tarquin Soll**: ""Well, are you happy? You've rob..." | `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false` | *Brak zmian stanu* | `[293]` **Tarquin Soll**: ""Show some respect. Without me, ..." |
| `[272]` | **""I'm happy justice has been served.""** | `[269]` **Tarquin Soll**: ""Well, are you happy? You've rob..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[308]` **Tarquin Soll**: ""You see it as justice. The rest..."<br>`[294]` **Tarquin Soll**: ""If there was any such thing as ..."<br>*(oraz 1 innych odgałęzień)* |
| `[273]` | **""You've still got eternal peace to look forward to. Maybe.""** | `[269]` **Tarquin Soll**: ""Well, are you happy? You've rob..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` | *Brak zmian stanu* | `[293]` **Tarquin Soll**: ""Show some respect. Without me, ..." |
| `[288]` | **""The courts won't always be your lapdog, you know.""** | `[212]` **Tarquin Soll**: ""Did you really think you could ..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true` | *Brak zmian stanu* | `[281]` **Tarquin Soll**: ""No. Just long enough to let me ..." |
| `[292]` | **""You don't deserve peace after everything you've done.""** | `[281]` **Tarquin Soll**: ""No. Just long enough to let me ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Tarquin Soll**: ""Everything **I've** done? Oh, A..." |
| `[302]` | **""Better a nobody than a villain like you.""** | `[293]` **Tarquin Soll**: ""Show some respect. Without me, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Tarquin Soll**: ""Me, a villain? Oh, Anton."" |
| `[307]` | **""That may be true. But it still doesn't make up for everything you've done.""** | `[293]` **Tarquin Soll**: ""Show some respect. Without me, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Tarquin Soll**: ""Everything **I've** done? Oh, A..." |
| `[365]` | **""A villain like you doesn't deserve peace.""** | `[281]` **Tarquin Soll**: ""No. Just long enough to let me ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Tarquin Soll**: ""Me, a villain? Oh, Anton."" |
| `[458]` | **""Thank you for your condolences.""** | `[457]` **Ewald Alphonso**: ""By the way, I'm sorry I couldn'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[480]` **Ewald Alphonso**: ""Of course. It must be a difficu..." |
| `[459]` | **""No apology necessary. I'm sure Gasom has kept you busy.""** | `[457]` **Ewald Alphonso**: ""By the way, I'm sorry I couldn'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[476]` **Narrator**: "His eyes darkened."<br>`[478]` **Narrator**: "He smiled." |
| `[460]` | **""Everyone did. But he had his dark side.""** | `[457]` **Ewald Alphonso**: ""By the way, I'm sorry I couldn'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[472]` **Ewald Alphonso**: ""Evidently so."" |
| `[465]` | **""No need to be sorry. I'm a free man now.""** | `[464]` **Ewald Alphonso**: ""By the way, I was sorry to hear..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[497]` **Ewald Alphonso**: ""Ha. No president of Sordland is..." |
| `[467]` | **""It has indeed, Mr. Alphonso.""** | `[453]` **Ewald Alphonso**: ""Mr. Rayne. It's been a while."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[468]` **Ewald Alphonso**: ""The trial of the century, they'..." |
| `[469]` | **""It's no wonder neither of us could hold on to a wife. Sordland is a demanding mis..."** | `[464]` **Ewald Alphonso**: ""By the way, I was sorry to hear..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Ewald Alphonso**: ""I take it you're finally beginn..." |
| `[470]` | **""I'm not quite ready to talk about it yet.""** | `[464]` **Ewald Alphonso**: ""By the way, I was sorry to hear..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[495]` **Ewald Alphonso**: ""I understand. I was a mess afte..." |
| `[471]` | **""At least yours left you after you'd already lost the presidency. I'm worried abou..."** | `[464]` **Ewald Alphonso**: ""By the way, I was sorry to hear..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[489]` **Narrator**: "He frowned." |
| `[510]` | **""Do you mean Gasom? Because yes, that is a mess.""** | `[502]` **Ewald Alphonso**: ""But how have you been? Still tr..."<br>`[513]` **Ewald Alphonso**: ""How have you been otherwise? St..." | `Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true  or  Variable["BaseGame.Gasom_Ownership_ForeignOwned"] == true` | *Brak zmian stanu* | `[511]` **Ewald Alphonso**: ""What happened to Gasom was nowh..." |
| `[514]` | **""I think it's safe to say that it's *my* mess now.""** | `[502]` **Ewald Alphonso**: ""But how have you been? Still tr..."<br>`[513]` **Ewald Alphonso**: ""How have you been otherwise? St..." | `Variable["BaseGame.Economy"] <= 3` | *Brak zmian stanu* | `[515]` **Ewald Alphonso**: ""You see, {BaseGameText.Alphonso..." |
| `[519]` | **""Not just trying. Succeeding.""** | `[502]` **Ewald Alphonso**: ""But how have you been? Still tr..."<br>`[513]` **Ewald Alphonso**: ""How have you been otherwise? St..." | `(Variable["BaseGame.Economy"] <= 3) == false` | *Brak zmian stanu* | `[520]` **Ewald Alphonso**: ""Don't boast too prematurely. So..." |
| `[523]` | **""Your mess isn't what keeps me up at night. It's Soll's.""** | `[502]` **Ewald Alphonso**: ""But how have you been? Still tr..."<br>`[513]` **Ewald Alphonso**: ""How have you been otherwise? St..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[527]` **Ewald Alphonso**: ""You always did have it in for h..."<br>`[529]` **Ewald Alphonso**: ""I remember a time when you were..." |
| `[542]` | **""Yes. You're forgetting about the deep state he established to undermine the democ..."** | `[142]` **Ovid Grecer**: ""You have an objection, Mr. Pres..."<br>`[143]` **Heron Garaci**: ""You have an objection, Mr. Pres..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PlaySoundEffect("Chatter"); ;` | `[543]` **Narrator**: "The courtroom came alive with ch..." |
| `[547]` | **""Hell of a second case as Chief Justice, isn't it? I hope the result will be simil..."** | `[11]` **Narrator**: "In the hallway, I encountered Ov..." | `Variable["BaseGame.Bergia_Governor_Ersen"] == true  and  Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == true` | *Brak zmian stanu* | `[18]` **Ovid Grecer**: ""Mr. President, as Chief Justice..." |

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
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("PrologueIntro", "PrologueLoop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The papers were calling it the "Trial of the Century" -- and they were right. Colonel Tarquin Soll, the so-called father of Sordland, was finally being made to answer for his crimes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "After months of investigations and hearings, the Supreme ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "After months of investigations and hearings, the Supreme Court was about to deliver its verdict. I fairly bounded up the steps of the courthouse, eager not to miss a word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "In the hallway, I encountered Ovid Grecer, still dressed ..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "In the hallway, I encountered Heron Garaci, still dressed..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "In the hallway, I encountered Orso Hawker, still dressed ..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "In the hallway, I encountered Ovid Grecer, still dressed in a suit and tie. The two of us shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == true && BaseGame.Policy..."*)
  - -> `[15]` (*Player: ""We got him, right?""*)
  - -> `[16]` (*Player: ""I trust you've made the right choice?""*)

### Węzeł `[12]`
Mówca: **Narrator**
> "In the hallway, I encountered Heron Garaci, still dressed in a suit and tie. The two of us shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: ""I trust your personal loyalties to Soll won't get in the..."*)
  - -> `[33]` (*Player: ""Must be a shock seeing your man on the witness stand.""*)
  - -> `[34]` (*Player: ""Hell of a first case as Chief Justice, isn't it?""*)

### Węzeł `[13]`
Mówca: **Narrator**
> "In the hallway, I encountered Orso Hawker, still dressed in a suit and tie. The two of us shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: ""Must be a shock seeing your man on the witness stand.""*)
  - -> `[22]` (*Player: ""I trust your personal loyalties to Soll won't get in the..."*)
  - -> `[23]` (*Player: ""I'm looking forward to hearing your verdict.""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Hell of a first case as Chief Justice, isn't it?""]** — Mówca: **Player**
> ""Hell of a first case as Chief Justice, isn't it?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == true  and  Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Ovid Grecer: ""To say the least.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""We got him, right?""]** — Mówca: **Player**
> ""We got him, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Ovid Grecer: ""Mr. President, as Chief Justice I am committed to mainta..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I trust you've made the right choice?""]** — Mówca: **Player**
> ""I trust you've made the right choice?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Ovid Grecer: ""Mr. President, as Chief Justice I am sworn to secrecy re..."*)

### Węzeł `[17]`
Mówca: **Ovid Grecer**
> ""To say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Ovid Grecer: ""But I believe the history books will say I made the righ..."*)

### Węzeł `[18]`
Mówca: **Ovid Grecer**
> ""Mr. President, as Chief Justice I am committed to maintaining a neutral stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Ovid Grecer: ""But I will say that justice shall be delivered. Possibly..."*)

### Węzeł `[19]`
Mówca: **Ovid Grecer**
> ""Mr. President, as Chief Justice I am sworn to secrecy regarding my verdict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Ovid Grecer: ""But I will say that justice shall be delivered. Possibly..."*)

### Węzeł `[20]`
Mówca: **Ovid Grecer**
> ""But I will say that justice shall be delivered. Possibly for the first time in decades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: ""I'm counting on you, Mr. Grecer.""*)
  - -> `[27]` (*Player: ""See you in the courtroom.""*)
  - -> `[28]` (*Player: ""I'm glad to hear that.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Must be a shock seeing your man on the witness stand.""]** — Mówca: **Player**
> ""Must be a shock seeing your man on the witness stand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Orso Hawker: ""Fortunately, he won't be there for much longer.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""I trust your personal loyalties to Soll won't get in the way of delivering justice.""]** — Mówca: **Player**
> ""I trust your personal loyalties to Soll won't get in the way of delivering justice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Orso Hawker: ""Rest assured I have made the right decision for Sordland.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""I'm looking forward to hearing your verdict.""]** — Mówca: **Player**
> ""I'm looking forward to hearing your verdict.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Orso Hawker: ""And I'm looking forward to your accepting it without que..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""I trust your personal loyalties to Soll won't get in the way of delivering justice.""]** — Mówca: **Player**
> ""I trust your personal loyalties to Soll won't get in the way of delivering justice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Heron Garaci: ""I think you're mistaking me for someone else. Orso Hawke..."*)

### Węzeł `[25]`
Mówca: **Ovid Grecer**
> ""But I believe the history books will say I made the right decision:""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: ""I'm counting on you, Mr. Grecer.""*)
  - -> `[27]` (*Player: ""See you in the courtroom.""*)
  - -> `[28]` (*Player: ""I'm glad to hear that.""*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""I'm counting on you, Mr. Grecer.""]** — Mówca: **Player**
> ""I'm counting on you, Mr. Grecer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Ovid Grecer), `[25]` (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "He nodded at me and went to change into his robes."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""See you in the courtroom.""]** — Mówca: **Player**
> ""See you in the courtroom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Ovid Grecer), `[25]` (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "He nodded at me and went to change into his robes."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""I'm glad to hear that.""]** — Mówca: **Player**
> ""I'm glad to hear that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Ovid Grecer), `[25]` (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "He nodded at me and went to change into his robes."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "He nodded at me and went to change into his robes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Besides Soll and the judges, only a select few others wer..."*)

### Węzeł `[30]`
Mówca: **Orso Hawker**
> ""Rest assured I have made the right decision for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""Careful, Orso -- your strings are showing.""*)
  - -> `[41]` (*Player: ""I'll see you in the courtroom.""*)
  - -> `[43]` (*Player: ""I'm watching you, Mr. Hawker.""*)

### Węzeł `[31]`
Mówca: **Orso Hawker**
> ""Fortunately, he won't be there for much longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""Careful, Orso -- your strings are showing.""*)
  - -> `[41]` (*Player: ""I'll see you in the courtroom.""*)
  - -> `[43]` (*Player: ""I'm watching you, Mr. Hawker.""*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""Careful, Orso -- your strings are showing.""]** — Mówca: **Player**
> ""Careful, Orso -- your strings are showing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Orso Hawker), `[31]` (Orso Hawker), `[42]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He gave an imperious sniff and went to change into his ro..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Must be a shock seeing your man on the witness stand.""]** — Mówca: **Player**
> ""Must be a shock seeing your man on the witness stand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Heron Garaci: ""I think you're mistaking me for someone else. Orso Hawke..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""Hell of a first case as Chief Justice, isn't it?""]** — Mówca: **Player**
> ""Hell of a first case as Chief Justice, isn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true || BaseGame.Ref..."*)

### Węzeł `[35]`
Mówca: **Heron Garaci**
> ""I think you're mistaking me for someone else. Orso Hawker is gone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true || BaseGame.Ref..."*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true || BaseGame.R..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Heron Garaci: ""To say the least.""*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Heron Garaci: ""Now is hardly the time for small talk.""*)

### Węzeł `[39]`
Mówca: **Heron Garaci**
> ""To say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""I'll see you in the courtroom.""*)
  - -> `[52]` (*Player: ""I'm counting on you, Heron.""*)

### Węzeł `[40]`
Mówca: **Heron Garaci**
> ""Now is hardly the time for small talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""I'll see you in the courtroom.""*)
  - -> `[52]` (*Player: ""I'm counting on you, Heron.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""I'll see you in the courtroom.""]** — Mówca: **Player**
> ""I'll see you in the courtroom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Orso Hawker), `[31]` (Orso Hawker), `[42]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He gave an imperious sniff and went to change into his ro..."*)

### Węzeł `[42]`
Mówca: **Orso Hawker**
> ""And I'm looking forward to your accepting it without question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""Careful, Orso -- your strings are showing.""*)
  - -> `[41]` (*Player: ""I'll see you in the courtroom.""*)
  - -> `[43]` (*Player: ""I'm watching you, Mr. Hawker.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""I'm watching you, Mr. Hawker.""]** — Mówca: **Player**
> ""I'm watching you, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Orso Hawker), `[31]` (Orso Hawker), `[42]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He gave an imperious sniff and went to change into his ro..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "He gave an imperious sniff and went to change into his robes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Besides Soll and the judges, only a select few others wer..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""So he is. It'd be a shame if anything happened to his replacement.""]** — Mówca: **Player**
> ""So he is. It'd be a shame if anything happened to his replacement.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true`
- **Kontekst wejściowy (poprzednik):** `[35]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "He abruptly turned his back on me and went to change into..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""I'll see you in the courtroom.""]** — Mówca: **Player**
> ""I'll see you in the courtroom.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true`
- **Kontekst wejściowy (poprzednik):** `[39]` (Heron Garaci), `[40]` (Heron Garaci), `[35]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "He abruptly turned his back on me and went to change into..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: ""So he is. It'd be a shame if anything happened to his re..."*)
  - -> `[50]` (*Player: ""Oh, right. Remind me who got rid of him?""*)
  - -> `[46]` (*Player: ""I'll see you in the courtroom.""*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: ""Oh, right. Remind me who got rid of him?""*)
  - -> `[51]` (*Player: ""How could I forget?""*)
  - -> `[46]` (*Player: ""I'll see you in the courtroom.""*)

### Węzeł `[50]`
**[WYBÓR GRACZA: ""Oh, right. Remind me who got rid of him?""]** — Mówca: **Player**
> ""Oh, right. Remind me who got rid of him?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true`
- **Kontekst wejściowy (poprzednik):** `[35]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "He abruptly turned his back on me and went to change into..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""How could I forget?""]** — Mówca: **Player**
> ""How could I forget?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[35]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "He abruptly turned his back on me and went to change into..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""I'm counting on you, Heron.""]** — Mówca: **Player**
> ""I'm counting on you, Heron.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Heron Garaci), `[40]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "He abruptly turned his back on me and went to change into..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "He abruptly turned his back on me and went to change into his robes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Besides Soll and the judges, only a select few others wer..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Besides Soll and the judges, only a select few others were allowed in the courtroom. After a thorough screening, I walked in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "As soon as I entered, I saw my predecessor, Ewald Alphons..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "As soon as I entered, I saw my predecessor, Ewald Alphonso, sitting right in the middle of the gallery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "Go talk to him."]** — Mówca: **Player_Italic**
> "I took a seat in the row behind him and tapped him on the shoulder."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator), `[449]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "Pretend you don't notice him."]** — Mówca: **Player_Italic**
> "I took a seat two rows in front of him and stared at the ceiling. Eventually, I felt a tap on my shoulder."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator), `[449]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[58]`
Mówca: **Ewald Alphonso**
> ""Anton! It's been a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: ""That's President Rayne to you.""*)
  - -> `[62]` (*Player: ""It has indeed, Ewald.""*)
  - -> `[60]` (*Player: ""Mr. Alphonso. To what do we owe this pleasure?""*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""That's President Rayne to you.""]** — Mówca: **Player**
> ""That's President Rayne to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Ewald Alphonso), `[453]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Ewald Alphonso: ""After all we've been through together? Well, I guess the..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Mr. Alphonso. To what do we owe this pleasure?""]** — Mówca: **Player**
> ""Mr. Alphonso. To what do we owe this pleasure?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Ewald Alphonso), `[453]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Ewald Alphonso: ""It's the trial of the century, isn't it? I couldn't just..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "He looked happier than he had back at Petr's villa. Color had returned to his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Italic: "Go talk to him."*)
  - -> `[57]` (*Player_Italic: "Pretend you don't notice him."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It has indeed, Ewald.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Ewald Alphonso: ""I couldn't stay home and miss the trial of the century. ..."*)

### Węzeł `[63]`
Mówca: **Ewald Alphonso**
> ""It's the trial of the century, isn't it? I couldn't just sit at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead == true"*)

### Węzeł `[64]`
Mówca: **Narrator**
> "Tarquin Soll entered the courtroom, escorted by Karl Greiser and at least half a dozen other guards. His hands were cuffed, but he held his head defiantly high as they walked him to the defendant's seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Ewald Alphonso: ""How the mighty have fallen. I can't say it entirely sadd..."*)

### Węzeł `[65]`
Mówca: **Ewald Alphonso**
> ""How the mighty have fallen. I can't say it entirely saddens me to see him like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Honorary_NoImmunity == true"*)

### Węzeł `[66]`
Mówca: **Ewald Alphonso**
> ""Although it would've been nice to grab some of those Member of Honor privileges for myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""'Alphonso' and 'Honor' don't belong in the same sentence.""*)
  - -> `[69]` (*Player: ""No president, current or former, should be above the law.""*)
  - -> `[70]` (*Player: ""That was Soll's pet status. It should die with him.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""'Alphonso' and 'Honor' don't belong in the same sentence.""]** — Mówca: **Player**
> ""'Alphonso' and 'Honor' don't belong in the same sentence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_PublicBlame == true"*)

### Węzeł `[68]`
Mówca: **Ewald Alphonso**
> ""No, you made sure of that when you ran that smear campaign against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""No president, current or former, should be above the law.""]** — Mówca: **Player**
> ""No president, current or former, should be above the law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Ewald Alphonso), `[367]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: ""That was Soll's pet status. It should die with him.""]** — Mówca: **Player**
> ""That was Soll's pet status. It should die with him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Ewald Alphonso), `[367]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Ewald Alphonso: ""It's come down to that, has it? I wonder who's next on t..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_PublicBlame == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_PublicBlame == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Ewald Alphonso: ""No, you made sure of that when you ran that smear campai..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_PublicBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)

### Węzeł `[74]`
Mówca: **Ewald Alphonso**
> ""No, you made sure of that when you turned my party against me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Ewald Alphonso: ""No, you made sure of that when you turned my party again..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Ewald Alphonso: ""Time heals all wounds. I foresee a day when the Sordish ..."*)

### Węzeł `[78]`
Mówca: **Ewald Alphonso**
> ""Time heals all wounds. I foresee a day when the Sordish people will get nostalgic even for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Ewald Alphonso: ""Says the man who bribed and extorted his way into the pr..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_PublicBlame == true"*)

### Węzeł `[82]`
Mówca: **Ewald Alphonso**
> ""Says the man who bribed and extorted his way into the presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_PublicBlame == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_PublicBlame == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Ewald Alphonso: ""Says the man who prevaricated his way into the presidency.""*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_PublicBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Ewald Alphonso: ""Ideally, yes.""*)

### Węzeł `[86]`
Mówca: **Ewald Alphonso**
> ""Says the man who prevaricated his way into the presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[87]`
Mówca: **Ewald Alphonso**
> ""It's come down to that, has it? I wonder who's next on the chopping block...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[88]`
Mówca: **Narrator**
> "My response was cut off as the court justices filed in, led by Chief Justice Grecer in his full judge's regalia. Alphonso and I rose along with everyone else in the courtroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "After motioning for us to sit, the judge eyed Soll. A mir..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "My response was cut off as the court justices filed in, l..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "My response was cut off as the court justices filed in, l..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "My response was cut off as the court justices filed in, l..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "My response was cut off as the court justices filed in, led by Chief Justice Garaci in his full judge's regalia. Alphonso and I rose along with everyone else in the courtroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true || BaseGame.Ref..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "My response was cut off as the court justices filed in, led by Chief Justice Hawker in his full judge's regalia. Alphonso and I rose along with everyone else in the courtroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "After motioning for us to sit, the judge eyed Soll. A sli..."*)

### Węzeł `[97]`
Mówca: **Heron Garaci**
> ""Founder of the Sordish Republic, Former President Tarquin Soll. Former colonel and commander of the 6th Army of the Sordish Armed Forces, and the founder of the United Sordland Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Heron Garaci: ""You stand accused of 'multiple crimes against the state ..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "After motioning for us to sit, the judge eyed Soll. A slight smile played across his lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Orso Hawker: ""Founder of the Sordish Republic, Former President Tarqui..."*)

### Węzeł `[99]`
Mówca: **Orso Hawker**
> ""Founder of the Sordish Republic, Former President Tarquin Soll. Former colonel and commander of the 6th Army of the Sordish Armed Forces, and the founder of the United Sordland Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Orso Hawker: ""You stand accused of 'multiple alleged crimes against th..."*)

### Węzeł `[100]`
Mówca: **Orso Hawker**
> ""You stand accused of 'multiple alleged crimes against the state and the Sordish people' committed during your term in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "I could hear the quotation marks in his voice."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "I could hear the quotation marks in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Heron Garaci was seated next to him. He spoke in a bored-..."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "Heron Garaci was seated next to him. He spoke in a bored-sounding monotone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Heron Garaci: ""As President you allegedly abused your position for your..."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "After motioning for us to sit, he eyed Soll. A slight smile played across his lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Heron Garaci: ""Founder of the Sordish Republic, Former President Tarqui..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true || BaseGame.Ref..."*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true || BaseGame.R..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "After motioning for us to sit, he eyed Soll. A mirthless ..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "After motioning for us to sit, he eyed Soll. A slight smi..."*)

### Węzeł `[107]`
Mówca: **Heron Garaci**
> ""You stand accused of 'multiple crimes against the state and the Sordish people' committed during your term in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "I could hear the quotation marks in his voice."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "I could hear the quotation marks in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Gloria Tory was seated next to him. She spoke in an uncharacteristic monotone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Gloria Tory: ""As President you allegedly abused your position for your..."*)

### Węzeł `[110]`
Mówca: **Gloria Tory**
> ""As President you allegedly abused your position for your own personal benefit while undermining the Constitution you yourself created.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Gloria Tory: ""You are also being accused of inciting violence against ..."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "After motioning for us to sit, he eyed Soll. A mirthless smile played across his lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Heron Garaci: ""Former President Tarquin Soll. Former colonel and comman..."*)

### Węzeł `[112]`
Mówca: **Heron Garaci**
> ""Former President Tarquin Soll. Former colonel and commander of the 6th Army of the Sordish Armed Forces, and the founder of the United Sordland Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Heron Garaci: ""You stand accused of multiple crimes against the state a..."*)

### Węzeł `[113]`
Mówca: **Heron Garaci**
> ""You stand accused of multiple crimes against the state and the Sordish people committed during your time in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_GloriaJustice == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_GloriaJustice == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_GloriaJustice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Gloria Tory was seated next to him. She spoke in an uncha..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_GloriaJustice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_GloriaJustice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Isabel Edmonds was seated next to him. She began reading ..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "After motioning for us to sit, the judge eyed Soll. A mirthless smile played across his lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Ovid Grecer: ""Former President Tarquin Soll. Former colonel and comman..."*)

### Węzeł `[118]`
Mówca: **Ovid Grecer**
> ""Former President Tarquin Soll. Former colonel and commander of the 6th Army of the Sordish Armed Forces, and the founder of the United Sordland Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Ovid Grecer: ""You stand accused of multiple crimes against the state a..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Isabel Edmonds was seated next to him. She began reading off the piece of paper she was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Isabel Edmonds: ""As President you allegedly abused your position for your..."*)

### Węzeł `[120]`
Mówca: **Ovid Grecer**
> ""You stand accused of multiple crimes against the state and the Sordish people committed during your time in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Isabel Edmonds was seated next to him. She began reading ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)

### Węzeł `[124]`
Mówca: **Isabel Edmonds**
> ""As President you allegedly abused your position for your own personal benefit while undermining the Constitution you yourself created.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Isabel Edmonds: ""You are also being accused of inciting violence against ..."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "Heron Garaci was seated next to him. He spoke in a monotone, avoiding Soll's gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Heron Garaci: ""As President you allegedly abused your position for your..."*)

### Węzeł `[126]`
Mówca: **Heron Garaci**
> ""As President you allegedly abused your position for your own personal benefit while undermining the Constitution you yourself created.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Heron Garaci: ""You are also being accused of inciting violence against ..."*)

### Węzeł `[127]`
Mówca: **Isabel Edmonds**
> ""You are also being accused of inciting violence against the Bludish people during the construction of the Soll Dam at Erzaren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Italic: "Wait for the court's verdict."*)
  - -> `[135]` (*Player_Italic: "Introduce new false evidence against Soll."*)

### Węzeł `[128]`
Mówca: **Heron Garaci**
> ""You are also being accused of inciting violence against the Bludish people during the construction of the Soll Dam at Erzaren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Italic: "Wait for the court's verdict."*)
  - -> `[135]` (*Player_Italic: "Introduce new false evidence against Soll."*)

### Węzeł `[129]`
Mówca: **Gloria Tory**
> ""You are also being accused of inciting violence against the Bludish people during the construction of the Soll Dam at Erzaren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Italic: "Wait for the court's verdict."*)
  - -> `[135]` (*Player_Italic: "Introduce new false evidence against Soll."*)

### Węzeł `[130]`
Mówca: **Isabel Edmonds**
> ""As President you allegedly abused your position for your own personal benefit while undermining the Constitution you yourself created.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Isabel Edmonds: ""You are also being accused of inciting violence against ..."*)

### Węzeł `[131]`
Mówca: **Isabel Edmonds**
> ""You are also being accused of inciting violence against the Bludish people during the construction of the Soll Dam at Erzaren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Italic: "Wait for the court's verdict."*)
  - -> `[135]` (*Player_Italic: "Introduce new false evidence against Soll."*)

### Węzeł `[132]`
Mówca: **Heron Garaci**
> ""You are also being accused of inciting violence against the Bludish people during the construction of the Soll Dam at Erzaren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Italic: "Wait for the court's verdict."*)
  - -> `[135]` (*Player_Italic: "Introduce new false evidence against Soll."*)

### Węzeł `[133]`
Mówca: **Heron Garaci**
> ""As President you allegedly abused your position for your own personal benefit while undermining the Constitution you yourself created.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Heron Garaci: ""You are also being accused of inciting violence against ..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "Wait for the court's verdict."]** — Mówca: **Player_Italic**
> "I leaned forward in my seat, waiting for the verdict."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Isabel Edmonds), `[128]` (Heron Garaci), `[129]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "Introduce new false evidence against Soll."]** — Mówca: **Player_Italic**
> "I stood up and waved my hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Isabel Edmonds), `[128]` (Heron Garaci), `[129]` (Gloria Tory)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Heron Garaci: ""You have an objection, Mr. President?""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Orso Hawker: ""You have an objection, Mr. President?""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Ovid Grecer: ""You have an objection, Mr. President?""*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[142]`
Mówca: **Ovid Grecer**
> ""You have an objection, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player: ""No, never mind. Carry on.""*)
  - -> `[146]` (*Player: ""Yes. You're forgetting about the millions that Colonel S..."*)
  - -> `[542]` (*Player: ""Yes. You're forgetting about the deep state he establish..."*)

### Węzeł `[143]`
Mówca: **Heron Garaci**
> ""You have an objection, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player: ""No, never mind. Carry on.""*)
  - -> `[146]` (*Player: ""Yes. You're forgetting about the millions that Colonel S..."*)
  - -> `[542]` (*Player: ""Yes. You're forgetting about the deep state he establish..."*)

### Węzeł `[144]`
Mówca: **Orso Hawker**
> ""You have an objection, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player: ""No, never mind. Carry on.""*)
  - -> `[146]` (*Player: ""Yes. You're forgetting about the millions that Colonel S..."*)
  - -> `[542]` (*Player: ""Yes. You're forgetting about the deep state he establish..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA: ""No, never mind. Carry on.""]** — Mówca: **Player**
> ""No, never mind. Carry on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Ovid Grecer), `[143]` (Heron Garaci), `[144]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[146]`
**[WYBÓR GRACZA: ""Yes. You're forgetting about the millions that Colonel Soll embezzled from the state and squirreled away in foreign bank accounts.""]** — Mówca: **Player**
> ""Yes. You're forgetting about the millions that Colonel Soll embezzled from the state and squirreled away in foreign bank accounts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Ovid Grecer), `[143]` (Heron Garaci), `[144]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Chatter");"*)

### Węzeł `[147]`
Mówca: **Narrator**
> "The courtroom came alive with chatter. Alphonso stared at me, his mouth wide open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Ewald Alphonso: ""What? That's not even...""*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true || BaseGame.Ref..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Orso Hawker: ""The court will not tolerate such baseless accusations, P..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Ovid Grecer: ""I'm afraid the court wasn't provided with a proper evide..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[154]`
Mówca: **Ovid Grecer**
> ""I'm afraid the court wasn't provided with a proper evidence on this topic, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Soll twisted around in his seat to glare at me. I felt my..."*)

### Węzeł `[155]`
Mówca: **Heron Garaci**
> ""We, the Supreme Court, have thoroughly examined the facts and are prepared to deliver our final judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Heron Garaci: ""We find the defendant, Tarquin Soll...""*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true || BaseGame.Ref..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true || BaseGame.R..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Heron Garaci: ""I... of course. That's the third and final charge agains..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Heron Garaci: ""The court will not tolerate such baseless accusations, P..."*)

### Węzeł `[159]`
Mówca: **Heron Garaci**
> ""I... of course. That's the third and final charge against Colonel Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Soll twisted around in his seat to glare at me. I felt my..."*)

### Węzeł `[160]`
Mówca: **Heron Garaci**
> ""The court will not tolerate such baseless accusations, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Soll twisted around in his seat to glare at me. I felt my..."*)

### Węzeł `[161]`
Mówca: **Orso Hawker**
> ""The court will not tolerate such baseless accusations, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Soll twisted around in his seat to glare at me. I felt my..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "Soll twisted around in his seat to glare at me. I felt my cheeks burning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Tarquin Soll: ""That is a new low, boy. Even coming from you.""*)

### Węzeł `[163]`
Mówca: **Tarquin Soll**
> ""That is a new low, boy. Even coming from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Ovid Grecer: ""We, the Supreme Court, have thoroughly examined the fact..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Heron Garaci: ""We, the Supreme Court, have thoroughly examined the fact..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Orso Hawker: ""We, the Supreme Court, have thoroughly examined the fact..."*)

### Węzeł `[170]`
Mówca: **Ovid Grecer**
> ""We, the Supreme Court, have thoroughly examined the facts and are prepared to deliver our final judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Ovid Grecer: ""We find the defendant, Tarquin Soll...""*)

### Węzeł `[171]`
Mówca: **Orso Hawker**
> ""We, the Supreme Court, have thoroughly examined the facts and are prepared to deliver our final judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Orso Hawker: ""We find the defendant, Tarquin Soll...""*)

### Węzeł `[172]`
Mówca: **Heron Garaci**
> ""We find the defendant, Tarquin Soll...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true && BaseGame.Ref..."*)

### Węzeł `[173]`
Mówca: **Orso Hawker**
> ""We find the defendant, Tarquin Soll...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true && BaseGame.Ref..."*)

### Węzeł `[174]`
Mówca: **Ovid Grecer**
> ""We find the defendant, Tarquin Soll...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true && BaseGame.Ref..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true && BaseGame.Ref..."*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true && BaseGame.R..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true  and  Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Valken Kruger: ""Stop this trial at once!""*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true  and  Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Ovid Grecer: ""Guilty.""*)

### Węzeł `[178]`
Mówca: **Valken Kruger**
> ""Stop this trial at once!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_FormerPresidents_Tarquin..."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "Valken Kruger's deep, authoritative voice rang out from the back of the courtroom. Everyone turned to face him, looking confused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Valken Kruger: ""Mr. President, Your Honors -- I cannot in good conscienc..."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Soll, looking as serene as I'd ever seen him, barely blinked. Behind him, Karl Greiser reached for his firearm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Karl Greiser: ""General Kruger, with all due respect... you can't stop t..."*)

### Węzeł `[181]`
Mówca: **Valken Kruger**
> ""Mr. President, Your Honors -- I cannot in good conscience allow you to continue besmirching the name of Colonel Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "He gave a brief nod. Several dozen men in full military g..."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "He gave a brief nod. Several dozen men in full military gear strode past him into the courtroom, armed to the teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[183]`
Mówca: **Karl Greiser**
> ""General Kruger, with all due respect... you can't stop the trial. You don't have the power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Valken Kruger: ""Don't make me upset, *Mister* Greiser.""*)

### Węzeł `[184]`
Mówca: **Valken Kruger**
> ""Don't make me upset, *Mister* Greiser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Valken Kruger: ""President Rayne has given the military authority to inte..."*)

### Węzeł `[185]`
Mówca: **Valken Kruger**
> ""President Rayne has given the military authority to intervene in case of a national emergency. I'd say the father of our Republic being treated as a common criminal constitutes exactly such an emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: ""That isn't what I meant.""*)
  - -> `[187]` (*Player: ""General Kruger, I order you and your men to leave the co..."*)
  - -> `[188]` (*Player: ""Soll *is* a criminal. He's not your goddamn daddy.""*)

### Węzeł `[186]`
**[WYBÓR GRACZA: ""That isn't what I meant.""]** — Mówca: **Player**
> ""That isn't what I meant.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Valken Kruger: ""My apologies, Mr. President. Free Colonel Soll now, and ..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA: ""General Kruger, I order you and your men to leave the courtroom. Now.""]** — Mówca: **Player**
> ""General Kruger, I order you and your men to leave the courtroom. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Valken Kruger: ""My apologies, Mr. President. Free Colonel Soll now, and ..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA: ""Soll *is* a criminal. He's not your goddamn daddy.""]** — Mówca: **Player**
> ""Soll *is* a criminal. He's not your goddamn daddy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Valken Kruger: ""My apologies, Mr. President. Free Colonel Soll now, and ..."*)

### Węzeł `[189]`
Mówca: **Valken Kruger**
> ""My apologies, Mr. President. Free Colonel Soll now, and I promise nobody will get hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true || BaseGame.Ref..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "I glanced at Orso. He smirked back at me triumphantly."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "I glanced at Ovid. He looked back at me helplessly."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[196]`
Mówca: **Narrator**
> "I glanced at Ovid. He looked back at me helplessly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: ""All right. Uncuff him.""*)
  - -> `[204]` (*Player: ""You win again, Colonel.""*)

### Węzeł `[197]`
Mówca: **Narrator**
> "I glanced at Heron. He looked back at me helplessly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: ""All right. Uncuff him.""*)
  - -> `[204]` (*Player: ""You win again, Colonel.""*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true || BaseGame.Ref..."*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true || BaseGame.R..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "I glanced at Heron. He looked back at me helplessly."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "I glanced at Heron. He looked like he was trying very har..."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "I glanced at Heron. He looked like he was trying very hard not to laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: ""All right. Uncuff him.""*)
  - -> `[204]` (*Player: ""You win again, Colonel.""*)
  - -> `[205]` (*Player: ""You... did you plan this?""*)

### Węzeł `[202]`
Mówca: **Narrator**
> "I glanced at Orso. He smirked back at me triumphantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player: ""All right. Uncuff him.""*)
  - -> `[204]` (*Player: ""You win again, Colonel.""*)
  - -> `[205]` (*Player: ""You... did you plan this?""*)

### Węzeł `[203]`
**[WYBÓR GRACZA: ""All right. Uncuff him.""]** — Mówca: **Player**
> ""All right. Uncuff him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Narrator), `[197]` (Narrator), `[201]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[204]`
**[WYBÓR GRACZA: ""You win again, Colonel.""]** — Mówca: **Player**
> ""You win again, Colonel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Narrator), `[197]` (Narrator), `[201]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[205]`
**[WYBÓR GRACZA: ""You... did you plan this?""]** — Mówca: **Player**
> ""You... did you plan this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Narrator), `[202]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Heron merely shrugged."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Orso merely shrugged."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "Heron merely shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[210]`
Mówca: **Narrator**
> "Orso merely shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[211]`
Mówca: **Narrator**
> "Without taking his eyes off Valken Kruger, Karl reluctantly unlocked Soll's handcuffs. As soon as his hands were free, Soll beckoned for me to approach the bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled = true"*)

### Węzeł `[212]`
Mówca: **Tarquin Soll**
> ""Did you really think you could get rid of me that easily?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Acquitted == true"*)
  - -> `[215]` (*Player: ""You'll pay for everything you've done, Soll.""*)
  - -> `[213]` (*Player: ""A boy can dream.""*)

### Węzeł `[213]`
**[WYBÓR GRACZA: ""A boy can dream.""]** — Mówca: **Player**
> ""A boy can dream.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Tarquin Soll: ""Show some respect. Without me, Sordland would be a backw..."*)

### Węzeł `[214]`
**[WYBÓR GRACZA: ""The military won't always be your lapdog, you know.""]** — Mówca: **Player**
> ""The military won't always be your lapdog, you know.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[212]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Tarquin Soll: ""No. Just long enough to let me live out my last few year..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA: ""You'll pay for everything you've done, Soll.""]** — Mówca: **Player**
> ""You'll pay for everything you've done, Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Tarquin Soll: ""Everything **I've** done? Oh, Anton.""*)

### Węzeł `[216]`
Mówca: **Tarquin Soll**
> ""Everything **I've** done? Oh, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true || BaseGame.Sec..."*)

### Węzeł `[217]`
Mówca: **Tarquin Soll**
> ""Authorizing armed attacks on innocents to protect your own interests? Don't pretend you're somehow better than I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Tarquin Soll: ""The only difference between you and me is that I will be..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true || BaseGame.Security_Unrest_Police == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true || BaseGame.Sec..."*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true || BaseGame.S..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true || BaseGame.Security_Unrest_Police == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true  or  Variable["BaseGame.Security_Unrest_Police"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true || BaseGame.Security_Unrest_Police == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true  or  Variable["BaseGame.Security_Unrest_Police"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Tarquin Soll: ""Considering your own abominable treatment of our citizen..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Tarquin Soll: ""Stoking the Bludish conflict? Authorizing armed attacks ..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Tarquin Soll: ""Authorizing armed attacks on innocents to protect your o..."*)

### Węzeł `[224]`
Mówca: **Tarquin Soll**
> ""Stoking the Bludish conflict? Authorizing armed attacks on innocents to protect your own interests? Don't pretend you're somehow better than I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Tarquin Soll: ""The only difference between you and me is that I will be..."*)

### Węzeł `[225]`
Mówca: **Tarquin Soll**
> ""Considering your own abominable treatment of our citizens, you're no better than I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Tarquin Soll: ""The only difference between you and me is that I will be..."*)

### Węzeł `[226]`
Mówca: **Tarquin Soll**
> ""The only difference between you and me is that I will be remembered as a hero, and you -- well, you'll be lucky to be remembered at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "He straightened his tie and smoothly motioned for the guards to escort him out of the courthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "My legs suddenly felt as if they were about to give way. ..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true && BaseGame.Ref..."*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true && BaseGame.R..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true  and  Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Valken Kruger: ""Stop this trial at once!""*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true  and  Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true || BaseGame.Ref..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true && BaseGame.Ref..."*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true && BaseGame.R..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true  and  Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Valken Kruger: ""Stop this trial at once!""*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true && BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true  and  Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Orso Hawker: ""Not guilty.""*)

### Węzeł `[234]`
Mówca: **Ovid Grecer**
> ""Guilty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gasp");"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content == true || BaseGame.Ref..."*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_OldGuard_Content == true || BaseGame.R..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Heron Garaci: ""Not guilty.""*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_OldGuard_Content == true || BaseGame.Reform_Reform_Heron_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_OldGuard_Content"] == true  or  Variable["BaseGame.Reform_Reform_Heron_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Heron Garaci: ""Guilty.""*)

### Węzeł `[238]`
Mówca: **Heron Garaci**
> ""Guilty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Gasp");"*)

### Węzeł `[239]`
Mówca: **Heron Garaci**
> ""Not guilty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_SollTrial_NotGuilty = true"*)

### Węzeł `[240]`
Mówca: **Orso Hawker**
> ""Not guilty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_SollTrial_NotGuilty = true"*)

### Węzeł `[241]`
Mówca: **Ewald Alphonso**
> ""You did it. You actually did it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true"*)

### Węzeł `[242]`
Mówca: **Narrator**
> "The courtroom collectively gasped. Next to me, Alphonso mock-applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Ewald Alphonso: ""You did it. You actually did it.""*)

### Węzeł `[243]`
Mówca: **Narrator**
> "Orso smirked triumphantly. Alphonso crumpled his hat in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Ewald Alphonso: ""You never did stand much of a chance. But bravo for tryi..."*)

### Węzeł `[244]`
Mówca: **Narrator**
> "Heron smirked triumphantly. Alphonso crumpled his hat in his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Ewald Alphonso: ""You never did stand much of a chance. But bravo for tryi..."*)

### Węzeł `[245]`
Mówca: **Ewald Alphonso**
> ""You never did stand much of a chance. But bravo for trying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Orso Hawker: ""Colonel Soll, I hope you will forgive us for forcing you..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == ..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Ovid Grecer: ""Tarquin Soll, for the magnitude of your crimes against t..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Ovid Grecer: ""Tarquin Soll, for the magnitude of your crimes against t..."*)

### Węzeł `[249]`
Mówca: **Ovid Grecer**
> ""Tarquin Soll, for the magnitude of your crimes against the state and humanity, I hereby sentence you to death by execution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death = true"*)

### Węzeł `[250]`
Mówca: **Ovid Grecer**
> ""Tarquin Soll, for the magnitude of your crimes against the state and humanity, I hereby sentence you to life in prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison = true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == ..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Heron Garaci: ""Tarquin Soll, for the magnitude of your crimes against t..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_CapitalPunishment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Heron Garaci: ""Tarquin Soll, for the magnitude of your crimes against t..."*)

### Węzeł `[254]`
Mówca: **Heron Garaci**
> ""Tarquin Soll, for the magnitude of your crimes against the state and humanity, I hereby sentence you to death by execution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death = true"*)

### Węzeł `[255]`
Mówca: **Heron Garaci**
> ""Tarquin Soll, for the magnitude of your crimes against the state and humanity, I hereby sentence you to life in prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison = true"*)

### Węzeł `[256]`
Mówca: **Narrator**
> "The courtroom collectively gasped. Soll fixed Heron with a disbelieving stare. Next to me, Alphonso broke out in mock-applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Ewald Alphonso: ""You did it. You actually did it.""*)

### Węzeł `[257]`
Mówca: **Ewald Alphonso**
> ""You did it. You actually did it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_CapitalPunishment == true"*)

### Węzeł `[258]`
Mówca: **Ewald Alphonso**
> ""You never did stand much of a chance. But bravo for trying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Heron Garaci: ""Colonel Soll, I hope you will forgive us for forcing you..."*)

### Węzeł `[259]`
Mówca: **Heron Garaci**
> ""Colonel Soll, I hope you will forgive us for forcing you to endure this charade. I hereby declare this case closed and the court adjourned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Soll bowed his head in mock humility."*)

### Węzeł `[260]`
Mówca: **Orso Hawker**
> ""Colonel Soll, I hope you will forgive us for forcing you to endure this charade. I hereby declare this case closed and the court adjourned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "Soll bowed his head in mock humility."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "Someone in the room shrieked. For his part, Soll barely blinked. He looked as serene as I'd ever seen him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Ovid Grecer: ""Court is now adjourned. Guards, you may escort Colonel S..."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "Someone in the room shrieked. For his part, Soll barely blinked. He looked as serene as I'd ever seen him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Heron Garaci: ""Court is now adjourned. Guards, you may escort Colonel S..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "Soll barely blinked. He looked as serene as I'd ever seen him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Ovid Grecer: ""Court is now adjourned. Guards, you may escort Colonel S..."*)

### Węzeł `[264]`
Mówca: **Narrator**
> "Soll barely blinked. He looked as serene as I'd ever seen him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Heron Garaci: ""Court is now adjourned. Guards, you may escort Colonel S..."*)

### Węzeł `[265]`
Mówca: **Ovid Grecer**
> ""Court is now adjourned. Guards, you may escort Colonel Soll to his cell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[266]`
Mówca: **Heron Garaci**
> ""Court is now adjourned. Guards, you may escort Colonel Soll to his cell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[267]`
Mówca: **Narrator**
> "With a grim smile on his face, Karl roughly pulled Soll onto his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "As he stood, Soll looked straight at me and twitched the ..."*)

### Węzeł `[268]`
Mówca: **Narrator**
> "As he stood, Soll looked straight at me and twitched the fingers of one of his cuffed hands, beckoning me to approach the bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "Jump to: [Soll Last Talk]"*)

### Węzeł `[269]`
Mówca: **Tarquin Soll**
> ""Well, are you happy? You've robbed an old man of his last few years of peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player: ""You don't deserve peace after everything you've done.""*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[272]` (*Player: ""I'm happy justice has been served.""*)

### Węzeł `[270]`
**[WYBÓR GRACZA: ""You don't deserve peace after everything you've done.""]** — Mówca: **Player**
> ""You don't deserve peace after everything you've done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Tarquin Soll: ""Everything **I've** done? Oh, Anton.""*)

### Węzeł `[271]`
**[WYBÓR GRACZA: ""You can find peace in your cell.""]** — Mówca: **Player**
> ""You can find peace in your cell.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[269]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Tarquin Soll: ""Show some respect. Without me, Sordland would be a backw..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA: ""I'm happy justice has been served.""]** — Mówca: **Player**
> ""I'm happy justice has been served.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true || BaseGame.Sec..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA: ""You've still got eternal peace to look forward to. Maybe.""]** — Mówca: **Player**
> ""You've still got eternal peace to look forward to. Maybe.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Kontekst wejściowy (poprzednik):** `[269]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Tarquin Soll: ""Show some respect. Without me, Sordland would be a backw..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Soll Last Talk`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Acquitted == true || Ba..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Soll Last Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "Soll Last Talk"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Soll Last Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "Soll Last Talk"*)

### Węzeł `[277]`
Mówca: **Narrator**
> "Soll bowed his head in mock humility."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_FormerPresidents_Tarquin..."*)

### Węzeł `[278]`
Mówca: **Tarquin Soll**
> ""We all must make sacrifices in order for democracy to function. Mr. Greiser, if you will, these cuffs are beginning to chafe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Acquitted = true"*)

### Węzeł `[279]`
Mówca: **Narrator**
> "With a reluctant sigh, Karl unlocked the handcuffs. As soon as he was free, Soll beckoned me to approach the bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "Jump to: [Soll Last Talk]"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Soll Last Talk]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "Soll Last Talk"*)

### Węzeł `[281]`
Mówca: **Tarquin Soll**
> ""No. Just long enough to let me live out my last few years in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player: ""You don't deserve peace after everything you've done.""*)
  - -> `[365]` (*Player: ""A villain like you doesn't deserve peace.""*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Acquitted == true || BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Acquitted == true || Ba..."*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Acquitted == true || ..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Acquitted == true || BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Tarquin Soll: ""Did you really think you could get rid of me that easily?""*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Acquitted == true || BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Tarquin Soll: ""Well, are you happy? You've robbed an old man of his las..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player: ""You've still got eternal peace to look forward to. Maybe.""*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player: ""You can find peace in your cell.""*)

### Węzeł `[288]`
**[WYBÓR GRACZA: ""The courts won't always be your lapdog, you know.""]** — Mówca: **Player**
> ""The courts won't always be your lapdog, you know.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true`
- **Kontekst wejściowy (poprzednik):** `[212]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Tarquin Soll: ""No. Just long enough to let me live out my last few year..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Acquitted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Acquitted == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Acquitted == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Acquitted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: ""The courts won't always be your lapdog, you know.""*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Acquitted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player: ""The military won't always be your lapdog, you know.""*)

### Węzeł `[292]`
**[WYBÓR GRACZA: ""You don't deserve peace after everything you've done.""]** — Mówca: **Player**
> ""You don't deserve peace after everything you've done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Tarquin Soll: ""Everything **I've** done? Oh, Anton.""*)

### Węzeł `[293]`
Mówca: **Tarquin Soll**
> ""Show some respect. Without me, Sordland would be a backwater. And you'd be nobody.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player: ""Better a nobody than a villain like you.""*)
  - -> `[307]` (*Player: ""That may be true. But it still doesn't make up for every..."*)

### Węzeł `[294]`
Mówca: **Tarquin Soll**
> ""If there was any such thing as justice, you'd be headed straight to the chair with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true || BaseGame.Sec..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Tarquin Soll: ""If there was any such thing as justice, you'd be headed ..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Tarquin Soll: ""If there was any such thing as justice, you'd be headed ..."*)

### Węzeł `[298]`
Mówca: **Tarquin Soll**
> ""If there was any such thing as justice, you'd be headed straight to prison with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true || BaseGame.Sec..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true || BaseGame.Security_Unrest_Police == true || BaseGame.Unrest_BFF_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true || BaseGame.Sec..."*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true || BaseGame.S..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true || BaseGame.Security_Unrest_Police == true || BaseGame.Unrest_BFF_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true  or  Variable["BaseGame.Security_Unrest_Police"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true || BaseGame.Security_Unrest_Police == true || BaseGame.Unrest_BFF_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true  or  Variable["BaseGame.Security_Unrest_Police"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Tarquin Soll: ""You see it as justice. The rest of Sordland may see it d..."*)

### Węzeł `[302]`
**[WYBÓR GRACZA: ""Better a nobody than a villain like you.""]** — Mówca: **Player**
> ""Better a nobody than a villain like you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Tarquin Soll: ""Me, a villain? Oh, Anton.""*)

### Węzeł `[303]`
Mówca: **Tarquin Soll**
> ""Me, a villain? Oh, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true || BaseGame.Sec..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true || BaseGame.Security_Unrest_Police == true || BaseGame.Unrest_BFF_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true || BaseGame.Sec..."*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true || BaseGame.S..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true || BaseGame.Security_Unrest_Police == true || BaseGame.Unrest_BFF_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true  or  Variable["BaseGame.Security_Unrest_Police"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true || BaseGame.Sec..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true || BaseGame.Security_Unrest_Police == true || BaseGame.Unrest_BFF_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true  or  Variable["BaseGame.Security_Unrest_Police"] == true  or  Variable["BaseGame.Unrest_BFF_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Tarquin Soll: ""You see me as a villain. The rest of Sordland may see it..."*)

### Węzeł `[307]`
**[WYBÓR GRACZA: ""That may be true. But it still doesn't make up for everything you've done.""]** — Mówca: **Player**
> ""That may be true. But it still doesn't make up for everything you've done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Tarquin Soll: ""Everything **I've** done? Oh, Anton.""*)

### Węzeł `[308]`
Mówca: **Tarquin Soll**
> ""You see it as justice. The rest of Sordland may see it differently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[309]`
Mówca: **Tarquin Soll**
> ""You see me as a villain. The rest of Sordland may see it differently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Tarquin Soll: ""For all your efforts, you've only succeeded in turning m..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Tarquin Soll: ""For all your efforts, you've only succeeded in making yo..."*)

### Węzeł `[313]`
Mówca: **Tarquin Soll**
> ""For all your efforts, you've only succeeded in turning me into a martyr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Tarquin Soll: ""The end result is the same. I will be remembered as a he..."*)

### Węzeł `[314]`
Mówca: **Tarquin Soll**
> ""For all your efforts, you've only succeeded in making yourself look weak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Tarquin Soll: ""The end result is the same. I will be remembered as a he..."*)

### Węzeł `[315]`
Mówca: **Tarquin Soll**
> ""The end result is the same. I will be remembered as a hero, and you -- well, you'll be lucky to be remembered at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true |..."*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "After one last look at me, he turned his back and allowed..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true || BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true  or  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true"*)

### Węzeł `[319]`
Mówca: **Narrator**
> "After one last look at me, he turned his back and allowed the guards to escort him out of the courthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)

### Węzeł `[320]`
Mówca: **Narrator**
> "My legs suddenly felt as if they were about to give way. I collapsed in the nearest chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_OldGuard_Content = false"*)

### Węzeł `[321]`
Mówca: **Narrator**
> "I stayed there as Alphonso left, then the rest of the spectators, then the justices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "Jump to: [Soll Last Talk]"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_SollTrial_Guilty_Death = true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_FormerPresidents_Tarquin..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_SollTrial_Guilty_Prison = ..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_FormerPresidents_Tarquin..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Acquitted = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "With a reluctant sigh, Karl unlocked the handcuffs. As so..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == t..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "He straightened his tie and smoothly motioned for Kruger'..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "He straightened his tie and smoothly motioned for the gua..."*)

### Węzeł `[331]`
Mówca: **Narrator**
> "He straightened his tie and smoothly motioned for Kruger's men to escort him out of the courthouse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "My legs suddenly felt as if they were about to give way. ..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Honorary_NoImmunity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Honorary_NoImmunity == true"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Honorary_NoImmunity == true)"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Honorary_NoImmunity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Ewald Alphonso: ""I'm surprised you weren't tempted to grant yourself immu..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Honorary_NoImmunity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Ewald Alphonso: ""Although it would've been nice to grab some of those Mem..."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "Isabel Edmonds was seated next to him. She began reading off the piece of paper she was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Isabel Edmonds: ""As President you allegedly abused your position for your..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_Shuffled == true)"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Ovid Grecer: ""As President you allegedly abused your position for your..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_Shuffled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "Heron Garaci was seated next to him. He spoke in a monoto..."*)

### Węzeł `[339]`
Mówca: **Ovid Grecer**
> ""As President you allegedly abused your position for your own personal benefit while undermining the Constitution you yourself created.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Ovid Grecer: ""You are also being accused of inciting violence against ..."*)

### Węzeł `[340]`
Mówca: **Ovid Grecer**
> ""You are also being accused of inciting violence against the Bludish people during the construction of the Soll Dam at Erzaren.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Italic: "Wait for the court's verdict."*)
  - -> `[135]` (*Player_Italic: "Introduce new false evidence against Soll."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "Soll, looking as serene as I'd ever seen him, barely blin..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Soll, looking as serene as I'd ever seen him, barely blin..."*)

### Węzeł `[344]`
Mówca: **Narrator**
> "Soll, looking as serene as I'd ever seen him, barely blinked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Valken Kruger: ""President Rayne has given the military authority to inte..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Narrator: "Without taking their eyes off Valken Kruger, the guards r..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "Without taking his eyes off Valken Kruger, Karl reluctant..."*)

### Węzeł `[348]`
Mówca: **Narrator**
> "Without taking their eyes off Valken Kruger, the guards reluctantly unlocked Soll's handcuffs. As soon as his hands were free, Soll beckoned for me to approach the bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled = true"*)

### Węzeł `[349]`
Mówca: **Narrator**
> "Tarquin Soll entered the courtroom, escorted by at least half a dozen guards. His hands were cuffed, but he held his head defiantly high as they walked him to the defendant's seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Ewald Alphonso: ""How the mighty have fallen. I can't say it entirely sadd..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "Tarquin Soll entered the courtroom, escorted by at least ..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Tarquin Soll entered the courtroom, escorted by Karl Grei..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "With a grim smile on his face, a guard roughly pulled Sol..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "With a grim smile on his face, Karl roughly pulled Soll o..."*)

### Węzeł `[356]`
Mówca: **Narrator**
> "With a grim smile on his face, a guard roughly pulled Soll onto his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "As he stood, Soll looked straight at me and twitched the ..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Fired_KarlGreiser == true)"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Fired_KarlGreiser == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Tarquin Soll: ""We all must make sacrifices in order for democracy to fu..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Fired_KarlGreiser == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Tarquin Soll: ""We all must make sacrifices in order for democracy to fu..."*)

### Węzeł `[360]`
Mówca: **Tarquin Soll**
> ""We all must make sacrifices in order for democracy to function.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "He turned to the guards."*)

### Węzeł `[361]`
Mówca: **Narrator**
> "He turned to the guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Tarquin Soll: ""If you will, these cuffs are beginning to chafe.""*)

### Węzeł `[362]`
Mówca: **Tarquin Soll**
> ""If you will, these cuffs are beginning to chafe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Acquitted = true"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Acquitted = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "With a reluctant sigh, the guards unlocked the handcuffs...."*)

### Węzeł `[364]`
Mówca: **Narrator**
> "With a reluctant sigh, the guards unlocked the handcuffs. As soon as he was free, Soll beckoned me to approach the bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "Jump to: [Soll Last Talk]"*)

### Węzeł `[365]`
**[WYBÓR GRACZA: ""A villain like you doesn't deserve peace.""]** — Mówca: **Player**
> ""A villain like you doesn't deserve peace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Tarquin Soll: ""Me, a villain? Oh, Anton.""*)

### Węzeł `[366]`
Mówca: **Ewald Alphonso**
> ""Ideally, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[367]`
Mówca: **Ewald Alphonso**
> ""I'm surprised you weren't tempted to grant yourself immunity along with him, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player: ""No president, current or former, should be above the law.""*)
  - -> `[70]` (*Player: ""That was Soll's pet status. It should die with him.""*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true"*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1;"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 5;"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 3;"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 3;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion += 2;"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion += 2;"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion += 2;"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1;"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion += 5;"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 10;"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion += 5;"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion += 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 10;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 10;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion += 5;"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 5;"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_A_SollTrial = true"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Iosef_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "My legs suddenly felt as if they were about to give way. ..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy = true"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "My legs suddenly felt as if they were about to give way. ..."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_OldGuard_Content = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Faction_OldGuard_Content"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Narrator: "I stayed there as Alphonso left, then the rest of the spe..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_SollTrial_NotGuilty = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_SollTrial_NotGuilty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "Heron smirked triumphantly. Alphonso crumpled his hat in ..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_SollTrial_NotGuilty = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_SollTrial_NotGuilty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "Orso smirked triumphantly. Alphonso crumpled his hat in h..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_SollTrial_Intervention = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_SollTrial_Intervention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "Valken Kruger's deep, authoritative voice rang out from t..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_SollTrial_Guilty_Death = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_SollTrial_Guilty_Death"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_FormerPresidents_Tarquin..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_SollTrial_Guilty_Prison = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_SollTrial_Guilty_Prison"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_FormerPresidents_Tarquin..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_R_SollTrial_Death = true;
BaseGameSupport.News_Turn09_HP_SollTrial_Death = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_R_SollTrial_Death"] = true;
Variable["BaseGameSupport.News_Turn09_HP_SollTrial_Death"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_R_SollTrial_Prison = true;
BaseGameSupport.News_Turn09_HP_SollTrial_Prison = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_R_SollTrial_Prison"] = true;
Variable["BaseGameSupport.News_Turn09_HP_SollTrial_Prison"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_SollTrial_NotGuilty = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_SollTrial_NotGuilty"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true"*)
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == t..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_MilitaryCanceled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_LT_SollTrial_NotGuilty = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_LT_SollTrial_NotGuilty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_R_SollTrial_Death = true; Bas..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_R_SollTrial_Prison = true; Ba..."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_LT_SollTrial_NotGuilty = true"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_SollTrial_NotGuilty = true;"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_A_SollTrial = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_A_SollTrial"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_SollTrial_Intervention = true"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled = true; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled"] = true;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "Someone in the room shrieked. For his part, Soll barely b..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty = true; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty"] = true;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "Soll barely blinked. He looked as serene as I'd ever seen..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty = true; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty"] = true;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "Soll barely blinked. He looked as serene as I'd ever seen..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled = true; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled"] = true;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "Someone in the room shrieked. For his part, Soll barely b..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved = false; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt = true; BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuilty"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_FoundGuiltyKilled"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_MemberofHonorRemoved"] = false;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedAtCourt"] = true;
Variable["BaseGameSupport.Codex_Characters_FormerPresidents_TarquinSoll_TrialFailedValkenSaves"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[435]`
Mówca: **Narrator**
> "Only when the courtroom had completely emptied out did I gather all my strength, get up and leave to face the crowd of reporters outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Narrator: "Only when the courtroom had completely emptied out did I ..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Narrator: "Only when the courtroom had completely emptied out did I ..."*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "Only when the courtroom had completely emptied out did I ..."*)

### Węzeł `[442]`
Mówca: **Narrator**
> "Only when the courtroom had completely emptied out did I gather all my strength, get up and leave to face the crowd of reporters outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true"*)

### Węzeł `[443]`
Mówca: **Narrator**
> "Only when the courtroom had completely emptied out did I gather all my strength, get up and leave to face the crowd of reporters outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == true"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[445]`
Mówca: **Ewald Alphonso**
> ""After all we've been through together? Well, I guess the trial of the century is quite a formal occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead == true"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downs..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Narrator: "He looked more haggard than he had at Petr's villa. When ..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "He looked happier than he had back at Petr's villa. Color..."*)

### Węzeł `[449]`
Mówca: **Narrator**
> "He looked more haggard than he had at Petr's villa. When he removed his hat, I saw a bald spot on the back of his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Italic: "Go talk to him."*)
  - -> `[57]` (*Player_Italic: "Pretend you don't notice him."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Friendly == true)"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Ewald Alphonso: ""Anton! It's been a while.""*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Friendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Ewald Alphonso: ""Mr. Rayne. It's been a while.""*)

### Węzeł `[453]`
Mówca: **Ewald Alphonso**
> ""Mr. Rayne. It's been a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: ""That's President Rayne to you.""*)
  - -> `[467]` (*Player: ""It has indeed, Mr. Alphonso.""*)
  - -> `[60]` (*Player: ""Mr. Alphonso. To what do we owe this pleasure?""*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Petr_Dead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead == true"*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Petr_Dead == true)"*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Petr_Dead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Petr_Dead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Ewald Alphonso: ""By the way, I'm sorry I couldn't attend Mr. Vectern's fu..."*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Petr_Dead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Petr_Dead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)

### Węzeł `[457]`
Mówca: **Ewald Alphonso**
> ""By the way, I'm sorry I couldn't attend Mr. Vectern's funeral. I always liked the man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Player: ""Thank you for your condolences.""*)
  - -> `[459]` (*Player: ""No apology necessary. I'm sure Gasom has kept you busy.""*)
  - -> `[460]` (*Player: ""Everyone did. But he had his dark side.""*)

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for your condolences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[457]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Ewald Alphonso: ""Of course. It must be a difficult time for you.""*)

### Węzeł `[459]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No apology necessary. I'm sure Gasom has kept you busy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[457]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Everyone did. But he had his dark side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[457]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Ewald Alphonso: ""Evidently so.""*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce == true"*)
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Divorce == true)"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Ewald Alphonso: ""By the way, I was sorry to hear about Mrs. Rayne. Welcom..."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Divorce == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Ewald Alphonso: ""But how have you been? Still trying to lead Sordland out..."*)

### Węzeł `[464]`
Mówca: **Ewald Alphonso**
> ""By the way, I was sorry to hear about Mrs. Rayne. Welcome to the club of divorced Sordish presidents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Player: ""No need to be sorry. I'm a free man now.""*)
  - -> `[469]` (*Player: ""It's no wonder neither of us could hold on to a wife. So..."*)
  - -> `[470]` (*Player: ""I'm not quite ready to talk about it yet.""*)
  - -> `[471]` (*Player: ""At least yours left you after you'd already lost the pre..."*)

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No need to be sorry. I'm a free man now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Ewald Alphonso: ""Ha. No president of Sordland is ever free. Once this cou..."*)

### Węzeł `[466]`
Mówca: **Ewald Alphonso**
> ""I couldn't stay home and miss the trial of the century. I still can't believe you got the old man indicted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead == true"*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It has indeed, Mr. Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[453]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Ewald Alphonso: ""The trial of the century, they're calling it. I must say..."*)

### Węzeł `[468]`
Mówca: **Ewald Alphonso**
> ""The trial of the century, they're calling it. I must say I have mixed feelings about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_Dead == true"*)

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's no wonder neither of us could hold on to a wife. Sordland is a demanding mistress.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Ewald Alphonso: ""I take it you're finally beginning to understand all the..."*)

### Węzeł `[470]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not quite ready to talk about it yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Ewald Alphonso: ""I understand. I was a mess after my wife left. Thank God..."*)

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""At least yours left you after you'd already lost the presidency. I'm worried about my public opinion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[464]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "He frowned."*)

### Węzeł `[472]`
Mówca: **Ewald Alphonso**
> ""Evidently so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downs..."*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Narrator: "His eyes darkened."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Narrator: "He smiled."*)

### Węzeł `[476]`
Mówca: **Narrator**
> "His eyes darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Ewald Alphonso: ""That's a conversation for another day, Mr. President.""*)

### Węzeł `[477]`
Mówca: **Ewald Alphonso**
> ""That's a conversation for another day, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true || BaseGame.Joine..."*)

### Węzeł `[478]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Ewald Alphonso: ""Actually, I'm a retiree now. I can rest easy, knowing my..."*)

### Węzeł `[479]`
Mówca: **Ewald Alphonso**
> ""Actually, I'm a retiree now. I can rest easy, knowing my legacy is safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Ownership_ForeignOwned == true"*)

### Węzeł `[480]`
Mówca: **Ewald Alphonso**
> ""Of course. It must be a difficult time for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downs..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Ewald Alphonso: ""So I won't bring up the whole Gasom quagmire. That's a c..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Ewald Alphonso: ""How have you been otherwise? Still trying to lead Sordla..."*)

### Węzeł `[484]`
Mówca: **Ewald Alphonso**
> ""So I won't bring up the whole Gasom quagmire. That's a conversation for another day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true || BaseGame.Joine..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Ownership_ForeignOwned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Ownership_ForeignOwned == true"*)
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Ownership_ForeignOwned == true)"*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Ownership_ForeignOwned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Ownership_ForeignOwned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Ewald Alphonso: ""Albeit in foreign hands. But that's a conversation for a..."*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Ownership_ForeignOwned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Ownership_ForeignOwned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Ewald Alphonso: ""How have you been otherwise? Still trying to lead Sordla..."*)

### Węzeł `[488]`
Mówca: **Ewald Alphonso**
> ""Albeit in foreign hands. But that's a conversation for another day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true || BaseGame.Joine..."*)

### Węzeł `[489]`
Mówca: **Narrator**
> "He frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[490]`
Mówca: **Ewald Alphonso**
> ""You really do have a heart of stone, don't you, Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true || BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true || BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downs..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true || BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true || BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true  or  Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Ewald Alphonso: ""You really do have a heart of stone, don't you, Rayne?""*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true || BaseGame.Confrontation_USP_EnergyAct_RevertedTo10 == true || BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true  or  Variable["BaseGame.Confrontation_USP_EnergyAct_RevertedTo10"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Ewald Alphonso: ""That's... pragmatic of you.""*)

### Węzeł `[494]`
Mówca: **Ewald Alphonso**
> ""That's... pragmatic of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[495]`
Mówca: **Ewald Alphonso**
> ""I understand. I was a mess after my wife left. Thank God it didn't happen while I was still in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[496]`
Mówca: **Ewald Alphonso**
> ""I take it you're finally beginning to understand all the challenges I was up against.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[497]`
Mówca: **Ewald Alphonso**
> ""Ha. No president of Sordland is ever free. Once this country has you in its grip, there's no wriggling out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downs..."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Ewald Alphonso: ""I know it's a difficult time for you, so I'll refrain fr..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Ewald Alphonso: ""How have you been otherwise? Still trying to lead Sordla..."*)

### Węzeł `[501]`
Mówca: **Ewald Alphonso**
> ""I know it's a difficult time for you, so I'll refrain from bringing up the whole Gasom quagmire. That's a conversation for another day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true || BaseGame.Joine..."*)

### Węzeł `[502]`
Mówca: **Ewald Alphonso**
> ""But how have you been? Still trying to lead Sordland out of the mess I made?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Player: ""Your mess isn't what keeps me up at night. It's Soll's.""*)
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 3"*)
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true || BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true || BaseGame.Joine..."*)
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true || BaseGame.Joi..."*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true || BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Ewald Alphonso: ""As is the one about your full-on embrace of Malenyevism...."*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true || BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true  or  Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 3"*)

### Węzeł `[506]`
Mówca: **Ewald Alphonso**
> ""As is the one about your full-on embrace of Malenyevism. My God, if there's anything Soll and I would agree on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Ewald Alphonso: ""But speak of the devil.""*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true || BaseGame.Gasom_Ownership_ForeignOwned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downs..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true || BaseGame.Gasom_Ownership_ForeignOwned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true  or  Variable["BaseGame.Gasom_Ownership_ForeignOwned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Player: ""Do you mean Gasom? Because yes, that is a mess.""*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsized == true || BaseGame.Gasom_Ownership_ForeignOwned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true  or  Variable["BaseGame.Gasom_Ownership_ForeignOwned"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[510]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you mean Gasom? Because yes, that is a mess.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Gasom_Bankrupt"] == true  or  Variable["BaseGame.Gasom_Downsized"] == true  or  Variable["BaseGame.Gasom_Ownership_ForeignOwned"] == true`
- **Kontekst wejściowy (poprzednik):** `[502]` (Ewald Alphonso), `[513]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Ewald Alphonso: ""What happened to Gasom was nowhere near my fault. But th..."*)

### Węzeł `[511]`
Mówca: **Ewald Alphonso**
> ""What happened to Gasom was nowhere near my fault. But that's a conversation for another day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true || BaseGame.Joine..."*)

### Węzeł `[512]`
Mówca: **Ewald Alphonso**
> ""But speak of the devil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[513]`
Mówca: **Ewald Alphonso**
> ""How have you been otherwise? Still trying to lead Sordland out of the mess I made?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Player: ""Your mess isn't what keeps me up at night. It's Soll's.""*)
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 3"*)
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "BaseGame.Gasom_Bankrupt == true || BaseGame.Gasom_Downsiz..."*)

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think it's safe to say that it's *my* mess now.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Economy"] <= 3`
- **Kontekst wejściowy (poprzednik):** `[502]` (Ewald Alphonso), `[513]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Ewald Alphonso: ""You see, {BaseGameText.AlphonsoToPlayer}. Being in charg..."*)

### Węzeł `[515]`
Mówca: **Ewald Alphonso**
> ""You see, {BaseGameText.AlphonsoToPlayer}. Being in charge of a country like Sordland isn't as easy as you think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Ewald Alphonso: ""And he who is considered a great leader today could end ..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 3"*)
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy <= 3)"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy <= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Player: ""I think it's safe to say that it's *my* mess now.""*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy <= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] <= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Player: ""Not just trying. Succeeding.""*)

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not just trying. Succeeding.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Economy"] <= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[502]` (Ewald Alphonso), `[513]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Ewald Alphonso: ""Don't boast too prematurely. Sordland isn't out of the w..."*)

### Węzeł `[520]`
Mówca: **Ewald Alphonso**
> ""Don't boast too prematurely. Sordland isn't out of the weeds yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Ewald Alphonso: ""There's one particular thorn that still needs pruning...""*)

### Węzeł `[521]`
Mówca: **Ewald Alphonso**
> ""There's one particular thorn that still needs pruning...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Ewald Alphonso: ""Speak of the devil.""*)

### Węzeł `[522]`
Mówca: **Ewald Alphonso**
> ""And he who is considered a great leader today could end up in shackles tomorrow...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Ewald Alphonso: ""Speak of the devil.""*)

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your mess isn't what keeps me up at night. It's Soll's.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[502]` (Ewald Alphonso), `[513]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_CampaignedForAlphonso == true)"*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Ewald Alphonso: ""You always did have it in for him. Starting with when yo..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_CampaignedForAlphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Ewald Alphonso: ""I remember a time when you were eager to support the Col..."*)

### Węzeł `[527]`
Mówca: **Ewald Alphonso**
> ""You always did have it in for him. Starting with when you helped oust him from USP leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Ewald Alphonso: ""Or maybe you just wanted to get rid of anyone who stood ..."*)

### Węzeł `[528]`
Mówca: **Ewald Alphonso**
> ""Or maybe you just wanted to get rid of anyone who stood between you and the Maroon Palace...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Ewald Alphonso: ""Speak of the devil.""*)

### Węzeł `[529]`
Mówca: **Ewald Alphonso**
> ""I remember a time when you were eager to support the Colonel. Even at the expense of a new chance at growth for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Ewald Alphonso: ""But we all fell victim to his cult of personality at one..."*)

### Węzeł `[530]`
Mówca: **Ewald Alphonso**
> ""But we all fell victim to his cult of personality at one point or another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Ewald Alphonso: ""Speak of the devil.""*)

### Węzeł `[531]`
Mówca: **Ewald Alphonso**
> ""Speak of the devil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 3"*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy <= 3)"*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy <= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] <= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Ewald Alphonso: ""As is the one about how the Sordish economy is in even w..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy <= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] <= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Dictator_Success == true"*)

### Węzeł `[535]`
Mówca: **Ewald Alphonso**
> ""As is the one about how the Sordish economy is in even worse shape than during my presidency. If there's anything Soll and I would agree on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Ewald Alphonso: ""But speak of the devil.""*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Dictator_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Dictator_Success == true"*)
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Dictator_Success == true)"*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Dictator_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Dictator_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Ewald Alphonso: ""As is the one about the rather dictatorial path you've l..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Dictator_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Dictator_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Ewald Alphonso: ""Today is all about that man right over there.""*)

### Węzeł `[539]`
Mówca: **Ewald Alphonso**
> ""As is the one about the rather dictatorial path you've led the country down. My God, if there's anything Soll and I would agree on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Ewald Alphonso: ""But speak of the devil.""*)

### Węzeł `[540]`
Mówca: **Ewald Alphonso**
> ""Today is all about that man right over there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Fired_KarlGreiser == true"*)

### Węzeł `[541]`
Mówca: **Ewald Alphonso**
> ""What? That's not even...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes. You're forgetting about the deep state he established to undermine the democratic institutions of this republic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Ovid Grecer), `[143]` (Heron Garaci), `[144]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Chatter");"*)

### Węzeł `[543]`
Mówca: **Narrator**
> "The courtroom came alive with chatter. Alphonso stared at me, his mouth wide open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == true && BaseGame.Policy_Law_SpecialZoneOfBergia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == true && BaseGame.Policy..."*)
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Ersen == true && BaseGame.Poli..."*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == true && BaseGame.Policy_Law_SpecialZoneOfBergia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == true  and  Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Player: ""Hell of a second case as Chief Justice, isn't it? I hope..."*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Ersen == true && BaseGame.Policy_Law_SpecialZoneOfBergia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == true  and  Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""Hell of a first case as Chief Justice, isn't it?""*)

### Węzeł `[547]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Hell of a second case as Chief Justice, isn't it? I hope the result will be similar to the first.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Bergia_Governor_Ersen"] == true  and  Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == true`
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Ovid Grecer: ""Mr. President, as Chief Justice I am committed to mainta..."*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Chatter");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Chatter");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "The courtroom came alive with chatter. Alphonso stared at..."*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Chatter");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Chatter");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Narrator: "The courtroom came alive with chatter. Alphonso stared at..."*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Gasp");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Gasp");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "The courtroom collectively gasped. Next to me, Alphonso m..."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Gasp");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Gasp");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "The courtroom collectively gasped. Soll fixed Heron with ..."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("PrologueIntro", "PrologueLoop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("PrologueIntro","PrologueLoop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The papers were calling it the "Trial of the Century" -- ..."*)
