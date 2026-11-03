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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 1

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[146]` (Paskal Beniwoll): `UpdateCharacterTitle("Nia Morgna","Former Minister");`

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
  - -> `[114]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `246` (*Sordland/Turn11/A_ImpeachmentTrial*), Węzeł `[42]`

### Węzeł `[3]`
Mówca: **Ovid Grecer**
> "“Silence! Silence in the court!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[4]`
Mówca: **Heron Garaci**
> "“Silence! Silence in the court!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "“After all I have done for you, you betrayed me.”"]** — Mówca: **Player**
> "“After all I have done for you, you betrayed me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[6]`
Mówca: **Nia Morgna**
> "“Mr. President personally prevented an investigation into Mr. Koronti's connections with the Koranelli Cartel, making him an accomplice and a criminal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_Both == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_Both == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Nia Morgna, the Minister of Justice and the head of the Anti-Corruption Police, entered the room. She barely looked at me as she took her place before the judges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[11]`
Mówca: **Nia Morgna**
> "“No. You betrayed your country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[12]`
Mówca: **Nia Morgna**
> "“We have found evidence of backroom dealings related to the privatization of Sordland's national corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Nia Morgna**
> "“Before the shares from privatization could go on the public market, President Rayne granted them directly to oligarchs Marcel Koronti and Walter Tusk. This is a criminal offence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[17]`
Mówca: **Nia Morgna**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`
  - -> `[132]`

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“You little snake! I will have your head!”"]** — Mówca: **Player**
> "“You little snake! I will have your head!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[22]`
Mówca: **Nia Morgna**
> "“Before the shares from privatization could go on the public market, President Rayne granted them directly to Marcel Koronti. This is a criminal offence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[23]`
Mówca: **Nia Morgna**
> "“We have found evidence of backroom dealings related to the privatization of Sordland's national corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Nia approached the table next to mine and sat down with a large stack of papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[28]`
Mówca: **Nia Morgna**
> "“Before the shares from privatization could go on the public market, President Rayne granted them directly to Walter Tusk. This is a criminal offence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
Mówca: **Nia Morgna**
> "“We have found evidence of backroom dealings related to the privatization of Sordland's national corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[30]`
Mówca: **Nia Morgna**
> "“As the head of the Anti-Corruption Police, I have been tasked by President Rayne to root out and eliminate corruption in the government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[37]`
Mówca: **Nia Morgna**
> "“By the President's order, we began a probe into the powerful media mogul Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[38]`
Mówca: **Nia Morgna**
> "“During our investigations, we have found dire incriminating evidence against Mr. President himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Nia Morgna**
> "“I, being a member of the cabinet and having worked with the defendant for many years, did not want to believe what I heard and saw. Yet the evidence could not be ignored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[40]`
Mówca: **Nia Morgna**
> "“My Anti-Corruption Police force was asked to look into Walter Tusk, the spokesperson for the Lotherberg Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Nia Morgna**
> "“According to the evidence, Mr. Manger offered the President a personal stake in Underhall Construction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[42]`
Mówca: **Nia Morgna**
> "“What we found was, quite frankly, shocking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I sat there, quietly seething."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[49]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[53]`
Mówca: **Nia Morgna**
> "“I have dedicated my life to the pursuit of justice, and that dedication has led me to a position of utmost responsibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[54]`
Mówca: **Nia Morgna**
> "“The President's business bailout was a direct result of hidden dealings with Mr. Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[55]`
Mówca: **Nia Morgna**
> "“We found that shortly after Mr. Rayne took office, Mr. Koronti offered the President what amounted to government control over Sordland's major media in exchange for special protections for his conglomerate, Heart of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[56]`
Mówca: **Nia Morgna**
> "“I am obligated to uphold my ideals by revealing the reality behind Anton Rayne, the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[57]`
Mówca: **Nia Morgna**
> "“President Rayne subsequently chose Underhall Construction as the contractor for his new government megaproject, siphoning millions of SR from the government to his company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[58]`
Mówca: **Nia Morgna**
> "“The tax cuts for large corporations were the product of a hidden deal between Mr. Tusk and Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[59]`
Mówca: **Nia Morgna**
> "“I hereby present the following allegations against Anton Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Nia Morgna**
> "“Mr. Tusk engaged the President in flat-out bribery to ensure that his company Underhall Construction would be selected as the main contractor for a major infrastructure project.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[61]`
Mówca: **Nia Morgna**
> "“The President accepted. Needless to say, this deal is a horrifying breach of democratic values.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_AlbinClavin_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_AlbinClavin_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[65]`
Mówca: **Nia Morgna**
> "“Our investigations have revealed President Rayne's involvement in a bribery scheme with PFJP leader Frens Ricter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[66]`
Mówca: **Nia Morgna**
> "“As you can see, there is substantial incriminating evidence against Anton Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[67]`
Mówca: **Nia Morgna**
> "“Our investigations have revealed President Rayne's involvement in a bribery scheme with PFJP leader Frens Ricter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[68]`
Mówca: **Orso Hawker**
> "“Silence! Silence in the court!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[72]`
Mówca: **Nia Morgna**
> "“As the man holding the highest office in this country, he should be a shining example of democracy. Instead, he has abused his position for his own personal gain and desecrated Sordland's democratic ideals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[76]`
Mówca: **Nia Morgna**
> "“I hope this court sees the ugly truth and relieves Anton Rayne from his presidency once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Nia Morgna**
> "“We have found a direct conflict of interest linked to the Minister of Agriculture and Rural Development, Gus Manger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[78]`
Mówca: **Nia Morgna**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[82]`
  - -> `[21]`
  - -> `[43]`

### Węzeł `[79]`
Mówca: **Nia Morgna**
> "“Our investigations found that during the constitutional reform process, Anton Rayne promised Albin Clavin the position of Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[80]`
Mówca: **Nia Morgna**
> "“Mr. President has been involved in the obstruction of justice by tipping off the subject of a government investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
Mówca: **Nia Morgna**
> "“Our investigations found a large sum of money transferred between Anton Rayne and Albin Clavin during the constitutional reform process.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“Objection!”"]** — Mówca: **Player**
> "“Objection!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[83]`
Mówca: **Nia Morgna**
> "“The person in question is Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[87]`
Mówca: **Narrator**
> "Loud chatter started spreading through the courtroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[88]`
Mówca: **Nia Morgna**
> "“In return for his support in the Assembly, Frens Ricter received a large sum of money from the President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[89]`
Mówca: **Nia Morgna**
> "“All evidence suggests that this was a bribe meant to secure Mr. Clavin's support for the constitutional changes in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
Mówca: **Nia Morgna**
> "“It is therefore no coincidence that, not long after Mr. Clavin supported the President's reforms in the Assembly, he was offered the Vice Presidency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[97]`
Mówca: **Heron Garaci**
> "“Overruled!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[98]`
Mówca: **Orso Hawker**
> "“Overruled!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[99]`
Mówca: **Ovid Grecer**
> "“Overruled!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[100]`
Mówca: **Nia Morgna**
> "“In return for Mr. Ricter's support in the Assembly, the President promised to favor Taurus Holding, a company that Frens Ricter is directly involved in, for government infrastructure projects. This is a baldfaced conflict of interest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_Bribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_Bribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Nia gathered her documents and left the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[108]`
Mówca: **Orso Hawker**
> "“This court now summons Nia Morgna to present the evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[112]`
Mówca: **Heron Garaci**
> "“This court now summons Nia Morgna to present the evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[113]`
Mówca: **Ovid Grecer**
> "“This court now summons Nia Morgna to present the evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[117]`
Mówca: **Orso Hawker**
> "“Thank you, Mrs. Morgna. You may leave the courtroom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[118]`
Mówca: **Ovid Grecer**
> "“Thank you, Mrs. Morgna. You may leave the courtroom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[119]`
Mówca: **Heron Garaci**
> "“Thank you, Mrs. Morgna. You may leave the courtroom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[120]`
Mówca: **Ovid Grecer**
> "“Your hard work and dedication to justice are acknowledged and appreciated by the members of this court, Mrs. Morgna.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_HeronGaraci == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_HeronGaraci == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.ChiefJustice_OvidGrecer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.ChiefJustice_OvidGrecer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Heron Garaci**
> "“Your hard work and dedication to justice are acknowledged and appreciated by the members of this court, Mrs. Morgna.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Orso Hawker**
> "“Your hard work and dedication to justice are acknowledged and appreciated by the members of this court, Mrs. Morgna.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Nia Morgna**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Nia. Don't do this. Please. I beg you.”"]** — Mówca: **Player**
> "“Nia. Don't do this. Please. I beg you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“I regret the day I made the decision to let you into my cabinet.”"]** — Mówca: **Player**
> "“I regret the day I made the decision to let you into my cabinet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“I was a fool to trust you.”"]** — Mówca: **Player**
> "“I was a fool to trust you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Nia Morgna**
> "“It's too late now, Mr. President. Justice will be served today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[134]`
Mówca: **Nia Morgna**
> "“I could say the same, Mr. President. But don't worry. Justice will be served today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Resigned_NiaMorgna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Resigned_NiaMorgna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Resigned_NiaMorgna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Resigned_NiaMorgna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Nia Morgna, the former Minister of Justice and the previous head of the Anti-Corruption Police, entered the room. She barely looked at me as she took her place before the judges."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[141]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[142]`
Mówca: **Nia Morgna**
> "“As were the tax cuts for Sordland's large corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[146]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCharacterTitle("Nia Morgna", "Former Minister");)*
- **Efekt (`userScript`):** `UpdateCharacterTitle("Nia Morgna","Former Minister");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
