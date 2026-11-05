# Rizia/Turn 9/FPnT_CallWithSmolak

- **ID konwersacji:** `434`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/434_FPnT_CallWithSmolak.md`
- **Liczba węzłów dialogowych:** 208
- **Liczba wyborów gracza:** 52

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[77]** Wiktor Smolak (R)
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Turn06_Cemetary_HonorDadPales`
- `RiziaDLC.Turn06_Cemetary_RectifyLegacyPales`
- `RiziaDLC.War_Objective_Captured_Remaz`
- `RiziaDLC.War_Objective_Captured_Solles`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLC.ZilleReferendum_NotStoppedByAN`
- `RiziaDLC.ZilleReturn_Success`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.War_Pales_Won`
- `RiziaDLC.War_WehlenJoined`
- `RiziaDLC.ZilleReferendum_SmolakOffer_Accepted`
- `RiziaDLC.ZilleReferendum_SmolakOffer_Rejected`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferAccepted`
- `RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferRejected`
- `RiziaDLCSupport.News_Turn09_G_SmolakCall_WehlenJoinsWar`
- `RiziaDLCSupport.News_Turn09_RH_SmolakCall_WehlenJoinsWar`
- `RiziaDLCSupport.News_Turn09_V_SmolakCall_WehlenJoinsWar`
- `RiziaDLCSupport.Reports_Turn09_MaveNortus_SmolakCall_WehlenJoinsWar`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **""Good evening, Mr. President. To what do I owe the pleasure?""** | `[7]` **Wiktor Smolak (R)**: ""Good evening, Your Majesty. I h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Wiktor Smolak (R)**: ""So tell me... how are you doing..." |
| `[9]` | **""Why did you call?""** | `[7]` **Wiktor Smolak (R)**: ""Good evening, Your Majesty. I h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Wiktor Smolak (R)**: ""My my. Last I recall, Rizians w..." |
| `[10]` | **""I wasn't disturbed before. Now I am.""** | `[7]` **Wiktor Smolak (R)**: ""Good evening, Your Majesty. I h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Wiktor Smolak (R)**: ""My my. Last I recall, Rizians w..." |
| `[13]` | **""None of your business.""** | `[12]` **Wiktor Smolak (R)**: ""So tell me... how are you doing..."<br>`[102]` **Wiktor Smolak (R)**: ""So how are you, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Wiktor Smolak (R)**: ""Alright, I will cut to the chase."" |
| `[14]` | **""I'm well. And you?""** | `[12]` **Wiktor Smolak (R)**: ""So tell me... how are you doing..."<br>`[102]` **Wiktor Smolak (R)**: ""So how are you, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Wiktor Smolak (R)**: ""Oh, you know how it is. Purging..." |
| `[15]` | **""Savoring the high life in one of my many palaces. You know?""** | `[12]` **Wiktor Smolak (R)**: ""So tell me... how are you doing..."<br>`[102]` **Wiktor Smolak (R)**: ""So how are you, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Wiktor Smolak (R)**: ""As a matter of fact, I do."" |
| `[24]` | **""I am listening.""** | `[22]` **Narrator**: "The water suddenly felt cold aga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "He took another drag." |
| `[25]` | **""Make it quick.""** | `[22]` **Narrator**: "The water suddenly felt cold aga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "He took another drag." |
| `[26]` | **""What is it?""** | `[22]` **Narrator**: "The water suddenly felt cold aga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "He took another drag." |
| `[29]` | **""Cut to the chase.""** | `[27]` **Wiktor Smolak (R)**: ""How is your little war going?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Wiktor Smolak (R)**: ""A man of few words, are you?"" |
| `[30]` | **""That's none of your business.""** | `[27]` **Wiktor Smolak (R)**: ""How is your little war going?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Wiktor Smolak (R)**: ""Don't be so rude, Your Majesty...." |
| `[31]` | **""Very well, thank you. A full victory is at hand.""** | `[27]` **Wiktor Smolak (R)**: ""How is your little war going?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Wiktor Smolak (R)**: ""Be glad you're a king and not a..."<br>`[34]` **Wiktor Smolak (R)**: ""Oh, really? Well, that's good. ..." |
| `[32]` | **""It could be better.""** | `[27]` **Wiktor Smolak (R)**: ""How is your little war going?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Wiktor Smolak (R)**: ""I thought so."" |
| `[38]` | **""If I didn't know any better, I'd interpret that as a veiled threat.""** | `[106]` **Wiktor Smolak (R)**: ""The unmatched glory that is the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Wiktor Smolak (R)**: ""Now. Now. No need to be so tense."" |
| `[39]` | **""And then?""** | `[106]` **Wiktor Smolak (R)**: ""The unmatched glory that is the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Wiktor Smolak (R)**: ""Here comes the good part."" |
| `[40]` | **""Are you out of your mind?""** | `[106]` **Wiktor Smolak (R)**: ""The unmatched glory that is the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Wiktor Smolak (R)**: ""Now. Now. No need to be so tense."" |
| `[43]` | **""What exactly is this glorious army doing?""** | `[106]` **Wiktor Smolak (R)**: ""The unmatched glory that is the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Wiktor Smolak (R)**: ""Here comes the good part."" |
| `[48]` | **""And what do you want in return?""** | `[46]` **Wiktor Smolak (R)**: ""So how about that?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Narrator**: "I heard a clink as he put the pi..." |
| `[49]` | **""Thank you for your generosity. Of course we would accept Wehlen's unconditional a..."** | `[46]` **Wiktor Smolak (R)**: ""So how about that?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Wiktor Smolak (R)**: ""Now hold on a minute... there's..." |
| `[50]` | **""I'm hanging up.""** | `[46]` **Wiktor Smolak (R)**: ""So how about that?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Wiktor Smolak (R)**: ""Hold on. Hold on."" |
| `[56]` | **""Absolutely not. What made you think Rizia can't win without Wehlen?""** | `[63]` **Wiktor Smolak (R)**: ""So what do you think? Do we hav..."<br>`[64]` **Narrator**: "I thought about it for another b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.ZilleReferendum_SmolakOffer_Rejected"]...` | `[60]` **Wiktor Smolak (R)**: ""Too bad. A pity."" |
| `[57]` | **""I'd rather not give up Zille. Perhaps, there's another option we can explore?""** | `[63]` **Wiktor Smolak (R)**: ""So what do you think? Do we hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Wiktor Smolak (R)**: ""This deal isn't negotiable. It'..." |
| `[61]` | **""Very well. I agree to your conditions, but only if you follow through with your s..."** | `[63]` **Wiktor Smolak (R)**: ""So what do you think? Do we hav..."<br>`[64]` **Narrator**: "I thought about it for another b..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `SetRichPresence("Losing one territory to regain the other...`<br>`Variable["RiziaDLC.War_Pales_Won"] = true; Variable["Rizi...` | `[65]` **Wiktor Smolak (R)**: ""Excellent! And of course, I'll ..." |
| `[70]` | **""Good night, Mr. President.""** | `[69]` **Wiktor Smolak (R)**: ""I wish you a good night, Your M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "He hung up." |
| `[71]` | **""I hope to never hear your voice again.""** | `[69]` **Wiktor Smolak (R)**: ""I wish you a good night, Your M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Wiktor Smolak (R)**: ""That makes two of us."" |
| `[72]` | **""Piss off.""** | `[69]` **Wiktor Smolak (R)**: ""I wish you a good night, Your M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Narrator**: "He hung up." |
| `[80]` | **""Good evening.""** | `[79]` **Wiktor Smolak (R)**: ""I'm eager to attend the victory..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "He hung up." |
| `[81]` | **""They'll surpass your wildest expectations, Mr. President.""** | `[79]` **Wiktor Smolak (R)**: ""I'm eager to attend the victory..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Wiktor Smolak (R)**: ""Well, I've had some pretty wild..." |
| `[82]` | **""Should you betray me, I'll make sure both you and your nation suffer the conseque..."** | `[79]` **Wiktor Smolak (R)**: ""I'm eager to attend the victory..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Wiktor Smolak (R)**: ""You're speaking my language, Yo..." |
| `[83]` | **""An interesting proposal... But how do I know you won't renege?""** | `[63]` **Wiktor Smolak (R)**: ""So what do you think? Do we hav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Wiktor Smolak (R)**: ""We will sign an agreement, of c..." |
| `[97]` | **""I was just about to take a leisurely swim in my pool of gold coins. But I suppose..."** | `[7]` **Wiktor Smolak (R)**: ""Good evening, Your Majesty. I h..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[98]` **Wiktor Smolak (R)**: ""'Ha! 'Pool of gold coins...' I'..." |
| `[104]` | **""Well, don't keep me in suspense. The anticipation is absolutely killing me!""** | `[22]` **Narrator**: "The water suddenly felt cold aga..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Narrator**: "There was a noticeable pause bef..." |
| `[115]` | **""A military alliance with Wiktor Smolak... what have I gotten myself into... ""** | `[118]` **Narrator**: "As I set my phone down, I reflec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "I muttered the words to no one b..." |
| `[116]` | **""Pales is within my grasp. I can feel it.""** | `[118]` **Narrator**: "As I set my phone down, I reflec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "I muttered the words to no one b..." |
| `[117]` | **""I've almost finished what my father started. "The Rizian flag *will* fly over Pal..."** | `[118]` **Narrator**: "As I set my phone down, I reflec..." | `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true` | *Brak zmian stanu* | `[86]` **Narrator**: "I muttered the words to no one b..." |
| `[121]` | **""A military alliance with Wiktor Smolak... I can't believe I even considered it.""** | `[123]` **Narrator**: "As I set my phone down, I reflec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "I said the words out loud to no ..." |
| `[122]` | **""Pales is within my grasp. I can feel it. Not even a two-bit dictator like Wiktor ..."** | `[123]` **Narrator**: "As I set my phone down, I reflec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "I said the words out loud to no ..." |
| `[124]` | **"Screw Smolak... I will finish what my father started. The Rizian flag *will* fly o..."** | `[123]` **Narrator**: "As I set my phone down, I reflec..." | `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true` | *Brak zmian stanu* | `[120]` **Narrator**: "I said the words out loud to no ..." |
| `[131]` | **""Screw Smolak... I don't need his help to rectify my father's mistakes. The Rizian..."** | `[123]` **Narrator**: "As I set my phone down, I reflec..." | `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true`<br>`(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false` | *Brak zmian stanu* | `[120]` **Narrator**: "I said the words out loud to no ..." |
| `[132]` | **""Screw Smolak. I don't need his help. The Rizian flag *will* fly over Pales and Zi..."** | `[123]` **Narrator**: "As I set my phone down, I reflec..." | `(Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true) == false`<br>`(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false` | *Brak zmian stanu* | `[120]` **Narrator**: "I said the words out loud to no ..." |
| `[139]` | **""The Rizian flag *will* once again fly over Pales. My father's mistakes will no lo..."** | `[118]` **Narrator**: "As I set my phone down, I reflec..." | `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true`<br>`(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false` | *Brak zmian stanu* | `[86]` **Narrator**: "I muttered the words to no one b..." |
| `[140]` | **""The Rizian flag *will* fly over Pales once more.""** | `[118]` **Narrator**: "As I set my phone down, I reflec..." | `(Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true) == false`<br>`(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false` | *Brak zmian stanu* | `[86]` **Narrator**: "I muttered the words to no one b..." |
| `[162]` | **""After everything I went through to get Zille back? Forget it.""** | `[53]` **Wiktor Smolak (R)**: ""I'm offering a trade. Zille for..." | `Variable["RiziaDLC.ZilleReturn_Success"] == true` | *Brak zmian stanu* | `[182]` **Wiktor Smolak (R)**: ""And here I thought you were doi..." |
| `[166]` | **""I see through your desperation. You're making this offer because you're going to ..."** | `[53]` **Wiktor Smolak (R)**: ""I'm offering a trade. Zille for..." | `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true` | *Brak zmian stanu* | `[184]` **Wiktor Smolak (R)**: ""Do you own a crystal ball, Your..." |
| `[170]` | **""It's too late for that, Mr. President. Zille is a part of Rizia again.""** | `[53]` **Wiktor Smolak (R)**: ""I'm offering a trade. Zille for..." | `Variable["RiziaDLC.ZilleReturn_Success"] == true` | *Brak zmian stanu* | `[174]` **Wiktor Smolak (R)**: ""It's never too late for another..." |
| `[171]` | **""Listen here, Smolak. Your puny little troops will only interfere with the unstopp..."** | `[53]` **Wiktor Smolak (R)**: ""I'm offering a trade. Zille for..." | `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true` | *Brak zmian stanu* | `[202]` **Narrator**: "He adopted a wounded tone." |
| `[181]` | **""Have you opened a newspaper lately? We're closing in on the Palesian capital. We ..."** | `[53]` **Wiktor Smolak (R)**: ""I'm offering a trade. Zille for..." | `Variable["RiziaDLC.War_Objective_Captured_Remaz"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Solles"]` | *Brak zmian stanu* | `[202]` **Narrator**: "He adopted a wounded tone." |
| `[186]` | **""Rizia calling on the Wehzek army for help? It's been done.""** | `[46]` **Wiktor Smolak (R)**: ""So how about that?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Wiktor Smolak (R)**: ""And it worked, didn't it?"" |
| `[188]` | **""Please elaborate.""** | `[53]` **Wiktor Smolak (R)**: ""I'm offering a trade. Zille for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Wiktor Smolak (R)**: ""It's simple. After we help you ..." |
| `[190]` | **""And what if your troops fail? We'll lose two regions in one go.""** | `[53]` **Wiktor Smolak (R)**: ""I'm offering a trade. Zille for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Wiktor Smolak (R)**: ""Don't you worry, Your Majesty. ..." |
| `[196]` | **""I'll see you at the Zille return ceremony.""** | `[69]` **Wiktor Smolak (R)**: ""I wish you a good night, Your M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Wiktor Smolak (R)**: ""I wouldn't count on it.""<br>`[201]` **Wiktor Smolak (R)**: ""If your war duties don't beckon."" |
| `[205]` | **""Excuse me?! Why is my Romultini glass empty?""** | `[118]` **Narrator**: "As I set my phone down, I reflec..."<br>`[123]` **Narrator**: "As I set my phone down, I reflec..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Narrator**: "My attendant ran to refresh my d..." |

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
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was having a massage and cocktail on the balcony of Palas Toras, high above Monqiz. The sun was setting, its rays shimmering on the water and illuminating the Rumburgian flags flying over the port."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "I basked in the serenity, almost able to forget my troubl..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "My masseuse handed me a towel as I got up. Fully adept at blending business with pleasure, I reached for my cocktail and told the attendent I'd be taking the call in the pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "When I reached my private oasis -- surrounded by marble c..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "As I did, the attendant ran a telephone out to me, setting it on the pool's edge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "He informed me that Wiktor Smolak was on the other end of..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "He informed me that Wiktor Smolak was on the other end of the line."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "I almost spit out my drink. I took a moment to compose my..."*)

### Węzeł `[7]`
Mówca: **Wiktor Smolak (R)**
> ""Good evening, Your Majesty. I hope I am not disturbing your regal downtime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[8]` (*Player_Romus: ""Good evening, Mr. President. To what do I owe the pleasu..."*)
  - -> `[9]` (*Player_Romus: ""Why did you call?""*)
  - -> `[10]` (*Player_Romus: ""I wasn't disturbed before. Now I am.""*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good evening, Mr. President. To what do I owe the pleasure?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Wiktor Smolak (R): ""So tell me... how are you doing, Your Majesty?""*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why did you call?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Wiktor Smolak (R): ""My my. Last I recall, Rizians were a bit more welcoming ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wasn't disturbed before. Now I am.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Wiktor Smolak (R): ""My my. Last I recall, Rizians were a bit more welcoming ..."*)

### Węzeł `[11]`
Mówca: **Wiktor Smolak (R)**
> ""My my. Last I recall, Rizians were a bit more welcoming than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Wiktor Smolak (R): ""So tell me... how are you doing, Your Majesty?""*)

### Węzeł `[12]`
Mówca: **Wiktor Smolak (R)**
> ""So tell me... how are you doing, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""Savoring the high life in one of my many palaces. You kn..."*)
  - -> `[14]` (*Player_Romus: ""I'm well. And you?""*)
  - -> `[13]` (*Player_Romus: ""None of your business.""*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""None of your business.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Wiktor Smolak (R)), `[102]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Wiktor Smolak (R): ""Alright, I will cut to the chase.""*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm well. And you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Wiktor Smolak (R)), `[102]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Wiktor Smolak (R): ""Oh, you know how it is. Purging my cabinet of infiltrato..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Savoring the high life in one of my many palaces. You know?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Wiktor Smolak (R)), `[102]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Wiktor Smolak (R): ""As a matter of fact, I do.""*)

### Węzeł `[16]`
Mówca: **Wiktor Smolak (R)**
> ""As a matter of fact, I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Wiktor Smolak (R): ""I'm currently partaking in the very same indulgence.""*)

### Węzeł `[17]`
Mówca: **Wiktor Smolak (R)**
> ""I'm currently partaking in the very same indulgence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Wiktor Smolak (R): ""Listen, Your Majesty.""*)

### Węzeł `[18]`
Mówca: **Wiktor Smolak (R)**
> ""Alright, I will cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Wiktor Smolak (R): ""Listen, Your Majesty.""*)

### Węzeł `[19]`
Mówca: **Wiktor Smolak (R)**
> ""Oh, you know how it is. Purging my cabinet of infiltrators, taking out 'personal loans' from the treasury department...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Wiktor Smolak (R): ""Just another day at the office.""*)

### Węzeł `[20]`
Mówca: **Wiktor Smolak (R)**
> ""Listen, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Wiktor Smolak (R): ""I have a proposition for you...""*)

### Węzeł `[21]`
Mówca: **Wiktor Smolak (R)**
> ""I have a proposition for you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "I heard him take a puff, likely from a khisha pipe."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "The water suddenly felt cold against my skin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus: ""I am listening.""*)
  - -> `[25]` (*Player_Romus: ""Make it quick.""*)
  - -> `[26]` (*Player_Romus: ""What is it?""*)
  - -> `[104]` (*Player_Romus: ""Well, don't keep me in suspense. The anticipation is abs..."*)

### Węzeł `[23]`
Mówca: **Wiktor Smolak (R)**
> ""One you might find to be of interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "The water suddenly felt cold against my skin."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "He took another drag."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Make it quick.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "He took another drag."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "He took another drag."*)

### Węzeł `[27]`
Mówca: **Wiktor Smolak (R)**
> ""How is your little war going?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""That's none of your business.""*)
  - -> `[29]` (*Player_Romus: ""Cut to the chase.""*)
  - -> `[31]` (*Player_Romus: ""Very well, thank you. A full victory is at hand.""*)
  - -> `[32]` (*Player_Romus: ""It could be better.""*)

### Węzeł `[28]`
Mówca: **Narrator**
> "He took another drag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Wiktor Smolak (R): ""How is your little war going?""*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cut to the chase.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Wiktor Smolak (R): ""A man of few words, are you?""*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your business.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Wiktor Smolak (R): ""Don't be so rude, Your Majesty. I'm asking as a friend.""*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well, thank you. A full victory is at hand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == false"*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It could be better.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Wiktor Smolak (R): ""I thought so.""*)

### Węzeł `[33]`
Mówca: **Wiktor Smolak (R)**
> ""I thought so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Wiktor Smolak (R): ""Here's what I think, if I may be so bold...""*)

### Węzeł `[34]`
Mówca: **Wiktor Smolak (R)**
> ""Oh, really? Well, that's good. That's good. Yeah.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Wiktor Smolak (R): ""Here's what I think, if I may be so bold...""*)

### Węzeł `[35]`
Mówca: **Wiktor Smolak (R)**
> ""A man of few words, are you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Wiktor Smolak (R): ""Here's what I think, if I may be so bold...""*)

### Węzeł `[36]`
Mówca: **Wiktor Smolak (R)**
> ""Here's what I think, if I may be so bold...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Wiktor Smolak (R): ""Imagine standing on your palace balcony, watching the su..."*)

### Węzeł `[37]`
Mówca: **Wiktor Smolak (R)**
> ""Imagine standing on your palace balcony, watching the sun dip in the west.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Wiktor Smolak (R): ""Suddenly, just as its fading light teeters over the hori..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I didn't know any better, I'd interpret that as a veiled threat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Wiktor Smolak (R): ""Now. Now. No need to be so tense.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Wiktor Smolak (R): ""Here comes the good part.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you out of your mind?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Wiktor Smolak (R): ""Now. Now. No need to be so tense.""*)

### Węzeł `[41]`
Mówca: **Wiktor Smolak (R)**
> ""Now. Now. No need to be so tense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Wiktor Smolak (R): ""Here comes the good part.""*)

### Węzeł `[42]`
Mówca: **Wiktor Smolak (R)**
> ""Here comes the good part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Wiktor Smolak (R): ""I use my army...""*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What exactly is this glorious army doing?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Wiktor Smolak (R): ""Here comes the good part.""*)

### Węzeł `[44]`
Mówca: **Wiktor Smolak (R)**
> ""I use my army...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Wiktor Smolak (R): ""...to help you win your war in Pales.""*)

### Węzeł `[45]`
Mówca: **Wiktor Smolak (R)**
> ""...to help you win your war in Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Wiktor Smolak (R): ""As you're undoubtedly aware, Wehzek troops boast a legen..."*)

### Węzeł `[46]`
Mówca: **Wiktor Smolak (R)**
> ""So how about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player_Romus: ""Rizia calling on the Wehzek army for help? It's been done.""*)
  - -> `[48]` (*Player_Romus: ""And what do you want in return?""*)
  - -> `[49]` (*Player_Romus: ""Thank you for your generosity. Of course we would accept..."*)
  - -> `[50]` (*Player_Romus: ""I'm hanging up.""*)

### Węzeł `[47]`
Mówca: **Narrator**
> "He took another drag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Wiktor Smolak (R): ""So how about that?""*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what do you want in return?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "I heard a clink as he put the pipe down. His tone shifted..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your generosity. Of course we would accept Wehlen's unconditional assistance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Wiktor Smolak (R): ""Now hold on a minute... there's nothing unconditional ab..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm hanging up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Wiktor Smolak (R): ""Hold on. Hold on.""*)

### Węzeł `[51]`
Mówca: **Wiktor Smolak (R)**
> ""Hold on. Hold on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "I heard a clink as he put the pipe down. His tone shifted..."*)

### Węzeł `[52]`
Mówca: **Wiktor Smolak (R)**
> ""Now hold on a minute... there's nothing unconditional about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "I heard a clink as he put the pipe down. His tone shifted..."*)

### Węzeł `[53]`
Mówca: **Wiktor Smolak (R)**
> ""I'm offering a trade. Zille for Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_NotStoppedByAN == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[188]` (*Player_Romus: ""Please elaborate.""*)
  - -> `[190]` (*Player_Romus: ""And what if your troops fail? We'll lose two regions in ..."*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Remaz == true || RiziaDLC..."*)

### Węzeł `[54]`
Mówca: **Wiktor Smolak (R)**
> ""That's my price. Accept, and Pales will be yours for the taking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Wiktor Smolak (R): ""The offer expires the moment I hang up. Thoughts?""*)

### Węzeł `[55]`
Mówca: **Wiktor Smolak (R)**
> ""The offer expires the moment I hang up. Thoughts?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "I took a moment to mull over his proposal. Could I really..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. What made you think Rizia can't win without Wehlen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Wiktor Smolak (R)), `[64]` (Narrator), `[84]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_SmolakOffer_Rejected = true; Riz..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd rather not give up Zille. Perhaps, there's another option we can explore?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Wiktor Smolak (R): ""This deal isn't negotiable. It's Zille or nothing.""*)

### Węzeł `[58]`
Mówca: **Narrator**
> "I heard a clink as he put the pipe down. His tone shifted to a much more serious one."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Wiktor Smolak (R): ""I'm offering a trade. Zille for Pales.""*)

### Węzeł `[59]`
Mówca: **Wiktor Smolak (R)**
> ""This deal isn't negotiable. It's Zille or nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "I thought about it for another brief moment."*)

### Węzeł `[60]`
Mówca: **Wiktor Smolak (R)**
> ""Too bad. A pity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Wiktor Smolak (R): ""I made my offer.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. I agree to your conditions, but only if you follow through with your side of the bargain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Wiktor Smolak (R)), `[64]` (Narrator), `[84]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Losing one territory to regain the other..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "I took a moment to mull over his proposal. Could I really trade Zille for Pales?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "On the one hand, accepting Wehlen's aid could tip the sca..."*)

### Węzeł `[63]`
Mówca: **Wiktor Smolak (R)**
> ""So what do you think? Do we have a deal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Absolutely not. What made you think Rizia can't win with..."*)
  - -> `[57]` (*Player_Romus: ""I'd rather not give up Zille. Perhaps, there's another o..."*)
  - -> `[83]` (*Player_Romus: ""An interesting proposal... But how do I know you won't r..."*)
  - -> `[61]` (*Player_Romus: ""Very well. I agree to your conditions, but only if you f..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "I thought about it for another brief moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Absolutely not. What made you think Rizia can't win with..."*)
  - -> `[61]` (*Player_Romus: ""Very well. I agree to your conditions, but only if you f..."*)

### Węzeł `[65]`
Mówca: **Wiktor Smolak (R)**
> ""Excellent! And of course, I'll follow through. You have my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Wiktor Smolak (R): ""I understand the importance of trust and honoring one's ..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "I could picture his wide grin in my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Wiktor Smolak (R): ""Then my people will talk to your people and we will be a..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Won = true; RiziaDLC.War_WehlenJoined = true; RiziaDLC.ZilleReturn_Success = false;
RiziaDLC.ZilleReferendum_SmolakOffer_Accepted = true; 
RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferAccepted = true;
RiziaDLCSupport.News_Turn09_G_SmolakCall_WehlenJoinsWar = true;
RiziaDLCSupport.News_Turn09_RH_SmolakCall_WehlenJoinsWar = true;
RiziaDLCSupport.News_Turn09_V_SmolakCall_WehlenJoinsWar = true;
RiziaDLCSupport.Reports_Turn09_MaveNortus_SmolakCall_WehlenJoinsWar = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.War_Pales_Won"] = true;
Variable["RiziaDLC.War_WehlenJoined"] = true;
Variable["RiziaDLC.ZilleReturn_Success"] = false;
Variable["RiziaDLC.ZilleReferendum_SmolakOffer_Accepted"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferAccepted"] = true;
Variable["RiziaDLCSupport.News_Turn09_G_SmolakCall_WehlenJoinsWar"] = true;
Variable["RiziaDLCSupport.News_Turn09_RH_SmolakCall_WehlenJoinsWar"] = true;
Variable["RiziaDLCSupport.News_Turn09_V_SmolakCall_WehlenJoinsWar"] = true;
Variable["RiziaDLCSupport.Reports_Turn09_MaveNortus_SmolakCall_WehlenJoinsWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Wiktor Smolak (R): ""Excellent! And of course, I'll follow through. You have ..."*)

### Węzeł `[68]`
Mówca: **Wiktor Smolak (R)**
> ""I made my offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Wiktor Smolak (R): ""I wish you a good night, Your Majesty. And good luck in ..."*)

### Węzeł `[69]`
Mówca: **Wiktor Smolak (R)**
> ""I wish you a good night, Your Majesty. And good luck in your war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player_Romus: ""I'll see you at the Zille return ceremony.""*)
  - -> `[71]` (*Player_Romus: ""I hope to never hear your voice again.""*)
  - -> `[70]` (*Player_Romus: ""Good night, Mr. President.""*)
  - -> `[72]` (*Player_Romus: ""Piss off.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good night, Mr. President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He hung up."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope to never hear your voice again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Wiktor Smolak (R): ""That makes two of us.""*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Piss off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He hung up."*)

### Węzeł `[73]`
Mówca: **Wiktor Smolak (R)**
> ""That makes two of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He hung up."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Wiktor Smolak (R)");"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[76]`
Mówca: **Wiktor Smolak (R)**
> ""Then my people will talk to your people and we will be all set.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Wiktor Smolak (R): ""You definitely are a man of reason.""*)

### Węzeł `[77]`
Mówca: **Wiktor Smolak (R)**
> ""You definitely are a man of reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Wiktor Smolak (R): ""Just think... this one phone call will inevitably change..."*)

### Węzeł `[78]`
Mówca: **Wiktor Smolak (R)**
> ""I wish you a good evening, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Wiktor Smolak (R): ""I'm eager to attend the victory celebrations in Pales, h..."*)

### Węzeł `[79]`
Mówca: **Wiktor Smolak (R)**
> ""I'm eager to attend the victory celebrations in Pales, hosted by none other than King Romus himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ""They'll surpass your wildest expectations, Mr. President.""*)
  - -> `[80]` (*Player_Romus: ""Good evening.""*)
  - -> `[82]` (*Player_Romus: ""Should you betray me, I'll make sure both you and your n..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good evening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "He hung up."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They'll surpass your wildest expectations, Mr. President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Wiktor Smolak (R): ""Well, I've had some pretty wild dreams, but I'll trust y..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Should you betray me, I'll make sure both you and your nation suffer the consequences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Wiktor Smolak (R): ""You're speaking my language, Your Majesty! I look forwar..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An interesting proposal... But how do I know you won't renege?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Wiktor Smolak (R): ""We will sign an agreement, of course! I trust your forei..."*)

### Węzeł `[84]`
Mówca: **Wiktor Smolak (R)**
> ""We will sign an agreement, of course! I trust your foreign affairs councilor to make sure everything is airtight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: ""Absolutely not. What made you think Rizia can't win with..."*)
  - -> `[61]` (*Player_Romus: ""Very well. I agree to your conditions, but only if you f..."*)

### Węzeł `[85]`
Mówca: **Wiktor Smolak (R)**
> ""You're speaking my language, Your Majesty! I look forward to hearing all about all the dirty details!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "He hung up."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "I muttered the words to no one before submerging myself in the pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_SmolakOffer_Rejected = true; RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferRejected = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_SmolakOffer_Rejected"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferRejected"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Wiktor Smolak (R): ""Too bad. A pity.""*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Wiktor Smolak (R)");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Wiktor Smolak (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Wiktor Smolak (R): ""Good evening, Your Majesty. I hope I am not disturbing y..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Wiktor Smolak (R)");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Wiktor Smolak (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "As I set my phone down, I reflected on what just transpired."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "I took a sip from my virgin Romultini -- my mother's inve..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "I took a sip from my Romultini -- my mother's invention -..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[94]`
Mówca: **Narrator**
> "I took a sip from my virgin Romultini -- my mother's invention -- and let out a long sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "As I did, the attendant ran a telephone out to me, settin..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "I took a sip from my Romultini -- my mother's invention -- and let out a long sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "As I did, the attendant ran a telephone out to me, settin..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "I almost spit out my drink. I took a moment to compose myself before picking up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "AddConversant("Wiktor Smolak (R)");"*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was just about to take a leisurely swim in my pool of gold coins. But I suppose your company is a worthy distraction.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[7]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Wiktor Smolak (R): ""'Ha! 'Pool of gold coins...' I'll have to remember that ..."*)

### Węzeł `[98]`
Mówca: **Wiktor Smolak (R)**
> ""'Ha! 'Pool of gold coins...' I'll have to remember that one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Wiktor Smolak (R): ""So how are you, Your Majesty?""*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""I was just about to take a leisurely swim in my pool of ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[102]`
Mówca: **Wiktor Smolak (R)**
> ""So how are you, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""Savoring the high life in one of my many palaces. You kn..."*)
  - -> `[14]` (*Player_Romus: ""I'm well. And you?""*)
  - -> `[13]` (*Player_Romus: ""None of your business.""*)

### Węzeł `[103]`
Mówca: **Wiktor Smolak (R)**
> ""Just another day at the office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Wiktor Smolak (R): ""Listen, Your Majesty.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, don't keep me in suspense. The anticipation is absolutely killing me!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "There was a noticeable pause before he took another drag...."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "There was a noticeable pause before he took another drag. I suspected my sarcasm might have missed its mark."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Wiktor Smolak (R): ""How is your little war going?""*)

### Węzeł `[106]`
Mówca: **Wiktor Smolak (R)**
> ""The unmatched glory that is the army of the Republic of Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: ""What exactly is this glorious army doing?""*)
  - -> `[39]` (*Player_Romus: ""And then?""*)
  - -> `[38]` (*Player_Romus: ""If I didn't know any better, I'd interpret that as a vei..."*)
  - -> `[40]` (*Player_Romus: ""Are you out of your mind?""*)

### Węzeł `[107]`
Mówca: **Wiktor Smolak (R)**
> ""Suddenly, just as its fading light teeters over the horizon, you spot a glimmer of gold amidst the shadows--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Wiktor Smolak (R): ""The unmatched glory that is the army of the Republic of ..."*)

### Węzeł `[108]`
Mówca: **Wiktor Smolak (R)**
> ""As you're undoubtedly aware, Wehzek troops boast a legendary reputation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "He took another drag."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "On the one hand, accepting Wehlen's aid could tip the scales in our favor, but aligning with the likes of Wikor Smolak could leave us indebted to him indefinitely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Not to mention, risk tarnishing our reputation with our i..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "On the other hand, if Smolak's intentions were true, a decisive victory over Pales could be within our grasp."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Wiktor Smolak (R): ""So what do you think? Do we have a deal?""*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Not to mention, risk tarnishing our reputation with our international partners, especially if we were to lose the war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "On the other hand, if Smolak's intentions were true, a de..."*)

### Węzeł `[112]`
Mówca: **Wiktor Smolak (R)**
> ""I understand the importance of trust and honoring one's commitments -- especially to a soon-to-be brother in arms!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "I could picture his wide grin in my head."*)

### Węzeł `[113]`
Mówca: **Wiktor Smolak (R)**
> ""Just think... this one phone call will inevitably change the course of history. No doubt about it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Wiktor Smolak (R): ""I wish you a good evening, Your Majesty.""*)

### Węzeł `[114]`
Mówca: **Wiktor Smolak (R)**
> ""Well, I've had some pretty wild dreams, but I'll trust you on this one!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "He hung up."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A military alliance with Wiktor Smolak... what have I gotten myself into... ""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "I muttered the words to no one before submerging myself i..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales is within my grasp. I can feel it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "I muttered the words to no one before submerging myself i..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've almost finished what my father started. "The Rizian flag *will* fly over Pales once more.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true`
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "I muttered the words to no one before submerging myself i..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "As I set my phone down, I reflected on what just transpired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus: ""Pales is within my grasp. I can feel it.""*)
  - -> `[115]` (*Player_Romus: ""A military alliance with Wiktor Smolak... what have I go..."*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_HonorDadPales == true"*)
  - -> `[205]` (*Player_Romus: ""Excuse me?! Why is my Romultini glass empty?""*)

### Węzeł `[119]`
Mówca: **Narrator**
> "He hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "As I set my phone down, I reflected on what just transpired."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "I said the words out loud to no one before submerging myself in the pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A military alliance with Wiktor Smolak... I can't believe I even considered it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "I said the words out loud to no one before submerging mys..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales is within my grasp. I can feel it. Not even a two-bit dictator like Wiktor Smolak will make me think otherwise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "I said the words out loud to no one before submerging mys..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "As I set my phone down, I reflected on what just transpired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""Pales is within my grasp. I can feel it. Not even a two-..."*)
  - -> `[121]` (*Player_Romus: ""A military alliance with Wiktor Smolak... I can't believ..."*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_HonorDadPales == true"*)
  - -> `[205]` (*Player_Romus: ""Excuse me?! Why is my Romultini glass empty?""*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "Screw Smolak... I will finish what my father started. The Rizian flag *will* fly over Pales and Zille, once more.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true`
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "I said the words out loud to no one before submerging mys..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_HonorDadPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_HonorDadPales == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_Cemetary_HonorDadPales == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_HonorDadPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: "Screw Smolak... I will finish what my father started. The..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_Cemetary_HonorDadPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player_Romus: ""Screw Smolak... I don't need his help to rectify my fath..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Romus: ""Screw Smolak. I don't need his help. The Rizian flag *wi..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Screw Smolak... I don't need his help to rectify my father's mistakes. The Rizian flag *will* fly over Pales and Zille, once more.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true` AND `(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "I said the words out loud to no one before submerging mys..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Screw Smolak. I don't need his help. The Rizian flag *will* fly over Pales and Zille, once more.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true) == false` AND `(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "I said the words out loud to no one before submerging mys..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_HonorDadPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_HonorDadPales == true"*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_Cemetary_HonorDadPales == true)"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_HonorDadPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""I've almost finished what my father started. "The Rizian..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_Cemetary_HonorDadPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true"*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true)"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""The Rizian flag *will* once again fly over Pales. My fat..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn06_Cemetary_RectifyLegacyPales == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player_Romus: ""The Rizian flag *will* fly over Pales once more.""*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Rizian flag *will* once again fly over Pales. My father's mistakes will no longer haunt this nation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true` AND `(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "I muttered the words to no one before submerging myself i..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Rizian flag *will* fly over Pales once more.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn06_Cemetary_RectifyLegacyPales"] == true) == false` AND `(Variable["RiziaDLC.Turn06_Cemetary_HonorDadPales"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "I muttered the words to no one before submerging myself i..."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "I basked in the serenity, almost able to forget my troubles, when an attendant broke the calm with news of an important phone call, pulling me back to reality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "My masseuse handed me a towel as I got up. Fully adept at..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "When I reached my private oasis -- surrounded by marble columns with an equally impressive view as before -- I descended the steps and immersed myself in the cool water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[143]`
Mówca: **Narrator**
> "I heard him take a puff, likely from a khisha pipe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Wiktor Smolak (R): ""One you might find to be of interest.""*)

### Węzeł `[144]`
Mówca: **Narrator**
> "With the Pales war a constant source of stress, Lucita had urged me to take some time for myself. For her sake, I agreed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "With the Pales war a constant source of stress, Lucita ha..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[148]`
Mówca: **Narrator**
> "With the Pales war a constant source of stress, Pabel had urged me to take some time for myself. For his sake, I agreed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "With the Pales war a constant source of stress, Pabel had..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "With the Pales war a constant source of stress, my mother..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "With the Pales war a constant source of stress, my mother had urged me to take some time for myself. For her sake, I agreed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "I was having a massage and cocktail on the balcony of Pal..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Rumburg_SellPortOfMonqiz"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "I was having a massage and cocktail on the balcony of Pal..."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "I was having a massage and cocktail on the balcony of Palas Toras, high above Monqiz. The sun was setting, its rays shimmering on the water and illuminating the Rizian flags flying over the port."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "I basked in the serenity, almost able to forget my troubl..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == false"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == false)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Wiktor Smolak (R): ""Be glad you're a king and not a poker player. You're blu..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Wiktor Smolak (R): ""Oh, really? Well, that's good. That's good. Yeah.""*)

### Węzeł `[160]`
Mówca: **Wiktor Smolak (R)**
> ""Be glad you're a king and not a poker player. You're bluffing terribly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Wiktor Smolak (R): ""Here's what I think, if I may be so bold...""*)

### Węzeł `[161]`
Mówca: **Wiktor Smolak (R)**
> ""Don't be so rude, Your Majesty. I'm asking as a friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Wiktor Smolak (R): ""Here's what I think, if I may be so bold...""*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After everything I went through to get Zille back? Forget it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[53]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Wiktor Smolak (R): ""And here I thought you were doing all that as a token of..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_NotStoppedByAN == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_NotStoppedByAN == true"*)
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_NotStoppedByAN == true)"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_NotStoppedByAN == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Romus: ""I see through your desperation. You're making this offer..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_NotStoppedByAN == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see through your desperation. You're making this offer because you're going to lose the referendum.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true`
- **Kontekst wejściowy (poprzednik):** `[53]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Wiktor Smolak (R): ""Do you own a crystal ball, Your Majesty? Nothing's decid..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player_Romus: ""After everything I went through to get Zille back? Forge..."*)
  - -> `[170]` (*Player_Romus: ""It's too late for that, Mr. President. Zille is a part o..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's too late for that, Mr. President. Zille is a part of Rizia again.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[53]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Wiktor Smolak (R): ""It's never too late for another agreement, Your Majesty.""*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen here, Smolak. Your puny little troops will only interfere with the unstoppable juggernaut that is the Rizian Armed Forces. Consider your offer declined.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Kontekst wejściowy (poprzednik):** `[53]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "He adopted a wounded tone."*)

### Węzeł `[172]`
Mówca: **Wiktor Smolak (R)**
> ""The only difference is that this time, our ownership of Zille will be permanent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Wiktor Smolak (R): ""But who need dusty old Zille anyway? Not when you've got..."*)

### Węzeł `[173]`
Mówca: **Wiktor Smolak (R)**
> ""But who need dusty old Zille anyway? Not when you've got full control over South Merkopa's largest new natural gas source...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Wiktor Smolak (R): ""That's my price. Accept, and Pales will be yours for the..."*)

### Węzeł `[174]`
Mówca: **Wiktor Smolak (R)**
> ""It's never too late for another agreement, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Wiktor Smolak (R): ""The only difference is that this time, our ownership of ..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming..."*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelmi..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player_Romus: ""Listen here, Smolak. Your puny little troops will only i..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Remaz == true || RiziaDLC.War_Objective_Captured_Solles`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Objective_Captured_Remaz == true || RiziaDLC..."*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Objective_Captured_Remaz == true || RiziaD..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Objective_Captured_Remaz == true || RiziaDLC.War_Objective_Captured_Solles`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Objective_Captured_Remaz"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Solles"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""Have you opened a newspaper lately? We're closing in on ..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Objective_Captured_Remaz == true || RiziaDLC.War_Objective_Captured_Solles)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Objective_Captured_Remaz"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Solles"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you opened a newspaper lately? We're closing in on the Palesian capital. We don't need help from you or anyone else.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Objective_Captured_Remaz"] == true  or  Variable["RiziaDLC.War_Objective_Captured_Solles"]`
- **Kontekst wejściowy (poprzednik):** `[53]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "He adopted a wounded tone."*)

### Węzeł `[182]`
Mówca: **Wiktor Smolak (R)**
> ""And here I thought you were doing all that as a token of friendship. Not because of some dusty old piece of land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Wiktor Smolak (R): ""Think about it, Your Majesty. Who needs Zille when you h..."*)

### Węzeł `[183]`
Mówca: **Wiktor Smolak (R)**
> ""Think about it, Your Majesty. Who needs Zille when you have full control over South Merkopa's largest new natural gas source?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Wiktor Smolak (R): ""That's my price. Accept, and Pales will be yours for the..."*)

### Węzeł `[184]`
Mówca: **Wiktor Smolak (R)**
> ""Do you own a crystal ball, Your Majesty? Nothing's decided until the people cast their vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Wiktor Smolak (R): ""Think about it. Lose both the referendum and the war, an..."*)

### Węzeł `[185]`
Mówca: **Wiktor Smolak (R)**
> ""Think about it. Lose both the referendum and the war, and you'll have lost two regions. Accept this deal, and you're guaranteed to gain one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Wiktor Smolak (R): ""The offer expires the moment I hang up. Thoughts?""*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia calling on the Wehzek army for help? It's been done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Wiktor Smolak (R): ""And it worked, didn't it?""*)

### Węzeł `[187]`
Mówca: **Wiktor Smolak (R)**
> ""And it worked, didn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "I heard a clink as he put the pipe down. His tone shifted..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please elaborate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Wiktor Smolak (R): ""It's simple. After we help you win the war, Rizia and We..."*)

### Węzeł `[189]`
Mówca: **Wiktor Smolak (R)**
> ""It's simple. After we help you win the war, Rizia and Wehlen will sign a land transfer agreement, just like your father did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Wiktor Smolak (R): ""The only difference is that this time, our ownership of ..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what if your troops fail? We'll lose two regions in one go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Wiktor Smolak (R): ""Don't you worry, Your Majesty. If Pales is lost, our agr..."*)

### Węzeł `[191]`
Mówca: **Wiktor Smolak (R)**
> ""Don't you worry, Your Majesty. If Pales is lost, our agreement will be void. Zille will be yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_NotStoppedByAN == true"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_NotStoppedByAN == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_NotStoppedByAN == true"*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_NotStoppedByAN == true)"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_NotStoppedByAN == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Wiktor Smolak (R): ""If you win the referendum. Which is by no means a given.""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_NotStoppedByAN == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Wiktor Smolak (R): ""That's my price. Accept, and Pales will be yours for the..."*)

### Węzeł `[195]`
Mówca: **Wiktor Smolak (R)**
> ""If you win the referendum. Which is by no means a given.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Wiktor Smolak (R): ""That's my price. Accept, and Pales will be yours for the..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see you at the Zille return ceremony.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Wiktor Smolak (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_NotStoppedByAN == true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_NotStoppedByAN == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_NotStoppedByAN == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReferendum_NotStoppedByAN == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_NotStoppedByAN == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Wiktor Smolak (R): ""I wouldn't count on it.""*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReferendum_NotStoppedByAN == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReferendum_NotStoppedByAN"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Wiktor Smolak (R): ""If your war duties don't beckon.""*)

### Węzeł `[200]`
Mówca: **Wiktor Smolak (R)**
> ""I wouldn't count on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He hung up."*)

### Węzeł `[201]`
Mówca: **Wiktor Smolak (R)**
> ""If your war duties don't beckon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He hung up."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "He adopted a wounded tone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Wiktor Smolak (R): ""No need to raise your voice, Your Majesty. It was a frie..."*)

### Węzeł `[203]`
Mówca: **Wiktor Smolak (R)**
> ""No need to raise your voice, Your Majesty. It was a friendly gesture, nothing more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReferendum_SmolakOffer_Rejected = true; Riz..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReferendum_SmolakOffer_Rejected = true; RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferRejected = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.ZilleReferendum_SmolakOffer_Rejected"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_CallWithSmolak_OfferRejected"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Wiktor Smolak (R): ""I wish you a good night, Your Majesty. And good luck in ..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excuse me?! Why is my Romultini glass empty?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator), `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "My attendant ran to refresh my drink as I submerged mysel..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "My attendant ran to refresh my drink as I submerged myself in the pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Losing one territory to regain the other", "Palas Toras", "Monqiz");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Losing one territory to regain the other","Palas Toras","Monqiz");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Won = true; RiziaDLC.War_WehlenJoined ..."*)
