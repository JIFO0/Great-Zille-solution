# Sordland/Turn11/Nia ACP Evidence

- **ID konwersacji:** `247`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/247_Nia_ACP_Evidence.md`
- **Liczba węzłów dialogowych:** 147
- **Liczba wyborów gracza:** 7

---

## 1. Uczestnicy Sceny

- **[1]** Ovid Grecer
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[9]** Nia Morgna
- **[10]** Narrator
- **[36]** Heron Garaci

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.ChiefJustice_HeronGaraci`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.LeakedScandal_AlbinClavin_Bribe`
- `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP`
- `BaseGame.LeakedScandal_FrensRicter_Bribe`
- `BaseGame.LeakedScandal_FrensRicter_TaurusBribe`
- `BaseGame.LeakedScandal_GusManger_UnderhallCollusion`
- `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal`
- `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation`
- `BaseGame.LeakedScandal_PrivatizationShares_Both`
- `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti`
- `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk`
- `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses`
- `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp`
- `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe`
- `BaseGame.Resigned_NiaMorgna`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[246] Sordland/Turn11/A_ImpeachmentTrial** (../Turn_11/246_A_ImpeachmentTrial.md), Węzeł `[42]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **"“After all I have done for you, you betrayed me.”"** | `[78]` **Nia Morgna**: "“Thank you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Nia Morgna**: "“No. You betrayed your country.”" |
| `[21]` | **"“You little snake! I will have your head!”"** | `[78]` **Nia Morgna**: "“Thank you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "Loud chatter started spreading t..." |
| `[43]` | **"Don't say anything."** | `[78]` **Nia Morgna**: "“Thank you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "Loud chatter started spreading t..." |
| `[82]` | **"“Objection!”"** | `[78]` **Nia Morgna**: "“Thank you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Heron Garaci**: "“Overruled!”"<br>`[99]` **Ovid Grecer**: "“Overruled!”"<br>*(oraz 1 innych odgałęzień)* |
| `[130]` | **"“Nia. Don't do this. Please. I beg you.”"** | `[17]` **Nia Morgna**: "“Thank you, your honor.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Nia Morgna**: "“It's too late now, Mr. Presiden..." |
| `[131]` | **"“I regret the day I made the decision to let you into my cabinet.”"** | `[17]` **Nia Morgna**: "“Thank you, your honor.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Nia Morgna**: "“It's too late now, Mr. Presiden..." |
| `[132]` | **"“I was a fool to trust you.”"** | `[17]` **Nia Morgna**: "“Thank you, your honor.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Nia Morgna**: "“I could say the same, Mr. Presi..." |

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
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Nia Morgna: "“What we found was, quite frankly, shocking.”"*)

### Węzeł `[3]`
Mówca: **Ovid Grecer**
> "“Silence! Silence in the court!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Ovid Grecer: "“Thank you, Mrs. Morgna. You may leave the courtroom.”"*)

### Węzeł `[4]`
Mówca: **Heron Garaci**
> "“Silence! Silence in the court!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Heron Garaci: "“Thank you, Mrs. Morgna. You may leave the courtroom.”"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "“After all I have done for you, you betrayed me.”"]** — Mówca: **Player**
> "“After all I have done for you, you betrayed me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Nia Morgna: "“No. You betrayed your country.”"*)

### Węzeł `[6]`
Mówca: **Nia Morgna**
> "“Mr. President personally prevented an investigation into Mr. Koronti's connections with the Koranelli Cartel, making him an accomplice and a criminal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_Both == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Nia Morgna: "“We have found evidence of backroom dealings related to t..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_Both == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Nia Morgna, the Minister of Justice and the head of the Anti-Corruption Police, entered the room. She barely looked at me as she took her place before the judges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Nia Morgna: "“Thank you, your honor.”"*)

### Węzeł `[11]`
Mówca: **Nia Morgna**
> "“No. You betrayed your country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Loud chatter started spreading through the courtroom."*)

### Węzeł `[12]`
Mówca: **Nia Morgna**
> "“We have found evidence of backroom dealings related to the privatization of Sordland's national corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Nia Morgna: "“Before the shares from privatization could go on the pub..."*)

### Węzeł `[13]`
Mówca: **Nia Morgna**
> "“Before the shares from privatization could go on the public market, President Rayne granted them directly to oligarchs Marcel Koronti and Walter Tusk. This is a criminal offence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == tr..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Nia Morgna: "“By the President's order, we began a probe into the powe..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[17]`
Mówca: **Nia Morgna**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "“Nia. Don't do this. Please. I beg you.”"*)
  - -> `[131]` (*Player: "“I regret the day I made the decision to let you into my ..."*)
  - -> `[132]` (*Player: "“I was a fool to trust you.”"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoront..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Nia Morgna: "“We have found evidence of backroom dealings related to t..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“You little snake! I will have your head!”"]** — Mówca: **Player**
> "“You little snake! I will have your head!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Loud chatter started spreading through the courtroom."*)

### Węzeł `[22]`
Mówca: **Nia Morgna**
> "“Before the shares from privatization could go on the public market, President Rayne granted them directly to Marcel Koronti. This is a criminal offence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == tr..."*)

### Węzeł `[23]`
Mówca: **Nia Morgna**
> "“We have found evidence of backroom dealings related to the privatization of Sordland's national corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Nia Morgna: "“Before the shares from privatization could go on the pub..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == t..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Nia Morgna: "“Our investigations found that during the constitutional ..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Nia approached the table next to mine and sat down with a large stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Nia Morgna: "“As the head of the Anti-Corruption Police, I have been t..."*)

### Węzeł `[28]`
Mówca: **Nia Morgna**
> "“Before the shares from privatization could go on the public market, President Rayne granted them directly to Walter Tusk. This is a criminal offence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == tr..."*)

### Węzeł `[29]`
Mówca: **Nia Morgna**
> "“We have found evidence of backroom dealings related to the privatization of Sordland's national corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Nia Morgna: "“Before the shares from privatization could go on the pub..."*)

### Węzeł `[30]`
Mówca: **Nia Morgna**
> "“As the head of the Anti-Corruption Police, I have been tasked by President Rayne to root out and eliminate corruption in the government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Nia Morgna: "“During our investigations, we have found dire incriminat..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Heron Garaci: "“Silence! Silence in the court!”"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == tr..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == ..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Nia Morgna: "“My Anti-Corruption Police force was asked to look into W..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Nia Morgna: "“As you can see, there is substantial incriminating evide..."*)

### Węzeł `[37]`
Mówca: **Nia Morgna**
> "“By the President's order, we began a probe into the powerful media mogul Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Nia Morgna: "“We found that shortly after Mr. Rayne took office, Mr. K..."*)

### Węzeł `[38]`
Mówca: **Nia Morgna**
> "“During our investigations, we have found dire incriminating evidence against Mr. President himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Nia Morgna: "“I, being a member of the cabinet and having worked with ..."*)

### Węzeł `[39]`
Mówca: **Nia Morgna**
> "“I, being a member of the cabinet and having worked with the defendant for many years, did not want to believe what I heard and saw. Yet the evidence could not be ignored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Nia Morgna: "“I have dedicated my life to the pursuit of justice, and ..."*)

### Węzeł `[40]`
Mówca: **Nia Morgna**
> "“My Anti-Corruption Police force was asked to look into Walter Tusk, the spokesperson for the Lotherberg Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Nia Morgna: "“What we found was, quite frankly, shocking.”"*)

### Węzeł `[41]`
Mówca: **Nia Morgna**
> "“According to the evidence, Mr. Manger offered the President a personal stake in Underhall Construction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Nia Morgna: "“President Rayne subsequently chose Underhall Constructio..."*)

### Węzeł `[42]`
Mówca: **Nia Morgna**
> "“What we found was, quite frankly, shocking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I sat there, quietly seething."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Loud chatter started spreading through the courtroom."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == ..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Nia Morgna: "“The President's business bailout was a direct result of ..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Nia Morgna: "“The tax cuts for large corporations were the product of ..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Nia Morgna: "“Mr. Tusk engaged the President in flat-out bribery to en..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Nia Morgna: "“As you can see, there is substantial incriminating evide..."*)

### Węzeł `[53]`
Mówca: **Nia Morgna**
> "“I have dedicated my life to the pursuit of justice, and that dedication has led me to a position of utmost responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Nia Morgna: "“I am obligated to uphold my ideals by revealing the real..."*)

### Węzeł `[54]`
Mówca: **Nia Morgna**
> "“The President's business bailout was a direct result of hidden dealings with Mr. Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[55]`
Mówca: **Nia Morgna**
> "“We found that shortly after Mr. Rayne took office, Mr. Koronti offered the President what amounted to government control over Sordland's major media in exchange for special protections for his conglomerate, Heart of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Nia Morgna: "“The President accepted. Needless to say, this deal is a ..."*)

### Węzeł `[56]`
Mówca: **Nia Morgna**
> "“I am obligated to uphold my ideals by revealing the reality behind Anton Rayne, the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[57]`
Mówca: **Nia Morgna**
> "“President Rayne subsequently chose Underhall Construction as the contractor for his new government megaproject, siphoning millions of SR from the government to his company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[58]`
Mówca: **Nia Morgna**
> "“The tax cuts for large corporations were the product of a hidden deal between Mr. Tusk and Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[59]`
Mówca: **Nia Morgna**
> "“I hereby present the following allegations against Anton Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)

### Węzeł `[60]`
Mówca: **Nia Morgna**
> "“Mr. Tusk engaged the President in flat-out bribery to ensure that his company Underhall Construction would be selected as the main contractor for a major infrastructure project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Nia Morgna: "“As you can see, there is substantial incriminating evide..."*)

### Węzeł `[61]`
Mówca: **Nia Morgna**
> "“The President accepted. Needless to say, this deal is a horrifying breach of democratic values.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Nia Morgna: "“Our investigations found a large sum of money transferre..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[65]`
Mówca: **Nia Morgna**
> "“Our investigations have revealed President Rayne's involvement in a bribery scheme with PFJP leader Frens Ricter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Nia Morgna: "“In return for his support in the Assembly, Frens Ricter ..."*)

### Węzeł `[66]`
Mówca: **Nia Morgna**
> "“As you can see, there is substantial incriminating evidence against Anton Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Nia Morgna: "“As the man holding the highest office in this country, h..."*)

### Węzeł `[67]`
Mówca: **Nia Morgna**
> "“Our investigations have revealed President Rayne's involvement in a bribery scheme with PFJP leader Frens Ricter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Nia Morgna: "“In return for Mr. Ricter's support in the Assembly, the ..."*)

### Węzeł `[68]`
Mówca: **Orso Hawker**
> "“Silence! Silence in the court!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Orso Hawker: "“Thank you, Mrs. Morgna. You may leave the courtroom.”"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigatio..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Nia Morgna: "“Mr. President has been involved in the obstruction of ju..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_Both == true"*)

### Węzeł `[72]`
Mówca: **Nia Morgna**
> "“As the man holding the highest office in this country, he should be a shining example of democracy. Instead, he has abused his position for his own personal gain and desecrated Sordland's democratic ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Nia Morgna: "“I hope this court sees the ugly truth and relieves Anton..."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Ovid Grecer: "“Silence! Silence in the court!”"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Orso Hawker: "“Silence! Silence in the court!”"*)

### Węzeł `[76]`
Mówca: **Nia Morgna**
> "“I hope this court sees the ugly truth and relieves Anton Rayne from his presidency once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Nia Morgna: "“Thank you.”"*)

### Węzeł `[77]`
Mówca: **Nia Morgna**
> "“We have found a direct conflict of interest linked to the Minister of Agriculture and Rural Development, Gus Manger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Nia Morgna: "“According to the evidence, Mr. Manger offered the Presid..."*)

### Węzeł `[78]`
Mówca: **Nia Morgna**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: "“After all I have done for you, you betrayed me.”"*)
  - -> `[82]` (*Player: "“Objection!”"*)
  - -> `[21]` (*Player: "“You little snake! I will have your head!”"*)
  - -> `[43]` (*Player_Italic: "Don't say anything."*)

### Węzeł `[79]`
Mówca: **Nia Morgna**
> "“Our investigations found that during the constitutional reform process, Anton Rayne promised Albin Clavin the position of Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Nia Morgna: "“It is therefore no coincidence that, not long after Mr. ..."*)

### Węzeł `[80]`
Mówca: **Nia Morgna**
> "“Mr. President has been involved in the obstruction of justice by tipping off the subject of a government investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Nia Morgna: "“The person in question is Marcel Koronti.”"*)

### Węzeł `[81]`
Mówca: **Nia Morgna**
> "“Our investigations found a large sum of money transferred between Anton Rayne and Albin Clavin during the constitutional reform process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Nia Morgna: "“All evidence suggests that this was a bribe meant to sec..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Objection!”"]** — Mówca: **Player**
> "“Objection!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[83]`
Mówca: **Nia Morgna**
> "“The person in question is Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Nia Morgna: "“Mr. President personally prevented an investigation into..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == ..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Nia Morgna: "“We have found a direct conflict of interest linked to th..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[87]`
Mówca: **Narrator**
> "Loud chatter started spreading through the courtroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[88]`
Mówca: **Nia Morgna**
> "“In return for his support in the Assembly, Frens Ricter received a large sum of money from the President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[89]`
Mówca: **Nia Morgna**
> "“All evidence suggests that this was a bribe meant to secure Mr. Clavin's support for the constitutional changes in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Heron Garaci: "“Overruled!”"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Ovid Grecer: "“Overruled!”"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Orso Hawker: "“Overruled!”"*)

### Węzeł `[96]`
Mówca: **Nia Morgna**
> "“It is therefore no coincidence that, not long after Mr. Clavin supported the President's reforms in the Assembly, he was offered the Vice Presidency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[97]`
Mówca: **Heron Garaci**
> "“Overruled!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Loud chatter started spreading through the courtroom."*)

### Węzeł `[98]`
Mówca: **Orso Hawker**
> "“Overruled!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Loud chatter started spreading through the courtroom."*)

### Węzeł `[99]`
Mówca: **Ovid Grecer**
> "“Overruled!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Loud chatter started spreading through the courtroom."*)

### Węzeł `[100]`
Mówca: **Nia Morgna**
> "“In return for Mr. Ricter's support in the Assembly, the President promised to favor Taurus Holding, a company that Frens Ricter is directly involved in, for government infrastructure projects. This is a baldfaced conflict of interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Nia Morgna: "“Our investigations have revealed President Rayne's invol..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Nia Morgna: "“Our investigations have revealed President Rayne's invol..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Nia gathered her documents and left the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[108]`
Mówca: **Orso Hawker**
> "“This court now summons Nia Morgna to present the evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Ovid Grecer: "“This court now summons Nia Morgna to present the evidence.”"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Orso Hawker: "“This court now summons Nia Morgna to present the evidence.”"*)

### Węzeł `[112]`
Mówca: **Heron Garaci**
> "“This court now summons Nia Morgna to present the evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[113]`
Mówca: **Ovid Grecer**
> "“This court now summons Nia Morgna to present the evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Heron Garaci: "“This court now summons Nia Morgna to present the evidence.”"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[117]`
Mówca: **Orso Hawker**
> "“Thank you, Mrs. Morgna. You may leave the courtroom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Nia gathered her documents and left the table."*)

### Węzeł `[118]`
Mówca: **Ovid Grecer**
> "“Thank you, Mrs. Morgna. You may leave the courtroom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Nia gathered her documents and left the table."*)

### Węzeł `[119]`
Mówca: **Heron Garaci**
> "“Thank you, Mrs. Morgna. You may leave the courtroom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Nia gathered her documents and left the table."*)

### Węzeł `[120]`
Mówca: **Ovid Grecer**
> "“Your hard work and dedication to justice are acknowledged and appreciated by the members of this court, Mrs. Morgna.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Nia Morgna: "“Thank you, your honor.”"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Heron Garaci: "“Your hard work and dedication to justice are acknowledge..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Ovid Grecer: "“Your hard work and dedication to justice are acknowledge..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Orso Hawker: "“Your hard work and dedication to justice are acknowledge..."*)

### Węzeł `[127]`
Mówca: **Heron Garaci**
> "“Your hard work and dedication to justice are acknowledged and appreciated by the members of this court, Mrs. Morgna.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Nia Morgna: "“Thank you, your honor.”"*)

### Węzeł `[128]`
Mówca: **Orso Hawker**
> "“Your hard work and dedication to justice are acknowledged and appreciated by the members of this court, Mrs. Morgna.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Nia Morgna: "“Thank you, your honor.”"*)

### Węzeł `[129]`
Mówca: **Nia Morgna**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Nia Morgna: "“I hereby present the following allegations against Anton..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Nia. Don't do this. Please. I beg you.”"]** — Mówca: **Player**
> "“Nia. Don't do this. Please. I beg you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Nia Morgna: "“It's too late now, Mr. President. Justice will be served..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“I regret the day I made the decision to let you into my cabinet.”"]** — Mówca: **Player**
> "“I regret the day I made the decision to let you into my cabinet.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Nia Morgna: "“It's too late now, Mr. President. Justice will be served..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“I was a fool to trust you.”"]** — Mówca: **Player**
> "“I was a fool to trust you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Nia Morgna: "“I could say the same, Mr. President. But don't worry. Ju..."*)

### Węzeł `[133]`
Mówca: **Nia Morgna**
> "“It's too late now, Mr. President. Justice will be served today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Nia approached the table next to mine and sat down with a..."*)

### Węzeł `[134]`
Mówca: **Nia Morgna**
> "“I could say the same, Mr. President. But don't worry. Justice will be served today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Nia approached the table next to mine and sat down with a..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "BaseGame.Resigned_NiaMorgna == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Resigned_NiaMorgna == true)"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Resigned_NiaMorgna == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "UpdateCharacterTitle("Nia Morgna", "Former Minister");"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Resigned_NiaMorgna == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Nia Morgna, the Minister of Justice and the head of the A..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Nia Morgna, the former Minister of Justice and the previous head of the Anti-Corruption Police, entered the room. She barely looked at me as she took her place before the judges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Nia Morgna: "“Thank you, your honor.”"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Nia Morgna: "“As were the tax cuts for Sordland's large corporations.”"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[142]`
Mówca: **Nia Morgna**
> "“As were the tax cuts for Sordland's large corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk =..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Nia Morgna: "“We have found evidence of backroom dealings related to t..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == tr..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCharacterTitle("Nia Morgna", "Former Minister");`
- **Efekt skryptowy (`userScript`):** `UpdateCharacterTitle("Nia Morgna","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Nia Morgna, the former Minister of Justice and the previo..."*)
