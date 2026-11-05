# Rizia/Turn 10/RelationshipAnnouncement

- **ID konwersacji:** `346`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/346_RelationshipAnnouncement.md`
- **Liczba węzłów dialogowych:** 606
- **Liczba wyborów gracza:** 114

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard`
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.BrunoDog_SleepsInBed`
- `RiziaDLC.Hugo_Arrested`
- `RiziaDLC.Hugo_Resigned`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Lucita_RelationshipPublic`
- `RiziaDLC.Pabel_Gone`
- `RiziaDLC.Pabel_Lord`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.Pabel_WeddingDate`
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_Intermerkopum`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Scar`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.Reform_Diplomatic`
- `RiziaDLC.Reform_Legislative_HouseOfLords`
- `RiziaDLC.Reform_Monarch_Symbolic`
- `RiziaDLC.Reform_Monarch_Veto`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Deposed`
- `RiziaDLC.Rico_PoliceChief_PorteDrazon`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Situation_Law_Media_Censored`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Taddeus_Arrested`
- `RiziaDLC.Taddeus_Deranked`
- `RiziaDLC.Taddeus_Disgraced`
- `RiziaDLC.Taddeus_Executed`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Titus_Arrested`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Turn05_MurderInvest_SuspectEstela`
- `RiziaDLC.Unrest_NatDes_Happened`
- `RiziaDLC.Vina_Escapes`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_Wedding_Happened`
- `RiziaDLC.War_Pales_Won`
- `RiziaDLC.ZilleReferendum_ArmedResistance`
- `RiziaDLC.ZilleReferendum_Interfere_Army`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate`
- `RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC`
- `RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians`
- `RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.FireRufusGragg`
- `RiziaDLC.Lucita_Pregnant`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLCSupport.Journal_Turn10_Lucita_Pregnant`
- `RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate`
- `RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic`
- `RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Butler`
- `RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Lord`
- `RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewChild`
- `RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewWifeAndChild`
- `RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Butler`
- `RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Lord`
- `RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Butler`
- `RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Lord`
- `RiziaDLCText.LucitaToPlayer`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **""Is something wrong, my wife?""** | `[7]` **Narrator**: "Lucita was standing by the bedsi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Narrator**: "She hesitated nervously." |
| `[9]` | **""What is it?""** | `[7]` **Narrator**: "Lucita was standing by the bedsi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Narrator**: "She hesitated nervously." |
| `[10]` | **""Can't we sleep in a little longer? It's not like I have a government to run anymo..."** | `[7]` **Narrator**: "Lucita was standing by the bedsi..." | `Variable["RiziaDLC.Reform_Monarch_Symbolic"] == true` | *Brak zmian stanu* | `[15]` **Narrator**: "She hesitated nervously." |
| `[14]` | **""Can't we sleep in a little longer?""** | `[7]` **Narrator**: "Lucita was standing by the bedsi..." | `(Variable["RiziaDLC.Reform_Monarch_Symbolic"] == true) == false` | *Brak zmian stanu* | `[15]` **Narrator**: "She hesitated nervously." |
| `[20]` | **""What do you mean, you *think*? Haven't you been to the doctor yet?""** | `[19]` **Lucita Azaro**: ""I think I'm pregnant."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Lucita Azaro**: ""No, not yet."" |
| `[21]` | **""What?! Since when?""** | `[19]` **Lucita Azaro**: ""I think I'm pregnant."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Lucita Azaro**: ""A month or two, maybe?"" |
| `[22]` | **""Praise the Lord!""** | `[19]` **Lucita Azaro**: ""I think I'm pregnant."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Lucita Azaro**: ""We shouldn't celebrate yet. Not..." |
| `[23]` | **""Is it a boy?""** | `[19]` **Lucita Azaro**: ""I think I'm pregnant."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Lucita Azaro**: ""I don't know. I don't even know..." |
| `[55]` | **""From a purely pragmatic point of view, this is perfect. I need a new successor no..."** | `[51]` **Narrator**: "She hesitantly took my hand, res..." | `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[64]` **Lucita Azaro**: ""She's not gone, you know."" |
| `[56]` | **""An heir and a spare. Just like I always wanted.""** | `[51]` **Narrator**: "She hesitantly took my hand, res..." | `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false` | *Brak zmian stanu* | `[62]` **Narrator**: "A puzzled frown formed on her face." |
| `[57]` | **""You needn't have worried, my love. I'm the happiest man in the world right now.""** | `[51]` **Narrator**: "She hesitantly took my hand, res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Narrator**: "She smiled and wrapped her arms ..." |
| `[58]` | **""We have a challenging time ahead of us, that's for certain.""** | `[51]` **Narrator**: "She hesitantly took my hand, res..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "She smiled." |
| `[59]` | **""A new heir for our holy kingdom. God has truly smiled upon us this day.""** | `[51]` **Narrator**: "She hesitantly took my hand, res..." | `Variable["RiziaDLC.Theocracy_Full"] == true` | *Brak zmian stanu* | `[73]` **Lucita Azaro**: ""Halaita."" |
| `[68]` | **""I love you, Queen Lucita.""** | `[66]` **Lucita Azaro**: ""I love you, King Romus."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "She kissed me on the forehead." |
| `[69]` | **""I cherish and respect you deeply.""** | `[66]` **Lucita Azaro**: ""I love you, King Romus."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "She kissed me on the forehead." |
| `[74]` | **""I know.""** | `[66]` **Lucita Azaro**: ""I love you, King Romus."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Narrator**: "She kissed me on the forehead." |
| `[78]` | **""And you'd never, ever do anything to betray me, right?""** | `[66]` **Lucita Azaro**: ""I love you, King Romus."" | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[80]` **Narrator**: "She kissed me on the forehead." |
| `[82]` | **""Wait. I want to tell Pabel first.""** | `[79]` **Lucita Azaro**: ""Will you come with me to the Pa..." | `Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true` | `AddConversant("Pabel Adria");` | `[96]` **Narrator**: "I summoned my butler. He cautiou..." |
| `[86]` | **""Of course. What are we waiting for?""** | `[79]` **Lucita Azaro**: ""Will you come with me to the Pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[597]` **Narrator**: "We walked down palace corridors ..." |
| `[87]` | **""What do I tell Vina? Her inheritance might be at stake.""** | `[79]` **Lucita Azaro**: ""Will you come with me to the Pa..." | `Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false` | *Brak zmian stanu* | `[88]` **Lucita Azaro**: ""It'll still be a while before w..." |
| `[89]` | **""First things first. Titus! Get in here! I'm going to be a father again!""** | `[79]` **Lucita Azaro**: ""Will you come with me to the Pa..." | `Variable["RiziaDLC.Titus_Arrested"] == false  and  Variable["RiziaDLC.Reform_Path"] == false  and  Variable["RiziaDLC.Theocracy_Full"] == false` | `AddConversant("Titus Gordion");` | `[93]` **Narrator**: "My bodyguard entered the room. H..." |
| `[97]` | **""Pabel! I'm going to be a father again!""** | `[103]` **Pabel Adria**: ""What is it, Your Majesty?"" | `Variable["RiziaDLC.Lucita_RelationshipPublic"] == true` | *Brak zmian stanu* | `[106]` **Narrator**: "A series of emotions passed acro..." |
| `[102]` | **""Lucita and I were married in secret, and now she's having my baby.""** | `[103]` **Pabel Adria**: ""What is it, Your Majesty?"" | `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false` | *Brak zmian stanu* | `[106]` **Narrator**: "A series of emotions passed acro..." |
| `[104]` | **""From now on, you're going to be butlering for three. King, queen and unborn heir.""** | `[103]` **Pabel Adria**: ""What is it, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Narrator**: "A series of emotions passed acro..." |
| `[105]` | **""Duchess Azaro and I are with child. You shall congratulate us at once.""** | `[103]` **Pabel Adria**: ""What is it, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Narrator**: "A series of emotions passed acro..." |
| `[108]` | **""As a gesture of gratitude for your friendship and service to the Crown, I want yo..."** | `[107]` **Pabel Adria**: ""Congratulations to you both. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "There was a touch of sadness to ..." |
| `[109]` | **""No time for chit-chat. We've got to get Lucita to the doctor.""** | `[107]` **Pabel Adria**: ""Congratulations to you both. Yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Pabel Adria**: ""I hope all goes well."" |
| `[110]` | **""As a gesture of gratitude for your service to the Crown, I want you to be the god..."** | `[95]` **Titus Gordion**: ""Congratulations, my king. You m..."<br>`[369]` **Titus Gordion**: ""This explains a lot. Congratula..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "I saw doubt in Lucita's eyes. Ti..." |
| `[111]` | **""No time for chit-chat. We've got to get Lucita to the doctor.""** | `[95]` **Titus Gordion**: ""Congratulations, my king. You m..."<br>`[369]` **Titus Gordion**: ""This explains a lot. Congratula..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Titus Gordion**: ""Right away."" |
| `[124]` | **""I want you as my security councilor, Lucita. You're the best we've got.""** | `[119]` **Lucita Azaro**: ""It's a good thing the Royal Cou..."<br>`[123]` **Lucita Azaro**: ""It's a good thing the Royal Cou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Narrator**: "She blushed." |
| `[125]` | **""Yes, good thinking. Your father will jump at the chance to serve.""** | `[119]` **Lucita Azaro**: ""It's a good thing the Royal Cou..."<br>`[123]` **Lucita Azaro**: ""It's a good thing the Royal Cou..." | `(Variable["RiziaDLC.Taddeus_Disgraced"] == true  or  Variable["RiziaDLC.Taddeus_Deranked"] == true) == false` | *Brak zmian stanu* | `[146]` **Lucita Azaro**: ""A poor choice of words, given h..." |
| `[129]` | **""Your father is a disgrace to your family, Lucita. He lost us Golden Shield.""** | `[119]` **Lucita Azaro**: ""It's a good thing the Royal Cou..."<br>`[123]` **Lucita Azaro**: ""It's a good thing the Royal Cou..." | `Variable["RiziaDLC.Taddeus_Disgraced"] == true  or  Variable["RiziaDLC.Taddeus_Deranked"] == true` | *Brak zmian stanu* | `[149]` **Lucita Azaro**: ""Give him a chance to prove hims..." |
| `[130]` | **""I can't think that far into the future. Let's wait until we know more.""** | `[119]` **Lucita Azaro**: ""It's a good thing the Royal Cou..."<br>`[123]` **Lucita Azaro**: ""It's a good thing the Royal Cou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Lucita Azaro**: ""It's not *that* far into the fu..." |
| `[151]` | **""I'm glad you don't think poorly of the decision to dissolve the Council, by the w..."** | `[144]` **Lucita Azaro**: ""We can announce the pregnancy r..."<br>`[145]` **Lucita Azaro**: ""We can announce the marriage an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Narrator**: "Her face scrunched up." |
| `[154]` | **""I can't wait to spread the gospel of St. Wruhec with you by my side.""** | `[144]` **Lucita Azaro**: ""We can announce the pregnancy r..."<br>`[145]` **Lucita Azaro**: ""We can announce the marriage an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Narrator**: "She half-smiled." |
| `[157]` | **""The Kingdom may be changing. But the Royal Family will be forever.""** | `[144]` **Lucita Azaro**: ""We can announce the pregnancy r..."<br>`[145]` **Lucita Azaro**: ""We can announce the marriage an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Narrator**: "She squeezed my hand." |
| `[167]` | **""You don't need to bring me the paper. You're not my butler anymore.""** | `[163]` **Narrator**: "Pabel was standing over my bed w..." | `Variable["RiziaDLC.Pabel_Lord"]` | *Brak zmian stanu* | `[175]` **Pabel Adria**: ""This is my copy of the Herald, ..." |
| `[168]` | **""Read the paper to me in bed. The King commands you.""** | `[163]` **Narrator**: "Pabel was standing over my bed w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Pabel Adria**: ""At once, sire."" |
| `[169]` | **""Let me guess. More bad news?""** | `[163]` **Narrator**: "Pabel was standing over my bed w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Pabel Adria**: ""I was just perusing today's Her..." |
| `[170]` | **""Can't I sleep in a little longer?""** | `[163]` **Narrator**: "Pabel was standing over my bed w..." | `(Variable["RiziaDLC.Pabel_Lord"]) == false` | *Brak zmian stanu* | `[171]` **Pabel Adria**: ""In a bit. Let me show you somet..." |
| `[178]` | **""Nobody cares what that old queen has to say.""** | `[174]` **Pabel Adria**: ""Rufus Gragg is at it again."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Pabel Adria**: ""He's the only gossip columnist ..."<br>`[190]` **Pabel Adria**: ""He doesn't wield as much influe..." |
| `[179]` | **""What's he writing this time?""** | `[174]` **Pabel Adria**: ""Rufus Gragg is at it again."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Narrator**: "Pabel cleared his throat and ado..." |
| `[183]` | **""Remind me. Why haven't I fired him yet?""** | `[174]` **Pabel Adria**: ""Rufus Gragg is at it again."" | `Variable["RiziaDLC.Situation_Law_Media_Censored"] == true` | *Brak zmian stanu* | `[191]` **Pabel Adria**: ""His gossip has been harmless up..." |
| `[184]` | **""However bad he is, I'm sure the Voice is worse.""** | `[174]` **Pabel Adria**: ""Rufus Gragg is at it again."" | `(Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false` | *Brak zmian stanu* | `[192]` **Pabel Adria**: ""Actually, the Voice has intelli..." |
| `[206]` | **""I'm used to such speculations about me. But they should leave you out of this.""** | `[205]` **Pabel Adria**: ""Or could it be that he has alre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Pabel Adria**: ""I got myself into this when I g..." |
| `[207]` | **""That's as bad as it gets? Ha. It's not like they can arrest us.""** | `[205]` **Pabel Adria**: ""Or could it be that he has alre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Pabel Adria**: ""No, they can't. Thanks to you."" |
| `[208]` | **""If only you could be my Queen Consort, Pabel.""** | `[205]` **Pabel Adria**: ""Or could it be that he has alre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Pabel Adria**: ""Why not?"" |
| `[210]` | **""My daughter might die, dammit! Can't a King get any privacy?""** | `[205]` **Pabel Adria**: ""Or could it be that he has alre..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[217]` **Pabel Adria**: ""Apparently not."" |
| `[219]` | **""It's true. My daughter's a prisoner. The worst thing that could ever happen to me..."** | `[226]` **Pabel Adria**: ""You told me you're planning on ..."<br>`[227]` **Pabel Adria**: ""I mean it. What's the worst tha..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[237]` **Pabel Adria**: ""I can't imagine how much pain y..." |
| `[228]` | **""I'll be usurped. Laughed off the throne. Perhaps even from within my own family.""** | `[227]` **Pabel Adria**: ""I mean it. What's the worst tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Pabel Adria**: ""Is House Toras really so intole..." |
| `[229]` | **""You're right. I am the king. If my subjects love me, they'll love you as well.""** | `[226]` **Pabel Adria**: ""You told me you're planning on ..."<br>`[227]` **Pabel Adria**: ""I mean it. What's the worst tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Pabel Adria**: ""Let's be real. Not all of them ..." |
| `[233]` | **""Vina's got her heart set on being queen. I don't want to do anything to jeopardiz..."** | `[226]` **Pabel Adria**: ""You told me you're planning on ..."<br>`[227]` **Pabel Adria**: ""I mean it. What's the worst tha..." | `Variable["RiziaDLC.Vina_Escapes"] == false`<br>`(Variable["RiziaDLC.Vina_Hostage"] == true) == false` | *Brak zmian stanu* | `[239]` **Pabel Adria**: ""You being involved with a man w..." |
| `[234]` | **""The entire world will know that the King of Rizia enjoys the company of men.""** | `[226]` **Pabel Adria**: ""You told me you're planning on ..."<br>`[227]` **Pabel Adria**: ""I mean it. What's the worst tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Pabel Adria**: ""You'll be more famous than ever..." |
| `[235]` | **""My daughter ran away. It's been one royal scandal after another.""** | `[226]` **Pabel Adria**: ""You told me you're planning on ..."<br>`[227]` **Pabel Adria**: ""I mean it. What's the worst tha..." | `(Variable["RiziaDLC.Vina_Escapes"] == false) == false`<br>`(Variable["RiziaDLC.Vina_Hostage"] == true) == false` | *Brak zmian stanu* | `[241]` **Pabel Adria**: ""Well, precisely. What's one more?"" |
| `[244]` | **""Let's test the waters first. We'll tell my mother.""** | `[238]` **Pabel Adria**: ""Whether us going public will ea..."<br>`[240]` **Pabel Adria**: ""It's up to you. But think of wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Narrator**: "He nodded his assent." |
| `[245]` | **""This is as out in the open as I'm willing to get, Pabel. We shall continue as we ..."** | `[238]` **Pabel Adria**: ""Whether us going public will ea..."<br>`[240]` **Pabel Adria**: ""It's up to you. But think of wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Pabel Adria**: ""All right. I understand."" |
| `[249]` | **""I'm having Rufus Gragg fired. My love life shall remain private, and no speculati..."** | `[238]` **Pabel Adria**: ""Whether us going public will ea..."<br>`[240]` **Pabel Adria**: ""It's up to you. But think of wh..." | `Variable["RiziaDLC.Situation_Law_Media_Censored"]` | `Variable["RiziaDLC.FireRufusGragg"] = true;` | `[251]` **Pabel Adria**: ""All right. I understand."" |
| `[269]` | **""You should sit down, Mother.""** | `[268]` **Estela Toras**: ""My goodness, son. What are you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Narrator**: "We entered the room and sat on o..." |
| `[270]` | **""Pabel and I have something to tell you.""** | `[268]` **Estela Toras**: ""My goodness, son. What are you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Narrator**: "We entered the room and sat on o..." |
| `[271]` | **""Let's go to the balcony. I could use a smoke.""** | `[268]` **Estela Toras**: ""My goodness, son. What are you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Estela Toras**: ""Starting early today, are we?"" |
| `[276]` | **""Mother... I am a homosexual.""** | `[275]` **Estela Toras**: ""Now. What is so urgent that you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Narrator**: "My mother was very quiet for a l..." |
| `[277]` | **""Pabel and I are in love. We have been for a long time.""** | `[275]` **Estela Toras**: ""Now. What is so urgent that you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Narrator**: "My mother was very quiet for a l..." |
| `[281]` | **""This might come as a shock, but I am attracted to men as well as women.""** | `[275]` **Estela Toras**: ""Now. What is so urgent that you..." | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | *Brak zmian stanu* | `[283]` **Narrator**: "My mother was very quiet for a l..." |
| `[282]` | **""I risk bringing shame upon this family by loving a member of the same sex.""** | `[275]` **Estela Toras**: ""Now. What is so urgent that you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Narrator**: "My mother was very quiet for a l..." |
| `[289]` | **""I want the world to know. We could set an example for millions.""** | `[286]` **Estela Toras**: ""The question remains, though. W..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Narrator**: "Her expression turned stern." |
| `[290]` | **""We haven't decided yet.""** | `[286]` **Estela Toras**: ""The question remains, though. W..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Narrator**: "Her expression turned stern." |
| `[291]` | **""Sooner or later, everyone will find out. I should control the narrative by making..."** | `[286]` **Estela Toras**: ""The question remains, though. W..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Narrator**: "Her expression turned stern." |
| `[319]` | **""I'm surprised at you, Mother. I thought you'd support me.""** | `[318]` **Estela Toras**: ""I love you, darling. But you ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Narrator**: "Pabel nodded in agreement." |
| `[321]` | **""I am sorry. But none of this was my fault.""** | `[318]` **Estela Toras**: ""I love you, darling. But you ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Estela Toras**: ""That makes no difference. You c..." |
| `[322]` | **""You started it! You seduced my father and brought our noble house to ruin.""** | `[318]` **Estela Toras**: ""I love you, darling. But you ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Estela Toras**: ""Seduced? Don't delude yourself."" |
| `[323]` | **""I won't. I promise.""** | `[318]` **Estela Toras**: ""I love you, darling. But you ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Estela Toras**: ""This is for your own good."" |
| `[332]` | **""If I have to leave the throne to be with the man I love, I will. My work as King ..."** | `[331]` **Narrator**: "Pabel and I looked at each other..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn10_Pabel_DecisionTo...` | `[335]` **Narrator**: "She nodded in approval." |
| `[333]` | **""Your true colors are showing. I refuse to give in to your bigotry. We will announ..."** | `[331]` **Narrator**: "Pabel and I looked at each other..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Pabel_RelationshipPublic"] = true;` | `[342]` **Narrator**: "Her jaw clenched." |
| `[334]` | **""You have made your point. As long as I am king, this will be our secret.""** | `[331]` **Narrator**: "Pabel and I looked at each other..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Narrator**: "She nodded in approval." |
| `[359]` | **""Did Bruno kick you out of bed again? Sorry, he does that.""** | `[7]` **Narrator**: "Lucita was standing by the bedsi..." | `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true` | *Brak zmian stanu* | `[15]` **Narrator**: "She hesitated nervously." |
| `[360]` | **""One moment. Bruno! You're going to be a big brother!""** | `[79]` **Lucita Azaro**: ""Will you come with me to the Pa..." | `Variable["RiziaDLC.BrunoDog_Adopted"] == true` | `AddConversant("Bruno");` | `[364]` **Narrator**: "My dog hopped on the bed and lic..." |
| `[382]` | **""If my reforms succeed, my power will be symbolic. Why not live out the rest of my..."** | `[375]` **Pabel Adria**: ""So that's it? After everything,..." | `Variable["RiziaDLC.Reform_Path"] == true` | *Brak zmian stanu* | `[411]` **Pabel Adria**: ""Why not, indeed?"" |
| `[386]` | **""I've accomplished what I set out to do. Things can only go downhill from here.""** | `[375]` **Pabel Adria**: ""So that's it? After everything,..." | `Variable["RiziaDLC.War_Pales_Won"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true  or  Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true` | *Brak zmian stanu* | `[409]` **Pabel Adria**: ""That's the spirit."" |
| `[390]` | **""I have failed my kingdom anyway. I don't deserve my crown.""** | `[375]` **Pabel Adria**: ""So that's it? After everything,..." | `(Variable["RiziaDLC.War_Pales_Won"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true  or  Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false` | *Brak zmian stanu* | `[410]` **Pabel Adria**: ""Don't be so hard on yourself."" |
| `[391]` | **""It will be a relief, to be honest. Being king is hard.""** | `[375]` **Pabel Adria**: ""So that's it? After everything,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[412]` **Pabel Adria**: ""Having served two of you, I won..." |
| `[392]` | **""I'm thinking about it. No promises yet.""** | `[375]` **Pabel Adria**: ""So that's it? After everything,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[413]` **Pabel Adria**: ""I understand."" |
| `[400]` | **""Homosexuality is legal. You're a lord. There's nothing stopping us.""** | `[396]` **Pabel Adria**: ""So that's it? We're going public?"" | `Variable["RiziaDLC.Pabel_Lord"] == true` | *Brak zmian stanu* | `[407]` **Pabel Adria**: ""You're right."" |
| `[404]` | **""Homosexuality is legal. There's nothing stopping us.""** | `[396]` **Pabel Adria**: ""So that's it? We're going public?"" | `(Variable["RiziaDLC.Pabel_Lord"] == true) == false` | *Brak zmian stanu* | `[407]` **Pabel Adria**: ""You're right."" |
| `[405]` | **""Screw what my mother says. I refuse to be ashamed of my identity.""** | `[396]` **Pabel Adria**: ""So that's it? We're going public?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Pabel Adria**: ""You're right."" |
| `[406]` | **""I'd rather not. But everyone will find out sooner or later. It's best to control ..."** | `[396]` **Pabel Adria**: ""So that's it? We're going public?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Pabel Adria**: ""You're right."" |
| `[432]` | **""I know your religion despises homosexuality. But can't you make an exception for ..."** | `[318]` **Estela Toras**: ""I love you, darling. But you ca..." | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true` | *Brak zmian stanu* | `[433]` **Narrator**: "She glanced around her." |
| `[435]` | **""I suspect my reign won't last much longer anyway. Might as well go out with a bang.""** | `[396]` **Pabel Adria**: ""So that's it? We're going public?"" | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Unrest_NatDes_Happened"] == true`<br>`(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false` | *Brak zmian stanu* | `[439]` **Pabel Adria**: ""I don't know what you're thinki..." |
| `[443]` | **""No. In fact, I want him fired for smearing my good name. Let's tell the main staf..."** | `[418]` **Pabel Adria**: ""Shall we leak the news to Rufus..." | `Variable["RiziaDLC.Situation_Law_Media_Censored"] == true` | `Variable["RiziaDLCSupport.News_Turn10_RH_KingHomosexual_L...`<br>`Variable["RiziaDLCSupport.News_Turn10_RH_KingHomosexual_B...` | `[446]` **Pabel Adria**: ""As you wish."" |
| `[444]` | **""No, let's give this to the Voice. That'll teach him for being such a busybody.""** | `[418]` **Pabel Adria**: ""Shall we leak the news to Rufus..." | `(Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false` | `Variable["RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Lor...`<br>`Variable["RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_But...` | `[446]` **Pabel Adria**: ""As you wish."" |
| `[445]` | **""Yes, let's. We'll make his career.""** | `[418]` **Pabel Adria**: ""Shall we leak the news to Rufus..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomos...`<br>`Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomos...` | `[447]` **Pabel Adria**: ""If we're lucky, it'll make the ..." |
| `[471]` | **""There is still no word about Vina. I may have to make the call at one point.""** | `[51]` **Narrator**: "She hesitantly took my hand, res..." | `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[67]` **Lucita Azaro**: ""We'll get through it together."" |
| `[485]` | **""I love you, Pabel. But I love being king more.""** | `[397]` **Pabel Adria**: ""I guess that's it, then."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Pabel Adria**: ""Madam Estela was right. I shoul..." |
| `[486]` | **""Just give it a few more years. The public will be ready for us someday.""** | `[397]` **Pabel Adria**: ""I guess that's it, then."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He smiled sadly and kissed me on..." |
| `[487]` | **""You shouldn't be with me anymore, Pabel. Go meet someone else. Be free.""** | `[397]` **Pabel Adria**: ""I guess that's it, then."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[551]` **Narrator**: "He smiled sadly and kissed me on..." |
| `[488]` | **""You heard my mother. My family has been through enough.""** | `[397]` **Pabel Adria**: ""I guess that's it, then."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Pabel Adria**: ""Madam Estela was right. I shoul..." |
| `[492]` | **""Are you sure you don't want to wait until after Mother's birthday?""** | `[79]` **Lucita Azaro**: ""Will you come with me to the Pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[493]` **Narrator**: "She scoffed." |
| `[500]` | **""The monarchy's barely changing under the new constitution. The Azaros and everyon..."** | `[499]` **Lucita Azaro**: ""My family is reluctant enough t..." | `Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true` | *Brak zmian stanu* | `[508]` **Lucita Azaro**: ""My father will have to be the j..." |
| `[504]` | **""But you'll convince them reform is the right way to go. Yes?""** | `[499]` **Lucita Azaro**: ""My family is reluctant enough t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Lucita Azaro**: ""I'll try my best. But not if th..." |
| `[505]` | **""The royal baby will be a Toras, anyway. Not an Azaro.""** | `[499]` **Lucita Azaro**: ""My family is reluctant enough t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[506]` **Lucita Azaro**: ""In name only. I'll teach him to..." |
| `[509]` | **""If they're truly concerned for the safety of their unborn heir, they'll agree to ..."** | `[499]` **Lucita Azaro**: ""My family is reluctant enough t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[510]` **Narrator**: "She swallowed." |
| `[512]` | **""The Rizian Royal Family shall still reign, my dear. The Azaros will be lucky to b..."** | `[499]` **Lucita Azaro**: ""My family is reluctant enough t..." | `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false` | *Brak zmian stanu* | `[513]` **Lucita Azaro**: ""My father's going to want more ..." |
| `[521]` | **""With everything that's been going on, you'd think he'd give it a rest.""** | `[174]` **Pabel Adria**: ""Rufus Gragg is at it again."" | `Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true` | *Brak zmian stanu* | `[522]` **Pabel Adria**: ""Gossip is a welcome distraction..." |
| `[523]` | **""It gladdens my heart that so many Rizians like us are now able to live freely. Bu..."** | `[238]` **Pabel Adria**: ""Whether us going public will ea..."<br>`[240]` **Pabel Adria**: ""It's up to you. But think of wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[524]` **Narrator**: "He looked at me for a moment, cr..." |
| `[527]` | **""It isn't. But I still want to share it with you.""** | `[526]` **Pabel Adria**: ""But you're right. You're a roya..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[532]` **Pabel Adria**: ""Bi mare volu, un oxit solu."" |
| `[528]` | **""I may not rule Rizia forever. 'Someday' could come sooner than you think.""** | `[526]` **Pabel Adria**: ""But you're right. You're a roya..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[529]` **Pabel Adria**: ""Rom. I could never ask you to g..." |
| `[530]` | **""It is. I'm just a coward.""** | `[526]` **Pabel Adria**: ""But you're right. You're a roya..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[531]` **Pabel Adria**: ""You're my coward."" |
| `[533]` | **""What about your life? You deserve to be with someone who can show you off like th..."** | `[526]` **Pabel Adria**: ""But you're right. You're a roya..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[534]` **Pabel Adria**: ""Touching, Rom. But I can't give..." |
| `[546]` | **""What do you think we should do?""** | `[286]` **Estela Toras**: ""The question remains, though. W..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Narrator**: "Her expression turned stern." |
| `[547]` | **""I'm sorry, Mother. But I can't keep hiding who I am. The birthday party will be o..."** | `[331]` **Narrator**: "Pabel and I looked at each other..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Pabel_RelationshipPublic"] = true;` | `[342]` **Narrator**: "Her jaw clenched." |
| `[571]` | **""Trust me. After my mother's birthday party, nobody will be talking about our rela..."** | `[396]` **Pabel Adria**: ""So that's it? We're going public?"" | `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true` | *Brak zmian stanu* | `[572]` **Pabel Adria**: ""I don't know if I like the soun..." |
| `[580]` | **""I know, but I have no choice. We're doing this.""** | `[579]` **Titus Gordion**: ""Your Majesty, do you still want..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[587]` **Narrator**: "Titus gave a grim nod." |
| `[581]` | **""You're right. We won't strike against House Azaro that night.""** | `[579]` **Titus Gordion**: ""Your Majesty, do you still want..." | `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true` | *Brak zmian stanu* | `[590]` **Narrator**: "Titus nodded quickly." |
| `[585]` | **""I will make sure nothing happens to either of them.""** | `[579]` **Titus Gordion**: ""Your Majesty, do you still want..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[589]` **Titus Gordion**: ""I suppose even in her condition..." |
| `[586]` | **""You're right. Let's call off the plan. It's too risky.""** | `[579]` **Titus Gordion**: ""Your Majesty, do you still want..." | `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false` | `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] = fa...` | `[592]` **Narrator**: "Titus gave a furtive sigh of rel..." |

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
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Solitude", "R_Solitude_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The morning sun streamed through the windows of my chambers as I slowly opened my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Lucita was standing by the bedside. She had an unusually ..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "Pabel was standing over my bed with the morning paper. He..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Lucita was standing by the bedside. She had an unusually intense expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)
  - -> `[8]` (*Player_Romus: ""Is something wrong, my wife?""*)
  - -> `[9]` (*Player_Romus: ""What is it?""*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Symbolic == true"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is something wrong, my wife?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "She hesitated nervously."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "She hesitated nervously."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't we sleep in a little longer? It's not like I have a government to run anymore.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Monarch_Symbolic"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "She hesitated nervously."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Symbolic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Symbolic == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Monarch_Symbolic == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Symbolic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Symbolic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""Can't we sleep in a little longer? It's not like I have ..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Monarch_Symbolic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Symbolic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""Can't we sleep in a little longer?""*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't we sleep in a little longer?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Monarch_Symbolic"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "She hesitated nervously."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "She hesitated nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucita Azaro: ""Your Maj-- Romus...""*)

### Węzeł `[16]`
Mówca: **Lucita Azaro**
> ""Your Maj-- Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucita Azaro: ""There's something I need to tell you.""*)

### Węzeł `[17]`
Mówca: **Lucita Azaro**
> ""There's something I need to tell you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucita Azaro: ""I...""*)

### Węzeł `[18]`
Mówca: **Lucita Azaro**
> ""I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucita Azaro: ""I think I'm pregnant.""*)

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""I think I'm pregnant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""What do you mean, you *think*? Haven't you been to the d..."*)
  - -> `[21]` (*Player_Romus: ""What?! Since when?""*)
  - -> `[22]` (*Player_Romus: ""Praise the Lord!""*)
  - -> `[23]` (*Player_Romus: ""Is it a boy?""*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean, you *think*? Haven't you been to the doctor yet?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucita Azaro: ""No, not yet.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What?! Since when?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucita Azaro: ""A month or two, maybe?""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Praise the Lord!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucita Azaro: ""We shouldn't celebrate yet. Nothing is certain.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it a boy?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucita Azaro: ""I don't know. I don't even know how far along I am.""*)

### Węzeł `[24]`
Mówca: **Lucita Azaro**
> ""I don't know. I don't even know how far along I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[25]`
Mówca: **Lucita Azaro**
> ""We shouldn't celebrate yet. Nothing is certain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[26]`
Mówca: **Lucita Azaro**
> ""A month or two, maybe?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[27]`
Mówca: **Lucita Azaro**
> ""No, not yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucita Azaro: ""And with everything that's happened to Her Highness-- Vi..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true || RiziaDLC.Taddeus_Arr..."*)

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""And with everything that's happened to Her Highness-- Vina...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "She swallowed."*)

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""Time's been a blur since the war began. I thought I was throwing up from nerves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucita Azaro: ""Time's been a blur since the war began. I thought I was ..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true || Rizia..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "She swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""I wasn't even sure how you would take the news.""*)

### Węzeł `[37]`
Mówca: **Lucita Azaro**
> ""I wasn't even sure how you would take the news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "She hesitantly took my hand, resting the other on her abd..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucita Azaro: ""We've had so many security issues lately. I thought I wa..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lucita Azaro: ""We've both been so busy lately...""*)

### Węzeł `[41]`
Mówca: **Lucita Azaro**
> ""We've had so many security issues lately. I thought I was throwing up from nerves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""I wasn't even sure how you would take the news.""*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true || RiziaDLC.Taddeus_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Executed == true || RiziaDLC.Taddeus_Arr..."*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Executed == true || RiziaDLC.Taddeus_A..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Executed == true || RiziaDLC.Taddeus_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucita Azaro: ""And then after everything with the General-- Father...""*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Executed == true || RiziaDLC.Taddeus_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Executed"] == true  or  Variable["RiziaDLC.Taddeus_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""I wasn't even sure how you would take the news.""*)

### Węzeł `[45]`
Mówca: **Lucita Azaro**
> ""And then after everything with the General-- Father...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""I wasn't even sure how you would take the news.""*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_ArmedResistance == true || RiziaDLC.ZilleReferendum_Interfere_Army == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_ArmedResistance == true || Rizia..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_ArmedResistance == true || Riz..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_ArmedResistance == true || RiziaDLC.ZilleReferendum_Interfere_Army == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucita Azaro: ""Our overthrow in Zille was such a blur. I thought I was ..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_ArmedResistance == true || RiziaDLC.ZilleReferendum_Interfere_Army == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_ArmedResistance"] == true  or  Variable["RiziaDLC.ZilleReferendum_Interfere_Army"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[49]`
Mówca: **Lucita Azaro**
> ""Our overthrow in Zille was such a blur. I thought I was throwing up from nerves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""I wasn't even sure how you would take the news.""*)

### Węzeł `[50]`
Mówca: **Lucita Azaro**
> ""We've both been so busy lately...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""I wasn't even sure how you would take the news.""*)
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true && RiziaDLC.Reform_Diplomati..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "She hesitantly took my hand, resting the other on her abdomen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)
  - -> `[57]` (*Player_Romus: ""You needn't have worried, my love. I'm the happiest man ..."*)
  - -> `[58]` (*Player_Romus: ""We have a challenging time ahead of us, that's for certa..."*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ==..."*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""From a purely pragmatic point of view, this is perfect. ..."*)
  - -> `[471]` (*Player_Romus: ""There is still no word about Vina. I may have to make th..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true || RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""An heir and a spare. Just like I always wanted.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From a purely pragmatic point of view, this is perfect. I need a new successor now that Vina is gone.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucita Azaro: ""She's not gone, you know.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An heir and a spare. Just like I always wanted.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "A puzzled frown formed on her face."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You needn't have worried, my love. I'm the happiest man in the world right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "She smiled and wrapped her arms around me."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have a challenging time ahead of us, that's for certain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "She smiled."*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A new heir for our holy kingdom. God has truly smiled upon us this day.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lucita Azaro: ""Halaita.""*)

### Węzeł `[60]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucita Azaro: ""We'll get through it together.""*)

### Węzeł `[61]`
Mówca: **Narrator**
> "She smiled and wrapped her arms around me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucita Azaro: ""I love you, King Romus.""*)

### Węzeł `[62]`
Mówca: **Narrator**
> "A puzzled frown formed on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucita Azaro: ""Who's the spare?""*)

### Węzeł `[63]`
Mówca: **Lucita Azaro**
> ""Who's the spare?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Lucita Azaro: ""Anyway...""*)

### Węzeł `[64]`
Mówca: **Lucita Azaro**
> ""She's not gone, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucita Azaro: ""Whatever happens, we'll remember her. But we're bringing..."*)

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""Whatever happens, we'll remember her. But we're bringing new life into the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "She kissed me on the forehead."*)

### Węzeł `[66]`
Mówca: **Lucita Azaro**
> ""I love you, King Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""I love you, Queen Lucita.""*)
  - -> `[69]` (*Player_Romus: ""I cherish and respect you deeply.""*)
  - -> `[74]` (*Player_Romus: ""I know.""*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[67]`
Mówca: **Lucita Azaro**
> ""We'll get through it together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucita Azaro: ""Will you come with me to the Palace doctors? I've put th..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love you, Queen Lucita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "She kissed me on the forehead."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cherish and respect you deeply.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "She kissed me on the forehead."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player_Romus: ""A new heir for our holy kingdom. God has truly smiled up..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[73]`
Mówca: **Lucita Azaro**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucita Azaro: ""Will you come with me to the Palace doctors? I've put th..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "She kissed me on the forehead."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""And you'd never, ever do anything to betray me, right?""*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you'd never, ever do anything to betray me, right?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[66]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "She kissed me on the forehead."*)

### Węzeł `[79]`
Mówca: **Lucita Azaro**
> ""Will you come with me to the Palace doctors? I've put this off for long enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == false && RiziaDLC.Prologue_Relatio..."*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false && RiziaDLC.Reform_Path ..."*)
  - -> `[86]` (*Player_Romus: ""Of course. What are we waiting for?""*)
  - -> `[492]` (*Player_Romus: ""Are you sure you don't want to wait until after Mother's..."*)
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_Hostage =..."*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[80]`
Mówca: **Narrator**
> "She kissed me on the forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucita Azaro: ""Will you come with me to the Palace doctors? I've put th..."*)

### Węzeł `[81]`
Mówca: **Lucita Azaro**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucita Azaro: ""Will you come with me to the Palace doctors? I've put th..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. I want to tell Pabel first.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Kontekst wejściowy (poprzednik):** `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "AddConversant("Pabel Adria");"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == false && RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Gone == false && RiziaDLC.Prologue_Relatio..."*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Gone == false && RiziaDLC.Prologue_Relat..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Gone == false && RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""Wait. I want to tell Pabel first.""*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Gone == false && RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Gone"] == false  and  Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. What are we waiting for?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Narrator: "We walked down palace corridors towards the medical wing."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do I tell Vina? Her inheritance might be at stake.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Kontekst wejściowy (poprzednik):** `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucita Azaro: ""It'll still be a while before we find out the sex. If it..."*)

### Węzeł `[88]`
Mówca: **Lucita Azaro**
> ""It'll still be a while before we find out the sex. If it's a boy, I'm sure you'll find a way to let Her Highness down easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Wedding_Happened == true"*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""First things first. Titus! Get in here! I'm going to be a father again!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Titus_Arrested"] == false  and  Variable["RiziaDLC.Reform_Path"] == false  and  Variable["RiziaDLC.Theocracy_Full"] == false`
- **Kontekst wejściowy (poprzednik):** `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false && RiziaDLC.Reform_Path == false && RiziaDLC.Theocracy_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Titus_Arrested == false && RiziaDLC.Reform_Path ..."*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Titus_Arrested == false && RiziaDLC.Reform_Pat..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Titus_Arrested == false && RiziaDLC.Reform_Path == false && RiziaDLC.Theocracy_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Titus_Arrested"] == false  and  Variable["RiziaDLC.Reform_Path"] == false  and  Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""First things first. Titus! Get in here! I'm going to be ..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Titus_Arrested == false && RiziaDLC.Reform_Path == false && RiziaDLC.Theocracy_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Titus_Arrested"] == false  and  Variable["RiziaDLC.Reform_Path"] == false  and  Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[93]`
Mówca: **Narrator**
> "My bodyguard entered the room. He cast an eye over myself and Lucita, then reached out to shake my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RelationshipPublic == true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "My bodyguard entered the room. He cast an eye over myself..."*)

### Węzeł `[95]`
Mówca: **Titus Gordion**
> ""Congratulations, my king. You must be very proud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""As a gesture of gratitude for your service to the Crown,..."*)
  - -> `[111]` (*Player_Romus: ""No time for chit-chat. We've got to get Lucita to the do..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "I summoned my butler. He cautiously regarded myself and Lucita as he stood in the doorway of my chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Pabel Adria: ""What is it, Your Majesty?""*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel! I'm going to be a father again!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_RelationshipPublic"] == true`
- **Kontekst wejściowy (poprzednik):** `[103]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "A series of emotions passed across his face as he absorbe..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RelationshipPublic == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_RelationshipPublic == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""Pabel! I'm going to be a father again!""*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player_Romus: ""Lucita and I were married in secret, and now she's havin..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "I summoned my butler. He cautiously regarded myself and L..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita and I were married in secret, and now she's having my baby.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[103]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "A series of emotions passed across his face as he absorbe..."*)

### Węzeł `[103]`
Mówca: **Pabel Adria**
> ""What is it, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RelationshipPublic == true"*)
  - -> `[104]` (*Player_Romus: ""From now on, you're going to be butlering for three. Kin..."*)
  - -> `[105]` (*Player_Romus: ""Duchess Azaro and I are with child. You shall congratula..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From now on, you're going to be butlering for three. King, queen and unborn heir.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "A series of emotions passed across his face as he absorbe..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duchess Azaro and I are with child. You shall congratulate us at once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "A series of emotions passed across his face as he absorbe..."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "A series of emotions passed across his face as he absorbed this news. Finally, he reached out to shake my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Pabel Adria: ""Congratulations to you both. You must be very proud.""*)

### Węzeł `[107]`
Mówca: **Pabel Adria**
> ""Congratulations to you both. You must be very proud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player_Romus: ""As a gesture of gratitude for your friendship and servic..."*)
  - -> `[109]` (*Player_Romus: ""No time for chit-chat. We've got to get Lucita to the do..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a gesture of gratitude for your friendship and service to the Crown, I want you to be the godfather.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "There was a touch of sadness to his smile."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time for chit-chat. We've got to get Lucita to the doctor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Pabel Adria: ""I hope all goes well.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a gesture of gratitude for your service to the Crown, I want you to be the godfather.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Titus Gordion), `[369]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "I saw doubt in Lucita's eyes. Titus knelt before me."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time for chit-chat. We've got to get Lucita to the doctor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Titus Gordion), `[369]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Titus Gordion: ""Right away.""*)

### Węzeł `[112]`
Mówca: **Titus Gordion**
> ""Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Titus trailed a short distance behind as we walked down p..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "I saw doubt in Lucita's eyes. Titus knelt before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Titus Gordion: ""Nothing would honor me more.""*)

### Węzeł `[114]`
Mówca: **Titus Gordion**
> ""Nothing would honor me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Titus trailed a short distance behind as we walked down p..."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "There was a touch of sadness to his smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Pabel Adria: ""Nothing would honor me more.""*)

### Węzeł `[116]`
Mówca: **Pabel Adria**
> ""Nothing would honor me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Narrator: "Pabel trailed a short distance behind as we walked down p..."*)

### Węzeł `[117]`
Mówca: **Pabel Adria**
> ""I hope all goes well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Narrator: "Pabel trailed a short distance behind as we walked down p..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "Titus trailed a short distance behind as we walked down palace corridors towards the medical wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion"); RemoveConversant("Pabe..."*)

### Węzeł `[119]`
Mówca: **Lucita Azaro**
> ""It's a good thing the Royal Council petition hearings are coming up soon. We can announce the pregnancy, then reinstate General Taddeus straight away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""I want you as my security councilor, Lucita. You're the ..."*)
  - -> `[130]` (*Player_Romus: ""I can't think that far into the future. Let's wait until..."*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true || RiziaDLC.Taddeus_De..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RelationshipPublic == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_RelationshipPublic == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucita Azaro: ""It's a good thing the Royal Council petition hearings ar..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucita Azaro: ""It's a good thing the Royal Council petition hearings ar..."*)

### Węzeł `[123]`
Mówca: **Lucita Azaro**
> ""It's a good thing the Royal Council petition hearings are coming up soon. We can announce the marriage and pregnancy, then reinstate General Taddeus straight away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""I want you as my security councilor, Lucita. You're the ..."*)
  - -> `[130]` (*Player_Romus: ""I can't think that far into the future. Let's wait until..."*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true || RiziaDLC.Taddeus_De..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want you as my security councilor, Lucita. You're the best we've got.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucita Azaro), `[123]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "She blushed."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, good thinking. Your father will jump at the chance to serve.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Taddeus_Disgraced"] == true  or  Variable["RiziaDLC.Taddeus_Deranked"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucita Azaro), `[123]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lucita Azaro: ""A poor choice of words, given his condition. But you're ..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Disgraced == true || RiziaDLC.Taddeus_Deranked == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Taddeus_Disgraced == true || RiziaDLC.Taddeus_De..."*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Taddeus_Disgraced == true || RiziaDLC.Taddeus_..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Taddeus_Disgraced == true || RiziaDLC.Taddeus_Deranked == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true  or  Variable["RiziaDLC.Taddeus_Deranked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player_Romus: ""Your father is a disgrace to your family, Lucita. He los..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Taddeus_Disgraced == true || RiziaDLC.Taddeus_Deranked == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Taddeus_Disgraced"] == true  or  Variable["RiziaDLC.Taddeus_Deranked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player_Romus: ""Yes, good thinking. Your father will jump at the chance ..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your father is a disgrace to your family, Lucita. He lost us Golden Shield.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Taddeus_Disgraced"] == true  or  Variable["RiziaDLC.Taddeus_Deranked"] == true`
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucita Azaro), `[123]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Lucita Azaro: ""Give him a chance to prove himself.""*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't think that far into the future. Let's wait until we know more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucita Azaro), `[123]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lucita Azaro: ""It's not *that* far into the future, Romus. The months w..."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "She blushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Lucita Azaro: ""If I am, it's because I learned from the best.""*)

### Węzeł `[132]`
Mówca: **Lucita Azaro**
> ""If I am, it's because I learned from the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "In the medical wing, we were received immediately by a gr..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lucita Azaro: ""Now that you're forming the new Wruhecist Royal Council,..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)

### Węzeł `[136]`
Mówca: **Lucita Azaro**
> ""Now that you're forming the new Wruhecist Royal Council, we don't have a reason for secrecy any more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RelationshipPublic == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Diplomatic == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lucita Azaro: ""I have to ask, Romus. Are you sure about these reforms?""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Diplomatic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RelationshipPublic == true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RelationshipPublic == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_RelationshipPublic == true)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucita Azaro: ""We can announce the pregnancy right away.""*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucita Azaro: ""We can announce the marriage and pregnancy right away.""*)

### Węzeł `[143]`
Mówca: **Lucita Azaro**
> ""I have to ask, Romus. Are you sure about these reforms?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Lucita Azaro: ""My family is reluctant enough to give up our power. If t..."*)

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""We can announce the pregnancy right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player_Romus: ""I'm glad you don't think poorly of the decision to disso..."*)
  - -> `[154]` (*Player_Romus: ""I can't wait to spread the gospel of St. Wruhec with you..."*)
  - -> `[157]` (*Player_Romus: ""The Kingdom may be changing. But the Royal Family will b..."*)

### Węzeł `[145]`
Mówca: **Lucita Azaro**
> ""We can announce the marriage and pregnancy right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player_Romus: ""I'm glad you don't think poorly of the decision to disso..."*)
  - -> `[154]` (*Player_Romus: ""I can't wait to spread the gospel of St. Wruhec with you..."*)
  - -> `[157]` (*Player_Romus: ""The Kingdom may be changing. But the Royal Family will b..."*)

### Węzeł `[146]`
Mówca: **Lucita Azaro**
> ""A poor choice of words, given his condition. But you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "In the medical wing, we were received immediately by a gr..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && ..."*)

### Węzeł `[148]`
Mówca: **Lucita Azaro**
> ""It's not *that* far into the future, Romus. The months will pass in a heartbeat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "In the medical wing, we were received immediately by a gr..."*)

### Węzeł `[149]`
Mówca: **Lucita Azaro**
> ""Give him a chance to prove himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "In the medical wing, we were received immediately by a gr..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "In the medical wing, we were received immediately by a group of nurses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "Lucita was rushed into a side room that contained Rizia's..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm glad you don't think poorly of the decision to dissolve the Council, by the way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucita Azaro), `[145]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Her face scrunched up."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "Her face scrunched up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lucita Azaro: ""I am Queen Consort. I'm above the Council now anyway.""*)

### Węzeł `[153]`
Mówca: **Lucita Azaro**
> ""I am Queen Consort. I'm above the Council now anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "In the medical wing, we were received immediately by a gr..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't wait to spread the gospel of St. Wruhec with you by my side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucita Azaro), `[145]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "She half-smiled."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "She half-smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucita Azaro: ""Yes.""*)

### Węzeł `[156]`
Mówca: **Lucita Azaro**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "In the medical wing, we were received immediately by a gr..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Kingdom may be changing. But the Royal Family will be forever.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Lucita Azaro), `[145]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "She squeezed my hand."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "She squeezed my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lucita Azaro: ""Yes.""*)

### Węzeł `[159]`
Mówca: **Narrator**
> "Lucita was rushed into a side room that contained Rizia's most state-of-the-art blood testing technology."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)

### Węzeł `[160]`
Mówca: **Narrator**
> "After two interminable hours in the waiting room, the doctors called me in and told me the news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "I was going to be a father again."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "I was going to be a father again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "By the end of the year, a new heir of Rizia would be born."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "By the end of the year, a new heir of Rizia would be born."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Lucita_Pregnant = true"*)

### Węzeł `[163]`
Mówca: **Narrator**
> "Pabel was standing over my bed with the morning paper. He had an unusually intense expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord"*)
  - -> `[168]` (*Player_Romus: ""Read the paper to me in bed. The King commands you.""*)
  - -> `[169]` (*Player_Romus: ""Let me guess. More bad news?""*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord"*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord)"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Romus: ""You don't need to bring me the paper. You're not my butl..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""Can't I sleep in a little longer?""*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to bring me the paper. You're not my butler anymore.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pabel_Lord"]`
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Pabel Adria: ""This is my copy of the Herald, thank you very much. But ..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Read the paper to me in bed. The King commands you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Pabel Adria: ""At once, sire.""*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me guess. More bad news?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Pabel Adria: ""I was just perusing today's Herald when I saw this.""*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't I sleep in a little longer?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pabel_Lord"]) == false`
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Pabel Adria: ""In a bit. Let me show you something first.""*)

### Węzeł `[171]`
Mówca: **Pabel Adria**
> ""In a bit. Let me show you something first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)

### Węzeł `[172]`
Mówca: **Pabel Adria**
> ""At once, sire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Pabel pulled back the covers and joined me in bed. He opened the newspaper and gestured at an article."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Pabel Adria: ""Rufus Gragg is at it again.""*)

### Węzeł `[174]`
Mówca: **Pabel Adria**
> ""Rufus Gragg is at it again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Player_Romus: ""Nobody cares what that old queen has to say.""*)
  - -> `[179]` (*Player_Romus: ""What's he writing this time?""*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_Media_Censored == true"*)
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Un..."*)

### Węzeł `[175]`
Mówca: **Pabel Adria**
> ""This is my copy of the Herald, thank you very much. But I wanted to show you something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)

### Węzeł `[176]`
Mówca: **Narrator**
> "Pabel sat down at the edge of the bed. He opened the newspaper and gestured at an article."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Pabel Adria: ""Rufus Gragg is at it again.""*)

### Węzeł `[177]`
Mówca: **Pabel Adria**
> ""I was just perusing today's Herald when I saw this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody cares what that old queen has to say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_Media_Censored == true"*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's he writing this time?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Pabel cleared his throat and adopted an exaggerated Rumbu..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_Media_Censored == true"*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_Media_Censored == true)"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player_Romus: ""Remind me. Why haven't I fired him yet?""*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player_Romus: ""However bad he is, I'm sure the Voice is worse.""*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remind me. Why haven't I fired him yet?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Law_Media_Censored"] == true`
- **Kontekst wejściowy (poprzednik):** `[174]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Pabel Adria: ""His gossip has been harmless up to now. A useful distrac..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However bad he is, I'm sure the Voice is worse.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[174]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Pabel Adria: ""Actually, the Voice has intelligently recognized that th..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Pabel cleared his throat and adopted an exaggerated Rumburgian accent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_Media_Censored == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_Media_Censored == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Pabel Adria: ""He's the only gossip columnist in the country. You can't..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Pabel Adria: ""He doesn't wield as much influence as he used to now tha..."*)

### Węzeł `[189]`
Mówca: **Pabel Adria**
> ""He's the only gossip columnist in the country. You can't deny his influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Pabel cleared his throat and adopted an exaggerated Rumbu..."*)

### Węzeł `[190]`
Mówca: **Pabel Adria**
> ""He doesn't wield as much influence as he used to now that the press has opened up. But still...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Pabel cleared his throat and adopted an exaggerated Rumbu..."*)

### Węzeł `[191]`
Mówca: **Pabel Adria**
> ""His gossip has been harmless up to now. A useful distraction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Pabel Adria: ""But this...""*)

### Węzeł `[192]`
Mówca: **Pabel Adria**
> ""Actually, the Voice has intelligently recognized that there are more urgent things to worry about than the King's love life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Pabel cleared his throat and adopted an exaggerated Rumbu..."*)

### Węzeł `[193]`
Mówca: **Pabel Adria**
> ""'Who *is* Lord Pabel Adria? From humble beginnings as a groundskeeper's son to head butler to the Royal Family, this man now commands both an estate in Rizia Imperii and the exclusive attention of the King himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_WeddingDate == true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Pabel Adria: ""'Who *is* Lord Pabel Adria? From humble beginnings as a ..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Pabel Adria: ""'Who *is* Pabel Adria? From humble beginnings as a groun..."*)

### Węzeł `[197]`
Mówca: **Pabel Adria**
> ""Since the Royal Wedding, Lord Adria has hardly strayed from His Majesty's side. They seem to share that rarest of treasures: a childhood friendship that has stretched well into middle age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Pabel Adria: ""Perhaps it is the depth of that special bond which has k..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_WeddingDate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_WeddingDate == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_WeddingDate == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_WeddingDate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_WeddingDate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Pabel Adria: ""Since the Royal Wedding, Lord Adria has hardly strayed f..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_WeddingDate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_WeddingDate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Pabel Adria: ""Though he keeps a low profile, Lord Adria has been seen ..."*)

### Węzeł `[201]`
Mówca: **Pabel Adria**
> ""Though he keeps a low profile, Lord Adria has been seen by His Majesty's side on numerous occasions. They seem to share that rarest of treasures: a childhood friendship that has stretched well into middle age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Pabel Adria: ""Perhaps it is the depth of that special bond which has k..."*)

### Węzeł `[202]`
Mówca: **Pabel Adria**
> ""'Who *is* Pabel Adria? From humble beginnings as a groundskeeper's son to head butler to the Royal Family, this man now commands the exclusive attention of the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Pabel Adria: ""His Majesty is hardly ever seen without Mr. Adria by his..."*)

### Węzeł `[203]`
Mówca: **Pabel Adria**
> ""His Majesty is hardly ever seen without Mr. Adria by his side. Not uncommon for a personal attendant, but these two seem to share that rarest of treasures: a childhood friendship that has stretched well into middle age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Pabel Adria: ""Perhaps it is the depth of that special bond which has k..."*)

### Węzeł `[204]`
Mówca: **Pabel Adria**
> ""Perhaps it is the depth of that special bond which has kept our King from seeking out a new Queen Consort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Pabel Adria: ""Or could it be that he has already found one?""*)

### Węzeł `[205]`
Mówca: **Pabel Adria**
> ""Or could it be that he has already found one?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Romus: ""I'm used to such speculations about me. But they should ..."*)
  - -> `[207]` (*Player_Romus: ""That's as bad as it gets? Ha. It's not like they can arr..."*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[208]` (*Player_Romus: ""If only you could be my Queen Consort, Pabel.""*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm used to such speculations about me. But they should leave you out of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Pabel Adria: ""I got myself into this when I got myself into your trous..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's as bad as it gets? Ha. It's not like they can arrest us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Pabel Adria: ""No, they can't. Thanks to you.""*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If only you could be my Queen Consort, Pabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[205]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Pabel Adria: ""Why not?""*)

### Węzeł `[209]`
Mówca: **Pabel Adria**
> ""But this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Pabel cleared his throat and adopted an exaggerated Rumbu..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter might die, dammit! Can't a King get any privacy?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[205]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Pabel Adria: ""Apparently not.""*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Player_Romus: ""My daughter might die, dammit! Can't a King get any priv..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[214]`
Mówca: **Pabel Adria**
> ""No, they can't. Thanks to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[215]`
Mówca: **Narrator**
> "He sighed wistfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Pabel Adria: ""What if we could just be out in the open about us?""*)

### Węzeł `[216]`
Mówca: **Pabel Adria**
> ""I got myself into this when I got myself into your trousers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[217]`
Mówca: **Pabel Adria**
> ""Apparently not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[218]`
Mówca: **Pabel Adria**
> ""What if we could just be out in the open about us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true || RiziaDLC.PromiseToAbdicat..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's true. My daughter's a prisoner. The worst thing that could ever happen to me has already happened.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[226]` (Pabel Adria), `[227]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Pabel Adria: ""I can't imagine how much pain you've been in.""*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player_Romus: ""It's true. My daughter's a prisoner. The worst thing tha..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == false"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true || RiziaDLC.PromiseToAbdicate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true || RiziaDLC.PromiseToAbdicat..."*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true || RiziaDLC.PromiseToAbdic..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true || RiziaDLC.PromiseToAbdicate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Pabel Adria: ""You told me you're planning on letting go of your power...."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true || RiziaDLC.PromiseToAbdicate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true  or  Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Pabel Adria: ""I mean it. What's the worst that could happen?""*)

### Węzeł `[226]`
Mówca: **Pabel Adria**
> ""You told me you're planning on letting go of your power. What's the worst that could happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[234]` (*Player_Romus: ""The entire world will know that the King of Rizia enjoys..."*)
  - -> `[229]` (*Player_Romus: ""You're right. I am the king. If my subjects love me, the..."*)

### Węzeł `[227]`
Mówca: **Pabel Adria**
> ""I mean it. What's the worst that could happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[234]` (*Player_Romus: ""The entire world will know that the King of Rizia enjoys..."*)
  - -> `[229]` (*Player_Romus: ""You're right. I am the king. If my subjects love me, the..."*)
  - -> `[228]` (*Player_Romus: ""I'll be usurped. Laughed off the throne. Perhaps even fr..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be usurped. Laughed off the throne. Perhaps even from within my own family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Pabel Adria: ""Is House Toras really so intolerant? Don't answer that.""*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I am the king. If my subjects love me, they'll love you as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Pabel Adria), `[227]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Pabel Adria: ""Let's be real. Not all of them will.""*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == false"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == false)"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Romus: ""Vina's got her heart set on being queen. I don't want to..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player_Romus: ""My daughter ran away. It's been one royal scandal after ..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina's got her heart set on being queen. I don't want to do anything to jeopardize that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == false` AND `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[226]` (Pabel Adria), `[227]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Pabel Adria: ""You being involved with a man won't disrupt the line of ..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The entire world will know that the King of Rizia enjoys the company of men.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Pabel Adria), `[227]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Pabel Adria: ""You'll be more famous than ever. But yes, not all of the..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My daughter ran away. It's been one royal scandal after another.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_Escapes"] == false) == false` AND `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[226]` (Pabel Adria), `[227]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Pabel Adria: ""Well, precisely. What's one more?""*)

### Węzeł `[236]`
Mówca: **Pabel Adria**
> ""You'll be more famous than ever. But yes, not all of the attention will be positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Pabel Adria: ""It's up to you. But think of what a relief it would be t..."*)

### Węzeł `[237]`
Mówca: **Pabel Adria**
> ""I can't imagine how much pain you've been in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Pabel Adria: ""Whether us going public will ease or compound that pain...."*)

### Węzeł `[238]`
Mówca: **Pabel Adria**
> ""Whether us going public will ease or compound that pain... I don't know, Rom. It's up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player_Romus: ""Let's test the waters first. We'll tell my mother.""*)
  - -> `[245]` (*Player_Romus: ""This is as out in the open as I'm willing to get, Pabel...."*)
  - -> `[523]` (*Player_Romus: ""It gladdens my heart that so many Rizians like us are no..."*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_Media_Censored"*)

### Węzeł `[239]`
Mówca: **Pabel Adria**
> ""You being involved with a man won't disrupt the line of succession. It'd be worse if you married a woman and had a boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Pabel Adria: ""It's up to you. But think of what a relief it would be t..."*)

### Węzeł `[240]`
Mówca: **Pabel Adria**
> ""It's up to you. But think of what a relief it would be to stop hiding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player_Romus: ""Let's test the waters first. We'll tell my mother.""*)
  - -> `[245]` (*Player_Romus: ""This is as out in the open as I'm willing to get, Pabel...."*)
  - -> `[523]` (*Player_Romus: ""It gladdens my heart that so many Rizians like us are no..."*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_Media_Censored"*)

### Węzeł `[241]`
Mówca: **Pabel Adria**
> ""Well, precisely. What's one more?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Pabel Adria: ""It's up to you. But think of what a relief it would be t..."*)

### Węzeł `[242]`
Mówca: **Pabel Adria**
> ""Let's be real. Not all of them will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Pabel Adria: ""It's up to you. But think of what a relief it would be t..."*)

### Węzeł `[243]`
Mówca: **Pabel Adria**
> ""Is House Toras really so intolerant? Don't answer that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Pabel Adria: ""It's up to you. But think of what a relief it would be t..."*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's test the waters first. We'll tell my mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Pabel Adria), `[240]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "He nodded his assent."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is as out in the open as I'm willing to get, Pabel. We shall continue as we have been. For the rest of our lives, if we have to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Pabel Adria), `[240]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Pabel Adria: ""All right. I understand.""*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_Media_Censored`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_Media_Censored"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_Media_Censored)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_Media_Censored`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_Media_Censored"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player_Romus: ""I'm having Rufus Gragg fired. My love life shall remain ..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_Media_Censored)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_Media_Censored"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm having Rufus Gragg fired. My love life shall remain private, and no speculation about it shall make it into the papers ever again.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Law_Media_Censored"]`
- **Kontekst wejściowy (poprzednik):** `[238]` (Pabel Adria), `[240]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.FireRufusGragg = true"*)

### Węzeł `[250]`
Mówca: **Pabel Adria**
> ""Why not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[251]`
Mówca: **Pabel Adria**
> ""All right. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Pabel Adria: ""But we can't go on forever like this. Sooner or later, t..."*)

### Węzeł `[252]`
Mówca: **Pabel Adria**
> ""But we can't go on forever like this. Sooner or later, the truth will out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "He got up and smoothed out his suit."*)

### Węzeł `[253]`
Mówca: **Narrator**
> "He got up and smoothed out his suit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Pabel Adria: ""If you'll excuse me, I have an estate that needs tending..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Pabel Adria: ""If you'll excuse me, I have chores that need tending to.""*)

### Węzeł `[257]`
Mówca: **Pabel Adria**
> ""If you'll excuse me, I have an estate that needs tending to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Narrator: "He bowed and walked out."*)

### Węzeł `[258]`
Mówca: **Pabel Adria**
> ""If you'll excuse me, I have chores that need tending to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Narrator: "He bowed and walked out."*)

### Węzeł `[259]`
Mówca: **Narrator**
> "He bowed and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[260]`
Mówca: **Narrator**
> "He nodded his assent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Pabel_..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Pabel_WeddingDate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Pabel_..."*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Pabe..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Pabel_WeddingDate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Pabel_WeddingDate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Pabel Adria: ""After our conversation at Vina's wedding, Madam Estela d..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Wedding_Happened == true && RiziaDLC.Pabel_WeddingDate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Wedding_Happened"] == true  and  Variable["RiziaDLC.Pabel_WeddingDate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Pabel Adria: ""The Queen Mother doesn't miss a thing that goes on in th..."*)

### Węzeł `[264]`
Mówca: **Pabel Adria**
> ""After our conversation at Vina's wedding, Madam Estela definitely suspects something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Bruno");"*)

### Węzeł `[265]`
Mówca: **Pabel Adria**
> ""The Queen Mother doesn't miss a thing that goes on in this palace. She must suspect something already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Bruno");"*)

### Węzeł `[266]`
Mówca: **Narrator**
> "We left my chambers and crossed the hall. I knocked on my mother's door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "She answered, still in her bathrobe."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "She answered, still in her bathrobe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Estela Toras: ""My goodness, son. What are you two doing here?""*)

### Węzeł `[268]`
Mówca: **Estela Toras**
> ""My goodness, son. What are you two doing here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""You should sit down, Mother.""*)
  - -> `[270]` (*Player_Romus: ""Pabel and I have something to tell you.""*)
  - -> `[271]` (*Player_Romus: ""Let's go to the balcony. I could use a smoke.""*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should sit down, Mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[268]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "We entered the room and sat on opposite sofas."*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel and I have something to tell you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[268]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "We entered the room and sat on opposite sofas."*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's go to the balcony. I could use a smoke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[268]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Estela Toras: ""Starting early today, are we?""*)

### Węzeł `[272]`
Mówca: **Narrator**
> "We entered the room and sat on opposite sofas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Estela Toras: ""Now. What is so urgent that you'd disturb an old lady's ..."*)

### Węzeł `[273]`
Mówca: **Estela Toras**
> ""Starting early today, are we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "We crossed the room and went onto the balcony. Mother lit..."*)

### Węzeł `[274]`
Mówca: **Narrator**
> "We crossed the room and went onto the balcony. Mother lit a cigarette and handed it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Estela Toras: ""Now. What is so urgent that you'd disturb an old lady's ..."*)

### Węzeł `[275]`
Mówca: **Estela Toras**
> ""Now. What is so urgent that you'd disturb an old lady's birthday preparations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Player_Romus: ""Mother... I am a homosexual.""*)
  - -> `[277]` (*Player_Romus: ""Pabel and I are in love. We have been for a long time.""*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[282]` (*Player_Romus: ""I risk bringing shame upon this family by loving a membe..."*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mother... I am a homosexual.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "My mother was very quiet for a long moment."*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel and I are in love. We have been for a long time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "My mother was very quiet for a long moment."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""This might come as a shock, but I am attracted to men as..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This might come as a shock, but I am attracted to men as well as women.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[275]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "My mother was very quiet for a long moment."*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I risk bringing shame upon this family by loving a member of the same sex.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "My mother was very quiet for a long moment."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "My mother was very quiet for a long moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "Then she burst out laughing."*)

### Węzeł `[284]`
Mówca: **Narrator**
> "Then she burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Estela Toras: ""Oh, darling. I know. I'm your mother, after all.""*)

### Węzeł `[285]`
Mówca: **Estela Toras**
> ""Oh, darling. I know. I'm your mother, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Estela Toras: ""I've been waiting for this news since you rolled out the..."*)

### Węzeł `[286]`
Mówca: **Estela Toras**
> ""The question remains, though. What exactly do you plan to do about it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Player_Romus: ""I want the world to know. We could set an example for mi..."*)
  - -> `[291]` (*Player_Romus: ""Sooner or later, everyone will find out. I should contro..."*)
  - -> `[290]` (*Player_Romus: ""We haven't decided yet.""*)
  - -> `[546]` (*Player_Romus: ""What do you think we should do?""*)

### Węzeł `[287]`
Mówca: **Estela Toras**
> ""I've been waiting for this news since you rolled out the rainbow carpet to homosexuals across the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "Pabel gave a smile of relief."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "Pabel gave a smile of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Estela Toras: ""The question remains, though. What exactly do you plan t..."*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want the world to know. We could set an example for millions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Her expression turned stern."*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We haven't decided yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Her expression turned stern."*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sooner or later, everyone will find out. I should control the narrative by making an announcement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Her expression turned stern."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "Her expression turned stern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Estela Toras: ""Listen to me very carefully, Romus.""*)

### Węzeł `[293]`
Mówca: **Estela Toras**
> ""Listen to me very carefully, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Estela Toras: ""I didn't fully know what I was signing up for when I mar..."*)

### Węzeł `[294]`
Mówca: **Estela Toras**
> ""I didn't fully know what I was signing up for when I married into House Toras. But I know now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)

### Węzeł `[295]`
Mówca: **Estela Toras**
> ""A husband poisoned by a religious lunatic...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Estela Toras: ""A precious daughter-in-law taken before her time...""*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == true)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Estela Toras: ""A husband poisoned by a religious lunatic...""*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Estela Toras: ""A husband known eternally as 'The Frail'...""*)

### Węzeł `[299]`
Mówca: **Estela Toras**
> ""A husband known eternally as 'The Frail'...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Estela Toras: ""A precious daughter-in-law taken before her time...""*)

### Węzeł `[300]`
Mówca: **Estela Toras**
> ""A precious daughter-in-law taken before her time...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true || (RiziaDLC.Rico_Deposed ..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true || (RiziaDLC.Rico_Deposed == true && RiziaDLC.Rico_PoliceChief_PorteDrazon == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true || (RiziaDLC.Rico_Deposed ..."*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Arrested == true || (RiziaDLC.Rico_Depose..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true || (RiziaDLC.Rico_Deposed == true && RiziaDLC.Rico_PoliceChief_PorteDrazon == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true  or  (Variable["RiziaDLC.Rico_Deposed"] == true  and  Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Estela Toras: ""A nephew ousted in disgrace...""*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Arrested == true || (RiziaDLC.Rico_Deposed == true && RiziaDLC.Rico_PoliceChief_PorteDrazon == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true  or  (Variable["RiziaDLC.Rico_Deposed"] == true  and  Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested == true"*)

### Węzeł `[304]`
Mówca: **Estela Toras**
> ""A nephew ousted in disgrace...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Resigned == true"*)

### Węzeł `[305]`
Mówca: **Estela Toras**
> ""His father humiliated to the point of resignation...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Resigned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Resigned == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Resigned == true)"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Resigned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Resigned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Estela Toras: ""His father humiliated to the point of resignation...""*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Resigned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Resigned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested == true"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Estela Toras: ""A granddaughter held hostage in a war that should never ..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)

### Węzeł `[312]`
Mówca: **Estela Toras**
> ""A granddaughter held hostage in a war that should never have happened in the first place...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == false"*)

### Węzeł `[313]`
Mówca: **Estela Toras**
> ""A granddaughter made miserable to the point of self-exile...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == false"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == true"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == true)"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Estela Toras: ""A granddaughter made miserable to the point of self-exil..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == false"*)

### Węzeł `[317]`
Mówca: **Narrator**
> "She pulled out a handkerchief and dabbed at her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Estela Toras: ""I love you, darling. But you can't bring more shame to t..."*)

### Węzeł `[318]`
Mówca: **Estela Toras**
> ""I love you, darling. But you can't bring more shame to this family. Especially not right before my birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Player_Romus: ""I'm surprised at you, Mother. I thought you'd support me.""*)
  - -> `[321]` (*Player_Romus: ""I am sorry. But none of this was my fault.""*)
  - -> `[322]` (*Player_Romus: ""You started it! You seduced my father and brought our no..."*)
  - -> `[323]` (*Player_Romus: ""I won't. I promise.""*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela == true"*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm surprised at you, Mother. I thought you'd support me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Narrator: "Pabel nodded in agreement."*)

### Węzeł `[320]`
Mówca: **Narrator**
> "Pabel nodded in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Estela Toras: ""I do support you. This is for your own good.""*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry. But none of this was my fault.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Estela Toras: ""That makes no difference. You carry the weight of your e..."*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You started it! You seduced my father and brought our noble house to ruin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Estela Toras: ""Seduced? Don't delude yourself.""*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't. I promise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Estela Toras: ""This is for your own good.""*)

### Węzeł `[324]`
Mówca: **Estela Toras**
> ""Seduced? Don't delude yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Estela Toras: ""If you want to live openly with your charming companion ..."*)

### Węzeł `[325]`
Mówca: **Estela Toras**
> ""That makes no difference. You carry the weight of your entire House on your shoulders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Estela Toras: ""If you want to live openly with your charming companion ..."*)

### Węzeł `[326]`
Mówca: **Estela Toras**
> ""This is for your own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Estela Toras: ""If you want to live openly with your charming companion ..."*)

### Węzeł `[327]`
Mówca: **Estela Toras**
> ""If you want to live openly with your charming companion here, by all means, do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Estela Toras: ""Just... not with the crown on your head. Please.""*)

### Węzeł `[328]`
Mówca: **Estela Toras**
> ""I do support you. This is for your own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Estela Toras: ""If you want to live openly with your charming companion ..."*)

### Węzeł `[329]`
Mówca: **Estela Toras**
> ""Just... not with the crown on your head. Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Estela Toras: ""Abdicate and live your truth. Or stay in power and hide ..."*)

### Węzeł `[330]`
Mówca: **Estela Toras**
> ""Abdicate and live your truth. Or stay in power and hide it. That's my advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "Pabel and I looked at each other, then at my mother once ..."*)

### Węzeł `[331]`
Mówca: **Narrator**
> "Pabel and I looked at each other, then at my mother once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Player_Romus: ""If I have to leave the throne to be with the man I love,..."*)
  - -> `[333]` (*Player_Romus: ""Your true colors are showing. I refuse to give in to you..."*)
  - -> `[547]` (*Player_Romus: ""I'm sorry, Mother. But I can't keep hiding who I am. The..."*)
  - -> `[334]` (*Player_Romus: ""You have made your point. As long as I am king, this wil..."*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I have to leave the throne to be with the man I love, I will. My work as King is not yet over, but I will take your advice seriously.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[331]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate =..."*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your true colors are showing. I refuse to give in to your bigotry. We will announce our love to the world.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[331]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic = true"*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have made your point. As long as I am king, this will be our secret.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[331]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "She nodded in approval."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "She nodded in approval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Estela Toras: ""Good boy.""*)

### Węzeł `[336]`
Mówca: **Estela Toras**
> ""Good boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord == true)"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Estela Toras: ""Now, Lord Adria. Don't you have an estate to attend to?""*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Estela Toras: ""Now, Mr. Adria. Don't you have chores to attend to?""*)

### Węzeł `[340]`
Mówca: **Estela Toras**
> ""Now, Lord Adria. Don't you have an estate to attend to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "Pabel nodded. He looked shaken."*)

### Węzeł `[341]`
Mówca: **Estela Toras**
> ""Now, Mr. Adria. Don't you have chores to attend to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "Pabel nodded. He looked shaken."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "Her jaw clenched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Estela Toras: ""You're making a mistake.""*)

### Węzeł `[343]`
Mówca: **Estela Toras**
> ""You're making a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Estela Toras: ""But I won't be the one to stop you.""*)

### Węzeł `[344]`
Mówca: **Estela Toras**
> ""But I won't be the one to stop you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Estela Toras: ""If you'll excuse me, I've got to put my face on before b..."*)

### Węzeł `[345]`
Mówca: **Narrator**
> "Pabel nodded. He looked shaken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Pabel Adria: ""Yes, madam. Sorry to trouble you.""*)

### Węzeł `[346]`
Mówca: **Pabel Adria**
> ""Yes, madam. Sorry to trouble you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Estela Toras: ""No problem at all.""*)

### Węzeł `[347]`
Mówca: **Estela Toras**
> ""No problem at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Narrator: "She swiftly ushered us both out the door and closed it wi..."*)

### Węzeł `[348]`
Mówca: **Narrator**
> "She swiftly ushered us both out the door and closed it without another word."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras");"*)

### Węzeł `[349]`
Mówca: **Estela Toras**
> ""If you'll excuse me, I've got to put my face on before breakfast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "Pabel nodded. He looked shaken."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == false"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == false)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Estela Toras: ""To add insult to injury, we lost Zille. If I may say so,..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "She pulled out a handkerchief and dabbed at her eyes."*)

### Węzeł `[353]`
Mówca: **Estela Toras**
> ""To add insult to injury, we lost Zille. If I may say so, dear... you had one job!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "She pulled out a handkerchief and dabbed at her eyes."*)

### Węzeł `[354]`
Mówca: **Narrator**
> "Pabel nodded. He looked shaken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Pabel Adria: ""Sorry to trouble you, madam.""*)

### Węzeł `[355]`
Mówca: **Pabel Adria**
> ""Sorry to trouble you, madam.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Estela Toras: ""No problem at all.""*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_SleepsInBed == true)"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: ""Did Bruno kick you out of bed again? Sorry, he does that.""*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_SleepsInBed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did Bruno kick you out of bed again? Sorry, he does that.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "She hesitated nervously."*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One moment. Bruno! You're going to be a big brother!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Kontekst wejściowy (poprzednik):** `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "AddConversant("Bruno");"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player_Romus: ""One moment. Bruno! You're going to be a big brother!""*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[364]`
Mówca: **Narrator**
> "My dog hopped on the bed and licked my face. Lucita scratched him behind the ears, then tugged my arm impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Lucita Azaro: ""Shall we?""*)

### Węzeł `[365]`
Mówca: **Lucita Azaro**
> ""Shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Narrator: "Bruno trailed a short distance behind as we walked down p..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RelationshipPublic == true"*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_RelationshipPublic == true)"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Titus Gordion: ""Congratulations, my king. You must be very proud.""*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Titus Gordion: ""This explains a lot. Congratulations, my king.""*)

### Węzeł `[369]`
Mówca: **Titus Gordion**
> ""This explains a lot. Congratulations, my king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""As a gesture of gratitude for your service to the Crown,..."*)
  - -> `[111]` (*Player_Romus: ""No time for chit-chat. We've got to get Lucita to the do..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Narrator: "Bruno hopped on the bed and licked Pabel's face. He sighe..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "He sighed wistfully."*)

### Węzeł `[373]`
Mówca: **Narrator**
> "Bruno hopped on the bed and licked Pabel's face. He sighed wistfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true || RiziaDLC.PromiseToAbdicat..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.FireRufusGragg = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.FireRufusGragg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Pabel Adria: ""All right. I understand.""*)

### Węzeł `[375]`
Mówca: **Pabel Adria**
> ""So that's it? After everything, you would really step down for me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true || RiziaDLC.Policy_Diploma..."*)
  - -> `[391]` (*Player_Romus: ""It will be a relief, to be honest. Being king is hard.""*)
  - -> `[392]` (*Player_Romus: ""I'm thinking about it. No promises yet.""*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "Her jaw clenched."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Narrator: "Pabel and I stood facing each other in the hallway."*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[378]`
Mówca: **Narrator**
> "Pabel and I stood facing each other in the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate =..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate =..."*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Pabel Adria: ""So that's it? After everything, you would really step do..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If my reforms succeed, my power will be symbolic. Why not live out the rest of my days in peace?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[375]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Pabel Adria: ""Why not, indeed?""*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true)"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Player_Romus: ""If my reforms succeed, my power will be symbolic. Why no..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've accomplished what I set out to do. Things can only go downhill from here.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Pales_Won"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true  or  Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Kontekst wejściowy (poprzednik):** `[375]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Pabel Adria: ""That's the spirit.""*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true || RiziaDLC.ZilleReturn_Success == true || RiziaDLC.Pales_Rizia_Unification == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won == true || RiziaDLC.Policy_Diploma..."*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Won == true || RiziaDLC.Policy_Diplo..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true || RiziaDLC.ZilleReturn_Success == true || RiziaDLC.Pales_Rizia_Unification == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Won"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true  or  Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Player_Romus: ""I've accomplished what I set out to do. Things can only ..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Won == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true || RiziaDLC.ZilleReturn_Success == true || RiziaDLC.Pales_Rizia_Unification == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Won"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true  or  Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Player_Romus: ""I have failed my kingdom anyway. I don't deserve my crown.""*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have failed my kingdom anyway. I don't deserve my crown.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Pales_Won"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true  or  Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.Pales_Rizia_Unification"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[375]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Pabel Adria: ""Don't be so hard on yourself.""*)

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It will be a relief, to be honest. Being king is hard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Pabel Adria: ""Having served two of you, I won't argue with that.""*)

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm thinking about it. No promises yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[375]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Pabel Adria: ""I understand.""*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true)"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Pabel Adria: ""So that's it? We're going public?""*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Pabel Adria: ""I guess that's it, then.""*)

### Węzeł `[396]`
Mówca: **Pabel Adria**
> ""So that's it? We're going public?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[405]` (*Player_Romus: ""Screw what my mother says. I refuse to be ashamed of my ..."*)
  - -> `[406]` (*Player_Romus: ""I'd rather not. But everyone will find out sooner or lat..."*)
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)

### Węzeł `[397]`
Mówca: **Pabel Adria**
> ""I guess that's it, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Player_Romus: ""I love you, Pabel. But I love being king more.""*)
  - -> `[488]` (*Player_Romus: ""You heard my mother. My family has been through enough.""*)
  - -> `[486]` (*Player_Romus: ""Just give it a few more years. The public will be ready ..."*)
  - -> `[487]` (*Player_Romus: ""You shouldn't be with me anymore, Pabel. Go meet someone..."*)

### Węzeł `[398]`
Mówca: **Pabel Adria**
> ""Madam Estela was right. I should be going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Narrator: "He rapidly turned away from me and walked down the hall."*)

### Węzeł `[399]`
Mówca: **Narrator**
> "He rapidly turned away from me and walked down the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Homosexuality is legal. You're a lord. There's nothing stopping us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Kontekst wejściowy (poprzednik):** `[396]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Pabel Adria: ""You're right.""*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord == true)"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Player_Romus: ""Homosexuality is legal. You're a lord. There's nothing s..."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Player_Romus: ""Homosexuality is legal. There's nothing stopping us.""*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Homosexuality is legal. There's nothing stopping us.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[396]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Pabel Adria: ""You're right.""*)

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Screw what my mother says. I refuse to be ashamed of my identity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Pabel Adria: ""You're right.""*)

### Węzeł `[406]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd rather not. But everyone will find out sooner or later. It's best to control the narrative.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[396]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Pabel Adria: ""You're right.""*)

### Węzeł `[407]`
Mówca: **Pabel Adria**
> ""You're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "He smirked."*)

### Węzeł `[408]`
Mówca: **Narrator**
> "He smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Pabel Adria: ""Shall we leak the news to Rufus Gragg? If anyone deserve..."*)

### Węzeł `[409]`
Mówca: **Pabel Adria**
> ""That's the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "He placed his hand in mine and we walked back down the ha..."*)

### Węzeł `[410]`
Mówca: **Pabel Adria**
> ""Don't be so hard on yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "He placed his hand in mine and we walked back down the ha..."*)

### Węzeł `[411]`
Mówca: **Pabel Adria**
> ""Why not, indeed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "He placed his hand in mine and we walked back down the ha..."*)

### Węzeł `[412]`
Mówca: **Pabel Adria**
> ""Having served two of you, I won't argue with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "He placed his hand in mine and we walked back down the ha..."*)

### Węzeł `[413]`
Mówca: **Pabel Adria**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Pabel Adria: ""I still wish Rizia were ready to be ruled by a King and ..."*)

### Węzeł `[414]`
Mówca: **Pabel Adria**
> ""I still wish Rizia were ready to be ruled by a King and a King Consort. But realistically... your mother has a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Narrator: "He placed his hand in mine and we walked back down the ha..."*)

### Węzeł `[415]`
Mówca: **Narrator**
> "He placed his hand in mine and we walked back down the hall together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "I thought about Mother's words. Perhaps the time would ha..."*)

### Węzeł `[416]`
Mówca: **Narrator**
> "I thought about Mother's words. Perhaps the time would have to come for me to end my reign."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Narrator: "But not just yet."*)

### Węzeł `[417]`
Mówca: **Narrator**
> "But not just yet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[418]`
Mówca: **Pabel Adria**
> ""Shall we leak the news to Rufus Gragg? If anyone deserves the scoop, he does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Player_Romus: ""Yes, let's. We'll make his career.""*)
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_Media_Censored == true"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Solitude", "R_Solitude_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Solitude","R_Solitude_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The morning sun streamed through the windows of my chambe..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_SleepsInBed == true)"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "AddConversant("Bruno");"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_SleepsInBed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "Pabel sat down at the edge of the bed. He opened the news..."*)

### Węzeł `[423]`
Mówca: **Narrator**
> "Bruno hopped off the bed as Pabel sat down. He opened the newspaper and gestured at an article."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Pabel Adria: ""Rufus Gragg is at it again.""*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_SleepsInBed == true"*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_SleepsInBed == true)"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_SleepsInBed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "AddConversant("Bruno");"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_SleepsInBed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_SleepsInBed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Pabel pulled back the covers and joined me in bed. He ope..."*)

### Węzeł `[427]`
Mówca: **Narrator**
> "Pabel gently shoved Bruno aside, pulled back the covers and joined me in bed. He opened the newspaper and gestured at an article."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Pabel Adria: ""Rufus Gragg is at it again.""*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");
RemoveConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");
RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectEstela == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela == true"*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectEstela == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Player_Romus: ""I know your religion despises homosexuality. But can't y..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectEstela == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know your religion despises homosexuality. But can't you make an exception for your son?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == true`
- **Kontekst wejściowy (poprzednik):** `[318]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Narrator: "She glanced around her."*)

### Węzeł `[433]`
Mówca: **Narrator**
> "She glanced around her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Estela Toras: ""My religion -- whatever it may be -- has nothing to do w..."*)

### Węzeł `[434]`
Mówca: **Estela Toras**
> ""My religion -- whatever it may be -- has nothing to do with what I'm saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Estela Toras: ""If you want to live openly with your charming companion ..."*)

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suspect my reign won't last much longer anyway. Might as well go out with a bang.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Unrest_NatDes_Happened"] == true` AND `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[396]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Pabel Adria: ""I don't know what you're thinking, but I draw the line a..."*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Unrest_NatDes_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Unrest_NatDes_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Unrest_NatDes_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Player_Romus: ""I suspect my reign won't last much longer anyway. Might ..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.Unrest_NatDes_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.Unrest_NatDes_Happened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[439]`
Mówca: **Pabel Adria**
> ""I don't know what you're thinking, but I draw the line at doing *that* in public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "He smirked."*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_Media_Censored == true"*)
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_Media_Censored == true)"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Player_Romus: ""No. In fact, I want him fired for smearing my good name...."*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player_Romus: ""No, let's give this to the Voice. That'll teach him for ..."*)

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. In fact, I want him fired for smearing my good name. Let's tell the main staff at the Herald.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Law_Media_Censored"] == true`
- **Kontekst wejściowy (poprzednik):** `[418]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, let's give this to the Voice. That'll teach him for being such a busybody.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Law_Media_Censored"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[418]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, let's. We'll make his career.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[446]`
Mówca: **Pabel Adria**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Pabel Adria: ""If we're lucky, it'll make the front page.""*)

### Węzeł `[447]`
Mówca: **Pabel Adria**
> ""If we're lucky, it'll make the front page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Narrator: "He placed his hand in mine. We walked back down the hall ..."*)

### Węzeł `[448]`
Mówca: **Narrator**
> "He placed his hand in mine. We walked back down the hall together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord == true)"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Lord = true..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Butler = tr..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord == true)"*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Lord = true"*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Butler = true"*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord == true)"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Lord..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Butl..."*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Butler = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Butler"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Pabel Adria: ""As you wish.""*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Lord = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_V_KingOpenlyGay_Lord"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Pabel Adria: ""As you wish.""*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Butler = true; RiziaDLC.FireRufusGragg = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Butler"] = true;
Variable["RiziaDLC.FireRufusGragg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Pabel Adria: ""As you wish.""*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Lord = true; RiziaDLC.FireRufusGragg = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_KingHomosexual_Lord"] = true;
Variable["RiziaDLC.FireRufusGragg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Pabel Adria: ""As you wish.""*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Butler = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Butler"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Pabel Adria: ""If we're lucky, it'll make the front page.""*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Lord = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_KingHomosexual_Lord"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Pabel Adria: ""If we're lucky, it'll make the front page.""*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion -= 3;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic = true"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic = true"*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord == true)"*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion -= 2;"*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion -= 3;"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Lucita_Pregnant = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Lucita_Pregnant"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RelationshipPublic == false"*)

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is still no word about Vina. I may have to make the call at one point.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Escapes"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucita Azaro: ""We'll get through it together.""*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true)"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_OutOfCloset");"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_OutOfCloset");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_OutOfCloset");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested == true"*)
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Arrested == true)"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Estela Toras: ""His father found guilty of poisoning his own brother -- ..."*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[480]`
Mówca: **Estela Toras**
> ""His father found guilty of poisoning his own brother -- my husband...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[481]`
Mówca: **Estela Toras**
> ""A brother-in-law capable of fratricide...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_Arrested == true"*)
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_Arrested == true)"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Estela Toras: ""A brother-in-law capable of fratricide...""*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I love you, Pabel. But I love being king more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[397]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Pabel Adria: ""Madam Estela was right. I should be going.""*)

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just give it a few more years. The public will be ready for us someday.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[397]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Narrator: "He smiled sadly and kissed me on the cheek."*)

### Węzeł `[487]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't be with me anymore, Pabel. Go meet someone else. Be free.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[397]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Narrator: "He smiled sadly and kissed me on the cheek."*)

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You heard my mother. My family has been through enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[397]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Pabel Adria: ""Madam Estela was right. I should be going.""*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_Hostage =..."*)
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_Hostage..."*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Romus: ""What do I tell Vina? Her inheritance might be at stake.""*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Escapes == false && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Escapes"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure you don't want to wait until after Mother's birthday?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Narrator: "She scoffed."*)

### Węzeł `[493]`
Mówca: **Narrator**
> "She scoffed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Lucita Azaro: ""That's what you're concerned about? Come on, let's go.""*)

### Węzeł `[494]`
Mówca: **Lucita Azaro**
> ""That's what you're concerned about? Come on, let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Narrator: "We walked down palace corridors towards the medical wing."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Wedding_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Wedding_Happened == true"*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Wedding_Happened == true)"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Wedding_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Wedding_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Lucita Azaro: ""...And her husband, of course.""*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Wedding_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Wedding_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Narrator: "We walked down palace corridors towards the medical wing."*)

### Węzeł `[498]`
Mówca: **Lucita Azaro**
> ""...And her husband, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Narrator: "We walked down palace corridors towards the medical wing."*)

### Węzeł `[499]`
Mówca: **Lucita Azaro**
> ""My family is reluctant enough to give up our power. If they know they've got a potential heir on the throne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true || RiziaDLC.Reform_L..."*)
  - -> `[504]` (*Player_Romus: ""But you'll convince them reform is the right way to go. ..."*)
  - -> `[505]` (*Player_Romus: ""The royal baby will be a Toras, anyway. Not an Azaro.""*)
  - -> `[509]` (*Player_Romus: ""If they're truly concerned for the safety of their unbor..."*)

### Węzeł `[500]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The monarchy's barely changing under the new constitution. The Azaros and everyone else have nothing to worry about.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Kontekst wejściowy (poprzednik):** `[499]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Lucita Azaro: ""My father will have to be the judge of that.""*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true || RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Monarch_Veto == true || RiziaDLC.Reform_L..."*)
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Monarch_Veto == true || RiziaDLC.Reform..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Monarch_Veto == true || RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Player_Romus: ""The monarchy's barely changing under the new constitutio..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Monarch_Veto == true || RiziaDLC.Reform_Legislative_HouseOfLords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Player_Romus: ""The Rizian Royal Family shall still reign, my dear. The ..."*)

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But you'll convince them reform is the right way to go. Yes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[499]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Lucita Azaro: ""I'll try my best. But not if the reforms go directly aga..."*)

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The royal baby will be a Toras, anyway. Not an Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[499]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Lucita Azaro: ""In name only. I'll teach him to swordfight before he can..."*)

### Węzeł `[506]`
Mówca: **Lucita Azaro**
> ""In name only. I'll teach him to swordfight before he can even walk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "In the medical wing, we were received immediately by a gr..."*)

### Węzeł `[507]`
Mówca: **Lucita Azaro**
> ""I'll try my best. But not if the reforms go directly against their interests. You have to understand that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "In the medical wing, we were received immediately by a gr..."*)

### Węzeł `[508]`
Mówca: **Lucita Azaro**
> ""My father will have to be the judge of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "In the medical wing, we were received immediately by a gr..."*)

### Węzeł `[509]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they're truly concerned for the safety of their unborn heir, they'll agree to these changes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[499]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Narrator: "She swallowed."*)

### Węzeł `[510]`
Mówca: **Narrator**
> "She swallowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Lucita Azaro: ""All right.""*)

### Węzeł `[511]`
Mówca: **Lucita Azaro**
> ""All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "In the medical wing, we were received immediately by a gr..."*)

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Rizian Royal Family shall still reign, my dear. The Azaros will be lucky to be part of it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Monarch_Veto"] == true  or  Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[499]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Lucita Azaro: ""My father's going to want more than that. And I'm not su..."*)

### Węzeł `[513]`
Mówca: **Lucita Azaro**
> ""My father's going to want more than that. And I'm not sure he can be convinced otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "In the medical wing, we were received immediately by a gr..."*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true && RiziaDLC.Reform_Diplomatic == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true && RiziaDLC.Reform_Diplomati..."*)
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true && RiziaDLC.Reform_Diploma..."*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true && RiziaDLC.Reform_Diplomatic == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Lucita Azaro: ""And you've been disappearing off God knows where...""*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true && RiziaDLC.Reform_Diplomatic == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.Reform_Diplomatic"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""I wasn't even sure how you would take the news.""*)

### Węzeł `[517]`
Mówca: **Lucita Azaro**
> ""And you've been disappearing off God knows where...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Lucita Azaro: ""I wasn't even sure how you would take the news.""*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Un..."*)
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_..."*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Player_Romus: ""With everything that's been going on, you'd think he'd g..."*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With everything that's been going on, you'd think he'd give it a rest.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Kontekst wejściowy (poprzednik):** `[174]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Pabel Adria: ""Gossip is a welcome distraction from times of turmoil. I..."*)

### Węzeł `[522]`
Mówca: **Pabel Adria**
> ""Gossip is a welcome distraction from times of turmoil. I get it. But listen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Pabel cleared his throat and adopted an exaggerated Rumbu..."*)

### Węzeł `[523]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It gladdens my heart that so many Rizians like us are now able to live freely. But it's never going to be us, Pabel. Not as long as I am King.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Pabel Adria), `[240]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Narrator: "He looked at me for a moment, crestfallen, then embraced ..."*)

### Węzeł `[524]`
Mówca: **Narrator**
> "He looked at me for a moment, crestfallen, then embraced me tightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Pabel Adria: ""I always thought, maybe someday...""*)

### Węzeł `[525]`
Mówca: **Pabel Adria**
> ""I always thought, maybe someday...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Pabel Adria: ""But you're right. You're a royal. Your life is not entir..."*)

### Węzeł `[526]`
Mówca: **Pabel Adria**
> ""But you're right. You're a royal. Your life is not entirely yours to lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Player_Romus: ""It isn't. But I still want to share it with you.""*)
  - -> `[528]` (*Player_Romus: ""I may not rule Rizia forever. 'Someday' could come soone..."*)
  - -> `[530]` (*Player_Romus: ""It is. I'm just a coward.""*)
  - -> `[533]` (*Player_Romus: ""What about your life? You deserve to be with someone who..."*)

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It isn't. But I still want to share it with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[526]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Pabel Adria: ""Bi mare volu, un oxit solu.""*)

### Węzeł `[528]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I may not rule Rizia forever. 'Someday' could come sooner than you think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[526]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Pabel Adria: ""Rom. I could never ask you to give up the throne for me.""*)

### Węzeł `[529]`
Mówca: **Pabel Adria**
> ""Rom. I could never ask you to give up the throne for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Scar == true"*)

### Węzeł `[530]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is. I'm just a coward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[526]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Pabel Adria: ""You're my coward.""*)

### Węzeł `[531]`
Mówca: **Pabel Adria**
> ""You're my coward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Scar == true"*)

### Węzeł `[532]`
Mówca: **Pabel Adria**
> ""Bi mare volu, un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Scar == true"*)

### Węzeł `[533]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What about your life? You deserve to be with someone who can show you off like the jewel you are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[526]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Pabel Adria: ""Touching, Rom. But I can't give you up that easily.""*)

### Węzeł `[534]`
Mówca: **Pabel Adria**
> ""Touching, Rom. But I can't give you up that easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Scar == true"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Scar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Scar == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Scar == true)"*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Scar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Scar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Narrator: "He pulled back and traced the scar on my chest with his f..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Scar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Scar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Narrator: "He pulled back and traced my bare collarbone with his fin..."*)

### Węzeł `[538]`
Mówca: **Narrator**
> "He pulled back and traced the scar on my chest with his fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[539]`
Mówca: **Narrator**
> "He pulled back and traced my bare collarbone with his fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord == true)"*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Pabel Adria: ""I'll see you at the Queen Mother's birthday. As an estee..."*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Pabel Adria: ""I should get going. Lots to do before the Queen Mother's..."*)

### Węzeł `[543]`
Mówca: **Pabel Adria**
> ""I'll see you at the Queen Mother's birthday. As an esteemed guest, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Narrator: "He kissed me, bowed and walked out."*)

### Węzeł `[544]`
Mówca: **Pabel Adria**
> ""I should get going. Lots to do before the Queen Mother's birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Narrator: "He kissed me, bowed and walked out."*)

### Węzeł `[545]`
Mówca: **Narrator**
> "He kissed me, bowed and walked out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think we should do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[286]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Her expression turned stern."*)

### Węzeł `[547]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, Mother. But I can't keep hiding who I am. The birthday party will be our debut as a couple.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[331]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic = true"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "Her jaw clenched."*)

### Węzeł `[549]`
Mówca: **Narrator**
> "He smiled sadly and kissed me on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Pabel Adria: ""I've waited this long. A few more years won't hurt.""*)

### Węzeł `[550]`
Mówca: **Pabel Adria**
> ""I've waited this long. A few more years won't hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[551]`
Mówca: **Narrator**
> "He smiled sadly and kissed me on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Pabel Adria: ""You say that as if loving you were a choice.""*)

### Węzeł `[552]`
Mówca: **Pabel Adria**
> ""You say that as if loving you were a choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_Lord == true"*)
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_Lord == true)"*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Pabel Adria: ""I'll see you at the Queen Mother's birthday. As an estee..."*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Pabel Adria: ""I should get going. Lots to do before the Queen Mother's..."*)

### Węzeł `[556]`
Mówca: **Pabel Adria**
> ""I'll see you at the Queen Mother's birthday. As an esteemed guest, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "He kissed me again, bowed and walked away."*)

### Węzeł `[557]`
Mówca: **Pabel Adria**
> ""I should get going. Lots to do before the Queen Mother's birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "He kissed me again, bowed and walked away."*)

### Węzeł `[558]`
Mówca: **Narrator**
> "He kissed me again, bowed and walked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewWifeAndChild = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewWifeAndChild"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Pregnant = true; RiziaDLCText.LucitaToPla..."*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RelationshipPublic == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_RelationshipPublic == false"*)
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_RelationshipPublic == false)"*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_RelationshipPublic == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_RelationshipPublic"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewWifeAndChil..."*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_RelationshipPublic == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_RelationshipPublic"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewChild = true"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewChild = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn10_RH_Gossip_KingsNewChild"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Pregnant = true; RiziaDLCText.LucitaToPla..."*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Pregnant = true;
RiziaDLCText.LucitaToPlayer = "Romus";
EnableCodexEntry("Characters_Council_LucitaAzaro_Married");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Lucita_Pregnant"] = true;
Variable["RiziaDLCText.LucitaToPlayer"] ="Romus";
EnableCodexEntry("Characters_Council_LucitaAzaro_Married");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Narrator: "Bruno hopped off the bed as Pabel sat down. He opened the..."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Narrator: "Pabel gently shoved Bruno aside, pulled back the covers a..."*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn10_Pabel_DecisionToAbdicate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "She nodded in approval."*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction == true)"*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Player_Romus: ""Trust me. After my mother's birthday party, nobody will ..."*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me. After my mother's birthday party, nobody will be talking about our relationship anymore.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Kontekst wejściowy (poprzednik):** `[396]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Pabel Adria: ""I don't know if I like the sound of that... But all right.""*)

### Węzeł `[572]`
Mówca: **Pabel Adria**
> ""I don't know if I like the sound of that... But all right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "He smirked."*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We left my chambers and crossed the hall. I knocked on my..."*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "My dog hopped on the bed and licked my face. Lucita scrat..."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true )`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true )`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true )`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Narrator: "As I was waiting for her to re-emerge, Titus whispered in..."*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true || (RiziaDLC.Reform_Path == true && RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard == true ))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  or  (Variable["RiziaDLC.Reform_Path"] == true  and  Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] == true )) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "After two interminable hours in the waiting room, the doc..."*)

### Węzeł `[578]`
Mówca: **Narrator**
> "As I was waiting for her to re-emerge, Titus whispered in my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Titus Gordion: ""Your Majesty, do you still want to go through with the p..."*)

### Węzeł `[579]`
Mówca: **Titus Gordion**
> ""Your Majesty, do you still want to go through with the plans we talked about? As it stands, you would be putting the Queen Consort -- and your own unborn child -- in great danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Player_Romus: ""I know, but I have no choice. We're doing this.""*)
  - -> `[585]` (*Player_Romus: ""I will make sure nothing happens to either of them.""*)
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)

### Węzeł `[580]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know, but I have no choice. We're doing this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[579]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Narrator: "Titus gave a grim nod."*)

### Węzeł `[581]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. We won't strike against House Azaro that night.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Kontekst wejściowy (poprzednik):** `[579]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Narrator: "Titus nodded quickly."*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == tru..."*)
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Player_Romus: ""You're right. We won't strike against House Azaro that n..."*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true || RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Player_Romus: ""You're right. Let's call off the plan. It's too risky.""*)

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will make sure nothing happens to either of them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[579]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Titus Gordion: ""I suppose even in her condition, Lucita is more than cap..."*)

### Węzeł `[586]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Let's call off the plan. It's too risky.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true  or  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[579]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction = false; RiziaDL..."*)

### Węzeł `[587]`
Mówca: **Narrator**
> "Titus gave a grim nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Titus Gordion: ""As you wish, Your Majesty.""*)

### Węzeł `[588]`
Mówca: **Titus Gordion**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "After two interminable hours in the waiting room, the doc..."*)

### Węzeł `[589]`
Mówca: **Titus Gordion**
> ""I suppose even in her condition, Lucita is more than capable of protecting herself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "After two interminable hours in the waiting room, the doc..."*)

### Węzeł `[590]`
Mówca: **Narrator**
> "Titus nodded quickly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro = false"*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Titus Gordion: ""As you wish, Your Majesty.""*)

### Węzeł `[592]`
Mówca: **Narrator**
> "Titus gave a furtive sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB = fal..."*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB = false; RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard = false; RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians = false;
RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ReformTalks_ViolentPlanB"] = false;
Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_GoldenGuard"] = false;
Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_WruhecsGuardians"] = false;
Variable["RiziaDLC.BirthdayGathering_ViolentAction_Deploy_RustyPMC"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Titus Gordion: ""As you wish, Your Majesty.""*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction = false;
RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike = false;
RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] = false;
Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] = false;
Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Narrator: "Titus gave a furtive sigh of relief."*)

### Węzeł `[595]`
Mówca: **Narrator**
> "Bruno trailed a short distance behind as we walked down palace corridors towards the medical wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion"); RemoveConversant("Pabe..."*)

### Węzeł `[596]`
Mówca: **Narrator**
> "Pabel trailed a short distance behind as we walked down palace corridors towards the medical wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion"); RemoveConversant("Pabe..."*)

### Węzeł `[597]`
Mówca: **Narrator**
> "We walked down palace corridors towards the medical wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion"); RemoveConversant("Pabe..."*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && ..."*)
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true &..."*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic"] == true  and  Variable["RiziaDLC.Pabel_Lord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 2;"*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic"] == true  and  Variable["RiziaDLC.Pabel_Lord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && ..."*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && ..."*)
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true &..."*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic"] == true  and  Variable["RiziaDLC.Pabel_Lord"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1;"*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic == true && RiziaDLC.Pabel_Lord == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCSupport.Journal_Turn10_Pabel_GoPublic"] == true  and  Variable["RiziaDLC.Pabel_Lord"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
