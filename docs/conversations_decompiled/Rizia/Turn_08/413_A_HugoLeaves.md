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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[14]` | **""He is a traitor, Hugo. We've already been through this.""** | `[13]` **Hugo Toras**: ""Ricardus might have erred, but ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Hugo Toras**: ""How could you let President Smo..." |
| `[15]` | **""I did what I had to do to get Zille back. Rico was a necessary sacrifice so that ..."** | `[13]` **Hugo Toras**: ""Ricardus might have erred, but ..."<br>`[18]` **Hugo Toras**: ""He's your cousin, for God's sak..." | `Variable["RiziaDLC.ZilleReturn_Success"] == true` | *Brak zmian stanu* | `[116]` **Hugo Toras**: ""Surely this was not the only way."" |
| `[16]` | **""I am sorry, Hugo. There is nothing I can do about it now.""** | `[13]` **Hugo Toras**: ""Ricardus might have erred, but ..."<br>`[18]` **Hugo Toras**: ""He's your cousin, for God's sak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Hugo Toras**: ""How could you let President Smo..."<br>`[7]` **Hugo Toras**: ""I begged you with all my heart ..." |
| `[17]` | **""You are speaking to the King, Hugo. Please lower your voice.""** | `[13]` **Hugo Toras**: ""Ricardus might have erred, but ..."<br>`[18]` **Hugo Toras**: ""He's your cousin, for God's sak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Narrator**: "He stopped himself and cleared h..." |
| `[20]` | **""We've already been through this.""** | `[18]` **Hugo Toras**: ""He's your cousin, for God's sak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Hugo Toras**: ""I begged you with all my heart ..." |
| `[29]` | **""Barbaric? Ricardus is royalty. They're probably feeding him grapes over there rig..."** | `[28]` **Hugo Toras**: ""What end goal can justify subje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Hugo Toras**: ""You know that isn't true."" |
| `[30]` | **""I am terribly sorry. I'll miss Rico just as much as you.""** | `[28]` **Hugo Toras**: ""What end goal can justify subje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Hugo Toras**: ""Think of my loyalty, Romus. Of ..." |
| `[31]` | **""It was a decision borne of necessity, not desire. The negative consequences of de..."** | `[28]` **Hugo Toras**: ""What end goal can justify subje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Hugo Toras**: ""Think of my loyalty, Romus. Of ..." |
| `[32]` | **""I believe I have said enough on this subject.""** | `[28]` **Hugo Toras**: ""What end goal can justify subje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Hugo Toras**: ""Think of my loyalty, Romus. Of ..." |
| `[36]` | **""Don't be so dramatic.""** | `[33]` **Hugo Toras**: ""Think of my loyalty, Romus. Of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "He looked at me with fury in his..." |
| `[37]` | **""Your loyalty has never been in question, nor will it ever be. This pains me deepl..."** | `[33]` **Hugo Toras**: ""Think of my loyalty, Romus. Of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "He let out a deep sigh." |
| `[38]` | **""What's done is done. The Crown must often make choices that wound us personally f..."** | `[33]` **Hugo Toras**: ""Think of my loyalty, Romus. Of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Narrator**: "He let out a deep sigh." |
| `[39]` | **""The longer you keep going on like this, the more I'm beginning to doubt that loya..."** | `[33]` **Hugo Toras**: ""Think of my loyalty, Romus. Of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Narrator**: "He looked at me with fury in his..." |
| `[48]` | **""What do you mean, you're leaving?""** | `[47]` **Hugo Toras**: ""I need some time on my own. I n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Hugo Toras**: ""I cannot stay here, Romus."" |
| `[49]` | **""You can't quit. You're fired.""** | `[47]` **Hugo Toras**: ""I need some time on my own. I n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Hugo Toras**: ""Then so be it."" |
| `[50]` | **""You cannot just abandon your duties, Hugo.""** | `[47]` **Hugo Toras**: ""I need some time on my own. I n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Hugo Toras**: ""It pains me deeply, but I must ..." |
| `[51]` | **""If that is your wish, Uncle, I will not stop you.""** | `[47]` **Hugo Toras**: ""I need some time on my own. I n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Hugo Toras**: ""Thank you."" |
| `[52]` | **""And where will you go?""** | `[47]` **Hugo Toras**: ""I need some time on my own. I n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Hugo Toras**: ""I will go back home, to Monqiz...." |
| `[69]` | **""Your departure is tantamount to betrayal. I will no longer be able to trust you a..."** | `[68]` **Hugo Toras**: ""It was an honor to serve you, K..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Hugo Toras**: ""I am disappointed you would thi..." |
| `[70]` | **""I'm warning you, Hugo. Don't think about doing anything questionable.""** | `[68]` **Hugo Toras**: ""It was an honor to serve you, K..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Hugo Toras**: ""I am disappointed you would thi..." |
| `[71]` | **""There is no need for that. Stand up. You are still family.""** | `[68]` **Hugo Toras**: ""It was an honor to serve you, K..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "He stood up." |
| `[75]` | **""And it was an honor to have your guidance.""** | `[68]` **Hugo Toras**: ""It was an honor to serve you, K..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Hugo Toras**: ""Glovurius axa Rizia."" |
| `[97]` | **""Bruno! Down!""** | `[95]` **Narrator**: "Bruno immediately jumped up on h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Narrator**: "Hugo stared ahead numbly. He pus..." |
| `[98]` | **""You're just going to let him do that?""** | `[95]` **Narrator**: "Bruno immediately jumped up on h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Narrator**: "Hugo didn't answer. He pushed Br..." |
| `[99]` | **""Sorry. He's forgotten all of the training Rico gave him.""** | `[95]` **Narrator**: "Bruno immediately jumped up on h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Narrator**: "On hearing his son's name, Hugo ..." |
| `[115]` | **""I did what I thought was right at the time. How was I to know Smolak wouldn't kee..."** | `[13]` **Hugo Toras**: ""Ricardus might have erred, but ..."<br>`[18]` **Hugo Toras**: ""He's your cousin, for God's sak..." | `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false` | *Brak zmian stanu* | `[116]` **Hugo Toras**: ""Surely this was not the only way."" |

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
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Being abandoned by their Grand Vizier an..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Shortly after my return from Wehlen, I was told that my uncle wanted to speak to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The door to my chambers swung open as Titus let him in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[5]`
Mówca: **Hugo Toras**
> ""Romus. My king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)

### Węzeł `[6]`
Mówca: **Hugo Toras**
> ""Yet I cannot help but wonder whether this triumph had to come at such a great cost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""I begged you with all my heart -- as your uncle and your Grand Vizier. And you refused to listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""You know how much I've done for the sake of the Crown. F..."*)

### Węzeł `[8]`
Mówca: **Hugo Toras**
> ""Despite the fact that my son was proven innocent, you are keen on letting Ricardus rot in a cell...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I could see him struggling to stay calm."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Extradited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Extradited == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Extradited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Hugo Toras: ""Despite my entreaties, you insisted on sending my son to..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Extradited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Extradited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Hugo Toras: ""Despite the fact that my son was proven innocent, you ar..."*)

### Węzeł `[12]`
Mówca: **Hugo Toras**
> ""Despite my entreaties, you insisted on sending my son to Wehlen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Hugo Toras: ""Ricardus might have erred, but he is still a Toras. Your..."*)

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""Ricardus might have erred, but he is still a Toras. Your flesh and blood, for God's sake!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""He is a traitor, Hugo. We've already been through this.""*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[16]` (*Player_Romus: ""I am sorry, Hugo. There is nothing I can do about it now.""*)
  - -> `[17]` (*Player_Romus: ""You are speaking to the King, Hugo. Please lower your vo..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He is a traitor, Hugo. We've already been through this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""How could you let President Smolak take him? I explicitl..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did what I had to do to get Zille back. Rico was a necessary sacrifice so that millions more Rizians could live in peace and freedom.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[13]` (Hugo Toras), `[18]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Hugo Toras: ""Surely this was not the only way.""*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am sorry, Hugo. There is nothing I can do about it now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Hugo Toras), `[18]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are speaking to the King, Hugo. Please lower your voice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Hugo Toras), `[18]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He stopped himself and cleared his throat."*)

### Węzeł `[18]`
Mówca: **Hugo Toras**
> ""He's your cousin, for God's sake! Your flesh and blood!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[16]` (*Player_Romus: ""I am sorry, Hugo. There is nothing I can do about it now.""*)
  - -> `[17]` (*Player_Romus: ""You are speaking to the King, Hugo. Please lower your vo..."*)
  - -> `[20]` (*Player_Romus: ""We've already been through this.""*)

### Węzeł `[19]`
Mówca: **Narrator**
> "I could see him struggling to stay calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Hugo Toras: ""He's your cousin, for God's sake! Your flesh and blood!""*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've already been through this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Hugo Toras: ""I begged you with all my heart -- as your uncle and your..."*)

### Węzeł `[21]`
Mówca: **Hugo Toras**
> ""How could you let President Smolak take him? I explicitly asked you to respect Rico's dignity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Hugo Toras: ""What end goal can justify subjecting your own cousin to ..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "He stopped himself and cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Hugo Toras: ""Your Majesty...""*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Extradited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Extradited == true)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Extradited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Hugo Toras: ""How could you let President Smolak take him? I explicitl..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Extradited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Extradited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Hugo Toras: ""I begged you with all my heart -- as your uncle and your..."*)

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)

### Węzeł `[27]`
Mówca: **Hugo Toras**
> ""You know how much I've done for the sake of the Crown. For our family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Hugo Toras: ""I swore an oath to give my life in service to this kingd..."*)

### Węzeł `[28]`
Mówca: **Hugo Toras**
> ""What end goal can justify subjecting your own cousin to the barbaric punishment of the Wehzeks? Have you so little faith in Rizian justice?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player_Romus: ""I believe I have said enough on this subject.""*)
  - -> `[29]` (*Player_Romus: ""Barbaric? Ricardus is royalty. They're probably feeding ..."*)
  - -> `[30]` (*Player_Romus: ""I am terribly sorry. I'll miss Rico just as much as you.""*)
  - -> `[31]` (*Player_Romus: ""It was a decision borne of necessity, not desire. The ne..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Barbaric? Ricardus is royalty. They're probably feeding him grapes over there right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Hugo Toras: ""You know that isn't true.""*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am terribly sorry. I'll miss Rico just as much as you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Hugo Toras: ""Think of my loyalty, Romus. Of my service to the Crown. ..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a decision borne of necessity, not desire. The negative consequences of denying Wehlen's request would have been far worse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Hugo Toras: ""Think of my loyalty, Romus. Of my service to the Crown. ..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe I have said enough on this subject.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Hugo Toras: ""Think of my loyalty, Romus. Of my service to the Crown. ..."*)

### Węzeł `[33]`
Mówca: **Hugo Toras**
> ""Think of my loyalty, Romus. Of my service to the Crown. Is this the price? My son's head on a foreign pike?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""Don't be so dramatic.""*)
  - -> `[37]` (*Player_Romus: ""Your loyalty has never been in question, nor will it eve..."*)
  - -> `[38]` (*Player_Romus: ""What's done is done. The Crown must often make choices t..."*)
  - -> `[39]` (*Player_Romus: ""The longer you keep going on like this, the more I'm beg..."*)

### Węzeł `[34]`
Mówca: **Hugo Toras**
> ""I swore an oath to give my life in service to this kingdom. And I do not intend to falter in my sacred duty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He was holding his golden pin, The Vizier's Star -- the o..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "He looked at me with fury in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Hugo Toras: ""You don't mean that.""*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be so dramatic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "He looked at me with fury in his eyes."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your loyalty has never been in question, nor will it ever be. This pains me deeply, Hugo. Believe me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "He let out a deep sigh."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's done is done. The Crown must often make choices that wound us personally for the greater good of the kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "He let out a deep sigh."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The longer you keep going on like this, the more I'm beginning to doubt that loyalty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "He looked at me with fury in his eyes."*)

### Węzeł `[40]`
Mówca: **Hugo Toras**
> ""You don't mean that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""You know how much I've done for the sake of the Crown. F..."*)

### Węzeł `[41]`
Mówca: **Narrator**
> "He looked at me with fury in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Hugo Toras: ""Are you serious?""*)

### Węzeł `[42]`
Mówca: **Hugo Toras**
> ""Are you serious?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""You know how much I've done for the sake of the Crown. F..."*)

### Węzeł `[43]`
Mówca: **Narrator**
> "He let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Hugo Toras: ""You know how much I've done for the sake of the Crown. F..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "He was holding his golden pin, The Vizier's Star -- the official symbol of his authority as the Grand Vizier -- in his hands. He gripped it tightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Hugo Toras: ""I cannot bear this, Romus...""*)

### Węzeł `[45]`
Mówca: **Hugo Toras**
> ""I cannot bear this, Romus...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Hugo Toras: ""I cannot continue to serve you in the same capacity anym..."*)

### Węzeł `[46]`
Mówca: **Hugo Toras**
> ""I cannot in good conscience continue my duties as Grand Vizier, knowing my son has been thrown to the wolves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""I need some time on my own. I need to leave the capital.""*)

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""I need some time on my own. I need to leave the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Romus: ""If that is your wish, Uncle, I will not stop you.""*)
  - -> `[50]` (*Player_Romus: ""You cannot just abandon your duties, Hugo.""*)
  - -> `[49]` (*Player_Romus: ""You can't quit. You're fired.""*)
  - -> `[48]` (*Player_Romus: ""What do you mean, you're leaving?""*)
  - -> `[52]` (*Player_Romus: ""And where will you go?""*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean, you're leaving?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Hugo Toras: ""I cannot stay here, Romus.""*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't quit. You're fired.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Hugo Toras: ""Then so be it.""*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot just abandon your duties, Hugo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Hugo Toras: ""It pains me deeply, but I must let go of my title and re..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that is your wish, Uncle, I will not stop you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Hugo Toras: ""Thank you.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And where will you go?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""I will go back home, to Monqiz. It has been too long, an..."*)

### Węzeł `[53]`
Mówca: **Hugo Toras**
> ""I will go back home, to Monqiz. It has been too long, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)

### Węzeł `[54]`
Mówca: **Hugo Toras**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Hugo Toras: ""It pains me deeply, but I must let go of my title and re..."*)

### Węzeł `[55]`
Mówca: **Hugo Toras**
> ""I cannot continue to serve you in the same capacity anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Hugo Toras: ""I cannot in good conscience continue my duties as Grand ..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "He walked up to my desk and placed his pin on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Hugo Toras: ""There.""*)

### Węzeł `[57]`
Mówca: **Hugo Toras**
> ""For the good of the Crown, I must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""I will go back home, to Monqiz. It has been too long, an..."*)

### Węzeł `[58]`
Mówca: **Hugo Toras**
> ""I cannot stay here, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""I will go back home, to Monqiz. It has been too long, an..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_DuchessOfValenqiris == true)"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Hugo Toras: ""I shall assist Vina once she moves to Valenqiris, if Her..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""I shall assist Duke Hubertus with his duties, if His Gra..."*)

### Węzeł `[62]`
Mówca: **Hugo Toras**
> ""I shall assist Vina once she moves to Valenqiris, if Her Highness accepts my help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""I will do what I can for our house and our province. But..."*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""I shall assist Duke Hubertus with his duties, if His Grace accepts my help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""I will do what I can for our house and our province. But..."*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""I will do what I can for our house and our province. But I will no longer involve myself in the affairs of the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "He walked up to my desk and placed his pin on it."*)

### Węzeł `[65]`
Mówca: **Hugo Toras**
> ""It pains me deeply, but I must let go of my title and responsibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Hugo Toras: ""For the good of the Crown, I must.""*)

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""There.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "He knelt in front of me."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "He knelt in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""It was an honor to serve you, King Romus Toras, the Firs..."*)

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""It was an honor to serve you, King Romus Toras, the First of His Name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus: ""And it was an honor to have your guidance.""*)
  - -> `[69]` (*Player_Romus: ""Your departure is tantamount to betrayal. I will no long..."*)
  - -> `[70]` (*Player_Romus: ""I'm warning you, Hugo. Don't think about doing anything ..."*)
  - -> `[71]` (*Player_Romus: ""There is no need for that. Stand up. You are still family.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your departure is tantamount to betrayal. I will no longer be able to trust you after this. You understand that, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Hugo Toras: ""I am disappointed you would think that of me, my nephew.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm warning you, Hugo. Don't think about doing anything questionable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Hugo Toras: ""I am disappointed you would think that of me, my nephew.""*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no need for that. Stand up. You are still family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "He stood up."*)

### Węzeł `[72]`
Mówca: **Hugo Toras**
> ""I am disappointed you would think that of me, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Hugo Toras: ""My loyalty to the Kingdom has never once wavered.""*)

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""My loyalty to the Kingdom has never once wavered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Hugo Toras: ""Glovurius axa Rizia.""*)

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He bowed his head and left the room."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And it was an honor to have your guidance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Hugo Toras: ""Glovurius axa Rizia.""*)

### Węzeł `[76]`
Mówca: **Narrator**
> "He stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Hugo Toras: ""Glovurius axa Rizia.""*)

### Węzeł `[77]`
Mówca: **Narrator**
> "He bowed his head and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo = false;
RiziaDLC.Council_GrandVizier_Empty = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] = false;
Variable["RiziaDLC.Council_GrandVizier_Empty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "As the door closed, I let out a breath I didn't realize I..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[80]`
Mówca: **Narrator**
> "As the door closed, I let out a breath I didn't realize I'd been holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Hugo would have to be watched closely from now on."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Hugo would have to be watched closely from now on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo = false; RiziaDLC.Counc..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The door to my chambers swung open as Titus let him in."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo = false; RiziaDLC.Counc..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Shortly after my return from Wehlen, I was told that my u..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Extradited == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Extradited == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Extradited == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Extradited"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Extradite = true;"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Extradited == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Extradited"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Arrest = true;"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Arrest = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Arrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Extradite = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn08_RH_HugoLeaves_Extradite"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo = false;
RiziaDLC.Council_GrandVizier_Empty = true;
RiziaDLC.Hugo_Resigned = true;
EnableCodexEntry("Characters_Council_HugoToras_Resigned");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] = false;
Variable["RiziaDLC.Council_GrandVizier_Empty"] = true;
Variable["RiziaDLC.Hugo_Resigned"] = true;
EnableCodexEntry("Characters_Council_HugoToras_Resigned");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Hugo Toras", "Uncle of the King");"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Hugo Toras", "Uncle of the King");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Hugo Toras","Uncle of the King");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "AddConversant("Bruno");"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "Hugo had a numb look in his eyes as he came to stand befo..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "Bruno immediately jumped up on him, tail wagging. Hugo didn't pay him any attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""Bruno! Down!""*)
  - -> `[98]` (*Player_Romus: ""You're just going to let him do that?""*)
  - -> `[99]` (*Player_Romus: ""Sorry. He's forgotten all of the training Rico gave him.""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Bruno");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Bruno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "Bruno immediately jumped up on him, tail wagging. Hugo di..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bruno! Down!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "Hugo stared ahead numbly. He pushed Bruno aside and stood..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're just going to let him do that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Hugo didn't answer. He pushed Bruno aside and stood befor..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry. He's forgotten all of the training Rico gave him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "On hearing his son's name, Hugo shuddered involuntarily. ..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "On hearing his son's name, Hugo shuddered involuntarily. He pushed Bruno aside and stood before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Hugo Toras: ""Romus. My king.""*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Hugo didn't answer. He pushed Bruno aside and stood before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Hugo Toras: ""Romus. My king.""*)

### Węzeł `[102]`
Mówca: **Narrator**
> "Hugo stared ahead numbly. He pushed Bruno aside and stood before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Hugo Toras: ""Romus. My king.""*)

### Węzeł `[103]`
Mówca: **Narrator**
> "Hugo had a numb look in his eyes as he came to stand before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Hugo Toras: ""Romus. My king.""*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Hugo Toras: ""I must... congratulate you on negotiating the successful..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""I was... sorry to hear that your negotiations with Wehle..."*)

### Węzeł `[107]`
Mówca: **Hugo Toras**
> ""I must... congratulate you on negotiating the successful return of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "He was having trouble getting the words out."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "He was having trouble getting the words out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Hugo Toras: ""Yet I cannot help but wonder whether this triumph had to..."*)

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""I was... sorry to hear that your negotiations with Wehlen did not result in Zille's return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "He was having trouble getting the words out."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "He was having trouble getting the words out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Hugo Toras: ""Despite the terrible cost that has been paid.""*)

### Węzeł `[111]`
Mówca: **Hugo Toras**
> ""Despite the terrible cost that has been paid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""I did what I had to do to get Zille back. Rico was a nec..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player_Romus: ""I did what I thought was right at the time. How was I to..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did what I thought was right at the time. How was I to know Smolak wouldn't keep his word?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[13]` (Hugo Toras), `[18]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Hugo Toras: ""Surely this was not the only way.""*)

### Węzeł `[116]`
Mówca: **Hugo Toras**
> ""Surely this was not the only way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Extradited == true"*)

### Węzeł `[117]`
Mówca: **Hugo Toras**
> ""You know that isn't true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Hugo Toras: ""Think of my loyalty, Romus. Of my service to the Crown. ..."*)

### Węzeł `[118]`
Mówca: **Hugo Toras**
> ""Then so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Hugo Toras: ""I will go back home, to Monqiz. It has been too long, an..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Being abandoned by their Grand Vizier and uncle", "Palace Rezna", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Being abandoned by their Grand Vizier and uncle","Palace Rezna","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)
