# Sordland/Turn08/SnO_EstordRaid

- **ID konwersacji:** `141`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/141_SnO_EstordRaid.md`
- **Liczba węzłów dialogowych:** 314
- **Liczba wyborów gracza:** 93

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[44]** Lileas Graf
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_A_Marcel_OwnershipDeal`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Fled_MarcelKoronti`
- `BaseGame.Turn08_SnO_InvestigationOnHOS`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Killed_MarcelKoronti`
- `BaseGame.Marcel_FundsReElection`
- `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff`
- `BaseGame.Turn08_SnO_InvestigationOnHOS`
- `BaseGame.Turn08_SnO_KorontiInvestigationStopped`
- `BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigation`
- `BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection`
- `BaseGameSupport.Journal_Turn08_EstordRaid_MarcelKilled`
- `BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestigation`
- `GameCondition.Turn08_SnO_EstordRaid`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **"Call Marcel Koronti."** | `[141]` **Narrator**: "Lileas got up from her seat and ..."<br>`[195]` **Narrator**: "Nia got up from her seat and lef..." | `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false` | *Brak zmian stanu* | `[8]` **Narrator**: "He answered right away." |
| `[5]` | **"Do nothing."** | `[141]` **Narrator**: "Lileas got up from her seat and ..."<br>`[195]` **Narrator**: "Nia got up from her seat and lef..." | `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false` | *Brak zmian stanu* | `[6]` **Narrator**: "If Marcel's cartel ties were rea..."<br>`[307]` **Narrator**: "If Marcel's cartel ties were rea..." |
| `[10]` | **"“I have some information that could be useful to you.”"** | `[9]` **Marcel Koronti**: "“Mr. President.”"<br>`[45]` **Marcel Koronti**: "“What is this about?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Marcel Koronti**: "“Oh? Now I'm excited.”" |
| `[11]` | **"“The government is launching an indepth investigation into HOS. Soon.”"** | `[16]` **Marcel Koronti**: "“What is it?”"<br>`[28]` **Marcel Koronti**: "“I have many enemies, Mr. Presid..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true` | `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"...` | `[17]` **Marcel Koronti**: "“Really? Who would be behind suc..." |
| `[18]` | **"“I just prevented my own government from launching an investigation into HOS. I'm ..."** | `[16]` **Marcel Koronti**: "“What is it?”"<br>`[28]` **Marcel Koronti**: "“I have many enemies, Mr. Presid..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false` | `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"...` | `[19]` **Marcel Koronti**: "“Well, well. Thank you for doing..." |
| `[20]` | **"“Lileas Graf.”"** | `[17]` **Marcel Koronti**: "“Really? Who would be behind suc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Marcel Koronti**: "“What an unfortunate turn of eve..." |
| `[21]` | **"“Me.”"** | `[17]` **Marcel Koronti**: "“Really? Who would be behind suc..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Marcel Koronti**: "“Then why are you calling me?”" |
| `[24]` | **"“Is it true that you have links to the Koranelli cartel?”"** | `[9]` **Marcel Koronti**: "“Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"...` | `[26]` **Narrator**: "He started laughing hysterically." |
| `[29]` | **"“That's all I wanted to know.”"** | `[28]` **Marcel Koronti**: "“I have many enemies, Mr. Presid..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Marcel Koronti**: "“What is this about?”" |
| `[31]` | **"“What are you offering for this information?”"** | `[16]` **Marcel Koronti**: "“What is it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Marcel Koronti**: "“Well, I don't think I can make ..." |
| `[33]` | **"“Too bad, then. See you Marcel.”"** | `[32]` **Marcel Koronti**: "“Well, I don't think I can make ..."<br>`[310]` **Marcel Koronti**: "“Well, I don't think I can make ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Marcel Koronti**: "“Wait.”" |
| `[36]` | **"“Let's just say it's important enough that I am calling you.”"** | `[35]` **Marcel Koronti**: "“How important is this *informat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Marcel Koronti**: "“Fair enough. Hmm.”" |
| `[37]` | **"Hang up."** | `[35]` **Marcel Koronti**: "“How important is this *informat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "The games Marcel was playing wer..." |
| `[40]` | **"“Deal.”"** | `[39]` **Marcel Koronti**: "“Let's do this then. I promise y..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Marcel_FundsReElection"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn08_EstordRaid_Marce...` | `[41]` **Marcel Koronti**: "“Very well. What is the informat..." |
| `[42]` | **"“On second thought, I just wanted to test you. I will come visit you when you are ..."** | `[39]` **Marcel Koronti**: "“Let's do this then. I promise y..."<br>`[41]` **Marcel Koronti**: "“Very well. What is the informat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Marcel Koronti**: "“Mr. Presi-.”" |
| `[46]` | **"“The government is launching a serious investigation into HOS. Very soon.""** | `[41]` **Marcel Koronti**: "“Very well. What is the informat..." | `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true` | `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"...` | `[53]` **Marcel Koronti**: "“Well, well. Thank you for telli..." |
| `[50]` | **"“I just prevented my own government from launching an investigation into HOS. I'm ..."** | `[41]` **Marcel Koronti**: "“Very well. What is the informat..." | `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false` | `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"...` | `[51]` **Marcel Koronti**: "“Well, well. Thank you for doing..." |
| `[62]` | **"“The government is launching an indepth investigation into HOS. Soon.""** | `[32]` **Marcel Koronti**: "“Well, I don't think I can make ..." | `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true` | *Brak zmian stanu* | `[65]` **Marcel Koronti**: "“Well, well. Thank you for telli..." |
| `[63]` | **"“I just prevented my own government from launching an investigation into HOS. I'm ..."** | `[32]` **Marcel Koronti**: "“Well, I don't think I can make ..." | `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false` | *Brak zmian stanu* | `[64]` **Marcel Koronti**: "“Well, well. Thank you for doing..." |
| `[68]` | **"“I don't need your help to win.”"** | `[67]` **Marcel Koronti**: "“I promise you campaign funds co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Marcel Koronti**: "“I have no doubt. Very well.”" |
| `[69]` | **"“Deal.”"** | `[67]` **Marcel Koronti**: "“I promise you campaign funds co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Marcel Koronti**: "“Perfect.”" |
| `[73]` | **"“You will learn soon. Goodbye, Marcel.”"** | `[22]` **Marcel Koronti**: "“Then why are you calling me?”"<br>`[45]` **Marcel Koronti**: "“What is this about?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "I hung up on Marcel." |
| `[75]` | **"“Consider this a token of goodwill.”"** | `[67]` **Marcel Koronti**: "“I promise you campaign funds co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Marcel Koronti**: "“That is certainly a bargain. Ve..." |
| `[103]` | **"“This is a very big accusation, are you absolutely sure?”"** | `[112]` **Lileas Graf**: "“It has contents linking their o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Lileas Graf**: "“The initial lead found by our l..." |
| `[104]` | **"“Without undeniable evidence there is no point in making assumptions.”"** | `[112]` **Lileas Graf**: "“It has contents linking their o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Lileas Graf**: "“Exactly. That is why I refrain ..." |
| `[105]` | **"“Something must have gone wrong in the investigation. This can't be true.”"** | `[112]` **Lileas Graf**: "“It has contents linking their o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Lileas Graf**: "“We can't know for sure without ..." |
| `[109]` | **"“I never trusted HOS and Koronti anyway.”"** | `[112]` **Lileas Graf**: "“It has contents linking their o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Lileas Graf**: "“My reservations regarding that ..." |
| `[115]` | **"“Marcel Koronti is a powerful figure that wouldn't like a development like this at..."** | `[113]` **Lileas Graf**: "“Obviously we hope that there is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Lileas Graf**: "“No. He wouldn't like it at all ..." |
| `[116]` | **"“There is no way a respectable company like HOS can be linked to this. I don't bel..."** | `[113]` **Lileas Graf**: "“Obviously we hope that there is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "Lileas looked at me with suspicion." |
| `[119]` | **"“To figure out the truth a more indepth investigation needs to be launched.”"** | `[113]` **Lileas Graf**: "“Obviously we hope that there is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Lileas Graf**: "“Agreed.”" |
| `[120]` | **"“Is that really enough to start rounding up suspects?”"** | `[113]` **Lileas Graf**: "“Obviously we hope that there is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Lileas Graf**: "“I wouldn't come to you if there..." |
| `[130]` | **"“Who did you hear that from?”"** | `[124]` **Lileas Graf**: "“We must tread carefully. There ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Narrator**: "Lileas bursted into a laugh." |
| `[131]` | **"“I'm not surprised at all.”"** | `[124]` **Lileas Graf**: "“We must tread carefully. There ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Lileas Graf**: "“Regardless, the Lotherberg memb..." |
| `[132]` | **"“I've personally met him once. Didn't seem like a bad guy.”"** | `[124]` **Lileas Graf**: "“We must tread carefully. There ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Lileas Graf**: "“You need to be careful with the..." |
| `[137]` | **"“Our administration wouldn't fall that low. I have trust in our people.”"** | `[124]` **Lileas Graf**: "“We must tread carefully. There ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Lileas Graf**: "“I hope that is not just wishful..." |
| `[139]` | **"“It would be even worse if we acted too hasty and the lead turned out to be a fals..."** | `[156]` **Lileas Graf**: "“Not to mention that it seems......" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Lileas Graf**: "“Hmm. You may be right, but I'd ..." |
| `[145]` | **"“We can't be hasty here. We will wait until we have a more concrete lead.”"** | `[144]` **Narrator**: "We both locked eyes." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Lileas Graf**: "“I'm disappointed by this course..." |
| `[148]` | **"“I trust that we will come with enough information to incriminate him in due time.”"** | `[156]` **Lileas Graf**: "“Not to mention that it seems......" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Lileas Graf**: "“Hmm. You may be right, but I'd ..." |
| `[149]` | **"“Very well. Meeting adjourned then.”"** | `[142]` **Lileas Graf**: "“I'll get in touch with Nia righ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Lileas Graf**: "“Thank you for your time, Mr. Pr..." |
| `[150]` | **"“Looking forward to the results. Do your best.”"** | `[142]` **Lileas Graf**: "“I'll get in touch with Nia righ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Lileas Graf**: "“We will.”" |
| `[153]` | **"“Absolutely not. Keep your focus on Tusk.""** | `[144]` **Narrator**: "We both locked eyes." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Lileas Graf**: "“I'm disappointed by this course..." |
| `[154]` | **"“There is just not enough evidence to trigger an investigation.”"** | `[156]` **Lileas Graf**: "“Not to mention that it seems......" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Lileas Graf**: "“Hmm. You may be right, but I'd ..." |
| `[155]` | **"“Begin an official investigation to find out if HOS is working with organised crim..."** | `[144]` **Narrator**: "We both locked eyes." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn08_EstordRaid_Begin...` | `[142]` **Lileas Graf**: "“I'll get in touch with Nia righ..." |
| `[165]` | **"“This is a very big accusation, are you absolutely sure?”"** | `[164]` **Nia Morgna**: "“It has contents linking their o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Nia Morgna**: "“The ledger contains several tra..." |
| `[166]` | **"“Without undeniable evidence there is no point in making assumptions.”"** | `[164]` **Nia Morgna**: "“It has contents linking their o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Nia Morgna**: "“Exactly. That is why I refrain ..." |
| `[167]` | **"“Something must have gone wrong in the investigation. This can't be true.”"** | `[164]` **Nia Morgna**: "“It has contents linking their o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Nia Morgna**: "“We can't know for sure without ..." |
| `[168]` | **"“I never trusted HOS and Koronti anyway.”"** | `[164]` **Nia Morgna**: "“It has contents linking their o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Nia Morgna**: "“That makes two of us.”" |
| `[174]` | **"“Is that really enough to start rounding up suspects?""** | `[186]` **Nia Morgna**: "“Obviously we hope that there is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Nia Morgna**: "“I wouldn't come to you if there..." |
| `[175]` | **"“Marcel Koronti is a powerful figure that wouldn't like a development like this at..."** | `[186]` **Nia Morgna**: "“Obviously we hope that there is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Nia Morgna**: "“No. He wouldn't like it at all ..." |
| `[176]` | **"“To figure out the truth, a more indepth investigation needs to be launched.”"** | `[186]` **Nia Morgna**: "“Obviously we hope that there is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Nia Morgna**: "“Agreed.”" |
| `[182]` | **"“There is no way a respectable company like HOS can be linked to this. I don't bel..."** | `[186]` **Nia Morgna**: "“Obviously we hope that there is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Narrator**: "Nia looked at me with suspicion." |
| `[187]` | **"“Who did you hear that from?”"** | `[188]` **Nia Morgna**: "“We must tread carefully. There ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Nia Morgna**: "“We all have our ways, Mr. Presi..." |
| `[191]` | **"“I'm not surprised at all.”"** | `[188]` **Nia Morgna**: "“We must tread carefully. There ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Nia Morgna**: "“Regardless, the Lotherberg memb..." |
| `[194]` | **"“Our administration wouldn't fall that low. I have trust in our people.”"** | `[188]` **Nia Morgna**: "“We must tread carefully. There ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Nia Morgna**: "“I hope that is not just wishful..." |
| `[196]` | **"“I trust that we will come with enough information to incriminate him in due time.”"** | `[211]` **Nia Morgna**: "“It seems... questionable that w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Nia Morgna**: "“Hmm. You may be right, but I'd ..." |
| `[197]` | **"“Begin an official investigation to find out if HOS is working with organised crim..."** | `[209]` **Narrator**: "We both locked eyes." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn08_EstordRaid_Begin...` | `[212]` **Nia Morgna**: "“I will contact Lileas and get t..." |
| `[198]` | **"“Very well. Meeting adjourned then.”"** | `[212]` **Nia Morgna**: "“I will contact Lileas and get t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Nia Morgna**: "“Thank you for your time, Mr. Pr..." |
| `[202]` | **"“There is just not enough evidence to trigger an investigation.”"** | `[211]` **Nia Morgna**: "“It seems... questionable that w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Nia Morgna**: "“Hmm. You may be right, but I'd ..." |
| `[203]` | **"“Absolutely not. Keep your focus on Tusk.""** | `[209]` **Narrator**: "We both locked eyes." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Nia Morgna**: "“It seems... questionable that w..." |
| `[206]` | **"“Looking forward to the results. Do your best.”"** | `[212]` **Nia Morgna**: "“I will contact Lileas and get t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Nia Morgna**: "“We will.”" |
| `[207]` | **"“I've personally met him once. Didn't seem like a bad guy.”"** | `[188]` **Nia Morgna**: "“We must tread carefully. There ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Nia Morgna**: "“You need to be careful with the..." |
| `[210]` | **"“We can't be hasty here. We will wait until we have a more concrete lead.”"** | `[209]` **Narrator**: "We both locked eyes." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Nia Morgna**: "“It seems... questionable that w..." |
| `[214]` | **"“It would be even worse if we acted too hasty and the lead turned out to be a fals..."** | `[211]` **Nia Morgna**: "“It seems... questionable that w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Nia Morgna**: "“Hmm. You may be right, but I'd ..." |
| `[217]` | **"“Karl. Good to see you. What did you want to talk about?”"** | `[216]` **Narrator**: "He entered the meeting room and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Karl Greiser**: "“Mr. President.”" |
| `[218]` | **"“This better be worth my time.”"** | `[216]` **Narrator**: "He entered the meeting room and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Karl Greiser**: "“Mr. President.”" |
| `[219]` | **"“At ease.”"** | `[216]` **Narrator**: "He entered the meeting room and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Karl Greiser**: "“Mr. President.”" |
| `[221]` | **"Salute him."** | `[216]` **Narrator**: "He entered the meeting room and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Karl Greiser**: "“Mr. President.”" |
| `[226]` | **"“Are you sure about this? If this is true, this is really big.”"** | `[224]` **Karl Greiser**: "“By his account, HOS has been ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Karl Greiser**: "“We have his written testimony, ..." |
| `[227]` | **"“Traitor! I knew it was a good idea to put him in prison.”"** | `[224]` **Karl Greiser**: "“By his account, HOS has been ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Karl Greiser**: "“I agree, sir.”" |
| `[228]` | **"“This doesn't surprise me at all.”"** | `[224]` **Karl Greiser**: "“By his account, HOS has been ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Karl Greiser**: "“Me too, sir. It was a good idea..." |
| `[232]` | **"“Try to get whatever you can out from him. There might be more leads.”"** | `[225]` **Karl Greiser**: "“He will spend the rest of his l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Karl Greiser**: "“As you wish.”" |
| `[234]` | **"“Serves him right!”"** | `[225]` **Karl Greiser**: "“He will spend the rest of his l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Karl Greiser**: "“You have brought a known crimin..." |
| `[235]` | **"“Very good. Anything else?”"** | `[225]` **Karl Greiser**: "“He will spend the rest of his l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Karl Greiser**: "“There is...”"<br>`[241]` **Karl Greiser**: "“That is all I had for today, sir.”" |
| `[242]` | **"“Excellent. You may leave now.”"** | `[241]` **Karl Greiser**: "“That is all I had for today, sir.”"<br>`[269]` **Karl Greiser**: "“That is all I had for today.”"<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Karl Greiser**: "“Thank you, Mr. President.”" |
| `[243]` | **"“Keep up the good work.”"** | `[241]` **Karl Greiser**: "“That is all I had for today, sir.”"<br>`[269]` **Karl Greiser**: "“That is all I had for today.”"<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Karl Greiser**: "“It's my duty.”" |
| `[244]` | **"“Good. We are done then. Dismissed.”"** | `[241]` **Karl Greiser**: "“That is all I had for today, sir.”"<br>`[269]` **Karl Greiser**: "“That is all I had for today.”"<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Karl Greiser**: "“Thank you, Mr. President.”" |
| `[251]` | **"“What did he confess?”"** | `[250]` **Karl Greiser**: "“He was definitely lying.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Karl Greiser**: "“He...he said that he had a deal..." |
| `[252]` | **"“Speak, man.”"** | `[250]` **Karl Greiser**: "“He was definitely lying.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Karl Greiser**: "“He...he said that he had a deal..." |
| `[253]` | **"“Lying about what?”"** | `[250]` **Karl Greiser**: "“He was definitely lying.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Karl Greiser**: "“He...he said that he had a deal..." |
| `[257]` | **"“I see. He is trying to bring me down along with himself.”"** | `[256]` **Karl Greiser**: "“Of course... he was lying.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Karl Greiser**: "“That is exactly what I thought,..." |
| `[258]` | **"“You will not speak a word of this to anyone. Do you understand?”"** | `[256]` **Karl Greiser**: "“Of course... he was lying.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[262]` **Karl Greiser**: "“As you command.”" |
| `[259]` | **"“Yes. What else did he say?”"** | `[256]` **Karl Greiser**: "“Of course... he was lying.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Karl Greiser**: "“He gave further accounts on how..." |
| `[263]` | **"“Make sure these rumours never get out. It might create a problem.”"** | `[262]` **Karl Greiser**: "“As you command.”"<br>`[264]` **Karl Greiser**: "“He does have a very wild imagin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Karl Greiser**: "“Only a few officers who were in..." |
| `[265]` | **"“I'm not worried. No one will believe this broken man.”"** | `[262]` **Karl Greiser**: "“As you command.”"<br>`[264]` **Karl Greiser**: "“He does have a very wild imagin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Karl Greiser**: "“There is no way, sir.”" |
| `[273]` | **"“He is too dangerous to stay alive. I want him gone. Discreetly.”"** | `[264]` **Karl Greiser**: "“He does have a very wild imagin..." | `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true` | `Variable["BaseGame.Killed_MarcelKoronti"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn08_EstordRaid_Marce...` | `[274]` **Karl Greiser**: "“Sir?”" |
| `[275]` | **"“You heard me. Are you questioning my decision, Karl?”"** | `[274]` **Karl Greiser**: "“Sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Karl Greiser**: "“No, sir. I will handle it right..." |
| `[276]` | **"“He has shown that he can affect the administration even in custody.”"** | `[274]` **Karl Greiser**: "“Sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Karl Greiser**: "“Makes sense, sir. I will handle..." |
| `[277]` | **"“I gave you an order.”"** | `[274]` **Karl Greiser**: "“Sir?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Karl Greiser**: "“Yes, sir. Right away.”" |
| `[283]` | **"“Remember. Both you and I are responsible for protecting Sordland.”"** | `[281]` **Karl Greiser**: "“Rest assured. No one will hear ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Karl Greiser**: "“I live for Sordland, sir.”" |
| `[284]` | **"“That better be right. For your own good.”"** | `[281]` **Karl Greiser**: "“Rest assured. No one will hear ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Karl Greiser**: "“As you command.”" |
| `[285]` | **"“Thank you, Karl. You are a loyal man.”"** | `[281]` **Karl Greiser**: "“Rest assured. No one will hear ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Karl Greiser**: "“Thank you, sir.”" |
| `[311]` | **"“What are you offering for this information?”"** | `[22]` **Marcel Koronti**: "“Then why are you calling me?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Marcel Koronti**: "“Well, I don't think I can make ..." |
| `[312]` | **"“Disappointing, I will find someone else to work with.”"** | `[310]` **Marcel Koronti**: "“Well, I don't think I can make ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Marcel Koronti**: "“Wait.”" |

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
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == false"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_SnO_EstordRaid = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_SnO_EstordRaid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[4]`
**[WYBÓR GRACZA: "Call Marcel Koronti."]** — Mówca: **Player_Italic**
> "I called Marcel Koronti."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false`
- **Kontekst wejściowy (poprzednik):** `[141]` (Narrator), `[195]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "He answered right away."*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I decided not to call Marcel."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false`
- **Kontekst wejściowy (poprzednik):** `[141]` (Narrator), `[195]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true || BaseGame.Turn07_A_..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "If Marcel's cartel ties were real, this was huge news. My deal with him aside, HOS was the largest corporation in all of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I had to be careful. More so than ever."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I had to be careful. More so than ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_SnO_EstordRaid = true"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "He answered right away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Marcel Koronti: "“Mr. President.”"*)

### Węzeł `[9]`
Mówca: **Marcel Koronti**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“I have some information that could be useful to you.”"*)
  - -> `[24]` (*Player: "“Is it true that you have links to the Koranelli cartel?”"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I have some information that could be useful to you.”"]** — Mówca: **Player**
> "“I have some information that could be useful to you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Marcel Koronti), `[45]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Marcel Koronti: "“Oh? Now I'm excited.”"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“The government is launching an indepth investigation into HOS. Soon.”"]** — Mówca: **Player**
> "“The government is launching an indepth investigation into HOS. Soon.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true`
- **Kontekst wejściowy (poprzednik):** `[16]` (Marcel Koronti), `[28]` (Marcel Koronti), `[45]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_InvestigationOnHOS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_InvestigationOnHOS == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SnO_InvestigationOnHOS == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_InvestigationOnHOS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: "“The government is launching an indepth investigation int..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SnO_InvestigationOnHOS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: "“I just prevented my own government from launching an inv..."*)

### Węzeł `[15]`
Mówca: **Marcel Koronti**
> "“Oh? Now I'm excited.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Marcel Koronti: "“What is it?”"*)

### Węzeł `[16]`
Mówca: **Marcel Koronti**
> "“What is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“What are you offering for this information?”"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_InvestigationOnHOS == true"*)

### Węzeł `[17]`
Mówca: **Marcel Koronti**
> "“Really? Who would be behind such a thing?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: "“Lileas Graf.”"*)
  - -> `[21]` (*Player: "“Me.”"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"]** — Mówca: **Player**
> "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[16]` (Marcel Koronti), `[28]` (Marcel Koronti), `[45]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true"*)

### Węzeł `[19]`
Mówca: **Marcel Koronti**
> "“Well, well. Thank you for doing that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“Now, I wouldn't like to stay indebted to you.”"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Lileas Graf.”"]** — Mówca: **Player**
> "“Lileas Graf.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Marcel Koronti: "“What an unfortunate turn of events.”"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Me.”"]** — Mówca: **Player**
> "“Me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Marcel Koronti: "“Then why are you calling me?”"*)

### Węzeł `[22]`
Mówca: **Marcel Koronti**
> "“Then why are you calling me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player: "“What are you offering for this information?”"*)
  - -> `[73]` (*Player: "“You will learn soon. Goodbye, Marcel.”"*)

### Węzeł `[23]`
Mówca: **Marcel Koronti**
> "“What an unfortunate turn of events.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Marcel Koronti: "“Thank you for telling me.”"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Is it true that you have links to the Koranelli cartel?”"]** — Mówca: **Player**
> "“Is it true that you have links to the Koranelli cartel?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true"*)

### Węzeł `[25]`
Mówca: **Marcel Koronti**
> "“Of course not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Marcel Koronti: "“I wonder whose plan is it to remove me from my position ..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "He started laughing hysterically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Marcel Koronti: "“Of course not.”"*)

### Węzeł `[27]`
Mówca: **Marcel Koronti**
> "“I wonder whose plan is it to remove me from my position this time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Marcel Koronti: "“I have many enemies, Mr. President. Probably as many as ..."*)

### Węzeł `[28]`
Mówca: **Marcel Koronti**
> "“I have many enemies, Mr. President. Probably as many as you do. I had no dealings with a *cartel*. I assure you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_InvestigationOnHOS == true"*)
  - -> `[29]` (*Player: "“That's all I wanted to know.”"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“That's all I wanted to know.”"]** — Mówca: **Player**
> "“That's all I wanted to know.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Marcel Koronti: "“What is this about?”"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "He started laughing hysterically."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“What are you offering for this information?”"]** — Mówca: **Player**
> "“What are you offering for this information?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Marcel Koronti: "“Well, I don't think I can make an offer without seeing w..."*)

### Węzeł `[32]`
Mówca: **Marcel Koronti**
> "“Well, I don't think I can make an offer without seeing what I am buying first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“Too bad, then. See you Marcel.”"*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_InvestigationOnHOS == true"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Too bad, then. See you Marcel.”"]** — Mówca: **Player**
> "“Too bad, then. See you Marcel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Marcel Koronti), `[310]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Marcel Koronti: "“Wait.”"*)

### Węzeł `[34]`
Mówca: **Marcel Koronti**
> "“Wait.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Marcel Koronti: "“How important is this *information*?”"*)

### Węzeł `[35]`
Mówca: **Marcel Koronti**
> "“How important is this *information*?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Italic: "Hang up."*)
  - -> `[36]` (*Player: "“Let's just say it's important enough that I am calling y..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Let's just say it's important enough that I am calling you.”"]** — Mówca: **Player**
> "“Let's just say it's important enough that I am calling you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Marcel Koronti: "“Fair enough. Hmm.”"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "Hang up."]** — Mówca: **Player_Italic**
> "I hung up on Marcel."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "The games Marcel was playing were getting more and more d..."*)

### Węzeł `[38]`
Mówca: **Marcel Koronti**
> "“Fair enough. Hmm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Marcel Koronti: "“Let's do this then. I promise you campaign funds. The am..."*)

### Węzeł `[39]`
Mówca: **Marcel Koronti**
> "“Let's do this then. I promise you campaign funds. The amount, however, will be dependent on the value of the information.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "“On second thought, I just wanted to test you. I will com..."*)
  - -> `[40]` (*Player: "“Deal.”"*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Deal.”"]** — Mówca: **Player**
> "“Deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Marcel_FundsReElection = true"*)

### Węzeł `[41]`
Mówca: **Marcel Koronti**
> "“Very well. What is the information then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "“On second thought, I just wanted to test you. I will com..."*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_InvestigationOnHOS == true"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“On second thought, I just wanted to test you. I will come visit you when you are behind bars.”"]** — Mówca: **Player**
> "“On second thought, I just wanted to test you. I will come visit you when you are behind bars.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Marcel Koronti), `[41]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Marcel Koronti: "“Mr. Presi-.”"*)

### Węzeł `[43]`
Mówca: **Marcel Koronti**
> "“Mr. Presi-.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Marcel_FundsReElection = false"*)

### Węzeł `[44]`
Mówca: **Narrator**
> "I hung up on Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "The games Marcel was playing were getting more and more d..."*)

### Węzeł `[45]`
Mówca: **Marcel Koronti**
> "“What is this about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“I have some information that could be useful to you.”"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_InvestigationOnHOS == true"*)
  - -> `[73]` (*Player: "“You will learn soon. Goodbye, Marcel.”"*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“The government is launching a serious investigation into HOS. Very soon.""]** — Mówca: **Player**
> "“The government is launching a serious investigation into HOS. Very soon.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true`
- **Kontekst wejściowy (poprzednik):** `[41]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_InvestigationOnHOS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_InvestigationOnHOS == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SnO_InvestigationOnHOS == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_InvestigationOnHOS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: "“The government is launching a serious investigation into..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SnO_InvestigationOnHOS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "“I just prevented my own government from launching an inv..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"]** — Mówca: **Player**
> "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[41]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true"*)

### Węzeł `[51]`
Mówca: **Marcel Koronti**
> "“Well, well. Thank you for doing that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Marcel Koronti: "“That is indeed valuable information. I will make good us..."*)

### Węzeł `[52]`
Mówca: **Marcel Koronti**
> "“That is indeed valuable information. I will make good use of it indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Marcel Koronti: "“As I have promised, I will deliver again on our deal whe..."*)

### Węzeł `[53]`
Mówca: **Marcel Koronti**
> "“Well, well. Thank you for telling me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Marcel Koronti: "“That is indeed valuable information. I will make good us..."*)

### Węzeł `[54]`
Mówca: **Marcel Koronti**
> "“As I have promised, I will deliver again on our deal when the time is right. Just as I have always done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Marcel Koronti: "“I must now make sure my people are on this.”"*)

### Węzeł `[55]`
Mówca: **Marcel Koronti**
> "“I must now make sure my people are on this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Marcel Koronti: "“Cheers to our deal once again, Mr. President, and to man..."*)

### Węzeł `[56]`
Mówca: **Marcel Koronti**
> "“Cheers to our deal once again, Mr. President, and to many more years of collaboration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Marcel Koronti: "“Bye bye, now.”"*)

### Węzeł `[57]`
Mówca: **Marcel Koronti**
> "“Bye bye, now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "Marcel hung up."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "Marcel hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "The games Marcel was playing were getting more and more d..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_InvestigationOnHOS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_InvestigationOnHOS == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SnO_InvestigationOnHOS == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_InvestigationOnHOS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "“The government is launching an indepth investigation int..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SnO_InvestigationOnHOS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "“I just prevented my own government from launching an inv..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“The government is launching an indepth investigation into HOS. Soon.""]** — Mówca: **Player**
> "“The government is launching an indepth investigation into HOS. Soon.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true`
- **Kontekst wejściowy (poprzednik):** `[32]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Marcel Koronti: "“Well, well. Thank you for telling me.”"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"]** — Mówca: **Player**
> "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[32]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Marcel Koronti: "“Well, well. Thank you for doing that.”"*)

### Węzeł `[64]`
Mówca: **Marcel Koronti**
> "“Well, well. Thank you for doing that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“Now, I wouldn't like to stay indebted to you.”"*)

### Węzeł `[65]`
Mówca: **Marcel Koronti**
> "“Well, well. Thank you for telling me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“Now, I wouldn't like to stay indebted to you.”"*)

### Węzeł `[66]`
Mówca: **Marcel Koronti**
> ""Here's what I can offer in exchange for your help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Marcel Koronti: "“I promise you campaign funds commensurate with the value..."*)

### Węzeł `[67]`
Mówca: **Marcel Koronti**
> "“I promise you campaign funds commensurate with the value of your information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "“I don't need your help to win.”"*)
  - -> `[69]` (*Player: "“Deal.”"*)
  - -> `[75]` (*Player: "“Consider this a token of goodwill.”"*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I don't need your help to win.”"]** — Mówca: **Player**
> "“I don't need your help to win.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Marcel Koronti: "“I have no doubt. Very well.”"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Deal.”"]** — Mówca: **Player**
> "“Deal.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Marcel Koronti: "“Perfect.”"*)

### Węzeł `[70]`
Mówca: **Marcel Koronti**
> "“I have no doubt. Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Marcel Koronti: "“Please let me know then if you ever need help.”"*)

### Węzeł `[71]`
Mówca: **Marcel Koronti**
> "“Perfect.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Marcel_FundsReElection = true"*)

### Węzeł `[72]`
Mówca: **Marcel Koronti**
> "“Please let me know then if you ever need help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Marcel Koronti: "“Bye bye, now.”"*)

### Węzeł `[73]`
**[WYBÓR GRACZA: "“You will learn soon. Goodbye, Marcel.”"]** — Mówca: **Player**
> "“You will learn soon. Goodbye, Marcel.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Marcel Koronti), `[45]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "I hung up on Marcel."*)

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“Now, I wouldn't like to stay indebted to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Marcel Koronti: ""Here's what I can offer in exchange for your help.”"*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Consider this a token of goodwill.”"]** — Mówca: **Player**
> "“Consider this a token of goodwill.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Marcel Koronti: "“That is certainly a bargain. Very well, I shall do so.”"*)

### Węzeł `[76]`
Mówca: **Marcel Koronti**
> "“That is certainly a bargain. Very well, I shall do so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Marcel Koronti: "“Please let me know if you ever need help.”"*)

### Węzeł `[77]`
Mówca: **Marcel Koronti**
> "“Please let me know if you ever need help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Marcel Koronti: "“I must now make sure my people are on this.”"*)

### Węzeł `[78]`
Mówca: **Narrator**
> "I hung up on Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "The games Marcel was playing were getting more and more d..."*)

### Węzeł `[79]`
Mówca: **Marcel Koronti**
> "“Thank you for telling me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Marcel Koronti: "“Now, I wouldn't like to stay indebted to you.”"*)

### Węzeł `[80]`
Mówca: **Narrator**
> "The games Marcel was playing were getting more and more dangerous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "The question was, who would be the winner?"*)

### Węzeł `[81]`
Mówca: **Narrator**
> "The question was, who would be the winner?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_SnO_EstordRaid = true"*)

### Węzeł `[82]`
Mówca: **Narrator**
> "The games Marcel was playing were getting more and more dangerous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "The question was, who would be the winner?"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Marcel Koronti: "“Really? Who would be behind such a thing?”"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Marcel Koronti: "“Well, well. Thank you for doing that.”"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Marcel Koronti: "“Well, well. Thank you for telling me.”"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Marcel Koronti: "“Well, well. Thank you for doing that.”"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Lileas Graf requested to set up an off-the-books meeting ..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Nia Morgna requested to set up an off-the-books meeting t..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MarcelKoronti == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == false"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_MarcelKoronti == false)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MarcelKoronti == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_MarcelKoronti == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "Karl Greiser requested to set up a short meeting regardin..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Nia Morgna requested to set up an off-the-books meeting to relay a new development from the criminal investigations conducted by the Anti-Corruption Police."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "She was seated right across from me in the meeting room."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "She was seated right across from me in the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Nia Morgna: "“Mr. President.”"*)

### Węzeł `[95]`
Mówca: **Nia Morgna**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Nia Morgna: "“You asked the ACP to start investigating the Oligarchs.”"*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Lileas Graf requested to set up an off-the-books meeting to relay a new development from the criminal investigations conducted by the Secret State Police."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "She was seated right across from me in the meeting room."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "She was seated right across from me in the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lileas Graf: "“Mr. President.”"*)

### Węzeł `[98]`
Mówca: **Lileas Graf**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lileas Graf: "“You asked the SSP to start investigating the Oligarchs.”"*)

### Węzeł `[99]`
Mówca: **Narrator**
> "She handed over a police report detailing the network of the Koranelli gang in the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lileas Graf: "“A ledger was found in one of the raids.”"*)

### Węzeł `[100]`
Mówca: **Lileas Graf**
> "“Thanks to Mr. Greiser's efforts, we have come across a suspicious link during our recent operations against organised crime in Estord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "She handed over a police report detailing the network of ..."*)

### Węzeł `[101]`
Mówca: **Lileas Graf**
> "“You asked the SSP to start investigating the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lileas Graf: "“We couldn't find anything related to Walter Tusk yet, bu..."*)

### Węzeł `[102]`
Mówca: **Lileas Graf**
> "“We couldn't find anything related to Walter Tusk yet, but there is a silver lining.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lileas Graf: "“Thanks to Mr. Greiser's efforts, we have come across a s..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“This is a very big accusation, are you absolutely sure?”"]** — Mówca: **Player**
> "“This is a very big accusation, are you absolutely sure?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lileas Graf: "“The initial lead found by our lead investigator refers t..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Without undeniable evidence there is no point in making assumptions.”"]** — Mówca: **Player**
> "“Without undeniable evidence there is no point in making assumptions.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lileas Graf: "“Exactly. That is why I refrain from making a final comme..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Something must have gone wrong in the investigation. This can't be true.”"]** — Mówca: **Player**
> "“Something must have gone wrong in the investigation. This can't be true.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lileas Graf: "“We can't know for sure without starting a full investiga..."*)

### Węzeł `[106]`
Mówca: **Lileas Graf**
> "“The initial lead found by our lead investigator refers to several transactions. There is a case to pursue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lileas Graf: "“At any rate, with this new evidence we need not keep our..."*)

### Węzeł `[107]`
Mówca: **Lileas Graf**
> "“We can't know for sure without starting a full investigation. It could be a local case but it could be something bigger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lileas Graf: "“At any rate, with this new evidence we need not keep our..."*)

### Węzeł `[108]`
Mówca: **Lileas Graf**
> "“Exactly. That is why I refrain from making a final comment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lileas Graf: "“At any rate, with this new evidence we need not keep our..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“I never trusted HOS and Koronti anyway.”"]** — Mówca: **Player**
> "“I never trusted HOS and Koronti anyway.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Lileas Graf: "“My reservations regarding that family and their fortunes..."*)

### Węzeł `[110]`
Mówca: **Lileas Graf**
> "“My reservations regarding that family and their fortunes never changed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lileas Graf: "“At any rate, with this new evidence we need not keep our..."*)

### Węzeł `[111]`
Mówca: **Lileas Graf**
> "“A ledger was found in one of the raids.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Lileas Graf: "“It has contents linking their operations to a subsidiary..."*)

### Węzeł `[112]`
Mówca: **Lileas Graf**
> "“It has contents linking their operations to a subsidiary of the Heart of Sordland Conglomerate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: "“This is a very big accusation, are you absolutely sure?”"*)
  - -> `[105]` (*Player: "“Something must have gone wrong in the investigation. Thi..."*)
  - -> `[104]` (*Player: "“Without undeniable evidence there is no point in making ..."*)
  - -> `[109]` (*Player: "“I never trusted HOS and Koronti anyway.”"*)

### Węzeł `[113]`
Mówca: **Lileas Graf**
> "“Obviously we hope that there is nothing beneath the surface but if in any way HOS is linked to organised crime...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "“Marcel Koronti is a powerful figure that wouldn't like a..."*)
  - -> `[119]` (*Player: "“To figure out the truth a more indepth investigation nee..."*)
  - -> `[120]` (*Player: "“Is that really enough to start rounding up suspects?”"*)
  - -> `[116]` (*Player: "“There is no way a respectable company like HOS can be li..."*)

### Węzeł `[114]`
Mówca: **Lileas Graf**
> "“At any rate, with this new evidence we need not keep our research into Mr. Koronti a secret any longer. In fact, we should open a full-blown joint investigation with the Ministry of Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lileas Graf: "“Obviously we hope that there is nothing beneath the surf..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Marcel Koronti is a powerful figure that wouldn't like a development like this at all.”"]** — Mówca: **Player**
> "“Marcel Koronti is a powerful figure that wouldn't like a development like this at all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lileas Graf: "“No. He wouldn't like it at all but if he is innocent he ..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“There is no way a respectable company like HOS can be linked to this. I don't believe it.”"]** — Mówca: **Player**
> "“There is no way a respectable company like HOS can be linked to this. I don't believe it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "Lileas looked at me with suspicion."*)

### Węzeł `[117]`
Mówca: **Lileas Graf**
> "“People like him think they are above the law.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[118]`
Mówca: **Lileas Graf**
> "“I wouldn't come to you if there wasn't anything worth looking into.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“To figure out the truth a more indepth investigation needs to be launched.”"]** — Mówca: **Player**
> "“To figure out the truth a more indepth investigation needs to be launched.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Lileas Graf: "“Agreed.”"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Is that really enough to start rounding up suspects?”"]** — Mówca: **Player**
> "“Is that really enough to start rounding up suspects?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lileas Graf: "“I wouldn't come to you if there wasn't anything worth lo..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "Lileas looked at me with suspicion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lileas Graf: "“I wouldn't come to you if there wasn't anything worth lo..."*)

### Węzeł `[122]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[123]`
Mówca: **Lileas Graf**
> "“No. He wouldn't like it at all but if he is innocent he shouldn't care.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Lileas Graf: "“People like him think they are above the law.”"*)

### Węzeł `[124]`
Mówca: **Lileas Graf**
> "“We must tread carefully. There have been rumours about Mr. Koronti having ties to our government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "“Who did you hear that from?”"*)
  - -> `[137]` (*Player: "“Our administration wouldn't fall that low. I have trust ..."*)
  - -> `[131]` (*Player: "“I'm not surprised at all.”"*)
  - -> `[132]` (*Player: "“I've personally met him once. Didn't seem like a bad guy.”"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lileas Graf: "“We must tread carefully. There have been rumours about M..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lileas Graf: "“So. Will you allow us to open an investigation?”"*)

### Węzeł `[128]`
Mówca: **Lileas Graf**
> "“So. Will you allow us to open an investigation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "We both locked eyes."*)

### Węzeł `[129]`
Mówca: **Lileas Graf**
> "“We all have our ways, Mr. President. I wouldn't be sitting here if I didn't know how to keep my ears open.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lileas Graf: "“So. Will you allow us to open an investigation?”"*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Who did you hear that from?”"]** — Mówca: **Player**
> "“Who did you hear that from?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Lileas bursted into a laugh."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“I'm not surprised at all.”"]** — Mówca: **Player**
> "“I'm not surprised at all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lileas Graf: "“Regardless, the Lotherberg members aren't to be trusted.”"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“I've personally met him once. Didn't seem like a bad guy.”"]** — Mówca: **Player**
> "“I've personally met him once. Didn't seem like a bad guy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lileas Graf: "“You need to be careful with the oligarchs, Mr. President..."*)

### Węzeł `[133]`
Mówca: **Lileas Graf**
> "“Regardless, the Lotherberg members aren't to be trusted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lileas Graf: "“So. Will you allow us to open an investigation?”"*)

### Węzeł `[134]`
Mówca: **Narrator**
> "Lileas bursted into a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lileas Graf: "“We all have our ways, Mr. President. I wouldn't be sitti..."*)

### Węzeł `[135]`
Mówca: **Lileas Graf**
> "“I hope that is not just wishful thinking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lileas Graf: "“Regardless, the Lotherberg members aren't to be trusted.”"*)

### Węzeł `[136]`
Mówca: **Lileas Graf**
> "“They always try to impress but it is all smoke and mirrors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lileas Graf: "“So. Will you allow us to open an investigation?”"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“Our administration wouldn't fall that low. I have trust in our people.”"]** — Mówca: **Player**
> "“Our administration wouldn't fall that low. I have trust in our people.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lileas Graf: "“I hope that is not just wishful thinking.”"*)

### Węzeł `[138]`
Mówca: **Lileas Graf**
> "“You need to be careful with the oligarchs, Mr. President. Their only loyalty is to money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lileas Graf: "“They always try to impress but it is all smoke and mirro..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "“It would be even worse if we acted too hasty and the lead turned out to be a false one.”"]** — Mówca: **Player**
> "“It would be even worse if we acted too hasty and the lead turned out to be a false one.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Lileas Graf: "“Hmm. You may be right, but I'd hate to find out that we ..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_InvestigationOnHOS = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigat..."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "Lileas got up from her seat and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_MarcelKoronti == false"*)

### Węzeł `[142]`
Mówca: **Lileas Graf**
> "“I'll get in touch with Nia right away. Of course, I needn't mention our previous activities or the SSP's ongoing investigation into Mr. Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: "“Very well. Meeting adjourned then.”"*)
  - -> `[150]` (*Player: "“Looking forward to the results. Do your best.”"*)

### Węzeł `[143]`
Mówca: **Lileas Graf**
> "“I'm disappointed by this course of action. The gang might try to erase evidence in the meantime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lileas Graf: "“Not to mention that it seems... questionable that we are..."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "We both locked eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Player: "“Begin an official investigation to find out if HOS is wo..."*)
  - -> `[145]` (*Player: "“We can't be hasty here. We will wait until we have a mor..."*)
  - -> `[153]` (*Player: "“Absolutely not. Keep your focus on Tusk.""*)

### Węzeł `[145]`
**[WYBÓR GRACZA: "“We can't be hasty here. We will wait until we have a more concrete lead.”"]** — Mówca: **Player**
> "“We can't be hasty here. We will wait until we have a more concrete lead.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lileas Graf: "“I'm disappointed by this course of action. The gang migh..."*)

### Węzeł `[146]`
Mówca: **Lileas Graf**
> "“Well. That is all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lileas Graf: "“Thank you for your time, Mr. President.”"*)

### Węzeł `[147]`
Mówca: **Lileas Graf**
> "“Thank you for your time, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Lileas got up from her seat and left the meeting room."*)

### Węzeł `[148]`
**[WYBÓR GRACZA: "“I trust that we will come with enough information to incriminate him in due time.”"]** — Mówca: **Player**
> "“I trust that we will come with enough information to incriminate him in due time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Lileas Graf: "“Hmm. You may be right, but I'd hate to find out that we ..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "“Very well. Meeting adjourned then.”"]** — Mówca: **Player**
> "“Very well. Meeting adjourned then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lileas Graf: "“Thank you for your time, Mr. President.”"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Looking forward to the results. Do your best.”"]** — Mówca: **Player**
> "“Looking forward to the results. Do your best.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Lileas Graf: "“We will.”"*)

### Węzeł `[151]`
Mówca: **Lileas Graf**
> "“Hmm. You may be right, but I'd hate to find out that we missed our chance later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_KorontiInvestigationStopped = true"*)

### Węzeł `[152]`
Mówca: **Lileas Graf**
> "“We will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lileas Graf: "“Well. That is all I had for today.”"*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“Absolutely not. Keep your focus on Tusk.""]** — Mówca: **Player**
> "“Absolutely not. Keep your focus on Tusk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lileas Graf: "“I'm disappointed by this course of action. The gang migh..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA: "“There is just not enough evidence to trigger an investigation.”"]** — Mówca: **Player**
> "“There is just not enough evidence to trigger an investigation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Lileas Graf: "“Hmm. You may be right, but I'd hate to find out that we ..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA: "“Begin an official investigation to find out if HOS is working with organised crime elements in Estord.”"]** — Mówca: **Player**
> "“Begin an official investigation to find out if HOS is working with organised crime elements in Estord.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_InvestigationOnHOS = true"*)

### Węzeł `[156]`
Mówca: **Lileas Graf**
> "“Not to mention that it seems... questionable that we aren't pursuing this now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player: "“It would be even worse if we acted too hasty and the lea..."*)
  - -> `[148]` (*Player: "“I trust that we will come with enough information to inc..."*)
  - -> `[154]` (*Player: "“There is just not enough evidence to trigger an investig..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Marcel_FundsReElection = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Marcel_FundsReElection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReel..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Marcel_FundsReElection = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Marcel_FundsReElection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReel..."*)

### Węzeł `[159]`
Mówca: **Nia Morgna**
> "“You asked the ACP to start investigating the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Nia Morgna: "“We couldn't find anything related to Walter Tusk yet, bu..."*)

### Węzeł `[160]`
Mówca: **Nia Morgna**
> "“We couldn't find anything related to Walter Tusk yet, but there is a silver lining.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Nia Morgna: "“By sheer luck, we have come across a suspicious link in ..."*)

### Węzeł `[161]`
Mówca: **Nia Morgna**
> "“By sheer luck, we have come across a suspicious link in Estord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "She handed over a police report detailing the network of ..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "She handed over a police report detailing the network of the Koranelli gang in the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Nia Morgna: "“A ledger was previously found in one of the raids agains..."*)

### Węzeł `[163]`
Mówca: **Nia Morgna**
> "“A ledger was previously found in one of the raids against the cartel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Nia Morgna: "“It has contents linking their operations to a subsidiary..."*)

### Węzeł `[164]`
Mówca: **Nia Morgna**
> "“It has contents linking their operations to a subsidiary of the Heart of Sordland Conglomerate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player: "“This is a very big accusation, are you absolutely sure?”"*)
  - -> `[167]` (*Player: "“Something must have gone wrong in the investigation. Thi..."*)
  - -> `[166]` (*Player: "“Without undeniable evidence there is no point in making ..."*)
  - -> `[168]` (*Player: "“I never trusted HOS and Koronti anyway.”"*)

### Węzeł `[165]`
**[WYBÓR GRACZA: "“This is a very big accusation, are you absolutely sure?”"]** — Mówca: **Player**
> "“This is a very big accusation, are you absolutely sure?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Nia Morgna: "“The ledger contains several transactions. There is a cas..."*)

### Węzeł `[166]`
**[WYBÓR GRACZA: "“Without undeniable evidence there is no point in making assumptions.”"]** — Mówca: **Player**
> "“Without undeniable evidence there is no point in making assumptions.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Nia Morgna: "“Exactly. That is why I refrain from making a final comme..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: "“Something must have gone wrong in the investigation. This can't be true.”"]** — Mówca: **Player**
> "“Something must have gone wrong in the investigation. This can't be true.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Nia Morgna: "“We can't know for sure without starting a full investiga..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA: "“I never trusted HOS and Koronti anyway.”"]** — Mówca: **Player**
> "“I never trusted HOS and Koronti anyway.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Nia Morgna: "“That makes two of us.”"*)

### Węzeł `[169]`
Mówca: **Nia Morgna**
> "“That makes two of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Nia Morgna: "“At any rate, with this new evidence our case against Mr...."*)

### Węzeł `[170]`
Mówca: **Nia Morgna**
> "“Exactly. That is why I refrain from making a final comment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Nia Morgna: "“At any rate, with this new evidence our case against Mr...."*)

### Węzeł `[171]`
Mówca: **Nia Morgna**
> "“We can't know for sure without starting a full investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Nia Morgna: "“At any rate, with this new evidence our case against Mr...."*)

### Węzeł `[172]`
Mówca: **Nia Morgna**
> "“The ledger contains several transactions. There is a case to pursue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Nia Morgna: "“At any rate, with this new evidence our case against Mr...."*)

### Węzeł `[173]`
Mówca: **Nia Morgna**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "“Is that really enough to start rounding up suspects?""]** — Mówca: **Player**
> "“Is that really enough to start rounding up suspects?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Nia Morgna: "“I wouldn't come to you if there wasn't anything worth lo..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Marcel Koronti is a powerful figure that wouldn't like a development like this at all.”"]** — Mówca: **Player**
> "“Marcel Koronti is a powerful figure that wouldn't like a development like this at all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Nia Morgna: "“No. He wouldn't like it at all but if he is innocent he ..."*)

### Węzeł `[176]`
**[WYBÓR GRACZA: "“To figure out the truth, a more indepth investigation needs to be launched.”"]** — Mówca: **Player**
> "“To figure out the truth, a more indepth investigation needs to be launched.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Nia Morgna: "“Agreed.”"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Nia Morgna: "“We must tread carefully. There have been rumours about M..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Nia Morgna: "“So. Will you allow us to open an investigation?”"*)

### Węzeł `[180]`
Mówca: **Narrator**
> "Nia looked at me with suspicion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Nia Morgna: "“I wouldn't come to you if there wasn't anything worth lo..."*)

### Węzeł `[181]`
Mówca: **Nia Morgna**
> "“I wouldn't come to you if there wasn't anything worth looking into.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[182]`
**[WYBÓR GRACZA: "“There is no way a respectable company like HOS can be linked to this. I don't believe it.”"]** — Mówca: **Player**
> "“There is no way a respectable company like HOS can be linked to this. I don't believe it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "Nia looked at me with suspicion."*)

### Węzeł `[183]`
Mówca: **Nia Morgna**
> "“People like him think they are above the law.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[184]`
Mówca: **Nia Morgna**
> "“No. He wouldn't like it at all but if he is innocent he shouldn't care.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Nia Morgna: "“People like him think they are above the law.”"*)

### Węzeł `[185]`
Mówca: **Nia Morgna**
> "“At any rate, with this new evidence our case against Mr. Koronti goes far past the ACP's purview. In fact, we should open a full-blown joint investigation with the Interior Ministry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Nia Morgna: "“Obviously we hope that there is nothing beneath the surf..."*)

### Węzeł `[186]`
Mówca: **Nia Morgna**
> "“Obviously we hope that there is nothing beneath the surface, but if in any way HOS is linked to organised crime...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: "“Marcel Koronti is a powerful figure that wouldn't like a..."*)
  - -> `[176]` (*Player: "“To figure out the truth, a more indepth investigation ne..."*)
  - -> `[174]` (*Player: "“Is that really enough to start rounding up suspects?""*)
  - -> `[182]` (*Player: "“There is no way a respectable company like HOS can be li..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA: "“Who did you hear that from?”"]** — Mówca: **Player**
> "“Who did you hear that from?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Nia Morgna: "“We all have our ways, Mr. President. I wouldn't be sitti..."*)

### Węzeł `[188]`
Mówca: **Nia Morgna**
> "“We must tread carefully. There have been rumours about Mr. Koronti having ties to our government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player: "“Who did you hear that from?”"*)
  - -> `[194]` (*Player: "“Our administration wouldn't fall that low. I have trust ..."*)
  - -> `[191]` (*Player: "“I'm not surprised at all.”"*)
  - -> `[207]` (*Player: "“I've personally met him once. Didn't seem like a bad guy.”"*)

### Węzeł `[189]`
Mówca: **Nia Morgna**
> "“So. Will you allow us to open an investigation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "We both locked eyes."*)

### Węzeł `[190]`
Mówca: **Nia Morgna**
> "“We all have our ways, Mr. President. I wouldn't be sitting here if I didn't know how to keep my ears open.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Nia Morgna: "“So. Will you allow us to open an investigation?”"*)

### Węzeł `[191]`
**[WYBÓR GRACZA: "“I'm not surprised at all.”"]** — Mówca: **Player**
> "“I'm not surprised at all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Nia Morgna: "“Regardless, the Lotherberg members aren't to be trusted.”"*)

### Węzeł `[192]`
Mówca: **Nia Morgna**
> "“Regardless, the Lotherberg members aren't to be trusted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Nia Morgna: "“So. Will you allow us to open an investigation?”"*)

### Węzeł `[193]`
Mówca: **Nia Morgna**
> "“I hope that is not just wishful thinking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Nia Morgna: "“Regardless, the Lotherberg members aren't to be trusted.”"*)

### Węzeł `[194]`
**[WYBÓR GRACZA: "“Our administration wouldn't fall that low. I have trust in our people.”"]** — Mówca: **Player**
> "“Our administration wouldn't fall that low. I have trust in our people.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Nia Morgna: "“I hope that is not just wishful thinking.”"*)

### Węzeł `[195]`
Mówca: **Narrator**
> "Nia got up from her seat and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_MarcelKoronti == false"*)

### Węzeł `[196]`
**[WYBÓR GRACZA: "“I trust that we will come with enough information to incriminate him in due time.”"]** — Mówca: **Player**
> "“I trust that we will come with enough information to incriminate him in due time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Nia Morgna: "“Hmm. You may be right, but I'd hate to find out that we ..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“Begin an official investigation to find out if HOS is working with organised crime elements in Estord.”"]** — Mówca: **Player**
> "“Begin an official investigation to find out if HOS is working with organised crime elements in Estord.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_InvestigationOnHOS = true"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“Very well. Meeting adjourned then.”"]** — Mówca: **Player**
> "“Very well. Meeting adjourned then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Nia Morgna: "“Thank you for your time, Mr. President.”"*)

### Węzeł `[199]`
Mówca: **Nia Morgna**
> "“Thank you for your time, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Nia got up from her seat and left the meeting room."*)

### Węzeł `[200]`
Mówca: **Nia Morgna**
> "“You need to be careful with the oligarchs, Mr. President. Their only loyalty is to money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Nia Morgna: "“They always try to impress but it is all smoke and mirro..."*)

### Węzeł `[201]`
Mówca: **Nia Morgna**
> "“Well. That is all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Nia Morgna: "“Thank you for your time, Mr. President.”"*)

### Węzeł `[202]`
**[WYBÓR GRACZA: "“There is just not enough evidence to trigger an investigation.”"]** — Mówca: **Player**
> "“There is just not enough evidence to trigger an investigation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Nia Morgna: "“Hmm. You may be right, but I'd hate to find out that we ..."*)

### Węzeł `[203]`
**[WYBÓR GRACZA: "“Absolutely not. Keep your focus on Tusk.""]** — Mówca: **Player**
> "“Absolutely not. Keep your focus on Tusk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Nia Morgna: "“It seems... questionable that we aren't pursuing this now.”"*)

### Węzeł `[204]`
Mówca: **Nia Morgna**
> "“Hmm. You may be right, but I'd hate to find out that we missed our chance later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SnO_KorontiInvestigationStopped = true"*)

### Węzeł `[205]`
Mówca: **Nia Morgna**
> "“We will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Nia Morgna: "“Well. That is all I had for today.”"*)

### Węzeł `[206]`
**[WYBÓR GRACZA: "“Looking forward to the results. Do your best.”"]** — Mówca: **Player**
> "“Looking forward to the results. Do your best.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Nia Morgna: "“We will.”"*)

### Węzeł `[207]`
**[WYBÓR GRACZA: "“I've personally met him once. Didn't seem like a bad guy.”"]** — Mówca: **Player**
> "“I've personally met him once. Didn't seem like a bad guy.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Nia Morgna: "“You need to be careful with the oligarchs, Mr. President..."*)

### Węzeł `[208]`
Mówca: **Nia Morgna**
> "“They always try to impress but it is all smoke and mirrors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Nia Morgna: "“So. Will you allow us to open an investigation?”"*)

### Węzeł `[209]`
Mówca: **Narrator**
> "We both locked eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player: "“Begin an official investigation to find out if HOS is wo..."*)
  - -> `[210]` (*Player: "“We can't be hasty here. We will wait until we have a mor..."*)
  - -> `[203]` (*Player: "“Absolutely not. Keep your focus on Tusk.""*)

### Węzeł `[210]`
**[WYBÓR GRACZA: "“We can't be hasty here. We will wait until we have a more concrete lead.”"]** — Mówca: **Player**
> "“We can't be hasty here. We will wait until we have a more concrete lead.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Nia Morgna: "“It seems... questionable that we aren't pursuing this now.”"*)

### Węzeł `[211]`
Mówca: **Nia Morgna**
> "“It seems... questionable that we aren't pursuing this now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player: "“It would be even worse if we acted too hasty and the lea..."*)
  - -> `[196]` (*Player: "“I trust that we will come with enough information to inc..."*)
  - -> `[202]` (*Player: "“There is just not enough evidence to trigger an investig..."*)

### Węzeł `[212]`
Mówca: **Nia Morgna**
> "“I will contact Lileas and get to the bottom of it. Expect a report soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player: "“Very well. Meeting adjourned then.”"*)
  - -> `[206]` (*Player: "“Looking forward to the results. Do your best.”"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_InvestigationOnHOS = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigat..."*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "“It would be even worse if we acted too hasty and the lead turned out to be a false one.”"]** — Mówca: **Player**
> "“It would be even worse if we acted too hasty and the lead turned out to be a false one.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[211]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Nia Morgna: "“Hmm. You may be right, but I'd hate to find out that we ..."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "Karl Greiser requested to set up a short meeting regarding Marcel Koronti."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "He entered the meeting room and saluted."*)

### Węzeł `[216]`
Mówca: **Narrator**
> "He entered the meeting room and saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player: "“Karl. Good to see you. What did you want to talk about?”"*)
  - -> `[218]` (*Player: "“This better be worth my time.”"*)
  - -> `[219]` (*Player: "“At ease.”"*)
  - -> `[221]` (*Player_Italic: "Salute him."*)

### Węzeł `[217]`
**[WYBÓR GRACZA: "“Karl. Good to see you. What did you want to talk about?”"]** — Mówca: **Player**
> "“Karl. Good to see you. What did you want to talk about?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Karl Greiser: "“Mr. President.”"*)

### Węzeł `[218]`
**[WYBÓR GRACZA: "“This better be worth my time.”"]** — Mówca: **Player**
> "“This better be worth my time.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Karl Greiser: "“Mr. President.”"*)

### Węzeł `[219]`
**[WYBÓR GRACZA: "“At ease.”"]** — Mówca: **Player**
> "“At ease.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Karl Greiser: "“Mr. President.”"*)

### Węzeł `[220]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Karl Greiser: "“I wanted to give you an update on the current status of ..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "Salute him."]** — Mówca: **Player_Italic**
> "I saluted him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Karl Greiser: "“Mr. President.”"*)

### Węzeł `[222]`
Mówca: **Karl Greiser**
> "“I wanted to give you an update on the current status of Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Karl Greiser: "“We have interrogated him and learned about something ext..."*)

### Węzeł `[223]`
Mówca: **Karl Greiser**
> "“We have interrogated him and learned about something extremely disturbing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Karl Greiser: "“By his account, HOS has been making deals with the Koran..."*)

### Węzeł `[224]`
Mówca: **Karl Greiser**
> "“By his account, HOS has been making deals with the Koranelli Cartel in Estord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: "“Are you sure about this? If this is true, this is really..."*)
  - -> `[227]` (*Player: "“Traitor! I knew it was a good idea to put him in prison.”"*)
  - -> `[228]` (*Player: "“This doesn't surprise me at all.”"*)

### Węzeł `[225]`
Mówca: **Karl Greiser**
> "“He will spend the rest of his life in prison.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player: "“Serves him right!”"*)
  - -> `[232]` (*Player: "“Try to get whatever you can out from him. There might be..."*)
  - -> `[235]` (*Player: "“Very good. Anything else?”"*)

### Węzeł `[226]`
**[WYBÓR GRACZA: "“Are you sure about this? If this is true, this is really big.”"]** — Mówca: **Player**
> "“Are you sure about this? If this is true, this is really big.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Karl Greiser: "“We have his written testimony, sir. Also, we checked the..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA: "“Traitor! I knew it was a good idea to put him in prison.”"]** — Mówca: **Player**
> "“Traitor! I knew it was a good idea to put him in prison.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Karl Greiser: "“I agree, sir.”"*)

### Węzeł `[228]`
**[WYBÓR GRACZA: "“This doesn't surprise me at all.”"]** — Mówca: **Player**
> "“This doesn't surprise me at all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Karl Greiser: "“Me too, sir. It was a good idea to put him in custody.”"*)

### Węzeł `[229]`
Mówca: **Karl Greiser**
> "“Me too, sir. It was a good idea to put him in custody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Karl Greiser: "“He will spend the rest of his life in prison.”"*)

### Węzeł `[230]`
Mówca: **Karl Greiser**
> "“I agree, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Karl Greiser: "“He will spend the rest of his life in prison.”"*)

### Węzeł `[231]`
Mówca: **Karl Greiser**
> "“We have his written testimony, sir. Also, we checked the connections. It all seems to add up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Karl Greiser: "“He will spend the rest of his life in prison.”"*)

### Węzeł `[232]`
**[WYBÓR GRACZA: "“Try to get whatever you can out from him. There might be more leads.”"]** — Mówca: **Player**
> "“Try to get whatever you can out from him. There might be more leads.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Karl Greiser: "“As you wish.”"*)

### Węzeł `[233]`
Mówca: **Karl Greiser**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "“Serves him right!”"]** — Mówca: **Player**
> "“Serves him right!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Karl Greiser: "“You have brought a known criminal to justice.”"*)

### Węzeł `[235]`
**[WYBÓR GRACZA: "“Very good. Anything else?”"]** — Mówca: **Player**
> "“Very good. Anything else?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[236]`
Mówca: **Karl Greiser**
> "“You have brought a known criminal to justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)

### Węzeł `[237]`
Mówca: **Karl Greiser**
> "“There is...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Karl Greiser: "“There is something else he confessed, sir.”"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Karl Greiser: "“There is...”"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Karl Greiser: "“That is all I had for today, sir.”"*)

### Węzeł `[241]`
Mówca: **Karl Greiser**
> "“That is all I had for today, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: "“Good. We are done then. Dismissed.”"*)
  - -> `[242]` (*Player: "“Excellent. You may leave now.”"*)
  - -> `[243]` (*Player: "“Keep up the good work.”"*)

### Węzeł `[242]`
**[WYBÓR GRACZA: "“Excellent. You may leave now.”"]** — Mówca: **Player**
> "“Excellent. You may leave now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Karl Greiser), `[269]` (Karl Greiser), `[289]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Karl Greiser: "“Thank you, Mr. President.”"*)

### Węzeł `[243]`
**[WYBÓR GRACZA: "“Keep up the good work.”"]** — Mówca: **Player**
> "“Keep up the good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Karl Greiser), `[269]` (Karl Greiser), `[289]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Karl Greiser: "“It's my duty.”"*)

### Węzeł `[244]`
**[WYBÓR GRACZA: "“Good. We are done then. Dismissed.”"]** — Mówca: **Player**
> "“Good. We are done then. Dismissed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Karl Greiser), `[269]` (Karl Greiser), `[289]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Karl Greiser: "“Thank you, Mr. President.”"*)

### Węzeł `[245]`
Mówca: **Narrator**
> "He saluted again and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_SnO_EstordRaid = true"*)

### Węzeł `[246]`
Mówca: **Karl Greiser**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "He saluted again and left the room."*)

### Węzeł `[247]`
Mówca: **Karl Greiser**
> "“It's my duty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Karl Greiser: "“Thank you, Mr. President.”"*)

### Węzeł `[248]`
Mówca: **Karl Greiser**
> "“There is something else he confessed, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Karl Greiser: "“We have disregarded his remarks, obviously.”"*)

### Węzeł `[249]`
Mówca: **Karl Greiser**
> "“We have disregarded his remarks, obviously.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Karl Greiser: "“He was definitely lying.”"*)

### Węzeł `[250]`
Mówca: **Karl Greiser**
> "“He was definitely lying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player: "“What did he confess?”"*)
  - -> `[252]` (*Player: "“Speak, man.”"*)
  - -> `[253]` (*Player: "“Lying about what?”"*)

### Węzeł `[251]`
**[WYBÓR GRACZA: "“What did he confess?”"]** — Mówca: **Player**
> "“What did he confess?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Karl Greiser: "“He...he said that he had a deal with you, sir.”"*)

### Węzeł `[252]`
**[WYBÓR GRACZA: "“Speak, man.”"]** — Mówca: **Player**
> "“Speak, man.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Karl Greiser: "“He...he said that he had a deal with you, sir.”"*)

### Węzeł `[253]`
**[WYBÓR GRACZA: "“Lying about what?”"]** — Mówca: **Player**
> "“Lying about what?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[250]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Karl Greiser: "“He...he said that he had a deal with you, sir.”"*)

### Węzeł `[254]`
Mówca: **Karl Greiser**
> "“He...he said that he had a deal with you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Karl Greiser: "“He said he lent you his power to control the media.”"*)

### Węzeł `[255]`
Mówca: **Karl Greiser**
> "“He said he lent you his power to control the media.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Karl Greiser: "“Of course... he was lying.”"*)

### Węzeł `[256]`
Mówca: **Karl Greiser**
> "“Of course... he was lying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Player: "“Yes. What else did he say?”"*)
  - -> `[257]` (*Player: "“I see. He is trying to bring me down along with himself.”"*)
  - -> `[258]` (*Player: "“You will not speak a word of this to anyone. Do you unde..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA: "“I see. He is trying to bring me down along with himself.”"]** — Mówca: **Player**
> "“I see. He is trying to bring me down along with himself.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Karl Greiser: "“That is exactly what I thought, sir.”"*)

### Węzeł `[258]`
**[WYBÓR GRACZA: "“You will not speak a word of this to anyone. Do you understand?”"]** — Mówca: **Player**
> "“You will not speak a word of this to anyone. Do you understand?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Karl Greiser: "“As you command.”"*)

### Węzeł `[259]`
**[WYBÓR GRACZA: "“Yes. What else did he say?”"]** — Mówca: **Player**
> "“Yes. What else did he say?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Karl Greiser: "“He gave further accounts on how the deal was made.”"*)

### Węzeł `[260]`
Mówca: **Karl Greiser**
> "“He gave further accounts on how the deal was made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Karl Greiser: "“He does have a very wild imagination, but I did not fall..."*)

### Węzeł `[261]`
Mówca: **Karl Greiser**
> "“That is exactly what I thought, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Karl Greiser: "“He does have a very wild imagination, but I did not fall..."*)

### Węzeł `[262]`
Mówca: **Karl Greiser**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player: "“Make sure these rumours never get out. It might create a..."*)
  - -> `[265]` (*Player: "“I'm not worried. No one will believe this broken man.”"*)

### Węzeł `[263]`
**[WYBÓR GRACZA: "“Make sure these rumours never get out. It might create a problem.”"]** — Mówca: **Player**
> "“Make sure these rumours never get out. It might create a problem.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Karl Greiser), `[264]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Karl Greiser: "“Only a few officers who were in the area heard him.”"*)

### Węzeł `[264]`
Mówca: **Karl Greiser**
> "“He does have a very wild imagination, but I did not fall for it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[263]` (*Player: "“Make sure these rumours never get out. It might create a..."*)
  - -> `[265]` (*Player: "“I'm not worried. No one will believe this broken man.”"*)

### Węzeł `[265]`
**[WYBÓR GRACZA: "“I'm not worried. No one will believe this broken man.”"]** — Mówca: **Player**
> "“I'm not worried. No one will believe this broken man.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Karl Greiser), `[264]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Karl Greiser: "“There is no way, sir.”"*)

### Węzeł `[266]`
Mówca: **Karl Greiser**
> "“There is no way, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Karl Greiser: "“That brings me to the end of my report.”"*)

### Węzeł `[267]`
Mówca: **Karl Greiser**
> "“Only a few officers who were in the area heard him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Karl Greiser: "“I will make sure your order is conveyed and implemented.”"*)

### Węzeł `[268]`
Mówca: **Karl Greiser**
> "“I will make sure your order is conveyed and implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Karl Greiser: "“That brings me to the end of my report.”"*)

### Węzeł `[269]`
Mówca: **Karl Greiser**
> "“That is all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: "“Good. We are done then. Dismissed.”"*)
  - -> `[242]` (*Player: "“Excellent. You may leave now.”"*)
  - -> `[243]` (*Player: "“Keep up the good work.”"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player: "“He is too dangerous to stay alive. I want him gone. Disc..."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[273]`
**[WYBÓR GRACZA: "“He is too dangerous to stay alive. I want him gone. Discreetly.”"]** — Mówca: **Player**
> "“He is too dangerous to stay alive. I want him gone. Discreetly.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Kontekst wejściowy (poprzednik):** `[264]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Killed_MarcelKoronti = true"*)

### Węzeł `[274]`
Mówca: **Karl Greiser**
> "“Sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player: "“I gave you an order.”"*)
  - -> `[275]` (*Player: "“You heard me. Are you questioning my decision, Karl?”"*)
  - -> `[276]` (*Player: "“He has shown that he can affect the administration even ..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA: "“You heard me. Are you questioning my decision, Karl?”"]** — Mówca: **Player**
> "“You heard me. Are you questioning my decision, Karl?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Karl Greiser: "“No, sir. I will handle it right away.”"*)

### Węzeł `[276]`
**[WYBÓR GRACZA: "“He has shown that he can affect the administration even in custody.”"]** — Mówca: **Player**
> "“He has shown that he can affect the administration even in custody.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Karl Greiser: "“Makes sense, sir. I will handle it right away.”"*)

### Węzeł `[277]`
**[WYBÓR GRACZA: "“I gave you an order.”"]** — Mówca: **Player**
> "“I gave you an order.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[274]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Karl Greiser: "“Yes, sir. Right away.”"*)

### Węzeł `[278]`
Mówca: **Karl Greiser**
> "“Yes, sir. Right away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Karl Greiser: "“Rest assured. No one will hear of this.”"*)

### Węzeł `[279]`
Mówca: **Karl Greiser**
> "“No, sir. I will handle it right away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Karl Greiser: "“Rest assured. No one will hear of this.”"*)

### Węzeł `[280]`
Mówca: **Karl Greiser**
> "“Makes sense, sir. I will handle it right away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Karl Greiser: "“Rest assured. No one will hear of this.”"*)

### Węzeł `[281]`
Mówca: **Karl Greiser**
> "“Rest assured. No one will hear of this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Player: "“That better be right. For your own good.”"*)
  - -> `[283]` (*Player: "“Remember. Both you and I are responsible for protecting ..."*)
  - -> `[285]` (*Player: "“Thank you, Karl. You are a loyal man.”"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Killed_MarcelKoronti = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Killed_MarcelKoronti"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_EstordRaid_MarcelKilled = ..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA: "“Remember. Both you and I are responsible for protecting Sordland.”"]** — Mówca: **Player**
> "“Remember. Both you and I are responsible for protecting Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Karl Greiser: "“I live for Sordland, sir.”"*)

### Węzeł `[284]`
**[WYBÓR GRACZA: "“That better be right. For your own good.”"]** — Mówca: **Player**
> "“That better be right. For your own good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Karl Greiser: "“As you command.”"*)

### Węzeł `[285]`
**[WYBÓR GRACZA: "“Thank you, Karl. You are a loyal man.”"]** — Mówca: **Player**
> "“Thank you, Karl. You are a loyal man.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Karl Greiser: "“Thank you, sir.”"*)

### Węzeł `[286]`
Mówca: **Karl Greiser**
> "“I live for Sordland, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Karl Greiser: "“That brings me to the end of my report.”"*)

### Węzeł `[287]`
Mówca: **Karl Greiser**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Karl Greiser: "“That brings me to the end of my report.”"*)

### Węzeł `[288]`
Mówca: **Karl Greiser**
> "“Thank you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Karl Greiser: "“That brings me to the end of my report.”"*)

### Węzeł `[289]`
Mówca: **Karl Greiser**
> "“That is all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: "“Good. We are done then. Dismissed.”"*)
  - -> `[242]` (*Player: "“Excellent. You may leave now.”"*)
  - -> `[243]` (*Player: "“Keep up the good work.”"*)

### Węzeł `[290]`
Mówca: **Karl Greiser**
> "“That brings me to the end of my report.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Karl Greiser: "“That is all I had for today.”"*)

### Węzeł `[291]`
Mówca: **Karl Greiser**
> "“That brings me to the end of my report.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Karl Greiser: "“That is all I had for today.”"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_KorontiInvestigationStopped = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestig..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SnO_KorontiInvestigationStopped = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestig..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_EstordRaid_MarcelKilled = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_MarcelKilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Karl Greiser: "“Sir?”"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Nia Morgna: "“I will contact Lileas and get to the bottom of it. Expec..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Lileas Graf: "“I'll get in touch with Nia right away. Of course, I need..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestigation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Nia Morgna: "“Well. That is all I had for today.”"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestigation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lileas Graf: "“Well. That is all I had for today.”"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Marcel Koronti: "“Very well. What is the information then?”"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Marcel Koronti: "“I must now make sure my people are on this.”"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_MarcelKoronti == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Fled_MarcelKoronti == false"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Fled_MarcelKoronti == false)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Fled_MarcelKoronti == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Italic: "Call Marcel Koronti."*)
  - -> `[5]` (*Player_Italic: "Do nothing."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Fled_MarcelKoronti == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_SnO_EstordRaid = true"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true || BaseGame.Turn07_A_Marcel_OwnershipDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true || BaseGame.Turn07_A_..."*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true || BaseGame.Turn07_..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true || BaseGame.Turn07_A_Marcel_OwnershipDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  or  Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "If Marcel's cartel ties were real, this was huge news. My..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true || BaseGame.Turn07_A_Marcel_OwnershipDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  or  Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "If Marcel's cartel ties were real, this was huge news."*)

### Węzeł `[307]`
Mówca: **Narrator**
> "If Marcel's cartel ties were real, this was huge news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I had to be careful. More so than ever."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "I hung up on Marcel."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Marcel_FundsReElection = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Marcel_FundsReElection"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReel..."*)

### Węzeł `[310]`
Mówca: **Marcel Koronti**
> "“Well, I don't think I can make an offer without seeing what I am buying first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Player: "“Disappointing, I will find someone else to work with.”"*)
  - -> `[33]` (*Player: "“Too bad, then. See you Marcel.”"*)

### Węzeł `[311]`
**[WYBÓR GRACZA: "“What are you offering for this information?”"]** — Mówca: **Player**
> "“What are you offering for this information?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Marcel Koronti: "“Well, I don't think I can make an offer without seeing w..."*)

### Węzeł `[312]`
**[WYBÓR GRACZA: "“Disappointing, I will find someone else to work with.”"]** — Mówca: **Player**
> "“Disappointing, I will find someone else to work with.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Marcel Koronti)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Marcel Koronti: "“Wait.”"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
