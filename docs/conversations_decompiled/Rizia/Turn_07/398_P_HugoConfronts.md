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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 6

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[9]` (Paskal Beniwoll): `AddConversant("Hugo Toras");`
- Węzeł `[88]` (Paskal Beniwoll): `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] = true; Variable["RiziaDLCSupport.News_Floating...`
- Węzeł `[164]` (Paskal Beniwoll): `End();`
- Węzeł `[170]` (Paskal Beniwoll): `EnableCollectionItem("CollectionItem_IzaKey");`
- Węzeł `[171]` (Paskal Beniwoll): `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");`
- Węzeł `[172]` (Paskal Beniwoll): `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "After receiving the news of his son's arrest, Uncle Hugo was on his way to talk to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Narrator**
> "If he were to openly go against me, I'd have a big problem with my entire house. I thought about each scenario in my head and tried to devise a plan."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Thoughts were running through my mind as I paced back and forth in my chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Suddenly, there was a knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I granted Hugo permission to enter, and he walked in. He seemed more sad than angry -- something that took me off guard."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[10]`
Mówca: **Narrator**
> "He bowed in front of me, lower and longer than he'd normally go for."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[14]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Deposed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Deposed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Deposed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Deposed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Deposed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Grand Vizier. Thank you for coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Uncle Hugo. I was expecting you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can rise, uncle. There is no need for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Romus_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""Romus, my king. May I speak freely?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`
  - -> `[21]`
  - -> `[22]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You always have, Hugo. Speak your mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know why you're here. Just be careful about your choice of words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Hugo Toras**
> ""It's about my son...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[24]`
Mówca: **Hugo Toras**
> ""Of course you do. It's about my son...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[25]`
Mówca: **Hugo Toras**
> ""About your decision to remove him as the Duke of Iza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Hugo leaned forward slightly, his hands clasped together, choosing his words carefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""I understand that he was not popular in the city. King Valero himself had reservations about his readiness to become Duke. Yet...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[28]`
  - -> `[29]`
  - -> `[30]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a decision not made lightly, Uncle. The entire population was demanding his removal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His actions left me no choice, Uncle. He was endangering the stability of our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yet what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Hugo's expression remained unchanged, but there was a flicker of sadness in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Hugo Toras**
> ""I understand the weight of the crown and the decisions it demands. But he is my son, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""He is my son, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""And I... I was not consulted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "His demeanor made me feel uncomfortable. I couldn't meet his gaze. I had to look away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I value your counsel, Hugo, more than you know. But some decisions must be made swiftly, to protect the realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand what it looks like, Hugo. But Rico failed at his job. I wouldn't do anything to hurt House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were not consulted precisely because of this. He is your son and emotions would have risen just like they're doing right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's done is done. You should learn to accept it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""You are right... I wouldn't question your judgment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""I accepted it already. I wouldn't question your judgment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""I have served this family and this kingdom all my life, Romus. My loyalty has never wavered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Hugo Toras**
> ""Indeed, and I wouldn't question your judgment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[44]`
Mówca: **Hugo Toras**
> ""I know... And I wouldn't question your judgment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""But as a father yourself, you must understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`
  - -> `[48]`
  - -> `[49]`
  - -> `[50]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not doubt your loyalty, nor do I take your sacrifices for granted. Your son's removal was not a punishment but a necessity. For him, for you, for all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your loyalty and service to our family and kingdom have never been in question. I am open to discussing how we might address this situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand your pain, uncle. But you must let it go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me. Him being the Duke of Iza was more dangerous to his life and our family's reputation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come now, uncle. Rico lost a job which he was unsuited for anyway. He'll survive this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""I appreciate your willingness to consider a path to redemption for my son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""I do not question your motives, Romus. But I nonetheless believe I was owed a consultation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""However, the loss of his position has... repercussions. For his future and for the name of our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""Indeed, I will. But I nonetheless believe I was owed a consultation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""Yes. But I nonetheless believe I was owed a consultation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Hugo Toras**
> ""And the loss of his position has... repercussions. For his future and for the name of our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""Some form of compensation could ease this transition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[59]`
  - -> `[61]`
  - -> `[62]`

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""The loss of his position has... repercussions. For his future and for the name of our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your feelings are justified, Hugo. In the haste of the moment, I overlooked the personal ramifications. For that, I offer my regret. But that's all I can offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What amends do you seek? Tell me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. You seek a salve for the wound this has caused our lineage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Uncle. I cannot offer anything. Rico must face the consequences for his actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""Not as a challenge to your authority, but as a balm for our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""I'm just asking for something in return. A role, an estate, something to maintain the dignity of my son and provide a path forward for him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Hugo took a deep breath, his posture relaxing ever so slightly, yet there was an underlying current of disappointment in his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""Then I shall stand by your decision, as I have always stood by you and your father before you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""My loyalty to the crown and to you remains unshaken. You are my monarch, and my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""I understand you cannot offer him a title right after revoking it. But please consider offering him a job in the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""How about he works for Duchess Azaro? As Chief of the Porte Drazon Police Department?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[70]`
  - -> `[161]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. I am definitely not going to trust Rico with the security of our capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So he can escalate tensions right at my doorstep as well? No. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure. I can do that. I'll tell Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Taddeus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Taddeus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Taddeus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Taddeus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Titus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Titus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[79]`
Mówca: **Hugo Toras**
> ""What about assigning him to serve under General Azaro? As Chief of the Porte Drazon Police Department?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[70]`
  - -> `[82]`

### Węzeł `[80]`
Mówca: **Hugo Toras**
> ""What about assigning him to serve under Captain Gordion? As Chief of the Porte Drazon Police Department?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[70]`
  - -> `[81]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure. I can do that. I'll tell Titus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure. I can do that. I'll tell General Taddeus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[83]`
Mówca: **Narrator**
> "He extended his hand to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`
  - -> `[86]`
  - -> `[181]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "We shook hands. Hugo looked at our hands for a moment before placing his own atop mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "Spread your arms."]** — Mówca: **Player_Romus_Italic**
> "I spread my arms and we hugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All shall be well, uncle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""For the kingdom, and for our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_PoliceChief_PorteDrazon = true;
RiziaDLCSupport.News_Floating_RH_RicoToras_ChiefOfPolice = true;
RiziaDLCSupport.News_Floating_V_RicoToras_ChiefOfPolice = true;
RiziaDLCSupport.Journal_Floating_Decision_RicoToras_ChiefOfPolice = true;
EnableCodexEntry("Characters_Family_RicoToras_ChiefOfPolice");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] = true;
Variable["RiziaDLCSupport.News_Floating_RH_RicoToras_ChiefOfPolice"] = true;
Variable["RiziaDLCSupport.News_Floating_V_RicoToras_ChiefOfPolice"] = true;
Variable["RiziaDLCSupport.Journal_Floating_Decision_RicoToras_ChiefOfPolice"] = true;
EnableCodexEntry("Characters_Family_RicoToras_ChiefOfPolice");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""Thank you, Romus. I am heartened by your understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Narrator**
> "Hugo's expression softened slightly, a sign of relief mixed with the residual weight of the situation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Hugo Toras**
> ""My son’s actions notwithstanding, I believe in his capacity for growth and redemption. I am committed to guiding him on this path, for the sake of our family and Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Narrator**
> "He extended his hand to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[84]`
  - -> `[85]`
  - -> `[181]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I value your fidelity, Hugo. I'm glad we have this mutual understanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[94]`
Mówca: **Hugo Toras**
> ""Very well. I shall return to my duties now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Narrator**
> "As Hugo exited, I was left to ponder the intricate balance of ruling, where the lines between kinship and kingship blurred."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Narrator**
> "I stood up and prepared for my next meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[97]`
Mówca: **Narrator**
> "Hugo leaned forward slightly, his hands clasped together. His voice trembled with emotion when he spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Hugo Toras**
> ""Romus, how could this have happened? My son, Rico, involved in the Zille bombing? Treason against his own country?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Narrator**
> "Realizing he was losing the volume of his voice, he stopped himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Hugo Toras**
> ""Excuse me, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[101]`
  - -> `[102]`
  - -> `[103]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's okay, Hugo. I understand that it's painful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know you are angry. But it had to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "Wait for him to continue."]** — Mówca: **Player_Romus_Italic**
> "I waited for him to recollect himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I also didn't want to believe it. But it's true. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
Mówca: **Hugo Toras**
> ""Romus, I come before you in the deepest humility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
Mówca: **Hugo Toras**
> ""Right now, my anger is limited to Rico.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Hugo shook his head, his grief etched deep into the lines of his face. I hadn't seen him this sad since my father's funeral."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[108]`
Mówca: **Hugo Toras**
> ""The actions of my son... I cannot fathom what led Rico to such darkness. The bombing, the scandal over Zille's return... It's a stain upon our House.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""I stand here, not only as your Grand Vizier but as a father disgraced, to beg your forgiveness for the turmoil he has wrought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`
  - -> `[112]`
  - -> `[114]`

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rico's actions were indeed treachery against Rizia. But the guilt is his to bear, not yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a tragedy that one of our own was involved. The repercussions have been severe, and we all must bear a responsibility for letting this take place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You need not ask for forgiveness, Uncle. Rico is already paying for his own actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May the Divine forgive you and your son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I accept your apologies and grant you a pardon. You are forgiven.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""As his father, the onus falls upon me. I failed in guiding him, in instilling the values of our lineage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respect that you're taking the responsibility upon yourself, Uncle. But what's done is already done, and you are not to blame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""For that, I must ask for your pardon, for my oversight, for any taint his actions have brought upon your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your integrity and loyalty have never been in question, Hugo. The heart of a father cannot always steer the will of a son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot blame yourself for this. You couldn't have done anything about it. We must now look to the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Hugo Toras**
> ""You are right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Hugo Toras**
> ""But... He is still my son, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Hugo Toras**
> ""I understand the need for justice but is there no room for mercy for him? For a chance at redemption?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[129]`
  - -> `[131]`
  - -> `[130]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He didn't have any mercy when he orchestrated the bombing that not only took lives but also our land. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[128]`
Mówca: **Hugo Toras**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your feelings are justified, Hugo. But you are being emotional. Rico is now an enemy of the state. I offer my regret. But that's all I can offer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Uncle. I cannot offer anything. Rico must face the consequences for his actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I feel your pain, Uncle. But I don't know what I can do about it now. I promise I'll try my best to mend our wounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Hugo Toras**
> ""I do not ask for exoneration, only that his life be spared.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Hugo Toras**
> ""Let him live, even if in exile or imprisonment and don't send him to Wehlen. God knows what they'll do to him there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Hugo Toras**
> ""Just let him have a chance to atone, in whatever way remains to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`
  - -> `[138]`
  - -> `[139]`

### Węzeł `[135]`
Mówca: **Narrator**
> "He lowered his head, hands still clasped. The plea was evident in his voice and posture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will consider your request, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. I will not do anything that will hurt his dignity further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot promise that, Uncle. Wehlen demands justice. There is nothing I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If President Smolak demands him to be sent in exchange for Zille, I'll have to take it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Hugo Toras**
> ""I understand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Hugo Toras**
> ""But should such a black mark be placed on my family, I am not sure I will be able to serve you in the same capacity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
Mówca: **Narrator**
> "Hugo took a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[143]`
Mówca: **Hugo Toras**
> ""Thank you, Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Hugo Toras**
> ""I will trust your wisdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[145]`
Mówca: **Hugo Toras**
> ""I appreciate your willingness to consider a path to redemption for my son. I am humbled before you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Narrator**
> "He bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[147]`
Mówca: **Narrator**
> "He extended his hand to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`
  - -> `[149]`
  - -> `[150]`
  - -> `[174]`

### Węzeł `[148]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Romus_Italic**
> "We shook hands. Hugo looked at our hands for a moment before placing his own atop mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[149]`
**[WYBÓR GRACZA: "Spread your arms."]** — Mówca: **Player_Romus_Italic**
> "I spread my arms and we hugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All shall be well, uncle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Hugo Toras**
> ""I'll see you later. I shall return to my duties now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""Thank you, Romus. For hearing my plea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Arrested == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[155]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Arrested == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[156]`
Mówca: **Narrator**
> "After receiving the news that I had deposed his son, Uncle Hugo was on his way to talk to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Iza_PowerTransfer_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Iza_PowerTransfer_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Iza_PowerTransfer_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He was only a temporary steward anyway. The people of Iza were demanding the return of their Duchess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_Security_Lucita == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Council_Security_Lucita == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[165]`
Mówca: **Narrator**
> "I looked at the oversized key on my desk. A symbolic Key to Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Iza_PowerTransfer_Angelica == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Iza_PowerTransfer_Angelica == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Iza_PowerTransfer_Angelica == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[169]`
Mówca: **Narrator**
> "The Sazons had sent it as a token of gratitude for reinstating their Duchess."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: EnableCollectionItem("CollectionItem_IzaKey");)*
- **Efekt (`userScript`):** `EnableCollectionItem("CollectionItem_IzaKey");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Negotiations", "R_Negotiations_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Negotiations","R_Negotiations_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[173]`
Mówca: **Hugo Toras**
> ""Your father -- my brother -- told me that Ricardus became Duke of Iza before he was ready. I see now that he was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. My father said Rico was not yet ready to rule... is this something you two often argued over?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Narrator**
> "His eyes once again turned sorrowful."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Hugo Toras**
> ""We quarreled about it on the very night King Valero passed, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Hugo Toras**
> ""Had I known it would be our last conversation -- and had I known what Ricardus was capable of -- I would never have raised my voice to my brother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_MurderInvest_SuspectHugo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. My father had doubts about Rico's readiness to rule... is this something you two often argued over?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Narrator**
> "His eyes once again turned sorrowful."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Hugo Toras**
> ""We quarreled about it on the very night King Valero passed, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Hugo Toras**
> ""Had I known it would be our last conversation, I would never have raised my voice to my brother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Hugo Toras**
> ""Now he's gone... I can't lose my son, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[189]`
Mówca: **Hugo Toras**
> ""Now he's gone... I can't lose my son, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
