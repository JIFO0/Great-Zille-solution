# Rizia/Turn 4/FPnT_AlvarezCall

- **ID konwersacji:** `314`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Rizia/Turn_04/314_FPnT_AlvarezCall.md`
- **Liczba węzłów dialogowych:** 597
- **Liczba wyborów gracza:** 160

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[95]** Player_Romus *(Gracz)*
- **[99]** Patricio Alvarez (R)

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLCIsolated.Turn04_Alvarez_Alcoholic`
- `RiziaDLCIsolated.Turn04_Alvarez_Father`
- `RiziaDLCIsolated.Turn04_Alvarez_Trustworthy`
- `RiziaDLCIsolated.Turn04_Alvarez_Want`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_PalesPipelineConstruction`
- `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal`
- `RiziaDLC.Diplomacy_Lespia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Lespia_PromiseITZSupport`
- `RiziaDLC.Diplomacy_Lespia_WehlenHelp`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_Cancelled`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_BuyCancelled`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Pales_NegotiatingPower`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Pales`
- `RiziaDLC.Policy_Economy_PalesPipeline_Project`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Zille_ReferendumPower`
- `RiziaDLC.Zille_ViolentResistancePower`
- `RiziaDLCIsolated.Turn04_Alvarez_Alcoholic`
- `RiziaDLCIsolated.Turn04_Alvarez_Father`
- `RiziaDLCIsolated.Turn04_Alvarez_Trustworthy`
- `RiziaDLCIsolated.Turn04_Alvarez_Want`
- `RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal`
- `RiziaDLCSupport.Journal_Turn04_Lespia_PromiseITZSupport`
- `RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal`
- `RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal`
- `RiziaDLCSupport.News_Turn04_G_AN_UpcomingMeeting`
- `RiziaDLCSupport.News_Turn04_G_RiziaPales_Arbitration`
- `RiziaDLCSupport.News_Turn04_G_RiziaPales_Deal`
- `RiziaDLCSupport.News_Turn04_G_RiziaPales_NavalBlockade`
- `RiziaDLCSupport.News_Turn04_RH_RiziaPales_Arbitration`
- `RiziaDLCSupport.News_Turn04_RH_RiziaPales_Deal`
- `RiziaDLCSupport.News_Turn04_RH_RiziaPales_NavalBlockade`
- `RiziaDLCSupport.Reports_Turn04_NavyWithdrawn`
- `RiziaDLCSupport.Reports_Turn04_Pales_PalesianNavySent`
- `RiziaDLCSupport.Reports_Turn04_PorteDrazon_Arbitration_Canceled`
- `RiziaDLCSupport.Reports_Turn04_PorteDrazon_SellField_Reneged`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[17]` | **""I trust you're well, Mr. Esquibel?""** | `[16]` **Laurento Esquibel**: ""Good afternoon, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Laurento Esquibel**: ""Well enough. Though I must say ..." |
| `[18]` | **""No time for small talk. Prime Minister Alvarez will be calling soon.""** | `[16]` **Laurento Esquibel**: ""Good afternoon, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Laurento Esquibel**: ""Very well. What did you want to..." |
| `[19]` | **""I won't know if it's a good afternoon or not until I've found out what Lespia wan..."** | `[16]` **Laurento Esquibel**: ""Good afternoon, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Laurento Esquibel**: ""Right you are. Forgive the inap..." |
| `[21]` | **""I'll do my best to defuse tensions. Just call me Romus the Defuser.""** | `[386]` **Laurento Esquibel**: ""Meanwhile, my requests for Wehl..."<br>`[397]` **Laurento Esquibel**: ""Wehlen still refuses to give us..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Narrator**: "He smiled wryly." |
| `[24]` | **""I understand that President Smolak may have lingering security concerns after the..."** | `[386]` **Laurento Esquibel**: ""Meanwhile, my requests for Wehl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[404]` **Laurento Esquibel**: ""I would like to give him the be..." |
| `[25]` | **""Isn't there anything we can do? President Smolak can't keep holding on to Zille f..."** | `[386]` **Laurento Esquibel**: ""Meanwhile, my requests for Wehl..."<br>`[397]` **Laurento Esquibel**: ""Wehlen still refuses to give us..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "He smoothed one of the ends of h..." |
| `[31]` | **""Why do you think he's calling?""** | `[22]` **Laurento Esquibel**: ""Very well. What did you want to..."<br>`[30]` **Laurento Esquibel**: ""For now, though, we have Prime ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == false` | *Brak zmian stanu* | `[42]` **Laurento Esquibel**: ""Well... He can't be happy that ..."<br>`[45]` **Laurento Esquibel**: ""Well... He can't be happy that ..."<br>*(oraz 1 innych odgałęzień)* |
| `[32]` | **""Did my father ever talk to him?""** | `[22]` **Laurento Esquibel**: ""Very well. What did you want to..."<br>`[30]` **Laurento Esquibel**: ""For now, though, we have Prime ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == false` | *Brak zmian stanu* | `[47]` **Laurento Esquibel**: ""No. His Majesty Valero died mer..." |
| `[33]` | **""How trustworthy is he?""** | `[22]` **Laurento Esquibel**: ""Very well. What did you want to..."<br>`[30]` **Laurento Esquibel**: ""For now, though, we have Prime ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == false` | *Brak zmian stanu* | `[49]` **Laurento Esquibel**: ""Considering the only reason he ..." |
| `[34]` | **""I've heard he's an alcoholic.""** | `[22]` **Laurento Esquibel**: ""Very well. What did you want to..."<br>`[30]` **Laurento Esquibel**: ""For now, though, we have Prime ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == false` | *Brak zmian stanu* | `[50]` **Laurento Esquibel**: ""Rare is the world leader who do..." |
| `[73]` | **""That'll be all. I'm ready for the phone call.""** | `[22]` **Laurento Esquibel**: ""Very well. What did you want to..."<br>`[30]` **Laurento Esquibel**: ""For now, though, we have Prime ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == true` | *Brak zmian stanu* | `[75]` **Laurento Esquibel**: ""Very good, Your Majesty. I'll m..." |
| `[79]` | **""This is His Majesty Romus Toras, Ruler of Rizia, Commander of the Royal Rizian Ar..."** | `[78]` **Patricio Alvarez (R)**: ""Good afternoon, King Romus. Thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Patricio Alvarez (R)**: ""Quite the mouthful. May your re..." |
| `[80]` | **""How is everything in Lespia, Mr. Prime Minister?""** | `[78]` **Patricio Alvarez (R)**: ""Good afternoon, King Romus. Thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Patricio Alvarez (R)**: ""I'll be honest with you, Your M..." |
| `[83]` | **""How are you, Mr. Alvarez?""** | `[78]` **Patricio Alvarez (R)**: ""Good afternoon, King Romus. Thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Patricio Alvarez (R)**: ""I'll be honest with you, Your M..." |
| `[100]` | **""Something to do with the gas field, I assume?""** | `[99]` **Patricio Alvarez (R)**: ""You must have some idea why I'm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Patricio Alvarez (R)**: ""Your assumption is correct."" |
| `[101]` | **""I honestly don't have a clue.""** | `[99]` **Patricio Alvarez (R)**: ""You must have some idea why I'm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Patricio Alvarez (R)**: ""Is that what it's like being a ..." |
| `[102]` | **""I suspect the reason involves Pales.""** | `[99]` **Patricio Alvarez (R)**: ""You must have some idea why I'm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[406]` **Patricio Alvarez (R)**: ""Your suspicions are correct."" |
| `[109]` | **""Rizia has gone up against the combined might of Pales and Lespia before. We won't..."** | `[108]` **Patricio Alvarez (R)**: ""I had an inkling that Rizia mig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Patricio Alvarez (R)**: ""That's very wise of you."" |
| `[110]` | **""Actually, Duke Reinhart tried to double-cross you. But I refused his offer.""** | `[108]` **Patricio Alvarez (R)**: ""I had an inkling that Rizia mig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Patricio Alvarez (R)**: ""Really? That's very interesting."" |
| `[111]` | **""I'd be a fool to interfere with Lespia's plans, now that you've got ATO behind you.""** | `[108]` **Patricio Alvarez (R)**: ""I had an inkling that Rizia mig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Patricio Alvarez (R)**: ""That's very wise of you."" |
| `[120]` | **""Apparently he likes me more than you.""** | `[105]` **Patricio Alvarez (R)**: ""What happened, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Patricio Alvarez (R)**: ""Hmm."" |
| `[121]` | **""Lespia joined ATO. That was the last straw for both of us.""** | `[105]` **Patricio Alvarez (R)**: ""What happened, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Patricio Alvarez (R)**: ""Hmm."" |
| `[122]` | **""We had the better offer. It's that simple.""** | `[105]` **Patricio Alvarez (R)**: ""What happened, Your Majesty?"" | `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false` | *Brak zmian stanu* | `[128]` **Patricio Alvarez (R)**: ""Hmm."" |
| `[123]` | **""Pales recognized Rizia's rightful claim to the field. You should do so as well.""** | `[105]` **Patricio Alvarez (R)**: ""What happened, Your Majesty?"" | `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true` | *Brak zmian stanu* | `[141]` **Patricio Alvarez (R)**: ""Hmm."" |
| `[124]` | **""The truth is that Pales has always shared a closer affinity with Rizia than Lespia.""** | `[105]` **Patricio Alvarez (R)**: ""What happened, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Patricio Alvarez (R)**: ""Hmm."" |
| `[132]` | **""Zille is a local dispute. I see superpowers as far more of a threat.""** | `[130]` **Patricio Alvarez (R)**: ""You're willing to let Wehlen tr..."<br>`[197]` **Patricio Alvarez (R)**: ""You're willing to let Wehlen tr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Patricio Alvarez (R)**: ""There are no 'local disputes' i..." |
| `[133]` | **""The deal with Pales has been made, Mr. Prime Minister. It can't be undone.""** | `[130]` **Patricio Alvarez (R)**: ""You're willing to let Wehlen tr..."<br>`[134]` **Patricio Alvarez (R)**: ""Shelling out for more natural g..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Patricio Alvarez (R)**: ""We both know that's nonsense. M..." |
| `[135]` | **""Rizia's energy needs are greater than you presume.""** | `[130]` **Patricio Alvarez (R)**: ""You're willing to let Wehlen tr..."<br>`[134]` **Patricio Alvarez (R)**: ""Shelling out for more natural g..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Patricio Alvarez (R)**: ""Are you building nuclear weapon..." |
| `[146]` | **""You really thought Rizia would cede the field without a fight?""** | `[145]` **Patricio Alvarez (R)**: ""And then my business partner ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Patricio Alvarez (R)**: ""I thought you were a shrewd kin..." |
| `[147]` | **""You're lucky it's only that. Duke Reinhart wanted me to buy the field out from un..."** | `[145]` **Patricio Alvarez (R)**: ""And then my business partner ca..." | `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false` | *Brak zmian stanu* | `[149]` **Patricio Alvarez (R)**: ""Did he? Interesting."" |
| `[148]` | **""I'm only observing protocol, Mr. Alvarez. You would do the same if I laid claim t..."** | `[145]` **Patricio Alvarez (R)**: ""And then my business partner ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Patricio Alvarez (R)**: ""It isn't your resource, Your Ma..." |
| `[156]` | **""You're bluffing. The AN will have no choice but to side with Rizia.""** | `[155]` **Patricio Alvarez (R)**: ""And who do you think has more s..."<br>`[166]` **Patricio Alvarez (R)**: ""And frankly, with Lespia on his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Patricio Alvarez (R)**: ""Are you sure about that? One hu..." |
| `[157]` | **""I understand I might lose. But I am not going to back down on this.""** | `[155]` **Patricio Alvarez (R)**: ""And who do you think has more s..."<br>`[166]` **Patricio Alvarez (R)**: ""And frankly, with Lespia on his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Patricio Alvarez (R)**: ""Not 'might', Your Majesty. You ..." |
| `[158]` | **""If you want Rizia to give up its claim on the field, you're going to have to pres..."** | `[155]` **Patricio Alvarez (R)**: ""And who do you think has more s..."<br>`[166]` **Patricio Alvarez (R)**: ""And frankly, with Lespia on his..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Patricio Alvarez (R)**: ""As it happens, I do have a prop..." |
| `[164]` | **""What kind of proposition?""** | `[160]` **Patricio Alvarez (R)**: ""Because if you aren't, I have a..."<br>`[162]` **Patricio Alvarez (R)**: ""If you want to avoid all that, ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Patricio Alvarez (R)**: ""I've been following the situati..." |
| `[165]` | **""Sorry, but I'm not interested.""** | `[160]` **Patricio Alvarez (R)**: ""Because if you aren't, I have a..."<br>`[162]` **Patricio Alvarez (R)**: ""If you want to avoid all that, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Patricio Alvarez (R)**: ""At least hear me out first."" |
| `[167]` | **""No promises. But I'm listening.""** | `[160]` **Patricio Alvarez (R)**: ""Because if you aren't, I have a..."<br>`[162]` **Patricio Alvarez (R)**: ""If you want to avoid all that, ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Patricio Alvarez (R)**: ""I've been following the situati..." |
| `[170]` | **""What debacle? Our countries have an agreement.""** | `[169]` **Patricio Alvarez (R)**: ""I've been following the situati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Patricio Alvarez (R)**: ""So President Smolak has promise..." |
| `[171]` | **""Thanks, but I have everything under control.""** | `[169]` **Patricio Alvarez (R)**: ""I've been following the situati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Patricio Alvarez (R)**: ""So President Smolak has promise..." |
| `[172]` | **""I am growing concerned about the timely return of the region, yes.""** | `[169]` **Patricio Alvarez (R)**: ""I've been following the situati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Patricio Alvarez (R)**: ""As you should be."" |
| `[175]` | **""Not in so many words...""** | `[174]` **Patricio Alvarez (R)**: ""So President Smolak has promise..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Patricio Alvarez (R)**: ""He's a slippery man, Smolak. Yo..." |
| `[176]` | **""Well... yes. Yes, he has.""** | `[174]` **Patricio Alvarez (R)**: ""So President Smolak has promise..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Patricio Alvarez (R)**: ""And you believed him?"" |
| `[179]` | **""I already have a plan. It doesn't involve Lespia.""** | `[177]` **Patricio Alvarez (R)**: ""He's a slippery man, Smolak. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Patricio Alvarez (R)**: ""All I'm suggesting is that we p..." |
| `[180]` | **""Are you offering to intervene, Mr. Prime Minister?""** | `[177]` **Patricio Alvarez (R)**: ""He's a slippery man, Smolak. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Patricio Alvarez (R)**: ""Of course Lespia can't do that...." |
| `[181]` | **""And how do you propose we do that?""** | `[177]` **Patricio Alvarez (R)**: ""He's a slippery man, Smolak. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Patricio Alvarez (R)**: ""Of course Lespia can't interfer..." |
| `[182]` | **""You catch flies with honey, not vinegar. I'm not going to risk inflaming hostilit..."** | `[177]` **Patricio Alvarez (R)**: ""He's a slippery man, Smolak. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Patricio Alvarez (R)**: ""I'm not suggesting hostility. I..." |
| `[188]` | **""It's not a debacle. Wehlen and Rizia have an agreement.""** | `[140]` **Patricio Alvarez (R)**: ""I've been following the situati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Patricio Alvarez (R)**: ""And President Smolak has promis..." |
| `[190]` | **""Not in so many words...""** | `[189]` **Patricio Alvarez (R)**: ""And President Smolak has promis..."<br>`[201]` **Patricio Alvarez (R)**: ""So President Smolak has promise..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Patricio Alvarez (R)**: ""He's a slippery man, Smolak. Yo..." |
| `[191]` | **""Well... yes. Yes, he has.""** | `[189]` **Patricio Alvarez (R)**: ""And President Smolak has promis..."<br>`[201]` **Patricio Alvarez (R)**: ""So President Smolak has promise..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Patricio Alvarez (R)**: ""And you believed him?"" |
| `[198]` | **""Thanks, but I have everything under control.""** | `[140]` **Patricio Alvarez (R)**: ""I've been following the situati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Patricio Alvarez (R)**: ""So President Smolak has promise..." |
| `[199]` | **""Not that it's your business, but yes, I am growing concerned about the timely ret..."** | `[140]` **Patricio Alvarez (R)**: ""I've been following the situati..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Patricio Alvarez (R)**: ""As you should be."" |
| `[202]` | **""I already have a plan. It doesn't involve Lespia.""** | `[192]` **Patricio Alvarez (R)**: ""He's a slippery man, Smolak. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Patricio Alvarez (R)**: ""We wouldn't interfere with what..." |
| `[203]` | **""Are you offering to intervene, Mr. Prime Minister?""** | `[192]` **Patricio Alvarez (R)**: ""He's a slippery man, Smolak. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Patricio Alvarez (R)**: ""Of course Lespia can't do that...." |
| `[204]` | **""And how do you propose we do that?""** | `[192]` **Patricio Alvarez (R)**: ""He's a slippery man, Smolak. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Patricio Alvarez (R)**: ""Of course Lespia can't interfer..." |
| `[205]` | **""You catch flies with honey, not vinegar. I'm not going to risk inflaming hostilit..."** | `[192]` **Patricio Alvarez (R)**: ""He's a slippery man, Smolak. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Patricio Alvarez (R)**: ""I'm not suggesting hostility. I..." |
| `[211]` | **""That's it? You expect Rizia to give up our gained rights to the gas field for tha..."** | `[207]` **Patricio Alvarez (R)**: ""By speaking up on your behalf a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Patricio Alvarez (R)**: ""You wouldn't have to give them ..." |
| `[213]` | **""That's it? You'd expect us to give up our claim on the gas field for that little?""** | `[185]` **Patricio Alvarez (R)**: ""By speaking up on your behalf a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Patricio Alvarez (R)**: ""It's more than you'll get if yo..." |
| `[214]` | **""Unfortunately, Rizia needs natural gas more than we need help with Wehlen.""** | `[185]` **Patricio Alvarez (R)**: ""By speaking up on your behalf a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Patricio Alvarez (R)**: ""What about both, then?"" |
| `[215]` | **""You'd have to make a very persuasive case for us.""** | `[185]` **Patricio Alvarez (R)**: ""By speaking up on your behalf a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Patricio Alvarez (R)**: ""I'm a charming man. Everyone sa..." |
| `[221]` | **""How do I know I can trust you?""** | `[555]` **Patricio Alvarez (R)**: ""And LesPower will take over wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Patricio Alvarez (R)**: ""My lying days are behind me, Yo..." |
| `[222]` | **""That's an insult, Mr. Alvarez. Those rights are ours to begin with.""** | `[555]` **Patricio Alvarez (R)**: ""And LesPower will take over wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[560]` **Patricio Alvarez (R)**: ""Even if you had a claim, defend..." |
| `[224]` | **""You wouldn't be bargaining if you thought you had an airtight case.""** | `[555]` **Patricio Alvarez (R)**: ""And LesPower will take over wha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Patricio Alvarez (R)**: ""I'm trying to make sure we both..." |
| `[228]` | **""I understand. I don't drink either.""** | `[226]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..."<br>`[227]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..." | `Variable["RiziaDLC.Trait_SoberKing"] == true` | *Brak zmian stanu* | `[234]` **Patricio Alvarez (R)**: ""One thing we have in common, th..." |
| `[232]` | **""My father was right about you.""** | `[226]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..."<br>`[227]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Patricio Alvarez (R)**: ""What'd His Majesty say? Only go..." |
| `[235]` | **""You may be sober, but I don't believe for a second that you've changed your ways.""** | `[226]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..."<br>`[227]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Patricio Alvarez (R)**: ""You don't have to believe me. A..." |
| `[236]` | **""You're not the bogeyman my councilors made you out to be.""** | `[226]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..."<br>`[227]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Patricio Alvarez (R)**: ""No. But you don't have to like ..." |
| `[241]` | **""Thanks for the offer, Mr. Alvarez. I'll remember your patronizing tone when I cru..."** | `[575]` **Patricio Alvarez (R)**: ""So how do you feel about a part..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Patricio Alvarez (R)**: ""No need for aggression, Your Ma..." |
| `[245]` | **""I know full well what I'm up against. But win or lose, I want to see how arbitrat..."** | `[575]` **Patricio Alvarez (R)**: ""So how do you feel about a part..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Patricio Alvarez (R)**: ""Fair enough, Your Majesty."" |
| `[246]` | **""Even if I were interested, I can't afford the gas offer. If arbitration is my onl..."** | `[575]` **Patricio Alvarez (R)**: ""So how do you feel about a part..." | `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false` | *Brak zmian stanu* | `[255]` **Patricio Alvarez (R)**: ""Fair enough, Your Majesty."" |
| `[247]` | **""I know when to back down. I'll accept the gas offer for a quarter of the field, b..."** | `[575]` **Patricio Alvarez (R)**: ""So how do you feel about a part..." | `Variable["RiziaDLC.Resources_Budget"] >= 4` | *Brak zmian stanu* | `[249]` **Patricio Alvarez (R)**: ""Your prerogative, Your Majesty...." |
| `[248]` | **""All right. Sell me 25% of the gas rights and help me out with Zille, and I'll wit..."** | `[575]` **Patricio Alvarez (R)**: ""So how do you feel about a part..." | `Variable["RiziaDLC.Resources_Budget"] >= 4` | *Brak zmian stanu* | `[250]` **Patricio Alvarez (R)**: ""It's a deal."" |
| `[258]` | **""You got what you were asking for. No need to butter me up further.""** | `[251]` **Patricio Alvarez (R)**: ""I'm looking forward to celebrat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Patricio Alvarez (R)**: ""Oh. And of course, I expect the..."<br>`[281]` **Narrator**: "We said our goodbyes and hung up." |
| `[259]` | **""Thank you for calling, Mr. Prime Minister.""** | `[251]` **Patricio Alvarez (R)**: ""I'm looking forward to celebrat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Patricio Alvarez (R)**: ""Oh. And of course, I expect the..."<br>`[281]` **Narrator**: "We said our goodbyes and hung up." |
| `[260]` | **""Something stronger for me.""** | `[251]` **Patricio Alvarez (R)**: ""I'm looking forward to celebrat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Patricio Alvarez (R)**: ""Oh. And of course, I expect the..."<br>`[281]` **Narrator**: "We said our goodbyes and hung up." |
| `[262]` | **""A pleasure speaking with you, Mr. Prime Minister.""** | `[256]` **Patricio Alvarez (R)**: ""I'll see you in Kyrute."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Narrator**: "We said our goodbyes and hung up." |
| `[263]` | **""I look forward to it.""** | `[256]` **Patricio Alvarez (R)**: ""I'll see you in Kyrute."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Narrator**: "We said our goodbyes and hung up." |
| `[264]` | **""And I'll see you in hell.""** | `[256]` **Patricio Alvarez (R)**: ""I'll see you in Kyrute."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Narrator**: "The line dropped." |
| `[265]` | **""Have you forgotten I hold the cards here? My navy has the field surrounded right ..."** | `[555]` **Patricio Alvarez (R)**: ""And LesPower will take over wha..." | `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true` | *Brak zmian stanu* | `[269]` **Patricio Alvarez (R)**: ""I wonder what will happen if yo..." |
| `[271]` | **""My father was right about you.""** | `[270]` **Patricio Alvarez (R)**: ""The longer your ships stay ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Patricio Alvarez (R)**: ""What'd His Majesty say? Only go..." |
| `[273]` | **""You may be sober, but I don't believe for a second that you've changed your ways.""** | `[270]` **Patricio Alvarez (R)**: ""The longer your ships stay ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Patricio Alvarez (R)**: ""You don't have to believe me. A..." |
| `[274]` | **""It would be very convenient to have this whole mess fixed by the time that meetin..."** | `[270]` **Patricio Alvarez (R)**: ""The longer your ships stay ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Patricio Alvarez (R)**: ""You're right about that. The We..." |
| `[291]` | **""'Comrade' Saltana can nationalize our gold over my dead body.""** | `[290]` **Patricio Alvarez (R)**: ""If you and I don't hold the lin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Patricio Alvarez (R)**: ""There you have it. We're in agr..." |
| `[292]` | **""It's a complex topic. The mines are on Morellan land, but we've invested millions..."** | `[290]` **Patricio Alvarez (R)**: ""If you and I don't hold the lin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Patricio Alvarez (R)**: ""It's not complex to me, Your Ma..." |
| `[293]` | **""We've exploited Morella's resources enough. Saltana can do what she wants with th..."** | `[290]` **Patricio Alvarez (R)**: ""If you and I don't hold the lin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Patricio Alvarez (R)**: ""So you're fine with losing all ..." |
| `[303]` | **""I do. Please help by any means necessary.""** | `[302]` **Patricio Alvarez (R)**: ""Assuming you want that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[480]` **Patricio Alvarez (R)**: ""With pleasure, Your Majesty."" |
| `[304]` | **""Thank you for the offer, but we've got the Zille situation under control.""** | `[302]` **Patricio Alvarez (R)**: ""Assuming you want that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[479]` **Patricio Alvarez (R)**: ""You do? That's not what I heard..." |
| `[306]` | **""I hope you'll honor the bargain.""** | `[481]` **Patricio Alvarez (R)**: ""Looking forward to getting rich..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[483]` **Patricio Alvarez (R)**: ""If there's one thing we Lespian..." |
| `[308]` | **""Something stronger for me.""** | `[307]` **Patricio Alvarez (R)**: ""We'll celebrate next month in K..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Narrator**: "The line dropped." |
| `[309]` | **""I can't wait, Mr. Prime Minister.""** | `[307]` **Patricio Alvarez (R)**: ""We'll celebrate next month in K..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Narrator**: "The line dropped." |
| `[310]` | **""Good day, Mr. Alvarez.""** | `[307]` **Patricio Alvarez (R)**: ""We'll celebrate next month in K..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Narrator**: "The line dropped." |
| `[317]` | **""Having Lespia on our side would hurt our chances with Wehlen, not help them.""** | `[207]` **Patricio Alvarez (R)**: ""By speaking up on your behalf a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Patricio Alvarez (R)**: ""I disagree, Your Majesty. We co..." |
| `[321]` | **""Is there an 'or else' you're implying?""** | `[319]` **Patricio Alvarez (R)**: ""Cancel on Pales, allow Lespia t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Patricio Alvarez (R)**: ""Not from Lespia's side, no."" |
| `[322]` | **""What makes you think Duke Reinhart would still sell to you after offering the fie..."** | `[319]` **Patricio Alvarez (R)**: ""Cancel on Pales, allow Lespia t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Patricio Alvarez (R)**: ""He doesn't have an alternative,..." |
| `[327]` | **""And why should I accept a quarter of the field instead of the rights to the whole..."** | `[319]` **Patricio Alvarez (R)**: ""Cancel on Pales, allow Lespia t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Patricio Alvarez (R)**: ""To save yourself trouble furthe..." |
| `[331]` | **""How very charitable of you.""** | `[330]` **Patricio Alvarez (R)**: ""Eventually, Reinhart will come ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[334]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..." |
| `[332]` | **""You may have a point. I was already beginning to have second thoughts about the P..."** | `[330]` **Patricio Alvarez (R)**: ""Eventually, Reinhart will come ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Patricio Alvarez (R)**: ""We're both intelligent men, You..." |
| `[333]` | **""This isn't generosity. This is an attempt to turn Rizia and Pales against each ot..."** | `[330]` **Patricio Alvarez (R)**: ""Eventually, Reinhart will come ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Patricio Alvarez (R)**: ""A reunion was never in the card..." |
| `[338]` | **""That is in fact what I believe. Please don't reach out to me again, Mr. Alvarez.""** | `[337]` **Patricio Alvarez (R)**: ""But it's up to you. Keep your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Patricio Alvarez (R)**: ""Fine with me. Good luck sorting..." |
| `[339]` | **""I do appreciate the offer. But my answer is no.""** | `[337]` **Patricio Alvarez (R)**: ""But it's up to you. Keep your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Patricio Alvarez (R)**: ""Fair enough, Your Majesty."" |
| `[340]` | **""You make a convincing case. I'll call off the deal and accept a smaller share of ..."** | `[337]` **Patricio Alvarez (R)**: ""But it's up to you. Keep your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Patricio Alvarez (R)**: ""That's perfectly fine, Your Maj..." |
| `[341]` | **""You're right. It's better for us if we cancel the deal. But I'm still counting on..."** | `[337]` **Patricio Alvarez (R)**: ""But it's up to you. Keep your d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Patricio Alvarez (R)**: ""Of course, Your Majesty."" |
| `[348]` | **""Thanks for your call, Mr. Prime Minister.""** | `[346]` **Patricio Alvarez (R)**: ""I'll see you in Kyrute."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Narrator**: "The line dropped." |
| `[349]` | **""I look forward to it.""** | `[346]` **Patricio Alvarez (R)**: ""I'll see you in Kyrute."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Narrator**: "The line dropped." |
| `[350]` | **""And I'll see you in hell.""** | `[346]` **Patricio Alvarez (R)**: ""I'll see you in Kyrute."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[365]` **Patricio Alvarez (R)**: ""I would expect more civility fr..." |
| `[351]` | **""Thanks for your call, Mr. Prime Minister.""** | `[356]` **Patricio Alvarez (R)**: ""And I'm looking forward to seei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Narrator**: "The line dropped." |
| `[352]` | **""I look forward to it as well.""** | `[356]` **Patricio Alvarez (R)**: ""And I'm looking forward to seei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Narrator**: "The line dropped." |
| `[353]` | **""I'm sure you are, now that you've gotten what you wanted.""** | `[356]` **Patricio Alvarez (R)**: ""And I'm looking forward to seei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Narrator**: "The line dropped." |
| `[401]` | **""To hell with Wehlen. If they won't give us Zille back, we'll just have to take it..."** | `[386]` **Laurento Esquibel**: ""Meanwhile, my requests for Wehl..."<br>`[397]` **Laurento Esquibel**: ""Wehlen still refuses to give us..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[402]` **Laurento Esquibel**: ""I would urge patience, Your Maj..." |
| `[410]` | **""I'm not buying it, Mr. Prime Minister. What's the catch?""** | `[576]` **Patricio Alvarez (R)**: ""LesPower will take care of any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Patricio Alvarez (R)**: ""No catch, Your Majesty."" |
| `[411]` | **""What makes you think I want anything to do with the Aureus field?""** | `[576]` **Patricio Alvarez (R)**: ""LesPower will take care of any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Patricio Alvarez (R)**: ""No use in being coy, Your Majes..." |
| `[412]` | **""If I wanted gas from that field, I'd purchase it from Pales directly.""** | `[576]` **Patricio Alvarez (R)**: ""LesPower will take care of any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Patricio Alvarez (R)**: ""Now, that's not true. I happen ..."<br>`[418]` **Patricio Alvarez (R)**: ""That's not the way it works. Le..." |
| `[413]` | **""I would be interested. Tell me more.""** | `[576]` **Patricio Alvarez (R)**: ""LesPower will take care of any ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[438]` **Patricio Alvarez (R)**: ""There's not much to tell, really."" |
| `[426]` | **""They tried to get me to join that club in my wilder days. I refused.""** | `[422]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..."<br>`[439]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..." | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true` | *Brak zmian stanu* | `[434]` **Patricio Alvarez (R)**: ""It's amazing, Your Majesty. Lik..." |
| `[427]` | **""I understand. I don't drink, either.""** | `[422]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..."<br>`[439]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..." | `Variable["RiziaDLC.Trait_SoberKing"] == true` | *Brak zmian stanu* | `[433]` **Patricio Alvarez (R)**: ""Amazing, isn't it? Like wiping ..." |
| `[431]` | **""That's nice. But I still don't believe you would offer such a large stake out of ..."** | `[422]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..."<br>`[439]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[435]` **Patricio Alvarez (R)**: ""Believe it or not, this is my o..." |
| `[432]` | **""I am glad that your faith gives you guidance, as it does me.""** | `[422]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..."<br>`[439]` **Patricio Alvarez (R)**: ""A certain... social club I'm in..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[440]` **Patricio Alvarez (R)**: ""I'm not talking about religion...." |
| `[444]` | **""I still don't understand your sudden show of generosity.""** | `[419]` **Patricio Alvarez (R)**: ""Fortunately, I have no such qua..."<br>`[420]` **Patricio Alvarez (R)**: ""Anyone who wants a piece of it ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[445]` **Patricio Alvarez (R)**: ""It's simple, Your Majesty."" |
| `[446]` | **""Perhaps we ceded it a little too hastily.""** | `[420]` **Patricio Alvarez (R)**: ""Anyone who wants a piece of it ..."<br>`[437]` **Patricio Alvarez (R)**: ""Every country in Merkopa is beg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[449]` **Patricio Alvarez (R)**: ""On the contrary, Your Majesty. ..." |
| `[447]` | **""Except that we'd still be beholden to Pales.""** | `[437]` **Patricio Alvarez (R)**: ""Every country in Merkopa is beg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[448]` **Patricio Alvarez (R)**: ""Let us worry about Pales, Your ..." |
| `[450]` | **""Well, Rizia has qualms about you.""** | `[419]` **Patricio Alvarez (R)**: ""Fortunately, I have no such qua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[451]` **Patricio Alvarez (R)**: ""But why, Your Majesty?"" |
| `[452]` | **""So Lespia wants a closer partnership with Rizia?""** | `[419]` **Patricio Alvarez (R)**: ""Fortunately, I have no such qua..."<br>`[420]` **Patricio Alvarez (R)**: ""Anyone who wants a piece of it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Patricio Alvarez (R)**: ""Is that so strange?"" |
| `[455]` | **""Morella's turn towards the east worries me as well.""** | `[454]` **Patricio Alvarez (R)**: ""Look at what we're up against. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Patricio Alvarez (R)**: ""Exactly, Your Majesty. Their ne..." |
| `[456]` | **""You're right. We have our differences, but neither of us wants Merkopa to turn in..."** | `[454]` **Patricio Alvarez (R)**: ""Look at what we're up against. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[463]` **Patricio Alvarez (R)**: ""Damn straight, Your Majesty."" |
| `[457]` | **""Malenyevism and Arcasian liberalism are just two sides of the same coin to me.""** | `[454]` **Patricio Alvarez (R)**: ""Look at what we're up against. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[459]` **Patricio Alvarez (R)**: ""We're not strictly Arcasian lib..." |
| `[458]` | **""It's capitalist vultures like you that keep me up at night, not the specter of Ma..."** | `[454]` **Patricio Alvarez (R)**: ""Look at what we're up against. ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[460]` **Patricio Alvarez (R)**: ""Hrm... Well, but you must still..." |
| `[467]` | **""The Meftiem International Trade Zone nationalization debate. I agree, it's pure r..."** | `[466]` **Patricio Alvarez (R)**: ""Getting up on her high horse, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Patricio Alvarez (R)**: ""Exactly!"" |
| `[468]` | **""I don't know if we see eye to eye on this, Mr. Prime Minister.""** | `[466]` **Patricio Alvarez (R)**: ""Getting up on her high horse, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[472]` **Patricio Alvarez (R)**: ""Well, we should."" |
| `[469]` | **""What does this have to do with the gas field, Mr. Alvarez?""** | `[466]` **Patricio Alvarez (R)**: ""Getting up on her high horse, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[471]` **Patricio Alvarez (R)**: ""We're on the same side with Aur..." |
| `[473]` | **""Aha. There's the ulterior motive I was looking for.""** | `[295]` **Patricio Alvarez (R)**: ""I hope you'll repeat that senti..."<br>`[297]` **Patricio Alvarez (R)**: ""I hope you'll see it my way by ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[476]` **Patricio Alvarez (R)**: ""Not an ulterior motive. Just la..." |
| `[474]` | **""You bet I will, Mr. Alvarez. And I'll take you up on that gas offer." [-3 Budget,..."** | `[295]` **Patricio Alvarez (R)**: ""I hope you'll repeat that senti..." | `Variable["RiziaDLC.Resources_Budget"] >= 3` | *Brak zmian stanu* | `[475]` **Patricio Alvarez (R)**: ""I knew you were a smart man."" |
| `[477]` | **""And if I don't?""** | `[295]` **Patricio Alvarez (R)**: ""I hope you'll repeat that senti..."<br>`[297]` **Patricio Alvarez (R)**: ""I hope you'll see it my way by ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[300]` **Patricio Alvarez (R)**: ""Then I'll do what I must to pro..." |
| `[478]` | **""Maybe I will, maybe I won't.""** | `[297]` **Patricio Alvarez (R)**: ""I hope you'll see it my way by ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Patricio Alvarez (R)**: ""If you don't, you should know I..." |
| `[482]` | **""Perfect. This could be the beginning of a new era.""** | `[481]` **Patricio Alvarez (R)**: ""Looking forward to getting rich..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[484]` **Patricio Alvarez (R)**: ""I hope so, Your Majesty."" |
| `[485]` | **""'Rich' is perhaps an overstatement.""** | `[481]` **Patricio Alvarez (R)**: ""Looking forward to getting rich..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[486]` **Patricio Alvarez (R)**: ""Natural gas is the future, isn'..." |
| `[487]` | **""We do. But I won't make any promises regarding the MITZ." [-3 Budget, +2 Energy P..."** | `[587]` **Patricio Alvarez (R)**: ""But enough about Morella. Do we..." | `Variable["RiziaDLC.Resources_Budget"] >= 3` | *Brak zmian stanu* | `[488]` **Patricio Alvarez (R)**: ""Fair enough."" |
| `[491]` | **""I do. Please help by any means necessary.""** | `[490]` **Patricio Alvarez (R)**: ""Assuming you want that."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] = true; ...` | `[495]` **Patricio Alvarez (R)**: ""You're a smart man."" |
| `[492]` | **""Thank you for the offer, but we've got the Zille situation under control.""** | `[490]` **Patricio Alvarez (R)**: ""Assuming you want that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[497]` **Patricio Alvarez (R)**: ""That's not what I heard. But su..." |
| `[500]` | **""Something stronger for me.""** | `[499]` **Patricio Alvarez (R)**: ""At any rate, I'm glad we could ..."<br>`[505]` **Patricio Alvarez (R)**: ""I look forward to celebrating i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Narrator**: "The line dropped." |
| `[501]` | **""I can't wait, Mr. Prime Minister.""** | `[499]` **Patricio Alvarez (R)**: ""At any rate, I'm glad we could ..."<br>`[505]` **Patricio Alvarez (R)**: ""I look forward to celebrating i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Narrator**: "The line dropped." |
| `[502]` | **""Good day, Mr. Alvarez.""** | `[499]` **Patricio Alvarez (R)**: ""At any rate, I'm glad we could ..."<br>`[505]` **Patricio Alvarez (R)**: ""I look forward to celebrating i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Narrator**: "The line dropped." |
| `[506]` | **""And the offer of assistance with Wehlen? That still stands?""** | `[270]` **Patricio Alvarez (R)**: ""The longer your ships stay ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Patricio Alvarez (R)**: ""Of course it does."" |
| `[508]` | **""Fine. I'll withdraw both the Rizian navy and our claim to the field in exchange f..."** | `[272]` **Patricio Alvarez (R)**: ""What'd His Majesty say? Only go..."<br>`[275]` **Patricio Alvarez (R)**: ""You don't have to believe me. A..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] >= 4` | *Brak zmian stanu* | `[510]` **Patricio Alvarez (R)**: ""Very excellent, Your Majesty. Y..." |
| `[509]` | **""I will not back down that easily, Mr. Alvarez. We will proceed with arbitration, ..."** | `[272]` **Patricio Alvarez (R)**: ""What'd His Majesty say? Only go..."<br>`[275]` **Patricio Alvarez (R)**: ""You don't have to believe me. A..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[511]` **Patricio Alvarez (R)**: ""That's too bad, Your Majesty."" |
| `[513]` | **""One that I am confident Rizia will win.""** | `[512]` **Patricio Alvarez (R)**: ""We have a long fight ahead of us."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[520]` **Patricio Alvarez (R)**: ""Ah, to have the confidence of a..." |
| `[514]` | **""'We'? This is Pales' fight, not yours.""** | `[512]` **Patricio Alvarez (R)**: ""We have a long fight ahead of us."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[518]` **Patricio Alvarez (R)**: ""You're right, Your Majesty. Les..." |
| `[515]` | **""I hope for a civil and peaceful legal process.""** | `[512]` **Patricio Alvarez (R)**: ""We have a long fight ahead of us."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[516]` **Patricio Alvarez (R)**: ""You know what would help with t..." |
| `[524]` | **""We are not closed to the idea, but I want to know more about what you have in mind.""** | `[207]` **Patricio Alvarez (R)**: ""By speaking up on your behalf a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[525]` **Patricio Alvarez (R)**: ""Let me help you with a brillian..." |
| `[541]` | **""I don't want to have anything to do with Lespia. Even if it means giving up acces..."** | `[587]` **Patricio Alvarez (R)**: ""But enough about Morella. Do we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[542]` **Patricio Alvarez (R)**: ""Suit yourself. I was only tryin..." |
| `[545]` | **""Thank you for calling.""** | `[544]` **Patricio Alvarez (R)**: ""I'll see you in Kyrute."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Narrator**: "The line dropped." |
| `[550]` | **""We can't make these sorts of financial commitments right now. Nothing changes in ..."** | `[272]` **Patricio Alvarez (R)**: ""What'd His Majesty say? Only go..."<br>`[275]` **Patricio Alvarez (R)**: ""You don't have to believe me. A..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false` | *Brak zmian stanu* | `[511]` **Patricio Alvarez (R)**: ""That's too bad, Your Majesty."" |
| `[553]` | **""So in your version of the deal, we'd get less gas from the field, but the pipelin..."** | `[330]` **Patricio Alvarez (R)**: ""Eventually, Reinhart will come ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[554]` **Patricio Alvarez (R)**: ""You got it. And if Aureus turns..." |
| `[564]` | **""Reinhart was the one who started this mess. And we're supposed to simply roll ove..."** | `[561]` **Patricio Alvarez (R)**: ""And I don't just mean money. A ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[565]` **Patricio Alvarez (R)**: ""You'd get championed as a peace..." |
| `[568]` | **""The Meftiem International Trade Zone nationalization debate. I agree, it's pure r..."** | `[574]` **Patricio Alvarez (R)**: ""Getting up on her high horse, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[571]` **Patricio Alvarez (R)**: ""Exactly! If Rizia and Lespia do..." |
| `[569]` | **""I don't know if we see eye to eye on this, Mr. Prime Minister.""** | `[574]` **Patricio Alvarez (R)**: ""Getting up on her high horse, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[573]` **Patricio Alvarez (R)**: ""Well, we should. If Rizia and L..." |
| `[570]` | **""That's an entirely different topic. We were talking about the gas field.""** | `[574]` **Patricio Alvarez (R)**: ""Getting up on her high horse, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[572]` **Patricio Alvarez (R)**: ""Resources are resources. And pe..." |
| `[580]` | **""You know what? If it helps grease the wheels on our gas deal, I will." [-3 Budget..."** | `[297]` **Patricio Alvarez (R)**: ""I hope you'll see it my way by ..." | `Variable["RiziaDLC.Resources_Budget"] >= 3` | *Brak zmian stanu* | `[475]` **Patricio Alvarez (R)**: ""I knew you were a smart man."" |
| `[584]` | **""I have to say upfront that I don't have the budget for this gas deal you're offer..."** | `[295]` **Patricio Alvarez (R)**: ""I hope you'll repeat that senti..."<br>`[297]` **Patricio Alvarez (R)**: ""I hope you'll see it my way by ..." | `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false` | *Brak zmian stanu* | `[585]` **Patricio Alvarez (R)**: ""That's great to hear, Your Maje..." |
| `[591]` | **""The gas field offer isn't within my budget. But I'll support you in the MITZ when..."** | `[587]` **Patricio Alvarez (R)**: ""But enough about Morella. Do we..." | `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false` | *Brak zmian stanu* | `[585]` **Patricio Alvarez (R)**: ""That's great to hear, Your Maje..." |
| `[592]` | **""Absolutely. And I'll back you against Morella if it means that much to you." [-3 ..."** | `[587]` **Patricio Alvarez (R)**: ""But enough about Morella. Do we..." | `Variable["RiziaDLC.Resources_Budget"] >= 3` | *Brak zmian stanu* | `[593]` **Patricio Alvarez (R)**: ""To *us*, Your Majesty. Thank you."" |
| `[595]` | **""I'm not going to accept the gas offer. But when it comes to the MITZ, Rizia has y..."** | `[587]` **Patricio Alvarez (R)**: ""But enough about Morella. Do we..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[585]` **Patricio Alvarez (R)**: ""That's great to hear, Your Maje..." |

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
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Taking a lucrative call from Lespia’s Pr..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It had been a week since my meeting with Duke Reinhart in Pales."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "I had signed an official document ceding ownership of the Aureus gas field to the Grand Duchy of Pales. Elena and the Palesian economic minister were busy drawing up our deal to purchase the exploration rights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "In the meantime, Lespian prime minister Patricio Alvarez ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "I had signed an official document ceding ownership of the..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "The Alliance of Nations had accepted our request to arbit..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I had signed an official document ceding ownership of the..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "I had signed an official document ceding ownership of the Aureus gas field to the Grand Duchy of Pales. According to reports, LesPower would shortly purchase the exploration rights to the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "In the meantime, Lespian prime minister Patricio Alvarez ..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "The Alliance of Nations had accepted our request to arbitrate ownership of the Aureus gas field. Preliminary hearings were to begin soon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "In the meantime, Lespian prime minister Patricio Alvarez ..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "In the meantime, Lespian prime minister Patricio Alvarez had contacted Laurento, asking to speak with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "I was spending the week at my palace in Monqiz. Laurento ..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "I was spending the week at my palace in Monqiz. Laurento visited to brief me ahead of the phone call."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "He stepped in front of my desk and bowed."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "He stepped in front of my desk and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Laurento Esquibel: ""Good afternoon, Your Majesty.""*)

### Węzeł `[16]`
Mówca: **Laurento Esquibel**
> ""Good afternoon, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""I trust you're well, Mr. Esquibel?""*)
  - -> `[18]` (*Player_Romus: ""No time for small talk. Prime Minister Alvarez will be c..."*)
  - -> `[19]` (*Player_Romus: ""I won't know if it's a good afternoon or not until I've ..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust you're well, Mr. Esquibel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Laurento Esquibel: ""Well enough. Though I must say I'm worried by the increa..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time for small talk. Prime Minister Alvarez will be calling soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Laurento Esquibel: ""Very well. What did you want to know about him?""*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't know if it's a good afternoon or not until I've found out what Lespia wants from me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Laurento Esquibel: ""Right you are. Forgive the inappropriate greeting.""*)

### Węzeł `[20]`
Mówca: **Laurento Esquibel**
> ""Well enough. Though I must say I'm worried by the increasing tensions in Southern Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll do my best to defuse tensions. Just call me Romus the Defuser.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Laurento Esquibel), `[397]` (Laurento Esquibel), `[399]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "He smiled wryly."*)

### Węzeł `[22]`
Mówca: **Laurento Esquibel**
> ""Very well. What did you want to know about him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "Alvarez Brief"*)

### Węzeł `[23]`
Mówca: **Laurento Esquibel**
> ""Right you are. Forgive the inappropriate greeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Laurento Esquibel: ""What questions did you have about Mr. Alvarez?""*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand that President Smolak may have lingering security concerns after the bombing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Laurento Esquibel: ""I would like to give him the benefit of the doubt. But t..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Isn't there anything we can do? President Smolak can't keep holding on to Zille forever.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Laurento Esquibel), `[397]` (Laurento Esquibel), `[399]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "He smoothed one of the ends of his moustache."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "He smiled wryly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Laurento Esquibel: ""It's not entirely up to you. I hope the upcoming Allianc..."*)

### Węzeł `[27]`
Mówca: **Laurento Esquibel**
> ""It's not entirely up to you. I hope the upcoming Alliance of Nations session on South Merkopa will provide us with some clarity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Laurento Esquibel: ""For now, though, we have Prime Minister Alvarez to worry..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "He smoothed one of the ends of his moustache."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Laurento Esquibel: ""I have filed a complaint with the Alliance of Nations. P..."*)

### Węzeł `[29]`
Mówca: **Laurento Esquibel**
> ""I have filed a complaint with the Alliance of Nations. Presumably this will be addressed during the upcoming South Merkopa session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Laurento Esquibel: ""For now, though, we have Prime Minister Alvarez to worry..."*)

### Węzeł `[30]`
Mówca: **Laurento Esquibel**
> ""For now, though, we have Prime Minister Alvarez to worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "Alvarez Brief"*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do you think he's calling?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Laurento Esquibel), `[30]` (Laurento Esquibel), `[72]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did my father ever talk to him?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Laurento Esquibel), `[30]` (Laurento Esquibel), `[72]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Laurento Esquibel: ""No. His Majesty Valero died mere months after Alvarez wo..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How trustworthy is he?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Laurento Esquibel), `[30]` (Laurento Esquibel), `[72]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Laurento Esquibel: ""Considering the only reason he entered politics was to a..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard he's an alcoholic.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == false`
- **Kontekst wejściowy (poprzednik):** `[22]` (Laurento Esquibel), `[30]` (Laurento Esquibel), `[72]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Laurento Esquibel: ""Rare is the world leader who doesn't enjoy a little drin..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Alvarez Brief`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Want == false"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Father == false"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == false"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == false"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == true || Rizi..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Laurento Esquibel: ""Well... He can't be happy that Pales has reneged on its ..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Laurento Esquibel: ""Well... He can't be happy that AN arbitration is delayin..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Laurento Esquibel: ""Well... He must be happy that Rizia is not challenging L..."*)

### Węzeł `[42]`
Mówca: **Laurento Esquibel**
> ""Well... He can't be happy that Pales has reneged on its gas deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Laurento Esquibel: ""His country's energy demands have skyrocketed since join..."*)

### Węzeł `[43]`
Mówca: **Laurento Esquibel**
> ""His country's energy demands have skyrocketed since joining ATO. I've heard rumors of massive new infrastructure investments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Laurento Esquibel: ""Naturally involving the Prime Minister's own constructio..."*)

### Węzeł `[44]`
Mówca: **Laurento Esquibel**
> ""Naturally involving the Prime Minister's own construction company, Alvarez Industries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Laurento Esquibel: ""And there's the matter of our shared interests in the Me..."*)

### Węzeł `[45]`
Mówca: **Laurento Esquibel**
> ""Well... He can't be happy that AN arbitration is delaying Lespia's access to the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Laurento Esquibel: ""His country's energy demands have skyrocketed since join..."*)

### Węzeł `[46]`
Mówca: **Laurento Esquibel**
> ""Well... He must be happy that Rizia is not challenging Lespia for access to the Aureus gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Laurento Esquibel: ""His country's energy demands have skyrocketed since join..."*)

### Węzeł `[47]`
Mówca: **Laurento Esquibel**
> ""No. His Majesty Valero died mere months after Alvarez won the 1949 election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Laurento Esquibel: ""He must have sent his obligatory congratulations. In pri..."*)

### Węzeł `[48]`
Mówca: **Laurento Esquibel**
> ""He must have sent his obligatory congratulations. In private, though, he referred to the young man as 'the viper in a diaper'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Father = true"*)

### Węzeł `[49]`
Mówca: **Laurento Esquibel**
> ""Considering the only reason he entered politics was to avoid going to jail?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Laurento Esquibel: ""No charge has successfully been leveled against him. But..."*)

### Węzeł `[50]`
Mówca: **Laurento Esquibel**
> ""Rare is the world leader who doesn't enjoy a little drink on the job. Or a big one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Laurento Esquibel: ""But no, Alvarez has apparently acknowledged his problem ..."*)

### Węzeł `[51]`
Mówca: **Laurento Esquibel**
> ""But no, Alvarez has apparently acknowledged his problem and entered a rehabilitation program. He's as sober as an Archpriestess. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Alcoholic = true"*)

### Węzeł `[52]`
Mówca: **Laurento Esquibel**
> ""No charge has successfully been leveled against him. But in my opinion, he can only be trusted to protect his own best interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Trustworthy = true"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Want == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Want == false"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_Alvarez_Want == false)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Want == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: ""Why do you think he's calling?""*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_Alvarez_Want == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Father == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Father == false"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_Alvarez_Father == false)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Father == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""Did my father ever talk to him?""*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_Alvarez_Father == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == false"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == false)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: ""How trustworthy is he?""*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == false"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == false)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""I've heard he's an alcoholic.""*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Alcoholic = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "Jump to: [Alvarez Brief]"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Trustworthy = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "Jump to: [Alvarez Brief]"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Father = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "Jump to: [Alvarez Brief]"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Want = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "Jump to: [Alvarez Brief]"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == true || RiziaDLCIsolated.Turn04_Alvarez_Father == true || RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == true || RiziaDLCIsolated.Turn04_Alvarez_Want == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == true || Rizi..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == true || Ri..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == true || RiziaDLCIsolated.Turn04_Alvarez_Father == true || RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == true || RiziaDLCIsolated.Turn04_Alvarez_Want == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player_Romus: ""That'll be all. I'm ready for the phone call.""*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_Alvarez_Alcoholic == true || RiziaDLCIsolated.Turn04_Alvarez_Father == true || RiziaDLCIsolated.Turn04_Alvarez_Trustworthy == true || RiziaDLCIsolated.Turn04_Alvarez_Want == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
Mówca: **Laurento Esquibel**
> ""What questions did you have about Mr. Alvarez?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "Alvarez Brief"*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That'll be all. I'm ready for the phone call.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn04_Alvarez_Alcoholic"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Father"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Trustworthy"] == true  or  Variable["RiziaDLCIsolated.Turn04_Alvarez_Want"] == true`
- **Kontekst wejściowy (poprzednik):** `[22]` (Laurento Esquibel), `[30]` (Laurento Esquibel), `[72]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Laurento Esquibel: ""Very good, Your Majesty. I'll meet you afterwards for a ..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Alvarez Brief]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "Alvarez Brief"*)

### Węzeł `[75]`
Mówca: **Laurento Esquibel**
> ""Very good, Your Majesty. I'll meet you afterwards for a debriefing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Laurento Esquibel");"*)

### Węzeł `[76]`
Mówca: **Narrator**
> "An assistant brought in the blue telephone that was used for calls with heads of state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("PhoneRingPickUp");"*)

### Węzeł `[77]`
Mówca: **Narrator**
> "At 3:01pm, it rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Patricio Alvarez (R): ""Good afternoon, King Romus. This is Patricio Alvarez.""*)

### Węzeł `[78]`
Mówca: **Patricio Alvarez (R)**
> ""Good afternoon, King Romus. This is Patricio Alvarez.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus: ""This is His Majesty Romus Toras, Ruler of Rizia, Command..."*)
  - -> `[80]` (*Player_Romus: ""How is everything in Lespia, Mr. Prime Minister?""*)
  - -> `[83]` (*Player_Romus: ""How are you, Mr. Alvarez?""*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is His Majesty Romus Toras, Ruler of Rizia, Commander of the Royal Rizian Armed Forces, Duke of Valenqiris and Protector of the Rezenid Empire.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Patricio Alvarez (R): ""Quite the mouthful. May your reign be as long as your ti..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How is everything in Lespia, Mr. Prime Minister?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Patricio Alvarez (R): ""I'll be honest with you, Your Majesty.""*)

### Węzeł `[81]`
Mówca: **Patricio Alvarez (R)**
> ""Quite the mouthful. May your reign be as long as your titles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Patricio Alvarez (R): ""You must have some idea why I'm calling.""*)

### Węzeł `[82]`
Mówca: **Patricio Alvarez (R)**
> ""I'll be honest with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you, Mr. Alvarez?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Patricio Alvarez (R): ""I'll be honest with you, Your Majesty.""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaD..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Patricio Alvarez (R): ""Things were going a lot better a week ago.""*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Patricio Alvarez (R): ""Things are going surprisingly well.""*)

### Węzeł `[87]`
Mówca: **Patricio Alvarez (R)**
> ""Things are going surprisingly well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Patricio Alvarez (R): ""I was heartened to hear of the results of your meeting w..."*)

### Węzeł `[88]`
Mówca: **Patricio Alvarez (R)**
> ""Things were going a lot better a week ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true )"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "I heard him swallow on the other end of the line."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[92]`
Mówca: **Patricio Alvarez (R)**
> ""Our deal with Reinhart was a year in the making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Patricio Alvarez (R): ""And one hour with you was enough to make the Duke of Pal..."*)

### Węzeł `[93]`
Mówca: **Patricio Alvarez (R)**
> ""I'll be honest with you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true ||  RiziaDL..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true ||  RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true ||  RiziaDL..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true ||  Rizia..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true ||  RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or   Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Patricio Alvarez (R): ""I was a lot better a week ago.""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true ||  RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true  or   Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Patricio Alvarez (R): ""I'm doing surprisingly well these days.""*)

### Węzeł `[97]`
Mówca: **Patricio Alvarez (R)**
> ""I'm doing surprisingly well these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Patricio Alvarez (R): ""I was heartened to hear of the results of your meeting w..."*)

### Węzeł `[98]`
Mówca: **Patricio Alvarez (R)**
> ""I was a lot better a week ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[99]`
Mówca: **Patricio Alvarez (R)**
> ""You must have some idea why I'm calling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player_Romus: ""Something to do with the gas field, I assume?""*)
  - -> `[102]` (*Player_Romus: ""I suspect the reason involves Pales.""*)
  - -> `[101]` (*Player_Romus: ""I honestly don't have a clue.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something to do with the gas field, I assume?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Patricio Alvarez (R): ""Your assumption is correct.""*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I honestly don't have a clue.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Patricio Alvarez (R): ""Is that what it's like being a monarch? Make a decision,..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect the reason involves Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Patricio Alvarez (R): ""Your suspicions are correct.""*)

### Węzeł `[103]`
Mówca: **Narrator**
> "I heard him swallow on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Patricio Alvarez (R): ""Our deal with Reinhart was a year in the making.""*)

### Węzeł `[104]`
Mówca: **Patricio Alvarez (R)**
> ""And one hour with you was enough to make the Duke of Pales have a sudden change of heart?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Patricio Alvarez (R): ""What happened, Your Majesty?""*)

### Węzeł `[105]`
Mówca: **Patricio Alvarez (R)**
> ""What happened, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""Apparently he likes me more than you.""*)
  - -> `[121]` (*Player_Romus: ""Lespia joined ATO. That was the last straw for both of us.""*)
  - -> `[124]` (*Player_Romus: ""The truth is that Pales has always shared a closer affin..."*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[106]`
Mówca: **Narrator**
> "I heard him sigh on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Patricio Alvarez (R): ""Here I am, about to land the gas deal of a lifetime.""*)

### Węzeł `[107]`
Mówca: **Patricio Alvarez (R)**
> ""I was heartened to hear of the results of your meeting with Duke Reinhart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Patricio Alvarez (R): ""I had an inkling that Rizia might try to obstruct our ga..."*)

### Węzeł `[108]`
Mówca: **Patricio Alvarez (R)**
> ""I had an inkling that Rizia might try to obstruct our gas deal with Pales. I'm happy that was not the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player_Romus: ""Rizia has gone up against the combined might of Pales an..."*)
  - -> `[110]` (*Player_Romus: ""Actually, Duke Reinhart tried to double-cross you. But I..."*)
  - -> `[111]` (*Player_Romus: ""I'd be a fool to interfere with Lespia's plans, now that..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia has gone up against the combined might of Pales and Lespia before. We won't make that mistake again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Patricio Alvarez (R): ""That's very wise of you.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Duke Reinhart tried to double-cross you. But I refused his offer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Patricio Alvarez (R): ""Really? That's very interesting.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd be a fool to interfere with Lespia's plans, now that you've got ATO behind you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Patricio Alvarez (R): ""That's very wise of you.""*)

### Węzeł `[112]`
Mówca: **Patricio Alvarez (R)**
> ""Really? That's very interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Patricio Alvarez (R): ""Thank you for turning him down. And for delivering me th..."*)

### Węzeł `[113]`
Mówca: **Patricio Alvarez (R)**
> ""Thank you for turning him down. And for delivering me this information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0 && RiziaDLC.Focus_Go..."*)

### Węzeł `[114]`
Mówca: **Patricio Alvarez (R)**
> ""That's very wise of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0 && RiziaDLC.Focus_Go..."*)

### Węzeł `[115]`
Mówca: **Patricio Alvarez (R)**
> ""I've heard you're something of an untraditional monarch. Maybe there's a way for us to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Patricio Alvarez (R): ""You and I both know how large the Aureus gas field is. L..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0 && RiziaDLC.Focus_Government_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0 && RiziaDLC.Focus_Go..."*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic > 0 && RiziaDLC.Focus_..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0 && RiziaDLC.Focus_Government_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0  and  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Patricio Alvarez (R): ""I've heard you're something of an untraditional monarch...."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic > 0 && RiziaDLC.Focus_Government_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0  and  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Patricio Alvarez (R): ""I've been hesitant to reach out to your kingdom in the p..."*)

### Węzeł `[119]`
Mówca: **Patricio Alvarez (R)**
> ""I've been hesitant to reach out to your kingdom in the past. But maybe there's a way for us to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Patricio Alvarez (R): ""You and I both know how large the Aureus gas field is. L..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Apparently he likes me more than you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Patricio Alvarez (R): ""Hmm.""*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia joined ATO. That was the last straw for both of us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Patricio Alvarez (R): ""Hmm.""*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We had the better offer. It's that simple.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[105]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Patricio Alvarez (R): ""Hmm.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales recognized Rizia's rightful claim to the field. You should do so as well.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Kontekst wejściowy (poprzednik):** `[105]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Patricio Alvarez (R): ""Hmm.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The truth is that Pales has always shared a closer affinity with Rizia than Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Patricio Alvarez (R): ""Hmm.""*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Romus: ""Pales recognized Rizia's rightful claim to the field. Yo..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""We had the better offer. It's that simple.""*)

### Węzeł `[128]`
Mówca: **Patricio Alvarez (R)**
> ""Hmm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Patricio Alvarez (R): ""I may be new at this Prime Minister thing. But I know wh..."*)

### Węzeł `[129]`
Mówca: **Patricio Alvarez (R)**
> ""Hmm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[130]`
Mówca: **Patricio Alvarez (R)**
> ""You're willing to let Wehlen tread all over you. But you saddle Rizia with more gas than you need because you're worried about ATO?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Romus: ""Zille is a local dispute. I see superpowers as far more ..."*)
  - -> `[133]` (*Player_Romus: ""The deal with Pales has been made, Mr. Prime Minister. I..."*)
  - -> `[135]` (*Player_Romus: ""Rizia's energy needs are greater than you presume.""*)

### Węzeł `[131]`
Mówca: **Patricio Alvarez (R)**
> ""I may be new at this Prime Minister thing. But I know when someone is making a business mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Patricio Alvarez (R): ""Shelling out for more natural gas than you need while We..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zille is a local dispute. I see superpowers as far more of a threat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Patricio Alvarez (R)), `[197]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Patricio Alvarez (R): ""There are no 'local disputes' in Merkopa these days, You..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The deal with Pales has been made, Mr. Prime Minister. It can't be undone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Patricio Alvarez (R)), `[134]` (Patricio Alvarez (R)), `[143]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Patricio Alvarez (R): ""We both know that's nonsense. My energy executives are s..."*)

### Węzeł `[134]`
Mówca: **Patricio Alvarez (R)**
> ""Shelling out for more natural gas than you need while Wehlen is still treading all over you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player_Romus: ""The deal with Pales has been made, Mr. Prime Minister. I..."*)
  - -> `[135]` (*Player_Romus: ""Rizia's energy needs are greater than you presume.""*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia's energy needs are greater than you presume.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Patricio Alvarez (R)), `[134]` (Patricio Alvarez (R)), `[143]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Patricio Alvarez (R): ""Are you building nuclear weapons? I don't think so.""*)

### Węzeł `[136]`
Mówca: **Patricio Alvarez (R)**
> ""There are no 'local disputes' in Merkopa these days, Your Majesty. You realize President Smolak has the long arm of Malenyev guiding him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Patricio Alvarez (R): ""I'll tell you what.""*)

### Węzeł `[137]`
Mówca: **Patricio Alvarez (R)**
> ""We both know that's nonsense. My energy executives are still floating around in the Aureus field as we speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Patricio Alvarez (R): ""I'll tell you what.""*)

### Węzeł `[138]`
Mówca: **Patricio Alvarez (R)**
> ""Are you building nuclear weapons? I don't think so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Patricio Alvarez (R): ""I'll tell you what.""*)

### Węzeł `[139]`
Mówca: **Patricio Alvarez (R)**
> ""I'll tell you what.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Patricio Alvarez (R): ""I've been following the situation in Zille. It seems to ..."*)

### Węzeł `[140]`
Mówca: **Patricio Alvarez (R)**
> ""I've been following the situation in Zille. It seems to me like you could use help with this debacle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player_Romus: ""It's not a debacle. Wehlen and Rizia have an agreement.""*)
  - -> `[198]` (*Player_Romus: ""Thanks, but I have everything under control.""*)
  - -> `[199]` (*Player_Romus: ""Not that it's your business, but yes, I am growing conce..."*)

### Węzeł `[141]`
Mówca: **Patricio Alvarez (R)**
> ""Hmm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Patricio Alvarez (R): ""I may be new at this Prime Minister thing. But I know wh..."*)

### Węzeł `[142]`
Mówca: **Patricio Alvarez (R)**
> ""I may be new at this Prime Minister thing. But I know when someone is making a business mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Patricio Alvarez (R): ""Saddling yourself with gas you don't need while Wehlen i..."*)

### Węzeł `[143]`
Mówca: **Patricio Alvarez (R)**
> ""Saddling yourself with gas you don't need while Wehlen is still treading all over you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player_Romus: ""The deal with Pales has been made, Mr. Prime Minister. I..."*)
  - -> `[135]` (*Player_Romus: ""Rizia's energy needs are greater than you presume.""*)

### Węzeł `[144]`
Mówca: **Patricio Alvarez (R)**
> ""Here I am, about to land the gas deal of a lifetime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Patricio Alvarez (R): ""And then my business partner calls me up and tells me we..."*)

### Węzeł `[145]`
Mówca: **Patricio Alvarez (R)**
> ""And then my business partner calls me up and tells me we have to wait for AN arbitration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player_Romus: ""You really thought Rizia would cede the field without a ..."*)
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[148]` (*Player_Romus: ""I'm only observing protocol, Mr. Alvarez. You would do t..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You really thought Rizia would cede the field without a fight?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Patricio Alvarez (R): ""I thought you were a shrewd king. One who knows which wa..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're lucky it's only that. Duke Reinhart wanted me to buy the field out from under you.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[145]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Patricio Alvarez (R): ""Did he? Interesting.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm only observing protocol, Mr. Alvarez. You would do the same if I laid claim to one of Lespia's resources.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Patricio Alvarez (R): ""It isn't your resource, Your Majesty.""*)

### Węzeł `[149]`
Mówca: **Patricio Alvarez (R)**
> ""Did he? Interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Patricio Alvarez (R): ""Well, as of my last conversation with him, he is determi..."*)

### Węzeł `[150]`
Mówca: **Patricio Alvarez (R)**
> ""I thought you were a shrewd king. One who knows which way the wind is blowing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Patricio Alvarez (R): ""My legal counsel has a crystal-clear case for Palesian o..."*)

### Węzeł `[151]`
Mówca: **Patricio Alvarez (R)**
> ""Well, as of my last conversation with him, he is determined to fight for what rightly belongs to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Patricio Alvarez (R): ""And frankly, with Lespia on his side, he has an unimpeac..."*)

### Węzeł `[152]`
Mówca: **Patricio Alvarez (R)**
> ""It isn't your resource, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Patricio Alvarez (R): ""My legal counsel has a crystal-clear case for Palesian o..."*)

### Węzeł `[153]`
Mówca: **Patricio Alvarez (R)**
> ""My legal counsel has a crystal-clear case for Palesian ownership of the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Patricio Alvarez (R): ""You can talk about ANDOR rules all you want, but in the ..."*)

### Węzeł `[154]`
Mówca: **Patricio Alvarez (R)**
> ""You can talk about ANDOR rules all you want, but in the end, it's going to come down to your word versus ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Patricio Alvarez (R): ""And who do you think has more sway with the Alliance of ..."*)

### Węzeł `[155]`
Mówca: **Patricio Alvarez (R)**
> ""And who do you think has more sway with the Alliance of Nations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player_Romus: ""You're bluffing. The AN will have no choice but to side ..."*)
  - -> `[157]` (*Player_Romus: ""I understand I might lose. But I am not going to back do..."*)
  - -> `[158]` (*Player_Romus: ""If you want Rizia to give up its claim on the field, you..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're bluffing. The AN will have no choice but to side with Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Patricio Alvarez (R)), `[166]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Patricio Alvarez (R): ""Are you sure about that? One hundred percent, absolutely..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand I might lose. But I am not going to back down on this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Patricio Alvarez (R)), `[166]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Patricio Alvarez (R): ""Not 'might', Your Majesty. You will lose. After wasting ..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you want Rizia to give up its claim on the field, you're going to have to present one hell of a counter-offer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Patricio Alvarez (R)), `[166]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Patricio Alvarez (R): ""As it happens, I do have a proposition that might intere..."*)

### Węzeł `[159]`
Mówca: **Patricio Alvarez (R)**
> ""Are you sure about that? One hundred percent, absolutely sure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Patricio Alvarez (R): ""Because if you aren't, I have a proposition for you.""*)

### Węzeł `[160]`
Mówca: **Patricio Alvarez (R)**
> ""Because if you aren't, I have a proposition for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: ""Sorry, but I'm not interested.""*)
  - -> `[164]` (*Player_Romus: ""What kind of proposition?""*)
  - -> `[167]` (*Player_Romus: ""No promises. But I'm listening.""*)

### Węzeł `[161]`
Mówca: **Patricio Alvarez (R)**
> ""Not 'might', Your Majesty. You will lose. After wasting a lot of unnecessary time and money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Patricio Alvarez (R): ""If you want to avoid all that, I have a proposition.""*)

### Węzeł `[162]`
Mówca: **Patricio Alvarez (R)**
> ""If you want to avoid all that, I have a proposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: ""Sorry, but I'm not interested.""*)
  - -> `[164]` (*Player_Romus: ""What kind of proposition?""*)
  - -> `[167]` (*Player_Romus: ""No promises. But I'm listening.""*)

### Węzeł `[163]`
Mówca: **Patricio Alvarez (R)**
> ""As it happens, I do have a proposition that might interest you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Romus: ""What kind of proposition?""*)
  - -> `[167]` (*Player_Romus: ""No promises. But I'm listening.""*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of proposition?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Patricio Alvarez (R)), `[162]` (Patricio Alvarez (R)), `[163]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Patricio Alvarez (R): ""I've been following the situation in Zille. It seems to ..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but I'm not interested.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Patricio Alvarez (R)), `[162]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Patricio Alvarez (R): ""At least hear me out first.""*)

### Węzeł `[166]`
Mówca: **Patricio Alvarez (R)**
> ""And frankly, with Lespia on his side, he has an unimpeachable case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player_Romus: ""You're bluffing. The AN will have no choice but to side ..."*)
  - -> `[157]` (*Player_Romus: ""I understand I might lose. But I am not going to back do..."*)
  - -> `[158]` (*Player_Romus: ""If you want Rizia to give up its claim on the field, you..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No promises. But I'm listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Patricio Alvarez (R)), `[162]` (Patricio Alvarez (R)), `[163]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Patricio Alvarez (R): ""I've been following the situation in Zille. It seems to ..."*)

### Węzeł `[168]`
Mówca: **Patricio Alvarez (R)**
> ""At least hear me out first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Patricio Alvarez (R): ""I've been following the situation in Zille. It seems to ..."*)

### Węzeł `[169]`
Mówca: **Patricio Alvarez (R)**
> ""I've been following the situation in Zille. It seems to me like you could use help with this debacle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""What debacle? Our countries have an agreement.""*)
  - -> `[171]` (*Player_Romus: ""Thanks, but I have everything under control.""*)
  - -> `[172]` (*Player_Romus: ""I am growing concerned about the timely return of the re..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What debacle? Our countries have an agreement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Patricio Alvarez (R): ""So President Smolak has promised to return Zille as sche..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I have everything under control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Patricio Alvarez (R): ""So President Smolak has promised to return Zille as sche..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am growing concerned about the timely return of the region, yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[169]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Patricio Alvarez (R): ""As you should be.""*)

### Węzeł `[173]`
Mówca: **Patricio Alvarez (R)**
> ""As you should be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Patricio Alvarez (R): ""He's a slippery man, Smolak. You won't get your territor..."*)

### Węzeł `[174]`
Mówca: **Patricio Alvarez (R)**
> ""So President Smolak has promised to return Zille as scheduled, despite the recent incident?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player_Romus: ""Not in so many words...""*)
  - -> `[176]` (*Player_Romus: ""Well... yes. Yes, he has.""*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not in so many words...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Patricio Alvarez (R): ""He's a slippery man, Smolak. You won't get your territor..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... yes. Yes, he has.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Patricio Alvarez (R): ""And you believed him?""*)

### Węzeł `[177]`
Mówca: **Patricio Alvarez (R)**
> ""He's a slippery man, Smolak. You won't get your territory back unless you tighten your grip on him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player_Romus: ""I already have a plan. It doesn't involve Lespia.""*)
  - -> `[180]` (*Player_Romus: ""Are you offering to intervene, Mr. Prime Minister?""*)
  - -> `[181]` (*Player_Romus: ""And how do you propose we do that?""*)
  - -> `[182]` (*Player_Romus: ""You catch flies with honey, not vinegar. I'm not going t..."*)

### Węzeł `[178]`
Mówca: **Patricio Alvarez (R)**
> ""And you believed him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Patricio Alvarez (R): ""He's a slippery man, Smolak. You won't get your territor..."*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I already have a plan. It doesn't involve Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Patricio Alvarez (R): ""All I'm suggesting is that we pitch in from the sidelines.""*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you offering to intervene, Mr. Prime Minister?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Patricio Alvarez (R): ""Of course Lespia can't do that. But we can provide some ..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do you propose we do that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Patricio Alvarez (R): ""Of course Lespia can't interfere directly. But we can pr..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You catch flies with honey, not vinegar. I'm not going to risk inflaming hostilities with Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Patricio Alvarez (R): ""I'm not suggesting hostility. I'm suggesting Lespia prov..."*)

### Węzeł `[183]`
Mówca: **Patricio Alvarez (R)**
> ""I'm not suggesting hostility. I'm suggesting Lespia provide assistance from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Patricio Alvarez (R): ""By speaking up on your behalf at the upcoming AN session..."*)

### Węzeł `[184]`
Mówca: **Patricio Alvarez (R)**
> ""Of course Lespia can't do that. But we can provide some assistance from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Patricio Alvarez (R): ""By speaking up on your behalf at the upcoming AN session..."*)

### Węzeł `[185]`
Mówca: **Patricio Alvarez (R)**
> ""By speaking up on your behalf at the upcoming AN session, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player_Romus: ""That's it? You'd expect us to give up our claim on the g..."*)
  - -> `[214]` (*Player_Romus: ""Unfortunately, Rizia needs natural gas more than we need..."*)
  - -> `[215]` (*Player_Romus: ""You'd have to make a very persuasive case for us.""*)

### Węzeł `[186]`
Mówca: **Patricio Alvarez (R)**
> ""Of course Lespia can't interfere directly. But we can provide some assistance from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Patricio Alvarez (R): ""By speaking up on your behalf at the upcoming AN session..."*)

### Węzeł `[187]`
Mówca: **Patricio Alvarez (R)**
> ""All I'm suggesting is that we pitch in from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Patricio Alvarez (R): ""By speaking up on your behalf at the upcoming AN session..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not a debacle. Wehlen and Rizia have an agreement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Patricio Alvarez (R): ""And President Smolak has promised to honor the terms of ..."*)

### Węzeł `[189]`
Mówca: **Patricio Alvarez (R)**
> ""And President Smolak has promised to honor the terms of that agreement, despite the bombing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player_Romus: ""Not in so many words...""*)
  - -> `[191]` (*Player_Romus: ""Well... yes. Yes, he has.""*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not in so many words...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Patricio Alvarez (R)), `[201]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Patricio Alvarez (R): ""He's a slippery man, Smolak. You won't get your territor..."*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well... yes. Yes, he has.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Patricio Alvarez (R)), `[201]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Patricio Alvarez (R): ""And you believed him?""*)

### Węzeł `[192]`
Mówca: **Patricio Alvarez (R)**
> ""He's a slippery man, Smolak. You won't get your territory back unless you tighten your grip on him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: ""I already have a plan. It doesn't involve Lespia.""*)
  - -> `[203]` (*Player_Romus: ""Are you offering to intervene, Mr. Prime Minister?""*)
  - -> `[204]` (*Player_Romus: ""And how do you propose we do that?""*)
  - -> `[205]` (*Player_Romus: ""You catch flies with honey, not vinegar. I'm not going t..."*)

### Węzeł `[193]`
Mówca: **Patricio Alvarez (R)**
> ""And you believed him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Patricio Alvarez (R): ""He's a slippery man, Smolak. You won't get your territor..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Patricio Alvarez (R): ""You're willing to let Wehlen tread all over you. But you..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Buy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Patricio Alvarez (R): ""You're willing to let Wehlen tread all over you. But you..."*)

### Węzeł `[197]`
Mówca: **Patricio Alvarez (R)**
> ""You're willing to let Wehlen tread all over you. But you shell out for more gas than your country needs because you're worried about ATO?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Romus: ""Zille is a local dispute. I see superpowers as far more ..."*)
  - -> `[133]` (*Player_Romus: ""The deal with Pales has been made, Mr. Prime Minister. I..."*)
  - -> `[135]` (*Player_Romus: ""Rizia's energy needs are greater than you presume.""*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I have everything under control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Patricio Alvarez (R): ""So President Smolak has promised to honor the terms of y..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not that it's your business, but yes, I am growing concerned about the timely return of the region.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Patricio Alvarez (R): ""As you should be.""*)

### Węzeł `[200]`
Mówca: **Patricio Alvarez (R)**
> ""As you should be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Patricio Alvarez (R): ""He's a slippery man, Smolak. You won't get your territor..."*)

### Węzeł `[201]`
Mówca: **Patricio Alvarez (R)**
> ""So President Smolak has promised to honor the terms of your agreement, despite the bombing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player_Romus: ""Not in so many words...""*)
  - -> `[191]` (*Player_Romus: ""Well... yes. Yes, he has.""*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I already have a plan. It doesn't involve Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Patricio Alvarez (R): ""We wouldn't interfere with whatever you have in motion. ..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you offering to intervene, Mr. Prime Minister?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Patricio Alvarez (R): ""Of course Lespia can't do that. But we can provide indir..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do you propose we do that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Patricio Alvarez (R): ""Of course Lespia can't interfere directly. But we can pr..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You catch flies with honey, not vinegar. I'm not going to risk inflaming hostilities with Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Patricio Alvarez (R): ""I'm not suggesting hostility. I'm suggesting Lespia prov..."*)

### Węzeł `[206]`
Mówca: **Patricio Alvarez (R)**
> ""I'm not suggesting hostility. I'm suggesting Lespia provide indirect assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Patricio Alvarez (R): ""By speaking up on your behalf at the upcoming AN session..."*)

### Węzeł `[207]`
Mówca: **Patricio Alvarez (R)**
> ""By speaking up on your behalf at the upcoming AN session, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Romus: ""That's it? You expect Rizia to give up our gained rights..."*)
  - -> `[524]` (*Player_Romus: ""We are not closed to the idea, but I want to know more a..."*)
  - -> `[317]` (*Player_Romus: ""Having Lespia on our side would hurt our chances with We..."*)

### Węzeł `[208]`
Mówca: **Patricio Alvarez (R)**
> ""We wouldn't interfere with whatever you have in motion. But we can provide indirect assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Patricio Alvarez (R): ""By speaking up on your behalf at the upcoming AN session..."*)

### Węzeł `[209]`
Mówca: **Patricio Alvarez (R)**
> ""Of course Lespia can't do that. But we can provide indirect assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Patricio Alvarez (R): ""By speaking up on your behalf at the upcoming AN session..."*)

### Węzeł `[210]`
Mówca: **Patricio Alvarez (R)**
> ""Of course Lespia can't interfere directly. But we can provide assistance from the sidelines.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Patricio Alvarez (R): ""By speaking up on your behalf at the upcoming AN session..."*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? You expect Rizia to give up our gained rights to the gas field for that little?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Patricio Alvarez (R): ""You wouldn't have to give them up entirely.""*)

### Węzeł `[212]`
Mówca: **Patricio Alvarez (R)**
> ""You wouldn't have to give them up entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Patricio Alvarez (R): ""Cancel on Pales, allow Lespia to go through with our pla..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? You'd expect us to give up our claim on the gas field for that little?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Patricio Alvarez (R): ""It's more than you'll get if you continue down the arbit..."*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unfortunately, Rizia needs natural gas more than we need help with Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Patricio Alvarez (R): ""What about both, then?""*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd have to make a very persuasive case for us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Patricio Alvarez (R): ""I'm a charming man. Everyone says so.""*)

### Węzeł `[216]`
Mówca: **Patricio Alvarez (R)**
> ""I'm a charming man. Everyone says so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Patricio Alvarez (R): ""Actually, I'll be extra generous.""*)

### Węzeł `[217]`
Mówca: **Patricio Alvarez (R)**
> ""What about both, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Patricio Alvarez (R): ""Cede the Aureus field to Pales, and in addition to the a..."*)

### Węzeł `[218]`
Mówca: **Patricio Alvarez (R)**
> ""It's more than you'll get if you continue down the arbitration path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Patricio Alvarez (R): ""Actually, I'll be extra generous.""*)

### Węzeł `[219]`
Mówca: **Patricio Alvarez (R)**
> ""Cede the Aureus field to Pales, and in addition to the assistance I just promised, we'll sell you one-quarter of the exploration rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Patricio Alvarez (R): ""And LesPower will take over whatever infrastructure cost..."*)

### Węzeł `[220]`
Mówca: **Patricio Alvarez (R)**
> ""Actually, I'll be extra generous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Patricio Alvarez (R): ""Cede the Aureus field to Pales, and in addition to the a..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do I know I can trust you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Patricio Alvarez (R): ""My lying days are behind me, Your Majesty.""*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's an insult, Mr. Alvarez. Those rights are ours to begin with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Patricio Alvarez (R): ""Even if you had a claim, defending and enforcing it woul..."*)

### Węzeł `[223]`
Mówca: **Patricio Alvarez (R)**
> ""My lying days are behind me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Patricio Alvarez (R): ""A certain... social club I'm in has taught me the import..."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You wouldn't be bargaining if you thought you had an airtight case.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Patricio Alvarez (R): ""I'm trying to make sure we both get something out of thi..."*)

### Węzeł `[225]`
Mówca: **Patricio Alvarez (R)**
> ""I'm trying to make sure we both get something out of this, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Patricio Alvarez (R): ""A certain... social club I'm in has taught me the import..."*)

### Węzeł `[226]`
Mówca: **Patricio Alvarez (R)**
> ""A certain... social club I'm in has taught me the importance of service to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[232]` (*Player_Romus: ""My father was right about you.""*)
  - -> `[235]` (*Player_Romus: ""You may be sober, but I don't believe for a second that ..."*)
  - -> `[236]` (*Player_Romus: ""You're not the bogeyman my councilors made you out to be.""*)

### Węzeł `[227]`
Mówca: **Patricio Alvarez (R)**
> ""A certain... social club I'm in has taught me the importance of accountability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[232]` (*Player_Romus: ""My father was right about you.""*)
  - -> `[235]` (*Player_Romus: ""You may be sober, but I don't believe for a second that ..."*)
  - -> `[236]` (*Player_Romus: ""You're not the bogeyman my councilors made you out to be.""*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I don't drink either.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[226]` (Patricio Alvarez (R)), `[227]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Patricio Alvarez (R): ""One thing we have in common, then.""*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player_Romus: ""I understand. I don't drink either.""*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father was right about you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Patricio Alvarez (R)), `[227]` (Patricio Alvarez (R)), `[561]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Patricio Alvarez (R): ""What'd His Majesty say? Only good things, I hope.""*)

### Węzeł `[233]`
Mówca: **Patricio Alvarez (R)**
> ""What'd His Majesty say? Only good things, I hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Patricio Alvarez (R): ""This isn't a plea for cooperation, Your Majesty. It's a ..."*)

### Węzeł `[234]`
Mówca: **Patricio Alvarez (R)**
> ""One thing we have in common, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Patricio Alvarez (R): ""But I'm not trying to be your friend. I'm just trying to..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be sober, but I don't believe for a second that you've changed your ways.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Patricio Alvarez (R)), `[227]` (Patricio Alvarez (R)), `[561]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Patricio Alvarez (R): ""You don't have to believe me. All you have to do is say ..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not the bogeyman my councilors made you out to be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Patricio Alvarez (R)), `[227]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Patricio Alvarez (R): ""No. But you don't have to like me. All you have to do is..."*)

### Węzeł `[237]`
Mówca: **Patricio Alvarez (R)**
> ""You don't have to believe me. All you have to do is say yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Patricio Alvarez (R): ""We're on the same side here. Don't forget about our part..."*)

### Węzeł `[238]`
Mówca: **Patricio Alvarez (R)**
> ""But I'm not trying to be your friend. I'm just trying to help you avoid embarrassment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Patricio Alvarez (R): ""We're on the same side here. Don't forget about our part..."*)

### Węzeł `[239]`
Mówca: **Patricio Alvarez (R)**
> ""No. But you don't have to like me. All you have to do is say yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Patricio Alvarez (R): ""We're on the same side here. Don't forget about our part..."*)

### Węzeł `[240]`
Mówca: **Patricio Alvarez (R)**
> ""This isn't a plea for cooperation, Your Majesty. It's a chance for you to avoid embarrassment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Patricio Alvarez (R): ""We're on the same side here. Don't forget about our part..."*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for the offer, Mr. Alvarez. I'll remember your patronizing tone when I crush you and Pales in court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[575]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Patricio Alvarez (R): ""No need for aggression, Your Majesty. This is a civil pr..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 4)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus: ""I know when to back down. I'll accept the gas offer for ..."*)
  - -> `[248]` (*Player_Romus: ""All right. Sell me 25% of the gas rights and help me out..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player_Romus: ""Even if I were interested, I can't afford the gas offer...."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know full well what I'm up against. But win or lose, I want to see how arbitration plays out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[575]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Patricio Alvarez (R): ""Fair enough, Your Majesty.""*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if I were interested, I can't afford the gas offer. If arbitration is my only chance for a piece of Aureus, I have to take it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Kontekst wejściowy (poprzednik):** `[575]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Patricio Alvarez (R): ""Fair enough, Your Majesty.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""I know when to back down. I'll accept the gas offer for a quarter of the field, but I don't want or need your help with Wehlen." [-4 Budget, +2 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""I know when to back down. I'll accept the gas offer, but I don't want or need your help with Wehlen.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Kontekst wejściowy (poprzednik):** `[575]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Patricio Alvarez (R): ""Your prerogative, Your Majesty. It's a deal.""*)

### Węzeł `[248]`
**[WYBÓR GRACZA: ""All right. Sell me 25% of the gas rights and help me out with Zille, and I'll withdraw Rizia's claim to the Aureus field." [-4 Budget, +2 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""All right. Sell me 25% of the gas rights and help me out with Zille, and I'll withdraw Rizia's claim to the Aureus field.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Kontekst wejściowy (poprzednik):** `[575]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Patricio Alvarez (R): ""It's a deal.""*)

### Węzeł `[249]`
Mówca: **Patricio Alvarez (R)**
> ""Your prerogative, Your Majesty. It's a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true"*)

### Węzeł `[250]`
Mówca: **Patricio Alvarez (R)**
> ""It's a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true"*)

### Węzeł `[251]`
Mówca: **Patricio Alvarez (R)**
> ""I'm looking forward to celebrating our agreement in person in Kyrute. Over, say, coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player_Romus: ""Something stronger for me.""*)
  - -> `[259]` (*Player_Romus: ""Thank you for calling, Mr. Prime Minister.""*)
  - -> `[258]` (*Player_Romus: ""You got what you were asking for. No need to butter me u..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = fal..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_WehlenHelp = true;
RiziaDLC.Zille_ViolentResistancePower += 3;
RiziaDLC.Zille_ReferendumPower += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] = true;
Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 3;
Variable["RiziaDLC.Zille_ReferendumPower"] = Variable["RiziaDLC.Zille_ReferendumPower"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = fal..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_WehlenHelp = true; RiziaDLC.Zil..."*)

### Węzeł `[255]`
Mówca: **Patricio Alvarez (R)**
> ""Fair enough, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Patricio Alvarez (R): ""I'll see you in Kyrute.""*)

### Węzeł `[256]`
Mówca: **Patricio Alvarez (R)**
> ""I'll see you in Kyrute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player_Romus: ""A pleasure speaking with you, Mr. Prime Minister.""*)
  - -> `[263]` (*Player_Romus: ""I look forward to it.""*)
  - -> `[264]` (*Player_Romus: ""And I'll see you in hell.""*)

### Węzeł `[257]`
Mówca: **Patricio Alvarez (R)**
> ""No need for aggression, Your Majesty. This is a civil process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Patricio Alvarez (R): ""I'll see you in Kyrute.""*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You got what you were asking for. No need to butter me up further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for calling, Mr. Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something stronger for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = false; 
RiziaDLCSupport.Reports_Turn04_PorteDrazon_Arbitration_Canceled = true;
RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal = true;
RiziaDLC.Resources_Budget -= 4;
RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] = false;
Variable["RiziaDLCSupport.Reports_Turn04_PorteDrazon_Arbitration_Canceled"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 4;
Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_Cancelled ..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pleasure speaking with you, Mr. Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "We said our goodbyes and hung up."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "We said our goodbyes and hung up."*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I'll see you in hell.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "The line dropped."*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you forgotten I hold the cards here? My navy has the field surrounded right now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Kontekst wejściowy (poprzednik):** `[555]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Patricio Alvarez (R): ""I wonder what will happen if you're forced to use it?""*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player_Romus: ""Have you forgotten I hold the cards here? My navy has th..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[269]`
Mówca: **Patricio Alvarez (R)**
> ""I wonder what will happen if you're forced to use it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Patricio Alvarez (R): ""The longer your ships stay there, the worse Rizia looks ..."*)

### Węzeł `[270]`
Mówca: **Patricio Alvarez (R)**
> ""The longer your ships stay there, the worse Rizia looks in the eyes of the international community. And as you know, there's a big AN meeting coming up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""My father was right about you.""*)
  - -> `[273]` (*Player_Romus: ""You may be sober, but I don't believe for a second that ..."*)
  - -> `[274]` (*Player_Romus: ""It would be very convenient to have this whole mess fixe..."*)
  - -> `[506]` (*Player_Romus: ""And the offer of assistance with Wehlen? That still stan..."*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father was right about you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Patricio Alvarez (R): ""What'd His Majesty say? Only good things, I hope.""*)

### Węzeł `[272]`
Mówca: **Patricio Alvarez (R)**
> ""What'd His Majesty say? Only good things, I hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[509]` (*Player_Romus: ""I will not back down that easily, Mr. Alvarez. We will p..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be sober, but I don't believe for a second that you've changed your ways.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Patricio Alvarez (R): ""You don't have to believe me. All you have to do is say ..."*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would be very convenient to have this whole mess fixed by the time that meeting rolls around.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Patricio Alvarez (R): ""You're right about that. The Wehlen situation's already ..."*)

### Węzeł `[275]`
Mówca: **Patricio Alvarez (R)**
> ""You don't have to believe me. All you have to do is say yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[509]` (*Player_Romus: ""I will not back down that easily, Mr. Alvarez. We will p..."*)

### Węzeł `[276]`
Mówca: **Patricio Alvarez (R)**
> ""You're right about that. The Wehlen situation's already messy enough without a naval standoff on your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[509]` (*Player_Romus: ""I will not back down that easily, Mr. Alvarez. We will p..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Patricio Alvarez (R): ""Oh. And of course, I expect the prompt removal of your n..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "We said our goodbyes and hung up."*)

### Węzeł `[280]`
Mówca: **Patricio Alvarez (R)**
> ""Oh. And of course, I expect the prompt removal of your naval reinforcements from the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal = tr..."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "We said our goodbyes and hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Patricio Alvarez (R)");"*)

### Węzeł `[282]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Patricio Alvarez (R)");"*)

### Węzeł `[283]`
Mówca: **Narrator**
> "I sat there for a while, wondering what I had gotten myself into."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "I'd avoided a legal battle, but to what end?"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Were Duke Reinhart and Prime Minister Alvarez right? Was ..."*)

### Węzeł `[287]`
Mówca: **Narrator**
> "I'd avoided a legal battle, but to what end?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_G_AN_UpcomingMeeting = true"*)

### Węzeł `[288]`
Mówca: **Narrator**
> "Were Duke Reinhart and Prime Minister Alvarez right? Was I doomed to lose this battle?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_G_AN_UpcomingMeeting = true"*)

### Węzeł `[289]`
Mówca: **Patricio Alvarez (R)**
> ""Four countries share the mining rights to the MITZ. It's no mystery that two of them want it nationalized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Patricio Alvarez (R): ""If you and I don't hold the line against the Malenyevist..."*)

### Węzeł `[290]`
Mówca: **Patricio Alvarez (R)**
> ""If you and I don't hold the line against the Malenyevists, they'll take everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player_Romus: ""'Comrade' Saltana can nationalize our gold over my dead ..."*)
  - -> `[292]` (*Player_Romus: ""It's a complex topic. The mines are on Morellan land, bu..."*)
  - -> `[293]` (*Player_Romus: ""We've exploited Morella's resources enough. Saltana can ..."*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Comrade' Saltana can nationalize our gold over my dead body.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Patricio Alvarez (R): ""There you have it. We're in agreement.""*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a complex topic. The mines are on Morellan land, but we've invested millions in them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Patricio Alvarez (R): ""It's not complex to me, Your Majesty.""*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've exploited Morella's resources enough. Saltana can do what she wants with the MITZ.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Patricio Alvarez (R): ""So you're fine with losing all the money you've invested..."*)

### Węzeł `[294]`
Mówca: **Patricio Alvarez (R)**
> ""There you have it. We're in agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Patricio Alvarez (R): ""I hope you'll repeat that sentiment the next time the MI..."*)

### Węzeł `[295]`
Mówca: **Patricio Alvarez (R)**
> ""I hope you'll repeat that sentiment the next time the MITZ board convenes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[473]` (*Player_Romus: ""Aha. There's the ulterior motive I was looking for.""*)
  - -> `[477]` (*Player_Romus: ""And if I don't?""*)

### Węzeł `[296]`
Mówca: **Patricio Alvarez (R)**
> ""It's not complex to me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Patricio Alvarez (R): ""I hope you'll see it my way by the next  MITZ board meet..."*)

### Węzeł `[297]`
Mówca: **Patricio Alvarez (R)**
> ""I hope you'll see it my way by the next  MITZ board meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[473]` (*Player_Romus: ""Aha. There's the ulterior motive I was looking for.""*)
  - -> `[478]` (*Player_Romus: ""Maybe I will, maybe I won't.""*)
  - -> `[477]` (*Player_Romus: ""And if I don't?""*)

### Węzeł `[298]`
Mówca: **Patricio Alvarez (R)**
> ""So you're fine with losing all the money you've invested there? And all the revenue the mines have been generating for you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Patricio Alvarez (R): ""I hope you'll see it my way by the next  MITZ board meet..."*)

### Węzeł `[299]`
Mówca: **Patricio Alvarez (R)**
> ""If you don't, you should know I'll do whatever I must to protect Lespia's interests. Whether that benefits Rizia or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Patricio Alvarez (R): ""But enough about Morella. Do we have a deal on Aureus?""*)

### Węzeł `[300]`
Mówca: **Patricio Alvarez (R)**
> ""Then I'll do what I must to protect Lespia's own interests. Which may or may not benefit your kingdom in the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Patricio Alvarez (R): ""But enough about Morella. Do we have a deal on Aureus?""*)

### Węzeł `[301]`
Mówca: **Patricio Alvarez (R)**
> ""And hell, I'll even put in a good word for you at the Alliance of Nations. Try and help you out of this sticky situation you're in with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Patricio Alvarez (R): ""Assuming you want that.""*)

### Węzeł `[302]`
Mówca: **Patricio Alvarez (R)**
> ""Assuming you want that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Player_Romus: ""I do. Please help by any means necessary.""*)
  - -> `[304]` (*Player_Romus: ""Thank you for the offer, but we've got the Zille situati..."*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do. Please help by any means necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[302]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Patricio Alvarez (R): ""With pleasure, Your Majesty.""*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the offer, but we've got the Zille situation under control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[302]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Patricio Alvarez (R): ""You do? That's not what I heard, but suit yourself.""*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_WehlenHelp = true; 
RiziaDLC.Zille_ViolentResistancePower += 3;
RiziaDLC.Zille_ReferendumPower += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] = true;
Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 3;
Variable["RiziaDLC.Zille_ReferendumPower"] = Variable["RiziaDLC.Zille_ReferendumPower"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you'll honor the bargain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Patricio Alvarez (R): ""If there's one thing we Lespians love, it's a long-term ..."*)

### Węzeł `[307]`
Mówca: **Patricio Alvarez (R)**
> ""We'll celebrate next month in Kyrute. Over coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player_Romus: ""Something stronger for me.""*)
  - -> `[309]` (*Player_Romus: ""I can't wait, Mr. Prime Minister.""*)
  - -> `[310]` (*Player_Romus: ""Good day, Mr. Alvarez.""*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something stronger for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "The line dropped."*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't wait, Mr. Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "The line dropped."*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good day, Mr. Alvarez.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "The line dropped."*)

### Węzeł `[311]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Patricio Alvarez (R)");"*)

### Węzeł `[312]`
Mówca: **Narrator**
> "I sat in my office for a while after that, wondering what kind of bargain I had made."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_G_AN_UpcomingMeeting = true"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Narrator: "I sat in my office for a while after that, wondering what..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "I sat in my office for a while after that, wondering if t..."*)

### Węzeł `[316]`
Mówca: **Narrator**
> "I sat in my office for a while after that, wondering if turning down Lespia's offer was the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_G_AN_UpcomingMeeting = true"*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Having Lespia on our side would hurt our chances with Wehlen, not help them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Patricio Alvarez (R): ""I disagree, Your Majesty. We could be instrumental in br..."*)

### Węzeł `[318]`
Mówca: **Patricio Alvarez (R)**
> ""I disagree, Your Majesty. We could be instrumental in bringing the plight of your kingdom to the greater international community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Patricio Alvarez (R): ""But I'll throw in a bonus.""*)

### Węzeł `[319]`
Mówca: **Patricio Alvarez (R)**
> ""Cancel on Pales, allow Lespia to go through with our planned purchase, and we'll sell you 25 percent of the gas rights.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Player_Romus: ""Is there an 'or else' you're implying?""*)
  - -> `[322]` (*Player_Romus: ""What makes you think Duke Reinhart would still sell to y..."*)
  - -> `[327]` (*Player_Romus: ""And why should I accept a quarter of the field instead o..."*)

### Węzeł `[320]`
Mówca: **Patricio Alvarez (R)**
> ""But I'll throw in a bonus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Patricio Alvarez (R): ""Cancel on Pales, allow Lespia to go through with our pla..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there an 'or else' you're implying?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Patricio Alvarez (R): ""Not from Lespia's side, no.""*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think Duke Reinhart would still sell to you after offering the field to me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Patricio Alvarez (R): ""He doesn't have an alternative, does he?""*)

### Węzeł `[323]`
Mówca: **Patricio Alvarez (R)**
> ""He doesn't have an alternative, does he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Patricio Alvarez (R): ""Reinhart's practically a teenager. Turning to you was hi..."*)

### Węzeł `[324]`
Mówca: **Patricio Alvarez (R)**
> ""Not from Lespia's side, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Patricio Alvarez (R): ""I will warn you that Reinhart's practically a teenager. ..."*)

### Węzeł `[325]`
Mówca: **Patricio Alvarez (R)**
> ""Reinhart's practically a teenager. Turning to you was his version of a tantrum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Patricio Alvarez (R): ""And let me guess. He talked you into paying for the infr..."*)

### Węzeł `[326]`
Mówca: **Patricio Alvarez (R)**
> ""I will warn you that Reinhart's practically a teenager. Turning to you was his version of a tantrum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Patricio Alvarez (R): ""And let me guess. He talked you into paying for the infr..."*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why should I accept a quarter of the field instead of the rights to the whole thing?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[319]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Patricio Alvarez (R): ""To save yourself trouble further down the line.""*)

### Węzeł `[328]`
Mówca: **Patricio Alvarez (R)**
> ""Duke Reinhart is practically a teenager. Turning to you was his version of a tantrum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Patricio Alvarez (R): ""And let me guess. He talked you into paying for the infr..."*)

### Węzeł `[329]`
Mówca: **Patricio Alvarez (R)**
> ""To save yourself trouble further down the line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Patricio Alvarez (R): ""Duke Reinhart is practically a teenager. Turning to you ..."*)

### Węzeł `[330]`
Mówca: **Patricio Alvarez (R)**
> ""Eventually, Reinhart will come back to us. I'm just trying to make sure Rizia is not left with nothing when he does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Player_Romus: ""So in your version of the deal, we'd get less gas from t..."*)
  - -> `[333]` (*Player_Romus: ""This isn't generosity. This is an attempt to turn Rizia ..."*)
  - -> `[332]` (*Player_Romus: ""You may have a point. I was already beginning to have se..."*)
  - -> `[331]` (*Player_Romus: ""How very charitable of you.""*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How very charitable of you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Patricio Alvarez (R): ""A certain... social club I'm in has taught me the import..."*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may have a point. I was already beginning to have second thoughts about the Pales deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Patricio Alvarez (R): ""We're both intelligent men, Your Majesty. We don't have ..."*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This isn't generosity. This is an attempt to turn Rizia and Pales against each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Patricio Alvarez (R): ""A reunion was never in the cards, Your Majesty. Do you t..."*)

### Węzeł `[334]`
Mówca: **Patricio Alvarez (R)**
> ""A certain... social club I'm in has taught me the importance of service to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Patricio Alvarez (R): ""But it's up to you. Keep your deal if you believe that's..."*)

### Węzeł `[335]`
Mówca: **Patricio Alvarez (R)**
> ""We're both intelligent men, Your Majesty. We don't have time for the whims of a brat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Patricio Alvarez (R): ""But it's up to you. Keep your deal if you believe that's..."*)

### Węzeł `[336]`
Mówca: **Patricio Alvarez (R)**
> ""A reunion was never in the cards, Your Majesty. Do you think the Duke has so easily forgotten the way your people tried to conquer his?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Patricio Alvarez (R): ""But it's up to you. Keep your deal if you believe that's..."*)

### Węzeł `[337]`
Mówca: **Patricio Alvarez (R)**
> ""But it's up to you. Keep your deal if you believe that's what's best for your country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Player_Romus: ""That is in fact what I believe. Please don't reach out t..."*)
  - -> `[339]` (*Player_Romus: ""I do appreciate the offer. But my answer is no.""*)
  - -> `[340]` (*Player_Romus: ""You make a convincing case. I'll call off the deal and a..."*)
  - -> `[341]` (*Player_Romus: ""You're right. It's better for us if we cancel the deal. ..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That is in fact what I believe. Please don't reach out to me again, Mr. Alvarez.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Patricio Alvarez (R): ""Fine with me. Good luck sorting everything out on your o..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do appreciate the offer. But my answer is no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Patricio Alvarez (R): ""Fair enough, Your Majesty.""*)

### Węzeł `[340]`
**[WYBÓR GRACZA: ""You make a convincing case. I'll call off the deal and accept a smaller share of the gas field rights. But I don't need or want your help with Wehlen." [Revert Pales Field Deal and Lose Paid Budget, +2 Energy Per Turn In Future]"]** — Mówca: **Player_Romus**
> ""You make a convincing case. I'll call off the deal and accept a smaller share of the gas field rights. But I don't need or want your help with Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Patricio Alvarez (R): ""That's perfectly fine, Your Majesty.""*)

### Węzeł `[341]`
**[WYBÓR GRACZA: ""You're right. It's better for us if we cancel the deal. But I'm still counting on a share of the gas rights and your full support with Wehlen." [Revert Pales Field Deal and Lose Paid Budget, +2 Energy Per Turn In Future, Diplomatic Support]"]** — Mówca: **Player_Romus**
> ""You're right. It's better for us if we cancel the deal. But I'm still counting on a share of the gas rights and your full support with Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Patricio Alvarez (R): ""Of course, Your Majesty.""*)

### Węzeł `[342]`
Mówca: **Patricio Alvarez (R)**
> ""That's perfectly fine, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true; ..."*)

### Węzeł `[343]`
Mówca: **Patricio Alvarez (R)**
> ""I truly appreciate this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Patricio Alvarez (R): ""And I'm looking forward to seeing you in Kyrute.""*)

### Węzeł `[344]`
Mówca: **Patricio Alvarez (R)**
> ""Of course, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_WehlenHelp = true; RiziaDLC.Zil..."*)

### Węzeł `[345]`
Mówca: **Patricio Alvarez (R)**
> ""Fair enough, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Patricio Alvarez (R): ""I'll see you in Kyrute.""*)

### Węzeł `[346]`
Mówca: **Patricio Alvarez (R)**
> ""I'll see you in Kyrute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player_Romus: ""Thanks for your call, Mr. Prime Minister.""*)
  - -> `[349]` (*Player_Romus: ""I look forward to it.""*)
  - -> `[350]` (*Player_Romus: ""And I'll see you in hell.""*)

### Węzeł `[347]`
Mówca: **Patricio Alvarez (R)**
> ""Fine with me. Good luck sorting everything out on your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Patricio Alvarez (R): ""I'll see you in Kyrute.""*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for your call, Mr. Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "The line dropped."*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "The line dropped."*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I'll see you in hell.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Patricio Alvarez (R): ""I would expect more civility from a king.""*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for your call, Mr. Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "The line dropped."*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to it as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "The line dropped."*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure you are, now that you've gotten what you wanted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "The line dropped."*)

### Węzeł `[354]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Patricio Alvarez (R)");  // Removes the..."*)

### Węzeł `[355]`
Mówca: **Narrator**
> "I sat in my office as daylight faded, wondering if I had made the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_G_AN_UpcomingMeeting = true"*)

### Węzeł `[356]`
Mówca: **Patricio Alvarez (R)**
> ""And I'm looking forward to seeing you in Kyrute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player_Romus: ""Thanks for your call, Mr. Prime Minister.""*)
  - -> `[352]` (*Player_Romus: ""I look forward to it as well.""*)
  - -> `[353]` (*Player_Romus: ""I'm sure you are, now that you've gotten what you wanted.""*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true; RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy = false; RiziaDLC.P..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Buy = false;
RiziaDLC.Policy_Diplomacy_TradeDeal_Pales = false;
RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal = true;
RiziaDLCSupport.Reports_Turn04_PorteDrazon_SellField_Reneged = true;
RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] = false;
Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Pales"] = false;
Variable["RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal"] = true;
Variable["RiziaDLCSupport.Reports_Turn04_PorteDrazon_SellField_Reneged"] = true;
Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_BuyCancelled = true"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_WehlenHelp = true;
RiziaDLC.Zille_ViolentResistancePower += 3;
RiziaDLC.Zille_ReferendumPower += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] = true;
Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 3;
Variable["RiziaDLC.Zille_ReferendumPower"] = Variable["RiziaDLC.Zille_ReferendumPower"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true; ..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_PromiseITZSupport = true; RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true; RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal = true;
RiziaDLC.Policy_Economy_PalesPipeline_Project = true;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower += 1;
RiziaDLC.Resources_Budget -= 3;
RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal"] = true;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] + 1;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_Country_Pales", "Progres..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Laurento Esquibel");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "An assistant brought in the blue telephone that was used ..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Patricio Alvarez (R)");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Patricio Alvarez (R)");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "I sat there for a while, wondering what I had gotten myse..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Patricio Alvarez (R)");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Patricio Alvarez (R)");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Patricio Alvarez (R)");

// Removes the conversant with the character name in database`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Patricio Alvarez (R)");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Narrator: "I sat in my office as daylight faded, wondering if I had ..."*)

### Węzeł `[365]`
Mówca: **Patricio Alvarez (R)**
> ""I would expect more civility from a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Patricio Alvarez (R): ""But not from a *Rizian* king.""*)

### Węzeł `[366]`
Mówca: **Patricio Alvarez (R)**
> ""But not from a *Rizian* king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "The line dropped."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn04_G_AN_UpcomingMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_G_AN_UpcomingMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "It had been a week since my meeting with Duke Reinhart in..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn04_Pales_PalesianNavySent = t..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn04_Pales_PalesianNavySent = true; RiziaDLCSupport.News_Turn04_G_RiziaPales_NavalBlockade = true; RiziaDLCSupport.News_Turn04_RH_RiziaPales_NavalBlockade = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Pales_PalesianNavySent"] = true;
Variable["RiziaDLCSupport.News_Turn04_G_RiziaPales_NavalBlockade"] = true;
Variable["RiziaDLCSupport.News_Turn04_RH_RiziaPales_NavalBlockade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent == tr..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false"*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_G_RiziaPales_Deal = true"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_G_RiziaPales_Arbitration = true"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn04_G_RiziaPales_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_G_RiziaPales_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_RH_RiziaPales_Deal = true"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn04_RH_RiziaPales_Deal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_RH_RiziaPales_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent == tr..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn04_G_RiziaPales_Arbitration = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_G_RiziaPales_Arbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn04_RH_RiziaPales_Arbitration = true"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn04_RH_RiziaPales_Arbitration = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_RH_RiziaPales_Arbitration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent == tr..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Laurento Esquibel: ""Our Rumburgian allies have expressed their support for o..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)

### Węzeł `[384]`
Mówca: **Laurento Esquibel**
> ""Our Rumburgian allies have expressed their support for our naval blockade, as expected. And they are sure to be of use during the AN arbitration process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Laurento Esquibel: ""However, the nation of Morella has yet to support or den..."*)

### Węzeł `[385]`
Mówca: **Laurento Esquibel**
> ""However, the nation of Morella has yet to support or denounce us. The same goes for Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Laurento Esquibel: ""Meanwhile, my requests for Wehlen to give us an updated ..."*)

### Węzeł `[386]`
Mówca: **Laurento Esquibel**
> ""Meanwhile, my requests for Wehlen to give us an updated timeline on the Zille handover have been repeatedly ignored...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""I'll do my best to defuse tensions. Just call me Romus t..."*)
  - -> `[24]` (*Player_Romus: ""I understand that President Smolak may have lingering se..."*)
  - -> `[401]` (*Player_Romus: ""To hell with Wehlen. If they won't give us Zille back, w..."*)
  - -> `[25]` (*Player_Romus: ""Isn't there anything we can do? President Smolak can't k..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Laurento Esquibel: ""Our Rumburgian allies have expressed their intent to sup..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede == true"*)

### Węzeł `[390]`
Mówca: **Laurento Esquibel**
> ""Our Rumburgian allies have expressed their intent to support us during the arbitration process, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Laurento Esquibel: ""However, the nation of Morella has yet to express an opi..."*)

### Węzeł `[391]`
Mówca: **Laurento Esquibel**
> ""However, the nation of Morella has yet to express an opinion either way. The same goes for Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Laurento Esquibel: ""Meanwhile, my requests for Wehlen to give us an updated ..."*)

### Węzeł `[392]`
Mówca: **Laurento Esquibel**
> ""We can expect improved relations with Lespia and Pales now that we've ceded ownership of the gas field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Laurento Esquibel: ""However, our neighbors don't seem happy that we've allow..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Cede == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede == true"*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GasField_Cede == true)"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Cede == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Laurento Esquibel: ""We can expect improved relations with Lespia and Pales n..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GasField_Cede == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Laurento Esquibel: ""We can expect improved relations with Pales now that we'..."*)

### Węzeł `[396]`
Mówca: **Laurento Esquibel**
> ""However, our neighbors don't seem happy that we've allowed Lespia to take control of such a large stretch of the Antacean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Laurento Esquibel: ""Wehlen still refuses to give us an updated timeline for ..."*)

### Węzeł `[397]`
Mówca: **Laurento Esquibel**
> ""Wehlen still refuses to give us an updated timeline for the Zille handover. Losing the gas field may have something to do with it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""I'll do my best to defuse tensions. Just call me Romus t..."*)
  - -> `[401]` (*Player_Romus: ""To hell with Wehlen. If they won't give us Zille back, w..."*)
  - -> `[25]` (*Player_Romus: ""Isn't there anything we can do? President Smolak can't k..."*)

### Węzeł `[398]`
Mówca: **Laurento Esquibel**
> ""We can expect improved relations with Pales now that we're on the verge of a gas deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Laurento Esquibel: ""Furthermore, Morella and Derdia have expressed interest ..."*)

### Węzeł `[399]`
Mówca: **Laurento Esquibel**
> ""However, we mustn't forget about Wehlen. My requests for an updated timeline on the Zille handover have been repeatedly ignored...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""I'll do my best to defuse tensions. Just call me Romus t..."*)
  - -> `[401]` (*Player_Romus: ""To hell with Wehlen. If they won't give us Zille back, w..."*)
  - -> `[25]` (*Player_Romus: ""Isn't there anything we can do? President Smolak can't k..."*)

### Węzeł `[400]`
Mówca: **Laurento Esquibel**
> ""Furthermore, Morella and Derdia have expressed interest in purchasing energy from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Laurento Esquibel: ""However, we mustn't forget about Wehlen. My requests for..."*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To hell with Wehlen. If they won't give us Zille back, we'll just have to take it from them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Laurento Esquibel), `[397]` (Laurento Esquibel), `[399]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Laurento Esquibel: ""I would urge patience, Your Majesty.""*)

### Węzeł `[402]`
Mówca: **Laurento Esquibel**
> ""I would urge patience, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Laurento Esquibel: ""I have filed a complaint with the Alliance of Nations. P..."*)

### Węzeł `[403]`
Mówca: **Laurento Esquibel**
> ""I have filed a complaint with the Alliance of Nations. Presumably this will be addressed during the upcoming South Merkopa session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Laurento Esquibel: ""For now, though, we have Prime Minister Alvarez to worry..."*)

### Węzeł `[404]`
Mówca: **Laurento Esquibel**
> ""I would like to give him the benefit of the doubt. But the lack of a response is very worrying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Laurento Esquibel: ""I have filed a complaint with the Alliance of Nations. P..."*)

### Węzeł `[405]`
Mówca: **Patricio Alvarez (R)**
> ""Is that what it's like being a monarch? Make a decision, forget about the consequences?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[406]`
Mówca: **Patricio Alvarez (R)**
> ""Your suspicions are correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[407]`
Mówca: **Patricio Alvarez (R)**
> ""Your assumption is correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Buy == true"*)

### Węzeł `[408]`
Mówca: **Patricio Alvarez (R)**
> ""You and I both know how large the Aureus gas field is. Lespia definitely doesn't need all of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Patricio Alvarez (R): ""What if we made a deal? We'll sell you 25 percent of the..."*)

### Węzeł `[409]`
Mówca: **Patricio Alvarez (R)**
> ""What if we made a deal? We'll sell you 25 percent of the rights we're buying from Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Patricio Alvarez (R): ""LesPower will take care of any infrastructure needed to ..."*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not buying it, Mr. Prime Minister. What's the catch?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[576]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Patricio Alvarez (R): ""No catch, Your Majesty.""*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think I want anything to do with the Aureus field?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[576]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Patricio Alvarez (R): ""No use in being coy, Your Majesty.""*)

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I wanted gas from that field, I'd purchase it from Pales directly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[576]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would be interested. Tell me more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[576]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Patricio Alvarez (R): ""There's not much to tell, really.""*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HostileToPales == true"*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HostileToPales == true)"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HostileToPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Patricio Alvarez (R): ""Now, that's not true. I happen to know that Duke Reinhar..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HostileToPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Patricio Alvarez (R): ""That's not the way it works. Lespia controls the rights ..."*)

### Węzeł `[417]`
Mówca: **Patricio Alvarez (R)**
> ""Now, that's not true. I happen to know that Duke Reinhart detests you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Patricio Alvarez (R): ""Fortunately, I have no such qualms about Rizia.""*)

### Węzeł `[418]`
Mówca: **Patricio Alvarez (R)**
> ""That's not the way it works. Lespia controls the rights to the entire field now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Patricio Alvarez (R): ""Anyone who wants a piece of it has to go through us.""*)

### Węzeł `[419]`
Mówca: **Patricio Alvarez (R)**
> ""Fortunately, I have no such qualms about Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player_Romus: ""I still don't understand your sudden show of generosity.""*)
  - -> `[450]` (*Player_Romus: ""Well, Rizia has qualms about you.""*)
  - -> `[452]` (*Player_Romus: ""So Lespia wants a closer partnership with Rizia?""*)

### Węzeł `[420]`
Mówca: **Patricio Alvarez (R)**
> ""Anyone who wants a piece of it has to go through us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player_Romus: ""I still don't understand your sudden show of generosity.""*)
  - -> `[446]` (*Player_Romus: ""Perhaps we ceded it a little too hastily.""*)
  - -> `[452]` (*Player_Romus: ""So Lespia wants a closer partnership with Rizia?""*)

### Węzeł `[421]`
Mówca: **Patricio Alvarez (R)**
> ""No catch, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Patricio Alvarez (R): ""A certain... social club I'm in has taught me the import..."*)

### Węzeł `[422]`
Mówca: **Patricio Alvarez (R)**
> ""A certain... social club I'm in has taught me the importance of service to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Player_Romus: ""I am glad that your faith gives you guidance, as it does..."*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[431]` (*Player_Romus: ""That's nice. But I still don't believe you would offer s..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Player_Romus: ""They tried to get me to join that club in my wilder days..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[426]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They tried to get me to join that club in my wilder days. I refused.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Kontekst wejściowy (poprzednik):** `[422]` (Patricio Alvarez (R)), `[439]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Patricio Alvarez (R): ""It's amazing, Your Majesty. Like wiping the fog off a wi..."*)

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I don't drink, either.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[422]` (Patricio Alvarez (R)), `[439]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Patricio Alvarez (R): ""Amazing, isn't it? Like wiping the fog off a window and ..."*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Player_Romus: ""I understand. I don't drink, either.""*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's nice. But I still don't believe you would offer such a large stake out of the goodness of your heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Patricio Alvarez (R)), `[439]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Patricio Alvarez (R): ""Believe it or not, this is my offer.""*)

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am glad that your faith gives you guidance, as it does me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Patricio Alvarez (R)), `[439]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[433]`
Mówca: **Patricio Alvarez (R)**
> ""Amazing, isn't it? Like wiping the fog off a window and finally being able to see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Patricio Alvarez (R): ""In my case, I saw that it's time for Rizia and Lespia to..."*)

### Węzeł `[434]`
Mówca: **Patricio Alvarez (R)**
> ""It's amazing, Your Majesty. Like wiping the fog off a window and finally being able to see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Patricio Alvarez (R): ""In my case, I saw that it's time for Rizia and Lespia to..."*)

### Węzeł `[435]`
Mówca: **Patricio Alvarez (R)**
> ""Believe it or not, this is my offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Patricio Alvarez (R): ""I feel it's finally time for Rizia and Lespia to grow cl..."*)

### Węzeł `[436]`
Mówca: **Patricio Alvarez (R)**
> ""No use in being coy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Patricio Alvarez (R): ""Every country in Merkopa is begging for a whiff of that ..."*)

### Węzeł `[437]`
Mówca: **Patricio Alvarez (R)**
> ""Every country in Merkopa is begging for a whiff of that gas. Even 25 percent of the field would grant you considerable power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player_Romus: ""I still don't understand your sudden show of generosity.""*)
  - -> `[447]` (*Player_Romus: ""Except that we'd still be beholden to Pales.""*)
  - -> `[446]` (*Player_Romus: ""Perhaps we ceded it a little too hastily.""*)

### Węzeł `[438]`
Mówca: **Patricio Alvarez (R)**
> ""There's not much to tell, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Patricio Alvarez (R): ""A certain... social club I'm in has taught me the import..."*)

### Węzeł `[439]`
Mówca: **Patricio Alvarez (R)**
> ""A certain... social club I'm in has taught me the importance of service to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Player_Romus: ""I am glad that your faith gives you guidance, as it does..."*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[431]` (*Player_Romus: ""That's nice. But I still don't believe you would offer s..."*)

### Węzeł `[440]`
Mówca: **Patricio Alvarez (R)**
> ""I'm not talking about religion. But never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Patricio Alvarez (R): ""I feel it's finally time for Rizia and Lespia to grow cl..."*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Patricio Alvarez (R): ""I'm not talking about religion. But never mind.""*)

### Węzeł `[442]`
Mówca: **Patricio Alvarez (R)**
> ""In my case, I saw that it's time for Rizia and Lespia to grow closer together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Patricio Alvarez (R): ""Look at what we're up against. The forces of Malenyevism..."*)

### Węzeł `[443]`
Mówca: **Patricio Alvarez (R)**
> ""I feel it's finally time for Rizia and Lespia to grow closer together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Patricio Alvarez (R): ""Look at what we're up against. The forces of Malenyevism..."*)

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still don't understand your sudden show of generosity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Patricio Alvarez (R)), `[420]` (Patricio Alvarez (R)), `[437]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Patricio Alvarez (R): ""It's simple, Your Majesty.""*)

### Węzeł `[445]`
Mówca: **Patricio Alvarez (R)**
> ""It's simple, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Patricio Alvarez (R): ""I feel it's finally time for Rizia and Lespia to grow cl..."*)

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps we ceded it a little too hastily.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[420]` (Patricio Alvarez (R)), `[437]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Patricio Alvarez (R): ""On the contrary, Your Majesty. This is the best possible..."*)

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Except that we'd still be beholden to Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Patricio Alvarez (R): ""Let us worry about Pales, Your Majesty.""*)

### Węzeł `[448]`
Mówca: **Patricio Alvarez (R)**
> ""Let us worry about Pales, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Patricio Alvarez (R): ""I feel it's finally time for Rizia and Lespia to grow cl..."*)

### Węzeł `[449]`
Mówca: **Patricio Alvarez (R)**
> ""On the contrary, Your Majesty. This is the best possible outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Patricio Alvarez (R): ""I feel it's finally time for Rizia and Lespia to grow cl..."*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, Rizia has qualms about you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Patricio Alvarez (R): ""But why, Your Majesty?""*)

### Węzeł `[451]`
Mówca: **Patricio Alvarez (R)**
> ""But why, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Patricio Alvarez (R): ""I feel it's finally time for Rizia and Lespia to grow cl..."*)

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So Lespia wants a closer partnership with Rizia?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Patricio Alvarez (R)), `[420]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Patricio Alvarez (R): ""Is that so strange?""*)

### Węzeł `[453]`
Mówca: **Patricio Alvarez (R)**
> ""Is that so strange?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Patricio Alvarez (R): ""In my case, I saw that it's time for Rizia and Lespia to..."*)

### Węzeł `[454]`
Mówca: **Patricio Alvarez (R)**
> ""Look at what we're up against. The forces of Malenyevism closing in on all sides.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Player_Romus: ""Morella's turn towards the east worries me as well.""*)
  - -> `[456]` (*Player_Romus: ""You're right. We have our differences, but neither of us..."*)
  - -> `[457]` (*Player_Romus: ""Malenyevism and Arcasian liberalism are just two sides o..."*)
  - -> `[458]` (*Player_Romus: ""It's capitalist vultures like you that keep me up at nig..."*)

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Morella's turn towards the east worries me as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[454]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Patricio Alvarez (R): ""Exactly, Your Majesty. Their new Prime Minister Saltana ..."*)

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. We have our differences, but neither of us wants Merkopa to turn into a socialist empire.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[454]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Patricio Alvarez (R): ""Damn straight, Your Majesty.""*)

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Malenyevism and Arcasian liberalism are just two sides of the same coin to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[454]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Patricio Alvarez (R): ""We're not strictly Arcasian liberals over here in Lespia..."*)

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's capitalist vultures like you that keep me up at night, not the specter of Malenyevism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[454]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist += 1"*)

### Węzeł `[459]`
Mówca: **Patricio Alvarez (R)**
> ""We're not strictly Arcasian liberals over here in Lespia, either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Patricio Alvarez (R): ""And at any rate, I'm sure you'll agree that the new prim..."*)

### Węzeł `[460]`
Mówca: **Patricio Alvarez (R)**
> ""Hrm... Well, but you must still agree that the new prime minister of Morella is bad news for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Patricio Alvarez (R): ""Getting up on her high horse, spouting made-up claims ab..."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Patricio Alvarez (R): ""Hrm... Well, but you must still agree that the new prime..."*)

### Węzeł `[462]`
Mówca: **Patricio Alvarez (R)**
> ""And at any rate, I'm sure you'll agree that the new prime minister of Morella is bad news for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Patricio Alvarez (R): ""Getting up on her high horse, spouting made-up claims ab..."*)

### Węzeł `[463]`
Mówca: **Patricio Alvarez (R)**
> ""Damn straight, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Patricio Alvarez (R): ""And I'm sure you'll agree that the new prime minister of..."*)

### Węzeł `[464]`
Mówca: **Patricio Alvarez (R)**
> ""And I'm sure you'll agree that the new prime minister of Morella is bad news for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Patricio Alvarez (R): ""Getting up on her high horse, spouting made-up claims ab..."*)

### Węzeł `[465]`
Mówca: **Patricio Alvarez (R)**
> ""Exactly, Your Majesty. Their new Prime Minister Saltana is bad news for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Patricio Alvarez (R): ""Getting up on her high horse, spouting made-up claims ab..."*)

### Węzeł `[466]`
Mówca: **Patricio Alvarez (R)**
> ""Getting up on her high horse, spouting made-up claims about pollution and human rights just because she has Valgsland in her corner...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Player_Romus: ""The Meftiem International Trade Zone nationalization deb..."*)
  - -> `[469]` (*Player_Romus: ""What does this have to do with the gas field, Mr. Alvarez?""*)
  - -> `[468]` (*Player_Romus: ""I don't know if we see eye to eye on this, Mr. Prime Min..."*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Meftiem International Trade Zone nationalization debate. I agree, it's pure rubbish.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Patricio Alvarez (R): ""Exactly!""*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know if we see eye to eye on this, Mr. Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Patricio Alvarez (R): ""Well, we should.""*)

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does this have to do with the gas field, Mr. Alvarez?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Patricio Alvarez (R): ""We're on the same side with Aureus. We've got to be a te..."*)

### Węzeł `[470]`
Mówca: **Patricio Alvarez (R)**
> ""Exactly!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Patricio Alvarez (R): ""Four countries share the mining rights to the MITZ. It's..."*)

### Węzeł `[471]`
Mówca: **Patricio Alvarez (R)**
> ""We're on the same side with Aureus. We've got to be a team here, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Patricio Alvarez (R): ""Four countries share the mining rights to the MITZ. It's..."*)

### Węzeł `[472]`
Mówca: **Patricio Alvarez (R)**
> ""Well, we should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Patricio Alvarez (R): ""Four countries share the mining rights to the MITZ. It's..."*)

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Aha. There's the ulterior motive I was looking for.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Patricio Alvarez (R)), `[297]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Patricio Alvarez (R): ""Not an ulterior motive. Just laying the facts on the tab..."*)

### Węzeł `[474]`
**[WYBÓR GRACZA: ""You bet I will, Mr. Alvarez. And I'll take you up on that gas offer." [-3 Budget, +2 Energy Per Turn In Future]"]** — Mówca: **Player_Romus**
> ""You bet I will, Mr. Alvarez. And I'll take you up on that gas offer.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[295]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Patricio Alvarez (R): ""I knew you were a smart man.""*)

### Węzeł `[475]`
Mówca: **Patricio Alvarez (R)**
> ""I knew you were a smart man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true; ..."*)

### Węzeł `[476]`
Mówca: **Patricio Alvarez (R)**
> ""Not an ulterior motive. Just laying the facts on the table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Patricio Alvarez (R): ""But enough about Morella. Do we have a deal on Aureus?""*)

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if I don't?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Patricio Alvarez (R)), `[297]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Patricio Alvarez (R): ""Then I'll do what I must to protect Lespia's own interes..."*)

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe I will, maybe I won't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Patricio Alvarez (R): ""If you don't, you should know I'll do whatever I must to..."*)

### Węzeł `[479]`
Mówca: **Patricio Alvarez (R)**
> ""You do? That's not what I heard, but suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)

### Węzeł `[480]`
Mówca: **Patricio Alvarez (R)**
> ""With pleasure, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_WehlenHelp = true;  RiziaDLC.Zi..."*)

### Węzeł `[481]`
Mówca: **Patricio Alvarez (R)**
> ""Looking forward to getting rich off Palesian gas together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_PromiseITZSupport = true; Rizia..."*)

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. This could be the beginning of a new era.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Patricio Alvarez (R): ""I hope so, Your Majesty.""*)

### Węzeł `[483]`
Mówca: **Patricio Alvarez (R)**
> ""If there's one thing we Lespians love, it's a long-term commitment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Patricio Alvarez (R): ""We'll celebrate next month in Kyrute. Over coffee.""*)

### Węzeł `[484]`
Mówca: **Patricio Alvarez (R)**
> ""I hope so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Patricio Alvarez (R): ""We'll celebrate next month in Kyrute. Over coffee.""*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Rich' is perhaps an overstatement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[481]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Patricio Alvarez (R): ""Natural gas is the future, isn't it? Any little bit is b..."*)

### Węzeł `[486]`
Mówca: **Patricio Alvarez (R)**
> ""Natural gas is the future, isn't it? Any little bit is better than none.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Patricio Alvarez (R): ""We'll celebrate next month in Kyrute. Over coffee.""*)

### Węzeł `[487]`
**[WYBÓR GRACZA: ""We do. But I won't make any promises regarding the MITZ." [-3 Budget, +2 Energy Per Turn In Future]"]** — Mówca: **Player_Romus**
> ""We do. But I won't make any promises regarding the MITZ.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[587]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Patricio Alvarez (R): ""Fair enough.""*)

### Węzeł `[488]`
Mówca: **Patricio Alvarez (R)**
> ""Fair enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true; ..."*)

### Węzeł `[489]`
Mówca: **Patricio Alvarez (R)**
> ""Hell, I'll even put in a good word for you at the Alliance of Nations. Try and help you out of this sticky situation you're in with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Patricio Alvarez (R): ""Assuming you want that.""*)

### Węzeł `[490]`
Mówca: **Patricio Alvarez (R)**
> ""Assuming you want that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Player_Romus: ""I do. Please help by any means necessary.""*)
  - -> `[492]` (*Player_Romus: ""Thank you for the offer, but we've got the Zille situati..."*)

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do. Please help by any means necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[490]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_WehlenHelp = true; RiziaDLC.Zil..."*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for the offer, but we've got the Zille situation under control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[490]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Patricio Alvarez (R): ""That's not what I heard. But suit yourself.""*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_WehlenHelp = true; RiziaDLC.Zille_ViolentResistancePower += 3;
RiziaDLC.Zille_ReferendumPower += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] = true;
Variable["RiziaDLC.Zille_ViolentResistancePower"] = Variable["RiziaDLC.Zille_ViolentResistancePower"] + 3;
Variable["RiziaDLC.Zille_ReferendumPower"] = Variable["RiziaDLC.Zille_ReferendumPower"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Patricio Alvarez (R): ""You're a smart man.""*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal = true; RiziaDLC.Diplomacy_Lespia_PromiseITZSupport = true; 
RiziaDLC.Diplomacy_Pales_GasField_Cede = false;
RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true;
RiziaDLC.Policy_Economy_PalesPipeline_Project = true; RiziaDLCSupport.Journal_Turn04_Lespia_PromiseITZSupport = true;
RiziaDLC.Resources_Budget -= 3; 
RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] = true;
Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = false;
Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Lespia_PromiseITZSupport"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_Country_Pales", "Progres..."*)

### Węzeł `[495]`
Mówca: **Patricio Alvarez (R)**
> ""You're a smart man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Patricio Alvarez (R): ""He's like an eel, that President Smolak. You won't get w..."*)

### Węzeł `[496]`
Mówca: **Patricio Alvarez (R)**
> ""He's like an eel, that President Smolak. You won't get what you want unless you tighten your grip on him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal..."*)

### Węzeł `[497]`
Mówca: **Patricio Alvarez (R)**
> ""That's not what I heard. But suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Patricio Alvarez (R): ""He's like an eel, that President Smolak. You won't get w..."*)

### Węzeł `[498]`
Mówca: **Patricio Alvarez (R)**
> ""He's like an eel, that President Smolak. You won't get what you want unless you tighten your grip on him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal..."*)

### Węzeł `[499]`
Mówca: **Patricio Alvarez (R)**
> ""At any rate, I'm glad we could do business. We'll celebrate next month in Kyrute. Over coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Player_Romus: ""Something stronger for me.""*)
  - -> `[501]` (*Player_Romus: ""I can't wait, Mr. Prime Minister.""*)
  - -> `[502]` (*Player_Romus: ""Good day, Mr. Alvarez.""*)

### Węzeł `[500]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Something stronger for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[499]` (Patricio Alvarez (R)), `[505]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "The line dropped."*)

### Węzeł `[501]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't wait, Mr. Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[499]` (Patricio Alvarez (R)), `[505]` (Patricio Alvarez (R)), `[544]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "The line dropped."*)

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good day, Mr. Alvarez.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[499]` (Patricio Alvarez (R)), `[505]` (Patricio Alvarez (R)), `[544]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "The line dropped."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true;
RiziaDLC.Resources_Budget -= 3;
RiziaDLC.Policy_Economy_PalesPipeline_Project = true; 
RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal = true;
RiziaDLC.Diplomacy_Pales_GasField_Cede = false;
RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;
Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 3;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;
Variable["RiziaDLCSupport.Journal_Turn04_Lespia_Accept25PercentDeal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = false;
Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_Country_Pales", "Progres..."*)

### Węzeł `[504]`
Mówca: **Patricio Alvarez (R)**
> ""We'll seal the deal soon after the Alliance of Nations meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Patricio Alvarez (R): ""I look forward to celebrating in person. Over coffee.""*)

### Węzeł `[505]`
Mówca: **Patricio Alvarez (R)**
> ""I look forward to celebrating in person. Over coffee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Player_Romus: ""Something stronger for me.""*)
  - -> `[501]` (*Player_Romus: ""I can't wait, Mr. Prime Minister.""*)
  - -> `[502]` (*Player_Romus: ""Good day, Mr. Alvarez.""*)

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the offer of assistance with Wehlen? That still stands?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Patricio Alvarez (R): ""Of course it does.""*)

### Węzeł `[507]`
Mówca: **Patricio Alvarez (R)**
> ""Of course it does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[509]` (*Player_Romus: ""I will not back down that easily, Mr. Alvarez. We will p..."*)

### Węzeł `[508]`
**[WYBÓR GRACZA: ""Fine. I'll withdraw both the Rizian navy and our claim to the field in exchange for 25 percent of the gas rights." [-4 Budget,  +2 Energy Per Turn in Future]"]** — Mówca: **Player_Romus**
> ""Fine. I'll withdraw both the Rizian navy and our claim to the field in exchange for 25 percent of the gas rights.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Kontekst wejściowy (poprzednik):** `[272]` (Patricio Alvarez (R)), `[275]` (Patricio Alvarez (R)), `[276]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Patricio Alvarez (R): ""Very excellent, Your Majesty. You've saved us both a lot..."*)

### Węzeł `[509]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not back down that easily, Mr. Alvarez. We will proceed with arbitration, and my navy will stay in place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Patricio Alvarez (R)), `[275]` (Patricio Alvarez (R)), `[276]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Patricio Alvarez (R): ""That's too bad, Your Majesty.""*)

### Węzeł `[510]`
Mówca: **Patricio Alvarez (R)**
> ""Very excellent, Your Majesty. You've saved us both a lot of trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal = tr..."*)

### Węzeł `[511]`
Mówca: **Patricio Alvarez (R)**
> ""That's too bad, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Patricio Alvarez (R): ""We have a long fight ahead of us.""*)

### Węzeł `[512]`
Mówca: **Patricio Alvarez (R)**
> ""We have a long fight ahead of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Player_Romus: ""One that I am confident Rizia will win.""*)
  - -> `[514]` (*Player_Romus: ""'We'? This is Pales' fight, not yours.""*)
  - -> `[515]` (*Player_Romus: ""I hope for a civil and peaceful legal process.""*)

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One that I am confident Rizia will win.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[512]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Patricio Alvarez (R): ""Ah, to have the confidence of a king.""*)

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'We'? This is Pales' fight, not yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[512]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Patricio Alvarez (R): ""You're right, Your Majesty. Lespia will not get directly..."*)

### Węzeł `[515]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope for a civil and peaceful legal process.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[512]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Patricio Alvarez (R): ""You know what would help with that? Withdrawing your mil..."*)

### Węzeł `[516]`
Mówca: **Patricio Alvarez (R)**
> ""You know what would help with that? Withdrawing your military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Patricio Alvarez (R): ""But I respect your decision.""*)

### Węzeł `[517]`
Mówca: **Patricio Alvarez (R)**
> ""But I respect your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Patricio Alvarez (R): ""I'll see you in Kyrute.""*)

### Węzeł `[518]`
Mówca: **Patricio Alvarez (R)**
> ""You're right, Your Majesty. Lespia will not get directly involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Patricio Alvarez (R): ""For now.""*)

### Węzeł `[519]`
Mówca: **Patricio Alvarez (R)**
> ""For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Patricio Alvarez (R): ""I'll see you in Kyrute.""*)

### Węzeł `[520]`
Mówca: **Patricio Alvarez (R)**
> ""Ah, to have the confidence of a king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Patricio Alvarez (R): ""I heard your father was also confident that Rizia would ..."*)

### Węzeł `[521]`
Mówca: **Patricio Alvarez (R)**
> ""I heard your father was also confident that Rizia would reconquer Pales. I wonder what happened there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Patricio Alvarez (R): ""I'll see you in Kyrute.""*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower += 2;
RiziaDLC.Policy_Economy_PalesPipeline_Project = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] + 2;
Variable["RiziaDLC.Policy_Economy_PalesPipeline_Project"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "AddTokenStatusImmediately("Rizia_Country_Pales", "Progres..."*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Pales_NegotiatingPower"] - 2;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Patricio Alvarez (R): ""I truly appreciate this.""*)

### Węzeł `[524]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are not closed to the idea, but I want to know more about what you have in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Patricio Alvarez (R): ""Let me help you with a brilliant and mutually beneficial..."*)

### Węzeł `[525]`
Mówca: **Patricio Alvarez (R)**
> ""Let me help you with a brilliant and mutually beneficial idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Patricio Alvarez (R): ""Cancel on Pales, allow Lespia to go through with our pla..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true"*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == ..."*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "I heard him sigh on the other end of the line."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Patricio Alvarez (R): ""I was heartened to hear of the results of your meeting w..."*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_BuyCancelled = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_BuyCancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_NegotiatingPower -= 2; RiziaDLC...."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_Cancelled = true;
RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_DiplomaticArbitration_Cancelled"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_NegotiatingPower += 1; RiziaDLC...."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Player_Romus: ""I hope you'll honor the bargain.""*)
  - -> `[482]` (*Player_Romus: ""Perfect. This could be the beginning of a new era.""*)
  - -> `[485]` (*Player_Romus: ""'Rich' is perhaps an overstatement.""*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Patricio Alvarez (R): ""At any rate, I'm glad we could do business. We'll celebr..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Patricio Alvarez (R): ""We'll seal the deal soon after the Alliance of Nations m..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatusImmediately("Rizia_Country_Pales", "Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Efekt skryptowy (`userScript`):** `AddTokenStatusImmediately("Rizia_Country_Pales","Progress_Construction_PalesPipeline");
ScheduleProgress("Progress_Construction_PalesPipeline", 2);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Patricio Alvarez (R): ""I'm looking forward to celebrating our agreement in pers..."*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true )"*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""You're lucky it's only that. Duke Reinhart wanted me to ..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 3)"*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Player_Romus: ""We do. But I won't make any promises regarding the MITZ...."*)
  - -> `[592]` (*Player_Romus: ""Absolutely. And I'll back you against Morella if it mean..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Player_Romus: ""The gas field offer isn't within my budget. But I'll sup..."*)

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to have anything to do with Lespia. Even if it means giving up access to the Aureus field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[587]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Patricio Alvarez (R): ""Suit yourself. I was only trying to be nice.""*)

### Węzeł `[542]`
Mówca: **Patricio Alvarez (R)**
> ""Suit yourself. I was only trying to be nice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede = true; RiziaDLC.D..."*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GasField_Cede = true;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Morella_NegotiatingPower += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Patricio Alvarez (R): ""I'll see you in Kyrute.""*)

### Węzeł `[544]`
Mówca: **Patricio Alvarez (R)**
> ""I'll see you in Kyrute.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Player_Romus: ""I can't wait, Mr. Prime Minister.""*)
  - -> `[502]` (*Player_Romus: ""Good day, Mr. Alvarez.""*)
  - -> `[545]` (*Player_Romus: ""Thank you for calling.""*)

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for calling.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[544]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "The line dropped."*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("PhoneRingPickUp");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("PhoneRingPickUp");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "At 3:01pm, it rang."*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 4)"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Player_Romus: ""Fine. I'll withdraw both the Rizian navy and our claim t..."*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Player_Romus: ""We can't make these sorts of financial commitments right..."*)

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't make these sorts of financial commitments right now. Nothing changes in our action plan.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Kontekst wejściowy (poprzednik):** `[272]` (Patricio Alvarez (R)), `[275]` (Patricio Alvarez (R)), `[276]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Patricio Alvarez (R): ""That's too bad, Your Majesty.""*)

### Węzeł `[551]`
Mówca: **Laurento Esquibel**
> ""And there's the matter of our shared interests in the Meftiem International Trade Zone. He must also be aware of Morella's nationalization intentions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Alvarez_Want = true"*)

### Węzeł `[552]`
Mówca: **Patricio Alvarez (R)**
> ""And let me guess. He talked you into paying for the infrastructure. All that money gone, for results you won't see for years if at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Patricio Alvarez (R): ""Eventually, Reinhart will come back to us. I'm just tryi..."*)

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So in your version of the deal, we'd get less gas from the field, but the pipeline would be free?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[330]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Patricio Alvarez (R): ""You got it. And if Aureus turns out to be a dud after al..."*)

### Węzeł `[554]`
Mówca: **Patricio Alvarez (R)**
> ""You got it. And if Aureus turns out to be a dud after all, you won't have lost a cent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Patricio Alvarez (R): ""But it's up to you. Keep your deal if you believe that's..."*)

### Węzeł `[555]`
Mówca: **Patricio Alvarez (R)**
> ""And LesPower will take over whatever infrastructure costs are necessary to bring that gas from Aureus to Rizia's doorstep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player_Romus: ""How do I know I can trust you?""*)
  - -> `[224]` (*Player_Romus: ""You wouldn't be bargaining if you thought you had an air..."*)
  - -> `[222]` (*Player_Romus: ""That's an insult, Mr. Alvarez. Those rights are ours to ..."*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true"*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_PalesPipelineConstruction"] = 0;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent == tr..."*)
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent == ..."*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Budget_Modifier_PalesPipelineConstruction = 0"*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Lespia_Aureus25Percent"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[560]`
Mówca: **Patricio Alvarez (R)**
> ""Even if you had a claim, defending and enforcing it would cost you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Patricio Alvarez (R): ""And I don't just mean money. A resource-hungry monarchy ..."*)

### Węzeł `[561]`
Mówca: **Patricio Alvarez (R)**
> ""And I don't just mean money. A resource-hungry monarchy clashing with its closest neighbors... do you really want that image for Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player_Romus: ""My father was right about you.""*)
  - -> `[235]` (*Player_Romus: ""You may be sober, but I don't believe for a second that ..."*)
  - -> `[564]` (*Player_Romus: ""Reinhart was the one who started this mess. And we're su..."*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal = true; 
RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = false; 
RiziaDLCSupport.Reports_Turn04_NavyWithdrawn = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = false;
Variable["RiziaDLCSupport.Reports_Turn04_NavyWithdrawn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "We said our goodbyes and hung up."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal = true; 
RiziaDLC.Diplomacy_Pales_Military_BlockDrillship = false; 
RiziaDLCSupport.Reports_Turn04_NavyWithdrawn = true;
RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal"] = true;
Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] = false;
Variable["RiziaDLCSupport.Reports_Turn04_NavyWithdrawn"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration = fal..."*)

### Węzeł `[564]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Reinhart was the one who started this mess. And we're supposed to simply roll over to him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[561]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Patricio Alvarez (R): ""You'd get championed as a peacemaker, and you'd still ge..."*)

### Węzeł `[565]`
Mówca: **Patricio Alvarez (R)**
> ""You'd get championed as a peacemaker, and you'd still get gas out of the deal. I'd go for it, if I were in your shoes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Patricio Alvarez (R): ""We're on the same side here. Don't forget about our part..."*)

### Węzeł `[566]`
Mówca: **Patricio Alvarez (R)**
> ""We're on the same side here. Don't forget about our partnership in the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Patricio Alvarez (R): ""You're worried about someone trying to steal your resour..."*)

### Węzeł `[567]`
Mówca: **Patricio Alvarez (R)**
> ""You're worried about someone trying to steal your resources away, you should look no further than your neighbor Ms. Saltana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Patricio Alvarez (R): ""Getting up on her high horse, spouting made-up concerns ..."*)

### Węzeł `[568]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Meftiem International Trade Zone nationalization debate. I agree, it's pure rubbish.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[574]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Patricio Alvarez (R): ""Exactly! If Rizia and Lespia don't hold the line against..."*)

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know if we see eye to eye on this, Mr. Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[574]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Patricio Alvarez (R): ""Well, we should. If Rizia and Lespia don't hold the line..."*)

### Węzeł `[570]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's an entirely different topic. We were talking about the gas field.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[574]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Patricio Alvarez (R): ""Resources are resources. And perhaps Rizia's time and en..."*)

### Węzeł `[571]`
Mówca: **Patricio Alvarez (R)**
> ""Exactly! If Rizia and Lespia don't hold the line against the commies, they'll take everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Patricio Alvarez (R): ""So how do you feel about a partnership?""*)

### Węzeł `[572]`
Mówca: **Patricio Alvarez (R)**
> ""Resources are resources. And perhaps Rizia's time and energy are better spent protecting what you already have instead of going after something you don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Patricio Alvarez (R): ""So how do you feel about a partnership?""*)

### Węzeł `[573]`
Mówca: **Patricio Alvarez (R)**
> ""Well, we should. If Rizia and Lespia don't hold the line against the commies, they'll take everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Patricio Alvarez (R): ""So how do you feel about a partnership?""*)

### Węzeł `[574]`
Mówca: **Patricio Alvarez (R)**
> ""Getting up on her high horse, spouting made-up concerns about pollution and human rights just because she has Valgsland in her corner...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Player_Romus: ""The Meftiem International Trade Zone nationalization deb..."*)
  - -> `[570]` (*Player_Romus: ""That's an entirely different topic. We were talking abou..."*)
  - -> `[569]` (*Player_Romus: ""I don't know if we see eye to eye on this, Mr. Prime Min..."*)

### Węzeł `[575]`
Mówca: **Patricio Alvarez (R)**
> ""So how do you feel about a partnership?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player_Romus: ""Thanks for the offer, Mr. Alvarez. I'll remember your pa..."*)
  - -> `[245]` (*Player_Romus: ""I know full well what I'm up against. But win or lose, I..."*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)

### Węzeł `[576]`
Mówca: **Patricio Alvarez (R)**
> ""LesPower will take care of any infrastructure needed to deliver the gas to Rizia. You'd barely even have to lift a finger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Player_Romus: ""I would be interested. Tell me more.""*)
  - -> `[410]` (*Player_Romus: ""I'm not buying it, Mr. Prime Minister. What's the catch?""*)
  - -> `[411]` (*Player_Romus: ""What makes you think I want anything to do with the Aure..."*)
  - -> `[412]` (*Player_Romus: ""If I wanted gas from that field, I'd purchase it from Pa..."*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 3)"*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Player_Romus: ""You bet I will, Mr. Alvarez. And I'll take you up on tha..."*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Player_Romus: ""I have to say upfront that I don't have the budget for t..."*)

### Węzeł `[580]`
**[WYBÓR GRACZA: ""You know what? If it helps grease the wheels on our gas deal, I will." [-3 Budget, +2 Energy Per Turn In Future]"]** — Mówca: **Player_Romus**
> ""You know what? If it helps grease the wheels on our gas deal, I will.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[297]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Patricio Alvarez (R): ""I knew you were a smart man.""*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 3)"*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Player_Romus: ""You know what? If it helps grease the wheels on our gas ..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Player_Romus: ""I have to say upfront that I don't have the budget for t..."*)

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to say upfront that I don't have the budget for this gas deal you're offering. But when it comes to the MITZ, we are on the same side.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[295]` (Patricio Alvarez (R)), `[297]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Patricio Alvarez (R): ""That's great to hear, Your Majesty. No worries about the..."*)

### Węzeł `[585]`
Mówca: **Patricio Alvarez (R)**
> ""That's great to hear, Your Majesty. No worries about the gas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_PromiseITZSupport = true"*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal = true; RiziaDLC.Diplomacy_Lespia_PromiseITZSupport = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Patricio Alvarez (R): ""And hell, I'll even put in a good word for you at the Al..."*)

### Węzeł `[587]`
Mówca: **Patricio Alvarez (R)**
> ""But enough about Morella. Do we have a deal on Aureus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 3"*)
  - -> `[595]` (*Player_Romus: ""I'm not going to accept the gas offer. But when it comes..."*)
  - -> `[541]` (*Player_Romus: ""I don't want to have anything to do with Lespia. Even if..."*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true"*)
  - -> `[590]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)"*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Patricio Alvarez (R): ""Looking forward to getting rich off Palesian gas together.""*)

### Węzeł `[590]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GasField_Cede = true; RiziaDLC.D..."*)

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The gas field offer isn't within my budget. But I'll support you in the MITZ when the time comes.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 3) == false`
- **Kontekst wejściowy (poprzednik):** `[587]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Patricio Alvarez (R): ""That's great to hear, Your Majesty. No worries about the..."*)

### Węzeł `[592]`
**[WYBÓR GRACZA: ""Absolutely. And I'll back you against Morella if it means that much to you." [-3 Budget, +2 Energy Per Turn In Future]"]** — Mówca: **Player_Romus**
> ""Absolutely. And I'll back you against Morella if it means that much to you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 3`
- **Kontekst wejściowy (poprzednik):** `[587]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Patricio Alvarez (R): ""To *us*, Your Majesty. Thank you.""*)

### Węzeł `[593]`
Mówca: **Patricio Alvarez (R)**
> ""To *us*, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Patricio Alvarez (R): ""Hell, I'll even put in a good word for you at the Allian..."*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Lespia_PromiseITZSupport = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Patricio Alvarez (R): ""And hell, I'll even put in a good word for you at the Al..."*)

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going to accept the gas offer. But when it comes to the MITZ, Rizia has your back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[587]` (Patricio Alvarez (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Patricio Alvarez (R): ""That's great to hear, Your Majesty. No worries about the..."*)

### Węzeł `[596]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Taking a lucrative call from Lespia’s Prime Minister", "Personal Office", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Taking a lucrative call from Lespia’s Prime Minister","Personal Office","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");"*)
