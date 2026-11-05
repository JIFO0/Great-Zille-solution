# Sordland/Turn11/Lucian Evidence

- **ID konwersacji:** `248`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/248_Lucian_Evidence.md`
- **Liczba węzłów dialogowych:** 287
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[1]** Ovid Grecer
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[36]** Heron Garaci
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ChiefJustice_HeronGaraci`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.LeakedScandal_Franc_StateUniversity`
- `BaseGame.LeakedScandal_GusManger_UnderhallCollusion`
- `BaseGame.LeakedScandal_HiddenFunding_RedYouth`
- `BaseGame.LeakedScandal_HiddenFunding_YoungSords`
- `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal`
- `BaseGame.LeakedScandal_SecretState_DetainFrensRicter`
- `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener`
- `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno`
- `BaseGame.LeakedScandal_SecretState_DetainPetrVectern`
- `BaseGame.LeakedScandal_SecretState_KillFrensRicter`
- `BaseGame.LeakedScandal_SecretState_KillKesaroKibener`
- `BaseGame.LeakedScandal_SecretState_KillLiviaSuno`
- `BaseGame.LeakedScandal_SecretState_KillOrsoHawker`
- `BaseGame.LeakedScandal_SecretState_KillPetrVectern`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[246] Sordland/Turn11/A_ImpeachmentTrial** (../Turn_11/246_A_ImpeachmentTrial.md), Węzeł `[45]`
- Węzeł `[101]` -> **[249] Sordland/Turn11/Karl Evidence** (../Turn_11/249_Karl_Evidence.md), Węzeł `[1]`
- Węzeł `[102]` -> **[249] Sordland/Turn11/Karl Evidence** (../Turn_11/249_Karl_Evidence.md), Węzeł `[1]`
- Węzeł `[106]` -> **[249] Sordland/Turn11/Karl Evidence** (../Turn_11/249_Karl_Evidence.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[15]` | **"“You too, Lucian?”"** | `[14]` **Narrator**: "Lucian sat down at the table." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Lucian Galade**: "“Yes, Mr. President. Me too.”" |
| `[16]` | **"“What? Lucian! What the hell is the meaning of this?”"** | `[14]` **Narrator**: "Lucian sat down at the table." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Lucian Galade**: "“Precisely what it looks like, M..." |
| `[20]` | **"“I didn't think you would stoop so low.”"** | `[14]` **Narrator**: "Lucian sat down at the table." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "He gave me a small, humorless sm..." |
| `[21]` | **"Do not make any comments."** | `[14]` **Narrator**: "Lucian sat down at the table." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Narrator**: "He gave me a small, humorless sm..." |
| `[28]` | **"“Liar!”"** | `[27]` **Lucian Galade**: "“The President told me that if I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Heron Garaci**: "“Silence in the court! Mr. Galad..."<br>`[179]` **Ovid Grecer**: "“Silence in the court! Mr. Galad..."<br>*(oraz 1 innych odgałęzień)* |
| `[29]` | **"“Bullshit!”"** | `[27]` **Lucian Galade**: "“The President told me that if I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Heron Garaci**: "“Silence in the court! Mr. Galad..."<br>`[179]` **Ovid Grecer**: "“Silence in the court! Mr. Galad..."<br>*(oraz 1 innych odgałęzień)* |
| `[30]` | **"“Your honor, objection!”"** | `[27]` **Lucian Galade**: "“The President told me that if I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Heron Garaci**: "“Overruled! Mr. Galade, please c..."<br>`[32]` **Ovid Grecer**: "“Overruled! Mr. Galade, please c..."<br>*(oraz 1 innych odgałęzień)* |
| `[31]` | **"Let him continue."** | `[27]` **Lucian Galade**: "“The President told me that if I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Lucian Galade**: "“His underhanded and criminal wa..." |
| `[191]` | **"“Spew your lies as much as you want. Your day will come too.”"** | `[178]` **Lucian Galade**: "“Despite my warnings, he eagerly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Heron Garaci**: "“Silence in the court! Mr. Galad..."<br>`[205]` **Ovid Grecer**: "“Silence in the court! Mr. Galad..."<br>*(oraz 1 innych odgałęzień)* |
| `[192]` | **"“You bastard!”"** | `[178]` **Lucian Galade**: "“Despite my warnings, he eagerly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Heron Garaci**: "“Silence in the court! Mr. Galad..."<br>`[205]` **Ovid Grecer**: "“Silence in the court! Mr. Galad..."<br>*(oraz 1 innych odgałęzień)* |
| `[193]` | **"“Your honor, objection!”"** | `[178]` **Lucian Galade**: "“Despite my warnings, he eagerly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[208]` **Heron Garaci**: "“Overruled! Mr. Galade, please c..."<br>`[206]` **Ovid Grecer**: "“Overruled! Mr. Galade, please c..."<br>*(oraz 1 innych odgałęzień)* |
| `[207]` | **"Let him continue."** | `[178]` **Lucian Galade**: "“Despite my warnings, he eagerly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Lucian Galade**: "“I have provided the court with ..." |
| `[213]` | **"“The tape must be tampered with! I never said that.”"** | `[212]` **Narrator**: "I couldn't believe it. I heard L..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Heron Garaci**: "“Silence!”"<br>`[223]` **Ovid Grecer**: "“Silence!”"<br>*(oraz 1 innych odgałęzień)* |
| `[214]` | **"“Where or when did you even record this?”"** | `[212]` **Narrator**: "I couldn't believe it. I heard L..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Heron Garaci**: "“Silence!”"<br>`[223]` **Ovid Grecer**: "“Silence!”"<br>*(oraz 1 innych odgałęzień)* |
| `[215]` | **"“Providing false evidence is a crime, Lucian.”"** | `[212]` **Narrator**: "I couldn't believe it. I heard L..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Heron Garaci**: "“Silence!”"<br>`[223]` **Ovid Grecer**: "“Silence!”"<br>*(oraz 1 innych odgałęzień)* |
| `[250]` | **"“How long have you been planning this?”"** | `[248]` **Lucian Galade**: "“This man cannot be allowed to b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Heron Garaci**: "“Silence in the court!”"<br>`[261]` **Ovid Grecer**: "“Silence in the court!”"<br>*(oraz 1 innych odgałęzień)* |
| `[251]` | **"“You bit the hand that fed you!”"** | `[248]` **Lucian Galade**: "“This man cannot be allowed to b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Heron Garaci**: "“Silence in the court!”"<br>`[261]` **Ovid Grecer**: "“Silence in the court!”"<br>*(oraz 1 innych odgałęzień)* |
| `[252]` | **"“When I'm done with you...”"** | `[248]` **Lucian Galade**: "“This man cannot be allowed to b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Heron Garaci**: "“Silence in the court!”"<br>`[261]` **Ovid Grecer**: "“Silence in the court!”"<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian Galade, my chief strategist, walked in, making a conscious effort to avoid my gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lucian Galade: "“Thank you, your honor.”"*)

### Węzeł `[4]`
Mówca: **Orso Hawker**
> "“This court now summons Lucian Galade to present his evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Lucian Galade, my chief strategist, walked in, making a c..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Ovid Grecer: "“This court now summons Lucian Galade to present his evid..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Orso Hawker: "“This court now summons Lucian Galade to present his evid..."*)

### Węzeł `[8]`
Mówca: **Heron Garaci**
> "“This court now summons Lucian Galade to present his evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Lucian Galade, my chief strategist, walked in, making a c..."*)

### Węzeł `[9]`
Mówca: **Ovid Grecer**
> "“This court now summons Lucian Galade to present his evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Lucian Galade, my chief strategist, walked in, making a c..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Heron Garaci: "“This court now summons Lucian Galade to present his evid..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[13]`
Mówca: **Lucian Galade**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Lucian sat down at the table."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Lucian sat down at the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "“You too, Lucian?”"*)
  - -> `[16]` (*Player: "“What? Lucian! What the hell is the meaning of this?”"*)
  - -> `[20]` (*Player: "“I didn't think you would stoop so low.”"*)
  - -> `[21]` (*Player_Italic: "Do not make any comments."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“You too, Lucian?”"]** — Mówca: **Player**
> "“You too, Lucian?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: "“Yes, Mr. President. Me too.”"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“What? Lucian! What the hell is the meaning of this?”"]** — Mówca: **Player**
> "“What? Lucian! What the hell is the meaning of this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: "“Precisely what it looks like, Mr. President.”"*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“Precisely what it looks like, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He gave me a small, humorless smile before turning his at..."*)

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“Yes, Mr. President. Me too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He gave me a small, humorless smile before turning his at..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "He gave me a small, humorless smile before turning his attention to the judges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: "“Your honor. Dear attendees.”"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“I didn't think you would stoop so low.”"]** — Mówca: **Player**
> "“I didn't think you would stoop so low.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He gave me a small, humorless smile before turning his at..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "Do not make any comments."]** — Mówca: **Player_Italic**
> "I didn't make any comments."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He gave me a small, humorless smile before turning his at..."*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> "“Your honor. Dear attendees.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucian Galade: "“I worked alongside Anton Rayne for many years and I have..."*)

### Węzeł `[23]`
Mówca: **Lucian Galade**
> "“I worked alongside Anton Rayne for many years and I have seen firsthand how he treats the office of President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: "“Some of the orders he gave me were completely atrocious ..."*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "“His underhanded and criminal ways are certainly grounds for impeachment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Lucian Galade: "“Today, I wish to clean my conscience by aiding in the re..."*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> "“Some of the orders he gave me were completely atrocious and utterly undemocratic. Unfortunately, I had no choice but to obey.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Lucian Galade: "“The President told me that if I failed to carry out his ..."*)

### Węzeł `[26]`
Mówca: **Lucian Galade**
> "“Today, I wish to clean my conscience by aiding in the removal of this rogue president from his post.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[27]`
Mówca: **Lucian Galade**
> "“The President told me that if I failed to carry out his orders, my life would be in danger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: "“Liar!”"*)
  - -> `[29]` (*Player: "“Bullshit!”"*)
  - -> `[30]` (*Player: "“Your honor, objection!”"*)
  - -> `[31]` (*Player_Italic: "Let him continue."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Liar!”"]** — Mówca: **Player**
> "“Liar!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Bullshit!”"]** — Mówca: **Player**
> "“Bullshit!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Your honor, objection!”"]** — Mówca: **Player**
> "“Your honor, objection!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "Let him continue."]** — Mówca: **Player_Italic**
> "I let him continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: "“His underhanded and criminal ways are certainly grounds ..."*)

### Węzeł `[32]`
Mówca: **Ovid Grecer**
> "“Overruled! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“Thank you, your honor.”"*)

### Węzeł `[33]`
Mówca: **Orso Hawker**
> "“Overruled! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“Thank you, your honor.”"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Ovid Grecer: "“Overruled! Mr. Galade, please continue.”"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Orso Hawker: "“Overruled! Mr. Galade, please continue.”"*)

### Węzeł `[37]`
Mówca: **Heron Garaci**
> "“Overruled! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“Thank you, your honor.”"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Heron Garaci: "“Overruled! Mr. Galade, please continue.”"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: "“His underhanded and criminal ways are certainly grounds ..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_Franc_StateUniversity == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_Franc_StateUniversity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lucian Galade: "“My personal investigations turned up shocking news about..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_Franc_StateUniversity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_Franc_StateUniversity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Lucian Galade: "“That is all the evidence I have to present to the Suprem..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == ..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lucian Galade: "“Recently, I managed to uncover a new scandal in the cabi..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true || BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true || ..."*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true |..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true || BaseGame.LeakedScandal_HiddenFunding_YoungSords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true  or  Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucian Galade: "“We all know of the tumultuous events that occurred at th..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true || BaseGame.LeakedScandal_HiddenFunding_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true  or  Variable["BaseGame.LeakedScandal_HiddenFunding_YoungSords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lucian Galade: "“I was personally present when the President attended a s..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "He held up some files."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true || BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillFrensRicter == true || BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true || BaseGame.LeakedScandal_SecretState_KillOrsoHawker == true || BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true || BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true || BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true || BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillOrsoHawker"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true  or  Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true || ..."*)

### Węzeł `[57]`
Mówca: **Orso Hawker**
> "“Thank you for your honesty, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: "“Thank you, your honor.”"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Heron Garaci: "“Thank you for your honesty, Mr. Galade.”"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[61]`
Mówca: **Heron Garaci**
> "“Thank you for your honesty, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: "“Thank you, your honor.”"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Ovid Grecer: "“Thank you for your honesty, Mr. Galade.”"*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Orso Hawker: "“Thank you for your honesty, Mr. Galade.”"*)

### Węzeł `[65]`
Mówca: **Ovid Grecer**
> "“Thank you for your honesty, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: "“Thank you, your honor.”"*)

### Węzeł `[66]`
Mówca: **Lucian Galade**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lucian Galade: "“I wish to present my evidence now.”"*)

### Węzeł `[67]`
Mówca: **Lucian Galade**
> "“I wish to present my evidence now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == t..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "He held up some files."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: "“These documents prove the existence of a new organizatio..."*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> "“These documents prove the existence of a new organization created by Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: "“The Secret State Police.”"*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> "“The Secret State Police.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "There was a collective gasp in the room."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "There was a collective gasp in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lucian Galade: "“Worse than President Rayne's covert creation of this pol..."*)

### Węzeł `[72]`
Mówca: **Lucian Galade**
> "“He has fabricated evidence in order to detain Frens Ricter, leader of the PFJP!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter ==..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Lucian Galade: "“President Rayne targeted the legal and official oppositi..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ==..."*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener ..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Lucian Galade: "“President Rayne targeted the legal and official oppositi..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillFrensRicter == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == t..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillFrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lucian Galade: "“President Rayne targeted the legal and official oppositi..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillFrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillFrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener ==..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Lucian Galade: "“President Rayne targeted the legal and official oppositi..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillKesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillKesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Lucian Galade: "“President Rayne targeted well known state figures in our..."*)

### Węzeł `[85]`
Mówca: **Lucian Galade**
> "“He has fabricated evidence in order to detain Kesaro Kibener, leader of the NFP!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“He ordered the assassination of Frens Ricter, leader of PFJP!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[87]`
Mówca: **Lucian Galade**
> "“He ordered the assassination of Kesaro Kibener, leader of NFP!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> "“He ordered the assassination of Orso Hawker, the Chief Justice of the Supreme Court!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[89]`
Mówca: **Lucian Galade**
> "“Worse than President Rayne's covert creation of this police force is the way in which it was used.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)

### Węzeł `[90]`
Mówca: **Lucian Galade**
> "“The evidence is clear, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucian Galade: "“At the helm of this organization is none other than Karl..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Heron Garaci: "“Mr. Galade, are you sure of this? What you are saying so..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Ovid Grecer: "“Mr. Galade, are you sure of this? What you are saying so..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Orso Hawker: "“Mr. Galade, are you sure of this? What you are saying so..."*)

### Węzeł `[97]`
Mówca: **Ovid Grecer**
> "“Mr. Galade, are you sure of this? What you are saying sounds like borderline conspiracy. It would create great ripples across our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: "“The evidence is clear, your honor.”"*)

### Węzeł `[98]`
Mówca: **Heron Garaci**
> "“Mr. Galade, are you sure of this? What you are saying sounds like borderline conspiracy. It would create great ripples across our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: "“The evidence is clear, your honor.”"*)

### Węzeł `[99]`
Mówca: **Orso Hawker**
> "“Mr. Galade, are you sure of this? What you are saying sounds like borderline conspiracy. It would create great ripples across our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: "“The evidence is clear, your honor.”"*)

### Węzeł `[100]`
Mówca: **Lucian Galade**
> "“At the helm of this organization is none other than Karl Greiser, the head of police forces in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[101]`
Mówca: **Orso Hawker**
> "“Let's hear it from the man himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[102]`
Mówca: **Ovid Grecer**
> "“Let's hear it from the man himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Ovid Grecer: "“Let's hear it from the man himself.”"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Orso Hawker: "“Let's hear it from the man himself.”"*)

### Węzeł `[106]`
Mówca: **Heron Garaci**
> "“Let's hear it from the man himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Heron Garaci: "“Let's hear it from the man himself.”"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[110]`
Mówca: **Lucian Galade**
> "“Your honor, I beg you to recuse Mr. Greiser. Just like me, he was merely following orders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[111]`
Mówca: **Ovid Grecer**
> "“Of course. This court knows that Mr. Greiser is a man of respect and loyalty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucian Galade: "“Thank you.”"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Heron Garaci: "“Of course. This court knows that Mr. Greiser is a man of..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Ovid Grecer: "“Of course. This court knows that Mr. Greiser is a man of..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Orso Hawker: "“Of course. This court knows that Mr. Greiser is a man of..."*)

### Węzeł `[118]`
Mówca: **Orso Hawker**
> "“Of course. This court knows that Mr. Greiser is a man of respect and loyalty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucian Galade: "“Thank you.”"*)

### Węzeł `[119]`
Mówca: **Heron Garaci**
> "“Of course. This court knows that Mr. Greiser is a man of respect and loyalty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucian Galade: "“Thank you.”"*)

### Węzeł `[120]`
Mówca: **Lucian Galade**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[121]`
Mówca: **Orso Hawker**
> "“Thank you, Mr. Greiser. You may leave the courtroom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Orso Hawker: "“Back to you, Mr. Galade.”"*)

### Węzeł `[122]`
Mówca: **Ovid Grecer**
> "“Thank you, Mr. Greiser. You may leave the courtroom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Ovid Grecer: "“Back to you, Mr. Galade.”"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Heron Garaci: "“Thank you, Mr. Greiser. You may leave the courtroom.”"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Ovid Grecer: "“Thank you, Mr. Greiser. You may leave the courtroom.”"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Orso Hawker: "“Thank you, Mr. Greiser. You may leave the courtroom.”"*)

### Węzeł `[129]`
Mówca: **Heron Garaci**
> "“Thank you, Mr. Greiser. You may leave the courtroom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Heron Garaci: "“Back to you, Mr. Galade.”"*)

### Węzeł `[130]`
Mówca: **Orso Hawker**
> "“Back to you, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true || ..."*)

### Węzeł `[131]`
Mówca: **Ovid Grecer**
> "“Back to you, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true || ..."*)

### Węzeł `[132]`
Mówca: **Heron Garaci**
> "“Back to you, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true || ..."*)

### Węzeł `[133]`
Mówca: **Lucian Galade**
> "“We all know of the tumultuous events that occurred at the beginning of our term.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Lucian Galade: "“The killing of Bernard Circas caused a spike in politica..."*)

### Węzeł `[134]`
Mówca: **Lucian Galade**
> "“The killing of Bernard Circas caused a spike in political violence like never seen before.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lucian Galade: "“The conflict was exacerbated by both the Young Sords and..."*)

### Węzeł `[135]`
Mówca: **Lucian Galade**
> "“The conflict was exacerbated by both the Young Sords and the Red Youth.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)

### Węzeł `[136]`
Mówca: **Lucian Galade**
> "“I believe the court will be surprised to hear that Mr. President has been secretly funding the Red Youth, a communist organization, illegally.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_HiddenFunding_RedYouth == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_HiddenFunding_RedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Lucian Galade: "“I believe the court will be surprised to hear that Mr. P..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_HiddenFunding_RedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_HiddenFunding_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Lucian Galade: "“I believe the court will be surprised to hear that Mr. P..."*)

### Węzeł `[140]`
Mówca: **Lucian Galade**
> "“I believe the court will be surprised to hear that Mr. President has been secretly funding the Young Sords, illegally.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[141]`
Mówca: **Heron Garaci**
> "“Mr. Galade. Do you claim that Mr. President has indirectly caused violence in Sordland by funding this organization?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: "“I do, your honor.”"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Heron Garaci: "“Mr. Galade. Do you claim that Mr. President has indirect..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Ovid Grecer: "“Mr. Galade. Do you claim that Mr. President has indirect..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Orso Hawker: "“Mr. Galade. Do you claim that Mr. President has indirect..."*)

### Węzeł `[148]`
Mówca: **Ovid Grecer**
> "“Mr. Galade. Do you claim that Mr. President has indirectly caused violence in Sordland by funding this organization?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: "“I do, your honor.”"*)

### Węzeł `[149]`
Mówca: **Orso Hawker**
> "“Mr. Galade. Do you claim that Mr. President has indirectly caused violence in Sordland by funding this organization?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucian Galade: "“I do, your honor.”"*)

### Węzeł `[150]`
Mówca: **Lucian Galade**
> "“I do, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[151]`
Mówca: **Orso Hawker**
> "“I see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Ovid Grecer: "“I see.”"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Orso Hawker: "“I see.”"*)

### Węzeł `[155]`
Mówca: **Ovid Grecer**
> "“I see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Heron Garaci: "“I see.”"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[159]`
Mówca: **Heron Garaci**
> "“I see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[160]`
Mówca: **Lucian Galade**
> "“Recently, I managed to uncover a new scandal in the cabinet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lucian Galade: "“I have learned that Mr. President has procured a persona..."*)

### Węzeł `[161]`
Mówca: **Lucian Galade**
> "“I have learned that Mr. President has procured a personal stake in Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lucian Galade: "“It is not a coincidence that Underhall was picked as the..."*)

### Węzeł `[162]`
Mówca: **Lucian Galade**
> "“It is not a coincidence that Underhall was picked as the contractor for one of the largest projects this government has undertaken.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Lucian Galade: "“I ask you this. Can we trust this man to lead our countr..."*)

### Węzeł `[163]`
Mówca: **Lucian Galade**
> "“I ask you this. Can we trust this man to lead our country when he would stop at nothing to increase his own wealth?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[164]`
Mówca: **Heron Garaci**
> "“You are making a good point, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Ovid Grecer: "“You are making a good point, Mr. Galade.”"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Orso Hawker: "“You are making a good point, Mr. Galade.”"*)

### Węzeł `[168]`
Mówca: **Ovid Grecer**
> "“You are making a good point, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Heron Garaci: "“You are making a good point, Mr. Galade.”"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[172]`
Mówca: **Orso Hawker**
> "“You are making a good point, Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[173]`
Mówca: **Lucian Galade**
> "“I was personally present when the President attended a secret backroom meeting in Conriat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucian Galade: "“This meeting was with Marcel Koronti, the CEO of Heart o..."*)

### Węzeł `[174]`
Mówca: **Lucian Galade**
> "“This meeting was with Marcel Koronti, the CEO of Heart of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Lucian Galade: "“He offered a deal to President Rayne. An unlawful one.”"*)

### Węzeł `[175]`
Mówca: **Lucian Galade**
> "“He offered a deal to President Rayne. An unlawful one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Lucian Galade: "“In return for special protections from the Sordish gover..."*)

### Węzeł `[176]`
Mówca: **Lucian Galade**
> "“In return for special protections from the Sordish government, he would effectively skew all major media in the President's favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Lucian Galade: "“I begged Mr. Rayne not to accept.”"*)

### Węzeł `[177]`
Mówca: **Lucian Galade**
> "“I begged Mr. Rayne not to accept.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lucian Galade: "“Despite my warnings, he eagerly took the deal. The resul..."*)

### Węzeł `[178]`
Mówca: **Lucian Galade**
> "“Despite my warnings, he eagerly took the deal. The results are all too apparent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player: "“Spew your lies as much as you want. Your day will come t..."*)
  - -> `[192]` (*Player: "“You bastard!”"*)
  - -> `[193]` (*Player: "“Your honor, objection!”"*)
  - -> `[207]` (*Player_Italic: "Let him continue."*)

### Węzeł `[179]`
Mówca: **Ovid Grecer**
> "“Silence in the court! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“Thank you, your honor.”"*)

### Węzeł `[180]`
Mówca: **Orso Hawker**
> "“Silence in the court! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“Thank you, your honor.”"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Ovid Grecer: "“Silence in the court! Mr. Galade, please continue.”"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Orso Hawker: "“Silence in the court! Mr. Galade, please continue.”"*)

### Węzeł `[184]`
Mówca: **Heron Garaci**
> "“Silence in the court! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: "“Thank you, your honor.”"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Heron Garaci: "“Silence in the court! Mr. Galade, please continue.”"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Heron Garaci: "“Silence in the court! Mr. Galade, please continue.”"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[191]`
**[WYBÓR GRACZA: "“Spew your lies as much as you want. Your day will come too.”"]** — Mówca: **Player**
> "“Spew your lies as much as you want. Your day will come too.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[192]`
**[WYBÓR GRACZA: "“You bastard!”"]** — Mówca: **Player**
> "“You bastard!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[193]`
**[WYBÓR GRACZA: "“Your honor, objection!”"]** — Mówca: **Player**
> "“Your honor, objection!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Ovid Grecer: "“Overruled! Mr. Galade, please continue.”"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Orso Hawker: "“Overruled! Mr. Galade, please continue.”"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Heron Garaci: "“Overruled! Mr. Galade, please continue.”"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[200]`
Mówca: **Heron Garaci**
> "“Silence in the court! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucian Galade: "“I have provided the court with voice recordings of said ..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Ovid Grecer: "“Silence in the court! Mr. Galade, please continue.”"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Orso Hawker: "“Silence in the court! Mr. Galade, please continue.”"*)

### Węzeł `[204]`
Mówca: **Orso Hawker**
> "“Silence in the court! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucian Galade: "“I have provided the court with voice recordings of said ..."*)

### Węzeł `[205]`
Mówca: **Ovid Grecer**
> "“Silence in the court! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucian Galade: "“I have provided the court with voice recordings of said ..."*)

### Węzeł `[206]`
Mówca: **Ovid Grecer**
> "“Overruled! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucian Galade: "“I have provided the court with voice recordings of said ..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: "Let him continue."]** — Mówca: **Player_Italic**
> "I let him continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucian Galade: "“I have provided the court with voice recordings of said ..."*)

### Węzeł `[208]`
Mówca: **Heron Garaci**
> "“Overruled! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucian Galade: "“I have provided the court with voice recordings of said ..."*)

### Węzeł `[209]`
Mówca: **Orso Hawker**
> "“Overruled! Mr. Galade, please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucian Galade: "“I have provided the court with voice recordings of said ..."*)

### Węzeł `[210]`
Mówca: **Lucian Galade**
> "“I have provided the court with voice recordings of said meeting as well as the full transcript.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "A court assistant brought out a tape recorder and pressed..."*)

### Węzeł `[211]`
Mówca: **Narrator**
> "A court assistant brought out a tape recorder and pressed play."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "I couldn't believe it. I heard Lucian's voice begging me ..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "I couldn't believe it. I heard Lucian's voice begging me not to accept Marcel's deal, and myself angrily overriding him. This definitely wasn't how it had happened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player: "“The tape must be tampered with! I never said that.”"*)
  - -> `[214]` (*Player: "“Where or when did you even record this?”"*)
  - -> `[215]` (*Player: "“Providing false evidence is a crime, Lucian.”"*)

### Węzeł `[213]`
**[WYBÓR GRACZA: "“The tape must be tampered with! I never said that.”"]** — Mówca: **Player**
> "“The tape must be tampered with! I never said that.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "“Where or when did you even record this?”"]** — Mówca: **Player**
> "“Where or when did you even record this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Providing false evidence is a crime, Lucian.”"]** — Mówca: **Player**
> "“Providing false evidence is a crime, Lucian.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[216]`
Mówca: **Orso Hawker**
> "“Silence!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Ovid Grecer: "“Silence!”"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Orso Hawker: "“Silence!”"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Heron Garaci: "“Silence!”"*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[223]`
Mówca: **Ovid Grecer**
> "“Silence!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[224]`
Mówca: **Heron Garaci**
> "“Silence!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_Franc_StateUniversity == true"*)

### Węzeł `[225]`
Mówca: **Lucian Galade**
> "“My personal investigations turned up shocking news about President Rayne's seemingly perfect family.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Lucian Galade: ""His son, Franc Rayne, is currently studying at Holsord S..."*)

### Węzeł `[226]`
Mówca: **Lucian Galade**
> ""His son, Franc Rayne, is currently studying at Holsord State University.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Lucian Galade: "“During a meeting with the Minister of Education Ciara Wa..."*)

### Węzeł `[227]`
Mówca: **Lucian Galade**
> "“During a meeting with the Minister of Education Ciara Walda, I came across a list of university exam marks received by the children of government officials.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Lucian Galade: "“My curiosity got the better of me and I found Franc Rayn..."*)

### Węzeł `[228]`
Mówca: **Lucian Galade**
> "“My curiosity got the better of me and I found Franc Rayne's scores.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lucian Galade: "“They disqualified him from nearly every university in th..."*)

### Węzeł `[229]`
Mówca: **Lucian Galade**
> "“They disqualified him from nearly every university in the country, let alone Holsord State. So I followed the trail.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Lucian Galade: "“I found out that the President abused his power to grant..."*)

### Węzeł `[230]`
Mówca: **Lucian Galade**
> "“I found out that the President abused his power to grant his son acceptance into Holsord State University.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "He held up a paper."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "He held up a paper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Lucian Galade: "“This is the list I mentioned as well as the enrollment i..."*)

### Węzeł `[232]`
Mówca: **Lucian Galade**
> "“This is the list I mentioned as well as the enrollment information from the university.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Lucian Galade: "“That is all the evidence I have to present to the Suprem..."*)

### Węzeł `[233]`
Mówca: **Lucian Galade**
> "“That is all the evidence I have to present to the Supreme Court today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[234]`
Mówca: **Ovid Grecer**
> "“Thank you, Mr. Galade. We will take the substantial evidence you have provided into consideration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Ovid Grecer: "“You may leave.”"*)

### Węzeł `[235]`
Mówca: **Orso Hawker**
> "“Thank you, Mr. Galade. We will take the substantial evidence you have provided into consideration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Orso Hawker: "“You may leave.”"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Ovid Grecer: "“Thank you, Mr. Galade. We will take the substantial evid..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Orso Hawker: "“Thank you, Mr. Galade. We will take the substantial evid..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Heron Garaci: "“Thank you, Mr. Galade. We will take the substantial evid..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[242]`
Mówca: **Heron Garaci**
> "“Thank you, Mr. Galade. We will take the substantial evidence you have provided into consideration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Heron Garaci: "“You may leave.”"*)

### Węzeł `[243]`
Mówca: **Heron Garaci**
> "“You may leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Lucian Galade: "“I would like to have a closing word.”"*)

### Węzeł `[244]`
Mówca: **Ovid Grecer**
> "“You may leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Lucian Galade: "“I would like to have a closing word.”"*)

### Węzeł `[245]`
Mówca: **Orso Hawker**
> "“You may leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Lucian Galade: "“I would like to have a closing word.”"*)

### Węzeł `[246]`
Mówca: **Lucian Galade**
> "“I would like to have a closing word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Lucian Galade: "“This man cannot be allowed to be President of Sordland. ..."*)

### Węzeł `[247]`
Mówca: **Lucian Galade**
> "“Thank you for your time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Lucian rose up from his seat and with one last look back ..."*)

### Węzeł `[248]`
Mówca: **Lucian Galade**
> "“This man cannot be allowed to be President of Sordland. The evidence is clear and we need to uphold the law. I have full confidence that this court will bring Anton Rayne to justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player: "“How long have you been planning this?”"*)
  - -> `[251]` (*Player: "“You bit the hand that fed you!”"*)
  - -> `[252]` (*Player: "“When I'm done with you...”"*)

### Węzeł `[249]`
Mówca: **Narrator**
> "Lucian rose up from his seat and with one last look back at me, he left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[250]`
**[WYBÓR GRACZA: "“How long have you been planning this?”"]** — Mówca: **Player**
> "“How long have you been planning this?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[251]`
**[WYBÓR GRACZA: "“You bit the hand that fed you!”"]** — Mówca: **Player**
> "“You bit the hand that fed you!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[252]`
**[WYBÓR GRACZA: "“When I'm done with you...”"]** — Mówca: **Player**
> "“When I'm done with you...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[248]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Ovid Grecer: "“Silence in the court!”"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Orso Hawker: "“Silence in the court!”"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Heron Garaci: "“Silence in the court!”"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[259]`
Mówca: **Heron Garaci**
> "“Silence in the court!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Lucian Galade: "“Thank you for your time.”"*)

### Węzeł `[260]`
Mówca: **Orso Hawker**
> "“Silence in the court!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Lucian Galade: "“Thank you for your time.”"*)

### Węzeł `[261]`
Mówca: **Ovid Grecer**
> "“Silence in the court!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Lucian Galade: "“Thank you for your time.”"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern ==..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Lucian Galade: "“Ladies and gentlemen. I am shocked to tell you that I ha..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillPetrVectern == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == t..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillPetrVectern == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Lucian Galade: "“Ladies and gentlemen. I am shocked to tell you that I ha..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillPetrVectern == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillPetrVectern"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[268]`
Mówca: **Lucian Galade**
> "“Ladies and gentlemen. I am shocked to tell you that I have evidence that Mr. President used the Secret State Police to detain Petr Vectern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Lucian Galade: "“President of Sordland had his own Vice President arreste..."*)

### Węzeł `[269]`
Mówca: **Lucian Galade**
> "“President of Sordland had his own Vice President arrested! Not just his Vice President... his best friend!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Lucian Galade: "“This is the type of person Anton Rayne is!”"*)

### Węzeł `[270]`
Mówca: **Lucian Galade**
> "“This is the type of person Anton Rayne is!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[271]`
Mówca: **Lucian Galade**
> "“Ladies and gentlemen. I am shocked to tell you that I have evidence that Mr. President used the Secret State Police to have Petr Vectern assassinated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Lucian Galade: "“President of Sordland had his own Vice President killed!..."*)

### Węzeł `[272]`
Mówca: **Lucian Galade**
> "“President of Sordland had his own Vice President killed! Not just his Vice President... his best friend!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Lucian Galade: "“This is the type of person Anton Rayne is!”"*)

### Węzeł `[273]`
Mówca: **Lucian Galade**
> "“This is the type of person Anton Rayne is!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)

### Węzeł `[274]`
Mówca: **Lucian Galade**
> "“The evidence is clear. I have the papers detailing that Mr. President had his then secretary, Ms. Suno detained.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == t..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Lucian Galade: "“The evidence is clear. I have the papers detailing that ..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_DetainLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_DetainLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Lucian Galade: "“The evidence is clear. I have the papers detailing that ..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_SecretState_KillLiviaSuno == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_SecretState_KillLiviaSuno"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[281]`
Mówca: **Lucian Galade**
> "“The evidence is clear. I have the papers detailing that Mr. President had his then secretary, Ms. Suno killed!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_SecretState_DetainFrensRicter == true"*)

### Węzeł `[282]`
Mówca: **Lucian Galade**
> "“President Rayne targeted the legal and official opposition the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: "“He has fabricated evidence in order to detain Frens Rict..."*)

### Węzeł `[283]`
Mówca: **Lucian Galade**
> "“President Rayne targeted the legal and official opposition the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucian Galade: "“He has fabricated evidence in order to detain Kesaro Kib..."*)

### Węzeł `[284]`
Mówca: **Lucian Galade**
> "“President Rayne targeted the legal and official opposition the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: "“He ordered the assassination of Frens Ricter, leader of ..."*)

### Węzeł `[285]`
Mówca: **Lucian Galade**
> "“President Rayne targeted the legal and official opposition the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lucian Galade: "“He ordered the assassination of Kesaro Kibener, leader o..."*)

### Węzeł `[286]`
Mówca: **Lucian Galade**
> "“President Rayne targeted well known state figures in our government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: "“He ordered the assassination of Orso Hawker, the Chief J..."*)
