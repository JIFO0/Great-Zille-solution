# Rizia/Turn 9/Morella Derdia Mediation

- **ID konwersacji:** `436`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/436_Morella_Derdia_Mediation.md`
- **Liczba węzłów dialogowych:** 403
- **Liczba wyborów gracza:** 63

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[70]** Laurento Esquibel
- **[95]** Player_Romus *(Gracz)*
- **[100]** Alma Saltana

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_QuelledProtests`
- `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort`
- `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Intermerkopum_Efforts`
- `RiziaDLC.MITZ_Concession_DerdianBorderAssistance`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Economy_DerdiaPipeline_Completed`
- `RiziaDLC.Policy_Law_Monarchy_Absolute`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Policy_RD_Religion_RemoveStateReligion`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed`
- `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Rico`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Resources_Military_Manpower`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed`
- `RiziaDLC.Turn09_MorellaDerdiaMediation_Success`
- `RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Failure`
- `RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Success`
- `RiziaDLCSupport.News_Turn09_G_PrayerCorridorMorella`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[435] Rizia/Turn 9/FPnT_Mediation** (../Turn_09/435_FPnT_Mediation.md), Węzeł `[6]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""So. Here we all are.""** | `[5]` **Narrator**: "They and a handful of their mini..."<br>`[362]` **Narrator**: "She and her entourage were escor..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Alma Saltana**: ""Yes. Here we are."" |
| `[10]` | **""I'd like to begin with a short prayer.""** | `[5]` **Narrator**: "They and a handful of their mini..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[11]` **Narrator**: "The Supreme Wiseman's eyes shone..." |
| `[14]` | **""Ladies, gentleman. Shall we get right to it?""** | `[5]` **Narrator**: "They and a handful of their mini..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Alma Saltana**: ""Gladly, {RiziaDLCText.SaltanaTo..." |
| `[15]` | **""Thank you both for joining me. I am confident we can accomplish great things today.""** | `[5]` **Narrator**: "They and a handful of their mini..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "Azmal and Saltana looked at each..." |
| `[17]` | **""As we gather today, I pray that we do not let our trivial differences blind us. F..."** | `[12]` **Alma Saltana**: ""If you must."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Jorga Azmal**: ""Halaita, Your Majesty."" |
| `[18]` | **""O Divine Creator, bless this mediation table and all who are seated at it. Help t..."** | `[12]` **Alma Saltana**: ""If you must."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Jorga Azmal**: ""Halaita, Your Majesty."" |
| `[19]` | **""Lord, guide me in my sacred duty of finding communion between the nations of the ..."** | `[12]` **Alma Saltana**: ""If you must."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Jorga Azmal**: ""Halaita, Your Majesty."" |
| `[31]` | **""Rizia re-allowed Derdian Golcondists into our places of worship with no ill conse..."** | `[117]` **Jorga Azmal**: ""And yet you cannot deny those w..." | `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true` | *Brak zmian stanu* | `[32]` **Alma Saltana**: ""Rizia shares no borders with De..." |
| `[39]` | **""You go home the way you came. It's not that difficult.""** | `[38]` **Jorga Azmal**: ""This route ends at Lauante. Aft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "Both Azmal and Saltana glowered ..." |
| `[40]` | **""You may continue into Rizia, as long as you agree to respect our blasphemy law.""** | `[38]` **Jorga Azmal**: ""This route ends at Lauante. Aft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "Both Azmal and Saltana glowered ..." |
| `[41]` | **""Not a bad idea.""** | `[38]` **Jorga Azmal**: ""This route ends at Lauante. Aft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "Both Azmal and Saltana glowered ..." |
| `[42]` | **""Not at all. I fully plan on allowing Golcondists to worship in Rizia as well.""** | `[38]` **Jorga Azmal**: ""This route ends at Lauante. Aft..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "Azmal raised his eyebrows skepti..." |
| `[45]` | **""Our Wruhecist community is larger than Morella's. There is greater potential for ..."** | `[44]` **Alma Saltana**: ""{RiziaDLCText.SaltanaToPlayer},..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Alma Saltana**: ""If you believe disruption is a ..." |
| `[46]` | **""I'm afraid revoking our blasphemy law is out of the question. The Wruhecist Sanct..."** | `[44]` **Alma Saltana**: ""{RiziaDLCText.SaltanaToPlayer},..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Jorga Azmal**: ""Then I cannot agree to your plan."" |
| `[47]` | **""Rizia is in the middle of a war. I don't want to make any sudden policy changes.""** | `[44]` **Alma Saltana**: ""{RiziaDLCText.SaltanaToPlayer},..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[161]` **Jorga Azmal**: ""Then I cannot agree to your plan."" |
| `[84]` | **""Now is not the time to talk about the energy situation. You may bring it up with ..."** | `[72]` **Alma Saltana**: ""It seems we have one thing in c..."<br>`[76]` **Alma Saltana**: ""Rizia has proven itself an unre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "Saltana pursed her lips."<br>`[98]` **Narrator**: "Azmal gritted his teeth." |
| `[85]` | **""I am truly sorry that our conflict with Pales interfered with our promised energy..."** | `[72]` **Alma Saltana**: ""It seems we have one thing in c..."<br>`[76]` **Alma Saltana**: ""Rizia has proven itself an unre..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true`<br>`(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true) == false` | *Brak zmian stanu* | `[97]` **Narrator**: "Saltana pursed her lips."<br>`[98]` **Narrator**: "Azmal gritted his teeth." |
| `[89]` | **""Our energy deliveries were impeded by circumstances beyond my control. I sincerel..."** | `[72]` **Alma Saltana**: ""It seems we have one thing in c..."<br>`[76]` **Alma Saltana**: ""Rizia has proven itself an unre..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Pales_War"] == true) == false`<br>`(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true) == false` | *Brak zmian stanu* | `[97]` **Narrator**: "Saltana pursed her lips."<br>`[98]` **Narrator**: "Azmal gritted his teeth." |
| `[90]` | **""You have more than that in common. It was only a few generations ago that the Mor..."** | `[72]` **Alma Saltana**: ""It seems we have one thing in c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Narrator**: "Azmal nodded vigorously." |
| `[93]` | **""You don't have a choice, do you? It's Rizia or nobody.""** | `[72]` **Alma Saltana**: ""It seems we have one thing in c..."<br>`[76]` **Alma Saltana**: ""Rizia has proven itself an unre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Narrator**: "Saltana pursed her lips."<br>`[98]` **Narrator**: "Azmal gritted his teeth." |
| `[113]` | **""You will address the Supreme Wiseman using his full title, Prime Minister Saltana.""** | `[106]` **Alma Saltana**: ""Are you sure it's my language y..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = ...` | `[115]` **Narrator**: "Her face darkened." |
| `[122]` | **""There's obviously only one way to solve this. A Duel of Generosity.""** | `[106]` **Alma Saltana**: ""Are you sure it's my language y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: "Laurento turned pale. Saltana bu..." |
| `[136]` | **""Never mind the Prime Minister's language, Supreme Wiseman. You must admit that th..."** | `[106]` **Alma Saltana**: ""Are you sure it's my language y..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = ...` | `[137]` **Narrator**: "His face darkened." |
| `[140]` | **""Stop squabbling at once, both of you. Your conduct is befitting of kindergartener..."** | `[106]` **Alma Saltana**: ""Are you sure it's my language y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Narrator**: "Both Saltana and Azmal looked do..." |
| `[148]` | **""Is it the right to worship you are after, or is it Morella's resources? We have n..."** | `[117]` **Jorga Azmal**: ""And yet you cannot deny those w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Jorga Azmal**: ""That was the work of rogue acto..." |
| `[149]` | **""The borders between Derdia and Morella were drawn only recently. They do feel rat..."** | `[117]` **Jorga Azmal**: ""And yet you cannot deny those w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Alma Saltana**: ""And yet they are there for a re..." |
| `[151]` | **""What Derdians do hardly falls under the category of worship.""** | `[117]` **Jorga Azmal**: ""And yet you cannot deny those w..." | `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false` | *Brak zmian stanu* | `[153]` **Jorga Azmal**: ""You are still under the sway of..."<br>`[157]` **Jorga Azmal**: ""You are still under the sway of..." |
| `[166]` | **""We're in a delicate situation with Wehlen at the moment. I don't want to make any..."** | `[44]` **Alma Saltana**: ""{RiziaDLCText.SaltanaToPlayer},..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[161]` **Jorga Azmal**: ""Then I cannot agree to your plan."" |
| `[169]` | **""So be it. I tried my best.""** | `[168]` **Jorga Azmal**: ""Nor can I."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Jorga Azmal**: ""I am not certain I believe you,..." |
| `[173]` | **""Wait. I don't have a Grand Wiseman to appease anymore. I will revoke Rizia's blas..."** | `[162]` **Alma Saltana**: ""Nor can I.""<br>`[168]` **Jorga Azmal**: ""Nor can I."" | `Variable["RiziaDLC.Sal_Arrested"] == true  and  Variable["RiziaDLC.Resources_Authority"] >= 4` | `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBla...` | `[191]` **Jorga Azmal**: ""How fortunate, Your Majesty. I ..." |
| `[174]` | **""Wait. If it helps your nations get along, I will revoke Rizia's blasphemy law, ef..."** | `[162]` **Alma Saltana**: ""Nor can I.""<br>`[168]` **Jorga Azmal**: ""Nor can I."" | `Variable["RiziaDLC.Resources_Authority"] >= 4`<br>`(Variable["RiziaDLC.Sal_Arrested"] == true  and  Variable["RiziaDLC.Resources_Authority"] >= 4) == false` | `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBla...` | `[191]` **Jorga Azmal**: ""How fortunate, Your Majesty. I ..." |
| `[178]` | **""There's nothing I can do. That was my kingdom's best effort.""** | `[162]` **Alma Saltana**: ""Nor can I.""<br>`[168]` **Jorga Azmal**: ""Nor can I."" | `(Variable["RiziaDLC.Resources_Authority"] >= 4) == false`<br>`(Variable["RiziaDLC.Sal_Arrested"] == true  and  Variable["RiziaDLC.Resources_Authority"] >= 4) == false` | *Brak zmian stanu* | `[193]` **Jorga Azmal**: ""I am not certain I believe you,..." |
| `[182]` | **""I don't have a Grand Wiseman to appease anymore. I will revoke Rizia's blasphemy ..."** | `[50]` **Jorga Azmal**: ""You will forgive me if I don't ..."<br>`[160]` **Jorga Azmal**: ""If you don't mind, I would like..." | `Variable["RiziaDLC.Sal_Arrested"] == true` | `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBla...` | `[191]` **Jorga Azmal**: ""How fortunate, Your Majesty. I ..." |
| `[183]` | **""Very well. If it helps your nations get along, I will revoke Rizia's blasphemy la..."** | `[50]` **Jorga Azmal**: ""You will forgive me if I don't ..."<br>`[160]` **Jorga Azmal**: ""If you don't mind, I would like..." | `Variable["RiziaDLC.Resources_Authority"] >= 4`<br>`(Variable["RiziaDLC.Sal_Arrested"] == true) == false` | `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBla...` | `[191]` **Jorga Azmal**: ""How fortunate, Your Majesty. I ..." |
| `[187]` | **""Sorry. An assurance is all I can give you right now.""** | `[50]` **Jorga Azmal**: ""You will forgive me if I don't ..."<br>`[160]` **Jorga Azmal**: ""If you don't mind, I would like..." | `(Variable["RiziaDLC.Resources_Authority"] >= 4) == false`<br>`(Variable["RiziaDLC.Sal_Arrested"] == true) == false` | *Brak zmian stanu* | `[188]` **Jorga Azmal**: ""Then I cannot agree to this pro..." |
| `[190]` | **""I don't like your attitude, Supreme Wiseman. I will promise you nothing.""** | `[50]` **Jorga Azmal**: ""You will forgive me if I don't ..."<br>`[160]` **Jorga Azmal**: ""If you don't mind, I would like..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Jorga Azmal**: ""Then I cannot agree to this pro..." |
| `[204]` | **""I will send a company from the Rizian Armed Forces to grant the pilgrims secure p..."** | `[219]` **Jorga Azmal**: ""How do *we* know the Morellans ..."<br>`[341]` **Alma Saltana**: ""Yes, {Salutations.SaltanaToPlay..." | `Variable["RiziaDLC.Resources_Military_Manpower"] > 250` | *Brak zmian stanu* | `[213]` **Jorga Azmal**: ""I can accept that.""<br>`[220]` **Jorga Azmal**: ""I'm afraid that's not enough as..." |
| `[205]` | **""The Kingdom of Rizia will pay for a small team of independent contractors to over..."** | `[219]` **Jorga Azmal**: ""How do *we* know the Morellans ..."<br>`[341]` **Alma Saltana**: ""Yes, {Salutations.SaltanaToPlay..." | `Variable["RiziaDLC.Resources_Budget"] >= 1` | *Brak zmian stanu* | `[226]` **Jorga Azmal**: ""I can accept that.""<br>`[231]` **Jorga Azmal**: ""I'm afraid that's not enough as..." |
| `[206]` | **""Whoever violates the agreement will face the most severe of consequences. My king..."** | `[219]` **Jorga Azmal**: ""How do *we* know the Morellans ..."<br>`[341]` **Alma Saltana**: ""Yes, {Salutations.SaltanaToPlay..." | `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true` | *Brak zmian stanu* | `[248]` **Jorga Azmal**: ""I can accept that.""<br>`[253]` **Jorga Azmal**: ""I'm afraid that's not enough as..." |
| `[261]` | **""Then you're both out of luck.""** | `[218]` **Alma Saltana**: ""I cannot.""<br>`[224]` **Alma Saltana**: ""I think it's a fine plan. But i..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Narrator**: "The two of them looked away from..." |
| `[263]` | **""Fine. We will send *two* army companies." [-500 Manpower]"** | `[218]` **Alma Saltana**: ""I cannot.""<br>`[224]` **Alma Saltana**: ""I think it's a fine plan. But i..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Resources_Military_Manpower"] >= 500` | `Variable["RiziaDLC.Resources_Military_Manpower"] = Variab...` | `[267]` **Narrator**: "The two of them looked at each o..." |
| `[264]` | **""Fine. We will pour twice as much funding into security as planned." [-2 Budget]"** | `[235]` **Alma Saltana**: ""I cannot.""<br>`[236]` **Alma Saltana**: ""I think it's a fine plan. But i..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] >= 2` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | `[267]` **Narrator**: "The two of them looked at each o..." |
| `[265]` | **""Fine. A company from the Rizian Armed Forces will be physically present to grant ..."** | `[257]` **Alma Saltana**: ""I cannot.""<br>`[258]` **Alma Saltana**: ""I think it's a fine plan. But i..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Resources_Military_Manpower"] >= 250` | `Variable["RiziaDLC.Resources_Military_Manpower"] = Variab...` | `[267]` **Narrator**: "The two of them looked at each o..." |
| `[266]` | **""If you insist, the Kingdom of Rizia will pay for a small team of independent cont..."** | `[257]` **Alma Saltana**: ""I cannot.""<br>`[258]` **Alma Saltana**: ""I think it's a fine plan. But i..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] >= 1` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | `[267]` **Narrator**: "The two of them looked at each o..." |
| `[270]` | **""In addition to the military reinforcements, we will contract a team of independen..."** | `[218]` **Alma Saltana**: ""I cannot.""<br>`[224]` **Alma Saltana**: ""I think it's a fine plan. But i..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Resources_Budget"] >= 1` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | `[267]` **Narrator**: "The two of them looked at each o..." |
| `[271]` | **""In addition to the security firm, we ourselves will send a company from the Rizia..."** | `[235]` **Alma Saltana**: ""I cannot.""<br>`[236]` **Alma Saltana**: ""I think it's a fine plan. But i..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Resources_Military_Manpower"] >= 250` | `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDL...` | `[267]` **Narrator**: "The two of them looked at each o..." |
| `[272]` | **""You're just going to have to trust each other, aren't you?""** | `[219]` **Jorga Azmal**: ""How do *we* know the Morellans ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Narrator**: "The two of them looked at each o..." |
| `[277]` | **""You really thought we could erase a century's worth of resentment in five minutes?""** | `[274]` **Jorga Azmal**: ""I should have known this would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Narrator**: "The two of them looked away from..." |
| `[303]` | **""If Morella and Derdia can come to a diplomatic agreement this quickly, I have hig..."** | `[262]` **Laurento Esquibel**: ""We'll assemble a team from all ..." | `Variable["RiziaDLC.Intermerkopum_Efforts"] == true` | *Brak zmian stanu* | `[318]` **Laurento Esquibel**: ""Agreed, Your Majesty."" |
| `[307]` | **""Prime Minister Saltana, I hope this means that I can count on your cooperation du..."** | `[262]` **Laurento Esquibel**: ""We'll assemble a team from all ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Narrator**: "She smiled mysteriously." |
| `[308]` | **""The Lord has truly blessed us on this day. Rejoice!""** | `[262]` **Laurento Esquibel**: ""We'll assemble a team from all ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[316]` **Jorga Azmal**: ""Halaita!"" |
| `[312]` | **""Thank you for your hard work, Laurento. This was truly a team effort.""** | `[262]` **Laurento Esquibel**: ""We'll assemble a team from all ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Laurento Esquibel**: ""You honor me, Your Majesty."" |
| `[321]` | **""It's fine. We don't need Morella and Derdia to get along for the Intermerkopum al..."** | `[195]` **Laurento Esquibel**: ""Thank you, Madam Prime Minister..." | `Variable["RiziaDLC.Intermerkopum_Efforts"] == true` | *Brak zmian stanu* | `[334]` **Laurento Esquibel**: ""I must say it would have helped..." |
| `[328]` | **""Alas, the Lord has not blessed us on this day. Perhaps we did something to anger ..."** | `[195]` **Laurento Esquibel**: ""Thank you, Madam Prime Minister..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[333]` **Alma Saltana**: ""No comment, Your Majesty."" |
| `[329]` | **""Prime Minister Saltana, I hope I can still count on your cooperation during the f..."** | `[195]` **Laurento Esquibel**: ""Thank you, Madam Prime Minister..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Narrator**: "Her expression betrayed no emotion." |
| `[330]` | **""Yes, thanks anyway, Laurento. This was a great idea.""** | `[195]` **Laurento Esquibel**: ""Thank you, Madam Prime Minister..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Laurento Esquibel**: ""You honor me, Your Majesty."" |
| `[337]` | **""No, wait. I do have one idea.""** | `[274]` **Jorga Azmal**: ""I should have known this would ..." | `Variable["RiziaDLC.Resources_Military_Manpower"] >= 1500  or  Variable["RiziaDLC.Resources_Budget"] >= 5  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true` | *Brak zmian stanu* | `[341]` **Alma Saltana**: ""Yes, {Salutations.SaltanaToPlay..." |
| `[342]` | **""Suddenly the man who believes in an invisible person in the sky doesn't have fait..."** | `[274]` **Jorga Azmal**: ""I should have known this would ..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[346]` **Narrator**: "Azmal gasped indignantly. Saltan..." |
| `[347]` | **""You must take a leap of faith, Supreme Wiseman. What would St. Wruhec have done?""** | `[274]` **Jorga Azmal**: ""I should have known this would ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[348]` **Jorga Azmal**: ""As Wruhec himself said, the fir..." |
| `[383]` | **""You don't have a choice, do you? It's Rizia or nobody.""** | `[379]` **Alma Saltana**: ""We in Morella have been paying ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Narrator**: "She gritted her teeth." |
| `[384]` | **""Rizia has always been an absolute monarchy, Ms. Saltana. You just chose to ignore..."** | `[379]` **Alma Saltana**: ""We in Morella have been paying ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Narrator**: "She gritted her teeth." |
| `[385]` | **""I hear your concerns, but they're not germane to today's conversation.""** | `[379]` **Alma Saltana**: ""We in Morella have been paying ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Alma Saltana**: ""No? I'd like to know just what ..." |
| `[386]` | **""You have no idea what you're talking about. The people of my country enjoy a grea..."** | `[379]` **Alma Saltana**: ""We in Morella have been paying ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Alma Saltana**: ""Excuse me? That's just not true."" |

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
  - -> `[3]` (*Narrator: "A knock came on the door. Prime Minister Saltana and Supr..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""So. Here we all are.""*)

### Węzeł `[3]`
Mówca: **Narrator**
> "A knock came on the door. Prime Minister Saltana and Supreme Wiseman Azmal had arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "A lot had happened since I promised the Derdian and Morel..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "A lot had happened since I promised the Derdian and Morellan leaders that I would mediate between them. But I was still determined to find a solution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "AddConversant("Alma Saltana"); AddConversant("Jorga Azmal");"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "They and a handful of their ministers joined myself and Laurento around the conference table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""So. Here we all are.""*)
  - -> `[14]` (*Player_Romus: ""Ladies, gentleman. Shall we get right to it?""*)
  - -> `[15]` (*Player_Romus: ""Thank you both for joining me. I am confident we can acc..."*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So. Here we all are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[362]` (Narrator), `[358]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Alma Saltana: ""Yes. Here we are.""*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""I'd like to begin with a short prayer.""*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd like to begin with a short prayer.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "The Supreme Wiseman's eyes shone with delight. His Morell..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "The Supreme Wiseman's eyes shone with delight. His Morellan counterpart crossed her arms impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Alma Saltana: ""If you must.""*)

### Węzeł `[12]`
Mówca: **Alma Saltana**
> ""If you must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""As we gather today, I pray that we do not let our trivia..."*)
  - -> `[18]` (*Player_Romus: ""O Divine Creator, bless this mediation table and all who..."*)
  - -> `[19]` (*Player_Romus: ""Lord, guide me in my sacred duty of finding communion be..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Alma Saltana");
AddConversant("Jorga Azmal");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Alma Saltana");
AddConversant("Jorga Azmal");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "They and a handful of their ministers joined myself and L..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ladies, gentleman. Shall we get right to it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Alma Saltana: ""Gladly, {RiziaDLCText.SaltanaToPlayer}.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you both for joining me. I am confident we can accomplish great things today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Azmal and Saltana looked at each other uneasily."*)

### Węzeł `[16]`
Mówca: **Alma Saltana**
> ""Gladly, {RiziaDLCText.SaltanaToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Laurento cleared his throat."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As we gather today, I pray that we do not let our trivial differences blind us. For we are but one people, united by God's enduring love.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Jorga Azmal: ""Halaita, Your Majesty.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""O Divine Creator, bless this mediation table and all who are seated at it. Help them to open their hearts and minds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Jorga Azmal: ""Halaita, Your Majesty.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lord, guide me in my sacred duty of finding communion between the nations of the former Empire of Moridia, that we may come together against the greater powers who wish us harm.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Jorga Azmal: ""Halaita, Your Majesty.""*)

### Węzeł `[20]`
Mówca: **Jorga Azmal**
> ""Halaita, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1; RiziaDLC..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1; RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Saltana looked at us both uneasily."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Azmal and Saltana looked at each other uneasily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Laurento cleared his throat."*)

### Węzeł `[23]`
Mówca: **Alma Saltana**
> ""Yes. Here we are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Azmal and Saltana looked at each other uneasily."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "Laurento tented his fingers on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Laurento Esquibel: ""Supreme Wiseman, Madam Prime Minister. This is the solut..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "He opened a folder and pulled out a map of Derdia, Rizia and Morella with a diagram drawn on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Laurento Esquibel: ""We call this St. Wruhec's Corridor.""*)

### Węzeł `[26]`
Mówca: **Laurento Esquibel**
> ""We call this St. Wruhec's Corridor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "His finger traced a thick black line from the Derdian-Mor..."*)

### Węzeł `[27]`
Mówca: **Laurento Esquibel**
> ""Each year, a select number of Derdians with an appropriate prayer visa will be allowed into Morella via this specific channel. It includes the most important sanctuaries on the Golcondist pilgrimage route.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player_Romus: ""Rizia re-allowed Derdian Golcondists into our places of ..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player_Romus: ""What Derdians do hardly falls under the category of wors..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia re-allowed Derdian Golcondists into our places of worship with no ill consequences.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Kontekst wejściowy (poprzednik):** `[117]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Alma Saltana: ""Rizia shares no borders with Derdia. The only reason you..."*)

### Węzeł `[32]`
Mówca: **Alma Saltana**
> ""Rizia shares no borders with Derdia. The only reason you have not been overwhelmed by an influx of so-called pilgrims is because we have been holding them back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Laurento tented his fingers on the table."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLa..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Laurento Esquibel: ""The route continues into Rizia, where Derdian pilgrims h..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "The Supreme Wiseman leaned forward and scrutinized the map."*)

### Węzeł `[36]`
Mówca: **Laurento Esquibel**
> ""The route continues into Rizia, where Derdian pilgrims have been permitted for some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "Saltana eyed me suspiciously."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "The Supreme Wiseman leaned forward and scrutinized the map."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Jorga Azmal: ""This route ends at Lauante. After which, I suppose, we a..."*)

### Węzeł `[38]`
Mówca: **Jorga Azmal**
> ""This route ends at Lauante. After which, I suppose, we are to march into the sea?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""You go home the way you came. It's not that difficult.""*)
  - -> `[40]` (*Player_Romus: ""You may continue into Rizia, as long as you agree to res..."*)
  - -> `[41]` (*Player_Romus: ""Not a bad idea.""*)
  - -> `[42]` (*Player_Romus: ""Not at all. I fully plan on allowing Golcondists to wors..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You go home the way you came. It's not that difficult.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Both Azmal and Saltana glowered at me. The Morellan prime..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may continue into Rizia, as long as you agree to respect our blasphemy law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Both Azmal and Saltana glowered at me. The Morellan prime..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not a bad idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Both Azmal and Saltana glowered at me. The Morellan prime..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not at all. I fully plan on allowing Golcondists to worship in Rizia as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Azmal raised his eyebrows skeptically."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Both Azmal and Saltana glowered at me. The Morellan prime minister cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Alma Saltana: ""{RiziaDLCText.SaltanaToPlayer}, you cannot really expect..."*)

### Węzeł `[44]`
Mówca: **Alma Saltana**
> ""{RiziaDLCText.SaltanaToPlayer}, you cannot really expect Morella to allow in Golcondist pilgrims while barring them from your own sanctuaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Romus: ""Our Wruhecist community is larger than Morella's. There ..."*)
  - -> `[46]` (*Player_Romus: ""I'm afraid revoking our blasphemy law is out of the ques..."*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our Wruhecist community is larger than Morella's. There is greater potential for disruption.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Alma Saltana: ""If you believe disruption is a concern at all, then I ca..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid revoking our blasphemy law is out of the question. The Wruhecist Sanctuary is very powerful in this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Jorga Azmal: ""Then I cannot agree to your plan.""*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is in the middle of a war. I don't want to make any sudden policy changes.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[44]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Jorga Azmal: ""Then I cannot agree to your plan.""*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Azmal raised his eyebrows skeptically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Jorga Azmal: ""You plan on it. I see.""*)

### Węzeł `[49]`
Mówca: **Jorga Azmal**
> ""You plan on it. I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fail..."*)

### Węzeł `[50]`
Mówca: **Jorga Azmal**
> ""You will forgive me if I don't place much stock in your promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)
  - -> `[190]` (*Player_Romus: ""I don't like your attitude, Supreme Wiseman. I will prom..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fail..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fa..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Jorga Azmal: ""You will forgive me if I don't place much stock in your ..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Jorga Azmal: ""If you don't mind, I would like to have more than a mere..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Saltana looked at us both uneasily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Laurento cleared his throat."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Laurento cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Laurento Esquibel: ""We all know why we are here.""*)

### Węzeł `[56]`
Mówca: **Laurento Esquibel**
> ""We all know why we are here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Concession_DerdianBorderAssistance == true"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Concession_DerdianBorderAssistance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Concession_DerdianBorderAssistance == true"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Concession_DerdianBorderAssistance == true)"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Concession_DerdianBorderAssistance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Concession_DerdianBorderAssistance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Laurento Esquibel: ""Your countries have been engaged in border disputes for ..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Concession_DerdianBorderAssistance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Concession_DerdianBorderAssistance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Laurento Esquibel: ""Rizia has formed energy partnerships with both of your c..."*)

### Węzeł `[60]`
Mówca: **Laurento Esquibel**
> ""Your countries have been engaged in border disputes for years. Rizia has promised to help you find a common solution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fail..."*)

### Węzeł `[61]`
Mówca: **Laurento Esquibel**
> ""Rizia has formed energy partnerships with both of your countries. It would behoove us all to find a solution to your border disputes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fail..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fail..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fa..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Jorga Azmal: ""With all due respect, Mr. Esquibel...""*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Fai..."*)

### Węzeł `[65]`
Mówca: **Jorga Azmal**
> ""With all due respect, Mr. Esquibel...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Jorga Azmal: ""Rizia has proven itself an unreliable energy partner. Wh..."*)

### Węzeł `[66]`
Mówca: **Jorga Azmal**
> ""Rizia has proven itself an unreliable energy partner. Why should we trust you as a mediator?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Fai..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Fai..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_F..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Saltana smiled coolly."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Saltana smiled coolly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Alma Saltana: ""Funny, Mr. Azmal. Rizia has failed to meet its energy pr..."*)

### Węzeł `[71]`
Mówca: **Alma Saltana**
> ""Funny, Mr. Azmal. Rizia has failed to meet its energy promises to us as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Alma Saltana: ""It seems we have one thing in common after all.""*)

### Węzeł `[72]`
Mówca: **Alma Saltana**
> ""It seems we have one thing in common after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""You have more than that in common. It was only a few gen..."*)
  - -> `[84]` (*Player_Romus: ""Now is not the time to talk about the energy situation. ..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[93]` (*Player_Romus: ""You don't have a choice, do you? It's Rizia or nobody.""*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Fai..."*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_F..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Alma Saltana: ""With all due respect, Mr. Esquibel...""*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_Monarchy_Absolute == true && (RiziaDL..."*)

### Węzeł `[76]`
Mówca: **Alma Saltana**
> ""Rizia has proven itself an unreliable energy partner. Why should we trust you as a mediator?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus: ""Now is not the time to talk about the energy situation. ..."*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[93]` (*Player_Romus: ""You don't have a choice, do you? It's Rizia or nobody.""*)

### Węzeł `[77]`
Mówca: **Narrator**
> "The Morellan prime minister nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Alma Saltana: ""A pipeline runs between Derdia and Morella now. If these..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Alma Saltana: ""It is time we put an end to these insurgencies. Our inte..."*)

### Węzeł `[81]`
Mówca: **Alma Saltana**
> ""A pipeline runs between Derdia and Morella now. If these insurgencies continue, our economies and image will suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Jorga Azmal: ""Insurgencies! It's exactly that kind of language that ha..."*)

### Węzeł `[82]`
Mówca: **Alma Saltana**
> ""It is time we put an end to these insurgencies. Our international image has suffered enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Jorga Azmal: ""Insurgencies! It's exactly that kind of language that ha..."*)

### Węzeł `[83]`
Mówca: **Alma Saltana**
> ""With all due respect, Mr. Esquibel...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Alma Saltana: ""Rizia has proven itself an unreliable energy partner. Wh..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now is not the time to talk about the energy situation. You may bring it up with me later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Alma Saltana), `[76]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Fai..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am truly sorry that our conflict with Pales interfered with our promised energy deliveries. Once we have won, I will repay you triplefold.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true` AND `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Alma Saltana), `[76]` (Alma Saltana), `[66]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Fai..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player_Romus: ""I am truly sorry that our conflict with Pales interfered..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""Our energy deliveries were impeded by circumstances beyo..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our energy deliveries were impeded by circumstances beyond my control. I sincerely apologize for that.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false` AND `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Alma Saltana), `[76]` (Alma Saltana), `[66]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Fai..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have more than that in common. It was only a few generations ago that the Moridians were one people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Narrator: "Azmal nodded vigorously."*)

### Węzeł `[91]`
Mówca: **Narrator**
> "Azmal nodded vigorously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Jorga Azmal: ""Precisely, Your Majesty. Which is why it is so ludicrous..."*)

### Węzeł `[92]`
Mówca: **Jorga Azmal**
> ""Precisely, Your Majesty. Which is why it is so ludicrous that Derdians are being denied entrance into Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Alma Saltana: ""We would gladly welcome you if you behaved yourselves. I..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have a choice, do you? It's Rizia or nobody.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Alma Saltana), `[76]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Fai..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Fai..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_F..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Saltana pursed her lips."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Morella_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Azmal gritted his teeth."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Saltana pursed her lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fail..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Azmal gritted his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Jorga Azmal: ""Very well. Let's continue.""*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fail..."*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Fa..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "She looked over at Azmal. He reluctantly nodded."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_EnergyCommitment_Derdia_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Alma Saltana: ""Very well. Let's continue.""*)

### Węzeł `[102]`
Mówca: **Narrator**
> "She looked over at Azmal. He reluctantly nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Alma Saltana: ""Very well. Let's continue.""*)

### Węzeł `[103]`
Mówca: **Alma Saltana**
> ""Very well. Let's continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true"*)

### Węzeł `[104]`
Mówca: **Jorga Azmal**
> ""Very well. Let's continue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true"*)

### Węzeł `[105]`
Mówca: **Jorga Azmal**
> ""Insurgencies! It's exactly that kind of language that has made me reluctant to deal with you, Madam Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Alma Saltana: ""Are you sure it's my language you have a problem with, M..."*)

### Węzeł `[106]`
Mówca: **Alma Saltana**
> ""Are you sure it's my language you have a problem with, Mr. Azmal? Not the fact that I'm a woman who holds more power than you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""You will address the Supreme Wiseman using his full titl..."*)
  - -> `[122]` (*Player_Romus: ""There's obviously only one way to solve this. A Duel of ..."*)
  - -> `[136]` (*Player_Romus: ""Never mind the Prime Minister's language, Supreme Wisema..."*)
  - -> `[140]` (*Player_Romus: ""Stop squabbling at once, both of you. Your conduct is be..."*)

### Węzeł `[107]`
Mówca: **Alma Saltana**
> ""We would gladly welcome you if you behaved yourselves. Instead, we get raids, insurgencies...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Jorga Azmal: ""Insurgencies! It's exactly that kind of language that ha..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true"*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Alma Saltana: ""Even if it's not currently in use, a pipeline runs betwe..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Alma Saltana: ""With or without a Rizian energy deal, it is time we put ..."*)

### Węzeł `[111]`
Mówca: **Alma Saltana**
> ""Even if it's not currently in use, a pipeline runs between Derdia and Morella now. If these insurgencies continue, our economies and image will suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Jorga Azmal: ""Insurgencies! It's exactly that kind of language that ha..."*)

### Węzeł `[112]`
Mówca: **Alma Saltana**
> ""With or without a Rizian energy deal, it is time we put an end to these insurgencies. Our international image has suffered enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Jorga Azmal: ""Insurgencies! It's exactly that kind of language that ha..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will address the Supreme Wiseman using his full title, Prime Minister Saltana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1; RiziaDLC..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1; RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "Her face darkened."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "Her face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Alma Saltana: ""Forgive me, Your Majesty. But I am adamantly opposed to ..."*)

### Węzeł `[116]`
Mówca: **Alma Saltana**
> ""Forgive me, Your Majesty. But I am adamantly opposed to the intrusion of religion into statecraft.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)

### Węzeł `[117]`
Mówca: **Jorga Azmal**
> ""And yet you cannot deny those who do believe in a higher power the right to worship as their ancestors have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""Is it the right to worship you are after, or is it Morel..."*)
  - -> `[149]` (*Player_Romus: ""The borders between Derdia and Morella were drawn only r..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Jorga Azmal: ""Both of you are, it seems.""*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Jorga Azmal: ""And yet you cannot deny those who do believe in a higher..."*)

### Węzeł `[121]`
Mówca: **Jorga Azmal**
> ""Both of you are, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Jorga Azmal: ""And yet you cannot deny those who do believe in a higher..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's obviously only one way to solve this. A Duel of Generosity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "Laurento turned pale. Saltana burst out laughing."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "Laurento turned pale. Saltana burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true"*)

### Węzeł `[124]`
Mówca: **Alma Saltana**
> ""A king who just married his daughter to his cousin is proposing a duel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Alma Saltana: ""I'm here to talk politics, gentleman. Not play some sort..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Alma Saltana: ""A king who just married his daughter to his cousin is pr..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Axel == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Alma Saltana: ""A king who just married off his daughter to expand his t..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Alma Saltana: ""A duel. Really?""*)

### Węzeł `[131]`
Mówca: **Alma Saltana**
> ""A king who just married off his daughter to expand his territory is proposing a duel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Alma Saltana: ""I'm here to talk politics, gentleman. Not play some sort..."*)

### Węzeł `[132]`
Mówca: **Alma Saltana**
> ""A duel. Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Alma Saltana: ""I'm here to talk politics, gentleman. Not play some sort..."*)

### Węzeł `[133]`
Mówca: **Alma Saltana**
> ""I'm here to talk politics, gentleman. Not play some sort of... game of thrones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Jorga Azmal: ""A duel won't be necessary, Your Majesty.""*)

### Węzeł `[134]`
Mówca: **Jorga Azmal**
> ""A duel won't be necessary, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Jorga Azmal: ""This is a problem with an easy solution. Allow Derdian G..."*)

### Węzeł `[135]`
Mówca: **Jorga Azmal**
> ""This is a problem with an easy solution. Allow Derdian Golcondists the freedom to practice their religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never mind the Prime Minister's language, Supreme Wiseman. You must admit that the violent conduct of your people at the Morellan border has not been justified.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1; RiziaDLC..."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "His face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Jorga Azmal: ""I will admit no such thing.""*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1; RiziaDLC.Diplomacy_Morella_NegotiatingPower += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "His face darkened."*)

### Węzeł `[139]`
Mówca: **Jorga Azmal**
> ""I will admit no such thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Jorga Azmal: ""This is a problem with an easy solution. Allow Derdian G..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop squabbling at once, both of you. Your conduct is befitting of kindergarteners, not world leaders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Both Saltana and Azmal looked down at the table."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "Both Saltana and Azmal looked down at the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Jorga Azmal: ""Forgive me, Your Majesty. However...""*)

### Węzeł `[142]`
Mówca: **Jorga Azmal**
> ""Forgive me, Your Majesty. However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Jorga Azmal: ""This is a problem with an easy solution. Allow Derdian G..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Jorga Azmal: ""You may both run godless countries yourselves.""*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_RemoveStateReligion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveStateReligion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Jorga Azmal: ""You may not believe in God yourself, Ms. Saltana.""*)

### Węzeł `[146]`
Mówca: **Jorga Azmal**
> ""You may both run godless countries yourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Jorga Azmal: ""And yet you cannot deny those who do believe in a higher..."*)

### Węzeł `[147]`
Mówca: **Jorga Azmal**
> ""You may not believe in God yourself, Ms. Saltana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Jorga Azmal: ""And yet you cannot deny those who do believe in a higher..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it the right to worship you are after, or is it Morella's resources? We have not forgotten the Meftiem invasion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Jorga Azmal: ""That was the work of rogue actors. And furthermore, it o..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The borders between Derdia and Morella were drawn only recently. They do feel rather arbitrary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Alma Saltana: ""And yet they are there for a reason.""*)

### Węzeł `[150]`
Mówca: **Alma Saltana**
> ""And yet they are there for a reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Laurento tented his fingers on the table."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What Derdians do hardly falls under the category of worship.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[117]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)

### Węzeł `[152]`
Mówca: **Jorga Azmal**
> ""That was the work of rogue actors. And furthermore, it occurred long before my appointment as Supreme Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Laurento tented his fingers on the table."*)

### Węzeł `[153]`
Mówca: **Jorga Azmal**
> ""You are still under the sway of your Grand Wiseman, I see. Even after having arrested him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Laurento tented his fingers on the table."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Jorga Azmal: ""You are still under the sway of your Grand Wiseman, I se..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Jorga Azmal: ""You are still under the sway of your Grand Wiseman, I see.""*)

### Węzeł `[157]`
Mówca: **Jorga Azmal**
> ""You are still under the sway of your Grand Wiseman, I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "Laurento tented his fingers on the table."*)

### Węzeł `[158]`
Mówca: **Laurento Esquibel**
> ""Supreme Wiseman, Madam Prime Minister. This is the solution my department has devised for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "He opened a folder and pulled out a map of Derdia, Rizia ..."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "His finger traced a thick black line from the Derdian-Morellan border towards the Antacean coast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Laurento Esquibel: ""Each year, a select number of Derdians with an appropria..."*)

### Węzeł `[160]`
Mówca: **Jorga Azmal**
> ""If you don't mind, I would like to have more than a mere assurance from you before agreeing to anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)
  - -> `[190]` (*Player_Romus: ""I don't like your attitude, Supreme Wiseman. I will prom..."*)

### Węzeł `[161]`
Mówca: **Jorga Azmal**
> ""Then I cannot agree to your plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Alma Saltana: ""Nor can I.""*)

### Węzeł `[162]`
Mówca: **Alma Saltana**
> ""Nor can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true && RiziaDLC.Resources_Autho..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""Rizia is in the middle of a war. I don't want to make an..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Romus: ""We're in a delicate situation with Wehlen at the moment...."*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're in a delicate situation with Wehlen at the moment. I don't want to make any sudden policy changes.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[44]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Jorga Azmal: ""Then I cannot agree to your plan.""*)

### Węzeł `[167]`
Mówca: **Alma Saltana**
> ""If you believe disruption is a concern at all, then I cannot agree to this plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Jorga Azmal: ""Nor can I.""*)

### Węzeł `[168]`
Mówca: **Jorga Azmal**
> ""Nor can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""So be it. I tried my best.""*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true && RiziaDLC.Resources_Autho..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So be it. I tried my best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Jorga Azmal: ""I am not certain I believe you, Your Majesty.""*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true && RiziaDLC.Resources_Authority >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true && RiziaDLC.Resources_Autho..."*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == true && RiziaDLC.Resources_Aut..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true && RiziaDLC.Resources_Authority >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true  and  Variable["RiziaDLC.Resources_Authority"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player_Romus: ""Wait. I don't have a Grand Wiseman to appease anymore. I..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == true && RiziaDLC.Resources_Authority >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true  and  Variable["RiziaDLC.Resources_Authority"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 4"*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Wait. I don't have a Grand Wiseman to appease anymore. I will revoke Rizia's blasphemy law, effective immediately." [-4 Authority]"]** — Mówca: **Player_Romus**
> ""Wait. I don't have a Grand Wiseman to appease anymore. I will revoke Rizia's blasphemy law, effective immediately.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Sal_Arrested"] == true  and  Variable["RiziaDLC.Resources_Authority"] >= 4`
- **Kontekst wejściowy (poprzednik):** `[162]` (Alma Saltana), `[168]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Wait. If it helps your nations get along, I will revoke Rizia's blasphemy law, effective immediately." [-4 Authority]"]** — Mówca: **Player_Romus**
> ""Wait. If it helps your nations get along, I will revoke Rizia's blasphemy law, effective immediately.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] >= 4` AND `(Variable["RiziaDLC.Sal_Arrested"] == true  and  Variable["RiziaDLC.Resources_Authority"] >= 4) == false`
- **Kontekst wejściowy (poprzednik):** `[162]` (Alma Saltana), `[168]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 4"*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority >= 4)"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""Wait. If it helps your nations get along, I will revoke ..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: ""There's nothing I can do. That was my kingdom's best eff..."*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's nothing I can do. That was my kingdom's best effort.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Authority"] >= 4) == false` AND `(Variable["RiziaDLC.Sal_Arrested"] == true  and  Variable["RiziaDLC.Resources_Authority"] >= 4) == false`
- **Kontekst wejściowy (poprzednik):** `[162]` (Alma Saltana), `[168]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Jorga Azmal: ""I am not certain I believe you, Your Majesty.""*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == true)"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""I don't have a Grand Wiseman to appease anymore. I will ..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 4"*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""I don't have a Grand Wiseman to appease anymore. I will revoke Rizia's blasphemy law, effective immediately." [-4 Authority]"]** — Mówca: **Player_Romus**
> ""I don't have a Grand Wiseman to appease anymore. I will revoke Rizia's blasphemy law, effective immediately.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Kontekst wejściowy (poprzednik):** `[50]` (Jorga Azmal), `[160]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[183]`
**[WYBÓR GRACZA: ""Very well. If it helps your nations get along, I will revoke Rizia's blasphemy law, effective immediately." [-4 Authority]"]** — Mówca: **Player_Romus**
> ""Very well. If it helps your nations get along, I will revoke Rizia's blasphemy law, effective immediately.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Authority"] >= 4` AND `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Jorga Azmal), `[160]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw ..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Authority >= 4"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Authority >= 4)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Authority >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Authority"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player_Romus: ""Very well. If it helps your nations get along, I will re..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Authority >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Authority"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player_Romus: ""Sorry. An assurance is all I can give you right now.""*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry. An assurance is all I can give you right now.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Authority"] >= 4) == false` AND `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[50]` (Jorga Azmal), `[160]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Jorga Azmal: ""Then I cannot agree to this proposal.""*)

### Węzeł `[188]`
Mówca: **Jorga Azmal**
> ""Then I cannot agree to this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Alma Saltana: ""Nor can I.""*)

### Węzeł `[189]`
Mówca: **Alma Saltana**
> ""Nor can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Alma Saltana: ""Thank you anyway for your hard work, Mr. Esquibel. This ..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like your attitude, Supreme Wiseman. I will promise you nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Jorga Azmal), `[160]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Jorga Azmal: ""Then I cannot agree to this proposal.""*)

### Węzeł `[191]`
Mówca: **Jorga Azmal**
> ""How fortunate, Your Majesty. I knew you would see the light someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "Saltana's brow was furrowed."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw = true; EnactDecree("Religion_RemoveGolcondistBlasphemyLaw");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Policy_RD_Religion_RemoveGolcondistBlasphemyLaw"] = true;
EnactDecree("Religion_RemoveGolcondistBlasphemyLaw");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Jorga Azmal: ""How fortunate, Your Majesty. I knew you would see the li..."*)

### Węzeł `[193]`
Mówca: **Jorga Azmal**
> ""I am not certain I believe you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Alma Saltana: ""Thank you anyway for your hard work, Mr. Esquibel. This ..."*)

### Węzeł `[194]`
Mówca: **Alma Saltana**
> ""Thank you anyway for your hard work, Mr. Esquibel. This corridor would have been an ideal compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Laurento Esquibel: ""Thank you, Madam Prime Minister. It may still be an opti..."*)

### Węzeł `[195]`
Mówca: **Laurento Esquibel**
> ""Thank you, Madam Prime Minister. It may still be an option in the future, even if it is not possible today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[330]` (*Player_Romus: ""Yes, thanks anyway, Laurento. This was a great idea.""*)
  - -> `[329]` (*Player_Romus: ""Prime Minister Saltana, I hope I can still count on your..."*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[196]`
Mówca: **Narrator**
> "Saltana eyed me suspiciously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Alma Saltana: ""How do we know the Derdians will stick to the route as t..."*)

### Węzeł `[197]`
Mówca: **Alma Saltana**
> ""How do we know the Derdians will stick to the route as they pass through Morella?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Jorga Azmal: ""How do *we* know the Morellans will not attempt to block..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower > 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower > 250"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_Manpower > 250)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower > 250`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] > 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player_Romus: ""I will send a company from the Rizian Armed Forces to gr..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_Manpower > 250)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] > 250) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player_Romus: ""The Kingdom of Rizia will pay for a small team of indepe..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
**[WYBÓR GRACZA: ""I will send a company from the Rizian Armed Forces to grant the pilgrims secure passage." [Manpower -250]"]** — Mówca: **Player_Romus**
> ""I will send a company from the Rizian Armed Forces to grant the pilgrims secure passage.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Military_Manpower"] > 250`
- **Kontekst wejściowy (poprzednik):** `[219]` (Jorga Azmal), `[341]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3"*)

### Węzeł `[205]`
**[WYBÓR GRACZA: ""The Kingdom of Rizia will pay for a small team of independent contractors to oversee the corridor's security." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""The Kingdom of Rizia will pay for a small team of independent contractors to oversee the corridor's security.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[219]` (Jorga Azmal), `[341]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3"*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whoever violates the agreement will face the most severe of consequences. My kingdom will make sure of it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Kontekst wejściowy (poprzednik):** `[219]` (Jorga Azmal), `[341]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Jorga Azmal: ""I can accept that.""*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Jorga Azmal: ""I'm afraid that's not enough assurance for me.""*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Jorga Azmal: ""I can accept that.""*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Jorga Azmal: ""I'm afraid that's not enough assurance for me.""*)

### Węzeł `[213]`
Mówca: **Jorga Azmal**
> ""I can accept that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Alma Saltana: ""So can I.""*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Alma Saltana: ""I cannot.""*)

### Węzeł `[217]`
Mówca: **Alma Saltana**
> ""So can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Laurento smiled proudly."*)

### Węzeł `[218]`
Mówca: **Alma Saltana**
> ""I cannot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 500"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[261]` (*Player_Romus: ""Then you're both out of luck.""*)

### Węzeł `[219]`
Mówca: **Jorga Azmal**
> ""How do *we* know the Morellans will not attempt to block it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower > 250"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)
  - -> `[272]` (*Player_Romus: ""You're just going to have to trust each other, aren't you?""*)

### Węzeł `[220]`
Mówca: **Jorga Azmal**
> ""I'm afraid that's not enough assurance for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Alma Saltana: ""I think it's a fine plan. But it's not entirely up to me.""*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Alma Saltana: ""Nor for me.""*)

### Węzeł `[224]`
Mówca: **Alma Saltana**
> ""I think it's a fine plan. But it's not entirely up to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 500"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[261]` (*Player_Romus: ""Then you're both out of luck.""*)

### Węzeł `[225]`
Mówca: **Alma Saltana**
> ""Nor for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 500"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[261]` (*Player_Romus: ""Then you're both out of luck.""*)

### Węzeł `[226]`
Mówca: **Jorga Azmal**
> ""I can accept that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Alma Saltana: ""So can I.""*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Alma Saltana: ""I cannot.""*)

### Węzeł `[230]`
Mówca: **Alma Saltana**
> ""So can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "Laurento smiled proudly."*)

### Węzeł `[231]`
Mówca: **Jorga Azmal**
> ""I'm afraid that's not enough assurance for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Alma Saltana: ""I think it's a fine plan. But it's not entirely up to me.""*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Alma Saltana: ""Nor for me.""*)

### Węzeł `[235]`
Mówca: **Alma Saltana**
> ""I cannot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 250"*)
  - -> `[261]` (*Player_Romus: ""Then you're both out of luck.""*)

### Węzeł `[236]`
Mówca: **Alma Saltana**
> ""I think it's a fine plan. But it's not entirely up to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 250"*)
  - -> `[261]` (*Player_Romus: ""Then you're both out of luck.""*)

### Węzeł `[237]`
Mówca: **Alma Saltana**
> ""Nor for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 250"*)
  - -> `[261]` (*Player_Romus: ""Then you're both out of luck.""*)

### Węzeł `[238]`
Mówca: **Narrator**
> "Laurento smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower -= 250"*)

### Węzeł `[239]`
Mówca: **Laurento Esquibel**
> ""Thank you both for your swift willingness to compromise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Laurento Esquibel: ""Such solutions always seem easy when it's a third party ..."*)

### Węzeł `[240]`
Mówca: **Laurento Esquibel**
> ""Such solutions always seem easy when it's a third party proposing them, don't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Laurento Esquibel: ""We'll assemble a team from all three of our countries to..."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "Laurento smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1;"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelmi..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Romus: ""Whoever violates the agreement will face the most severe..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Jorga Azmal: ""I can accept that.""*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Derdia_NegotiatingPower >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Jorga Azmal: ""I'm afraid that's not enough assurance for me.""*)

### Węzeł `[248]`
Mówca: **Jorga Azmal**
> ""I can accept that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Alma Saltana: ""So can I.""*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Alma Saltana: ""I cannot.""*)

### Węzeł `[252]`
Mówca: **Alma Saltana**
> ""So can I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "Laurento smiled proudly."*)

### Węzeł `[253]`
Mówca: **Jorga Azmal**
> ""I'm afraid that's not enough assurance for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Alma Saltana: ""I think it's a fine plan. But it's not entirely up to me.""*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Morella_NegotiatingPower >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Alma Saltana: ""Nor for me.""*)

### Węzeł `[257]`
Mówca: **Alma Saltana**
> ""I cannot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""Then you're both out of luck.""*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 250"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[258]`
Mówca: **Alma Saltana**
> ""I think it's a fine plan. But it's not entirely up to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""Then you're both out of luck.""*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 250"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[259]`
Mówca: **Alma Saltana**
> ""Nor for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""Then you're both out of luck.""*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 250"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[260]`
Mówca: **Narrator**
> "Laurento smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Laurento Esquibel: ""Thank you both for your swift willingness to compromise.""*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then you're both out of luck.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Alma Saltana), `[224]` (Alma Saltana), `[225]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "The two of them looked away from each other. Laurento att..."*)

### Węzeł `[262]`
Mówca: **Laurento Esquibel**
> ""We'll assemble a team from all three of our countries to begin the creation of the corridor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[312]` (*Player_Romus: ""Thank you for your hard work, Laurento. This was truly a..."*)
  - -> `[307]` (*Player_Romus: ""Prime Minister Saltana, I hope this means that I can cou..."*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[263]`
**[WYBÓR GRACZA: ""Fine. We will send *two* army companies." [-500 Manpower]"]** — Mówca: **Player_Romus**
> ""Fine. We will send *two* army companies.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 500`
- **Kontekst wejściowy (poprzednik):** `[218]` (Alma Saltana), `[224]` (Alma Saltana), `[225]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower -= 500"*)

### Węzeł `[264]`
**[WYBÓR GRACZA: ""Fine. We will pour twice as much funding into security as planned." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Fine. We will pour twice as much funding into security as planned.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[235]` (Alma Saltana), `[236]` (Alma Saltana), `[237]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 2"*)

### Węzeł `[265]`
**[WYBÓR GRACZA: ""Fine. A company from the Rizian Armed Forces will be physically present to grant the pilgrims secure passage." [Manpower -250]"]** — Mówca: **Player_Romus**
> ""Fine. A company from the Rizian Armed Forces will be physically present to grant the pilgrims secure passage.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 250`
- **Kontekst wejściowy (poprzednik):** `[257]` (Alma Saltana), `[258]` (Alma Saltana), `[259]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower -= 250"*)

### Węzeł `[266]`
**[WYBÓR GRACZA: ""If you insist, the Kingdom of Rizia will pay for a small team of independent contractors to oversee the corridor's security." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""If you insist, the Kingdom of Rizia will pay for a small team of independent contractors to oversee the corridor's security.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[257]` (Alma Saltana), `[258]` (Alma Saltana), `[259]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1"*)

### Węzeł `[267]`
Mówca: **Narrator**
> "The two of them looked at each other. Each gave a short, approving nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Laurento Esquibel: ""That's it, then? You agree?""*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower -= 250`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] - 250;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The two of them looked at each other. Each gave a short, ..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The two of them looked at each other. Each gave a short, ..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA: ""In addition to the military reinforcements, we will contract a team of independent security officers." [-250 Manpower, -1 Budget]"]** — Mówca: **Player_Romus**
> ""In addition to the military reinforcements, we will contract a team of independent security officers.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[218]` (Alma Saltana), `[224]` (Alma Saltana), `[225]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLC.Resources_Milita..."*)

### Węzeł `[271]`
**[WYBÓR GRACZA: ""In addition to the security firm, we ourselves will send a company from the Rizian Armed Forces." [-1 Budget, -250 Manpower]"]** — Mówca: **Player_Romus**
> ""In addition to the security firm, we ourselves will send a company from the Rizian Armed Forces.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 250`
- **Kontekst wejściowy (poprzednik):** `[235]` (Alma Saltana), `[236]` (Alma Saltana), `[237]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLC.Resources_Milita..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're just going to have to trust each other, aren't you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Narrator: "The two of them looked at each other."*)

### Węzeł `[273]`
Mówca: **Narrator**
> "The two of them looked at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Jorga Azmal: ""I should have known this would not be a serious plan.""*)

### Węzeł `[274]`
Mówca: **Jorga Azmal**
> ""I should have known this would not be a serious plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player_Romus: ""You really thought we could erase a century's worth of r..."*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 1500 || RiziaDLC...."*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[275]`
Mówca: **Narrator**
> "Saltana's brow was furrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Alma Saltana: ""Even if the corridor ends at Rizia's holy sites...""*)

### Węzeł `[276]`
Mówca: **Alma Saltana**
> ""Even if the corridor ends at Rizia's holy sites...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Alma Saltana: ""How do we know the Derdians will stick to the route as t..."*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You really thought we could erase a century's worth of resentment in five minutes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "The two of them looked away from each other. Laurento att..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The two of them looked at each other. Each gave a short, ..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Player_Romus: ""Fine. We will pour twice as much funding into security a..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower >= 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 250"*)
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_Manpower >= 250)"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower >= 250`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player_Romus: ""In addition to the security firm, we ourselves will send..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_Manpower >= 250)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] >= 250) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower >= 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 250"*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_Manpower >= 250)"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower >= 250`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 250`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player_Romus: ""Fine. A company from the Rizian Armed Forces will be phy..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_Manpower >= 250)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] >= 250) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player_Romus: ""If you insist, the Kingdom of Rizia will pay for a small..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower >= 500`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 500"*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_Manpower >= 500)"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower >= 500`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 500`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player_Romus: ""Fine. We will send *two* army companies." [-500 Manpower]"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_Manpower >= 500)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] >= 500) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player_Romus: ""In addition to the military reinforcements, we will cont..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1; RiziaDLC.Resources_Military_Manpower -= 250`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] - 250;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The two of them looked at each other. Each gave a short, ..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower -= 500`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] - 500;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "The two of them looked at each other. Each gave a short, ..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower -= 250`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Military_Manpower"] = Variable["RiziaDLC.Resources_Military_Manpower"] - 250;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Laurento Esquibel: ""Thank you both for your swift willingness to compromise.""*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Laurento Esquibel: ""Thank you both for your swift willingness to compromise.""*)

### Węzeł `[301]`
Mówca: **Laurento Esquibel**
> ""That's it, then? You agree?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "He smiled proudly."*)

### Węzeł `[302]`
Mówca: **Narrator**
> "He smiled proudly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Laurento Esquibel: ""Thank you both for your swift willingness to compromise.""*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Morella and Derdia can come to a diplomatic agreement this quickly, I have high hopes for the Intermerkopum alliance.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Kontekst wejściowy (poprzednik):** `[262]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Laurento Esquibel: ""Agreed, Your Majesty.""*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intermerkopum_Efforts == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Player_Romus: ""If Morella and Derdia can come to a diplomatic agreement..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intermerkopum_Efforts == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Saltana, I hope this means that I can count on your cooperation during the final MITZ vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "She smiled mysteriously."*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Lord has truly blessed us on this day. Rejoice!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[262]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Jorga Azmal: ""Halaita!""*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player_Romus: ""The Lord has truly blessed us on this day. Rejoice!""*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your hard work, Laurento. This was truly a team effort.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Laurento Esquibel: ""You honor me, Your Majesty.""*)

### Węzeł `[313]`
Mówca: **Laurento Esquibel**
> ""You honor me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Laurento checked his pocketwatch."*)

### Węzeł `[314]`
Mówca: **Narrator**
> "She smiled mysteriously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Alma Saltana: ""We will see, {RiziaDLCText.SaltanaToPlayer}.""*)

### Węzeł `[315]`
Mówca: **Alma Saltana**
> ""We will see, {RiziaDLCText.SaltanaToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Laurento checked his pocketwatch."*)

### Węzeł `[316]`
Mówca: **Jorga Azmal**
> ""Halaita!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Alma Saltana: ""...Yes. Halaita.""*)

### Węzeł `[317]`
Mówca: **Alma Saltana**
> ""...Yes. Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Laurento checked his pocketwatch."*)

### Węzeł `[318]`
Mówca: **Laurento Esquibel**
> ""Agreed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Laurento checked his pocketwatch."*)

### Węzeł `[319]`
Mówca: **Narrator**
> "Laurento checked his pocketwatch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Success = true; Ri..."*)

### Węzeł `[320]`
Mówca: **Narrator**
> "The two of them looked away from each other. Laurento attempted to mask his disappointment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Alma Saltana: ""Thank you anyway for your hard work, Mr. Esquibel. This ..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's fine. We don't need Morella and Derdia to get along for the Intermerkopum alliance to work out.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Kontekst wejściowy (poprzednik):** `[195]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Laurento Esquibel: ""I must say it would have helped, Your Majesty.""*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intermerkopum_Efforts == true)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Player_Romus: ""It's fine. We don't need Morella and Derdia to get along..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intermerkopum_Efforts == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Player_Romus: ""Alas, the Lord has not blessed us on this day. Perhaps w..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alas, the Lord has not blessed us on this day. Perhaps we did something to anger Him.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[195]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Alma Saltana: ""No comment, Your Majesty.""*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Saltana, I hope I can still count on your cooperation during the final MITZ vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Narrator: "Her expression betrayed no emotion."*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, thanks anyway, Laurento. This was a great idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[195]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Laurento Esquibel: ""You honor me, Your Majesty.""*)

### Węzeł `[331]`
Mówca: **Laurento Esquibel**
> ""You honor me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Laurento checked his pocketwatch."*)

### Węzeł `[332]`
Mówca: **Narrator**
> "Her expression betrayed no emotion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Alma Saltana: ""We will see, {RiziaDLCText.SaltanaToPlayer}.""*)

### Węzeł `[333]`
Mówca: **Alma Saltana**
> ""No comment, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Laurento checked his pocketwatch."*)

### Węzeł `[334]`
Mówca: **Laurento Esquibel**
> ""I must say it would have helped, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Laurento checked his pocketwatch."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "Laurento checked his pocketwatch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_MorellaDerdiaMediation_Failed = true; Riz..."*)

### Węzeł `[336]`
Mówca: **Alma Saltana**
> ""We will see, {RiziaDLCText.SaltanaToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Laurento checked his pocketwatch."*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, wait. I do have one idea.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 1500  or  Variable["RiziaDLC.Resources_Budget"] >= 5  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Kontekst wejściowy (poprzednik):** `[274]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Alma Saltana: ""Yes, {Salutations.SaltanaToPlayer} ?""*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower >= 1500 || RiziaDLC.Resources_Budget >= 5 || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower >= 1500 || RiziaDLC...."*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Military_Manpower >= 1500 || RiziaDL..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Military_Manpower >= 1500 || RiziaDLC.Resources_Budget >= 5 || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Military_Manpower"] >= 1500  or  Variable["RiziaDLC.Resources_Budget"] >= 5  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player_Romus: ""No, wait. I do have one idea.""*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Military_Manpower >= 1500 || RiziaDLC.Resources_Budget >= 5 || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Military_Manpower"] >= 1500  or  Variable["RiziaDLC.Resources_Budget"] >= 5  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[341]`
Mówca: **Alma Saltana**
> ""Yes, {Salutations.SaltanaToPlayer} ?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Military_Manpower > 250"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Suddenly the man who believes in an invisible person in the sky doesn't have faith in his own neighbor?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[274]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Narrator: "Azmal gasped indignantly. Saltana laughed out loud."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Player_Romus: ""You must take a leap of faith, Supreme Wiseman. What wou..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Player_Romus: ""Suddenly the man who believes in an invisible person in ..."*)

### Węzeł `[346]`
Mówca: **Narrator**
> "Azmal gasped indignantly. Saltana laughed out loud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Alma Saltana: ""Thank you anyway for your hard work, Mr. Esquibel. This ..."*)

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must take a leap of faith, Supreme Wiseman. What would St. Wruhec have done?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[274]` (Jorga Azmal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Jorga Azmal: ""As Wruhec himself said, the firmest bridge of trust may ..."*)

### Węzeł `[348]`
Mówca: **Jorga Azmal**
> ""As Wruhec himself said, the firmest bridge of trust may still be eroded by the waters of deceit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "Saltana shrugged."*)

### Węzeł `[349]`
Mówca: **Narrator**
> "Saltana shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Alma Saltana: ""Thank you anyway for your hard work, Mr. Esquibel. This ..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffor..."*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEff..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Laurento Esquibel: ""We still have the Derdia-Wehlen mediations scheduled for..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Laurento Esquibel: ""We are finished here. I am truly sorry we were not able ..."*)

### Węzeł `[353]`
Mówca: **Laurento Esquibel**
> ""We still have the Derdia-Wehlen mediations scheduled for today. Perhaps a short break?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Jorga Azmal: ""Yes, thank you. I must clear my head of prejudice after ..."*)

### Węzeł `[354]`
Mówca: **Laurento Esquibel**
> ""We are finished here. I am truly sorry we were not able to help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Narrator: "The Derdian Supreme Wiseman and Morellan prime minister r..."*)

### Węzeł `[355]`
Mówca: **Narrator**
> "The Derdian Supreme Wiseman and Morellan prime minister rose and shook both of our hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Alma Saltana: ""I will see you in the Trade Zone next month.""*)

### Węzeł `[356]`
Mówca: **Alma Saltana**
> ""I will see you in the Trade Zone next month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Jorga Azmal: ""May God be with you both.""*)

### Węzeł `[357]`
Mówca: **Jorga Azmal**
> ""May God be with you both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Narrator: "They and their entourages were escorted out of the suite."*)

### Węzeł `[358]`
Mówca: **Narrator**
> "They and their entourages were escorted out of the suite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Alma Saltana"); RemoveConversant("Jorga..."*)

### Węzeł `[359]`
Mówca: **Jorga Azmal**
> ""Yes, thank you. I must clear my head of prejudice after what just occurred.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Narrator: "The Morellan prime minister rose and shook our hands."*)

### Węzeł `[360]`
Mówca: **Narrator**
> "The Morellan prime minister rose and shook our hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Alma Saltana: ""I will see you in the Trade Zone next month.""*)

### Węzeł `[361]`
Mówca: **Alma Saltana**
> ""I will see you in the Trade Zone next month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "She and her entourage were escorted out of the suite."*)

### Węzeł `[362]`
Mówca: **Narrator**
> "She and her entourage were escorted out of the suite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Alma Saltana");"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffor..."*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEff..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Laurento Esquibel: ""We still have the Derdia-Wehlen mediations scheduled for..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort == true || RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffort"] == true  or  Variable["RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MinimalEffort"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Laurento Esquibel: ""We are finished here. I am happy Rizia was able to help ..."*)

### Węzeł `[366]`
Mówca: **Laurento Esquibel**
> ""We still have the Derdia-Wehlen mediations scheduled for today. Perhaps a short break?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Jorga Azmal: ""Yes, thank you. This was surprisingly pleasant, but I do..."*)

### Węzeł `[367]`
Mówca: **Laurento Esquibel**
> ""I'd like to go over a detail or two about that first. I'll escort you to the door.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "She and her entourage followed him out of the suite."*)

### Węzeł `[368]`
Mówca: **Narrator**
> "She and her entourage followed him out of the suite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Alma Saltana");"*)

### Węzeł `[369]`
Mówca: **Jorga Azmal**
> ""Yes, thank you. This was surprisingly pleasant, but I do not expect our interaction with President Smolak to go as smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "The Morellan prime minister rose and shook our hands."*)

### Węzeł `[370]`
Mówca: **Narrator**
> "The Morellan prime minister rose and shook our hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Alma Saltana: ""I will see you in the Trade Zone next month.""*)

### Węzeł `[371]`
Mówca: **Alma Saltana**
> ""I will see you in the Trade Zone next month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Laurento Esquibel: ""I'd like to go over a detail or two about that first. I'..."*)

### Węzeł `[372]`
Mówca: **Laurento Esquibel**
> ""We are finished here. I am happy Rizia was able to help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "The Morellan prime minister rose from her seat."*)

### Węzeł `[373]`
Mówca: **Narrator**
> "The Morellan prime minister rose from her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Alma Saltana: ""I will see you in the Trade Zone next month.""*)

### Węzeł `[374]`
Mówca: **Alma Saltana**
> ""I will see you in the Trade Zone next month.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_G_PrayerCorridorMorella = true"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Success = true; RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Success = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Success"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffor..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_MorellaDerdiaMediation_Failed = true; RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Failure = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_MorellaDerdiaMediation_Failed"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_MorellaDerdiaMediation_Failure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_MediateDerdiaWehlen_MassiveEffor..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn09_G_PrayerCorridorMorella = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_G_PrayerCorridorMorella"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Laurento Esquibel: ""I'd like to go over a detail or two about that first. I'..."*)

### Węzeł `[378]`
Mówca: **Alma Saltana**
> ""With all due respect, Mr. Esquibel...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Alma Saltana: ""We in Morella have been paying attention to Rizia's inte..."*)

### Węzeł `[379]`
Mówca: **Alma Saltana**
> ""We in Morella have been paying attention to Rizia's internal politics. Your increasingly authoritarian policies leave us wondering about your reliability as a mediator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Player_Romus: ""You don't have a choice, do you? It's Rizia or nobody.""*)
  - -> `[384]` (*Player_Romus: ""Rizia has always been an absolute monarchy, Ms. Saltana...."*)
  - -> `[385]` (*Player_Romus: ""I hear your concerns, but they're not germane to today's..."*)
  - -> `[386]` (*Player_Romus: ""You have no idea what you're talking about. The people o..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_Monarchy_Absolute == true && (RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Country_QuelledProtests >= 4)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_Monarchy_Absolute == true && (RiziaDL..."*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_Monarchy_Absolute == true && (Rizia..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_Monarchy_Absolute == true && (RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Country_QuelledProtests >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_Monarchy_Absolute"] == true  and  (Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Country_QuelledProtests"] >= 4)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Alma Saltana: ""With all due respect, Mr. Esquibel...""*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_Monarchy_Absolute == true && (RiziaDLC.Trait_TyrantKing == true || RiziaDLC.Country_QuelledProtests >= 4))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_Monarchy_Absolute"] == true  and  (Variable["RiziaDLC.Trait_TyrantKing"] == true  or  Variable["RiziaDLC.Country_QuelledProtests"] >= 4)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The Morellan prime minister nodded."*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have a choice, do you? It's Rizia or nobody.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[379]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Narrator: "She gritted her teeth."*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia has always been an absolute monarchy, Ms. Saltana. You just chose to ignore it when it suited you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[379]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Narrator: "She gritted her teeth."*)

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear your concerns, but they're not germane to today's conversation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[379]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Alma Saltana: ""No? I'd like to know just what kind of monarchy I'm deal..."*)

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have no idea what you're talking about. The people of my country enjoy a great many freedoms. More than Morella, in fact.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[379]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Alma Saltana: ""Excuse me? That's just not true.""*)

### Węzeł `[387]`
Mówca: **Narrator**
> "She gritted her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Laurento Esquibel: ""Madam Prime Minister, whatever our internal situation, w..."*)

### Węzeł `[388]`
Mówca: **Alma Saltana**
> ""Excuse me? That's just not true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "Laurento laughed nervously."*)

### Węzeł `[389]`
Mówca: **Laurento Esquibel**
> ""Madam Prime Minister, whatever our internal situation, we remain committed to finding a diplomatic compromise between your country and Derdia. And we are willing to put our money where our mouth is, so to speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Jorga Azmal: ""Derdia appreciates that commitment, Mr. Esquibel. As wel..."*)

### Węzeł `[390]`
Mówca: **Narrator**
> "Laurento laughed nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Laurento Esquibel: ""Madam Prime Minister, whatever our internal situation, w..."*)

### Węzeł `[391]`
Mówca: **Alma Saltana**
> ""No? I'd like to know just what kind of monarchy I'm dealing with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "Laurento laughed nervously."*)

### Węzeł `[392]`
Mówca: **Jorga Azmal**
> ""Derdia appreciates that commitment, Mr. Esquibel. As well as your tough but fair treatment of dissenters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "Saltana sighed reluctantly."*)

### Węzeł `[393]`
Mówca: **Narrator**
> "Saltana sighed reluctantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Alma Saltana: ""All right. Let's proceed.""*)

### Węzeł `[394]`
Mówca: **Alma Saltana**
> ""All right. Let's proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true"*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Alma Saltana: ""Derdia and Morella are now connected by an energy pipeli..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Economy_DerdiaPipeline_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Economy_DerdiaPipeline_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Alma Saltana: ""It is time we put an end to these insurgencies. Our inte..."*)

### Węzeł `[398]`
Mówca: **Alma Saltana**
> ""Derdia and Morella are now connected by an energy pipeline. If Derdians continue to violate our borders, the economies and our images of both nations will suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Jorga Azmal: ""Insurgencies! It's exactly that kind of language that ha..."*)

### Węzeł `[399]`
Mówca: **Alma Saltana**
> ""It is time we put an end to these insurgencies. Our international image has suffered enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Jorga Azmal: ""Insurgencies! It's exactly that kind of language that ha..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Alma Saltana");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Alma Saltana");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Alma Saltana");
RemoveConversant("Jorga Azmal");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Alma Saltana");
RemoveConversant("Jorga Azmal");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Alma Saltana");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Alma Saltana");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
