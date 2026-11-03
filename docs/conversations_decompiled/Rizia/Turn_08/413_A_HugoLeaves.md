# Rizia/Turn 8/A_HugoLeaves

- **ID konwersacji:** `413`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/413_A_HugoLeaves.md`
- **Liczba węzłów dialogowych:** 120
- **Liczba wyborów gracza:** 26

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.Rico_Extradited`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.ZilleReturn_Success`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Council_GrandVizier_Empty`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Hugo_Resigned`
- `RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Arrest`
- `RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Extradite`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 11

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[78]` (Paskal Beniwoll): `Variable["RiziaDLC.Council_GrandVizier_Hugo"] = false; Variable["RiziaDLC.Council_GrandVizier_Emp...`
- Węzeł `[79]` (Paskal Beniwoll): `End();`
- Węzeł `[82]` (Paskal Beniwoll): `AddConversant("Hugo Toras");`
- Węzeł `[83]` (Paskal Beniwoll): `RemoveConversant("Hugo Toras");`
- Węzeł `[84]` (Paskal Beniwoll): `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- Węzeł `[88]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Arrest"] = true;`
- Węzeł `[89]` (Paskal Beniwoll): `Variable["RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Extradite"] = true;`
- Węzeł `[90]` (Paskal Beniwoll): `Variable["RiziaDLC.Council_GrandVizier_Hugo"] = false; Variable["RiziaDLC.Council_GrandVizier_Emp...`
- *...oraz 3 innych węzłów ze skryptami.*

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
  - -> `[119]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Shortly after my return from Wehlen, I was told that my uncle wanted to speak to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The door to my chambers swung open as Titus let him in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[5]`
Mówca: **Hugo Toras**
> ""Romus. My king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[6]`
Mówca: **Hugo Toras**
> ""Yet I cannot help but wonder whether this triumph had to come at such a great cost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""I begged you with all my heart -- as your uncle and your Grand Vizier. And you refused to listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Despite the fact that my son was proven innocent, you are keen on letting Ricardus rot in a cell...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Extradited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Extradited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Extradited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Extradited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[12]`
Mówca: **Hugo Toras**
> ""Despite my entreaties, you insisted on sending my son to Wehlen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""Ricardus might have erred, but he is still a Toras. Your flesh and blood, for God's sake!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[112]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He is a traitor, Hugo. We've already been through this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did what I had to do to get Zille back. Rico was a necessary sacrifice so that millions more Rizians could live in peace and freedom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry, Hugo. There is nothing I can do about it now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are speaking to the King, Hugo. Please lower your voice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""He's your cousin, for God's sake! Your flesh and blood!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[16]`
  - -> `[17]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Narrator**
> "I could see him struggling to stay calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've already been through this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""How could you let President Smolak take him? I explicitly asked you to respect Rico's dignity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[22]`
Mówca: **Narrator**
> "He stopped himself and cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Extradited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Extradited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Extradited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Extradited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""You know how much I've done for the sake of the Crown. For our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""What end goal can justify subjecting your own cousin to the barbaric punishment of the Wehzeks? Have you so little faith in Rizian justice?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[29]`
  - -> `[30]`
  - -> `[31]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Barbaric? Ricardus is royalty. They're probably feeding him grapes over there right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am terribly sorry. I'll miss Rico just as much as you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a decision borne of necessity, not desire. The negative consequences of denying Wehlen's request would have been far worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe I have said enough on this subject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""Think of my loyalty, Romus. Of my service to the Crown. Is this the price? My son's head on a foreign pike?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""I swore an oath to give my life in service to this kingdom. And I do not intend to falter in my sacred duty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[35]`
Mówca: **Narrator**
> "He looked at me with fury in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be so dramatic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your loyalty has never been in question, nor will it ever be. This pains me deeply, Hugo. Believe me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's done is done. The Crown must often make choices that wound us personally for the greater good of the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The longer you keep going on like this, the more I'm beginning to doubt that loyalty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""You don't mean that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[41]`
Mówca: **Narrator**
> "He looked at me with fury in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""Are you serious?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[43]`
Mówca: **Narrator**
> "He let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[44]`
Mówca: **Narrator**
> "He was holding his golden pin, The Vizier's Star -- the official symbol of his authority as the Grand Vizier -- in his hands. He gripped it tightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""I cannot bear this, Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[46]`
Mówca: **Hugo Toras**
> ""I cannot in good conscience continue my duties as Grand Vizier, knowing my son has been thrown to the wolves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""I need some time on my own. I need to leave the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[50]`
  - -> `[49]`
  - -> `[48]`
  - -> `[52]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean, you're leaving?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't quit. You're fired.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot just abandon your duties, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that is your wish, Uncle, I will not stop you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And where will you go?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""I will go back home, to Monqiz. It has been too long, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""I cannot continue to serve you in the same capacity anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[56]`
Mówca: **Narrator**
> "He walked up to my desk and placed his pin on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""For the good of the Crown, I must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""I cannot stay here, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_DuchessOfValenqiris == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_DuchessOfValenqiris == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""I shall assist Vina once she moves to Valenqiris, if Her Highness accepts my help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""I shall assist Duke Hubertus with his duties, if His Grace accepts my help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""I will do what I can for our house and our province. But I will no longer involve myself in the affairs of the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[65]`
Mówca: **Hugo Toras**
> ""It pains me deeply, but I must let go of my title and responsibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""There.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Narrator**
> "He knelt in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""It was an honor to serve you, King Romus Toras, the First of His Name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[69]`
  - -> `[70]`
  - -> `[71]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your departure is tantamount to betrayal. I will no longer be able to trust you after this. You understand that, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm warning you, Hugo. Don't think about doing anything questionable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no need for that. Stand up. You are still family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[72]`
Mówca: **Hugo Toras**
> ""I am disappointed you would think that of me, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""My loyalty to the Kingdom has never once wavered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And it was an honor to have your guidance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[76]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[77]`
Mówca: **Narrator**
> "He bowed his head and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo = false;
RiziaDLC.Council_GrandVizier_Empty = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] = false;
Variable["RiziaDLC.Council_GrandVizier_Empty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[80]`
Mówca: **Narrator**
> "As the door closed, I let out a breath I didn't realize I'd been holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "Hugo would have to be watched closely from now on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Extradited == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rico_Extradited == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rico_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rico_Extradited == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rico_Extradited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Arrest = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Arrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Extradite = true;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Extradite"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Council_GrandVizier_Hugo = false;
RiziaDLC.Council_GrandVizier_Empty = true;
RiziaDLC.Hugo_Resigned = true;
EnableCodexEntry("Characters_Council_HugoToras_Resigned");)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] = false;
Variable["RiziaDLC.Council_GrandVizier_Empty"] = true;
Variable["RiziaDLC.Hugo_Resigned"] = true;
EnableCodexEntry("Characters_Council_HugoToras_Resigned");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Hugo Toras", "Uncle of the King");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Hugo Toras","Uncle of the King");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.BrunoDog_Adopted == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.BrunoDog_Adopted == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[95]`
Mówca: **Narrator**
> "Bruno immediately jumped up on him, tail wagging. Hugo didn't pay him any attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`
  - -> `[98]`
  - -> `[99]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Bruno");)*
- **Efekt (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bruno! Down!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're just going to let him do that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry. He's forgotten all of the training Rico gave him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "On hearing his son's name, Hugo shuddered involuntarily. He pushed Bruno aside and stood before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Hugo didn't answer. He pushed Bruno aside and stood before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[102]`
Mówca: **Narrator**
> "Hugo stared ahead numbly. He pushed Bruno aside and stood before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[103]`
Mówca: **Narrator**
> "Hugo had a numb look in his eyes as he came to stand before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""I must... congratulate you on negotiating the successful return of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Narrator**
> "He was having trouble getting the words out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""I was... sorry to hear that your negotiations with Wehlen did not result in Zille's return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Narrator**
> "He was having trouble getting the words out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""Despite the terrible cost that has been paid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did what I thought was right at the time. How was I to know Smolak wouldn't keep his word?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Hugo Toras**
> ""Surely this was not the only way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""You know that isn't true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""Then so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Being abandoned by their Grand Vizier and uncle", "Palace Rezna", "Porte Drazon");)*
- **Efekt (`userScript`):** `SetRichPresence("Being abandoned by their Grand Vizier and uncle","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
