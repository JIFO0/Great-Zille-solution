# Sordland/Turn06/Personal_ReturnOfInvestment2

- **ID konwersacji:** `88`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/088_Personal_ReturnOfInvestment2.md`
- **Liczba węzłów dialogowych:** 91
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[35]** Gus Manger
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall`
- `BaseGame.PersonalWealth`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_P_Underhall`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Enable_Lobbying`
- `BaseGame.Enable_Lobbying_Spend2`
- `BaseGame.Enable_Lobbying_Spend3`
- `BaseGame.PersonalWealth`
- `BaseGameSupport.Journal_Turn06_ReturnOfInvestment2`
- `GameCondition.Turn06_Decision_Lobbying`
- `GameCondition.Turn06_Personal_ReturnOfInvestment2`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **"“Let me know if there are any other opportunities.”"** | `[45]` **Gus Manger**: "“Thank you for your time.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Gus Manger**: "“Of course. I will be in contact.”" |
| `[13]` | **"“Yes? What is it?”"** | `[7]` **Livia Suno**: "“Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Livia Suno**: "“Mr. Manger is on the line, sir.”" |
| `[14]` | **"“I'm busy. Make it quick.”"** | `[7]` **Livia Suno**: "“Mr. President.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Livia Suno**: "“Yes, sir.”" |
| `[24]` | **"“Excellent. Connect him through.”"** | `[11]` **Livia Suno**: "“He said it is about an investme..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Livia Suno**: "“As you wish.”" |
| `[25]` | **"“Very well.”"** | `[11]` **Livia Suno**: "“He said it is about an investme..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Livia Suno**: "“As you wish.”" |
| `[29]` | **"“Thank you, Mr. Manger. It wouldn't be possible without you.”"** | `[67]` **Gus Manger**: "“Congratulations are in order, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Gus Manger**: "“Thank you, Mr. President. You a..." |
| `[33]` | **"“Mr. Manger. To what do I owe the pleasure?”"** | `[23]` **Narrator**: "A momentary crackling noise indi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Gus Manger**: "“Mr. President.”" |
| `[34]` | **"“I hope you have some good news.”"** | `[23]` **Narrator**: "A momentary crackling noise indi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Gus Manger**: "“I am sure you will be delighted..." |
| `[35]` | **"“It's the President speaking.”"** | `[23]` **Narrator**: "A momentary crackling noise indi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Gus Manger**: "“Mr. President.”" |
| `[36]` | **"“Good evening.”"** | `[45]` **Gus Manger**: "“Thank you for your time.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Gus Manger**: "“Have a good evening, Mr. Presid..." |
| `[37]` | **"“Cut to the chase.”"** | `[5]` **Gus Manger**: "“A very enjoyable party turned o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Gus Manger**: "“Well then...”" |
| `[39]` | **"“Thanks again.”"** | `[45]` **Gus Manger**: "“Thank you for your time.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Gus Manger**: "“Anytime. I will be in contact.”" |
| `[56]` | **"“Then let's hear the results.”"** | `[5]` **Gus Manger**: "“A very enjoyable party turned o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Gus Manger**: "“Well then...”" |
| `[57]` | **"“You are absolutely right.”"** | `[5]` **Gus Manger**: "“A very enjoyable party turned o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Gus Manger**: "“Well then...”" |
| `[58]` | **"“Thank you.”"** | `[67]` **Gus Manger**: "“Congratulations are in order, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Gus Manger**: "“My pleasure.”" |
| `[59]` | **"“You know, Gus, I am glad I went to that party as well!”"** | `[67]` **Gus Manger**: "“Congratulations are in order, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Gus Manger**: "“See. I told you.”" |

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
  - -> `[68]` (*Narrator: "The sun was setting over Holsord. I was in my office work..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Gus Manger**
> "“You now officially have a stake in Underhall Construction. Considering their status as the number one construction company in the entire Sordland, I must say that this was an excellent choice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_Personal_ReturnOfInvestment2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_Personal_ReturnOfInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_ReturnOfInvestment2 = true"*)

### Węzeł `[5]`
Mówca: **Gus Manger**
> "“A very enjoyable party turned out to be even more enjoyable with actual results out of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: "“Cut to the chase.”"*)
  - -> `[56]` (*Player: "“Then let's hear the results.”"*)
  - -> `[57]` (*Player: "“You are absolutely right.”"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The phone rang and I picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Livia Suno: "“Mr. President.”"*)

### Węzeł `[7]`
Mówca: **Livia Suno**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“Yes? What is it?”"*)
  - -> `[14]` (*Player: "“I'm busy. Make it quick.”"*)

### Węzeł `[8]`
Mówca: **Gus Manger**
> "“I am honestly very glad that I have decided to attend to Mr. Vice President's little gathering.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Gus Manger: "“A very enjoyable party turned out to be even more enjoya..."*)

### Węzeł `[9]`
Mówca: **Gus Manger**
> "“The Underhall board is very happy to have you on the team, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_UnderhallTrophy");"*)

### Węzeł `[10]`
Mówca: **Livia Suno**
> "“Mr. Manger is on the line, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Livia Suno: "“He said it is about an investment.”"*)

### Węzeł `[11]`
Mówca: **Livia Suno**
> "“He said it is about an investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "“Excellent. Connect him through.”"*)
  - -> `[25]` (*Player: "“Very well.”"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“Let me know if there are any other opportunities.”"]** — Mówca: **Player**
> "“Let me know if there are any other opportunities.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Gus Manger: "“Of course. I will be in contact.”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Yes? What is it?”"]** — Mówca: **Player**
> "“Yes? What is it?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Livia Suno: "“Mr. Manger is on the line, sir.”"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“I'm busy. Make it quick.”"]** — Mówca: **Player**
> "“I'm busy. Make it quick.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Livia Suno: "“Yes, sir.”"*)

### Węzeł `[15]`
Mówca: **Gus Manger**
> "“As your secretary might've informed you, I am calling about what we discussed at the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Gus Manger: "“I am honestly very glad that I have decided to attend to..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Gus Manger: "“The Underhall board is very happy to have you on the tea..."*)

### Węzeł `[17]`
Mówca: **Livia Suno**
> "“Yes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Livia Suno: "“Mr. Manger is on the line, sir.”"*)

### Węzeł `[18]`
Mówca: **Gus Manger**
> "“Have a good evening, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The line dropped."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0 && BaseGame.Reform_Autocrat_P..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Gus Manger: "“The Underhall board is very happy to have you on the tea..."*)

### Węzeł `[21]`
Mówca: **Gus Manger**
> "“Especially after you picked Underhall Construction for the new investment project. Our profits are expected to be doubled by next year!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Gus Manger: "“The investment happened at the right time for the end of..."*)

### Węzeł `[22]`
Mówca: **Gus Manger**
> "“I am sure you will be delighted to hear that as a matter of fact, I do, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Gus Manger: "“I am honestly very glad that I have decided to attend to..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "A momentary crackling noise indicated the line change."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“Mr. Manger. To what do I owe the pleasure?”"*)
  - -> `[34]` (*Player: "“I hope you have some good news.”"*)
  - -> `[35]` (*Player: "“It's the President speaking.”"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Excellent. Connect him through.”"]** — Mówca: **Player**
> "“Excellent. Connect him through.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Livia Suno: "“As you wish.”"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Very well.”"]** — Mówca: **Player**
> "“Very well.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Livia Suno: "“As you wish.”"*)

### Węzeł `[26]`
Mówca: **Gus Manger**
> "“Of course. I will be in contact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Gus Manger: "“Have a good evening, Mr. President.”"*)

### Węzeł `[27]`
Mówca: **Gus Manger**
> "“Anytime. I will be in contact.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Gus Manger: "“Have a good evening, Mr. President.”"*)

### Węzeł `[28]`
Mówca: **Livia Suno**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "A momentary crackling noise indicated the line change."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Thank you, Mr. Manger. It wouldn't be possible without you.”"]** — Mówca: **Player**
> "“Thank you, Mr. Manger. It wouldn't be possible without you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Gus Manger: "“Thank you, Mr. President. You are too kind.”"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == ..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Gus Manger: "“Especially after you picked Underhall Construction for t..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_2ndCompanyChoice_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Gus Manger: "“The investment happened at the right time for the end of..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Mr. Manger. To what do I owe the pleasure?”"]** — Mówca: **Player**
> "“Mr. Manger. To what do I owe the pleasure?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Gus Manger: "“Mr. President.”"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I hope you have some good news.”"]** — Mówca: **Player**
> "“I hope you have some good news.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Gus Manger: "“I am sure you will be delighted to hear that as a matter..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“It's the President speaking.”"]** — Mówca: **Player**
> "“It's the President speaking.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Gus Manger: "“Mr. President.”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Good evening.”"]** — Mówca: **Player**
> "“Good evening.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Gus Manger: "“Have a good evening, Mr. President.”"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Cut to the chase.”"]** — Mówca: **Player**
> "“Cut to the chase.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Gus Manger: "“Well then...”"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Gus Manger: "“Congratulations are in order, Mr. President.”"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Thanks again.”"]** — Mówca: **Player**
> "“Thanks again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Gus Manger: "“Anytime. I will be in contact.”"*)

### Węzeł `[40]`
Mówca: **Gus Manger**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Gus Manger: "“As your secretary might've informed you, I am calling ab..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_WineBottle");"*)

### Węzeł `[42]`
Mówca: **Gus Manger**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Gus Manger: "“I am calling about what we discussed at the party.”"*)

### Węzeł `[43]`
Mówca: **Gus Manger**
> "“I am very happy to inform you that your investment to FC Anrica has been accepted by the board members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Gus Manger: "“Now that we have the President of Sordland by our side, ..."*)

### Węzeł `[44]`
Mówca: **Gus Manger**
> "“I am very happy to inform you that your investment to buy stocks from Underhall Construction has been accepted by the board members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Gus Manger: "“You now officially have a stake in Underhall Constructio..."*)

### Węzeł `[45]`
Mówca: **Gus Manger**
> "“Thank you for your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: "“Thanks again.”"*)
  - -> `[12]` (*Player: "“Let me know if there are any other opportunities.”"*)
  - -> `[36]` (*Player: "“Good evening.”"*)

### Węzeł `[46]`
Mówca: **Gus Manger**
> "“I am calling about what we discussed at the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Gus Manger: "“I am honestly very glad that I have decided to attend to..."*)

### Węzeł `[47]`
Mówca: **Gus Manger**
> "“I sent the signed contract and we received some really nice merchandise from the team.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_AnricaTrophy");"*)

### Węzeł `[48]`
Mówca: **Gus Manger**
> "“I am very happy to inform you that your investment to procure the vineyard in Erlory has been accepted by the current resident.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Gus Manger: "“You are now the owner of a lovely vineyard, a beautiful ..."*)

### Węzeł `[49]`
Mówca: **Gus Manger**
> "“I will have the deed and the keys sent to you immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 1"*)

### Węzeł `[50]`
Mówca: **Gus Manger**
> "“You are now the owner of a lovely vineyard, a beautiful villa and a sizable land. As I mentioned before, there might be some cost related to refurbishing the wine making equipment however, the facilities are there.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Gus Manger: "“I will have the deed and the keys sent to you immediately.”"*)

### Węzeł `[51]`
Mówca: **Gus Manger**
> "“See. I told you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Gus Manger: "“I am looking forward to more successful ventures we migh..."*)

### Węzeł `[52]`
Mówca: **Gus Manger**
> "“My pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Gus Manger: "“I am looking forward to more successful ventures we migh..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Underhall == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Underhall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Underhall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Gus Manger: "“I am very happy to inform you that your investment to bu..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Underhall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Underhall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Gus Manger: "“I am very happy to inform you that your investment to pr..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“Then let's hear the results.”"]** — Mówca: **Player**
> "“Then let's hear the results.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Gus Manger: "“Well then...”"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“You are absolutely right.”"]** — Mówca: **Player**
> "“You are absolutely right.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Gus Manger: "“Well then...”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Gus Manger: "“My pleasure.”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“You know, Gus, I am glad I went to that party as well!”"]** — Mówca: **Player**
> "“You know, Gus, I am glad I went to that party as well!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Gus Manger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Gus Manger: "“See. I told you.”"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Gus Manger: "“I am very happy to inform you that your investment to FC..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Underhall == true"*)

### Węzeł `[63]`
Mówca: **Gus Manger**
> "“Well then...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[64]`
Mówca: **Gus Manger**
> "“Thank you, Mr. President. You are too kind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Gus Manger: "“I am looking forward to more successful ventures we migh..."*)

### Węzeł `[65]`
Mówca: **Gus Manger**
> "“I am looking forward to more successful ventures we might do together in the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Gus Manger: "“Thank you for your time.”"*)

### Węzeł `[66]`
Mówca: **Gus Manger**
> "“Now that we have the President of Sordland by our side, I assure you, this motivation will make us the champions this season!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Gus Manger: "“With the new investments coming in to the club, the mana..."*)

### Węzeł `[67]`
Mówca: **Gus Manger**
> "“Congratulations are in order, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "“Thank you, Mr. Manger. It wouldn't be possible without y..."*)
  - -> `[59]` (*Player: "“You know, Gus, I am glad I went to that party as well!”"*)
  - -> `[58]` (*Player: "“Thank you.”"*)

### Węzeł `[68]`
Mówca: **Narrator**
> "The sun was setting over Holsord. I was in my office working on the preliminary details that Ciara sent over about the curriculum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "The phone rang and I picked it up."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_ReturnOfInvestment2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_ReturnOfInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[70]`
Mówca: **Gus Manger**
> "“The investment happened at the right time for the end of year profit-share too. We were immediately able to reap the financial benefits of last year which will be sent to your personal account.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 1"*)

### Węzeł `[71]`
Mówca: **Gus Manger**
> "“The investment happened at the right time for the end of year profit-share too. We were immediately able to reap the massive financial benefits of last year which will be sent to your personal account.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 2"*)

### Węzeł `[72]`
Mówca: **Gus Manger**
> "“The investment happened at the right time for the end of year profit-share too. We were immediately able to reap the massive financial benefits of last year which will be sent to your personal account.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 2"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_Lobbying_Spend3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_Lobbying_Spend3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_Personal_ReturnOfInvestment2 = true"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_Lobbying_Spend2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_Lobbying_Spend2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 4"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 4"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth >= 4)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_Lobbying_Spend3 = true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_Personal_ReturnOfInvestment2 = true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0 && BaseGame.Reform_Autocrat_Path == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0 && BaseGame.Reform_Autocrat_P..."*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0 && BaseGame.Reform_Autocrat..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0 && BaseGame.Reform_Autocrat_Path == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0  and  Variable["BaseGame.Reform_Autocrat_Path"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_Lobbying = true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0 && BaseGame.Reform_Autocrat_Path == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0  and  Variable["BaseGame.Reform_Autocrat_Path"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_Decision_Lobbying = true"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_Lobbying = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_Lobbying"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 2"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_Decision_Lobbying = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_Decision_Lobbying"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_Personal_ReturnOfInvestment2 = true"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 2"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth >= 2)"*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_Lobbying_Spend2 = true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 4"*)

### Węzeł `[86]`
Mówca: **Gus Manger**
> "“With the new investments coming in to the club, the management is already looking to transfer big names to the squad.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Gus Manger: "“I sent the signed contract and we received some really n..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_AnricaTrophy");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_AnricaTrophy");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Gus Manger: "“The investment happened at the right time for the end of..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_UnderhallTrophy");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_UnderhallTrophy");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Gus Manger: "“Congratulations are in order, Mr. President.”"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_WineBottle");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_WineBottle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Gus Manger: "“Congratulations are in order, Mr. President.”"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
