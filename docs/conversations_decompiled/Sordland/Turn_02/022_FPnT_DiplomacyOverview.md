# Sordland/Turn02/FPnT_DiplomacyOverview

- **ID konwersacji:** `22`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/022_FPnT_DiplomacyOverview.md`
- **Liczba węzłów dialogowych:** 520
- **Liczba wyborów gracza:** 85

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[38]** Lucian Galade
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople`
- `BaseGame.Decision_Turn02_Funeral_DontAttend`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_Diplomatic`
- `BaseGame.Prologue_Party_Takeover_PublicBlame`
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Prologue_Studyplace_Holsord_Law`
- `BaseGame.Prologue_Studyplace_Lachaven_Economics`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Promise_Immigration_Relaxed`
- `BaseGame.Promise_Immigration_Tighten`
- `BaseGame.Promise_TermFocus_Military`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_FPnT_Consulate_Condemn`
- `BaseGame.Turn02_FPnT_Consulate_Retaliate`
- `BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc`
- `BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub`
- `BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer`
- `BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia`
- `BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy`
- `BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Turn02_FPnT_Consulate_Condemn`
- `BaseGame.Turn02_FPnT_Consulate_Retaliate`
- `BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention`
- `BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc`
- `BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub`
- `BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer`
- `BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia`
- `BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy`
- `BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen`
- `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint`
- `BaseGameSupport.FactionReport_Turn02_CSP_IyotakePlanRika`
- `BaseGameSupport.Journal_Turn02_ClosedSordlandConsulateInRumburg`
- `BaseGameSupport.Journal_Turn02_CondemnedRumburg`
- `BaseGameSupport.Journal_Turn02_RiziaEnergy_Interest`
- `BaseGameSupport.News_Turn02_E_EPARepealSupport`
- `BaseGameSupport.News_Turn02_G_PalesLesPower`
- `BaseGameSupport.News_Turn02_G_SordlandCloses`
- `BaseGameSupport.News_Turn02_G_SordlandCondemns`
- `BaseGameSupport.News_Turn02_HP_AnricaEmergency`
- `BaseGameSupport.News_Turn02_HP_EPARepealAttempt`
- `BaseGameSupport.News_Turn02_HP_RemusAntiWorkBill`
- `BaseGameSupport.News_Turn02_LT_ForeignSkilledWorkers`
- `BaseGameSupport.News_Turn02_LT_NarbelWelfare`
- `BaseGameSupport.News_Turn02_LT_UnrestContinues`
- `BaseGameSupport.News_Turn02_R_WeNeedDemocracy`
- `BaseGameSupport.News_Turn02_ST_AlphonsoFoundation`
- `BaseGameSupport.News_Turn02_ST_PresidentAbsent`
- `BaseGameSupport.Report_Turn02_Arvory_YSLinksToGovernment`
- `BaseGameSupport.Report_Turn02_Estord_CPSLUSProtest`
- `BaseGameSupport.Report_Turn02_Holsord_EPARepealProposal`
- `BaseGameSupport.Report_Turn02_Holsord_GNAGreenBill`
- `BaseGameSupport.Report_Turn02_Lachaven_CPSLUSPicketLine`
- `GameCondition.Turn02_FPnT_DiplomacyOverview`

### Skoki między-konwersacyjne:
- Węzeł `[66]` -> **[23] Sordland/Turn02/Neighbor Overview Hubs** (../Turn_02/023_Neighbor_Overview_Hubs.md), Węzeł `[1]`
- Węzeł `[169]` -> **[23] Sordland/Turn02/Neighbor Overview Hubs** (../Turn_02/023_Neighbor_Overview_Hubs.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"“Leave the formalities aside, Deivid. Please take a seat.”"** | `[6]` **Deivid Wisci**: "“May I sit down, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Deivid Wisci**: "“Ah right. Anton, I am used to t..." |
| `[4]` | **"Gesture at the chair."** | `[6]` **Deivid Wisci**: "“May I sit down, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Deivid Wisci**: "“Good to see you.”" |
| `[5]` | **"“Of course. It's a pleasure to see you, Mr. Wisci.”"** | `[6]` **Deivid Wisci**: "“May I sit down, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Deivid Wisci**: "“Likewise. We have so much ahead..." |
| `[10]` | **"“Would you like some tea or water?”"** | `[11]` **Narrator**: "He started coughing again. This ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Deivid Wisci**: "“Oh yes, please. Tea and water s..." |
| `[15]` | **"“Let's begin.”"** | `[60]` **Deivid Wisci**: "“We'll talk more later, Presiden..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Deivid Wisci**: "“Very well.”" |
| `[16]` | **"“How was your travel to Lachaven?”"** | `[60]` **Deivid Wisci**: "“We'll talk more later, Presiden..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Iosef Lancea**: "“A little bumpy due to some turb..." |
| `[40]` | **"“I'd rather not remember. It felt like a gargantuan task.”"** | `[30]` **Deivid Wisci**: "“And remember how hard we worked..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Deivid Wisci**: "“That accomplishment enabled you..." |
| `[41]` | **"“This is our opportunity to shape the future and we will do precisely that.”"** | `[9]` **Deivid Wisci**: "“Somehow the inexplicable ebb an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Deivid Wisci**: "“I am looking forward to our new..." |
| `[42]` | **"“Countless late nights at the Ministry to finalise. It was an experience for sure.”"** | `[30]` **Deivid Wisci**: "“And remember how hard we worked..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Deivid Wisci**: "“We signed our best trade deal y..." |
| `[43]` | **"“We got a little lucky. That's all.”"** | `[9]` **Deivid Wisci**: "“Somehow the inexplicable ebb an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Deivid Wisci**: "“Our work surely contributed. Ev..." |
| `[44]` | **"“Everything happens for a reason, Deivid. It was meant to be.”"** | `[9]` **Deivid Wisci**: "“Somehow the inexplicable ebb an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Deivid Wisci**: "“Maybe, maybe not. I don't belie..." |
| `[53]` | **"“Has your niece Margi started going to the kindergarten yet?”"** | `[14]` **Deivid Wisci**: "“It seems you still remember how..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Deivid Wisci**: "“Yes, she has. Spending time wit..." |
| `[54]` | **"“How is your health, Deivid?”"** | `[11]` **Narrator**: "He started coughing again. This ..."<br>`[14]` **Deivid Wisci**: "“It seems you still remember how..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Deivid Wisci**: "“Oh, I haven't had any big compl..." |
| `[56]` | **"“So how is your wife Cathrin doing?”"** | `[14]` **Deivid Wisci**: "“It seems you still remember how..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Deivid Wisci**: "“My lovely Cathrin is as energet..." |
| `[58]` | **"“Monica is really taking to the First Lady role.”"** | `[61]` **Deivid Wisci**: "“How is the Rayne family?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Deivid Wisci**: "“As time passes, I realize it mo..." |
| `[59]` | **"“Franc never liked the spotlight, so that hasn't changed.”"** | `[61]` **Deivid Wisci**: "“How is the Rayne family?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Deivid Wisci**: "“As time passes, I realize it mo..." |
| `[62]` | **"“Let's start talking about our foreign policy.”"** | `[11]` **Narrator**: "He started coughing again. This ..."<br>`[14]` **Deivid Wisci**: "“It seems you still remember how..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Narrator**: "The door opened. Iosef and Lucia..." |
| `[65]` | **"“We are slowly starting to get used to the routine.”"** | `[61]` **Deivid Wisci**: "“How is the Rayne family?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Deivid Wisci**: "“As time passes, I realize it mo..." |
| `[71]` | **"“You may be right. It's risky.”"** | `[115]` **Deivid Wisci**: "“I am of the opinion that it is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Lucian Galade**: "“I tend to agree.”" |
| `[75]` | **"“We are accustomed to the usual rhetoric but this is far more serious.”"** | `[139]` **Deivid Wisci**: "“Now there are only two Rumburg ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Petr Vectern**: "“They are playing with fire. Loo..." |
| `[80]` | **"“They have a point, Petr. We should have discipline in the cabinet.”"** | `[76]` **Lucian Galade**: "“Punctuality is important. We ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Petr Vectern**: "“Excuse me. It won't happen again.”" |
| `[81]` | **"“Petr was assigned a task from me, that is why he is late so let's move on.”"** | `[76]` **Lucian Galade**: "“Punctuality is important. We ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Petr Vectern**: "“Ah, yes, yes. It went successfu..." |
| `[82]` | **"Don't comment."** | `[76]` **Lucian Galade**: "“Punctuality is important. We ar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Petr Vectern**: "“It was a one-time thing. Let's ..." |
| `[83]` | **"“They are bluffing. We are used to it by now.”"** | `[139]` **Deivid Wisci**: "“Now there are only two Rumburg ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Petr Vectern**: "“They could be. We beat them onc..." |
| `[100]` | **"“Write an official diplomatic response condemning this unreasonable act. Declare t..."** | `[128]` **Iosef Lancea**: "“The people of Sordland must be ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn02_CondemnedRumburg...` | `[122]` **Deivid Wisci**: "“As you wish Mr. President. I sh..." |
| `[101]` | **"“Retaliate by closing the Sordland Consulate in Dome! They think they can bully us..."** | `[128]` **Iosef Lancea**: "“The people of Sordland must be ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn02_ClosedSordlandCo...`<br>*(+1 skryptów)* | `[116]` **Deivid Wisci**: "“As you wish Mr. President. I sh..." |
| `[103]` | **"“We should talk about the ongoing trade negotiations with our neighbors Wehlen and..."** | `[266]` **Deivid Wisci**: "“There are three trade-related t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Deivid Wisci**: "“Our primary goal will be to suc..." |
| `[104]` | **"“See you later, gentlemen.”"** | `[111]` **Deivid Wisci**: "“Well, that concludes our meetin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Lucian Galade**: "“I will take my leave then.”" |
| `[105]` | **"“Have a good day and enjoy Lachaven.”"** | `[111]` **Deivid Wisci**: "“Well, that concludes our meetin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Lucian Galade**: "“I will take my leave then.”" |
| `[108]` | **"“Thank you all for coming.”"** | `[111]` **Deivid Wisci**: "“Well, that concludes our meetin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Lucian Galade**: "“I will take my leave then.”" |
| `[112]` | **"“Tell me about the trade deal with Agnolia.”"** | `[110]` **Deivid Wisci**: "“We have two options with our tr..."<br>`[207]` **Lucian Galade**: "“Ultimately the decision will be..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia"] == false` | *Brak zmian stanu* | `[202]` **Deivid Wisci**: "“First off, the reason behind th..." |
| `[113]` | **"“Tell me about the trade deal with Wehlen.”"** | `[110]` **Deivid Wisci**: "“We have two options with our tr..."<br>`[207]` **Lucian Galade**: "“Ultimately the decision will be..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen"] == false` | *Brak zmian stanu* | `[212]` **Deivid Wisci**: "“Dealing with a fractured countr..." |
| `[120]` | **"“The security situation is under control, they are playing with us.”"** | `[114]` **Iosef Lancea**: "“Bastards! First they close thei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Petr Vectern**: "“Isn't it telling that other cou..." |
| `[121]` | **"“Their concerns could be genuine but this reaction is unnecessary.”"** | `[114]` **Iosef Lancea**: "“Bastards! First they close thei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Petr Vectern**: "“Agreed. Other diplomatic missio..." |
| `[140]` | **"“I would be open to creating a new agreement that would satisfy all sides.”"** | `[137]` **Deivid Wisci**: "“The downside is that we would n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Deivid Wisci**: "“That would be the best outcome.”" |
| `[141]` | **"“I don't want to give any concessions to them.”"** | `[137]` **Deivid Wisci**: "“The downside is that we would n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Deivid Wisci**: "“It might be unsatisfactory in t..." |
| `[142]` | **"“I think the return is too lucrative to pass on regardless of the risk.”"** | `[115]` **Deivid Wisci**: "“I am of the opinion that it is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Lucian Galade**: "“The migrant crisis was one of t..." |
| `[143]` | **"“I must display strength to my people. We can't be pushed around.”"** | `[139]` **Deivid Wisci**: "“Now there are only two Rumburg ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Petr Vectern**: "“All of this may be a calculated..." |
| `[201]` | **"“Good work.”"** | `[111]` **Deivid Wisci**: "“Well, that concludes our meetin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Lucian Galade**: "“I will take my leave then.”" |
| `[210]` | **"“We can't position ourselves against Valgsland.”"** | `[137]` **Deivid Wisci**: "“The downside is that we would n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Deivid Wisci**: "“That is certainly a valid reason.”" |
| `[256]` | **"“I'm interested to hear the intentions of the Kingdom of Rizia.”"** | `[266]` **Deivid Wisci**: "“There are three trade-related t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[379]` **Deivid Wisci**: "“Former President Alphonso signe..." |
| `[283]` | **"“I don't need any further information about Rizia.”"** | `[314]` **Lucian Galade**: "“Regardless, ideological or poli..."<br>`[317]` **Iosef Lancea**: "“The military should also be fun..."<br>*(oraz 10 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc"] == false`<br>`(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false` | *Brak zmian stanu* | `[330]` **Deivid Wisci**: "“Of course, Mr. President.”" |
| `[288]` | **"“Let's discuss the deal potential and what's on the table.”"** | `[314]` **Lucian Galade**: "“Regardless, ideological or poli..."<br>`[317]` **Iosef Lancea**: "“The military should also be fun..."<br>*(oraz 10 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer"] == false`<br>`(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false` | *Brak zmian stanu* | `[326]` **Deivid Wisci**: "“From what we have gathered, the..." |
| `[289]` | **"“I'd like to know more about Rizia.”"** | `[314]` **Lucian Galade**: "“Regardless, ideological or poli..."<br>`[317]` **Iosef Lancea**: "“The military should also be fun..."<br>*(oraz 10 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc"] == false`<br>`(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false` | `LookAt("Sordland_Country_Rizia");` | `[355]` **Deivid Wisci**: ""The nation south of Lespia is a..." |
| `[299]` | **"“I'm cynical about monarchies. Their time in Merkopa seems to be running out, and ..."** | `[298]` **Deivid Wisci**: "“King Romus is interested in inc..." | `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true) == false` | *Brak zmian stanu* | `[308]` **Deivid Wisci**: "“The international web of monarc..." |
| `[300]` | **"“We are still facing the potential of a recession. New avenues for trade could hel..."** | `[298]` **Deivid Wisci**: "“King Romus is interested in inc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Deivid Wisci**: "“Rizia is a developed nation wit..." |
| `[301]` | **"“Isn't this unusual? Aren't you and the Ministry of Foreign Affairs in charge of a..."** | `[298]` **Deivid Wisci**: "“King Romus is interested in inc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Deivid Wisci**: "“Usually, yes, but in special sc..." |
| `[322]` | **"“*Former* President Alphonso.”"** | `[321]` **Deivid Wisci**: "“We have no close contacts with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Deivid Wisci**: "“Ah, yes, Mr. President. Excuse ..." |
| `[323]` | **"“That sounds good to me.”"** | `[321]` **Deivid Wisci**: "“We have no close contacts with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Deivid Wisci**: "“Very well.”" |
| `[334]` | **"“Why deal with a monarchy? They've sucked enough blood from the people of Merkopa.”"** | `[298]` **Deivid Wisci**: "“King Romus is interested in inc..." | `Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true` | *Brak zmian stanu* | `[335]` **Petr Vectern**: "“Strong words, Anton. I like it!”" |
| `[338]` | **"“We should protect our energy independence, but we don’t know the offer's specific..."** | `[344]` **Iosef Lancea**: "“As a sovereign nation, we must ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Deivid Wisci**: "“I agree, but Gasom is a private..." |
| `[339]` | **"“Affluent Sords don’t stray far from each other.”"** | `[347]` **Lucian Galade**: "“I have information that the CEO..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Petr Vectern**: "“Why would they? Similar circles..." |
| `[340]` | **"“The shareholder links raise questions regarding Alphonso and Manger's motivations.”"** | `[347]` **Lucian Galade**: "“I have information that the CEO..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Lucian Galade**: "“I suspect that the corporation ..." |
| `[345]` | **"“As long as we can improve our economy and resource extraction, we shouldn’t care ..."** | `[344]` **Iosef Lancea**: "“As a sovereign nation, we must ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Deivid Wisci**: "“I think we must act pragmatical..." |
| `[348]` | **"“I look favorably towards a potential investment from Rizia into Sordland.”"** | `[407]` **Deivid Wisci**: "“I think this summarizes all we ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntenti...` | `[350]` **Deivid Wisci**: "“There is strong potential for f..." |
| `[349]` | **"“We will have to wait and hear more from Mr. Manger to decide.”"** | `[407]` **Deivid Wisci**: "“I think this summarizes all we ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Petr Vectern**: "“If there's one thing Gus is goo..." |
| `[361]` | **"“What exactly are these blood ties between Rizia and Rumburg?”"** | `[356]` **Deivid Wisci**: "“The Alphonso government signed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Deivid Wisci**: "“In the 1930s, King Romus marrie..." |
| `[362]` | **"“I’m curious how our neighbors Lespia and Wehlen get along with Rizia.”"** | `[356]` **Deivid Wisci**: "“The Alphonso government signed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Deivid Wisci**: "“There is some tension with both..." |
| `[364]` | **"Examine the coin."** | `[357]` **Narrator**: "Petr pulled out the ornamental c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Narrator**: "At the center was the emblem of ..." |
| `[365]` | **"“Not bad. You can't go wrong with gold.”"** | `[357]` **Narrator**: "Petr pulled out the ornamental c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[404]` **Petr Vectern**: "“Sure can't.”" |
| `[371]` | **"“I would watch the hell out of that.”"** | `[370]` **Petr Vectern**: "“All these kings and queens disa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Petr Vectern**: "“I'll bring the popcorn!”" |
| `[372]` | **"“Lets stay on point.”"** | `[370]` **Petr Vectern**: "“All these kings and queens disa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[397]` **Petr Vectern**: "“Sure, sure!”" |
| `[375]` | **"“The Kingdom was meant to collapse. Nothing could save it, regardless of the effort.”"** | `[409]` **Narrator**: "Deivid hesitated for a brief mom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Deivid Wisci**: "“Times change, and any good lead..." |
| `[376]` | **"“Your father was truly a great man, may he rest in peace.”"** | `[409]` **Narrator**: "Deivid hesitated for a brief mom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Deivid Wisci**: "“Thank you, Anton. I hope our na..." |
| `[377]` | **"“In the Tarquin Soll period, we never saw such dependency on foreign nations.”"** | `[409]` **Narrator**: "Deivid hesitated for a brief mom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Lucian Galade**: "“Yes, with the exceptionally suc..." |
| `[393]` | **"“We have enough issues to figure out; we can’t worry about the problems of others.”"** | `[391]` **Lucian Galade**: "“The relationship between Rizia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[406]` **Deivid Wisci**: "“It's good to be informed in the..." |
| `[394]` | **"“Merkopan geopolitics are a complexity of another caliber.”"** | `[391]` **Lucian Galade**: "“The relationship between Rizia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[395]` **Deivid Wisci**: "“My job is to make sense of it. ..." |
| `[400]` | **"“What is RRG?”"** | `[399]` **Narrator**: "At the bottom, the letters RRG w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[403]` **Petr Vectern**: "“It's Rizian Royal Gold. The com..." |
| `[401]` | **"“Nice piece, Petr.”"** | `[399]` **Narrator**: "At the bottom, the letters RRG w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[402]` **Petr Vectern**: "“Thanks. Maybe I'll turn it into..." |
| `[413]` | **"“Let's move on.”"** | `[357]` **Narrator**: "Petr pulled out the ornamental c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[414]` **Lucian Galade**: "“As you wish, and thank you.”" |
| `[425]` | **"“Remember campaigning for him back in the day? He wouldn't have gotten the USP lea..."** | `[424]` **Lucian Galade**: "“Ewald Alphonso adjusted this la..." | `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true  and  Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true` | *Brak zmian stanu* | `[438]` **Petr Vectern**: "“I've got to say his team was gr..." |
| `[426]` | **"“Things didn't end amicably between us. I mean, we aggressively destroyed his camp..."** | `[424]` **Lucian Galade**: "“Ewald Alphonso adjusted this la..." | `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true` | *Brak zmian stanu* | `[449]` **Petr Vectern**: "“It wasn’t my preferred method, ..." |
| `[427]` | **"“He was right to open up the country, regardless of what happened in '51. Sordland..."** | `[424]` **Lucian Galade**: "“Ewald Alphonso adjusted this la..." | `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true  and  Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true  and  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true` | *Brak zmian stanu* | `[461]` **Petr Vectern**: "“I agree with you, Anton, and I'..." |
| `[428]` | **"“I see a strong case for Tarquin Soll's regulation. Energy security is important f..."** | `[424]` **Lucian Galade**: "“Ewald Alphonso adjusted this la..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Petr Vectern**: "“We don't want to find ourselves..." |
| `[429]` | **"“Gasom is private, but it still sells most of the gas it produces to Sordland, rig..."** | `[424]` **Lucian Galade**: "“Ewald Alphonso adjusted this la..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[445]` **Petr Vectern**: "“I think so, yes. Lucian knows m..." |
| `[433]` | **"“The way we publicly embarrassed him on national television won't help further dia..."** | `[424]` **Lucian Galade**: "“Ewald Alphonso adjusted this la..." | `Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true`<br>`(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false` | *Brak zmian stanu* | `[453]` **Petr Vectern**: "“Any political opponent would ha..." |
| `[434]` | **"“Good thing, we handled the transfer of power within the party diplomatically. I'm..."** | `[424]` **Lucian Galade**: "“Ewald Alphonso adjusted this la..." | `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true`<br>`(Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true) == false`<br>`(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false` | *Brak zmian stanu* | `[457]` **Petr Vectern**: "“Yeah, so many people in the par..." |
| `[472]` | **"“The power structure behind the scenes shouldn't matter much to us.”"** | `[347]` **Lucian Galade**: "“I have information that the CEO..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[496]` **Deivid Wisci**: "“We are at a much stronger posit..." |
| `[473]` | **"“Anytime Rumburg enters the 'play', crap hits the fan.”"** | `[391]` **Lucian Galade**: "“The relationship between Rizia ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[478]` **Petr Vectern**: "“Haha! One way to put it, Mr. Pr..." |
| `[474]` | **"“I doubt he would allow it. It might hurt his hotel businesses around Port Grim.”"** | `[370]` **Petr Vectern**: "“All these kings and queens disa..." | `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false` | *Brak zmian stanu* | `[486]` **Petr Vectern**: "“Well, I'd watch the hell out of..." |
| `[475]` | **"“Well, we can continue official dialogue after this. It might lead to a more subst..."** | `[321]` **Deivid Wisci**: "“We have no close contacts with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[477]` **Deivid Wisci**: "“Of course, we are pushing to es..." |
| `[484]` | **"“You should bring it up next time you see him, see what he says.”"** | `[370]` **Petr Vectern**: "“All these kings and queens disa..." | `Variable["BaseGame.Accepted_MediaDeal"] == true` | *Brak zmian stanu* | `[485]` **Petr Vectern**: "“I smell an international hit!”" |
| `[493]` | **"“Allowing more market economics to determine the value and output of our energy is..."** | `[344]` **Iosef Lancea**: "“As a sovereign nation, we must ..." | `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false` | *Brak zmian stanu* | `[494]` **Iosef Lancea**: "“A potential mistake when our tr..." |
| `[501]` | **"“Keeping close control over critical resources is in sync with our planned economy..."** | `[344]` **Iosef Lancea**: "“As a sovereign nation, we must ..." | `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true` | *Brak zmian stanu* | `[502]` **Iosef Lancea**: "“I'm very glad you have chosen a..." |
| `[504]` | **"“You don't need help finding love. You've got Evelyn, right?”"** | `[357]` **Narrator**: "Petr pulled out the ornamental c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[505]` **Petr Vectern**: "“Yeah, sure. She's the greatest.”" |

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
  - -> `[23]` (*Narrator: "The Blue Mansion in Lachaven hosted us for the important ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "“Leave the formalities aside, Deivid. Please take a seat.”"]** — Mówca: **Player**
> "“Leave the formalities aside, Deivid. Please take a seat.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Deivid Wisci: "“Ah right. Anton, I am used to titles, diplomacy jobs tra..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "Gesture at the chair."]** — Mówca: **Player_Italic**
> "I gestured at the comfortable-looking leather chair."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Deivid Wisci: "“Good to see you.”"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "“Of course. It's a pleasure to see you, Mr. Wisci.”"]** — Mówca: **Player**
> "“Of course! It is a pleasure to see you, Mr. Wisci.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Deivid Wisci: "“Likewise. We have so much ahead of us to accomplish.”"*)

### Węzeł `[6]`
Mówca: **Deivid Wisci**
> "“May I sit down, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: "“Leave the formalities aside, Deivid. Please take a seat.”"*)
  - -> `[5]` (*Player: "“Of course. It's a pleasure to see you, Mr. Wisci.”"*)
  - -> `[4]` (*Player_Italic: "Gesture at the chair."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "The door opened, and Deivid Wisci -- once a lecturer to me, now the Minister of Foreign Affairs -- gently made his way towards my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Deivid Wisci: "“May I sit down, Mr. President?”"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "The door opened. Iosef and Lucian joined us for the briefing as the tall case clock hit the hour mark."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "Petr, however, was missing. I wondered if he was late fro..."*)

### Węzeł `[9]`
Mówca: **Deivid Wisci**
> "“Somehow the inexplicable ebb and flow of life has led us here. To positions where we can change the course of history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player: "“Everything happens for a reason, Deivid. It was meant to..."*)
  - -> `[43]` (*Player: "“We got a little lucky. That's all.”"*)
  - -> `[41]` (*Player: "“This is our opportunity to shape the future and we will ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Would you like some tea or water?”"]** — Mówca: **Player**
> "“Would you like some tea or water?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Deivid Wisci: "“Oh yes, please. Tea and water sounds nice. Thank you ver..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "He started coughing again. This time for longer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“Would you like some tea or water?”"*)
  - -> `[54]` (*Player: "“How is your health, Deivid?”"*)
  - -> `[62]` (*Player: "“Let's start talking about our foreign policy.”"*)

### Węzeł `[12]`
Mówca: **Deivid Wisci**
> "“Oh yes, please. Tea and water sounds nice. Thank you very much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "He smiled."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Livia brought two cups of tea along with a glass of water and placed them on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Deivid Wisci: "“It seems you still remember how much I like tea. Nowaday..."*)

### Węzeł `[14]`
Mówca: **Deivid Wisci**
> "“It seems you still remember how much I like tea. Nowadays it really does wonders for my throat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: "“So how is your wife Cathrin doing?”"*)
  - -> `[53]` (*Player: "“Has your niece Margi started going to the kindergarten y..."*)
  - -> `[54]` (*Player: "“How is your health, Deivid?”"*)
  - -> `[62]` (*Player: "“Let's start talking about our foreign policy.”"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Let's begin.”"]** — Mówca: **Player**
> "“Let's begin.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Deivid Wisci: "“Very well.”"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“How was your travel to Lachaven?”"]** — Mówca: **Player**
> "“How was your travel to Lachaven?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Iosef Lancea: "“A little bumpy due to some turbulence. I arrived via a m..."*)

### Węzeł `[17]`
Mówca: **Iosef Lancea**
> "“A little bumpy due to some turbulence. I arrived via a military cargo plane that landed at Lachaven International.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: "“I took the train. It was a little slow, but I can still ..."*)

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“I took the train. It was a little slow, but I can still recommend it for the beautiful landscape. I also had the possibility to work on a couple of things during the ride.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Deivid Wisci: "“From what I've heard, it will be much faster in the near..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: "“Well then. Since Mr. Vectern doesn't seem to be coming t..."*)

### Węzeł `[22]`
Mówca: **Deivid Wisci**
> "“From what I've heard, it will be much faster in the near future when the L-1 high-speed railway is finished.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: "“Exactly. If all goes well, it will be one of our major a..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "The Blue Mansion in Lachaven hosted us for the important diplomacy gathering."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "The door opened, and Deivid Wisci -- once a lecturer to m..."*)

### Węzeł `[24]`
Mówca: **Deivid Wisci**
> "“Ah right. Anton, I am used to titles, diplomacy jobs train oneself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "He slowly sat down, taking care not to aggravate the arth..."*)

### Węzeł `[25]`
Mówca: **Deivid Wisci**
> "“Good to see you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "He slowly sat down, taking care not to aggravate the arth..."*)

### Węzeł `[26]`
Mówca: **Deivid Wisci**
> "“Likewise. We have so much ahead of us to accomplish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "He slowly sat down, taking care not to aggravate the arth..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Deyr_History == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Deivid Wisci: "“And remember how hard we worked on the Agnolia trade agr..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Deivid Wisci: "“Somehow the inexplicable ebb and flow of life has led us..."*)

### Węzeł `[30]`
Mówca: **Deivid Wisci**
> "“And remember how hard we worked on the Agnolia trade agreement together?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "“Countless late nights at the Ministry to finalise. It wa..."*)
  - -> `[40]` (*Player: "“I'd rather not remember. It felt like a gargantuan task.”"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Deyr_History == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Deivid Wisci: "“I still remember the first day you took my class at the ..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Holsord_Law == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Deivid Wisci: "“I still remember the first day you took my class at Hols..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Holsord_Law == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Deivid Wisci: "“I still remember the first day you took my class at the ..."*)

### Węzeł `[37]`
Mówca: **Deivid Wisci**
> "“I still remember the first day you took my class at the Lachaven School of Economics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[38]`
Mówca: **Deivid Wisci**
> "“I still remember the first day you took my class at Holsord State University.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[39]`
Mówca: **Deivid Wisci**
> "“I still remember the first day you took my class at the Deyr University of Culture.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“I'd rather not remember. It felt like a gargantuan task.”"]** — Mówca: **Player**
> "“I'd rather not remember. It felt like a gargantuan task.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Deivid Wisci: "“That accomplishment enabled your rise in the party.”"*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“This is our opportunity to shape the future and we will do precisely that.”"]** — Mówca: **Player**
> "“This is our opportunity to shape the future and we will do precisely that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Deivid Wisci: "“I am looking forward to our new foreign policy.”"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“Countless late nights at the Ministry to finalise. It was an experience for sure.”"]** — Mówca: **Player**
> "“Countless late nights at the Ministry to finalize. It was an experience for sure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Deivid Wisci: "“We signed our best trade deal yet with a good slew of tr..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“We got a little lucky. That's all.”"]** — Mówca: **Player**
> "“We got a little lucky. That's all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Deivid Wisci: "“Our work surely contributed. Everybody made sacrifices o..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Everything happens for a reason, Deivid. It was meant to be.”"]** — Mówca: **Player**
> "“Everything happens for a reason, Deivid. It was meant to be.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Deivid Wisci: "“Maybe, maybe not. I don't believe in destiny, but someti..."*)

### Węzeł `[45]`
Mówca: **Deivid Wisci**
> "“We signed our best trade deal yet with a good slew of trade advantages over Agnolia. It was even somewhat unfair from my point of view.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Deivid Wisci: "“Somehow the inexplicable ebb and flow of life has led us..."*)

### Węzeł `[46]`
Mówca: **Deivid Wisci**
> "“That accomplishment enabled your rise in the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Deivid Wisci: "“Somehow the inexplicable ebb and flow of life has led us..."*)

### Węzeł `[47]`
Mówca: **Deivid Wisci**
> "“Maybe, maybe not. I don't believe in destiny, but sometimes it feels convenient to do so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Deivid Wisci: "“I am excited to present you the latest bill I am working..."*)

### Węzeł `[48]`
Mówca: **Deivid Wisci**
> "“Our work surely contributed. Everybody made sacrifices on some level.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Deivid Wisci: "“I am excited to present you the latest bill I am working..."*)

### Węzeł `[49]`
Mówca: **Deivid Wisci**
> "“I am looking forward to our new foreign policy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Deivid Wisci: "“I am excited to present you the latest bill I am working..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "He slowly sat down, taking care not to aggravate the arthritis in his knees. He'd always had an air of gravitas about him, and old age had only served to deepen that."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "After he settled himself, he regarded me with delight, hi..."*)

### Węzeł `[51]`
Mówca: **Deivid Wisci**
> "“Oh, I haven't had any big complications except the usual... After that heart attack earlier this year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Deivid Wisci: "“The health complications aren't a hindrance to my work, ..."*)

### Węzeł `[52]`
Mówca: **Deivid Wisci**
> "“Yes, she has. Spending time with Margi makes me happy. There's still much ahead of her in life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Deivid Wisci: "“I sometimes wish Cathrin and I had children, but that sh..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Has your niece Margi started going to the kindergarten yet?”"]** — Mówca: **Player**
> "“Has your niece Margi started going to the kindergarten yet?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Deivid Wisci: "“Yes, she has. Spending time with Margi makes me happy. T..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“How is your health, Deivid?”"]** — Mówca: **Player**
> "“How is your health, Deivid?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator), `[14]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Deivid Wisci: "“Oh, I haven't had any big complications except the usual..."*)

### Węzeł `[55]`
Mówca: **Deivid Wisci**
> "“My lovely Cathrin is as energetic as always. Age has hit me harder than her, for sure. She still does her daily jogs unlike me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Deivid Wisci: "“Nothing can challenge time. Nothing.”"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“So how is your wife Cathrin doing?”"]** — Mówca: **Player**
> "“So how is your wife Cathrin doing?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Deivid Wisci: "“My lovely Cathrin is as energetic as always. Age has hit..."*)

### Węzeł `[57]`
Mówca: **Deivid Wisci**
> "“The health complications aren't a hindrance to my work, of course. But thanks for asking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Deivid Wisci: "“How is the Rayne family?”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Monica is really taking to the First Lady role.”"]** — Mówca: **Player**
> "“Monica is really taking to the First Lady role.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Deivid Wisci: "“As time passes, I realize it more. Family is the most im..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“Franc never liked the spotlight, so that hasn't changed.”"]** — Mówca: **Player**
> "“Franc never liked the spotlight, so that hasn't changed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Deivid Wisci: "“As time passes, I realize it more. Family is the most im..."*)

### Węzeł `[60]`
Mówca: **Deivid Wisci**
> "“We'll talk more later, President Rayne. Welcome everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player: "“How was your travel to Lachaven?”"*)
  - -> `[15]` (*Player: "“Let's begin.”"*)

### Węzeł `[61]`
Mówca: **Deivid Wisci**
> "“How is the Rayne family?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "“We are slowly starting to get used to the routine.”"*)
  - -> `[58]` (*Player: "“Monica is really taking to the First Lady role.”"*)
  - -> `[59]` (*Player: "“Franc never liked the spotlight, so that hasn't changed.”"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Let's start talking about our foreign policy.”"]** — Mówca: **Player**
> "“Let's start talking about our foreign policy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator), `[14]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "The door opened. Iosef and Lucian joined us for the brief..."*)

### Węzeł `[63]`
Mówca: **Deivid Wisci**
> "“I sometimes wish Cathrin and I had children, but that ship sailed a long time ago.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Deivid Wisci: "“How is the Rayne family?”"*)

### Węzeł `[64]`
Mówca: **Deivid Wisci**
> "“Nothing can challenge time. Nothing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Deivid Wisci: "“How is the Rayne family?”"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“We are slowly starting to get used to the routine.”"]** — Mówca: **Player**
> "“We are slowly starting to get used to the routine.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Deivid Wisci: "“As time passes, I realize it more. Family is the most im..."*)

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“Well then. Since Mr. Vectern doesn't seem to be coming today... I think we are ready to start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "Petr, however, was missing. I wondered if he was late from all the drinking he did at the party in Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Deivid Wisci: "“We'll talk more later, President Rayne. Welcome everyone.”"*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Petr arrived late. He looked a little rougher than usual. It must have been the drinking from last night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Petr Vectern: "“Hey there, folks. Excuse my delay. I'm sure I didn't mis..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "The sun began to set over the hills surrounding Lachaven. The team was ready to give advice on the new trade initiative and the response to the latest diplomatic incident with Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Petr arrived late. He looked a little rougher than usual...."*)

### Węzeł `[70]`
Mówca: **Petr Vectern**
> "“Hey there, folks. Excuse my delay. I'm sure I didn't miss anything we didn't already know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Iosef Lancea: "“You were still supposed to be a part of this meeting. An..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“You may be right. It's risky.”"]** — Mówca: **Player**
> "“You may be right. It's risky.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: "“I tend to agree.”"*)

### Węzeł `[72]`
Mówca: **Iosef Lancea**
> "“You were still supposed to be a part of this meeting. An hour ago.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: "“Punctuality is important. We are talking about serious s..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn02_FPnT_DiplomacyOverview = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn02_FPnT_DiplomacyOverview"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Agnolia", "Progress_Dipl..."*)

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“I tend to agree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Deivid Wisci: "“If we wish to go forward with the deal when the time com..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“We are accustomed to the usual rhetoric but this is far more serious.”"]** — Mówca: **Player**
> "“We are accustomed to the usual rhetoric but this is far more serious.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Petr Vectern: "“They are playing with fire. Look at what the Wehlen dest..."*)

### Węzeł `[76]`
Mówca: **Lucian Galade**
> "“Punctuality is important. We are talking about serious subjects here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "“Petr was assigned a task from me, that is why he is late..."*)
  - -> `[80]` (*Player: "“They have a point, Petr. We should have discipline in th..."*)
  - -> `[82]` (*Player_Italic: "Don't comment."*)

### Węzeł `[77]`
Mówca: **Lucian Galade**
> "“A strong response to Rumburg will boost popularity at home.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Iosef Lancea: "“I'm glad that we are drawing a clear red line. Otherwise..."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "The meeting concluded and the team dispersed. Our diplomatic action plan officially began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_G_SordlandCloses = true"*)

### Węzeł `[79]`
Mówca: **Narrator**
> "The meeting concluded and the team dispersed. Our diplomatic action plan officially began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_G_SordlandCondemns = true"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“They have a point, Petr. We should have discipline in the cabinet.”"]** — Mówca: **Player**
> "“They have a point, Petr. We should have discipline in the cabinet.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Petr Vectern: "“Excuse me. It won't happen again.”"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Petr was assigned a task from me, that is why he is late so let's move on.”"]** — Mówca: **Player**
> "“Petr was assigned a task from me, that is why he is late. So let's move on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Petr Vectern: "“Ah, yes, yes. It went successfully, sir.”"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I stood in silence, which prompted Petr to answer them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Petr Vectern: "“It was a one-time thing. Let's just get on with it.”"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“They are bluffing. We are used to it by now.”"]** — Mówca: **Player**
> "“They are bluffing. We are used to it by now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Petr Vectern: "“They could be. We beat them once before. They might not ..."*)

### Węzeł `[84]`
Mówca: **Iosef Lancea**
> "“I'm glad that we are drawing a clear red line. Otherwise they will keep escalating the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Petr Vectern: "“I like your determination, Mr. President.”"*)

### Węzeł `[85]`
Mówca: **Petr Vectern**
> "“Ah, yes, yes. It went successfully, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Petr's tone was more serious."*)

### Węzeł `[86]`
Mówca: **Petr Vectern**
> "“It was a one-time thing. Let's just get on with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Lucian and Iosef looked at Petr before Deivid moved away ..."*)

### Węzeł `[87]`
Mówca: **Petr Vectern**
> "“Excuse me. It won't happen again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Lucian and Iosef looked at Petr before Deivid moved away ..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Condemn == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Condemn == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_FPnT_Consulate_Condemn == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Condemn == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "The meeting concluded and the team dispersed. Our diploma..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_FPnT_Consulate_Condemn == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "The meeting concluded and the team dispersed. Our diploma..."*)

### Węzeł `[91]`
Mówca: **Lucian Galade**
> "“Swaying the international stage is the key in long-term strategy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Iosef Lancea: "“I wish we had reacted more strongly. If we don't confron..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Condemn = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_CondemnedRumburg = true"*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Petr's tone was more serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Petr Vectern: "“Expect a report on your desk tomorrow.”"*)

### Węzeł `[94]`
Mówca: **Iosef Lancea**
> "“Sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Condemn == true"*)

### Węzeł `[95]`
Mówca: **Petr Vectern**
> "“Expect a report on your desk tomorrow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Deivid Wisci: "“The Vice President will be part of the trade delegation,..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Lucian and Iosef looked at Petr before Deivid moved away from the subject."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Deivid Wisci: "“The Vice President will be part of the trade delegation,..."*)

### Węzeł `[97]`
Mówca: **Deivid Wisci**
> "“The Vice President will be part of the trade delegation, so it will be great to have his input on that subject as well as on the Rumburg incident.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Deivid Wisci: "“Rumburg Consul Sir Bran Harrington announced the closure..."*)

### Węzeł `[98]`
Mówca: **Deivid Wisci**
> "“Our trade delegation will begin work towards the end of the year. We expect final negotiations and the signings of the trade agreements to happen next year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Petr Vectern: "“I'm very much looking forward to visiting Staalport and ..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Retaliate = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_ClosedSordlandConsulateInR..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Write an official diplomatic response condemning this unreasonable act. Declare that Rumburg aims to destabilize Sordland and the region.”"]** — Mówca: **Player**
> "“Write an official diplomatic response condemning this unreasonable act. Declare that Rumburg aims to destabilize Sordland and the region.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Condemn = true"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Retaliate by closing the Sordland Consulate in Dome! They think they can bully us. They were never so wrong.”"]** — Mówca: **Player**
> "“Retaliate by closing the Sordland Consulate in Dome! They think they can bully us. They were never so wrong.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Retaliate = true"*)

### Węzeł `[102]`
Mówca: **Lucian Galade**
> "“I will take my leave then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Iosef Lancea: "“Sir.”"*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We should talk about the ongoing trade negotiations with our neighbors Wehlen and Agnolia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Deivid Wisci: "“Our primary goal will be to successfully sign at least o..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“See you later, gentlemen.”"]** — Mówca: **Player**
> "“See you later, gentlemen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“I will take my leave then.”"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Have a good day and enjoy Lachaven.”"]** — Mówca: **Player**
> "“Have a good day and enjoy Lachaven.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“I will take my leave then.”"*)

### Węzeł `[106]`
Mówca: **Deivid Wisci**
> "“Our primary goal will be to successfully sign at least one trade agreement with one of our smaller neighbors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Deivid Wisci: "“We have two options with our trade initiative. Starting ..."*)

### Węzeł `[107]`
Mówca: **Deivid Wisci**
> "“Rumburg Consul Sir Bran Harrington announced the closure of the 120-year-old consulate. Now their diplomatic staff is leaving this city to go back to Thornbourgh.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucian Galade: "“He blamed the lack of security in Sordland due to the as..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“Thank you all for coming.”"]** — Mówca: **Player**
> "“Thank you all for coming.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“I will take my leave then.”"*)

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“He blamed the lack of security in Sordland due to the assassination and the subsequent protests. But it is obvious that they are making excuses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Iosef Lancea: "“Bastards! First they close their consulate and then they..."*)

### Węzeł `[110]`
Mówca: **Deivid Wisci**
> "“We have two options with our trade initiative. Starting new negotiations with our old partner Agnolia to the north-east, and forming a new cooperation with Wehlen to the west.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "Wehlen Agnolia Trade"*)

### Węzeł `[111]`
Mówca: **Deivid Wisci**
> "“Well, that concludes our meeting, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: "“Thank you all for coming.”"*)
  - -> `[105]` (*Player: "“Have a good day and enjoy Lachaven.”"*)
  - -> `[104]` (*Player: "“See you later, gentlemen.”"*)
  - -> `[201]` (*Player: "“Good work.”"*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“Tell me about the trade deal with Agnolia.”"]** — Mówca: **Player**
> "“Tell me about the trade deal with Agnolia.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia"] == false`
- **Kontekst wejściowy (poprzednik):** `[110]` (Deivid Wisci), `[207]` (Lucian Galade), `[235]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Deivid Wisci: "“First off, the reason behind this option is more diploma..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Tell me about the trade deal with Wehlen.”"]** — Mówca: **Player**
> "“Tell me about the trade deal with Wehlen.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen"] == false`
- **Kontekst wejściowy (poprzednik):** `[110]` (Deivid Wisci), `[207]` (Lucian Galade), `[235]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Deivid Wisci: "“Dealing with a fractured country like Wehlen has its pos..."*)

### Węzeł `[114]`
Mówca: **Iosef Lancea**
> "“Bastards! First they close their consulate and then they blame our security!?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player: "“The security situation is under control, they are playin..."*)
  - -> `[121]` (*Player: "“Their concerns could be genuine but this reaction is unn..."*)

### Węzeł `[115]`
Mówca: **Deivid Wisci**
> "“I am of the opinion that it is simply too risky. Yes, we would gain resources and immediate capital, but I'm afraid of the consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: "“I think the return is too lucrative to pass on regardles..."*)
  - -> `[71]` (*Player: "“You may be right. It's risky.”"*)

### Węzeł `[116]`
Mówca: **Deivid Wisci**
> "“As you wish Mr. President. I shall begin work by immediately informing the Ministry of Foreign Affairs and Trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucian Galade: "“A strong response to Rumburg will boost popularity at ho..."*)

### Węzeł `[117]`
Mówca: **Iosef Lancea**
> "“I want to state my support for the decision to stick to our old ally, Agnolia. Even though I disagree with their demand to relax immigration, we have cooperated with them on many issues in the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[118]`
Mówca: **Iosef Lancea**
> "“I certainly don't support the decision to become friendlier with Wehlen. We carried their burdens for decades. Their migrants flooded our country and now they are expecting a deal from us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Petr Vectern: "“Maintaining influence with Wehlen could prove useful. Ye..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "Petr laughed. Iosef narrowed his eyes and stared at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy = true"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“The security situation is under control, they are playing with us.”"]** — Mówca: **Player**
> "“The security situation is under control. They are playing with us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Petr Vectern: "“Isn't it telling that other countries are working with u..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "“Their concerns could be genuine but this reaction is unnecessary.”"]** — Mówca: **Player**
> "“Their concerns could be genuine, but this reaction is unnecessary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Petr Vectern: "“Agreed. Other diplomatic missions have worked with our s..."*)

### Węzeł `[122]`
Mówca: **Deivid Wisci**
> "“As you wish Mr. President. I shall begin work by immediately informing the Ministry of Foreign Affairs and Trade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: "“Swaying the international stage is the key in long-term ..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Deyr_History == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Petr Vectern: "“Agnolia is a solid partner for us, Deivid and the Presid..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Petr Vectern: "“There are obviously subjects that we would still need to..."*)

### Węzeł `[126]`
Mówca: **Petr Vectern**
> "“Isn't it telling that other countries are working with us while Rumburg is just cutting more ties with us?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Deivid Wisci: "“The neglect of President Alphonso, and the chaos of the ..."*)

### Węzeł `[127]`
Mówca: **Petr Vectern**
> "“Agreed. Other diplomatic missions have worked with our security units to increase the protection of staff and buildings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Deivid Wisci: "“The neglect of President Alphonso, and the chaos of the ..."*)

### Węzeł `[128]`
Mówca: **Iosef Lancea**
> "“The people of Sordland must be protected, no matter the cost. I say we respond equally.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "“Retaliate by closing the Sordland Consulate in Dome! The..."*)
  - -> `[100]` (*Player: "“Write an official diplomatic response condemning this un..."*)

### Węzeł `[129]`
Mówca: **Petr Vectern**
> "“There are obviously subjects that we would still need to tackle like our economies, the traded goods and what to do with immigration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Deivid Wisci: "“My opinion is that this is a good deal and we should go ..."*)

### Węzeł `[130]`
Mówca: **Petr Vectern**
> "“Maintaining influence with Wehlen could prove useful. Yes, it is risky, but think about our influence on a underdeveloped region like that. We could also sell more products and enter their market easily.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Deivid Wisci: "“I am of the opinion that it is simply too risky. Yes, we..."*)

### Węzeł `[131]`
Mówca: **Petr Vectern**
> "“I'm very much looking forward to visiting Staalport and Wraclawitz with party animals like Deivid and Symon! Haha!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "Petr laughed. Iosef narrowed his eyes and stared at him."*)

### Węzeł `[132]`
Mówca: **Petr Vectern**
> "“Agnolia is a solid partner for us, Deivid and the President worked on the previous comprehensive trade agreement in the 30s.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Petr Vectern: "“There are obviously subjects that we would still need to..."*)

### Węzeł `[133]`
Mówca: **Deivid Wisci**
> "“The neglect of President Alphonso, and the chaos of the elections, delayed our diplomatic efforts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Deivid Wisci: "“Now there are only two Rumburg diplomatic missions left ..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Deivid Wisci: "“The fact that we are headed towards a market economy wil..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Deivid Wisci: "“The fact that we are headed towards a planned economy wi..."*)

### Węzeł `[137]`
Mówca: **Deivid Wisci**
> "“The downside is that we would need to make concessions. A reality of any trade deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: "“I would be open to creating a new agreement that would s..."*)
  - -> `[141]` (*Player: "“I don't want to give any concessions to them.”"*)
  - -> `[210]` (*Player: "“We can't position ourselves against Valgsland.”"*)

### Węzeł `[138]`
Mówca: **Iosef Lancea**
> "“I wish we had reacted more strongly. If we don't confront them, they will keep escalating the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Petr Vectern: "“I, on the other hand, am glad that we are taking the mor..."*)

### Węzeł `[139]`
Mówca: **Deivid Wisci**
> "“Now there are only two Rumburg diplomatic missions left in Sordland. One is the consulate in Deyr and the other is the embassy in Holsord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: "“We are accustomed to the usual rhetoric but this is far ..."*)
  - -> `[143]` (*Player: "“I must display strength to my people. We can't be pushed..."*)
  - -> `[83]` (*Player: "“They are bluffing. We are used to it by now.”"*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“I would be open to creating a new agreement that would satisfy all sides.”"]** — Mówca: **Player**
> "“I would be open to creating a new agreement that would satisfy all sides.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Deivid Wisci: "“That would be the best outcome.”"*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“I don't want to give any concessions to them.”"]** — Mówca: **Player**
> "“I don't want to give any concessions to them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Deivid Wisci: "“It might be unsatisfactory in the short run however, it ..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA: "“I think the return is too lucrative to pass on regardless of the risk.”"]** — Mówca: **Player**
> "“I think the return is too lucrative to pass on regardless of the risk.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lucian Galade: "“The migrant crisis was one of the reasons behind the des..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "“I must display strength to my people. We can't be pushed around.”"]** — Mówca: **Player**
> "“I must display strength to my people. We can't be pushed around.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Petr Vectern: "“All of this may be a calculated plan of action to push u..."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "Iosef Lancea was furious. He barely kept himself from slamming the desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Iosef Lancea: "“There are worrying developments like the smuggled arms a..."*)

### Węzeł `[145]`
Mówca: **Lucian Galade**
> "“The migrant crisis was one of the reasons behind the destabilization of Sordland. I would like to point out that it was due to Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Deivid Wisci: "“If we wish to go forward with the deal when the time com..."*)

### Węzeł `[146]`
Mówca: **Lucian Galade**
> "“Regardless, if we are going to increase our regional influence to previous levels, we might need to make amends with our neighbours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Lucian Galade: "“Ultimately the decision will be up to you as always.”"*)

### Węzeł `[147]`
Mówca: **Lucian Galade**
> "“I want to say that an escalation would be risky this early in our Presidency. We should focus on creating a negative image of Rumburg in the international scene.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Iosef Lancea: "“The people of Sordland must be protected, no matter the ..."*)

### Węzeł `[148]`
Mówca: **Deivid Wisci**
> "“This is not the usual bluff. The military has also seen unusual build-up in the regions close to the border.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Iosef Lancea was furious. He barely kept himself from sla..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true &&..."*)

### Węzeł `[150]`
Mówca: **Deivid Wisci**
> "“The fact that we are headed towards a planned economy will have an influence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Petr Vectern: "“Good negotiators optimize the interests which makes the ..."*)

### Węzeł `[151]`
Mówca: **Deivid Wisci**
> "“The fact that we are headed towards a market economy will have an influence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Petr Vectern: "“Good negotiators optimize the interests which makes the ..."*)

### Węzeł `[152]`
Mówca: **Deivid Wisci**
> "“We either respond to this aggressive act with a diplomatic condemnation or we retaliate by closing our consulate in Dome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“I want to say that an escalation would be risky this ear..."*)

### Węzeł `[153]`
Mówca: **Iosef Lancea**
> "“There are worrying developments like the smuggled arms and the build-up near the border. Our military must be buffed up to stand against a great power like Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Deivid Wisci: "“We either respond to this aggressive act with a diplomat..."*)

### Węzeł `[154]`
Mówca: **Petr Vectern**
> "“They are playing with fire. Look at what the Wehlen destabilization has done to the region. Sordland breaking apart would tear Merkopa apart.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Deivid Wisci: "“In my entire career I have never seen our Rumburg relati..."*)

### Węzeł `[155]`
Mówca: **Petr Vectern**
> "“All of this may be a calculated plan of action to push us into a corner and get us to act irrationally.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Deivid Wisci: "“This is my fear. They might be looking for a casus belli..."*)

### Węzeł `[156]`
Mówca: **Petr Vectern**
> "“They could be. We beat them once before. They might not want to try again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Deivid Wisci: "“This is not the usual bluff. The military has also seen ..."*)

### Węzeł `[157]`
Mówca: **Petr Vectern**
> "“Good negotiators optimize the interests which makes the differences become trivial, allowing both sides to reach a deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Deivid Wisci: "“Very true, Mr. Vectern. We have a lot of time to prepare..."*)

### Węzeł `[158]`
Mówca: **Petr Vectern**
> "“I, on the other hand, am glad that we are taking the more cautious road.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Deivid Wisci: "“There are three trade-related topics to address today. W..."*)

### Węzeł `[159]`
Mówca: **Petr Vectern**
> "“I like your determination, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Deivid Wisci: "“There are three trade-related topics to address today. W..."*)

### Węzeł `[160]`
Mówca: **Deivid Wisci**
> "“In my entire career I have never seen our Rumburg relations suffer this much. The previous low point was the War of Broken Wills.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Iosef Lancea was furious. He barely kept himself from sla..."*)

### Węzeł `[161]`
Mówca: **Deivid Wisci**
> "“This is my fear. They might be looking for a casus belli and are slowly spiralling downward to find reasons to wage war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Iosef Lancea was furious. He barely kept himself from sla..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Livia brought two cups of tea along with a glass of water..."*)

### Węzeł `[163]`
Mówca: **Deivid Wisci**
> "“Hmm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Arvory_YSLinksToGovernment = true; BaseGameSupport.Report_Turn02_Holsord_EPARepealProposal = true;
BaseGameSupport.FactionReport_Turn02_CSP_IyotakePlanRika = true;
BaseGameSupport.News_Turn02_E_EPARepealSupport = true;
BaseGameSupport.News_Turn02_G_PalesLesPower = true;
BaseGameSupport.News_Turn02_ST_AlphonsoFoundation = true;
BaseGameSupport.News_Turn02_LT_ForeignSkilledWorkers = true;
BaseGameSupport.News_Turn02_HP_EPARepealAttempt = true;
BaseGameSupport.News_Turn02_HP_RemusAntiWorkBill = true;
BaseGameSupport.Report_Turn02_Estord_CPSLUSProtest = true;
BaseGameSupport.Report_Turn02_Lachaven_CPSLUSPicketLine = true;
BaseGameSupport.Report_Turn02_Holsord_GNAGreenBill = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Arvory_YSLinksToGovernment"] = true;
Variable["BaseGameSupport.Report_Turn02_Holsord_EPARepealProposal"] = true;
Variable["BaseGameSupport.FactionReport_Turn02_CSP_IyotakePlanRika"] = true;
Variable["BaseGameSupport.News_Turn02_E_EPARepealSupport"] = true;
Variable["BaseGameSupport.News_Turn02_G_PalesLesPower"] = true;
Variable["BaseGameSupport.News_Turn02_ST_AlphonsoFoundation"] = true;
Variable["BaseGameSupport.News_Turn02_LT_ForeignSkilledWorkers"] = true;
Variable["BaseGameSupport.News_Turn02_HP_EPARepealAttempt"] = true;
Variable["BaseGameSupport.News_Turn02_HP_RemusAntiWorkBill"] = true;
Variable["BaseGameSupport.Report_Turn02_Estord_CPSLUSProtest"] = true;
Variable["BaseGameSupport.Report_Turn02_Lachaven_CPSLUSPicketLine"] = true;
Variable["BaseGameSupport.Report_Turn02_Holsord_GNAGreenBill"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_R_WeNeedDemocracy = true; Bas..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_R_WeNeedDemocracy = true; BaseGameSupport.News_Turn02_LT_NarbelWelfare = true; BaseGameSupport.News_Turn02_LT_UnrestContinues = true; BaseGameSupport.News_Turn02_HP_AnricaEmergency = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_WeNeedDemocracy"] = true;
Variable["BaseGameSupport.News_Turn02_LT_NarbelWelfare"] = true;
Variable["BaseGameSupport.News_Turn02_LT_UnrestContinues"] = true;
Variable["BaseGameSupport.News_Turn02_HP_AnricaEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "LookAtModeOff();"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_G_SordlandCondemns = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_G_SordlandCondemns"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Arvory_YSLinksToGovernment ..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_G_SordlandCloses = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_G_SordlandCloses"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Arvory_YSLinksToGovernment ..."*)

### Węzeł `[168]`
Mówca: **Lucian Galade**
> "“Exactly. If all goes well, it will be one of our major achievements.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: "“Well then. Since Mr. Vectern doesn't seem to be coming t..."*)

### Węzeł `[169]`
Mówca: **Deivid Wisci**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[170]`
Mówca: **Deivid Wisci**
> "“Look at you, Anton. The 4th President of Sordland. What a privilege for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[171]`
Mówca: **Deivid Wisci**
> "“As time passes, I realize it more. Family is the most important thing in life. We must take care of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "The door opened. Iosef and Lucian joined us for the brief..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Wehlen Agnolia Trade`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == tru..."*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == false"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen == false"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen == false"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen == fa..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: "“Tell me about the trade deal with Wehlen.”"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == false"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == f..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "“Tell me about the trade deal with Agnolia.”"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == true && BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == tru..."*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == t..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == true && BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Deivid Wisci: "“Hmm.”"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia == true && BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "Jump to: [Wehlen Agnolia Trade]"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "Jump to: [Wehlen Agnolia Trade]"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Wehlen Agnolia Trade]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "Wehlen Agnolia Trade"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Wehlen Agnolia Trade]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "Wehlen Agnolia Trade"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_East == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_East == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_East == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Deivid Wisci: "“Our campaign promise to steer Sordland towards the east ..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_East == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)

### Węzeł `[189]`
Mówca: **Deivid Wisci**
> "“Our campaign promise to steer Sordland towards the east and United Contana will have an effect on the negotiations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Deivid Wisci: "“Especially with Wehlen. As you know the current affairs ..."*)

### Węzeł `[190]`
Mówca: **Deivid Wisci**
> "“Our campaign promise to steer Sordland towards the west and Arcasia will have an effect on the negotiations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Deivid Wisci: "“Especially with Wehlen. As you know the current affairs ..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_West == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Deivid Wisci: "“Our campaign promise to steer Sordland towards the west ..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_West == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Deivid Wisci: "“Since we did not promise to align with neither east nor ..."*)

### Węzeł `[194]`
Mówca: **Deivid Wisci**
> "“Especially with Wehlen. As you know the current affairs of Wehlen are partly a result of United Contana's support of Wiktor Smolak. Our promise will come in handy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Deivid Wisci: "“As for Agnolia, this promise has made them cautious, whi..."*)

### Węzeł `[195]`
Mówca: **Deivid Wisci**
> "“Especially with Wehlen. As you know the current affairs of Wehlen are partly a result of United Contana's support of Wiktor Smolak. This will be a problem but definitely worth trying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Deivid Wisci: "“As for Agnolia, this promise has made them cautious, whi..."*)

### Węzeł `[196]`
Mówca: **Deivid Wisci**
> "“As for Agnolia, this promise has made them cautious, which might make it harder to get a good deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Deivid Wisci: "“We also need to consider the effects of our economic doc..."*)

### Węzeł `[197]`
Mówca: **Deivid Wisci**
> "“Since we did not promise to align with neither east nor west, it is very likely that their concerns would be more around the deal itself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Retaliate == true"*)

### Węzeł `[198]`
Mówca: **Deivid Wisci**
> "“We also need to consider the effects of our economic doctrine plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[199]`
Mówca: **Deivid Wisci**
> "“Very true, Mr. Vectern. We have a lot of time to prepare before the scheduled visits to Wehlen and Agnolia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Deivid Wisci: "“I believe this gives a brief overview of our current opt..."*)

### Węzeł `[200]`
Mówca: **Deivid Wisci**
> "“I believe this gives a brief overview of our current options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Deivid Wisci: "“Our trade delegation will begin work towards the end of ..."*)

### Węzeł `[201]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucian Galade: "“I will take my leave then.”"*)

### Węzeł `[202]`
Mówca: **Deivid Wisci**
> "“First off, the reason behind this option is more diplomatic than economic, although of course we can't forgo the added economic value. Agnolia is an old ally and a valuable trade partner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Deivid Wisci: "“The point we are at with the early negotiations is aroun..."*)

### Węzeł `[203]`
Mówca: **Deivid Wisci**
> "“The point we are at with the early negotiations is around the steel trade. They are demanding that we buy their steel for a higher price. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Deivid Wisci: "“That is because they think that the deal is far too unba..."*)

### Węzeł `[204]`
Mówca: **Deivid Wisci**
> "“Their second main demand is a privileged access to our agricultural market.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Deivid Wisci: "“If we are to fulfil their demands, in return they are of..."*)

### Węzeł `[205]`
Mówca: **Deivid Wisci**
> "“If we are to fulfil their demands, in return they are offering a full alliance with Sordland against Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Iosef Lancea: "“Looking at the current advances of Rumburg near our bord..."*)

### Węzeł `[206]`
Mówca: **Deivid Wisci**
> "“Obviously there will be consequences for entering a full alliance. Mainly the issue is around Heljiland. Valgsland has clear intentions on taking over the island one way or another and entering a military alliance with Agnolia will make them furious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Iosef Lancea: "“I want to state my support for the decision to stick to ..."*)

### Węzeł `[207]`
Mówca: **Lucian Galade**
> "“Ultimately the decision will be up to you as always.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_TradeAgnolia = true"*)

### Węzeł `[208]`
Mówca: **Deivid Wisci**
> "“That would be the best outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Deivid Wisci: "“If you decide that Agnolia is a good option, another poi..."*)

### Węzeł `[209]`
Mówca: **Deivid Wisci**
> "“It might be unsatisfactory in the short run however, it would have real impact on the long run.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Deivid Wisci: "“If you decide that Agnolia is a good option, another poi..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA: "“We can't position ourselves against Valgsland.”"]** — Mówca: **Player**
> "“We can't position ourselves against Valgsland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Deivid Wisci: "“That is certainly a valid reason.”"*)

### Węzeł `[211]`
Mówca: **Deivid Wisci**
> "“That is certainly a valid reason.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Deivid Wisci: "“If you decide that Agnolia is a good option, another poi..."*)

### Węzeł `[212]`
Mówca: **Deivid Wisci**
> "“Dealing with a fractured country like Wehlen has its positives and negatives. Although it will be lucrative in the short term, there are risks associated with dealing with such a country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Deivid Wisci: "“They are proposing co-investment projects and a no-tarif..."*)

### Węzeł `[213]`
Mówca: **Deivid Wisci**
> "“If you decide that Agnolia is a good option, another point is that they have a very democratic system. After the recent elections the PM has a mandate to arrange a fairer deal with us. Maartin Van Hoorten also is an avid supporter of relaxed immigration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Relaxed == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Relaxed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Deivid Wisci: "“Since we said we will keep immigration relaxed, it will ..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Relaxed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Deivid Wisci: "“Since we said we will tighten immigration, he might be r..."*)

### Węzeł `[217]`
Mówca: **Deivid Wisci**
> "“Since we said we will keep immigration relaxed, it will help us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[218]`
Mówca: **Deivid Wisci**
> "“Since we said we will tighten immigration, he might be reluctant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Deivid Wisci: "“Starting the highway construction in Agnland plays a par..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lucian Galade: "“Regardless, if we are going to increase our regional inf..."*)

### Węzeł `[222]`
Mówca: **Deivid Wisci**
> "“Starting the highway construction in Agnland plays a part too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lucian Galade: "“Regardless, if we are going to increase our regional inf..."*)

### Węzeł `[223]`
Mówca: **Deivid Wisci**
> "“My opinion is that this is a good deal and we should go for it. The new Agnolian Prime Minister is trying to improve the existing relationship.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Deivid Wisci: "“The downside is that we would need to make concessions. ..."*)

### Węzeł `[224]`
Mówca: **Deivid Wisci**
> "“They are proposing co-investment projects and a no-tariff agreement. They are also offering oil in return for attracting foreign capital interests from Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Deivid Wisci: "“However, it is possible that there will be international..."*)

### Węzeł `[225]`
Mówca: **Deivid Wisci**
> "“However, it is possible that there will be international ramifications of getting closer with a country like Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Deivid Wisci: "“All in all, this is a very lucrative deal for us. Howeve..."*)

### Węzeł `[226]`
Mówca: **Deivid Wisci**
> "“If we wish to go forward with the deal when the time comes, there is the topic of immigration to consider.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Tighten == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Tighten == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Tighten == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Tighten == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Tighten"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Deivid Wisci: "“Wiktor Smolak is a known isolationist. Our promise to ti..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Tighten == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Tighten"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Deivid Wisci: "“Wiktor Smolak is a known isolationist. Our promise to ke..."*)

### Węzeł `[230]`
Mówca: **Deivid Wisci**
> "“Wiktor Smolak is a known isolationist. Our promise to tighten our immigration policy will increase the likelihood of the deal. He believes our borders need better security.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Lucian Galade: "“I personally don't like the idea of getting too close to..."*)

### Węzeł `[231]`
Mówca: **Deivid Wisci**
> "“Wiktor Smolak is a known isolationist. Our promise to keep our immigration policy relaxed will not help at all. He blames us for bringing western interests to the region. He also doesn't want his political opponents to flee here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Lucian Galade: "“I personally don't like the idea of getting too close to..."*)

### Węzeł `[232]`
Mówca: **Lucian Galade**
> "“I personally don't like the idea of getting too close to Wehlen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Deivid Wisci: "“Me too.”"*)

### Węzeł `[233]`
Mówca: **Deivid Wisci**
> "“Me too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Iosef Lancea: "“Agreed.”"*)

### Węzeł `[234]`
Mówca: **Iosef Lancea**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Petr Vectern: "“I still think we should give it a try.”"*)

### Węzeł `[235]`
Mówca: **Petr Vectern**
> "“I still think we should give it a try.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_TradeWehlen = true"*)

### Węzeł `[236]`
Mówca: **Iosef Lancea**
> "“Looking at the current advances of Rumburg near our borders, having a coalition against Rumburg would prove extremely useful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Deivid Wisci: "“Obviously there will be consequences for entering a full..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_ClosedSordlandConsulateInRumburg = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_ClosedSordlandConsulateInRumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Rumburg", "Ho..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_CondemnedRumburg = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_CondemnedRumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Deivid Wisci: "“As you wish Mr. President. I shall begin work by immedia..."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "After he settled himself, he regarded me with delight, his blue eyes sparkling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Deivid Wisci: "“Look at you, Anton. The 4th President of Sordland. What ..."*)

### Węzeł `[240]`
Mówca: **Deivid Wisci**
> "“That is because they think that the deal is far too unbalanced as it is. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Deivid Wisci: "“Their second main demand is a privileged access to our a..."*)

### Węzeł `[241]`
Mówca: **Deivid Wisci**
> "“All in all, this is a very lucrative deal for us. However, we need to think about the consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Iosef Lancea: "“I certainly don't support the decision to become friendl..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_ST_PresidentAbsent = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_PresidentAbsent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness == true &&..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_Funeral_DontAttend == true && BaseGame.Media_SordlandToday_Bias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_DontAttend == true && Ba..."*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_Funeral_DontAttend == true && ..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_Funeral_DontAttend == true && BaseGame.Media_SordlandToday_Bias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_Funeral_DontAttend"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_PresidentAbsent = true"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_Funeral_DontAttend == true && BaseGame.Media_SordlandToday_Bias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_Funeral_DontAttend"] == true  and  Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness == true &&..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness == true && BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusiness == true &&..."*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusiness == true ..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusiness == true && BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusiness == true && BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  and  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Bailing out businesses under financial s..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedPeople ==..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Giving stimulus checks to the people in ..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_FPnT_DiplomacyOverview = true"*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I'm interested to hear the intentions of the Kingdom of Rizia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Deivid Wisci: "“Former President Alphonso signed trade agreements with K..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Rizia Trade Offer`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == true &..."*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == false"*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer == false"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true &&..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Trade Exit]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "Trade Exit"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == false"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == false)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Player: "“I'd like to know more about Rizia.”"*)
  - -> `[283]` (*Player: "“I don't need any further information about Rizia.”"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer == false"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer == false)"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: "“Let's discuss the deal potential and what's on the table.”"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[266]`
Mówca: **Deivid Wisci**
> "“There are three trade-related topics to address today. Which topic should we tackle first?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: "“We should talk about the ongoing trade negotiations with..."*)
  - -> `[256]` (*Player: "“I'm interested to hear the intentions of the Kingdom of ..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true && BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true &&..."*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true ..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true && BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "Jump to: [Trade Exit]"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true && BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rizia Trade Offer]"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Trade Exit]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "Trade Exit"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == true && BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == true..."*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == tr..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == true && BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Deivid Wisci: "“Well, that concludes our meeting, Mr. Rayne.”"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == true && BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Trade Exit`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == true..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Rizia Trade Offer]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "Rizia Trade Offer"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true && BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true &&..."*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true ..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true && BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "Jump to: [Trade Exit]"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub == true && BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_TradePolicy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "Jump to: [Wehlen Agnolia Trade]"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Wehlen Agnolia Trade]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "Wehlen Agnolia Trade"*)

### Węzeł `[280]`
Mówca: **Deivid Wisci**
> "“In 1918, King Egmund signed a trade deal with Queen Lyza 'the Great' to save the Kingdom from economic collapse with the support of his key advisors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Deivid Wisci: "“Some Rizians who settled for the deal in the final years..."*)

### Węzeł `[281]`
Mówca: **Deivid Wisci**
> "“Yes, the Rizian gold invested in Sordland in exchange for different degrees of ownership of state assets strengthened the currency by boosting the Central Bank reserves and averted a full depression after the '51 Recession.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Deivid Wisci: ""Edith Agnoc's handling with the Central Bank measures to..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rizia Trade Offer]"*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I don't need any further information about Rizia.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc"] == false` AND `(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[314]` (Lucian Galade), `[317]` (Iosef Lancea), `[324]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Deivid Wisci: "“Of course, Mr. President.”"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rizia Trade Offer]"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == true && BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == true &..."*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == true..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == true && BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaHub = true"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc == true && BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc"] == true  and  Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Let's discuss the deal potential and what's on the table.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer"] == false` AND `(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[314]` (Lucian Galade), `[317]` (Iosef Lancea), `[324]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Deivid Wisci: "“From what we have gathered, there is no clear offer yet...."*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I'd like to know more about Rizia.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc"] == false` AND `(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[314]` (Lucian Galade), `[317]` (Iosef Lancea), `[324]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_Country_Rizia");"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Rizia Trade Offer]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "Rizia Trade Offer"*)

### Węzeł `[291]`
Mówca: **Deivid Wisci**
> "“Our neutrality strategy would have been seen as positive by nations like Rumburg if we hadn't decided to retaliate aggressively.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Deivid Wisci: "“The last handful of monarchies in Merkopa are reactive a..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Retaliate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Retaliate == true"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_FPnT_Consulate_Retaliate == true)"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Retaliate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Deivid Wisci: "“Our neutrality strategy would have been seen as positive..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_FPnT_Consulate_Retaliate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Deivid Wisci: "“Our neutrality strategy might ease the tensions with Rum..."*)

### Węzeł `[295]`
Mówca: **Deivid Wisci**
> "“Our neutrality strategy might ease the tensions with Rumburg, since their primary concern is the strengthening of the superpower blocs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Deivid Wisci: "“The last handful of monarchies in Merkopa are reactive a..."*)

### Węzeł `[296]`
Mówca: **Deivid Wisci**
> "“The last handful of monarchies in Merkopa are reactive against the influences of Arcasian Capitalism and Malenyevism.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Deivid Wisci: "“We also need to consider the effects of our economic doc..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention = true; BaseGameSupport.Journal_Turn02_RiziaEnergy_Interest = true; BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] = true;
Variable["BaseGameSupport.Journal_Turn02_RiziaEnergy_Interest"] = true;
Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Deivid Wisci: "“There is strong potential for further cooperation, and R..."*)

### Węzeł `[298]`
Mówca: **Deivid Wisci**
> "“King Romus is interested in increasing energy independence and diversifying his energy assets. Our sources indicate that he wants to acquire control of more natural gas resources.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true ..."*)
  - -> `[300]` (*Player: "“We are still facing the potential of a recession. New av..."*)
  - -> `[301]` (*Player: "“Isn't this unusual? Aren't you and the Ministry of Forei..."*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I'm cynical about monarchies. Their time in Merkopa seems to be running out, and their stability is in question.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[298]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Deivid Wisci: "“The international web of monarchies and sympathizers acr..."*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We are still facing the potential of a recession. New avenues for trade could help keep our books balanced.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Deivid Wisci: "“Rizia is a developed nation with a resilient economy tha..."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Isn't this unusual? Aren't you and the Ministry of Foreign Affairs in charge of arranging negotiations?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Deivid Wisci: "“Usually, yes, but in special scenarios such as this, rea..."*)

### Węzeł `[302]`
Mówca: **Iosef Lancea**
> "“The Toras and Livingston families should be considered allies for the time being. However, from a practical standpoint, they are too far from each other to provide military support.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Deivid Wisci: "“Both countries are also part of the worldwide network of..."*)

### Węzeł `[303]`
Mówca: **Petr Vectern**
> "“Classic Wild Gus. Even before we started campaigning, he was in the game non-stop. Gus, connecting people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Lucian Galade: "“It wouldn't be bad to focus on the important job of keep..."*)

### Węzeł `[304]`
Mówca: **Lucian Galade**
> "“Self-reliant monarchies like Rumburg are much more likely to last. But for the time being, many of the international monarchs have close ties and trade with each other to avoid revolution and change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Iosef Lancea: "“We must take into account Rizia’s blood ties and de fact..."*)

### Węzeł `[305]`
Mówca: **Deivid Wisci**
> "“Both countries are also part of the worldwide network of monarchies known as GRACE. The framework is mostly financially and politically motivated due to the pressures of Malenyevism and democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Petr Vectern: "“All these kings and queens disagree more than agree, but..."*)

### Węzeł `[306]`
Mówca: **Deivid Wisci**
> "“Rizia is a developed nation with a resilient economy thanks to its gold wealth. They can aid Sordland's economic health and the fiscal pain points Minister Holl keeps highlighting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Lucian Galade: "“As Minister Holl rightfully described, we must do everyt..."*)

### Węzeł `[307]`
Mówca: **Deivid Wisci**
> "“Usually, yes, but in special scenarios such as this, real and close connections between people can improve the likelihood of a positive outcome. Since Mr. Manger has the strongest relations with the envoy, we have assigned staff to him to help with the talks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Petr Vectern: "“Classic Wild Gus. Even before we started campaigning, he..."*)

### Węzeł `[308]`
Mówca: **Deivid Wisci**
> "“The international web of monarchies and sympathizers across all the continents of Merkopa, Rika, Xina, Contana have united under The Guild of Royal Allies for Commercial Exchange.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Deivid Wisci: "“GRACE has proven more resilient than the international c..."*)

### Węzeł `[309]`
Mówca: **Iosef Lancea**
> "“We must take into account Rizia’s blood ties and de facto alliance with Rumburg. The King married into the Livingston family. Geographically, Rizia and Rumburg are too far to help each other; their only actual link is through sea lanes passing by Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Lucian Galade: "“Regardless, ideological or political motivations are les..."*)

### Węzeł `[310]`
Mówca: **Petr Vectern**
> "“I'm sure if Gus is involved, the deal will be financially viable. His connections in the business world are vast.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == false"*)

### Węzeł `[311]`
Mówca: **Lucian Galade**
> "“As Minister Holl rightfully described, we must do everything in our power not to fall into debt with an unhealthy economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Petr Vectern: "“I'm sure if Gus is involved, the deal will be financiall..."*)

### Węzeł `[312]`
Mówca: **Lucian Galade**
> "“But as long as we are getting a good offer, it doesn’t matter who officially leads the negotiation. I’m sure Mr. Wisci doesn’t mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Deivid Wisci: "“Alphonso's Minister of Foreign Affairs, Keres, coordinat..."*)

### Węzeł `[313]`
Mówca: **Lucian Galade**
> "“We should be more concerned with-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "Petr interjected and reached in his pocket."*)

### Węzeł `[314]`
Mówca: **Lucian Galade**
> "“Regardless, ideological or political motivations are less of a concern. We need to assess what Sordland stands to benefit from a potential agreement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "Rizia Trade Offer"*)

### Węzeł `[315]`
Mówca: **Iosef Lancea**
> "“If Rizia wants to buy more than 20 percent of shares allowed by the protectionism laws, then the government can step in to make changes to the EPA.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Lucian Galade: "“Precisely, but we don’t know if this will be the case. T..."*)

### Węzeł `[316]`
Mówca: **Lucian Galade**
> "“Precisely, but we don’t know if this will be the case. There is a scenario in which they might invest within the EPA limitations; we just have to hear more before weighing the options.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Petr Vectern: "“They never revealed much about their involvement to me, ..."*)

### Węzeł `[317]`
Mówca: **Iosef Lancea**
> "“The military should also be funded appropriately if additional resources are to be acquired.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "Rizia Trade Offer"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == false"*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Military == false)"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Iosef Lancea: "“The military should also be funded appropriately if addi..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Military == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "Rizia Trade Offer"*)

### Węzeł `[321]`
Mówca: **Deivid Wisci**
> "“We have no close contacts with the Toras royals anymore. It leaves us little option but to use the back channel of Mr. Manger and President Alphonso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player: "“*Former* President Alphonso.”"*)
  - -> `[323]` (*Player: "“That sounds good to me.”"*)
  - -> `[475]` (*Player: "“Well, we can continue official dialogue after this. It m..."*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“*Former* President Alphonso.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Deivid Wisci: "“Ah, yes, Mr. President. Excuse me. Former President Alph..."*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“That sounds good to me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Deivid Wisci: "“Very well.”"*)

### Węzeł `[324]`
Mówca: **Deivid Wisci**
> "“Ah, yes, Mr. President. Excuse me. Former President Alphonso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "Rizia Trade Offer"*)

### Węzeł `[325]`
Mówca: **Deivid Wisci**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "Rizia Trade Offer"*)

### Węzeł `[326]`
Mówca: **Deivid Wisci**
> "“From what we have gathered, there is no clear offer yet. The interest clearly seems to be more control over the gas produced and sold in Sordland. I suspect this must be related to the recent tensions on the coast of Pales.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Deivid Wisci: "“Mr. Manger is working out the details to get more concre..."*)

### Węzeł `[327]`
Mówca: **Petr Vectern**
> "“That must be related to Gasom operations. Gus has ties with the people around that corporation. Even though there is another CEO, Ewald Alphonso is still chairman.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Lucian Galade: "“Gasom is a private corporation, a fact that limits our c..."*)

### Węzeł `[328]`
Mówca: **Lucian Galade**
> "“I suspect that the corporation isn’t doing too well, and they are seeking investments. Any investment into Gasom will enrich the owners but might also lead to more jobs and growth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Deivid Wisci: "“Any further comments, esteemed cabinet members?”"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Rizia Trade Offer]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "Rizia Trade Offer"*)

### Węzeł `[330]`
Mówca: **Deivid Wisci**
> "“Of course, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc = true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Turn02_FPnT_Consulate_Retaliate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true ..."*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == tru..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Turn02_FPnT_Consulate_Retaliate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Player: "“Why deal with a monarchy? They've sucked enough blood fr..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Turn02_FPnT_Consulate_Retaliate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Player: "“I'm cynical about monarchies. Their time in Merkopa seem..."*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Why deal with a monarchy? They've sucked enough blood from the people of Merkopa.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true`
- **Kontekst wejściowy (poprzednik):** `[298]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Petr Vectern: "“Strong words, Anton. I like it!”"*)

### Węzeł `[335]`
Mówca: **Petr Vectern**
> "“Strong words, Anton. I like it!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Deivid Wisci: "“From a humanistic standpoint, without the general popula..."*)

### Węzeł `[336]`
Mówca: **Deivid Wisci**
> "“From a humanistic standpoint, without the general population participating in governance, equality problems arise. Yet these countries are here to stay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Deivid Wisci: "“The international web of monarchies and sympathizers acr..."*)

### Węzeł `[337]`
Mówca: **Deivid Wisci**
> "“Mr. Manger is working out the details to get more concrete headline terms soon. Of particular interest are the gas fields in the Narbel area of the Nargis region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Petr Vectern: "“That must be related to Gasom operations. Gus has ties w..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We should protect our energy independence, but we don’t know the offer's specifics yet.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Deivid Wisci: "“I agree, but Gasom is a private corporation. Even though..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Affluent Sords don’t stray far from each other.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Petr Vectern: "“Why would they? Similar circles, similar educational bac..."*)

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The shareholder links raise questions regarding Alphonso and Manger's motivations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Lucian Galade: "“I suspect that the corporation isn’t doing too well, and..."*)

### Węzeł `[341]`
Mówca: **Deivid Wisci**
> "“I agree, but Gasom is a private corporation. Even though it mostly supplies the government, we have little control over it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Iosef Lancea: "“If Rizia wants to buy more than 20 percent of shares all..."*)

### Węzeł `[342]`
Mówca: **Petr Vectern**
> "“Why would they? Similar circles, similar educational background, companies. Half of the oligarchs are from LBS or Harcard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Deivid Wisci: "“Any further comments, esteemed cabinet members?”"*)

### Węzeł `[343]`
Mówca: **Lucian Galade**
> "“Gasom is a private corporation, a fact that limits our control over any foreign investment. Tarquin Soll's Energy Protection Act of 1932 specifically limits the purchases of Sordish energy company shares by foreign nations to ten percent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Lucian Galade: "“Ewald Alphonso adjusted this law in 1948 and increased i..."*)

### Węzeł `[344]`
Mówca: **Iosef Lancea**
> "“As a sovereign nation, we must protect our resources. Our energy independence is part of our national security concern here; Gasom handles most of our gas production.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[338]` (*Player: "“We should protect our energy independence, but we don’t ..."*)
  - -> `[345]` (*Player: "“As long as we can improve our economy and resource extra..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“As long as we can improve our economy and resource extraction, we shouldn’t care much.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Deivid Wisci: "“I think we must act pragmatically in this case. I stand ..."*)

### Węzeł `[346]`
Mówca: **Deivid Wisci**
> "“I think we must act pragmatically in this case. I stand with Mr. Galade, as long as the country stands to benefit economically and there are no human rights concerns.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Iosef Lancea: "“If Rizia wants to buy more than 20 percent of shares all..."*)

### Węzeł `[347]`
Mówca: **Lucian Galade**
> "“I have information that the CEO that replaced Alphonso is a loyalist. Alphonso still is the chairman of Gasom and the de facto key figure. Additionally, National Business Council Chairman Mikail Aven and Minister Gus Manger have shares in the company and preside over the board.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Player: "“The power structure behind the scenes shouldn't matter m..."*)
  - -> `[339]` (*Player: "“Affluent Sords don’t stray far from each other.”"*)
  - -> `[340]` (*Player: "“The shareholder links raise questions regarding Alphonso..."*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I look favorably towards a potential investment from Rizia into Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention = true;..."*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We will have to wait and hear more from Mr. Manger to decide.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Petr Vectern: "“If there's one thing Gus is good at, it’s making deals.”"*)

### Węzeł `[350]`
Mówca: **Deivid Wisci**
> "“There is strong potential for further cooperation, and Rizia previously aided Sordland when it needed foreign help the most.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Lucian Galade: "“I will assist in analyzing the political implications, M..."*)

### Węzeł `[351]`
Mówca: **Petr Vectern**
> "“If there's one thing Gus is good at, it’s making deals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Deivid Wisci: "“I’m curious how it will develop. It’s mostly out of the ..."*)

### Węzeł `[352]`
Mówca: **Deivid Wisci**
> "“Thank you. Our support staff and I will be working towards the next steps soon after receiving more context from Mr. Manger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Deivid Wisci: "“Our ambassador in Porte Drazon is in communication with ..."*)

### Węzeł `[353]`
Mówca: **Lucian Galade**
> "“I will assist in analyzing the political implications, Mr. Wisci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Deivid Wisci: "“Thank you. Our support staff and I will be working towar..."*)

### Węzeł `[354]`
Mówca: **Deivid Wisci**
> "“Our ambassador in Porte Drazon is in communication with Laurento Esquibel, the Rizian Councilor of Foreign Affairs, already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaOffer = true"*)

### Węzeł `[355]`
Mówca: **Deivid Wisci**
> ""The nation south of Lespia is a centralized constitutional monarchy led by King Romus Toras. The grandson of Queen Lyza Toras, 'the Great', and son of King Valero Toras, 'the Frail'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Lucian Galade: "“The kingdom is a developed nation that wielded considera..."*)

### Węzeł `[356]`
Mówca: **Deivid Wisci**
> "“The Alphonso government signed vital trade agreements with King Romus Toras, benefitting both nations at a time of need. Attempts at further cooperation stalled out due to the King's blood ties to Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Player: "“What exactly are these blood ties between Rizia and Rumb..."*)
  - -> `[362]` (*Player: "“I’m curious how our neighbors Lespia and Wehlen get alon..."*)

### Węzeł `[357]`
Mówca: **Narrator**
> "Petr pulled out the ornamental coin and put it on the table. It was so polished that it caught reflections of light in the room. Lucian was clearly frustrated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Player_Italic: "Examine the coin."*)
  - -> `[365]` (*Player: "“Not bad. You can't go wrong with gold.”"*)
  - -> `[504]` (*Player: "“You don't need help finding love. You've got Evelyn, rig..."*)
  - -> `[413]` (*Player: "“Let's move on.”"*)

### Węzeł `[358]`
Mówca: **Lucian Galade**
> "“The kingdom is a developed nation that wielded considerable influence in Southern Merkopa before the reign of Valero. The country has lost some territory due to internal strife.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Deivid Wisci: "“The Alphonso government signed vital trade agreements wi..."*)

### Węzeł `[359]`
Mówca: **Deivid Wisci**
> "“There is some tension with both. It appears that since Lespia's acceptance into ATO in 1950, most of South Merkopa has been heading towards a boiling point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Iosef Lancea: "“Not to mention Wehlen's struggles with the BFF, an organ..."*)

### Węzeł `[360]`
Mówca: **Deivid Wisci**
> "“In the 1930s, King Romus married Princess Lena Livingston, the youngest daughter of King Alfred Livingston the Second, sister of Queen Beatrice Livingston.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“It was a political marriage that benefitted Rizia, helpi..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“What exactly are these blood ties between Rizia and Rumburg?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Deivid Wisci: "“In the 1930s, King Romus married Princess Lena Livingsto..."*)

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I’m curious how our neighbors Lespia and Wehlen get along with Rizia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Deivid Wisci: "“There is some tension with both. It appears that since L..."*)

### Węzeł `[363]`
Mówca: **Petr Vectern**
> "“Actually, a friend of Gus called Rusty gifted me this beautiful piece of full Rizian gold coin. They say it helps you find love. Look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Narrator: "Petr pulled out the ornamental coin and put it on the tab..."*)

### Węzeł `[364]`
**[WYBÓR GRACZA: "Examine the coin."]** — Mówca: **Player_Italic**
> "I took the coin in my hands and looked at the details."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "At the center was the emblem of Rizia, a fierce bull stan..."*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Not bad. You can't go wrong with gold.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Petr Vectern: "“Sure can't.”"*)

### Węzeł `[366]`
Mówca: **Narrator**
> "Petr interjected and reached in his pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Petr Vectern: "“Actually, a friend of Gus called Rusty gifted me this be..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "LookAtModeOff();"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Rizia Trade Offer]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "Rizia Trade Offer"*)

### Węzeł `[369]`
Mówca: **Lucian Galade**
> "“It was a political marriage that benefitted Rizia, helping save it from downfall. The two nations are close, to say the least.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Iosef Lancea: "“The Toras and Livingston families should be considered a..."*)

### Węzeł `[370]`
Mówca: **Petr Vectern**
> "“All these kings and queens disagree more than agree, but they're forced to tolerate each other's differences. Imagine if Koronti and the SBC cast the world's remaining monarchs in a soap opera.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[371]` (*Player: "“I would watch the hell out of that.”"*)
  - -> `[372]` (*Player: "“Lets stay on point.”"*)

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I would watch the hell out of that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[370]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Petr Vectern: "“I'll bring the popcorn!”"*)

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Lets stay on point.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[370]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Petr Vectern: "“Sure, sure!”"*)

### Węzeł `[373]`
Mówca: **Deivid Wisci**
> "“This new engagement regarding the Rizian investment interest is coordinated through our Minister of Agriculture and Rural Development, Gus Manger, and former President Alphonso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Deivid Wisci: "“King Romus is interested in increasing energy independen..."*)

### Węzeł `[374]`
Mówca: **Deivid Wisci**
> "“Many are not official allies, but have economic pacts to secure global independence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lucian Galade: "“Self-reliant monarchies like Rumburg are much more likel..."*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The Kingdom was meant to collapse. Nothing could save it, regardless of the effort.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Deivid Wisci: "“Times change, and any good leader must make an effort to..."*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Your father was truly a great man, may he rest in peace.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Deivid Wisci: "“Thank you, Anton. I hope our nation never faces the trag..."*)

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“In the Tarquin Soll period, we never saw such dependency on foreign nations.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Lucian Galade: "“Yes, with the exceptionally successful SSC bills, the So..."*)

### Węzeł `[378]`
Mówca: **Lucian Galade**
> "“Looking a few years back, they played a significant role in helping Sordland avoid depression. There is merit to this fact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Deivid Wisci: "“Yes, the Rizian gold invested in Sordland in exchange fo..."*)

### Węzeł `[379]`
Mówca: **Deivid Wisci**
> "“Former President Alphonso signed trade agreements with King Romus Toras of Rizia. The previous government revived the older relationship that existed during the days of the Sordish monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Deivid Wisci: "“In 1918, King Egmund signed a trade deal with Queen Lyza..."*)

### Węzeł `[380]`
Mówca: **Lucian Galade**
> "“Yes, with the exceptionally successful SSC bills, the Soll government raised funds for its autarky plans from the Sordish population alone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Iosef Lancea: "“The Colonel knew the real intentions of foreign powers. ..."*)

### Węzeł `[381]`
Mówca: **Iosef Lancea**
> "“The Colonel knew the real intentions of foreign powers. Our strength comes from within. Our greatest resource is our people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Deivid Wisci: "“Independence is important, but as the world is changing ..."*)

### Węzeł `[382]`
Mówca: **Petr Vectern**
> "“He deserved a more honorable end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "The room went silent for a moment."*)

### Węzeł `[383]`
Mówca: **Deivid Wisci**
> "“Independence is important, but as the world is changing and our continental blocs are trading more with one another, we must adapt. There is a place for trade and co-development with nations like Rizia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Lucian Galade: "“Looking a few years back, they played a significant role..."*)

### Węzeł `[384]`
Mówca: **Deivid Wisci**
> "“Thank you, Anton. I hope our nation never faces the tragedies of those dark days again. He was the best father one could have wanted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Petr Vectern: "“He deserved a more honorable end.”"*)

### Węzeł `[385]`
Mówca: **Narrator**
> "The room went silent for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Petr Vectern: "“Let's continue our discussion about Rizia.”"*)

### Węzeł `[386]`
Mówca: **Petr Vectern**
> "“Let's continue our discussion about Rizia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Lucian Galade: "“Looking a few years back, they played a significant role..."*)

### Węzeł `[387]`
Mówca: **Lucian Galade**
> "“King Egmund was far too isolated and detached. Figures like Heron Walt and Artor S. Wisci spent a great deal of effort attempting to bring him to his senses.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Iosef Lancea: "Our Republic stands on firmer footing despite these recen..."*)

### Węzeł `[388]`
Mówca: **Deivid Wisci**
> "“Times change, and any good leader must make an effort to adapt. The Kingdom indeed had structural flaws that led to the Republic my father founded.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Lucian Galade: "“King Egmund was far too isolated and detached. Figures l..."*)

### Węzeł `[389]`
Mówca: **Iosef Lancea**
> "Our Republic stands on firmer footing despite these recent troubles than those days.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Petr Vectern: "“Let's continue our discussion about Rizia.”"*)

### Węzeł `[390]`
Mówca: **Deivid Wisci**
> ""Edith Agnoc's handling with the Central Bank measures to prevent the depression also deserves credit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Deivid Wisci: "“This new engagement regarding the Rizian investment inte..."*)

### Węzeł `[391]`
Mówca: **Lucian Galade**
> "“The relationship between Rizia and Wehlen is more complex than that. They were closely aligned under Valero's rule until Rumburg entered the play.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Player: "“We have enough issues to figure out; we can’t worry abou..."*)
  - -> `[394]` (*Player: "“Merkopan geopolitics are a complexity of another caliber.”"*)
  - -> `[473]` (*Player: "“Anytime Rumburg enters the 'play', crap hits the fan.”"*)

### Węzeł `[392]`
Mówca: **Iosef Lancea**
> "“Not to mention Wehlen's struggles with the BFF, an organization that we've long suspected to be armed by King Romus' in-laws in Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Lucian Galade: "“The relationship between Rizia and Wehlen is more comple..."*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We have enough issues to figure out; we can’t worry about the problems of others.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[391]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Deivid Wisci: "“It's good to be informed in the diplomacy field. There i..."*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Merkopan geopolitics are a complexity of another caliber.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[391]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Deivid Wisci: "“My job is to make sense of it. It is a privilege I enjoy..."*)

### Węzeł `[395]`
Mówca: **Deivid Wisci**
> "“My job is to make sense of it. It is a privilege I enjoy, regardless of my age.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Petr Vectern: "“I heard Smolak also makes sense of things with certain s..."*)

### Węzeł `[396]`
Mówca: **Petr Vectern**
> "“I'll bring the popcorn!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Narrator: "Lucian knocked on the table."*)

### Węzeł `[397]`
Mówca: **Petr Vectern**
> "“Sure, sure!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Narrator: "Lucian knocked on the table."*)

### Węzeł `[398]`
Mówca: **Narrator**
> "At the center was the emblem of Rizia, a fierce bull standing on two feet with its horns pointed upwards. In the background was a shield intricately ornamented with leaves and a crown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Narrator: "At the bottom, the letters RRG were engraved."*)

### Węzeł `[399]`
Mówca: **Narrator**
> "At the bottom, the letters RRG were engraved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Player: "“What is RRG?”"*)
  - -> `[401]` (*Player: "“Nice piece, Petr.”"*)

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“What is RRG?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Petr Vectern: "“It's Rizian Royal Gold. The company that mines and proce..."*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Nice piece, Petr.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Petr Vectern: "“Thanks. Maybe I'll turn it into a golden tooth when I ge..."*)

### Węzeł `[402]`
Mówca: **Petr Vectern**
> "“Thanks. Maybe I'll turn it into a golden tooth when I get old.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc = true"*)

### Węzeł `[403]`
Mówca: **Petr Vectern**
> "“It's Rizian Royal Gold. The company that mines and processes the high-quality ore used to mint the country's gold.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc = true"*)

### Węzeł `[404]`
Mówca: **Petr Vectern**
> "“Sure can't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Lucian Galade: "“Moving on.”"*)

### Węzeł `[405]`
Mówca: **Deivid Wisci**
> "“Some Rizians who settled for the deal in the final years of Kingdom still live in the Old Town of Holsord to this day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Deivid Wisci: "“The main negotiator was my father, former president Arto..."*)

### Węzeł `[406]`
Mówca: **Deivid Wisci**
> "“It's good to be informed in the diplomacy field. There is always so much movement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Petr Vectern: "“Speaking of movement, have you seen the latest numbers o..."*)

### Węzeł `[407]`
Mówca: **Deivid Wisci**
> "“I think this summarizes all we know and what we stand to gain, Mr. President. What are your thoughts?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player: "“I look favorably towards a potential investment from Riz..."*)
  - -> `[349]` (*Player: "“We will have to wait and hear more from Mr. Manger to de..."*)

### Węzeł `[408]`
Mówca: **Deivid Wisci**
> "“I’m curious how it will develop. It’s mostly out of the hands of the Ministry of Foreign Affairs for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Lucian Galade: "“I will assist in analyzing the political implications, M..."*)

### Węzeł `[409]`
Mówca: **Narrator**
> "Deivid hesitated for a brief moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Player: "“The Kingdom was meant to collapse. Nothing could save it..."*)
  - -> `[376]` (*Player: "“Your father was truly a great man, may he rest in peace.”"*)
  - -> `[377]` (*Player: "“In the Tarquin Soll period, we never saw such dependency..."*)

### Węzeł `[410]`
Mówca: **Deivid Wisci**
> "“The main negotiator was my father, former president Artor S. Wisci, who, with the Republican faction of the King’s parliament, fought to achieve a rare consensus in the heavily fractured council at the time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Deivid Wisci: "“Mot He Vest Peasa.”"*)

### Węzeł `[411]`
Mówca: **Deivid Wisci**
> "“Mot He Vest Peasa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Narrator: "Deivid hesitated for a brief moment."*)

### Węzeł `[412]`
Mówca: **Lucian Galade**
> "“It wouldn't be bad to focus on the important job of keeping our farmers and rural population happy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Lucian Galade: "“But as long as we are getting a good offer, it doesn’t m..."*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Let's move on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Lucian Galade: "“As you wish, and thank you.”"*)

### Węzeł `[414]`
Mówca: **Lucian Galade**
> "“As you wish, and thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc = true"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true)"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Player: "“Things didn't end amicably between us. I mean, we aggres..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_PublicBlame == true"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true && BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true && ..."*)
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_CampaignedForAlphonso == true &..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true && BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true  and  Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Player: "“Remember campaigning for him back in the day? He wouldn'..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_CampaignedForAlphonso == true && BaseGame.Prologue_Speech_Democracy_Liberal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true  and  Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true && BaseGame.Prologue_Studyplace_Lachaven_Economics == true && BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true && Bas..."*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true && B..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true && BaseGame.Prologue_Studyplace_Lachaven_Economics == true && BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true  and  Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true  and  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Player: "“He was right to open up the country, regardless of what ..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true && BaseGame.Prologue_Studyplace_Lachaven_Economics == true && BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true  and  Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true  and  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[424]`
Mówca: **Lucian Galade**
> "“Ewald Alphonso adjusted this law in 1948 and increased it to up to 20 percent. Anything above that requires us to change the Energy Protection Act. Ewald holds most of Gasom's cards in his hands still.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true && ..."*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true && Bas..."*)
  - -> `[428]` (*Player: "“I see a strong case for Tarquin Soll's regulation. Energ..."*)
  - -> `[429]` (*Player: "“Gasom is private, but it still sells most of the gas it ..."*)

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Remember campaigning for him back in the day? He wouldn't have gotten the USP leadership without us.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true  and  Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true`
- **Kontekst wejściowy (poprzednik):** `[424]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Petr Vectern: "“I've got to say his team was great to work with. Topplin..."*)

### Węzeł `[426]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Things didn't end amicably between us. I mean, we aggressively destroyed his campaign team one by one.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Kontekst wejściowy (poprzednik):** `[424]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Petr Vectern: "“It wasn’t my preferred method, Anton, but it worked. I h..."*)

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“He was right to open up the country, regardless of what happened in '51. Sordland is in a good position to benefit from world trade.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true  and  Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true  and  Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Kontekst wejściowy (poprzednik):** `[424]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Petr Vectern: "“I agree with you, Anton, and I'll always support you, bu..."*)

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I see a strong case for Tarquin Soll's regulation. Energy security is important for our nation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Petr Vectern: "“We don't want to find ourselves in the energy crisis sit..."*)

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Gasom is private, but it still sells most of the gas it produces to Sordland, right?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Petr Vectern: "“I think so, yes. Lucian knows more than me.”"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_PublicBlame == true"*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_PublicBlame == true)"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_PublicBlame == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Player: "“The way we publicly embarrassed him on national televisi..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_PublicBlame == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Diplomatic == true"*)

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The way we publicly embarrassed him on national television won't help further dialogue.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true` AND `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[424]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Petr Vectern: "“Any political opponent would have done what we did. Ther..."*)

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Good thing, we handled the transfer of power within the party diplomatically. I'm sure he will be more open to talk.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true` AND `(Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true) == false` AND `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[424]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Petr Vectern: "“Yeah, so many people in the party approached me and prai..."*)

### Węzeł `[435]`
Mówca: **Iosef Lancea**
> "“His decision not to increase the armed forces budget for the term was unprecedented. President Soll would always fund our troops a little more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Deivid Wisci: "“We helped him get to power, but also led him to his fall..."*)

### Węzeł `[436]`
Mówca: **Lucian Galade**
> "“We had to break the status quo to get into government ourselves. I always thought Alphonso was too optimistic about his grand plans.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Iosef Lancea: "“His decision not to increase the armed forces budget for..."*)

### Węzeł `[437]`
Mówca: **Deivid Wisci**
> "“We helped him get to power, but also led him to his fall. Such a peaceful transition with the '53 elections, however, showed the strength of our democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "Lucian pulled out a pen and took a few notes."*)

### Węzeł `[438]`
Mówca: **Petr Vectern**
> "“I've got to say his team was great to work with. Toppling Tarquin Soll was a historic moment in the USP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Lucian Galade: "“We had to break the status quo to get into government ou..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Diplomatic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Diplomatic == true"*)
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Diplomatic == true)"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Diplomatic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Player: "“Good thing, we handled the transfer of power within the ..."*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Diplomatic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[442]`
Mówca: **Iosef Lancea**
> "“Fueling the Rumburg war machine is indisputably wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "Lucian pulled out a pen and took a few notes."*)

### Węzeł `[443]`
Mówca: **Lucian Galade**
> "“Up to 70 percent goes to Sordland. This used to be higher, but international demand has seen Gasom diversify its deliveries outward.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Deivid Wisci: "“Rumburg and Lespia are increasing their demand each year..."*)

### Węzeł `[444]`
Mówca: **Deivid Wisci**
> "“Rumburg and Lespia are increasing their demand each year. They have hungry industries waiting to be fulfilled.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Iosef Lancea: "“Fueling the Rumburg war machine is indisputably wrong.”"*)

### Węzeł `[445]`
Mówca: **Petr Vectern**
> "“I think so, yes. Lucian knows more than me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Lucian Galade: "“Up to 70 percent goes to Sordland. This used to be highe..."*)

### Węzeł `[446]`
Mówca: **Iosef Lancea**
> "“This is why I like to stay out of politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Deivid Wisci: "“I played little to no part in the last period except for..."*)

### Węzeł `[447]`
Mówca: **Lucian Galade**
> "“We reached a successful result and won over the country. The rest is history; it happened. I’m focused on the history we are writing now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Iosef Lancea: "“This is why I like to stay out of politics.”"*)

### Węzeł `[448]`
Mówca: **Deivid Wisci**
> "“I played little to no part in the last period except for campaigning and helping Anton get the votes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "Lucian pulled out a pen and took a few notes."*)

### Węzeł `[449]`
Mówca: **Petr Vectern**
> "“It wasn’t my preferred method, Anton, but it worked. I have to say all the bribing, persuading and promise-making we did was exhausting, not to mention expensive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Lucian Galade: "“We reached a successful result and won over the country...."*)

### Węzeł `[450]`
Mówca: **Iosef Lancea**
> "“The Sordish Council of Radio and Television should prevent disrespectful language, especially towards our elected leaders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Deivid Wisci: "“It’s good to have a free and democratic debate in front ..."*)

### Węzeł `[451]`
Mówca: **Lucian Galade**
> "“Any good politician wouldn't let that stop them from making a beneficial deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Iosef Lancea: "“The Sordish Council of Radio and Television should preve..."*)

### Węzeł `[452]`
Mówca: **Deivid Wisci**
> "“It’s good to have a free and democratic debate in front of the eyes of the people. Even though television ownership still isn't the majority, plenty of radio listeners tuned in.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "Lucian pulled out a pen and took a few notes."*)

### Węzeł `[453]`
Mówca: **Petr Vectern**
> "“Any political opponent would have done what we did. There was too much chaos after '51, and everything weakened Alphonso.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Lucian Galade: "“Any good politician wouldn't let that stop them from mak..."*)

### Węzeł `[454]`
Mówca: **Iosef Lancea**
> "“I would still be wary of his and Mr. Manger's intentions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Deivid Wisci: "“Diplomacy is the way, 99 percent of the time.”"*)

### Węzeł `[455]`
Mówca: **Lucian Galade**
> "“I wouldn't be surprised if Alphonso would be willing to concede more due to this fact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Iosef Lancea: "“I would still be wary of his and Mr. Manger's intentions.”"*)

### Węzeł `[456]`
Mówca: **Deivid Wisci**
> "“Diplomacy is the way, 99 percent of the time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "Lucian pulled out a pen and took a few notes."*)

### Węzeł `[457]`
Mówca: **Petr Vectern**
> "“Yeah, so many people in the party approached me and praised our course of action. They thought the USP was fractured enough and didn't need further tension.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Lucian Galade: "“I wouldn't be surprised if Alphonso would be willing to ..."*)

### Węzeł `[458]`
Mówca: **Iosef Lancea**
> "“I think it would be wise to remember that after the civil war, all the global and regional powers wanted a piece of Sordland. Like sharks in the Antacean Sea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Deivid Wisci: "“Such is the nature of geopolitics. Our national self-int..."*)

### Węzeł `[459]`
Mówca: **Lucian Galade**
> "“I wouldn't say it worked, Petr. Sordland will truly start working under our leadership very soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Iosef Lancea: "“I think it would be wise to remember that after the civi..."*)

### Węzeł `[460]`
Mówca: **Deivid Wisci**
> "“Such is the nature of geopolitics. Our national self-interest should be preserved with as little damage done to human dignity and rights as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Deivid Wisci: "“I try to tread that difficult path to the best of my abi..."*)

### Węzeł `[461]`
Mówca: **Petr Vectern**
> "“I agree with you, Anton, and I'll always support you, but you know my motto. If something works, don't break it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Lucian Galade: "“I wouldn't say it worked, Petr. Sordland will truly star..."*)

### Węzeł `[462]`
Mówca: **Iosef Lancea**
> "“No matter how much people criticize Soll these days, the Colonel is the reason why Sordland can stand mostly independent in this age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Deivid Wisci: "“The energy topic is gaining importance again with the te..."*)

### Węzeł `[463]`
Mówca: **Lucian Galade**
> "“They smelled weakness, and thanks to initiatives of the Soll government, and the technocrats, the nation survived those hardships.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Iosef Lancea: "“No matter how much people criticize Soll these days, the..."*)

### Węzeł `[464]`
Mówca: **Deivid Wisci**
> "“The energy topic is gaining importance again with the tensions in the Antacean Sea. I'm keeping a close watch on the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "Lucian pulled out a pen and took a few notes."*)

### Węzeł `[465]`
Mówca: **Petr Vectern**
> "“We don't want to find ourselves in the energy crisis situation of the early 1930s, where nations like Rumburg and Lespia leeched off our weakened position and charged us triple the cost per cubic ton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Lucian Galade: "“They smelled weakness, and thanks to initiatives of the ..."*)

### Węzeł `[466]`
Mówca: **Narrator**
> "Lucian pulled out a pen and took a few notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Narrator: "Deivid coughed a bit and then continued talking."*)

### Węzeł `[467]`
Mówca: **Deivid Wisci**
> "“From our diplomatic channels, we can tell that Lespia is still very interested in Sordish petrol, whereas Rumburg wants more gas resources.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Iosef Lancea: "“As a sovereign nation, we must protect our resources. Ou..."*)

### Węzeł `[468]`
Mówca: **Deivid Wisci**
> "“I try to tread that difficult path to the best of my ability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "Lucian pulled out a pen and took a few notes."*)

### Węzeł `[469]`
Mówca: **Narrator**
> "Deivid coughed a bit and then continued talking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Deivid Wisci: "“From our diplomatic channels, we can tell that Lespia is..."*)

### Węzeł `[470]`
Mówca: **Narrator**
> "The room went silent and no one stepped forward. It was noticeable how much people respected Wisci. He carried the soul of Sordland as a symbol of the past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Deivid Wisci: "“I think this summarizes all we know and what we stand to..."*)

### Węzeł `[471]`
Mówca: **Deivid Wisci**
> "“Any further comments, esteemed cabinet members?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Narrator: "The room went silent and no one stepped forward. It was n..."*)

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The power structure behind the scenes shouldn't matter much to us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Deivid Wisci: "“We are at a much stronger position to negotiate either w..."*)

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Anytime Rumburg enters the 'play', crap hits the fan.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[391]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Petr Vectern: "“Haha! One way to put it, Mr. President.”"*)

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I doubt he would allow it. It might hurt his hotel businesses around Port Grim.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[370]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Petr Vectern: "“Well, I'd watch the hell out of it.”"*)

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Well, we can continue official dialogue after this. It might lead to a more substantial agreement.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Deivid Wisci: "“Of course, we are pushing to establish a stronger relati..."*)

### Węzeł `[476]`
Mówca: **Deivid Wisci**
> "“Alphonso's Minister of Foreign Affairs, Keres, coordinated the previous trade agreement, but is no longer working at the Ministry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Deivid Wisci: "“We have no close contacts with the Toras royals anymore...."*)

### Węzeł `[477]`
Mówca: **Deivid Wisci**
> "“Of course, we are pushing to establish a stronger relationship. But in the short term, this method is the one that could yield results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "Rizia Trade Offer"*)

### Węzeł `[478]`
Mówca: **Petr Vectern**
> "“Haha! One way to put it, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Narrator: "Petr kept grinning. The rest of the room wasn't feeling it."*)

### Węzeł `[479]`
Mówca: **Narrator**
> "Petr kept grinning. The rest of the room wasn't feeling it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Petr Vectern: "“Dung business.”"*)

### Węzeł `[480]`
Mówca: **Petr Vectern**
> "“Dung business.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Narrator: "Lucian knocked on the table."*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Player: "“You should bring it up next time you see him, see what h..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Player: "“I doubt he would allow it. It might hurt his hotel busin..."*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You should bring it up next time you see him, see what he says.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[370]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Petr Vectern: "“I smell an international hit!”"*)

### Węzeł `[485]`
Mówca: **Petr Vectern**
> "“I smell an international hit!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Narrator: "Lucian knocked on the table."*)

### Węzeł `[486]`
Mówca: **Petr Vectern**
> "“Well, I'd watch the hell out of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Narrator: "Lucian knocked on the table."*)

### Węzeł `[487]`
Mówca: **Petr Vectern**
> "“Speaking of movement, have you seen the latest numbers of refugees from Wehlen?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Iosef Lancea: "“We didn't do a good enough job guarding our borders. Now..."*)

### Węzeł `[488]`
Mówca: **Petr Vectern**
> "“I heard Smolak also makes sense of things with certain substances.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Iosef Lancea: "“Unbefitting a national leader if true.”"*)

### Węzeł `[489]`
Mówca: **Iosef Lancea**
> "“We didn't do a good enough job guarding our borders. Now this is causing significant tension that could lead to further friction down the line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Narrator: "Lucian knocked on the table."*)

### Węzeł `[490]`
Mówca: **Iosef Lancea**
> "“Unbefitting a national leader if true.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Narrator: "Lucian knocked on the table."*)

### Węzeł `[491]`
Mówca: **Narrator**
> "Lucian knocked on the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Lucian Galade: "“We should be more concerned with-”"*)

### Węzeł `[492]`
Mówca: **Lucian Galade**
> "“Moving on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_FPnT_Listened_RiziaDesc = true"*)

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Allowing more market economics to determine the value and output of our energy is aligned with our economic plan.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[344]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Iosef Lancea: "“A potential mistake when our traders use our dependence ..."*)

### Węzeł `[494]`
Mówca: **Iosef Lancea**
> "“A potential mistake when our traders use our dependence on them against us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Deivid Wisci: "“I concur with Mr. Lancea. This is a distinct possibility.”"*)

### Węzeł `[495]`
Mówca: **Deivid Wisci**
> "“I concur with Mr. Lancea. This is a distinct possibility.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Iosef Lancea: "“If Rizia wants to buy more than 20 percent of shares all..."*)

### Węzeł `[496]`
Mówca: **Deivid Wisci**
> "“We are at a much stronger position to negotiate either way. Lucian's information gives us an extra edge in talks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Deivid Wisci: "“Any further comments, esteemed cabinet members?”"*)

### Węzeł `[497]`
Mówca: **Petr Vectern**
> "“They never revealed much about their involvement to me, but I always had the feeling that Alphonso's crew was more linked to Gasom than they seemed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Lucian Galade: "“I have information that the CEO that replaced Alphonso i..."*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Player: "“Keeping close control over critical resources is in sync..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Player: "“Allowing more market economics to determine the value an..."*)

### Węzeł `[501]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Keeping close control over critical resources is in sync with our planned economy strategy.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Kontekst wejściowy (poprzednik):** `[344]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Iosef Lancea: "“I'm very glad you have chosen a Sordland-centric path, M..."*)

### Węzeł `[502]`
Mówca: **Iosef Lancea**
> "“I'm very glad you have chosen a Sordland-centric path, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Deivid Wisci: "“In theory, centralization works. But it leaves little ro..."*)

### Węzeł `[503]`
Mówca: **Deivid Wisci**
> "“In theory, centralization works. But it leaves little room for outside help when internal conditions are dire.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Iosef Lancea: "“If Rizia wants to buy more than 20 percent of shares all..."*)

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You don't need help finding love. You've got Evelyn, right?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Petr Vectern: "“Yeah, sure. She's the greatest.”"*)

### Węzeł `[505]`
Mówca: **Petr Vectern**
> "“Yeah, sure. She's the greatest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Lucian Galade: "“Moving on.”"*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Anrica", "City_Lockdown");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Anrica","City_Lockdown");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_Funeral_DontAttend == true && Ba..."*)

### Węzeł `[507]`
Mówca: **Deivid Wisci**
> "“GRACE has proven more resilient than the international community expected. Rumburg protects the sovereignty of many of these nations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Deivid Wisci: "“Many are not official allies, but have economic pacts to..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAtModeOff();`
- **Efekt skryptowy (`userScript`):** `LookAtModeOff();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "Jump to: [Rizia Trade Offer]"*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_Country_Rizia");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_Country_Rizia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Deivid Wisci: ""The nation south of Lespia is a centralized constitution..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAtModeOff();`
- **Efekt skryptowy (`userScript`):** `LookAtModeOff();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Anrica", "City_Lockdown");"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Bailing out businesses under financial strain", "Presidential Office", "Maroon Palace");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Bailing out businesses under financial strain","Presidential Office","Maroon Palace");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_FPnT_DiplomacyOverview = true"*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Giving stimulus checks to the people in need", "Presidential Office", "Maroon Palace");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Giving stimulus checks to the people in need","Presidential Office","Maroon Palace");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_FPnT_DiplomacyOverview = true"*)

### Węzeł `[514]`
Mówca: **Deivid Wisci**
> "“I am excited to present you the latest bill I am working on. The TCPA has turned out to be an initiative that may significantly boost our tourism and culture industry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Deivid Wisci: "“This untapped value would help us promote our position i..."*)

### Węzeł `[515]`
Mówca: **Deivid Wisci**
> "“This untapped value would help us promote our position internationally. I am convinced it can also help improve our economic condition after discussions with Ministers Holl and Manger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Deivid Wisci: "“The GNA factions are supportive too. I really shouldn't ..."*)

### Węzeł `[516]`
Mówca: **Deivid Wisci**
> "“The GNA factions are supportive too. I really shouldn't have worked overtime hours to get it done, but I really care for the position and value of our cult-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "He started coughing again. This time for longer."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Agnolia", "Progress_DiplomaticMission_Agnolia");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Agnolia","Progress_DiplomaticMission_Agnolia");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_Country_Wehlen", "Progress_Diplo..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_Country_Wehlen", "Progress_DiplomaticMission_Wehlen");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_Country_Wehlen","Progress_DiplomaticMission_Wehlen");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Rumburg", "Hostile");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rumburg","Hostile");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Deivid Wisci: "“As you wish Mr. President. I shall begin work by immedia..."*)
