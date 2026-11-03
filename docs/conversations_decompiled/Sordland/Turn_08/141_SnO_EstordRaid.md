# Sordland/Turn08/SnO_EstordRaid

- **ID konwersacji:** `141`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/141_SnO_EstordRaid.md`
- **Liczba węzłów dialogowych:** 314
- **Liczba wyborów gracza:** 93

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[14]** Marcel Koronti
- **[44]** Lileas Graf
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Turn05_SnO_LE_Policy_SecretStateService`
- `BaseGame.Turn07_A_Marcel_OwnershipDeal`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_Fled_MarcelKoronti`
- `BaseGame.Turn08_SnO_InvestigationOnHOS`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Killed_MarcelKoronti`
- `BaseGame.Marcel_FundsReElection`
- `BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff`
- `BaseGame.Turn08_SnO_InvestigationOnHOS`
- `BaseGame.Turn08_SnO_KorontiInvestigationStopped`
- `BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigation`
- `BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection`
- `BaseGameSupport.Journal_Turn08_EstordRaid_MarcelKilled`
- `BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestigation`
- `GameCondition.Turn08_SnO_EstordRaid`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 23

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Lileas Graf): `Variable["GameCondition.Turn08_SnO_EstordRaid"] = true;`
- Węzeł `[30]` (Lileas Graf): `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- Węzeł `[83]` (Lileas Graf): `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- Węzeł `[84]` (Lileas Graf): `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- Węzeł `[85]` (Lileas Graf): `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- Węzeł `[86]` (Lileas Graf): `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- Węzeł `[140]` (Lileas Graf): `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] = true;`
- Węzeł `[157]` (Lileas Graf): `Variable["BaseGame.Marcel_FundsReElection"] = true;`
- *...oraz 15 innych węzłów ze skryptami.*

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
  - -> `[90]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lileas Graf)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_SnO_EstordRaid = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_SnO_EstordRaid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "Call Marcel Koronti."]** — Mówca: **Player_Italic**
> "I called Marcel Koronti."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I decided not to call Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[6]`
Mówca: **Narrator**
> "If Marcel's cartel ties were real, this was huge news. My deal with him aside, HOS was the largest corporation in all of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I had to be careful. More so than ever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[8]`
Mówca: **Narrator**
> "He answered right away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Marcel Koronti**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[24]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I have some information that could be useful to you.”"]** — Mówca: **Player**
> "“I have some information that could be useful to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“The government is launching an indepth investigation into HOS. Soon.”"]** — Mówca: **Player**
> "“The government is launching an indepth investigation into HOS. Soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[12]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_InvestigationOnHOS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_InvestigationOnHOS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[14]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SnO_InvestigationOnHOS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
Mówca: **Marcel Koronti**
> "“Oh? Now I'm excited.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Marcel Koronti**
> "“What is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[12]`

### Węzeł `[17]`
Mówca: **Marcel Koronti**
> "“Really? Who would be behind such a thing?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"]** — Mówca: **Player**
> "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[19]`
Mówca: **Marcel Koronti**
> "“Well, well. Thank you for doing that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“Lileas Graf.”"]** — Mówca: **Player**
> "“Lileas Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Me.”"]** — Mówca: **Player**
> "“Me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Marcel Koronti**
> "“Then why are you calling me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`
  - -> `[73]`

### Węzeł `[23]`
Mówca: **Marcel Koronti**
> "“What an unfortunate turn of events.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Is it true that you have links to the Koranelli cartel?”"]** — Mówca: **Player**
> "“Is it true that you have links to the Koranelli cartel?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[25]`
Mówca: **Marcel Koronti**
> "“Of course not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Narrator**
> "He started laughing hysterically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[27]`
Mówca: **Marcel Koronti**
> "“I wonder whose plan is it to remove me from my position this time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Marcel Koronti**
> "“I have many enemies, Mr. President. Probably as many as you do. I had no dealings with a *cartel*. I assure you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[29]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“That's all I wanted to know.”"]** — Mówca: **Player**
> "“That's all I wanted to know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[30]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“What are you offering for this information?”"]** — Mówca: **Player**
> "“What are you offering for this information?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Marcel Koronti**
> "“Well, I don't think I can make an offer without seeing what I am buying first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[59]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Too bad, then. See you Marcel.”"]** — Mówca: **Player**
> "“Too bad, then. See you Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Marcel Koronti**
> "“Wait.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Marcel Koronti**
> "“How important is this *information*?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[36]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Let's just say it's important enough that I am calling you.”"]** — Mówca: **Player**
> "“Let's just say it's important enough that I am calling you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "Hang up."]** — Mówca: **Player_Italic**
> "I hung up on Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[38]`
Mówca: **Marcel Koronti**
> "“Fair enough. Hmm.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Marcel Koronti**
> "“Let's do this then. I promise you campaign funds. The amount, however, will be dependent on the value of the information.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[40]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Deal.”"]** — Mówca: **Player**
> "“Deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[41]`
Mówca: **Marcel Koronti**
> "“Very well. What is the information then?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`
  - -> `[47]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“On second thought, I just wanted to test you. I will come visit you when you are behind bars.”"]** — Mówca: **Player**
> "“On second thought, I just wanted to test you. I will come visit you when you are behind bars.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Marcel Koronti**
> "“Mr. Presi-.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[44]`
Mówca: **Narrator**
> "I hung up on Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[45]`
Mówca: **Marcel Koronti**
> "“What is this about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[12]`
  - -> `[73]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“The government is launching a serious investigation into HOS. Very soon.""]** — Mówca: **Player**
> "“The government is launching a serious investigation into HOS. Very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[47]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_InvestigationOnHOS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_InvestigationOnHOS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[49]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SnO_InvestigationOnHOS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"]** — Mówca: **Player**
> "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[51]`
Mówca: **Marcel Koronti**
> "“Well, well. Thank you for doing that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Marcel Koronti**
> "“That is indeed valuable information. I will make good use of it indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Marcel Koronti**
> "“Well, well. Thank you for telling me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[54]`
Mówca: **Marcel Koronti**
> "“As I have promised, I will deliver again on our deal when the time is right. Just as I have always done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Marcel Koronti**
> "“I must now make sure my people are on this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Marcel Koronti**
> "“Cheers to our deal once again, Mr. President, and to many more years of collaboration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Marcel Koronti**
> "“Bye bye, now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Marcel hung up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[59]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_InvestigationOnHOS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_InvestigationOnHOS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[61]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SnO_InvestigationOnHOS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“The government is launching an indepth investigation into HOS. Soon.""]** — Mówca: **Player**
> "“The government is launching an indepth investigation into HOS. Soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"]** — Mówca: **Player**
> "“I just prevented my own government from launching an investigation into HOS. I'm not sure how long I can keep them at bay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Marcel Koronti**
> "“Well, well. Thank you for doing that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[65]`
Mówca: **Marcel Koronti**
> "“Well, well. Thank you for telling me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[66]`
Mówca: **Marcel Koronti**
> ""Here's what I can offer in exchange for your help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Marcel Koronti**
> "“I promise you campaign funds commensurate with the value of your information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`
  - -> `[69]`
  - -> `[75]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“I don't need your help to win.”"]** — Mówca: **Player**
> "“I don't need your help to win.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Deal.”"]** — Mówca: **Player**
> "“Deal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Marcel Koronti**
> "“I have no doubt. Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Marcel Koronti**
> "“Perfect.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[72]`
Mówca: **Marcel Koronti**
> "“Please let me know then if you ever need help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“You will learn soon. Goodbye, Marcel.”"]** — Mówca: **Player**
> "“You will learn soon. Goodbye, Marcel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[74]`
Mówca: **Marcel Koronti**
> "“Now, I wouldn't like to stay indebted to you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "“Consider this a token of goodwill.”"]** — Mówca: **Player**
> "“Consider this a token of goodwill.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Marcel Koronti**
> "“That is certainly a bargain. Very well, I shall do so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Marcel Koronti**
> "“Please let me know if you ever need help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[78]`
Mówca: **Narrator**
> "I hung up on Marcel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Marcel Koronti**
> "“Thank you for telling me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[80]`
Mówca: **Narrator**
> "The games Marcel was playing were getting more and more dangerous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Narrator**
> "The question was, who would be the winner?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[82]`
Mówca: **Narrator**
> "The games Marcel was playing were getting more and more dangerous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[83]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[84]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[85]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[86]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SnO_EstordRaid_MarcelTippedOff"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[87]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[89]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[90]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MarcelKoronti == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Detained_MarcelKoronti == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[92]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Detained_MarcelKoronti == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Nia Morgna requested to set up an off-the-books meeting to relay a new development from the criminal investigations conducted by the Anti-Corruption Police."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Narrator**
> "She was seated right across from me in the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Nia Morgna**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Lileas Graf requested to set up an off-the-books meeting to relay a new development from the criminal investigations conducted by the Secret State Police."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> "She was seated right across from me in the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Lileas Graf**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[99]`
Mówca: **Narrator**
> "She handed over a police report detailing the network of the Koranelli gang in the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[100]`
Mówca: **Lileas Graf**
> "“Thanks to Mr. Greiser's efforts, we have come across a suspicious link during our recent operations against organised crime in Estord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[101]`
Mówca: **Lileas Graf**
> "“You asked the SSP to start investigating the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Lileas Graf**
> "“We couldn't find anything related to Walter Tusk yet, but there is a silver lining.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“This is a very big accusation, are you absolutely sure?”"]** — Mówca: **Player**
> "“This is a very big accusation, are you absolutely sure?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Without undeniable evidence there is no point in making assumptions.”"]** — Mówca: **Player**
> "“Without undeniable evidence there is no point in making assumptions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Something must have gone wrong in the investigation. This can't be true.”"]** — Mówca: **Player**
> "“Something must have gone wrong in the investigation. This can't be true.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Lileas Graf**
> "“The initial lead found by our lead investigator refers to several transactions. There is a case to pursue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[107]`
Mówca: **Lileas Graf**
> "“We can't know for sure without starting a full investigation. It could be a local case but it could be something bigger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[108]`
Mówca: **Lileas Graf**
> "“Exactly. That is why I refrain from making a final comment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“I never trusted HOS and Koronti anyway.”"]** — Mówca: **Player**
> "“I never trusted HOS and Koronti anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Lileas Graf**
> "“My reservations regarding that family and their fortunes never changed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[111]`
Mówca: **Lileas Graf**
> "“A ledger was found in one of the raids.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Lileas Graf**
> "“It has contents linking their operations to a subsidiary of the Heart of Sordland Conglomerate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[105]`
  - -> `[104]`
  - -> `[109]`

### Węzeł `[113]`
Mówca: **Lileas Graf**
> "“Obviously we hope that there is nothing beneath the surface but if in any way HOS is linked to organised crime...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[119]`
  - -> `[120]`
  - -> `[116]`

### Węzeł `[114]`
Mówca: **Lileas Graf**
> "“At any rate, with this new evidence we need not keep our research into Mr. Koronti a secret any longer. In fact, we should open a full-blown joint investigation with the Ministry of Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Marcel Koronti is a powerful figure that wouldn't like a development like this at all.”"]** — Mówca: **Player**
> "“Marcel Koronti is a powerful figure that wouldn't like a development like this at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“There is no way a respectable company like HOS can be linked to this. I don't believe it.”"]** — Mówca: **Player**
> "“There is no way a respectable company like HOS can be linked to this. I don't believe it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[117]`
Mówca: **Lileas Graf**
> "“People like him think they are above the law.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[118]`
Mówca: **Lileas Graf**
> "“I wouldn't come to you if there wasn't anything worth looking into.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“To figure out the truth a more indepth investigation needs to be launched.”"]** — Mówca: **Player**
> "“To figure out the truth a more indepth investigation needs to be launched.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Is that really enough to start rounding up suspects?”"]** — Mówca: **Player**
> "“Is that really enough to start rounding up suspects?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[121]`
Mówca: **Narrator**
> "Lileas looked at me with suspicion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[122]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[123]`
Mówca: **Lileas Graf**
> "“No. He wouldn't like it at all but if he is innocent he shouldn't care.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[124]`
Mówca: **Lileas Graf**
> "“We must tread carefully. There have been rumours about Mr. Koronti having ties to our government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[137]`
  - -> `[131]`
  - -> `[132]`

### Węzeł `[125]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[127]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Lileas Graf**
> "“So. Will you allow us to open an investigation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[129]`
Mówca: **Lileas Graf**
> "“We all have our ways, Mr. President. I wouldn't be sitting here if I didn't know how to keep my ears open.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Who did you hear that from?”"]** — Mówca: **Player**
> "“Who did you hear that from?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“I'm not surprised at all.”"]** — Mówca: **Player**
> "“I'm not surprised at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA: "“I've personally met him once. Didn't seem like a bad guy.”"]** — Mówca: **Player**
> "“I've personally met him once. Didn't seem like a bad guy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[133]`
Mówca: **Lileas Graf**
> "“Regardless, the Lotherberg members aren't to be trusted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[134]`
Mówca: **Narrator**
> "Lileas bursted into a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[135]`
Mówca: **Lileas Graf**
> "“I hope that is not just wishful thinking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[136]`
Mówca: **Lileas Graf**
> "“They always try to impress but it is all smoke and mirrors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“Our administration wouldn't fall that low. I have trust in our people.”"]** — Mówca: **Player**
> "“Our administration wouldn't fall that low. I have trust in our people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[138]`
Mówca: **Lileas Graf**
> "“You need to be careful with the oligarchs, Mr. President. Their only loyalty is to money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "“It would be even worse if we acted too hasty and the lead turned out to be a false one.”"]** — Mówca: **Player**
> "“It would be even worse if we acted too hasty and the lead turned out to be a false one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[140]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_InvestigationOnHOS = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[141]`
Mówca: **Narrator**
> "Lileas got up from her seat and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[142]`
Mówca: **Lileas Graf**
> "“I'll get in touch with Nia right away. Of course, I needn't mention our previous activities or the SSP's ongoing investigation into Mr. Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[143]`
Mówca: **Lileas Graf**
> "“I'm disappointed by this course of action. The gang might try to erase evidence in the meantime.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[144]`
Mówca: **Narrator**
> "We both locked eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[145]`
  - -> `[153]`

### Węzeł `[145]`
**[WYBÓR GRACZA: "“We can't be hasty here. We will wait until we have a more concrete lead.”"]** — Mówca: **Player**
> "“We can't be hasty here. We will wait until we have a more concrete lead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[146]`
Mówca: **Lileas Graf**
> "“Well. That is all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Lileas Graf**
> "“Thank you for your time, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[148]`
**[WYBÓR GRACZA: "“I trust that we will come with enough information to incriminate him in due time.”"]** — Mówca: **Player**
> "“I trust that we will come with enough information to incriminate him in due time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[149]`
**[WYBÓR GRACZA: "“Very well. Meeting adjourned then.”"]** — Mówca: **Player**
> "“Very well. Meeting adjourned then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Looking forward to the results. Do your best.”"]** — Mówca: **Player**
> "“Looking forward to the results. Do your best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Lileas Graf**
> "“Hmm. You may be right, but I'd hate to find out that we missed our chance later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[152]`
Mówca: **Lileas Graf**
> "“We will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[153]`
**[WYBÓR GRACZA: "“Absolutely not. Keep your focus on Tusk.""]** — Mówca: **Player**
> "“Absolutely not. Keep your focus on Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[154]`
**[WYBÓR GRACZA: "“There is just not enough evidence to trigger an investigation.”"]** — Mówca: **Player**
> "“There is just not enough evidence to trigger an investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[155]`
**[WYBÓR GRACZA: "“Begin an official investigation to find out if HOS is working with organised crime elements in Estord.”"]** — Mówca: **Player**
> "“Begin an official investigation to find out if HOS is working with organised crime elements in Estord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[156]`
Mówca: **Lileas Graf**
> "“Not to mention that it seems... questionable that we aren't pursuing this now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[148]`
  - -> `[154]`

### Węzeł `[157]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Marcel_FundsReElection = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Marcel_FundsReElection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[158]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Marcel_FundsReElection = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Marcel_FundsReElection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[159]`
Mówca: **Nia Morgna**
> "“You asked the ACP to start investigating the Oligarchs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Nia Morgna**
> "“We couldn't find anything related to Walter Tusk yet, but there is a silver lining.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Nia Morgna**
> "“By sheer luck, we have come across a suspicious link in Estord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Narrator**
> "She handed over a police report detailing the network of the Koranelli gang in the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Nia Morgna**
> "“A ledger was previously found in one of the raids against the cartel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Nia Morgna**
> "“It has contents linking their operations to a subsidiary of the Heart of Sordland Conglomerate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[167]`
  - -> `[166]`
  - -> `[168]`

### Węzeł `[165]`
**[WYBÓR GRACZA: "“This is a very big accusation, are you absolutely sure?”"]** — Mówca: **Player**
> "“This is a very big accusation, are you absolutely sure?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[166]`
**[WYBÓR GRACZA: "“Without undeniable evidence there is no point in making assumptions.”"]** — Mówca: **Player**
> "“Without undeniable evidence there is no point in making assumptions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[167]`
**[WYBÓR GRACZA: "“Something must have gone wrong in the investigation. This can't be true.”"]** — Mówca: **Player**
> "“Something must have gone wrong in the investigation. This can't be true.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[168]`
**[WYBÓR GRACZA: "“I never trusted HOS and Koronti anyway.”"]** — Mówca: **Player**
> "“I never trusted HOS and Koronti anyway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Nia Morgna**
> "“That makes two of us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[170]`
Mówca: **Nia Morgna**
> "“Exactly. That is why I refrain from making a final comment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[171]`
Mówca: **Nia Morgna**
> "“We can't know for sure without starting a full investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[172]`
Mówca: **Nia Morgna**
> "“The ledger contains several transactions. There is a case to pursue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[173]`
Mówca: **Nia Morgna**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "“Is that really enough to start rounding up suspects?""]** — Mówca: **Player**
> "“Is that really enough to start rounding up suspects?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Marcel Koronti is a powerful figure that wouldn't like a development like this at all.”"]** — Mówca: **Player**
> "“Marcel Koronti is a powerful figure that wouldn't like a development like this at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[176]`
**[WYBÓR GRACZA: "“To figure out the truth, a more indepth investigation needs to be launched.”"]** — Mówca: **Player**
> "“To figure out the truth, a more indepth investigation needs to be launched.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[177]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[179]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[180]`
Mówca: **Narrator**
> "Nia looked at me with suspicion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Nia Morgna**
> "“I wouldn't come to you if there wasn't anything worth looking into.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[182]`
**[WYBÓR GRACZA: "“There is no way a respectable company like HOS can be linked to this. I don't believe it.”"]** — Mówca: **Player**
> "“There is no way a respectable company like HOS can be linked to this. I don't believe it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[183]`
Mówca: **Nia Morgna**
> "“People like him think they are above the law.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[184]`
Mówca: **Nia Morgna**
> "“No. He wouldn't like it at all but if he is innocent he shouldn't care.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[185]`
Mówca: **Nia Morgna**
> "“At any rate, with this new evidence our case against Mr. Koronti goes far past the ACP's purview. In fact, we should open a full-blown joint investigation with the Interior Ministry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[186]`
Mówca: **Nia Morgna**
> "“Obviously we hope that there is nothing beneath the surface, but if in any way HOS is linked to organised crime...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`
  - -> `[174]`
  - -> `[182]`

### Węzeł `[187]`
**[WYBÓR GRACZA: "“Who did you hear that from?”"]** — Mówca: **Player**
> "“Who did you hear that from?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[188]`
Mówca: **Nia Morgna**
> "“We must tread carefully. There have been rumours about Mr. Koronti having ties to our government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[194]`
  - -> `[191]`
  - -> `[207]`

### Węzeł `[189]`
Mówca: **Nia Morgna**
> "“So. Will you allow us to open an investigation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[190]`
Mówca: **Nia Morgna**
> "“We all have our ways, Mr. President. I wouldn't be sitting here if I didn't know how to keep my ears open.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[191]`
**[WYBÓR GRACZA: "“I'm not surprised at all.”"]** — Mówca: **Player**
> "“I'm not surprised at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Nia Morgna**
> "“Regardless, the Lotherberg members aren't to be trusted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[193]`
Mówca: **Nia Morgna**
> "“I hope that is not just wishful thinking.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[194]`
**[WYBÓR GRACZA: "“Our administration wouldn't fall that low. I have trust in our people.”"]** — Mówca: **Player**
> "“Our administration wouldn't fall that low. I have trust in our people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[195]`
Mówca: **Narrator**
> "Nia got up from her seat and left the meeting room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[196]`
**[WYBÓR GRACZA: "“I trust that we will come with enough information to incriminate him in due time.”"]** — Mówca: **Player**
> "“I trust that we will come with enough information to incriminate him in due time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "“Begin an official investigation to find out if HOS is working with organised crime elements in Estord.”"]** — Mówca: **Player**
> "“Begin an official investigation to find out if HOS is working with organised crime elements in Estord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "“Very well. Meeting adjourned then.”"]** — Mówca: **Player**
> "“Very well. Meeting adjourned then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Nia Morgna**
> "“Thank you for your time, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[200]`
Mówca: **Nia Morgna**
> "“You need to be careful with the oligarchs, Mr. President. Their only loyalty is to money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[201]`
Mówca: **Nia Morgna**
> "“Well. That is all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[202]`
**[WYBÓR GRACZA: "“There is just not enough evidence to trigger an investigation.”"]** — Mówca: **Player**
> "“There is just not enough evidence to trigger an investigation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[203]`
**[WYBÓR GRACZA: "“Absolutely not. Keep your focus on Tusk.""]** — Mówca: **Player**
> "“Absolutely not. Keep your focus on Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[204]`
Mówca: **Nia Morgna**
> "“Hmm. You may be right, but I'd hate to find out that we missed our chance later.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[205]`
Mówca: **Nia Morgna**
> "“We will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[206]`
**[WYBÓR GRACZA: "“Looking forward to the results. Do your best.”"]** — Mówca: **Player**
> "“Looking forward to the results. Do your best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[207]`
**[WYBÓR GRACZA: "“I've personally met him once. Didn't seem like a bad guy.”"]** — Mówca: **Player**
> "“I've personally met him once. Didn't seem like a bad guy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[208]`
Mówca: **Nia Morgna**
> "“They always try to impress but it is all smoke and mirrors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[209]`
Mówca: **Narrator**
> "We both locked eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[210]`
  - -> `[203]`

### Węzeł `[210]`
**[WYBÓR GRACZA: "“We can't be hasty here. We will wait until we have a more concrete lead.”"]** — Mówca: **Player**
> "“We can't be hasty here. We will wait until we have a more concrete lead.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Nia Morgna**
> "“It seems... questionable that we aren't pursuing this now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`
  - -> `[196]`
  - -> `[202]`

### Węzeł `[212]`
Mówca: **Nia Morgna**
> "“I will contact Lileas and get to the bottom of it. Expect a report soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[206]`

### Węzeł `[213]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_InvestigationOnHOS = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SnO_InvestigationOnHOS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[214]`
**[WYBÓR GRACZA: "“It would be even worse if we acted too hasty and the lead turned out to be a false one.”"]** — Mówca: **Player**
> "“It would be even worse if we acted too hasty and the lead turned out to be a false one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[215]`
Mówca: **Narrator**
> "Karl Greiser requested to set up a short meeting regarding Marcel Koronti."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Narrator**
> "He entered the meeting room and saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`
  - -> `[219]`
  - -> `[221]`

### Węzeł `[217]`
**[WYBÓR GRACZA: "“Karl. Good to see you. What did you want to talk about?”"]** — Mówca: **Player**
> "“Karl. Good to see you. What did you want to talk about?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[218]`
**[WYBÓR GRACZA: "“This better be worth my time.”"]** — Mówca: **Player**
> "“This better be worth my time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[219]`
**[WYBÓR GRACZA: "“At ease.”"]** — Mówca: **Player**
> "“At ease.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
**[WYBÓR GRACZA: "Salute him."]** — Mówca: **Player_Italic**
> "I saluted him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[222]`
Mówca: **Karl Greiser**
> "“I wanted to give you an update on the current status of Marcel Koronti.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Karl Greiser**
> "“We have interrogated him and learned about something extremely disturbing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[224]`
Mówca: **Karl Greiser**
> "“By his account, HOS has been making deals with the Koranelli Cartel in Estord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[227]`
  - -> `[228]`

### Węzeł `[225]`
Mówca: **Karl Greiser**
> "“He will spend the rest of his life in prison.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`
  - -> `[232]`
  - -> `[235]`

### Węzeł `[226]`
**[WYBÓR GRACZA: "“Are you sure about this? If this is true, this is really big.”"]** — Mówca: **Player**
> "“Are you sure about this? If this is true, this is really big.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[227]`
**[WYBÓR GRACZA: "“Traitor! I knew it was a good idea to put him in prison.”"]** — Mówca: **Player**
> "“Traitor! I knew it was a good idea to put him in prison.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[228]`
**[WYBÓR GRACZA: "“This doesn't surprise me at all.”"]** — Mówca: **Player**
> "“This doesn't surprise me at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Karl Greiser**
> "“Me too, sir. It was a good idea to put him in custody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[230]`
Mówca: **Karl Greiser**
> "“I agree, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[231]`
Mówca: **Karl Greiser**
> "“We have his written testimony, sir. Also, we checked the connections. It all seems to add up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[232]`
**[WYBÓR GRACZA: "“Try to get whatever you can out from him. There might be more leads.”"]** — Mówca: **Player**
> "“Try to get whatever you can out from him. There might be more leads.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Karl Greiser**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "“Serves him right!”"]** — Mówca: **Player**
> "“Serves him right!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
**[WYBÓR GRACZA: "“Very good. Anything else?”"]** — Mówca: **Player**
> "“Very good. Anything else?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
Mówca: **Karl Greiser**
> "“You have brought a known criminal to justice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Karl Greiser**
> "“There is...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[238]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[240]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Karl Greiser**
> "“That is all I had for today, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[242]`
  - -> `[243]`

### Węzeł `[242]`
**[WYBÓR GRACZA: "“Excellent. You may leave now.”"]** — Mówca: **Player**
> "“Excellent. You may leave now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[243]`
**[WYBÓR GRACZA: "“Keep up the good work.”"]** — Mówca: **Player**
> "“Keep up the good work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[244]`
**[WYBÓR GRACZA: "“Good. We are done then. Dismissed.”"]** — Mówca: **Player**
> "“Good. We are done then. Dismissed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Narrator**
> "He saluted again and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[246]`
Mówca: **Karl Greiser**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[247]`
Mówca: **Karl Greiser**
> "“It's my duty.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[248]`
Mówca: **Karl Greiser**
> "“There is something else he confessed, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Karl Greiser**
> "“We have disregarded his remarks, obviously.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[250]`
Mówca: **Karl Greiser**
> "“He was definitely lying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`
  - -> `[253]`

### Węzeł `[251]`
**[WYBÓR GRACZA: "“What did he confess?”"]** — Mówca: **Player**
> "“What did he confess?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[252]`
**[WYBÓR GRACZA: "“Speak, man.”"]** — Mówca: **Player**
> "“Speak, man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
**[WYBÓR GRACZA: "“Lying about what?”"]** — Mówca: **Player**
> "“Lying about what?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Karl Greiser**
> "“He...he said that he had a deal with you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[255]`
Mówca: **Karl Greiser**
> "“He said he lent you his power to control the media.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Karl Greiser**
> "“Of course... he was lying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[257]`
  - -> `[258]`

### Węzeł `[257]`
**[WYBÓR GRACZA: "“I see. He is trying to bring me down along with himself.”"]** — Mówca: **Player**
> "“I see. He is trying to bring me down along with himself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[258]`
**[WYBÓR GRACZA: "“You will not speak a word of this to anyone. Do you understand?”"]** — Mówca: **Player**
> "“You will not speak a word of this to anyone. Do you understand?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[259]`
**[WYBÓR GRACZA: "“Yes. What else did he say?”"]** — Mówca: **Player**
> "“Yes. What else did he say?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Karl Greiser**
> "“He gave further accounts on how the deal was made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[261]`
Mówca: **Karl Greiser**
> "“That is exactly what I thought, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[262]`
Mówca: **Karl Greiser**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[265]`

### Węzeł `[263]`
**[WYBÓR GRACZA: "“Make sure these rumours never get out. It might create a problem.”"]** — Mówca: **Player**
> "“Make sure these rumours never get out. It might create a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[264]`
Mówca: **Karl Greiser**
> "“He does have a very wild imagination, but I did not fall for it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[263]`
  - -> `[265]`

### Węzeł `[265]`
**[WYBÓR GRACZA: "“I'm not worried. No one will believe this broken man.”"]** — Mówca: **Player**
> "“I'm not worried. No one will believe this broken man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Karl Greiser**
> "“There is no way, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[267]`
Mówca: **Karl Greiser**
> "“Only a few officers who were in the area heard him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[268]`
Mówca: **Karl Greiser**
> "“I will make sure your order is conveyed and implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[269]`
Mówca: **Karl Greiser**
> "“That is all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[242]`
  - -> `[243]`

### Węzeł `[270]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_SnO_LE_Policy_SecretStateService == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_LE_Policy_SecretStateService"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[273]`
**[WYBÓR GRACZA: "“He is too dangerous to stay alive. I want him gone. Discreetly.”"]** — Mówca: **Player**
> "“He is too dangerous to stay alive. I want him gone. Discreetly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[274]`
Mówca: **Karl Greiser**
> "“Sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
**[WYBÓR GRACZA: "“You heard me. Are you questioning my decision, Karl?”"]** — Mówca: **Player**
> "“You heard me. Are you questioning my decision, Karl?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[276]`
**[WYBÓR GRACZA: "“He has shown that he can affect the administration even in custody.”"]** — Mówca: **Player**
> "“He has shown that he can affect the administration even in custody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[277]`
**[WYBÓR GRACZA: "“I gave you an order.”"]** — Mówca: **Player**
> "“I gave you an order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Karl Greiser**
> "“Yes, sir. Right away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[279]`
Mówca: **Karl Greiser**
> "“No, sir. I will handle it right away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Karl Greiser**
> "“Makes sense, sir. I will handle it right away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Karl Greiser**
> "“Rest assured. No one will hear of this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[283]`
  - -> `[285]`

### Węzeł `[282]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Killed_MarcelKoronti = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Killed_MarcelKoronti"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[283]`
**[WYBÓR GRACZA: "“Remember. Both you and I are responsible for protecting Sordland.”"]** — Mówca: **Player**
> "“Remember. Both you and I are responsible for protecting Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[284]`
**[WYBÓR GRACZA: "“That better be right. For your own good.”"]** — Mówca: **Player**
> "“That better be right. For your own good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[285]`
**[WYBÓR GRACZA: "“Thank you, Karl. You are a loyal man.”"]** — Mówca: **Player**
> "“Thank you, Karl. You are a loyal man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[286]`
Mówca: **Karl Greiser**
> "“I live for Sordland, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[287]`
Mówca: **Karl Greiser**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[288]`
Mówca: **Karl Greiser**
> "“Thank you, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[289]`
Mówca: **Karl Greiser**
> "“That is all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`
  - -> `[242]`
  - -> `[243]`

### Węzeł `[290]`
Mówca: **Karl Greiser**
> "“That brings me to the end of my report.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[291]`
Mówca: **Karl Greiser**
> "“That brings me to the end of my report.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[292]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_KorontiInvestigationStopped = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[293]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SnO_KorontiInvestigationStopped = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SnO_KorontiInvestigationStopped"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[294]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_EstordRaid_MarcelKilled = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_MarcelKilled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[295]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[296]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_BeginInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[297]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestigation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[298]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestigation = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_StoppedInvestigation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[299]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[300]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[301]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Fled_MarcelKoronti == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Fled_MarcelKoronti == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[303]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Fled_MarcelKoronti == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Fled_MarcelKoronti"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[304]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true || BaseGame.Turn07_A_Marcel_OwnershipDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_MediaDeal == true || BaseGame.Turn07_A_Marcel_OwnershipDeal == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true  or  Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[306]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_MediaDeal == true || BaseGame.Turn07_A_Marcel_OwnershipDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true  or  Variable["BaseGame.Turn07_A_Marcel_OwnershipDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Narrator**
> "If Marcel's cartel ties were real, this was huge news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[308]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection = false)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_EstordRaid_MarcelFundsReelection"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[309]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: BaseGame.Marcel_FundsReElection = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Marcel_FundsReElection"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[310]`
Mówca: **Marcel Koronti**
> "“Well, I don't think I can make an offer without seeing what I am buying first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`
  - -> `[33]`

### Węzeł `[311]`
**[WYBÓR GRACZA: "“What are you offering for this information?”"]** — Mówca: **Player**
> "“What are you offering for this information?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[312]`
**[WYBÓR GRACZA: "“Disappointing, I will find someone else to work with.”"]** — Mówca: **Player**
> "“Disappointing, I will find someone else to work with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[313]`
Mówca: **Lileas Graf**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
