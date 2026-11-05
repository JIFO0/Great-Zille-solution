# Sordland/Turn03/Personal_HelicopterEscape

- **ID konwersacji:** `46`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/046_Personal_HelicopterEscape.md`
- **Liczba węzłów dialogowych:** 395
- **Liczba wyborów gracza:** 92

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.Relations_Ewald_Friendly`
- `BaseGame.Relations_Ewald_Neutral`
- `BaseGame.Relations_Ewald_PromiseNotHarsherEPA`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits`
- `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages`
- `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn03_HP_Address_HelicopterEscape`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity`
- `BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries`
- `BaseGameSupport.News_Turn03_LT_Address_HelicopterEscape`
- `BaseGameSupport.News_Turn03_LT_Address_PresidentLandsLachaven`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations`
- `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction`
- `BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory`
- `BaseGameSupport.Report_Turn03_Lachaven_BlueMansionSecurity`
- `BaseGameText.AlphonsoToPlayer`

### Skoki między-konwersacyjne:
- Węzeł `[118]` -> **[47] Sordland/Turn03/Mid Conversation** (../Turn_03/047_Mid_Conversation.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **""I'm committed to creating a favorable environment for businesses like Gasom. Your..."** | `[7]` **Ewald Alphonso**: ""It could deter potential invest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Ewald Alphonso**: ""I'm glad to hear that, Mr. Pres..." |
| `[10]` | **""You're making it sound as if any change to the EPA would lead to an economic cata..."** | `[7]` **Ewald Alphonso**: ""It could deter potential invest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Ewald Alphonso**: ""Mr. President, I assure you tha..." |
| `[13]` | **""I hear your concerns, Mr. Alphonso. But we also have to consider Sordland's long-..."** | `[7]` **Ewald Alphonso**: ""It could deter potential invest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Ewald Alphonso**: ""Absolutely, Mr. President. Stri..." |
| `[48]` | **""It was an adventure, wasn't it? And I agree, Serge's assistance was invaluable.""** | `[51]` **Ewald Alphonso**: ""I heard from Gasom security and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Serge Wolkner**: ""Just doing my job, Mr. Presiden..." |
| `[49]` | **""Yes, our safety matters most. But it's unfortunate that we had to leave under tho..."** | `[51]` **Ewald Alphonso**: ""I heard from Gasom security and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Serge Wolkner**: ""Truly unfortunate, sir. But saf..." |
| `[53]` | **""Yes, I'm glad we're safe. Although i can't help but wonder whether I should have ..."** | `[64]` **Ewald Alphonso**: ""The Gasom security and local po..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Serge Wolkner**: ""Safety comes first, Mr. Preside..." |
| `[54]` | **""I can always rely on Serge to get me out of a dangerous situation.""** | `[64]` **Ewald Alphonso**: ""The Gasom security and local po..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Serge Wolkner**: ""That's what I'm here for, Mr. P..." |
| `[55]` | **""Yes, it was unfortunate how the situation unfolded. But a stroke of luck that you..."** | `[63]` **Ewald Alphonso**: ""It's just a pity we couldn't ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Serge Wolkner**: ""I'm glad I could be of assistan..." |
| `[56]` | **""A shame about the protests, but to be honest, I'm not sure we were ever going to ..."** | `[63]` **Ewald Alphonso**: ""It's just a pity we couldn't ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Serge Wolkner**: ""I'm just doing my job, Mr. Pres..." |
| `[73]` | **""Serge, can you sing any Sordish folk songs to lighten the mood?""** | `[66]` **Ewald Alphonso**: ""Once we were stuck in a traffic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Serge Wolkner**: ""I'm afraid I'm not much of a si..." |
| `[74]` | **""Perhaps we should add singing ability to the job requirements for presidential dr..."** | `[66]` **Ewald Alphonso**: ""Once we were stuck in a traffic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Serge Wolkner**: ""I don't know about that, Mr. Pr..." |
| `[75]` | **""Serge, I didn't know your job had such... unusual requirements.""** | `[66]` **Ewald Alphonso**: ""Once we were stuck in a traffic..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Serge Wolkner**: ""Well, Mr. President, you never ..." |
| `[82]` | **""Do you have any stories for us, Serge?""** | `[68]` **Ewald Alphonso**: ""Once he convinced a junior aide..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Serge Wolkner**: ""I'm afraid I'm not much of a st..." |
| `[83]` | **""Serge, it seems like you have a tough act to follow.""** | `[68]` **Ewald Alphonso**: ""Once he convinced a junior aide..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Serge Wolkner**: ""Indeed, Mr. President. Nouman w..." |
| `[84]` | **""Come to think of it, I do hear some strange noises in there sometimes.""** | `[68]` **Ewald Alphonso**: ""Once he convinced a junior aide..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Serge Wolkner**: ""Whatever you hear, it's not the..." |
| `[91]` | **""Do you have any funny stories for us, Serge?""** | `[72]` **Ewald Alphonso**: ""His stories could get even the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Serge Wolkner**: ""Mr. Rayne, Nouman had his style..." |
| `[92]` | **""He used humor to lighten a stressful situation. I see. Ever hear of humor, Serge?""** | `[72]` **Ewald Alphonso**: ""His stories could get even the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Serge Wolkner**: ""Of course, Mr. President. But I..." |
| `[93]` | **""Serge, did learning from Nouman help you stay cool in a crisis?""** | `[72]` **Ewald Alphonso**: ""His stories could get even the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Serge Wolkner**: ""Mr. President, Nouman's lessons..." |
| `[109]` | **""The returns might not be immediate. But I truly think the highway will pay off in..."** | `[106]` **Ewald Alphonso**: ""Serge may be right. You could m..."<br>`[107]` **Ewald Alphonso**: ""Its impact on rural areas is st..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Serge Wolkner**: ""It moves me to think about how ..." |
| `[110]` | **""Just wait until it's completed, Sordland will make progress in leaps and bounds.""** | `[106]` **Ewald Alphonso**: ""Serge may be right. You could m..."<br>`[107]` **Ewald Alphonso**: ""Its impact on rural areas is st..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Serge Wolkner**: ""It moves me to think about how ..." |
| `[111]` | **""Some of my ministers had concerns as well. But I believe the H-3 was a solid inve..."** | `[106]` **Ewald Alphonso**: ""Serge may be right. You could m..."<br>`[107]` **Ewald Alphonso**: ""Its impact on rural areas is st..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Serge Wolkner**: ""It moves me to think about how ..." |
| `[112]` | **""It's a symbol of Sordland's past as well as its future.""** | `[138]` **Ewald Alphonso**: ""But Lachaven has its issues, li..."<br>`[139]` **Ewald Alphonso**: ""Wealth and poverty, side by sid..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Serge Wolkner**: ""I can't imagine what it must be..." |
| `[113]` | **""It shows the complexity of our nation.""** | `[138]` **Ewald Alphonso**: ""But Lachaven has its issues, li..."<br>`[139]` **Ewald Alphonso**: ""Wealth and poverty, side by sid..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Serge Wolkner**: ""I can't imagine what it must be..." |
| `[114]` | **""There are some issues, but with your foundation, you're already making a differen..."** | `[138]` **Ewald Alphonso**: ""But Lachaven has its issues, li..."<br>`[139]` **Ewald Alphonso**: ""Wealth and poverty, side by sid..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Serge Wolkner**: ""I can't imagine what it must be..." |
| `[115]` | **""Just wait until it's completed. Logistical operations in Sordland will never be t..."** | `[126]` **Ewald Alphonso**: ""The L-1 railway... quite an inv..."<br>`[127]` **Ewald Alphonso**: ""It's a fine line you're treading.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Serge Wolkner**: ""A revolutionary vision from a v..." |
| `[116]` | **""Yes, it's ambitious. But great change often requires bold decisions.""** | `[126]` **Ewald Alphonso**: ""The L-1 railway... quite an inv..."<br>`[127]` **Ewald Alphonso**: ""It's a fine line you're treading.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Serge Wolkner**: ""A revolutionary vision from a v..." |
| `[117]` | **""Your man Gus Manger made an especially convincing case for the railway's construc..."** | `[126]` **Ewald Alphonso**: ""The L-1 railway... quite an inv..."<br>`[127]` **Ewald Alphonso**: ""It's a fine line you're treading.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Serge Wolkner**: ""A revolutionary vision from a v..." |
| `[146]` | **""You prefer to keep things professional, right? Let's do that going forward.""** | `[142]` **Serge Wolkner**: ""My apologies, gentlemen. I didn..." | `Variable["BaseGame.Relations_Serge_Friend"] == false` | *Brak zmian stanu* | `[150]` **Serge Wolkner**: ""Understood, Mr. President. I'll..." |
| `[147]` | **""Who needs Nouman's entertainment when we can listen to Serge Wolkner rhapsodizing..."** | `[142]` **Serge Wolkner**: ""My apologies, gentlemen. I didn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Serge Wolkner**: ""It's true, Mr. President. I cou..." |
| `[148]` | **""No need to apologize, Serge. It's always a pleasure to listen to you.""** | `[142]` **Serge Wolkner**: ""My apologies, gentlemen. I didn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Serge Wolkner**: ""I appreciate you saying that, M..." |
| `[149]` | **""That's quite all right. But I do have a few more things I'd like to bring up with..."** | `[142]` **Serge Wolkner**: ""My apologies, gentlemen. I didn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Serge Wolkner**: ""Certainly, Mr. President."" |
| `[168]` | **""That sounds promising. These initiatives could significantly improve workers' liv..."** | `[225]` **Ewald Alphonso**: ""I'm considering initiatives to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Ewald Alphonso**: ""Thank you. I believe the same."" |
| `[169]` | **""That's an ambitious plan. I hope you can execute it.""** | `[225]` **Ewald Alphonso**: ""I'm considering initiatives to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Ewald Alphonso**: ""I share your sentiment. It's ti..." |
| `[181]` | **""It's a bold move, but it could indeed create an economic upswing. I'll consider r..."** | `[180]` **Ewald Alphonso**: ""Galmland, Qinal, and Anraka hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Ewald Alphonso**: ""I'm glad to hear that, Mr. Pres..." |
| `[182]` | **""We must also consider the potential risks. Aren't you worried that increasing for..."** | `[180]` **Ewald Alphonso**: ""Galmland, Qinal, and Anraka hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Ewald Alphonso**: ""Maintaining control and ensurin..." |
| `[185]` | **""Your argument is compelling, but it's a complex issue. I'll consider your recomme..."** | `[180]` **Ewald Alphonso**: ""Galmland, Qinal, and Anraka hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Ewald Alphonso**: ""I appreciate your open-mindedne..." |
| `[189]` | **""I understand your points, Mr. Alphonso, but we need to consider national security..."** | `[188]` **Ewald Alphonso**: ""Of course they'd be a controver..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Ewald Alphonso**: ""National security is paramount,..." |
| `[190]` | **""Mr. Alphonso, don't you think we're gambling a bit too much with the future of ou..."** | `[188]` **Ewald Alphonso**: ""Of course they'd be a controver..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Ewald Alphonso**: ""Rumburg's involvement could ind..." |
| `[193]` | **""This is a bold move. But it could indeed provide a much-needed boost to our econo..."** | `[188]` **Ewald Alphonso**: ""Of course they'd be a controver..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Ewald Alphonso**: ""In my experience, fortune favor..." |
| `[197]` | **""I must say I'm disappointed that we are in this situation. As the chair of Gasom,..."** | `[196]` **Ewald Alphonso**: ""And that's not a prospect I rel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Ewald Alphonso**: ""Yes, the situation is far from ..." |
| `[198]` | **""You're Gasom's chair. Can't you find a way  to save the company without risking o..."** | `[196]` **Ewald Alphonso**: ""And that's not a prospect I rel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[342]` **Ewald Alphonso**: ""We could consider other avenues..." |
| `[200]` | **""This conversation seems to revolve around accommodating foreign investors rather ..."** | `[196]` **Ewald Alphonso**: ""And that's not a prospect I rel..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Ewald Alphonso**: ""Capital is a tool. Used properl..." |
| `[205]` | **""Our strength is not measured by how much we invest, but how wisely we use our res..."** | `[204]` **Ewald Alphonso**: ""I worry that Sordland's unwilli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Ewald Alphonso**: ""Wise words, Mr. President, but ..." |
| `[206]` | **""We're showing that we can't be bought or influenced by money.""** | `[204]` **Ewald Alphonso**: ""I worry that Sordland's unwilli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Ewald Alphonso**: ""A strong stance. But we must al..." |
| `[207]` | **""Strength can also mean resisting the urge to chase after every opportunity.""** | `[204]` **Ewald Alphonso**: ""I worry that Sordland's unwilli..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Ewald Alphonso**: ""Perhaps. We'll have to see how ..." |
| `[212]` | **""Exactly. We're setting a strong foundation for future growth.""** | `[211]` **Ewald Alphonso**: ""Your government's large investm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Ewald Alphonso**: ""Indeed, {BaseGameText.AlphonsoT..." |
| `[213]` | **""This is our chance to make Sordland a global leader in energy.""** | `[211]` **Ewald Alphonso**: ""Your government's large investm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Ewald Alphonso**: ""Absolutely, we're not just maki..." |
| `[214]` | **""We're showing the world that Sordland is open for business.""** | `[211]` **Ewald Alphonso**: ""Your government's large investm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Ewald Alphonso**: ""That's right, {BaseGameText.Alp..." |
| `[219]` | **""Agreed. We need to ensure our sovereignty isn't compromised.""** | `[218]` **Ewald Alphonso**: ""I'm sure that you agree it's im..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Ewald Alphonso**: ""Exactly, {BaseGameText.Alphonso..." |
| `[220]` | **""I see this as an opportunity to learn and grow together with the Kingdom.""** | `[218]` **Ewald Alphonso**: ""I'm sure that you agree it's im..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Ewald Alphonso**: ""Indeed, we can definitely learn..." |
| `[221]` | **""Our collaboration is a mere stepping stone to bigger and better opportunities.""** | `[218]` **Ewald Alphonso**: ""I'm sure that you agree it's im..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Ewald Alphonso**: ""I share your optimism, Mr. Pres..." |
| `[229]` | **""I'm glad you're thinking along these lines. I expect more than mere consideration..."** | `[225]` **Ewald Alphonso**: ""I'm considering initiatives to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Ewald Alphonso**: ""You're absolutely right. It's a..." |
| `[233]` | **""That's a step in the right direction. Fair wages are fundamental to worker satisf..."** | `[226]` **Ewald Alphonso**: ""We need to ensure they're recei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Ewald Alphonso**: ""I agree. A satisfied workforce ..." |
| `[234]` | **""I'm glad to hear that. As long as this review isn't merely a token gesture.""** | `[226]` **Ewald Alphonso**: ""We need to ensure they're recei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Ewald Alphonso**: ""I assure you, this won't be jus..." |
| `[235]` | **""That's long overdue. I hope to see substantial improvements in their remuneration.""** | `[226]` **Ewald Alphonso**: ""We need to ensure they're recei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Ewald Alphonso**: ""I understand your concerns. We'..." |
| `[239]` | **""That's a positive direction. I hope to see Gasom leading the way in corporate res..."** | `[227]` **Ewald Alphonso**: ""I'm considering supporting loca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Ewald Alphonso**: ""Thank you. We hope to set a goo..." |
| `[240]` | **""Good thinking. But remember, sustainability is more than just philanthropy.""** | `[227]` **Ewald Alphonso**: ""I'm considering supporting loca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Ewald Alphonso**: ""Absolutely. We're looking at a ..." |
| `[241]` | **""It's high time. I expect these considerations to translate into substantial chang..."** | `[227]` **Ewald Alphonso**: ""I'm considering supporting loca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Ewald Alphonso**: ""Of course, {BaseGameText.Alphon..." |
| `[245]` | **""I appreciate your concern for Gasom's economic contribution, but it's crucial not..."** | `[228]` **Ewald Alphonso**: ""Our company will do its best wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Ewald Alphonso**: ""I assure you that we always str..." |
| `[246]` | **""That's a narrow view, Alphonso. As Gasom grows, its social responsibilities shoul..."** | `[228]` **Ewald Alphonso**: ""Our company will do its best wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Ewald Alphonso**: ""A valid point. We will need to ..." |
| `[247]` | **""Maintaining the status quo is not enough. Gasom needs to be a part of the solutio..."** | `[228]` **Ewald Alphonso**: ""Our company will do its best wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Ewald Alphonso**: ""I appreciate your input, {BaseG..." |
| `[257]` | **""As long as Gasom is doing well, I'm not concerned about how you choose to distrib..."** | `[228]` **Ewald Alphonso**: ""Our company will do its best wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Ewald Alphonso**: ""I appreciate your trust in Gaso..." |
| `[259]` | **""The financial situation of Gasom's employees is not my concern. They're paid for ..."** | `[226]` **Ewald Alphonso**: ""We need to ensure they're recei..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Ewald Alphonso**: ""Yes, they are. Our company has ..." |
| `[261]` | **""As long as the workers are doing their jobs and Gasom is profitable, I see no rea..."** | `[225]` **Ewald Alphonso**: ""I'm considering initiatives to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[262]` **Ewald Alphonso**: ""I appreciate your pragmatic app..." |
| `[263]` | **""Your ideas are commendable, but they're not my priority.""** | `[227]` **Ewald Alphonso**: ""I'm considering supporting loca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Ewald Alphonso**: ""I understand. But I do believe ..." |
| `[270]` | **""I understand why you sponsored the motion. But you of all people should understan..."** | `[269]` **Ewald Alphonso**: ""The vote was 179 against the re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Ewald Alphonso**: ""Of course I do. But I also unde..." |
| `[271]` | **""The defeat of the repeal was a setback for our plans to liberalize the economy. W..."** | `[269]` **Ewald Alphonso**: ""The vote was 179 against the re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Ewald Alphonso**: ""I agree. It's clear that you'll..." |
| `[272]` | **""I'm glad the repeal was defeated. We should not open our energy sector to foreign..."** | `[269]` **Ewald Alphonso**: ""The vote was 179 against the re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Ewald Alphonso**: ""I still believe that the repeal..." |
| `[273]` | **""The defeat of the repeal wasn't surprising given the political climate. I'd rathe..."** | `[269]` **Ewald Alphonso**: ""The vote was 179 against the re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Ewald Alphonso**: ""We must be pragmatic and pick o..." |
| `[284]` | **""I agree, Mr. Alphonso. With the state on board, Gasom's future will be bright.""** | `[283]` **Ewald Alphonso**: ""Our foundation is strong, and o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Ewald Alphonso**: ""I appreciate your optimism, {Ba..." |
| `[285]` | **""You still haven't convinced me. But consider Sordland's investment a vote of conf..."** | `[283]` **Ewald Alphonso**: ""Our foundation is strong, and o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Ewald Alphonso**: ""Of course, {BaseGameText.Alphon..." |
| `[286]` | **""Gasom's future certainly looks promising, but the decision about the EPA is a com..."** | `[283]` **Ewald Alphonso**: ""Our foundation is strong, and o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Ewald Alphonso**: ""Absolutely, Mr. President. Give..." |
| `[287]` | **""I'm not so sure, Mr. Alphonso. We mustn't become over-reliant on Gasom or overly ..."** | `[283]` **Ewald Alphonso**: ""Our foundation is strong, and o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Ewald Alphonso**: ""I understand your concerns, Mr...." |
| `[308]` | **""Good evening, Mr. Alphonso. It was a productive discussion.""** | `[8]` **Narrator**: "The helicopter gradually reduced..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Ewald Alphonso**: ""Thank you for a stimulating dis..."<br>`[318]` **Ewald Alphonso**: ""Thank you for your time, Mr. Pr..."<br>*(oraz 1 innych odgałęzień)* |
| `[309]` | **""Good talking to you, Mr. Alphonso.""** | `[8]` **Narrator**: "The helicopter gradually reduced..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Ewald Alphonso**: ""Thank you for a stimulating dis..."<br>`[318]` **Ewald Alphonso**: ""Thank you for your time, Mr. Pr..."<br>*(oraz 1 innych odgałęzień)* |
| `[310]` | **""It was a pleasure, Mr. Alphonso. Goodbye.""** | `[8]` **Narrator**: "The helicopter gradually reduced..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Ewald Alphonso**: ""Thank you for a stimulating dis..."<br>`[318]` **Ewald Alphonso**: ""Thank you for your time, Mr. Pr..."<br>*(oraz 1 innych odgałęzień)* |
| `[325]` | **""Not bumpy at all. I appreciate the lift.""** | `[8]` **Narrator**: "The helicopter gradually reduced..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Ewald Alphonso**: ""Thank you for a stimulating dis..."<br>`[318]` **Ewald Alphonso**: ""Thank you for your time, Mr. Pr..."<br>*(oraz 1 innych odgałęzień)* |
| `[329]` | **""Your confidence is reassuring. However, how can we ensure that Rumburg won't atte..."** | `[328]` **Ewald Alphonso**: ""In business, a certain level of..."<br>`[374]` **Ewald Alphonso**: ""Were Rumburg to get involved, t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Ewald Alphonso**: ""That's a risk we'll have to man..." |
| `[330]` | **""I share your views. However, I do worry about a potential backlash. The prospect ..."** | `[328]` **Ewald Alphonso**: ""In business, a certain level of..."<br>`[374]` **Ewald Alphonso**: ""Were Rumburg to get involved, t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Ewald Alphonso**: ""Public opinion is a vital facto..." |
| `[331]` | **""I am still concerned about the implications of letting foreign entities have a st..."** | `[328]` **Ewald Alphonso**: ""In business, a certain level of..."<br>`[374]` **Ewald Alphonso**: ""Were Rumburg to get involved, t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[334]` **Ewald Alphonso**: ""As I've said before, it's a mat..." |
| `[332]` | **""The changes we make to the Energy Protection Act will have long-lasting implicati..."** | `[328]` **Ewald Alphonso**: ""In business, a certain level of..."<br>`[374]` **Ewald Alphonso**: ""Were Rumburg to get involved, t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[333]` **Ewald Alphonso**: ""Take all the time you need, {Ba..." |
| `[345]` | **""Our resources are not infinite. We must prioritize, and sometimes, tough calls ha..."** | `[344]` **Ewald Alphonso**: ""It's a bitter pill to swallow, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Ewald Alphonso**: ""I understand the constraints yo..." |
| `[346]` | **""We have to remember the importance of keeping our energy sector secure. The idea ..."** | `[344]` **Ewald Alphonso**: ""It's a bitter pill to swallow, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Ewald Alphonso**: ""I share your concerns about Rum..." |
| `[349]` | **""While I sympathize with your position, the reality is that we had to make some ha..."** | `[344]` **Ewald Alphonso**: ""It's a bitter pill to swallow, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Ewald Alphonso**: ""I'm not sure if I trust your ju..." |
| `[355]` | **""Mr. Alphonso, I'm aware of the gravity of the situation. But we must not rush int..."** | `[344]` **Ewald Alphonso**: ""It's a bitter pill to swallow, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Ewald Alphonso**: ""Indeed, Mr. President. We must ..." |
| `[360]` | **""It's a compromise that could save Gasom without compromising our sovereignty too ..."** | `[359]` **Ewald Alphonso**: ""For old times' sake, let's work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Narrator**: "Suddenly, the former president's..." |
| `[361]` | **""Tightening the EPA laws further may be a necessary step for our future, even if i..."** | `[359]` **Ewald Alphonso**: ""For old times' sake, let's work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Narrator**: "Suddenly, the former president's..." |
| `[362]` | **""Not my decisions, Mr. Alphonso. Yours.""** | `[359]` **Ewald Alphonso**: ""For old times' sake, let's work..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Narrator**: "Suddenly, the former president's..." |
| `[365]` | **""Of course, Ewald. You don't even need to ask.""** | `[364]` **Ewald Alphonso**: ""Now that we've escaped an angry..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameText.AlphonsoToPlayer"] ="Anton";` | `[42]` **Ewald Alphonso**: ""I must say, {BaseGameText.Alpho..." |
| `[366]` | **""I'd rather keep things on the professional level, if you don't mind.""** | `[364]` **Ewald Alphonso**: ""Now that we've escaped an angry..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[368]` **Ewald Alphonso**: ""Of course. Forgive my forwardne..." |
| `[372]` | **""It may not be perfect, but I'm proud to call it my hometown.""** | `[138]` **Ewald Alphonso**: ""But Lachaven has its issues, li..."<br>`[139]` **Ewald Alphonso**: ""Wealth and poverty, side by sid..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true` | *Brak zmian stanu* | `[373]` **Serge Wolkner**: ""It must have been exciting to g..." |
| `[394]` | **""Its wealth disparities concern me. This place needs our help.""** | `[138]` **Ewald Alphonso**: ""But Lachaven has its issues, li..."<br>`[139]` **Ewald Alphonso**: ""Wealth and poverty, side by sid..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Serge Wolkner**: ""I can't imagine what it must be..." |

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
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("On a helicopter flight with a former Pre..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Ewald Alphonso**
> ""You've already agreed that you won't further tighten the EPA's restrictions. So I don't think I need to remind you how detrimental tighter restrictions would be to Gasom's operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Ewald Alphonso: ""It could deter potential investors, thereby causing a ri..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Ewald Alphonso: ""Your government's large investment in Gasom will undoubt..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)

### Węzeł `[7]`
Mówca: **Ewald Alphonso**
> ""It could deter potential investors, thereby causing a ripple effect that could lead to job losses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: ""I'm committed to creating a favorable environment for bu..."*)
  - -> `[10]` (*Player: ""You're making it sound as if any change to the EPA would..."*)
  - -> `[13]` (*Player: ""I hear your concerns, Mr. Alphonso. But we also have to ..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "The helicopter gradually reduced its speed, hovering for a moment before softly touching down on the helipad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player: ""Good evening, Mr. Alphonso. It was a productive discussi..."*)
  - -> `[309]` (*Player: ""Good talking to you, Mr. Alphonso.""*)
  - -> `[325]` (*Player: ""Not bumpy at all. I appreciate the lift.""*)
  - -> `[310]` (*Player: ""It was a pleasure, Mr. Alphonso. Goodbye.""*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm committed to creating a favorable environment for businesses like Gasom. Your success translates to more jobs and prosperity for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Ewald Alphonso: ""I'm glad to hear that, Mr. President. Your support and u..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're making it sound as if any change to the EPA would lead to an economic catastrophe. As the government, it's our duty to ensure energy security, not cater to private interests.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Ewald Alphonso: ""Mr. President, I assure you that it's not about private ..."*)

### Węzeł `[11]`
Mówca: **Ewald Alphonso**
> ""I'm glad to hear that, Mr. President. Your support and understanding of our challenges are essential for us to thrive and contribute to Sordland's economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[12]`
Mówca: **Ewald Alphonso**
> ""Mr. President, I assure you that it's not about private interests. It's about allowing companies like Gasom to provide energy security, drive economic growth, and create jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hear your concerns, Mr. Alphonso. But we also have to consider Sordland's long-term energy security.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Ewald Alphonso: ""Absolutely, Mr. President. Striking that balance is the ..."*)

### Węzeł `[14]`
Mówca: **Ewald Alphonso**
> ""Absolutely, Mr. President. Striking that balance is the key, and I believe we can achieve it together. Gasom is ready to be a part of the solution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Serge leaned forward in his seat, his eyes tracing the pa..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Serge's gaze traced the path of the still-in-progress L-1..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "We were approaching the outskirts of Lachaven. Serge lean..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "A patchwork of verdant fields, sprawling forests, and untouched land stretched out beneath us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "The further we moved from the mountains, the more rural t..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Friendly == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Ewald Alphonso: ""The H-3 highway... you know, {BaseGameText.AlphonsoToPla..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Friendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Neutral == true"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Neutral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Neutral == true"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Neutral == true)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Neutral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Neutral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Ewald Alphonso: ""Economically, the H-3 highway was a sound decision. It's..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Neutral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Neutral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Ewald Alphonso: ""I suppose the highway will have its benefits, but I can'..."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "The further we moved from the mountains, the more rural the landscape became. Small clusters of wooden houses and farmers' huts began to appear, their rustic charm a stark contrast to the grey concrete of Narbel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Helicopter");"*)

### Węzeł `[29]`
Mówca: **Narrator**
> "We turned our attention to the stunning view below us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Serge leaned forward in his seat, his eyes tracing the path of the H-3 highway through the Sordish countryside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Serge Wolkner: ""It's inspiring to see the highway construction from here..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Serge's gaze traced the path of the still-in-progress L-1 railway. The ribbon of steel gleamed bright in the sun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Serge Wolkner: ""What a marvel, Mr. President. I can't wait for the new r..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "We were approaching the outskirts of Lachaven. Serge leaned forward in his seat to get a better look at the city's skyline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Serge Wolkner: ""Lachaven... it's quite a sight, isn't it, Mr. President?""*)

### Węzeł `[33]`
Mówca: **Serge Wolkner**
> ""It's inspiring to see the highway construction from here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Serge Wolkner: ""The H-3 has the potential to connect the nation in a way..."*)

### Węzeł `[34]`
Mówca: **Serge Wolkner**
> ""What a marvel, Mr. President. I can't wait for the new railway to transform transportation in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Serge Wolkner: ""Seeing it from above is like witnessing history in the m..."*)

### Węzeł `[35]`
Mówca: **Serge Wolkner**
> ""Lachaven... it's quite a sight, isn't it, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Serge Wolkner: ""Historical, yet modern. There's something special about ..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Friendly == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Ewald Alphonso: ""Now that we've escaped an angry mob together, may I call..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Friendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Neutral == true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Neutral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Neutral == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Neutral == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Neutral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Neutral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Ewald Alphonso: ""That was quite an unexpected twist back there, Mr. Presi..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Neutral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Neutral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Ewald Alphonso: ""I have to admit, Mr. President, I didn't anticipate that..."*)

### Węzeł `[42]`
Mówca: **Ewald Alphonso**
> ""I must say, {BaseGameText.AlphonsoToPlayer}, that was quite the adventure we just had. Never a dull moment with you around, eh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Ewald Alphonso: ""Your driver did a great job escorting us out of there. H..."*)

### Węzeł `[43]`
Mówca: **Ewald Alphonso**
> ""That was quite an unexpected twist back there, Mr. President. I'd hoped to celebrate our deal with a drink, not a protest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Ewald Alphonso: ""But it seems we made the right choice. Your driver did a..."*)

### Węzeł `[44]`
Mówca: **Ewald Alphonso**
> ""I have to admit, Mr. President, I didn't anticipate that our meeting would come to this particular end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Ewald Alphonso: ""Of course your driver had the right instincts. Escaping ..."*)

### Węzeł `[45]`
Mówca: **Ewald Alphonso**
> ""Your driver did a great job escorting us out of there. He's a keeper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Ewald Alphonso: ""I heard from Gasom security and the local police about s..."*)

### Węzeł `[46]`
Mówca: **Ewald Alphonso**
> ""But it seems we made the right choice. Your driver did a terrific job escorting us out of there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Ewald Alphonso: ""The Gasom security and local police had been warning abo..."*)

### Węzeł `[47]`
Mówca: **Ewald Alphonso**
> ""Of course your driver had the right instincts. Escaping by helicopter was the safest choice for us both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Ewald Alphonso: ""It's just a pity we couldn't tap into the potential of o..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was an adventure, wasn't it? And I agree, Serge's assistance was invaluable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Serge Wolkner: ""Just doing my job, Mr. President. I'm glad we're all safe.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, our safety matters most. But it's unfortunate that we had to leave under those circumstances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Serge Wolkner: ""Truly unfortunate, sir. But safety always comes first.""*)

### Węzeł `[50]`
Mówca: **Serge Wolkner**
> ""Mr. Alphonso, it's an honor to meet you in person. I was trained by your former driver Nouman Fevon. He always spoke highly of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Ewald Alphonso: ""Ah, Nouman! What a man he was. Always had a knack for li..."*)

### Węzeł `[51]`
Mówca: **Ewald Alphonso**
> ""I heard from Gasom security and the local police about some armed gang activity in the area a week ago. Better safe than sorry, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: ""It was an adventure, wasn't it? And I agree, Serge's ass..."*)
  - -> `[49]` (*Player: ""Yes, our safety matters most. But it's unfortunate that ..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "Alphonso had been quiet for most of the journey, but as we neared Lachaven, he finally broke his silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, I'm glad we're safe. Although i can't help but wonder whether I should have spoken to those protesters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Serge Wolkner: ""Safety comes first, Mr. President. Always.""*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I can always rely on Serge to get me out of a dangerous situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Serge Wolkner: ""That's what I'm here for, Mr. President.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, it was unfortunate how the situation unfolded. But a stroke of luck that you had a helicopter at the ready.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Serge Wolkner: ""I'm glad I could be of assistance, Mr. President. The im..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A shame about the protests, but to be honest, I'm not sure we were ever going to see eye to eye. The only thing we can agree on is that Serge was right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Serge Wolkner: ""I'm just doing my job, Mr. President. Safety is top prio..."*)

### Węzeł `[57]`
Mówca: **Serge Wolkner**
> ""Just doing my job, Mr. President. I'm glad we're all safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Serge Wolkner: ""Mr. Alphonso, it's an honor to meet you in person. I was..."*)

### Węzeł `[58]`
Mówca: **Serge Wolkner**
> ""Truly unfortunate, sir. But safety always comes first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Serge Wolkner: ""Mr. Alphonso, it's an honor to meet you in person. I was..."*)

### Węzeł `[59]`
Mówca: **Serge Wolkner**
> ""Safety comes first, Mr. President. Always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Serge Wolkner: ""Mr. Alphonso, I was trained by Nouman Fevon, your former..."*)

### Węzeł `[60]`
Mówca: **Serge Wolkner**
> ""That's what I'm here for, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Serge Wolkner: ""Mr. Alphonso, I was trained by Nouman Fevon, your former..."*)

### Węzeł `[61]`
Mówca: **Serge Wolkner**
> ""I'm glad I could be of assistance, Mr. President. The important thing is that we're safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Serge Wolkner: ""Mr. Alphonso, I was trained by your former driver Nouman..."*)

### Węzeł `[62]`
Mówca: **Serge Wolkner**
> ""I'm just doing my job, Mr. President. Safety is top priority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Serge Wolkner: ""Mr. Alphonso, I was trained by your former driver Nouman..."*)

### Węzeł `[63]`
Mówca: **Ewald Alphonso**
> ""It's just a pity we couldn't tap into the potential of our meeting before all this... chaos.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: ""Yes, it was unfortunate how the situation unfolded. But ..."*)
  - -> `[56]` (*Player: ""A shame about the protests, but to be honest, I'm not su..."*)

### Węzeł `[64]`
Mówca: **Ewald Alphonso**
> ""The Gasom security and local police had been warning about potential armed gang activity in the area. It was best not to take any chances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""Yes, I'm glad we're safe. Although i can't help but wond..."*)
  - -> `[54]` (*Player: ""I can always rely on Serge to get me out of a dangerous ..."*)

### Węzeł `[65]`
Mówca: **Ewald Alphonso**
> ""Ah, Nouman! What a man he was. Always had a knack for lightening the mood, even in the direst of situations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Ewald Alphonso: ""Once we were stuck in a traffic jam for hours, and he st..."*)

### Węzeł `[66]`
Mówca: **Ewald Alphonso**
> ""Once we were stuck in a traffic jam for hours, and he started singing old Sordish folk songs right there in the car. He had the whole motorcade laughing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""Serge, can you sing any Sordish folk songs to lighten th..."*)
  - -> `[74]` (*Player: ""Perhaps we should add singing ability to the job require..."*)
  - -> `[75]` (*Player: ""Serge, I didn't know your job had such... unusual requir..."*)

### Węzeł `[67]`
Mówca: **Ewald Alphonso**
> ""Ah, Nouman! What a man. He used to tell us the most outrageous stories to keep us entertained during long journeys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Ewald Alphonso: ""Once he convinced a junior aide that the presidential li..."*)

### Węzeł `[68]`
Mówca: **Ewald Alphonso**
> ""Once he convinced a junior aide that the presidential limo was haunted! The poor lad didn't set foot in it for a week.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""Do you have any stories for us, Serge?""*)
  - -> `[83]` (*Player: ""Serge, it seems like you have a tough act to follow.""*)
  - -> `[84]` (*Player: ""Come to think of it, I do hear some strange noises in th..."*)

### Węzeł `[69]`
Mówca: **Serge Wolkner**
> ""Mr. Alphonso, I was trained by Nouman Fevon, your former driver. He spoke often of his time serving you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Ewald Alphonso: ""Ah, Nouman! What a man. He used to tell us the most outr..."*)

### Węzeł `[70]`
Mówca: **Serge Wolkner**
> ""Mr. Alphonso, I was trained by your former driver Nouman Fevon. He often mentioned the challenges of your presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Ewald Alphonso: ""Ah, Nouman. He was a real character. Always ready with a..."*)

### Węzeł `[71]`
Mówca: **Ewald Alphonso**
> ""Ah, Nouman. He was a real character. Always ready with a joke, even during the most serious of crises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Ewald Alphonso: ""His stories could get even the most stone-faced security..."*)

### Węzeł `[72]`
Mówca: **Ewald Alphonso**
> ""His stories could get even the most stone-faced security agents chuckling. I hope he was a good mentor to you, Serge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: ""Do you have any funny stories for us, Serge?""*)
  - -> `[92]` (*Player: ""He used humor to lighten a stressful situation. I see. E..."*)
  - -> `[93]` (*Player: ""Serge, did learning from Nouman help you stay cool in a ..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, can you sing any Sordish folk songs to lighten the mood?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Serge Wolkner: ""I'm afraid I'm not much of a singer, Mr. President. But ..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps we should add singing ability to the job requirements for presidential drivers, eh Serge?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Serge Wolkner: ""I don't know about that, Mr. President. I think driving ..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, I didn't know your job had such... unusual requirements.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Serge Wolkner: ""Well, Mr. President, you never know what skills might co..."*)

### Węzeł `[76]`
Mówca: **Serge Wolkner**
> ""I'm afraid I'm not much of a singer, Mr. President. But I know how to avoid traffic jams.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Ewald Alphonso: ""Ha! A true professional, this one.""*)

### Węzeł `[77]`
Mówca: **Serge Wolkner**
> ""I don't know about that, Mr. President. I think driving skills should be first on the list.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Ewald Alphonso: ""I'm sure your driving skills are top-notch, Serge. But a..."*)

### Węzeł `[78]`
Mówca: **Serge Wolkner**
> ""Well, Mr. President, you never know what skills might come in handy. But I must admit, singing isn't my strong suit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Ewald Alphonso: ""I'm sure you've got other hidden talents.""*)

### Węzeł `[79]`
Mówca: **Ewald Alphonso**
> ""Ha! A true professional, this one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We turned our attention to the stunning view below us."*)

### Węzeł `[80]`
Mówca: **Ewald Alphonso**
> ""I'm sure your driving skills are top-notch, Serge. But a sense of humor can be just as important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We turned our attention to the stunning view below us."*)

### Węzeł `[81]`
Mówca: **Ewald Alphonso**
> ""I'm sure you've got other hidden talents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We turned our attention to the stunning view below us."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you have any stories for us, Serge?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Serge Wolkner: ""I'm afraid I'm not much of a storyteller, Mr. President...."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, it seems like you have a tough act to follow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Serge Wolkner: ""Indeed, Mr. President. Nouman was quite a character. I d..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Come to think of it, I do hear some strange noises in there sometimes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Serge Wolkner: ""Whatever you hear, it's not the engine. I check up on it..."*)

### Węzeł `[85]`
Mówca: **Serge Wolkner**
> ""I'm afraid I'm not much of a storyteller, Mr. President. I'd rather keep my focus on the road.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Ewald Alphonso: ""A wise approach, Serge. We wouldn't want any nervous aid..."*)

### Węzeł `[86]`
Mówca: **Serge Wolkner**
> ""Indeed, Mr. President. Nouman was quite a character. I do my best to serve in my own way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Ewald Alphonso: ""And you're doing it very well, from the looks of it.""*)

### Węzeł `[87]`
Mówca: **Serge Wolkner**
> ""Whatever you hear, it's not the engine. I check up on it at least once a month to make sure it's running smoothly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Ewald Alphonso: ""Well done, Serge. I'll come to you the next time I need ..."*)

### Węzeł `[88]`
Mówca: **Ewald Alphonso**
> ""A wise approach, Serge. We wouldn't want any nervous aides running around, would we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We turned our attention to the stunning view below us."*)

### Węzeł `[89]`
Mówca: **Ewald Alphonso**
> ""And you're doing it very well, from the looks of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We turned our attention to the stunning view below us."*)

### Węzeł `[90]`
Mówca: **Ewald Alphonso**
> ""Well done, Serge. I'll come to you the next time I need car advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We turned our attention to the stunning view below us."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you have any funny stories for us, Serge?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Serge Wolkner: ""Mr. Rayne, Nouman had his style, and I have mine. I beli..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He used humor to lighten a stressful situation. I see. Ever hear of humor, Serge?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Serge Wolkner: ""Of course, Mr. President. But I've found that focus and ..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Serge, did learning from Nouman help you stay cool in a crisis?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Serge Wolkner: ""Mr. President, Nouman's lessons were invaluable, but I h..."*)

### Węzeł `[94]`
Mówca: **Serge Wolkner**
> ""Mr. Rayne, Nouman had his style, and I have mine. I believe in maintaining professionalism at all times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Ewald Alphonso: ""I see, Serge. Different strokes for different folks.""*)

### Węzeł `[95]`
Mówca: **Serge Wolkner**
> ""Of course, Mr. President. But I've found that focus and competence are more effective in managing stress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Ewald Alphonso: ""I'd pay good money to see this one in a car with Nouman...."*)

### Węzeł `[96]`
Mówca: **Serge Wolkner**
> ""Mr. President, Nouman's lessons were invaluable, but I have tried to develop my own style.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Ewald Alphonso: ""It's important to forge your own path, Serge. I respect ..."*)

### Węzeł `[97]`
Mówca: **Ewald Alphonso**
> ""I see, Serge. Different strokes for different folks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We turned our attention to the stunning view below us."*)

### Węzeł `[98]`
Mówca: **Ewald Alphonso**
> ""I'd pay good money to see this one in a car with Nouman. A straight man and a cut-up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We turned our attention to the stunning view below us."*)

### Węzeł `[99]`
Mówca: **Ewald Alphonso**
> ""It's important to forge your own path, Serge. I respect that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "We turned our attention to the stunning view below us."*)

### Węzeł `[100]`
Mówca: **Serge Wolkner**
> ""The H-3 has the potential to connect the nation in a way we've never seen before. Your legacy will be etched into the very landscape of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[101]`
Mówca: **Serge Wolkner**
> ""Seeing it from above is like witnessing history in the making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[102]`
Mówca: **Serge Wolkner**
> ""Historical, yet modern. There's something special about this city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[103]`
Mówca: **Ewald Alphonso**
> ""The H-3 highway... you know, {BaseGameText.AlphonsoToPlayer}, I was initially skeptical. But it could become a lifeline for our rural regions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Ewald Alphonso: ""Serge may be right. You could make a significant impact.""*)

### Węzeł `[104]`
Mówca: **Ewald Alphonso**
> ""Economically, the H-3 highway was a sound decision. It's a visible symbol of progress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Ewald Alphonso: ""Its impact on rural areas is still up for debate, however.""*)

### Węzeł `[105]`
Mówca: **Ewald Alphonso**
> ""I suppose the highway will have its benefits, but I can't help but think the funds could have been better allocated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Ewald Alphonso: ""To a project with a more immediate impact, perhaps.""*)

### Węzeł `[106]`
Mówca: **Ewald Alphonso**
> ""Serge may be right. You could make a significant impact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""The returns might not be immediate. But I truly think th..."*)
  - -> `[110]` (*Player: ""Just wait until it's completed, Sordland will make progr..."*)
  - -> `[111]` (*Player: ""Some of my ministers had concerns as well. But I believe..."*)

### Węzeł `[107]`
Mówca: **Ewald Alphonso**
> ""Its impact on rural areas is still up for debate, however.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""The returns might not be immediate. But I truly think th..."*)
  - -> `[110]` (*Player: ""Just wait until it's completed, Sordland will make progr..."*)
  - -> `[111]` (*Player: ""Some of my ministers had concerns as well. But I believe..."*)

### Węzeł `[108]`
Mówca: **Ewald Alphonso**
> ""To a project with a more immediate impact, perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""The returns might not be immediate. But I truly think th..."*)
  - -> `[110]` (*Player: ""Just wait until it's completed, Sordland will make progr..."*)
  - -> `[111]` (*Player: ""Some of my ministers had concerns as well. But I believe..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The returns might not be immediate. But I truly think the highway will pay off in the long term.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Ewald Alphonso), `[107]` (Ewald Alphonso), `[108]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Serge Wolkner: ""It moves me to think about how many citizens' lives will..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just wait until it's completed, Sordland will make progress in leaps and bounds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Ewald Alphonso), `[107]` (Ewald Alphonso), `[108]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Serge Wolkner: ""It moves me to think about how many citizens' lives will..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Some of my ministers had concerns as well. But I believe the H-3 was a solid investment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Ewald Alphonso), `[107]` (Ewald Alphonso), `[108]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Serge Wolkner: ""It moves me to think about how many citizens' lives will..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a symbol of Sordland's past as well as its future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Ewald Alphonso), `[139]` (Ewald Alphonso), `[141]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Serge Wolkner: ""I can't imagine what it must be like to live here. Somet..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It shows the complexity of our nation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Ewald Alphonso), `[139]` (Ewald Alphonso), `[141]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Serge Wolkner: ""I can't imagine what it must be like to live here. Somet..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There are some issues, but with your foundation, you're already making a difference.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Ewald Alphonso), `[139]` (Ewald Alphonso), `[141]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Serge Wolkner: ""I can't imagine what it must be like to live here. Somet..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just wait until it's completed. Logistical operations in Sordland will never be the same again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Ewald Alphonso), `[127]` (Ewald Alphonso), `[129]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Serge Wolkner: ""A revolutionary vision from a visionary president.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, it's ambitious. But great change often requires bold decisions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Ewald Alphonso), `[127]` (Ewald Alphonso), `[129]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Serge Wolkner: ""A revolutionary vision from a visionary president.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your man Gus Manger made an especially convincing case for the railway's construction. I hope he was right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Ewald Alphonso), `[127]` (Ewald Alphonso), `[129]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Serge Wolkner: ""A revolutionary vision from a visionary president.""*)

### Węzeł `[118]`
Mówca: **Narrator**
> "I peered out the window at the looming cityscape of Lachaven was quickly enlarging. The sea was visible in the distance, its blue surface dotted with cargo ships."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Friendly == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Ewald Alphonso: ""The L-1 railway. Now that's a project I can stand behind.""*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Friendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Neutral == true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Neutral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Neutral == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Neutral == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Neutral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Neutral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Ewald Alphonso: ""An ambitious project, to be sure. But you'll need to ens..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Neutral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Neutral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Ewald Alphonso: ""The L-1 railway... quite an investment. I hope it will n..."*)

### Węzeł `[125]`
Mówca: **Ewald Alphonso**
> ""An ambitious project, to be sure. But you'll need to ensure it doesn't become a white elephant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Ewald Alphonso: ""It's a fine line you're treading.""*)

### Węzeł `[126]`
Mówca: **Ewald Alphonso**
> ""The L-1 railway... quite an investment. I hope it will not turn out to be a financial burden in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""Just wait until it's completed. Logistical operations in..."*)
  - -> `[116]` (*Player: ""Yes, it's ambitious. But great change often requires bol..."*)
  - -> `[117]` (*Player: ""Your man Gus Manger made an especially convincing case f..."*)

### Węzeł `[127]`
Mówca: **Ewald Alphonso**
> ""It's a fine line you're treading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""Just wait until it's completed. Logistical operations in..."*)
  - -> `[116]` (*Player: ""Yes, it's ambitious. But great change often requires bol..."*)
  - -> `[117]` (*Player: ""Your man Gus Manger made an especially convincing case f..."*)

### Węzeł `[128]`
Mówca: **Ewald Alphonso**
> ""The L-1 railway. Now that's a project I can stand behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Ewald Alphonso: ""It's not only efficient, it's a statement. It shows that..."*)

### Węzeł `[129]`
Mówca: **Ewald Alphonso**
> ""It's not only efficient, it's a statement. It shows that Sordland is ready for the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: ""Just wait until it's completed. Logistical operations in..."*)
  - -> `[116]` (*Player: ""Yes, it's ambitious. But great change often requires bol..."*)
  - -> `[117]` (*Player: ""Your man Gus Manger made an especially convincing case f..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Friendly == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ewald Alphonso: ""Ah, Lachaven... ‘The Gateway of Sordland’.""*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Friendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Neutral == true"*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Neutral == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Neutral == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Neutral == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Neutral == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Neutral"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Ewald Alphonso: ""What a city. It nearly brings me to tears every time I s..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Neutral == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Neutral"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Ewald Alphonso: ""Lachaven... it's a symbol of our nation, in both a good ..."*)

### Węzeł `[136]`
Mówca: **Ewald Alphonso**
> ""What a city. It nearly brings me to tears every time I see it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Ewald Alphonso: ""But Lachaven has its issues, like any other city. We mus..."*)

### Węzeł `[137]`
Mówca: **Ewald Alphonso**
> ""Lachaven... it's a symbol of our nation, in both a good and bad way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Ewald Alphonso: ""Wealth and poverty, side by side... it's a stark reminde..."*)

### Węzeł `[138]`
Mówca: **Ewald Alphonso**
> ""But Lachaven has its issues, like any other city. We mustn't forget that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: ""It's a symbol of Sordland's past as well as its future.""*)
  - -> `[113]` (*Player: ""It shows the complexity of our nation.""*)
  - -> `[114]` (*Player: ""There are some issues, but with your foundation, you're ..."*)
  - -> `[394]` (*Player: ""Its wealth disparities concern me. This place needs our ..."*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)

### Węzeł `[139]`
Mówca: **Ewald Alphonso**
> ""Wealth and poverty, side by side... it's a stark reminder of how much work people like us have left to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: ""It's a symbol of Sordland's past as well as its future.""*)
  - -> `[113]` (*Player: ""It shows the complexity of our nation.""*)
  - -> `[114]` (*Player: ""There are some issues, but with your foundation, you're ..."*)
  - -> `[394]` (*Player: ""Its wealth disparities concern me. This place needs our ..."*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)

### Węzeł `[140]`
Mówca: **Ewald Alphonso**
> ""Ah, Lachaven... ‘The Gateway of Sordland’.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Ewald Alphonso: ""It truly is the heart of our nation.""*)

### Węzeł `[141]`
Mówca: **Ewald Alphonso**
> ""It truly is the heart of our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: ""It's a symbol of Sordland's past as well as its future.""*)
  - -> `[113]` (*Player: ""It shows the complexity of our nation.""*)
  - -> `[114]` (*Player: ""There are some issues, but with your foundation, you're ..."*)
  - -> `[394]` (*Player: ""Its wealth disparities concern me. This place needs our ..."*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)

### Węzeł `[142]`
Mówca: **Serge Wolkner**
> ""My apologies, gentlemen. I didn't mean to dominate the conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == false"*)
  - -> `[147]` (*Player: ""Who needs Nouman's entertainment when we can listen to S..."*)
  - -> `[148]` (*Player: ""No need to apologize, Serge. It's always a pleasure to l..."*)
  - -> `[149]` (*Player: ""That's quite all right. But I do have a few more things ..."*)

### Węzeł `[143]`
Mówca: **Serge Wolkner**
> ""It moves me to think about how many citizens' lives will change because of your project, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Serge Wolkner: ""My apologies, gentlemen. I didn't mean to dominate the c..."*)

### Węzeł `[144]`
Mówca: **Serge Wolkner**
> ""A revolutionary vision from a visionary president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Serge Wolkner: ""My apologies, gentlemen. I didn't mean to dominate the c..."*)

### Węzeł `[145]`
Mówca: **Serge Wolkner**
> ""I can't imagine what it must be like to live here. Something exciting happening every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Serge Wolkner: ""My apologies, gentlemen. I didn't mean to dominate the c..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You prefer to keep things professional, right? Let's do that going forward.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Serge_Friend"] == false`
- **Kontekst wejściowy (poprzednik):** `[142]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Serge Wolkner: ""Understood, Mr. President. I'll make sure to keep that i..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Who needs Nouman's entertainment when we can listen to Serge Wolkner rhapsodizing about Sordland?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Serge Wolkner: ""It's true, Mr. President. I couldn't stay silent in the ..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No need to apologize, Serge. It's always a pleasure to listen to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Serge Wolkner: ""I appreciate you saying that, Mr. President. Sordland ha..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's quite all right. But I do have a few more things I'd like to bring up with Mr. Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Serge Wolkner)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Serge Wolkner: ""Certainly, Mr. President.""*)

### Węzeł `[150]`
Mówca: **Serge Wolkner**
> ""Understood, Mr. President. I'll make sure to keep that in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Ewald Alphonso: ""We're approximately 25 minutes away from the Blue Mansio..."*)

### Węzeł `[151]`
Mówca: **Serge Wolkner**
> ""It's true, Mr. President. I couldn't stay silent in the face of such a beautiful sight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Ewald Alphonso: ""We're approximately 25 minutes away from the Blue Mansio..."*)

### Węzeł `[152]`
Mówca: **Serge Wolkner**
> ""I appreciate you saying that, Mr. President. Sordland has always been my great love.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Ewald Alphonso: ""We're approximately 25 minutes away from the Blue Mansio..."*)

### Węzeł `[153]`
Mówca: **Serge Wolkner**
> ""Certainly, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Ewald Alphonso: ""We're approximately 25 minutes away from the Blue Mansio..."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "As we began our descent towards the Blue Mansion, Alphonso shifted the conversation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Ewald Alphonso: ""One last thing before we land. I've been hearing noise a..."*)

### Węzeł `[155]`
Mówca: **Ewald Alphonso**
> ""We're approximately 25 minutes away from the Blue Mansion State Building, {BaseGameText.AlphonsoToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "I peered out the window at the looming cityscape of Lacha..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Ewald Alphonso: ""I'm sure that you agree it's important to maintain auton..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Ewald Alphonso: ""I worry that Sordland's unwillingness to invest in its o..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBe..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Ewald Alphonso: ""Following our earlier conversation, I've been contemplat..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == ..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Ewald Alphonso: ""Based on our earlier discussion, I'm going to push for a..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Ewald Alphonso: ""In light of our discussion today, I've been thinking abo..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Ewald Alphonso: ""As for Gasom itself, we need to focus on maintaining our..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That sounds promising. These initiatives could significantly improve workers' lives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Ewald Alphonso: ""Thank you. I believe the same.""*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's an ambitious plan. I hope you can execute it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Ewald Alphonso: ""I share your sentiment. It's time to turn these ideas in..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ..."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Ewald Alphonso: ""I can't thank you enough for Sordland's heavy investment..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Ewald Alphonso: ""Mr. President, this strategic partnership with Rizia in ..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Ewald Alphonso: ""I'm especially concerned now that it's become clear that..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Ewald Alphonso: ""You've already agreed that you won't further tighten the..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[179]`
Mówca: **Ewald Alphonso**
> ""I can't thank you enough for Sordland's heavy investment in Gasom. Thanks to you, we'll be able to expand operations enough to meet both Sordish and global demand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Ewald Alphonso: ""With that stage set, I believe an increase in the foreig..."*)

### Węzeł `[180]`
Mówca: **Ewald Alphonso**
> ""Galmland, Qinal, and Anraka have all indicated their willingness to invest. If we were to eventually remove the EPA, the influx of foreign money could lead to significant profit for the state in the next round of investments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player: ""It's a bold move, but it could indeed create an economic..."*)
  - -> `[182]` (*Player: ""We must also consider the potential risks. Aren't you wo..."*)
  - -> `[185]` (*Player: ""Your argument is compelling, but it's a complex issue. I..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a bold move, but it could indeed create an economic upswing. I'll consider raising the foreign ownership limit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Ewald Alphonso: ""I'm glad to hear that, Mr. President. This could mark a ..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We must also consider the potential risks. Aren't you worried that increasing foreign ownership could lead to less control over our energy resources?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Ewald Alphonso: ""Maintaining control and ensuring energy security are ind..."*)

### Węzeł `[183]`
Mówca: **Ewald Alphonso**
> ""I'm glad to hear that, Mr. President. This could mark a new era of prosperity for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Ewald Alphonso: ""Our foundation is strong, and our potential is limitless.""*)

### Węzeł `[184]`
Mówca: **Ewald Alphonso**
> ""Maintaining control and ensuring energy security are indeed important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Ewald Alphonso: ""However, with the right regulatory framework, we can do ..."*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your argument is compelling, but it's a complex issue. I'll consider your recommendation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Ewald Alphonso: ""I appreciate your open-mindedness, Mr. President. All I ..."*)

### Węzeł `[186]`
Mówca: **Ewald Alphonso**
> ""I appreciate your open-mindedness, Mr. President. All I ask is that we approach this with a clear vision of the economic potential it could unlock for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Ewald Alphonso: ""Our foundation is strong, and our potential is limitless.""*)

### Węzeł `[187]`
Mówca: **Ewald Alphonso**
> ""Mr. President, this strategic partnership with Rizia in Gasom is a promising step forward. It allows us to spread the initial risks and invites additional interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Ewald Alphonso: ""Their 15 percent stake is a fair deal. But I believe we ..."*)

### Węzeł `[188]`
Mówca: **Ewald Alphonso**
> ""Of course they'd be a controversial partner, but as long as they hold a minority stake, we shouldn't face any significant issues. Qinal is also showing interest, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: ""I understand your points, Mr. Alphonso, but we need to c..."*)
  - -> `[190]` (*Player: ""Mr. Alphonso, don't you think we're gambling a bit too m..."*)
  - -> `[193]` (*Player: ""This is a bold move. But it could indeed provide a much-..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your points, Mr. Alphonso, but we need to consider national security. Inviting multiple foreign powers into Sordland's energy sector could lead to problems down the line.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Ewald Alphonso: ""National security is paramount, {BaseGameText.AlphonsoTo..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Alphonso, don't you think we're gambling a bit too much with the future of our energy sector? What if Rumburg decides to use their stake for political leverage?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Ewald Alphonso: ""Rumburg's involvement could indeed be a double-edged swo..."*)

### Węzeł `[191]`
Mówca: **Ewald Alphonso**
> ""National security is paramount, {BaseGameText.AlphonsoToPlayer}. But we also need to consider the economic potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Ewald Alphonso: ""Don't forget that Rizia holds only a minority stake and ..."*)

### Węzeł `[192]`
Mówca: **Ewald Alphonso**
> ""Rumburg's involvement could indeed be a double-edged sword. But we must remember that their stake would be a minority one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Ewald Alphonso: ""In business, a certain level of risk is unavoidable. Wit..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is a bold move. But it could indeed provide a much-needed boost to our economy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Ewald Alphonso: ""In my experience, fortune favors the bold. We're not onl..."*)

### Węzeł `[194]`
Mówca: **Ewald Alphonso**
> ""In my experience, fortune favors the bold. We're not only securing Gasom's future but also placing Sordland on the global energy map.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Ewald Alphonso: ""Don't forget that Rizia holds only a minority stake and ..."*)

### Węzeł `[195]`
Mówca: **Ewald Alphonso**
> ""I'm especially concerned now that it's become clear that Sordland is abandoning Gasom to its fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Ewald Alphonso: ""Rizia's 20 percent investment will keep us afloat for a ..."*)

### Węzeł `[196]`
Mówca: **Ewald Alphonso**
> ""And that's not a prospect I relish. We're truly caught between a rock and a hard place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player: ""I must say I'm disappointed that we are in this situatio..."*)
  - -> `[198]` (*Player: ""You're Gasom's chair. Can't you find a way  to save the ..."*)
  - -> `[200]` (*Player: ""This conversation seems to revolve around accommodating ..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I must say I'm disappointed that we are in this situation. As the chair of Gasom, you should have anticipated these challenges.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Ewald Alphonso: ""Yes, the situation is far from ideal. But I assure you, ..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're Gasom's chair. Can't you find a way  to save the company without risking our sovereignty?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Ewald Alphonso: ""We could consider other avenues like public-private part..."*)

### Węzeł `[199]`
Mówca: **Ewald Alphonso**
> ""Yes, the situation is far from ideal. But I assure you, we've done our best under the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Ewald Alphonso: ""The question now is, how do we move forward? And that's ..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This conversation seems to revolve around accommodating foreign investors rather than serving Sordland. We shouldn't prioritize the interests of capitalists over our own citizens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Ewald Alphonso: ""Capital is a tool. Used properly, it can bring prosperit..."*)

### Węzeł `[201]`
Mówca: **Ewald Alphonso**
> ""Capital is a tool. Used properly, it can bring prosperity and create jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Ewald Alphonso: ""Our challenge is to control it, not let it control us.""*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Helicopter");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Helicopter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "Alphonso had been quiet for most of the journey, but as w..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Mountains");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Mountains");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "The low rumble of the helicopter's engines reverberated t..."*)

### Węzeł `[204]`
Mówca: **Ewald Alphonso**
> ""I worry that Sordland's unwillingness to invest in its own gas company might be perceived as a sign of weakness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: ""Our strength is not measured by how much we invest, but ..."*)
  - -> `[206]` (*Player: ""We're showing that we can't be bought or influenced by m..."*)
  - -> `[207]` (*Player: ""Strength can also mean resisting the urge to chase after..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our strength is not measured by how much we invest, but how wisely we use our resources.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Ewald Alphonso: ""Wise words, Mr. President, but if you truly believed the..."*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We're showing that we can't be bought or influenced by money.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Ewald Alphonso: ""A strong stance. But we must also remember that money is..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Strength can also mean resisting the urge to chase after every opportunity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Ewald Alphonso: ""Perhaps. We'll have to see how this approach pans out.""*)

### Węzeł `[208]`
Mówca: **Ewald Alphonso**
> ""Wise words, Mr. President, but if you truly believed them, you would have invested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "He looked out the window and yawned."*)

### Węzeł `[209]`
Mówca: **Ewald Alphonso**
> ""A strong stance. But we must also remember that money is a tool, and it can be used to shape our destiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "He looked out the window and yawned."*)

### Węzeł `[210]`
Mówca: **Ewald Alphonso**
> ""Perhaps. We'll have to see how this approach pans out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Narrator: "He looked out the window and yawned."*)

### Węzeł `[211]`
Mówca: **Ewald Alphonso**
> ""Your government's large investment in Gasom will undoubtedly drive our economy forward and give us a stronger position in the global market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: ""Exactly. We're setting a strong foundation for future gr..."*)
  - -> `[213]` (*Player: ""This is our chance to make Sordland a global leader in e..."*)
  - -> `[214]` (*Player: ""We're showing the world that Sordland is open for busine..."*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Exactly. We're setting a strong foundation for future growth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Ewald Alphonso: ""Indeed, {BaseGameText.AlphonsoToPlayer}. It's a move tha..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is our chance to make Sordland a global leader in energy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Ewald Alphonso: ""Absolutely, we're not just making an investment; we're m..."*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We're showing the world that Sordland is open for business.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Ewald Alphonso: ""That's right, {BaseGameText.AlphonsoToPlayer}. It's a st..."*)

### Węzeł `[215]`
Mówca: **Ewald Alphonso**
> ""Indeed, {BaseGameText.AlphonsoToPlayer}. It's a move that will echo positively in our history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Alphonso scribbled something on his notepad and passed it..."*)

### Węzeł `[216]`
Mówca: **Ewald Alphonso**
> ""Absolutely, we're not just making an investment; we're making a statement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Alphonso scribbled something on his notepad and passed it..."*)

### Węzeł `[217]`
Mówca: **Ewald Alphonso**
> ""That's right, {BaseGameText.AlphonsoToPlayer}. It's a strong message, and the world is certainly watching.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Alphonso scribbled something on his notepad and passed it..."*)

### Węzeł `[218]`
Mówca: **Ewald Alphonso**
> ""I'm sure that you agree it's important to maintain autonomy, even while co-investing with Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player: ""Agreed. We need to ensure our sovereignty isn't compromi..."*)
  - -> `[220]` (*Player: ""I see this as an opportunity to learn and grow together ..."*)
  - -> `[221]` (*Player: ""Our collaboration is a mere stepping stone to bigger and..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Agreed. We need to ensure our sovereignty isn't compromised.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Ewald Alphonso: ""Exactly, {BaseGameText.AlphonsoToPlayer}. Maintaining co..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I see this as an opportunity to learn and grow together with the Kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Ewald Alphonso: ""Indeed, we can definitely learn a lot from each other in..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our collaboration is a mere stepping stone to bigger and better opportunities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Ewald Alphonso: ""I share your optimism, Mr. President. The potential for ..."*)

### Węzeł `[222]`
Mówca: **Ewald Alphonso**
> ""Exactly, {BaseGameText.AlphonsoToPlayer}. Maintaining control is crucial, even as we build stronger alliances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Alphonso scribbled something on his notepad and passed it..."*)

### Węzeł `[223]`
Mówca: **Ewald Alphonso**
> ""Indeed, we can definitely learn a lot from each other in this partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Alphonso scribbled something on his notepad and passed it..."*)

### Węzeł `[224]`
Mówca: **Ewald Alphonso**
> ""I share your optimism, Mr. President. The potential for growth is certainly exciting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "Alphonso scribbled something on his notepad and passed it..."*)

### Węzeł `[225]`
Mówca: **Ewald Alphonso**
> ""I'm considering initiatives to provide private housing, health, and education support for our blue-collar workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player: ""As long as the workers are doing their jobs and Gasom is..."*)
  - -> `[168]` (*Player: ""That sounds promising. These initiatives could significa..."*)
  - -> `[169]` (*Player: ""That's an ambitious plan. I hope you can execute it.""*)
  - -> `[229]` (*Player: ""I'm glad you're thinking along these lines. I expect mor..."*)

### Węzeł `[226]`
Mówca: **Ewald Alphonso**
> ""We need to ensure they're receiving competitive compensation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Player: ""The financial situation of Gasom's employees is not my c..."*)
  - -> `[233]` (*Player: ""That's a step in the right direction. Fair wages are fun..."*)
  - -> `[234]` (*Player: ""I'm glad to hear that. As long as this review isn't mere..."*)
  - -> `[235]` (*Player: ""That's long overdue. I hope to see substantial improveme..."*)

### Węzeł `[227]`
Mówca: **Ewald Alphonso**
> ""I'm considering supporting local charities in Narbel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player: ""Your ideas are commendable, but they're not my priority.""*)
  - -> `[239]` (*Player: ""That's a positive direction. I hope to see Gasom leading..."*)
  - -> `[240]` (*Player: ""Good thinking. But remember, sustainability is more than..."*)
  - -> `[241]` (*Player: ""It's high time. I expect these considerations to transla..."*)

### Węzeł `[228]`
Mówca: **Ewald Alphonso**
> ""Our company will do its best with the means it has.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Player: ""As long as Gasom is doing well, I'm not concerned about ..."*)
  - -> `[245]` (*Player: ""I appreciate your concern for Gasom's economic contribut..."*)
  - -> `[246]` (*Player: ""That's a narrow view, Alphonso. As Gasom grows, its soci..."*)
  - -> `[247]` (*Player: ""Maintaining the status quo is not enough. Gasom needs to..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad you're thinking along these lines. I expect more than mere consideration, though.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Ewald Alphonso: ""You're absolutely right. It's about making these plans a..."*)

### Węzeł `[230]`
Mówca: **Ewald Alphonso**
> ""Thank you. I believe the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[231]`
Mówca: **Ewald Alphonso**
> ""I share your sentiment. It's time to turn these ideas into tangible actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[232]`
Mówca: **Ewald Alphonso**
> ""You're absolutely right. It's about making these plans a reality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a step in the right direction. Fair wages are fundamental to worker satisfaction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Ewald Alphonso: ""I agree. A satisfied workforce is a productive one.""*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad to hear that. As long as this review isn't merely a token gesture.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Ewald Alphonso: ""I assure you, this won't be just for show. We're committ..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's long overdue. I hope to see substantial improvements in their remuneration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Ewald Alphonso: ""I understand your concerns. We'll strive to make this re..."*)

### Węzeł `[236]`
Mówca: **Ewald Alphonso**
> ""I agree. A satisfied workforce is a productive one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[237]`
Mówca: **Ewald Alphonso**
> ""I assure you, this won't be just for show. We're committed to making real changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[238]`
Mówca: **Ewald Alphonso**
> ""I understand your concerns. We'll strive to make this review beneficial for our workers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a positive direction. I hope to see Gasom leading the way in corporate responsibility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Ewald Alphonso: ""Thank you. We hope to set a good example for other Sordi..."*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good thinking. But remember, sustainability is more than just philanthropy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Ewald Alphonso: ""Absolutely. We're looking at a comprehensive approach, b..."*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's high time. I expect these considerations to translate into substantial changes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Ewald Alphonso: ""Of course, {BaseGameText.AlphonsoToPlayer}. You can coun..."*)

### Węzeł `[242]`
Mówca: **Ewald Alphonso**
> ""Thank you. We hope to set a good example for other Sordish corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[243]`
Mówca: **Ewald Alphonso**
> ""Absolutely. We're looking at a comprehensive approach, beyond just charity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[244]`
Mówca: **Ewald Alphonso**
> ""Of course, {BaseGameText.AlphonsoToPlayer}. You can count on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I appreciate your concern for Gasom's economic contribution, but it's crucial not to overlook the welfare of the workers and the community.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Ewald Alphonso: ""I assure you that we always strive to balance business g..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's a narrow view, Alphonso. As Gasom grows, its social responsibilities should grow in tandem.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Ewald Alphonso: ""A valid point. We will need to reassess our priorities a..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Maintaining the status quo is not enough. Gasom needs to be a part of the solution, not the problem.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Ewald Alphonso: ""I appreciate your input, {BaseGameText.AlphonsoToPlayer}..."*)

### Węzeł `[248]`
Mówca: **Ewald Alphonso**
> ""I assure you that we always strive to balance business growth with social responsibility. It's the Gasom way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[249]`
Mówca: **Ewald Alphonso**
> ""A valid point. We will need to reassess our priorities as we move forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[250]`
Mówca: **Ewald Alphonso**
> ""I appreciate your input, {BaseGameText.AlphonsoToPlayer}. I'll take your thoughts into consideration as we plan for the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[251]`
Mówca: **Narrator**
> "He looked out the window and yawned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "Alphonso scribbled something on his notepad and passed it to one of his assistants in the helicopter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)

### Węzeł `[253]`
Mówca: **Ewald Alphonso**
> ""Following our earlier conversation, I've been contemplating how Gasom can play a larger role in supporting our workers and the community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Ewald Alphonso: ""I'm considering initiatives to provide private housing, ..."*)

### Węzeł `[254]`
Mówca: **Ewald Alphonso**
> ""Based on our earlier discussion, I'm going to push for a review of our workers' salaries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Ewald Alphonso: ""We need to ensure they're receiving competitive compensa..."*)

### Węzeł `[255]`
Mówca: **Ewald Alphonso**
> ""In light of our discussion today, I've been thinking about how Gasom can implement sustainable practices and enhance our community engagement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Ewald Alphonso: ""I'm considering supporting local charities in Narbel.""*)

### Węzeł `[256]`
Mówca: **Ewald Alphonso**
> ""As for Gasom itself, we need to focus on maintaining our current bottom line rather than stretching ourselves thin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Ewald Alphonso: ""Our company will do its best with the means it has.""*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As long as Gasom is doing well, I'm not concerned about how you choose to distribute your resources.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Ewald Alphonso: ""I appreciate your trust in Gasom's management.""*)

### Węzeł `[258]`
Mówca: **Ewald Alphonso**
> ""I appreciate your trust in Gasom's management.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The financial situation of Gasom's employees is not my concern. They're paid for their work, aren't they?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Ewald Alphonso: ""Yes, they are. Our company has some of the country's bes..."*)

### Węzeł `[260]`
Mówca: **Ewald Alphonso**
> ""Yes, they are. Our company has some of the country's best-paid engineering jobs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As long as the workers are doing their jobs and Gasom is profitable, I see no reason to change anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Ewald Alphonso: ""I appreciate your pragmatic approach. But investing in o..."*)

### Węzeł `[262]`
Mówca: **Ewald Alphonso**
> ""I appreciate your pragmatic approach. But investing in our workers' welfare can also lead to increased productivity and profitability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your ideas are commendable, but they're not my priority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Ewald Alphonso: ""I understand. But I do believe that more engagement with..."*)

### Węzeł `[264]`
Mówca: **Ewald Alphonso**
> ""I understand. But I do believe that more engagement with the community around us will have a positive impact on our productivity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "We were hovering over Lachaven now. The entire city was v..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "Republic Avenue stretched directly beneath us, a grand boulevard lined with palm trees and decorated with sculptures. Even from this height, landmarks like the Evaria Gallery of Art, the Maroon Theatre, and the Lachaven Opera House were discernible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "As we began our descent towards the Blue Mansion, Alphons..."*)

### Węzeł `[266]`
Mówca: **Narrator**
> "We were hovering over Lachaven now. The entire city was visible below us, its activity concentrated on its bustling port."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "I cast my gaze over the harbor teeming with ships and the..."*)

### Węzeł `[267]`
Mówca: **Ewald Alphonso**
> ""One last thing before we land. I've been hearing noise about your administration making changes to the Energy Protection Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Ewald Alphonso: ""You might remember that I struggled to repeal it during ..."*)

### Węzeł `[268]`
Mówca: **Ewald Alphonso**
> ""You might remember that I struggled to repeal it during my term, and that said struggle was in vain. The Energy Protection Act of 1932 remains in force, and the restrictions on foreign ownership of energy companies in Sordland persist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Ewald Alphonso: ""The vote was 179 against the repeal to 71 in favor. The ..."*)

### Węzeł `[269]`
Mówca: **Ewald Alphonso**
> ""The vote was 179 against the repeal to 71 in favor. The status quo prevailed, as it has to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player: ""I understand why you sponsored the motion. But you of al..."*)
  - -> `[271]` (*Player: ""The defeat of the repeal was a setback for our plans to ..."*)
  - -> `[272]` (*Player: ""I'm glad the repeal was defeated. We should not open our..."*)
  - -> `[273]` (*Player: ""The defeat of the repeal wasn't surprising given the pol..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand why you sponsored the motion. But you of all people should understand the importance of protecting Sordland's crucial energy sector.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Ewald Alphonso: ""Of course I do. But I also understand that the right amo..."*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The defeat of the repeal was a setback for our plans to liberalize the economy. We must strategize and push for it in the next Assembly session.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Ewald Alphonso: ""I agree. It's clear that you'll need a different approac..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad the repeal was defeated. We should not open our energy sector to foreign control. We must prioritize Sordland's sovereignty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Ewald Alphonso: ""I still believe that the repeal would have attracted muc..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The defeat of the repeal wasn't surprising given the political climate. I'd rather focus my efforts elsewhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Ewald Alphonso: ""We must be pragmatic and pick our battles. This is *the*..."*)

### Węzeł `[274]`
Mówca: **Ewald Alphonso**
> ""Of course I do. But I also understand that the right amount of foreign investment could rejuvenate both our energy sector and our economy as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)

### Węzeł `[275]`
Mówca: **Ewald Alphonso**
> ""I agree. It's clear that you'll need a different approach to win over the majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)

### Węzeł `[276]`
Mówca: **Ewald Alphonso**
> ""I still believe that the repeal would have attracted much-needed foreign investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)

### Węzeł `[277]`
Mówca: **Ewald Alphonso**
> ""We must be pragmatic and pick our battles. This is *the* battle to fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true"*)

### Węzeł `[278]`
Mówca: **Ewald Alphonso**
> ""I'm still mulling over the implications of your investment decision, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone ==..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Gasom Invest Choice Talk`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Ewald Alphonso: ""I'm still mulling over the implications of your investme..."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "I cast my gaze over the harbor teeming with ships and the distinctive buildings of downtown. Their Lespian-style architecture lent the skyline a flavor unlike anywhere else in Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "Republic Avenue stretched directly beneath us, a grand bo..."*)

### Węzeł `[281]`
Mówca: **Ewald Alphonso**
> ""With that stage set, I believe an increase in the foreign ownership limit to 49% under the Energy Protection Act would attract considerable international investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Ewald Alphonso: ""Galmland, Qinal, and Anraka have all indicated their wil..."*)

### Węzeł `[282]`
Mówca: **Ewald Alphonso**
> ""However, with the right regulatory framework, we can do both while still benefiting from foreign investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Ewald Alphonso: ""Our foundation is strong, and our potential is limitless.""*)

### Węzeł `[283]`
Mówca: **Ewald Alphonso**
> ""Our foundation is strong, and our potential is limitless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Player: ""I agree, Mr. Alphonso. With the state on board, Gasom's ..."*)
  - -> `[285]` (*Player: ""You still haven't convinced me. But consider Sordland's ..."*)
  - -> `[286]` (*Player: ""Gasom's future certainly looks promising, but the decisi..."*)
  - -> `[287]` (*Player: ""I'm not so sure, Mr. Alphonso. We mustn't become over-re..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I agree, Mr. Alphonso. With the state on board, Gasom's future will be bright.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Ewald Alphonso: ""I appreciate your optimism, {BaseGameText.AlphonsoToPlay..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You still haven't convinced me. But consider Sordland's investment a vote of confidence for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Ewald Alphonso: ""Of course, {BaseGameText.AlphonsoToPlayer}. I will.""*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Gasom's future certainly looks promising, but the decision about the EPA is a complicated one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Ewald Alphonso: ""Absolutely, Mr. President. Give it all the time you need.""*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not so sure, Mr. Alphonso. We mustn't become over-reliant on Gasom or overly susceptible to foreign influence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Ewald Alphonso: ""I understand your concerns, Mr. President. It's certainl..."*)

### Węzeł `[288]`
Mówca: **Ewald Alphonso**
> ""I understand your concerns, Mr. President. It's certainly a complex situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Suddenly, the former president's attention shifted as the..."*)

### Węzeł `[289]`
Mówca: **Ewald Alphonso**
> ""Absolutely, Mr. President. Give it all the time you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Suddenly, the former president's attention shifted as the..."*)

### Węzeł `[290]`
Mówca: **Ewald Alphonso**
> ""Of course, {BaseGameText.AlphonsoToPlayer}. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Suddenly, the former president's attention shifted as the..."*)

### Węzeł `[291]`
Mówca: **Ewald Alphonso**
> ""I appreciate your optimism, {BaseGameText.AlphonsoToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Suddenly, the former president's attention shifted as the..."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "Suddenly, the former president's attention shifted as the pilot announced our landing over the intercom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Ewald Alphonso: ""That'll be it then, {BaseGameText.AlphonsoToPlayer}. I u..."*)

### Węzeł `[293]`
Mówca: **Ewald Alphonso**
> ""That'll be it then, {BaseGameText.AlphonsoToPlayer}. I urge you to remain seated. These landings can be bumpy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Serge Wolkner: ""Thank you again for your assistance with the helicopter,..."*)

### Węzeł `[294]`
Mówca: **Serge Wolkner**
> ""Thank you again for your assistance with the helicopter, Mr. Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Ewald Alphonso: ""Thank you for your fine company, Mr. Wolkner.""*)

### Węzeł `[295]`
Mówca: **Ewald Alphonso**
> ""Thank you for your fine company, Mr. Wolkner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "The helicopter gradually reduced its speed, hovering for ..."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "The ground crew and Presidential Guard hurried to secure the landing site as Serge and I disembarked. Glancing back, I caught a final glimpse of Alphonso inside the helicopter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[297]`
Mówca: **Narrator**
> "In a sudden rush of air and sound, the helicopter lifted off, headed towards the Gasom headquarters in the heart of Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "I watched as it disappeared into the cityscape, swallowed..."*)

### Węzeł `[298]`
Mówca: **Narrator**
> "I watched as it disappeared into the cityscape, swallowed by the luminous glow of the Lachaven skyline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Friendly == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "He winked."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Friendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)

### Węzeł `[302]`
Mówca: **Narrator**
> "He winked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "In a sudden rush of air and sound, the helicopter lifted ..."*)

### Węzeł `[303]`
Mówca: **Narrator**
> "He looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "In a sudden rush of air and sound, the helicopter lifted ..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Discontent == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Narrator: "He looked away."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Discontent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "A mutual nod of acknowledgement passed between us."*)

### Węzeł `[307]`
Mówca: **Narrator**
> "A mutual nod of acknowledgement passed between us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "In a sudden rush of air and sound, the helicopter lifted ..."*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good evening, Mr. Alphonso. It was a productive discussion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good talking to you, Mr. Alphonso.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was a pleasure, Mr. Alphonso. Goodbye.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Friendly == true)"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Friendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Friendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Ewald Alphonso: ""Thank you for a stimulating discussion, {BaseGameText.Al..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Friendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Friendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Discontent == true"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Ewald_Discontent == true)"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Ewald_Discontent == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Ewald Alphonso: ""Thank you for your time, Mr. President. I do hope that o..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Ewald_Discontent == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Ewald Alphonso: ""It was a pleasure discussing these matters with you, Mr...."*)

### Węzeł `[317]`
Mówca: **Ewald Alphonso**
> ""Thank you for a stimulating discussion, {BaseGameText.AlphonsoToPlayer}. I have high hopes for Sordland's future, and for the continuation of the work we began during my presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Ewald Alphonso: ""Here's to a prosperous future for Sordland, Gasom, and t..."*)

### Węzeł `[318]`
Mówca: **Ewald Alphonso**
> ""Thank you for your time, Mr. President. I do hope that our discussion has given you some perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Ewald Alphonso: ""I didn't steer Gasom through tumultuous times and lead S..."*)

### Węzeł `[319]`
Mówca: **Ewald Alphonso**
> ""It was a pleasure discussing these matters with you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Ewald Alphonso: ""It's not easy to run a country while preserving one's le..."*)

### Węzeł `[320]`
Mówca: **Ewald Alphonso**
> ""I didn't steer Gasom through tumultuous times and lead Sordland through a critical phase of its history only to watch my legacy disintegrate. I trust you understand the stakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Ewald Alphonso: ""I look forward to seeing how your decisions will shape o..."*)

### Węzeł `[321]`
Mówca: **Ewald Alphonso**
> ""It's not easy to run a country while preserving one's legacy. I trust that you will take our conversation to heart as you steer Sordland into the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Ewald Alphonso: ""We will be in touch.""*)

### Węzeł `[322]`
Mówca: **Ewald Alphonso**
> ""Here's to a prosperous future for Sordland, Gasom, and the legacy we leave behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Ewald Alphonso: ""We will be in touch.""*)

### Węzeł `[323]`
Mówca: **Ewald Alphonso**
> ""I look forward to seeing how your decisions will shape our nation's future. We're fighting against the current, but I believe we can change the tide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "The ground crew and Presidential Guard hurried to secure ..."*)

### Węzeł `[324]`
Mówca: **Ewald Alphonso**
> ""We will be in touch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "The ground crew and Presidential Guard hurried to secure ..."*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not bumpy at all. I appreciate the lift.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Ewald_Friendly == true"*)

### Węzeł `[326]`
Mówca: **Ewald Alphonso**
> ""Their 15 percent stake is a fair deal. But I believe we could attract even larger international investments if the EPA is removed. Imagine the potential if Rumburg joined in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Ewald Alphonso: ""Of course they'd be a controversial partner, but as long..."*)

### Węzeł `[327]`
Mówca: **Ewald Alphonso**
> ""Don't forget that Rizia holds only a minority stake and we still have control over Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Ewald Alphonso: ""Were Rumburg to get involved, they would be limited to a..."*)

### Węzeł `[328]`
Mówca: **Ewald Alphonso**
> ""In business, a certain level of risk is unavoidable. With the right safeguards, we can mitigate these risks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Player: ""Your confidence is reassuring. However, how can we ensur..."*)
  - -> `[330]` (*Player: ""I share your views. However, I do worry about a potentia..."*)
  - -> `[331]` (*Player: ""I am still concerned about the implications of letting f..."*)
  - -> `[332]` (*Player: ""The changes we make to the Energy Protection Act will ha..."*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your confidence is reassuring. However, how can we ensure that Rumburg won't attempt to gain more influence over time?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Ewald Alphonso), `[374]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Ewald Alphonso: ""That's a risk we'll have to manage. Regular reviews and ..."*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I share your views. However, I do worry about a potential backlash. The prospect of Rumburg buying a stake in our energy sector might not sit well with the public.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Ewald Alphonso), `[374]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Ewald Alphonso: ""Public opinion is a vital factor, Mr. President. However..."*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am still concerned about the implications of letting foreign entities have a stake in our energy sector. Isn't there a way to boost our economy without compromising our sovereignty?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Ewald Alphonso), `[374]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Ewald Alphonso: ""As I've said before, it's a matter of striking the right..."*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The changes we make to the Energy Protection Act will have long-lasting implications for our nation's future. I can't decide this in a helicopter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Ewald Alphonso), `[374]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Ewald Alphonso: ""Take all the time you need, {BaseGameText.AlphonsoToPlay..."*)

### Węzeł `[333]`
Mówca: **Ewald Alphonso**
> ""Take all the time you need, {BaseGameText.AlphonsoToPlayer}. These are not decisions to be made lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Ewald Alphonso: ""I trust your judgement in making the right call for our ..."*)

### Węzeł `[334]`
Mówca: **Ewald Alphonso**
> ""As I've said before, it's a matter of striking the right balance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Ewald Alphonso: ""Foreign investment can boost our economy, and as long as..."*)

### Węzeł `[335]`
Mówca: **Ewald Alphonso**
> ""Public opinion is a vital factor, Mr. President. However, in my experience, people often resist change initially.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Ewald Alphonso: ""Once they see the economic benefits, they usually come a..."*)

### Węzeł `[336]`
Mówca: **Ewald Alphonso**
> ""That's a risk we'll have to manage. Regular reviews and stringent regulations can help keep their influence in check.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Suddenly, the former president's attention shifted as the..."*)

### Węzeł `[337]`
Mówca: **Ewald Alphonso**
> ""Once they see the economic benefits, they usually come around. We have to be transparent and communicate our intentions clearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Suddenly, the former president's attention shifted as the..."*)

### Węzeł `[338]`
Mówca: **Ewald Alphonso**
> ""Foreign investment can boost our economy, and as long as we ensure that our nation's interests are protected, I believe it's a risk worth taking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Suddenly, the former president's attention shifted as the..."*)

### Węzeł `[339]`
Mówca: **Ewald Alphonso**
> ""I trust your judgement in making the right call for our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Suddenly, the former president's attention shifted as the..."*)

### Węzeł `[340]`
Mówca: **Ewald Alphonso**
> ""Rizia's 20 percent investment will keep us afloat for a while, but it won't be enough. Any further tightening of the EPA restrictions will spell disaster for Gasom, possibly even leading to bankruptcy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Ewald Alphonso: ""On the other hand, loosening those restrictions too much..."*)

### Węzeł `[341]`
Mówca: **Ewald Alphonso**
> ""The question now is, how do we move forward? And that's something we need to figure out together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Ewald Alphonso: ""It's a bitter pill to swallow, knowing that all of this ..."*)

### Węzeł `[342]`
Mówca: **Ewald Alphonso**
> ""We could consider other avenues like public-private partnerships or exploring new markets, but these options come with their own risks and uncertainties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Ewald Alphonso: ""It's a bitter pill to swallow, knowing that all of this ..."*)

### Węzeł `[343]`
Mówca: **Ewald Alphonso**
> ""Our challenge is to control it, not let it control us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Ewald Alphonso: ""It's a bitter pill to swallow, knowing that all of this ..."*)

### Węzeł `[344]`
Mówca: **Ewald Alphonso**
> ""It's a bitter pill to swallow, knowing that all of this could have been avoided.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player: ""Our resources are not infinite. We must prioritize, and ..."*)
  - -> `[346]` (*Player: ""We have to remember the importance of keeping our energy..."*)
  - -> `[349]` (*Player: ""While I sympathize with your position, the reality is th..."*)
  - -> `[355]` (*Player: ""Mr. Alphonso, I'm aware of the gravity of the situation...."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Our resources are not infinite. We must prioritize, and sometimes, tough calls have to be made.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Ewald Alphonso: ""I understand the constraints you're under, Mr. President.""*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have to remember the importance of keeping our energy sector secure. The idea of Rumburg gaining significant influence is worrisome.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Ewald Alphonso: ""I share your concerns about Rumburg, Mr. President.""*)

### Węzeł `[347]`
Mówca: **Ewald Alphonso**
> ""I understand the constraints you're under, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Ewald Alphonso: ""I just hope we can navigate through this and find a solu..."*)

### Węzeł `[348]`
Mówca: **Ewald Alphonso**
> ""I share your concerns about Rumburg, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Ewald Alphonso: ""But I believe that with careful consideration, we can fi..."*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""While I sympathize with your position, the reality is that we had to make some hard choices.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Ewald Alphonso: ""I'm not sure if I trust your judgement, Mr. President.""*)

### Węzeł `[350]`
Mówca: **Ewald Alphonso**
> ""I'm not sure if I trust your judgement, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Ewald Alphonso: ""I just hope that we can find a solution that ensures Gas..."*)

### Węzeł `[351]`
Mówca: **Ewald Alphonso**
> ""I just hope we can navigate through this and find a solution that doesn't jeopardize Gasom or Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Ewald Alphonso: ""At the very least, I ask you to consider increasing the ..."*)

### Węzeł `[352]`
Mówca: **Ewald Alphonso**
> ""But I believe that with careful consideration, we can find a way forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Ewald Alphonso: ""At the very least, I ask you to consider increasing the ..."*)

### Węzeł `[353]`
Mówca: **Ewald Alphonso**
> ""I just hope that we can find a solution that ensures Gasom's survival without compromising Sordland's interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Ewald Alphonso: ""At the very least, I ask you to consider increasing the ..."*)

### Węzeł `[354]`
Mówca: **Ewald Alphonso**
> ""On the other hand, loosening those restrictions too much will allow foreign entities like Rumburg to acquire a majority stake in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Ewald Alphonso: ""And that's not a prospect I relish. We're truly caught b..."*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Alphonso, I'm aware of the gravity of the situation. But we must not rush into decisions that could risk our sovereignty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Ewald Alphonso: ""Indeed, Mr. President. We must not be too hasty.""*)

### Węzeł `[356]`
Mówca: **Ewald Alphonso**
> ""Indeed, Mr. President. We must not be too hasty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Ewald Alphonso: ""It's a delicate situation, and the decisions we make now..."*)

### Węzeł `[357]`
Mówca: **Ewald Alphonso**
> ""It's a delicate situation, and the decisions we make now will have lasting implications for our nation's future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Ewald Alphonso: ""At the very least, I ask you to consider increasing the ..."*)

### Węzeł `[358]`
Mówca: **Ewald Alphonso**
> ""At the very least, I ask you to consider increasing the foreign investment cap to 49%. It might not be the perfect solution, but it could provide the lifeline Gasom needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Ewald Alphonso: ""For old times' sake, let's work together to ensure Gasom..."*)

### Węzeł `[359]`
Mówca: **Ewald Alphonso**
> ""For old times' sake, let's work together to ensure Gasom doesn't become a casualty of our decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player: ""It's a compromise that could save Gasom without compromi..."*)
  - -> `[361]` (*Player: ""Tightening the EPA laws further may be a necessary step ..."*)
  - -> `[362]` (*Player: ""Not my decisions, Mr. Alphonso. Yours.""*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a compromise that could save Gasom without compromising our sovereignty too much. I'll consider it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Suddenly, the former president's attention shifted as the..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tightening the EPA laws further may be a necessary step for our future, even if it poses challenges for Gasom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Suddenly, the former president's attention shifted as the..."*)

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not my decisions, Mr. Alphonso. Yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[359]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "Suddenly, the former president's attention shifted as the..."*)

### Węzeł `[363]`
Mówca: **Narrator**
> "The low rumble of the helicopter's engines reverberated through the cabin as we soared over the vast expanse of Nargis."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "A patchwork of verdant fields, sprawling forests, and unt..."*)

### Węzeł `[364]`
Mówca: **Ewald Alphonso**
> ""Now that we've escaped an angry mob together, may I call you Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Player: ""Of course, Ewald. You don't even need to ask.""*)
  - -> `[366]` (*Player: ""I'd rather keep things on the professional level, if you..."*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course, Ewald. You don't even need to ask.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGameText.AlphonsoToPlayer = "Anton""*)

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'd rather keep things on the professional level, if you don't mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[364]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Ewald Alphonso: ""Of course. Forgive my forwardness.""*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameText.AlphonsoToPlayer = "Anton"`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameText.AlphonsoToPlayer"] ="Anton";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Ewald Alphonso: ""I must say, {BaseGameText.AlphonsoToPlayer}, that was qu..."*)

### Węzeł `[368]`
Mówca: **Ewald Alphonso**
> ""Of course. Forgive my forwardness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Ewald Alphonso: ""I must say, {BaseGameText.AlphonsoToPlayer}, that was qu..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Player: ""It may not be perfect, but I'm proud to call it my homet..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It may not be perfect, but I'm proud to call it my hometown.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Kontekst wejściowy (poprzednik):** `[138]` (Ewald Alphonso), `[139]` (Ewald Alphonso), `[141]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Serge Wolkner: ""It must have been exciting to grow up here, Mr. Presiden..."*)

### Węzeł `[373]`
Mówca: **Serge Wolkner**
> ""It must have been exciting to grow up here, Mr. President. Something new happening every day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Serge Wolkner: ""My apologies, gentlemen. I didn't mean to dominate the c..."*)

### Węzeł `[374]`
Mówca: **Ewald Alphonso**
> ""Were Rumburg to get involved, they would be limited to a minority stake as well. I don't think it would pose a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Player: ""Your confidence is reassuring. However, how can we ensur..."*)
  - -> `[330]` (*Player: ""I share your views. However, I do worry about a potentia..."*)
  - -> `[331]` (*Player: ""I am still concerned about the implications of letting f..."*)
  - -> `[332]` (*Player: ""The changes we make to the Energy Protection Act will ha..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBene..."*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBe..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare =..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_FreeHousingEducationHealthBenefits"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true"*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == ..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSala..."*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_IncreasedBlueCollarWages"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true"*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity ..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_PSnW_Gasom_LocalCharityDonation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose = true;..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomExpandsCare"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinCare"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSVictory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Address_HelicopterEscape =..."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomIncreasesSalaries"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinSalaries"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSDisappointed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Address_HelicopterEscape =..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity = true;
BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Workers_GasomGivesCharity"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSWinDonations"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSCondemn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Address_HelicopterEscape =..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose = true;
BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_Workers_LUSCPSLose"] = true;
Variable["BaseGameSupport.News_Turn03_R_Workers_LUSCPSInaction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_Address_HelicopterEscape =..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_Address_HelicopterEscape = true; BaseGameSupport.News_Turn03_LT_Address_PresidentLandsLachaven = true; 
BaseGameSupport.News_Turn03_LT_Address_HelicopterEscape = true; 
BaseGameSupport.Report_Turn03_Lachaven_BlueMansionSecurity = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_Address_HelicopterEscape"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Address_PresidentLandsLachaven"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Address_HelicopterEscape"] = true;
Variable["BaseGameSupport.Report_Turn03_Lachaven_BlueMansionSecurity"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Serge_Friend == false"*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Serge_Friend == false)"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Serge_Friend == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: ""You prefer to keep things professional, right? Let's do ..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Serge_Friend == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("On a helicopter flight with a former President and driver", "Countryside", "Nargis");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("On a helicopter flight with a former President and driver","Countryside","Nargis");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Mountains");"*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Its wealth disparities concern me. This place needs our help.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Ewald Alphonso), `[139]` (Ewald Alphonso), `[141]` (Ewald Alphonso)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Serge Wolkner: ""I can't imagine what it must be like to live here. Somet..."*)
