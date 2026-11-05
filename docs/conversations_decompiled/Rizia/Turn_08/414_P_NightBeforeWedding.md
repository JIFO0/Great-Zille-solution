# Rizia/Turn 8/P_NightBeforeWedding

- **ID konwersacji:** `414`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/414_P_NightBeforeWedding.md`
- **Liczba węzłów dialogowych:** 895
- **Liczba wyborów gracza:** 189

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.BrunoDog_SleepsInBed`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Country_HouseAzaro`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Decision_Turn08_WeddingCommittee`
- `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_WearsLenasRing`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Path_Stratocracy`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Economy_LandOwnersTax`
- `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed`
- `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws`
- `RiziaDLC.Prologue_Limp`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn03_LucitaLoveConvo`
- `RiziaDLC.Turn05_MurderInvest_InvestigateSal`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.Vina_Engaged`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_FullCouncilor`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_KeepsLastName`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.Vina_WearsLenasRing`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.Zille_ViolentResistancePower`
- `RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_OKWithVinaSuccessor`
- `RiziaDLC.Lucita_WearsLenasRing`
- `RiziaDLC.Pabel_Gone`
- `RiziaDLC.Pabel_Lord`
- `RiziaDLC.Pabel_WeddingDate`
- `RiziaDLC.Path_Stratocracy`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Vina_Engaged`
- `RiziaDLC.Vina_WearsLenasRing`
- `RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling`
- `RiziaDLCIsolated.Turn08_LucitaProposal_Sitting`
- `RiziaDLCIsolated.Turn08_LucitaProposal_Standing`
- `RiziaDLCSupport.Journal_Turn08_Lucita_Married`
- `RiziaDLCSupport.Journal_Turn08_Pabel_Lord`
- `RiziaDLCSupport.Journal_Turn08_Pabel_WeddingDate`
- `RiziaDLCSupport.News_Turn08_RH_RoyalWedding_VinaDuchess`
- `RiziaDLCSupport.News_Turn08_V_VinaEscape_Regular`
- `RiziaDLCSupport.Reports_Turn08_MaveNortus_IntelligenceServiceSearchesVina`
- `RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_Protests`
- `RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_TorasCelebrates`

### Skoki między-konwersacyjne:
- Węzeł `[25]` -> **[415] Rizia/Turn 8/VINA ESCAPES** (../Turn_08/415_VINA_ESCAPES.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **""Believe me, Princess Lena of Rumburg couldn't hold a candle to Duchess Lucita of ..."** | `[10]` **Lucita Azaro**: ""I still remember attending the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Narrator**: "Lucita snorted." |
| `[12]` | **""I still miss her. But I have to move on.""** | `[10]` **Lucita Azaro**: ""I still remember attending the ..." | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | *Brak zmian stanu* | `[22]` **Lucita Azaro**: ""You're doing a fine job."" |
| `[13]` | **""Poor Lena. She never got to see her daughter become a woman.""** | `[10]` **Lucita Azaro**: ""I still remember attending the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Lucita Azaro**: ""She lives on in Her Highness. A..." |
| `[17]` | **""And me? How did I look?""** | `[10]` **Lucita Azaro**: ""I still remember attending the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Lucita Azaro**: ""Like a handsome prince."" |
| `[45]` | **""I suspect she's trying to flee the country. Can our foreign intelligence services..."** | `[41]` **Lucita Azaro**: ""I was in the council chambers w..." | `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true` | *Brak zmian stanu* | `[46]` **Lucita Azaro**: ""Yes, of course. I'll tell them ..." |
| `[47]` | **""She had someone on the inside. A guard helping her out.""** | `[41]` **Lucita Azaro**: ""I was in the council chambers w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Lucita Azaro**: ""That's very troubling. I'll ask..."<br>`[97]` **Lucita Azaro**: ""That's very troubling."" |
| `[49]` | **""Pabel was in on it. He's vanished without a trace.""** | `[41]` **Lucita Azaro**: ""I was in the council chambers w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Lucita Azaro**: ""That's very troubling. I'll ask..."<br>`[97]` **Lucita Azaro**: ""That's very troubling."" |
| `[50]` | **""I think my mother might have helped her, but I have no proof.""** | `[41]` **Lucita Azaro**: ""I was in the council chambers w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Lucita Azaro**: ""That's very troubling. I'll ask..."<br>`[97]` **Lucita Azaro**: ""That's very troubling."" |
| `[52]` | **""It won't be easy to rest. But I'll try.""** | `[51]` **Lucita Azaro**: ""You should get some rest, Your ..." | `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true) == false` | *Brak zmian stanu* | `[59]` **Narrator**: "She gave me a terse nod." |
| `[53]` | **""No. I have to do something. I'll go crazy otherwise.""** | `[51]` **Lucita Azaro**: ""You should get some rest, Your ..." | `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true) == false` | *Brak zmian stanu* | `[59]` **Narrator**: "She gave me a terse nod." |
| `[54]` | **""Wait. Take a walk with me." [Marriage Proposal]"** | `[244]` **Narrator**: "My mother's words echoed in my h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Narrator**: "She paused, thinking it over." |
| `[60]` | **""Thank you, Duchess Azaro. I hope this all resolves quickly.""** | `[51]` **Lucita Azaro**: ""You should get some rest, Your ..." | `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`<br>`(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true) == false` | *Brak zmian stanu* | `[61]` **Lucita Azaro**: ""I have faith that it will."" |
| `[66]` | **"Kneel."** | `[242]` **Narrator**: "I thought about how, as of tomor..."<br>`[243]` **Narrator**: "I thought how, if Vina died in P..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Prologue_Limp"] == true`<br>`(Variable["RiziaDLC.Vina_Hostage"] == true) == false`<br>`(Variable["RiziaDLC.Vina_KeepsLastName"] == false) == false` | `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling...` | `[77]` **Narrator**: "Lucita's eyes widened. She looke..." |
| `[70]` | **"Stay standing."** | `[242]` **Narrator**: "I thought about how, as of tomor..."<br>`[243]` **Narrator**: "I thought how, if Vina died in P..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`<br>`(Variable["RiziaDLC.Vina_KeepsLastName"] == false) == false` | `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Standing...` | `[77]` **Narrator**: "Lucita's eyes widened. She looke..." |
| `[71]` | **""Do you love me?""** | `[77]` **Narrator**: "Lucita's eyes widened. She looke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Narrator**: "She pulled back from me slightly." |
| `[72]` | **""Are you able to bear children?""** | `[77]` **Narrator**: "Lucita's eyes widened. She looke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Narrator**: "She pulled back and gave me a me..." |
| `[75]` | **"Kneel."** | `[242]` **Narrator**: "I thought about how, as of tomor..."<br>`[243]` **Narrator**: "I thought how, if Vina died in P..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`<br>`(Variable["RiziaDLC.Vina_Hostage"] == true) == false`<br>`(Variable["RiziaDLC.Vina_KeepsLastName"] == false) == false` | `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling...` | `[77]` **Narrator**: "Lucita's eyes widened. She looke..." |
| `[76]` | **"Sit down."** | `[242]` **Narrator**: "I thought about how, as of tomor..."<br>`[243]` **Narrator**: "I thought how, if Vina died in P..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`<br>`(Variable["RiziaDLC.Vina_KeepsLastName"] == false) == false` | `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Sitting"...` | `[77]` **Narrator**: "Lucita's eyes widened. She looke..." |
| `[78]` | **""Lucita, will you marry me?""** | `[77]` **Narrator**: "Lucita's eyes widened. She looke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "She clapped a hand to her mouth...." |
| `[79]` | **""In the presence of the heavens above and the earth below, I do extend unto thee a..."** | `[77]` **Narrator**: "Lucita's eyes widened. She looke..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "She clapped a hand to her mouth...." |
| `[82]` | **""I need another heir, Lucita. Preferably a boy.""** | `[81]` **Lucita Azaro**: ""Is this because of your daughte..."<br>`[154]` **Lucita Azaro**: ""Is it unromantic of me to ask w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Lucita Azaro**: ""That's the most cold-blooded th..." |
| `[83]` | **""That's incidental. I've loved you since the moment you entered my council chambers.""** | `[81]` **Lucita Azaro**: ""Is this because of your daughte..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Lucita Azaro**: ""I've loved you since before we ..." |
| `[84]` | **""With my command of the Rizian government and your command of the military, we wil..."** | `[81]` **Lucita Azaro**: ""Is this because of your daughte..."<br>`[154]` **Lucita Azaro**: ""Is it unromantic of me to ask w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Lucita Azaro**: ""Unstoppable. I like the sound o..." |
| `[85]` | **""Don't ask why. Just say yes.""** | `[81]` **Lucita Azaro**: ""Is this because of your daughte..."<br>`[154]` **Lucita Azaro**: ""Is it unromantic of me to ask w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Lucita Azaro**: ""In that case..."" |
| `[88]` | **""Then I would like to request that you grant me the honor of your hand in marriage.""** | `[74]` **Lucita Azaro**: ""I believe so. My monthly visito..."<br>`[144]` **Lucita Azaro**: ""Except for my king.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "She clapped a hand to her mouth...." |
| `[89]` | **""Then have *my* my children, Duchess Azaro. Be my wife.""** | `[74]` **Lucita Azaro**: ""I believe so. My monthly visito..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "She clapped a hand to her mouth...." |
| `[103]` | **""Never mind that. I want to know about my mother's involvement.""** | `[101]` **Titus Gordion**: ""Still no trace of her, Your Maj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Titus Gordion**: ""I'll find out what I can."" |
| `[105]` | **""Find them both. This is an embarrassment.""** | `[101]` **Titus Gordion**: ""Still no trace of her, Your Maj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Titus Gordion**: ""As I said, I'll see what I can ..." |
| `[107]` | **""It's no use. She's gone.""** | `[101]` **Titus Gordion**: ""Still no trace of her, Your Maj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Titus Gordion**: ""Don't give up yet. We'll bring ..." |
| `[120]` | **"Leave it there."** | `[117]` **Narrator**: "Bruno was waiting for me by my v..."<br>`[118]` **Narrator**: "Arranged on my valet stand was a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Narrator**: "There was a chance I would still..." |
| `[126]` | **"Throw it in the corner."** | `[117]` **Narrator**: "Bruno was waiting for me by my v..."<br>`[118]` **Narrator**: "Arranged on my valet stand was a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Narrator**: "I knew that I would never wear it." |
| `[128]` | **"Leave it hanging there."** | `[119]` **Narrator**: "Bruno was waiting for me by my v..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Narrator**: "There was a chance tomorrow coul..." |
| `[130]` | **"Throw it in the corner."** | `[124]` **Narrator**: "Pabel had hung up my favorite su..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Narrator**: "I knew that I would never wear i..." |
| `[150]` | **""I don't know if you're lying. I don't care. Marry me, Lucita.""** | `[144]` **Lucita Azaro**: ""Except for my king.""<br>`[148]` **Lucita Azaro**: ""We've held our ground against P..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "She clapped a hand to her mouth...." |
| `[155]` | **""I've loved you since the moment you entered my council chambers.""** | `[154]` **Lucita Azaro**: ""Is it unromantic of me to ask w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Lucita Azaro**: ""I've loved you since before we ..." |
| `[173]` | **"Hang it up."** | `[170]` **Narrator**: "Bruno was on my bed, lying atop ..."<br>`[171]` **Narrator**: "Atop my bed was a brand-new, cri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "I wondered what tomorrow would b..." |
| `[178]` | **"Throw it in the corner."** | `[177]` **Narrator**: "Atop my bed was my favorite suit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "I wondered what tomorrow would b..." |
| `[180]` | **"Throw it in the corner."** | `[170]` **Narrator**: "Bruno was on my bed, lying atop ..."<br>`[171]` **Narrator**: "Atop my bed was a brand-new, cri..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "I wondered what tomorrow would b..." |
| `[181]` | **"Hang it up."** | `[172]` **Narrator**: "Bruno was on my bed, lying atop ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "I wondered what tomorrow would b..." |
| `[213]` | **""Look at us. Addicted to our jobs.""** | `[33]` **Lucita Azaro**: ""I was conducting last-minute se..."<br>`[37]` **Lucita Azaro**: ""I was just reviewing our latest..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Lucita Azaro**: ""There's no clocking out when th..." |
| `[214]` | **""Nobody told me that ruling the country would be all this work.""** | `[33]` **Lucita Azaro**: ""I was conducting last-minute se..."<br>`[37]` **Lucita Azaro**: ""I was just reviewing our latest..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true` | *Brak zmian stanu* | `[224]` **Lucita Azaro**: ""At least you've got your counci..." |
| `[218]` | **""It sounds like you're urgently in need of stress relief.""** | `[33]` **Lucita Azaro**: ""I was conducting last-minute se..."<br>`[37]` **Lucita Azaro**: ""I was just reviewing our latest..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Narrator**: "She smiled." |
| `[219]` | **""You've got too much on your plate. Why not share the load with the Golden Guard?""** | `[33]` **Lucita Azaro**: ""I was conducting last-minute se..."<br>`[37]` **Lucita Azaro**: ""I was just reviewing our latest..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true` | *Brak zmian stanu* | `[227]` **Narrator**: "She made a scoffing sound." |
| `[252]` | **""What? You want to wake the old man up now?""** | `[251]` **Narrator**: "She led me through the ground-fl..." | `Variable["RiziaDLC.Sal_Arrested"] == false` | *Brak zmian stanu* | `[271]` **Narrator**: "She put a finger to her lips and..." |
| `[253]` | **""The Grand Wiseman? I still don't trust him.""** | `[251]` **Narrator**: "She led me through the ground-fl..." | `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true`<br>`Variable["RiziaDLC.Sal_Arrested"] == false` | *Brak zmian stanu* | `[271]` **Narrator**: "She put a finger to her lips and..." |
| `[260]` | **""Ah, a visit to my beloved spiritual advisor. Always a good idea.""** | `[251]` **Narrator**: "She led me through the ground-fl..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true`<br>`Variable["RiziaDLC.Sal_Arrested"] == false` | *Brak zmian stanu* | `[271]` **Narrator**: "She put a finger to her lips and..." |
| `[261]` | **""I think I see where this is going...""** | `[251]` **Narrator**: "She led me through the ground-fl..." | `Variable["RiziaDLC.Sal_Arrested"] == false` | *Brak zmian stanu* | `[271]` **Narrator**: "She put a finger to her lips and..." |
| `[262]` | **""We can't get in. It's been locked since his arrest.""** | `[251]` **Narrator**: "She led me through the ground-fl..." | `(Variable["RiziaDLC.Sal_Arrested"] == false) == false` | *Brak zmian stanu* | `[269]` **Narrator**: "She put a finger to her lips, th..." |
| `[263]` | **""The traitor's chambers? Why have you brought me here?""** | `[251]` **Narrator**: "She led me through the ground-fl..." | `(Variable["RiziaDLC.Sal_Arrested"] == false) == false` | *Brak zmian stanu* | `[269]` **Narrator**: "She put a finger to her lips, th..." |
| `[264]` | **""No, I will not consummate our engagement in a holy man's bed, no matter how treas..."** | `[251]` **Narrator**: "She led me through the ground-fl..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true`<br>`(Variable["RiziaDLC.Sal_Arrested"] == false) == false` | *Brak zmian stanu* | `[269]` **Narrator**: "She put a finger to her lips, th..." |
| `[268]` | **""Consummating our engagement in a treasonous priest's bed? See, this is why I love..."** | `[251]` **Narrator**: "She led me through the ground-fl..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`<br>`(Variable["RiziaDLC.Sal_Arrested"] == false) == false` | *Brak zmian stanu* | `[269]` **Narrator**: "She put a finger to her lips, th..." |
| `[270]` | **""You want to go snooping for more evidence against him? Good idea.""** | `[251]` **Narrator**: "She led me through the ground-fl..." | `(Variable["RiziaDLC.Sal_Arrested"] == false) == false` | *Brak zmian stanu* | `[269]` **Narrator**: "She put a finger to her lips, th..." |
| `[278]` | **""Her Grace has spoken correctly. As your King, I command you to perform the marria..."** | `[277]` **Sal Ignacius**: ""This is most unorthodox."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Sal Ignacius**: ""Yes, yes, of course. Give me on..." |
| `[279]` | **""I agree. This seems incredibly hasty.""** | `[277]` **Sal Ignacius**: ""This is most unorthodox."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Lucita Azaro**: ""Why wait? It's what we want. An..."<br>`[285]` **Lucita Azaro**: ""Why wait? It's what we want. An..." |
| `[283]` | **""Need I remind you that my mercy saved you from imprisonment? You will do this for..."** | `[277]` **Sal Ignacius**: ""This is most unorthodox."" | `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true` | *Brak zmian stanu* | `[290]` **Sal Ignacius**: ""Yes, yes, of course. Give me on..." |
| `[284]` | **""Would you rather we live in sin, Grand Wiseman?""** | `[277]` **Sal Ignacius**: ""This is most unorthodox."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Sal Ignacius**: ""No, no, of course not. Give me ..." |
| `[296]` | **""I still have Lena's wedding ring. Let me fetch it.""** | `[295]` **Narrator**: "He carefully closed the door."<br>`[348]` **Narrator**: "A wooden box was on Sal's desk, ..."<br>*(oraz 1 innych węzłów)* | `(Variable["RiziaDLC.Vina_WearsLenasRing"] == true) == false`<br>`IsCollectionItemShowing("CollectionItem_WeddingRing")` | *Brak zmian stanu* | `[305]` **Narrator**: "Her breath caught in her throat." |
| `[300]` | **""You're insane.""** | `[295]` **Narrator**: "He carefully closed the door."<br>`[348]` **Narrator**: "A wooden box was on Sal's desk, ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Lucita Azaro**: ""What's insane is spending endle..." |
| `[301]` | **""Don't you want your father to be here?""** | `[295]` **Narrator**: "He carefully closed the door."<br>`[348]` **Narrator**: "A wooden box was on Sal's desk, ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Lucita Azaro**: ""He never had any use for weddin..." |
| `[302]` | **""Was this how you always dreamed your wedding would be?""** | `[295]` **Narrator**: "He carefully closed the door."<br>`[348]` **Narrator**: "A wooden box was on Sal's desk, ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Lucita Azaro**: ""Mmhmm. Right down to the grass ..." |
| `[307]` | **""She would want you to have it. I'm sure of it.""** | `[306]` **Lucita Azaro**: ""Are... are you sure?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Narrator**: "I dashed up to my study and took..." |
| `[308]` | **""It's been gathering dust on my table all these years. It'll look much better on y..."** | `[306]` **Lucita Azaro**: ""Are... are you sure?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Narrator**: "I dashed up to my study and took..." |
| `[309]` | **""It symbolizes the continuity of our kingdom's relationship with Rumburg. The alli..."** | `[306]` **Lucita Azaro**: ""Are... are you sure?"" | `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] > 0` | *Brak zmian stanu* | `[314]` **Narrator**: "I dashed up to my study and took..." |
| `[313]` | **""I'm sure. Imagine how furious it'll make Queen Beatrice to see you wearing it.""** | `[306]` **Lucita Azaro**: ""Are... are you sure?"" | `(Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] > 0) == false` | *Brak zmian stanu* | `[314]` **Narrator**: "I dashed up to my study and took..." |
| `[325]` | **""This seems incredibly hasty.""** | `[324]` **Lucita Azaro**: ""Including his own."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Lucita Azaro**: ""Why wait? It's what we want. An..."<br>`[326]` **Lucita Azaro**: ""Why wait? It's what we want. An..." |
| `[331]` | **""A wedding without boring religious speeches? Count me in.""** | `[324]` **Lucita Azaro**: ""Including his own."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Lucita Azaro**: ""I knew you'd like the idea."" |
| `[335]` | **""True. I should practice doing this before Vina's wedding tomorrow.""** | `[324]` **Lucita Azaro**: ""Including his own."" | `Variable["RiziaDLC.Vina_Engaged"] == true` | *Brak zmian stanu* | `[344]` **Lucita Azaro**: ""It'll be easy. An oath here, a ..." |
| `[337]` | **""I'm afraid it won't be legitimate before the Lord.""** | `[324]` **Lucita Azaro**: ""Including his own."" | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[343]` **Lucita Azaro**: ""You're the King. The Lord's wil..." |
| `[341]` | **""I'm afraid it won't be legitimate.""** | `[324]` **Lucita Azaro**: ""Including his own."" | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[342]` **Lucita Azaro**: ""You're the King. You are the law."" |
| `[359]` | **""Almighty and ever-loving God...""** | `[358]` **Narrator**: "First in the row was a scroll. S..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[395]` **Player_Romus**: ""In this sacred covenant, love a..." |
| `[364]` | **""Wait. I want to say my own vows.""** | `[363]` **Sal Ignacius**: ""Now, repeat after me. I, Romus ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Narrator**: "Sal raised his eyebrows." |
| `[365]` | **""I, Romus Toras...""** | `[363]` **Sal Ignacius**: ""Now, repeat after me. I, Romus ..."<br>`[396]` **Narrator**: "Lucita gestured to the royal orb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[366]` **Player_Romus**: ""I vow to honor and uphold you, ..." |
| `[366]` | **""I vow to honor and uphold you...""** | `[365]` **Player_Romus**: ""I, Romus Toras, do pledge my un..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Player_Romus**: ""In all our days, my commitment ..." |
| `[367]` | **""In all our days...""** | `[366]` **Player_Romus**: ""I vow to honor and uphold you, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[400]` **Narrator**: "Sal nodded to Lucita, and she re..."<br>`[407]` **Narrator**: "Lucita looked me in the eyes as ..." |
| `[371]` | **""Lucita, I claim you not only as my queen, but as the ironclad partner to my reign.""** | `[370]` **Narrator**: "Lucita looked at me. Her eyes sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Player_Romus**: ""As we defend our kingdom from o..."<br>`[376]` **Player_Romus**: ""I vow to honor the bond we have..."<br>*(oraz 2 innych odgałęzień)* |
| `[372]` | **""As we defend our kingdom from our hordes of enemies, so shall we champion one ano..."** | `[371]` **Player_Romus**: ""Lucita, I claim you not only as..."<br>`[374]` **Player_Romus**: ""As the memory of my cherished L..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Player_Romus**: ""I offer you my heart, my loyalt..."<br>`[380]` **Player_Romus**: ""I pledge myself to you not as a..."<br>*(oraz 3 innych odgałęzień)* |
| `[373]` | **""Together, we shall forge an unbreakable empire and crush all those who stand agai..."** | `[372]` **Player_Romus**: ""As we defend our kingdom from o..."<br>`[376]` **Player_Romus**: ""I vow to honor the bond we have..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[393]` **Narrator**: "Sal cast his gaze over us both. ..."<br>`[411]` **Narrator**: "Lucita was struggling to fight b..." |
| `[374]` | **""As the memory of my cherished Lena fades into the past, I stand here before you r..."** | `[370]` **Narrator**: "Lucita looked at me. Her eyes sh..." | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | *Brak zmian stanu* | `[372]` **Player_Romus**: ""As we defend our kingdom from o..."<br>`[376]` **Player_Romus**: ""I vow to honor the bond we have..."<br>*(oraz 2 innych odgałęzień)* |
| `[375]` | **""I offer you my heart, my loyalty, and my life, as we embark on this journey toget..."** | `[372]` **Player_Romus**: ""As we defend our kingdom from o..."<br>`[376]` **Player_Romus**: ""I vow to honor the bond we have..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Narrator**: "Sal cast his gaze over us both. ..."<br>`[411]` **Narrator**: "Lucita was struggling to fight b..." |
| `[376]` | **""I vow to honor the bond we have created with kindness and patience. I promise to ..."** | `[371]` **Player_Romus**: ""Lucita, I claim you not only as..."<br>`[374]` **Player_Romus**: ""As the memory of my cherished L..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Player_Romus**: ""I offer you my heart, my loyalt..."<br>`[380]` **Player_Romus**: ""I pledge myself to you not as a..."<br>*(oraz 3 innych odgałęzień)* |
| `[377]` | **""I vow that I shall listen to every word you say -- well, except for when you're r..."** | `[390]` **Player_Romus**: ""Duchess Azaro, just as we have ..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[375]` **Player_Romus**: ""I offer you my heart, my loyalt..."<br>`[380]` **Player_Romus**: ""I pledge myself to you not as a..."<br>*(oraz 3 innych odgałęzień)* |
| `[378]` | **""Luce, the past few years I've spent with you have been the happiest in my entire ..."** | `[370]` **Narrator**: "Lucita looked at me. Her eyes sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Player_Romus**: ""As we defend our kingdom from o..."<br>`[376]` **Player_Romus**: ""I vow to honor the bond we have..."<br>*(oraz 2 innych odgałęzień)* |
| `[379]` | **""Whether in the chaos of council meetings or in the intimacy of moments alone, I f..."** | `[371]` **Player_Romus**: ""Lucita, I claim you not only as..."<br>`[374]` **Player_Romus**: ""As the memory of my cherished L..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Player_Romus**: ""I offer you my heart, my loyalt..."<br>`[380]` **Player_Romus**: ""I pledge myself to you not as a..."<br>*(oraz 3 innych odgałęzień)* |
| `[380]` | **""I pledge myself to you not as a king to his queen, but as a man eager to spend th..."** | `[372]` **Player_Romus**: ""As we defend our kingdom from o..."<br>`[376]` **Player_Romus**: ""I vow to honor the bond we have..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Narrator**: "Sal cast his gaze over us both. ..."<br>`[411]` **Narrator**: "Lucita was struggling to fight b..." |
| `[390]` | **""Duchess Azaro, just as we have navigated the waters of international diplomacy, s..."** | `[370]` **Narrator**: "Lucita looked at me. Her eyes sh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Player_Romus**: ""As we defend our kingdom from o..."<br>`[376]` **Player_Romus**: ""I vow to honor the bond we have..."<br>*(oraz 3 innych odgałęzień)* |
| `[391]` | **""Together, let us usher in a new era for our kingdom, marked by strength, resilien..."** | `[372]` **Player_Romus**: ""As we defend our kingdom from o..."<br>`[376]` **Player_Romus**: ""I vow to honor the bond we have..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Narrator**: "Sal cast his gaze over us both. ..."<br>`[411]` **Narrator**: "Lucita was struggling to fight b..." |
| `[392]` | **""Together, we are more than the sum of our parts. We are bound by shared ambition ..."** | `[371]` **Player_Romus**: ""Lucita, I claim you not only as..."<br>`[374]` **Player_Romus**: ""As the memory of my cherished L..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Player_Romus**: ""I offer you my heart, my loyalt..."<br>`[380]` **Player_Romus**: ""I pledge myself to you not as a..."<br>*(oraz 3 innych odgałęzień)* |
| `[394]` | **""Let our marriage be the foundation upon which we build a legacy of peace and pros..."** | `[372]` **Player_Romus**: ""As we defend our kingdom from o..."<br>`[376]` **Player_Romus**: ""I vow to honor the bond we have..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[393]` **Narrator**: "Sal cast his gaze over us both. ..."<br>`[411]` **Narrator**: "Lucita was struggling to fight b..." |
| `[395]` | **""In this sacred covenant...""** | `[359]` **Player_Romus**: ""Almighty and ever-living God, w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[399]` **Lucita Azaro**: ""Perfect. And now for the oath."" |
| `[397]` | **""If we're going to break tradition, I want to go all the way. I'll recite my own v..."** | `[396]` **Narrator**: "Lucita gestured to the royal orb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Lucita Azaro**: ""As you wish. It's just us and t..." |
| `[435]` | **""I promised Vina my late wife's ring. But I want you to have it instead.""** | `[295]` **Narrator**: "He carefully closed the door."<br>`[348]` **Narrator**: "A wooden box was on Sal's desk, ..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Vina_WearsLenasRing"] == true`<br>`IsCollectionItemShowing("CollectionItem_WeddingRing")` | *Brak zmian stanu* | `[305]` **Narrator**: "Her breath caught in her throat." |
| `[439]` | **""My daughter lost her right to it when she ran away.""** | `[306]` **Lucita Azaro**: ""Are... are you sure?"" | `Variable["RiziaDLC.Vina_Escapes"] == true` | *Brak zmian stanu* | `[314]` **Narrator**: "I dashed up to my study and took..." |
| `[442]` | **""It'll have to do for now. We'll find a proper one later.""** | `[431]` **Lucita Azaro**: ""It belongs to House Azaro, Gran..."<br>`[443]` **Lucita Azaro**: ""This is a House Azaro ring. The..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[449]` **Narrator**: "As we exchanged rings, I looked ..." |
| `[445]` | **""A Toras king with an Azaro ring. I shall keep your house with me at all times.""** | `[431]` **Lucita Azaro**: ""It belongs to House Azaro, Gran..."<br>`[441]` **Lucita Azaro**: ""They belong to House Azaro, Gra..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[449]` **Narrator**: "As we exchanged rings, I looked ..." |
| `[446]` | **""They'll have to do for now. We'll have proper ones made later.""** | `[441]` **Lucita Azaro**: ""They belong to House Azaro, Gra..."<br>`[444]` **Lucita Azaro**: ""These are House Azaro rings. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[449]` **Narrator**: "As we exchanged rings, I looked ..." |
| `[447]` | **""They're beautiful. I'll wear mine with pride.""** | `[441]` **Lucita Azaro**: ""They belong to House Azaro, Gra..."<br>`[444]` **Lucita Azaro**: ""These are House Azaro rings. Th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[449]` **Narrator**: "As we exchanged rings, I looked ..." |
| `[448]` | **""It's beautiful. I'll wear it with pride.""** | `[431]` **Lucita Azaro**: ""It belongs to House Azaro, Gran..."<br>`[443]` **Lucita Azaro**: ""This is a House Azaro ring. The..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[449]` **Narrator**: "As we exchanged rings, I looked ..." |
| `[454]` | **""By the power vested in me, through the divine grace and the laws that govern our ..."** | `[449]` **Narrator**: "As we exchanged rings, I looked ..." | `(Variable["RiziaDLC.Sal_Arrested"] == false) == false` | *Brak zmian stanu* | `[460]` **Lucita Azaro**: ""You may kiss the bride."" |
| `[456]` | **""As the sovereign of this realm, I name you as my queen. Now and forever more.""** | `[449]` **Narrator**: "As we exchanged rings, I looked ..." | `(Variable["RiziaDLC.Sal_Arrested"] == false) == false` | *Brak zmian stanu* | `[460]` **Lucita Azaro**: ""You may kiss the bride."" |
| `[458]` | **""That's it? We're married now?""** | `[449]` **Narrator**: "As we exchanged rings, I looked ..." | `(Variable["RiziaDLC.Sal_Arrested"] == false) == false` | *Brak zmian stanu* | `[459]` **Lucita Azaro**: ""That's it."" |
| `[473]` | **""It's late. Shouldn't you have done that already?""** | `[471]` **Narrator**: "I pushed open the door to my qua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[480]` **Pabel Adria**: ""I didn't get the chance. Some f..."<br>`[476]` **Pabel Adria**: ""I didn't get the chance. There ..."<br>*(oraz 1 innych odgałęzień)* |
| `[474]` | **""Pabel. You're a sight for sore eyes.""** | `[471]` **Narrator**: "I pushed open the door to my qua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[482]` **Pabel Adria**: ""As are you, Your Majesty."" |
| `[475]` | **""Ooh. What am I wearing tomorrow?""** | `[471]` **Narrator**: "I pushed open the door to my qua..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[486]` **Pabel Adria**: ""The royal blue tuxedo from Thor..."<br>`[487]` **Pabel Adria**: ""Your charcoal grey suit. I know..." |
| `[494]` | **""I still miss her. But I have to move on.""** | `[506]` **Pabel Adria**: ""It feels like just yesterday th..." | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | *Brak zmian stanu* | `[504]` **Pabel Adria**: ""You're doing a fine job."" |
| `[495]` | **""Poor Lena. She never got to see her daughter become a woman.""** | `[506]` **Pabel Adria**: ""It feels like just yesterday th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[501]` **Pabel Adria**: ""She lives on in Her Highness. A..." |
| `[499]` | **""And me? How did I look?""** | `[506]` **Pabel Adria**: ""It feels like just yesterday th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[500]` **Pabel Adria**: ""Like a handsome prince."" |
| `[507]` | **""Believe me, Princess Lena of Rumburg couldn't hold a candle to Mr. Pabel Adria.""** | `[506]` **Pabel Adria**: ""It feels like just yesterday th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[502]` **Narrator**: "Pabel laughed." |
| `[512]` | **""We argued over every aspect of those celebrations. It was hell.""** | `[10]` **Lucita Azaro**: ""I still remember attending the ..." | `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false` | *Brak zmian stanu* | `[513]` **Lucita Azaro**: ""From the outside, it was a fair..." |
| `[514]` | **""We argued over every aspect of those celebrations. It was hell.""** | `[506]` **Pabel Adria**: ""It feels like just yesterday th..." | `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false` | *Brak zmian stanu* | `[515]` **Pabel Adria**: ""I remember. Your love for your ..." |
| `[517]` | **""You know, with Vina changing her last name, the reputation of House Toras really ..."** | `[538]` **Pabel Adria**: ""A king openly dating a man is c..." | `Variable["RiziaDLC.Vina_KeepsLastName"] == false  and  (Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true)` | *Brak zmian stanu* | `[521]` **Pabel Adria**: ""Even so, what about my reputati..." |
| `[523]` | **""Vina's a hostage. Hugo and Rico's side of the family will probably inherit the th..."** | `[538]` **Pabel Adria**: ""A king openly dating a man is c..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[524]` **Pabel Adria**: ""It matters to me."" |
| `[526]` | **""Let the papers say what they will. I'm not afraid for my reputation.""** | `[538]` **Pabel Adria**: ""A king openly dating a man is c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[531]` **Pabel Adria**: ""I'm afraid for mine."" |
| `[530]` | **""Titles mean nothing, Pabel. I see you as a friend and an equal, regardless of our..."** | `[538]` **Pabel Adria**: ""A king openly dating a man is c..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.LeaningValue_Democratic"] > 0` | *Brak zmian stanu* | `[532]` **Pabel Adria**: ""But the rest of the kingdom doe..." |
| `[534]` | **""It's just a shame that you and I can't enjoy that freedom for ourselves.""** | `[533]` **Pabel Adria**: ""I know that decriminalizing hom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[537]` **Narrator**: "He shook his head." |
| `[535]` | **""It might be legal for us to see each other, but I still rather enjoy the secrecy ..."** | `[533]` **Pabel Adria**: ""I know that decriminalizing hom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[536]` **Pabel Adria**: ""It's not only enjoyable. It's n..." |
| `[539]` | **""I might no longer be breaking the law, but I'm still a very bad boy who needs to ..."** | `[533]` **Pabel Adria**: ""I know that decriminalizing hom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[541]` **Narrator**: "A glint appeared in his eye. He ..." |
| `[542]` | **""My popularity with *Rizians*. The Derdians love me now.""** | `[533]` **Pabel Adria**: ""I know that decriminalizing hom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[543]` **Pabel Adria**: ""So do I."" |
| `[546]` | **""You grew up in this palace. You hardly count as a commoner.""** | `[538]` **Pabel Adria**: ""A king openly dating a man is c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[547]` **Pabel Adria**: ""My family's legacy is tending t..." |
| `[549]` | **""Nothing will ever happen to me. I'm basically immortal.""** | `[548]` **Pabel Adria**: ""And if something happens to you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[571]` **Narrator**: "He laughed and kissed me on the ..." |
| `[550]` | **""It will never end badly between us.""** | `[548]` **Pabel Adria**: ""And if something happens to you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[569]` **Narrator**: "He laughed and kissed me on the ..." |
| `[551]` | **""Then we'll continue in secret. As we always have.""** | `[548]` **Pabel Adria**: ""And if something happens to you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[552]` **Narrator**: "He nodded." |
| `[553]` | **""What if I were to confer noble status upon you?""** | `[548]` **Pabel Adria**: ""And if something happens to you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[554]` **Narrator**: "He blinked in confusion." |
| `[559]` | **""It's strictly a symbolic title now that the electoral reforms have been enacted. ..."** | `[555]` **Pabel Adria**: ""I beg your pardon?"" | `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true` | *Brak zmian stanu* | `[563]` **Narrator**: "Pabel mulled it over for a second." |
| `[560]` | **""I grant you a piece of land and make you a lord. Like my mother's family, or Dari..."** | `[555]` **Pabel Adria**: ""I beg your pardon?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[563]` **Narrator**: "Pabel mulled it over for a second." |
| `[561]` | **""You'd have to take on one or two extra responsibilities. But you wouldn't be a co..."** | `[555]` **Pabel Adria**: ""I beg your pardon?"" | `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false` | *Brak zmian stanu* | `[563]` **Narrator**: "Pabel mulled it over for a second." |
| `[562]` | **""*If* anything were to disrupt our relationship, you'd still have an estate to fal..."** | `[555]` **Pabel Adria**: ""I beg your pardon?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[563]` **Narrator**: "Pabel mulled it over for a second." |
| `[565]` | **""Hugo would have to make it official. Shall we go fetch him now?""** | `[564]` **Pabel Adria**: ""And you can just... do that?"" | `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false) == false` | *Brak zmian stanu* | `[579]` **Narrator**: "He gave me an excited hug." |
| `[566]` | **""Actually, no. It's too difficult.""** | `[564]` **Pabel Adria**: ""And you can just... do that?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[567]` **Narrator**: "Pabel lowered his head." |
| `[588]` | **""You know I'm not one to play by the rules, Hugo.""** | `[584]` **Hugo Toras**: ""A head butler, joining the gent..." | `Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 3` | *Brak zmian stanu* | `[592]` **Hugo Toras**: ""So I have gathered."" |
| `[589]` | **""Pabel has spent his entire life in service to the Royal Family. He deserves a rew..."** | `[584]` **Hugo Toras**: ""A head butler, joining the gent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[593]` **Hugo Toras**: ""His loyalty is undisputed, it's..." |
| `[590]` | **""He's not only my butler, he's my close friend.""** | `[584]` **Hugo Toras**: ""A head butler, joining the gent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[594]` **Narrator**: "He eyed us both closely." |
| `[591]` | **""It's a symbolic gesture. It won't change anything.""** | `[584]` **Hugo Toras**: ""A head butler, joining the gent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[596]` **Hugo Toras**: ""It sets a dangerous precedent. ..." |
| `[616]` | **"Put your seal on the document."** | `[615]` **Hugo Toras**: ""Here is the letters patent. It ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[617]` **Narrator**: "Pabel added his signature. Hugo ..." |
| `[618]` | **""I hereby proclaim you Lord Pabel Adria of Veridian. May your actions reflect the ..."** | `[617]` **Narrator**: "Pabel added his signature. Hugo ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[619]` **Narrator**: "Pabel grinned from ear to ear." |
| `[621]` | **""As you have served me as a butler, so now do I entrust you with the care of your ..."** | `[617]` **Narrator**: "Pabel added his signature. Hugo ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[634]` **Narrator**: "Pabel grinned from ear to ear." |
| `[631]` | **"Pet him."** | `[626]` **Narrator**: "Bruno was on my bed yet again. H..."<br>`[627]` **Narrator**: "From his corner, Bruno whimpered..." | *Brak (Dostępna bezwarunkowo)* | `End();`<br>`Variable["RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuche...`<br>*(+1 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[632]` | **""Shhh. Bad dog.""** | `[626]` **Narrator**: "Bruno was on my bed yet again. H..."<br>`[627]` **Narrator**: "From his corner, Bruno whimpered..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[633]` **Narrator**: "Bruno quieted down and rolled ov..." |
| `[647]` | **""May this mark the beginning of a new era, where titles are not inherited but earn..."** | `[617]` **Narrator**: "Pabel added his signature. Hugo ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[648]` **Narrator**: "Hugo coughed. Pabel, grinning fr..." |
| `[650]` | **""The institution of nobility is a relic of a bygone era, one that perpetuates ineq..."** | `[617]` **Narrator**: "Pabel added his signature. Hugo ..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2` | *Brak zmian stanu* | `[654]` **Narrator**: "Hugo coughed. Pabel, grinning fr..." |
| `[656]` | **""Nonsense. Lord Adria will accompany me to the ceremony.""** | `[646]` **Hugo Toras**: ""Don't let it get to your head. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[659]` **Narrator**: "Pabel and Hugo appeared equally ..." |
| `[657]` | **""It's true, Pabel. You've got to hold on to your head butler duties, at least unti..."** | `[646]` **Hugo Toras**: ""Don't let it get to your head. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[661]` **Pabel Adria**: ""Of course, Your Majesty. I'll m..." |
| `[672]` | **""We're going to get her back. I can feel it in my bones.""** | `[668]` **Pabel Adria**: ""I can't believe it's been a yea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[685]` **Pabel Adria**: ""As long as she's still alive, t..." |
| `[673]` | **""When we win this war, Pales will pay for what they did to her.""** | `[668]` **Pabel Adria**: ""I can't believe it's been a yea..." | `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true` | *Brak zmian stanu* | `[684]` **Pabel Adria**: ""That's the spirit."" |
| `[674]` | **""The Azaros seem to have given up hope of finding her. Perhaps I should as well.""** | `[668]` **Pabel Adria**: ""I can't believe it's been a yea..." | `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false` | *Brak zmian stanu* | `[683]` **Pabel Adria**: ""Don't be ridiculous. There's al..." |
| `[675]` | **""You don't have to remind me. I've been counting the days.""** | `[668]` **Pabel Adria**: ""I can't believe it's been a yea..." | `Variable["RiziaDLC.Relations_Vina"] > 0` | *Brak zmian stanu* | `[682]` **Pabel Adria**: ""I'm sure you have. I'm sorry."" |
| `[679]` | **""That's what she gets for being such a brat to me.""** | `[668]` **Pabel Adria**: ""I can't believe it's been a yea..." | `(Variable["RiziaDLC.Relations_Vina"] > 0) == false` | *Brak zmian stanu* | `[680]` **Narrator**: "Pabel frowned." |
| `[699]` | **""When we win this war, Pales will pay for what they did to her.""** | `[698]` **Lucita Azaro**: ""I can't help but feel personall..." | `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true` | *Brak zmian stanu* | `[709]` **Lucita Azaro**: ""I will make sure of it."" |
| `[703]` | **""You don't need to tell me how long it's been. I've been counting every single day.""** | `[698]` **Lucita Azaro**: ""I can't help but feel personall..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[707]` **Lucita Azaro**: ""Of course you have. I'm sorry."" |
| `[704]` | **""Don't blame yourself. Blame your goddamn fool of a father.""** | `[698]` **Lucita Azaro**: ""I can't help but feel personall..." | `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false` | *Brak zmian stanu* | `[708]` **Lucita Azaro**: ""I should have spoken against hi..." |
| `[705]` | **""No, it's my fault for sending her there in the first place.''"** | `[698]` **Lucita Azaro**: ""I can't help but feel personall..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[706]` **Lucita Azaro**: ""You couldn't have known what wo..." |
| `[725]` | **"Pick it up."** | `[715]` **Narrator**: "Bruno was on my bed as usual. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[727]` **Pabel Adria**: ""Dear Romus..."" |
| `[726]` | **"Pick it up."** | `[724]` **Narrator**: "I looked at my bed. There was a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[727]` **Pabel Adria**: ""Dear Romus..."" |
| `[739]` | **""Un oxit solu.""** | `[738]` **Pabel Adria**: ""Bi mare volu..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[742]` **Narrator**: "The bed let out a loud creak as ..." |
| `[740]` | **""You fucking traitor.""** | `[738]` **Pabel Adria**: ""Bi mare volu..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[742]` **Narrator**: "The bed let out a loud creak as ..." |
| `[741]` | **"Crumple up the note and throw it away."** | `[738]` **Pabel Adria**: ""Bi mare volu..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[742]` **Narrator**: "The bed let out a loud creak as ..." |
| `[751]` | **""Why not?""** | `[564]` **Pabel Adria**: ""And you can just... do that?"" | `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false` | *Brak zmian stanu* | `[752]` **Narrator**: "He gave me an excited hug." |
| `[756]` | **"Put your seal on the document."** | `[755]` **Narrator**: "It was the Veridian estate on th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[757]` **Narrator**: "Pabel added his signature. I nod..." |
| `[758]` | **""I hereby proclaim you Lord Pabel Adria of Veridian. May your actions reflect the ..."** | `[757]` **Narrator**: "Pabel added his signature. I nod..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[759]` **Narrator**: "Pabel grinned from ear to ear." |
| `[761]` | **""As you have served me as a butler, so now do I entrust you with the care of your ..."** | `[757]` **Narrator**: "Pabel added his signature. I nod..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[762]` **Narrator**: "Pabel grinned from ear to ear." |
| `[764]` | **""May this mark the beginning of a new era, where titles are not inherited but earn..."** | `[757]` **Narrator**: "Pabel added his signature. I nod..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[765]` **Narrator**: "Pabel grinned from ear to ear." |
| `[767]` | **""The institution of nobility is a relic of a bygone era, one that perpetuates ineq..."** | `[757]` **Narrator**: "Pabel added his signature. I nod..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2` | *Brak zmian stanu* | `[773]` **Narrator**: "Pabel grinned from ear to ear." |
| `[774]` | **""Keep this safe.""** | `[768]` **Narrator**: "I handed him the document." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[778]` **Pabel Adria**: ""I will. Thank you."" |
| `[775]` | **""Lord Adria.""** | `[768]` **Narrator**: "I handed him the document." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[777]` **Pabel Adria**: ""At your service, Your Majesty."" |
| `[776]` | **""See? Easy.""** | `[768]` **Narrator**: "I handed him the document." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[779]` **Pabel Adria**: ""Thank you!"" |
| `[793]` | **""No, I surrender to you. I want you to be Rizia's new Queen Consort.""** | `[144]` **Lucita Azaro**: ""Except for my king.""<br>`[148]` **Lucita Azaro**: ""We've held our ground against P..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "She clapped a hand to her mouth...." |
| `[794]` | **""That's all I wanted to know. Good night.""** | `[74]` **Lucita Azaro**: ""I believe so. My monthly visito..."<br>`[144]` **Lucita Azaro**: ""Except for my king.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[795]` **Narrator**: "Lucita grabbed my arm. She made ..." |
| `[798]` | **""It won't be easy to rest. But I'll try.""** | `[244]` **Narrator**: "My mother's words echoed in my h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[800]` **Narrator**: "She looked in both directions, t..." |
| `[799]` | **""No. I have to do something. I'll go crazy otherwise.""** | `[244]` **Narrator**: "My mother's words echoed in my h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[800]` **Narrator**: "She looked in both directions, t..." |
| `[801]` | **""How can you ask me that right now? With my daughter Lord knows where...""** | `[797]` **Lucita Azaro**: ""I have to know. Do you ever int..." | `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[807]` **Lucita Azaro**: ""I hate to say it, but: exactly...." |
| `[805]` | **""No. Just the one was enough for me.""** | `[797]` **Lucita Azaro**: ""I have to know. Do you ever int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[809]` **Narrator**: "She looked me in the eye." |
| `[806]` | **""Yes, I do.""** | `[797]` **Lucita Azaro**: ""I have to know. Do you ever int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[813]` **Narrator**: "She looked me in the eye." |
| `[816]` | **""You've made your point. I want to marry you, Lucita. But I've already shelled out..."** | `[811]` **Lucita Azaro**: ""Of course, if you did have a se..."<br>`[812]` **Lucita Azaro**: ""Not to mention... You know I've..." | `Variable["RiziaDLC.Vina_Engaged"] == true` | *Brak zmian stanu* | `[883]` **Lucita Azaro**: ""I have a rather more low-budget..." |
| `[820]` | **""Are you trying to wheedle a proposal out of me? It won't work.""** | `[811]` **Lucita Azaro**: ""Of course, if you did have a se..."<br>`[812]` **Lucita Azaro**: ""Not to mention... You know I've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[823]` **Narrator**: "Resolve formed on her face." |
| `[821]` | **""Please don't take this personally. But no, I do not wish to have a child with you..."** | `[811]` **Lucita Azaro**: ""Of course, if you did have a se..."<br>`[812]` **Lucita Azaro**: ""Not to mention... You know I've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[823]` **Narrator**: "Resolve formed on her face."<br>`[858]` **Lucita Azaro**: ""She can be your successor if yo..." |
| `[822]` | **""Then by all means, Duchess, let us be wed posthaste.""** | `[811]` **Lucita Azaro**: ""Of course, if you did have a se..."<br>`[812]` **Lucita Azaro**: ""Not to mention... You know I've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[853]` **Lucita Azaro**: ""Really? You mean that?"" |
| `[826]` | **""I'm sorry too. Sorry you only wanted me for my royal seed.""** | `[825]` **Lucita Azaro**: ""I'm sorry, Romus.""<br>`[865]` **Lucita Azaro**: ""I'm sorry too, Romus."" | `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false` | *Brak zmian stanu* | `[830]` **Narrator**: "She made a disgusted face." |
| `[827]` | **""This seems sudden.""** | `[825]` **Lucita Azaro**: ""I'm sorry, Romus.""<br>`[865]` **Lucita Azaro**: ""I'm sorry too, Romus."" | `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false` | *Brak zmian stanu* | `[831]` **Lucita Azaro**: ""I know. But I've been thinking ..." |
| `[828]` | **""If we were not royals, this wouldn't be so complicated.""** | `[825]` **Lucita Azaro**: ""I'm sorry, Romus.""<br>`[865]` **Lucita Azaro**: ""I'm sorry too, Romus."" | `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false` | *Brak zmian stanu* | `[833]` **Lucita Azaro**: ""Alas, this is the only life we ..." |
| `[829]` | **""I do love you, you know.""** | `[825]` **Lucita Azaro**: ""I'm sorry, Romus.""<br>`[865]` **Lucita Azaro**: ""I'm sorry too, Romus."" | `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false` | *Brak zmian stanu* | `[866]` **Lucita Azaro**: ""I know."" |
| `[859]` | **""I don't think you mean that. The second I impregnate you, the Azaros will be scra..."** | `[858]` **Lucita Azaro**: ""She can be your successor if yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[860]` **Narrator**: "A hurt look formed on her face." |
| `[862]` | **""If you truly will accept it if Vina stays first in line for the throne... then ye..."** | `[858]` **Lucita Azaro**: ""She can be your successor if yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Lucita_OKWithVinaSuccessor"] = true;` | `[161]` **Narrator**: "We kissed with such force that w..." |
| `[863]` | **""That may be true. But I still find it too risky to muddy up the line of successio..."** | `[858]` **Lucita Azaro**: ""She can be your successor if yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[864]` **Narrator**: "A hurt look formed on her face." |
| `[867]` | **""I can't bring another child into this world, Lucita.""** | `[811]` **Lucita Azaro**: ""Of course, if you did have a se..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[823]` **Narrator**: "Resolve formed on her face." |
| `[884]` | **""Go ahead.""** | `[883]` **Lucita Azaro**: ""I have a rather more low-budget..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Narrator**: "She took my hand and pulled me t..." |
| `[885]` | **""I haven't even proposed yet. Lucita Azaro, will you marry me?""** | `[883]` **Lucita Azaro**: ""I have a rather more low-budget..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Narrator**: "She reached down, grabbed the ba..."<br>`[87]` **Narrator**: "She reached up, grabbed the back..." |
| `[886]` | **""Wait. This all happening too fast. I've got cold feet. I'm sorry.""** | `[883]` **Lucita Azaro**: ""I have a rather more low-budget..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[864]` **Narrator**: "A hurt look formed on her face." |
| `[887]` | **""I did love you. I do.""** | `[881]` **Lucita Azaro**: ""Did you ever love me? Or were y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[892]` **Lucita Azaro**: ""Too late."" |
| `[888]` | **""They were never *your* armies, sweetie.""** | `[881]` **Lucita Azaro**: ""Did you ever love me? Or were y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[891]` **Lucita Azaro**: ""Sweetie?!"" |
| `[889]` | **""We can still have a monarcho-military alliance without literally uniting our bloo..."** | `[881]` **Lucita Azaro**: ""Did you ever love me? Or were y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[890]` **Lucita Azaro**: ""Not where my family's concerned."" |

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
  - -> `[747]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Solitude", "R_Solitude_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "We strolled further into the gardens. It was a balmy night, and the moon was just beginning to rise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Under cover of darkness, Lucita slipped her hand into mine."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Under cover of darkness, Lucita slipped her hand into mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lucita Azaro: ""I can't believe Her Highness is getting married tomorrow.""*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FullCouncilor == true"*)

### Węzeł `[8]`
Mówca: **Lucita Azaro**
> ""I can't believe Her Highness is getting married tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""I still remember attending the celebrations when she was..."*)

### Węzeł `[9]`
Mówca: **Lucita Azaro**
> ""I was skeptical at first, but your daughter has really come into her own as a councilor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""I still remember attending the celebrations when she was..."*)

### Węzeł `[10]`
Mówca: **Lucita Azaro**
> ""I still remember attending the celebrations when she was born. Her mother looked so gorgeous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[11]` (*Player_Romus: ""Believe me, Princess Lena of Rumburg couldn't hold a can..."*)
  - -> `[13]` (*Player_Romus: ""Poor Lena. She never got to see her daughter become a wo..."*)
  - -> `[17]` (*Player_Romus: ""And me? How did I look?""*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Believe me, Princess Lena of Rumburg couldn't hold a candle to Duchess Lucita of Montaklar.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Lucita snorted."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still miss her. But I have to move on.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucita Azaro: ""You're doing a fine job.""*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Poor Lena. She never got to see her daughter become a woman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucita Azaro: ""She lives on in Her Highness. And in her progeny, whoeve..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""I still miss her. But I have to move on.""*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Player_Romus: ""We argued over every aspect of those celebrations. It wa..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And me? How did I look?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucita Azaro: ""Like a handsome prince.""*)

### Węzeł `[18]`
Mówca: **Lucita Azaro**
> ""Like a handsome prince.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "We had come to the clearing in the middle of the gardens...."*)

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""She lives on in Her Highness. And in her progeny, whoever they may be...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "We had come to the clearing in the middle of the gardens...."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "Lucita snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Lucita Azaro: ""The blossoming flower versus the bird of prey? I know wh..."*)

### Węzeł `[21]`
Mówca: **Lucita Azaro**
> ""The blossoming flower versus the bird of prey? I know what they all say about me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "We had come to the clearing in the middle of the gardens...."*)

### Węzeł `[22]`
Mówca: **Lucita Azaro**
> ""You're doing a fine job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "We had come to the clearing in the middle of the gardens...."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "We had come to the clearing in the middle of the gardens. To our left was the stone bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "Jump to: [PROPOSAL]"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lu..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true) && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.P..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLC.Relations_Lucita_Together == true || RiziaDLC..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true) && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The air in the palace suddenly felt suffocating. I went o..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true) && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true)  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "In a daze, I slowly walked upstairs to my quarters."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "The air in the palace suddenly felt suffocating. I went out to the gardens to clear my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "I had just exited the palace when I bumped into Lucita."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "I had just exited the palace when I bumped into Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucita Azaro: ""Oh! Hello, Your Majesty.""*)

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""Oh! Hello, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucita Azaro: ""I was in the council chambers when I heard Titus' radio ..."*)

### Węzeł `[33]`
Mówca: **Lucita Azaro**
> ""I was conducting last-minute security drills in the Grand Hall. You really can't be too careful with these things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player_Romus: ""Look at us. Addicted to our jobs.""*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[218]` (*Player_Romus: ""It sounds like you're urgently in need of stress relief.""*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""I was just reviewing our latest battle plans.""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower > 0"*)

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> ""I was just reviewing our latest battle plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player_Romus: ""Look at us. Addicted to our jobs.""*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[218]` (*Player_Romus: ""It sounds like you're urgently in need of stress relief.""*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucita Azaro: ""I was conducting last-minute security drills in the Gran..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[41]`
Mówca: **Lucita Azaro**
> ""I was in the council chambers when I heard Titus' radio transmission. I can't believe the Golden Guard let this happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[47]` (*Player_Romus: ""She had someone on the inside. A guard helping her out.""*)
  - -> `[49]` (*Player_Romus: ""Pabel was in on it. He's vanished without a trace.""*)
  - -> `[50]` (*Player_Romus: ""I think my mother might have helped her, but I have no p..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player_Romus: ""I suspect she's trying to flee the country. Can our fore..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect she's trying to flee the country. Can our foreign intelligence services help find her?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Kontekst wejściowy (poprzednik):** `[41]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucita Azaro: ""Yes, of course. I'll tell them to be on the lookout.""*)

### Węzeł `[46]`
Mówca: **Lucita Azaro**
> ""Yes, of course. I'll tell them to be on the lookout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""You should get some rest, Your Majesty. Trust in your se..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She had someone on the inside. A guard helping her out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[48]`
Mówca: **Lucita Azaro**
> ""That's very troubling. I'll ask my intelligence operatives to look into it at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""You should get some rest, Your Majesty. Trust in your se..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel was in on it. He's vanished without a trace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think my mother might have helped her, but I have no proof.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)

### Węzeł `[51]`
Mówca: **Lucita Azaro**
> ""You should get some rest, Your Majesty. Trust in your security staff to handle the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Complete..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It won't be easy to rest. But I'll try.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "She gave me a terse nod."*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I have to do something. I'll go crazy otherwise.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "She gave me a terse nod."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Wait. Take a walk with me." [Marriage Proposal]"]** — Mówca: **Player_Romus**
> ""Wait. Take a walk with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "She paused, thinking it over."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Narrator: "My mother's words echoed in my head. "Unless...""*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""Thank you, Duchess Azaro. I hope this all resolves quick..."*)
  - -> `[53]` (*Player_Romus: ""No. I have to do something. I'll go crazy otherwise.""*)
  - -> `[52]` (*Player_Romus: ""It won't be easy to rest. But I'll try.""*)

### Węzeł `[58]`
Mówca: **Lucita Azaro**
> ""It will all be fine. Don't worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Węzeł Logiki Narracyjnej: "End No Marriage"*)

### Węzeł `[59]`
Mówca: **Narrator**
> "She gave me a terse nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucita Azaro: ""It will all be fine. Don't worry.""*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Duchess Azaro. I hope this all resolves quickly.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false` AND `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucita Azaro: ""I have faith that it will.""*)

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""I have faith that it will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Węzeł Logiki Narracyjnej: "End No Marriage"*)

### Węzeł `[62]`
Mówca: **Narrator**
> "She paused, thinking it over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucita Azaro: ""All right. I'm sure you could use the distraction.""*)

### Węzeł `[63]`
Mówca: **Lucita Azaro**
> ""All right. I'm sure you could use the distraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "We started walking together through the gardens. It was a..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "We started walking together through the gardens. It was a balmy night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Eventually, we came to the spot in the center with the st..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Eventually, we came to the spot in the center with the stone bench."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "PROPOSAL"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "Kneel."]** — Mówca: **Player_Romus_Italic**
> "I knelt on the ground, ignoring the twinge in my bad leg."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Limp"] == true` AND `(Variable["RiziaDLC.Vina_Hostage"] == true) == false` AND `(Variable["RiziaDLC.Vina_KeepsLastName"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[243]` (Narrator), `[241]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling = true"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Limp == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Limp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Limp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player_Romus_Italic: "Kneel."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Limp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus_Italic: "Kneel."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "Stay standing."]** — Mówca: **Player_Romus_Italic**
> "I stayed standing and turned towards my councilor."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false` AND `(Variable["RiziaDLC.Vina_KeepsLastName"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[243]` (Narrator), `[241]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Standing = true"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you love me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "She pulled back from me slightly."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you able to bear children?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "She pulled back and gave me a measured look."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "She pulled back and gave me a measured look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucita Azaro: ""I believe so. My monthly visitor continues to bless me w..."*)

### Węzeł `[74]`
Mówca: **Lucita Azaro**
> ""I believe so. My monthly visitor continues to bless me with exasperating regularity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Player_Romus: ""That's all I wanted to know. Good night.""*)
  - -> `[88]` (*Player_Romus: ""Then I would like to request that you grant me the honor..."*)
  - -> `[89]` (*Player_Romus: ""Then have *my* my children, Duchess Azaro. Be my wife.""*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "Kneel."]** — Mówca: **Player_Romus_Italic**
> "I knelt on the ground."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Limp"] == true) == false` AND `(Variable["RiziaDLC.Vina_Hostage"] == true) == false` AND `(Variable["RiziaDLC.Vina_KeepsLastName"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[243]` (Narrator), `[241]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling = true"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "Sit down."]** — Mówca: **Player_Romus_Italic**
> "I motioned for Lucita to sit next to me on the bench."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false` AND `(Variable["RiziaDLC.Vina_KeepsLastName"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[243]` (Narrator), `[241]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Sitting = true"*)

### Węzeł `[77]`
Mówca: **Narrator**
> "Lucita's eyes widened. She looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""Lucita, will you marry me?""*)
  - -> `[79]` (*Player_Romus: ""In the presence of the heavens above and the earth below..."*)
  - -> `[72]` (*Player_Romus: ""Are you able to bear children?""*)
  - -> `[71]` (*Player_Romus: ""Do you love me?""*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita, will you marry me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "She clapped a hand to her mouth. It was a second before s..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the presence of the heavens above and the earth below, I do extend unto thee an offer of marriage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "She clapped a hand to her mouth. It was a second before s..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "She clapped a hand to her mouth. It was a second before she replied."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""Is this because of your daughter's disappearance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""I need another heir, Lucita. Preferably a boy.""*)
  - -> `[83]` (*Player_Romus: ""That's incidental. I've loved you since the moment you e..."*)
  - -> `[84]` (*Player_Romus: ""With my command of the Rizian government and your comman..."*)
  - -> `[85]` (*Player_Romus: ""Don't ask why. Just say yes.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need another heir, Lucita. Preferably a boy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucita Azaro), `[154]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucita Azaro: ""That's the most cold-blooded thing I've ever heard.""*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's incidental. I've loved you since the moment you entered my council chambers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucita Azaro: ""I've loved you since before we even met.""*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With my command of the Rizian government and your command of the military, we will be unstoppable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucita Azaro), `[154]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucita Azaro: ""Unstoppable. I like the sound of that.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't ask why. Just say yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Lucita Azaro), `[154]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucita Azaro: ""In that case...""*)

### Węzeł `[86]`
Mówca: **Lucita Azaro**
> ""That's the most cold-blooded thing I've ever heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true"*)

### Węzeł `[87]`
Mówca: **Narrator**
> "She reached up, grabbed the back of my head and pulled my face level with hers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucita Azaro: ""Yes, King Romus. I will marry you.""*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I would like to request that you grant me the honor of your hand in marriage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Lucita Azaro), `[144]` (Lucita Azaro), `[148]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "She clapped a hand to her mouth. It was a second before s..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then have *my* my children, Duchess Azaro. Be my wife.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "She clapped a hand to her mouth. It was a second before s..."*)

### Węzeł `[90]`
Mówca: **Lucita Azaro**
> ""Yes, King Romus. I will marry you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "We kissed with such force that we nearly toppled to the g..."*)

### Węzeł `[91]`
Mówca: **Lucita Azaro**
> ""I've loved you since before we even met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true"*)

### Węzeł `[92]`
Mówca: **Lucita Azaro**
> ""Unstoppable. I like the sound of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true"*)

### Węzeł `[93]`
Mówca: **Lucita Azaro**
> ""In that case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded ..."*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expande..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lucita Azaro: ""That's very troubling. I'll ask my intelligence operativ..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lucita Azaro: ""That's very troubling.""*)

### Węzeł `[97]`
Mówca: **Lucita Azaro**
> ""That's very troubling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucita Azaro: ""You should get some rest, Your Majesty. Trust in your se..."*)

### Węzeł `[98]`
Mówca: **Lucita Azaro**
> ""Good night, Your Majesty. I'll let you know at once if the Princess is found.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[99]`
Mówca: **Narrator**
> "She walked off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I re-entered the palace, where I was greeted by Titus."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "I re-entered the palace, where I was greeted by Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Titus Gordion: ""Still no trace of her, Your Majesty. Your butler seems t..."*)

### Węzeł `[101]`
Mówca: **Titus Gordion**
> ""Still no trace of her, Your Majesty. Your butler seems to have disappeared from the palace grounds as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: ""Never mind that. I want to know about my mother's involv..."*)
  - -> `[105]` (*Player_Romus: ""Find them both. This is an embarrassment.""*)
  - -> `[107]` (*Player_Romus: ""It's no use. She's gone.""*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "She walked off."*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never mind that. I want to know about my mother's involvement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Titus Gordion: ""I'll find out what I can.""*)

### Węzeł `[104]`
Mówca: **Titus Gordion**
> ""I'll find out what I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Find them both. This is an embarrassment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Titus Gordion: ""As I said, I'll see what I can do.""*)

### Węzeł `[106]`
Mówca: **Titus Gordion**
> ""As I said, I'll see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's no use. She's gone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Titus Gordion: ""Don't give up yet. We'll bring Her Highness home.""*)

### Węzeł `[108]`
Mówca: **Titus Gordion**
> ""Don't give up yet. We'll bring Her Highness home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "He shadowed me as I walked upstairs and into my quarters."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "He shadowed me as I walked upstairs and into my quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "Bruno was waiting for me by my valet stand, where a brand..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Arranged on my valet stand was a brand-new, crisp royal b..."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "Bruno was waiting for me by my valet stand, where a brand-new, crisp royal blue suit had been hung up. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus_Italic: "Leave it there."*)
  - -> `[126]` (*Player_Romus_Italic: "Throw it in the corner."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "Arranged on my valet stand was a brand-new, crisp royal blue suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus_Italic: "Leave it there."*)
  - -> `[126]` (*Player_Romus_Italic: "Throw it in the corner."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Bruno was waiting for me by my valet stand, where my favorite suit had been hung up. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player_Romus_Italic: "Leave it hanging there."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "Leave it there."]** — Mówca: **Player_Romus_Italic**
> "I left the outfit where it was."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Narrator), `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "There was a chance I would still get to wear it."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Bruno was waiting for me by my valet stand, where my favo..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Pabel had hung up my favorite suit on the valet stand."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Pabel had hung up my favorite suit on the valet stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Romus_Italic: "Throw it in the corner."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "There was a chance I would still get to wear it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "Throw it in the corner."]** — Mówca: **Player_Romus_Italic**
> "I crumpled it up and threw it in the corner of the room."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Narrator), `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "I knew that I would never wear it."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "I knew that I would never wear it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "Leave it hanging there."]** — Mówca: **Player_Romus_Italic**
> "I left the outfit where it was."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "There was a chance tomorrow could still be a normal day."*)

### Węzeł `[129]`
Mówca: **Narrator**
> "There was a chance tomorrow could still be a normal day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "Throw it in the corner."]** — Mówca: **Player_Romus_Italic**
> "I crumpled it up and threw it in the corner of the room."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "I knew that I would never wear it again."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "I knew that I would never wear it again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_LucitaProposal_Sitting = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Sitting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Lucita's eyes widened. She looked at me questioningly."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_LucitaProposal_Standing = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Standing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Lucita's eyes widened. She looked at me questioningly."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "Lucita's eyes widened. She looked at me questioningly."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "She pulled back from me slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn03_LucitaLoveConvo == true"*)

### Węzeł `[136]`
Mówca: **Lucita Azaro**
> ""I told you long ago that falling in love was like heading into battle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_LucitaLoveConvo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn03_LucitaLoveConvo == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn03_LucitaLoveConvo == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn03_LucitaLoveConvo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn03_LucitaLoveConvo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lucita Azaro: ""I told you long ago that falling in love was like headin..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn03_LucitaLoveConvo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn03_LucitaLoveConvo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucita Azaro: ""I told myself long ago that I would never fall in love. ..."*)

### Węzeł `[140]`
Mówca: **Lucita Azaro**
> ""Of course, that was before you and I found ourselves fighting an actual battle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lucita Azaro: ""We've held our ground against Pales. But when it comes t..."*)

### Węzeł `[141]`
Mówca: **Lucita Azaro**
> ""I told myself long ago that I would never fall in love. Giving yourself to someone like that allows them to have absolute power over you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Lucita Azaro: ""And I refuse to subjugate myself to anyone.""*)

### Węzeł `[142]`
Mówca: **Lucita Azaro**
> ""And I refuse to subjugate myself to anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "She smiled slowly."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "She smiled slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucita Azaro: ""Except for my king.""*)

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""Except for my king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Player_Romus: ""That's all I wanted to know. Good night.""*)
  - -> `[88]` (*Player_Romus: ""Then I would like to request that you grant me the honor..."*)
  - -> `[150]` (*Player_Romus: ""I don't know if you're lying. I don't care. Marry me, Lu..."*)
  - -> `[793]` (*Player_Romus: ""No, I surrender to you. I want you to be Rizia's new Que..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lucita Azaro: ""Of course, that was before you and I found ourselves fig..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucita Azaro: ""Well, Your Majesty... I surrender.""*)

### Węzeł `[148]`
Mówca: **Lucita Azaro**
> ""We've held our ground against Pales. But when it comes to the two of us... well, Your Majesty, I surrender.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Player_Romus: ""That's all I wanted to know. Good night.""*)
  - -> `[88]` (*Player_Romus: ""Then I would like to request that you grant me the honor..."*)
  - -> `[150]` (*Player_Romus: ""I don't know if you're lying. I don't care. Marry me, Lu..."*)
  - -> `[793]` (*Player_Romus: ""No, I surrender to you. I want you to be Rizia's new Que..."*)

### Węzeł `[149]`
Mówca: **Lucita Azaro**
> ""Well, Your Majesty... I surrender.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Player_Romus: ""That's all I wanted to know. Good night.""*)
  - -> `[88]` (*Player_Romus: ""Then I would like to request that you grant me the honor..."*)
  - -> `[150]` (*Player_Romus: ""I don't know if you're lying. I don't care. Marry me, Lu..."*)
  - -> `[793]` (*Player_Romus: ""No, I surrender to you. I want you to be Rizia's new Que..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know if you're lying. I don't care. Marry me, Lucita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucita Azaro), `[148]` (Lucita Azaro), `[149]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "She clapped a hand to her mouth. It was a second before s..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true )"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucita Azaro: ""Is this because of your daughter's disappearance?""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucita Azaro: ""Is it unromantic of me to ask why?""*)

### Węzeł `[154]`
Mówca: **Lucita Azaro**
> ""Is it unromantic of me to ask why?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""I need another heir, Lucita. Preferably a boy.""*)
  - -> `[84]` (*Player_Romus: ""With my command of the Rizian government and your comman..."*)
  - -> `[85]` (*Player_Romus: ""Don't ask why. Just say yes.""*)
  - -> `[155]` (*Player_Romus: ""I've loved you since the moment you entered my council c..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've loved you since the moment you entered my council chambers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucita Azaro: ""I've loved you since before we even met.""*)

### Węzeł `[156]`
Mówca: **Lucita Azaro**
> ""I've loved you since before we even met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "She reached down, grabbed the back of my head and pulled ..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "She reached up, grabbed the back of my head and pulled my..."*)

### Węzeł `[160]`
Mówca: **Narrator**
> "She reached down, grabbed the back of my head and pulled my face level with hers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucita Azaro: ""Yes, King Romus. I will marry you.""*)

### Węzeł `[161]`
Mówca: **Narrator**
> "We kissed with such force that we nearly toppled to the ground. I wondered if any guards had eyes on us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "When we broke apart, she was grinning."*)

### Węzeł `[162]`
Mówca: **Lucita Azaro**
> ""Wait. I have an idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "She took my hand and pulled me towards the palace."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "She took my hand and pulled me towards the palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "She led me through the ground-floor corridors until we ca..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfV..."*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessO..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_SleepsInBed == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "Bruno was on my bed, lying atop a brand-new, crisp royal ..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_SleepsInBed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "Atop my bed was a brand-new, crisp royal blue suit. Pabel..."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "Bruno was on my bed, lying atop a brand-new, crisp royal blue suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player_Romus_Italic: "Hang it up."*)
  - -> `[180]` (*Player_Romus_Italic: "Throw it in the corner."*)

### Węzeł `[171]`
Mówca: **Narrator**
> "Atop my bed was a brand-new, crisp royal blue suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player_Romus_Italic: "Hang it up."*)
  - -> `[180]` (*Player_Romus_Italic: "Throw it in the corner."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "Bruno was on my bed, lying atop my favorite suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus_Italic: "Hang it up."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: "Hang it up."]** — Mówca: **Player_Romus_Italic**
> "I carefully hung it on the wall next to me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Narrator), `[171]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "I wondered what tomorrow would bring."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_SleepsInBed == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "Bruno was on my bed, lying atop my favorite suit. Pabel h..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_SleepsInBed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "Atop my bed was my favorite suit. Pabel had laid it out f..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "Atop my bed was my favorite suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus_Italic: "Throw it in the corner."*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "Throw it in the corner."]** — Mówca: **Player_Romus_Italic**
> "I crumpled it up and threw it in the corner of the room."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "I wondered what tomorrow would bring."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "I wondered what tomorrow would bring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)

### Węzeł `[180]`
**[WYBÓR GRACZA: "Throw it in the corner."]** — Mówca: **Player_Romus_Italic**
> "I crumpled it up and threw it in the corner of the room."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[170]` (Narrator), `[171]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "I wondered what tomorrow would bring."*)

### Węzeł `[181]`
**[WYBÓR GRACZA: "Hang it up."]** — Mówca: **Player_Romus_Italic**
> "I carefully hung it on the wall next to me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "I wondered what tomorrow would bring."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "In a daze, I slowly walked upstairs to my quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfV..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "It was the night before Vina's wedding."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)

### Węzeł `[186]`
Mówca: **Narrator**
> "It was the night before Vina's wedding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[187]`
Mówca: **Narrator**
> "After a day spent finalizing arrangements, conducting interviews and meeting with visiting guests, I was exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[188]`
Mówca: **Narrator**
> "After a day spent finalizing arrangements, holding press conferences and reviewing security details, I was exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[189]`
Mówca: **Narrator**
> "After an endless day of war briefings and strategy planning sessions, I was looking forward to collapsing in my bed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "After a day spent finalizing arrangements, holding press ..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "After a day spent finalizing arrangements, conducting int..."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "It was late at night at Palas Rezna."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "After an endless day of war briefings and strategy planni..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "After an endless day of meetings, I was looking forward t..."*)

### Węzeł `[197]`
Mówca: **Narrator**
> "After an endless day of meetings, I was looking forward to collapsing in my bed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lu..."*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true && RiziaDLC...."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "First, though, I decided to take a walk in the palace gar..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true && RiziaDLC.Lucita_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == ..."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "First, though, I decided to take a walk in the palace gardens to clear my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "I had just stepped onto the grounds when I bumped into Lu..."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "I had just stepped onto the grounds when I bumped into Lucita."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lucita Azaro: ""Oh! Hello, Your Majesty.""*)

### Węzeł `[203]`
Mówca: **Lucita Azaro**
> ""Oh! Hello, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[204]`
Mówca: **Lucita Azaro**
> ""I was just reviewing the latest strategies for the Zille resistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player_Romus: ""Look at us. Addicted to our jobs.""*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[218]` (*Player_Romus: ""It sounds like you're urgently in need of stress relief.""*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_ViolentResistancePower > 0"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_ViolentResistancePower > 0)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_ViolentResistancePower > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Lucita Azaro: ""I was just reviewing the latest strategies for the Zille..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_ViolentResistancePower > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_ViolentResistancePower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[208]`
Mówca: **Lucita Azaro**
> ""I was just reviewing our latest plans for dealing with the unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player_Romus: ""Look at us. Addicted to our jobs.""*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[218]` (*Player_Romus: ""It sounds like you're urgently in need of stress relief.""*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lucita Azaro: ""I was just reviewing our latest plans for dealing with t..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Lucita Azaro: ""I was just reviewing the latest internal security reports.""*)

### Węzeł `[212]`
Mówca: **Lucita Azaro**
> ""I was just reviewing the latest internal security reports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player_Romus: ""Look at us. Addicted to our jobs.""*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[218]` (*Player_Romus: ""It sounds like you're urgently in need of stress relief.""*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at us. Addicted to our jobs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Lucita Azaro), `[37]` (Lucita Azaro), `[204]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lucita Azaro: ""There's no clocking out when the kingdom's future is at ..."*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody told me that ruling the country would be all this work.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Kontekst wejściowy (poprzednik):** `[33]` (Lucita Azaro), `[37]` (Lucita Azaro), `[204]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lucita Azaro: ""At least you've got your council to fall back on.""*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player_Romus: ""Nobody told me that ruling the country would be all this..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds like you're urgently in need of stress relief.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Lucita Azaro), `[37]` (Lucita Azaro), `[204]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "She smiled."*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've got too much on your plate. Why not share the load with the Golden Guard?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Kontekst wejściowy (poprzednik):** `[33]` (Lucita Azaro), `[37]` (Lucita Azaro), `[204]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "She made a scoffing sound."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player_Romus: ""You've got too much on your plate. Why not share the loa..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[223]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucita Azaro: ""Come on. Let's take a walk.""*)

### Węzeł `[224]`
Mówca: **Lucita Azaro**
> ""At least you've got your council to fall back on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucita Azaro: ""Come on. Let's take a walk.""*)

### Węzeł `[225]`
Mówca: **Lucita Azaro**
> ""There's no clocking out when the kingdom's future is at stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucita Azaro: ""Come on. Let's take a walk.""*)

### Węzeł `[226]`
Mówca: **Lucita Azaro**
> ""Come on. Let's take a walk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "We strolled further into the gardens. It was a balmy nigh..."*)

### Węzeł `[227]`
Mówca: **Narrator**
> "She made a scoffing sound."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucita Azaro: ""Come on. Let's take a walk.""*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FullCouncilor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FullCouncilor == true"*)
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FullCouncilor == true)"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FullCouncilor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FullCouncilor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucita Azaro: ""I was skeptical at first, but your daughter has really c..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FullCouncilor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FullCouncilor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)

### Węzeł `[231]`
Mówca: **Lucita Azaro**
> ""Vina Toras, Duchess of Valenqiris. The day has finally come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""I still remember attending the celebrations when she was..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_DuchessOfValenqiris == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "It was the night before Vina's investiture ceremony as Du..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "It was late at night at Palas Rezna."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "It was the night before Vina's investiture ceremony as Duchess of Monqiz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[236]`
Mówca: **Narrator**
> "The moon had risen by now, illuminating Lucita's features. I thought about everything we'd been through together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "I thought about her position as councilor. Her 'interim' ..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_KeepsLastName == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_KeepsLastName == false"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_KeepsLastName == false)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_KeepsLastName == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_KeepsLastName"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "I thought about how, as of tomorrow, the heir to the thro..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_KeepsLastName == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_KeepsLastName"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PROPOSAL`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "The moon had risen by now, illuminating Lucita's features..."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "I thought about her position as councilor. Her 'interim' status had lasted longer than expected, but it was nearly time for her father to return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_KeepsLastName == false"*)

### Węzeł `[242]`
Mówca: **Narrator**
> "I thought about how, as of tomorrow, the heir to the throne of Rizia would not be a member of House Toras."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[70]` (*Player_Romus_Italic: "Stay standing."*)
  - -> `[76]` (*Player_Romus_Italic: "Sit down."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "I thought how, if Vina died in Pales, I would be left without an heir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[70]` (*Player_Romus_Italic: "Stay standing."*)
  - -> `[76]` (*Player_Romus_Italic: "Sit down."*)

### Węzeł `[244]`
Mówca: **Narrator**
> "My mother's words echoed in my head. "Unless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Player_Romus: ""No. I have to do something. I'll go crazy otherwise.""*)
  - -> `[798]` (*Player_Romus: ""It won't be easy to rest. But I'll try.""*)
  - -> `[54]` (*Player_Romus: ""Wait. Take a walk with me." [Marriage Proposal]"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [PROPOSAL]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "PROPOSAL"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[247]`
Mówca: **Narrator**
> "When we broke apart, she was grinning."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucita Azaro: ""Wait. I have an idea.""*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == false)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Player_Romus: ""What? You want to wake the old man up now?""*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateSal == true"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[261]` (*Player_Romus: ""I think I see where this is going...""*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player_Romus: ""We can't get in. It's been locked since his arrest.""*)
  - -> `[263]` (*Player_Romus: ""The traitor's chambers? Why have you brought me here?""*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[270]` (*Player_Romus: ""You want to go snooping for more evidence against him? G..."*)

### Węzeł `[251]`
Mówca: **Narrator**
> "She led me through the ground-floor corridors until we came to the entrance to Sal Ignacius' quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? You want to wake the old man up now?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[251]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "She put a finger to her lips and quietly rapped on the door."*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman? I still don't trust him.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true` AND `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[251]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "She put a finger to her lips and quietly rapped on the door."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateSal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateSal == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateSal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: ""The Grand Wiseman? I still don't trust him.""*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player_Romus: ""Ah, a visit to my beloved spiritual advisor. Always a go..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, a visit to my beloved spiritual advisor. Always a good idea.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true` AND `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[251]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "She put a finger to her lips and quietly rapped on the door."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I see where this is going...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Kontekst wejściowy (poprzednik):** `[251]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "She put a finger to her lips and quietly rapped on the door."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can't get in. It's been locked since his arrest.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[251]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "She put a finger to her lips, then took a keychain from h..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The traitor's chambers? Why have you brought me here?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[251]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "She put a finger to her lips, then took a keychain from h..."*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I will not consummate our engagement in a holy man's bed, no matter how treasonous he turned out to be.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true` AND `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[251]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "She put a finger to her lips, then took a keychain from h..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Player_Romus: ""No, I will not consummate our engagement in a holy man's..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player_Romus: ""Consummating our engagement in a treasonous priest's bed..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Consummating our engagement in a treasonous priest's bed? See, this is why I love you.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` AND `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[251]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "She put a finger to her lips, then took a keychain from h..."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "She put a finger to her lips, then took a keychain from her pocket and silently unlocked the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "The room was as he'd left it: minimally furnished, with s..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You want to go snooping for more evidence against him? Good idea.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[251]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "She put a finger to her lips, then took a keychain from h..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "She put a finger to her lips and quietly rapped on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "After almost a minute, it creaked open. Sal stood there i..."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "After almost a minute, it creaked open. Sal stood there in his dressing gown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Sal Ignacius: ""Your Majesty, Your Grace! Is there an emergency?""*)

### Węzeł `[273]`
Mówca: **Sal Ignacius**
> ""Your Majesty, Your Grace! Is there an emergency?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "Lucita took my hand and stepped forward."*)

### Węzeł `[274]`
Mówca: **Narrator**
> "Lucita took my hand and stepped forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucita Azaro: ""Grand Wiseman, His Majesty and I are in love and wish fo..."*)

### Węzeł `[275]`
Mówca: **Lucita Azaro**
> ""Grand Wiseman, His Majesty and I are in love and wish for you to sanctify our union by the sacrament of marriage. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "He rubbed his eyes."*)

### Węzeł `[276]`
Mówca: **Narrator**
> "He rubbed his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Sal Ignacius: ""This is most unorthodox.""*)

### Węzeł `[277]`
Mówca: **Sal Ignacius**
> ""This is most unorthodox.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Player_Romus: ""I agree. This seems incredibly hasty.""*)
  - -> `[278]` (*Player_Romus: ""Her Grace has spoken correctly. As your King, I command ..."*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateSal == true"*)
  - -> `[284]` (*Player_Romus: ""Would you rather we live in sin, Grand Wiseman?""*)

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Her Grace has spoken correctly. As your King, I command you to perform the marriage rites.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Sal Ignacius: ""Yes, yes, of course. Give me one moment.""*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. This seems incredibly hasty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateSal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateSal == true"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateSal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player_Romus: ""Need I remind you that my mercy saved you from imprisonm..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Need I remind you that my mercy saved you from imprisonment? You will do this for us, no questions asked.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true`
- **Kontekst wejściowy (poprzednik):** `[277]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Sal Ignacius: ""Yes, yes, of course. Give me one moment.""*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Would you rather we live in sin, Grand Wiseman?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Sal Ignacius: ""No, no, of course not. Give me one moment.""*)

### Węzeł `[285]`
Mówca: **Lucita Azaro**
> ""Why wait? It's what we want. And you know how frowned-upon garish second weddings are in royal circles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "She turned back to Sal."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Lucita Azaro: ""Why wait? It's what we want. And it'll look desperate fo..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Lucita Azaro: ""Why wait? It's what we want. And you know how frowned-up..."*)

### Węzeł `[289]`
Mówca: **Lucita Azaro**
> ""Why wait? It's what we want. And it'll look desperate for our kingdom to put on two grand royal weddings in a row.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "She turned back to Sal."*)

### Węzeł `[290]`
Mówca: **Sal Ignacius**
> ""Yes, yes, of course. Give me one moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "He carefully closed the door."*)

### Węzeł `[291]`
Mówca: **Sal Ignacius**
> ""Of course, Your Grace. Give me one moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "He carefully closed the door."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "She turned back to Sal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Lucita Azaro: ""Well? Will you do it?""*)

### Węzeł `[293]`
Mówca: **Lucita Azaro**
> ""Well? Will you do it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Sal Ignacius: ""Of course, Your Grace. Give me one moment.""*)

### Węzeł `[294]`
Mówca: **Sal Ignacius**
> ""No, no, of course not. Give me one moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "He carefully closed the door."*)

### Węzeł `[295]`
Mówca: **Narrator**
> "He carefully closed the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "IsCollectionItemShowing("CollectionItem_WeddingRing")"*)
  - -> `[300]` (*Player_Romus: ""You're insane.""*)
  - -> `[301]` (*Player_Romus: ""Don't you want your father to be here?""*)
  - -> `[302]` (*Player_Romus: ""Was this how you always dreamed your wedding would be?""*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still have Lena's wedding ring. Let me fetch it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_WearsLenasRing"] == true) == false` AND `IsCollectionItemShowing("CollectionItem_WeddingRing")`
- **Kontekst wejściowy (poprzednik):** `[295]` (Narrator), `[348]` (Narrator), `[349]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Her breath caught in her throat."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `IsCollectionItemShowing("CollectionItem_WeddingRing")`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "IsCollectionItemShowing("CollectionItem_WeddingRing")"*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(IsCollectionItemShowing("CollectionItem_WeddingRing"))"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `IsCollectionItemShowing("CollectionItem_WeddingRing")`
- **Warunek bezpośredni (`conditionsString`):** `IsCollectionItemShowing("CollectionItem_WeddingRing")`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_WearsLenasRing == true"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(IsCollectionItemShowing("CollectionItem_WeddingRing"))`
- **Warunek bezpośredni (`conditionsString`):** `(IsCollectionItemShowing("CollectionItem_WeddingRing")) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're insane.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Narrator), `[348]` (Narrator), `[349]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lucita Azaro: ""What's insane is spending endless amounts of time and re..."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you want your father to be here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Narrator), `[348]` (Narrator), `[349]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Lucita Azaro: ""He never had any use for weddings. It'll be far more imp..."*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was this how you always dreamed your wedding would be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[295]` (Narrator), `[348]` (Narrator), `[349]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Lucita Azaro: ""Mmhmm. Right down to the grass stain on my dress.""*)

### Węzeł `[303]`
Mówca: **Lucita Azaro**
> ""He never had any use for weddings. It'll be far more important for him to be present when we first address the troops together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[304]`
Mówca: **Lucita Azaro**
> ""What's insane is spending endless amounts of time and resources to achieve exactly the same result.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[305]`
Mówca: **Narrator**
> "Her breath caught in her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Lucita Azaro: ""Are... are you sure?""*)

### Węzeł `[306]`
Mówca: **Lucita Azaro**
> ""Are... are you sure?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[307]` (*Player_Romus: ""She would want you to have it. I'm sure of it.""*)
  - -> `[308]` (*Player_Romus: ""It's been gathering dust on my table all these years. It..."*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_NegotiatingPower > 0"*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She would want you to have it. I'm sure of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[306]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "I dashed up to my study and took Lena's ring from my desk..."*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's been gathering dust on my table all these years. It'll look much better on your finger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[306]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "I dashed up to my study and took Lena's ring from my desk..."*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It symbolizes the continuity of our kingdom's relationship with Rumburg. The alliance endures, even if my marriage did not.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] > 0`
- **Kontekst wejściowy (poprzednik):** `[306]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "I dashed up to my study and took Lena's ring from my desk..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_NegotiatingPower > 0"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Rumburg_NegotiatingPower > 0)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Romus: ""It symbolizes the continuity of our kingdom's relationsh..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Rumburg_NegotiatingPower > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Player_Romus: ""I'm sure. Imagine how furious it'll make Queen Beatrice ..."*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure. Imagine how furious it'll make Queen Beatrice to see you wearing it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[306]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "I dashed up to my study and took Lena's ring from my desk..."*)

### Węzeł `[314]`
Mówca: **Narrator**
> "I dashed up to my study and took Lena's ring from my desk. My mind flashed back to the all-too-brief time my first wife and I had spent together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "DisableCollectionItem("CollectionItem_WeddingRing"); Rizi..."*)

### Węzeł `[315]`
Mówca: **Narrator**
> "When I made it back to Sal's quarters, the door was open. The Grand Wiseman, now dressed in ceremonial robes, beckoned us inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Sal Ignacius: ""Because we are not in a sanctuary, some sacred tradition..."*)

### Węzeł `[316]`
Mówca: **Lucita Azaro**
> ""Mmhmm. Right down to the grass stain on my dress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[317]`
Mówca: **Narrator**
> "The door opened and Sal beckoned us inside, now dressed in ceremonial robes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Sal Ignacius: ""Because we are not in a sanctuary, some sacred tradition..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DisableCollectionItem("CollectionItem_WeddingRing"); RiziaDLC.Lucita_WearsLenasRing = true;
RiziaDLC.Vina_WearsLenasRing = false;`
- **Efekt skryptowy (`userScript`):** `DisableCollectionItem("CollectionItem_WeddingRing");
Variable["RiziaDLC.Lucita_WearsLenasRing"] = true;
Variable["RiziaDLC.Vina_WearsLenasRing"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_WeddingRing");"*)

### Węzeł `[319]`
Mówca: **Sal Ignacius**
> ""Because we are not in a sanctuary, some sacred traditions will have to be foregone. But your marriage shall still be valid before the Lord and the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Sal Ignacius: ""Please join hands.""*)

### Węzeł `[320]`
Mówca: **Sal Ignacius**
> ""Please join hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Narrator: "I clasped Lucita's hand in mine as we stood side by side ..."*)

### Węzeł `[321]`
Mówca: **Narrator**
> "I clasped Lucita's hand in mine as we stood side by side in front of Sal. He opened an ancient-looking scroll and read from it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Sal Ignacius: ""Almighty and ever-living God, who in Thy infinite wisdom..."*)

### Węzeł `[322]`
Mówca: **Narrator**
> "The room was as he'd left it: minimally furnished, with shelves full of books and sacred objects lining the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Lucita Azaro: ""Rizian law dictates that in the absence of a Grand Wisem..."*)

### Węzeł `[323]`
Mówca: **Lucita Azaro**
> ""Rizian law dictates that in the absence of a Grand Wiseman, the monarch is granted the ability to officiate marriages.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Lucita Azaro: ""Including his own.""*)

### Węzeł `[324]`
Mówca: **Lucita Azaro**
> ""Including his own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[331]` (*Player_Romus: ""A wedding without boring religious speeches? Count me in.""*)
  - -> `[325]` (*Player_Romus: ""This seems incredibly hasty.""*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This seems incredibly hasty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[326]`
Mówca: **Lucita Azaro**
> ""Why wait? It's what we want. And you know how frowned-upon garish second weddings are in royal circles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Lucita Azaro: ""Why wait? It's what we want. And it'll look desperate fo..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Lucita Azaro: ""Why wait? It's what we want. And you know how frowned-up..."*)

### Węzeł `[330]`
Mówca: **Lucita Azaro**
> ""Why wait? It's what we want. And it'll look desperate for our kingdom to put on two grand royal weddings in a row.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged"*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A wedding without boring religious speeches? Count me in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Lucita Azaro: ""I knew you'd like the idea.""*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Player_Romus: ""True. I should practice doing this before Vina's wedding..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""True. I should practice doing this before Vina's wedding tomorrow.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Kontekst wejściowy (poprzednik):** `[324]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Lucita Azaro: ""It'll be easy. An oath here, a speech there.""*)

### Węzeł `[336]`
Mówca: **Lucita Azaro**
> ""I knew you'd like the idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged"*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid it won't be legitimate before the Lord.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[324]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Lucita Azaro: ""You're the King. The Lord's will incarnate, supposedly.""*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player_Romus: ""I'm afraid it won't be legitimate before the Lord.""*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Player_Romus: ""I'm afraid it won't be legitimate.""*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm afraid it won't be legitimate.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[324]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Lucita Azaro: ""You're the King. You are the law.""*)

### Węzeł `[342]`
Mówca: **Lucita Azaro**
> ""You're the King. You are the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged"*)

### Węzeł `[343]`
Mówca: **Lucita Azaro**
> ""You're the King. The Lord's will incarnate, supposedly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged"*)

### Węzeł `[344]`
Mówca: **Lucita Azaro**
> ""It'll be easy. An oath here, a speech there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged"*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged)"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Narrator: "A wooden box was on Sal's desk, containing the materials ..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "Lucita walked into the room and began browsing the shelves."*)

### Węzeł `[348]`
Mówca: **Narrator**
> "A wooden box was on Sal's desk, containing the materials needed for Vina's ceremony tomorrow. Lucita walked into the room and began poking through it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "IsCollectionItemShowing("CollectionItem_WeddingRing")"*)
  - -> `[300]` (*Player_Romus: ""You're insane.""*)
  - -> `[301]` (*Player_Romus: ""Don't you want your father to be here?""*)
  - -> `[302]` (*Player_Romus: ""Was this how you always dreamed your wedding would be?""*)

### Węzeł `[349]`
Mówca: **Narrator**
> "Lucita walked into the room and began browsing the shelves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "IsCollectionItemShowing("CollectionItem_WeddingRing")"*)
  - -> `[300]` (*Player_Romus: ""You're insane.""*)
  - -> `[301]` (*Player_Romus: ""Don't you want your father to be here?""*)
  - -> `[302]` (*Player_Romus: ""Was this how you always dreamed your wedding would be?""*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == false)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "When I made it back to Sal's quarters, the door was open...."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "When I made it back to Sal's quarters, the door was open...."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == false)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "The door opened and Sal beckoned us inside, now dressed i..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "I watched as she lit a pair of candles and arranged a set..."*)

### Węzeł `[356]`
Mówca: **Narrator**
> "When I made it back to Sal's quarters, the door was open. Lucita had lit a pair of candles and arranged a set of objects in a row on Sal's desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Narrator: "First in the row was a scroll. She handed it to me."*)

### Węzeł `[357]`
Mówca: **Narrator**
> "I watched as she lit a pair of candles and arranged a set of objects in a row on Sal's desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Narrator: "First in the row was a scroll. She handed it to me."*)

### Węzeł `[358]`
Mówca: **Narrator**
> "First in the row was a scroll. She handed it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: ""Almighty and ever-loving God...""*)

### Węzeł `[359]`
**[WYBÓR GRACZA: ""Almighty and ever-loving God...""]** — Mówca: **Player_Romus**
> ""Almighty and ever-living God, who in Thy infinite wisdom hast blessed the union of two hearts in sacred wedlock, look kindly upon myself and Duchess Lucita Azaro, who stand before Thee, seeking Thy blessing. ""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Player_Romus: ""In this sacred covenant...""*)

### Węzeł `[360]`
Mówca: **Sal Ignacius**
> ""Almighty and ever-living God, who in Thy infinite wisdom hast blessed the union of two hearts in holy wedlock, look kindly upon His Majesty Romus Toras and Duchess Lucita Azaro, who stand before Thee, seeking Thy blessing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Sal Ignacius: ""In this sacred covenant, love and duty converge to forge..."*)

### Węzeł `[361]`
Mówca: **Sal Ignacius**
> ""In this sacred covenant, love and duty converge to forge a legacy that transcends the temporal realm. Let it be known that in the heart of such a union, the virtues of loyalty, honor, and commitment are the true jewels that adorn the crown of matrimonial sanctity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "The royal orb was on his desk. He picked it up and motion..."*)

### Węzeł `[362]`
Mówca: **Narrator**
> "The royal orb was on his desk. He picked it up and motioned for us to place our joined hands upon it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Sal Ignacius: ""Now, repeat after me. I, Romus Toras...""*)

### Węzeł `[363]`
Mówca: **Sal Ignacius**
> ""Now, repeat after me. I, Romus Toras...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Player_Romus: ""Wait. I want to say my own vows.""*)
  - -> `[365]` (*Player_Romus: ""I, Romus Toras...""*)

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I want to say my own vows.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[363]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "Sal raised his eyebrows."*)

### Węzeł `[365]`
**[WYBÓR GRACZA: ""I, Romus Toras...""]** — Mówca: **Player_Romus**
> ""I, Romus Toras, do pledge my unwavering faithfulness and devotion to you, Lucita Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[363]` (Sal Ignacius), `[396]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Player_Romus: ""I vow to honor and uphold you...""*)

### Węzeł `[366]`
**[WYBÓR GRACZA: ""I vow to honor and uphold you...""]** — Mówca: **Player_Romus**
> ""I vow to honor and uphold you, in joy and in sorrow, in prosperity and in adversity. I commit to lead our union with wisdom and compassion, seeking always the guidance of the divine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player_Romus: ""In all our days...""*)

### Węzeł `[367]`
**[WYBÓR GRACZA: ""In all our days...""]** — Mówca: **Player_Romus**
> ""In all our days, my commitment to you shall remain steadfast, as we walk together in God’s light.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[368]`
Mówca: **Narrator**
> "Sal raised his eyebrows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Sal Ignacius: ""Again, highly unorthodox. But it will not nullify the ma..."*)

### Węzeł `[369]`
Mówca: **Sal Ignacius**
> ""Again, highly unorthodox. But it will not nullify the marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "Lucita looked at me. Her eyes shone brightly."*)

### Węzeł `[370]`
Mówca: **Narrator**
> "Lucita looked at me. Her eyes shone brightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Player_Romus: ""Lucita, I claim you not only as my queen, but as the iro..."*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[378]` (*Player_Romus: ""Luce, the past few years I've spent with you have been t..."*)
  - -> `[390]` (*Player_Romus: ""Duchess Azaro, just as we have navigated the waters of i..."*)

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita, I claim you not only as my queen, but as the ironclad partner to my reign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[370]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Player_Romus: ""As we defend our kingdom from our hordes of enemies, so ..."*)
  - -> `[376]` (*Player_Romus: ""I vow to honor the bond we have created with kindness an..."*)
  - -> `[379]` (*Player_Romus: ""Whether in the chaos of council meetings or in the intim..."*)
  - -> `[392]` (*Player_Romus: ""Together, we are more than the sum of our parts. We are ..."*)

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As we defend our kingdom from our hordes of enemies, so shall we champion one another.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Player_Romus), `[374]` (Player_Romus), `[378]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[375]` (*Player_Romus: ""I offer you my heart, my loyalty, and my life, as we emb..."*)
  - -> `[380]` (*Player_Romus: ""I pledge myself to you not as a king to his queen, but a..."*)
  - -> `[391]` (*Player_Romus: ""Together, let us usher in a new era for our kingdom, mar..."*)

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we shall forge an unbreakable empire and crush all those who stand against us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[372]` (Player_Romus), `[376]` (Player_Romus), `[377]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As the memory of my cherished Lena fades into the past, I stand here before you ready to love anew.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[370]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Player_Romus: ""As we defend our kingdom from our hordes of enemies, so ..."*)
  - -> `[376]` (*Player_Romus: ""I vow to honor the bond we have created with kindness an..."*)
  - -> `[379]` (*Player_Romus: ""Whether in the chaos of council meetings or in the intim..."*)
  - -> `[392]` (*Player_Romus: ""Together, we are more than the sum of our parts. We are ..."*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I offer you my heart, my loyalty, and my life, as we embark on this journey together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Player_Romus), `[376]` (Player_Romus), `[377]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I vow to honor the bond we have created with kindness and patience. I promise to be your steadfast rock through all the trials and triumphs that our days may bring.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Player_Romus), `[374]` (Player_Romus), `[378]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[375]` (*Player_Romus: ""I offer you my heart, my loyalty, and my life, as we emb..."*)
  - -> `[380]` (*Player_Romus: ""I pledge myself to you not as a king to his queen, but a..."*)
  - -> `[391]` (*Player_Romus: ""Together, let us usher in a new era for our kingdom, mar..."*)

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I vow that I shall listen to every word you say -- well, except for when you're reviewing logistics reports. Who listens to those?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[390]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[375]` (*Player_Romus: ""I offer you my heart, my loyalty, and my life, as we emb..."*)
  - -> `[380]` (*Player_Romus: ""I pledge myself to you not as a king to his queen, but a..."*)
  - -> `[391]` (*Player_Romus: ""Together, let us usher in a new era for our kingdom, mar..."*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Luce, the past few years I've spent with you have been the happiest in my entire life.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[370]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Player_Romus: ""As we defend our kingdom from our hordes of enemies, so ..."*)
  - -> `[376]` (*Player_Romus: ""I vow to honor the bond we have created with kindness an..."*)
  - -> `[379]` (*Player_Romus: ""Whether in the chaos of council meetings or in the intim..."*)
  - -> `[392]` (*Player_Romus: ""Together, we are more than the sum of our parts. We are ..."*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether in the chaos of council meetings or in the intimacy of moments alone, I feel I have truly found my equal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Player_Romus), `[374]` (Player_Romus), `[378]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[375]` (*Player_Romus: ""I offer you my heart, my loyalty, and my life, as we emb..."*)
  - -> `[380]` (*Player_Romus: ""I pledge myself to you not as a king to his queen, but a..."*)
  - -> `[391]` (*Player_Romus: ""Together, let us usher in a new era for our kingdom, mar..."*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pledge myself to you not as a king to his queen, but as a man eager to spend the rest of his life with the woman he loves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Player_Romus), `[376]` (Player_Romus), `[377]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Player_Romus: ""As the memory of my cherished Lena fades into the past, ..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Player_Romus: ""Together, we shall forge an unbreakable empire and crush..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Player_Romus: ""Let our marriage be the foundation upon which we build a..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Player_Romus: ""I vow that I shall listen to every word you say -- well,..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess Azaro, just as we have navigated the waters of international diplomacy, so too will we chart a course through holy matrimony.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[370]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Player_Romus: ""As we defend our kingdom from our hordes of enemies, so ..."*)
  - -> `[376]` (*Player_Romus: ""I vow to honor the bond we have created with kindness an..."*)
  - -> `[379]` (*Player_Romus: ""Whether in the chaos of council meetings or in the intim..."*)
  - -> `[392]` (*Player_Romus: ""Together, we are more than the sum of our parts. We are ..."*)
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, let us usher in a new era for our kingdom, marked by strength, resilience, and the legacy of the heirs that shall spring from your still-fertile loins.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Player_Romus), `[376]` (Player_Romus), `[377]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Together, we are more than the sum of our parts. We are bound by shared ambition and mutual respect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Player_Romus), `[374]` (Player_Romus), `[378]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[375]` (*Player_Romus: ""I offer you my heart, my loyalty, and my life, as we emb..."*)
  - -> `[380]` (*Player_Romus: ""I pledge myself to you not as a king to his queen, but a..."*)
  - -> `[391]` (*Player_Romus: ""Together, let us usher in a new era for our kingdom, mar..."*)

### Węzeł `[393]`
Mówca: **Narrator**
> "Sal cast his gaze over us both. He looked genuinely moved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Sal Ignacius: ""Thank you, Your Majesty. Would you like to do the same, ..."*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let our marriage be the foundation upon which we build a legacy of peace and prosperity, for our kingdom and for the generations that will follow.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[372]` (Player_Romus), `[376]` (Player_Romus), `[377]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[395]`
**[WYBÓR GRACZA: ""In this sacred covenant...""]** — Mówca: **Player_Romus**
> ""In this sacred covenant, love and duty converge to forge a legacy that transcends the temporal realm. Let it be known that in the heart of such a union, the virtues of loyalty, honor, and commitment are the true jewels that adorn the crown of matrimonial sanctity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Lucita Azaro: ""Perfect. And now for the oath.""*)

### Węzeł `[396]`
Mówca: **Narrator**
> "Lucita gestured to the royal orb she had placed on the desk. We both lay our hands on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Player_Romus: ""I, Romus Toras...""*)
  - -> `[397]` (*Player_Romus: ""If we're going to break tradition, I want to go all the ..."*)

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we're going to break tradition, I want to go all the way. I'll recite my own vows.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Lucita Azaro: ""As you wish. It's just us and the Lord anyway.""*)

### Węzeł `[398]`
Mówca: **Lucita Azaro**
> ""As you wish. It's just us and the Lord anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "Lucita looked at me. Her eyes shone brightly."*)

### Węzeł `[399]`
Mówca: **Lucita Azaro**
> ""Perfect. And now for the oath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Narrator: "Lucita gestured to the royal orb she had placed on the de..."*)

### Węzeł `[400]`
Mówca: **Narrator**
> "Sal nodded to Lucita, and she repeated the vow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "The Grand Wiseman placed the orb back on his desk. He too..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == false)"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Narrator: "Sal nodded to Lucita, and she repeated the vow."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "Lucita looked me in the eyes as she repeated the vow."*)

### Węzeł `[404]`
Mówca: **Narrator**
> "The Grand Wiseman placed the orb back on his desk. He took out a small pot containing a strong-smelling substance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Sal Ignacius: ""This oil is infused with the protection of our Lord and ..."*)

### Węzeł `[405]`
Mówca: **Sal Ignacius**
> ""Thank you, Your Majesty. Would you like to do the same, Duchess Azaro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Lucita was struggling to fight back tears. Eventually, sh..."*)

### Węzeł `[406]`
Mówca: **Narrator**
> "Lucita was struggling to fight back tears. Eventually, she brought herself to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Lucita Azaro: ""As the queen on a chessboard guards her king, so do I vo..."*)

### Węzeł `[407]`
Mówca: **Narrator**
> "Lucita looked me in the eyes as she repeated the vow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Narrator: "We took our hands off the orb. Next to it on the desk was..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == false)"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "Sal cast his gaze over us both. He looked genuinely moved."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Narrator: "Lucita was struggling to fight back tears. Eventually, sh..."*)

### Węzeł `[411]`
Mówca: **Narrator**
> "Lucita was struggling to fight back tears. Eventually, she brought herself to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Lucita Azaro: ""As the queen on a chessboard guards her king, so do I vo..."*)

### Węzeł `[412]`
Mówca: **Lucita Azaro**
> ""As the queen on a chessboard guards her king, so do I vow to protect you and this kingdom, Romus Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "The Grand Wiseman placed the orb back on his desk. He too..."*)

### Węzeł `[413]`
Mówca: **Lucita Azaro**
> ""As the queen on a chessboard guards her king, so do I vow to protect you and this kingdom, Romus Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Narrator: "We took our hands off the orb. Next to it on the desk was..."*)

### Węzeł `[414]`
Mówca: **Narrator**
> "We took our hands off the orb. Next to it on the desk was a small pot containing a strong-smelling substance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "Lucita took a quick look at the scroll."*)

### Węzeł `[415]`
Mówca: **Narrator**
> "Lucita took a quick look at the scroll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Lucita Azaro: ""This oil is infused with the protection of our Lord and ..."*)

### Węzeł `[416]`
Mówca: **Sal Ignacius**
> ""This oil is infused with the protection of our Lord and the strength and blessings of our ancestors. As you anoint one another, be reminded of your promises to serve each other, the Lord and this realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Narrator: "I dipped a finger into the oil and lightly touched Lucita..."*)

### Węzeł `[417]`
Mówca: **Lucita Azaro**
> ""This oil is infused with the protection of our Lord and the strength and blessings of our ancestors. As you anoint one another, be reminded of your promises to serve each other, the Lord and this realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Narrator: "I dipped a finger into the oil and lightly touched Lucita..."*)

### Węzeł `[418]`
Mówca: **Narrator**
> "I dipped a finger into the oil and lightly touched Lucita's forehead. She did the same to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_WearsLenasRing == true"*)

### Węzeł `[419]`
Mówca: **Narrator**
> "I dipped a finger into the oil and lightly touched Lucita's forehead. She did the same to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_WearsLenasRing == true"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_WearsLenasRing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_WearsLenasRing == true"*)
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_WearsLenasRing == true)"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_WearsLenasRing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_WearsLenasRing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Narrator: "I handed Sal Lena's old wedding ring. He produced another..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_WearsLenasRing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_WearsLenasRing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Narrator: "Sal reached into a drawer and produced two ancient-lookin..."*)

### Węzeł `[423]`
Mówca: **Narrator**
> "I handed Sal Lena's old wedding ring. He produced another, more ancient-looking one from a drawer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Sal Ignacius: ""This was salvaged from the Plavo crypt. I don't know who..."*)

### Węzeł `[424]`
Mówca: **Narrator**
> "Lucita took two ancient-looking rings off the desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Lucita Azaro: ""These are House Azaro rings. The Grand Wiseman must have..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_WearsLenasRing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_WearsLenasRing == true"*)
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_WearsLenasRing == true)"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_WearsLenasRing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_WearsLenasRing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Narrator: "I produced Lena's ring from my pocket. Lucita took anothe..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_WearsLenasRing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_WearsLenasRing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Narrator: "Lucita took two ancient-looking rings off the desk."*)

### Węzeł `[428]`
Mówca: **Narrator**
> "I produced Lena's ring from my pocket. Lucita took another, more ancient-looking one off the desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Lucita Azaro: ""This is a House Azaro ring. The Grand Wiseman must have ..."*)

### Węzeł `[429]`
Mówca: **Narrator**
> "Sal reached into a drawer and produced two ancient-looking rings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Sal Ignacius: ""These were salvaged from the Plavo crypt. I don't know w..."*)

### Węzeł `[430]`
Mówca: **Sal Ignacius**
> ""These were salvaged from the Plavo crypt. I don't know who they belonged to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Lucita Azaro: ""They belong to House Azaro, Grand Wiseman. That much is ..."*)

### Węzeł `[431]`
Mówca: **Lucita Azaro**
> ""It belongs to House Azaro, Grand Wiseman. That much is certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Player_Romus: ""It's beautiful. I'll wear it with pride.""*)
  - -> `[442]` (*Player_Romus: ""It'll have to do for now. We'll find a proper one later.""*)
  - -> `[445]` (*Player_Romus: ""A Toras king with an Azaro ring. I shall keep your house..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_WearsLenasRing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_WearsLenasRing == true"*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_WearsLenasRing == true)"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_WearsLenasRing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_WearsLenasRing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Player_Romus: ""I promised Vina my late wife's ring. But I want you to h..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_WearsLenasRing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_WearsLenasRing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Player_Romus: ""I still have Lena's wedding ring. Let me fetch it.""*)

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promised Vina my late wife's ring. But I want you to have it instead.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_WearsLenasRing"] == true` AND `IsCollectionItemShowing("CollectionItem_WeddingRing")`
- **Kontekst wejściowy (poprzednik):** `[295]` (Narrator), `[348]` (Narrator), `[349]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Her breath caught in her throat."*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true )"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Player_Romus: ""My daughter lost her right to it when she ran away.""*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter lost her right to it when she ran away.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Kontekst wejściowy (poprzednik):** `[306]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "I dashed up to my study and took Lena's ring from my desk..."*)

### Węzeł `[440]`
Mówca: **Sal Ignacius**
> ""This was salvaged from the Plavo crypt. I don't know who it belonged to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Lucita Azaro: ""It belongs to House Azaro, Grand Wiseman. That much is c..."*)

### Węzeł `[441]`
Mówca: **Lucita Azaro**
> ""They belong to House Azaro, Grand Wiseman. That much is certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Player_Romus: ""A Toras king with an Azaro ring. I shall keep your house..."*)
  - -> `[446]` (*Player_Romus: ""They'll have to do for now. We'll have proper ones made ..."*)
  - -> `[447]` (*Player_Romus: ""They're beautiful. I'll wear mine with pride.""*)

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It'll have to do for now. We'll find a proper one later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[431]` (Lucita Azaro), `[443]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Narrator: "As we exchanged rings, I looked deep into Lucita's eyes. ..."*)

### Węzeł `[443]`
Mówca: **Lucita Azaro**
> ""This is a House Azaro ring. The Grand Wiseman must have salvaged it from the Plavo Archsanctuary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Player_Romus: ""It's beautiful. I'll wear it with pride.""*)
  - -> `[442]` (*Player_Romus: ""It'll have to do for now. We'll find a proper one later.""*)
  - -> `[445]` (*Player_Romus: ""A Toras king with an Azaro ring. I shall keep your house..."*)

### Węzeł `[444]`
Mówca: **Lucita Azaro**
> ""These are House Azaro rings. The Grand Wiseman must have salvaged them from the Plavo Archsanctuary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Player_Romus: ""A Toras king with an Azaro ring. I shall keep your house..."*)
  - -> `[446]` (*Player_Romus: ""They'll have to do for now. We'll have proper ones made ..."*)
  - -> `[447]` (*Player_Romus: ""They're beautiful. I'll wear mine with pride.""*)

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A Toras king with an Azaro ring. I shall keep your house with me at all times.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[431]` (Lucita Azaro), `[441]` (Lucita Azaro), `[443]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Narrator: "As we exchanged rings, I looked deep into Lucita's eyes. ..."*)

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They'll have to do for now. We'll have proper ones made later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[441]` (Lucita Azaro), `[444]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Narrator: "As we exchanged rings, I looked deep into Lucita's eyes. ..."*)

### Węzeł `[447]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They're beautiful. I'll wear mine with pride.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[441]` (Lucita Azaro), `[444]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Narrator: "As we exchanged rings, I looked deep into Lucita's eyes. ..."*)

### Węzeł `[448]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's beautiful. I'll wear it with pride.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[431]` (Lucita Azaro), `[443]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Narrator: "As we exchanged rings, I looked deep into Lucita's eyes. ..."*)

### Węzeł `[449]`
Mówca: **Narrator**
> "As we exchanged rings, I looked deep into Lucita's eyes. They were like bottomless pools, concealing the future of the kingdom somewhere within their depths."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[450]`
Mówca: **Sal Ignacius**
> ""By the power vested in me, through the divine grace and the laws that govern our land, I now pronounce you husband and wife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Sal Ignacius: ""In accordance with tradition, you may now seal your vows..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == false)"*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Sal Ignacius: ""By the power vested in me, through the divine grace and ..."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Player_Romus: ""By the power vested in me, through the divine grace and ..."*)
  - -> `[456]` (*Player_Romus: ""As the sovereign of this realm, I name you as my queen. ..."*)
  - -> `[458]` (*Player_Romus: ""That's it? We're married now?""*)

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By the power vested in me, through the divine grace and the laws that govern our land, I now pronounce us husband and wife.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[449]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Lucita Azaro: ""You may kiss the bride.""*)

### Węzeł `[455]`
Mówca: **Sal Ignacius**
> ""In accordance with tradition, you may now seal your vows with a kiss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Narrator: "Our lips met. I sensed every molecule in her body vibrati..."*)

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As the sovereign of this realm, I name you as my queen. Now and forever more.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[449]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Lucita Azaro: ""You may kiss the bride.""*)

### Węzeł `[457]`
Mówca: **Narrator**
> "Our lips met. I sensed every molecule in her body vibrating with happiness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Narrator: "Once again, I was a married man."*)

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? We're married now?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Sal_Arrested"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[449]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Lucita Azaro: ""That's it.""*)

### Węzeł `[459]`
Mówca: **Lucita Azaro**
> ""That's it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Lucita Azaro: ""You may kiss the bride.""*)

### Węzeł `[460]`
Mówca: **Lucita Azaro**
> ""You may kiss the bride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Narrator: "Our lips met. I sensed every molecule in her body vibrati..."*)

### Węzeł `[461]`
Mówca: **Narrator**
> "Once again, I was a married man."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Narrator: "But there was still one more wedding to go."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "This time, by choice."*)

### Węzeł `[465]`
Mówca: **Narrator**
> "But there was still one more wedding to go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married = true; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[466]`
Mówca: **Narrator**
> "This time, by choice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married = true; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married = true;
RiziaDLCSupport.Journal_Turn08_Lucita_Married = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_Married"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_Lucita_Married"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == ..."*)
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality =..."*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Narrator: "I pushed open the door to my quarters to find Pabel, busy..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Narrator: "I pushed open the door to my quarters."*)

### Węzeł `[471]`
Mówca: **Narrator**
> "I pushed open the door to my quarters to find Pabel, busy hanging up an outfit on my valet stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Player_Romus: ""It's late. Shouldn't you have done that already?""*)
  - -> `[474]` (*Player_Romus: ""Pabel. You're a sight for sore eyes.""*)
  - -> `[475]` (*Player_Romus: ""Ooh. What am I wearing tomorrow?""*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged = false;
RiziaDLC.Pabel_Gone = true; RiziaDLC.Relations_Pabel_Together = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_Engaged"] = false;
Variable["RiziaDLC.Pabel_Gone"] = true;
Variable["RiziaDLC.Relations_Pabel_Together"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "(RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.P..."*)

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's late. Shouldn't you have done that already?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[471]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel. You're a sight for sore eyes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[471]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Pabel Adria: ""As are you, Your Majesty.""*)

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ooh. What am I wearing tomorrow?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[471]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfV..."*)

### Węzeł `[476]`
Mówca: **Pabel Adria**
> ""I didn't get the chance. There was a snag with the seating arrangements for tomorrow. Some fool from the wedding committee placed the Qinali and Free Cities delegations next to each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Pabel Adria: ""Besides... I was rather hoping our paths would cross.""*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_WeddingCommittee == true"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Pabel Adria: ""I didn't get the chance. Some fool gardening assistant p..."*)

### Węzeł `[480]`
Mówca: **Pabel Adria**
> ""I didn't get the chance. Some fool gardening assistant poured leftover wine on the begonias. I just barely resuscitated them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Pabel Adria: ""Besides... I was rather hoping our paths would cross.""*)

### Węzeł `[481]`
Mówca: **Pabel Adria**
> ""Besides... I was rather hoping our paths would cross.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Narrator: "He stepped closer to me, and we embraced."*)

### Węzeł `[482]`
Mówca: **Pabel Adria**
> ""As are you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Narrator: "He stepped closer to me, and we embraced."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfV..."*)
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessO..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Pabel Adria: ""The royal blue tuxedo from Thornfield & Marchmont in Bro..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Pabel Adria: ""Your charcoal grey suit. I know you're fond of it.""*)

### Węzeł `[486]`
Mówca: **Pabel Adria**
> ""The royal blue tuxedo from Thornfield & Marchmont in Bronaz. Don't you remember getting fitted for it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Narrator: "He stepped closer to me, and we embraced."*)

### Węzeł `[487]`
Mówca: **Pabel Adria**
> ""Your charcoal grey suit. I know you're fond of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Narrator: "He stepped closer to me, and we embraced."*)

### Węzeł `[488]`
Mówca: **Narrator**
> "He stepped closer to me, and we embraced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "Since I'd done away with Rizia's anti-homosexuality laws,..."*)

### Węzeł `[489]`
Mówca: **Narrator**
> "Since I'd done away with Rizia's anti-homosexuality laws, we had started to be less secretive about our meetings, though we still had not mentioned our relationship to anyone in the palace or beyond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Pabel Adria: ""I can't believe Princess Vina is getting married tomorrow.""*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FullCouncilor == true"*)

### Węzeł `[493]`
Mówca: **Pabel Adria**
> ""I can't believe Princess Vina is getting married tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Pabel Adria: ""It feels like just yesterday that the kingdom was celebr..."*)

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still miss her. But I have to move on.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[506]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Pabel Adria: ""You're doing a fine job.""*)

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Poor Lena. She never got to see her daughter become a woman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[506]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Pabel Adria: ""She lives on in Her Highness. And in all of her descende..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Player_Romus: ""I still miss her. But I have to move on.""*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Player_Romus: ""We argued over every aspect of those celebrations. It wa..."*)

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And me? How did I look?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[506]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Pabel Adria: ""Like a handsome prince.""*)

### Węzeł `[500]`
Mówca: **Pabel Adria**
> ""Like a handsome prince.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Narrator: "He pulled back from me, his arms still encircling my waist."*)

### Węzeł `[501]`
Mówca: **Pabel Adria**
> ""She lives on in Her Highness. And in all of her descendents, whoever they may be...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Narrator: "He pulled back from me, his arms still encircling my waist."*)

### Węzeł `[502]`
Mówca: **Narrator**
> "Pabel laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Pabel Adria: ""You're too kind. She was beautiful in a way even I could..."*)

### Węzeł `[503]`
Mówca: **Pabel Adria**
> ""You're too kind. She was beautiful in a way even I could appreciate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Narrator: "He pulled back from me, his arms still encircling my waist."*)

### Węzeł `[504]`
Mówca: **Pabel Adria**
> ""You're doing a fine job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Narrator: "He pulled back from me, his arms still encircling my waist."*)

### Węzeł `[505]`
Mówca: **Pabel Adria**
> ""Vina Toras, Duchess of Monqiz. The time has finally come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Pabel Adria: ""It feels like just yesterday that the kingdom was celebr..."*)

### Węzeł `[506]`
Mówca: **Pabel Adria**
> ""It feels like just yesterday that the kingdom was celebrating her birth. Her mother looked positively radiant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[507]` (*Player_Romus: ""Believe me, Princess Lena of Rumburg couldn't hold a can..."*)
  - -> `[495]` (*Player_Romus: ""Poor Lena. She never got to see her daughter become a wo..."*)
  - -> `[499]` (*Player_Romus: ""And me? How did I look?""*)

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Believe me, Princess Lena of Rumburg couldn't hold a candle to Mr. Pabel Adria.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[506]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Narrator: "Pabel laughed."*)

### Węzeł `[508]`
Mówca: **Pabel Adria**
> ""It seems as though Princess Vina has come into her own as a councilor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Pabel Adria: ""It feels like just yesterday that the kingdom was celebr..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FullCouncilor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FullCouncilor == true"*)
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FullCouncilor == true)"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FullCouncilor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FullCouncilor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Pabel Adria: ""It seems as though Princess Vina has come into her own a..."*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FullCouncilor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FullCouncilor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We argued over every aspect of those celebrations. It was hell.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Lucita Azaro: ""From the outside, it was a fairy tale.""*)

### Węzeł `[513]`
Mówca: **Lucita Azaro**
> ""From the outside, it was a fairy tale.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "We had come to the clearing in the middle of the gardens...."*)

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We argued over every aspect of those celebrations. It was hell.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[506]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Pabel Adria: ""I remember. Your love for your daughter was the only thi..."*)

### Węzeł `[515]`
Mówca: **Pabel Adria**
> ""I remember. Your love for your daughter was the only thing you agreed on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Narrator: "He pulled back from me, his arms still encircling my waist."*)

### Węzeł `[516]`
Mówca: **Narrator**
> "He pulled back from me, his arms still encircling my waist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Pabel Adria: ""I know that decriminalizing homosexuality came at a grea..."*)

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know, with Vina changing her last name, the reputation of House Toras really doesn't matter anymore.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_KeepsLastName"] == false  and  (Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true)`
- **Kontekst wejściowy (poprzednik):** `[538]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Pabel Adria: ""Even so, what about my reputation?""*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_KeepsLastName == false && (RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_KeepsLastName == false && (RiziaDLC.Vina_Ma..."*)
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_KeepsLastName == false && (RiziaDLC.Vina_..."*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_KeepsLastName == false && (RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_KeepsLastName"] == false  and  (Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Player_Romus: ""You know, with Vina changing her last name, the reputati..."*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_KeepsLastName == false && (RiziaDLC.Vina_MarriageDecision_Axel == true || RiziaDLC.Vina_MarriageDecision_Manus == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_KeepsLastName"] == false  and  (Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true  or  Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[521]`
Mówca: **Pabel Adria**
> ""Even so, what about my reputation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "He dropped his arms to his sides. His fists curled in fru..."*)

### Węzeł `[522]`
Mówca: **Narrator**
> "He dropped his arms to his sides. His fists curled in frustration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Pabel Adria: ""You have a modicum of protection as the king. But the mo..."*)

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina's a hostage. Hugo and Rico's side of the family will probably inherit the throne anyway. It doesn't matter what I do.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[538]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Pabel Adria: ""It matters to me.""*)

### Węzeł `[524]`
Mówca: **Pabel Adria**
> ""It matters to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "He dropped his arms to his sides. His fists curled in fru..."*)

### Węzeł `[525]`
Mówca: **Pabel Adria**
> ""You have a modicum of protection as the king. But the moment the truth gets out about us, I'll be torn apart from all sides.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Pabel Adria: ""And if something happens to you, or things end badly bet..."*)

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let the papers say what they will. I'm not afraid for my reputation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[538]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Pabel Adria: ""I'm afraid for mine.""*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.LeaningValue_Democratic > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Leanin..."*)
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Lean..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.LeaningValue_Democratic > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Player_Romus: ""Titles mean nothing, Pabel. I see you as a friend and an..."*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.LeaningValue_Democratic > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.LeaningValue_Democratic"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[530]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titles mean nothing, Pabel. I see you as a friend and an equal, regardless of our stations.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0  or  Variable["RiziaDLC.LeaningValue_Democratic"] > 0`
- **Kontekst wejściowy (poprzednik):** `[538]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Pabel Adria: ""But the rest of the kingdom doesn't.""*)

### Węzeł `[531]`
Mówca: **Pabel Adria**
> ""I'm afraid for mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "He dropped his arms to his sides. His fists curled in fru..."*)

### Węzeł `[532]`
Mówca: **Pabel Adria**
> ""But the rest of the kingdom doesn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "He dropped his arms to his sides. His fists curled in fru..."*)

### Węzeł `[533]`
Mówca: **Pabel Adria**
> ""I know that decriminalizing homosexuality came at a great cost to your popularity. But I'm so glad you did it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Player_Romus: ""I might no longer be breaking the law, but I'm still a v..."*)
  - -> `[534]` (*Player_Romus: ""It's just a shame that you and I can't enjoy that freedo..."*)
  - -> `[535]` (*Player_Romus: ""It might be legal for us to see each other, but I still ..."*)
  - -> `[542]` (*Player_Romus: ""My popularity with *Rizians*. The Derdians love me now.""*)

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's just a shame that you and I can't enjoy that freedom for ourselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[533]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Narrator: "He shook his head."*)

### Węzeł `[535]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It might be legal for us to see each other, but I still rather enjoy the secrecy of it all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[533]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Pabel Adria: ""It's not only enjoyable. It's necessary.""*)

### Węzeł `[536]`
Mówca: **Pabel Adria**
> ""It's not only enjoyable. It's necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Pabel Adria: ""A king openly dating a man is cause enough for scandal, ..."*)

### Węzeł `[537]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Pabel Adria: ""A king openly dating a man is cause enough for scandal, ..."*)

### Węzeł `[538]`
Mówca: **Pabel Adria**
> ""A king openly dating a man is cause enough for scandal, but a commoner? And a member of his household staff, at that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player_Romus: ""Let the papers say what they will. I'm not afraid for my..."*)
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_KeepsLastName == false && (RiziaDLC.Vina_Ma..."*)
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[546]` (*Player_Romus: ""You grew up in this palace. You hardly count as a common..."*)
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0 || RiziaDLC.Leanin..."*)

### Węzeł `[539]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I might no longer be breaking the law, but I'm still a very bad boy who needs to be punished.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[533]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Narrator: "A glint appeared in his eye. He shook his head."*)

### Węzeł `[540]`
Mówca: **Pabel Adria**
> ""Easy there, Your Majesty. We can't throw all caution to the wind yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Pabel Adria: ""A king openly dating a man is cause enough for scandal, ..."*)

### Węzeł `[541]`
Mówca: **Narrator**
> "A glint appeared in his eye. He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Pabel Adria: ""Easy there, Your Majesty. We can't throw all caution to ..."*)

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My popularity with *Rizians*. The Derdians love me now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[533]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Pabel Adria: ""So do I.""*)

### Węzeł `[543]`
Mówca: **Pabel Adria**
> ""So do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Narrator: "He sighed."*)

### Węzeł `[544]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Pabel Adria: ""But I'm still dreading what will happen if the rumors ab..."*)

### Węzeł `[545]`
Mówca: **Pabel Adria**
> ""But I'm still dreading what will happen if the rumors about us ever spread beyond palace walls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Pabel Adria: ""A king openly dating a man is cause enough for scandal, ..."*)

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You grew up in this palace. You hardly count as a commoner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[538]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Pabel Adria: ""My family's legacy is tending to other people's land. We..."*)

### Węzeł `[547]`
Mówca: **Pabel Adria**
> ""My family's legacy is tending to other people's land. We have none of our own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "He dropped his arms to his sides. His fists curled in fru..."*)

### Węzeł `[548]`
Mówca: **Pabel Adria**
> ""And if something happens to you, or things end badly between us? Rom, I'll have nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Player_Romus: ""What if I were to confer noble status upon you?""*)
  - -> `[551]` (*Player_Romus: ""Then we'll continue in secret. As we always have.""*)
  - -> `[550]` (*Player_Romus: ""It will never end badly between us.""*)
  - -> `[549]` (*Player_Romus: ""Nothing will ever happen to me. I'm basically immortal.""*)

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing will ever happen to me. I'm basically immortal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[548]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Narrator: "He laughed and kissed me on the forehead."*)

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It will never end badly between us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[548]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Narrator: "He laughed and kissed me on the forehead."*)

### Węzeł `[551]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then we'll continue in secret. As we always have.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[548]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Narrator: "He nodded."*)

### Węzeł `[552]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Pabel Adria: ""Bi mare volu, un oxit solu.""*)

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if I were to confer noble status upon you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[548]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Narrator: "He blinked in confusion."*)

### Węzeł `[554]`
Mówca: **Narrator**
> "He blinked in confusion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Pabel Adria: ""I beg your pardon?""*)

### Węzeł `[555]`
Mówca: **Pabel Adria**
> ""I beg your pardon?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Player_Romus: ""I grant you a piece of land and make you a lord. Like my..."*)
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[562]` (*Player_Romus: ""*If* anything were to disrupt our relationship, you'd st..."*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == true"*)
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)"*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Player_Romus: ""It's strictly a symbolic title now that the electoral re..."*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Player_Romus: ""You'd have to take on one or two extra responsibilities...."*)

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's strictly a symbolic title now that the electoral reforms have been enacted. But you wouldn't be a commoner anymore.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true`
- **Kontekst wejściowy (poprzednik):** `[555]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Narrator: "Pabel mulled it over for a second."*)

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I grant you a piece of land and make you a lord. Like my mother's family, or Daria de Rava.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Narrator: "Pabel mulled it over for a second."*)

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You'd have to take on one or two extra responsibilities. But you wouldn't be a commoner anymore.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[555]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Narrator: "Pabel mulled it over for a second."*)

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*If* anything were to disrupt our relationship, you'd still have an estate to fall back on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[555]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Narrator: "Pabel mulled it over for a second."*)

### Węzeł `[563]`
Mówca: **Narrator**
> "Pabel mulled it over for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Pabel Adria: ""And you can just... do that?""*)

### Węzeł `[564]`
Mówca: **Pabel Adria**
> ""And you can just... do that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == false"*)
  - -> `[566]` (*Player_Romus: ""Actually, no. It's too difficult.""*)

### Węzeł `[565]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo would have to make it official. Shall we go fetch him now?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[564]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Narrator: "He gave me an excited hug."*)

### Węzeł `[566]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, no. It's too difficult.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[564]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Narrator: "Pabel lowered his head."*)

### Węzeł `[567]`
Mówca: **Narrator**
> "Pabel lowered his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Pabel Adria: ""Then secrecy it is.""*)

### Węzeł `[568]`
Mówca: **Pabel Adria**
> ""Then secrecy it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfV..."*)

### Węzeł `[569]`
Mówca: **Narrator**
> "He laughed and kissed me on the forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Pabel Adria: ""Romus the Romantic.""*)

### Węzeł `[570]`
Mówca: **Pabel Adria**
> ""Romus the Romantic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfV..."*)

### Węzeł `[571]`
Mówca: **Narrator**
> "He laughed and kissed me on the forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Pabel Adria: ""If only.""*)

### Węzeł `[572]`
Mówca: **Pabel Adria**
> ""If only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfV..."*)

### Węzeł `[573]`
Mówca: **Pabel Adria**
> ""Bi mare volu, un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfV..."*)

### Węzeł `[574]`
Mówca: **Pabel Adria**
> ""I'll let you rest. Big day tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Narrator: "He gave me a quick kiss and walked out."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfV..."*)
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessO..."*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Pabel Adria: ""I'll let you rest. Big day tomorrow.""*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Pabel Adria: ""I'll let you rest.""*)

### Węzeł `[578]`
Mówca: **Pabel Adria**
> ""I'll let you rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Narrator: "He gave me a quick kiss and walked out."*)

### Węzeł `[579]`
Mówca: **Narrator**
> "He gave me an excited hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Pabel Adria: ""I'll do it. I'm your butler, after all.""*)

### Węzeł `[580]`
Mówca: **Pabel Adria**
> ""I'll do it. I'm your butler, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Narrator: "Not long afterwards, Hugo, Pabel and I convened in the Gr..."*)

### Węzeł `[581]`
Mówca: **Narrator**
> "Not long afterwards, Hugo, Pabel and I convened in the Grand Vizier's chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[582]`
Mówca: **Narrator**
> "My uncle uneasily glanced from one of us to another."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Hugo Toras: ""A head butler, joining the gentry. I must say I've never..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Narrator: "My uncle uneasily glanced from one of us to another."*)

### Węzeł `[584]`
Mówca: **Hugo Toras**
> ""A head butler, joining the gentry. I must say I've never heard of such a thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_BrokeTradition > 3"*)
  - -> `[589]` (*Player_Romus: ""Pabel has spent his entire life in service to the Royal ..."*)
  - -> `[590]` (*Player_Romus: ""He's not only my butler, he's my close friend.""*)
  - -> `[591]` (*Player_Romus: ""It's a symbolic gesture. It won't change anything.""*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_BrokeTradition > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_BrokeTradition > 3"*)
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_BrokeTradition > 3)"*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_BrokeTradition > 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Player_Romus: ""You know I'm not one to play by the rules, Hugo.""*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_BrokeTradition > 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 3) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know I'm not one to play by the rules, Hugo.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] > 3`
- **Kontekst wejściowy (poprzednik):** `[584]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Hugo Toras: ""So I have gathered.""*)

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel has spent his entire life in service to the Royal Family. He deserves a reward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[584]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Hugo Toras: ""His loyalty is undisputed, it's true.""*)

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's not only my butler, he's my close friend.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[584]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Narrator: "He eyed us both closely."*)

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a symbolic gesture. It won't change anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[584]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Hugo Toras: ""It sets a dangerous precedent. We can't have every scull..."*)

### Węzeł `[592]`
Mówca: **Hugo Toras**
> ""So I have gathered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "He turned away from us and pulled out an enormous book of..."*)

### Węzeł `[593]`
Mówca: **Hugo Toras**
> ""His loyalty is undisputed, it's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "He turned away from us and pulled out an enormous book of..."*)

### Węzeł `[594]`
Mówca: **Narrator**
> "He eyed us both closely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Hugo Toras: ""Yes. So I gather.""*)

### Węzeł `[595]`
Mówca: **Hugo Toras**
> ""Yes. So I gather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "He turned away from us and pulled out an enormous book of..."*)

### Węzeł `[596]`
Mówca: **Hugo Toras**
> ""It sets a dangerous precedent. We can't have every scullery maid in the palace clamoring to be a lady.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Hugo Toras: ""But your many years of service to this household do dese..."*)

### Węzeł `[597]`
Mówca: **Narrator**
> "He turned to Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Hugo Toras: ""I assume His Majesty has told you of the unfair taxes th..."*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true"*)
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true )"*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_LandOwnersTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Narrator: "He turned to Pabel."*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_LandOwnersTax == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_LandOwnersTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true"*)

### Węzeł `[601]`
Mówca: **Hugo Toras**
> ""I assume His Majesty has told you of the unfair taxes that will be levied upon you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Pabel Adria: ""I will pay what I must, Your Grace.""*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true"*)
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true)"*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Narrator: "He turned to Pabel."*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Narrator: "He turned to Pabel."*)

### Węzeł `[605]`
Mówca: **Narrator**
> "He turned away from us and pulled out an enormous book of records. After rifling though it for a while, he put his finger on one of the entries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Hugo Toras: ""The Veridian estate on the outskirts of Malcos. It's lai..."*)

### Węzeł `[606]`
Mówca: **Hugo Toras**
> ""The Veridian estate on the outskirts of Malcos. It's lain abandoned for years after an unresolved inheritance dispute, but its famous orchards are as fecund as ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_LandOwnersTax == true"*)

### Węzeł `[607]`
Mówca: **Narrator**
> "He turned to Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Hugo Toras: ""I will warn you not to take on any tenants. You'll never..."*)

### Węzeł `[608]`
Mówca: **Hugo Toras**
> ""I will warn you not to take on any tenants. You'll never be able to get rid of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Pabel Adria: ""Your advice has been noted, Your Grace.""*)

### Węzeł `[609]`
Mówca: **Narrator**
> "He turned to Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Hugo Toras: ""With your title comes great responsibility. I hope you a..."*)

### Węzeł `[610]`
Mówca: **Hugo Toras**
> ""With your title comes great responsibility. I hope you are ready for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Pabel Adria: ""I served two royal households, Your Grace. I am ready.""*)

### Węzeł `[611]`
Mówca: **Pabel Adria**
> ""I served two royal households, Your Grace. I am ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Narrator: "Hugo busied himself at his desk for a few minutes, then h..."*)

### Węzeł `[612]`
Mówca: **Pabel Adria**
> ""Your advice has been noted, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Narrator: "Hugo busied himself at his desk for a few minutes, then h..."*)

### Węzeł `[613]`
Mówca: **Pabel Adria**
> ""I will pay what I must, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Narrator: "Hugo busied himself at his desk for a few minutes, then h..."*)

### Węzeł `[614]`
Mówca: **Narrator**
> "Hugo busied himself at his desk for a few minutes, then held up a piece of parchment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Hugo Toras: ""Here is the letters patent. It needs your signature and ..."*)

### Węzeł `[615]`
Mówca: **Hugo Toras**
> ""Here is the letters patent. It needs your signature and the King's seal, and then the deed is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Player_Romus_Italic: "Put your seal on the document."*)

### Węzeł `[616]`
**[WYBÓR GRACZA: "Put your seal on the document."]** — Mówca: **Player_Romus_Italic**
> "I heated a stick of wax, dripped it onto the document and stamped it with my seal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[615]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Narrator: "Pabel added his signature. Hugo nodded solemnly."*)

### Węzeł `[617]`
Mówca: **Narrator**
> "Pabel added his signature. Hugo nodded solemnly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[647]` (*Player_Romus: ""May this mark the beginning of a new era, where titles a..."*)
  - -> `[618]` (*Player_Romus: ""I hereby proclaim you Lord Pabel Adria of Veridian. May ..."*)
  - -> `[621]` (*Player_Romus: ""As you have served me as a butler, so now do I entrust y..."*)

### Węzeł `[618]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hereby proclaim you Lord Pabel Adria of Veridian. May your actions reflect the honor of your title.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[617]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Narrator: "Pabel grinned from ear to ear."*)

### Węzeł `[619]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Pabel Adria: ""They will, Your Majesty.""*)

### Węzeł `[620]`
Mówca: **Pabel Adria**
> ""They will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Narrator: "Hugo shook Pabel's hand and handed him the document."*)

### Węzeł `[621]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you have served me as a butler, so now do I entrust you with the care of your own domain. May you tend to it as thoughtfully as you tend to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[617]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Narrator: "Pabel grinned from ear to ear."*)

### Węzeł `[622]`
Mówca: **Narrator**
> "He gave me a quick kiss and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)

### Węzeł `[623]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_SleepsInBed == true)"*)

### Węzeł `[624]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Narrator: "Bruno was on my bed yet again. He whimpered disappointedl..."*)

### Węzeł `[625]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_SleepsInBed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[626]`
Mówca: **Narrator**
> "Bruno was on my bed yet again. He whimpered disappointedly as Pabel left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Player_Romus_Italic: "Pet him."*)
  - -> `[632]` (*Player_Romus: ""Shhh. Bad dog.""*)

### Węzeł `[627]`
Mówca: **Narrator**
> "From his corner, Bruno whimpered disappointedly as Pabel left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Player_Romus_Italic: "Pet him."*)
  - -> `[632]` (*Player_Romus: ""Shhh. Bad dog.""*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Narrator: "From his corner, Bruno whimpered disappointedly as Pabel ..."*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)

### Węzeł `[631]`
**[WYBÓR GRACZA: "Pet him."]** — Mówca: **Player_Romus_Italic**
> "I gave him a reassuring pat on the head before beginning my bedtime routine."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[626]` (Narrator), `[627]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Shhh. Bad dog.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[626]` (Narrator), `[627]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Narrator: "Bruno quieted down and rolled over on his side as I began..."*)

### Węzeł `[633]`
Mówca: **Narrator**
> "Bruno quieted down and rolled over on his side as I began my bedtime routine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)

### Węzeł `[634]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Pabel Adria: ""I will, Your Majesty.""*)

### Węzeł `[635]`
Mówca: **Pabel Adria**
> ""I will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Narrator: "Hugo shook Pabel's hand and handed him the document."*)

### Węzeł `[636]`
Mówca: **Narrator**
> "Hugo shook Pabel's hand and handed him the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfV..."*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord = true;
RiziaDLCSupport.Journal_Turn08_Pabel_Lord = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pabel_Lord"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_Pabel_Lord"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[877]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Others_PabelAdria_Lord");"*)

### Węzeł `[638]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_WeddingCommittee == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn08_WeddingCommittee == true"*)
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn08_WeddingCommittee == true)"*)

### Węzeł `[639]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn08_WeddingCommittee == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn08_WeddingCommittee"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Pabel Adria: ""I didn't get the chance. There was a snag with the seati..."*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn08_WeddingCommittee == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn08_WeddingCommittee"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Pabel Adria: ""I didn't get the chance. There was a snag with the seati..."*)

### Węzeł `[641]`
Mówca: **Pabel Adria**
> ""I didn't get the chance. There was a snag with the seating arrangements. Some fool from the wedding committee placed the Qinali and Free Cities delegations next to each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Pabel Adria: ""Besides... I was rather hoping our paths would cross.""*)

### Węzeł `[642]`
Mówca: **Hugo Toras**
> ""But your many years of service to this household do deserve acknowledgement, Mr. Adria.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Narrator: "He turned away from us and pulled out an enormous book of..."*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfV..."*)
  - -> `[645]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessO..."*)

### Węzeł `[644]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Hugo Toras: ""Don't let it get to your head. We need all your focus on..."*)

### Węzeł `[645]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true || RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true  or  Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Hugo Toras: ""Congratulations, Lord Adria. Don't let it get to your he..."*)

### Węzeł `[646]`
Mówca: **Hugo Toras**
> ""Don't let it get to your head. We need all your focus on coordinating tomorrow's festivities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Player_Romus: ""Nonsense. Lord Adria will accompany me to the ceremony.""*)
  - -> `[657]` (*Player_Romus: ""It's true, Pabel. You've got to hold on to your head but..."*)

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May this mark the beginning of a new era, where titles are not inherited but earned by merit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[617]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Narrator: "Hugo coughed. Pabel, grinning from ear to ear, ignored him."*)

### Węzeł `[648]`
Mówca: **Narrator**
> "Hugo coughed. Pabel, grinning from ear to ear, ignored him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Pabel Adria: ""A new era indeed, Your Majesty.""*)

### Węzeł `[649]`
Mówca: **Pabel Adria**
> ""A new era indeed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Narrator: "Hugo shook Pabel's hand and handed him the document."*)

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The institution of nobility is a relic of a bygone era, one that perpetuates inequality and stifles the true potential of our people. But enjoy the fruit trees.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Kontekst wejściowy (poprzednik):** `[617]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Narrator: "Hugo coughed. Pabel, grinning from ear to ear, ignored him."*)

### Węzeł `[651]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[653]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 2)"*)

### Węzeł `[652]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Player_Romus: ""The institution of nobility is a relic of a bygone era, ..."*)

### Węzeł `[653]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[654]`
Mówca: **Narrator**
> "Hugo coughed. Pabel, grinning from ear to ear, ignored him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Pabel Adria: ""I will, Your Majesty.""*)

### Węzeł `[655]`
Mówca: **Pabel Adria**
> ""I will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Narrator: "Hugo shook Pabel's hand and handed him the document."*)

### Węzeł `[656]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. Lord Adria will accompany me to the ceremony.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[646]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Narrator: "Pabel and Hugo appeared equally surprised."*)

### Węzeł `[657]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's true, Pabel. You've got to hold on to your head butler duties, at least until a replacement is found.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[646]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Pabel Adria: ""Of course, Your Majesty. I'll make sure tomorrow goes of..."*)

### Węzeł `[658]`
Mówca: **Hugo Toras**
> ""Congratulations, Lord Adria. Don't let it get to your head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Pabel Adria: ""Absolutely not, Your Grace.""*)

### Węzeł `[659]`
Mówca: **Narrator**
> "Pabel and Hugo appeared equally surprised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Pabel Adria: ""Why... it would be an honor, Your Majesty.""*)

### Węzeł `[660]`
Mówca: **Pabel Adria**
> ""Why... it would be an honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_WeddingDate = true; RiziaDLCSupport.Journa..."*)

### Węzeł `[661]`
Mówca: **Pabel Adria**
> ""Of course, Your Majesty. I'll make sure tomorrow goes off without a hitch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord = true; RiziaDLCSupport.Journal_Turn0..."*)

### Węzeł `[662]`
Mówca: **Narrator**
> "My uncle stared in open amazement as we left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Narrator: "I could still feel his eyes on us as we made our way back..."*)

### Węzeł `[663]`
Mówca: **Narrator**
> "I could still feel his eyes on us as we made our way back down the hall and upstairs to my quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_WeddingDate = true;
RiziaDLCSupport.Journal_Turn08_Pabel_WeddingDate = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pabel_WeddingDate"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_Pabel_WeddingDate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord = true; RiziaDLCSupport.Journal_Turn0..."*)

### Węzeł `[665]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_DuchessOfValenqiris == true)"*)

### Węzeł `[666]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Pabel Adria: ""Vina Toras, Duchess of Monqiz. The time has finally come.""*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Pabel Adria: ""I can't believe it's been a year since Her Highness was ..."*)

### Węzeł `[668]`
Mówca: **Pabel Adria**
> ""I can't believe it's been a year since Her Highness was taken hostage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Player_Romus: ""We're going to get her back. I can feel it in my bones.""*)
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 0"*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Player_Romus: ""When we win this war, Pales will pay for what they did t..."*)

### Węzeł `[671]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Player_Romus: ""The Azaros seem to have given up hope of finding her. Pe..."*)

### Węzeł `[672]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're going to get her back. I can feel it in my bones.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[668]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Pabel Adria: ""As long as she's still alive, there's hope.""*)

### Węzeł `[673]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When we win this war, Pales will pay for what they did to her.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Kontekst wejściowy (poprzednik):** `[668]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Pabel Adria: ""That's the spirit.""*)

### Węzeł `[674]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Azaros seem to have given up hope of finding her. Perhaps I should as well.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[668]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Pabel Adria: ""Don't be ridiculous. There's always hope.""*)

### Węzeł `[675]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to remind me. I've been counting the days.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina"] > 0`
- **Kontekst wejściowy (poprzednik):** `[668]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Pabel Adria: ""I'm sure you have. I'm sorry.""*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 0"*)
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina > 0)"*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Player_Romus: ""You don't have to remind me. I've been counting the days.""*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Player_Romus: ""That's what she gets for being such a brat to me.""*)

### Węzeł `[679]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's what she gets for being such a brat to me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Vina"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[668]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Narrator: "Pabel frowned."*)

### Węzeł `[680]`
Mówca: **Narrator**
> "Pabel frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Pabel Adria: ""I'm sure you don't mean that.""*)

### Węzeł `[681]`
Mówca: **Pabel Adria**
> ""I'm sure you don't mean that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Pabel Adria: ""It feels like just yesterday that the kingdom was celebr..."*)

### Węzeł `[682]`
Mówca: **Pabel Adria**
> ""I'm sure you have. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Pabel Adria: ""It feels like just yesterday that the kingdom was celebr..."*)

### Węzeł `[683]`
Mówca: **Pabel Adria**
> ""Don't be ridiculous. There's always hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Pabel Adria: ""It feels like just yesterday that the kingdom was celebr..."*)

### Węzeł `[684]`
Mówca: **Pabel Adria**
> ""That's the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Pabel Adria: ""It feels like just yesterday that the kingdom was celebr..."*)

### Węzeł `[685]`
Mówca: **Pabel Adria**
> ""As long as she's still alive, there's hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Pabel Adria: ""It feels like just yesterday that the kingdom was celebr..."*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Player_Romus: ""Vina's a hostage. Hugo and Rico's side of the family wil..."*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[689]`
Mówca: **Pabel Adria**
> ""Absolutely not, Your Grace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord = true; RiziaDLCSupport.Journal_Turn0..."*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "I thought how, if Vina died in Pales, I would be left wit..."*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Limp == true"*)
  - -> `[70]` (*Player_Romus_Italic: "Stay standing."*)
  - -> `[76]` (*Player_Romus_Italic: "Sit down."*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_DuchessOfValenqiris == true)"*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn08_RH_RoyalWedding_VinaDuchess =..."*)

### Węzeł `[695]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Lucita Azaro: ""I can't believe it's been a year since Her Highness was ..."*)

### Węzeł `[696]`
Mówca: **Lucita Azaro**
> ""I can't believe it's been a year since Her Highness was taken hostage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Narrator: "She sighed unhappily."*)

### Węzeł `[697]`
Mówca: **Narrator**
> "She sighed unhappily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Lucita Azaro: ""I can't help but feel personally responsible that she ha..."*)

### Węzeł `[698]`
Mówca: **Lucita Azaro**
> ""I can't help but feel personally responsible that she hasn't made it home yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[703]` (*Player_Romus: ""You don't need to tell me how long it's been. I've been ..."*)
  - -> `[705]` (*Player_Romus: ""No, it's my fault for sending her there in the first pla..."*)

### Węzeł `[699]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When we win this war, Pales will pay for what they did to her.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Kontekst wejściowy (poprzednik):** `[698]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Lucita Azaro: ""I will make sure of it.""*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Player_Romus: ""When we win this war, Pales will pay for what they did t..."*)

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Player_Romus: ""Don't blame yourself. Blame your goddamn fool of a father.""*)

### Węzeł `[703]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to tell me how long it's been. I've been counting every single day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[698]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Lucita Azaro: ""Of course you have. I'm sorry.""*)

### Węzeł `[704]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't blame yourself. Blame your goddamn fool of a father.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[698]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]` (*Lucita Azaro: ""I should have spoken against him. He hardly even knew th..."*)

### Węzeł `[705]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, it's my fault for sending her there in the first place.''"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[698]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Lucita Azaro: ""You couldn't have known what would happen.""*)

### Węzeł `[706]`
Mówca: **Lucita Azaro**
> ""You couldn't have known what would happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""I still remember attending the celebrations when she was..."*)

### Węzeł `[707]`
Mówca: **Lucita Azaro**
> ""Of course you have. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""I still remember attending the celebrations when she was..."*)

### Węzeł `[708]`
Mówca: **Lucita Azaro**
> ""I should have spoken against him. He hardly even knew the Princess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""I still remember attending the celebrations when she was..."*)

### Węzeł `[709]`
Mówca: **Lucita Azaro**
> ""I will make sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""I still remember attending the celebrations when she was..."*)

### Węzeł `[710]`
Mówca: **Narrator**
> "I pushed open the door to my quarters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[711]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[712]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Narrator: "Arranged on my valet stand was a brand-new, crisp royal b..."*)

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Narrator: "Pabel had hung up my favorite suit on the valet stand."*)

### Węzeł `[714]`
Mówca: **Narrator**
> "Arranged on my valet stand was a brand-new, crisp royal blue suit. Pabel had laid it out for me to wear tomorrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[715]`
Mówca: **Narrator**
> "Bruno was on my bed as usual. I noticed the corner of a piece of paper sticking out from under him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Player_Romus_Italic: "Pick it up."*)

### Węzeł `[716]`
Mówca: **Narrator**
> "Pabel had hung up my favorite suit on the valet stand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[719]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[718]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)

### Węzeł `[719]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Narrator: "I looked at my bed. There was a piece of paper on it."*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)
  - -> `[722]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_SleepsInBed == true)"*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Narrator: "Bruno was on my bed as usual. I noticed the corner of a p..."*)

### Węzeł `[722]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_SleepsInBed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Narrator: "Bruno was pacing around next to it. He seemed agitated."*)

### Węzeł `[723]`
Mówca: **Narrator**
> "Bruno was pacing around next to it. He seemed agitated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Narrator: "I looked at my bed. There was a piece of paper on it."*)

### Węzeł `[724]`
Mówca: **Narrator**
> "I looked at my bed. There was a piece of paper on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Player_Romus_Italic: "Pick it up."*)

### Węzeł `[725]`
**[WYBÓR GRACZA: "Pick it up."]** — Mówca: **Player_Romus_Italic**
> "I shoved the dog off the bed and looked at the paper. It was a note from Pabel."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[715]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Pabel Adria: ""Dear Romus...""*)

### Węzeł `[726]`
**[WYBÓR GRACZA: "Pick it up."]** — Mówca: **Player_Romus_Italic**
> "I picked it up. It was a note from Pabel."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[724]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Pabel Adria: ""Dear Romus...""*)

### Węzeł `[727]`
Mówca: **Pabel Adria**
> ""Dear Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Pabel Adria: ""I write these words with a heavy heart.""*)

### Węzeł `[728]`
Mówca: **Pabel Adria**
> ""I write these words with a heavy heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Pabel Adria: ""I will never forget the years I spent serving your famil..."*)

### Węzeł `[729]`
Mówca: **Pabel Adria**
> ""I will never forget the years I spent serving your family, nor the time you and I shared together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Pabel Adria: ""But in the end, my deepest loyalty must be to myself.""*)

### Węzeł `[730]`
Mówca: **Pabel Adria**
> ""I have not lost hope that time will bring forth change -- in our nation and in your own heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Pabel Adria: ""But I am done waiting.""*)

### Węzeł `[731]`
Mówca: **Pabel Adria**
> ""But in the end, my deepest loyalty must be to myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[732]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[734]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[733]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Pabel Adria: ""I wish Her Highness all the happiness in the world. But ..."*)

### Węzeł `[734]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Pabel Adria: ""I can no longer bear silent witness as you deny your dau..."*)

### Węzeł `[735]`
Mówca: **Pabel Adria**
> ""I wish Her Highness all the happiness in the world. But the thought of celebrating her love while the law still forces us to conceal our own fills me with unbearable sorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Pabel Adria: ""I have not lost hope that time will bring forth change -..."*)

### Węzeł `[736]`
Mówca: **Pabel Adria**
> ""I can no longer bear silent witness as you deny your daughter, your country and yourself the freedom to love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Pabel Adria: ""I have not lost hope that time will bring forth change -..."*)

### Węzeł `[737]`
Mówca: **Pabel Adria**
> ""But I am done waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Pabel Adria: ""Bi mare volu...""*)

### Węzeł `[738]`
Mówca: **Pabel Adria**
> ""Bi mare volu...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[739]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Un oxit solu.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[738]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Narrator: "The bed let out a loud creak as I sat down on it."*)

### Węzeł `[740]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You fucking traitor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[738]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Narrator: "The bed let out a loud creak as I sat down on it."*)

### Węzeł `[741]`
**[WYBÓR GRACZA: "Crumple up the note and throw it away."]** — Mówca: **Player_Romus_Italic**
> "I crumpled up the note and threw it away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[738]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Narrator: "The bed let out a loud creak as I sat down on it."*)

### Węzeł `[742]`
Mówca: **Narrator**
> "The bed let out a loud creak as I sat down on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Narrator: "My chambers had never seemed this empty before."*)

### Węzeł `[743]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Player_Romus: ""Un oxit solu.""*)
  - -> `[740]` (*Player_Romus: ""You fucking traitor.""*)
  - -> `[741]` (*Player_Romus_Italic: "Crumple up the note and throw it away."*)

### Węzeł `[744]`
Mówca: **Narrator**
> "My chambers had never seemed this empty before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone = true; RiziaDLC.Relations_Pabel_Toge..."*)

### Węzeł `[745]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone = true; RiziaDLC.Relations_Pabel_Together = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pabel_Gone"] = true;
Variable["RiziaDLC.Relations_Pabel_Together"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "Jump to: [End();]"*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [End();]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[747]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Solitude", "R_Solitude_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Solitude","R_Solitude_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[748]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == false"*)
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == false)"*)

### Węzeł `[749]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Player_Romus: ""Why not?""*)

### Węzeł `[750]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Player_Romus: ""Hugo would have to make it official. Shall we go fetch h..."*)

### Węzeł `[751]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false`
- **Kontekst wejściowy (poprzednik):** `[564]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Narrator: "He gave me an excited hug."*)

### Węzeł `[752]`
Mówca: **Narrator**
> "He gave me an excited hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Narrator: "I took him to the Grand Vizier's chambers, where Hugo use..."*)

### Węzeł `[753]`
Mówca: **Narrator**
> "Inside, we pulled out an enormous book of records. After rifling though it for a while, I saw an entry with no ownership."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Narrator: "It was the Veridian estate on the outskirts of Malcos. Ac..."*)

### Węzeł `[754]`
Mówca: **Narrator**
> "I took him to the Grand Vizier's chambers, where Hugo used to keep the book of records for such estates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]` (*Narrator: "Inside, we pulled out an enormous book of records. After ..."*)

### Węzeł `[755]`
Mówca: **Narrator**
> "It was the Veridian estate on the outskirts of Malcos. According to the documents, it's lain abandoned for years after an unresolved inheritance dispute."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Player_Romus_Italic: "Put your seal on the document."*)

### Węzeł `[756]`
**[WYBÓR GRACZA: "Put your seal on the document."]** — Mówca: **Player_Romus_Italic**
> "I heated a stick of wax, dripped it onto the document and stamped it with my seal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[755]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Narrator: "Pabel added his signature. I nodded at him. It was done."*)

### Węzeł `[757]`
Mówca: **Narrator**
> "Pabel added his signature. I nodded at him. It was done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[764]` (*Player_Romus: ""May this mark the beginning of a new era, where titles a..."*)
  - -> `[758]` (*Player_Romus: ""I hereby proclaim you Lord Pabel Adria of Veridian. May ..."*)
  - -> `[761]` (*Player_Romus: ""As you have served me as a butler, so now do I entrust y..."*)

### Węzeł `[758]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hereby proclaim you Lord Pabel Adria of Veridian. May your actions reflect the honor of your title.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[757]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Narrator: "Pabel grinned from ear to ear."*)

### Węzeł `[759]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Pabel Adria: ""They will, Your Majesty.""*)

### Węzeł `[760]`
Mówca: **Pabel Adria**
> ""They will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Narrator: "I handed him the document."*)

### Węzeł `[761]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As you have served me as a butler, so now do I entrust you with the care of your own domain. May you tend to it as thoughtfully as you tend to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[757]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Narrator: "Pabel grinned from ear to ear."*)

### Węzeł `[762]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Pabel Adria: ""I will, Your Majesty.""*)

### Węzeł `[763]`
Mówca: **Pabel Adria**
> ""I will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Narrator: "I handed him the document."*)

### Węzeł `[764]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May this mark the beginning of a new era, where titles are not inherited but earned by merit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[757]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Narrator: "Pabel grinned from ear to ear."*)

### Węzeł `[765]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Pabel Adria: ""A new era indeed, Your Majesty.""*)

### Węzeł `[766]`
Mówca: **Pabel Adria**
> ""A new era indeed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Narrator: "I handed him the document."*)

### Węzeł `[767]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The institution of nobility is a relic of a bygone era, one that perpetuates inequality and stifles the true potential of our people. But enjoy the fruit trees.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Kontekst wejściowy (poprzednik):** `[757]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]` (*Narrator: "Pabel grinned from ear to ear."*)

### Węzeł `[768]`
Mówca: **Narrator**
> "I handed him the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Player_Romus: ""Keep this safe.""*)
  - -> `[775]` (*Player_Romus: ""Lord Adria.""*)
  - -> `[776]` (*Player_Romus: ""See? Easy.""*)

### Węzeł `[769]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[771]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 2)"*)

### Węzeł `[770]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Player_Romus: ""The institution of nobility is a relic of a bygone era, ..."*)

### Węzeł `[771]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[772]`
Mówca: **Pabel Adria**
> ""I will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Narrator: "I handed him the document."*)

### Węzeł `[773]`
Mówca: **Narrator**
> "Pabel grinned from ear to ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]` (*Pabel Adria: ""I will, Your Majesty.""*)

### Węzeł `[774]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep this safe.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[768]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Pabel Adria: ""I will. Thank you.""*)

### Węzeł `[775]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lord Adria.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[768]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Pabel Adria: ""At your service, Your Majesty.""*)

### Węzeł `[776]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See? Easy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[768]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Pabel Adria: ""Thank you!""*)

### Węzeł `[777]`
Mówca: **Pabel Adria**
> ""At your service, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_WeddingDate = true; RiziaDLCSupport.Journa..."*)

### Węzeł `[778]`
Mówca: **Pabel Adria**
> ""I will. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_WeddingDate = true; RiziaDLCSupport.Journa..."*)

### Węzeł `[779]`
Mówca: **Pabel Adria**
> ""Thank you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_WeddingDate = true; RiziaDLCSupport.Journa..."*)

### Węzeł `[780]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == false"*)
  - -> `[782]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == false)"*)

### Węzeł `[781]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Narrator: "We left the Grand Vizier's chambers together."*)

### Węzeł `[782]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Narrator: "My uncle stared in open amazement as we left."*)

### Węzeł `[783]`
Mówca: **Narrator**
> "We left the Grand Vizier's chambers together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)

### Węzeł `[784]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[786]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[785]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged = false; RiziaDLC.Pabel_Gone = true..."*)

### Węzeł `[786]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged = false; RiziaDLC.Pabel_Gone = true..."*)

### Węzeł `[787]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged = false;
RiziaDLC.Pabel_Gone = true;
RiziaDLCSupport.News_Turn08_V_VinaEscape_Regular = true; RiziaDLC.Relations_Pabel_Together = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_Engaged"] = false;
Variable["RiziaDLC.Pabel_Gone"] = true;
Variable["RiziaDLCSupport.News_Turn08_V_VinaEscape_Regular"] = true;
Variable["RiziaDLC.Relations_Pabel_Together"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged = false; RiziaDLC.Pabel_Gone = true..."*)

### Węzeł `[788]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn08_RH_RoyalWedding_VinaDuchess = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_RH_RoyalWedding_VinaDuchess"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Lucita Azaro: ""Vina Toras, Duchess of Valenqiris. The day has finally c..."*)

### Węzeł `[789]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Complete..."*)
  - -> `[791]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Comple..."*)

### Węzeł `[790]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn08_MaveNortus_IntelligenceSer..."*)

### Węzeł `[791]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_BuildMaveNortusIntelHub_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[792]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn08_MaveNortus_IntelligenceServiceSearchesVina = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn08_MaveNortus_IntelligenceServiceSearchesVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[793]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I surrender to you. I want you to be Rizia's new Queen Consort.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucita Azaro), `[148]` (Lucita Azaro), `[149]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "She clapped a hand to her mouth. It was a second before s..."*)

### Węzeł `[794]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's all I wanted to know. Good night.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Lucita Azaro), `[144]` (Lucita Azaro), `[148]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]` (*Narrator: "Lucita grabbed my arm. She made an effort to keep a pleas..."*)

### Węzeł `[795]`
Mówca: **Narrator**
> "Lucita grabbed my arm. She made an effort to keep a pleasant expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]` (*Lucita Azaro: ""Wait, Romus.""*)

### Węzeł `[796]`
Mówca: **Lucita Azaro**
> ""Wait, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]` (*Lucita Azaro: ""I have to know. Do you ever intend to have another child?""*)

### Węzeł `[797]`
Mówca: **Lucita Azaro**
> ""I have to know. Do you ever intend to have another child?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)
  - -> `[805]` (*Player_Romus: ""No. Just the one was enough for me.""*)
  - -> `[806]` (*Player_Romus: ""Yes, I do.""*)

### Węzeł `[798]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It won't be easy to rest. But I'll try.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]` (*Narrator: "She looked in both directions, then grabbed my arm."*)

### Węzeł `[799]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I have to do something. I'll go crazy otherwise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]` (*Narrator: "She looked in both directions, then grabbed my arm."*)

### Węzeł `[800]`
Mówca: **Narrator**
> "She looked in both directions, then grabbed my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]` (*Lucita Azaro: ""Wait, Romus.""*)

### Węzeł `[801]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How can you ask me that right now? With my daughter Lord knows where...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[797]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Lucita Azaro: ""I hate to say it, but: exactly. You must be aware that y..."*)

### Węzeł `[802]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)
  - -> `[804]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[803]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Player_Romus: ""How can you ask me that right now? With my daughter Lord..."*)

### Węzeł `[804]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[805]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Just the one was enough for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[797]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]` (*Narrator: "She looked me in the eye."*)

### Węzeł `[806]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[797]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]` (*Narrator: "She looked me in the eye."*)

### Węzeł `[807]`
Mówca: **Lucita Azaro**
> ""I hate to say it, but: exactly. You must be aware that you need a backup plan in case Her Highness doesn't return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Lucita Azaro: ""And, well, I'm not getting any younger.""*)

### Węzeł `[808]`
Mówca: **Lucita Azaro**
> ""And, well, I'm not getting any younger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]` (*Lucita Azaro: ""Of course, if you did have a second child, he or she wou..."*)

### Węzeł `[809]`
Mówca: **Narrator**
> "She looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Lucita Azaro: ""Then we shouldn't be together.""*)

### Węzeł `[810]`
Mówca: **Lucita Azaro**
> ""Then we shouldn't be together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Lucita Azaro: ""I'm not getting any younger. And it isn't my intention t..."*)

### Węzeł `[811]`
Mówca: **Lucita Azaro**
> ""Of course, if you did have a second child, he or she would have to be legitimate to qualify for the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[867]` (*Player_Romus: ""I can't bring another child into this world, Lucita.""*)
  - -> `[820]` (*Player_Romus: ""Are you trying to wheedle a proposal out of me? It won't..."*)
  - -> `[821]` (*Player_Romus: ""Please don't take this personally. But no, I do not wish..."*)
  - -> `[822]` (*Player_Romus: ""Then by all means, Duchess, let us be wed posthaste.""*)

### Węzeł `[812]`
Mówca: **Lucita Azaro**
> ""Not to mention... You know I've been careful. But an illegitimate child between the two of us could throw the kingdom into chaos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[820]` (*Player_Romus: ""Are you trying to wheedle a proposal out of me? It won't..."*)
  - -> `[821]` (*Player_Romus: ""Please don't take this personally. But no, I do not wish..."*)
  - -> `[822]` (*Player_Romus: ""Then by all means, Duchess, let us be wed posthaste.""*)

### Węzeł `[813]`
Mówca: **Narrator**
> "She looked me in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Lucita Azaro: ""Then we should be wed.""*)

### Węzeł `[814]`
Mówca: **Lucita Azaro**
> ""Then we should be wed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Lucita Azaro: ""I'm not getting any younger. And it isn't my intention t..."*)

### Węzeł `[815]`
Mówca: **Lucita Azaro**
> ""I'm not getting any younger. And it isn't my intention to die an old maid or secret mistress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]` (*Lucita Azaro: ""Not to mention... You know I've been careful. But an ill..."*)

### Węzeł `[816]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've made your point. I want to marry you, Lucita. But I've already shelled out for one royal wedding.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Kontekst wejściowy (poprzednik):** `[811]` (Lucita Azaro), `[812]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Lucita Azaro: ""I have a rather more low-budget idea. If you'll permit me.""*)

### Węzeł `[817]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[819]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[818]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]` (*Player_Romus: ""You've made your point. I want to marry you, Lucita. But..."*)

### Węzeł `[819]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[820]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you trying to wheedle a proposal out of me? It won't work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[811]` (Lucita Azaro), `[812]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Narrator: "Resolve formed on her face."*)

### Węzeł `[821]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please don't take this personally. But no, I do not wish to have a child with you. My daughter must remain my successor, no matter what.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[811]` (Lucita Azaro), `[812]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 3"*)

### Węzeł `[822]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then by all means, Duchess, let us be wed posthaste.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[811]` (Lucita Azaro), `[812]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]` (*Lucita Azaro: ""Really? You mean that?""*)

### Węzeł `[823]`
Mówca: **Narrator**
> "Resolve formed on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]` (*Lucita Azaro: ""Then... this is over.""*)

### Węzeł `[824]`
Mówca: **Lucita Azaro**
> ""Then... this is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]` (*Lucita Azaro: ""I'm sorry, Romus.""*)

### Węzeł `[825]`
Mówca: **Lucita Azaro**
> ""I'm sorry, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Path_Stratocracy == true"*)

### Węzeł `[826]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry too. Sorry you only wanted me for my royal seed.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[825]` (Lucita Azaro), `[865]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Narrator: "She made a disgusted face."*)

### Węzeł `[827]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This seems sudden.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[825]` (Lucita Azaro), `[865]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Lucita Azaro: ""I know. But I've been thinking about it for some time.""*)

### Węzeł `[828]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we were not royals, this wouldn't be so complicated.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[825]` (Lucita Azaro), `[865]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Lucita Azaro: ""Alas, this is the only life we have. And I don't want to..."*)

### Węzeł `[829]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do love you, you know.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[825]` (Lucita Azaro), `[865]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]` (*Lucita Azaro: ""I know.""*)

### Węzeł `[830]`
Mówca: **Narrator**
> "She made a disgusted face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]` (*Lucita Azaro: ""I promise that's not the reason.""*)

### Węzeł `[831]`
Mówca: **Lucita Azaro**
> ""I know. But I've been thinking about it for some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Narrator: "She straightened up and saluted."*)

### Węzeł `[832]`
Mówca: **Narrator**
> "She straightened up and saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[833]`
Mówca: **Lucita Azaro**
> ""Alas, this is the only life we have. And I don't want to waste mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Narrator: "She straightened up and saluted."*)

### Węzeł `[834]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End No Marriage`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucita Azaro: ""Good night, Your Majesty. I'll let you know at once if t..."*)

### Węzeł `[835]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[837]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[836]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together = false; RiziaDLC.Path..."*)

### Węzeł `[837]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[838]`
Mówca: **Lucita Azaro**
> ""Good night, Your Majesty. I'll see you at the wedding tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]` (*Narrator: "She turned and walked away from me, breaking into a jog a..."*)

### Węzeł `[839]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[841]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[840]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]` (*Lucita Azaro: ""Good night, Your Majesty. I'll see you at the wedding to..."*)

### Węzeł `[841]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]` (*Lucita Azaro: ""Good night, Your Majesty. I'll see you at our next counc..."*)

### Węzeł `[842]`
Mówca: **Narrator**
> "She turned and walked away from me, breaking into a jog as she reached the edge of the clearing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[843]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [End No Marriage]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Węzeł Logiki Narracyjnej: "End No Marriage"*)

### Węzeł `[844]`
Mówca: **Lucita Azaro**
> ""Good night, Your Majesty. I'll see you at our next council meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]` (*Narrator: "She turned and walked away from me, breaking into a jog a..."*)

### Węzeł `[845]`
Mówca: **Narrator**
> "That was it. Just as soon as I had found new love, I'd lost it again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)

### Węzeł `[846]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together = false; RiziaDLC.Path..."*)

### Węzeł `[847]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[849]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[848]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]` (*Narrator: "I hoped Vina would be luckier."*)

### Węzeł `[849]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]` (*Węzeł Logiki Narracyjnej: "Jump to: [End();]"*)

### Węzeł `[850]`
Mówca: **Narrator**
> "I hoped Vina would be luckier."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]` (*Węzeł Logiki Narracyjnej: "Jump to: [End();]"*)

### Węzeł `[851]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [End();]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[852]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together = false; RiziaDLC.Path_Stratocracy = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Together"] = false;
Variable["RiziaDLC.Path_Stratocracy"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]` (*Narrator: "That was it. Just as soon as I had found new love, I'd lo..."*)

### Węzeł `[853]`
Mówca: **Lucita Azaro**
> ""Really? You mean that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true"*)

### Węzeł `[854]`
Mówca: **Lucita Azaro**
> ""I promise that's not the reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Narrator: "She straightened up and saluted."*)

### Węzeł `[855]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseAzaro < 3"*)
  - -> `[857]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseAzaro < 3)"*)

### Węzeł `[856]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseAzaro < 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseAzaro"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Narrator: "Resolve formed on her face."*)

### Węzeł `[857]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseAzaro < 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseAzaro"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]` (*Lucita Azaro: ""She can be your successor if you like. You're the king, ..."*)

### Węzeł `[858]`
Mówca: **Lucita Azaro**
> ""She can be your successor if you like. You're the king, you make the rules.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]` (*Player_Romus: ""I don't think you mean that. The second I impregnate you..."*)
  - -> `[862]` (*Player_Romus: ""If you truly will accept it if Vina stays first in line ..."*)
  - -> `[863]` (*Player_Romus: ""That may be true. But I still find it too risky to muddy..."*)

### Węzeł `[859]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't think you mean that. The second I impregnate you, the Azaros will be scrambling to get Vina out of the picture.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[858]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Narrator: "A hurt look formed on her face."*)

### Węzeł `[860]`
Mówca: **Narrator**
> "A hurt look formed on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Lucita Azaro: ""If that's the level of trust you have for me and my fami..."*)

### Węzeł `[861]`
Mówca: **Lucita Azaro**
> ""If that's the level of trust you have for me and my family... then this is over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]` (*Lucita Azaro: ""I'm sorry, Romus.""*)

### Węzeł `[862]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you truly will accept it if Vina stays first in line for the throne... then yes. Let's get married.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[858]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[894]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_OKWithVinaSuccessor = true"*)

### Węzeł `[863]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That may be true. But I still find it too risky to muddy up the line of succession. I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[858]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]` (*Narrator: "A hurt look formed on her face."*)

### Węzeł `[864]`
Mówca: **Narrator**
> "A hurt look formed on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]` (*Lucita Azaro: ""I'm sorry too, Romus.""*)

### Węzeł `[865]`
Mówca: **Lucita Azaro**
> ""I'm sorry too, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Path_Stratocracy == true"*)

### Węzeł `[866]`
Mówca: **Lucita Azaro**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Narrator: "She straightened up and saluted."*)

### Węzeł `[867]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't bring another child into this world, Lucita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[811]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Narrator: "Resolve formed on her face."*)

### Węzeł `[868]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_MarriageDecision_Rico == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vin..."*)
  - -> `[870]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.V..."*)

### Węzeł `[869]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_MarriageDecision_Rico == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[870]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_DuchessOfValenqiris == true && RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_MarriageDecision_Rico == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true  and  Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[871]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_TorasCelebrates = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_TorasCelebrates"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[872]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[873]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)
  - -> `[874]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras < 0)"*)

### Węzeł `[873]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_Protest..."*)

### Węzeł `[874]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_TorasCe..."*)

### Węzeł `[875]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_Protests = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn09_Monqiz_VinaDuchess_Protests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[876]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_WeddingRing");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_WeddingRing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == false"*)

### Węzeł `[877]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCodexEntry("Characters_Others_PabelAdria_Lord");`
- **Efekt skryptowy (`userScript`):** `EnableCodexEntry("Characters_Others_PabelAdria_Lord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == false"*)

### Węzeł `[878]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Path_Stratocracy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[879]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Path_Stratocracy == true"*)
  - -> `[880]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Path_Stratocracy == true)"*)

### Węzeł `[879]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Path_Stratocracy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Path_Stratocracy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]` (*Lucita Azaro: ""Did you ever love me? Or were you just looking to use my..."*)

### Węzeł `[880]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Path_Stratocracy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Path_Stratocracy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[881]`
Mówca: **Lucita Azaro**
> ""Did you ever love me? Or were you just looking to use my armies to consolidate your power?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]` (*Player_Romus: ""I did love you. I do.""*)
  - -> `[888]` (*Player_Romus: ""They were never *your* armies, sweetie.""*)
  - -> `[889]` (*Player_Romus: ""We can still have a monarcho-military alliance without l..."*)

### Węzeł `[882]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Player_Romus: ""I'm sorry too. Sorry you only wanted me for my royal seed.""*)
  - -> `[827]` (*Player_Romus: ""This seems sudden.""*)
  - -> `[828]` (*Player_Romus: ""If we were not royals, this wouldn't be so complicated.""*)
  - -> `[829]` (*Player_Romus: ""I do love you, you know.""*)

### Węzeł `[883]`
Mówca: **Lucita Azaro**
> ""I have a rather more low-budget idea. If you'll permit me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]` (*Player_Romus: ""Wait. This all happening too fast. I've got cold feet. I..."*)
  - -> `[885]` (*Player_Romus: ""I haven't even proposed yet. Lucita Azaro, will you marr..."*)
  - -> `[884]` (*Player_Romus: ""Go ahead.""*)

### Węzeł `[884]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go ahead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[883]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "She took my hand and pulled me towards the palace."*)

### Węzeł `[885]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't even proposed yet. Lucita Azaro, will you marry me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[883]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_LucitaProposal_Kneeling == true"*)

### Węzeł `[886]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. This all happening too fast. I've got cold feet. I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[883]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]` (*Narrator: "A hurt look formed on her face."*)

### Węzeł `[887]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did love you. I do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[881]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[892]` (*Lucita Azaro: ""Too late.""*)

### Węzeł `[888]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They were never *your* armies, sweetie.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[881]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[891]` (*Lucita Azaro: ""Sweetie?!""*)

### Węzeł `[889]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can still have a monarcho-military alliance without literally uniting our bloodlines.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[881]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]` (*Lucita Azaro: ""Not where my family's concerned.""*)

### Węzeł `[890]`
Mówca: **Lucita Azaro**
> ""Not where my family's concerned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Narrator: "She straightened up and saluted."*)

### Węzeł `[891]`
Mówca: **Lucita Azaro**
> ""Sweetie?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Narrator: "She straightened up and saluted."*)

### Węzeł `[892]`
Mówca: **Lucita Azaro**
> ""Too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Narrator: "She straightened up and saluted."*)

### Węzeł `[893]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together = false; RiziaDLC.Path_Stratocracy = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Lucita_Together"] = false;
Variable["RiziaDLC.Path_Stratocracy"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]` (*Węzeł Logiki Narracyjnej: "Jump to: [End No Marriage]"*)

### Węzeł `[894]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_OKWithVinaSuccessor = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_OKWithVinaSuccessor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "We kissed with such force that we nearly toppled to the g..."*)
