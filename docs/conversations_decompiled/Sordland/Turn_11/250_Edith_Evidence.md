# Sordland/Turn11/Edith Evidence

- **ID konwersacji:** `250`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/250_Edith_Evidence.md`
- **Liczba węzłów dialogowych:** 123
- **Liczba wyborów gracza:** 3

---

## 1. Uczestnicy Sceny

- **[1]** Ovid Grecer
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[25]** Edith Agnoc
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
- `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti`
- `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk`
- `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses`
- `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp`
- `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[246] Sordland/Turn11/A_ImpeachmentTrial** (../Turn_11/246_A_ImpeachmentTrial.md), Węzeł `[56]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[112]` | **"“I never trusted you in the first place.”"** | `[114]` **Edith Agnoc**: "“I'm sorry, Anton. I really am. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Edith Agnoc**: "“I'm sorry.”" |
| `[115]` | **"“Screw you, Edith.”"** | `[114]` **Edith Agnoc**: "“I'm sorry, Anton. I really am. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Edith Agnoc**: "“I'm sorry.”" |
| `[116]` | **"Do not reply to her."** | `[114]` **Edith Agnoc**: "“I'm sorry, Anton. I really am. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "She turned her attention to the ..." |

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
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Edith Agnoc: "“Mr. President appears to have been involved in a bribery..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == t..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Edith Agnoc: "“Mr. President appears to have illegally colluded with Al..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_Bribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Edith Agnoc: "“A report states that the President was in cahoots with F..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_Bribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Edith Agnoc: "“A report states that the President acted against the bes..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == ..."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Edith Agnoc: "“The President has procured shares from Underhall Constru..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_GusManger_UnderhallCollusion"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Edith Agnoc: "“There has apparently been a deal between Mr. President a..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigatio..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Edith Agnoc: "“The President tipped off Marcel Koronti to the ongoing g..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoront..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Edith Agnoc: "“The government privatization program was supposed to hav..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == ..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk =..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Edith Agnoc: "“The government privatization program was supposed to hav..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == ..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Edith Agnoc: "“Mr. President and Walter Tusk made a deal to bail out So..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Edith Agnoc: "“The recent tax cuts for large corporations in Sordland a..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Edith Agnoc: "“Walter Tusk offered a bribe to the President in order to..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Edith Agnoc: "“This is the end of my summary.”"*)

### Węzeł `[39]`
Mówca: **Orso Hawker**
> "“This court now summons Edith Agnoc to present her evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Chairwoman of the Central Bank of Sordland Edith Agnoc en..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Ovid Grecer: "“This court now summons Edith Agnoc to present her eviden..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Orso Hawker: "“This court now summons Edith Agnoc to present her eviden..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Heron Garaci: "“This court now summons Edith Agnoc to present her eviden..."*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Chairwoman of the Central Bank of Sordland Edith Agnoc entered the court room nonchalantly and took her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Edith Agnoc: "“Thank you, your honor.”"*)

### Węzeł `[47]`
Mówca: **Ovid Grecer**
> "“This court now summons Edith Agnoc to present her evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Chairwoman of the Central Bank of Sordland Edith Agnoc en..."*)

### Węzeł `[48]`
Mówca: **Heron Garaci**
> "“This court now summons Edith Agnoc to present her evidence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Chairwoman of the Central Bank of Sordland Edith Agnoc en..."*)

### Węzeł `[49]`
Mówca: **Edith Agnoc**
> "“Thank you, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "She whispered to me quietly from the table opposite mine."*)

### Węzeł `[50]`
Mówca: **Edith Agnoc**
> "“I am here at the request of a person who shall not be named to present this incriminating evidence against the president of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[51]`
Mówca: **Orso Hawker**
> "“Does the person who granted you with the rights to present evidence in his or her stead wish to remain anonymous before this court?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Edith Agnoc: "“Yes, your honor.”"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Heron Garaci: "“Does the person who granted you with the rights to prese..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Ovid Grecer: "“Does the person who granted you with the rights to prese..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Orso Hawker: "“Does the person who granted you with the rights to prese..."*)

### Węzeł `[58]`
Mówca: **Ovid Grecer**
> "“Does the person who granted you with the rights to present evidence in his or her stead wish to remain anonymous before this court?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Edith Agnoc: "“Yes, your honor.”"*)

### Węzeł `[59]`
Mówca: **Heron Garaci**
> "“Does the person who granted you with the rights to present evidence in his or her stead wish to remain anonymous before this court?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Edith Agnoc: "“Yes, your honor.”"*)

### Węzeł `[60]`
Mówca: **Edith Agnoc**
> "“Yes, your honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[61]`
Mówca: **Orso Hawker**
> "“Very well. Permission granted. This court will respect the anonymity of the witness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Edith Agnoc: "“Thank you.”"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Heron Garaci: "“Very well. Permission granted. This court will respect t..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Ovid Grecer: "“Very well. Permission granted. This court will respect t..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Orso Hawker: "“Very well. Permission granted. This court will respect t..."*)

### Węzeł `[68]`
Mówca: **Ovid Grecer**
> "“Very well. Permission granted. This court will respect the anonymity of the witness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Edith Agnoc: "“Thank you.”"*)

### Węzeł `[69]`
Mówca: **Heron Garaci**
> "“Very well. Permission granted. This court will respect the anonymity of the witness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Edith Agnoc: "“Thank you.”"*)

### Węzeł `[70]`
Mówca: **Edith Agnoc**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Edith Agnoc: "“The summary of the evidence I have provided to the court..."*)

### Węzeł `[71]`
Mówca: **Edith Agnoc**
> "“The summary of the evidence I have provided to the court is as follows.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_AlbinClavin_Bribe == true"*)

### Węzeł `[72]`
Mówca: **Edith Agnoc**
> "“Mr. President appears to have been involved in a bribery scandal with Albin Clavin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Edith Agnoc: "“There was a very large money transfer from the President..."*)

### Węzeł `[73]`
Mówca: **Edith Agnoc**
> "“Mr. President appears to have illegally colluded with Albin Clavin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Edith Agnoc: "“Albin Clavin was promised the Vice Presidency in return ..."*)

### Węzeł `[74]`
Mówca: **Edith Agnoc**
> "“There was a very large money transfer from the President's account to Mr. Clavin's.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Edith Agnoc: "“The timeline of this event coincides with the preparatio..."*)

### Węzeł `[75]`
Mówca: **Edith Agnoc**
> "“The timeline of this event coincides with the preparation of the new constitutional changes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_FrensRicter_Bribe == true"*)

### Węzeł `[76]`
Mówca: **Edith Agnoc**
> "“Albin Clavin was promised the Vice Presidency in return for the support of the USP's reformist wing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Edith Agnoc: "“The timeline of this event coincides with the preparatio..."*)

### Węzeł `[77]`
Mówca: **Edith Agnoc**
> "“A report states that the President was in cahoots with Frens Ricter during the constitutional reform process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Edith Agnoc: "“A hefty money transfer between the accounts of Mr. Rayne..."*)

### Węzeł `[78]`
Mówca: **Edith Agnoc**
> "“A report states that the President acted against the best interests of the state in choosing a contractor for a major infrastructure project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Edith Agnoc: "“According to the report, President Rayne contracted Taur..."*)

### Węzeł `[79]`
Mówca: **Edith Agnoc**
> "“A hefty money transfer between the accounts of Mr. Rayne and Mr. Ricter is outlined.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[80]`
Mówca: **Edith Agnoc**
> "“According to the report, President Rayne contracted Taurus Holding, a company in which Mr. Ricter holds a major share, in order to curry Mr. Ricter's favor during the reform process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Edith Agnoc: "“Mr. Ricter potentially has made millions from this deal.”"*)

### Węzeł `[81]`
Mówca: **Edith Agnoc**
> "“Mr. Ricter potentially has made millions from this deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true"*)

### Węzeł `[82]`
Mówca: **Edith Agnoc**
> "“There has apparently been a deal between Mr. President and Marcel Koronti in Mr. Koronti's villa in Conriat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Edith Agnoc: "“Mr. Koronti agreed to use the media to support the presi..."*)

### Węzeł `[83]`
Mówca: **Edith Agnoc**
> "“Mr. Koronti agreed to use the media to support the president's rhetoric in exchange for protection against various government policies that could otherwise target his company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Edith Agnoc: "“The evidence includes a voice recording by the security ..."*)

### Węzeł `[84]`
Mówca: **Edith Agnoc**
> "“The evidence includes a voice recording by the security personnel in the villa.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation ..."*)

### Węzeł `[85]`
Mówca: **Edith Agnoc**
> "“The President tipped off Marcel Koronti to the ongoing government investigation into him when his links to the Koranelli Cartel were discovered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Edith Agnoc: "“As a result, any evidence of Mr. Koronti's cartel connec..."*)

### Węzeł `[86]`
Mówca: **Edith Agnoc**
> "“As a result, any evidence of Mr. Koronti's cartel connections that may have existed was most likely destroyed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti ..."*)

### Węzeł `[87]`
Mówca: **Edith Agnoc**
> "“The government privatization program was supposed to have opened the shares of the privatized companies to the public.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Edith Agnoc: "“Instead, a backroom deal was struck and these shares wer..."*)

### Węzeł `[88]`
Mówca: **Edith Agnoc**
> "“Instead, a backroom deal was struck and these shares were transferred to Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[89]`
Mówca: **Edith Agnoc**
> "“Instead, a backroom deal was struck and these shares were transferred to Walter Tusk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_GusManger_UnderhallCollusion == true"*)

### Węzeł `[90]`
Mówca: **Edith Agnoc**
> "“The government privatization program was supposed to have opened the shares of the privatized companies to the public.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Edith Agnoc: "“Instead, a backroom deal was struck and these shares wer..."*)

### Węzeł `[91]`
Mówca: **Edith Agnoc**
> "“The President has procured shares from Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Edith Agnoc: "“These shares are the reason Underhall was picked as the ..."*)

### Węzeł `[92]`
Mówca: **Edith Agnoc**
> "“These shares are the reason Underhall was picked as the construction company for the recent government megaproject.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true"*)

### Węzeł `[93]`
Mówca: **Edith Agnoc**
> "“Mr. President and Walter Tusk made a deal to bail out Sordland's businesses. Bribery appears to have been involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)

### Węzeł `[94]`
Mówca: **Edith Agnoc**
> "“The recent tax cuts for large corporations in Sordland are a direct result of collusion between President Rayne and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[95]`
Mówca: **Edith Agnoc**
> "“Walter Tusk offered a bribe to the President in order to secure Underhall Construction as a government contractor at a time when Mr. Tusk owned half of the company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Edith Agnoc: "“This is the end of my summary.”"*)

### Węzeł `[96]`
Mówca: **Heron Garaci**
> "“This is a very concerning report.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Heron Garaci: "“Thank you for presenting the evidence, Mrs. Agnoc. You m..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Ovid Grecer: "“This is a very concerning report.”"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Orso Hawker: "“This is a very concerning report.”"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_HeronGaraci == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_HeronGaraci == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_HeronGaraci"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Heron Garaci: "“This is a very concerning report.”"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_HeronGaraci == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_HeronGaraci"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true"*)

### Węzeł `[103]`
Mówca: **Ovid Grecer**
> "“This is a very concerning report.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Ovid Grecer: "“Thank you for presenting the evidence, Mrs. Agnoc. You m..."*)

### Węzeł `[104]`
Mówca: **Orso Hawker**
> "“This is a very concerning report.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Orso Hawker: "“Thank you for presenting the evidence, Mrs. Agnoc. You m..."*)

### Węzeł `[105]`
Mówca: **Edith Agnoc**
> "“This is the end of my summary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Edith Agnoc: "“The evidence is well documented and proven to be the tru..."*)

### Węzeł `[106]`
Mówca: **Edith Agnoc**
> "“The evidence is well documented and proven to be the truth according to the files provided by my anonymous client.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "She pulled out a very large stack of papers that she coul..."*)

### Węzeł `[107]`
Mówca: **Heron Garaci**
> "“Thank you for presenting the evidence, Mrs. Agnoc. You may leave the room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Edith collected her belongings and left the courtroom, no..."*)

### Węzeł `[108]`
Mówca: **Ovid Grecer**
> "“Thank you for presenting the evidence, Mrs. Agnoc. You may leave the room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Edith collected her belongings and left the courtroom, no..."*)

### Węzeł `[109]`
Mówca: **Orso Hawker**
> "“Thank you for presenting the evidence, Mrs. Agnoc. You may leave the room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Edith collected her belongings and left the courtroom, no..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "She pulled out a very large stack of papers that she could barely carry and put it on the table with a loud thud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_HeronGaraci == true"*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Edith collected her belongings and left the courtroom, not looking back at me as she did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I never trusted you in the first place.”"]** — Mówca: **Player**
> "“I never trusted you in the first place.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Edith Agnoc: "“I'm sorry.”"*)

### Węzeł `[113]`
Mówca: **Narrator**
> "She whispered to me quietly from the table opposite mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Edith Agnoc: "“I'm sorry, Anton. I really am. But I'm just the messenger.”"*)

### Węzeł `[114]`
Mówca: **Edith Agnoc**
> "“I'm sorry, Anton. I really am. But I'm just the messenger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "“Screw you, Edith.”"*)
  - -> `[112]` (*Player: "“I never trusted you in the first place.”"*)
  - -> `[116]` (*Player_Italic: "Do not reply to her."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Screw you, Edith.”"]** — Mówca: **Player**
> "“Screw you, Edith.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Edith Agnoc: "“I'm sorry.”"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "Do not reply to her."]** — Mówca: **Player_Italic**
> "I did not reply to her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Edith Agnoc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "She turned her attention to the papers in front of her."*)

### Węzeł `[117]`
Mówca: **Edith Agnoc**
> "“I'm sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "She turned her attention to the papers in front of her."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "She turned her attention to the papers in front of her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Edith Agnoc: "“I am here at the request of a person who shall not be na..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Edith Agnoc: "“The recent tax cuts for large corporations in Sordland a..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)

### Węzeł `[122]`
Mówca: **Edith Agnoc**
> "“The recent tax cuts for large corporations in Sordland are the product of similar collusion between the two men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true"*)
