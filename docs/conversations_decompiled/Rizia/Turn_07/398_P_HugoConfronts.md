# Rizia/Turn 7/P_HugoConfronts

- **ID konwersacji:** `398`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/398_P_HugoConfronts.md`
- **Liczba węzłów dialogowych:** 190
- **Liczba wyborów gracza:** 59

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Taddeus`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.Iza_PowerTransfer_Angelica`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Deposed`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn05_MurderInvest_SuspectHugo`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Rico_PoliceChief_PorteDrazon`
- `RiziaDLCSupport.Journal_Floating_Decision_RicoToras_ChiefOfPolice`
- `RiziaDLCSupport.News_Floating_RH_RicoToras_ChiefOfPolice`
- `RiziaDLCSupport.News_Floating_V_RicoToras_ChiefOfPolice`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[14]` | **""Grand Vizier. Thank you for coming.""** | `[10]` **Narrator**: "He bowed in front of me, lower a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Hugo Toras**: ""Romus, my king. May I speak fre..." |
| `[15]` | **""Uncle Hugo. I was expecting you.""** | `[10]` **Narrator**: "He bowed in front of me, lower a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Hugo Toras**: ""Romus, my king. May I speak fre..." |
| `[16]` | **""You can rise, uncle. There is no need for that.""** | `[10]` **Narrator**: "He bowed in front of me, lower a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Hugo Toras**: ""Romus, my king. May I speak fre..." |
| `[17]` | **"Nod."** | `[10]` **Narrator**: "He bowed in front of me, lower a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Hugo Toras**: ""Romus, my king. May I speak fre..." |
| `[19]` | **""You always have, Hugo. Speak your mind.""** | `[18]` **Hugo Toras**: ""Romus, my king. May I speak fre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Hugo Toras**: ""It's about my son..."" |
| `[20]` | **""Please.""** | `[18]` **Hugo Toras**: ""Romus, my king. May I speak fre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Hugo Toras**: ""It's about my son..."" |
| `[21]` | **""I know why you're here. Just be careful about your choice of words.""** | `[18]` **Hugo Toras**: ""Romus, my king. May I speak fre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Hugo Toras**: ""Of course you do. It's about my..." |
| `[22]` | **""If you have to.""** | `[18]` **Hugo Toras**: ""Romus, my king. May I speak fre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Hugo Toras**: ""It's about my son..."" |
| `[28]` | **""It was a decision not made lightly, Uncle. The entire population was demanding hi..."** | `[27]` **Hugo Toras**: ""I understand that he was not po..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "Hugo's expression remained uncha..." |
| `[29]` | **""His actions left me no choice, Uncle. He was endangering the stability of our kin..."** | `[27]` **Hugo Toras**: ""I understand that he was not po..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "Hugo's expression remained uncha..." |
| `[30]` | **""Yet what?""** | `[27]` **Hugo Toras**: ""I understand that he was not po..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Hugo Toras**: ""He is my son, Romus."" |
| `[36]` | **""I value your counsel, Hugo, more than you know. But some decisions must be made s..."** | `[35]` **Narrator**: "His demeanor made me feel uncomf..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Hugo Toras**: ""Indeed, and I wouldn't question..." |
| `[37]` | **""I understand what it looks like, Hugo. But Rico failed at his job. I wouldn't do ..."** | `[35]` **Narrator**: "His demeanor made me feel uncomf..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Hugo Toras**: ""I know... And I wouldn't questi..." |
| `[38]` | **""You were not consulted precisely because of this. He is your son and emotions wou..."** | `[35]` **Narrator**: "His demeanor made me feel uncomf..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Hugo Toras**: ""You are right... I wouldn't que..." |
| `[39]` | **""What's done is done. You should learn to accept it.""** | `[35]` **Narrator**: "His demeanor made me feel uncomf..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Hugo Toras**: ""I accepted it already. I wouldn..." |
| `[46]` | **""I do not doubt your loyalty, nor do I take your sacrifices for granted. Your son'..."** | `[45]` **Hugo Toras**: ""But as a father yourself, you m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Hugo Toras**: ""I do not question your motives,..." |
| `[47]` | **""Your loyalty and service to our family and kingdom have never been in question. I..."** | `[45]` **Hugo Toras**: ""But as a father yourself, you m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Hugo Toras**: ""I appreciate your willingness t..." |
| `[48]` | **""I understand your pain, uncle. But you must let it go.""** | `[45]` **Hugo Toras**: ""But as a father yourself, you m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Hugo Toras**: ""Indeed, I will. But I nonethele..." |
| `[49]` | **""Trust me. Him being the Duke of Iza was more dangerous to his life and our family..."** | `[45]` **Hugo Toras**: ""But as a father yourself, you m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Hugo Toras**: ""I do not question your motives,..." |
| `[50]` | **""Come now, uncle. Rico lost a job which he was unsuited for anyway. He'll survive ..."** | `[45]` **Hugo Toras**: ""But as a father yourself, you m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Hugo Toras**: ""Yes. But I nonetheless believe ..." |
| `[59]` | **""Your feelings are justified, Hugo. In the haste of the moment, I overlooked the p..."** | `[57]` **Hugo Toras**: ""Some form of compensation could..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Hugo Toras**: ""I understand."" |
| `[60]` | **""What amends do you seek? Tell me.""** | `[57]` **Hugo Toras**: ""Some form of compensation could..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Hugo Toras**: ""I'm just asking for something i..." |
| `[61]` | **""I see. You seek a salve for the wound this has caused our lineage.""** | `[57]` **Hugo Toras**: ""Some form of compensation could..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Hugo Toras**: ""Not as a challenge to your auth..." |
| `[62]` | **""No, Uncle. I cannot offer anything. Rico must face the consequences for his actio..."** | `[57]` **Hugo Toras**: ""Some form of compensation could..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "Hugo took a deep breath, his pos..." |
| `[70]` | **""Absolutely not. I am definitely not going to trust Rico with the security of our ..."** | `[69]` **Hugo Toras**: ""How about he works for Duchess ..."<br>`[79]` **Hugo Toras**: ""What about assigning him to ser..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "Hugo took a deep breath, his pos..." |
| `[71]` | **""So he can escalate tensions right at my doorstep as well? No. I'm sorry.""** | `[69]` **Hugo Toras**: ""How about he works for Duchess ..."<br>`[79]` **Hugo Toras**: ""What about assigning him to ser..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "Hugo took a deep breath, his pos..." |
| `[72]` | **""Sure. I can do that. I'll tell Lucita.""** | `[69]` **Hugo Toras**: ""How about he works for Duchess ..." | `Variable["RiziaDLC.Council_Security_Lucita"] == true` | `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] = true;...` | `[89]` **Hugo Toras**: ""Thank you, Romus. I am heartene..." |
| `[81]` | **""Sure. I can do that. I'll tell Titus.""** | `[80]` **Hugo Toras**: ""What about assigning him to ser..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] = true;...` | `[89]` **Hugo Toras**: ""Thank you, Romus. I am heartene..." |
| `[82]` | **""Sure. I can do that. I'll tell General Taddeus.""** | `[79]` **Hugo Toras**: ""What about assigning him to ser..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] = true;...` | `[89]` **Hugo Toras**: ""Thank you, Romus. I am heartene..." |
| `[84]` | **"Shake his hand."** | `[83]` **Narrator**: "He extended his hand to me."<br>`[92]` **Narrator**: "He extended his hand to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Hugo Toras**: ""For the kingdom, and for our fa..." |
| `[85]` | **"Spread your arms."** | `[83]` **Narrator**: "He extended his hand to me."<br>`[92]` **Narrator**: "He extended his hand to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Hugo Toras**: ""For the kingdom, and for our fa..." |
| `[86]` | **""All shall be well, uncle.""** | `[83]` **Narrator**: "He extended his hand to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Hugo Toras**: ""Very well. I shall return to my..." |
| `[93]` | **""I value your fidelity, Hugo. I'm glad we have this mutual understanding.""** | `[92]` **Narrator**: "He extended his hand to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Hugo Toras**: ""For the kingdom, and for our fa..." |
| `[101]` | **""It's okay, Hugo. I understand that it's painful.""** | `[100]` **Hugo Toras**: ""Excuse me, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "Hugo shook his head, his grief e..." |
| `[102]` | **""I know you are angry. But it had to be done.""** | `[100]` **Hugo Toras**: ""Excuse me, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Hugo Toras**: ""Right now, my anger is limited ..." |
| `[103]` | **"Wait for him to continue."** | `[100]` **Hugo Toras**: ""Excuse me, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "Hugo shook his head, his grief e..." |
| `[104]` | **""I also didn't want to believe it. But it's true. I'm sorry.""** | `[100]` **Hugo Toras**: ""Excuse me, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "Hugo shook his head, his grief e..." |
| `[110]` | **""Rico's actions were indeed treachery against Rizia. But the guilt is his to bear,..."** | `[109]` **Hugo Toras**: ""I stand here, not only as your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Hugo Toras**: ""As his father, the onus falls u..." |
| `[111]` | **""It's a tragedy that one of our own was involved. The repercussions have been seve..."** | `[109]` **Hugo Toras**: ""I stand here, not only as your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Hugo Toras**: ""As his father, the onus falls u..." |
| `[112]` | **""You need not ask for forgiveness, Uncle. Rico is already paying for his own actio..."** | `[109]` **Hugo Toras**: ""I stand here, not only as your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Hugo Toras**: ""As his father, the onus falls u..." |
| `[113]` | **""May the Divine forgive you and your son.""** | `[109]` **Hugo Toras**: ""I stand here, not only as your ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[118]` **Hugo Toras**: ""As his father, the onus falls u..." |
| `[117]` | **""Then I accept your apologies and grant you a pardon. You are forgiven.""** | `[120]` **Hugo Toras**: ""For that, I must ask for your p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Hugo Toras**: ""Thank you."" |
| `[119]` | **""I respect that you're taking the responsibility upon yourself, Uncle. But what's ..."** | `[109]` **Hugo Toras**: ""I stand here, not only as your ..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[118]` **Hugo Toras**: ""As his father, the onus falls u..." |
| `[121]` | **""Your integrity and loyalty have never been in question, Hugo. The heart of a fath..."** | `[120]` **Hugo Toras**: ""For that, I must ask for your p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Hugo Toras**: ""You are right..."" |
| `[122]` | **""You cannot blame yourself for this. You couldn't have done anything about it. We ..."** | `[120]` **Hugo Toras**: ""For that, I must ask for your p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Hugo Toras**: ""You are right..."" |
| `[127]` | **""He didn't have any mercy when he orchestrated the bombing that not only took live..."** | `[126]` **Hugo Toras**: ""I understand the need for justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Hugo Toras**: ""I do not ask for exoneration, o..." |
| `[129]` | **""Your feelings are justified, Hugo. But you are being emotional. Rico is now an en..."** | `[126]` **Hugo Toras**: ""I understand the need for justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Hugo Toras**: ""I do not ask for exoneration, o..." |
| `[130]` | **""No, Uncle. I cannot offer anything. Rico must face the consequences for his actio..."** | `[126]` **Hugo Toras**: ""I understand the need for justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Hugo Toras**: ""I do not ask for exoneration, o..." |
| `[131]` | **""I feel your pain, Uncle. But I don't know what I can do about it now. I promise I..."** | `[126]` **Hugo Toras**: ""I understand the need for justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Hugo Toras**: ""I do not ask for exoneration, o..." |
| `[136]` | **""I will consider your request, Hugo.""** | `[134]` **Hugo Toras**: ""Just let him have a chance to a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Hugo Toras**: ""Thank you, Romus..."" |
| `[137]` | **""Of course. I will not do anything that will hurt his dignity further.""** | `[134]` **Hugo Toras**: ""Just let him have a chance to a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Hugo Toras**: ""Thank you, Romus..."" |
| `[138]` | **""I cannot promise that, Uncle. Wehlen demands justice. There is nothing I can do.""** | `[134]` **Hugo Toras**: ""Just let him have a chance to a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Hugo Toras**: ""I understand..."" |
| `[139]` | **""If President Smolak demands him to be sent in exchange for Zille, I'll have to ta..."** | `[134]` **Hugo Toras**: ""Just let him have a chance to a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Hugo Toras**: ""I understand..."" |
| `[148]` | **"Shake his hand."** | `[147]` **Narrator**: "He extended his hand to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Hugo Toras**: ""Thank you, Romus. For hearing m..." |
| `[149]` | **"Spread your arms."** | `[147]` **Narrator**: "He extended his hand to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Hugo Toras**: ""Thank you, Romus. For hearing m..." |
| `[150]` | **""All shall be well, uncle.""** | `[147]` **Narrator**: "He extended his hand to me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Hugo Toras**: ""Thank you, Romus. For hearing m..." |
| `[160]` | **""He was only a temporary steward anyway. The people of Iza were demanding the retu..."** | `[27]` **Hugo Toras**: ""I understand that he was not po..." | `Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true` | *Brak zmian stanu* | `[31]` **Narrator**: "Hugo's expression remained uncha..." |
| `[177]` | **""Wait. My father said Rico was not yet ready to rule... is this something you two ..."** | `[147]` **Narrator**: "He extended his hand to me." | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true` | *Brak zmian stanu* | `[178]` **Narrator**: "His eyes once again turned sorro..." |
| `[184]` | **""Wait. My father had doubts about Rico's readiness to rule... is this something yo..."** | `[83]` **Narrator**: "He extended his hand to me."<br>`[92]` **Narrator**: "He extended his hand to me." | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true` | *Brak zmian stanu* | `[185]` **Narrator**: "His eyes once again turned sorro..." |

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
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "After receiving the news of his son's arrest, Uncle Hugo was on his way to talk to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Thoughts were running through my mind as I paced back and..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "If he were to openly go against me, I'd have a big problem with my entire house. I thought about each scenario in my head and tried to devise a plan."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Iza_PowerTransfer_Angelica == true"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Thoughts were running through my mind as I paced back and forth in my chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "If he were to openly go against me, I'd have a big proble..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Suddenly, there was a knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I granted Hugo permission to enter, and he walked in. He ..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I granted Hugo permission to enter, and he walked in. He seemed more sad than angry -- something that took me off guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "He bowed in front of me, lower and longer than he'd norma..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Your Majesty.""*)

### Węzeł `[10]`
Mówca: **Narrator**
> "He bowed in front of me, lower and longer than he'd normally go for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus_Italic: "Nod."*)
  - -> `[14]` (*Player_Romus: ""Grand Vizier. Thank you for coming.""*)
  - -> `[15]` (*Player_Romus: ""Uncle Hugo. I was expecting you.""*)
  - -> `[16]` (*Player_Romus: ""You can rise, uncle. There is no need for that.""*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Deposed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Deposed == true"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Deposed == true)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Deposed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Deposed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Hugo leaned forward slightly, his hands clasped together,..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Deposed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Deposed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "Hugo leaned forward slightly, his hands clasped together...."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Grand Vizier. Thank you for coming.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""Romus, my king. May I speak freely?""*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Uncle Hugo. I was expecting you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""Romus, my king. May I speak freely?""*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can rise, uncle. There is no need for that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""Romus, my king. May I speak freely?""*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Romus_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""Romus, my king. May I speak freely?""*)

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""Romus, my king. May I speak freely?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""You always have, Hugo. Speak your mind.""*)
  - -> `[20]` (*Player_Romus: ""Please.""*)
  - -> `[21]` (*Player_Romus: ""I know why you're here. Just be careful about your choic..."*)
  - -> `[22]` (*Player_Romus: ""If you have to.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You always have, Hugo. Speak your mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Hugo Toras: ""It's about my son...""*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Hugo Toras: ""It's about my son...""*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know why you're here. Just be careful about your choice of words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Hugo Toras: ""Of course you do. It's about my son...""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you have to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Hugo Toras: ""It's about my son...""*)

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""It's about my son...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Deposed == true"*)

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""Of course you do. It's about my son...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Deposed == true"*)

### Węzeł `[25]`
Mówca: **Hugo Toras**
> ""About your decision to remove him as the Duke of Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""I understand that he was not popular in the city. King V..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Hugo leaned forward slightly, his hands clasped together, choosing his words carefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Hugo Toras: ""About your decision to remove him as the Duke of Iza.""*)

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""I understand that he was not popular in the city. King Valero himself had reservations about his readiness to become Duke. Yet...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Iza_PowerTransfer_Angelica == true"*)
  - -> `[28]` (*Player_Romus: ""It was a decision not made lightly, Uncle. The entire po..."*)
  - -> `[29]` (*Player_Romus: ""His actions left me no choice, Uncle. He was endangering..."*)
  - -> `[30]` (*Player_Romus: ""Yet what?""*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a decision not made lightly, Uncle. The entire population was demanding his removal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Hugo's expression remained unchanged, but there was a fli..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His actions left me no choice, Uncle. He was endangering the stability of our kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Hugo's expression remained unchanged, but there was a fli..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yet what?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Hugo Toras: ""He is my son, Romus.""*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Hugo's expression remained unchanged, but there was a flicker of sadness in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Hugo Toras: ""I understand the weight of the crown and the decisions i..."*)

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""I understand the weight of the crown and the decisions it demands. But he is my son, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Hugo Toras: ""And I... I was not consulted.""*)

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""He is my son, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Hugo Toras: ""And I... I was not consulted.""*)

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""And I... I was not consulted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "His demeanor made me feel uncomfortable. I couldn't meet ..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "His demeanor made me feel uncomfortable. I couldn't meet his gaze. I had to look away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""I value your counsel, Hugo, more than you know. But some..."*)
  - -> `[37]` (*Player_Romus: ""I understand what it looks like, Hugo. But Rico failed a..."*)
  - -> `[38]` (*Player_Romus: ""You were not consulted precisely because of this. He is ..."*)
  - -> `[39]` (*Player_Romus: ""What's done is done. You should learn to accept it.""*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I value your counsel, Hugo, more than you know. But some decisions must be made swiftly, to protect the realm.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Hugo Toras: ""Indeed, and I wouldn't question your judgment.""*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand what it looks like, Hugo. But Rico failed at his job. I wouldn't do anything to hurt House Toras.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Hugo Toras: ""I know... And I wouldn't question your judgment.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were not consulted precisely because of this. He is your son and emotions would have risen just like they're doing right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""You are right... I wouldn't question your judgment.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's done is done. You should learn to accept it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Hugo Toras: ""I accepted it already. I wouldn't question your judgment.""*)

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""You are right... I wouldn't question your judgment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""I have served this family and this kingdom all my life, ..."*)

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""I accepted it already. I wouldn't question your judgment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""I have served this family and this kingdom all my life, ..."*)

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""I have served this family and this kingdom all my life, Romus. My loyalty has never wavered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Hugo Toras: ""But as a father yourself, you must understand.""*)

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""Indeed, and I wouldn't question your judgment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""I have served this family and this kingdom all my life, ..."*)

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""I know... And I wouldn't question your judgment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""I have served this family and this kingdom all my life, ..."*)

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""But as a father yourself, you must understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""I do not doubt your loyalty, nor do I take your sacrific..."*)
  - -> `[47]` (*Player_Romus: ""Your loyalty and service to our family and kingdom have ..."*)
  - -> `[48]` (*Player_Romus: ""I understand your pain, uncle. But you must let it go.""*)
  - -> `[49]` (*Player_Romus: ""Trust me. Him being the Duke of Iza was more dangerous t..."*)
  - -> `[50]` (*Player_Romus: ""Come now, uncle. Rico lost a job which he was unsuited f..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not doubt your loyalty, nor do I take your sacrifices for granted. Your son's removal was not a punishment but a necessity. For him, for you, for all of us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""I do not question your motives, Romus. But I nonetheless..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your loyalty and service to our family and kingdom have never been in question. I am open to discussing how we might address this situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""I appreciate your willingness to consider a path to rede..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your pain, uncle. But you must let it go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Hugo Toras: ""Indeed, I will. But I nonetheless believe I was owed a c..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me. Him being the Duke of Iza was more dangerous to his life and our family's reputation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""I do not question your motives, Romus. But I nonetheless..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come now, uncle. Rico lost a job which he was unsuited for anyway. He'll survive this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Hugo Toras: ""Yes. But I nonetheless believe I was owed a consultation.""*)

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""I appreciate your willingness to consider a path to redemption for my son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""The loss of his position has... repercussions. For his f..."*)

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""I do not question your motives, Romus. But I nonetheless believe I was owed a consultation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""The loss of his position has... repercussions. For his f..."*)

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""However, the loss of his position has... repercussions. For his future and for the name of our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""Some form of compensation could ease this transition.""*)

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""Indeed, I will. But I nonetheless believe I was owed a consultation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""However, the loss of his position has... repercussions. ..."*)

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""Yes. But I nonetheless believe I was owed a consultation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Hugo Toras: ""And the loss of his position has... repercussions. For h..."*)

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""And the loss of his position has... repercussions. For his future and for the name of our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""Some form of compensation could ease this transition.""*)

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Some form of compensation could ease this transition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""What amends do you seek? Tell me.""*)
  - -> `[59]` (*Player_Romus: ""Your feelings are justified, Hugo. In the haste of the m..."*)
  - -> `[61]` (*Player_Romus: ""I see. You seek a salve for the wound this has caused ou..."*)
  - -> `[62]` (*Player_Romus: ""No, Uncle. I cannot offer anything. Rico must face the c..."*)

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""The loss of his position has... repercussions. For his future and for the name of our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""Some form of compensation could ease this transition.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your feelings are justified, Hugo. In the haste of the moment, I overlooked the personal ramifications. For that, I offer my regret. But that's all I can offer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Hugo Toras: ""I understand.""*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What amends do you seek? Tell me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""I'm just asking for something in return. A role, an esta..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. You seek a salve for the wound this has caused our lineage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""Not as a challenge to your authority, but as a balm for ..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Uncle. I cannot offer anything. Rico must face the consequences for his actions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Hugo took a deep breath, his posture relaxing ever so sli..."*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""Not as a challenge to your authority, but as a balm for our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""I'm just asking for something in return. A role, an esta..."*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""I'm just asking for something in return. A role, an estate, something to maintain the dignity of my son and provide a path forward for him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""I understand you cannot offer him a title right after re..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Hugo took a deep breath, his posture relaxing ever so slightly, yet there was an underlying current of disappointment in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Hugo Toras: ""Then I shall stand by your decision, as I have always st..."*)

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""Then I shall stand by your decision, as I have always stood by you and your father before you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""My loyalty to the crown and to you remains unshaken. You..."*)

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""My loyalty to the crown and to you remains unshaken. You are my monarch, and my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "He extended his hand to me."*)

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""I understand you cannot offer him a title right after revoking it. But please consider offering him a job in the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""How about he works for Duchess Azaro? As Chief of the Porte Drazon Police Department?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus: ""So he can escalate tensions right at my doorstep as well..."*)
  - -> `[70]` (*Player_Romus: ""Absolutely not. I am definitely not going to trust Rico ..."*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. I am definitely not going to trust Rico with the security of our capital.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Hugo Toras), `[79]` (Hugo Toras), `[80]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Hugo took a deep breath, his posture relaxing ever so sli..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So he can escalate tensions right at my doorstep as well? No. I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Hugo Toras), `[79]` (Hugo Toras), `[80]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Hugo took a deep breath, his posture relaxing ever so sli..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure. I can do that. I'll tell Lucita.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Kontekst wejściowy (poprzednik):** `[69]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_PoliceChief_PorteDrazon = true; RiziaDLCSup..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Taddeus == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Taddeus == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Taddeus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Hugo Toras: ""What about assigning him to serve under General Azaro? A..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Taddeus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Hugo Toras: ""What about assigning him to serve under Captain Gordion?..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""How about he works for Duchess Azaro? As Chief of the Po..."*)

### Węzeł `[79]`
Mówca: **Hugo Toras**
> ""What about assigning him to serve under General Azaro? As Chief of the Porte Drazon Police Department?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus: ""So he can escalate tensions right at my doorstep as well..."*)
  - -> `[70]` (*Player_Romus: ""Absolutely not. I am definitely not going to trust Rico ..."*)
  - -> `[82]` (*Player_Romus: ""Sure. I can do that. I'll tell General Taddeus.""*)

### Węzeł `[80]`
Mówca: **Hugo Toras**
> ""What about assigning him to serve under Captain Gordion? As Chief of the Porte Drazon Police Department?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player_Romus: ""So he can escalate tensions right at my doorstep as well..."*)
  - -> `[70]` (*Player_Romus: ""Absolutely not. I am definitely not going to trust Rico ..."*)
  - -> `[81]` (*Player_Romus: ""Sure. I can do that. I'll tell Titus.""*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure. I can do that. I'll tell Titus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_PoliceChief_PorteDrazon = true; RiziaDLCSup..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure. I can do that. I'll tell General Taddeus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_PoliceChief_PorteDrazon = true; RiziaDLCSup..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "He extended his hand to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus_Italic: "Shake his hand."*)
  - -> `[85]` (*Player_Romus_Italic: "Spread your arms."*)
  - -> `[86]` (*Player_Romus: ""All shall be well, uncle.""*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo == true"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "We shook hands. Hugo looked at our hands for a moment before placing his own atop mine."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator), `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Hugo Toras: ""For the kingdom, and for our family.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "Spread your arms."]** — Mówca: **Player_Romus_Italic**
> "I spread my arms and we hugged."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator), `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Hugo Toras: ""For the kingdom, and for our family.""*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All shall be well, uncle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Hugo Toras: ""Very well. I shall return to my duties now.""*)

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""For the kingdom, and for our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "As Hugo exited, I was left to ponder the intricate balanc..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_PoliceChief_PorteDrazon = true;
RiziaDLCSupport.News_Floating_RH_RicoToras_ChiefOfPolice = true;
RiziaDLCSupport.News_Floating_V_RicoToras_ChiefOfPolice = true;
RiziaDLCSupport.Journal_Floating_Decision_RicoToras_ChiefOfPolice = true;
EnableCodexEntry("Characters_Family_RicoToras_ChiefOfPolice");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] = true;
Variable["RiziaDLCSupport.News_Floating_RH_RicoToras_ChiefOfPolice"] = true;
Variable["RiziaDLCSupport.News_Floating_V_RicoToras_ChiefOfPolice"] = true;
Variable["RiziaDLCSupport.Journal_Floating_Decision_RicoToras_ChiefOfPolice"] = true;
EnableCodexEntry("Characters_Family_RicoToras_ChiefOfPolice");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Hugo Toras: ""Thank you, Romus. I am heartened by your understanding.""*)

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""Thank you, Romus. I am heartened by your understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Hugo's expression softened slightly, a sign of relief mix..."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Hugo's expression softened slightly, a sign of relief mixed with the residual weight of the situation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Hugo Toras: ""My son’s actions notwithstanding, I believe in his capac..."*)

### Węzeł `[91]`
Mówca: **Hugo Toras**
> ""My son’s actions notwithstanding, I believe in his capacity for growth and redemption. I am committed to guiding him on this path, for the sake of our family and Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Narrator: "He extended his hand to me."*)

### Węzeł `[92]`
Mówca: **Narrator**
> "He extended his hand to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player_Romus: ""I value your fidelity, Hugo. I'm glad we have this mutua..."*)
  - -> `[84]` (*Player_Romus_Italic: "Shake his hand."*)
  - -> `[85]` (*Player_Romus_Italic: "Spread your arms."*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo == true"*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I value your fidelity, Hugo. I'm glad we have this mutual understanding.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Hugo Toras: ""For the kingdom, and for our family.""*)

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""Very well. I shall return to my duties now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "As Hugo exited, I was left to ponder the intricate balanc..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "As Hugo exited, I was left to ponder the intricate balance of ruling, where the lines between kinship and kingship blurred."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "I stood up and prepared for my next meeting."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "I stood up and prepared for my next meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[97]`
Mówca: **Narrator**
> "Hugo leaned forward slightly, his hands clasped together. His voice trembled with emotion when he spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Hugo Toras: ""Romus, how could this have happened? My son, Rico, invol..."*)

### Węzeł `[98]`
Mówca: **Hugo Toras**
> ""Romus, how could this have happened? My son, Rico, involved in the Zille bombing? Treason against his own country?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "Realizing he was losing the volume of his voice, he stopp..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "Realizing he was losing the volume of his voice, he stopped himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Hugo Toras: ""Excuse me, Your Majesty.""*)

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""Excuse me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""I also didn't want to believe it. But it's true. I'm sor..."*)
  - -> `[101]` (*Player_Romus: ""It's okay, Hugo. I understand that it's painful.""*)
  - -> `[102]` (*Player_Romus: ""I know you are angry. But it had to be done.""*)
  - -> `[103]` (*Player_Romus_Italic: "Wait for him to continue."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's okay, Hugo. I understand that it's painful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Hugo shook his head, his grief etched deep into the lines..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know you are angry. But it had to be done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Hugo Toras: ""Right now, my anger is limited to Rico.""*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "Wait for him to continue."]** — Mówca: **Player_Romus_Italic**
> "I waited for him to recollect himself."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Hugo shook his head, his grief etched deep into the lines..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I also didn't want to believe it. But it's true. I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Hugo shook his head, his grief etched deep into the lines..."*)

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""Romus, I come before you in the deepest humility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Hugo Toras: ""The actions of my son... I cannot fathom what led Rico t..."*)

### Węzeł `[106]`
Mówca: **Hugo Toras**
> ""Right now, my anger is limited to Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Hugo shook his head, his grief etched deep into the lines..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Hugo shook his head, his grief etched deep into the lines of his face. I hadn't seen him this sad since my father's funeral."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Hugo Toras: ""Romus, I come before you in the deepest humility.""*)

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""The actions of my son... I cannot fathom what led Rico to such darkness. The bombing, the scandal over Zille's return... It's a stain upon our House.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Hugo Toras: ""Your father -- my brother -- told me that Ricardus becam..."*)

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""I stand here, not only as your Grand Vizier but as a father disgraced, to beg your forgiveness for the turmoil he has wrought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""Rico's actions were indeed treachery against Rizia. But ..."*)
  - -> `[111]` (*Player_Romus: ""It's a tragedy that one of our own was involved. The rep..."*)
  - -> `[112]` (*Player_Romus: ""You need not ask for forgiveness, Uncle. Rico is already..."*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rico's actions were indeed treachery against Rizia. But the guilt is his to bear, not yours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Hugo Toras: ""As his father, the onus falls upon me. I failed in guidi..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a tragedy that one of our own was involved. The repercussions have been severe, and we all must bear a responsibility for letting this take place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Hugo Toras: ""As his father, the onus falls upon me. I failed in guidi..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You need not ask for forgiveness, Uncle. Rico is already paying for his own actions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Hugo Toras: ""As his father, the onus falls upon me. I failed in guidi..."*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the Divine forgive you and your son.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[109]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Hugo Toras: ""As his father, the onus falls upon me. I failed in guidi..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""May the Divine forgive you and your son.""*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus: ""I respect that you're taking the responsibility upon you..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I accept your apologies and grant you a pardon. You are forgiven.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Hugo Toras: ""Thank you.""*)

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""As his father, the onus falls upon me. I failed in guiding him, in instilling the values of our lineage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Hugo Toras: ""For that, I must ask for your pardon, for my oversight, ..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respect that you're taking the responsibility upon yourself, Uncle. But what's done is already done, and you are not to blame.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[109]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Hugo Toras: ""As his father, the onus falls upon me. I failed in guidi..."*)

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""For that, I must ask for your pardon, for my oversight, for any taint his actions have brought upon your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""Then I accept your apologies and grant you a pardon. You..."*)
  - -> `[121]` (*Player_Romus: ""Your integrity and loyalty have never been in question, ..."*)
  - -> `[122]` (*Player_Romus: ""You cannot blame yourself for this. You couldn't have do..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your integrity and loyalty have never been in question, Hugo. The heart of a father cannot always steer the will of a son.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Hugo Toras: ""You are right...""*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot blame yourself for this. You couldn't have done anything about it. We must now look to the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Hugo Toras: ""You are right...""*)

### Węzeł `[123]`
Mówca: **Hugo Toras**
> ""You are right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Hugo Toras: ""But... He is still my son, Romus.""*)

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Hugo Toras: ""But... He is still my son, Romus.""*)

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""But... He is still my son, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Hugo Toras: ""I understand the need for justice but is there no room f..."*)

### Węzeł `[126]`
Mówca: **Hugo Toras**
> ""I understand the need for justice but is there no room for mercy for him? For a chance at redemption?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Romus: ""He didn't have any mercy when he orchestrated the bombin..."*)
  - -> `[129]` (*Player_Romus: ""Your feelings are justified, Hugo. But you are being emo..."*)
  - -> `[131]` (*Player_Romus: ""I feel your pain, Uncle. But I don't know what I can do ..."*)
  - -> `[130]` (*Player_Romus: ""No, Uncle. I cannot offer anything. Rico must face the c..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He didn't have any mercy when he orchestrated the bombing that not only took lives but also our land. I'm sorry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""I do not ask for exoneration, only that his life be spar..."*)

### Węzeł `[128]`
Mówca: **Hugo Toras**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Hugo took a deep breath, his posture relaxing ever so sli..."*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your feelings are justified, Hugo. But you are being emotional. Rico is now an enemy of the state. I offer my regret. But that's all I can offer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""I do not ask for exoneration, only that his life be spar..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Uncle. I cannot offer anything. Rico must face the consequences for his actions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""I do not ask for exoneration, only that his life be spar..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I feel your pain, Uncle. But I don't know what I can do about it now. I promise I'll try my best to mend our wounds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Hugo Toras: ""I do not ask for exoneration, only that his life be spar..."*)

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""I do not ask for exoneration, only that his life be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Hugo Toras: ""Let him live, even if in exile or imprisonment and don't..."*)

### Węzeł `[133]`
Mówca: **Hugo Toras**
> ""Let him live, even if in exile or imprisonment and don't send him to Wehlen. God knows what they'll do to him there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "He lowered his head, hands still clasped. The plea was ev..."*)

### Węzeł `[134]`
Mówca: **Hugo Toras**
> ""Just let him have a chance to atone, in whatever way remains to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""I will consider your request, Hugo.""*)
  - -> `[137]` (*Player_Romus: ""Of course. I will not do anything that will hurt his dig..."*)
  - -> `[138]` (*Player_Romus: ""I cannot promise that, Uncle. Wehlen demands justice. Th..."*)
  - -> `[139]` (*Player_Romus: ""If President Smolak demands him to be sent in exchange f..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "He lowered his head, hands still clasped. The plea was evident in his voice and posture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Hugo Toras: ""Just let him have a chance to atone, in whatever way rem..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will consider your request, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Hugo Toras: ""Thank you, Romus...""*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. I will not do anything that will hurt his dignity further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Hugo Toras: ""Thank you, Romus...""*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot promise that, Uncle. Wehlen demands justice. There is nothing I can do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Hugo Toras: ""I understand...""*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If President Smolak demands him to be sent in exchange for Zille, I'll have to take it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Hugo Toras: ""I understand...""*)

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""I understand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "Hugo took a deep sigh."*)

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""But should such a black mark be placed on my family, I am not sure I will be able to serve you in the same capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "He bowed."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "Hugo took a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Hugo Toras: ""But should such a black mark be placed on my family, I a..."*)

### Węzeł `[143]`
Mówca: **Hugo Toras**
> ""Thank you, Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Hugo Toras: ""I appreciate your willingness to consider a path to rede..."*)

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""I will trust your wisdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "He extended his hand to me."*)

### Węzeł `[145]`
Mówca: **Hugo Toras**
> ""I appreciate your willingness to consider a path to redemption for my son. I am humbled before you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "He bowed."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "He bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Hugo Toras: ""I will trust your wisdom.""*)

### Węzeł `[147]`
Mówca: **Narrator**
> "He extended his hand to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus_Italic: "Shake his hand."*)
  - -> `[149]` (*Player_Romus_Italic: "Spread your arms."*)
  - -> `[150]` (*Player_Romus: ""All shall be well, uncle.""*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo == true"*)

### Węzeł `[148]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "We shook hands. Hugo looked at our hands for a moment before placing his own atop mine."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Hugo Toras: ""Thank you, Romus. For hearing my plea.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "Spread your arms."]** — Mówca: **Player_Romus_Italic**
> "I spread my arms and we hugged."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Hugo Toras: ""Thank you, Romus. For hearing my plea.""*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All shall be well, uncle.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Hugo Toras: ""Thank you, Romus. For hearing my plea.""*)

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""I'll see you later. I shall return to my duties now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "As Hugo exited, I was left to ponder the intricate balanc..."*)

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""Thank you, Romus. For hearing my plea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Hugo Toras: ""I'll see you later. I shall return to my duties now.""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Arrested == true)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");"*)

### Węzeł `[156]`
Mówca: **Narrator**
> "After receiving the news that I had deposed his son, Uncle Hugo was on his way to talk to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Thoughts were running through my mind as I paced back and..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Iza_PowerTransfer_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Iza_PowerTransfer_Angelica == true"*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Iza_PowerTransfer_Angelica == true)"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Iza_PowerTransfer_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player_Romus: ""He was only a temporary steward anyway. The people of Iz..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Iza_PowerTransfer_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He was only a temporary steward anyway. The people of Iza were demanding the return of their Duchess.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true`
- **Kontekst wejściowy (poprzednik):** `[27]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Hugo's expression remained unchanged, but there was a fli..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""Sure. I can do that. I'll tell Lucita.""*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[165]`
Mówca: **Narrator**
> "I looked at the oversized key on my desk. A symbolic Key to Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "The Sazons had sent it as a token of gratitude for reinst..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Iza_PowerTransfer_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Iza_PowerTransfer_Angelica == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Iza_PowerTransfer_Angelica == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Iza_PowerTransfer_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I looked at the oversized key on my desk. A symbolic Key ..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Iza_PowerTransfer_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Suddenly, there was a knock on the door."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "The Sazons had sent it as a token of gratitude for reinstating their Duchess."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_IzaKey");"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_IzaKey");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_IzaKey");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Suddenly, there was a knock on the door."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "After receiving the news of his son's arrest, Uncle Hugo ..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "After receiving the news that I had deposed his son, Uncl..."*)

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""Your father -- my brother -- told me that Ricardus became Duke of Iza before he was ready. I see now that he was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""I stand here, not only as your Grand Vizier but as a fat..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectHugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectHugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player_Romus: ""Wait. My father said Rico was not yet ready to rule... i..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. My father said Rico was not yet ready to rule... is this something you two often argued over?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[147]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "His eyes once again turned sorrowful."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "His eyes once again turned sorrowful."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Hugo Toras: ""We quarreled about it on the very night King Valero pass..."*)

### Węzeł `[179]`
Mówca: **Hugo Toras**
> ""We quarreled about it on the very night King Valero passed, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Hugo Toras: ""Had I known it would be our last conversation -- and had..."*)

### Węzeł `[180]`
Mówca: **Hugo Toras**
> ""Had I known it would be our last conversation -- and had I known what Ricardus was capable of -- I would never have raised my voice to my brother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Hugo Toras: ""Now he's gone... I can't lose my son, too.""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectHugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectHugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player_Romus: ""Wait. My father had doubts about Rico's readiness to rul..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. My father had doubts about Rico's readiness to rule... is this something you two often argued over?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator), `[92]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "His eyes once again turned sorrowful."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "His eyes once again turned sorrowful."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Hugo Toras: ""We quarreled about it on the very night King Valero pass..."*)

### Węzeł `[186]`
Mówca: **Hugo Toras**
> ""We quarreled about it on the very night King Valero passed, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Hugo Toras: ""Had I known it would be our last conversation, I would n..."*)

### Węzeł `[187]`
Mówca: **Hugo Toras**
> ""Had I known it would be our last conversation, I would never have raised my voice to my brother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Hugo Toras: ""Now he's gone... I can't lose my son, too.""*)

### Węzeł `[188]`
Mówca: **Hugo Toras**
> ""Now he's gone... I can't lose my son, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "As Hugo exited, I was left to ponder the intricate balanc..."*)

### Węzeł `[189]`
Mówca: **Hugo Toras**
> ""Now he's gone... I can't lose my son, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Hugo Toras: ""Thank you, Romus. For hearing my plea.""*)
