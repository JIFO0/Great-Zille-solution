# Sordland/Turn06/A_ReformistConvincePFJP

- **ID konwersacji:** `81`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/081_A_ReformistConvincePFJP.md`
- **Liczba węzłów dialogowych:** 488
- **Liczba wyborów gracza:** 118

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[32]** Frens Ricter

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Decision_Turn06_Megaproject_NoInvestment`
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Ministers_Default`
- `BaseGame.Reform_Law_TermLimits_2`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Reform_Reform_PFJP_Convinced`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Frens_Promise_Seat`
- `BaseGame.Relations_Frens_Promise_Taurus`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_Reform_PFJP_Convinced`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Frens_Promise_Seat`
- `BaseGame.Relations_Frens_Promise_Taurus`
- `BaseGameSupport.Journal_Turn06_Frens_Bribed`
- `BaseGameSupport.Journal_Turn06_Frens_Convinced`
- `BaseGameSupport.Journal_Turn06_Frens_PromisedSeat`
- `BaseGameSupport.Journal_Turn06_Frens_Taurus`
- `BaseGameSupport.News_Turn06_LT_PFJPConvinced`
- `BaseGameSupport.News_Turn06_LT_PFJPNotConvinced`
- `BaseGameSupport.News_Turn06_ST_RayneMeetsRicter`
- `BaseGameSupport.News_Turn06_ST_VictoryDay`
- `BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced`
- `BaseGameSupport.Report_Turn06_Holsord_PFJP_NotConvinced`
- `GameCondition.Turn06_A_Reform`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""It's good to have you here, Mr. Ricter.""** | `[5]` **Narrator**: "We met in the presidential offic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Frens Ricter**: ""Likewise. It's nice to finally ..." |
| `[7]` | **""Thank you for the gift.""** | `[5]` **Narrator**: "We met in the presidential offic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Frens Ricter**: ""Oh, it's nothing, Mr. Rayne."" |
| `[8]` | **""You are a fan of Arcasia, aren't you?""** | `[5]` **Narrator**: "We met in the presidential offic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Frens Ricter**: ""A fan of their chocolates, yes."" |
| `[14]` | **""Oh, that's not what I meant. Thanks for the gift.""** | `[12]` **Frens Ricter**: ""You don't like them?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Frens Ricter**: ""It's nothing, Mr. Rayne."" |
| `[15]` | **""I don't like chocolate.""** | `[12]` **Frens Ricter**: ""You don't like them?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Frens Ricter**: ""Oh, I didn't know that, Mr. Ray..." |
| `[16]` | **""I don't like Arcasia.""** | `[12]` **Frens Ricter**: ""You don't like them?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "He laughed." |
| `[34]` | **""I thought we were on the same page.""** | `[24]` **Frens Ricter**: ""I am surprised by this proposal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Frens Ricter**: ""I thought so too. But it seems ..."<br>`[48]` **Frens Ricter**: ""Don't get me wrong, I like your..." |
| `[35]` | **""What parts don't you understand?""** | `[24]` **Frens Ricter**: ""I am surprised by this proposal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Frens Ricter**: ""I don't know where to begin.""<br>`[48]` **Frens Ricter**: ""Don't get me wrong, I like your..." |
| `[36]` | **""What's on your mind?""** | `[24]` **Frens Ricter**: ""I am surprised by this proposal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Frens Ricter**: ""I don't know where to begin.""<br>`[48]` **Frens Ricter**: ""Don't get me wrong, I like your..." |
| `[56]` | **""I'll need protection from the Supreme Court.""** | `[52]` **Frens Ricter**: ""You want to remove the impeachm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Frens Ricter**: ""Protection? By eliminating the ..." |
| `[57]` | **""That was necessary for the whole package to work.""** | `[52]` **Frens Ricter**: ""You want to remove the impeachm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Frens Ricter**: ""Come on, Mr. Rayne. We are not ..." |
| `[58]` | **""How about you look at the bigger picture instead?""** | `[52]` **Frens Ricter**: ""You want to remove the impeachm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Frens Ricter**: ""What bigger picture? This law w..." |
| `[99]` | **""You prefer Soll's Constitution then?""** | `[98]` **Frens Ricter**: ""How are you calling this a demo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Frens Ricter**: ""This is not a contest, Mr. Pres..." |
| `[100]` | **""Be a realist, Mr. Ricter. This proposal is the best we can do.""** | `[98]` **Frens Ricter**: ""How are you calling this a demo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Frens Ricter**: ""A realist?"" |
| `[101]` | **""These are all necessary to maintain stability.""** | `[98]` **Frens Ricter**: ""How are you calling this a demo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Frens Ricter**: ""Necessary?"" |
| `[113]` | **""I can't deny that we are desperate for your support.""** | `[108]` **Frens Ricter**: ""And you're saying this while yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Frens Ricter**: ""I know. And we can help you.""<br>`[159]` **Frens Ricter**: ""Isn't it funny how life works?"" |
| `[114]` | **""Be it small or great, a step forward is a step forward.""** | `[108]` **Frens Ricter**: ""And you're saying this while yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Frens Ricter**: ""While that's true, that shouldn..."<br>`[161]` **Frens Ricter**: ""While that's true, we cannot se..." |
| `[115]` | **""I still believe we can accomplish meaningful change together.""** | `[108]` **Frens Ricter**: ""And you're saying this while yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Frens Ricter**: ""Maybe we can.""<br>`[163]` **Frens Ricter**: ""The only problem is... your pro..." |
| `[116]` | **""Yes, Frens. And you will give me your support.""** | `[108]` **Frens Ricter**: ""And you're saying this while yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Frens Ricter**: ""I'm not sure if that was a thre..." |
| `[121]` | **""Why would you care if this was a political suicide for me?""** | `[120]` **Frens Ricter**: ""How does the USP feel about tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Frens Ricter**: ""I cannot afford to support anot..." |
| `[122]` | **""The USP is in agreement. It is up to you to support it now.""** | `[120]` **Frens Ricter**: ""How does the USP feel about tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Frens Ricter**: ""Mrs. Tory didn't seem to be ext..." |
| `[123]` | **""The party listens to what I say.""** | `[120]` **Frens Ricter**: ""How does the USP feel about tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Frens Ricter**: ""Mrs. Tory didn't seem to be ext..." |
| `[129]` | **""You're saying the PFJP can be bought?""** | `[128]` **Frens Ricter**: ""Are you aware the Old Guard has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Frens Ricter**: ""What? No."" |
| `[130]` | **""Who would have thought? Of course they are, but we shouldn't worry.""** | `[128]` **Frens Ricter**: ""Are you aware the Old Guard has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Frens Ricter**: ""So you have a plan..."" |
| `[131]` | **""My hands are tied. We just need to focus on the upcoming vote.""** | `[128]` **Frens Ricter**: ""Are you aware the Old Guard has..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Frens Ricter**: ""I hope it works out, Mr. Presid..." |
| `[138]` | **""We have a few connections on the inside. I'm going to handle that.""** | `[136]` **Frens Ricter**: ""But even if the changes pass in..."<br>`[137]` **Frens Ricter**: ""But even if the changes pass in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Frens Ricter**: ""Oh?"" |
| `[139]` | **""Trust me, the Justices care about money more than anything else.""** | `[136]` **Frens Ricter**: ""But even if the changes pass in..."<br>`[137]` **Frens Ricter**: ""But even if the changes pass in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Frens Ricter**: ""That's your plan? You're going ..." |
| `[140]` | **""If we unite together, they will be forced to support us.""** | `[136]` **Frens Ricter**: ""But even if the changes pass in..."<br>`[137]` **Frens Ricter**: ""But even if the changes pass in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Frens Ricter**: ""I'm not so sure about that. A f..." |
| `[169]` | **""Of course not.""** | `[164]` **Frens Ricter**: ""I'm not sure if that was a thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Frens Ricter**: ""Look, Mr. President. I may be w..."<br>`[188]` **Frens Ricter**: ""I'm sure it wasn't..."" |
| `[170]` | **""It was.""** | `[164]` **Frens Ricter**: ""I'm not sure if that was a thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Narrator**: "He repositioned himself on the c..." |
| `[171]` | **""I just know that you will do the right thing.""** | `[164]` **Frens Ricter**: ""I'm not sure if that was a thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Frens Ricter**: ""Is that so?""<br>`[176]` **Frens Ricter**: ""Which is to push for real refor..." |
| `[193]` | **""You're going to miss our chance for reforms just because they don't contain every..."** | `[168]` **Frens Ricter**: ""I'm still not sure what to make..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Frens Ricter**: ""You're putting all the reformis..." |
| `[194]` | **""What are you thinking about?""** | `[168]` **Frens Ricter**: ""I'm still not sure what to make..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Frens Ricter**: ""You're putting all the reformis..." |
| `[195]` | **""All you need to do is say yes.""** | `[168]` **Frens Ricter**: ""I'm still not sure what to make..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Frens Ricter**: ""That would be very useful, woul..." |
| `[200]` | **""Don't make a mistake, Frens. You might regret it.""** | `[183]` **Frens Ricter**: ""There is nothing in this for me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Frens Ricter**: ""I don't appreciate that talk."" |
| `[201]` | **""So you're looking for political gain after all.""** | `[183]` **Frens Ricter**: ""There is nothing in this for me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Frens Ricter**: ""I value Sordland and democracy ..." |
| `[202]` | **""There are no other plans. This was the most we could do with the proposal.""** | `[179]` **Frens Ricter**: ""Let's not kid ourselves any lon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Frens Ricter**: ""Then it seems it's time that yo..." |
| `[203]` | **""Don't make a mistake, Frens. You might regret it.""** | `[179]` **Frens Ricter**: ""Let's not kid ourselves any lon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Frens Ricter**: ""I don't appreciate that talk."" |
| `[204]` | **""Come on, Mr. Ricter. I'm sure we can agree on something.""** | `[179]` **Frens Ricter**: ""Let's not kid ourselves any lon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Frens Ricter**: ""I don't see anything to agree o..." |
| `[205]` | **""Come on, Mr. Ricter. I'm sure we can agree on something.""** | `[183]` **Frens Ricter**: ""There is nothing in this for me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Frens Ricter**: ""I value Sordland and democracy ..." |
| `[212]` | **""So you're looking for political gain after all...""** | `[214]` **Frens Ricter**: ""You'd better have something els..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Frens Ricter**: ""I value Sordland and democracy ..." |
| `[213]` | **""Oh, is the idealist reformist asking for a bribe?""** | `[214]` **Frens Ricter**: ""You'd better have something els..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Frens Ricter**: ""Who said anything about a bribe?"" |
| `[215]` | **""I have nothing to offer but democracy...""** | `[214]` **Frens Ricter**: ""You'd better have something els..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Frens Ricter**: ""You're still going to use that ..." |
| `[216]` | **""I'm sure you have something in mind.""** | `[214]` **Frens Ricter**: ""You'd better have something els..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Frens Ricter**: ""I value Sordland and democracy ..." |
| `[222]` | **""Mrs. Morgna assured me that she's a lock.""** | `[145]` **Frens Ricter**: ""Is Mrs. Edmonds one of them?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Frens Ricter**: ""I respect the Minister of Justi..." |
| `[223]` | **""Not yet, but we're working on it.""** | `[145]` **Frens Ricter**: ""Is Mrs. Edmonds one of them?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Frens Ricter**: ""You can't afford to fail this."" |
| `[224]` | **""Yes, she is supporting us.""** | `[145]` **Frens Ricter**: ""Is Mrs. Edmonds one of them?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Frens Ricter**: ""That's good news."" |
| `[231]` | **""I don't think there's unbalanced representation.""** | `[230]` **Frens Ricter**: ""And if we're talking about demo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Frens Ricter**: ""Mr. President, I thought we've ..." |
| `[232]` | **""I can't promise you anything out of my control.""** | `[230]` **Frens Ricter**: ""And if we're talking about demo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Frens Ricter**: ""Mr. President, I thought we've ..." |
| `[233]` | **""Of course, Mr. Ricter. You can count on me.""** | `[230]` **Frens Ricter**: ""And if we're talking about demo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Frens Ricter**: ""That's good to hear."" |
| `[237]` | **""I can't deny the wrongdoing. But there's nothing I can do about it.""** | `[236]` **Frens Ricter**: ""...We expect you to properly ac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Frens Ricter**: ""Mr. President... We just want p..."<br>`[244]` **Frens Ricter**: ""It seems we will not be seeing ..." |
| `[238]` | **""You're right. You can count on my support.""** | `[236]` **Frens Ricter**: ""...We expect you to properly ac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Frens Ricter**: ""That's good to hear."" |
| `[239]` | **""Do not blame the state. It was the people who elected the USP.""** | `[236]` **Frens Ricter**: ""...We expect you to properly ac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Frens Ricter**: ""It seems we will not be seeing ..." |
| `[246]` | **""Of course, Mr. Ricter. Your support will not go unnoticed.""** | `[243]` **Frens Ricter**: ""Mr. President... We just want p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Frens Ricter**: ""I should hope not."" |
| `[247]` | **""You deserve no credit. You're still beating around the bush with no real intentio..."** | `[243]` **Frens Ricter**: ""Mr. President... We just want p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Frens Ricter**: ""It seems we will not be seeing ..." |
| `[260]` | **""Of course, we're in this together.""** | `[259]` **Frens Ricter**: ""...I expect you to finally ackn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Frens Ricter**: ""That's great to hear."" |
| `[261]` | **""Of course I can't deny my party's disreputable actions.""** | `[259]` **Frens Ricter**: ""...I expect you to finally ackn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Frens Ricter**: ""I respect your honesty, Mr. Pre..." |
| `[262]` | **""Do not blame the USP. Sordland has gone through a lot.""** | `[259]` **Frens Ricter**: ""...I expect you to finally ackn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Frens Ricter**: ""Whatever you say, Mr. President..." |
| `[268]` | **""The USP will not be a problem. With your support, these reforms will pass.""** | `[267]` **Frens Ricter**: ""I can assure you, you'll have t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Frens Ricter**: ""I'm looking forward to it."" |
| `[269]` | **""I'm happy to cooperate with you, Mr. Ricter.""** | `[267]` **Frens Ricter**: ""I can assure you, you'll have t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Frens Ricter**: ""Likewise, Mr. Rayne."" |
| `[270]` | **""Don't doubt it. We'll change the Constitution together.""** | `[267]` **Frens Ricter**: ""I can assure you, you'll have t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Frens Ricter**: ""I'm looking forward to it."" |
| `[275]` | **""No, Mr. Ricter. Thank you for coming. I'm looking forward to our cooperation.""** | `[274]` **Frens Ricter**: ""Was there anything else?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Narrator**: "We shook hands." |
| `[276]` | **""Before you leave, I'd like to address a few things I've heard about you.""** | `[274]` **Frens Ricter**: ""Was there anything else?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Frens Ricter**: ""There are so many 'things' said..." |
| `[282]` | **""I'm sorry, Mr. Ricter. I'm sure we can still agree on something.""** | `[221]` **Frens Ricter**: ""If there's nothing else you'd l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Frens Ricter**: ""Well...""<br>`[292]` **Frens Ricter**: ""There's nothing to agree on. Th..." |
| `[283]` | **""You're not going anywhere before we have a deal.""** | `[221]` **Frens Ricter**: ""If there's nothing else you'd l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Frens Ricter**: ""Please calm down, Mr. President..." |
| `[284]` | **""You're free to do as you want, Mr. Ricter.""** | `[221]` **Frens Ricter**: ""If there's nothing else you'd l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Frens Ricter**: ""Then I'll be leaving, Mr. Presi..." |
| `[299]` | **"Shake his hand."** | `[298]` **Narrator**: "He stood up and offered his hand." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Frens Ricter**: ""Good luck in the Assembly, Mr. ..." |
| `[300]` | **"Don't shake his hand."** | `[298]` **Narrator**: "He stood up and offered his hand." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Frens Ricter**: ""Good luck in the Assembly, Mr. ..." |
| `[309]` | **""Of course.""** | `[308]` **Frens Ricter**: ""I will hold you to your promise."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Frens Ricter**: ""Was there anything else?"" |
| `[310]` | **""And I'll hold you to yours.""** | `[308]` **Frens Ricter**: ""I will hold you to your promise."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Frens Ricter**: ""Was there anything else?"" |
| `[311]` | **""I'm happy to cooperate with you too.""** | `[308]` **Frens Ricter**: ""I will hold you to your promise."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Frens Ricter**: ""Was there anything else?"" |
| `[314]` | **""Tell me what you want.""** | `[255]` **Frens Ricter**: ""We are talking about a lot of v..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[430]` **Frens Ricter**: ""I know you have already conclud..."<br>`[434]` **Frens Ricter**: ""A company that I'm involved wit..."<br>*(oraz 1 innych odgałęzień)* |
| `[315]` | **""You damn corrupt bastard.""** | `[255]` **Frens Ricter**: ""We are talking about a lot of v..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Narrator**: "He did not reply." |
| `[316]` | **""Nothing a check addressed to your name couldn't handle." [Bribe Offer -1 Personal..."** | `[255]` **Frens Ricter**: ""We are talking about a lot of v..." | `Variable["BaseGame.PersonalWealth"] >= 1` | *Brak zmian stanu* | `[334]` **Frens Ricter**: ""Now you've got my attention."" |
| `[323]` | **""I can't do that.""** | `[322]` **Frens Ricter**: ""I'd like you to give them a cha..."<br>`[445]` **Frens Ricter**: ""I'd like you to give them anoth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Frens Ricter**: ""It's a shame things won't work ..." |
| `[324]` | **""Consider it done.""** | `[322]` **Frens Ricter**: ""I'd like you to give them a cha..."<br>`[445]` **Frens Ricter**: ""I'd like you to give them anoth..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Frens_Promise_Taurus"] = true;` | `[351]` **Frens Ricter**: ""...Then you have the support of..." |
| `[327]` | **""Okay, tell me what you want.""** | `[326]` **Narrator**: "He did not reply." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[430]` **Frens Ricter**: ""I know you have already conclud..."<br>`[434]` **Frens Ricter**: ""A company that I'm involved wit..."<br>*(oraz 1 innych odgałęzień)* |
| `[328]` | **""Okay, how about a few checks addressed to your name then?" [BRIBE, -1 Personal We..."** | `[326]` **Narrator**: "He did not reply." | `Variable["BaseGame.PersonalWealth"] >= 1` | *Brak zmian stanu* | `[334]` **Frens Ricter**: ""Now you've got my attention."" |
| `[332]` | **""I can't give you anything else.""** | `[326]` **Narrator**: "He did not reply." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[333]` **Frens Ricter**: ""I see."" |
| `[342]` | **""Nothing a check worth close to a million couldn't handle." [BRIBE, -1 Personal We..."** | `[325]` **Frens Ricter**: ""It's a shame things won't work ..." | `Variable["BaseGame.PersonalWealth"] >= 1` | *Brak zmian stanu* | `[334]` **Frens Ricter**: ""Now you've got my attention."" |
| `[343]` | **""I can try to give you a cabinet position.""** | `[325]` **Frens Ricter**: ""It's a shame things won't work ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Frens Ricter**: ""Are you joking?"" |
| `[345]` | **""There won't be any deals.""** | `[325]` **Frens Ricter**: ""It's a shame things won't work ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[333]` **Frens Ricter**: ""I see."" |
| `[346]` | **""Of course.""** | `[347]` **Frens Ricter**: ""I will hold you to your promise."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Frens Ricter**: ""Was there anything else?"" |
| `[349]` | **""And I'll hold you to yours.""** | `[347]` **Frens Ricter**: ""I will hold you to your promise."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Frens Ricter**: ""Was there anything else?"" |
| `[350]` | **""I'm happy to have reached a deal.""** | `[347]` **Frens Ricter**: ""I will hold you to your promise."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Frens Ricter**: ""Was there anything else?"" |
| `[353]` | **""I'm happy to have gotten to know the real you, Frens.""** | `[352]` **Frens Ricter**: ""I'll do my best to gather the s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Frens_Bribed"] = true;` | `[274]` **Frens Ricter**: ""Was there anything else?"" |
| `[354]` | **""That's great to hear.""** | `[352]` **Frens Ricter**: ""I'll do my best to gather the s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Frens_Bribed"] = true;` | `[274]` **Frens Ricter**: ""Was there anything else?"" |
| `[356]` | **""Likewise, Mr. Ricter. I like this cooperative spirit.""** | `[352]` **Frens Ricter**: ""I'll do my best to gather the s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Frens_Bribed"] = true;` | `[274]` **Frens Ricter**: ""Was there anything else?"" |
| `[358]` | **""No. There may be some vacancies sooner or later.""** | `[357]` **Frens Ricter**: ""Are you joking?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Frens Ricter**: ""I can't believe that you'd offe..." |
| `[359]` | **""I can try and force someone to resign.""** | `[357]` **Frens Ricter**: ""Are you joking?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Frens Ricter**: ""I can't believe that you'd offe..." |
| `[360]` | **""Obviously.""** | `[357]` **Frens Ricter**: ""Are you joking?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Narrator**: "He did not reply." |
| `[365]` | **""Okay, how about a few checks?" [BRIBE]"** | `[361]` **Narrator**: "He did not reply." | `Variable["BaseGame.PersonalWealth"] >= 1` | *Brak zmian stanu* | `[334]` **Frens Ricter**: ""Now you've got my attention."" |
| `[366]` | **""It seems there won't be any deals.""** | `[361]` **Narrator**: "He did not reply." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Frens Ricter**: ""So it seems."" |
| `[373]` | **""Sounds good.""** | `[372]` **Frens Ricter**: ""If everything works out, I'll e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Frens Ricter**: ""Great. Then we have a deal."" |
| `[374]` | **""I promise I'll figure something out.""** | `[372]` **Frens Ricter**: ""If everything works out, I'll e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Frens Ricter**: ""Great. Then we have a deal."" |
| `[375]` | **""I'll do my best.""** | `[372]` **Frens Ricter**: ""If everything works out, I'll e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Frens Ricter**: ""Great. Then we have a deal."" |
| `[376]` | **""Finally! Thanks for the support.""** | `[372]` **Frens Ricter**: ""If everything works out, I'll e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Frens Ricter**: ""Great. Then we have a deal."" |
| `[381]` | **""I received intelligence that you made a deal with Arcasia and that you tried cove..."** | `[277]` **Frens Ricter**: ""There are so many 'things' said..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Frens Ricter**: ""Oh, it did come to that, after ..." |
| `[382]` | **""Do you have some sort of secret partnership with President Dwight Walker? There a..."** | `[277]` **Frens Ricter**: ""There are so many 'things' said..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Frens Ricter**: ""Because I've met with Walker be..." |
| `[386]` | **""Wait. What are you trying to say?""** | `[388]` **Frens Ricter**: ""...And it did. Afterwards the p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Frens Ricter**: ""I am trying to say that everyth..." |
| `[389]` | **""You think Soll and the Old Guard orchestrated all of this?""** | `[388]` **Frens Ricter**: ""...And it did. Afterwards the p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Frens Ricter**: ""Yes. They knew that Alphonso's ..." |
| `[390]` | **""Act how?""** | `[394]` **Frens Ricter**: ""We are in this together, so I w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Frens Ricter**: ""I was contacted by an Arcasian ..." |
| `[396]` | **""I hope you didn't do anything to compromise our country.""** | `[394]` **Frens Ricter**: ""We are in this together, so I w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[397]` **Frens Ricter**: ""Of course not."" |
| `[400]` | **""I am grateful that you're telling me all this.""** | `[403]` **Frens Ricter**: ""I told him that I was only ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[413]` **Frens Ricter**: ""Thanks for taking it so well. W..." |
| `[401]` | **""So the intel was correct after all...""** | `[403]` **Frens Ricter**: ""I told him that I was only ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[412]` **Frens Ricter**: ""To some extent, yes. But now yo..." |
| `[402]` | **""That was a big mistake from your side.""** | `[403]` **Frens Ricter**: ""I told him that I was only ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[411]` **Frens Ricter**: ""I know..."" |
| `[404]` | **""You're saying I was elected because Soll wanted it?""** | `[388]` **Frens Ricter**: ""...And it did. Afterwards the p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Frens Ricter**: ""I don't know. But your candidac..." |
| `[406]` | **""I don't like where this is going.""** | `[394]` **Frens Ricter**: ""We are in this together, so I w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Frens Ricter**: ""I was contacted by an Arcasian ..." |
| `[407]` | **""I don't know if I can trust you after this.""** | `[403]` **Frens Ricter**: ""I told him that I was only ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[414]` **Frens Ricter**: ""The fact that I've told you som..." |
| `[408]` | **""You did what!?""** | `[398]` **Frens Ricter**: ""I was contacted by an Arcasian ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Frens Ricter**: ""Please allow me to continue, Mr..." |
| `[409]` | **"Let him continue."** | `[398]` **Frens Ricter**: ""I was contacted by an Arcasian ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[399]` **Frens Ricter**: ""I flew to Arcasia and I eventua..." |
| `[417]` | **""I'll trust you, Mr. Ricter.""** | `[416]` **Frens Ricter**: ""I gave you my trust. I hope I h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Frens Ricter**: ""That means a lot coming from you."" |
| `[418]` | **""You are correct. I hope to be together in this fight for a better future.""** | `[416]` **Frens Ricter**: ""I gave you my trust. I hope I h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Frens Ricter**: ""As the revolutionaries once sai..." |
| `[419]` | **""I appreciate your trust in me, but I'll need to think more about this.""** | `[416]` **Frens Ricter**: ""I gave you my trust. I hope I h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Frens Ricter**: ""That's fair."" |
| `[449]` | **""Their work left much to be desired. I will not work with them again.""** | `[445]` **Frens Ricter**: ""I'd like you to give them anoth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Frens Ricter**: ""It's a shame things won't work ..." |
| `[457]` | **""That bill also increased your funding, Mr. Ricter...""** | `[456]` **Frens Ricter**: ""The first bill you signed effec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[460]` **Frens Ricter**: ""Oh, so I should be grateful for..." |
| `[458]` | **""It was passed by the Assembly. All I did was sign it into law.""** | `[456]` **Frens Ricter**: ""The first bill you signed effec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[461]` **Frens Ricter**: ""Exactly. You *did* sign it into..." |
| `[459]` | **""The past is past, Mr. Ricter. Let's fix the future.""** | `[456]` **Frens Ricter**: ""The first bill you signed effec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[462]` **Frens Ricter**: ""Well, it's not so simple, Mr. R..." |

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
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_ST_VictoryDay = true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "But we desperately needed more support. That's why I had invited Frens Ricter for a chat about the upcoming vote. He and his party held the key to our success."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "We met in the presidential office at the end of the day. ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The preparations for the new Constitution were nearly complete. Soon we were going to propose it in the Grand National Assembly. A huge step for our administration."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "But we desperately needed more support. That's why I had ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "We met in the presidential office at the end of the day. He arrived in his signature navy blue suit and handed me a box of famous Arcasian chocolates before settling down on the couch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player: ""It's good to have you here, Mr. Ricter.""*)
  - -> `[7]` (*Player: ""Thank you for the gift.""*)
  - -> `[8]` (*Player: ""You are a fan of Arcasia, aren't you?""*)

### Węzeł `[6]`
**[WYBÓR GRACZA: ""It's good to have you here, Mr. Ricter.""]** — Mówca: **Player**
> ""It's good to have you here, Mr. Ricter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Frens Ricter: ""Likewise. It's nice to finally have some time to talk.""*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""Thank you for the gift.""]** — Mówca: **Player**
> ""Thank you for the gift.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Frens Ricter: ""Oh, it's nothing, Mr. Rayne.""*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""You are a fan of Arcasia, aren't you?""]** — Mówca: **Player**
> ""You are a fan of Arcasia, aren't you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Frens Ricter: ""A fan of their chocolates, yes.""*)

### Węzeł `[9]`
Mówca: **Frens Ricter**
> ""Likewise. It's nice to finally have some time to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He took a folder from his briefcase and flipped it open. ..."*)

### Węzeł `[10]`
Mówca: **Frens Ricter**
> ""Oh, it's nothing, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He took a folder from his briefcase and flipped it open. ..."*)

### Węzeł `[11]`
Mówca: **Frens Ricter**
> ""A fan of their chocolates, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He pointed to the box."*)

### Węzeł `[12]`
Mówca: **Frens Ricter**
> ""You don't like them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""Oh, that's not what I meant. Thanks for the gift.""*)
  - -> `[15]` (*Player: ""I don't like chocolate.""*)
  - -> `[16]` (*Player: ""I don't like Arcasia.""*)

### Węzeł `[13]`
Mówca: **Narrator**
> "He pointed to the box."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Frens Ricter: ""You don't like them?""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Oh, that's not what I meant. Thanks for the gift.""]** — Mówca: **Player**
> ""Oh, that's not what I meant. Thanks for the gift.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Frens Ricter: ""It's nothing, Mr. Rayne.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I don't like chocolate.""]** — Mówca: **Player**
> ""I don't like chocolate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Frens Ricter: ""Oh, I didn't know that, Mr. Rayne. Maybe your kids would..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""I don't like Arcasia.""]** — Mówca: **Player**
> ""I don't like Arcasia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "He laughed."*)

### Węzeł `[17]`
Mówca: **Frens Ricter**
> ""Oh, come on. You can't deny there are a few things they do well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He took a folder from his briefcase and flipped it open. ..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Frens Ricter: ""Oh, come on. You can't deny there are a few things they ..."*)

### Węzeł `[19]`
Mówca: **Frens Ricter**
> ""Oh, I didn't know that, Mr. Rayne. Maybe your kids would like them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Frens Ricter: ""But I'll keep that in mind for next time.""*)

### Węzeł `[20]`
Mówca: **Frens Ricter**
> ""But I'll keep that in mind for next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He took a folder from his briefcase and flipped it open. ..."*)

### Węzeł `[21]`
Mówca: **Frens Ricter**
> ""It's nothing, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He took a folder from his briefcase and flipped it open. ..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "He took a folder from his briefcase and flipped it open. I could see the scribbles he'd made in the margins of my draft proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Frens Ricter: ""I have to say...""*)

### Węzeł `[23]`
Mówca: **Frens Ricter**
> ""I have to say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Frens Ricter: ""I am surprised by this proposal you've prepared for the ..."*)

### Węzeł `[24]`
Mówca: **Frens Ricter**
> ""I am surprised by this proposal you've prepared for the new Constitution. I really do not understand your reasoning behind some of the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player: ""I thought we were on the same page.""*)
  - -> `[35]` (*Player: ""What parts don't you understand?""*)
  - -> `[36]` (*Player: ""What's on your mind?""*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_TermLimits_2 == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_TermLimits_2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_TermLimits_2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Frens Ricter: ""I'm just shocked you listened to our demands. Decreasing..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_TermLimits_2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_TermLimits_2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Frens Ricter: ""I'm just shocked you listened to our demands. Decreasing..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Frens Ricter: ""But even if the changes pass in Assembly, how are you go..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Frens Ricter: ""But even if the changes pass in Assembly, how are you go..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Abolished == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Frens Ricter: ""And I completely did not expect you to go against Tarqui..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Frens Ricter: ""How does the USP feel about that, Mr. President? Is this..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: ""I thought we were on the same page.""]** — Mówca: **Player**
> ""I thought we were on the same page.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true || BaseGa..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""What parts don't you understand?""]** — Mówca: **Player**
> ""What parts don't you understand?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true || BaseGa..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""What's on your mind?""]** — Mówca: **Player**
> ""What's on your mind?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true || BaseGa..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true || BaseGa..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true || Base..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Frens Ricter: ""I thought so too. But it seems I was wrong.""*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Frens Ricter: ""Don't get me wrong, I like your draft. As I've already s..."*)

### Węzeł `[40]`
Mówca: **Frens Ricter**
> ""I thought so too. But it seems I was wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true || BaseGa..."*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true || Base..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Frens Ricter: ""I don't know where to begin.""*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Frens Ricter: ""Don't get me wrong, I like your draft. As I've already s..."*)

### Węzeł `[44]`
Mówca: **Frens Ricter**
> ""I don't know where to begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true || BaseGa..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true || Base..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Frens Ricter: ""I don't know where to begin.""*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Ministers_Default == true || BaseGame.Reform_Law_Threshold_Default == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Ministers_Default"] == true  or  Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Frens Ricter: ""Don't get me wrong, I like your draft. As I've already s..."*)

### Węzeł `[48]`
Mówca: **Frens Ricter**
> ""Don't get me wrong, I like your draft. As I've already stated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_TermLimits_2 == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Frens Ricter: ""You want to remove the impeachment procedure from the Co..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame...."*)

### Węzeł `[52]`
Mówca: **Frens Ricter**
> ""You want to remove the impeachment procedure from the Constitution. Why is that even part of the proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player: ""I'll need protection from the Supreme Court.""*)
  - -> `[57]` (*Player: ""That was necessary for the whole package to work.""*)
  - -> `[58]` (*Player: ""How about you look at the bigger picture instead?""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Frens Ricter: ""You are not reforming the presidential decree process. T..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: ""I'll need protection from the Supreme Court.""]** — Mówca: **Player**
> ""I'll need protection from the Supreme Court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Frens Ricter: ""Protection? By eliminating the whole process?""*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""That was necessary for the whole package to work.""]** — Mówca: **Player**
> ""That was necessary for the whole package to work.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Frens Ricter: ""Come on, Mr. Rayne. We are not in front of cameras right..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""How about you look at the bigger picture instead?""]** — Mówca: **Player**
> ""How about you look at the bigger picture instead?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Frens Ricter: ""What bigger picture? This law would destroy the balances..."*)

### Węzeł `[59]`
Mówca: **Frens Ricter**
> ""Come on, Mr. Rayne. We are not in front of cameras right now. You already know that there is no way we could support this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true && BaseGame.R..."*)

### Węzeł `[60]`
Mówca: **Frens Ricter**
> ""Protection? By eliminating the whole process?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Frens Ricter: ""Come on, Mr. Rayne. We are not in front of cameras right..."*)

### Węzeł `[61]`
Mówca: **Frens Ricter**
> ""What bigger picture? This law would destroy the balances and checks of presidential power. I cannot create another Soll with my own hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Frens Ricter: ""Come on, Mr. Rayne. We are not in front of cameras right..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Frens Ricter: ""On top of that, you are not reforming the presidential d..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)

### Węzeł `[65]`
Mówca: **Frens Ricter**
> ""On top of that, you are not reforming the presidential decree process. This was not at all what we talked about. This has become the opposite of democratic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[66]`
Mówca: **Frens Ricter**
> ""You are not reforming the presidential decree process. This was not at all what we talked about. This has become the opposite of democratic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true && BaseGame.R..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Default == true && BaseGame..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Frens Ricter: ""On top of that, you're not reforming the presidential de..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Default == true && BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Default"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Frens Ricter: ""On top of that, you are expanding the Member of Honor la..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[73]`
Mówca: **Frens Ricter**
> ""On top of that, you are expanding the Member of Honor laws to give yourself immunity after your term. This has turned into a power grab.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Frens Ricter: ""You are expanding the Member of Honor laws to give yours..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[77]`
Mówca: **Frens Ricter**
> ""You are expanding the Member of Honor laws to give yourself immunity after your term. Your proposal has turned into a power grab.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[78]`
Mówca: **Frens Ricter**
> ""On top of that, you're not reforming the presidential decree process *and* you're expanding the Member of Honor laws to give yourself total immunity after your term?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Frens Ricter: ""You have successfully hijacked our constitutional reform..."*)

### Węzeł `[79]`
Mówca: **Frens Ricter**
> ""You have successfully hijacked our constitutional reform talks and created a proposal for your own benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Frens Ricter: ""Although we clearly want a new Constitution, this is not..."*)

### Węzeł `[80]`
Mówca: **Frens Ricter**
> ""Although we clearly want a new Constitution, this is not it, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame...."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGam..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Frens Ricter: ""You're daring to strengthen presidential decree powers w..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Default == true"*)

### Węzeł `[84]`
Mówca: **Frens Ricter**
> ""You're daring to strengthen presidential decree powers while expanding the Member of Honor laws to give yourself total immunity after your term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Frens Ricter: ""You have successfully hijacked our constitutional reform..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Frens Ricter: ""You have ignored our demands for a reform in the appoint..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Frens Ricter: ""You have ignored our demands to lower the undemocratic e..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Ministers_Default == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Ministers_Default == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Ministers_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Frens Ricter: ""Not to mention that you have ignored our demands for a r..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Ministers_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == true"*)

### Węzeł `[91]`
Mówca: **Frens Ricter**
> ""Not to mention that you have ignored our demands for a reform in the appointment of ministers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_Default == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Frens Ricter: ""Not to mention that you have ignored our demands to lowe..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Frens Ricter: ""How are you calling this a democratic package?""*)

### Węzeł `[95]`
Mówca: **Frens Ricter**
> ""Not to mention that you have ignored our demands to lower the undemocratic electoral threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Frens Ricter: ""How are you calling this a democratic package?""*)

### Węzeł `[96]`
Mówca: **Frens Ricter**
> ""You have ignored our demands for a reform in the appointment of ministers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == true"*)

### Węzeł `[97]`
Mówca: **Frens Ricter**
> ""You have ignored our demands to lower the undemocratic electoral threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Frens Ricter: ""How are you calling this a democratic package?""*)

### Węzeł `[98]`
Mówca: **Frens Ricter**
> ""How are you calling this a democratic package?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: ""These are all necessary to maintain stability.""*)
  - -> `[100]` (*Player: ""Be a realist, Mr. Ricter. This proposal is the best we c..."*)
  - -> `[99]` (*Player: ""You prefer Soll's Constitution then?""*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""You prefer Soll's Constitution then?""]** — Mówca: **Player**
> ""You prefer Soll's Constitution then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Frens Ricter: ""This is not a contest, Mr. President. You know how I fee..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Be a realist, Mr. Ricter. This proposal is the best we can do.""]** — Mówca: **Player**
> ""Be a realist, Mr. Ricter. This proposal is the best we can do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Frens Ricter: ""A realist?""*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""These are all necessary to maintain stability.""]** — Mówca: **Player**
> ""These are all necessary to maintain stability.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Frens Ricter: ""Necessary?""*)

### Węzeł `[102]`
Mówca: **Frens Ricter**
> ""A realist?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Frens Ricter: ""Is that your excuse, Mr. President? So this proposal is ..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_Default == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Frens Ricter: ""And you're refusing to lower our undemocratic electoral ..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_Default == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Frens Ricter: ""How are you calling this a democratic package?""*)

### Węzeł `[106]`
Mówca: **Frens Ricter**
> ""And you're refusing to lower our undemocratic electoral threshold...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Frens Ricter: ""How are you calling this a democratic package?""*)

### Węzeł `[107]`
Mówca: **Frens Ricter**
> ""Is that your excuse, Mr. President? So this proposal is realistic but what we demand is not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Frens Ricter: ""And you're saying this while you're begging me for my pa..."*)

### Węzeł `[108]`
Mówca: **Frens Ricter**
> ""And you're saying this while you're begging me for my party's support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: ""I can't deny that we are desperate for your support.""*)
  - -> `[114]` (*Player: ""Be it small or great, a step forward is a step forward.""*)
  - -> `[115]` (*Player: ""I still believe we can accomplish meaningful change toge..."*)
  - -> `[116]` (*Player: ""Yes, Frens. And you will give me your support.""*)

### Węzeł `[109]`
Mówca: **Frens Ricter**
> ""Necessary?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Frens Ricter: ""What kind of an excuse is that, Mr. President?""*)

### Węzeł `[110]`
Mówca: **Frens Ricter**
> ""What kind of an excuse is that, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Frens Ricter: ""And you're saying this while you're begging me for my pa..."*)

### Węzeł `[111]`
Mówca: **Frens Ricter**
> ""This is not a contest, Mr. President. You know how I feel about the current Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Frens Ricter: ""But we must fix its shortcomings, not pronounce them fur..."*)

### Węzeł `[112]`
Mówca: **Frens Ricter**
> ""But we must fix its shortcomings, not pronounce them further...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Frens Ricter: ""And you're saying this while you're begging me for my pa..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA: ""I can't deny that we are desperate for your support.""]** — Mówca: **Player**
> ""I can't deny that we are desperate for your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == false && BaseG..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Be it small or great, a step forward is a step forward.""]** — Mówca: **Player**
> ""Be it small or great, a step forward is a step forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == false && BaseG..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: ""I still believe we can accomplish meaningful change together.""]** — Mówca: **Player**
> ""I still believe we can accomplish meaningful change together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == false && BaseG..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""Yes, Frens. And you will give me your support.""]** — Mówca: **Player**
> ""Yes, Frens. And you will give me your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Frens Ricter: ""I'm not sure if that was a threat, Mr. President.""*)

### Węzeł `[117]`
Mówca: **Frens Ricter**
> ""I'm just shocked you listened to our demands. Decreasing the electoral threshold and the term limits... that's more than we hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[118]`
Mówca: **Frens Ricter**
> ""I'm just shocked you listened to our demands. Decreasing the electoral threshold... that's more than we hoped for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Abolished == true"*)

### Węzeł `[119]`
Mówca: **Frens Ricter**
> ""And I completely did not expect you to go against Tarquin Soll and abolish the Member of Honor laws. It's a bold move, and I respect it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Frens Ricter: ""How does the USP feel about that, Mr. President? Is this..."*)

### Węzeł `[120]`
Mówca: **Frens Ricter**
> ""How does the USP feel about that, Mr. President? Is this political suicide or did you actually manage to get the party behind your changes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""The party listens to what I say.""*)
  - -> `[122]` (*Player: ""The USP is in agreement. It is up to you to support it n..."*)
  - -> `[121]` (*Player: ""Why would you care if this was a political suicide for me?""*)

### Węzeł `[121]`
**[WYBÓR GRACZA: ""Why would you care if this was a political suicide for me?""]** — Mówca: **Player**
> ""Why would you care if this was a political suicide for me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Frens Ricter: ""I cannot afford to support another set of failed reforms..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""The USP is in agreement. It is up to you to support it now.""]** — Mówca: **Player**
> ""The USP is in agreement. It is up to you to support it now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Frens Ricter: ""Mrs. Tory didn't seem to be extremely enthusiastic about..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: ""The party listens to what I say.""]** — Mówca: **Player**
> ""The party listens to what I say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Frens Ricter: ""Mrs. Tory didn't seem to be extremely enthusiastic about..."*)

### Węzeł `[124]`
Mówca: **Frens Ricter**
> ""I cannot afford to support another set of failed reforms... I am the opposition leader after all, Mr. President. People expect me to be hard against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Frens Ricter: ""I've been campaigning for a new Constitution for years a..."*)

### Węzeł `[125]`
Mówca: **Frens Ricter**
> ""I've been campaigning for a new Constitution for years and I cannot just let it vanish because of Tarquin Soll's party again. No offense intended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Frens Ricter: ""Are you aware the Old Guard has been reaching out even t..."*)

### Węzeł `[126]`
Mówca: **Frens Ricter**
> ""Mrs. Tory didn't seem to be extremely enthusiastic about the new Constitution. Are you sure you have all the votes needed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Frens Ricter: ""I believe that the Chief Justice has her ear. And the Ol..."*)

### Węzeł `[127]`
Mówca: **Frens Ricter**
> ""I believe that the Chief Justice has her ear. And the Old Guard is doing their best to make sure you fail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Frens Ricter: ""Are you aware the Old Guard has been reaching out even t..."*)

### Węzeł `[128]`
Mówca: **Frens Ricter**
> ""Are you aware the Old Guard has been reaching out even to PFJP members? I hope you're doing something to contain this mess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""My hands are tied. We just need to focus on the upcoming..."*)
  - -> `[130]` (*Player: ""Who would have thought? Of course they are, but we shoul..."*)
  - -> `[129]` (*Player: ""You're saying the PFJP can be bought?""*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""You're saying the PFJP can be bought?""]** — Mówca: **Player**
> ""You're saying the PFJP can be bought?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Frens Ricter: ""What? No.""*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""Who would have thought? Of course they are, but we shouldn't worry.""]** — Mówca: **Player**
> ""Who would have thought? Of course they are, but we shouldn't worry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Frens Ricter: ""So you have a plan...""*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""My hands are tied. We just need to focus on the upcoming vote.""]** — Mówca: **Player**
> ""My hands are tied. We just need to focus on the upcoming vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Frens Ricter: ""I hope it works out, Mr. President.""*)

### Węzeł `[132]`
Mówca: **Frens Ricter**
> ""What? No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Frens Ricter: ""I am saying the circumstances might be stacked against y..."*)

### Węzeł `[133]`
Mówca: **Frens Ricter**
> ""I am saying the circumstances might be stacked against you without your knowledge. That's it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[134]`
Mówca: **Frens Ricter**
> ""So you have a plan...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[135]`
Mówca: **Frens Ricter**
> ""I hope it works out, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[136]`
Mówca: **Frens Ricter**
> ""But even if the changes pass in Assembly, how are you going to win the Supreme Court over when your draft takes away the Justices' immunity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player: ""We have a few connections on the inside. I'm going to ha..."*)
  - -> `[139]` (*Player: ""Trust me, the Justices care about money more than anythi..."*)
  - -> `[140]` (*Player: ""If we unite together, they will be forced to support us.""*)

### Węzeł `[137]`
Mówca: **Frens Ricter**
> ""But even if the changes pass in Assembly, how are you going to get such an anti-Sollist proposal past the Supreme Court?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Player: ""We have a few connections on the inside. I'm going to ha..."*)
  - -> `[139]` (*Player: ""Trust me, the Justices care about money more than anythi..."*)
  - -> `[140]` (*Player: ""If we unite together, they will be forced to support us.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""We have a few connections on the inside. I'm going to handle that.""]** — Mówca: **Player**
> ""We have a few connections on the inside. I'm going to handle that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Frens Ricter), `[137]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Frens Ricter: ""Oh?""*)

### Węzeł `[139]`
**[WYBÓR GRACZA: ""Trust me, the Justices care about money more than anything else.""]** — Mówca: **Player**
> ""Trust me, the Justices care about money more than anything else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Frens Ricter), `[137]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Frens Ricter: ""That's your plan? You're going to bribe them?""*)

### Węzeł `[140]`
**[WYBÓR GRACZA: ""If we unite together, they will be forced to support us.""]** — Mówca: **Player**
> ""If we unite together, they will be forced to support us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Frens Ricter), `[137]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Frens Ricter: ""I'm not so sure about that. A few Justices will sympathi..."*)

### Węzeł `[141]`
Mówca: **Frens Ricter**
> ""I'm not so sure about that. A few Justices will sympathize with us, but the ultimate decision will be up to the centrists... And Orso has them locked up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Frens Ricter: ""If we're doing this, we have to make it count.""*)

### Węzeł `[142]`
Mówca: **Frens Ricter**
> ""That's your plan? You're going to bribe them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Frens Ricter: ""Just be careful not to let it go public, Mr. President. ..."*)

### Węzeł `[143]`
Mówca: **Frens Ricter**
> ""Just be careful not to let it go public, Mr. President. It could hurt the whole reformist movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Frens Ricter: ""If we're doing this, we have to make it count.""*)

### Węzeł `[144]`
Mówca: **Frens Ricter**
> ""Oh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Frens Ricter: ""Is Mrs. Edmonds one of them?""*)

### Węzeł `[145]`
Mówca: **Frens Ricter**
> ""Is Mrs. Edmonds one of them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player: ""Mrs. Morgna assured me that she's a lock.""*)
  - -> `[223]` (*Player: ""Not yet, but we're working on it.""*)
  - -> `[224]` (*Player: ""Yes, she is supporting us.""*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == false && BaseG..."*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == false && Bas..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Frens Ricter: ""I know. And we can help you.""*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Frens Ricter: ""Isn't it funny how life works?""*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Frens Ricter: ""Look, Mr. Rayne...""*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Frens Ricter: ""Look, Mr. Rayne...""*)

### Węzeł `[152]`
Mówca: **Frens Ricter**
> ""I know. And we can help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Frens Ricter: ""But I do not find the proposal by any means sufficient.""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == false && BaseG..."*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == false && Bas..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Frens Ricter: ""While that's true, that shouldn't stop anyone from tryin..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Frens Ricter: ""While that's true, we cannot settle for 'just enough' wh..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == false && BaseG..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == false && Bas..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Frens Ricter: ""Maybe we can.""*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Frens Ricter: ""The only problem is... your proposal does not contain an..."*)

### Węzeł `[159]`
Mówca: **Frens Ricter**
> ""Isn't it funny how life works?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[160]`
Mówca: **Frens Ricter**
> ""While that's true, that shouldn't stop anyone from trying their best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Frens Ricter: ""That being said, I may be willing to support this propos..."*)

### Węzeł `[161]`
Mówca: **Frens Ricter**
> ""While that's true, we cannot settle for 'just enough' when we can achieve more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[162]`
Mówca: **Frens Ricter**
> ""Maybe we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Frens Ricter: ""But I do not find the proposal by any means sufficient.""*)

### Węzeł `[163]`
Mówca: **Frens Ricter**
> ""The only problem is... your proposal does not contain anything meaningful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[164]`
Mówca: **Frens Ricter**
> ""I'm not sure if that was a threat, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""Of course not.""*)
  - -> `[170]` (*Player: ""It was.""*)
  - -> `[171]` (*Player: ""I just know that you will do the right thing.""*)

### Węzeł `[165]`
Mówca: **Frens Ricter**
> ""That being said, I may be willing to support this proposal even though I don't find it sufficient. However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Frens Ricter: ""I'm still not sure what to make of it...""*)

### Węzeł `[166]`
Mówca: **Frens Ricter**
> ""But I do not find the proposal by any means sufficient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Frens Ricter: ""I'm still not sure what to make of it...""*)

### Węzeł `[167]`
Mówca: **Frens Ricter**
> ""But I do not find the proposal by any means sufficient.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Frens Ricter: ""I'm still not sure what to make of it...""*)

### Węzeł `[168]`
Mówca: **Frens Ricter**
> ""I'm still not sure what to make of it...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player: ""You're going to miss our chance for reforms just because..."*)
  - -> `[194]` (*Player: ""What are you thinking about?""*)
  - -> `[195]` (*Player: ""All you need to do is say yes.""*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""Of course not.""]** — Mówca: **Player**
> ""Of course not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == false && BaseG..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""It was.""]** — Mówca: **Player**
> ""It was.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "He repositioned himself on the couch."*)

### Węzeł `[171]`
**[WYBÓR GRACZA: ""I just know that you will do the right thing.""]** — Mówca: **Player**
> ""I just know that you will do the right thing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == false && BaseG..."*)

### Węzeł `[172]`
Mówca: **Frens Ricter**
> ""Is that so?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Frens Ricter: ""Look, Mr. President. I may be willing to give my support..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == false && BaseG..."*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == false && Bas..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Frens Ricter: ""Is that so?""*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Frens Ricter: ""Which is to push for real reform right after your inevit..."*)

### Węzeł `[176]`
Mówca: **Frens Ricter**
> ""Which is to push for real reform right after your inevitable political suicide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Frens Ricter: ""We have survived Tarquin Soll, surely we will survive yo..."*)

### Węzeł `[177]`
Mówca: **Frens Ricter**
> ""Look, Mr. Rayne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Frens Ricter: ""There is simply no way that we can support this.""*)

### Węzeł `[178]`
Mówca: **Frens Ricter**
> ""There is simply no way that we can support this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Frens Ricter: ""Let's not kid ourselves any longer. You're trying to des..."*)

### Węzeł `[179]`
Mówca: **Frens Ricter**
> ""Let's not kid ourselves any longer. You're trying to destroy the Old Guard only so you can take their place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player: ""There are no other plans. This was the most we could do ..."*)
  - -> `[204]` (*Player: ""Come on, Mr. Ricter. I'm sure we can agree on something.""*)
  - -> `[203]` (*Player: ""Don't make a mistake, Frens. You might regret it.""*)

### Węzeł `[180]`
Mówca: **Frens Ricter**
> ""Look, Mr. Rayne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Frens Ricter: ""There is simply no way that we can support this proposal.""*)

### Węzeł `[181]`
Mówca: **Frens Ricter**
> ""There is simply no way that we can support this proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Frens Ricter: ""Let's not kid ourselves any longer.""*)

### Węzeł `[182]`
Mówca: **Frens Ricter**
> ""Let's not kid ourselves any longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Frens Ricter: ""There is nothing in this for me or my party.""*)

### Węzeł `[183]`
Mówca: **Frens Ricter**
> ""There is nothing in this for me or my party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player: ""So you're looking for political gain after all.""*)
  - -> `[205]` (*Player: ""Come on, Mr. Ricter. I'm sure we can agree on something.""*)
  - -> `[200]` (*Player: ""Don't make a mistake, Frens. You might regret it.""*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Honorary_Presidents == false && BaseG..."*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Honorary_Presidents == false && Bas..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Frens Ricter: ""Look, Mr. President. I may be willing to give my support..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Honorary_Presidents == false && BaseGame.Reform_Law_Impeachment_Removed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false  and  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Frens Ricter: ""I'm sure it wasn't...""*)

### Węzeł `[187]`
Mówca: **Frens Ricter**
> ""Look, Mr. President. I may be willing to give my support to the proposal. But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Frens Ricter: ""I'm still not sure what to make of it...""*)

### Węzeł `[188]`
Mówca: **Frens Ricter**
> ""I'm sure it wasn't...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true"*)

### Węzeł `[189]`
Mówca: **Frens Ricter**
> ""Oh, good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Frens Ricter: ""Then I don't have to feel bad about watching you commit ..."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "He repositioned himself on the couch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Frens Ricter: ""Oh, good.""*)

### Węzeł `[191]`
Mówca: **Frens Ricter**
> ""Then I don't have to feel bad about watching you commit political suicide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Frens Ricter: ""We have survived Tarquin Soll, surely we will survive yo..."*)

### Węzeł `[192]`
Mówca: **Frens Ricter**
> ""We have survived Tarquin Soll, surely we will survive you as well. Don't expect me to be scared of your threats, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Frens Ricter: ""If there's nothing else you'd like to talk about, I'd li..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA: ""You're going to miss our chance for reforms just because they don't contain everything you want?""]** — Mówca: **Player**
> ""You're going to miss our chance for reforms just because they don't contain everything you want?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Frens Ricter: ""You're putting all the reformists in a tough spot like t..."*)

### Węzeł `[194]`
**[WYBÓR GRACZA: ""What are you thinking about?""]** — Mówca: **Player**
> ""What are you thinking about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Frens Ricter: ""You're putting all the reformists in a tough spot like t..."*)

### Węzeł `[195]`
**[WYBÓR GRACZA: ""All you need to do is say yes.""]** — Mówca: **Player**
> ""All you need to do is say yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Frens Ricter: ""That would be very useful, wouldn't it?""*)

### Węzeł `[196]`
Mówca: **Frens Ricter**
> ""You're putting all the reformists in a tough spot like this, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Frens Ricter: ""I'm sure it was tough to persuade your party to support ..."*)

### Węzeł `[197]`
Mówca: **Frens Ricter**
> ""I'm sure it was tough to persuade your party to support this proposal... But this is what happens when you expect the USP to bring change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Frens Ricter: ""Don't expect me to sympathize with you. Not only have yo..."*)

### Węzeł `[198]`
Mówca: **Frens Ricter**
> ""Don't expect me to sympathize with you. Not only have you minimized the potential of the reforms, you're taking the spotlight away from PFJP members who campaigned for these reforms for years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Frens Ricter: ""You'd better have something else to offer.""*)

### Węzeł `[199]`
Mówca: **Frens Ricter**
> ""That would be very useful, wouldn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Frens Ricter: ""You're putting all the reformists in a tough spot like t..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA: ""Don't make a mistake, Frens. You might regret it.""]** — Mówca: **Player**
> ""Don't make a mistake, Frens. You might regret it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Frens Ricter: ""I don't appreciate that talk.""*)

### Węzeł `[201]`
**[WYBÓR GRACZA: ""So you're looking for political gain after all.""]** — Mówca: **Player**
> ""So you're looking for political gain after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Frens Ricter: ""I value Sordland and democracy more than anything, Mr. P..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA: ""There are no other plans. This was the most we could do with the proposal.""]** — Mówca: **Player**
> ""There are no other plans. This was the most we could do with the proposal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Frens Ricter: ""Then it seems it's time that you accept that real change..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA: ""Don't make a mistake, Frens. You might regret it.""]** — Mówca: **Player**
> ""Don't make a mistake, Frens. You might regret it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Frens Ricter: ""I don't appreciate that talk.""*)

### Węzeł `[204]`
**[WYBÓR GRACZA: ""Come on, Mr. Ricter. I'm sure we can agree on something.""]** — Mówca: **Player**
> ""Come on, Mr. Ricter. I'm sure we can agree on something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Frens Ricter: ""I don't see anything to agree on. Your so called 'democr..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA: ""Come on, Mr. Ricter. I'm sure we can agree on something.""]** — Mówca: **Player**
> ""Come on, Mr. Ricter. I'm sure we can agree on something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Frens Ricter: ""I value Sordland and democracy more than anything, Mr. P..."*)

### Węzeł `[206]`
Mówca: **Frens Ricter**
> ""I don't appreciate that talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Frens Ricter: ""We have survived Tarquin Soll, surely we will survive yo..."*)

### Węzeł `[207]`
Mówca: **Frens Ricter**
> ""I don't see anything to agree on. Your so called 'democratic reforms' will not silence the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Frens Ricter: ""It is time to finally accept that real change will never..."*)

### Węzeł `[208]`
Mówca: **Frens Ricter**
> ""Then it seems it's time that you accept that real change will not come from the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Frens Ricter: ""If you really wanted change, you would have pushed for i..."*)

### Węzeł `[209]`
Mówca: **Frens Ricter**
> ""If you really wanted change, you would have pushed for it. You are accepting failure without even trying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Frens Ricter: ""I am sorry to disappoint you, but you'll find no support..."*)

### Węzeł `[210]`
Mówca: **Frens Ricter**
> ""It is time to finally accept that real change will never come from the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Frens Ricter: ""I am sorry to disappoint you, but you'll find no support..."*)

### Węzeł `[211]`
Mówca: **Frens Ricter**
> ""I am sorry to disappoint you, but you'll find no support from me or my fellow reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Frens Ricter: ""If there's nothing else you'd like to talk about, I'd li..."*)

### Węzeł `[212]`
**[WYBÓR GRACZA: ""So you're looking for political gain after all...""]** — Mówca: **Player**
> ""So you're looking for political gain after all...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Frens Ricter: ""I value Sordland and democracy more than anything, Mr. P..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA: ""Oh, is the idealist reformist asking for a bribe?""]** — Mówca: **Player**
> ""Oh, is the idealist reformist asking for a bribe?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Frens Ricter: ""Who said anything about a bribe?""*)

### Węzeł `[214]`
Mówca: **Frens Ricter**
> ""You'd better have something else to offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: ""So you're looking for political gain after all...""*)
  - -> `[213]` (*Player: ""Oh, is the idealist reformist asking for a bribe?""*)
  - -> `[215]` (*Player: ""I have nothing to offer but democracy...""*)
  - -> `[216]` (*Player: ""I'm sure you have something in mind.""*)

### Węzeł `[215]`
**[WYBÓR GRACZA: ""I have nothing to offer but democracy...""]** — Mówca: **Player**
> ""I have nothing to offer but democracy...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Frens Ricter: ""You're still going to use that word?""*)

### Węzeł `[216]`
**[WYBÓR GRACZA: ""I'm sure you have something in mind.""]** — Mówca: **Player**
> ""I'm sure you have something in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Frens Ricter: ""I value Sordland and democracy more than anything, Mr. P..."*)

### Węzeł `[217]`
Mówca: **Frens Ricter**
> ""I value Sordland and democracy more than anything, Mr. President. And I also have to look out for myself and my party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Frens Ricter: ""Surely you understand.""*)

### Węzeł `[218]`
Mówca: **Frens Ricter**
> ""Surely you understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[219]`
Mówca: **Frens Ricter**
> ""Who said anything about a bribe?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Frens Ricter: ""I value Sordland and democracy more than anything, Mr. P..."*)

### Węzeł `[220]`
Mówca: **Frens Ricter**
> ""You're still going to use that word?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Frens Ricter: ""I value Sordland and democracy more than anything, Mr. P..."*)

### Węzeł `[221]`
Mówca: **Frens Ricter**
> ""If there's nothing else you'd like to talk about, I'd like to get going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: ""I'm sorry, Mr. Ricter. I'm sure we can still agree on so..."*)
  - -> `[283]` (*Player: ""You're not going anywhere before we have a deal.""*)
  - -> `[284]` (*Player: ""You're free to do as you want, Mr. Ricter.""*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""Mrs. Morgna assured me that she's a lock.""]** — Mówca: **Player**
> ""Mrs. Morgna assured me that she's a lock.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Frens Ricter: ""I respect the Minister of Justice. If she's sure about t..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""Not yet, but we're working on it.""]** — Mówca: **Player**
> ""Not yet, but we're working on it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Frens Ricter: ""You can't afford to fail this.""*)

### Węzeł `[224]`
**[WYBÓR GRACZA: ""Yes, she is supporting us.""]** — Mówca: **Player**
> ""Yes, she is supporting us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[145]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Frens Ricter: ""That's good news.""*)

### Węzeł `[225]`
Mówca: **Frens Ricter**
> ""If we're doing this, we have to make it count.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Frens Ricter: ""I hope that you will succeed, Mr. Rayne. I respect what ..."*)

### Węzeł `[226]`
Mówca: **Frens Ricter**
> ""I respect the Minister of Justice. If she's sure about this, I believe we might actually have a chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Frens Ricter: ""I hope that you will succeed, Mr. Rayne. I respect what ..."*)

### Węzeł `[227]`
Mówca: **Frens Ricter**
> ""You can't afford to fail this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Frens Ricter: ""I hope that you will succeed, Mr. Rayne. I respect what ..."*)

### Węzeł `[228]`
Mówca: **Frens Ricter**
> ""That's good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Frens Ricter: ""I hope that you will succeed, Mr. Rayne. I respect what ..."*)

### Węzeł `[229]`
Mówca: **Frens Ricter**
> ""I hope that you will succeed, Mr. Rayne. I respect what you're doing inside the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Frens Ricter: ""I will do my best to flip the Supreme Court as well. You..."*)

### Węzeł `[230]`
Mówca: **Frens Ricter**
> ""And if we're talking about democracy here... I first need your promise that you're not going to cast a shadow over the PFJP anymore. You will give us proper credit and finally do something about the unbalanced representation of our party on state television.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player: ""Of course, Mr. Ricter. You can count on me.""*)
  - -> `[231]` (*Player: ""I don't think there's unbalanced representation.""*)
  - -> `[232]` (*Player: ""I can't promise you anything out of my control.""*)

### Węzeł `[231]`
**[WYBÓR GRACZA: ""I don't think there's unbalanced representation.""]** — Mówca: **Player**
> ""I don't think there's unbalanced representation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Frens Ricter: ""Mr. President, I thought we've been through this...""*)

### Węzeł `[232]`
**[WYBÓR GRACZA: ""I can't promise you anything out of my control.""]** — Mówca: **Player**
> ""I can't promise you anything out of my control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Frens Ricter: ""Mr. President, I thought we've been through this...""*)

### Węzeł `[233]`
**[WYBÓR GRACZA: ""Of course, Mr. Ricter. You can count on me.""]** — Mówca: **Player**
> ""Of course, Mr. Ricter. You can count on me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Frens Ricter: ""That's good to hear.""*)

### Węzeł `[234]`
Mówca: **Frens Ricter**
> ""Mr. President, I thought we've been through this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Frens Ricter: ""Your party has spent decades trying to keep my party fro..."*)

### Węzeł `[235]`
Mówca: **Frens Ricter**
> ""Your party has spent decades trying to keep my party from gaining significance. If we are to be on the same side...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Frens Ricter: ""...We expect you to properly acknowledge the wrongs that..."*)

### Węzeł `[236]`
Mówca: **Frens Ricter**
> ""...We expect you to properly acknowledge the wrongs that have been done, and finally act against the Sollist state apparatus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Player: ""You're right. You can count on my support.""*)
  - -> `[237]` (*Player: ""I can't deny the wrongdoing. But there's nothing I can d..."*)
  - -> `[239]` (*Player: ""Do not blame the state. It was the people who elected th..."*)

### Węzeł `[237]`
**[WYBÓR GRACZA: ""I can't deny the wrongdoing. But there's nothing I can do about it.""]** — Mówca: **Player**
> ""I can't deny the wrongdoing. But there's nothing I can do about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == false && BaseGam..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA: ""You're right. You can count on my support.""]** — Mówca: **Player**
> ""You're right. You can count on my support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Frens Ricter: ""That's good to hear.""*)

### Węzeł `[239]`
**[WYBÓR GRACZA: ""Do not blame the state. It was the people who elected the USP.""]** — Mówca: **Player**
> ""Do not blame the state. It was the people who elected the USP.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Frens Ricter: ""It seems we will not be seeing eye to eye.""*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == false && BaseGame.Reform_Law_Ministers_Default == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Threshold_Default == false && BaseGam..."*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Threshold_Default == false && BaseG..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Threshold_Default == false && BaseGame.Reform_Law_Ministers_Default == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Frens Ricter: ""Mr. President... We just want proper credit.""*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Threshold_Default == false && BaseGame.Reform_Law_Ministers_Default == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == false  and  Variable["BaseGame.Reform_Law_Ministers_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Frens Ricter: ""It seems we will not be seeing eye to eye.""*)

### Węzeł `[243]`
Mówca: **Frens Ricter**
> ""Mr. President... We just want proper credit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player: ""Of course, Mr. Ricter. Your support will not go unnoticed.""*)
  - -> `[247]` (*Player: ""You deserve no credit. You're still beating around the b..."*)

### Węzeł `[244]`
Mówca: **Frens Ricter**
> ""It seems we will not be seeing eye to eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Frens Ricter: ""I'd rather get going before it's too late, Mr. President..."*)

### Węzeł `[245]`
Mówca: **Frens Ricter**
> ""That's good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == false || BaseG..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Of course, Mr. Ricter. Your support will not go unnoticed.""]** — Mówca: **Player**
> ""Of course, Mr. Ricter. Your support will not go unnoticed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Frens Ricter: ""I should hope not.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA: ""You deserve no credit. You're still beating around the bush with no real intention of support.""]** — Mówca: **Player**
> ""You deserve no credit. You're still beating around the bush with no real intention of support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Frens Ricter: ""It seems we will not be seeing eye to eye.""*)

### Węzeł `[248]`
Mówca: **Frens Ricter**
> ""I should hope not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == false || BaseG..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Honorary_Presidents == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == false || BaseG..."*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == false || Bas..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Honorary_Presidents == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Frens Ricter: ""Then I can say that I'll be happy to cooperate with you,..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == false || BaseGame.Reform_Law_Honorary_Presidents == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  or  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Frens Ricter: ""In any case... It will be very tough to persuade my part..."*)

### Węzeł `[252]`
Mówca: **Frens Ricter**
> ""Then I can say that I'll be happy to cooperate with you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Frens Ricter: ""I will hold you to your promise.""*)

### Węzeł `[253]`
Mówca: **Frens Ricter**
> ""In any case... It will be very tough to persuade my party with such a proposal. The reformists are not happy with how things developed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Frens Ricter: ""Even in the case of success, we have very little to gain..."*)

### Węzeł `[254]`
Mówca: **Frens Ricter**
> ""Even in the case of success, we have very little to gain from this. Do you have anything else to offer, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Frens Ricter: ""We are talking about a lot of votes here... for somethin..."*)

### Węzeł `[255]`
Mówca: **Frens Ricter**
> ""We are talking about a lot of votes here... for something that will shape the future of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player: ""Tell me what you want.""*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[315]` (*Player: ""You damn corrupt bastard.""*)

### Węzeł `[256]`
Mówca: **Frens Ricter**
> ""I will do my best to flip the Supreme Court as well. You can count on the PFJP's votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Frens Ricter: ""I just want your promise that you will give us proper cr..."*)

### Węzeł `[257]`
Mówca: **Frens Ricter**
> ""I just want your promise that you will give us proper credit and finally do something about the unbalanced representation of our party on state television.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Frens Ricter: ""For decades, your party has been doing whatever it could..."*)

### Węzeł `[258]`
Mówca: **Frens Ricter**
> ""For decades, your party has been doing whatever it could to stay in power while keeping the PFJP silenced. If we're to be on the same side...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Frens Ricter: ""...I expect you to finally acknowledge all the wrongs th..."*)

### Węzeł `[259]`
Mówca: **Frens Ricter**
> ""...I expect you to finally acknowledge all the wrongs that have been done, and act against the Sollist state apparatus in full force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player: ""Of course, we're in this together.""*)
  - -> `[261]` (*Player: ""Of course I can't deny my party's disreputable actions.""*)
  - -> `[262]` (*Player: ""Do not blame the USP. Sordland has gone through a lot.""*)

### Węzeł `[260]`
**[WYBÓR GRACZA: ""Of course, we're in this together.""]** — Mówca: **Player**
> ""Of course, we're in this together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Frens Ricter: ""That's great to hear.""*)

### Węzeł `[261]`
**[WYBÓR GRACZA: ""Of course I can't deny my party's disreputable actions.""]** — Mówca: **Player**
> ""Of course I can't deny my party's disreputable actions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Frens Ricter: ""I respect your honesty, Mr. President.""*)

### Węzeł `[262]`
**[WYBÓR GRACZA: ""Do not blame the USP. Sordland has gone through a lot.""]** — Mówca: **Player**
> ""Do not blame the USP. Sordland has gone through a lot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Frens Ricter: ""Whatever you say, Mr. President. As long as you do somet..."*)

### Węzeł `[263]`
Mówca: **Frens Ricter**
> ""Whatever you say, Mr. President. As long as you do something about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Frens Ricter: ""I hope I can rely on you. In the upcoming vote, we expec..."*)

### Węzeł `[264]`
Mówca: **Frens Ricter**
> ""I respect your honesty, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Frens Ricter: ""I hope I can rely on you. In the upcoming vote, we expec..."*)

### Węzeł `[265]`
Mówca: **Frens Ricter**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Frens Ricter: ""I hope I can rely on you. In the upcoming vote, we expec..."*)

### Węzeł `[266]`
Mówca: **Frens Ricter**
> ""I hope I can rely on you. In the upcoming vote, we expect the USP to rally behind your proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Frens Ricter: ""I can assure you, you'll have the PFJP's full support.""*)

### Węzeł `[267]`
Mówca: **Frens Ricter**
> ""I can assure you, you'll have the PFJP's full support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player: ""The USP will not be a problem. With your support, these ..."*)
  - -> `[269]` (*Player: ""I'm happy to cooperate with you, Mr. Ricter.""*)
  - -> `[270]` (*Player: ""Don't doubt it. We'll change the Constitution together.""*)

### Węzeł `[268]`
**[WYBÓR GRACZA: ""The USP will not be a problem. With your support, these reforms will pass.""]** — Mówca: **Player**
> ""The USP will not be a problem. With your support, these reforms will pass.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Frens Ricter: ""I'm looking forward to it.""*)

### Węzeł `[269]`
**[WYBÓR GRACZA: ""I'm happy to cooperate with you, Mr. Ricter.""]** — Mówca: **Player**
> ""I'm happy to cooperate with you, Mr. Ricter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Frens Ricter: ""Likewise, Mr. Rayne.""*)

### Węzeł `[270]`
**[WYBÓR GRACZA: ""Don't doubt it. We'll change the Constitution together.""]** — Mówca: **Player**
> ""Don't doubt it. We'll change the Constitution together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Frens Ricter: ""I'm looking forward to it.""*)

### Węzeł `[271]`
Mówca: **Frens Ricter**
> ""Likewise, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Frens Ricter: ""Was there anything else?""*)

### Węzeł `[272]`
Mówca: **Frens Ricter**
> ""I'm looking forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Frens Ricter: ""Was there anything else?""*)

### Węzeł `[273]`
Mówca: **Frens Ricter**
> ""I'm looking forward to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Frens Ricter: ""Was there anything else?""*)

### Węzeł `[274]`
Mówca: **Frens Ricter**
> ""Was there anything else?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player: ""No, Mr. Ricter. Thank you for coming. I'm looking forwar..."*)
  - -> `[276]` (*Player: ""Before you leave, I'd like to address a few things I've ..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA: ""No, Mr. Ricter. Thank you for coming. I'm looking forward to our cooperation.""]** — Mówca: **Player**
> ""No, Mr. Ricter. Thank you for coming. I'm looking forward to our cooperation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "We shook hands."*)

### Węzeł `[276]`
**[WYBÓR GRACZA: ""Before you leave, I'd like to address a few things I've heard about you.""]** — Mówca: **Player**
> ""Before you leave, I'd like to address a few things I've heard about you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Frens Ricter: ""There are so many 'things' said about me that I can't ke..."*)

### Węzeł `[277]`
Mówca: **Frens Ricter**
> ""There are so many 'things' said about me that I can't keep track of them anymore. What exactly do you mean?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Player: ""I received intelligence that you made a deal with Arcasi..."*)
  - -> `[382]` (*Player: ""Do you have some sort of secret partnership with Preside..."*)

### Węzeł `[278]`
Mówca: **Frens Ricter**
> ""It's nice to have a president that we can finally have a dialogue with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "He laughed."*)

### Węzeł `[279]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Frens Ricter: ""It's nice to have a president that we can finally have a..."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Frens Ricter: ""I'll see you in the history books. Have a nice evening f..."*)

### Węzeł `[281]`
Mówca: **Frens Ricter**
> ""I'll see you in the history books. Have a nice evening for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "He left the room."*)

### Węzeł `[282]`
**[WYBÓR GRACZA: ""I'm sorry, Mr. Ricter. I'm sure we can still agree on something.""]** — Mówca: **Player**
> ""I'm sorry, Mr. Ricter. I'm sure we can still agree on something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == false"*)

### Węzeł `[283]`
**[WYBÓR GRACZA: ""You're not going anywhere before we have a deal.""]** — Mówca: **Player**
> ""You're not going anywhere before we have a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Frens Ricter: ""Please calm down, Mr. President. You're making a fool of..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA: ""You're free to do as you want, Mr. Ricter.""]** — Mówca: **Player**
> ""You're free to do as you want, Mr. Ricter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Frens Ricter: ""Then I'll be leaving, Mr. President.""*)

### Węzeł `[285]`
Mówca: **Frens Ricter**
> ""Then I'll be leaving, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Frens Ricter: ""Thank you for the meeting.""*)

### Węzeł `[286]`
Mówca: **Frens Ricter**
> ""Thank you for the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Frens Ricter: ""Good luck in the Assembly.""*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Impeachment_Removed == false"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Impeachment_Removed == false)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Impeachment_Removed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Frens Ricter: ""Well...""*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Impeachment_Removed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Frens Ricter: ""There's nothing to agree on. This proposal is designed t..."*)

### Węzeł `[290]`
Mówca: **Frens Ricter**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true &..."*)

### Węzeł `[291]`
Mówca: **Frens Ricter**
> ""Please calm down, Mr. President. You're making a fool of yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "He stood up."*)

### Węzeł `[292]`
Mówca: **Frens Ricter**
> ""There's nothing to agree on. This proposal is designed to give you more power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "He stood up."*)

### Węzeł `[293]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Frens Ricter: ""It's getting late. I must be going.""*)

### Węzeł `[294]`
Mówca: **Frens Ricter**
> ""It's getting late. I must be going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Frens Ricter: ""Good luck in the Assembly.""*)

### Węzeł `[295]`
Mówca: **Frens Ricter**
> ""I'd rather get going before it's too late, Mr. President. I think our meeting is over anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "He stood up and offered his hand."*)

### Węzeł `[296]`
Mówca: **Frens Ricter**
> ""Good luck in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "He left the room."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "He left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_A_Reform = true; BaseGameSupport.New..."*)

### Węzeł `[298]`
Mówca: **Narrator**
> "He stood up and offered his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Player_Italic: "Shake his hand."*)
  - -> `[300]` (*Player_Italic: "Don't shake his hand."*)

### Węzeł `[299]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "I shook his hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Frens Ricter: ""Good luck in the Assembly, Mr. President. Have a good ev..."*)

### Węzeł `[300]`
**[WYBÓR GRACZA: "Don't shake his hand."]** — Mówca: **Player_Italic**
> "I ignored it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Frens Ricter: ""Good luck in the Assembly, Mr. President. Have a good ev..."*)

### Węzeł `[301]`
Mówca: **Narrator**
> "He left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_A_Reform = true; BaseGameSupport.New..."*)

### Węzeł `[302]`
Mówca: **Frens Ricter**
> ""Good luck in the Assembly, Mr. President. Have a good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "He left the room."*)

### Węzeł `[303]`
Mówca: **Narrator**
> "He left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced = true"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_A_Reform = true; BaseGameSupport.New..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Honorary_Presidents == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Judges_Impeachment_Assembly == true &..."*)
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Honorary_Presidents == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Frens Ricter: ""There's nothing to agree on. This proposal is designed t..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true && BaseGame.Reform_Law_Honorary_Presidents == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Frens Ricter: ""I value Sordland and democracy more than anything, Mr. P..."*)

### Węzeł `[308]`
Mówca: **Frens Ricter**
> ""I will hold you to your promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player: ""Of course.""*)
  - -> `[310]` (*Player: ""And I'll hold you to yours.""*)
  - -> `[311]` (*Player: ""I'm happy to cooperate with you too.""*)

### Węzeł `[309]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[308]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "Jump to: [PersuadedRicter]"*)

### Węzeł `[310]`
**[WYBÓR GRACZA: ""And I'll hold you to yours.""]** — Mówca: **Player**
> ""And I'll hold you to yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[308]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "Jump to: [PersuadedRicter]"*)

### Węzeł `[311]`
**[WYBÓR GRACZA: ""I'm happy to cooperate with you too.""]** — Mówca: **Player**
> ""I'm happy to cooperate with you too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[308]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "Jump to: [PersuadedRicter]"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [PersuadedRicter]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "PersuadedRicter"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PersuadedRicter`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Frens Ricter: ""Was there anything else?""*)

### Węzeł `[314]`
**[WYBÓR GRACZA: ""Tell me what you want.""]** — Mówca: **Player**
> ""Tell me what you want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_NoInvestment == true"*)

### Węzeł `[315]`
**[WYBÓR GRACZA: ""You damn corrupt bastard.""]** — Mówca: **Player**
> ""You damn corrupt bastard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Narrator: "He did not reply."*)

### Węzeł `[316]`
**[WYBÓR GRACZA: ""Nothing a check addressed to your name couldn't handle." [Bribe Offer -1 Personal Wealth]"]** — Mówca: **Player**
> ""Nothing a check addressed to your name couldn't handle.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[255]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Frens Ricter: ""Now you've got my attention.""*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth >= 1)"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Player: ""Nothing a check addressed to your name couldn't handle."..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[320]`
Mówca: **Frens Ricter**
> ""A company that I'm involved with, Taurus Holding, has been conducting research on new machines for construction megaprojects and created a construction force that's unmatched in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Frens Ricter: ""They have a great track record with efficiency and high-..."*)

### Węzeł `[321]`
Mówca: **Frens Ricter**
> ""They have a great track record with efficiency and high-quality materials. They have been waiting for a large project to show their capabilities and definitely have the potential to be a leading brand in the world if the state decides to support it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Frens Ricter: ""I'd like you to give them a chance with the next state p..."*)

### Węzeł `[322]`
Mówca: **Frens Ricter**
> ""I'd like you to give them a chance with the next state project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Player: ""Consider it done.""*)
  - -> `[323]` (*Player: ""I can't do that.""*)

### Węzeł `[323]`
**[WYBÓR GRACZA: ""I can't do that.""]** — Mówca: **Player**
> ""I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[322]` (Frens Ricter), `[445]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Frens Ricter: ""It's a shame things won't work out between us.""*)

### Węzeł `[324]`
**[WYBÓR GRACZA: ""Consider it done.""]** — Mówca: **Player**
> ""Consider it done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[322]` (Frens Ricter), `[445]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Taurus = true"*)

### Węzeł `[325]`
Mówca: **Frens Ricter**
> ""It's a shame things won't work out between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[343]` (*Player: ""I can try to give you a cabinet position.""*)
  - -> `[345]` (*Player: ""There won't be any deals.""*)

### Węzeł `[326]`
Mówca: **Narrator**
> "He did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Player: ""Okay, tell me what you want.""*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[332]` (*Player: ""I can't give you anything else.""*)

### Węzeł `[327]`
**[WYBÓR GRACZA: ""Okay, tell me what you want.""]** — Mówca: **Player**
> ""Okay, tell me what you want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_NoInvestment == true"*)

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Okay, how about a few checks addressed to your name then?" [BRIBE, -1 Personal Wealth]"]** — Mówca: **Player**
> ""Okay, how about a few checks addressed to your name then?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[326]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Frens Ricter: ""Now you've got my attention.""*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth >= 1)"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Player: ""Okay, how about a few checks addressed to your name then..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[332]`
**[WYBÓR GRACZA: ""I can't give you anything else.""]** — Mówca: **Player**
> ""I can't give you anything else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Frens Ricter: ""I see.""*)

### Węzeł `[333]`
Mówca: **Frens Ricter**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Frens Ricter: ""Then I think I can't promise you in persuading all my pe..."*)

### Węzeł `[334]`
Mówca: **Frens Ricter**
> ""Now you've got my attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "After some back-and-forth, we agreed on a sum and decided..."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "After some back-and-forth, we agreed on a sum and decided how to transfer it. Frens shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth -= 1"*)

### Węzeł `[336]`
Mówca: **Frens Ricter**
> ""I'm glad we were able to cooperate, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Frens Ricter: ""I'll do my best to gather the support of my party.""*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Frens Ricter: ""I'm glad we were able to cooperate, Mr. President.""*)

### Węzeł `[338]`
Mówca: **Frens Ricter**
> ""Then I think I can't promise you in persuading all my people. It's a tough job, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Frens Ricter: ""It seems we will not be seeing eye to eye.""*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth >= 1)"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Player: ""Nothing a check worth close to a million couldn't handle..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[342]`
**[WYBÓR GRACZA: ""Nothing a check worth close to a million couldn't handle." [BRIBE, -1 Personal Wealth]"]** — Mówca: **Player**
> ""Nothing a check worth a million couldn't handle.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[325]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Frens Ricter: ""Now you've got my attention.""*)

### Węzeł `[343]`
**[WYBÓR GRACZA: ""I can try to give you a cabinet position.""]** — Mówca: **Player**
> ""I can try to give you a cabinet position.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Frens Ricter: ""Are you joking?""*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Taurus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Frens_Promise_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Frens Ricter: ""...Then you have the support of the PFJP, Mr. Rayne.""*)

### Węzeł `[345]`
**[WYBÓR GRACZA: ""There won't be any deals.""]** — Mówca: **Player**
> ""There won't be any deals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Frens Ricter: ""I see.""*)

### Węzeł `[346]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "Jump to: [PersuadedRicter]"*)

### Węzeł `[347]`
Mówca: **Frens Ricter**
> ""I will hold you to your promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Player: ""Of course.""*)
  - -> `[349]` (*Player: ""And I'll hold you to yours.""*)
  - -> `[350]` (*Player: ""I'm happy to have reached a deal.""*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [PersuadedRicter]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "PersuadedRicter"*)

### Węzeł `[349]`
**[WYBÓR GRACZA: ""And I'll hold you to yours.""]** — Mówca: **Player**
> ""And I'll hold you to yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "Jump to: [PersuadedRicter]"*)

### Węzeł `[350]`
**[WYBÓR GRACZA: ""I'm happy to have reached a deal.""]** — Mówca: **Player**
> ""I'm happy to have reached a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[347]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "Jump to: [PersuadedRicter]"*)

### Węzeł `[351]`
Mówca: **Frens Ricter**
> ""...Then you have the support of the PFJP, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Frens Ricter: ""I will hold you to your promise.""*)

### Węzeł `[352]`
Mówca: **Frens Ricter**
> ""I'll do my best to gather the support of my party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Player: ""That's great to hear.""*)
  - -> `[356]` (*Player: ""Likewise, Mr. Ricter. I like this cooperative spirit.""*)
  - -> `[353]` (*Player: ""I'm happy to have gotten to know the real you, Frens.""*)

### Węzeł `[353]`
**[WYBÓR GRACZA: ""I'm happy to have gotten to know the real you, Frens.""]** — Mówca: **Player**
> ""I'm happy to have gotten to know the real you, Frens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed = true"*)

### Węzeł `[354]`
**[WYBÓR GRACZA: ""That's great to hear.""]** — Mówca: **Player**
> ""That's great to hear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed = true"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [PersuadedRicter]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "PersuadedRicter"*)

### Węzeł `[356]`
**[WYBÓR GRACZA: ""Likewise, Mr. Ricter. I like this cooperative spirit.""]** — Mówca: **Player**
> ""Likewise, Mr. Ricter. I like this cooperative spirit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed = true"*)

### Węzeł `[357]`
Mówca: **Frens Ricter**
> ""Are you joking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player: ""No. There may be some vacancies sooner or later.""*)
  - -> `[359]` (*Player: ""I can try and force someone to resign.""*)
  - -> `[360]` (*Player: ""Obviously.""*)

### Węzeł `[358]`
**[WYBÓR GRACZA: ""No. There may be some vacancies sooner or later.""]** — Mówca: **Player**
> ""No. There may be some vacancies sooner or later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Frens Ricter: ""I can't believe that you'd offer such a thing.""*)

### Węzeł `[359]`
**[WYBÓR GRACZA: ""I can try and force someone to resign.""]** — Mówca: **Player**
> ""I can try and force someone to resign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Frens Ricter: ""I can't believe that you'd offer such a thing.""*)

### Węzeł `[360]`
**[WYBÓR GRACZA: ""Obviously.""]** — Mówca: **Player**
> ""Obviously.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "He did not reply."*)

### Węzeł `[361]`
Mówca: **Narrator**
> "He did not reply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[366]` (*Player: ""It seems there won't be any deals.""*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 1"*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth >= 1)"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Player: ""Okay, how about a few checks?" [BRIBE]"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[365]`
**[WYBÓR GRACZA: ""Okay, how about a few checks?" [BRIBE]"]** — Mówca: **Player**
> ""Okay, how about a few checks?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Kontekst wejściowy (poprzednik):** `[361]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Frens Ricter: ""Now you've got my attention.""*)

### Węzeł `[366]`
**[WYBÓR GRACZA: ""It seems there won't be any deals.""]** — Mówca: **Player**
> ""It seems there won't be any deals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[361]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Frens Ricter: ""So it seems.""*)

### Węzeł `[367]`
Mówca: **Frens Ricter**
> ""So it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Frens Ricter: ""It seems we will not be seeing eye to eye.""*)

### Węzeł `[368]`
Mówca: **Frens Ricter**
> ""I can't believe that you'd offer such a thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Frens Ricter: ""But all right. Here's what I'll say.""*)

### Węzeł `[369]`
Mówca: **Frens Ricter**
> ""But all right. Here's what I'll say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Frens Ricter: ""I'll try my best to convince my people to support this p..."*)

### Węzeł `[370]`
Mówca: **Frens Ricter**
> ""I'll try my best to convince my people to support this proposal, even though they have their problems with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Frens Ricter: ""I can't promise you full support. But then, you can't pr..."*)

### Węzeł `[371]`
Mówca: **Frens Ricter**
> ""I can't promise you full support. But then, you can't promise me anything either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Frens Ricter: ""If everything works out, I'll expect you to at least try..."*)

### Węzeł `[372]`
Mówca: **Frens Ricter**
> ""If everything works out, I'll expect you to at least try to fulfil your promise. If you can give me a cabinet position after we enact the reforms, I'd be a great partner to have inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Player: ""Sounds good.""*)
  - -> `[374]` (*Player: ""I promise I'll figure something out.""*)
  - -> `[375]` (*Player: ""I'll do my best.""*)
  - -> `[376]` (*Player: ""Finally! Thanks for the support.""*)

### Węzeł `[373]`
**[WYBÓR GRACZA: ""Sounds good.""]** — Mówca: **Player**
> ""Sounds good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Frens Ricter: ""Great. Then we have a deal.""*)

### Węzeł `[374]`
**[WYBÓR GRACZA: ""I promise I'll figure something out.""]** — Mówca: **Player**
> ""I promise I'll figure something out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Frens Ricter: ""Great. Then we have a deal.""*)

### Węzeł `[375]`
**[WYBÓR GRACZA: ""I'll do my best.""]** — Mówca: **Player**
> ""I'll do my best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Frens Ricter: ""Great. Then we have a deal.""*)

### Węzeł `[376]`
**[WYBÓR GRACZA: ""Finally! Thanks for the support.""]** — Mówca: **Player**
> ""Finally! Thanks for the support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[372]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Frens Ricter: ""Great. Then we have a deal.""*)

### Węzeł `[377]`
Mówca: **Frens Ricter**
> ""Great. Then we have a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Seat = true"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [PersuadedRicter]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "PersuadedRicter"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Seat = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Frens_Promise_Seat"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "Jump to: [PersuadedRicter]"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_A_Reform = true;
BaseGameSupport.News_Turn06_ST_RayneMeetsRicter = true;`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_A_Reform"] = true;
Variable["BaseGameSupport.News_Turn06_ST_RayneMeetsRicter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true"*)

### Węzeł `[381]`
**[WYBÓR GRACZA: ""I received intelligence that you made a deal with Arcasia and that you tried covering your tracks. What do you have to say about that?""]** — Mówca: **Player**
> ""I received intelligence that you made a deal with Arcasia and that you tried covering your tracks. What do you have to say about that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Frens Ricter: ""Oh, it did come to that, after all... Well, I will enlig..."*)

### Węzeł `[382]`
**[WYBÓR GRACZA: ""Do you have some sort of secret partnership with President Dwight Walker? There are rumors about his influence on you.""]** — Mówca: **Player**
> ""Do you have some sort of secret partnership with President Dwight Walker? There are rumors about his influence on you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Frens Ricter: ""Because I've met with Walker before? I am the leader of ..."*)

### Węzeł `[383]`
Mówca: **Frens Ricter**
> ""Oh, it did come to that, after all... Well, I will enlighten you about my relationship with Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Frens Ricter: ""As you know, the downfall of President Alphonso was abru..."*)

### Węzeł `[384]`
Mówca: **Frens Ricter**
> ""Because I've met with Walker before? I am the leader of Sordland's largest opposition party and free to visit anyone I please. But since you asked, I will explain the context of our relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Frens Ricter: ""As you know, the downfall of President Alphonso was abru..."*)

### Węzeł `[385]`
Mówca: **Frens Ricter**
> ""As you know, the downfall of President Alphonso was abrupt. He was the only progressive hope we had in the USP. Our brief alliance with him accomplished great things, but we ran into a very concerning revelation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Frens Ricter: ""In our last meeting before the USP abandoned him, Presid..."*)

### Węzeł `[386]`
**[WYBÓR GRACZA: ""Wait. What are you trying to say?""]** — Mówca: **Player**
> ""Wait. What are you trying to say?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Frens Ricter: ""I am trying to say that everything leading up to the 195..."*)

### Węzeł `[387]`
Mówca: **Frens Ricter**
> ""In our last meeting before the USP abandoned him, President Alphonso said that Soll was not gone and still pulled the strings behind his back. He was suspicious about a conspiracy against his reformist agenda and he feared everything would collapse around him...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Frens Ricter: ""...And it did. Afterwards the party voted you in. I don'..."*)

### Węzeł `[388]`
Mówca: **Frens Ricter**
> ""...And it did. Afterwards the party voted you in. I don't think it was a coincidence, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Player: ""Wait. What are you trying to say?""*)
  - -> `[389]` (*Player: ""You think Soll and the Old Guard orchestrated all of this?""*)
  - -> `[404]` (*Player: ""You're saying I was elected because Soll wanted it?""*)

### Węzeł `[389]`
**[WYBÓR GRACZA: ""You think Soll and the Old Guard orchestrated all of this?""]** — Mówca: **Player**
> ""You think Soll and the Old Guard orchestrated all of this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Frens Ricter: ""Yes. They knew that Alphonso's reforms would cripple the..."*)

### Węzeł `[390]`
**[WYBÓR GRACZA: ""Act how?""]** — Mówca: **Player**
> ""Act how?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Frens Ricter: ""I was contacted by an Arcasian senator and one of Arcasi..."*)

### Węzeł `[391]`
Mówca: **Frens Ricter**
> ""I am trying to say that everything leading up to the 1953 election was orchestrated by the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Frens Ricter: ""After realizing the true extent of the Sollist deep stat..."*)

### Węzeł `[392]`
Mówca: **Frens Ricter**
> ""Yes. They knew that Alphonso's reforms would cripple their strength and remove them from power... So they removed him first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Frens Ricter: ""After realizing the true extent of the Sollist deep stat..."*)

### Węzeł `[393]`
Mówca: **Frens Ricter**
> ""After realizing the true extent of the Sollist deep state's influence, I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Narrator: "He looked down for a second and continued."*)

### Węzeł `[394]`
Mówca: **Frens Ricter**
> ""We are in this together, so I will be honest. I lost hope that Sordland could ever achieve the liberties and democracy that I'd been working so hard for as long as Sollism was still alive and well. So I decided to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Player: ""Act how?""*)
  - -> `[396]` (*Player: ""I hope you didn't do anything to compromise our country.""*)
  - -> `[406]` (*Player: ""I don't like where this is going.""*)

### Węzeł `[395]`
Mówca: **Narrator**
> "He looked down for a second and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Frens Ricter: ""We are in this together, so I will be honest. I lost hop..."*)

### Węzeł `[396]`
**[WYBÓR GRACZA: ""I hope you didn't do anything to compromise our country.""]** — Mówca: **Player**
> ""I hope you didn't do anything to compromise our country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Frens Ricter: ""Of course not.""*)

### Węzeł `[397]`
Mówca: **Frens Ricter**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Frens Ricter: ""I was contacted by an Arcasian senator and one of Arcasi..."*)

### Węzeł `[398]`
Mówca: **Frens Ricter**
> ""I was contacted by an Arcasian senator and one of Arcasia's biggest tycoons. And I decided to agree to their meeting in hopes of receiving support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Player_Italic: "Let him continue."*)
  - -> `[408]` (*Player: ""You did what!?""*)

### Węzeł `[399]`
Mówca: **Frens Ricter**
> ""I flew to Arcasia and I eventually met President Walker. He offered political and economic support for me and my party, asking us to lead Sordland into the democratic sphere and become a member of the ATO. But the exploitative conditions he was demanding would have had crippling effects on our economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Frens Ricter: ""I told him that I was only there to increase economic co..."*)

### Węzeł `[400]`
**[WYBÓR GRACZA: ""I am grateful that you're telling me all this.""]** — Mówca: **Player**
> ""I am grateful that you're telling me all this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Frens Ricter: ""Thanks for taking it so well. We must always be honest w..."*)

### Węzeł `[401]`
**[WYBÓR GRACZA: ""So the intel was correct after all...""]** — Mówca: **Player**
> ""So the intel was correct after all...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Frens Ricter: ""To some extent, yes. But now you know the real story.""*)

### Węzeł `[402]`
**[WYBÓR GRACZA: ""That was a big mistake from your side.""]** — Mówca: **Player**
> ""That was a big mistake from your side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Frens Ricter: ""I know...""*)

### Węzeł `[403]`
Mówca: **Frens Ricter**
> ""I told him that I was only there to increase economic cooperation and nothing else. I did not get their support, nor did I do anything illegal. To this day, I feel ashamed to have gone to the feet of Arcasia like that. But at least I managed to stop myself from becoming the very thing I've been fighting against.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Player: ""That was a big mistake from your side.""*)
  - -> `[401]` (*Player: ""So the intel was correct after all...""*)
  - -> `[400]` (*Player: ""I am grateful that you're telling me all this.""*)
  - -> `[407]` (*Player: ""I don't know if I can trust you after this.""*)

### Węzeł `[404]`
**[WYBÓR GRACZA: ""You're saying I was elected because Soll wanted it?""]** — Mówca: **Player**
> ""You're saying I was elected because Soll wanted it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[388]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Frens Ricter: ""I don't know. But your candidacy was definitely connecte..."*)

### Węzeł `[405]`
Mówca: **Frens Ricter**
> ""I don't know. But your candidacy was definitely connected to the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Frens Ricter: ""After realizing the true extent of the Sollist deep stat..."*)

### Węzeł `[406]`
**[WYBÓR GRACZA: ""I don't like where this is going.""]** — Mówca: **Player**
> ""I don't like where this is going.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[394]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Frens Ricter: ""I was contacted by an Arcasian senator and one of Arcasi..."*)

### Węzeł `[407]`
**[WYBÓR GRACZA: ""I don't know if I can trust you after this.""]** — Mówca: **Player**
> ""I don't know if I can trust you after this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[403]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Frens Ricter: ""The fact that I've told you something this incriminating..."*)

### Węzeł `[408]`
**[WYBÓR GRACZA: ""You did what!?""]** — Mówca: **Player**
> ""You did what!?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Frens Ricter: ""Please allow me to continue, Mr. Rayne.""*)

### Węzeł `[409]`
**[WYBÓR GRACZA: "Let him continue."]** — Mówca: **Player_Italic**
> "I kept listening."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Frens Ricter: ""I flew to Arcasia and I eventually met President Walker...."*)

### Węzeł `[410]`
Mówca: **Frens Ricter**
> ""Please allow me to continue, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Frens Ricter: ""I flew to Arcasia and I eventually met President Walker...."*)

### Węzeł `[411]`
Mówca: **Frens Ricter**
> ""I know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Frens Ricter: ""You have the authority to investigate this and potential..."*)

### Węzeł `[412]`
Mówca: **Frens Ricter**
> ""To some extent, yes. But now you know the real story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Frens Ricter: ""You have the authority to investigate this and potential..."*)

### Węzeł `[413]`
Mówca: **Frens Ricter**
> ""Thanks for taking it so well. We must always be honest with one another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Frens Ricter: ""You have the authority to investigate this and potential..."*)

### Węzeł `[414]`
Mówca: **Frens Ricter**
> ""The fact that I've told you something this incriminating should be an indication that you can trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Frens Ricter: ""You have the authority to investigate this and potential..."*)

### Węzeł `[415]`
Mówca: **Frens Ricter**
> ""You have the authority to investigate this and potentially prosecute me for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Frens Ricter: ""I gave you my trust. I hope I have yours too. I will alw..."*)

### Węzeł `[416]`
Mówca: **Frens Ricter**
> ""I gave you my trust. I hope I have yours too. I will always acknowledge my wrongs and keep fighting for a better future. I believe we are not that different in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Player: ""I'll trust you, Mr. Ricter.""*)
  - -> `[418]` (*Player: ""You are correct. I hope to be together in this fight for..."*)
  - -> `[419]` (*Player: ""I appreciate your trust in me, but I'll need to think mo..."*)

### Węzeł `[417]`
**[WYBÓR GRACZA: ""I'll trust you, Mr. Ricter.""]** — Mówca: **Player**
> ""I'll trust you, Mr. Ricter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[416]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Frens Ricter: ""That means a lot coming from you.""*)

### Węzeł `[418]`
**[WYBÓR GRACZA: ""You are correct. I hope to be together in this fight for a better future.""]** — Mówca: **Player**
> ""You are correct. I hope to be together in this fight for a better future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[416]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Frens Ricter: ""As the revolutionaries once said, 'The morning will come..."*)

### Węzeł `[419]`
**[WYBÓR GRACZA: ""I appreciate your trust in me, but I'll need to think more about this.""]** — Mówca: **Player**
> ""I appreciate your trust in me, but I'll need to think more about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[416]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Frens Ricter: ""That's fair.""*)

### Węzeł `[420]`
Mówca: **Frens Ricter**
> ""That's fair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Frens Ricter: ""Anyway, if you ever want to discuss this topic further, ..."*)

### Węzeł `[421]`
Mówca: **Frens Ricter**
> ""As the revolutionaries once said, 'The morning will come', Mr. Rayne. We'll see it one day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Frens Ricter: ""Anyway, if you ever want to discuss this topic further, ..."*)

### Węzeł `[422]`
Mówca: **Frens Ricter**
> ""That means a lot coming from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Frens Ricter: ""Anyway, if you ever want to discuss this topic further, ..."*)

### Węzeł `[423]`
Mówca: **Frens Ricter**
> ""Anyway, if you ever want to discuss this topic further, feel free to call me. I don't have anything to hide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Narrator: "He stood up."*)

### Węzeł `[424]`
Mówca: **Frens Ricter**
> ""I'll get going now, if you'll excuse me. Thanks for the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "We shook hands."*)

### Węzeł `[425]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Frens Ricter: ""I'll get going now, if you'll excuse me. Thanks for the ..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Bribed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Frens_Bribed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "Jump to: [PersuadedRicter]"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_NoInvestment == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_Megaproject_NoInvestment == true"*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_Megaproject_NoInvestment == true)"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_Megaproject_NoInvestment == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_NoInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Frens Ricter: ""I know you have already concluded the draft with your pa..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_Megaproject_NoInvestment == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_NoInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)

### Węzeł `[430]`
Mówca: **Frens Ricter**
> ""I know you have already concluded the draft with your party, but the proposal is forcing our hand. Normally, this is not something we could support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Frens Ricter: ""All I wanted was a democratic constitution, Mr. Rayne...""*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_TaurusHolding == true"*)
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Frens Ricter: ""A company that I'm involved with, Taurus Holding, has be..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_TaurusHolding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Frens Ricter: ""A company that I'm involved with, Taurus Holding, has be..."*)

### Węzeł `[434]`
Mówca: **Frens Ricter**
> ""A company that I'm involved with, Taurus Holding, has been conducting research on new machines for construction megaprojects and created a construction force that's unmatched in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved == true"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_RailwayIssue_Solved == true"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_HighwayIssue_Solved == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved == true"*)
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_HighwayIssue_Solved == true)"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_HighwayIssue_Solved == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Frens Ricter: ""You already know about their efficiency and high-quality..."*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_HighwayIssue_Solved == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Frens Ricter: ""I know you had some troubles with the H-3 Line, but they..."*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_RailwayIssue_Solved == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_RailwayIssue_Solved == true"*)
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_RailwayIssue_Solved == true)"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_RailwayIssue_Solved == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Frens Ricter: ""You already know about their efficiency and high quality..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_RailwayIssue_Solved == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Frens Ricter: ""I know you had some troubles with the L-1 Line, but they..."*)

### Węzeł `[444]`
Mówca: **Frens Ricter**
> ""You already know about their efficiency and high-quality materials. They did a great job with the new H-3 Line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Frens Ricter: ""I'd like you to give them another chance with the next s..."*)

### Węzeł `[445]`
Mówca: **Frens Ricter**
> ""I'd like you to give them another chance with the next state project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Player: ""Consider it done.""*)
  - -> `[449]` (*Player: ""Their work left much to be desired. I will not work with..."*)
  - -> `[323]` (*Player: ""I can't do that.""*)

### Węzeł `[446]`
Mówca: **Frens Ricter**
> ""You already know about their efficiency and high quality materials. They did a great job with the new L-1 railway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Frens Ricter: ""I'd like you to give them another chance with the next s..."*)

### Węzeł `[447]`
Mówca: **Frens Ricter**
> ""I know you had some troubles with the H-3 Line, but they have greatly increased their capabilities and they now definitely surpass the potential to be a leading brand in the world. If the state decides to support it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Frens Ricter: ""I'd like you to give them another chance with the next s..."*)

### Węzeł `[448]`
Mówca: **Frens Ricter**
> ""I know you had some troubles with the L-1 Line, but they have greatly increased their capabilities and they now definitely surpass the potential to be a leading brand in the world. If the State decides to support it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Frens Ricter: ""I'd like you to give them another chance with the next s..."*)

### Węzeł `[449]`
**[WYBÓR GRACZA: ""Their work left much to be desired. I will not work with them again.""]** — Mówca: **Player**
> ""Their work left much to be desired. I will not work with them again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[445]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Frens Ricter: ""It's a shame things won't work out between us.""*)

### Węzeł `[450]`
Mówca: **Frens Ricter**
> ""All I wanted was a democratic constitution, Mr. Rayne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Frens Ricter: ""It's a shame things won't work out between us.""*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)"*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Frens Ricter: ""And if we're talking about democracy here... I first nee..."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Frens Ricter: ""And if we're talking about democracy here... I first nee..."*)

### Węzeł `[454]`
Mówca: **Frens Ricter**
> ""And if we're talking about democracy here... I first need to trust your agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Frens Ricter: ""And I currently do not.""*)

### Węzeł `[455]`
Mówca: **Frens Ricter**
> ""And I currently do not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Frens Ricter: ""The first bill you signed effectively removed all other ..."*)

### Węzeł `[456]`
Mówca: **Frens Ricter**
> ""The first bill you signed effectively removed all other parties from funding. You are hijacking the elections from the very start. How can we trust you now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player: ""That bill also increased your funding, Mr. Ricter...""*)
  - -> `[458]` (*Player: ""It was passed by the Assembly. All I did was sign it int..."*)
  - -> `[459]` (*Player: ""The past is past, Mr. Ricter. Let's fix the future.""*)

### Węzeł `[457]`
**[WYBÓR GRACZA: ""That bill also increased your funding, Mr. Ricter...""]** — Mówca: **Player**
> ""That bill also increased your funding, Mr. Ricter...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[456]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Frens Ricter: ""Oh, so I should be grateful for a small increase in fund..."*)

### Węzeł `[458]`
**[WYBÓR GRACZA: ""It was passed by the Assembly. All I did was sign it into law.""]** — Mówca: **Player**
> ""It was passed by the Assembly. All I did was sign it into law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[456]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Frens Ricter: ""Exactly. You *did* sign it into law, and did not use you..."*)

### Węzeł `[459]`
**[WYBÓR GRACZA: ""The past is past, Mr. Ricter. Let's fix the future.""]** — Mówca: **Player**
> ""The past is past, Mr. Ricter. Let's fix the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[456]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Frens Ricter: ""Well, it's not so simple, Mr. Rayne. You came here with ..."*)

### Węzeł `[460]`
Mówca: **Frens Ricter**
> ""Oh, so I should be grateful for a small increase in funding? While your party gets all the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Frens Ricter: ""I think it's too late to fix anything now. I can't see a..."*)

### Węzeł `[461]`
Mówca: **Frens Ricter**
> ""Exactly. You *did* sign it into law, and did not use your veto on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Frens Ricter: ""I think it's too late to fix anything now. I can't see a..."*)

### Węzeł `[462]`
Mówca: **Frens Ricter**
> ""Well, it's not so simple, Mr. Rayne. You came here with a proposal that ignored our demands. On top of it, you're not even acknowledging your mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Frens Ricter: ""I think it's too late to fix anything now. I can't see a..."*)

### Węzeł `[463]`
Mówca: **Frens Ricter**
> ""I think it's too late to fix anything now. I can't see any deals being made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Frens Ricter: ""It's a shame things won't work out between us.""*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Bribed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true"*)
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Bribed == true)"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Bribed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Bribed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Frens_Bribed = true; BaseG..."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Bribed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Bribed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Taurus == true"*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Frens_Bribed = true;
BaseGameSupport.News_Turn06_LT_PFJPConvinced = true;
BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Frens_Bribed"] = true;
Variable["BaseGameSupport.News_Turn06_LT_PFJPConvinced"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Taurus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Taurus == true"*)
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Promise_Taurus == true)"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Taurus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Frens_Taurus = true; BaseG..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Promise_Taurus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Taurus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Seat == true"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Frens_Taurus = true;
BaseGameSupport.News_Turn06_LT_PFJPConvinced = true;
BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Frens_Taurus"] = true;
Variable["BaseGameSupport.News_Turn06_LT_PFJPConvinced"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Frens_PromisedSeat = true;
BaseGameSupport.News_Turn06_LT_PFJPConvinced = true;
BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Frens_PromisedSeat"] = true;
Variable["BaseGameSupport.News_Turn06_LT_PFJPConvinced"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Seat == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Promise_Seat == true"*)
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Promise_Seat == true)"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Promise_Seat == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Promise_Seat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Frens_PromisedSeat = true;..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Promise_Seat == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Promise_Seat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_PFJP_Convinced == true"*)
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_PFJP_Convinced == true)"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_PFJP_Convinced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Frens_Convinced = true; Ba..."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_PFJP_Convinced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_PFJP_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_LT_PFJPNotConvinced = true"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Frens_Convinced = true;
BaseGameSupport.News_Turn06_LT_PFJPConvinced = true;
BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Frens_Convinced"] = true;
Variable["BaseGameSupport.News_Turn06_LT_PFJPConvinced"] = true;
Variable["BaseGameSupport.Report_Turn06_Holsord_PFJP_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_LT_PFJPNotConvinced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_LT_PFJPNotConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn06_Holsord_PFJP_NotConvinced =..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn06_Holsord_PFJP_NotConvinced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn06_Holsord_PFJP_NotConvinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_ST_VictoryDay = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_VictoryDay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The preparations for the new Constitution were nearly com..."*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
