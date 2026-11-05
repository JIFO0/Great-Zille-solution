# Rizia/Turn 10/Murder Notes/Murder Notes Conversation

- **ID konwersacji:** `543`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/543_Murder_Notes_Conversation.md`
- **Liczba węzłów dialogowych:** 80
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[81]** Titus Gordion
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **"“Well, then what would you call it?”"** | `[4]` **Titus Gordion**: "Government facilities in a handf..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[6]` **Titus Gordion**: "“I'd call it, a revolution.”" |
| `[8]` | **"“Titus, I think you're blowing this out of proportion.”"** | `[7]` **Titus Gordion**: "“Or at the very least, the makin..."<br>`[29]` **Titus Gordion**: ""It's a matter not to be taken l..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Titus Gordion**: "“I can assure you, I'm not. We’r..." |
| `[12]` | **""Your concern is duly noted, Captain. However, I have weathered many storms in my ..."** | `[11]` **Titus Gordion**: ""A storm is coming, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Titus Gordion"); ;` | *Koniec sceny / Terminal* |
| `[23]` | **""Discontent? From within our own court?""** | `[22]` **Titus Gordion**: ""I've been receiving anonymous t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Titus Gordion**: ""Yes, sir. These sources hint at..." |
| `[24]` | **""I see... It seems trust is becoming a rare commodity these days. What else can yo..."** | `[22]` **Titus Gordion**: ""I've been receiving anonymous t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Titus Gordion**: ""From what I've gathered, my sou..." |
| `[25]` | **""I won't tolerate betrayal from within my own court. Can you tell me who these tra..."** | `[22]` **Titus Gordion**: ""I've been receiving anonymous t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Titus Gordion**: "My informants haven't disclosed ..." |
| `[27]` | **""'Anonymous sources... unnamed noble houses... Sorry, but I don't take cryptically..."** | `[29]` **Titus Gordion**: ""It's a matter not to be taken l..."<br>`[32]` **Titus Gordion**: ""This may not sound like much, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Titus Gordion**: "“I assure you, this threat is ve..." |
| `[28]` | **""This is troubling news. Continue to gather any and all information that you can, ..."** | `[7]` **Titus Gordion**: "“Or at the very least, the makin..."<br>`[29]` **Titus Gordion**: ""It's a matter not to be taken l..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Titus Gordion**: ""Yes, sir. Before I go, I would ..." |
| `[33]` | **""Sounds like someone's been reading too many spy thrillers. But in all seriousness..."** | `[29]` **Titus Gordion**: ""It's a matter not to be taken l..."<br>`[32]` **Titus Gordion**: ""This may not sound like much, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Titus Gordion**: "Very well. But before I go, I wo..." |
| `[37]` | **""Thanks for the weather report, Titus. I'll make sure to pack an umbrella.""** | `[11]` **Titus Gordion**: ""A storm is coming, Your Majesty..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | `RemoveConversant("Titus Gordion"); ;` | *Koniec sceny / Terminal* |
| `[38]` | **""Thanks, but I didn't ask for unsolicited advice. You're excused, Captain.""** | `[11]` **Titus Gordion**: ""A storm is coming, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Titus Gordion"); ;` | *Koniec sceny / Terminal* |
| `[39]` | **""I appreciate your concern, Titus. I'll take it into consideration.""** | `[11]` **Titus Gordion**: ""A storm is coming, Your Majesty..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Titus Gordion"); ;` | *Koniec sceny / Terminal* |
| `[43]` | **""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[44]` | **""** | `[4]` **Titus Gordion**: "Government facilities in a handf..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[45]` | **""** | `[4]` **Titus Gordion**: "Government facilities in a handf..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |
| `[46]` | **""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | *Koniec sceny / Terminal* |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Titus Gordion**
> "“Actually, there is, in fact, a matter that requires your attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Titus Gordion: ""The ongoing protests we've been seeing have taken a sign..."*)

### Węzeł `[4]`
Mówca: **Titus Gordion**
> "Government facilities in a handful of smaller towns have been seized, sparking street riots as citizens demand change. The situation has escalated far beyond calling it mere unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "Player_Romus: "...""*)
  - -> `[5]` (*Player_Romus: "“Well, then what would you call it?”"*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Well, then what would you call it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Titus Gordion: "“I'd call it, a revolution.”"*)

### Węzeł `[6]`
Mówca: **Titus Gordion**
> "“I'd call it, a revolution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Titus Gordion: "“Or at the very least, the makings of one.”"*)

### Węzeł `[7]`
Mówca: **Titus Gordion**
> "“Or at the very least, the makings of one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: "“Titus, I think you're blowing this out of proportion.”"*)
  - -> `[28]` (*Player_Romus: ""This is troubling news. Continue to gather any and all i..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Titus, I think you're blowing this out of proportion.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Titus Gordion), `[29]` (Titus Gordion), `[32]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Titus Gordion: "“I can assure you, I'm not. We’re seeing a turning point ..."*)

### Węzeł `[9]`
Mówca: **Titus Gordion**
> "“I can assure you, I'm not. We’re seeing a turning point that we can no longer ignore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Titus Gordion: "“I've already made arrangements for myself in case this w..."*)

### Węzeł `[10]`
Mówca: **Titus Gordion**
> "“I've already made arrangements for myself in case this worst-case scenario comes to pass, and advise you to do the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Titus Gordion: ""A storm is coming, Your Majesty. There's no doubt about ..."*)

### Węzeł `[11]`
Mówca: **Titus Gordion**
> ""A storm is coming, Your Majesty. There's no doubt about it. How you prepare for it is up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""I appreciate your concern, Titus. I'll take it into cons..."*)
  - -> `[38]` (*Player_Romus: ""Thanks, but I didn't ask for unsolicited advice. You're ..."*)
  - -> `[12]` (*Player_Romus: ""Your concern is duly noted, Captain. However, I have wea..."*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your concern is duly noted, Captain. However, I have weathered many storms in my time as king, and I will not falter now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus > 4"*)
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Titus > 4)"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus > 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Titus"] > 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Titus > 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Titus"] > 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[16]`
Mówca: **Titus Gordion**
> ""The ongoing protests we've been seeing have taken a significant turn for the worse, escalating across the entire kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Titus Gordion: "Government facilities in a handful of smaller towns have ..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");
;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
Mówca: **Titus Gordion**
> "“Actually, there is a matter that may require your attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Titus Gordion: ""I've been receiving anonymous tips and warnings from inf..."*)

### Węzeł `[22]`
Mówca: **Titus Gordion**
> ""I've been receiving anonymous tips and warnings from informants within the court and from sources outside the kingdom who speak of growing discontent with the current leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""Discontent? From within our own court?""*)
  - -> `[24]` (*Player_Romus: ""I see... It seems trust is becoming a rare commodity the..."*)
  - -> `[25]` (*Player_Romus: ""I won't tolerate betrayal from within my own court. Can ..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Discontent? From within our own court?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Titus Gordion: ""Yes, sir. These sources hint at potential changes in lea..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see... It seems trust is becoming a rare commodity these days. What else can you tell me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Titus Gordion: ""From what I've gathered, my sources hint at potential ch..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't tolerate betrayal from within my own court. Can you tell me who these traitor are? We need to get to the bottom of this treachery.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Titus Gordion: "My informants haven't disclosed the specific noble houses..."*)

### Węzeł `[26]`
Mówca: **Titus Gordion**
> ""Yes, sir. These sources hint at potential changes in leadership, but don't disclose which noble houses are involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Titus Gordion: ""It's a matter not to be taken lightly.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Anonymous sources... unnamed noble houses... Sorry, but I don't take cryptically vague threats very seriously.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Titus Gordion), `[32]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Titus Gordion: "“I assure you, this threat is very real. We’re seeing a t..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is troubling news. Continue to gather any and all information that you can, Titus. We must stay vigilant.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Titus Gordion), `[29]` (Titus Gordion), `[32]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Titus Gordion: ""Yes, sir. Before I go, I would be remiss if I didn't inf..."*)

### Węzeł `[29]`
Mówca: **Titus Gordion**
> ""It's a matter not to be taken lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: "“Titus, I think you're blowing this out of proportion.”"*)
  - -> `[28]` (*Player_Romus: ""This is troubling news. Continue to gather any and all i..."*)
  - -> `[27]` (*Player_Romus: ""'Anonymous sources... unnamed noble houses... Sorry, but..."*)
  - -> `[33]` (*Player_Romus: ""Sounds like someone's been reading too many spy thriller..."*)

### Węzeł `[30]`
Mówca: **Titus Gordion**
> ""From what I've gathered, my sources hint at potential changes in leadership, but don't disclose which noble houses are involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Titus Gordion: ""This may not sound like much, but I can assure you that ..."*)

### Węzeł `[31]`
Mówca: **Titus Gordion**
> "My informants haven't disclosed the specific noble houses involved -- rather, they've only mentioned a growing discussion about a potential leadership change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Titus Gordion: ""This may not sound like much, but I can assure you that ..."*)

### Węzeł `[32]`
Mówca: **Titus Gordion**
> ""This may not sound like much, but I can assure you that my informants are reliable, and what they've uncovered shouldn't be taken lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: "“Titus, I think you're blowing this out of proportion.”"*)
  - -> `[28]` (*Player_Romus: ""This is troubling news. Continue to gather any and all i..."*)
  - -> `[27]` (*Player_Romus: ""'Anonymous sources... unnamed noble houses... Sorry, but..."*)
  - -> `[33]` (*Player_Romus: ""Sounds like someone's been reading too many spy thriller..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like someone's been reading too many spy thrillers. But in all seriousness, if there's even a hint of truth to these whispers, we must act swiftly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Titus Gordion), `[32]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Titus Gordion: "Very well. But before I go, I would be remiss if I didn't..."*)

### Węzeł `[34]`
Mówca: **Titus Gordion**
> ""Yes, sir. Before I go, I would be remiss if I didn't inform you that I've already made arrangements for myself in case this worst-case scenario comes to pass, and would advise you to do the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Titus Gordion: ""A storm is coming, Your Majesty. There's no doubt about ..."*)

### Węzeł `[35]`
Mówca: **Titus Gordion**
> "“I assure you, this threat is very real. We’re seeing a turning point that we can no longer ignore.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Titus Gordion: "“I've already made arrangements for myself in case this w..."*)

### Węzeł `[36]`
Mówca: **Titus Gordion**
> "Very well. But before I go, I would be remiss if I didn't inform you that I've already made arrangements for myself in case this worst-case scenario comes to pass, and would advise you to do the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Titus Gordion: ""A storm is coming, Your Majesty. There's no doubt about ..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for the weather report, Titus. I'll make sure to pack an umbrella.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[11]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I didn't ask for unsolicited advice. You're excused, Captain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your concern, Titus. I'll take it into consideration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player_Romus: ""Thanks for the weather report, Titus. I'll make sure to ..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Titus Gordion)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Titus Gordion)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Węzeł Logiki Narracyjnej**
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[47]`
Mówca: **Titus Gordion**
> ""Funny you should mention it... it just so happens that I took the liberty of inviting Lucita to meet us for that very purpose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "He checked his watch."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "He checked his watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Titus Gordion: ""And, actually, should be arriving any minute--""*)

### Węzeł `[49]`
Mówca: **Titus Gordion**
> ""And, actually, should be arriving any minute--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej*)

### Węzeł `[50]`
Mówca: **Titus Gordion**
> ""And speaking of unexpected revelations, there's someone here who can hopefully shed some light on the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej*)

### Węzeł `[51]`
Mówca: **Titus Gordion**
> ""Well, if you don't believe me, then maybe you'll believe what Lucita has to say for herself, who I invited here and should be arriving shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[53]`
Mówca: **Titus Gordion**
> ""I'm glad you brought that up because that brings up another matter that deserves your immediate attention.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[54]`
Mówca: **Narrator**
> ""I felt compelled to share with you the findings of our investigation into your uncle and Grand Vizier, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: ""It all began with eyewitness accounts, including my own,..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> ""It all began with eyewitness accounts, including my own, placing Hugo exiting the late King’s private chambers just before his death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: ""There's been a lingering conspiracy theory surrounding H..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> ""There's been a lingering conspiracy theory surrounding Hugo, suggesting he sees himself as the rightful king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: ""This alone provided a motive for suspicion, not to menti..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> ""This alone provided a motive for suspicion, not to mention the rumored bitter rivalry between them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: ""However, as I delved deeper, I uncovered a surprising tr..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> ""However, as I delved deeper, I uncovered a surprising truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: ""Hugo and King Valero shared a close bond, evident throug..."*)

### Węzeł `[59]`
Mówca: **Narrator**
> ""Hugo and King Valero shared a close bond, evident through their correspondence and numerous testimonials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: ""There was no evidence of Hugo aspiring to claim the thro..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> ""There was no evidence of Hugo aspiring to claim the throne. The supposed rivalry was a mere fiction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: ""Regarding the night of Valero’s demise, I found no trace..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> ""Regarding the night of Valero’s demise, I found no traces linking Hugo to any murder weapon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: ""You might be surprised to learn that traces of Mandragor..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> ""When the late king was exhumed, a preserved sample of formalin-fixed tissue allowed for an advanced toxicology examination by Iza University's laboratories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: ""However, despite our exhaustive efforts, there's no evid..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> ""You might be surprised to learn that traces of Mandragora -- a deadly nightshade --were found in the late king's system during a recent toxicology test.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: ""When the late king was exhumed, a preserved sample of fo..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> ""However, despite our exhaustive efforts, there's no evidence linking Hugo to the possession or acquisition of such a poison. It appears to be a case of him being at the wrong place at the wrong time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: ""I hope this information proves useful to you, Your Majes..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> ""I hope this information proves useful to you, Your Majesty, as you continue to seek answers and closure regarding your father's untimely passing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: ""Sincerely,   Captain Titus Gordion""*)

### Węzeł `[66]`
Mówca: **Narrator**
> ""I must bring to your attention the progress made in our investigation concerning Lucita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: ""While our efforts yielded significant findings, they onl..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> ""While our efforts yielded significant findings, they only extended as far as the toxicology report.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: ""Initially, suspicions were raised due to the presence of..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> ""Initially, suspicions were raised due to the presence of Mandragora—a lethal nightshade—in your father's toxicology report.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: ""However, we were unable to uncover any tangible evidence..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> ""However, we were unable to uncover any tangible evidence linking Lucita to the acquisition or possession of such a poison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: ""Despite our thorough investigation, we were unable to un..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> ""Respectfully,

Captain Titus Gordion""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == false"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == false)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: ""I felt compelled to share with you the findings of our i..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: ""I felt compelled to share with you the findings of our i..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> ""I felt compelled to share with you the findings of our investigation into your uncle and former Grand Vizier, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: ""It all began with eyewitness accounts, including my own,..."*)

### Węzeł `[75]`
Mówca: **Narrator**
> ""Sincerely, 

Captain Titus Gordion""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[76]`
Mówca: **Narrator**
> ""Despite our thorough investigation, we were unable to uncover any further leads or evidence implicating Lucita in the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: ""I trust this information sheds some light on the ongoing..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> ""I trust this information sheds some light on the ongoing investigation, and I remain committed to assisting you in any way possible to bring closure to this troubling ordeal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: ""Respectfully,  Captain Titus Gordion""*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: ""I must bring to your attention the progress made in our ..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == false"*)
