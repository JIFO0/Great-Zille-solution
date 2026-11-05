# Sordland/Turn03/Ewald Alphonso Debate

- **ID konwersacji:** `43`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/043_Ewald_Alphonso_Debate.md`
- **Liczba węzłów dialogowych:** 424
- **Liczba wyborów gracza:** 101

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[35]** Gus Manger

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople`
- `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Economy_PromoteMarket`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_Diplomatic`
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Promise_Immigration_Relaxed`
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Reformist_Intention`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention`
- `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[41] Sordland/Turn03/EnT_GasomProposal** (../Turn_03/041_EnT_GasomProposal.md), Węzeł `[183]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[18]` | **""Yes, you helped rescue the country from Soll's extreme protectionist and isolatio..."** | `[15]` **Gus Manger**: "“And serve you did. Sordland wou..." | `Variable["BaseGame.Promise_Diplomacy_West"] == true  or  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true` | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[17]` **Ewald Alphonso**: "“The structure was rotting from ..." |
| `[19]` | **""Gasom continues to thrive, doesn't it? Your tenure as president may have come to ..."** | `[15]` **Gus Manger**: "“And serve you did. Sordland wou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Ewald Alphonso**: ""Gasom still operates, yes. 'Thr..." |
| `[41]` | **""I cannot help but empathize with individuals who invest their utmost dedication a..."** | `[15]` **Gus Manger**: "“And serve you did. Sordland wou..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[53]` **Ewald Alphonso**: ""That is much appreciated. I am ..." |
| `[43]` | **"“The fact that a leading privatizer is coming to the state to bail out his corpora..."** | `[374]` **Gus Manger**: ""There is the aforementioned int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Ewald Alphonso**: "“Not the right choice of words. ..." |
| `[44]` | **"“You do know that Rizia can't invest more than 20 percent unless the government pe..."** | `[374]` **Gus Manger**: ""There is the aforementioned int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Ewald Alphonso**: "“Which is precisely why you were..." |
| `[45]` | **"“Gasom is a private corporation. What does Sordland have to do with your business?”"** | `[374]` **Gus Manger**: ""There is the aforementioned int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Ewald Alphonso**: "“We provide gas to half of Sordl..." |
| `[46]` | **"“If your analysis is correct, any investment would also make returns and secure fu..."** | `[374]` **Gus Manger**: ""There is the aforementioned int..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Ewald Alphonso**: ""Indeed. This deal has the poten..." |
| `[50]` | **""It's too early to tell whether the Alphonso era was good for Sordland. It'll be a..."** | `[15]` **Gus Manger**: "“And serve you did. Sordland wou..." | `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  or  Variable["BaseGame.Promise_Diplomacy_East"] == true) == false` | *Brak zmian stanu* | `[56]` **Ewald Alphonso**: ""We're not here to talk about my..." |
| `[51]` | **""The deviation from our planned economic strategy didn't bode well for the nation.""** | `[15]` **Gus Manger**: "“And serve you did. Sordland wou..." | `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  or  Variable["BaseGame.Promise_Diplomacy_East"] == true` | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[55]` **Ewald Alphonso**: ""If Soll had continued, we would..." |
| `[74]` | **"“We don't need another nation to take care of our own energy company. Couldn't we ..."** | `[92]` **Gus Manger**: ""Mr. Alphonso has neglected to m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Ewald Alphonso**: "“I think there is a strong poten..." |
| `[75]` | **""Considering the current state of the government budget, it may not be prudent to ..."** | `[92]` **Gus Manger**: ""Mr. Alphonso has neglected to m..." | `Variable["BaseGame.GovernmentBudget"] <= 2` | *Brak zmian stanu* | `[76]` **Ewald Alphonso**: ""The right economic decisions ca..." |
| `[81]` | **"“Investing together with Rizia could be better than just letting them purchase as ..."** | `[92]` **Gus Manger**: ""Mr. Alphonso has neglected to m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Ewald Alphonso**: "“Co-investing would reduce Sordl..." |
| `[86]` | **"“Don't act so innocent. You and I both know how this game is played.""** | `[48]` **Ewald Alphonso**: "“And now that you're in office, ..."<br>`[101]` **Ewald Alphonso**: "“Did the road to power blind you?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Ewald Alphonso**: "“This isn't a game. If something..." |
| `[87]` | **"“Blind? No, I see the truth all too well.""** | `[101]` **Ewald Alphonso**: "“Did the road to power blind you?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Ewald Alphonso**: "“And that is?”" |
| `[88]` | **"“The nation needs strong leadership after our fall from grace.”"** | `[48]` **Ewald Alphonso**: "“And now that you're in office, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Ewald Alphonso**: "“And you are providing it? Have ..." |
| `[91]` | **"“Why didn't you approach the large international banks in Kyrute or Anraka? They m..."** | `[92]` **Gus Manger**: ""Mr. Alphonso has neglected to m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Ewald Alphonso**: "“Why travel far for what you can..." |
| `[96]` | **""We've got the budget for it. And such a cooperation could be beneficial.""** | `[92]` **Gus Manger**: ""Mr. Alphonso has neglected to m..." | `(Variable["BaseGame.GovernmentBudget"] <= 2) == false` | *Brak zmian stanu* | `[97]` **Ewald Alphonso**: "“Very beneficial. I will be at t..." |
| `[100]` | **"“I did what I had to do. Just like you did to beat Soll in the '46 Congress. Don't..."** | `[49]` **Ewald Alphonso**: "“I always spoke highly of you, i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Ewald Alphonso**: "“I beat that contest fairly. The..." |
| `[107]` | **"“And I appreciate your kind words but I want to iterate that the past is in the pa..."** | `[49]` **Ewald Alphonso**: "“I always spoke highly of you, i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Ewald Alphonso**: "“If we are going to work togethe..." |
| `[108]` | **"“Your term may have come to a rough end. This doesn't mean I don't respect you.”"** | `[49]` **Ewald Alphonso**: "“I always spoke highly of you, i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Ewald Alphonso**: "“As presidents of this republic ..." |
| `[109]` | **"“I worked with you because I believed in your vision. But opinions change, and so ..."** | `[48]` **Ewald Alphonso**: "“And now that you're in office, ..."<br>`[101]` **Ewald Alphonso**: "“Did the road to power blind you?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Ewald Alphonso**: "“We worked well together before,..." |
| `[128]` | **""Optimism is a choice, Ewald. And sometimes, it's a difficult one to make.""** | `[137]` **Ewald Alphonso**: "“I'm an optimist, you know. I ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Ewald Alphonso**: ""A difficult choice, but often t..." |
| `[130]` | **""...you won't get fooled again?""** | `[138]` **Ewald Alphonso**: "“You know what they say. Fool me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Ewald Alphonso**: ""Something like that. My point i..." |
| `[131]` | **""Yes, Ewald, we've seen division. Now it's a question of how we overcome it.""** | `[136]` **Ewald Alphonso**: "“I have been in your shoes. I sa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Ewald Alphonso**: ""That's easier said than done, i..." |
| `[140]` | **"“You need help with Gasom.”"** | `[139]` **Ewald Alphonso**: "“And that is?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Ewald Alphonso**: ""I trust you comprehend Sordland..." |
| `[146]` | **"“We were always meant to work together.”"** | `[139]` **Ewald Alphonso**: "“And that is?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[142]` **Ewald Alphonso**: "“Indeed. I've always considered ..." |
| `[147]` | **"“You are the reason that I am where I am now.”"** | `[139]` **Ewald Alphonso**: "“And that is?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Ewald Alphonso**: "“You should thank the obstructio..." |
| `[153]` | **"“I know there were other factors, Ewald. But you have to admit you played a part i..."** | `[152]` **Gus Manger**: "“Other nations also heavily weig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Gus Manger**: "“Gentleman, I think we are losin..."<br>`[376]` **Ewald Alphonso**: ""I confess I've been following t..." |
| `[154]` | **"“It's easy to blame everyone else for your own faults, isn't it?""** | `[152]` **Gus Manger**: "“Other nations also heavily weig..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[120]` **Gus Manger**: "“Gentleman, I think we are losin..."<br>`[376]` **Ewald Alphonso**: ""I confess I've been following t..." |
| `[162]` | **""Division is a fact of life, Ewald. The challenge is how we navigate it.""** | `[136]` **Ewald Alphonso**: "“I have been in your shoes. I sa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Ewald Alphonso**: ""Indeed, President Rayne. And it..." |
| `[163]` | **""Sometimes countries need to go through social division to change.""** | `[136]` **Ewald Alphonso**: "“I have been in your shoes. I sa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Ewald Alphonso**: ""But how many people will suffer..." |
| `[164]` | **""Optimism, Ewald? That's a luxury I can't afford.""** | `[137]` **Ewald Alphonso**: "“I'm an optimist, you know. I ca..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[157]` **Ewald Alphonso**: ""But without optimism, what do w..." |
| `[165]` | **""I am as optimistic as you are, Ewald. We cannot afford to lose hope.""** | `[137]` **Ewald Alphonso**: "“I'm an optimist, you know. I ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Gus Manger**: ""We can't afford despair either,..." |
| `[166]` | **""I wouldn't come all this way just to fool you, Ewald.""** | `[138]` **Ewald Alphonso**: "“You know what they say. Fool me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Ewald Alphonso**: ""Good. Because you're on my terr..." |
| `[167]` | **""I have a country to lead. Why should I even bother speaking to you?""** | `[138]` **Ewald Alphonso**: "“You know what they say. Fool me..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[238]` **Ewald Alphonso**: ""I'm well aware of the responsib..." |
| `[174]` | **""Let's put the past aside, Ewald. I have a country to run.""** | `[26]` **Ewald Alphonso**: "“I also happen to believe that c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Ewald Alphonso**: ""A sentiment I share, President ..." |
| `[175]` | **""This is indeed a business arrangement, Ewald. Let's focus on that.""** | `[26]` **Ewald Alphonso**: "“I also happen to believe that c..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[177]` **Ewald Alphonso**: ""Of course, President Rayne. Bus..." |
| `[176]` | **""Presidents sticking together? That's an interesting notion.""** | `[26]` **Ewald Alphonso**: "“I also happen to believe that c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Ewald Alphonso**: ""Indeed, it is an interesting no..." |
| `[187]` | **""My greatest concern is for the well-being of Sordland, whether that involves a co..."** | `[184]` **Ewald Alphonso**: ""Now I hear that you are positiv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Ewald Alphonso**: ""Indeed, Mr. President. The welf..." |
| `[188]` | **""Yes, I take it as an encouraging sign that a foreign nation is interested in a So..."** | `[184]` **Ewald Alphonso**: ""Now I hear that you are positiv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Ewald Alphonso**: ""You make a valid point, Preside..." |
| `[189]` | **""I am certainly receptive to the idea, but engaging with international partners li..."** | `[184]` **Ewald Alphonso**: ""Now I hear that you are positiv..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[213]` **Ewald Alphonso**: ""Your caution is well-founded, P..." |
| `[190]` | **""While the prospect of collaborating with a wealthy nation like Rizia is not unapp..."** | `[185]` **Ewald Alphonso**: ""On the other hand, I have not h..."<br>`[406]` **Ewald Alphonso**: ""Meanwhile, I have not heard any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Ewald Alphonso**: ""Your wariness is understandable..." |
| `[191]` | **""I have yet to receive a comprehensive briefing on the matter. I prefer to maintai..."** | `[185]` **Ewald Alphonso**: ""On the other hand, I have not h..."<br>`[406]` **Ewald Alphonso**: ""Meanwhile, I have not heard any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Ewald Alphonso**: ""I respect your prudence, but le..." |
| `[192]` | **""I'd rather not hand over crucial components of our energy industry to foreign ent..."** | `[185]` **Ewald Alphonso**: ""On the other hand, I have not h..."<br>`[406]` **Ewald Alphonso**: ""Meanwhile, I have not heard any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Ewald Alphonso**: ""It's encouraging to hear your c..." |
| `[194]` | **""Look, I am open to make sense out of why I have come all the way here.""** | `[127]` **Ewald Alphonso**: "“And I guess you can empathize a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Ewald Alphonso**: ""Well, isn't that magnanimous of..." |
| `[195]` | **""I understand your perspective, and it is justified to a degree. I want to explore..."** | `[127]` **Ewald Alphonso**: "“And I guess you can empathize a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Ewald Alphonso**: ""Then let's do that. For Sordlan..." |
| `[196]` | **""I do understand your perspective, but I'm not here to care about your problems.""** | `[127]` **Ewald Alphonso**: "“And I guess you can empathize a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Ewald Alphonso**: ""These aren't just my problems. ..." |
| `[197]` | **""For the future of Sordland, it is the best interest of all if Gasom remains in So..."** | `[129]` **Ewald Alphonso**: "“The future of this corporation ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Ewald Alphonso**: ""I can't disagree. But it's not ..." |
| `[198]` | **""We have state energy corporations that can do what you are doing with Gasom. Bett..."** | `[129]` **Ewald Alphonso**: "“The future of this corporation ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Ewald Alphonso**: ""Then by all means, let them try..." |
| `[199]` | **""Gasom plays a crucial role in Sordland's energy independence. It must be controll..."** | `[129]` **Ewald Alphonso**: "“The future of this corporation ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Ewald Alphonso**: ""The state's interest and Gasom'..." |
| `[200]` | **""That just shows how weak our so-called 'democracy' is.""** | `[119]` **Ewald Alphonso**: "“Until '51, that is. Then the So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Ewald Alphonso**: ""Our democracy is not weak. It h..." |
| `[201]` | **""The reforms while bold were conducted way too quick. If they had succeeded any de..."** | `[119]` **Ewald Alphonso**: "“Until '51, that is. Then the So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Ewald Alphonso**: ""You're quick to judge from the ..." |
| `[202]` | **""I've come face to face with the Old Guard myself now. I understand what you were ..."** | `[119]` **Ewald Alphonso**: "“Until '51, that is. Then the So..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Ewald Alphonso**: "“I believe they can be defeated...." |
| `[222]` | **""You're correct, Gus. We need to refocus. Ewald, let's set our differences aside a..."** | `[24]` **Gus Manger**: "“There might have been some disa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Ewald Alphonso**: ""Very well, President Rayne. Our..." |
| `[223]` | **"I don't know. If our visions for Sordland are fundamentally at odds, is there even..."** | `[118]` **Narrator**: "Gus scratched his head."<br>`[24]` **Gus Manger**: "“There might have been some disa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Ewald Alphonso**: ""Your words hint at resignation,..." |
| `[228]` | **""I agree. Our reputation is the mirror of our actions, and our legacy, the shadow ..."** | `[227]` **Gus Manger**: ""Right you are, Ewald. How can a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Ewald Alphonso**: ""I see them as more than just re..." |
| `[229]` | **""An interesting take. But reputation is transient, while legacy is lasting. The la..."** | `[227]` **Gus Manger**: ""Right you are, Ewald. How can a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Ewald Alphonso**: ""I would argue that the transien..." |
| `[230]` | **""A valid point, Mr. Alphonso. But I would argue that integrity and service to the ..."** | `[227]` **Gus Manger**: ""Right you are, Ewald. How can a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Ewald Alphonso**: ""A noble perspective. But isn't ..." |
| `[234]` | **""I believe we've exhausted the possibilities here, Ewald. Our visions for Sordland..."** | `[118]` **Narrator**: "Gus scratched his head."<br>`[24]` **Gus Manger**: "“There might have been some disa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Ewald Alphonso**: ""That's unfortunate, President R..." |
| `[246]` | **""You're right, Ewald. Our country needs both energy independence and economic reco..."** | `[143]` **Ewald Alphonso**: "“Don't you see the mutual benefi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Ewald Alphonso**: ""That's the spirit, President Ra..." |
| `[247]` | **""Our goals may align, Ewald, but that doesn't mean we need each other. Sordland is..."** | `[143]` **Ewald Alphonso**: "“Don't you see the mutual benefi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Ewald Alphonso**: ""True. It's yours. But remember,..." |
| `[248]` | **""I'm not convinced, Ewald. Your past actions make me skeptical of your intentions.""** | `[143]` **Ewald Alphonso**: "“Don't you see the mutual benefi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Ewald Alphonso**: ""I understand your skepticism. B..." |
| `[249]` | **""Your vision for Sordland has its merits, Ewald. However, my administration has it..."** | `[148]` **Ewald Alphonso**: "“Despite our past differences, o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Ewald Alphonso**: ""Yes, every administration has i..." |
| `[250]` | **""Our visions heavily intersect, Ewald. We should try our best to work together.""** | `[148]` **Ewald Alphonso**: "“Despite our past differences, o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Ewald Alphonso**: ""Indeed, President Rayne. I will..." |
| `[251]` | **""Common visions are not always grounds for alliances, Ewald.""** | `[148]` **Ewald Alphonso**: "“Despite our past differences, o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Ewald Alphonso**: ""True, President Rayne. But some..." |
| `[252]` | **""The people's favor is a heavy burden, Ewald. One I intend to bear with honor and ..."** | `[144]` **Ewald Alphonso**: ""Of course, we've had our differ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Ewald Alphonso**: ""Your bitterness casts doubts th..." |
| `[253]` | **""It's not about favor, Ewald. It's about making the right decisions for our country.""** | `[144]` **Ewald Alphonso**: ""Of course, we've had our differ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[262]` **Ewald Alphonso**: ""Indeed, President Rayne. The ri..." |
| `[254]` | **""The people's favor is transient, Ewald. What matters is the legacy we leave behind.""** | `[144]` **Ewald Alphonso**: ""Of course, we've had our differ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Ewald Alphonso**: ""A wise observation, President R..." |
| `[275]` | **""Your past actions show nothing but a ruthless pursuit of profit, at the expense o..."** | `[227]` **Gus Manger**: ""Right you are, Ewald. How can a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Ewald Alphonso**: ""A harsh critique, but not an un..." |
| `[282]` | **""I'm intrigued by the untapped fields. What's the potential return if we invest in..."** | `[311]` **Ewald Alphonso**: ""But that requires us to be will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Gus Manger**: ""With proper investment and deve..." |
| `[283]` | **""Will the investment help keep Gasom from having to downsize its operations?""** | `[311]` **Ewald Alphonso**: ""But that requires us to be will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Ewald Alphonso**: ""That's the question of the hour..." |
| `[284]` | **""That's a risk, Mr. Alphonso. What if the investment doesn't pay off as expected?""** | `[311]` **Ewald Alphonso**: ""But that requires us to be will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Ewald Alphonso**: ""Every investment involves risk...." |
| `[287]` | **""A heartwarming story, Gus. But one successful case doesn't necessarily mean it's ..."** | `[285]` **Gus Manger**: ""It was only when his father fel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Gus Manger**: ""Of course not, Mr. President. B..." |
| `[288]` | **""A truly inspiring story, Gus. This is the kind of innovation and growth we should..."** | `[285]` **Gus Manger**: ""It was only when his father fel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Gus Manger**: ""That's the power of economic fr..." |
| `[289]` | **""Wait a minute, Gus. Is this story about you? Were you the young farmer?""** | `[285]` **Gus Manger**: ""It was only when his father fel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Gus Manger**: ""Ha! Well, I did grow up on a fa..." |
| `[291]` | **""That's a nice story, Gus, but we're not talking about a company here, we're talki..."** | `[290]` **Gus Manger**: "“Years later, those same people ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Gus Manger**: ""You're right, Mr. President."" |
| `[292]` | **""Your experience with OMEC is very valuable for us, Gus. We do need to stay the co..."** | `[290]` **Gus Manger**: "“Years later, those same people ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Gus Manger**: ""It's true, OMEC was a great lea..." |
| `[293]` | **""Change may be met with resistance, Gus, but it's our job to ensure that the peopl..."** | `[290]` **Gus Manger**: "“Years later, those same people ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Gus Manger**: ""I completely agree, Mr. Preside..." |
| `[304]` | **""I don't like bullshit. Just tell me what you want from me.""** | `[232]` **Ewald Alphonso**: ""Your words hint at resignation,..."<br>`[235]` **Ewald Alphonso**: ""That's unfortunate, President R..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[366]` **Ewald Alphonso**: ""One would expect more diplomati..." |
| `[305]` | **""I will at least hear the details of your proposal. But I won't make any promises.""** | `[232]` **Ewald Alphonso**: ""Your words hint at resignation,..."<br>`[235]` **Ewald Alphonso**: ""That's unfortunate, President R..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Gus Manger**: ""It seems we are at a crossroads..." |
| `[306]` | **""An inspiring story, President Alphonso.""** | `[270]` **Ewald Alphonso**: ""That's the essence of opportuni..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[278]` **Gus Manger**: ""It seems we are at a crossroads..." |
| `[307]` | **""You talk about seizing opportunities, yet your rapid privatization nearly crashed..."** | `[270]` **Ewald Alphonso**: ""That's the essence of opportuni..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[278]` **Gus Manger**: ""It seems we are at a crossroads..." |
| `[308]` | **""Your approach might have worked for you, but it's not always as simple as that.""** | `[270]` **Ewald Alphonso**: ""That's the essence of opportuni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Gus Manger**: ""It seems we are at a crossroads..." |
| `[317]` | **""Rusty Montoro, the Toras family, the Rizian government...it seems like an impress..."** | `[316]` **Gus Manger**: ""Back under Alphonso's governmen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Gus Manger**: ""It was quite a feat, and not on..." |
| `[318]` | **""So I've heard, Gus. I understand the need for strategic alliances, but let's reme..."** | `[316]` **Gus Manger**: ""Back under Alphonso's governmen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Gus Manger**: ""Absolutely, we're in this for S..." |
| `[319]` | **""With all due respect, Gus, I'm not thrilled that you got Sordland in bed with a m..."** | `[316]` **Gus Manger**: ""Back under Alphonso's governmen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Gus Manger**: ""I hear your concern, but busine..." |
| `[331]` | **""Don't we all yearn to be remembered and to make a meaningful contribution?""** | `[329]` **Narrator**: "With a cup of coffee in hand, he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "He gazed out for a moment longer..." |
| `[332]` | **""Life's true essence lies in the present moment.""** | `[329]` **Narrator**: "With a cup of coffee in hand, he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "He gazed out for a moment longer..." |
| `[333]` | **""The focus on reputation and legacy is rooted in a capitalist framework that perpe..."** | `[329]` **Narrator**: "With a cup of coffee in hand, he..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[28]` **Narrator**: "He gazed out for a moment longer..." |
| `[336]` | **"Don't comment."** | `[329]` **Narrator**: "With a cup of coffee in hand, he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Narrator**: "After taking a moment to appreci..." |
| `[339]` | **""That makes sense. Foreign investors will bring much-needed capital and expertise.""** | `[37]` **Gus Manger**: "“This is why we have decided to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Gus Manger**: ""Correct, Mr. President."" |
| `[340]` | **""Engaging with foreign investors can be a double-edged sword.""** | `[37]` **Gus Manger**: "“This is why we have decided to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Gus Manger**: ""I appreciate your perspective, ..." |
| `[341]` | **""I have concerns about relying too heavily on foreign investors. It's important to..."** | `[37]` **Gus Manger**: "“This is why we have decided to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Gus Manger**: ""I understand your concerns. But..." |
| `[348]` | **""Foreign investors such as the Kingdom of Rizia, you mean?""** | `[37]` **Gus Manger**: "“This is why we have decided to ..." | `Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true` | *Brak zmian stanu* | `[349]` **Gus Manger**: ""The Kingdom of Rizia certainly ..." |
| `[362]` | **"“I won't let the Old Guard do what they did to you to me. You should have seen thr..."** | `[152]` **Gus Manger**: "“Other nations also heavily weig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Ewald Alphonso**: ""You'll need allies if you want ..." |
| `[364]` | **""I don't like bullshit. Can we get to the choice at hand?""** | `[265]` **Ewald Alphonso**: ""It was all because I seized an ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Ewald Alphonso**: ""Your lack of statesmanship is d..." |
| `[365]` | **"Don't interrupt."** | `[265]` **Ewald Alphonso**: ""It was all because I seized an ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Ewald Alphonso**: ""After acquiring the shares, I w..." |
| `[369]` | **""I've seen enough corporate bailouts and handouts to know that it's always the big..."** | `[311]` **Ewald Alphonso**: ""But that requires us to be will..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[370]` **Ewald Alphonso**: ""Gasom is not just another corpo..." |
| `[419]` | **""I can assist you if you can return the favor by improving the situation in the ci..."** | `[316]` **Gus Manger**: ""Back under Alphonso's governmen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[418]` **Gus Manger**: ""One hand washes the other."" |
| `[421]` | **""I will seize opportunities, but not the ones you might like.""** | `[270]` **Ewald Alphonso**: ""That's the essence of opportuni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Ewald Alphonso**: ""I respect a man that sticks to ..." |
| `[423]` | **""Our image and our perception are a key force that shape our lives. But they can a..."** | `[329]` **Narrator**: "With a cup of coffee in hand, he..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealP...` | `[28]` **Narrator**: "He gazed out for a moment longer..." |

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
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Diplomatic == true && Ba..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Ewald Alphonso: ""As we discuss the future of Sordland, it is paramount th..."*)

### Węzeł `[3]`
Mówca: **Ewald Alphonso**
> ""It's been a while, Mr. Rayne. Let me catch you up on my activities since I left office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Ewald Alphonso: "“I ventured to Xina, immersing myself in its vibrant cult..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Diplomatic == true && Ba..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Diplomatic == true && ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 2"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Diplomatic == true && BaseGame.Prologue_Party_CampaignedForAlphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true  and  Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true || BaseGame.Policy_Economy_PromoteMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true || BaseGame.Polic..."*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_West == true || BaseGame.Pol..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true || BaseGame.Policy_Economy_PromoteMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true  or  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: ""Yes, you helped rescue the country from Soll's extreme p..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_West == true || BaseGame.Policy_Economy_PromoteMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true  or  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[10]`
Mówca: **Ewald Alphonso**
> ""Before we move on, I want to talk about the elephant in the room. The events that preceded the '53 election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_Takeover_Backstab == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_Takeover_Backstab == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Ewald Alphonso: "“President Rayne, I am here because we have a great oppor..."*)

### Węzeł `[14]`
Mówca: **Ewald Alphonso**
> "“President Rayne, I am here because we have a great opportunity on our hands. A business arrangement that will benefit Gasom and Sordland alike.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Ewald Alphonso: "“I also happen to believe that current and former preside..."*)

### Węzeł `[15]`
Mówca: **Gus Manger**
> "“And serve you did. Sordland would be much worse off without you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true || BaseGame.Polic..."*)
  - -> `[41]` (*Player: ""I cannot help but empathize with individuals who invest ..."*)
  - -> `[19]` (*Player: ""Gasom continues to thrive, doesn't it? Your tenure as pr..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true || BaseGame.P..."*)

### Węzeł `[16]`
Mówca: **Ewald Alphonso**
> ""I put so many years of my life into this corporation. And then I left it all behind and devoted myself to serving the people of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gus Manger: "“And serve you did. Sordland would be much worse off with..."*)

### Węzeł `[17]`
Mówca: **Ewald Alphonso**
> "“The structure was rotting from the inside. It needed a shake-up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Ewald Alphonso: "“My Gasom is not nearly as bad off as the Sordish governm..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, you helped rescue the country from Soll's extreme protectionist and isolationist policies.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Promise_Diplomacy_West"] == true  or  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true`
- **Kontekst wejściowy (poprzednik):** `[15]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom continues to thrive, doesn't it? Your tenure as president may have come to an end, but it's not as if you were left with nothing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Ewald Alphonso: ""Gasom still operates, yes. 'Thrives' is perhaps an exagg..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_CampaignedForAlphonso == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Ewald Alphonso: ""I never would have imagined you capable of such a betray..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_CampaignedForAlphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Ewald Alphonso: ""I never would have imagined you capable of such a betray..."*)

### Węzeł `[23]`
Mówca: **Ewald Alphonso**
> ""I never would have imagined you capable of such a betrayal. Especially after you provided such invaluable support during my party leadership contest against Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == t..."*)

### Węzeł `[24]`
Mówca: **Gus Manger**
> "“There might have been some disagreements in the past, but the President has shown strong leadership and good decision-making.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[25]`
Mówca: **Ewald Alphonso**
> ""I never would have imagined you capable of such a betrayal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[26]`
Mówca: **Ewald Alphonso**
> "“I also happen to believe that current and former presidents of Sordland should stick together and share our experiences. Not everyone has been in our shoes, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: ""This is indeed a business arrangement, Ewald. Let's focu..."*)
  - -> `[176]` (*Player: ""Presidents sticking together? That's an interesting noti..."*)
  - -> `[174]` (*Player: ""Let's put the past aside, Ewald. I have a country to run.""*)

### Węzeł `[27]`
Mówca: **Ewald Alphonso**
> ""These two pillars embody the lasting impact we leave behind and the way we are remembered by others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "With a cup of coffee in hand, he strolled over to the win..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "He gazed out for a moment longer as he contemplated what I'd said, then turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Ewald Alphonso: ""I have been thinking about my own legacy and reputation...."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true || BaseGame.Promise_Diplomacy_East == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true || BaseGame.P..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true || BaseGame..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true || BaseGame.Promise_Diplomacy_East == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  or  Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: ""The deviation from our planned economic strategy didn't ..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true || BaseGame.Promise_Diplomacy_East == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  or  Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: ""It's too early to tell whether the Alphonso era was good..."*)

### Węzeł `[32]`
Mówca: **Ewald Alphonso**
> "“My Gasom is not nearly as bad off as the Sordish government was. But a shake-up is needed nonetheless.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gus Manger: "“The latest figures show that Gasom will have to either d..."*)

### Węzeł `[33]`
Mówca: **Gus Manger**
> "“The latest figures show that Gasom will have to either decrease staff and operations by 40 percent in one year or take on a crushing amount of debt.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Gus Manger: "“This is why we have decided to reach out to foreign inve..."*)

### Węzeł `[34]`
Mówca: **Ewald Alphonso**
> "“I appreciate you coming through, Gus. Getting Rizia interested in another investment is a major feat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Ewald Alphonso: "“We've got an amazing opportunity here. The demand for ga..."*)

### Węzeł `[35]`
Mówca: **Ewald Alphonso**
> "“But I'm concerned about the future of what I have built up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gus Manger: "“The latest figures show that Gasom will have to either d..."*)

### Węzeł `[36]`
Mówca: **Ewald Alphonso**
> ""But let's shift our focus to Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gus Manger: "“The latest figures show that Gasom will have to either d..."*)

### Węzeł `[37]`
Mówca: **Gus Manger**
> "“This is why we have decided to reach out to foreign investors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Player: ""That makes sense. Foreign investors will bring much-need..."*)
  - -> `[341]` (*Player: ""I have concerns about relying too heavily on foreign inv..."*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true"*)
  - -> `[340]` (*Player: ""Engaging with foreign investors can be a double-edged sw..."*)

### Węzeł `[38]`
Mówca: **Ewald Alphonso**
> "“We've got an amazing opportunity here. The demand for gas is steadily increasing from both international partners and the Sordish state. All we have to do is ensure a consistent supply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Ewald Alphonso: "“The trouble is that right now, some of our fields are op..."*)

### Węzeł `[39]`
Mówca: **Ewald Alphonso**
> ""I've had some time to think since leaving office. And to me, all of life's complexities can be distilled into two elements. Reputation and legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Ewald Alphonso: ""Our reputation, what we're known for during our time, ca..."*)

### Węzeł `[40]`
Mówca: **Ewald Alphonso**
> "“With the right amount of investment, we can expand resource extraction, effectively fulfill rising demand and ensure long-term stability and profitability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Gus Manger: ""There is the aforementioned interest from Rizia. But the..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I cannot help but empathize with individuals who invest their utmost dedication and passion into their work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[42]`
Mówca: **Ewald Alphonso**
> "“Not the right choice of words. This is not a bailout, but a strategic long-term cooperation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The fact that a leading privatizer is coming to the state to bail out his corporation is hysterical.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Ewald Alphonso: "“Not the right choice of words. This is not a bailout, bu..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You do know that Rizia can't invest more than 20 percent unless the government permits the transaction which can take a long time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Ewald Alphonso: "“Which is precisely why you were invited to be a part of ..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Gasom is a private corporation. What does Sordland have to do with your business?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Ewald Alphonso: "“We provide gas to half of Sordland, Mr. President. We co..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“If your analysis is correct, any investment would also make returns and secure further gas.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Ewald Alphonso: ""Indeed. This deal has the potential to bolster both Gaso..."*)

### Węzeł `[47]`
Mówca: **Ewald Alphonso**
> "“I ventured to Xina, immersing myself in its vibrant culture, then traversed the captivating landscapes of the Anrakan archipelago, and finally reunited with old acquaintances in Kyow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Ewald Alphonso: "“Along the way, I had the privilege of encountering remar..."*)

### Węzeł `[48]`
Mówca: **Ewald Alphonso**
> "“And now that you're in office, you seem to be turning your back on your ideals entirely. Is power getting to you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: "“The nation needs strong leadership after our fall from g..."*)
  - -> `[86]` (*Player: "“Don't act so innocent. You and I both know how this game..."*)
  - -> `[109]` (*Player: "“I worked with you because I believed in your vision. But..."*)

### Węzeł `[49]`
Mówca: **Ewald Alphonso**
> "“I always spoke highly of you, in fact. The youngest MP, a prodigy, I said. Even though I knew we could be rivals one day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: "“I did what I had to do. Just like you did to beat Soll i..."*)
  - -> `[107]` (*Player: "“And I appreciate your kind words but I want to iterate t..."*)
  - -> `[108]` (*Player: "“Your term may have come to a rough end. This doesn't mea..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's too early to tell whether the Alphonso era was good for Sordland. It'll be a subject of debate among future historians.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  or  Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[15]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Ewald Alphonso: ""We're not here to talk about my presidential successes o..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The deviation from our planned economic strategy didn't bode well for the nation.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true  or  Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Kontekst wejściowy (poprzednik):** `[15]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[52]`
Mówca: **Ewald Alphonso**
> ""Gasom still operates, yes. 'Thrives' is perhaps an exaggeration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Ewald Alphonso: ""That's why Mr. Manger and I have been diligently explori..."*)

### Węzeł `[53]`
Mówca: **Ewald Alphonso**
> ""That is much appreciated. I am well aware of the challenges you yourself have faced. I commend you for navigating those obstacles without causing harm to others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Ewald Alphonso: "“But I'm concerned about the future of what I have built ..."*)

### Węzeł `[54]`
Mówca: **Ewald Alphonso**
> ""That's why Mr. Manger and I have been diligently exploring alternative solutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Gus Manger: "“The latest figures show that Gasom will have to either d..."*)

### Węzeł `[55]`
Mówca: **Ewald Alphonso**
> ""If Soll had continued, we would have faced a severe economic downturn as well. The fabric of the country was being torn apart by corruption, greed and autocratic tendencies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Ewald Alphonso: ""But let's shift our focus to Gasom.""*)

### Węzeł `[56]`
Mówca: **Ewald Alphonso**
> ""We're not here to talk about my presidential successes or failures, Mr. Rayne. But I will say this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Ewald Alphonso: ""If Soll had continued, we would have faced a severe econ..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "The sound of sirens briefly distracted us. Through the window, we saw police cars driving down the street adjacent to the Gasom zone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We redirected our attention to the meeting."*)

### Węzeł `[58]`
Mówca: **Ewald Alphonso**
> "“I will remind you that I was never against the complete removal of the Energy Protection Act of 1932.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Ewald Alphonso: "“In fact, I saw eye to eye with Soll about protecting our..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Ewald Alphonso: ""Considering your own recent bailouts of businesses, you'..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Ewald Alphonso: ""I hope you won't stand idly by once again while the coun..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedPeople ==..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Ewald Alphonso: ""Your government has recently provided stimulus payouts t..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedPeople"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[65]`
Mówca: **Ewald Alphonso**
> "“In fact, I saw eye to eye with Soll about protecting our natural resources from foreign interests. But there is a balance in all things.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Gus Manger: "“The reality of Arcasian-style capitalism means that our ..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedPeople == true"*)

### Węzeł `[67]`
Mówca: **Ewald Alphonso**
> ""I hope you won't stand idly by once again while the country is in desperate need of economic support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Gus Manger: "“Mr. President, Gasom is a strategic asset to this nation..."*)

### Węzeł `[68]`
Mówca: **Ewald Alphonso**
> ""Your government has recently provided stimulus payouts to Sordish citizens, so you understand the necessity of such investments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Gus Manger: "“Mr. President, Gasom is a strategic asset to this nation..."*)

### Węzeł `[69]`
Mówca: **Ewald Alphonso**
> "“Which is precisely why you were invited to be a part of this discussion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Ewald Alphonso: "“I will remind you that I was never against the complete ..."*)

### Węzeł `[70]`
Mówca: **Ewald Alphonso**
> ""Considering your own recent bailouts of businesses, you're hardly in a position to judge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Gus Manger: "“Mr. President, Gasom is a strategic asset to this nation..."*)

### Węzeł `[71]`
Mówca: **Ewald Alphonso**
> "“We provide gas to half of Sordland, Mr. President. We could earn even more by selling gas abroad, but we value national advantage.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Ewald Alphonso: ""To be honest, I prefer engaging with you and the Sordish..."*)

### Węzeł `[72]`
Mówca: **Ewald Alphonso**
> ""Why settle for being in the top 10 energy exporters when we have the potential to compete with Arcasia and United Contana?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Gus Manger: ""Mr. Alphonso has neglected to mention that this is not a..."*)

### Węzeł `[73]`
Mówca: **Gus Manger**
> "“Mr. President, Gasom is a strategic asset to this nation regardless of its ownership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Gus Manger: ""Mr. Alphonso has neglected to mention that this is not a..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We don't need another nation to take care of our own energy company. Couldn't we keep this between Sordland and Gasom?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Ewald Alphonso: "“I think there is a strong potential for a deep partnersh..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Considering the current state of the government budget, it may not be prudent to allocate additional funds.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.GovernmentBudget"] <= 2`
- **Kontekst wejściowy (poprzednik):** `[92]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Ewald Alphonso: ""The right economic decisions can increase those funds. G..."*)

### Węzeł `[76]`
Mówca: **Ewald Alphonso**
> ""The right economic decisions can increase those funds. Gasom is poised for significant growth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Gus Manger: "“It might seem risky. But if we lose this opportunity, we..."*)

### Węzeł `[77]`
Mówca: **Ewald Alphonso**
> ""To be honest, I prefer engaging with you and the Sordish government over foreign powers who prioritize their own interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Gus Manger: "“The reality of Arcasian-style capitalism means that our ..."*)

### Węzeł `[78]`
Mówca: **Ewald Alphonso**
> ""Indeed. This deal has the potential to bolster both Gasom and Sordland. Together, we can create a historic opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Ewald Alphonso: ""Why settle for being in the top 10 energy exporters when..."*)

### Węzeł `[79]`
Mówca: **Gus Manger**
> "“The reality of Arcasian-style capitalism means that our national interests should absolutely be part of the discussion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Gus Manger: ""Mr. Alphonso has neglected to mention that this is not a..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Ewald Alphonso: ""Before we move on, I want to talk about the elephant in ..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Investing together with Rizia could be better than just letting them purchase as much as they can.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Ewald Alphonso: "“Co-investing would reduce Sordland's contribution while ..."*)

### Węzeł `[82]`
Mówca: **Gus Manger**
> "“It might seem risky. But if we lose this opportunity, we might never have the chance again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The sound of sirens briefly distracted us. Through the wi..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Ewald Alphonso: ""Now I hear that you are positive about the Kingdom of Ri..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Ewald Alphonso: ""On the other hand, I have not heard any indication of yo..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Don't act so innocent. You and I both know how this game is played.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Ewald Alphonso), `[101]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Ewald Alphonso: "“This isn't a game. If something fruitful is to come out ..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Blind? No, I see the truth all too well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Ewald Alphonso: "“And that is?”"*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“The nation needs strong leadership after our fall from grace.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Ewald Alphonso: "“And you are providing it? Have you looked outside the pa..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Ewald Alphonso: "“The structure was rotting from the inside. It needed a s..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Ewald Alphonso: ""That is much appreciated. I am well aware of the challen..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Why didn't you approach the large international banks in Kyrute or Anraka? They might be eager.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Ewald Alphonso: "“Why travel far for what you can achieve at home, or with..."*)

### Węzeł `[92]`
Mówca: **Gus Manger**
> ""Mr. Alphonso has neglected to mention that this is not an either/or proposition. Sordland can invest alongside Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= 2"*)
  - -> `[91]` (*Player: "“Why didn't you approach the large international banks in..."*)
  - -> `[81]` (*Player: "“Investing together with Rizia could be better than just ..."*)
  - -> `[74]` (*Player: "“We don't need another nation to take care of our own ene..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget <= 2"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget <= 2)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget <= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] <= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player: ""Considering the current state of the government budget, ..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget <= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] <= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: ""We've got the budget for it. And such a cooperation coul..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We've got the budget for it. And such a cooperation could be beneficial.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.GovernmentBudget"] <= 2) == false`
- **Kontekst wejściowy (poprzednik):** `[92]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Ewald Alphonso: "“Very beneficial. I will be at the helm to ensure these f..."*)

### Węzeł `[97]`
Mówca: **Ewald Alphonso**
> "“Very beneficial. I will be at the helm to ensure these funds bring sustainable growth and good returns.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Gus Manger: "“Ewald won't be alone. We have a talented financial team.”"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Ewald Alphonso: "“I always spoke highly of you, in fact. The youngest MP, ..."*)

### Węzeł `[99]`
Mówca: **Gus Manger**
> "“Ewald won't be alone. We have a talented financial team.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The sound of sirens briefly distracted us. Through the wi..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I did what I had to do. Just like you did to beat Soll in the '46 Congress. Don't act like we are different.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Ewald Alphonso: "“I beat that contest fairly. The era of Soll was ending. ..."*)

### Węzeł `[101]`
Mówca: **Ewald Alphonso**
> "“Did the road to power blind you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: "“Don't act so innocent. You and I both know how this game..."*)
  - -> `[109]` (*Player: "“I worked with you because I believed in your vision. But..."*)
  - -> `[87]` (*Player: "“Blind? No, I see the truth all too well.""*)

### Węzeł `[102]`
Mówca: **Ewald Alphonso**
> "“If we are going to work together, we'd better figure out if we are on the same page.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Ewald Alphonso: "“The future of this corporation matters as much to me as ..."*)

### Węzeł `[103]`
Mówca: **Ewald Alphonso**
> "“As presidents of this republic there is more that binds us than that separates us. I want to establish a good partnership.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Ewald Alphonso: "“And I guess you can empathize as to where my lack of opt..."*)

### Węzeł `[104]`
Mówca: **Ewald Alphonso**
> "“And you are providing it? Have you looked outside the palace windows?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Ewald Alphonso: "“I have been in your shoes. I saw the country descend int..."*)

### Węzeł `[105]`
Mówca: **Ewald Alphonso**
> "“This isn't a game. If something fruitful is to come out of our talk today, we need to establish trust.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Ewald Alphonso: "“I'm an optimist, you know. I came here today despite eve..."*)

### Węzeł `[106]`
Mówca: **Ewald Alphonso**
> "“We worked well together before, and we can again. But our intentions must be genuine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Ewald Alphonso: "“You know what they say. Fool me once...”"*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“And I appreciate your kind words but I want to iterate that the past is in the past. No reason to be petty.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Ewald Alphonso: "“If we are going to work together, we'd better figure out..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Your term may have come to a rough end. This doesn't mean I don't respect you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Ewald Alphonso: "“As presidents of this republic there is more that binds ..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I worked with you because I believed in your vision. But opinions change, and so do allegiances.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Ewald Alphonso), `[101]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Ewald Alphonso: "“We worked well together before, and we can again. But ou..."*)

### Węzeł `[110]`
Mówca: **Ewald Alphonso**
> "“I think there is a strong potential for a deep partnership. The government strengthens the security of gas and the company can compete and grow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Ewald Alphonso: "“It would be more costly from the government perspective,..."*)

### Węzeł `[111]`
Mówca: **Gus Manger**
> "“And after we draw other investors, the state can always sell shares for a higher price and make a return.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The sound of sirens briefly distracted us. Through the wi..."*)

### Węzeł `[112]`
Mówca: **Ewald Alphonso**
> "“It would be more costly from the government perspective, but a worthwhile endeavor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Gus Manger: "“And after we draw other investors, the state can always ..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Ewald Alphonso: ""We should strive to build a reputation that speaks to ou..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Ewald Alphonso: ""It's been a while, Mr. Rayne. Let me catch you up on my ..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false && (BaseGame.Policy_Economy_PromoteMarket == true || BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Promise_Diplomacy_West == true || BaseGame.Promise_Immigration_Relaxed == true || BaseGame.Reform_Reformist_Intention == true || BaseGame.Reform_Reformist_Path == true ||
BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend =..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false && (BaseGame.Policy_Economy_PromoteMarket == true || BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Promise_Diplomacy_West == true || BaseGame.Promise_Immigration_Relaxed == true || BaseGame.Reform_Reformist_Intention == true || BaseGame.Reform_Reformist_Path == true ||
BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == false  and  (Variable["BaseGame.Policy_Economy_PromoteMarket"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Promise_Diplomacy_West"] == true  or  Variable["BaseGame.Promise_Immigration_Relaxed"] == true  or  Variable["BaseGame.Reform_Reformist_Intention"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true  or 
Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Gus Manger: "“There might have been some disagreements in the past, bu..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == false && (BaseGame.Policy_Economy_PromoteMarket == true || BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Promise_Diplomacy_West == true || BaseGame.Promise_Immigration_Relaxed == true || BaseGame.Reform_Reformist_Intention == true || BaseGame.Reform_Reformist_Path == true ||
BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_PersonalInvestment_DontSpend"] == false  and  (Variable["BaseGame.Policy_Economy_PromoteMarket"] == true  or  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Promise_Diplomacy_West"] == true  or  Variable["BaseGame.Promise_Immigration_Relaxed"] == true  or  Variable["BaseGame.Reform_Reformist_Intention"] == true  or  Variable["BaseGame.Reform_Reformist_Path"] == true  or 
Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "Gus scratched his head."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "Gus scratched his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player: ""I believe we've exhausted the possibilities here, Ewald...."*)
  - -> `[223]` (*Player: "I don't know. If our visions for Sordland are fundamental..."*)

### Węzeł `[119]`
Mówca: **Ewald Alphonso**
> "“Until '51, that is. Then the Sollist deep state began their damaging acts against our democracy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player: ""I've come face to face with the Old Guard myself now. I ..."*)
  - -> `[200]` (*Player: ""That just shows how weak our so-called 'democracy' is.""*)
  - -> `[201]` (*Player: ""The reforms while bold were conducted way too quick. If ..."*)

### Węzeł `[120]`
Mówca: **Gus Manger**
> "“Gentleman, I think we are losing sight of our goal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_PersonalInvestment_DontSpend == ..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player: ""You're correct, Gus. We need to refocus. Ewald, let's se..."*)
  - -> `[234]` (*Player: ""I believe we've exhausted the possibilities here, Ewald...."*)
  - -> `[223]` (*Player: "I don't know. If our visions for Sordland are fundamental..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true || BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == t..."*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors ==..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true || BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true  or  Variable["BaseGame.Reform_Autocrat_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Ewald Alphonso: "“And now that you're in office, you seem to be turning yo..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_StatusReaction_WarnTraitors == true || BaseGame.Reform_Autocrat_Intention == true || BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_StatusReaction_WarnTraitors"] == true  or  Variable["BaseGame.Reform_Autocrat_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Ewald Alphonso: "“Did the road to power blind you?”"*)

### Węzeł `[125]`
Mówca: **Ewald Alphonso**
> "“I beat that contest fairly. The era of Soll was ending. All I provided was a future vision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Ewald Alphonso: "“And Tarquin Soll didn't obstruct me initially. He actual..."*)

### Węzeł `[126]`
Mówca: **Ewald Alphonso**
> "“And Tarquin Soll didn't obstruct me initially. He actually respected the will of the party and gave me free reign.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Ewald Alphonso: "“Until '51, that is. Then the Sollist deep state began th..."*)

### Węzeł `[127]`
Mówca: **Ewald Alphonso**
> "“And I guess you can empathize as to where my lack of optimism comes from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: ""I do understand your perspective, but I'm not here to ca..."*)
  - -> `[194]` (*Player: ""Look, I am open to make sense out of why I have come all..."*)
  - -> `[195]` (*Player: ""I understand your perspective, and it is justified to a ..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Optimism is a choice, Ewald. And sometimes, it's a difficult one to make.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Ewald Alphonso: ""A difficult choice, but often the only one that can prop..."*)

### Węzeł `[129]`
Mówca: **Ewald Alphonso**
> "“The future of this corporation matters as much to me as it does to the nation of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: ""Gasom plays a crucial role in Sordland's energy independ..."*)
  - -> `[197]` (*Player: ""For the future of Sordland, it is the best interest of a..."*)
  - -> `[198]` (*Player: ""We have state energy corporations that can do what you a..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""...you won't get fooled again?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Ewald Alphonso: ""Something like that. My point is, it would be unwise to ..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, Ewald, we've seen division. Now it's a question of how we overcome it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Ewald Alphonso: ""That's easier said than done, isn't it?""*)

### Węzeł `[132]`
Mówca: **Ewald Alphonso**
> "“Why travel far for what you can achieve at home, or with our good friends in Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Gus Manger: "“Some international banks are interested, but they would ..."*)

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“Some international banks are interested, but they would rather buy the entirety of Gasom. Which is not possible, at least for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The sound of sirens briefly distracted us. Through the wi..."*)

### Węzeł `[134]`
Mówca: **Ewald Alphonso**
> "“Co-investing would reduce Sordland's contribution while allowing the nation to still have a stake for strategic purposes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Gus Manger: "“If the treasury situation is a concern, this path could ..."*)

### Węzeł `[135]`
Mówca: **Gus Manger**
> "“If the treasury situation is a concern, this path could be the most optimal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The sound of sirens briefly distracted us. Through the wi..."*)

### Węzeł `[136]`
Mówca: **Ewald Alphonso**
> "“I have been in your shoes. I saw the country descend into infighting, first in the Maroon Palace and then on the street.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""Yes, Ewald, we've seen division. Now it's a question of ..."*)
  - -> `[162]` (*Player: ""Division is a fact of life, Ewald. The challenge is how ..."*)
  - -> `[163]` (*Player: ""Sometimes countries need to go through social division t..."*)

### Węzeł `[137]`
Mówca: **Ewald Alphonso**
> "“I'm an optimist, you know. I came here today despite everything because I believe we can still find common ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: ""Optimism is a choice, Ewald. And sometimes, it's a diffi..."*)
  - -> `[164]` (*Player: ""Optimism, Ewald? That's a luxury I can't afford.""*)
  - -> `[165]` (*Player: ""I am as optimistic as you are, Ewald. We cannot afford t..."*)

### Węzeł `[138]`
Mówca: **Ewald Alphonso**
> "“You know what they say. Fool me once...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: ""...you won't get fooled again?""*)
  - -> `[166]` (*Player: ""I wouldn't come all this way just to fool you, Ewald.""*)
  - -> `[167]` (*Player: ""I have a country to lead. Why should I even bother speak..."*)

### Węzeł `[139]`
Mówca: **Ewald Alphonso**
> "“And that is?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: "“You need help with Gasom.”"*)
  - -> `[146]` (*Player: "“We were always meant to work together.”"*)
  - -> `[147]` (*Player: "“You are the reason that I am where I am now.”"*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You need help with Gasom.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Ewald Alphonso: ""I trust you comprehend Sordland's need for energy indepe..."*)

### Węzeł `[141]`
Mówca: **Ewald Alphonso**
> ""I trust you comprehend Sordland's need for energy independence, President Rayne, especially as we labor to recover from the recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Ewald Alphonso: "“Don't you see the mutual benefit in our collaboration?”"*)

### Węzeł `[142]`
Mówca: **Ewald Alphonso**
> "“Indeed. I've always considered you a strategic ally, President Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true || Bas..."*)

### Węzeł `[143]`
Mówca: **Ewald Alphonso**
> "“Don't you see the mutual benefit in our collaboration?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: ""You're right, Ewald. Our country needs both energy indep..."*)
  - -> `[247]` (*Player: ""Our goals may align, Ewald, but that doesn't mean we nee..."*)
  - -> `[248]` (*Player: ""I'm not convinced, Ewald. Your past actions make me skep..."*)

### Węzeł `[144]`
Mówca: **Ewald Alphonso**
> ""Of course, we've had our differences. But the people have chosen you. The nation's future is in your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Player: ""The people's favor is a heavy burden, Ewald. One I inten..."*)
  - -> `[253]` (*Player: ""It's not about favor, Ewald. It's about making the right..."*)
  - -> `[254]` (*Player: ""The people's favor is transient, Ewald. What matters is ..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Ewald Alphonso: "“Indeed. I've always considered you a strategic ally, Pre..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“We were always meant to work together.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“You are the reason that I am where I am now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Ewald Alphonso: "“You should thank the obstructionists of the Old Guard an..."*)

### Węzeł `[148]`
Mówca: **Ewald Alphonso**
> "“Despite our past differences, our visions for Sordland still intersect.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player: ""Your vision for Sordland has its merits, Ewald. However,..."*)
  - -> `[250]` (*Player: ""Our visions heavily intersect, Ewald. We should try our ..."*)
  - -> `[251]` (*Player: ""Common visions are not always grounds for alliances, Ewa..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true || BaseGame.Policy_Economy_PromoteMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true || Bas..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Speech_Democracy_Liberal == true || B..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true || BaseGame.Policy_Economy_PromoteMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true  or  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Ewald Alphonso: "“Despite our past differences, our visions for Sordland s..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Speech_Democracy_Liberal == true || BaseGame.Policy_Economy_PromoteMarket == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true  or  Variable["BaseGame.Policy_Economy_PromoteMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Ewald Alphonso: ""Of course, we've had our differences. But the people hav..."*)

### Węzeł `[152]`
Mówca: **Gus Manger**
> "“Other nations also heavily weighed against Sordland in that period.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player: "“It's easy to blame everyone else for your own faults, is..."*)
  - -> `[153]` (*Player: "“I know there were other factors, Ewald. But you have to ..."*)
  - -> `[362]` (*Player: "“I won't let the Old Guard do what they did to you to me...."*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I know there were other factors, Ewald. But you have to admit you played a part in your own downfall.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1"*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“It's easy to blame everyone else for your own faults, isn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[155]`
Mówca: **Ewald Alphonso**
> "“You should thank the obstructionists of the Old Guard and their disagreements with Soll for that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Gus Manger: "“Other nations also heavily weighed against Sordland in t..."*)

### Węzeł `[156]`
Mówca: **Ewald Alphonso**
> ""That's easier said than done, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Gus Manger: ""It's a tough road, sure. But we can't just roll over. So..."*)

### Węzeł `[157]`
Mówca: **Ewald Alphonso**
> ""But without optimism, what do we have? Despair? That's no way to lead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Gus Manger: ""We can't afford despair either, can we? Let's keep our h..."*)

### Węzeł `[158]`
Mówca: **Ewald Alphonso**
> ""Something like that. My point is, it would be unwise to attempt another double-cross.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Gus Manger: ""Let's not let old grudges cloud our judgment, gentlemen.""*)

### Węzeł `[159]`
Mówca: **Gus Manger**
> ""It's a tough road, sure. But we can't just roll over. Sordland needs us, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Alphonso took a sip of coffee before continuing."*)

### Węzeł `[160]`
Mówca: **Gus Manger**
> ""We can't afford despair either, can we? Let's keep our heads up and our eyes forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Alphonso took a sip of coffee before continuing."*)

### Węzeł `[161]`
Mówca: **Gus Manger**
> ""Let's not let old grudges cloud our judgment, gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Alphonso took a sip of coffee before continuing."*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Division is a fact of life, Ewald. The challenge is how we navigate it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Ewald Alphonso: ""Indeed, President Rayne. And it seems our methods of nav..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sometimes countries need to go through social division to change.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Ewald Alphonso: ""But how many people will suffer because of that division?""*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Optimism, Ewald? That's a luxury I can't afford.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am as optimistic as you are, Ewald. We cannot afford to lose hope.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Gus Manger: ""We can't afford despair either, can we? Let's keep our h..."*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wouldn't come all this way just to fool you, Ewald.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Ewald Alphonso: ""Good. Because you're on my territory right now, and anot..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have a country to lead. Why should I even bother speaking to you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[168]`
Mówca: **Ewald Alphonso**
> ""A difficult choice, but often the only one that can propel us forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Alphonso took a sip of coffee before continuing."*)

### Węzeł `[169]`
Mówca: **Ewald Alphonso**
> ""Indeed, President Rayne. And it seems our methods of navigation might differ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Gus Manger: ""It's a tough road, sure. But we can't just roll over. So..."*)

### Węzeł `[170]`
Mówca: **Ewald Alphonso**
> ""But how many people will suffer because of that division?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Gus Manger: ""It's a tough road, sure. But we can't just roll over. So..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] <= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Gus Manger: "“Gentleman, I think we are losing sight of our goal.”"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] <= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Ewald Alphonso: ""I confess I've been following the news from the Maroon P..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's put the past aside, Ewald. I have a country to run.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Ewald Alphonso: ""A sentiment I share, President Rayne. The welfare of Sor..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is indeed a business arrangement, Ewald. Let's focus on that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Presidents sticking together? That's an interesting notion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Ewald Alphonso: ""Indeed, it is an interesting notion, President Rayne. It..."*)

### Węzeł `[177]`
Mówca: **Ewald Alphonso**
> ""Of course, President Rayne. Business, above all, should drive this discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Gus Manger: ""Exactly, gentlemen! Let's get down to brass tacks, eh?""*)

### Węzeł `[178]`
Mówca: **Ewald Alphonso**
> ""Indeed, it is an interesting notion, President Rayne. It's a shame that politics often stand in the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Gus Manger: ""Could do with a bit more of that, couldn't we? Former pr..."*)

### Węzeł `[179]`
Mówca: **Ewald Alphonso**
> ""A sentiment I share, President Rayne. The welfare of Sordland must always be our top priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Gus Manger: ""That's the spirit, gentlemen! Sordland is above most els..."*)

### Węzeł `[180]`
Mówca: **Gus Manger**
> ""Exactly, gentlemen! Let's get down to brass tacks, eh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Ewald Alphonso: ""As we discuss the future of Sordland, it is paramount th..."*)

### Węzeł `[181]`
Mówca: **Gus Manger**
> ""Could do with a bit more of that, couldn't we? Former presidents, current presidents, all pulling together for Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Ewald Alphonso: ""As we discuss the future of Sordland, it is paramount th..."*)

### Węzeł `[182]`
Mówca: **Gus Manger**
> ""That's the spirit, gentlemen! Sordland is above most else, am I right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Ewald Alphonso: ""As we discuss the future of Sordland, it is paramount th..."*)

### Węzeł `[183]`
Mówca: **Ewald Alphonso**
> ""As we discuss the future of Sordland, it is paramount that I comprehend your vision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Ewald Alphonso: ""The trajectory you set for this country will inevitably ..."*)

### Węzeł `[184]`
Mówca: **Ewald Alphonso**
> ""Now I hear that you are positive about the Kingdom of Rizia investing in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[185]`
Mówca: **Ewald Alphonso**
> ""On the other hand, I have not heard any indication of your leanings regarding the Kingdom of Rizia's interest in investing in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player: ""I have yet to receive a comprehensive briefing on the ma..."*)
  - -> `[192]` (*Player: ""I'd rather not hand over crucial components of our energ..."*)
  - -> `[190]` (*Player: ""While the prospect of collaborating with a wealthy natio..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: ""Yes, I take it as an encouraging sign that a foreign nat..."*)
  - -> `[189]` (*Player: ""I am certainly receptive to the idea, but engaging with ..."*)
  - -> `[187]` (*Player: ""My greatest concern is for the well-being of Sordland, w..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My greatest concern is for the well-being of Sordland, whether that involves a collaboration with Rizia or not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Ewald Alphonso: ""Indeed, Mr. President. The welfare and progress of Sordl..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, I take it as an encouraging sign that a foreign nation is interested in a Sordish corporation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Ewald Alphonso: ""You make a valid point, President Rayne. The interest of..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am certainly receptive to the idea, but engaging with international partners like monarchies brings its own set of bad repercussions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""While the prospect of collaborating with a wealthy nation like Rizia is not unappealing, I am suspicious of their underlying intentions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Ewald Alphonso), `[406]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Ewald Alphonso: ""Your wariness is understandable, President Rayne. The mo..."*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have yet to receive a comprehensive briefing on the matter. I prefer to maintain a careful approach, and not make premature commitments.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Ewald Alphonso), `[406]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Ewald Alphonso: ""I respect your prudence, but let us not forget that fort..."*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'd rather not hand over crucial components of our energy industry to foreign entities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Ewald Alphonso), `[406]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Ewald Alphonso: ""It's encouraging to hear your concern for Sordland's key..."*)

### Węzeł `[193]`
Mówca: **Ewald Alphonso**
> ""The trajectory you set for this country will inevitably impact not just Gasom, but also Sordland's position on the global stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Ewald Alphonso: ""I confess I've been following the news from the Maroon P..."*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Look, I am open to make sense out of why I have come all the way here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Ewald Alphonso: ""Well, isn't that magnanimous of you. It's not about maki..."*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your perspective, and it is justified to a degree. I want to explore an earnest way out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Ewald Alphonso: ""Then let's do that. For Sordland's sake, we need to find..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I do understand your perspective, but I'm not here to care about your problems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Ewald Alphonso: ""These aren't just my problems. They're Sordland's proble..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""For the future of Sordland, it is the best interest of all if Gasom remains in Sordish hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Ewald Alphonso: ""I can't disagree. But it's not about who owns Gasom, it'..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have state energy corporations that can do what you are doing with Gasom. Better, even.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Ewald Alphonso: ""Then by all means, let them try. Competition is the life..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom plays a crucial role in Sordland's energy independence. It must be controlled.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Ewald Alphonso: ""The state's interest and Gasom's success are not mutuall..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That just shows how weak our so-called 'democracy' is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Ewald Alphonso: ""Our democracy is not weak. It has been tested, but it ha..."*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The reforms while bold were conducted way too quick. If they had succeeded any deep state attempt would have failed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Ewald Alphonso: ""You're quick to judge from the comfort of hindsight. We ..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I've come face to face with the Old Guard myself now. I understand what you were up against.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Ewald Alphonso: "“I believe they can be defeated. But not without allies.”"*)

### Węzeł `[203]`
Mówca: **Ewald Alphonso**
> "“I believe they can be defeated. But not without allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[204]`
Mówca: **Ewald Alphonso**
> ""Our democracy is not weak. It has been tested, but it has also shown resilience. We should not confuse struggle with weakness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[205]`
Mówca: **Ewald Alphonso**
> ""You're quick to judge from the comfort of hindsight. We acted decisively, yes, but that's what was needed at the time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Ewald Alphonso: ""Our pace was not the problem. Resistance to change was.""*)

### Węzeł `[206]`
Mówca: **Ewald Alphonso**
> ""The state's interest and Gasom's success are not mutually exclusive. Our control can be shared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[207]`
Mówca: **Ewald Alphonso**
> ""I can't disagree. But it's not about who owns Gasom, it's about how it's run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[208]`
Mówca: **Ewald Alphonso**
> ""Then by all means, let them try. Competition is the lifeblood of progress. Let the best corporation win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[209]`
Mówca: **Ewald Alphonso**
> ""These aren't just my problems. They're Sordland's problems. And if you're not here to care about them, then why are you here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[210]`
Mówca: **Ewald Alphonso**
> ""Well, isn't that magnanimous of you. It's not about making sense of why you're here. It's about understanding the critical role you play in shaping the future of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[211]`
Mówca: **Ewald Alphonso**
> ""Then let's do that. For Sordland's sake, we need to find common ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[212]`
Mówca: **Ewald Alphonso**
> ""You make a valid point, President Rayne. The interest of foreign investors could indeed be seen as an endorsement of our potential for growth and competitiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Ewald Alphonso: ""However, I would caution that such interest is not a gua..."*)

### Węzeł `[213]`
Mówca: **Ewald Alphonso**
> ""Your caution is well-founded, President Rayne. International partnerships are fraught with complexity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Ewald Alphonso: ""However, I trust that you recognize the potential opport..."*)

### Węzeł `[214]`
Mówca: **Ewald Alphonso**
> ""Indeed, Mr. President. The welfare and progress of Sordland must always be our primary concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Gus Manger: ""You know, gentlemen, this reminds me of a story from whe..."*)

### Węzeł `[215]`
Mówca: **Ewald Alphonso**
> ""I respect your prudence, but let us not forget that fortune often favors the bold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[216]`
Mówca: **Ewald Alphonso**
> ""It's encouraging to hear your concern for Sordland's key industries, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Ewald Alphonso: ""Maintaining control of these sectors is indeed crucial, ..."*)

### Węzeł `[217]`
Mówca: **Ewald Alphonso**
> ""Your wariness is understandable, President Rayne. The motivations of nations like Rizia are not always clear-cut.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Ewald Alphonso: ""Our utmost priority should be to ensure that any partner..."*)

### Węzeł `[218]`
Mówca: **Ewald Alphonso**
> ""However, I would caution that such interest is not a guarantee of our success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Gus Manger: ""You know, gentlemen, this reminds me of a story from whe..."*)

### Węzeł `[219]`
Mówca: **Ewald Alphonso**
> ""However, I trust that you recognize the potential opportunities and benefits they might bring to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Gus Manger: ""You know, gentlemen, this reminds me of a story from whe..."*)

### Węzeł `[220]`
Mówca: **Ewald Alphonso**
> ""Maintaining control of these sectors is indeed crucial, but we must also consider the potential benefits that foreign investment might bring.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[221]`
Mówca: **Ewald Alphonso**
> ""Our utmost priority should be to ensure that any partnership we enter is in the best interest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're correct, Gus. We need to refocus. Ewald, let's set our differences aside and aim for the best possible outcome for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Ewald Alphonso: ""Very well, President Rayne. Our personal differences sho..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "I don't know. If our visions for Sordland are fundamentally at odds, is there even a point to continue this discussion?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator), `[24]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Ewald Alphonso: ""Your words hint at resignation, President Rayne. But I s..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Gus Manger: "“Your concerns, Mr. President, remind me of a time when I..."*)

### Węzeł `[225]`
Mówca: **Ewald Alphonso**
> ""Our reputation, what we're known for during our time, can shape our legacy, what we leave behind. The two are inseparable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Gus Manger: ""Right you are, Ewald. How can a man be judged, if not by..."*)

### Węzeł `[226]`
Mówca: **Ewald Alphonso**
> ""We should strive to build a reputation that speaks to our values and a legacy that demonstrates our impact on Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Ewald Alphonso: ""As chair, my own reputation and legacy are tied with tha..."*)

### Węzeł `[227]`
Mówca: **Gus Manger**
> ""Right you are, Ewald. How can a man be judged, if not by the impact he makes on others and the way he is remembered?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player: ""I agree. Our reputation is the mirror of our actions, an..."*)
  - -> `[229]` (*Player: ""An interesting take. But reputation is transient, while ..."*)
  - -> `[275]` (*Player: ""Your past actions show nothing but a ruthless pursuit of..."*)
  - -> `[230]` (*Player: ""A valid point, Mr. Alphonso. But I would argue that inte..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree. Our reputation is the mirror of our actions, and our legacy, the shadow that remains.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Ewald Alphonso: ""I see them as more than just reflections and shadows. Th..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An interesting take. But reputation is transient, while legacy is lasting. The latter is what truly matters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Ewald Alphonso: ""I would argue that the transient nature of reputation is..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A valid point, Mr. Alphonso. But I would argue that integrity and service to the people should stand above reputation and legacy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Ewald Alphonso: ""A noble perspective. But isn't it through our reputation..."*)

### Węzeł `[231]`
Mówca: **Ewald Alphonso**
> ""Very well, President Rayne. Our personal differences shouldn't overshadow the future of our country and my company.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Gus Manger: ""I'm glad to see you both finding common ground. Let's pr..."*)

### Węzeł `[232]`
Mówca: **Ewald Alphonso**
> ""Your words hint at resignation, President Rayne. But I still believe in the possibility of a consensus, despite our differences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Player: ""I will at least hear the details of your proposal. But I..."*)
  - -> `[304]` (*Player: ""I don't like bullshit. Just tell me what you want from me.""*)

### Węzeł `[233]`
Mówca: **Gus Manger**
> ""I'm glad to see you both finding common ground. Let's proceed with Sordland's interests at heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gus Manger: ""It seems we are at a crossroads with Gasom. The numbers ..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I believe we've exhausted the possibilities here, Ewald. Our visions for Sordland are just too divergent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator), `[24]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Ewald Alphonso: ""That's unfortunate, President Rayne. I was hoping we cou..."*)

### Węzeł `[235]`
Mówca: **Ewald Alphonso**
> ""That's unfortunate, President Rayne. I was hoping we could find some middle ground. But I respect your stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Player: ""I will at least hear the details of your proposal. But I..."*)
  - -> `[304]` (*Player: ""I don't like bullshit. Just tell me what you want from me.""*)

### Węzeł `[236]`
Mówca: **Ewald Alphonso**
> ""Good. Because you're on my territory right now, and another double-cross would be a terrible mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Gus Manger: ""Gentlemen, let's remember that we're here to make a new ..."*)

### Węzeł `[237]`
Mówca: **Gus Manger**
> ""Gentlemen, let's remember that we're here to make a new agreement, not rehash old disagreements.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Alphonso took a sip of coffee before continuing."*)

### Węzeł `[238]`
Mówca: **Ewald Alphonso**
> ""I'm well aware of the responsibilities of leadership, President Rayne. Have you never thought that you could benefit from my experience?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Gus Manger: ""Mr. President, Ewald, let's not lose sight of the fact t..."*)

### Węzeł `[239]`
Mówca: **Gus Manger**
> ""Mr. President, Ewald, let's not lose sight of the fact that we all want what's best for Sordland. We may have different ideas, but our goals are the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Alphonso took a sip of coffee before continuing."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Ewald Alphonso: ""I'm well aware of the responsibilities of leadership, Pr..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Ewald Alphonso: ""But without optimism, what do we have? Despair? That's n..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He took a sip of coffee. His face assumed a contemplative..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right, Ewald. Our country needs both energy independence and economic recovery. Perhaps a collaboration could be beneficial.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Ewald Alphonso: ""That's the spirit, President Rayne. Together, we can acc..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our goals may align, Ewald, but that doesn't mean we need each other. Sordland isn't your responsibility anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Ewald Alphonso: ""True. It's yours. But remember, no man is an island.""*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not convinced, Ewald. Your past actions make me skeptical of your intentions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Ewald Alphonso: ""I understand your skepticism. But we can't let past misu..."*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your vision for Sordland has its merits, Ewald. However, my administration has its own path to tread.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Ewald Alphonso: ""Yes, every administration has its own path. But don't di..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our visions heavily intersect, Ewald. We should try our best to work together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Ewald Alphonso: ""Indeed, President Rayne. I will respect your autonomy in..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Common visions are not always grounds for alliances, Ewald.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Ewald Alphonso: ""True, President Rayne. But sometimes, unexpected allianc..."*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The people's favor is a heavy burden, Ewald. One I intend to bear with honor and integrity, unlike you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Ewald Alphonso: ""Your bitterness casts doubts that you will, President Ra..."*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's not about favor, Ewald. It's about making the right decisions for our country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Ewald Alphonso: ""Indeed, President Rayne. The right decisions, however, a..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The people's favor is transient, Ewald. What matters is the legacy we leave behind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Ewald Alphonso: ""A wise observation, President Rayne.""*)

### Węzeł `[255]`
Mówca: **Ewald Alphonso**
> ""That's the spirit, President Rayne. Together, we can accomplish great things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[256]`
Mówca: **Ewald Alphonso**
> ""True. It's yours. But remember, no man is an island.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[257]`
Mówca: **Ewald Alphonso**
> ""I understand your skepticism. But we can't let past misunderstandings get in the way of a fruitful future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He took a sip of coffee. His face assumed a contemplative..."*)

### Węzeł `[258]`
Mówca: **Ewald Alphonso**
> ""Yes, every administration has its own path. But don't disregard the wisdom of those who have trod it before you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He took a sip of coffee. His face assumed a contemplative..."*)

### Węzeł `[259]`
Mówca: **Ewald Alphonso**
> ""Indeed, President Rayne. I will respect your autonomy in decision-making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[260]`
Mówca: **Ewald Alphonso**
> ""True, President Rayne. But sometimes, unexpected alliances can bring about the greatest changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He took a sip of coffee. His face assumed a contemplative..."*)

### Węzeł `[261]`
Mówca: **Ewald Alphonso**
> ""Your bitterness casts doubts that you will, President Rayne. It is not wise to make enemies for no reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[262]`
Mówca: **Ewald Alphonso**
> ""Indeed, President Rayne. The right decisions, however, aren't always the easiest ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He took a sip of coffee. His face assumed a contemplative..."*)

### Węzeł `[263]`
Mówca: **Ewald Alphonso**
> ""A wise observation, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[264]`
Mówca: **Ewald Alphonso**
> ""Have I told you about I became involved with Gasom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Ewald Alphonso: ""It was all because I seized an opportunity. I bought the..."*)

### Węzeł `[265]`
Mówca: **Ewald Alphonso**
> ""It was all because I seized an opportunity. I bought the shares being sold by the Contanan partners and secured a significant stake. This move wasn't just about financial gain or personal ambition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Player_Italic: "Don't interrupt."*)
  - -> `[364]` (*Player: ""I don't like bullshit. Can we get to the choice at hand?""*)

### Węzeł `[266]`
Mówca: **Narrator**
> "We redirected our attention to the meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[267]`
Mówca: **Narrator**
> "Alphonso took a sip of coffee before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Ewald Alphonso: ""Have I told you about I became involved with Gasom?""*)

### Węzeł `[268]`
Mówca: **Ewald Alphonso**
> ""After acquiring the shares, I was elected as CEO. The company expanded, hired world-class engineers from all over the world, turned the small town of Narbel into a thriving city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Ewald Alphonso: ""Despite criticism from the Nature Preservation Foundatio..."*)

### Węzeł `[269]`
Mówca: **Ewald Alphonso**
> ""Despite criticism from the Nature Preservation Foundation, I fulfilled most of the gas needs of Sordland and increased our energy independence, all while aligning with Tarquin Soll's autarky strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Ewald Alphonso: ""That's the essence of opportunity. What matters is that ..."*)

### Węzeł `[270]`
Mówca: **Ewald Alphonso**
> ""That's the essence of opportunity. What matters is that you seize it when it appears. And remember, it's not just about taking that leap, but about what you do once you've landed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Player: ""I will seize opportunities, but not the ones you might l..."*)
  - -> `[306]` (*Player: ""An inspiring story, President Alphonso.""*)
  - -> `[307]` (*Player: ""You talk about seizing opportunities, yet your rapid pri..."*)
  - -> `[308]` (*Player: ""Your approach might have worked for you, but it's not al..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "He took a sip of coffee. His face assumed a contemplative expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Ewald Alphonso: ""I've had some time to think since leaving office. And to..."*)

### Węzeł `[272]`
Mówca: **Ewald Alphonso**
> ""I see them as more than just reflections and shadows. They are the tangible products of our actions, the fruits of our labor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Ewald Alphonso: ""We should strive to build a reputation that speaks to ou..."*)

### Węzeł `[273]`
Mówca: **Ewald Alphonso**
> ""I would argue that the transient nature of reputation is what makes it important. It's the soil in which the seed of legacy grows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Ewald Alphonso: ""We should strive to build a reputation that speaks to ou..."*)

### Węzeł `[274]`
Mówca: **Ewald Alphonso**
> ""A noble perspective. But isn't it through our reputation and legacy that our integrity and service are ultimately judged?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Ewald Alphonso: ""We should strive to build a reputation that speaks to ou..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your past actions show nothing but a ruthless pursuit of profit, at the expense of the people and environment. That's hardly a reputation or a legacy to be proud of.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Ewald Alphonso: ""A harsh critique, but not an unexpected one. I see profi..."*)

### Węzeł `[276]`
Mówca: **Ewald Alphonso**
> ""A harsh critique, but not an unexpected one. I see profit as a means to a greater end. It enables us to drive progress, change lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Ewald Alphonso: ""As for my legacy, it will be for history to judge, not y..."*)

### Węzeł `[277]`
Mówca: **Ewald Alphonso**
> ""As for my legacy, it will be for history to judge, not you or me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[278]`
Mówca: **Gus Manger**
> ""It seems we are at a crossroads with Gasom. The numbers tell a tale of struggle and potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Ewald Alphonso: ""No need to sugarcoat it, Gus. Our corporation is teeteri..."*)

### Węzeł `[279]`
Mówca: **Ewald Alphonso**
> ""No need to sugarcoat it, Gus. Our corporation is teetering on the edge of a cliff. Without significant restructuring, the firm risks plunging into insurmountable debt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Gus Manger: ""My old friend Ewald reached out to me for assistance. Ou..."*)

### Węzeł `[280]`
Mówca: **Gus Manger**
> ""My old friend Ewald reached out to me for assistance. Out of respect for our shared history -- and my small stake in the company -- I couldn't refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Gus Manger: ""I've always believed in the power of networking. I'm sur..."*)

### Węzeł `[281]`
Mówca: **Ewald Alphonso**
> ""Thanks to Gus' Rizian connections, investors from the kingdom are now interested in Gasom, a development that could steer us clear of the looming crisis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Ewald Alphonso: "“We've got an amazing opportunity here. The demand for ga..."*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm intrigued by the untapped fields. What's the potential return if we invest in these new areas?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Gus Manger: ""With proper investment and development, we project extre..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Will the investment help keep Gasom from having to downsize its operations?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Ewald Alphonso: ""That's the question of the hour, Mr. President. It won't..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a risk, Mr. Alphonso. What if the investment doesn't pay off as expected?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Ewald Alphonso: ""Every investment involves risk. But this one is an easy ..."*)

### Węzeł `[285]`
Mówca: **Gus Manger**
> ""It was only when his father fell ill that he took over and transformed the farm. He took risks, made some mistakes, but ultimately, he tripled their output in just a few years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player: ""A heartwarming story, Gus. But one successful case doesn..."*)
  - -> `[288]` (*Player: ""A truly inspiring story, Gus. This is the kind of innova..."*)
  - -> `[289]` (*Player: ""Wait a minute, Gus. Is this story about you? Were you th..."*)

### Węzeł `[286]`
Mówca: **Gus Manger**
> "“Your concerns, Mr. President, remind me of a time when I was working with OMEC. We were bringing in foreign investments to revitalize the local companies. There were protests, people who were scared of change, who thought we were selling out. But we weathered the backlash, stood by our decisions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Gus Manger: "“Years later, those same people saw the benefits, the job..."*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A heartwarming story, Gus. But one successful case doesn't necessarily mean it's the best approach for the whole country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[285]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Gus Manger: ""Of course not, Mr. President. But if we completely turn ..."*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A truly inspiring story, Gus. This is the kind of innovation and growth we should be fostering in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[285]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Gus Manger: ""That's the power of economic freedom. It allows innovati..."*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Wait a minute, Gus. Is this story about you? Were you the young farmer?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[285]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Gus Manger: ""Ha! Well, I did grow up on a farm, but no, that wasn't m..."*)

### Węzeł `[290]`
Mówca: **Gus Manger**
> "“Years later, those same people saw the benefits, the jobs we created, the growth we spurred. Change is always met with resistance, but in the end, it's the results that matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player: ""That's a nice story, Gus, but we're not talking about a ..."*)
  - -> `[292]` (*Player: ""Your experience with OMEC is very valuable for us, Gus. ..."*)
  - -> `[293]` (*Player: ""Change may be met with resistance, Gus, but it's our job..."*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a nice story, Gus, but we're not talking about a company here, we're talking about an entire nation. The stakes are much higher.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Gus Manger: ""You're right, Mr. President.""*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your experience with OMEC is very valuable for us, Gus. We do need to stay the course and see our decisions through.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Gus Manger: ""It's true, OMEC was a great learning experience.""*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Change may be met with resistance, Gus, but it's our job to ensure that the people are with us on this journey. We can't disregard their concerns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Gus Manger: ""I completely agree, Mr. President. The people are our gr..."*)

### Węzeł `[294]`
Mówca: **Gus Manger**
> ""Ha! Well, I did grow up on a farm, but no, that wasn't me. I was too busy trying to turn apples into a viable fuel source. A failed experiment, but it made some damn good cider!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "As Gus finished his point, we suddenly heard the faint wa..."*)

### Węzeł `[295]`
Mówca: **Gus Manger**
> ""That's the power of economic freedom. It allows innovation, it allows us to adapt and to grow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[296]`
Mówca: **Gus Manger**
> ""Of course not, Mr. President. But if we completely turn our backs on the idea of economic freedom, we're no worse than that farmer's father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "As Gus finished his point, we suddenly heard the faint wa..."*)

### Węzeł `[297]`
Mówca: **Gus Manger**
> ""I completely agree, Mr. President. The people are our greatest asset.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Gus Manger: ""But remember, sometimes, people don't know what's best f..."*)

### Węzeł `[298]`
Mówca: **Gus Manger**
> ""It's true, OMEC was a great learning experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Gus Manger: ""A lot of sleepless nights, tough negotiations, and even ..."*)

### Węzeł `[299]`
Mówca: **Gus Manger**
> ""You're right, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Gus Manger: ""But remember, a nation is also a conglomerate of sorts, ..."*)

### Węzeł `[300]`
Mówca: **Gus Manger**
> ""But remember, sometimes, people don't know what's best for them until they see it. That's why we're here, to help them see a better future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "As Gus finished his point, we suddenly heard the faint wa..."*)

### Węzeł `[301]`
Mówca: **Gus Manger**
> ""A lot of sleepless nights, tough negotiations, and even a few broken friendships... but I'd do it all over again if it means seeing our country prosper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[302]`
Mówca: **Gus Manger**
> ""But remember, a nation is also a conglomerate of sorts, of people, of businesses, of hopes and dreams.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "As Gus finished his point, we suddenly heard the faint wa..."*)

### Węzeł `[303]`
Mówca: **Narrator**
> "As Gus finished his point, we suddenly heard the faint wailing of sirens in the distance. He waited for the noise to fade before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Gus Manger: ""Back to the topic at hand.""*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't like bullshit. Just tell me what you want from me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Ewald Alphonso), `[235]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will at least hear the details of your proposal. But I won't make any promises.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Ewald Alphonso), `[235]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gus Manger: ""It seems we are at a crossroads with Gasom. The numbers ..."*)

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An inspiring story, President Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 2"*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You talk about seizing opportunities, yet your rapid privatization nearly crashed our economy. That's rich, considering your 'leap' resulted in anything but a graceful landing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 2"*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your approach might have worked for you, but it's not always as simple as that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gus Manger: ""It seems we are at a crossroads with Gasom. The numbers ..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gus Manger: ""It seems we are at a crossroads with Gasom. The numbers ..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gus Manger: ""It seems we are at a crossroads with Gasom. The numbers ..."*)

### Węzeł `[311]`
Mówca: **Ewald Alphonso**
> ""But that requires us to be willing to take risks and weather the storm. Now, that's a legacy worth striving for, wouldn't you agree?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: ""I'm intrigued by the untapped fields. What's the potenti..."*)
  - -> `[284]` (*Player: ""That's a risk, Mr. Alphonso. What if the investment does..."*)
  - -> `[283]` (*Player: ""Will the investment help keep Gasom from having to downs..."*)
  - -> `[369]` (*Player: ""I've seen enough corporate bailouts and handouts to know..."*)

### Węzeł `[312]`
Mówca: **Ewald Alphonso**
> ""Every investment involves risk. But this one is an easy bet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Gus Manger: ""With proper investment and development, we project extre..."*)

### Węzeł `[313]`
Mówca: **Ewald Alphonso**
> ""That's the question of the hour, Mr. President. It won't be easy, but with the right moves, we might be able to navigate this storm without losing our crew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Gus Manger: ""We have developed a strategic plan that focuses on diver..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Ewald Alphonso: ""One would expect more diplomatic skill from a president.""*)

### Węzeł `[315]`
Mówca: **Gus Manger**
> ""I've always believed in the power of networking. I'm sure you've heard of Rusty Montoro, Chairman and CEO of Rizian Royal Gold. Rusty and I go way back, and he's done quite well for himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Gus Manger: ""Back under Alphonso's government, I was able to broker a..."*)

### Węzeł `[316]`
Mówca: **Gus Manger**
> ""Back under Alphonso's government, I was able to broker a deal with King Romus Toras, thanks to my connection with Rusty. It was a win for all involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Player: ""Rusty Montoro, the Toras family, the Rizian government....."*)
  - -> `[319]` (*Player: ""With all due respect, Gus, I'm not thrilled that you got..."*)
  - -> `[318]` (*Player: ""So I've heard, Gus. I understand the need for strategic ..."*)
  - -> `[419]` (*Player: ""I can assist you if you can return the favor by improvin..."*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Rusty Montoro, the Toras family, the Rizian government...it seems like an impressively powerful alliance you've formed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Gus Manger: ""It was quite a feat, and not one without risk. But the p..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So I've heard, Gus. I understand the need for strategic alliances, but let's remember our own interests and values.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Gus Manger: ""Absolutely, we're in this for Sordland first and foremos..."*)

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""With all due respect, Gus, I'm not thrilled that you got Sordland in bed with a monarchy. The kingdom's connection to Rumburg isn't particularly reassuring either.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Gus Manger: ""I hear your concern, but business doesn't always line up..."*)

### Węzeł `[320]`
Mówca: **Gus Manger**
> ""It was quite a feat, and not one without risk. But the potential rewards for Sordland, I believe, are worth it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[321]`
Mówca: **Gus Manger**
> ""I hear your concern, but business doesn't always line up neatly with politics. Our deal with the Toras family was purely about economic growth for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Ewald Alphonso: ""Thanks to Gus' Rizian connections, investors from the ki..."*)

### Węzeł `[322]`
Mówca: **Gus Manger**
> ""Absolutely, we're in this for Sordland first and foremost. But remember, in the world of international business, alliances are tools, not ties that bind us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Ewald Alphonso: ""Thanks to Gus' Rizian connections, investors from the ki..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1"*)

### Węzeł `[326]`
Mówca: **Ewald Alphonso**
> ""Our pace was not the problem. Resistance to change was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[327]`
Mówca: **Ewald Alphonso**
> "“Along the way, I had the privilege of encountering remarkable individuals who have made significant contributions to their respective fields.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Ewald Alphonso: ""My experiences prompted deep reflection on the essence o..."*)

### Węzeł `[328]`
Mówca: **Ewald Alphonso**
> ""My experiences prompted deep reflection on the essence of life. I came out of it all with two words resonating in my head: reputation and legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Ewald Alphonso: ""These two pillars embody the lasting impact we leave beh..."*)

### Węzeł `[329]`
Mówca: **Narrator**
> "With a cup of coffee in hand, he strolled over to the window, his gaze drawn to the expansive gas fields stretching before him. Towering mountains provided a majestic backdrop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Player: ""Don't we all yearn to be remembered and to make a meanin..."*)
  - -> `[423]` (*Player: ""Our image and our perception are a key force that shape ..."*)
  - -> `[333]` (*Player: ""The focus on reputation and legacy is rooted in a capita..."*)
  - -> `[332]` (*Player: ""Life's true essence lies in the present moment.""*)
  - -> `[336]` (*Player_Italic: "Don't comment."*)

### Węzeł `[330]`
Mówca: **Ewald Alphonso**
> ""I have been thinking about my own legacy and reputation. And I refuse to be remembered as a failed reformer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Ewald Alphonso: ""I put so many years of my life into this corporation. An..."*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't we all yearn to be remembered and to make a meaningful contribution?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "He gazed out for a moment longer as he contemplated what ..."*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Life's true essence lies in the present moment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "He gazed out for a moment longer as he contemplated what ..."*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The focus on reputation and legacy is rooted in a capitalist framework that perpetuates individualism and inequality.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "He gazed out for a moment longer as he contemplated what ..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "He gazed out for a moment longer as he contemplated what ..."*)

### Węzeł `[336]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Italic**
> "I didn't comment."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "After taking a moment to appreciate the landscape, Alphon..."*)

### Węzeł `[337]`
Mówca: **Narrator**
> "After taking a moment to appreciate the landscape, Alphonso turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Ewald Alphonso: ""I have been thinking about my own legacy and reputation...."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Ewald Alphonso: ""If Soll had continued, we would have faced a severe econ..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That makes sense. Foreign investors will bring much-needed capital and expertise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Gus Manger: ""Correct, Mr. President.""*)

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Engaging with foreign investors can be a double-edged sword.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Gus Manger: ""I appreciate your perspective, but we need to adapt to t..."*)

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I have concerns about relying too heavily on foreign investors. It's important to prioritize local ownership and maintain sovereignty over our national resources.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Gus Manger: ""I understand your concerns. But the future of Gasom is o..."*)

### Węzeł `[342]`
Mówca: **Gus Manger**
> ""Correct, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Gus Manger: ""It's a strategic move to ensure the growth and success o..."*)

### Węzeł `[343]`
Mówca: **Gus Manger**
> ""I understand your concerns. But the future of Gasom is on the line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Gus Manger: ""Rest assured, we will take measures to protect our inter..."*)

### Węzeł `[344]`
Mówca: **Gus Manger**
> ""I appreciate your perspective, but we need to adapt to the changing global landscape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Gus Manger: ""Foreign investors will bring new opportunities and techn..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true"*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player: ""Foreign investors such as the Kingdom of Rizia, you mean?""*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Foreign investors such as the Kingdom of Rizia, you mean?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true`
- **Kontekst wejściowy (poprzednik):** `[37]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Gus Manger: ""The Kingdom of Rizia certainly has valuable expertise an..."*)

### Węzeł `[349]`
Mówca: **Gus Manger**
> ""The Kingdom of Rizia certainly has valuable expertise and resources in the energy sector.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Gus Manger: ""We will carefully consider their investment proposal and..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Ewald Alphonso: "“I appreciate you coming through, Gus. Getting Rizia inte..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Ewald Alphonso: "“I appreciate you coming through, Gus. Getting Rizia inte..."*)

### Węzeł `[352]`
Mówca: **Gus Manger**
> ""It's a strategic move to ensure the growth and success of Gasom, benefiting both the company and the nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[353]`
Mówca: **Gus Manger**
> ""Rest assured, we will take measures to protect our interests and ensure responsible engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[354]`
Mówca: **Gus Manger**
> ""Foreign investors will bring new opportunities and technologies that could enhance the efficiency and competitiveness of Gasom. It's about finding the right balance and safeguarding our interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Ewald Alphonso: "“I appreciate you coming through, Gus. Getting Rizia inte..."*)

### Węzeł `[355]`
Mówca: **Gus Manger**
> ""We will carefully consider their investment proposal and assess how it aligns with our long-term goals for Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[356]`
Mówca: **Ewald Alphonso**
> "“The trouble is that right now, some of our fields are operating at only half of their capacity due to resource limitations. But we have significant potential for expansion, including two new fields that haven't even been tapped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Ewald Alphonso: "“With the right amount of investment, we can expand resou..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He took a sip of coffee. His face assumed a contemplative..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He took a sip of coffee. His face assumed a contemplative..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He took a sip of coffee. His face assumed a contemplative..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He took a sip of coffee. His face assumed a contemplative..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1"*)

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“I won't let the Old Guard do what they did to you to me. You should have seen through it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Ewald Alphonso: ""You'll need allies if you want to beat the deep state, M..."*)

### Węzeł `[363]`
Mówca: **Ewald Alphonso**
> ""You'll need allies if you want to beat the deep state, Mr. Rayne. A difficult proposition for a traitor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint <= 1"*)

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't like bullshit. Can we get to the choice at hand?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Ewald Alphonso: ""Your lack of statesmanship is disheartening, President R..."*)

### Węzeł `[365]`
**[WYBÓR GRACZA: "Don't interrupt."]** — Mówca: **Player_Italic**
> "I kept listening."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Ewald Alphonso: ""After acquiring the shares, I was elected as CEO. The co..."*)

### Węzeł `[366]`
Mówca: **Ewald Alphonso**
> ""One would expect more diplomatic skill from a president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gus Manger: ""It seems we are at a crossroads with Gasom. The numbers ..."*)

### Węzeł `[367]`
Mówca: **Ewald Alphonso**
> ""Your lack of statesmanship is disheartening, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gus Manger: ""It seems we are at a crossroads with Gasom. The numbers ..."*)

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I've seen enough corporate bailouts and handouts to know that it's always the big businesses that benefit, while the common people are left to suffer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Ewald Alphonso: ""Gasom is not just another corporation; it's an essential..."*)

### Węzeł `[370]`
Mówca: **Ewald Alphonso**
> ""Gasom is not just another corporation; it's an essential part of the energy infrastructure that powers our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The sound of sirens briefly distracted us. Through the wi..."*)

### Węzeł `[372]`
Mówca: **Gus Manger**
> ""With proper investment and development, we project extremely high returns in the first five years alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The sound of sirens briefly distracted us. Through the wi..."*)

### Węzeł `[373]`
Mówca: **Gus Manger**
> ""We have developed a strategic plan that focuses on diversifying revenue streams and exploring new markets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The sound of sirens briefly distracted us. Through the wi..."*)

### Węzeł `[374]`
Mówca: **Gus Manger**
> ""There is the aforementioned interest from Rizia. But the investment could also come from Sordland itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“The fact that a leading privatizer is coming to the stat..."*)
  - -> `[44]` (*Player: "“You do know that Rizia can't invest more than 20 percent..."*)
  - -> `[45]` (*Player: "“Gasom is a private corporation. What does Sordland have ..."*)
  - -> `[46]` (*Player: "“If your analysis is correct, any investment would also m..."*)

### Węzeł `[375]`
Mówca: **Ewald Alphonso**
> ""As chair, my own reputation and legacy are tied with that of Gasom. But so, I would argue, are Sordland's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gus Manger: ""It seems we are at a crossroads with Gasom. The numbers ..."*)

### Węzeł `[376]`
Mówca: **Ewald Alphonso**
> ""I confess I've been following the news from the Maroon Palace closely since leaving office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses ..."*)
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesse..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromoteMarket == true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromoteMarket == true"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromoteMarket == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_PromoteMarket == true"*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_PromoteMarket == true)"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_PromoteMarket == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromoteMarket"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_PromoteMarket == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromoteMarket"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Ewald Alphonso: ""I am heartened that your economic interests seem to alig..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Ewald Alphonso: ""Your decision to deviate from a market economy is, let's..."*)

### Węzeł `[387]`
Mówca: **Ewald Alphonso**
> ""I am heartened that your economic interests seem to align with mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)

### Węzeł `[388]`
Mówca: **Ewald Alphonso**
> ""Your decision to deviate from a market economy is, let's say, not what I would have chosen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_West == true)"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Ewald Alphonso: ""Even more so that you have chosen to align with the West..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_West == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Ewald Alphonso: ""But I am puzzled that your administration has so far ign..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Diplomacy_West == true"*)
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Diplomacy_West == true)"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Diplomacy_West == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Ewald Alphonso: ""But I am heartened by your decision to align with the We..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Diplomacy_West == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Ewald Alphonso: ""And I am puzzled that your administration has so far ign..."*)

### Węzeł `[395]`
Mówca: **Ewald Alphonso**
> ""Even more so that you have chosen to align with the West. It's a path I myself considered while drafting my foreign policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[396]`
Mówca: **Ewald Alphonso**
> ""But I am heartened by your decision to align with the West. It's a path I myself considered while drafting my foreign policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true"*)

### Węzeł `[399]`
Mówca: **Ewald Alphonso**
> ""But I am puzzled that your administration has so far ignored the wealth of opportunities provided by the West. It's not a foreign policy direction I would have chosen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true"*)

### Węzeł `[401]`
Mówca: **Ewald Alphonso**
> ""And I am puzzled that your administration has so far ignored the wealth of opportunities provided by the West.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true"*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Ewald Alphonso: ""Now I hear that you are positive about the Kingdom of Ri..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_RiziaOffer_PositiveIntention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Ewald Alphonso: ""Meanwhile, I have not heard any indication of your leani..."*)

### Węzeł `[406]`
Mówca: **Ewald Alphonso**
> ""Meanwhile, I have not heard any indication of your leanings regarding the Kingdom of Rizia's interest in investing in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player: ""I have yet to receive a comprehensive briefing on the ma..."*)
  - -> `[192]` (*Player: ""I'd rather not hand over crucial components of our energ..."*)
  - -> `[190]` (*Player: ""While the prospect of collaborating with a wealthy natio..."*)

### Węzeł `[407]`
Mówca: **Gus Manger**
> ""You know, gentlemen, this reminds me of a story from when I was just starting out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Gus Manger: ""There was this young farmer in Gruni. His father was a s..."*)

### Węzeł `[408]`
Mówca: **Gus Manger**
> ""There was this young farmer in Gruni. His father was a stubborn man, insisted on doing things the old way. But this young farmer, he had ideas. He wanted to modernize, to innovate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Gus Manger: ""It was only when his father fell ill that he took over a..."*)

### Węzeł `[409]`
Mówca: **Gus Manger**
> ""Back to the topic at hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gus Manger: ""It seems we are at a crossroads with Gasom. The numbers ..."*)

### Węzeł `[410]`
Mówca: **Ewald Alphonso**
> "“We've got an amazing opportunity here. The demand for gas is steadily increasing from both international partners and the Sordish state. All we have to do is ensure a consistent supply.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Ewald Alphonso: "“The trouble is that right now, some of our fields are op..."*)

### Węzeł `[411]`
Mówca: **Ewald Alphonso**
> "“With the right amount of investment, we can expand resource extraction, effectively fulfill rising demand and ensure long-term stability and profitability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Ewald Alphonso: ""But that requires us to be willing to take risks and wea..."*)

### Węzeł `[412]`
Mówca: **Ewald Alphonso**
> "“The trouble is that right now, some of our fields are operating at only half of their capacity due to resource limitations. But we have significant potential for expansion, including two new fields that haven't even been tapped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Ewald Alphonso: "“With the right amount of investment, we can expand resou..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "As Gus finished his point, we suddenly heard the faint wa..."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "As Gus finished his point, we suddenly heard the faint wa..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Ewald Alphonso: ""Of course, President Rayne. Business, above all, should ..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Ewald Alphonso: ""Your caution is well-founded, President Rayne. Internati..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Ewald Alphonso: ""Thanks to Gus' Rizian connections, investors from the ki..."*)

### Węzeł `[418]`
Mówca: **Gus Manger**
> ""One hand washes the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I can assist you if you can return the favor by improving the situation in the city.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Gus Manger: ""One hand washes the other.""*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] = Variable["BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Ewald Alphonso: ""Thanks to Gus' Rizian connections, investors from the ki..."*)

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will seize opportunities, but not the ones you might like.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Ewald Alphonso: ""I respect a man that sticks to his ideals.""*)

### Węzeł `[422]`
Mówca: **Ewald Alphonso**
> ""I respect a man that sticks to his ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Gus Manger: ""It seems we are at a crossroads with Gasom. The numbers ..."*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our image and our perception are a key force that shape our lives. But they can also be burdensome.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_EnT_Gasom_AlphonsoDealPoint += 1"*)
