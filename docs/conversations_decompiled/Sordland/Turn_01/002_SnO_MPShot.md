# Sordland/Turn01/SnO_MPShot

- **ID konwersacji:** `2`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/002_SnO_MPShot.md`
- **Liczba węzłów dialogowych:** 96
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[38]** Lucian Galade
- **[44]** Lileas Graf
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Reform_Reformist_Intention`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameSupport.News_Turn01_LT_Murder`
- `GameCondition.Turn01_SnO_MPShot`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 6
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[5]` (Lileas Graf): `Variable["GameCondition.Turn01_SnO_MPShot"] = true;`
- Węzeł `[92]` (Lileas Graf): `Variable["BaseGameSupport.News_Turn01_LT_Murder"] = true;`
- Węzeł `[95]` (Lileas Graf): `End();`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lileas Graf)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The mood in the situation room was gloomy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "My cabinet members were gathered to discuss the shooting outside the Palace. Lileas presented the initial report."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[5]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: GameCondition.Turn01_SnO_MPShot = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn01_SnO_MPShot"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[6]`
Mówca: **Lileas Graf**
> "“I agree. We are re-evaluating our security measures. However, the recession has affected my ministry negatively.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[7]`
Mówca: **Iosef Lancea**
> "“Only if we stay vigilant as a country... We must think about the upcoming budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[31]`
  - -> `[37]`
  - -> `[40]`
  - -> `[43]`

### Węzeł `[8]`
Mówca: **Nia Morgna**
> "“Freedom of expression is part of our constitution. We can't have anyone, let alone an MP, shot for voicing different opinions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[22]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“But why Bernard Circas?”"]** — Mówca: **Player**
> "“But why Bernard Circas?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[10]`
Mówca: **Lileas Graf**
> "“Bernard Circas was shot dead at 9:03 pm in front of the palace gates. He was an elected independent member of Assembly and as you know, a famous communist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“What were the motivations of such a horrid act?”"]** — Mówca: **Player**
> "“What were the motivations behind such a horrid act?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[12]`
Mówca: **Lucian Galade**
> "“We should refrain from making the issue a political one from the start. It will only add fuel to the fire.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[70]`
  - -> `[63]`

### Węzeł `[13]`
Mówca: **Lileas Graf**
> "“Regardless, a full investigation into all involved parties is under way. We will find the subversives and punish them soon enough, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[14]`
Mówca: **Narrator**
> "The meeting concluded and the ministers left the room with concerned looks. It was hard to anticipate what would happen next."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[15]`
Mówca: **Lileas Graf**
> "“The guards at the scene were fifty meters away and immediately took action by responding and killing the assailant who was identified as a member of the nationalist organization, Young Sords.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“An MP shot near the Palace. That is absolutely unacceptable.”"]** — Mówca: **Player**
> "“An MP shot near the Palace. That is absolutely unacceptable.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[17]`
Mówca: **Lileas Graf**
> "“Our investigators are suspecting a political assassination since the Young Sords have been threatening the communists for some time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Lileas Graf**
> "“He has always been an infamous figure. His poems had a large impact in the spread of communist ideas in Sordland. Many considered him a threat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
> "“This may well create a dangerous atmosphere where the left versus right political violence of the 1920s could spark once again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“I fully agree. We should protect freedom of speech.”"]** — Mówca: **Player**
> "“I fully agree. We should protect freedom of speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“The Malenyevist ideology that the Red Youth promotes poses threats to our country too. We should be cautious.”"]** — Mówca: **Player**
> "“The Malenyevist ideology that the Red Youth promotes poses threats to our country too. We should be cautious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“The nationalist Young Sords have overstepped, and they must face consequences for such an extreme action.”"]** — Mówca: **Player**
> "“The nationalist Young Sords have overstepped, and they must face consequences for such an extreme action.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[23]`
Mówca: **Petr Vectern**
> "“A return to those days would be devastating. The coups are the reason why our country stagnated for a decade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Nia Morgna, the Minister of Justice, sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[25]`
Mówca: **Nia Morgna**
> "“Our laws do, and for good reason. Silencing voices only results in fear and stagnation inside society.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Several police cars rushed past the Maroon Palace and everyone went silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[27]`
Mówca: **Iosef Lancea**
> "“All due respect, ma'am, but we shouldn't be quick to jump to conclusions before a full investigation has been conducted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[28]`
Mówca: **Lileas Graf**
> "“Agreed. We are always watchful of internal threats, like the banned Communist Party members who support a similar agenda as the Red Youth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[29]`
Mówca: **Iosef Lancea**
> "“Don't be stupid, woman. These organizations speak against the state. The Labor Union of Sordland is also in the same boat. I wouldn't be surprised if United Contana had a hand in supporting all of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[30]`
Mówca: **Lileas Graf**
> "“I hear your concerns, our police do their best to uphold the rights of our citizens. We will prevent such an act from happening again by making sure our security measures are re-evaluated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“I agree. Internal stability must be maintained. Our security funding might need to be increased.”"]** — Mówca: **Player**
> "“I agree. Internal stability must be maintained. Our security funding might need to be increased.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“We should not lose sight of our real political goals, like the constitutional reforms.”"]** — Mówca: **Player**
> "“We should not lose sight of our real political goals, like the constitutional reforms.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“It is too soon to jump to conclusions. Reckless acts will have dire consequences.”"]** — Mówca: **Player**
> "“It is too soon to jump to conclusions. Reckless acts will have dire consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Lucian Galade**
> "“Agreed. We need to be patient until we have the full picture.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> "“I am sure the Minister of Interior has already taken the necessary precautions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[36]`
Mówca: **Lucian Galade**
> "“Agreed, these matters shouldn't distract us from what the people want us to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[37]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reformist_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[39]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reformist_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[40]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Dictator_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[42]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Dictator_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Any threat to our power must be dealt with as soon as possible.”"]** — Mówca: **Player**
> "“Any threat to our power must be dealt with as soon as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
> "“Any direct attack against the government and our people is a serious concern but we don't know enough to act on yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[48]`
Mówca: **Lucian Galade**
> "“It seems that the tensions between the communists and nationalists will escalate further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Nia Morgna**
> "“It will be very difficult to pass any meaningful change if there is chaos in the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[76]`
  - -> `[78]`
  - -> `[85]`

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“You can be assured that our police units and intelligence units are on increased threat condition. Nobody should be able to move a finger against government officials.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[51]`
Mówca: **Petr Vectern**
> "“This will be it for today then. We will convene again soon. Thank you all, and keep us updated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Nia had always been one of the only members of the Justice Ministry truly deserving of the name. She had survived countless attacks on her character while fighting corruption within the ministry, and rising to power had only compounded her sense of moral duty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Minister of Defense Iosef Lancea grunted in disapproval. He towered over the rest of us in full military uniform, his many war medals conspicuously on display."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Minister of Defense Iosef Lancea grunted in disapproval. He towered over the rest of us in full military uniform, his many war medals conspicuously on display."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[55]`
Mówca: **Lileas Graf**
> "“Fortunately, no. You were simply in the wrong place at the wrong time. Our security forces have no reason to believe anybody has motivations to act against the President of Sordland for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“So I wasn't the target?”"]** — Mówca: **Player**
> "“So I wasn't the target?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[57]`
Mówca: **Nia Morgna**
> "“The Red Youth has condemned the killing but didn't stop there. They promised revenge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Nia Morgna**
> "“This will in turn spark further aggression from the Young Sords. The whole cycle started because Bernard Circas expressed his views. We can't simply look away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[59]`
Mówca: **Nia Morgna**
> "“This is not a simple overstep but an attack on our country. Murder for political opinions is a thing of the past. Our administration is building something new.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[60]`
Mówca: **Nia Morgna**
> "“These groups wouldn't resort to unconventional means if they were represented in our Assembly. The high electoral threshold and bans are making these factions extreme.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[61]`
Mówca: **Nia Morgna**
> "“Justice will be served and the rule of law will return to this country stronger than ever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“It is political, though, isn't it?”"]** — Mówca: **Player**
> "“It is political, though, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“It's early, but will we attend the funeral?”"]** — Mówca: **Player**
> "“It's early, but will we attend the funeral?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[64]`
Mówca: **Iosef Lancea**
> "“How can that be achieved when it is Bernard Circas we are talking about? He is *the* communist of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[65]`
Mówca: **Iosef Lancea**
> "“There aren't many sides. The state versus its enemies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[66]`
Mówca: **Nia Morgna**
> "“We had that before and know very well how it was.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[67]`
Mówca: **Iosef Lancea**
> "“Agreed, ma'am. Our Gendarmerie will also help boost security in the rural areas where possible. There might be more violence to come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Minister of Defense Iosef Lancea grunted in approval. He towered over the rest of us in full military uniform, his many war medals conspicuously on display."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[69]`
Mówca: **Lileas Graf**
> "“Agreed. We will reach out to the NFP and ask them to calm the situation with the Young Sords. The two groups have ties and Mr. Kibener sees reason, after all, which can't be said about the Young Sords at times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“You are right. We need to defuse the situation.”"]** — Mówca: **Player**
> "“You are right, we need to calm the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
> "“Yes, but we need to calm the country. If we take sides we could escalate the situation further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[72]`
Mówca: **Lucian Galade**
> "“Our government is capable to maintain security. Our job will be to reduce tensions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[73]`
Mówca: **Lucian Galade**
> "“In my opinion we should. The nuance here is to detach the person from the violent act.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“It is difficult, but an elected official has been shot. This is unacceptable for our new administration. We need to make sure we show our stance by condemning it at the funeral.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[75]`
Mówca: **Narrator**
> "Lucian took some notes after checking the latest newspapers and reports."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“We can't fix the recession if there isn't stability.”"]** — Mówca: **Player**
> "“We can't fix the recession if there isn't stability.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“We can't pass any constitutional reform in such an atmosphere.”"]** — Mówca: **Player**
> "“We can't pass any constitutional reform in such an atmosphere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“We will make it through this and deliver our promises.”"]** — Mówca: **Player**
> "“We will make it through this and deliver our promises.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Petr Vectern**
> "“You are right. We need to trust our ministers to stabilize the situation if it comes to it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[80]`
Mówca: **Petr Vectern**
> "“No use worrying about it now. Let's analyze the effects first. We will cross that bridge when we come to it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[81]`
Mówca: **Petr Vectern**
> "“Hell yes, President Rayne!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[82]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[84]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Intention == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[87]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Intention == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
**[WYBÓR GRACZA: "“Whoever is against the state is an enemy.”"]** — Mówca: **Player**
> "“Whoever is against the state is an enemy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Iosef Lancea**
> "“We will prevail.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Petr Vectern**
> "“We are here to stay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[91]`
Mówca: **Petr Vectern**
> "“I'll do my best to help coordinate the administrative tasks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[92]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_LT_Murder = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_LT_Murder"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[93]`
Mówca: **Narrator**
> "She spat the last word out with some distaste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[94]`
Mówca: **Lileas Graf**
> ""The president and his family were unharmed, praise God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[11]`
  - -> `[9]`
  - -> `[56]`

### Węzeł `[95]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
