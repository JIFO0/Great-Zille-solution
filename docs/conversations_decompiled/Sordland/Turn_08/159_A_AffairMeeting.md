# Sordland/Turn08/A_AffairMeeting

- **ID konwersacji:** `159`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/159_A_AffairMeeting.md`
- **Liczba węzłów dialogowych:** 355
- **Liczba wyborów gracza:** 79

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BFF_EliminationOperation`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Ersen`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Lespia_TradeDeal`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Diplomacy_EmbargoingArcasia`
- `BaseGame.Policy_Diplomacy_EmbargoingUnitedContana`
- `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.TradeDeal_Negotiation_Lespia`
- `BaseGame.TradeDeal_Negotiation_Valgsland`
- `BaseGame.Turn04_SnO_LE_Interior_Decreased`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn08_SecondScandal_InformLucianAboutAffair`
- `BaseGame.Turn08_SecondScandal_RumburgBlamed`
- `BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Valgsland_TradeDeal`
- `BaseGame.YoungSords_Aids_Security`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.BFF_Damaged`
- `BaseGame.BFF_Destroyed`
- `BaseGame.BFF_EliminationOperation_Botched`
- `BaseGame.Relations_Lucian_Opinion`
- `BaseGame.Turn08_SecondScandal_LiviaInvestigated`
- `BaseGameSupport.Journal_Turn08_SecondScandal_LiviaInvestigated`
- `BaseGameSupport.News_Turn08_HP_GovernorErsen_DisplaysArge`
- `BaseGameSupport.News_Turn08_HP_GovernorKrull_InvitesRemus`
- `BaseGameSupport.News_Turn08_LT_GovernorBronContinuesResettlement`
- `BaseGameSupport.News_Turn08_LT_GovernorErsen_DisplaysArge`
- `BaseGameSupport.News_Turn08_R_GovernorBronContinuesResettlement`
- `BaseGameSupport.News_Turn08_R_GovernorKrull_InvitesRemus`
- `BaseGameSupport.News_Turn08_ST_NoDeal_GovernorErsen_DisplaysArge`
- `BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_Both`
- `BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_LanguageBill`
- `BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_ReligiousHarmonyBill`
- `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Ersen`
- `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Governor`
- `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Damaged`
- `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Failure`
- `BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Success`
- `GameCondition.Turn08_A_AffairMeeting`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 36

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Lucian_Opinion`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Lucian Galade): `Variable["GameCondition.Turn08_A_AffairMeeting"] = true;`
- Węzeł `[38]` (Lucian Galade): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- Węzeł `[39]` (Lucian Galade): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- Węzeł `[42]` (Lucian Galade): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- Węzeł `[142]` (Lucian Galade): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- Węzeł `[176]` (Lucian Galade): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- Węzeł `[223]` (Lucian Galade): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- Węzeł `[233]` (Lucian Galade): `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- *...oraz 28 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn08_A_AffairMeeting = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn08_A_AffairMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[4]`
Mówca: **Narrator**
> "It was early in the morning after my talk with Petr. The sun was just beginning to peek over the horizon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_InformLucianAboutAffair == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_InformLucianAboutAffair == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_InformLucianAboutAffair"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_InformLucianAboutAffair == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_InformLucianAboutAffair"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
Mówca: **Narrator**
> "The Maroon Palace was empty save for a few cleaning staff. I entered my office to find Lucian already waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[9]`
Mówca: **Narrator**
> "The Maroon Palace was empty save for a few cleaning staff. I entered my office and was shocked to see Lucian already there, waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Narrator**
> "I couldn't sleep, so I decided I might as well head to the palace early and get some uninterrupted work done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[11]`
Mówca: **Lucian Galade**
> ""Mr. President. Good. I was hoping you'd be early.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Lucian, I know you're punctual, but this is ridiculous!""]** — Mówca: **Player**
> ""Lucian, I know you're punctual, but this is ridiculous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""What's going on?""]** — Mówca: **Player**
> ""What's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[14]`
Mówca: **Lucian Galade**
> ""Mr. President. Thank you for meeting with me at this hour.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
**[WYBÓR GRACZA: ""I couldn't sleep anyway.""]** — Mówca: **Player**
> ""I couldn't sleep anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
**[WYBÓR GRACZA: ""Cut to the chase.""]** — Mówca: **Player**
> ""Cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""Very well. I'm pleased that you chose to call me after your conversation with Mr. Vectern last night -- although I was already aware of his illicit relationship with Miss Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""I figured as much. You do know everything that goes on in the Palace, after all.""]** — Mówca: **Player**
> ""I figured as much. You do know everything that goes on in the Palace, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""How did you find out?""]** — Mówca: **Player**
> ""How did you find out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""I'll get to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Lucian smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""On its own, given Mr. Vectern's established reputation as something of a playboy, the affair is unlikely to cause much damage. However, a more troubling possibility has been brought to light.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Lucian Galade**
> ""A recent conversation with Mr. Hailstone, our whistleblower from Rumburg, revealed the presence of a spy within the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[27]`
Mówca: **Lucian Galade**
> ""For some time now, I have privately suspected the presence of an intelligence leak coming from within the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""I have a sensitive matter to discuss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""I have very good reason to believe your vice president and your secretary are engaging in illicit relations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[32]`
  - -> `[31]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""Yes, he told me. It's over now.""]** — Mówca: **Player**
> ""Yes, he told me. It's over now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""What? Unbelievable!""]** — Mówca: **Player**
> ""What? Unbelievable!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""I know. We're handling it.""]** — Mówca: **Player**
> ""I know. We're handling it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "Lucian gave me a wounded look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Lucian Galade**
> ""You knew, and you didn't come to me with this information?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`
  - -> `[37]`

### Węzeł `[35]`
**[WYBÓR GRACZA: ""I assumed you were already aware. You do know everything that goes on in this palace, after all.""]** — Mówca: **Player**
> ""I assumed you were already aware. You do know everything that goes on in this palace, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""I don't need your help. We've got this under control.""]** — Mówca: **Player**
> ""I don't need your help. We've got this under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: ""He only told me yesterday. I was going to come to you first thing today.""]** — Mówca: **Player**
> ""He only told me yesterday. I was going to come to you first thing today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Lucian frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Lucian smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[42]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""I'm sorry to be the bearer of this news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""Well, don't hesitate to call straight away next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""I believe Miss Suno is our mole. She has been using her relationship with Mr. Vectern to gather information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`
  - -> `[48]`
  - -> `[49]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "Laugh incredulously."]** — Mówca: **Player_Italic**
> "I laughed incredulously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""Tell me more.""]** — Mówca: **Player**
> ""Tell me more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""You're being paranoid, Lucian.""]** — Mówca: **Player**
> ""You're being paranoid, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[49]`
**[WYBÓR GRACZA: ""That's preposterous.""]** — Mówca: **Player**
> ""That's preposterous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[50]`
Mówca: **Narrator**
> "Lucian reached into his coat pocket, pulled out an audio tape and fed it into the reel-to-reel machine on my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""This was recorded in the Palace at 18:09 on the second day of your trade visit to Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[52]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame.Valgsland_TradeDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame.Valgsland_TradeDeal == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true  and  Variable["BaseGame.Valgsland_TradeDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[54]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.TradeDeal_Negotiation_Lespia == true && BaseGame.Valgsland_TradeDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Lespia"] == true  and  Variable["BaseGame.Valgsland_TradeDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.TradeDeal_Negotiation_Valgsland == true && BaseGame.Lespia_TradeDeal == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.TradeDeal_Negotiation_Valgsland == true && BaseGame.Lespia_TradeDeal == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == true  and  Variable["BaseGame.Lespia_TradeDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.TradeDeal_Negotiation_Valgsland == true && BaseGame.Lespia_TradeDeal == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.TradeDeal_Negotiation_Valgsland"] == true  and  Variable["BaseGame.Lespia_TradeDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Lucian Galade**
> ""This was recorded in the Palace at 18:09 following our return from the meeting with Deivid Wisci in Benfi.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[59]`
Mówca: **Lucian Galade**
> ""This was recorded in the Palace at 18:09 on the second day of your trade visit to Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[60]`
Mówca: **Narrator**
> "He pressed play. I heard Petr and Livia's voices."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Livia Suno**
> ""You're sure everyone's gone for the day?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[62]`
Mówca: **Petr Vectern**
> ""Relax, Liv. Nobody's working that hard with Anton off in Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
Mówca: **Petr Vectern**
> ""Relax, Liv. Nobody's working that hard with Anton off in Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[64]`
Mówca: **Petr Vectern**
> ""Relax, Liv. You don't have to bend over backwards for my pal Anton tonight. Only me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[65]`
Mówca: **Narrator**
> "Livia giggled. I heard the sound of kissing, then of drinks being poured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Livia Suno**
> ""Mmm. I'm glad you stayed behind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[67]`
Mówca: **Narrator**
> "Livia giggled. I heard the sound of kissing, then of drinks being poured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Livia giggled. I heard the sound of kissing, then of drinks being poured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Livia Suno**
> ""Mmm. I missed you in Benfi.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""I wish I was wrong, sir. But I've just come into possession of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[71]`
Mówca: **Lucian Galade**
> ""I can do better than that -- I'll show you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[72]`
Mówca: **Livia Suno**
> ""Did he tell you how it's going over there? Do you think there's a chance they'll form an alliance?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[73]`
Mówca: **Livia Suno**
> ""Did he tell you why he decided not to make a deal with Lespia or Valgsland? He's not interested in forming any alliances?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[74]`
Mówca: **Petr Vectern**
> ""As a matter of fact, yes. He and Prime Minister Alvarez just sealed the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[77]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[81]`
Mówca: **Petr Vectern**
> ""As a matter of fact, yes. He and Secretary Hegel just sealed the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[82]`
Mówca: **Petr Vectern**
> ""The embargo diminished our chances with United Contana. Although we've still got a shot with Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[83]`
Mówca: **Petr Vectern**
> ""Ah, something about staying as neutral as possible. Although even Iosef is saying we should find allies to deter Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[84]`
Mówca: **Petr Vectern**
> ""But speaking of forming alliances, Miss Suno...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[85]`
Mówca: **Narrator**
> "Lucian grimaced and switched the tape off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`
  - -> `[88]`
  - -> `[89]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""That's it? That's your damning evidence?""]** — Mówca: **Player**
> ""That's it? That's your damning evidence?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""This is indeed cause for concern.""]** — Mówca: **Player**
> ""This is indeed cause for concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""Curiosity about foreign relations doesn't make one a spy.""]** — Mówca: **Player**
> ""Curiosity about foreign relations doesn't make one a spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""And then what happened?""]** — Mówca: **Player**
> ""And then what happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
> ""You don't need to hear the rest of it. The important question is, why so much curiosity about these particular alliances, if not because they could strengthen us against Rumburg?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""I'm glad you agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""Perhaps, but why so much curiosity about these particular alliances, if not because they could strengthen us against Rumburg?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""Think about it. Why so much curiosity about these particular alliances, if not because they could strengthen us against Rumburg?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Just then, there was a knock on the door. Livia opened it cautiously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Livia Suno**
> ""Good morning, Mr. President, Mr. Galade. I didn't realize you'd be in so early. Can I get you some coffee?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[97]`
  - -> `[96]`

### Węzeł `[96]`
**[WYBÓR GRACZA: ""Close the door. Have a seat.""]** — Mówca: **Player**
> ""Close the door. Have a seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Coffee would be great, actually.""]** — Mówca: **Player**
> ""Coffee would be great, actually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "Wait for Lucian to say something."]** — Mówca: **Player_Italic**
> "I stayed silent. Lucian finally spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Lucian Galade**
> ""Please have a seat, Miss Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Narrator**
> "Livia left to make coffee. A few minutes later, she came back and served the coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[101]`
Mówca: **Narrator**
> "Livia sat. She looked puzzled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Livia Suno**
> ""Is something the matter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""Enough pretending. Your secret is out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Livia Suno**
> ""I... I'm not sure what you're talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`
  - -> `[107]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Come on, Livia. Petr already told me everything.""]** — Mówca: **Player**
> ""Come on, Livia. Petr already told me everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""You know perfectly well.""]** — Mówca: **Player**
> ""You know perfectly well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""Livia. Lucian has evidence.""]** — Mówca: **Player**
> ""Livia. Lucian has evidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Livia buried her face in her hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Livia Suno**
> ""I'm so sorry, Mr. President. I was foolish, and Petr was so nice to me... But it's over now. Nobody ever needs to know--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Lucian Galade**
> ""That's not what the President means, Miss Suno. We're referring to you being an intelligence agent for Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Livia sat upright. She looked shocked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Livia Suno**
> ""Pardon me, Mr. Galade, but are you feeling all right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[118]`
  - -> `[114]`
  - -> `[115]`

### Węzeł `[113]`
**[WYBÓR GRACZA: ""No, he isn't. You'll have to excuse him.""]** — Mówca: **Player**
> ""No, he isn't. You'll have to excuse him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""Don't play dumb, Livia. If that is your real name.""]** — Mówca: **Player**
> ""Don't play dumb, Livia. If that is your real name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[115]`
**[WYBÓR GRACZA: ""He's fine. What do you have to say for yourself?""]** — Mówca: **Player**
> ""He's fine. What do you have to say for yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[116]`
Mówca: **Lucian Galade**
> ""And that's not all. I found her resume on file and there's a year-long gap between her finishing secretarial school and beginning her career.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Lucian Galade**
> ""Normally, this would have been looked into. But Miss Suno was hired before a background check could be completed. By one Petr Vectern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[118]`
**[WYBÓR GRACZA: ""I know. It sounds ridiculous to me as well.""]** — Mówca: **Player**
> ""I know. It sounds ridiculous to me as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""Miss Suno, indulge me for a moment. What were you doing in the year 1951?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Lucian folded his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[121]`
Mówca: **Narrator**
> "Livia's face flushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Livia Suno**
> ""If you must know, I was working as a cigarette girl at Porto's. It's a Lachaven saloon. I was saving up so I could afford my own place in Holsord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Livia Suno**
> ""Here's the proprietor's number if you need to double check.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Livia Suno**
> ""Mr. President, I understand if you don't want me to keep my job, but why smear me with outlandish accusations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[125]`
Mówca: **Narrator**
> "She scribbled a telephone number on a piece of paper. Lucian snatched it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`
  - -> `[128]`

### Węzeł `[126]`
**[WYBÓR GRACZA: ""But why have you been asking me so many questions about what I do?""]** — Mówca: **Player**
> ""But why have you been asking me so many questions about what I do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[127]`
**[WYBÓR GRACZA: ""But why were you asking Petr about my alliances?""]** — Mówca: **Player**
> ""But why were you asking Petr about my alliances?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[128]`
**[WYBÓR GRACZA: ""But why were you so eager to help Deivid back in Benfi?""]** — Mówca: **Player**
> ""But why were you so eager to help Deivid back in Benfi?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[129]`
Mówca: **Livia Suno**
> ""To tell the truth, Mr. Rayne... I was hoping to run for office myself someday. I want to make a real difference in the world, like Ms. Morgna or Ms. Walda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Livia Suno**
> ""But I guess I messed that up by getting involved with Petr. Now they're all just going to say I slept my way to the top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[131]`
Mówca: **Livia Suno**
> ""To tell the truth, Mr. Rayne... I was hoping to run for office myself someday. I want to make a real difference in the world, like Ms. Morgna or Ms. Walda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Livia Suno**
> ""But I guess I messed that up by getting involved with Petr. Now they're all just going to say I slept my way to the top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[133]`
Mówca: **Livia Suno**
> ""But I guess I messed that up by getting involved with Petr. Now they're all just going to say I slept my way to the top.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[134]`
Mówca: **Livia Suno**
> ""To tell the truth, Mr. Rayne... I was hoping to run for office myself someday. I want to make a real difference in the world, like Ms. Morgna or Ms. Walda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[135]`
Mówca: **Livia Suno**
> ""Wait. How did you know about that conversation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Narrator**
> "There was a loud pounding on the door. Petr barged in without waiting for an answer. He was unshaven, and wore the same clothes as the night before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""And your questioning Petr about Sordland's potential alliances?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[138]`
Mówca: **Lucian Galade**
> ""And your questioning Petr about Sordland's potential alliances?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Livia Suno**
> ""I told you, I-- wait. How do you know about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[140]`
Mówca: **Livia Suno**
> ""I told you, I-- wait. How do you know about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[141]`
Mówca: **Petr Vectern**
> ""I came as soon as I heard the three of you were in here. Anton, what the hell are you doing? I told you I had this under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
  - -> `[144]`
  - -> `[145]`

### Węzeł `[142]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[143]`
**[WYBÓR GRACZA: ""Sorry. I had to tell Lucian.""]** — Mówca: **Player**
> ""Sorry. I had to tell Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[144]`
**[WYBÓR GRACZA: ""Sorry. Lucian already found out.""]** — Mówca: **Player**
> ""Sorry. Lucian already found out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
**[WYBÓR GRACZA: ""Sit down and shut up.""]** — Mówca: **Player**
> ""Sit down and shut up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Narrator**
> "Petr took a seat on the far end of the sofa. He looked over at Livia and noticed her troubled expression."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Petr Vectern**
> ""God, why involve her? This is my mess. She did nothing wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[149]`
  - -> `[148]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""She's a spy, Petr. You messed up big-time.""]** — Mówca: **Player**
> ""She's a spy, Petr. You messed up big-time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Lucian has the preposterous idea that she's a spy.""]** — Mówca: **Player**
> ""Lucian has the preposterous idea that she's a spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""Well... there's a small chance she could be a spy.""]** — Mówca: **Player**
> ""Well... there's a small chance she could be a spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Petr Vectern**
> ""I-- what?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
> ""I have reason to believe she's been relaying information to Rumburg. Information that you leaked to her in your carelessness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Narrator**
> "Lucian rewound his tape and played it again. As Petr listened, his eyes widened in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Petr Vectern**
> ""Lucian, you rat bastard. You've been bugging my office!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[156]`
  - -> `[157]`

### Węzeł `[155]`
**[WYBÓR GRACZA: ""Obviously for a good reason.""]** — Mówca: **Player**
> ""Obviously for a good reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[156]`
**[WYBÓR GRACZA: ""Lucian, is this true? How could you?""]** — Mówca: **Player**
> ""Lucian, is this true? How could you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[157]`
**[WYBÓR GRACZA: ""I'm sure there's an explanation for this.""]** — Mówca: **Player**
> ""I'm sure there's an explanation for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Lucian Galade**
> ""I had noticed the Vice President's behaviour becoming increasingly erratic and unprofessional over the past months. I wanted to get to the root of the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Narrator**
> "Both Petr and Livia were glaring at Lucian now. He looked unrepentant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[160]`
Mówca: **Petr Vectern**
> ""So you wiretapped your own goddamn colleague? And for what? Have you been getting off on this, you pervert?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
> ""Certainly not. I believe that along with the Rumburg whistleblower's admission that there is a spy in the Palace and certain gaps in Miss Suno's resume, this tape makes a compelling case to investigate the secretary for espionage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[164]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Lucian Galade**
> ""Certainly not. I believe that along with certain gaps in Miss Suno's resume, this tape makes a compelling case to investigate the secretary for espionage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Lucian Galade**
> ""Whether or not the investigation yields positive results, Mr. Vectern ought to be held accountable for his willingness to divulge such sensitive information. He ought to stand trial or, at the very least, resign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Narrator**
> "Petr's jaw dropped. Livia stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Livia Suno**
> ""If I may, Mr. President. I've been paying attention to what goes on in the Palace. Not because I'm some sort of agent, but out of genuine interest. Hard as that may be for you to believe, Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[169]`
Mówca: **Livia Suno**
> ""And from what I've seen, this man has been attempting to undermine your vice president at every turn. Perhaps with the goal of replacing Petr himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`
  - -> `[174]`
  - -> `[173]`

### Węzeł `[170]`
Mówca: **Narrator**
> "She scowled at Lucian, then turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[171]`
**[WYBÓR GRACZA: ""Of course you'd say that. Petr's your lover.""]** — Mówca: **Player**
> ""Of course you'd say that. Petr's your lover.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[172]`
**[WYBÓR GRACZA: ""That's ridiculous. I would never make Lucian vice president.""]** — Mówca: **Player**
> ""That's ridiculous. I would never make Lucian vice president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""That actually makes a lot of sense.""]** — Mówca: **Player**
> ""That actually makes a lot of sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Nonsense. Lucian's been nothing but loyal.""]** — Mówca: **Player**
> ""Nonsense. Lucian's been nothing but loyal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[175]`
Mówca: **Narrator**
> "Lucian looked slightly shaken at that remark, but quickly regained his usual grace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[176]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[177]`
Mówca: **Narrator**
> "Livia looked at Petr on the other end of the couch. Her eyes softened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Livia Suno**
> ""He *was* my lover. We've put this behind us. The two of you ought to do so as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[179]`
Mówca: **Petr Vectern**
> ""Loyal to you. It's true, he never could stand me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Livia Suno**
> ""Thank you. I'm happy someone at the Palace still takes me seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Narrator**
> "Lucian frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""My personal misgivings about Mr. Vectern aside, I would never do anything to harm this administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Lucian Galade**
> ""Mr. Vectern, on the other hand, has at best committed adultery, and at worst, delivered state secrets straight into enemy hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Who could I believe?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`
  - -> `[187]`

### Węzeł `[185]`
**[WYBÓR GRACZA: ""Lucian, can I speak to you alone for a moment?""]** — Mówca: **Player**
> ""Lucian, can I speak to you alone for a moment?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[186]`
**[WYBÓR GRACZA: ""Petr, Livia -- out. Now!""]** — Mówca: **Player**
> ""Petr, Livia -- out. Now!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[187]`
**[WYBÓR GRACZA: ""Petr and Livia, please wait outside while I try to talk some sense into Lucian.""]** — Mówca: **Player**
> ""Petr and Livia, please wait outside while I try to talk some sense into Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[188]`
Mówca: **Narrator**
> "Petr and Livia exchanged worried glances before exiting my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Lucian Galade**
> ""What are you going to do, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`
  - -> `[192]`
  - -> `[191]`
  - -> `[193]`

### Węzeł `[190]`
**[WYBÓR GRACZA: ""I believe you. We should investigate Livia.""]** — Mówca: **Player**
> ""I believe you. We should investigate Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[191]`
**[WYBÓR GRACZA: ""Honestly, I ought to fire you for surveilling Petr.""]** — Mówca: **Player**
> ""Honestly, I ought to fire you for surveilling Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[192]`
**[WYBÓR GRACZA: ""You're the strategist here, not me. You make the call.""]** — Mówca: **Player**
> ""You're the strategist here, not me. You make the call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[193]`
**[WYBÓR GRACZA: ""I'm not investigating my own secretary. I won't play into your hands.""]** — Mówca: **Player**
> ""I'm not investigating my own secretary. I won't play into your hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[194]`
Mówca: **Lucian Galade**
> ""What else could I have done? You couldn't look past your history together and see Mr. Vectern for who he truly is. You still can't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[213]`
  - -> `[208]`
  - -> `[209]`

### Węzeł `[195]`
Mówca: **Lucian Galade**
> ""I already told you what we should do, sir. Investigate Miss Suno.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[199]`
  - -> `[193]`

### Węzeł `[196]`
Mówca: **Lucian Galade**
> ""Then you're playing straight into Rumburg's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[214]`
  - -> `[232]`

### Węzeł `[197]`
Mówca: **Narrator**
> "Lucian breathed a sigh of relief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[198]`
Mówca: **Lucian Galade**
> ""And Mr. Vectern? What will you do about his willingness to compromise Sordland's security at the drop of a pencil skirt?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[201]`
  - -> `[202]`

### Węzeł `[199]`
**[WYBÓR GRACZA: ""And if she does turn out to be a spy, and word gets out? I'll look like a fool.""]** — Mówca: **Player**
> ""And if she does turn out to be a spy, and word gets out? I'll look like a fool.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
**[WYBÓR GRACZA: ""Not if Mr. Vectern shoulders the blame. As he should.""]** — Mówca: **Lucian Galade**
> ""Not if Mr. Vectern shoulders the blame. As he should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`
  - -> `[206]`

### Węzeł `[201]`
**[WYBÓR GRACZA: ""I'll settle that with him personally.""]** — Mówca: **Player**
> ""I'll settle that with him personally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
**[WYBÓR GRACZA: ""I'll decide that once we have the results.""]** — Mówca: **Player**
> ""I'll decide that once we have the results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Lucian Galade**
> ""Very well. Just keep in mind you may need him to shoulder the blame for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[204]`
**[WYBÓR GRACZA: ""I wouldn't make him do that.""]** — Mówca: **Player**
> ""I wouldn't make him do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[205]`
**[WYBÓR GRACZA: ""True, he was the one who hired her...""]** — Mówca: **Player**
> ""True, he was the one who hired her...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[206]`
**[WYBÓR GRACZA: ""We'll decide that when the time comes.""]** — Mówca: **Player**
> ""We'll decide that when the time comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[207]`
**[WYBÓR GRACZA: ""Livia was right. You do have it out for him.""]** — Mówca: **Player**
> ""Livia was right. You do have it out for him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[208]`
**[WYBÓR GRACZA: ""You might have a point. He's not the man he once was.""]** — Mówca: **Player**
> ""You might have a point. He's not the man he once was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[209]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_TalkToEvelynAboutAffair"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WYBÓR GRACZA: ""Evelyn also told me something to that effect.""]** — Mówca: **Player**
> ""Evelyn also told me something to that effect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[213]`
**[WYBÓR GRACZA: ""Petr's problems aren't your business.""]** — Mówca: **Player**
> ""Petr's problems aren't your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[214]`
**[WYBÓR GRACZA: ""Get a grip on yourself, Lucian. There is no spy.""]** — Mówca: **Player**
> ""Get a grip on yourself, Lucian. There is no spy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[215]`
**[WYBÓR GRACZA: ""Fine. Let's investigate her just to be on the safe side.""]** — Mówca: **Player**
> ""Fine. Let's investigate her just to be on the safe side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[216]`
Mówca: **Lucian Galade**
> ""Sir, do I have your permission to proceed with the investigation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
**[WYBÓR GRACZA: ""Yes.""]** — Mówca: **Player**
> ""Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[218]`
**[WYBÓR GRACZA: ""No. Livia and Petr will continue working for me as usual. None of this happened.""]** — Mówca: **Player**
> ""No. Livia and Petr will continue working for me as usual. None of this happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[219]`
**[WYBÓR GRACZA: ""Petr did what any man would. You'd understand if you weren't a workaholic.""]** — Mówca: **Player**
> ""Petr did what any man would. You'd understand if you weren't a workaholic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Lucian Galade**
> ""It's a legitimate orientation, sir. That aside, keep in mind you may well need Petr to shoulder the blame for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[221]`
Mówca: **Narrator**
> "Lucian adjusted his tie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Lucian Galade**
> ""I'll apologize to Miss Suno and tell her this has all been a misunderstanding. We can't have her running away during the investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`
  - -> `[242]`

### Węzeł `[223]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[224]`
Mówca: **Lucian Galade**
> ""I am only looking out for you, sir. The way I always do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
Mówca: **Lucian Galade**
> ""He's exactly the man he once was. That's the problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Lucian Galade**
> ""Just tell me, do I have your permission to launch an investigation into Miss Suno?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`
  - -> `[229]`

### Węzeł `[227]`
Mówca: **Lucian Galade**
> ""That poor woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[228]`
**[WYBÓR GRACZA: ""Yes. Just to be safe.""]** — Mówca: **Player**
> ""Yes. Just to be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[229]`
**[WYBÓR GRACZA: ""No. Livia and Petr will continue working for me as usual. None of this happened.""]** — Mówca: **Player**
> ""No. Livia and Petr will continue working for me as usual. None of this happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[230]`
**[WYBÓR GRACZA: ""Right. Let's do it.""]** — Mówca: **Player**
> ""Right. Let's do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[231]`
Mówca: **Lucian Galade**
> ""I appreciate your trust in me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[232]`
**[WYBÓR GRACZA: ""Livia was right. You're completely off your rocker.""]** — Mówca: **Player**
> ""Livia was right. You're completely off your rocker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[234]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Lucian_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Lucian_Opinion"] = Variable["BaseGame.Relations_Lucian_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[235]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_LiviaInvestigated = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaInvestigated"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[236]`
Mówca: **Lucian Galade**
> ""Sir, this is a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`
  - -> `[239]`

### Węzeł `[237]`
**[WYBÓR GRACZA: ""From now on, I'll ask when I want your advice.""]** — Mówca: **Player**
> ""From now on, I'll ask when I want your advice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[238]`
**[WYBÓR GRACZA: ""I don't want to hear another word against either of them again.""]** — Mówca: **Player**
> ""I don't want to hear another word against either of them again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[239]`
**[WYBÓR GRACZA: ""This is my decision. I'll face the consequences.""]** — Mówca: **Player**
> ""This is my decision. I'll face the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[240]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[241]`
**[WYBÓR GRACZA: ""No, I'll do it myself. She's too suspicious of you.""]** — Mówca: **Player**
> ""No, I'll do it myself. She's too suspicious of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
**[WYBÓR GRACZA: ""Fine. But I'm warning you -- don't spy on your colleagues. Ever again.""]** — Mówca: **Player**
> ""Fine. But I'm warning you -- don't spy on your colleagues. Ever again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Lucian Galade**
> ""Very well, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Narrator**
> "Lucian gave a slight bow as he left the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Narrator**
> "I sat by myself for a while, wondering what exactly I had set into motion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[246]`
Mówca: **Narrator**
> "Lucian clenched his jaw. I'd never seen him this unhinged in all my years working with him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Lucian Galade**
> ""Very well, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Narrator**
> "He stood up and stiffly walked out of the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Narrator**
> "I was right to defend my secretary and my best friend. But I hoped I hadn't just made an enemy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[250]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == true || BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_TradeDeal == true || BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_TradeDeal"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[252]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_TradeDeal == true || BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_TradeDeal"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[253]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal == true || BaseGame.Lespia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_TradeDeal == true || BaseGame.Lespia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_TradeDeal"] == true  or  Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[255]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_TradeDeal == true || BaseGame.Lespia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_TradeDeal"] == true  or  Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[256]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn08_SecondScandal_LiviaInvestigated = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_SecondScandal_LiviaInvestigated"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[257]`
Mówca: **Petr Vectern**
> ""I think Anton is making the moves to isolate Rumburg step by step:""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[258]`
Mówca: **Petr Vectern**
> ""We've opened two new lines of communication with Ventrie City and Kyow. Just exploratory talks at this point, but they might lead to something deeper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[259]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[261]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_EmbargoingArcasia == true && BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true  and  Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[264]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_EmbargoingUnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[265]`
Mówca: **Petr Vectern**
> ""We lost our shot with the superpowers due to the embargoes. We're reviewing other options at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[266]`
Mówca: **Petr Vectern**
> ""The embargo reduced our chances with Arcasia. Although we've still got a shot with United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[267]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingArcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_EmbargoingArcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[269]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_EmbargoingArcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_EmbargoingArcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Petr Vectern**
> ""It seems like we've still got a shot with the superpowers, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[271]`
Mówca: **Petr Vectern**
> ""We opened a new line of communication with Kyow. Just exploratory talks at this point, but they might lead to something deeper:""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[272]`
Mówca: **Petr Vectern**
> "We opened a new line of communication with Ventrie City. Just exploratory talks at this point, but they might lead to something deeper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Petr Vectern**
> ""No, doesn't seem like it. We'll have to find other alternatives if we're going to keep Rumburg at bay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[274]`
Mówca: **Petr Vectern**
> ""And speaking of something deeper, Miss Suno...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[275]`
Mówca: **Petr Vectern**
> ""In the meantime, I can think of another deal that needs sealing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[276]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: PlaySoundEffect("ReelToReel");)*
- **Efekt (`userScript`):** `PlaySoundEffect("ReelToReel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[277]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[280]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[282]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[283]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[285]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[286]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[288]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[289]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BFF_EliminationOperation_Botched = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.BFF_EliminationOperation_Botched"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[290]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BFF_EliminationOperation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BFF_EliminationOperation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[292]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.BFF_EliminationOperation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[293]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Damaged = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.BFF_Damaged"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[294]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Destroyed = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.BFF_Destroyed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[295]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.BFF_Damaged = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.BFF_Damaged"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[296]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[298]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[299]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[301]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[302]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Decreased == false || BaseGame.Policy_Order_SecretStatePolice == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Decreased == false || BaseGame.Policy_Order_SecretStatePolice == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[304]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Decreased == false || BaseGame.Policy_Order_SecretStatePolice == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[305]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[307]`

### Węzeł `[306]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[307]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[308]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true   or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[310]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true   or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[311]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[313]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Ersen = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Ersen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[314]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Governor = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Botched_Governor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[315]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Damaged = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Damaged"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[316]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Failure = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Failure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Success = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Ribel_BFFOperation_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Bron == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Bron == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_LT_GovernorBronContinuesResettlement = true;
BaseGameSupport.News_Turn08_R_GovernorBronContinuesResettlement = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_LT_GovernorBronContinuesResettlement"] = true;
Variable["BaseGameSupport.News_Turn08_R_GovernorBronContinuesResettlement"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[323]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Krull == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Krull == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_HP_GovernorKrull_InvitesRemus = true;
BaseGameSupport.News_Turn08_R_GovernorKrull_InvitesRemus = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_GovernorKrull_InvitesRemus"] = true;
Variable["BaseGameSupport.News_Turn08_R_GovernorKrull_InvitesRemus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[327]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Ersen == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bergia_Governor_Ersen == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[329]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bergia_Governor_Ersen == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[330]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_Both = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_Both"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[331]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[333]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Bill_Turn07_LanguageBill_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[334]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[336]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[339]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn07_LanguageBill_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[340]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_ReligiousHarmonyBill = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_ReligiousHarmonyBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_LanguageBill = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Deyr_GovernorErsen_Cancels_LanguageBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[343]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`
  - -> `[345]`

### Węzeł `[344]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[345]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true || BaseGame.Bill_Turn07_LanguageBill_Signed == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  or  Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[346]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_LT_GovernorErsen_DisplaysArge = true;
BaseGameSupport.News_Turn08_HP_GovernorErsen_DisplaysArge = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_LT_GovernorErsen_DisplaysArge"] = true;
Variable["BaseGameSupport.News_Turn08_HP_GovernorErsen_DisplaysArge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[347]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true || BaseGame.Media_Censored == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true || BaseGame.Media_Censored == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[349]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true || BaseGame.Media_Censored == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  or  Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[350]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn08_ST_NoDeal_GovernorErsen_DisplaysArge = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_NoDeal_GovernorErsen_DisplaysArge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[351]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: RemoveConversant("Petr Vectern");)*
- **Efekt (`userScript`):** `RemoveConversant("Petr Vectern");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[352]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: RemoveConversant("Livia Suno");)*
- **Efekt (`userScript`):** `RemoveConversant("Livia Suno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[353]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: AddConversant("Livia Suno");)*
- **Efekt (`userScript`):** `AddConversant("Livia Suno");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[354]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
