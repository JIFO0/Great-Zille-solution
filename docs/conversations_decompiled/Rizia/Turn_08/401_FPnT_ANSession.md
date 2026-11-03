# Rizia/Turn 8/FPnT_ANSession

- **ID konwersacji:** `401`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/401_FPnT_ANSession.md`
- **Liczba węzłów dialogowych:** 331
- **Liczba wyborów gracza:** 78

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[76]** Ephraim Nines (R)
- **[82]** Dwight Walker (R)
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[100]** Alma Saltana

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.CountryRelation_Morella_Allied`
- `RiziaDLC.CountryRelation_Sordland_Hostile`
- `RiziaDLC.CountryRelation_Sordland_Unfriendly`
- `RiziaDLC.CountryRelation_Valgsland_Unfriendly`
- `RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella`
- `RiziaDLC.Intermerkopum_Efforts`
- `RiziaDLC.MITZ_Renegotiation_Failed`
- `RiziaDLC.Morella_Pipeline_Sabotage`
- `RiziaDLC.Morella_Sabotage_Plans_Discovered`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Revolutionary_Pipeline_Sabotage`
- `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad`
- `RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn05_ITZVote_Nationalization`
- `RiziaDLC.ZilleReferendum_Disapproved`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLC.Zille_Destroyed_LespianEvidence`
- `RiziaDLC.Zille_Discovered_LespianInvolvement`
- `RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty`
- `RiziaDLC.Zille_Publicized_LespianInvolvement`
- `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage`
- `RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage`
- `RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO`
- `RiziaDLCText.SaltanaToPlayer`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_MITZRevenues`
- `RiziaDLC.Morella_ConfrontedWithSabotageEvidence`
- `RiziaDLC.Morella_RevealedSabotagePlot`
- `RiziaDLC.Reform_Movement_Radicalism`
- `RiziaDLC.Zille_Publicized_LespianInvolvement_Rusty`
- `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage`
- `RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage`
- `RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO`
- `RiziaDLCSupport.Journal_Turn08_AN_LespiaEvidenceReveal`
- `RiziaDLCSupport.Journal_Turn08_AN_MorellaEvidenceConfront`
- `RiziaDLCSupport.Journal_Turn08_AN_MorellaSabotageReveal`
- `RiziaDLCSupport.News_Turn08_G_LespiaEvidenceReleased`

### Skoki między-konwersacyjne:
- Węzeł `[4]` -> **[402] Rizia/Turn 8/Sanctions** (../Turn_08/402_Sanctions.md), Węzeł `[1]`
- Węzeł `[5]` -> **[403] Rizia/Turn 8/Heljiland Dispute** (../Turn_08/403_Heljiland_Dispute.md), Węzeł `[1]`
- Węzeł `[30]` -> **[404] Rizia/Turn 8/Zille Territory Issue** (../Turn_08/404_Zille_Territory_Issue.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 13
- **Węzły modyfikujące stan gry:** 20

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Budget_Modifier_MITZRevenues`
- `RiziaDLC.Zille_Publicized_LespianInvolvement_Rusty`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[6]` (Paskal Beniwoll): `End();`
- Węzeł `[23]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] = true;`
- Węzeł `[27]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] = true;`
- Węzeł `[28]` (Paskal Beniwoll): `PlayLoopedMusic("R_Impasse","R_Impasse_Loop");`
- Węzeł `[60]` (Paskal Beniwoll): `AddConversant("Laurento Esquibel");`
- Węzeł `[88]` (Paskal Beniwoll): `AddConversant("Laurento Esquibel");`
- Węzeł `[130]` (Paskal Beniwoll): `AddConversant("Ephraim Nines (R)");`
- Węzeł `[154]` (Paskal Beniwoll): `Variable["RiziaDLC.Zille_Publicized_LespianInvolvement_Rusty"] = true; Variable["RiziaDLCSupport....`
- *...oraz 12 innych węzłów ze skryptami.*

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
  - -> `[20]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `402` (*Rizia/Turn 8/Sanctions*), Węzeł `[1]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `403` (*Rizia/Turn 8/Heljiland Dispute*), Węzeł `[1]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[7]`
Mówca: **Narrator**
> "The royal convoy finally arrived at the entrance to the Alliance of Nations Headquarters in Konstantium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Narrator**
> "After the usual greetings, Laurento and I settled at our table in the conference hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
Mówca: **Narrator**
> "I looked around the foyer. Of all the leaders gathered here, we'd made the most grandiose entrance by far. I felt good about today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[10]`
Mówca: **Laurento Esquibel**
> ""Here we go, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`
  - -> `[15]`

### Węzeł `[11]`
Mówca: **Narrator**
> "He leaned over and whispered in my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the worst thing that can happen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am confident in this session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
Mówca: **Laurento Esquibel**
> ""We will see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These sessions bore me to death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Laurento Esquibel**
> ""It should be over in a heartbeat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[17]`
Mówca: **Laurento Esquibel**
> ""Let's see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[18]`
Mówca: **Ephraim Nines (R)**
> ""Very well. On to the first item on the agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[19]`
Mówca: **Narrator**
> "A man that I recognized as President Nines approached the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false && RiziaDLC.Pales_War == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[22]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false && RiziaDLC.Pales_War == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false  and  Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false && RiziaDLC.Pales_War == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false  and  Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Impasse", "R_Impasse_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Impasse","R_Impasse_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `404` (*Rizia/Turn 8/Zille Territory Issue*), Węzeł `[1]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Prime Minister Saltana turned to face me head-on as I approached her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Alma Saltana**
> ""Your Majesty. So nice to see you here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[38]`
  - -> `[39]`
  - -> `[40]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, so *now* it's 'Your Majesty'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.SaltanaToPlayer == "Your Majesty")*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCText.SaltanaToPlayer == "Your Majesty")*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCText.SaltanaToPlayer"] =="Your Majesty"`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCText.SaltanaToPlayer == "Your Majesty"))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCText.SaltanaToPlayer"] =="Your Majesty") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough small talk. I know all about your sabotage plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You too, Madam Prime Minister. Despite the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've got some nerve, showing your face in these chambers after what you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[41]`
Mówca: **Alma Saltana**
> ""Our plans?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Alma Saltana**
> ""Morella didn't plan anything. Your own people were the ones attempting to take the Rizian energy grid into their own hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`
  - -> `[52]`
  - -> `[209]`

### Węzeł `[43]`
Mówca: **Alma Saltana**
> ""What circumstances?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[44]`
Mówca: **Alma Saltana**
> ""Titles are important to you Rizians, aren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[45]`
Mówca: **Alma Saltana**
> ""What I did...?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Alma Saltana**
> ""I'm sorry, but the session's just about to start. We'll talk another time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[48]`
  - -> `[49]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll talk now. Or I'll reveal your plans to sabotage our energy infrastructure to this entire assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't fool me. Pretending to be Little Miss Do-Gooder while plotting to blow up our pipelines...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Ms. Saltana. I'm giving you a chance to explain yourself. You may not get another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you wouldn't mind if I revealed your involvement to everyone at the Alliance of Nations?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They never would have done such a thing on their own. You and your CSP partners drove them to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cut the bullshit. We have concrete proof of your involvement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[53]`
Mówca: **Narrator**
> "She exhaled impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[54]`
Mówca: **Alma Saltana**
> ""No harm has been done. And I'm willing to listen to whatever it is you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[55]`
Mówca: **Narrator**
> "That is, until I realized that none of the various delegations I passed were making eye contact with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[59]`
Mówca: **Narrator**
> "Laurento caught up to me with quick steps. His words came in a worried whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[61]`
Mówca: **Laurento Esquibel**
> ""I've just spoken to an old friend of mine. Deivid Wisci, the Sordish foreign minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Hostile == true || RiziaDLC.CountryRelation_Sordland_Unfriendly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Sordland_Hostile == true || RiziaDLC.CountryRelation_Sordland_Unfriendly == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Hostile"] == true  or  Variable["RiziaDLC.CountryRelation_Sordland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Sordland_Hostile == true || RiziaDLC.CountryRelation_Sordland_Unfriendly == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Hostile"] == true  or  Variable["RiziaDLC.CountryRelation_Sordland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
Mówca: **Laurento Esquibel**
> ""Despite the deteriorating relations between our countries, he was willing to divulge that Lespia is planning on proposing sanctions on Rizia at today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[83]`
  - -> `[84]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Laurento Esquibel**
> ""Despite the deteriorating relations between our countries, he was willing to divulge that Valgsland is planning on proposing sanctions on Rizia at today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[79]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Laurento Esquibel**
> ""He confided that Lespia is planning on proposing sanctions on Rizia at today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[83]`
  - -> `[84]`

### Węzeł `[74]`
Mówca: **Laurento Esquibel**
> ""He confided that Valgsland is planning on proposing sanctions on Rizia at today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`
  - -> `[79]`

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare Alvarez pull a stunt like this after what Lespia did to us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement == true || RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement == true || RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  or  Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_Discovered_LespianInvolvement == true || RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  or  Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Morella_Pipeline_Sabotage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Morella_Pipeline_Sabotage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Morella_Pipeline_Sabotage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Morella_Pipeline_Sabotage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Morella_Pipeline_Sabotage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare Hegel pull a stunt like this after what his Morellan minions did to us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you're sure this Deivid is a trustworthy source?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I can't say I'm surprised to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? The other member states will never go along with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? The other member states will never go along with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[87]`
Mówca: **Laurento Esquibel**
> ""The man doesn't have a dishonest bone in his body.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
Mówca: **Narrator**
> "Laurento caught up to me with quick steps. I had to strain to hear his words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Laurento Esquibel**
> ""Rusty came through, Your Majesty. The documents he provided indeed implicate Lespia in the Friendship Day incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[94]`
Mówca: **Laurento Esquibel**
> ""But I don't know what you intend to do with this evidence. After all, you and Prime Minister Alvarez agreed that Lespia's involvement would be kept secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`
  - -> `[106]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Destroyed_LespianEvidence == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Destroyed_LespianEvidence == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_Destroyed_LespianEvidence"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_Destroyed_LespianEvidence == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_Destroyed_LespianEvidence"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Laurento Esquibel**
> ""If this comes to light, the other AN states will never agree to Smolak's referendum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[107]`
  - -> `[106]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Laurento Esquibel**
> ""But I'm not sure what good this information does now. You've already managed to negotiate Zille's safe return, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[106]`
  - -> `[105]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I said I'd destroy the evidence our investigation had turned up. I never agreed to keep Lespia's involvement a secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia must be held accountable for its crimes. It's time to shame Prime Minister Alvarez on a global stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For now. Who knows what Smolak will try to pull at the last minute?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't decided what to do yet. But it's a useful piece of leverage to have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is it. Zille will be ours again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Narrator**
> "A voice over the loudspeaker announced that it was time to take our seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[109]`
Mówca: **Laurento Esquibel**
> ""If these sanctions go through, they have the potential to severely damage our economy and our foreign standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[110]`
Mówca: **Laurento Esquibel**
> ""I should hope not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[111]`
Mówca: **Laurento Esquibel**
> ""I should hope not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[112]`
Mówca: **Laurento Esquibel**
> ""I'm surprised as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[113]`
Mówca: **Laurento Esquibel**
> ""I'm surprised as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Laurento Esquibel**
> ""But we do have one useful piece of leverage. Rusty came through with his evidence. We now possess conclusive proof that Lespia organized the Friendship Day bombing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[118]`
  - -> `[121]`
  - -> `[127]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true && RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true && RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true  and  Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true && RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true  and  Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wow. I didn't think Rusty had it in him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. It's time to shame Alvarez on a global stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can use it to stop the sanctions and get back Zille at the same time. Two victories for the price of one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[124]`
Mówca: **Laurento Esquibel**
> ""At the expense of our relations with Lespia. But those were never going to recover, I fear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[125]`
Mówca: **Laurento Esquibel**
> ""He didn't get to where he is by being bad at subterfuge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[126]`
Mówca: **Laurento Esquibel**
> ""I must admit he deserves it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know what good that'll do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Laurento Esquibel**
> ""At the very least, it will make Lespia look hypocritical for accusing us of wrongdoing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[129]`
Mówca: **Laurento Esquibel**
> ""But not everyone in this hall will be on our accuser's side. I'm sure of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Ephraim Nines (R)");)*
- **Efekt (`userScript`):** `AddConversant("Ephraim Nines (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[131]`
Mówca: **Narrator**
> "He sharply banged his gavel to begin the session."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Ephraim Nines (R)**
> ""Good morning. I hereby open this session of the Alliance of Nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[135]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[139]`
Mówca: **Ephraim Nines (R)**
> ""Today's agenda includes a proposal of sanctions on the Kingdom of Rizia, a vote regarding the disputed territory of Heljiland, and a discussion on the region of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Ephraim Nines (R)**
> ""I additionally invite all member states to share any other urgent matters you believe deserve our collective attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[141]`
Mówca: **Ephraim Nines (R)**
> ""Today's agenda includes a proposal of sanctions on the Kingdom of Rizia and a vote regarding the disputed territory of Heljiland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[142]`
Mówca: **Ephraim Nines (R)**
> ""Today's agenda includes a vote regarding the disputed territory of Heljiland and a discussion on the region of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[145]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Ephraim Nines (R)**
> ""Today's agenda includes a vote regarding the disputed territory of Heljiland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Kingdom of Rizia would like to draw this assembly's attention to the crimes perpetrated by the Republic of Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[151]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "I didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[152]`
Mówca: **Narrator**
> "One of my aides approached President Nines' podium with the evidence Rusty had given us. Gasps and animated chatter filled the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I submit to you all conclusive proof that Lespia organized the Friendship Day incident of 1951.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[154]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Publicized_LespianInvolvement_Rusty = true;
RiziaDLCSupport.News_Turn08_G_LespiaEvidenceReleased = true;
RiziaDLCSupport.Journal_Turn08_AN_LespiaEvidenceReveal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Zille_Publicized_LespianInvolvement_Rusty"] = true;
Variable["RiziaDLCSupport.News_Turn08_G_LespiaEvidenceReleased"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_AN_LespiaEvidenceReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[155]`
  - -> `[158]`
  - -> `[161]`
  - -> `[164]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An anonymous source bravely disclosed to us that Lespia has secretly been attempting to sow discord between Rizia and Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Patricio Alvarez tried to buy my silence. But I hold in my hands the truth about his misdeeds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Alvarez will point the finger at Rizia today. He is only trying to divert the blame from his government's attempts to sabotage our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Destroyed_LespianEvidence == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Zille_Destroyed_LespianEvidence == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Zille_Destroyed_LespianEvidence"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[160]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Zille_Destroyed_LespianEvidence == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Zille_Destroyed_LespianEvidence"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have evidence that Lespia and its backers in ATO actively worked to destabilize us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[165]`
Mówca: **Narrator**
> "I looked across the room at Alvarez. His face was white with rage, but he said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`
  - -> `[166]`
  - -> `[171]`
  - -> `[173]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.ZilleReturn_Success == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.ZilleReturn_Success == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fortunately, Rizia and Wehlen were able to see through the lies and reconcile our differences. Nonetheless, our would-be saboteurs must be held to account.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We hope that the members of this assembly will keep this information in mind as the session continues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This blatant meddling is proof of the deep contempt the Arcasian Treaty Organization holds for the countries of South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia's act of terrorism killed civilians and directly impeded the return of the Zille region. They must be held to account.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our neighbors to the north are jealous of our resources and our great monarchy. But we will not let them tear us down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That will be all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, let the session begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May justice prevail today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Trait_ReligiousKing == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Trait_ReligiousKing == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you and God bless Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[181]`
Mówca: **Narrator**
> "A stunned silence settled around the chamber as my words sunk in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Ephraim Nines (R)**
> ""Thank you, King Romus. The Alliance of Nations acknowledges the evidence submitted by the Kingdom of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Ephraim Nines (R)**
> ""Now, on to the agenda...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Nobody spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[185]`
Mówca: **Dwight Walker (R)**
> ""Let the record show Arcasia had no knowledge of Lespia's actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`
  - -> `[192]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[189]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[191]`
Mówca: **Narrator**
> "A voice came from the back row."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`
  - -> `[176]`
  - -> `[177]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I highly doubt that, President Walker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I hope you discipline your member state accordingly. No nation must be allowed to act outside the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Dwight Walker (R)");)*
- **Efekt (`userScript`):** `RemoveConversant("Dwight Walker (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[196]`
Mówca: **Narrator**
> "At the same time, I noticed Prime Minister Alma Saltana trying to walk past me unnoticed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`
  - -> `[200]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Morella_Sabotage_Plans_Discovered == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Morella_Sabotage_Plans_Discovered == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[199]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Morella_Sabotage_Plans_Discovered == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, shall we go inside?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Laurento Esquibel**
> ""I suppose we had better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You go on ahead. I just need a quick word with Madam Prime Minister over there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Laurento Esquibel**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Laurento Esquibel**
> ""Looking forward to hearing what the little snake has to say for herself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Narrator**
> "He bowed and walked into the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `RemoveConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[207]`
Mówca: **Narrator**
> "She exhaled impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[208]`
Mówca: **Alma Saltana**
> ""There's nothing to explain. Your own people were the ones attempting to take the Rizian energy grid into their own hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`
  - -> `[52]`
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Turn05_ITZVote_Nationalization == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Turn05_ITZVote_Nationalization == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't try to lie to me. You threatened me with exactly this scenario when I didn't go along with your nationalization plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Narrator**
> "She gritted her teeth. It was a moment before she spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[214]`
Mówca: **Alma Saltana**
> ""There's no need to involve anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[315]`

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not only that. You will vote in Rizia's best interests today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[216]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you'll convince your friend Hegel not to threaten us with sanctions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. As long as your agents never touch Rizian soil again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[224]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: //)*
- **Efekt (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[219]`
  - -> `[223]`
  - -> `[225]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will decide what's best for my kingdom's workers. Not you. Do not forget that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[226]`
Mówca: **Alma Saltana**
> ""It's too late for that. But I will vote in your favor, despite fully agreeing with the Chancellor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[227]`
Mówca: **Alma Saltana**
> ""If you insist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[228]`
Mówca: **Alma Saltana**
> ""They won't. If there's a revolution in your country, it will be 100 percent homegrown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[229]`
Mówca: **Alma Saltana**
> ""Then I entreat you to make the right decisions. Before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Alma Saltana**
> ""Thank you for your understanding, Your Majesty. I'll be taking my seat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[232]`
  - -> `[233]`

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't try to pull anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have a nice day, Madam Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See you in there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[234]`
Mówca: **Narrator**
> "We parted ways and went to take our respective seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Alma Saltana");)*
- **Efekt (`userScript`):** `RemoveConversant("Alma Saltana");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[236]`
Mówca: **Narrator**
> "After the usual greetings, I settled next to Laurento at our table in the conference hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Morella_Allied == true && RiziaDLC.Revolutionary_Pipeline_Sabotage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.CountryRelation_Morella_Allied == true && RiziaDLC.Revolutionary_Pipeline_Sabotage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Morella_Allied"] == true  and  Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.CountryRelation_Morella_Allied == true && RiziaDLC.Revolutionary_Pipeline_Sabotage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Morella_Allied"] == true  and  Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[240]`
Mówca: **Narrator**
> "At the same time, I noticed Prime Minister Alma Saltana standing nearby, trying to get my attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[200]`

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You go on ahead. I need a quick word with Madam Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Laurento Esquibel**
> ""Yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Narrator**
> "He bowed and walked into the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `RemoveConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Narrator**
> "Saltana turned to face me head-on as I approached her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[248]`
  - -> `[246]`
  - -> `[255]`

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Changed your mind about my marriage offer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Narrator**
> "She rolled her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's good to see you again, Ms. Saltana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[249]`
Mówca: **Alma Saltana**
> ""Likewise, {RiziaDLCText.SaltanaToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope I can count on you to vote in Rizia's favor today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Alma Saltana**
> ""You have Morella's support, {RiziaDLCText.SaltanaToPlayer}. But that's not why I want to talk to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Alma Saltana**
> ""Very busy. But there's something you should be aware of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Narrator**
> "She handed me a sheet of paper. On it was a list of names and addresses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[258]`
Mówca: **Alma Saltana**
> ""I'll make this quick. Connections of mine have revealed a potential sabotage plot by revolutionaries in your country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Alma Saltana**
> ""They appear to be targeting your energy infrastructure. If they succeed, it'd be ruinous for our energy agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`
  - -> `[262]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Alma Saltana**
> ""They appear to be targeting your energy infrastructure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[264]`
Mówca: **Alma Saltana**
> ""I trust you to use this wisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`
  - -> `[272]`
  - -> `[271]`
  - -> `[267]`

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see to it that every individual on this list is punished to the full extent of the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I value our agreement as much as you do. We'll take quick action to prevent disaster.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'connections' revealed this plot? Was Morella in on it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, this is embarrassing. Why didn't Rizian intelligence get wind of it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[273]`
Mówca: **Narrator**
> "She shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Alma Saltana**
> ""Some of the more extreme left-wingers in my coalition have had contact with Rizian anti-monarchists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[275]`
Mówca: **Alma Saltana**
> ""A good question. I hope you'll be more attuned to this movement going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[276]`
Mówca: **Alma Saltana**
> ""What are allies for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Narrator**
> "She smiled wryly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Intermerkopum_Efforts == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[280]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Intermerkopum_Efforts == true ))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[281]`
Mówca: **Alma Saltana**
> ""I'm looking forward to hearing more about this inter-Merkopan alliance you're proposing. But I have to say I'm troubled that a portion of your society feels they have to resort to desperate measures to be heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[287]`
  - -> `[290]`
  - -> `[293]`

### Węzeł `[282]`
Mówca: **Alma Saltana**
> ""I have to say I'm troubled that a portion of your society feels they have to resort to desperate measures to be heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[287]`
  - -> `[290]`
  - -> `[293]`

### Węzeł `[283]`
Mówca: **Alma Saltana**
> ""Just be careful. You wouldn't want to spark a backlash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[284]`
Mówca: **Alma Saltana**
> ""I wouldn't expect anything less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These are rogue dissidents. They don't represent the opinion of the entire working class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to worry. I am listening to their demands for reform and I'm planning to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Path == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear them just fine. But they are demanding too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[291]`
Mówca: **Alma Saltana**
> ""Very intriguing. I hope you'll keep us informed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[292]`
Mówca: **Alma Saltana**
> ""Can your Adarfo Sotelato confirm that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You really don't need to concern yourself with the political situation in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[294]`
Mówca: **Alma Saltana**
> ""Apparently I do. Or would you prefer your pipelines exploded?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Alma Saltana**
> ""It doesn't seem like too much to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[296]`
Mówca: **Narrator**
> "The loudspeaker voice repeated the announcement. Saltana turned towards the conference hall doors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[297]`
Mówca: **Alma Saltana**
> ""I'll be taking my seat now. See you in there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`
  - -> `[301]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have a nice day, Madam Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't forget to vote the right way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[301]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn08_AN_MorellaEvidenceConfront = true; RiziaDLC.Morella_ConfrontedWithSabotageEvidence = true;
RiziaDLC.Reform_Movement_Radicalism -= 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_AN_MorellaEvidenceConfront"] = true;
Variable["RiziaDLC.Morella_ConfrontedWithSabotageEvidence"] = true;
Variable["RiziaDLC.Reform_Movement_Radicalism"] = Variable["RiziaDLC.Reform_Movement_Radicalism"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Morella_RevealedSabotagePlot = true; RiziaDLCSupport.Journal_Turn08_AN_MorellaSabotageReveal = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Morella_RevealedSabotagePlot"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_AN_MorellaSabotageReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""First things first. You are to expedite our MITZ shipments from this point onward. No more obstruction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[307]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`
  - -> `[312]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Renegotiation_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""First things first. You are to honor our MITZ agreement. No matter if Rizia doesn't hold up our end of the bargain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Call off the MITZ talks. We're going back to the way things were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[313]`
Mówca: **Alma Saltana**
> ""It's too late to call them off completely. But if Rizia insists on the status quo, I will not get in your way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Adarfo Sotelato. Is he one of yours?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[315]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Reform_Movement_Leader_Adarfo == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[317]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Reform_Movement_Leader_Adarfo == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[318]`
Mówca: **Alma Saltana**
> ""No, of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[319]`
Mówca: **Alma Saltana**
> ""But in the case that any of his supporters have links to Morella... they will cease being a problem from now on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How many of your people are embedded in the RPP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[321]`
Mówca: **Alma Saltana**
> ""Officially, none.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[322]`
Mówca: **Alma Saltana**
> ""But in the case that any of the party's supporters have links to Morella... they will cease being a problem from now on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.MITZ_Renegotiation_Failed == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[325]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.MITZ_Renegotiation_Failed == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Budget_Modifier_MITZRevenues += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_MITZRevenues"] = Variable["RiziaDLC.Budget_Modifier_MITZRevenues"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[327]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[329]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Budget_Modifier_MITZRevenues += 2)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_MITZRevenues"] = Variable["RiziaDLC.Budget_Modifier_MITZRevenues"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`
