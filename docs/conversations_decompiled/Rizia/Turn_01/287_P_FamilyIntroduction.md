# Rizia/Turn 1/P_FamilyIntroduction

- **ID konwersacji:** `287`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/287_P_FamilyIntroduction.md`
- **Liczba węzłów dialogowych:** 413
- **Liczba wyborów gracza:** 113

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[79]** Vina Toras
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Coronation_GaveSpeech`
- `RiziaDLC.Prologue_DadLetter`
- `RiziaDLC.Prologue_DistantAsDad`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_Relations_PabelBoss`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Prologue_Studied`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_YourMajesty`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLCSupport.Journal_Turn01_VinaOffCouncil`
- `RiziaDLCSupport.Journal_Turn01_VinaOnCouncil`
- `RiziaDLCSupport.News_Turn01_RH_ClashesIza`
- `RiziaDLCSupport.Reports_Turn01_PorteDrazon_DelegateAllegiance`
- `RiziaDLCSupport.Reports_Turn01_Qalus_WineHarvest`
- `RiziaDLCSupport.Reports_Turn01_Valenqir_TorasTruthers`
- `RiziaDLCText.PabelToPlayer`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Yes?""** | `[76]` **Narrator**: "The knocking on the door continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "The door swung open. Pabel walke..."<br>`[11]` **Narrator**: "The door opened, and Pabel grace..." |
| `[5]` | **""Who is it?""** | `[76]` **Narrator**: "The knocking on the door continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "The door swung open. Pabel walke..."<br>`[11]` **Narrator**: "The door opened, and Pabel grace..." |
| `[6]` | **""Go away. I'm sleeping.""** | `[76]` **Narrator**: "The knocking on the door continued." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "The door swung open. Pabel walke..."<br>`[11]` **Narrator**: "The door opened, and Pabel grace..." |
| `[13]` | **""What nerve. Barge in on the King again like that, and I'll have your head.""** | `[7]` **Pabel Adria**: ""Rise and shine, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "The corner of Pabel's mouth twit..." |
| `[14]` | **""It's nice to see a familiar face.""** | `[12]` **Pabel Adria**: ""You said you wanted to be woken..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Narrator**: "Pabel's expression didn't change."<br>`[211]` **Narrator**: "Pabel smiled." |
| `[15]` | **""Yes, I did. It's best to get a head start while the day's still young.""** | `[12]` **Pabel Adria**: ""You said you wanted to be woken..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "Pabel nodded."<br>`[267]` **Narrator**: "Pabel smiled." |
| `[16]` | **""It's good to see you, Pabel.""** | `[7]` **Pabel Adria**: ""Rise and shine, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Pabel Adria**: ""You, too."" |
| `[17]` | **""I knew this day would come, but it still feels odd having you wait on me.""** | `[7]` **Pabel Adria**: ""Rise and shine, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Narrator**: "Pabel chuckled." |
| `[18]` | **""Where's my newspaper?""** | `[7]` **Pabel Adria**: ""Rise and shine, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "Pabel blinked. He responded calmly." |
| `[19]` | **""Where's my breakfast?""** | `[12]` **Pabel Adria**: ""You said you wanted to be woken..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "Pabel leveled his gaze at me, hi..." |
| `[20]` | **""What nerve. Barge in on me again like that, and I'll have your head.""** | `[12]` **Pabel Adria**: ""You said you wanted to be woken..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "Pabel leveled his gaze at me, hi..." |
| `[26]` | **""Sorry, I couldn't resist. How are you, Pabel?""** | `[214]` **Pabel Adria**: ""Certainly, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Narrator**: "He let out a sigh of relief." |
| `[27]` | **""I mean it.""** | `[214]` **Pabel Adria**: ""Certainly, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "Pabel paused for a second, then ..." |
| `[35]` | **""No, no, I was joking. How are you, Pabel?""** | `[23]` **Pabel Adria**: ""I wasn't informed you wanted on..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Narrator**: "He let out a sigh of relief." |
| `[36]` | **""Good. See that you do.""** | `[23]` **Pabel Adria**: ""I wasn't informed you wanted on..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC...` | `[241]` **Narrator**: "He gave a brusque nod and drew b..." |
| `[39]` | **""Really? That's all you're eating?""** | `[38]` **Narrator**: "My mother was already sitting at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Estela Toras**: ""How do you think I stay this tr..." |
| `[40]` | **""Good morning, Mother.""** | `[38]` **Narrator**: "My mother was already sitting at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Estela Toras**: ""Same to you, darling."" |
| `[41]` | **""You're supposed to rise when the King enters the room.""** | `[38]` **Narrator**: "My mother was already sitting at..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Estela Toras**: ""I gave birth to you, darling, I..." |
| `[47]` | **""Who cares what they write?""** | `[46]` **Estela Toras**: ""That was one cheeky speech you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Estela Toras**: ""They're all rags, anyway."" |
| `[51]` | **""Forget the papers. Did you see the look on Hugo's face?""** | `[46]` **Estela Toras**: ""That was one cheeky speech you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Estela Toras**: ""How could I have missed it?"" |
| `[52]` | **""I meant every word of it.""** | `[46]` **Estela Toras**: ""That was one cheeky speech you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Estela Toras**: ""I'm very sure that you did."" |
| `[60]` | **""What can I say? My people love me.""** | `[53]` **Estela Toras**: ""I hope you're satisfied with ye..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Estela Toras**: ""They love to be seen on televis..." |
| `[61]` | **""That was mostly your fault.""** | `[53]` **Estela Toras**: ""I hope you're satisfied with ye..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Estela Toras**: ""Yes, better a dead wife than a ..." |
| `[62]` | **""That was his fault.""** | `[53]` **Estela Toras**: ""I hope you're satisfied with ye..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Estela Toras**: ""Don't speak ill of the dead. On..." |
| `[69]` | **""That's nonsense. Vina, eat as much as you want.""** | `[97]` **Estela Toras**: ""Not too many of those. The swee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "Vina took a bite of a rizetta an..." |
| `[70]` | **""Absolutely. If you eat this much every morning, you'll never get married.""** | `[97]` **Estela Toras**: ""Not too many of those. The swee..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[73]` **Narrator**: "Vina's smile vanished. She took ..." |
| `[71]` | **""Whatever you say, Mother.""** | `[97]` **Estela Toras**: ""Not too many of those. The swee..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[73]` **Narrator**: "Vina's smile vanished. She took ..." |
| `[81]` | **""That's only because of the TV cameras.""** | `[53]` **Estela Toras**: ""I hope you're satisfied with ye..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Estela Toras**: ""Oh, don't sell yourself short."" |
| `[88]` | **""I'd rather keep that private.""** | `[83]` **Estela Toras**: ""What was in that letter he wrot..."<br>`[87]` **Estela Toras**: ""What did he say to you before h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Estela Toras**: ""I hope it was an apology. He wa..."<br>`[376]` **Estela Toras**: ""You boys did always have your s..." |
| `[89]` | **""He said not to make the same mistakes he did.""** | `[83]` **Estela Toras**: ""What was in that letter he wrot..."<br>`[87]` **Estela Toras**: ""What did he say to you before h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Estela Toras**: ""He must've been talking about Z..." |
| `[90]` | **""He told me to take back the lands that were lost.""** | `[83]` **Estela Toras**: ""What was in that letter he wrot..."<br>`[87]` **Estela Toras**: ""What did he say to you before h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Estela Toras**: ""Zille and Pales, I suppose. He ..." |
| `[98]` | **""It's a special occasion. Our diet can start tomorrow.""** | `[97]` **Estela Toras**: ""Not too many of those. The swee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "Vina took a bite of a rizetta an..." |
| `[100]` | **""That old? How time flies.""** | `[99]` **Vina Toras**: ""You know that I'm 18 now."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Vina Toras**: ""That was supposed to be a joke,..."<br>`[185]` **Vina Toras**: ""Right. Silly of me to think you..." |
| `[101]` | **""I know. We're already behind on finding you a husband.""** | `[99]` **Vina Toras**: ""You know that I'm 18 now."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Vina Toras**: ""Ugh, that's not what I meant."" |
| `[102]` | **""I know. You've got to start thinking about where to study.""** | `[99]` **Vina Toras**: ""You know that I'm 18 now."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Vina Toras**: ""That's not quite what I had in ..." |
| `[103]` | **""Yes, it's time you started taking on more responsibilities.""** | `[99]` **Vina Toras**: ""You know that I'm 18 now."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Vina Toras**: ""Exactly!"" |
| `[109]` | **""No, getting an education was far more important to me.""** | `[196]` **Vina Toras**: ""It's unusual for a female heir ..." | `Variable["RiziaDLC.Prologue_Studied"]` | *Brak zmian stanu* | `[121]` **Vina Toras**: ""Well, this is what's important ..." |
| `[116]` | **""No, learning how to fight for my country was far more important to me.""** | `[196]` **Vina Toras**: ""It's unusual for a female heir ..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"]`<br>`(Variable["RiziaDLC.Prologue_Studied"]) == false` | *Brak zmian stanu* | `[121]` **Vina Toras**: ""Well, this is what's important ..." |
| `[117]` | **""Yes, but I had to keep my mouth shut.""** | `[196]` **Vina Toras**: ""It's unusual for a female heir ..." | `(Variable["RiziaDLC.Prologue_JoinedMilitary"]) == false`<br>`(Variable["RiziaDLC.Prologue_Studied"]) == false` | *Brak zmian stanu* | `[123]` **Vina Toras**: ""So will I. I'm willing to make ..." |
| `[118]` | **""The council is no place for a princess.""** | `[196]` **Vina Toras**: ""It's unusual for a female heir ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Vina Toras**: ""Please, Father. If I'm going to..." |
| `[119]` | **""Well, 18 is old enough to get involved in royal politics.""** | `[196]` **Vina Toras**: ""It's unusual for a female heir ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Vina Toras**: ""And Lyza the Great is a huge le..." |
| `[124]` | **""Yes, but they were too dull to bear.""** | `[196]` **Vina Toras**: ""It's unusual for a female heir ..." | `(Variable["RiziaDLC.Prologue_JoinedMilitary"]) == false`<br>`(Variable["RiziaDLC.Prologue_Studied"]) == false` | *Brak zmian stanu* | `[125]` **Vina Toras**: ""It seems fascinating to me. And..." |
| `[126]` | **""All right, Vina. You can come to the meetings.""** | `[361]` **Narrator**: "Vina looked at me with pleading ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....`<br>`Variable["RiziaDLC.Vina_OnCouncil"] = true; Variable["Riz...` | `[136]` **Narrator**: "My daughter's face lit up." |
| `[127]` | **""Sorry, but your grandma's right. You'd get bored in those meetings anyway.""** | `[361]` **Narrator**: "Vina looked at me with pleading ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[130]` **Narrator**: "My daughter looked crestfallen." |
| `[128]` | **""Your grandmother's just jealous, Vina. You can join the meetings if you want.""** | `[361]` **Narrator**: "Vina looked at me with pleading ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....`<br>`Variable["RiziaDLC.Vina_OnCouncil"] = true; Variable["Riz...` | `[136]` **Narrator**: "My daughter's face lit up." |
| `[129]` | **""You're not coming to council meetings, Vina. That's an order.""** | `[361]` **Narrator**: "Vina looked at me with pleading ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[130]` **Narrator**: "My daughter looked crestfallen." |
| `[141]` | **""I just don't want her concerning herself with state affairs at such a young age.""** | `[140]` **Estela Toras**: ""You made the right decision. In..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Estela Toras**: ""Smart boy."" |
| `[142]` | **""It doesn't matter either way. The council is an antiquated institution.""** | `[140]` **Estela Toras**: ""You made the right decision. In..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Narrator**: "She raised an eyebrow." |
| `[143]` | **""You're right. I don't want to give my opponents any more leverage over me.""** | `[140]` **Estela Toras**: ""You made the right decision. In..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Estela Toras**: ""Smart boy."" |
| `[144]` | **""You're right. I feel lousy letting her down, though.""** | `[140]` **Estela Toras**: ""You made the right decision. In..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Estela Toras**: ""She'll get over it."" |
| `[145]` | **""I don't care. She's my daughter and she'll get what she wants.""** | `[139]` **Estela Toras**: ""You do realize that she'll be n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Estela Toras**: ""Growing up motherless doesn't g..." |
| `[146]` | **""She's the heir apparent. It'll be a good education for her.""** | `[139]` **Estela Toras**: ""You do realize that she'll be n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Estela Toras**: ""I hope you're right."" |
| `[147]` | **""One more Toras on the council is an asset, not a liability.""** | `[139]` **Estela Toras**: ""You do realize that she'll be n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Estela Toras**: ""I hope you're right."" |
| `[148]` | **""What does it matter? The council is an antiquated institution anyway.""** | `[139]` **Estela Toras**: ""You do realize that she'll be n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Narrator**: "She raised an eyebrow." |
| `[157]` | **""Thanks for saying that.""** | `[156]` **Estela Toras**: ""He always believed you'd make a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Narrator**: "I headed back upstairs to fetch ..."<br>`[170]` **Narrator**: "I headed back upstairs to get re..." |
| `[158]` | **""Bullshit.""** | `[156]` **Estela Toras**: ""He always believed you'd make a..." | `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true` | *Brak zmian stanu* | `[164]` **Narrator**: "Her laughter followed me up the ..." |
| `[163]` | **""I really don't care what my father thought of me.""** | `[156]` **Estela Toras**: ""He always believed you'd make a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Narrator**: "I headed back upstairs to fetch ..."<br>`[170]` **Narrator**: "I headed back upstairs to get re..." |
| `[165]` | **""I won't just be good. I'll be the best.""** | `[156]` **Estela Toras**: ""He always believed you'd make a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Narrator**: "I headed back upstairs to fetch ..."<br>`[170]` **Narrator**: "I headed back upstairs to get re..." |
| `[175]` | **""Zille will be ours again. And so will Pales.""** | `[377]` **Estela Toras**: ""It's a pity he didn't live to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Estela Toras**: ""I never cared much about Pales...." |
| `[177]` | **""Just two years to go until the treaty expires.""** | `[377]` **Estela Toras**: ""It's a pity he didn't live to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[381]` **Estela Toras**: ""I'm looking forward to that day."" |
| `[178]` | **""I'm already planning the reunification ceremony.""** | `[377]` **Estela Toras**: ""It's a pity he didn't live to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Estela Toras**: ""I'll find a suitably scandalizi..." |
| `[179]` | **""Halaita. If it is said, so it is and shall be.""** | `[377]` **Estela Toras**: ""It's a pity he didn't live to p..." | `Variable["RiziaDLC.Prologue_Religious"] == true` | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[406]` **Narrator**: "She looked skeptical for a secon..." |
| `[193]` | **""What's so funny?""** | `[214]` **Pabel Adria**: ""Certainly, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Narrator**: "Pabel paused for a second, then ..." |
| `[195]` | **""Yes. And?""** | `[99]` **Vina Toras**: ""You know that I'm 18 now."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Vina Toras**: ""I was thinking I'm old enough t..." |
| `[219]` | **""Not really. All I had to do to get this job was wait for Father to die.""** | `[218]` **Pabel Adria**: ""Romus Toras, King of Rizia. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Narrator**: "Pabel's eyes flooded with compas..." |
| `[220]` | **""So have you, Mr. Chief Butler.""** | `[218]` **Pabel Adria**: ""Romus Toras, King of Rizia. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Pabel Adria**: ""Not bad for the groundskeeper's..." |
| `[221]` | **""And yet here I am in the exact same palace.""** | `[218]` **Pabel Adria**: ""Romus Toras, King of Rizia. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Pabel Adria**: ""But now you've got me as your b..." |
| `[222]` | **""It feels natural, somehow. Like I was born to do this.""** | `[218]` **Pabel Adria**: ""Romus Toras, King of Rizia. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Pabel Adria**: ""You were."" |
| `[232]` | **""Thank you for your concern.""** | `[228]` **Pabel Adria**: ""I know you two didn't get along..."<br>`[229]` **Pabel Adria**: ""I'm so sorry. This must be hard..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Pabel Adria**: ""Anything I can do to make your ..." |
| `[233]` | **""It's complicated. I don't know what I should be feeling right now.""** | `[228]` **Pabel Adria**: ""I know you two didn't get along..."<br>`[229]` **Pabel Adria**: ""I'm so sorry. This must be hard..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Pabel Adria**: ""There's no 'should'. You feel w..." |
| `[234]` | **""To be honest, I'm not that bothered.""** | `[228]` **Pabel Adria**: ""I know you two didn't get along..."<br>`[229]` **Pabel Adria**: ""I'm so sorry. This must be hard..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Pabel Adria**: ""Well, I'm here to make your lif..." |
| `[235]` | **""It must have been even harder being his butler.""** | `[228]` **Pabel Adria**: ""I know you two didn't get along..."<br>`[229]` **Pabel Adria**: ""I'm so sorry. This must be hard..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Narrator**: "Something dark passed across Pab..." |
| `[250]` | **""Won't you eat with us?""** | `[244]` **Pabel Adria**: ""You have quite the packed sched..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Narrator**: "Pabel shook his head." |
| `[251]` | **""I can pick out my own clothes, Pabel.""** | `[244]` **Pabel Adria**: ""You have quite the packed sched..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[253]` **Pabel Adria**: ""Can you? Remember when your fat..." |
| `[252]` | **""That sounds great.""** | `[244]` **Pabel Adria**: ""You have quite the packed sched..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Pabel Adria**: ""Queen Mother Estela and Princes..." |
| `[261]` | **""We're still friends, though, right?""** | `[259]` **Pabel Adria**: ""I ate in the servants' quarters..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Pabel Adria**: ""Always. Bi mare volu, un oxit s..." |
| `[262]` | **""Yes, fine. Thank you.""** | `[257]` **Pabel Adria**: ""I trust you slept well?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Pabel Adria**: ""I'm glad."" |
| `[270]` | **""No, not really. I was thinking about Father.""** | `[257]` **Pabel Adria**: ""I trust you slept well?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Narrator**: "Compassion appeared in his eyes." |
| `[271]` | **""He can't have been an easy man to serve. Especially towards the end.""** | `[275]` **Pabel Adria**: ""My condolences, Your Majesty. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Narrator**: "Something dark passed across Pab..." |
| `[276]` | **""I have no need for your pity.""** | `[275]` **Pabel Adria**: ""My condolences, Your Majesty. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Narrator**: "Pabel took a step backwards." |
| `[277]` | **""Good riddance to the bastard.""** | `[275]` **Pabel Adria**: ""My condolences, Your Majesty. T..." | `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true` | *Brak zmian stanu* | `[280]` **Narrator**: "Pabel looked mildly shocked." |
| `[278]` | **""Thank you, Pabel. That means a lot.""** | `[275]` **Pabel Adria**: ""My condolences, Your Majesty. T..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Pabel Adria**: ""Just let me know if there's any..." |
| `[292]` | **""We're still friends, right?""** | `[260]` **Pabel Adria**: ""Don't worry, Your Majesty. I'll..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Pabel Adria**: ""Always. Bi mare volu, un oxit s..." |
| `[293]` | **""Hierarchies are meant to be broken. You're the head butler, not a common scullery..."** | `[259]` **Pabel Adria**: ""I ate in the servants' quarters..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Varia...` | `[401]` **Pabel Adria**: ""If the King commands it, I can ..." |
| `[294]` | **""Can you at least stop calling me 'Your Majesty'? We don't need to be so formal wi..."** | `[259]` **Pabel Adria**: ""I ate in the servants' quarters..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Pabel Adria**: ""I can in private. In public, it..." |
| `[297]` | **""Please. Can you call me Romus?""** | `[260]` **Pabel Adria**: ""Don't worry, Your Majesty. I'll..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Pabel Adria**: ""I can in private. In public, it..." |
| `[305]` | **""Won't you eat with us?""** | `[304]` **Pabel Adria**: ""Why don't you join your family ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[308]` **Narrator**: "Pabel shook his head." |
| `[306]` | **""I can pick out my own clothes, Pabel.""** | `[304]` **Pabel Adria**: ""Why don't you join your family ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Pabel Adria**: ""This is one of my royal duties,..." |
| `[307]` | **""That sounds perfect.""** | `[304]` **Pabel Adria**: ""Why don't you join your family ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Pabel Adria**: ""Queen Mother Estela and Princes..." |
| `[315]` | **""We're still friends, right?""** | `[309]` **Pabel Adria**: ""I ate in the servant's quarters..."<br>`[311]` **Pabel Adria**: ""Don't worry, Your Majesty. I'll..." | `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true` | *Brak zmian stanu* | `[295]` **Pabel Adria**: ""Always. Bi mare volu, un oxit s..."<br>`[328]` **Pabel Adria**: ""Of course."" |
| `[316]` | **""Can you stop calling me 'Your Majesty'? We don't need to be so formal with each o..."** | `[309]` **Pabel Adria**: ""I ate in the servant's quarters..."<br>`[311]` **Pabel Adria**: ""Don't worry, Your Majesty. I'll..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Pabel Adria**: ""I can in private. In public, it..."<br>`[323]` **Pabel Adria**: ""Sorry, Your Majesty. But that w..." |
| `[321]` | **""I expect nothing less.""** | `[260]` **Pabel Adria**: ""Don't worry, Your Majesty. I'll..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Pabel Adria**: ""I haven't forgotten. Bi mare vo..." |
| `[329]` | **""I expect nothing less.""** | `[311]` **Pabel Adria**: ""Don't worry, Your Majesty. I'll..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Pabel Adria**: ""Enjoy your breakfast."" |
| `[330]` | **""Thanks, Pabel. Let's catch up later.""** | `[296]` **Narrator**: "I recognized the slogan we'd mad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Pabel Adria**: ""Enjoy your breakfast."" |
| `[331]` | **""This will be fun. Just like old times.""** | `[296]` **Narrator**: "I recognized the slogan we'd mad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Pabel Adria**: ""Enjoy your breakfast."" |
| `[332]` | **""You always were a poetic type.""** | `[296]` **Narrator**: "I recognized the slogan we'd mad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Pabel Adria**: ""I'm just a humble servant. Enjo..." |
| `[333]` | **""My grandmother Queen Lyza didn't get her wisdom from serving on her father's coun..."** | `[121]` **Vina Toras**: ""Well, this is what's important ..."<br>`[122]` **Vina Toras**: ""Please, Father. If I'm going to..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Vina Toras**: ""That's not fair. She was alread..." |
| `[334]` | **""Greatness is something you're born with, my daughter. You can't glean it off of o..."** | `[120]` **Vina Toras**: ""And Lyza the Great is a huge le..."<br>`[121]` **Vina Toras**: ""Well, this is what's important ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Vina Toras**: ""Queen Lyza herself would disagr..." |
| `[335]` | **""My grandmother's achievements weren't as noteworthy as everyone says. She just ha..."** | `[120]` **Vina Toras**: ""And Lyza the Great is a huge le..."<br>`[121]` **Vina Toras**: ""Well, this is what's important ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[339]` **Vina Toras**: ""That's what some people say, ye..." |
| `[336]` | **""You shouldn't have to worry about living up to anyone's legacy. You're great in y..."** | `[120]` **Vina Toras**: ""And Lyza the Great is a huge le..."<br>`[121]` **Vina Toras**: ""Well, this is what's important ..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Vina Toras**: ""That's very kind of you, Father..." |
| `[344]` | **""Your grandmother's right, Vina. As the princess, it's up to you to serve as the u..."** | `[343]` **Estela Toras**: ""And what your father needs is f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Vina Toras**: ""Listen to both of you! I need t..." |
| `[345]` | **""Now, Mother. We both know Vina is much more than a pretty face.""** | `[343]` **Estela Toras**: ""And what your father needs is f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Vina Toras**: ""I do recognize my duty to repre..." |
| `[346]` | **""That's an outdated image of a princess, isn't it? If Vina wants to get involved i..."** | `[343]` **Estela Toras**: ""And what your father needs is f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[386]` **Vina Toras**: ""It would mean the world to me, ..." |
| `[347]` | **""It is true that you'll learn more about how the world works by being out in it, n..."** | `[343]` **Estela Toras**: ""And what your father needs is f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Vina Toras**: ""Going to balls won't teach me h..." |
| `[354]` | **""My councilors represent many cumulative decades of experience. I would not discou..."** | `[353]` **Estela Toras**: ""And God help you if you get in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Estela Toras**: ""Their 'wisdom' turned Pales int..." |
| `[355]` | **""I have always found it odd that we entrust the country's direction to a handful o..."** | `[353]` **Estela Toras**: ""And God help you if you get in ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[363]` **Vina Toras**: ""If choosing when to ignore the ..." |
| `[356]` | **""My father may have allowed his council to run roughshod over him. I will not make..."** | `[353]` **Estela Toras**: ""And God help you if you get in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Vina Toras**: ""If navigating the council's sel..." |
| `[358]` | **""That's enough, Mother. This is my decision to make.""** | `[353]` **Estela Toras**: ""And God help you if you get in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Estela Toras**: ""I'm only trying to be helpful. ..." |
| `[369]` | **""Honestly, I wasn't even sure what I wanted to say.""** | `[46]` **Estela Toras**: ""That was one cheeky speech you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Estela Toras**: ""You certainly said something."" |
| `[389]` | **""I insist you join us at the table next time. You're the head butler, not a common..."** | `[309]` **Pabel Adria**: ""I ate in the servant's quarters..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[390]` **Narrator**: "He smiled." |
| `[393]` | **""Even more fashionable than King Darius the Debonair?""** | `[311]` **Pabel Adria**: ""Don't worry, Your Majesty. I'll..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[395]` **Pabel Adria**: ""I wasn't aware such a monarch e..." |
| `[396]` | **""How rude. In the future, you will not take a bite before your King does.""** | `[309]` **Pabel Adria**: ""I ate in the servant's quarters..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[397]` **Narrator**: "His expression stayed neutral." |
| `[402]` | **""Even more fashionable than King Darius the Debonair?""** | `[260]` **Pabel Adria**: ""Don't worry, Your Majesty. I'll..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[403]` **Narrator**: "He grinned." |

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
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Debating their daughter’s fate over tea,..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The morning after my coronation, I was woken up by a knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "It took me a few seconds to remember where I was."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go away. I'm sleeping.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[7]`
Mówca: **Pabel Adria**
> ""Rise and shine, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Romus: ""It's good to see you, Pabel.""*)
  - -> `[17]` (*Player_Romus: ""I knew this day would come, but it still feels odd havin..."*)
  - -> `[13]` (*Player_Romus: ""What nerve. Barge in on the King again like that, and I'..."*)
  - -> `[18]` (*Player_Romus: ""Where's my newspaper?""*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The door swung open. Pabel walked in, beaming."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "The door opened, and Pabel gracefully stepped in."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "The door opened, and Pabel gracefully stepped in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "In the years I'd been gone, the groundskeeper's son had w..."*)

### Węzeł `[12]`
Mówca: **Pabel Adria**
> ""You said you wanted to be woken up at this time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""Yes, I did. It's best to get a head start while the day'..."*)
  - -> `[14]` (*Player_Romus: ""It's nice to see a familiar face.""*)
  - -> `[20]` (*Player_Romus: ""What nerve. Barge in on me again like that, and I'll hav..."*)
  - -> `[19]` (*Player_Romus: ""Where's my breakfast?""*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What nerve. Barge in on the King again like that, and I'll have your head.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "The corner of Pabel's mouth twitched. He responded calmly."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's nice to see a familiar face.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelBoss == true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I did. It's best to get a head start while the day's still young.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelBoss == true"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's good to see you, Pabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Pabel Adria: ""You, too.""*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew this day would come, but it still feels odd having you wait on me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "Pabel chuckled."*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's my newspaper?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "Pabel blinked. He responded calmly."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where's my breakfast?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Pabel leveled his gaze at me, his manner calm."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What nerve. Barge in on me again like that, and I'll have your head.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Pabel leveled his gaze at me, his manner calm."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "The corner of Pabel's mouth twitched. He responded calmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Pabel Adria: ""Certainly, Your Majesty.""*)

### Węzeł `[22]`
Mówca: **Narrator**
> "Pabel blinked. He responded calmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Pabel Adria: ""I wasn't informed you wanted one, Your Majesty. I'll mak..."*)

### Węzeł `[23]`
Mówca: **Pabel Adria**
> ""I wasn't informed you wanted one, Your Majesty. I'll make sure to bring you the Herald every morning going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Romus: ""No, no, I was joking. How are you, Pabel?""*)
  - -> `[36]` (*Player_Romus: ""Good. See that you do.""*)

### Węzeł `[24]`
Mówca: **Pabel Adria**
> ""You, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "He drew back the heavy velvet curtains. Sunshine flooded ..."*)

### Węzeł `[25]`
Mówca: **Pabel Adria**
> ""You had better get used to it. Everyone answers to you now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "He drew back the heavy velvet curtains. Sunshine flooded ..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""Sorry, I couldn't resist. How are you, Pabel?""]** — Mówca: **Player_Romus**
> ""Sorry, I couldn't resist. How are you, Pabel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "He let out a sigh of relief."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""I mean it.""]** — Mówca: **Player_Romus**
> ""I mean it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Pabel paused for a second, then responded with composure."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "Pabel paused for a second, then responded with composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 1; RiziaDLC.PersonalValue_Tyr..."*)

### Węzeł `[29]`
Mówca: **Pabel Adria**
> ""I'm fine, Your Majesty. Wonderful, actually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "He drew back the heavy velvet curtains. Sunshine flooded ..."*)

### Węzeł `[30]`
Mówca: **Pabel Adria**
> ""Indeed. You've got a packed schedule ahead of you today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "He briskly drew back the heavy velvet curtains. Sunshine ..."*)

### Węzeł `[31]`
Mówca: **Pabel Adria**
> ""It won't happen again, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 1"*)

### Węzeł `[32]`
Mówca: **Pabel Adria**
> ""They're just getting it ready for you downstairs now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 1"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Pabel nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Pabel Adria: ""Indeed. You've got a packed schedule ahead of you today.""*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Pabel leveled his gaze at me, his manner calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Pabel Adria: ""It won't happen again, Your Majesty.""*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, no, I was joking. How are you, Pabel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "He let out a sigh of relief."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. See that you do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 1"*)

### Węzeł `[37]`
Mówca: **Narrator**
> "In the eastern dining room, an enormous breakfast spread had been laid out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[38]`
Mówca: **Narrator**
> "My mother was already sitting at the table, digging a spoon into a single grapefruit half."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""Really? That's all you're eating?""*)
  - -> `[41]` (*Player_Romus: ""You're supposed to rise when the King enters the room.""*)
  - -> `[40]` (*Player_Romus: ""Good morning, Mother.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""Really? That's all you're eating?""]** — Mówca: **Player_Romus**
> ""Really? That's all you're eating?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Estela Toras: ""How do you think I stay this trim, darling?""*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Good morning, Mother.""]** — Mówca: **Player_Romus**
> ""Good morning, Mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Estela Toras: ""Same to you, darling.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""You're supposed to rise when the King enters the room.""]** — Mówca: **Player_Romus**
> ""You're supposed to rise when the King enters the room.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Estela Toras: ""I gave birth to you, darling, I've earned the right to s..."*)

### Węzeł `[42]`
Mówca: **Estela Toras**
> ""How do you think I stay this trim, darling?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Despite the early hour, my mother was already in her full..."*)

### Węzeł `[43]`
Mówca: **Estela Toras**
> ""Same to you, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Despite the early hour, my mother was already in her full..."*)

### Węzeł `[44]`
Mówca: **Estela Toras**
> ""I gave birth to you, darling, I've earned the right to stay seated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Despite the early hour, my mother was already in her full..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Despite the early hour, my mother was already in her full makeup. She dabbed at her lips with a napkin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)

### Węzeł `[46]`
Mówca: **Estela Toras**
> ""That was one cheeky speech you gave yesterday. The papers are having a field day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus: ""I meant every word of it.""*)
  - -> `[51]` (*Player_Romus: ""Forget the papers. Did you see the look on Hugo's face?""*)
  - -> `[369]` (*Player_Romus: ""Honestly, I wasn't even sure what I wanted to say.""*)
  - -> `[47]` (*Player_Romus: ""Who cares what they write?""*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""Who cares what they write?""]** — Mówca: **Player_Romus**
> ""Who cares what they write?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Estela Toras: ""They're all rags, anyway.""*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_GaveSpeech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_GaveSpeech == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_GaveSpeech == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_GaveSpeech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_GaveSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Estela Toras: ""That was one cheeky speech you gave yesterday. The paper..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_GaveSpeech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_GaveSpeech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Estela Toras: ""I hope you're satisfied with yesterday's coronation. You..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Forget the papers. Did you see the look on Hugo's face?""]** — Mówca: **Player_Romus**
> ""Forget the papers. Did you see the look on Hugo's face?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Estela Toras: ""How could I have missed it?""*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""I meant every word of it.""]** — Mówca: **Player_Romus**
> ""I meant every word of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Estela Toras: ""I'm very sure that you did.""*)

### Węzeł `[53]`
Mówca: **Estela Toras**
> ""I hope you're satisfied with yesterday's coronation. Your father's wasn't nearly as well-attended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player_Romus: ""What can I say? My people love me.""*)
  - -> `[81]` (*Player_Romus: ""That's only because of the TV cameras.""*)
  - -> `[62]` (*Player_Romus: ""That was his fault.""*)
  - -> `[61]` (*Player_Romus: ""That was mostly your fault.""*)

### Węzeł `[54]`
Mówca: **Estela Toras**
> ""I'm very sure that you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Her face grew stern."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Her face grew stern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Estela Toras: ""You ought to be careful, though. This country takes its ..."*)

### Węzeł `[56]`
Mówca: **Estela Toras**
> ""How could I have missed it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Her face grew stern."*)

### Węzeł `[57]`
Mówca: **Estela Toras**
> ""They're all rags, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Her face grew stern."*)

### Węzeł `[58]`
Mówca: **Estela Toras**
> ""You ought to be careful, though. This country takes its royal traditions seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Estela Toras: ""Your father and I learned that the hard way.""*)

### Węzeł `[59]`
Mówca: **Estela Toras**
> ""Your father and I learned that the hard way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter == true"*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""What can I say? My people love me.""]** — Mówca: **Player_Romus**
> ""What can I say? My people love me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Estela Toras: ""They love to be seen on television. You, they're not so ..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""That was mostly your fault.""]** — Mówca: **Player_Romus**
> ""That was mostly your fault.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Estela Toras: ""Yes, better a dead wife than a common one.""*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""That was his fault.""]** — Mówca: **Player_Romus**
> ""That was his fault.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Estela Toras: ""Don't speak ill of the dead. Only their widows can do th..."*)

### Węzeł `[63]`
Mówca: **Estela Toras**
> ""They love to be seen on television. You, they're not so sure about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Her eyes grew serious."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "My daughter gave a kiss on the cheek to mother, then me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Vina Toras: ""I nearly got lost on the way here. Grandma, why didn't y..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DistantAsDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DistantAsDad == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_DistantAsDad == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DistantAsDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_DistantAsDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "My daughter kissed mother on the cheek, then gave me a sh..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_DistantAsDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DistantAsDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "My daughter gave a kiss on the cheek to mother, then me."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "My daughter kissed mother on the cheek, then gave me a shy wave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Vina Toras: ""I nearly got lost on the way here. Grandma, why didn't y..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's nonsense. Vina, eat as much as you want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Vina took a bite of a rizetta and gave an exaggerated sig..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely. If you eat this much every morning, you'll never get married.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever you say, Mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Vina took a bite of a rizetta and gave an exaggerated sigh of pleasure. My mother rolled her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Estela Toras: ""Suit yourself. Now, if anyone in this place could make a..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Vina's smile vanished. She took most of the food off her plate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Estela Toras: ""We'll make a princess of you yet. Now, if anyone in this..."*)

### Węzeł `[74]`
Mówca: **Vina Toras**
> ""Father, I wanted to ask you something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Vina Toras: ""You know that I'm 18 now.""*)

### Węzeł `[75]`
Mówca: **Narrator**
> "It took me a few seconds to remember where I was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "The royal bedroom, on the top floor of the residential wi..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "The knocking on the door continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: ""Yes?""*)
  - -> `[5]` (*Player_Romus: ""Who is it?""*)
  - -> `[6]` (*Player_Romus: ""Go away. I'm sleeping.""*)

### Węzeł `[77]`
Mówca: **Narrator**
> "The door swung open. Pabel walked in, beaming."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)

### Węzeł `[78]`
Mówca: **Estela Toras**
> ""Yes, better a dead wife than a common one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Her eyes grew serious."*)

### Węzeł `[79]`
Mówca: **Estela Toras**
> ""Don't speak ill of the dead. Only their widows can do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Her eyes grew serious."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Her eyes grew serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter == true"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""That's only because of the TV cameras.""]** — Mówca: **Player_Romus**
> ""That's only because of the TV cameras.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Estela Toras: ""Oh, don't sell yourself short.""*)

### Węzeł `[82]`
Mówca: **Estela Toras**
> ""Oh, don't sell yourself short.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Her eyes grew serious."*)

### Węzeł `[83]`
Mówca: **Estela Toras**
> ""What was in that letter he wrote you, by the way? I never asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""I'd rather keep that private.""*)
  - -> `[89]` (*Player_Romus: ""He said not to make the same mistakes he did.""*)
  - -> `[90]` (*Player_Romus: ""He told me to take back the lands that were lost.""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DadLetter == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_DadLetter == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DadLetter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_DadLetter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Estela Toras: ""What was in that letter he wrote you, by the way? I neve..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_DadLetter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DadLetter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Estela Toras: ""What did he say to you before he died, by the way? I nev..."*)

### Węzeł `[87]`
Mówca: **Estela Toras**
> ""What did he say to you before he died, by the way? I never asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""I'd rather keep that private.""*)
  - -> `[89]` (*Player_Romus: ""He said not to make the same mistakes he did.""*)
  - -> `[90]` (*Player_Romus: ""He told me to take back the lands that were lost.""*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""I'd rather keep that private.""]** — Mówca: **Player_Romus**
> ""I'd rather keep that private.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Estela Toras), `[87]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""He said not to make the same mistakes he did.""]** — Mówca: **Player_Romus**
> ""He said not to make the same mistakes he did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Estela Toras), `[87]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Estela Toras: ""He must've been talking about Zille and Pales. His great..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""He told me to take back the lands that were lost.""]** — Mówca: **Player_Romus**
> ""He told me to take back the lands that were lost.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Estela Toras), `[87]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Estela Toras: ""Zille and Pales, I suppose. He never did give up on the ..."*)

### Węzeł `[91]`
Mówca: **Estela Toras**
> ""Zille and Pales, I suppose. He never did give up on the Grand Duchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Estela Toras: ""It's a pity he didn't live to preside over my homeland's..."*)

### Węzeł `[92]`
Mówca: **Estela Toras**
> ""He must've been talking about Zille and Pales. His great follies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Estela Toras: ""It's a pity he didn't live to preside over my homeland's..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "She handed me a rizetta, the traditional rice and quince custard tart. The crust was exceptionally flaky."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Just then, Vina came bounding down the stairs."*)

### Węzeł `[94]`
Mówca: **Vina Toras**
> ""Isn't it a lovely morning?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DistantAsDad == true"*)

### Węzeł `[95]`
Mówca: **Vina Toras**
> ""I nearly got lost on the way here. Grandma, why didn't you tell me this place had such a big library?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Estela Toras: ""Because I didn't want you holed up in there all the time..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Vina eagerly took a plate and started piling it high with pastries. My mother clicked her tongue disapprovingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Estela Toras: ""Not too many of those. The sweeter the taste, the wider ..."*)

### Węzeł `[97]`
Mówca: **Estela Toras**
> ""Not too many of those. The sweeter the taste, the wider the waist. Don't you agree, Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""That's nonsense. Vina, eat as much as you want.""*)
  - -> `[98]` (*Player_Romus: ""It's a special occasion. Our diet can start tomorrow.""*)
  - -> `[70]` (*Player_Romus: ""Absolutely. If you eat this much every morning, you'll n..."*)
  - -> `[71]` (*Player_Romus: ""Whatever you say, Mother.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a special occasion. Our diet can start tomorrow.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Vina took a bite of a rizetta and gave an exaggerated sig..."*)

### Węzeł `[99]`
Mówca: **Vina Toras**
> ""You know that I'm 18 now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: ""Yes, it's time you started taking on more responsibiliti..."*)
  - -> `[102]` (*Player_Romus: ""I know. You've got to start thinking about where to study.""*)
  - -> `[101]` (*Player_Romus: ""I know. We're already behind on finding you a husband.""*)
  - -> `[195]` (*Player_Romus: ""Yes. And?""*)
  - -> `[100]` (*Player_Romus: ""That old? How time flies.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That old? How time flies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DistantAsDad == true"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know. We're already behind on finding you a husband.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Vina Toras: ""Ugh, that's not what I meant.""*)

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know. You've got to start thinking about where to study.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Vina Toras: ""That's not quite what I had in mind.""*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, it's time you started taking on more responsibilities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Vina Toras: ""Exactly!""*)

### Węzeł `[104]`
Mówca: **Vina Toras**
> ""Exactly!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Vina Toras: ""I was thinking I'm old enough to accompany you to your c..."*)

### Węzeł `[105]`
Mówca: **Vina Toras**
> ""Ugh, that's not what I meant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Vina Toras: ""I was thinking I'm old enough to accompany you to your c..."*)

### Węzeł `[106]`
Mówca: **Vina Toras**
> ""That's not quite what I had in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Vina Toras: ""I was thinking I'm old enough to accompany you to your c..."*)

### Węzeł `[107]`
Mówca: **Vina Toras**
> ""That was supposed to be a joke, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Vina Toras: ""I was thinking I'm old enough to accompany you to your c..."*)

### Węzeł `[108]`
Mówca: **Vina Toras**
> ""I was thinking I'm old enough to accompany you to your council meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Vina Toras: ""It's unusual for a female heir to join the council, I kn..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, getting an education was far more important to me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Studied"]`
- **Kontekst wejściowy (poprzednik):** `[196]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Vina Toras: ""Well, this is what's important to me. Lyza the Great is ..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player_Romus: ""No, getting an education was far more important to me.""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus: ""No, learning how to fight for my country was far more im..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""Yes, but I had to keep my mouth shut.""*)
  - -> `[124]` (*Player_Romus: ""Yes, but they were too dull to bear.""*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, learning how to fight for my country was far more important to me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"]` AND `(Variable["RiziaDLC.Prologue_Studied"]) == false`
- **Kontekst wejściowy (poprzednik):** `[196]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Vina Toras: ""Well, this is what's important to me. Lyza the Great is ..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but I had to keep my mouth shut.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"]) == false` AND `(Variable["RiziaDLC.Prologue_Studied"]) == false`
- **Kontekst wejściowy (poprzednik):** `[196]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Vina Toras: ""So will I. I'm willing to make sacrifices to live up to ..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The council is no place for a princess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Vina Toras: ""Please, Father. If I'm going to live up to the legacy of..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, 18 is old enough to get involved in royal politics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Vina Toras: ""And Lyza the Great is a huge legacy for me to live up to.""*)

### Węzeł `[120]`
Mówca: **Vina Toras**
> ""And Lyza the Great is a huge legacy for me to live up to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player_Romus: ""You shouldn't have to worry about living up to anyone's ..."*)
  - -> `[335]` (*Player_Romus: ""My grandmother's achievements weren't as noteworthy as e..."*)
  - -> `[334]` (*Player_Romus: ""Greatness is something you're born with, my daughter. Yo..."*)

### Węzeł `[121]`
Mówca: **Vina Toras**
> ""Well, this is what's important to me. Lyza the Great is a huge legacy to live up to, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player_Romus: ""You shouldn't have to worry about living up to anyone's ..."*)
  - -> `[335]` (*Player_Romus: ""My grandmother's achievements weren't as noteworthy as e..."*)
  - -> `[334]` (*Player_Romus: ""Greatness is something you're born with, my daughter. Yo..."*)
  - -> `[333]` (*Player_Romus: ""My grandmother Queen Lyza didn't get her wisdom from ser..."*)

### Węzeł `[122]`
Mówca: **Vina Toras**
> ""Please, Father. If I'm going to live up to the legacy of Lyza the Great, I need to start early.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player_Romus: ""You shouldn't have to worry about living up to anyone's ..."*)
  - -> `[335]` (*Player_Romus: ""My grandmother's achievements weren't as noteworthy as e..."*)
  - -> `[334]` (*Player_Romus: ""Greatness is something you're born with, my daughter. Yo..."*)
  - -> `[333]` (*Player_Romus: ""My grandmother Queen Lyza didn't get her wisdom from ser..."*)

### Węzeł `[123]`
Mówca: **Vina Toras**
> ""So will I. I'm willing to make sacrifices to live up to the legacy of Lyza the Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player_Romus: ""You shouldn't have to worry about living up to anyone's ..."*)
  - -> `[335]` (*Player_Romus: ""My grandmother's achievements weren't as noteworthy as e..."*)
  - -> `[334]` (*Player_Romus: ""Greatness is something you're born with, my daughter. Yo..."*)
  - -> `[333]` (*Player_Romus: ""My grandmother Queen Lyza didn't get her wisdom from ser..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but they were too dull to bear.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"]) == false` AND `(Variable["RiziaDLC.Prologue_Studied"]) == false`
- **Kontekst wejściowy (poprzednik):** `[196]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Vina Toras: ""It seems fascinating to me. And if I'm going to live up ..."*)

### Węzeł `[125]`
Mówca: **Vina Toras**
> ""It seems fascinating to me. And if I'm going to live up to the legacy of Lyza the Great, I'm going to have to start early.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Player_Romus: ""You shouldn't have to worry about living up to anyone's ..."*)
  - -> `[335]` (*Player_Romus: ""My grandmother's achievements weren't as noteworthy as e..."*)
  - -> `[334]` (*Player_Romus: ""Greatness is something you're born with, my daughter. Yo..."*)
  - -> `[333]` (*Player_Romus: ""My grandmother Queen Lyza didn't get her wisdom from ser..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right, Vina. You can come to the meetings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[361]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but your grandma's right. You'd get bored in those meetings anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[361]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1; RiziaDLCSupport.Journal_Tur..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your grandmother's just jealous, Vina. You can join the meetings if you want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[361]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're not coming to council meetings, Vina. That's an order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[361]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1; RiziaDLCSupport.Journal_Tur..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "My daughter looked crestfallen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Vina Toras: ""I guess I'll just go read in my room, then.""*)

### Węzeł `[131]`
Mówca: **Vina Toras**
> ""I guess I'll just go read in my room, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "She pushed her plate away and trudged back upstairs. Once..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Vina's smile vanished. She took most of the food off her ..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1; RiziaDLCSupport.Journal_Turn01_VinaOffCouncil = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;
Variable["RiziaDLCSupport.Journal_Turn01_VinaOffCouncil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "My daughter looked crestfallen."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil = true; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[135]`
Mówca: **Vina Toras**
> ""Thank you! I can't wait to start. Oh, I'd better refresh myself on Rizian law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "She pushed her plate away and dashed back up the stairs. ..."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "My daughter's face lit up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Vina Toras: ""Thank you! I can't wait to start. Oh, I'd better refresh..."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "She pushed her plate away and trudged back upstairs. Once she was gone, my mother lit a cigarette."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras");"*)

### Węzeł `[138]`
Mówca: **Narrator**
> "She pushed her plate away and dashed back up the stairs. Once she was gone, my mother lit a cigarette."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras");"*)

### Węzeł `[139]`
Mówca: **Estela Toras**
> ""You do realize that she'll be nothing but a liability to you in that room.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Player_Romus: ""I don't care. She's my daughter and she'll get what she ..."*)
  - -> `[146]` (*Player_Romus: ""She's the heir apparent. It'll be a good education for h..."*)
  - -> `[147]` (*Player_Romus: ""One more Toras on the council is an asset, not a liabili..."*)
  - -> `[148]` (*Player_Romus: ""What does it matter? The council is an antiquated instit..."*)

### Węzeł `[140]`
Mówca: **Estela Toras**
> ""You made the right decision. In that room, she's nothing but a liability to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""It doesn't matter either way. The council is an antiquat..."*)
  - -> `[141]` (*Player_Romus: ""I just don't want her concerning herself with state affa..."*)
  - -> `[143]` (*Player_Romus: ""You're right. I don't want to give my opponents any more..."*)
  - -> `[144]` (*Player_Romus: ""You're right. I feel lousy letting her down, though.""*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I just don't want her concerning herself with state affairs at such a young age.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Estela Toras: ""Smart boy.""*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter either way. The council is an antiquated institution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "She raised an eyebrow."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I don't want to give my opponents any more leverage over me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Estela Toras: ""Smart boy.""*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. I feel lousy letting her down, though.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Estela Toras: ""She'll get over it.""*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care. She's my daughter and she'll get what she wants.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Estela Toras: ""Growing up motherless doesn't give you a free pass forev..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's the heir apparent. It'll be a good education for her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Estela Toras: ""I hope you're right.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One more Toras on the council is an asset, not a liability.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Estela Toras: ""I hope you're right.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does it matter? The council is an antiquated institution anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "She raised an eyebrow."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "She raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Estela Toras: ""Don't let them catch you saying that.""*)

### Węzeł `[150]`
Mówca: **Estela Toras**
> ""Don't let them catch you saying that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "The clock struck quarter to nine. My first council meetin..."*)

### Węzeł `[151]`
Mówca: **Estela Toras**
> ""She'll get over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "The clock struck quarter to nine. My first council meetin..."*)

### Węzeł `[152]`
Mówca: **Estela Toras**
> ""I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "The clock struck quarter to nine. My first council meetin..."*)

### Węzeł `[153]`
Mówca: **Estela Toras**
> ""Smart boy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "The clock struck quarter to nine. My first council meetin..."*)

### Węzeł `[154]`
Mówca: **Estela Toras**
> ""Growing up motherless doesn't give you a free pass forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "The clock struck quarter to nine. My first council meetin..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "The clock struck quarter to nine. My first council meeting was starting soon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "I excused myself from the table. As I was leaving the din..."*)

### Węzeł `[156]`
Mówca: **Estela Toras**
> ""He always believed you'd make a good king, you know. Even if he didn't always show it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""I really don't care what my father thought of me.""*)
  - -> `[165]` (*Player_Romus: ""I won't just be good. I'll be the best.""*)
  - -> `[157]` (*Player_Romus: ""Thanks for saying that.""*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for saying that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bullshit.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Kontekst wejściowy (poprzednik):** `[156]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Her laughter followed me up the stairs."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad == true)"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player_Romus: ""Bullshit.""*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[162]`
Mówca: **Narrator**
> "I excused myself from the table. As I was leaving the dining room, my mother cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Estela Toras: ""He always believed you'd make a good king, you know. Eve..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I really don't care what my father thought of me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[164]`
Mówca: **Narrator**
> "Her laughter followed me up the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_ClashesIza = true"*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't just be good. I'll be the best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[156]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "I headed back upstairs to fetch Vina. It was almost time ..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "I headed back upstairs to get ready. It was almost time t..."*)

### Węzeł `[169]`
Mówca: **Narrator**
> "I headed back upstairs to fetch Vina. It was almost time to go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_ClashesIza = true"*)

### Węzeł `[170]`
Mówca: **Narrator**
> "I headed back upstairs to get ready. It was almost time to go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_ClashesIza = true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil = true; RiziaDLCSupport.Journal_Turn01_VinaOnCouncil = true;
EnableCodexEntry("Characters_Family_VinaToras_InCouncil");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Vina_OnCouncil"] = true;
Variable["RiziaDLCSupport.Journal_Turn01_VinaOnCouncil"] = true;
EnableCodexEntry("Characters_Family_VinaToras_InCouncil");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "My daughter's face lit up."*)

### Węzeł `[172]`
Mówca: **Estela Toras**
> ""Suit yourself. Now, if anyone in this place could make a halfway decent strudel -- *that* would be worth ruining one's figure for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "We ate for a while in silence. Vina looked lost in though..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "We ate for a while in silence. Vina looked lost in thought. Finally, she spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Vina Toras: ""Father, I wanted to ask you something.""*)

### Węzeł `[174]`
Mówca: **Estela Toras**
> ""We'll make a princess of you yet. Now, if anyone in this place could make a halfway decent strudel -- *that* would be worth ruining one's figure for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "We ate for a while in silence. Vina looked lost in though..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Zille will be ours again. And so will Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Estela Toras: ""I never cared much about Pales. But I don't have to tell..."*)

### Węzeł `[176]`
Mówca: **Estela Toras**
> ""I never cared much about Pales. But I don't have to tell you how much Zille means to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Estela Toras: ""But don't let my nattering on keep you from eating. A ki..."*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just two years to go until the treaty expires.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Estela Toras: ""I'm looking forward to that day.""*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm already planning the reunification ceremony.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Estela Toras: ""I'll find a suitably scandalizing dress to wear to it.""*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita. If it is said, so it is and shall be.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[377]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[180]`
Mówca: **Estela Toras**
> ""I'll find a suitably scandalizing dress to wear to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Estela Toras: ""But don't let my nattering on keep you from eating. A ki..."*)

### Węzeł `[181]`
Mówca: **Estela Toras**
> ""Halaita indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Estela Toras: ""But don't let my nattering on keep you from eating. A ki..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DistantAsDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DistantAsDad == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_DistantAsDad == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DistantAsDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_DistantAsDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Vina Toras: ""That was supposed to be a joke, right?""*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_DistantAsDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DistantAsDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Vina Toras: ""Right. Silly of me to think you were keeping track.""*)

### Węzeł `[185]`
Mówca: **Vina Toras**
> ""Right. Silly of me to think you were keeping track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Vina Toras: ""I was thinking I'm old enough to accompany you to your c..."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "Pabel leveled his gaze at me, his manner calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Pabel Adria: ""They're just getting it ready for you downstairs now.""*)

### Węzeł `[187]`
Mówca: **Narrator**
> "He let out a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Pabel Adria: ""I'm fine, Your Majesty. Wonderful, actually.""*)

### Węzeł `[188]`
Mówca: **Narrator**
> "The royal bedroom, on the top floor of the residential wing of Palas Rezna, made the one in the Toras palace in Monqiz look shabby. Ornate gold trim covered the walls. I was alone in a bed that could easily have slept four."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "The knocking on the door continued."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "After I'd left for university, my friend had worked his way up to Chief Butler. It was hard to believe he was now head of my royal household."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Pabel Adria: ""Rise and shine, Your Majesty.""*)

### Węzeł `[190]`
Mówca: **Narrator**
> "After I'd left to join the military, my friend had worked his way up to Chief Butler. It was hard to believe he was now head of my royal household."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Pabel Adria: ""Rise and shine, Your Majesty.""*)

### Węzeł `[191]`
Mówca: **Narrator**
> "After I'd left for Monqiz, my friend had worked his way up to Chief Butler. It was hard to believe he was now head of my royal household."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Pabel Adria: ""Rise and shine, Your Majesty.""*)

### Węzeł `[192]`
Mówca: **Narrator**
> "In the years I'd been gone, the groundskeeper's son had worked his way up to Chief Butler. I'd seen him on visits to the palace, but we rarely exchanged words. Now, he was the head of my royal household."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Pabel Adria: ""You said you wanted to be woken up at this time, Your Ma..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's so funny?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "Pabel paused for a second, then responded with composure."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "Just then, Vina came bounding down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Vina Toras: ""Isn't it a lovely morning?""*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. And?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Vina Toras: ""I was thinking I'm old enough to accompany you to your c..."*)

### Węzeł `[196]`
Mówca: **Vina Toras**
> ""It's unusual for a female heir to join the council, I know. But didn't you do the same when you were my age?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus: ""Well, 18 is old enough to get involved in royal politics.""*)
  - -> `[118]` (*Player_Romus: ""The council is no place for a princess.""*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Estela Toras: ""You do realize that she'll be nothing but a liability to..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Estela Toras: ""You made the right decision. In that room, she's nothing..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "My mother was already sitting at the table, digging a spo..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_RH_ClashesIza = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_ClashesIza"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Qalus_WineHarvest = true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Qalus_WineHarvest = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Qalus_WineHarvest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_Valenqir_TorasTruthers = true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Studied == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Studied == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Studied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Studied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "After I'd left for university, my friend had worked his w..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Studied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Studied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "After I'd left to join the military, my friend had worked..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "After I'd left for Monqiz, my friend had worked his way u..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelBoss == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelBoss == true"*)
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelBoss == true)"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelBoss == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "Pabel's expression didn't change."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelBoss == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "Pabel smiled."*)

### Węzeł `[211]`
Mówca: **Narrator**
> "Pabel smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Pabel Adria: ""Likewise. I'm happy to serve you.""*)

### Węzeł `[212]`
Mówca: **Narrator**
> "Pabel's expression didn't change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Pabel Adria: ""Likewise. I'm happy to serve you.""*)

### Węzeł `[213]`
Mówca: **Pabel Adria**
> ""Likewise. I'm happy to serve you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel += 1"*)

### Węzeł `[214]`
Mówca: **Pabel Adria**
> ""Certainly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""Sorry, I couldn't resist. How are you, Pabel?""*)
  - -> `[27]` (*Player_Romus: ""I mean it.""*)
  - -> `[193]` (*Player_Romus: ""What's so funny?""*)

### Węzeł `[215]`
Mówca: **Pabel Adria**
> ""Please pardon my impudence. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "He briskly drew back the heavy velvet curtains. Sunshine ..."*)

### Węzeł `[216]`
Mówca: **Narrator**
> "Pabel chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Pabel Adria: ""You had better get used to it. Everyone answers to you n..."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "He drew back the heavy velvet curtains. Sunshine flooded the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Pabel Adria: ""Romus Toras, King of Rizia. You've come a long way since..."*)

### Węzeł `[218]`
Mówca: **Pabel Adria**
> ""Romus Toras, King of Rizia. You've come a long way since we were kids.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player_Romus: ""Not really. All I had to do to get this job was wait for..."*)
  - -> `[220]` (*Player_Romus: ""So have you, Mr. Chief Butler.""*)
  - -> `[221]` (*Player_Romus: ""And yet here I am in the exact same palace.""*)
  - -> `[222]` (*Player_Romus: ""It feels natural, somehow. Like I was born to do this.""*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not really. All I had to do to get this job was wait for Father to die.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "Pabel's eyes flooded with compassion."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So have you, Mr. Chief Butler.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Pabel Adria: ""Not bad for the groundskeeper's son. Of course, it helpe..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And yet here I am in the exact same palace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Pabel Adria: ""But now you've got me as your butler. A significant upgr..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It feels natural, somehow. Like I was born to do this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Pabel Adria: ""You were.""*)

### Węzeł `[223]`
Mówca: **Pabel Adria**
> ""Not bad for the groundskeeper's son. Of course, it helped to have friends in high places.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "He looked me in the eyes."*)

### Węzeł `[224]`
Mówca: **Narrator**
> "Pabel's eyes flooded with compassion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad == true)"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Pabel Adria: ""I know you two didn't get along by the end. But it's nev..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Pabel Adria: ""I'm so sorry. This must be hard for you.""*)

### Węzeł `[228]`
Mówca: **Pabel Adria**
> ""I know you two didn't get along by the end. But it's never easy to lose a parent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player_Romus: ""Thank you for your concern.""*)
  - -> `[233]` (*Player_Romus: ""It's complicated. I don't know what I should be feeling ..."*)
  - -> `[234]` (*Player_Romus: ""To be honest, I'm not that bothered.""*)
  - -> `[235]` (*Player_Romus: ""It must have been even harder being his butler.""*)

### Węzeł `[229]`
Mówca: **Pabel Adria**
> ""I'm so sorry. This must be hard for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player_Romus: ""Thank you for your concern.""*)
  - -> `[233]` (*Player_Romus: ""It's complicated. I don't know what I should be feeling ..."*)
  - -> `[234]` (*Player_Romus: ""To be honest, I'm not that bothered.""*)
  - -> `[235]` (*Player_Romus: ""It must have been even harder being his butler.""*)

### Węzeł `[230]`
Mówca: **Pabel Adria**
> ""But now you've got me as your butler. A significant upgrade from your man in Monqiz, I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "He looked me in the eyes."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "He looked me in the eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for your concern.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Pabel Adria), `[229]` (Pabel Adria), `[248]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Pabel Adria: ""Anything I can do to make your life easier, I'm here.""*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's complicated. I don't know what I should be feeling right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Pabel Adria), `[229]` (Pabel Adria), `[248]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Pabel Adria: ""There's no 'should'. You feel what you feel.""*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be honest, I'm not that bothered.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Pabel Adria), `[229]` (Pabel Adria), `[248]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Pabel Adria: ""Well, I'm here to make your life easier. Let me know if ..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It must have been even harder being his butler.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Pabel Adria), `[229]` (Pabel Adria), `[248]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Something dark passed across Pabel's face."*)

### Węzeł `[236]`
Mówca: **Pabel Adria**
> ""There's no 'should'. You feel what you feel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "He opened the doors of my armoire and began pulling out i..."*)

### Węzeł `[237]`
Mówca: **Pabel Adria**
> ""Anything I can do to make your life easier, I'm here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "He opened the doors of my armoire and began pulling out i..."*)

### Węzeł `[238]`
Mówca: **Pabel Adria**
> ""Well, I'm here to make your life easier. Let me know if there's anything I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "He opened the doors of my armoire and began pulling out i..."*)

### Węzeł `[239]`
Mówca: **Narrator**
> "Something dark passed across Pabel's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Pabel Adria: ""He had his difficult moments. But I tried my best to mak..."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "He briskly drew back the heavy velvet curtains. Sunshine flooded the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Pabel Adria: ""I trust you slept well?""*)

### Węzeł `[241]`
Mówca: **Narrator**
> "He gave a brusque nod and drew back the heavy red velvet curtains. Sunshine flooded the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Pabel Adria: ""I trust you slept well?""*)

### Węzeł `[242]`
Mówca: **Pabel Adria**
> ""You were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "He looked me in the eyes."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "He opened the doors of my armoire and began pulling out items of clothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Pabel Adria: ""You have quite the packed schedule this morning. Why don..."*)

### Węzeł `[244]`
Mówca: **Pabel Adria**
> ""You have quite the packed schedule this morning. Why don't you eat breakfast with the girls while I get your outfit ready?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: ""Won't you eat with us?""*)
  - -> `[251]` (*Player_Romus: ""I can pick out my own clothes, Pabel.""*)
  - -> `[252]` (*Player_Romus: ""That sounds great.""*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad == true)"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Pabel Adria: ""Forgive me if I'm overstepping, but how are you doing? I..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Pabel Adria: ""Forgive me if I'm overstepping, but how are you doing? L..."*)

### Węzeł `[248]`
Mówca: **Pabel Adria**
> ""Forgive me if I'm overstepping, but how are you doing? I know you and your father didn't get along by the end. But it's never easy to lose a parent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player_Romus: ""Thank you for your concern.""*)
  - -> `[233]` (*Player_Romus: ""It's complicated. I don't know what I should be feeling ..."*)
  - -> `[234]` (*Player_Romus: ""To be honest, I'm not that bothered.""*)
  - -> `[235]` (*Player_Romus: ""It must have been even harder being his butler.""*)

### Węzeł `[249]`
Mówca: **Pabel Adria**
> ""Forgive me if I'm overstepping, but how are you doing? Losing your father must have been hard for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player_Romus: ""Thank you for your concern.""*)
  - -> `[233]` (*Player_Romus: ""It's complicated. I don't know what I should be feeling ..."*)
  - -> `[234]` (*Player_Romus: ""To be honest, I'm not that bothered.""*)
  - -> `[235]` (*Player_Romus: ""It must have been even harder being his butler.""*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Won't you eat with us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "Pabel shook his head."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can pick out my own clothes, Pabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Pabel Adria: ""Can you? Remember when your father brought the whole fam..."*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds great.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Pabel Adria: ""Queen Mother Estela and Princess Vina must be waiting al..."*)

### Węzeł `[253]`
Mówca: **Pabel Adria**
> ""Can you? Remember when your father brought the whole family to meet the Baron of Soradis and you insisted on wearing shorts? *Shorts*!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Pabel Adria: ""Don't worry, Your Majesty. I'll make sure you're the bes..."*)

### Węzeł `[254]`
Mówca: **Pabel Adria**
> ""Queen Mother Estela and Princess Vina must be waiting already. You should get a move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Pabel Adria: ""Don't worry, Your Majesty. I'll make sure you're the bes..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 1; RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Pabel Adria: ""Please pardon my impudence. It won't happen again.""*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "He gave a brusque nod and drew back the heavy red velvet ..."*)

### Węzeł `[257]`
Mówca: **Pabel Adria**
> ""I trust you slept well?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player_Romus: ""No, not really. I was thinking about Father.""*)
  - -> `[262]` (*Player_Romus: ""Yes, fine. Thank you.""*)

### Węzeł `[258]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Pabel Adria: ""I ate in the servants' quarters before coming here. Ther..."*)

### Węzeł `[259]`
Mówca: **Pabel Adria**
> ""I ate in the servants' quarters before coming here. There are hierarchies to be observed now that you're king, I'm afraid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Player_Romus: ""We're still friends, though, right?""*)
  - -> `[293]` (*Player_Romus: ""Hierarchies are meant to be broken. You're the head butl..."*)
  - -> `[294]` (*Player_Romus: ""Can you at least stop calling me 'Your Majesty'? We don'..."*)

### Węzeł `[260]`
Mówca: **Pabel Adria**
> ""Don't worry, Your Majesty. I'll make sure you're the best-dressed king in Rizian history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player_Romus: ""We're still friends, right?""*)
  - -> `[297]` (*Player_Romus: ""Please. Can you call me Romus?""*)
  - -> `[321]` (*Player_Romus: ""I expect nothing less.""*)
  - -> `[402]` (*Player_Romus: ""Even more fashionable than King Darius the Debonair?""*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're still friends, though, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Pabel Adria: ""Always. Bi mare volu, un oxit solu.""*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, fine. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Pabel Adria: ""I'm glad.""*)

### Węzeł `[263]`
Mówca: **Narrator**
> "He briskly drew back the heavy velvet curtains. Sunshine flooded the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Pabel Adria: ""I trust you slept well?""*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelBoss == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelBoss == true"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelBoss == true)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelBoss == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Pabel nodded."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelBoss == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Pabel smiled."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "Pabel smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Pabel Adria: ""Indeed. You've got a packed schedule ahead of you today.""*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "He briskly drew back the heavy velvet curtains. Sunshine ..."*)

### Węzeł `[269]`
Mówca: **Pabel Adria**
> ""He had his difficult moments. But I tried my best to make him comfortable in his last days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "He opened the doors of my armoire and began pulling out i..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, not really. I was thinking about Father.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[257]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "Compassion appeared in his eyes."*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He can't have been an easy man to serve. Especially towards the end.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "Something dark passed across Pabel's face."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad == true)"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player_Romus: ""Good riddance to the bastard.""*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[275]`
Mówca: **Pabel Adria**
> ""My condolences, Your Majesty. This must not be an easy time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[276]` (*Player_Romus: ""I have no need for your pity.""*)
  - -> `[271]` (*Player_Romus: ""He can't have been an easy man to serve. Especially towa..."*)
  - -> `[278]` (*Player_Romus: ""Thank you, Pabel. That means a lot.""*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no need for your pity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "Pabel took a step backwards."*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good riddance to the bastard.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Kontekst wejściowy (poprzednik):** `[275]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Pabel looked mildly shocked."*)

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Pabel. That means a lot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Pabel Adria: ""Just let me know if there's anything I can do.""*)

### Węzeł `[279]`
Mówca: **Narrator**
> "Compassion appeared in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Pabel Adria: ""My condolences, Your Majesty. This must not be an easy t..."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "Pabel looked mildly shocked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[281]`
Mówca: **Narrator**
> "Something dark passed across Pabel's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Pabel Adria: ""He had his difficult moments. But I tried my best to mak..."*)

### Węzeł `[282]`
Mówca: **Pabel Adria**
> ""He had his difficult moments. But I tried my best to make him comfortable in his last days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel += 1"*)

### Węzeł `[283]`
Mówca: **Pabel Adria**
> ""Just let me know if there's anything I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel += 1"*)

### Węzeł `[284]`
Mówca: **Narrator**
> "Pabel took a step backwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Pabel Adria: ""Excuse me. I only wanted to express my sympathies.""*)

### Węzeł `[285]`
Mówca: **Pabel Adria**
> ""Excuse me. I only wanted to express my sympathies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "He moved over to my armoire and began pulling out items o..."*)

### Węzeł `[286]`
Mówca: **Pabel Adria**
> ""I know you two had your disagreements, but I wasn't aware it was that bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "He moved over to my armoire and began pulling out items o..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Pabel Adria: ""I know you two had your disagreements, but I wasn't awar..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Pabel Adria: ""I wasn't aware the two of you were at odds.""*)

### Węzeł `[290]`
Mówca: **Pabel Adria**
> ""I wasn't aware the two of you were at odds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "He moved over to my armoire and began pulling out items o..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "He moved over to my armoire and began pulling out items o..."*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're still friends, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Pabel Adria: ""Always. Bi mare volu, un oxit solu.""*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hierarchies are meant to be broken. You're the head butler, not a common scullery maid. I insist you join us next time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_BrokeTradition += 1; RiziaDLC.Rela..."*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can you at least stop calling me 'Your Majesty'? We don't need to be so formal with each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Pabel Adria: ""I can in private. In public, it would be seen as highly ..."*)

### Węzeł `[295]`
Mówca: **Pabel Adria**
> ""Always. Bi mare volu, un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "I recognized the slogan we'd made up as kids. "Two tides ..."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "I recognized the slogan we'd made up as kids. "Two tides rise, one sun sets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player_Romus: ""Thanks, Pabel. Let's catch up later.""*)
  - -> `[331]` (*Player_Romus: ""This will be fun. Just like old times.""*)
  - -> `[332]` (*Player_Romus: ""You always were a poetic type.""*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. Can you call me Romus?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Pabel Adria: ""I can in private. In public, it would be seen as highly ..."*)

### Węzeł `[298]`
Mówca: **Pabel Adria**
> ""I can in private. In public, it would be seen as highly disrespectful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty = false; RiziaDLCTex..."*)

### Węzeł `[299]`
Mówca: **Pabel Adria**
> ""I haven't forgotten, though. Bi mare volu, un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "I recognized the slogan we'd made up as kids. "Two tides ..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty = false; RiziaDLCText.PabelToPlayer = "Romus";`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] = false;
Variable["RiziaDLCText.PabelToPlayer"] ="Romus";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Pabel Adria: ""I haven't forgotten, though. Bi mare volu, un oxit solu.""*)

### Węzeł `[301]`
Mówca: **Narrator**
> "Still in my dressing gown, I headed downstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "In the eastern dining room, an enormous breakfast spread ..."*)

### Węzeł `[302]`
Mówca: **Narrator**
> "He moved over to my armoire and began pulling out items of clothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Pabel Adria: ""Why don't you join your family downstairs? I'll have you..."*)

### Węzeł `[303]`
Mówca: **Pabel Adria**
> ""I'm glad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "He moved over to my armoire and began pulling out items o..."*)

### Węzeł `[304]`
Mówca: **Pabel Adria**
> ""Why don't you join your family downstairs? I'll have your outfit ready by the time you're finished eating.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Player_Romus: ""Won't you eat with us?""*)
  - -> `[306]` (*Player_Romus: ""I can pick out my own clothes, Pabel.""*)
  - -> `[307]` (*Player_Romus: ""That sounds perfect.""*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Won't you eat with us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "Pabel shook his head."*)

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can pick out my own clothes, Pabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Pabel Adria: ""This is one of my royal duties, I'm afraid.""*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds perfect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Pabel Adria: ""Queen Mother Estela and Princess Vina must be waiting al..."*)

### Węzeł `[308]`
Mówca: **Narrator**
> "Pabel shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Pabel Adria: ""I ate in the servant's quarters before coming here.""*)

### Węzeł `[309]`
Mówca: **Pabel Adria**
> ""I ate in the servant's quarters before coming here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[389]` (*Player_Romus: ""I insist you join us at the table next time. You're the ..."*)
  - -> `[396]` (*Player_Romus: ""How rude. In the future, you will not take a bite before..."*)
  - -> `[316]` (*Player_Romus: ""Can you stop calling me 'Your Majesty'? We don't need to..."*)

### Węzeł `[310]`
Mówca: **Pabel Adria**
> ""This is one of my royal duties, I'm afraid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Pabel Adria: ""Don't worry, Your Majesty. I'll make sure you're the bes..."*)

### Węzeł `[311]`
Mówca: **Pabel Adria**
> ""Don't worry, Your Majesty. I'll make sure you're the best-dressed king in Rizian history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[316]` (*Player_Romus: ""Can you stop calling me 'Your Majesty'? We don't need to..."*)
  - -> `[329]` (*Player_Romus: ""I expect nothing less.""*)
  - -> `[393]` (*Player_Romus: ""Even more fashionable than King Darius the Debonair?""*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Player_Romus: ""We're still friends, right?""*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're still friends, right?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Kontekst wejściowy (poprzednik):** `[309]` (Pabel Adria), `[311]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel >= 0"*)

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can you stop calling me 'Your Majesty'? We don't need to be so formal with each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Pabel Adria), `[311]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaD..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaD..."*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true && Rizi..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Pabel Adria: ""I can in private. In public, it would be seen as highly ..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Pabel Adria: ""Sorry, Your Majesty. But that would be seen as highly di..."*)

### Węzeł `[320]`
Mówca: **Pabel Adria**
> ""Queen Mother Estela and Princess Vina must be waiting already. You should get a move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Pabel Adria: ""Don't worry, Your Majesty. I'll make sure you're the bes..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expect nothing less.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Pabel Adria: ""I haven't forgotten. Bi mare volu, un oxit solu.""*)

### Węzeł `[322]`
Mówca: **Pabel Adria**
> ""I haven't forgotten. Bi mare volu, un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "I recognized the slogan we'd made up as kids. "Two tides ..."*)

### Węzeł `[323]`
Mówca: **Pabel Adria**
> ""Sorry, Your Majesty. But that would be seen as highly disrespectful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Pabel Adria: ""Enjoy your breakfast.""*)

### Węzeł `[324]`
Mówca: **Pabel Adria**
> ""Enjoy your breakfast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "Still in my dressing gown, I headed downstairs."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel >= 0"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel >= 0)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Pabel Adria: ""Always. Bi mare volu, un oxit solu.""*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Pabel Adria: ""Of course.""*)

### Węzeł `[328]`
Mówca: **Pabel Adria**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Pabel Adria: ""Enjoy your breakfast.""*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I expect nothing less.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Pabel Adria: ""Enjoy your breakfast.""*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, Pabel. Let's catch up later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Pabel Adria: ""Enjoy your breakfast.""*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This will be fun. Just like old times.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Pabel Adria: ""Enjoy your breakfast.""*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You always were a poetic type.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[296]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Pabel Adria: ""I'm just a humble servant. Enjoy your breakfast.""*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My grandmother Queen Lyza didn't get her wisdom from serving on her father's council.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Vina Toras), `[122]` (Vina Toras), `[123]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Vina Toras: ""That's not fair. She was already queen by the time she w..."*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Greatness is something you're born with, my daughter. You can't glean it off of others.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Vina Toras), `[121]` (Vina Toras), `[122]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Vina Toras: ""Queen Lyza herself would disagree. That's why she worked..."*)

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My grandmother's achievements weren't as noteworthy as everyone says. She just happened to be in the right place at the right time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Vina Toras), `[121]` (Vina Toras), `[122]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Vina Toras: ""That's what some people say, yes. But I've read all her ..."*)

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't have to worry about living up to anyone's legacy. You're great in your own right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Vina Toras), `[121]` (Vina Toras), `[122]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Vina Toras: ""That's very kind of you, Father. But Lyza was the most b..."*)

### Węzeł `[337]`
Mówca: **Vina Toras**
> ""That's not fair. She was already queen by the time she was my age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Estela Toras: ""That's true, sweetheart. But your father is the one wear..."*)

### Węzeł `[338]`
Mówca: **Vina Toras**
> ""Queen Lyza herself would disagree. That's why she worked so hard to improve educational opportunities for women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Estela Toras: ""Her Majesty loved women, yes. Except for the one her son..."*)

### Węzeł `[339]`
Mówca: **Vina Toras**
> ""That's what some people say, yes. But I've read all her essays. She was a true visionary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Estela Toras: ""I don't doubt it, my love. But your father is the one we..."*)

### Węzeł `[340]`
Mówca: **Vina Toras**
> ""That's very kind of you, Father. But Lyza was the most beloved queen in our history. Of course people will compare me to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Estela Toras: ""You're getting ahead of yourself, sweetheart. The crown ..."*)

### Węzeł `[341]`
Mówca: **Estela Toras**
> ""You're getting ahead of yourself, sweetheart. The crown is on your father's head right now, not yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "She looked at me sharply."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "She looked at me sharply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Estela Toras: ""And what your father needs is for your lovely little fac..."*)

### Węzeł `[343]`
Mówca: **Estela Toras**
> ""And what your father needs is for your lovely little face to be seen at balls and ribbon-cutting ceremonies, not hidden behind council doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Player_Romus: ""Your grandmother's right, Vina. As the princess, it's up..."*)
  - -> `[345]` (*Player_Romus: ""Now, Mother. We both know Vina is much more than a prett..."*)
  - -> `[346]` (*Player_Romus: ""That's an outdated image of a princess, isn't it? If Vin..."*)
  - -> `[347]` (*Player_Romus: ""It is true that you'll learn more about how the world wo..."*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your grandmother's right, Vina. As the princess, it's up to you to serve as the ultimate example of beauty and grace in this country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Vina Toras: ""Listen to both of you! I need to learn how to govern the..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, Mother. We both know Vina is much more than a pretty face.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Vina Toras: ""I do recognize my duty to represent Rizia in public. But..."*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's an outdated image of a princess, isn't it? If Vina wants to get involved in politics, I don't see why I shouldn't let her.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Vina Toras: ""It would mean the world to me, Father.""*)

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is true that you'll learn more about how the world works by being out in it, not by shadowing me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Vina Toras: ""Going to balls won't teach me how decrees are made, or h..."*)

### Węzeł `[348]`
Mówca: **Vina Toras**
> ""Listen to both of you! I need to learn how to govern the country, not just symbolize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Estela Toras: ""You want to spend the best years of your life cooped up ..."*)

### Węzeł `[349]`
Mówca: **Vina Toras**
> ""Going to balls won't teach me how decrees are made, or how to negotiate with foreign leaders. Only time served on the council will do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Estela Toras: ""You want to spend the best years of your life cooped up ..."*)

### Węzeł `[350]`
Mówca: **Vina Toras**
> ""I do recognize my duty to represent Rizia in public. But I need to learn how to govern the country, not just represent it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Estela Toras: ""You want to spend the best years of your life cooped up ..."*)

### Węzeł `[351]`
Mówca: **Estela Toras**
> ""You want to spend the best years of your life cooped up in that den of snakes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Estela Toras: ""The council isn't some wise, all-knowing entity. Everyon..."*)

### Węzeł `[352]`
Mówca: **Estela Toras**
> ""The council isn't some wise, all-knowing entity. Everyone on it is only looking after their own house and their own stature.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Estela Toras: ""And God help you if you get in the way of either of those.""*)

### Węzeł `[353]`
Mówca: **Estela Toras**
> ""And God help you if you get in the way of either of those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Player_Romus: ""My councilors represent many cumulative decades of exper..."*)
  - -> `[355]` (*Player_Romus: ""I have always found it odd that we entrust the country's..."*)
  - -> `[356]` (*Player_Romus: ""My father may have allowed his council to run roughshod ..."*)
  - -> `[358]` (*Player_Romus: ""That's enough, Mother. This is my decision to make.""*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My councilors represent many cumulative decades of experience. I would not discount their wisdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Estela Toras: ""Their 'wisdom' turned Pales into a bloodbath and sparked..."*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have always found it odd that we entrust the country's direction to a handful of privileged nobles.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 1"*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father may have allowed his council to run roughshod over him. I will not make that mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Vina Toras: ""If navigating the council's self-interests will be part ..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Vina Toras: ""If choosing when to ignore the council will be part of m..."*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's enough, Mother. This is my decision to make.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[353]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Estela Toras: ""I'm only trying to be helpful. But you're right, of cour..."*)

### Węzeł `[359]`
Mówca: **Estela Toras**
> ""I'm only trying to be helpful. But you're right, of course. Go on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "Vina looked at me with pleading eyes."*)

### Węzeł `[360]`
Mówca: **Estela Toras**
> ""Their 'wisdom' turned Pales into a bloodbath and sparked an uprising. It almost got you killed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Vina Toras: ""I don't know if the uprising was the council's fault. Fr..."*)

### Węzeł `[361]`
Mówca: **Narrator**
> "Vina looked at me with pleading eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player_Romus: ""All right, Vina. You can come to the meetings.""*)
  - -> `[128]` (*Player_Romus: ""Your grandmother's just jealous, Vina. You can join the ..."*)
  - -> `[129]` (*Player_Romus: ""You're not coming to council meetings, Vina. That's an o..."*)
  - -> `[127]` (*Player_Romus: ""Sorry, but your grandma's right. You'd get bored in thos..."*)

### Węzeł `[362]`
Mówca: **Vina Toras**
> ""If navigating the council's self-interests will be part of my future duties, I need to learn how to do that too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Vina Toras: ""I promise, it'll be like I'm not even there. And I'll st..."*)

### Węzeł `[363]`
Mówca: **Vina Toras**
> ""If choosing when to ignore the council will be part of my future duties, I need to learn how to do that too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Vina Toras: ""I promise, it'll be like I'm not even there. And I'll st..."*)

### Węzeł `[364]`
Mówca: **Vina Toras**
> ""And besides, if choosing when to ignore the council will be part of my future duties, I need to learn how to do that too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Vina Toras: ""I promise, it'll be like I'm not even there. And I'll st..."*)

### Węzeł `[365]`
Mówca: **Vina Toras**
> ""I promise, it'll be like I'm not even there. And I'll step out in public as much as I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "Vina looked at me with pleading eyes."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[367]`
Mówca: **Vina Toras**
> ""I don't know if the uprising was the council's fault. From what I've read, there were many factors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Vina Toras: ""And besides, if choosing when to ignore the council will..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Solitude", "R_Solitude_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Solitude","R_Solitude_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The morning after my coronation, I was woken up by a knoc..."*)

### Węzeł `[369]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Honestly, I wasn't even sure what I wanted to say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Estela Toras: ""You certainly said something.""*)

### Węzeł `[370]`
Mówca: **Estela Toras**
> ""But don't let my nattering on keep you from eating. A king needs energy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "She handed me a rizetta, the traditional rice and quince ..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "He briskly drew back the heavy velvet curtains. Sunshine ..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad"*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad)"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Estela Toras: ""I hope it was an apology. He was so cruel to everyone at..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Estela Toras: ""You boys did always have your secrets.""*)

### Węzeł `[375]`
Mówca: **Estela Toras**
> ""I hope it was an apology. He was so cruel to everyone at the end. Not at all like the man I married.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Estela Toras: ""It's a pity he didn't live to preside over my homeland's..."*)

### Węzeł `[376]`
Mówca: **Estela Toras**
> ""You boys did always have your secrets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Estela Toras: ""It's a pity he didn't live to preside over my homeland's..."*)

### Węzeł `[377]`
Mówca: **Estela Toras**
> ""It's a pity he didn't live to preside over my homeland's big return to Rizia. But soon you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player_Romus: ""Zille will be ours again. And so will Pales.""*)
  - -> `[177]` (*Player_Romus: ""Just two years to go until the treaty expires.""*)
  - -> `[178]` (*Player_Romus: ""I'm already planning the reunification ceremony.""*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player_Romus: ""Halaita. If it is said, so it is and shall be.""*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[381]`
Mówca: **Estela Toras**
> ""I'm looking forward to that day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Estela Toras: ""But don't let my nattering on keep you from eating. A ki..."*)

### Węzeł `[382]`
Mówca: **Estela Toras**
> ""I don't doubt it, my love. But your father is the one wearing the crown now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "She looked at me sharply."*)

### Węzeł `[383]`
Mówca: **Estela Toras**
> ""That's true, sweetheart. But your father is the one wearing the crown right now. Not Lyza, and not you -- yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "She looked at me sharply."*)

### Węzeł `[384]`
Mówca: **Estela Toras**
> ""Her Majesty loved women, yes. Except for the one her son married.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Estela Toras: ""In any event, sweetheart, your father is the one wearing..."*)

### Węzeł `[385]`
Mówca: **Estela Toras**
> ""In any event, sweetheart, your father is the one wearing the crown right now. Not Lyza, and not you -- yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "She looked at me sharply."*)

### Węzeł `[386]`
Mówca: **Vina Toras**
> ""It would mean the world to me, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Estela Toras: ""You want to spend the best years of your life cooped up ..."*)

### Węzeł `[387]`
Mówca: **Estela Toras**
> ""Because I didn't want you holed up in there all the time. A grandmother's got to see her granddaughter every so often, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Vina eagerly took a plate and started piling it high with..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "Still in my dressing gown, I headed downstairs."*)

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I insist you join us at the table next time. You're the head butler, not a common scullery maid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "He smiled."*)

### Węzeł `[390]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Pabel Adria: ""If the King commands it, I can hardly refuse.""*)

### Węzeł `[391]`
Mówca: **Pabel Adria**
> ""If the King commands it, I can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel += 1"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Pabel Adria: ""Enjoy your breakfast.""*)

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even more fashionable than King Darius the Debonair?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Pabel Adria: ""I wasn't aware such a monarch existed. But yes, I'll do ..."*)

### Węzeł `[395]`
Mówca: **Pabel Adria**
> ""I wasn't aware such a monarch existed. But yes, I'll do my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Pabel Adria: ""Enjoy your breakfast.""*)

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How rude. In the future, you will not take a bite before your King does.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Narrator: "His expression stayed neutral."*)

### Węzeł `[397]`
Mówca: **Narrator**
> "His expression stayed neutral."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Pabel Adria: ""Of course, Your Majesty. I'll see to it.""*)

### Węzeł `[398]`
Mówca: **Pabel Adria**
> ""Of course, Your Majesty. I'll see to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 1"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Pabel Adria: ""Enjoy your breakfast.""*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_BrokeTradition += 1; RiziaDLC.Relations_Pabel += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] + 1;
Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Pabel Adria: ""If the King commands it, I can hardly refuse.""*)

### Węzeł `[401]`
Mówca: **Pabel Adria**
> ""If the King commands it, I can hardly refuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Pabel Adria: ""I haven't forgotten. Bi mare volu, un oxit solu.""*)

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even more fashionable than King Darius the Debonair?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Narrator: "He grinned."*)

### Węzeł `[403]`
Mówca: **Narrator**
> "He grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Pabel Adria: ""I'll do my best.""*)

### Węzeł `[404]`
Mówca: **Pabel Adria**
> ""I'll do my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Pabel Adria: ""I haven't forgotten. Bi mare volu, un oxit solu.""*)

### Węzeł `[405]`
Mówca: **Estela Toras**
> ""You certainly said something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Her face grew stern."*)

### Węzeł `[406]`
Mówca: **Narrator**
> "She looked skeptical for a second, then assumed a reverent position."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Estela Toras: ""Halaita indeed.""*)

### Węzeł `[407]`
Mówca: **Pabel Adria**
> ""I'm just a humble servant. Enjoy your breakfast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel += 2"*)

### Węzeł `[408]`
Mówca: **Pabel Adria**
> ""Enjoy your breakfast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel += 2"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_Valenqir_TorasTruthers = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_Valenqir_TorasTruthers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn01_PorteDrazon_DelegateAllegi..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn01_PorteDrazon_DelegateAllegiance = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn01_PorteDrazon_DelegateAllegiance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "She looked skeptical for a second, then assumed a reveren..."*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Debating their daughter’s fate over tea, toast and Rizettas", "Palace Rezna", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Debating their daughter’s fate over tea, toast and Rizettas","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Solitude", "R_Solitude_Loop");"*)
