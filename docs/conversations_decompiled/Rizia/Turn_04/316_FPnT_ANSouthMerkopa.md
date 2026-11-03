# Rizia/Turn 4/FPnT_ANSouthMerkopa

- **ID konwersacji:** `316`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Rizia/Turn_04/316_FPnT_ANSouthMerkopa.md`
- **Liczba węzłów dialogowych:** 831
- **Liczba wyborów gracza:** 275

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[69]** Jorga Azmal
- **[70]** Laurento Esquibel
- **[76]** Ephraim Nines (R)
- **[77]** Wiktor Smolak (R)
- **[78]** Emmerich Hegel (R)
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*
- **[99]** Patricio Alvarez (R)
- **[100]** Alma Saltana

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO`
- `RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal`
- `RiziaDLC.Diplomacy_Lespia_PromiseITZSupport`
- `RiziaDLC.Diplomacy_Lespia_WehlenHelp`
- `RiziaDLC.Diplomacy_Morella_ANSpeech_SideWith`
- `RiziaDLC.Diplomacy_Pales_GasField_Buy`
- `RiziaDLC.Diplomacy_Pales_GasField_Cede`
- `RiziaDLC.Diplomacy_Pales_Military_BlockDrillship`
- `RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech`
- `RiziaDLC.Diplomacy_Wehlen_FundBFF`
- `RiziaDLC.Diplomacy_Wehlen_Scapegoats`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded`
- `RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries`
- `RiziaDLC.Prologue_HostileToPales`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Security_Pales_SendSpecialOps`
- `RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration`
- `RiziaDLC.Situation_Diplomacy_Zille_ATAActive`
- `RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive`
- `RiziaDLCIsolated.Turn04_ANSpeech_Morella`
- `RiziaDLCIsolated.Turn04_ANSpeech_Wehlen`
- `RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal`
- `RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy`
- `RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeMad`
- `RiziaDLC.Diplomacy_Derdia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Lespia_NegotiatingPower`
- `RiziaDLC.Diplomacy_Morella_ANSpeech_SideAgainst`
- `RiziaDLC.Diplomacy_Morella_ANSpeech_SideWith`
- `RiziaDLC.Diplomacy_Morella_NegotiatingPower`
- `RiziaDLC.Diplomacy_Rumburg_NegotiatingPower`
- `RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech`
- `RiziaDLC.Diplomacy_Valgsland_NegotiatingPower`
- `RiziaDLC.Diplomacy_Wehlen_ANSpeech_Aggression`
- `RiziaDLC.Diplomacy_Wehlen_ANSpeech_Appeasement`
- `RiziaDLC.Diplomacy_Wehlen_NegotiatingPower`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLC.Said_Halaita`
- `RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol`
- `RiziaDLCIsolated.Turn04_ANSpeech_Morella`
- `RiziaDLCIsolated.Turn04_ANSpeech_Wehlen`
- `RiziaDLCSupport.News_Turn04_G_AN_Hegel`
- `RiziaDLCSupport.News_Turn04_G_AN_WehlenAnnouncement`
- `RiziaDLCSupport.News_Turn04_RH_ZilleAnnouncement`
- `RiziaDLCSupport.Reports_Turn04_Zille_ATAProtest`
- `RiziaDLCSupport.Reports_Turn04_Zille_SOProtest`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 20
- **Węzły modyfikujące stan gry:** 44

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLCSupport.News_Turn04_RH_ZilleAnnouncement`
- `RiziaDLCSupport.Reports_Turn04_Zille_ATAProtest`
- `RiziaDLCSupport.Reports_Turn04_Zille_SOProtest`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[421]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn04_ANSpeech_Wehlen"] = true;`
- Węzeł `[427]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Wehlen_ANSpeech_Appeasement"] = true; Variable["RiziaDLC.Diplomacy_W...`
- Węzeł `[428]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Wehlen_ANSpeech_Aggression"] = true; Variable["RiziaDLC.Diplomacy_We...`
- Węzeł `[453]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeMad"] = true; Variable["RiziaDLC.Diplomacy_Derdi...`
- Węzeł `[454]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Morella_ANSpeech_SideAgainst"] = true; Variable["RiziaDLC.Diplomacy_...`
- Węzeł `[455]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Morella_ANSpeech_SideWith"] = true; Variable["RiziaDLC.Diplomacy_Mor...`
- Węzeł `[488]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn04_ANSpeech_Morella"] = true;`
- Węzeł `[735]` (Paskal Beniwoll): `AddConversant("Laurento Esquibel"); ;`
- *...oraz 36 innych węzłów ze skryptami.*

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
  - -> `[830]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was a rainy day in Kyrute, one of only a handful the island experienced per year."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "The sound of the falling drops on the Alliance of Nations dome made for an unexpectedly soothing backdrop to what I could tell was going to be a tense session."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I sat with Laurento and the rest of the Rizian delegation in the half-full assembly hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Today's session was to focus on South Merkopa only. Looking around the room, I could see representatives and leaders from Wehlen, Morella, Derdia and Lespia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Duke Axel Reinhart entered late, accompanied by a few of his ministers. He took a seat as far from the Lespian delegation as possible."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[18]`
  - -> `[26]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[9]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[10]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Duke Axel Reinhart and Patricio Alvarez entered late, deep in conversation. They nodded at each other and took seats with their respective delegations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Duke Axel Reinhart and Patricio Alvarez entered late, deep in conversation. They nodded at each other and took seats with their respective delegations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]`
  - -> `[19]`
  - -> `[785]`

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alvarez must have given him quite the talking-to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It must be awkward, encountering one's ex-husband here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wonder how badly the two of them fell out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at those two lovebirds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wonder what they were talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did I make a mistake? Should I have gone with the Duke's deal after all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Laurento Esquibel**
> ""They clearly plan to put up a united front. It'll be hard to argue against them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[23]`
Mówca: **Laurento Esquibel**
> ""Imagine the amount of tension in this room had that been the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[24]`
Mówca: **Narrator**
> "Reinhart had an obvious scowl on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[20]`
  - -> `[21]`

### Węzeł `[25]`
Mówca: **Laurento Esquibel**
> ""Prime Minister Alvarez can't be happy. The last thing he wants is Rizia and Pales making deals behind his back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "Wave to him."]** — Mówca: **Player_Romus_Italic**
> "I waved to Duke Reinhart. He nodded tersely in acknowledgement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Laurento Esquibel**
> ""He seems nervous. Alvarez's presence here is rattling him, I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Laurento Esquibel**
> ""I've been told that Lespia renegotiated their deal after Rizia backed out. Not in Pales' favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Laurento Esquibel**
> ""Are you well, Your Majesty? Your father always had a case of nerves before these sessions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[32]`
  - -> `[33]`
  - -> `[36]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not surprised. One more royal duty that he couldn't handle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm nervous about the arbitration case. We have a lot riding on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Arcasia or United Contana were here today, I'd be nervous. All these others are small potatoes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm fine, Mr. Esquibel. I appreciate your concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Narrator**
> "We turned our attention to the front of the room as President Ephraim Nines entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]`

### Węzeł `[35]`
Mówca: **Ephraim Nines (R)**
> ""First on today's docket is Prime Minister Alma Saltana of the Republic of Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mother said something about Wiktor Smolak making an announcement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Wehlen AN Speech)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Derdia AN Speech)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Morella AN Speech)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Pales AN Speech)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Lespia AN Speech)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Player AN Speech)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Prime Minister Alma Saltana strode up to the podium. She had to lower the microphone to reach it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Alma Saltana**
> ""Mr. President, esteemed leaders and distinguished guests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[48]`
Mówca: **Laurento Esquibel**
> ""Big trouble in a small package.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not find that amusing, Mr. Esquibel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope she keeps her address short, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's hear what she has to say before passing judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Narrator**
> "The Morellan leader greeted the assembly. Her voice had a melodic lilt to it that I associated with Qinal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[53]`
Mówca: **Alma Saltana**
> ""It is my honor to speak in these hallowed halls for the first time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Alma Saltana**
> ""I come before you as a representative of the new Morella. A country committed to breaking free from the shackles of our repressive past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[55]`
Mówca: **Alma Saltana**
> ""And one that is proud to build bridges with those who share our vision of a more equal society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Narrator**
> "She nodded towards the upper seats of the assembly room. I looked behind me to see Valgslandian Chancellor Emmerich Hegel applauding fiercely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[57]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Laurento, I thought this was a *South* Merkopa session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who invited him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew today would be exciting, but this is another level.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
Mówca: **Laurento Esquibel**
> ""Chancellor Hegel is not on the speaking program. He must have flown to Kyrute solely to support Madame Prime Minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
Mówca: **Laurento Esquibel**
> ""Prime Minister Saltana must have wanted him in the audience to demonstrate Valgsland's support for her country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Laurento Esquibel**
> ""Chancellor Hegel isn't on today's program. But I wouldn't rule out an impromptu speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Alma Saltana**
> ""It is a time of transition for Morella. But as we redefine our principles and our partnerships, one fact becomes abundantly clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Alma Saltana**
> ""A country that is now truly aligned with the AN values of justice, solidarity and human dignity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[65]`
Mówca: **Alma Saltana**
> ""We can no longer abide the senseless exploitation of our land, people and resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
  - -> `[67]`
  - -> `[68]`

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Aha. I knew this would be about the International Trade Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Senseless? Gold makes plenty of sense to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hegel put this into her head. I'm sure of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Laurento Esquibel**
> ""She hasn't taken her eye off the topic since her election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[70]`
Mówca: **Laurento Esquibel**
> ""Behind every strong woman is a crazed Valgslandian socialist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Laurento Esquibel**
> ""The agreement her predecessors signed was airtight. She'll need a lot of international backing to get out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Alma Saltana**
> ""For too long, our so-called 'partners' in the Meftiem International Trade Zone have dug the ground out from under us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Alma Saltana**
> ""We've allowed them to ravage our soil and abuse our workers, while reaping more than their fair share of the profits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[74]`
Mówca: **Alma Saltana**
> ""Meanwhile, the shocking lack of mining regulations in countries such as Rizia shows they are no less careless at home than abroad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[89]`
  - -> `[88]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist <= 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist <= 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""More than one Malenyevist in the same room is bound to spell trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[82]`
Mówca: **Alma Saltana**
> ""Meanwhile, countries such as Rizia are willing to regulate their mining industries at home, but turn a blind eye to exploitation abroad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[88]`
  - -> `[83]`
  - -> `[181]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't turn a blind eye! I just haven't gotten around to regulating the MITZ yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[84]`
Mówca: **Laurento Esquibel**
> ""I have the feeling Ms. Saltana wouldn't be happy either way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[85]`
Mówca: **Laurento Esquibel**
> ""Morella's international profile isn't large enough to go after a country of Lespia's stature. Yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew I shouldn't have given in to Rusty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Laurento Esquibel**
> ""If it wasn't this, she'd go after us for something else. She's trying to prove a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why is she naming us? What about the corruption in Lespian industries?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not our fault that Morellan soil is so prone to cave-ins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Laurento Esquibel**
> ""I doubt regulations are the real issue here. If it wasn't this, it would be something else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Alma Saltana**
> ""Morella calls on the Alliance of Nations to recognize our human rights struggle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Alma Saltana**
> ""And to accept that if the Meftiem ITZ is to continue, any wealth it generates must be reinvested in the Morellan people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]`

### Węzeł `[93]`
Mówca: **Alma Saltana**
> ""They send security forces to guard their gold, yet leave the rest of Morella to the mercy of Derdian terrorists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Supreme Wiseman Jorga Azmal stepped on to the stage, dressed in a ceremonial robe with silver trim."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[95]`
Mówca: **Narrator**
> "There were some whispers from within the room as Wehlen's president stepped up to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Narrator**
> "He silenced them with a theatrical shushing motion, then continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Wiktor Smolak (R)**
> ""Dear fellow leaders!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Wiktor Smolak (R)**
> ""I wish I could say I was happy to be here, standing as one of the six proud nations of South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Wiktor Smolak (R)**
> ""And yet I feel only sorrow. Sorrow that our magnificent region has let itself been torn apart by forces greater than ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Wiktor Smolak (R)**
> ""I speak, of course, of Arcasia and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`
  - -> `[104]`

### Węzeł `[101]`
Mówca: **Wiktor Smolak (R)**
> ""Convinced of the idea that might makes right, they sow discord among us in order to strengthen themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Conveniently leaving out United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wehlen alienates every country around it, then blames the superpowers? What nerve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He isn't wrong. Our countries could all be allies if we rid ourselves of foreign interference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_FundBFF == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_FundBFF == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_FundBFF == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[108]`
Mówca: **Wiktor Smolak (R)**
> ""And Wehlen -- poor, war-torn Wehlen -- must pay the highest price.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Wiktor Smolak (R)**
> ""Who among you can deny ATO's involvement in the Wehlen Civil War?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[110]`
Mówca: **Wiktor Smolak (R)**
> ""Or Rumburg's shipping of arms to the Bludish separatist movement, both during the war and in the present day?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Narrator**
> "Nobody in the hall said a word. Wiktor looked up at me directly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[112]`
Mówca: **Wiktor Smolak (R)**
> ""Or Rumburg's shipping of arms to the Bludish separatist movement?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[113]`
Mówca: **Wiktor Smolak (R)**
> ""In light of that, I cannot simply accept that the Zille bombing -- the most heinous terrorist act to occur in Wehlen since the Civil War -- was the work of a few rogue agents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_ZilleIncidentResponse_DenounceSO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Wiktor Smolak (R)**
> ""In light of that, the Rizian government's failure to denounce the perpetrators of the Zille bombing -- the most heinous terrorist attack to occur in Wehlen since the Civil War -- concerns me greatly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here it comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He wouldn't dare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[120]`
Mówca: **Wiktor Smolak (R)**
> ""Suspects have already been named and extradited. But is it a tactic to throw us off track? Rumburg isn't beneath such subterfuge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[123]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_RizianForeignIntelligence_Expanded"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[127]`
Mówca: **Wiktor Smolak (R)**
> ""It is to my everlasting regret that when Wehlen was at its weakest, our direct neighbors opted for an alliance with a nation that has sought to harm us at every turn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[128]`
Mówca: **Laurento Esquibel**
> ""Yes, it doesn't count if the superpower is *his* patron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[129]`
Mówca: **Laurento Esquibel**
> ""Especially since he himself has well-documented ties to United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[130]`
Mówca: **Laurento Esquibel**
> ""He can start by getting rid of his own ties to United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[131]`
Mówca: **Wiktor Smolak (R)**
> ""I do not blame the great Kingdom of Rizia for its decision. But neither can I ignore that for the past 20 years, Rumburg has maintained a presence to both our north and south.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[132]`
Mówca: **Wiktor Smolak (R)**
> ""This is why I have decided to invoke the AN Threat Mitigation Protocol for Treaty Obligations to delay the return of Zille until that risk is neutralized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bullshit!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "Pound your fist on the table in front of you."]** — Mówca: **Player_Romus_Italic**
> "I pounded my fist on the table, creating a racket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[135]`
Mówca: **Narrator**
> "Gasps and murmurs rippled through the assembly. I felt many pairs of eyes on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`
  - -> `[195]`
  - -> `[419]`

### Węzeł `[136]`
Mówca: **Laurento Esquibel**
> ""You'll have to wait until your own speech to raise your objections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_Scapegoats == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Wehlen_Scapegoats == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Wehlen_Scapegoats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Wiktor Smolak (R)**
> ""Rizia has been investigating the organization that we believe to be responsible. But is it a tactic to throw us off track? Rumburg isn't beneath such subterfuge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[141]`
Mówca: **Wiktor Smolak (R)**
> ""I am a man who respects the rule of law. Yet I cannot put my country-people at risk by abandoning the territory while these questions still hang in the air.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`
  - -> `[142]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "I sat still and kept listening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[143]`
Mówca: **Narrator**
> "Laurento shrugged and joined in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[144]`
Mówca: **Wiktor Smolak (R)**
> ""Especially since the government agencies investigating the incident seem more interested in pinning the blame on Wehlen than uncovering the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[145]`
Mówca: **Wiktor Smolak (R)**
> ""Rizia's inaction in the wake of the incident speaks volumes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Wiktor Smolak (R)**
> ""What is to stop such violence from reoccurring? What will happen to the Wehzeks who have made Zille their home once Rizia -- and by proxy Rumburg -- regains control of the region?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[147]`
Mówca: **Narrator**
> "President Nines banged a gavel for silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[148]`
Mówca: **Narrator**
> "The murmurs in the room were growing louder. President Nines banged a gavel for silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[149]`
Mówca: **Laurento Esquibel**
> ""But yes, Your Majesty. It is indeed bullshit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_WehlenHelp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`

### Węzeł `[153]`
Mówca: **Narrator**
> "From across the room, I saw Patricio Alvarez do the same."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]`

### Węzeł `[154]`
Mówca: **Wiktor Smolak (R)**
> ""If I may continue...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Wiktor Smolak (R)**
> ""It is not my intention to keep custody of the Zille region forever. The sooner that safety and security are restored, the sooner we may begin preparing for an orderly transition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Wiktor Smolak (R)**
> ""I hope for swift cooperation from His Majesty King Romus and my fellow South Merkopan nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[157]`
Mówca: **Narrator**
> "Before speaking, he waved his hand in the air six times, representing the six pillars of Golcondism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Laurento Esquibel**
> ""I'm surprised he flew out here. Derdia's Supreme Wiseman normally refrains from speaking in public.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`
  - -> `[161]`

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's too busy praying in a cave?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever he has to say must be important.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He must have been eager to catch a glimpse of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]`

### Węzeł `[162]`
Mówca: **Narrator**
> "The Supreme Wiseman spoke in a deep baritone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Jorga Azmal**
> ""Dear great and powerful leaders of South Merkopa. In the name of Prophet Wruhec, I salute you all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Jorga Azmal**
> ""I am humble enough to know that we men alone cannot decide the fate of a continent. Not without God's guidance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Jorga Azmal**
> ""And it is God who has guided me here today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Jorga Azmal**
> ""We are one of the few nations brave enough to let themselves be ruled by His law. But we are also a country like any other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[167]`
Mówca: **Jorga Azmal**
> ""Yet our attempts to find common ground with our neighbors have been rebuffed, over and over, solely on account of our beliefs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Narrator**
> "I looked over at where Alma Saltana was sitting. She was openly scowling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Jorga Azmal**
> ""The PM of Morella accuses us of violating her borders. Yet it was not so long ago that we were one country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Jorga Azmal**
> ""Because of arbitrary lines that have been drawn, my people can no longer visit the graves of their ancestors, or the shrines where they once worshipped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Jorga Azmal**
> ""Every single one of us, Derdia, Morella, Rizia, Wehlen -- we all have different views, yet we all are united by the divine path of St. Wruhec.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[172]`
Mówca: **Jorga Azmal**
> ""And it is my humble request that we Derdians be able to follow that path as we have for centuries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`
  - -> `[175]`

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. He sounds reasonable enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's forgetting the part where Derdians take part in violent insurgencies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's a gross oversimplification. His path is not ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Laurento Esquibel**
> ""He's ignoring the divergence within Wruhecism, yes. But we do share many of the same holy sites.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[177]`
Mówca: **Laurento Esquibel**
> ""Yes, he's far from the servant of peace that he makes himself out to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Laurento Esquibel**
> ""But does what he's saying justify the violent acts committed by Derdian pilgrims?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Jorga Azmal**
> ""On that note. Concerns have been raised about the missile tests my country has been conducting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[180]`
Mówca: **Jorga Azmal**
> ""Our aim has only ever been to protect our people and way of life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's true. We should apply the same standards in the MITZ as we do in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Laurento Esquibel**
> ""And we can, if you're willing to fight another uphill battle with Mr. Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[183]`
Mówca: **Emmerich Hegel (R)**
> ""Brava, Madam Prime Minister!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "Chancellor Hegel was standing now. The other AN guests turned their heads in his direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Emmerich Hegel (R)**
> ""As fellow stewards of the International Trade Zone and fellow soldiers in the fight against imperialism, the nation of Valgsland supports Morella in its journey.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`
  - -> `[187]`
  - -> `[188]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He must have cut a fat deal with her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't she see that he's using her?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure that he can't get her into the CSP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Laurento Esquibel**
> ""The two were meeting more regularly in the weeks leading up to this session, it's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[190]`
Mówca: **Laurento Esquibel**
> ""Not until Morella improves its military. Which may be the reason for this sudden interest in nationalization...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Laurento Esquibel**
> ""It's difficult to tell who's using whom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Narrator**
> "Hegel sat back down. Nines motioned for Prime Minister Saltana to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Alma Saltana**
> ""I thank all of you for your attention today, and look forward to forging a brighter future for the people of South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[194]`
Mówca: **Patricio Alvarez (R)**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[195]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "I didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[196]`
Mówca: **Laurento Esquibel**
> ""This is unprecedented, Your Majesty. No nation has invoked this protocol since the signing of the AN Charter nearly a century ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[197]`
Mówca: **Wiktor Smolak (R)**
> ""Together, we are strong!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Narrator**
> "He raised his arms in expectation of applause. None came."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Laurento Esquibel**
> ""None of our neighbors is openly taking Wehlen's side. That bodes well for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Narrator**
> "Wiktor shook his head and left the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]`
  - -> `[699]`
  - -> `[697]`
  - -> `[698]`

### Węzeł `[201]`
Mówca: **Narrator**
> "Prime Minister Patricio Alvarez was next. He straightened his tie as he approached the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[202]`
Mówca: **Patricio Alvarez (R)**
> ""May I just start by voicing my heartfelt support for this fine organization and the role that it plays.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Patricio Alvarez (R)**
> ""Were it not for the Alliance of Nations, there would be no way to stop our countries' petty quarrels from devouring the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Patricio Alvarez (R)**
> ""Which, ladies and gentlemen, is precisely what's in danger of happening today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[210]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[211]`
Mówca: **Patricio Alvarez (R)**
> ""The nation of Lespia is deeply concerned about the deployment of Rizian naval forces around the Aureus gas field in the Antacean Sea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Patricio Alvarez (R)**
> ""It is essential that Rizia respect the legal process and accept the results of arbitration, whatever they may be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[213]`
Mówca: **Patricio Alvarez (R)**
> ""The use of military force to occupy a disputed territory goes directly against the AN's most cherished principles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[214]`
Mówca: **Patricio Alvarez (R)**
> ""We stand ready to aid in the peaceful settlement of this dispute, and we beg of the AN not to let Rizia's show of force affect its judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[215]`
Mówca: **Patricio Alvarez (R)**
> ""Such blatant use of intimidation tactics shows that the Kingdom has no intention of doing so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[216]`
Mówca: **Patricio Alvarez (R)**
> ""As we learned mere moments ago, the state of Wehlen is keeping its hold on the Zille region under the pretenses of 'national security'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[217]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`
  - -> `[219]`

### Węzeł `[218]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[219]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_WehlenHelp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[220]`
Mówca: **Patricio Alvarez (R)**
> ""We feel nothing but sympathy for the victims of the terrorist attack in Zille. But we do not believe said attack is a reason to delay the region's return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Patricio Alvarez (R)**
> ""As a matter of fact, from this point forward, Wehlen's actions in Zille should be considered an illegal occupation of Rizian territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`
  - -> `[228]`

### Węzeł `[222]`
Mówca: **Patricio Alvarez (R)**
> ""We consider this nothing less than a socialist incursion into our beloved value systems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Patricio Alvarez (R)**
> ""Rizia has done nothing but abide by the rule of law, while Wehlen attempts to control that which it does not own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hear, hear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you hear that, President Smolak? Illegal!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Narrator**
> "A round of lukewarm applause came from those assembled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Laurento Esquibel**
> ""Hmm. Lespia's support is encouraging, but we may have to work harder to get other neighbors on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
**[WYBÓR GRACZA: "Say nothing and wait for the crowd's reaction."]** — Mówca: **Player_Romus_Italic**
> "I waited for the crowd's reaction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[229]`
Mówca: **Patricio Alvarez (R)**
> ""And now I'm afraid I must address yet another threat to Southern Merkopa masterminded by the Malenyevist east.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Patricio Alvarez (R)**
> ""I speak, of course, of the conspiracy to nationalize the Meftiem International Trade Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Narrator**
> "Chancellor Hegel stood up again. Alvarez ignored him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Patricio Alvarez (R)**
> ""Let us not for one second believe that Morella is acting of its own accord. The long arm of the Contanan Security Pact is behind this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Patricio Alvarez (R)**
> ""By giving in to Prime Minister Saltana's demands, the nations of Lespia and Rizia would be effectively paying to increase United Contana's sphere of influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[234]`
Mówca: **Patricio Alvarez (R)**
> ""I know I am not alone in wanting to avoid those disastrous consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Narrator**
> "He looked straight at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[239]`
Mówca: **Patricio Alvarez (R)**
> ""I know I am not alone in wanting to avoid those disastrous consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[240]`
**[WYBÓR GRACZA: "Applaud."]** — Mówca: **Player_Romus_Italic**
> "I applauded from my seat. Laurento joined me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[241]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent. Prime Minister Alvarez waited a beat, then continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Cede == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[244]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Cede == true || RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true || RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Cede"] == true  or  Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[245]`
Mówca: **Narrator**
> "He looked at the Palesian delegation. Reinhart and his ministers politely applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Patricio Alvarez (R)**
> ""I will remind Morella and Valgsland that the Alliance of Nations is watching. As is ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[247]`
Mówca: **Patricio Alvarez (R)**
> ""The nation of Lespia has observed the gas field dispute between Pales and Rizia with some concern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Patricio Alvarez (R)**
> ""We know from the past that arguments over resources can easily spiral into violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
Mówca: **Patricio Alvarez (R)**
> ""For our part, it is clear that due to the small size and limited habitability of the Rizian island of Caleqabiz, the Grand Duchy of Pales has a greater claim to the field than the Kingdom of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[255]`
  - -> `[257]`

### Węzeł `[250]`
Mówca: **Patricio Alvarez (R)**
> ""Before arbitration concludes, we would like to beseech both nations to respect the results, whatever they may be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[251]`
**[WYBÓR GRACZA: "Pound your fist on the table in protest."]** — Mówca: **Player_Romus_Italic**
> "I pounded my fist on the table in front of me. Laurento and our fellow Rizian representatives joined."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`

### Węzeł `[252]`
Mówca: **Emmerich Hegel (R)**
> ""Malarkey!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[253]`
Mówca: **Narrator**
> "Everyone turned to look at the Valgslandian chancellor. Hegel bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[254]`
Mówca: **Patricio Alvarez (R)**
> ""And we beg the AN to undergo a thorough review of the evidence before submitting their decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Should I say something, Mr. Esquibel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Laurento Esquibel**
> ""I don't see the point, but if you like--.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Liar!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Laurento Esquibel**
> ""No need to shout, Your Majesty. The AN will see through--.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]`

### Węzeł `[259]`
Mówca: **Emmerich Hegel (R)**
> ""Forgive my ill-timed cough. I have a terrible cold today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`
  - -> `[262]`

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Mr. Chancellor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I heard what you said, Mr. Hegel, but I don't require your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[262]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing. Hegel gave me a significant look, then sat back in his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Narrator**
> "He gave me a significant look, then sat back in his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]`

### Węzeł `[264]`
Mówca: **Patricio Alvarez (R)**
> ""Ahem. That brings me to another point I was going to make today...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[265]`
Mówca: **Patricio Alvarez (R)**
> ""Any attempt to seize the International Trade Zone by unlawful means will be met with retaliation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Narrator**
> "He looked around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[241]`

### Węzeł `[267]`
Mówca: **Patricio Alvarez (R)**
> ""That will be all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]`

### Węzeł `[268]`
Mówca: **Jorga Azmal**
> ""It is God's will that we use this technology not for evil, but to contribute to global security and stability.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Narrator**
> "Alma Saltana started laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`
  - -> `[282]`
  - -> `[302]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God wants missiles? That's priceless!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That isn't funny. It's scary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's right, you know. Humans made these weapons, but only God can guide us to use them the right way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Laurento Esquibel**
> ""Then I hope He guides the Supreme Wiseman in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[274]`
Mówca: **Laurento Esquibel**
> ""What's scary is if he finds the wrong buyer for this technology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Laurento Esquibel**
> ""All in the Golcondist gospel, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Narrator**
> "Azmal put his hands on the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[277]`
Mówca: **Jorga Azmal**
> ""How far we have fallen, that the only country in South Merkopa where the pillars of Nurity still stand tall is treated as a laughing stock.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Jorga Azmal**
> ""You all speak of superpowers. But I know there is only one superpower we need to worry about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Narrator**
> "He pointed upwards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Jorga Azmal**
> ""The sooner our nations come together under Him, the sooner true peace and prosperity can be realized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]`

### Węzeł `[282]`
**[WYBÓR GRACZA: "Shush her."]** — Mówca: **Player_Romus_Italic**
> "I made a shushing noise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[283]`
Mówca: **Alma Saltana**
> ""Excuse me. I thought this was a meeting of nations, not a sermon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What a nut job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The chandelier is a superpower?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[286]`
**[WYBÓR GRACZA: "Applaud."]** — Mówca: **Player_Romus_Italic**
> "I applauded along with about half of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Laurento Esquibel**
> ""A potentially useful one. His country needs energy, after all...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[291]`
Mówca: **Laurento Esquibel**
> ""A wild card. Certainly not aligned with either the east or west.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[292]`
Mówca: **Narrator**
> "Laurento held back a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]`

### Węzeł `[296]`
Mówca: **Laurento Esquibel**
> ""A man of strong faith indeed. But faith alone won't be able to solve his country's problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`
  - -> `[299]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[299]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Laurento Esquibel**
> ""A strange leader, but a potentially useful one. His country needs energy, after all...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[301]`
Mówca: **Laurento Esquibel**
> ""He's a wild card. Certainly not aligned with either the east or west.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]`

### Węzeł `[302]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`
  - -> `[304]`

### Węzeł `[303]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[304]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[305]`
Mówca: **Narrator**
> "Duke Reinhart stepped up to the podium. With the spotlight on the Palesian leader, I could see that he had stubble on his chin and dark circles under his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`
  - -> `[457]`
  - -> `[458]`
  - -> `[460]`

### Węzeł `[306]`
Mówca: **Narrator**
> "Laurento gave me a quick smile of encouragement as I left my seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dear esteemed fellow members of the Alliance of Nations!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`
  - -> `[317]`
  - -> `[318]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[311]`
Mówca: **Narrator**
> "I stepped up to the podium to a smattering of applause. The delegations from Wehlen and Lespia stayed pointedly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[313]`
  - -> `[314]`

### Węzeł `[312]`
Mówca: **Narrator**
> "I stepped up to the podium to a smattering of applause. The delegations from Wehlen and Pales stayed pointedly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My fellow rulers of the free world!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Most respected leaders of South Merkopa!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is an immense honor to be addressing this assembly for the first time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`
  - -> `[337]`

### Węzeł `[316]`
Mówca: **Alma Saltana**
> ""*All* of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]`

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My monarchical forebears instilled in me a great respect for this institution and its values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`
  - -> `[321]`
  - -> `[337]`

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've heard enough today about how important the Alliance of Nations is. So I will get straight to the point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[319]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which is why I am so saddened by the division plaguing South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As we have seen over and over throughout history, our nations can accomplish much more together than we can apart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[319]`
  - -> `[338]`
  - -> `[339]`

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The AN's unwavering commitment to peace and justice in times of tension is a true inspiration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[338]`
  - -> `[339]`

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you all see Wehlen's failure to return Zille for what it is: a flagrant violation of international law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`
  - -> `[358]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The AN Threat Mitigation Protocol can only be invoked under extreme circumstances. In my opinion, the Zille incident is not one of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`
  - -> `[326]`
  - -> `[358]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But such bonds do not always form organically, Sometimes they must be fostered, other times forced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any intelligent person can see through the concerns about security and Rumburg. This was a purely self-serving decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[332]`
  - -> `[357]`

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The bombing was a tragedy. However, my kingdom has taken the necessary steps to ensure it will not be repeated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[332]`
  - -> `[357]`
  - -> `[362]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate Prime Minister Alvarez's boldness in speaking out against Wehlen today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`
  - -> `[360]`
  - -> `[381]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[330]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_WehlenHelp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pledge my country's cooperation in resolving the horrific incident of last year.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`
  - -> `[386]`

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wehlen's willingness to disregard the terms of a legal document has chilling implications for its relations with the rest of the continent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[361]`
  - -> `[383]`

### Węzeł `[333]`
Mówca: **Narrator**
> "Wiktor Smolak applauded from his seat. He had a placid expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`
  - -> `[387]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His invocation of AN protocol was completely understandable. The transition of Zille cannot happen until and unless security is restored to the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[331]`
  - -> `[335]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust the rest of South Merkopa to provide aid in this matter if and when it is required.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`
  - -> `[386]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Saltana, in light of the human rights violations Wehlen has committed, Morella surely cannot stay silent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The AN's swift interference has stopped many a would-be evildoer in their tracks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[340]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Which is why I am appealing to you all today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A lesson which all of you have apparently forgotten.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And as the world becomes more cutthroat, its existence becomes all the more essential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am aware that the comments made by President Wiktor Smolak earlier in this session demand a response from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`
  - -> `[334]`
  - -> `[356]`

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know I can count on Wehlen's full transparency as we work to bring this tragedy to a close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[344]`
  - -> `[386]`

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I am confident that a safe and secure transition can still be arranged with minimal delay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am willing to invest however much time it takes in order to get our territory back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Player AN Issues Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`
  - -> `[423]`
  - -> `[676]`

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot ignore the presence of Chancellor Hegel and his newfound interest in our neighbor, Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I may not share Morella's worldview. Yet I believe our citizens' struggles are one and the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[390]`
  - -> `[395]`
  - -> `[822]`

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree that we must improve our communication to ensure our gold mining standards are in alignment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia and Morella have maintained good relations for centuries. It pains me to see this noble country fall victim to Valgsland's influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]`
  - -> `[397]`
  - -> `[398]`
  - -> `[352]`

### Węzeł `[350]`
Mówca: **Narrator**
> "I saw Hegel lean forward in his seat intently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`
  - -> `[388]`
  - -> `[349]`
  - -> `[391]`

### Węzeł `[351]`
Mówca: **Narrator**
> "Prime Minister Saltana began applauding. Hegel looked pleasantly surprised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`
  - -> `[433]`
  - -> `[389]`

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Prime Minister Saltana is unhappy with the terms of the International Trade Zone, all she needs to do is tell us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[401]`
  - -> `[410]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_WorkersRightsAllIndustries"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However, I do not believe that this is the appropriate forum. I invite the President of Wehlen to expand on his security concerns in a private dialogue with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""President Smolak pointed his finger at Rumburg, yet failed to mention the financial backing his own country has received from United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[361]`
  - -> `[383]`

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, I would like to give President Smolak the benefit of the doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`
  - -> `[343]`
  - -> `[344]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So I ask you: Who will join us in holding President Smolak accountable?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[364]`
  - -> `[382]`
  - -> `[371]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I am saddened that nobody else joined him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[336]`
  - -> `[364]`
  - -> `[382]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are not fighting for a sliver of Rizia. We are fighting for the future of South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[364]`
  - -> `[382]`
  - -> `[371]`

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The people of Zille yearn for their home. Who is Wehlen to deny it to them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[361]`
  - -> `[383]`

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But now I ask of you: Who will be next?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[336]`
  - -> `[364]`
  - -> `[382]`

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Supreme Wiseman Azmal, Wehlen's occupation of Zille represents an invasion of Dastnurity into the land of St. Wruhec. Derdia must not condone it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart, given the Grand Duchy's close ties to Lespia, I would think you'd align with Mr. Alvarez on this vital issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[366]`
Mówca: **Narrator**
> "Alma Saltana applauded somewhat hesitantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[368]`
  - -> `[376]`

### Węzeł `[367]`
Mówca: **Narrator**
> "Jorga Azmal applauded loudly. His face remained impassive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[368]`
  - -> `[376]`

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. That's all I wanted to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[369]`
Mówca: **Narrator**
> "Axel Reinhart stayed motionless in his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart, given the results of our last meeting, I would expect you to align with Rizia on this vital issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[371]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`
  - -> `[373]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[374]`
Mówca: **Narrator**
> "Axel Reinhart hesitantly applauded from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`
  - -> `[368]`
  - -> `[376]`

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You see, President Smolak? Wehlen is outnumbered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I call on the rest of you to choose a side. History may ride on this outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Moving on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not yet finished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will give him another chance to honor the terms of our agreement. If that fails to happen, I will have to take matters into my own hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Narrator**
> "I snuck a look at Wiktor Smolak. He had a placid expression on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`
  - -> `[361]`
  - -> `[384]`
  - -> `[385]`
  - -> `[387]`

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like me, he knows there is more at stake than a mere sliver of Rizia. We are fighting for the future of South Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[336]`
  - -> `[364]`
  - -> `[382]`

### Węzeł `[382]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not ask for your commitment at this time. Only that you will support Rizia when the moment arrives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If President Smolak does not honor the terms of our agreement, we will be forced to take matters into our own hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`
  - -> `[364]`
  - -> `[382]`
  - -> `[371]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prior to the civil war, Rizia and Wehlen were close allies. I believe we can return to that relationship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia and Wehlen may never be allies as we once were. But I am holding out hope for a peaceful coexistence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""At this moment, our alliance with Rumburg comes secondary to our relationship with our direct neighbors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wehlen has been unfairly maligned since the events of the civil war. After order is restored in Zille, we shall help it regain its international prominence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]`

### Węzeł `[388]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Given the ongoing exploitation happening in Morella, I am not surprised that Prime Minister Saltana has looked to the east for assistance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`
  - -> `[390]`
  - -> `[395]`
  - -> `[396]`

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will discuss this further at the next meeting of the MITZ board.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The pillaging of the Meftiem International Trade Zone must stop. On that, we are in agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The specter of encroaching socialism does not scare me as much as the potential loss of our precious resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`
  - -> `[403]`
  - -> `[352]`

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let us not forget that the gas field would not have been discovered without our scientists' initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`
  - -> `[586]`
  - -> `[587]`

### Węzeł `[393]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a signee of the AN Directive on Offshore Resources, we have a right to the undersea gas within 200 kilometers from our coast. No matter which coast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`
  - -> `[586]`
  - -> `[587]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia still maintains ancient sovereignty over Pales. Ipso facto, their resources are ours as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`
  - -> `[586]`
  - -> `[587]`

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As Morella's longtime allies, we are prepared to offer what assistance we can in building a more equitable MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yet Rizia cannot condone this new radical direction. Nor will we simply accept the massive job and revenue loss that would come with nationalization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia cannot condone this radical new direction, nor will we simply accept the massive job and revenue loss that would come with nationalization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Morella is free to choose its own political direction. But it cannot use those politics to wantonly lay waste to its neighbors' economies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[399]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will use this forum to warn Prime Minister Saltana that if she is looking for a fight, Lespia and Rizia will give her one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Saltana is not acting of her own agency. The Malenyevist east is coercing our neighbor to do its bidding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I suspect her real interest is not in building a more equitable ITZ. It's in acquiring enough wealth to join the Contanan Security Pact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But Madam Prime Minister clearly has her heart set on a hostile takeover, with Valgsland's aid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Meftiem Trade Zone was established with the full agreement of all four countries involved, and only with their agreement can it be altered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`
  - -> `[411]`
  - -> `[410]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`
  - -> `[408]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`
  - -> `[414]`
  - -> `[411]`

### Węzeł `[407]`
Mówca: **Narrator**
> "Alma Saltana folded her arms, her expression stony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`
  - -> `[413]`

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not alone in my concerns. Isn't that right, Prime Minister Alvarez?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[409]`
Mówca: **Patricio Alvarez (R)**
> ""That's right, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not opposed to reopening negotiations, as long as Rizia continues to be able to provide for its citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[411]`
  - -> `[413]`

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I may be honest, it makes the most sense for both Valgsland and Lespia to end their involvement, as neither share a direct border with Morella.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[412]`
Mówca: **Narrator**
> "The Lespian and Valgslandian delegations broke into hushed whispers. President Nines gestured for silence again, then motioned for me to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to discussing this further at the next MITZ board meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will use this forum to warn Prime Minister Saltana that if she is looking for a fight, Rizia will give her one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]`

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not alone in my concerns. Isn't that right, Prime Minister Alvarez?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_ANSpeech_Wehlen == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_ANSpeech_Wehlen == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_ANSpeech_Wehlen"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_ANSpeech_Wehlen == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_ANSpeech_Wehlen"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that a real thing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[420]`
Mówca: **Laurento Esquibel**
> ""It is, Your Majesty, but no nation has ever invoked it before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[421]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_ANSpeech_Wehlen = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_ANSpeech_Wehlen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Player AN Issues Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[423]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_ANSpeech_Morella == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`
  - -> `[425]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_ANSpeech_Morella == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_ANSpeech_Morella"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_ANSpeech_Morella == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_ANSpeech_Morella"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[426]`
Mówca: **Narrator**
> "The assembly hall went silent. Laurento grimaced slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]`

### Węzeł `[427]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_ANSpeech_Appeasement = true; RiziaDLC.Diplomacy_Wehlen_NegotiatingPower += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_ANSpeech_Appeasement"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[428]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_ANSpeech_Aggression = true; RiziaDLC.Diplomacy_Wehlen_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_ANSpeech_Aggression"] = true;
Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Wehlen_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[378]`

### Węzeł `[429]`
Mówca: **Patricio Alvarez (R)**
> ""We are in agreement, Your Majesty. At least on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[430]`
Mówca: **Narrator**
> "The Morellan and Valgslandian delegations broke into hushed whispers. President Nines gestured for silence again, then motioned for me to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]`

### Węzeł `[431]`
Mówca: **Patricio Alvarez (R)**
> ""So will Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Having said that, I urge Morella to rethink its stance towards Derdian Golcondist pilgrims.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[444]`
  - -> `[441]`

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not opposed to reopening Trade Zone negotiations, as long as Rizia continues to be able to provide for its citizens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Rizia must make sacrifices so that Morella may prosper, so be it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[435]`
Mówca: **Narrator**
> "Prime Minister Alvarez and the Lespian delegation were speaking in worried whispers. President Nines again gestured for silence, then motioned for me to continue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[436]`
Mówca: **Patricio Alvarez (R)**
> ""So does Lespia, I might add.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I also stand with Morella against the Derdian extremists who seek to infiltrate their borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`
  - -> `[441]`
  - -> `[443]`

### Węzeł `[438]`
Mówca: **Narrator**
> "The Derdian leader sat silently, a defiant look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]`

### Węzeł `[439]`
Mówca: **Narrator**
> "Neither Prime Minister Saltana nor Supreme Wiseman Azmal seemed pleased with that remark."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the same spirit of cooperation, I believe a compromise can be reached regarding Derdia's religious travelers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]`
  - -> `[441]`
  - -> `[446]`

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The division of the former Empire of Moridia has pitted brother against brother. The violence must end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Supreme Wiseman Azmal, you speak of peace while pursuing advanced weaponry. Do your people not see the contradiction?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They have perverted the teachings of St. Wruhec, and their form of worship cannot be tolerated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]`

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After all, their ideology is no more dangerous than Malenyevism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is the 1950s, and freedom of religion should be a given in modern Merkopa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Their right to their sacred sites should not be ignored, but neither should the violent methods they have employed in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[447]`
Mówca: **Jorga Azmal**
> ""Halaita!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`

### Węzeł `[448]`
Mówca: **Narrator**
> "Scattered applause came from around the assembly hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[449]`
Mówca: **Narrator**
> "The Supreme Wiseman and the Derdian delegation rose and applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]`

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I also urge Morella to rethink its stance towards Derdian Golcondist pilgrims.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[444]`
  - -> `[441]`

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Having said that, I do stand with Morella against the Derdian extremists who seek to infiltrate our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`
  - -> `[441]`
  - -> `[443]`

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I also believe a compromise can be reached regarding Derdia's religious travelers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`
  - -> `[441]`
  - -> `[446]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeMad = true;
RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Morella_NegotiatingPower += 1;
RiziaDLC.Diplomacy_Valgsland_NegotiatingPower += 1;
RiziaDLC.LeaningValue_Democratic -= 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeMad"] = true;
Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Valgsland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Valgsland_NegotiatingPower"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[454]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_ANSpeech_SideAgainst = true;
RiziaDLC.Diplomacy_Lespia_NegotiatingPower += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Morella_ANSpeech_SideAgainst"] = true;
Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Lespia_NegotiatingPower"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]`
  - -> `[451]`
  - -> `[452]`

### Węzeł `[455]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_ANSpeech_SideWith = true; RiziaDLC.Diplomacy_Morella_NegotiatingPower += 2;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Morella_ANSpeech_SideWith"] = true;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`
  - -> `[437]`
  - -> `[440]`

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wow. He looks like shit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Poor Axel. He must be a bundle of nerves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope he doesn't make a fool of himself up there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[459]`
Mówca: **Laurento Esquibel**
> ""It's his first AN address. And he is quite inexperienced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[460]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "Laurento raised his eyebrows at the Duke's appearance. I didn't comment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[461]`
Mówca: **Narrator**
> "Duke Reinhart cleared his throat and shuffled a few papers around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[462]`
Mówca: **Axel Reinhart**
> ""Ahem. As the leader of the youngest nation in Southern Merkopa, I am humbled to be in this great hall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[463]`
Mówca: **Axel Reinhart**
> ""I am fully aware that everyone else in this room has spent their lives preparing to be in power. Whereas me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[464]`
Mówca: **Axel Reinhart**
> ""Let's just say that calling me a dilettante would be generous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[465]`
Mówca: **Narrator**
> "I heard laughter from around the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`
  - -> `[483]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[469]`
Mówca: **Axel Reinhart**
> ""The Kingdom of Rizia has deployed a naval fleet to the waters of my Grand Duchy. Supposedly in self-defense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[470]`
Mówca: **Axel Reinhart**
> ""But just because I am inexperienced does not mean I am naive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[471]`
Mówca: **Axel Reinhart**
> ""And yet we know what happened the last time Rizia sent military units to Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Axel Reinhart**
> ""On multiple occasions, His Majesty King Romus has indicated that he considers Rizia's loss of Pales to be unfinished business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`
  - -> `[475]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[476]`
Mówca: **Axel Reinhart**
> ""I believed that the coronation of His Majesty King Romus heralded a fresh start for our two nations. But I believed wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[477]`
Mówca: **Axel Reinhart**
> ""In this context, it is vital that my emerging nation assert its sovereignty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[478]`
Mówca: **Axel Reinhart**
> ""We hope the Alliance of Nations' arbitration committee sees through the Kingdom's poorly justified infringement on our maritime borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[479]`
Mówca: **Axel Reinhart**
> ""The incident in Wehlen has proven the lengths to which this dangerous new monarch will go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[480]`
Mówca: **Axel Reinhart**
> ""And we invite our other colleagues in this esteemed organization to engage with us as equals, irrespective of the way our neighbor has treated us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of act is he pulling?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[482]`
**[WYBÓR GRACZA: "Laugh yourself."]** — Mówca: **Player_Romus_Italic**
> "I joined in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]`

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's joking, but it's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`

### Węzeł `[484]`
Mówca: **Narrator**
> "Laurento gestured to where Prime Minister Alvarez was sitting. The Lespian leader wasn't smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`
  - -> `[487]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_ANSpeech_Morella = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn04_ANSpeech_Morella"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Player AN Issues Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[490]`
Mówca: **Laurento Esquibel**
> ""I wonder what he's getting at.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[491]`
Mówca: **Patricio Alvarez (R)**
> ""Well said, Your Grace!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`
  - -> `[494]`
  - -> `[500]`

### Węzeł `[492]`
Mówca: **Narrator**
> "Alvarez rose to his feet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]`

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pull those strings, Alvarez!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare you play the victim, Reinhart! You invaded *our* field!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]`

### Węzeł `[495]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]`
  - -> `[497]`

### Węzeł `[496]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[497]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[498]`
Mówca: **Axel Reinhart**
> ""The Kingdom of Rizia has staked a claim to a gas field that lies in Palesian waters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[499]`
Mówca: **Axel Reinhart**
> ""And it has refused to let go of that claim in spite of all of Pales' counteroffers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]`

### Węzeł `[500]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "I didn't speak up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`

### Węzeł `[501]`
Mówca: **Laurento Esquibel**
> ""Please, Your Majesty. This is the reaction Duke Reinhart wants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]`

### Węzeł `[502]`
Mówca: **Narrator**
> "Laurento looked at me worriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]`

### Węzeł `[503]`
Mówca: **Laurento Esquibel**
> ""Good, Your Majesty. Don't play the aggressor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[504]`
Mówca: **Axel Reinhart**
> ""You see. Even here, in this bastion of neutrality, Rizia believes it can bully us into submission. Which is why--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[505]`
Mówca: **Axel Reinhart**
> ""Pales may not yet have truly earned its spot in this assembly. But it is my hope that it will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[506]`
Mówca: **Axel Reinhart**
> ""And any nation that attempts to stop us from doing so will be met with a strong and resolute response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[507]`
Mówca: **Narrator**
> "His voice had regained its full confidence now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[508]`
Mówca: **Axel Reinhart**
> ""Since the fall of the Valgos Empire, Pales has been battled over by nations much more powerful than itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[509]`
Mówca: **Axel Reinhart**
> ""The Grand Duchy may be small. But it is not a plaything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[510]`
Mówca: **Axel Reinhart**
> ""Look at the art, literature and thought that has come out of Pales in the last 30 years. Look at our technological innovation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[511]`
Mówca: **Narrator**
> "He glanced up at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[512]`
Mówca: **Emmerich Hegel (R)**
> ""Criminal!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]`

### Węzeł `[513]`
Mówca: **Narrator**
> "Duke Reinhart looked shaken by the interjection."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[514]`
Mówca: **Emmerich Hegel (R)**
> ""No. No, I cannot stay silent while you make your entitled demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[515]`
Mówca: **Emmerich Hegel (R)**
> ""Your family used Pales as a base to pillage the Xinan continent. Everything you had, you stole from someone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[516]`
Mówca: **Emmerich Hegel (R)**
> ""And rather than give it back when the revolution forced your hand, you begged the capitalist swine of Lespia to help you hold on to your ill-gotten gains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[517]`
Mówca: **Axel Reinhart**
> ""I-- I beg your pardon, Chancellor Hegel, but I am not responsible for my family's sins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[518]`
Mówca: **Emmerich Hegel (R)**
> ""But you're happy to profit from them, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[519]`
Mówca: **Emmerich Hegel (R)**
> ""Up there in your glass castle... I'll tell you, Duke Reinhart, the cracks are beginning to show.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]`
  - -> `[526]`
  - -> `[542]`
  - -> `[520]`
  - -> `[823]`

### Węzeł `[520]`
**[WYBÓR GRACZA: "Applaud."]** — Mówca: **Player_Romus_Italic**
> "I applauded from my seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[521]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`
  - -> `[523]`

### Węzeł `[522]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]`

### Węzeł `[523]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[524]`
Mówca: **Axel Reinhart**
> ""That didn't sound like a cough, Chancellor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[525]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Damn. Duke Reinhart just got Hegeled!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot talk to a Duke this way, Chancellor Hegel. Be silent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[527]`
Mówca: **Axel Reinhart**
> ""Uh. Well. As I was saying, we Palesians--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[528]`
Mówca: **Axel Reinhart**
> ""Our new energy partnership with Rizia is a signal of Pales' entrance onto a greater global stage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[529]`
Mówca: **Narrator**
> "Patricio Alvarez was silently stewing in his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[530]`
Mówca: **Axel Reinhart**
> ""King Romus and I represent a new kind of monarchy. One that is young, flexible and in line with modern values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[531]`
Mówca: **Axel Reinhart**
> ""And I invite my other colleagues in this esteemed organization to engage with us as equals, irrespective of the way we have been treated in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`

### Węzeł `[532]`
Mówca: **Axel Reinhart**
> ""Furthermore, I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[533]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`
  - -> `[535]`

### Węzeł `[534]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]`

### Węzeł `[535]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]`

### Węzeł `[536]`
Mówca: **Narrator**
> "He glanced at Patricio Alvarez."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[537]`
Mówca: **Axel Reinhart**
> ""Yes, much of that was the result of our partnership with Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[538]`
Mówca: **Axel Reinhart**
> ""But it is ultimately our hope to stand tall on our own, while not forgetting the debt we owe to our benefactors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[539]`
Mówca: **Axel Reinhart**
> ""I think of Pales as a new kind of monarchy. One that is young, flexible and in line with modern values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[540]`
Mówca: **Laurento Esquibel**
> ""So it appears, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[541]`
Mówca: **Laurento Esquibel**
> ""I didn't realize the Chancellor harbored such lingering resentment over Pales. I wonder if we can use it to our advantage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[542]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]`
  - -> `[544]`

### Węzeł `[543]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[544]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[545]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""President Nines! Please remove the Chancellor from this session at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`

### Węzeł `[546]`
Mówca: **Narrator**
> "Hegel frowned at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]`

### Węzeł `[547]`
Mówca: **Emmerich Hegel (R)**
> ""You are equally culpable, Your Majesty. The days of both of your monarchies are numbered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]`

### Węzeł `[548]`
Mówca: **Narrator**
> "He glared out from his seat as Duke Reinhart finished his speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]`

### Węzeł `[549]`
Mówca: **Patricio Alvarez (R)**
> ""President Nines, this man is abusing his guest privileges. Can he be removed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]`

### Węzeł `[550]`
Mówca: **Axel Reinhart**
> ""I, uh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[551]`
Mówca: **Narrator**
> "He tapped on the mic nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]`

### Węzeł `[552]`
Mówca: **Axel Reinhart**
> ""I see the Chancellor is still resentful that the people of Pales chose the firm leadership of the Reinhart family over the chaos of revolution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]`

### Węzeł `[553]`
Mówca: **Axel Reinhart**
> ""Rest assured that we will resist any further attempts to bully us into submission. And furthermore--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`

### Węzeł `[554]`
Mówca: **Axel Reinhart**
> ""Yes, the Grand Duchy aided in the colonialist aims of the Valgos Empire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[555]`
Mówca: **Axel Reinhart**
> ""But like Valgsland, we are ready to put that past behind us and look towards the future. We simply have a different vision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[556]`
Mówca: **Narrator**
> "He rushed back to his seat as chatter erupted from the rest of the assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]`

### Węzeł `[557]`
Mówca: **Laurento Esquibel**
> ""It's certainly been an eventful session, Your Majesty. I hope you're ready for your speech.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`
  - -> `[559]`
  - -> `[560]`

### Węzeł `[558]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not in the slightest, but I'll improvise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm as ready as I'll ever be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I have it all planned out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]`

### Węzeł `[561]`
Mówca: **Narrator**
> "I took a deep breath as President Nines announced my name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]`

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Finally, a word regarding Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[563]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]`
  - -> `[565]`

### Węzeł `[564]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]`
  - -> `[567]`
  - -> `[568]`
  - -> `[577]`

### Węzeł `[565]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]`

### Węzeł `[566]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is to my great dismay that my kingdom has been forced to quarrel with our closest neighbor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`
  - -> `[575]`
  - -> `[576]`
  - -> `[574]`

### Węzeł `[567]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duke Reinhart has said he wants other nations to engage with Pales as an equal. That is exactly what Rizia is doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`
  - -> `[575]`
  - -> `[576]`
  - -> `[574]`

### Węzeł `[568]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite the Duke's claims, Rizia is not the aggressor in this situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`
  - -> `[575]`
  - -> `[576]`
  - -> `[574]`

### Węzeł `[569]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]`
  - -> `[571]`

### Węzeł `[570]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]`
  - -> `[628]`
  - -> `[630]`

### Węzeł `[571]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]`
  - -> `[644]`
  - -> `[645]`

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like Duke Reinhart, I believe our nations' burgeoning partnership represents the dawning of a new golden age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`
  - -> `[629]`
  - -> `[633]`

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pales sent a drillship to disputed territory. Our response should not come as a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`
  - -> `[579]`
  - -> `[580]`

### Węzeł `[574]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My kingdom is not even asking for ownership of the entire territory in question. Only our rightful half.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`
  - -> `[579]`
  - -> `[580]`

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You cannot well paint us as a bully when you are backed by Lespia and thus the full strength of ATO.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`
  - -> `[579]`
  - -> `[580]`

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we truly wanted to intimidate Pales into giving up control of the gas field, we would have done so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]`
  - -> `[579]`
  - -> `[580]`

### Węzeł `[577]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This gas dispute is nothing less than a fight for South Merkopa's right to self-determination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]`
  - -> `[575]`
  - -> `[576]`
  - -> `[574]`

### Węzeł `[578]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am convinced that a peaceful compromise can be reached with the AN's help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
  - -> `[393]`
  - -> `[394]`
  - -> `[582]`

### Węzeł `[579]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is my hope that the AN arbitration committee ignores the emotional statements that have been made today and focuses on the facts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
  - -> `[393]`
  - -> `[394]`
  - -> `[582]`

### Węzeł `[580]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From Rizia's point of view, this is a cut-and-dry case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`
  - -> `[393]`
  - -> `[394]`
  - -> `[582]`

### Węzeł `[581]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our intelligence services submitted concrete proof of Pales' cooperation with Lespian energy executives. Their lack of transparency should concern us all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]`
  - -> `[586]`
  - -> `[587]`

### Węzeł `[582]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]`
  - -> `[584]`

### Węzeł `[583]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_Pales_SendSpecialOps == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]`

### Węzeł `[584]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Security_Pales_SendSpecialOps == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Security_Pales_SendSpecialOps"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In light of that, we cannot promise we will abide by the AN's arbitration results.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[586]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, we will respect the arbitration committee's ruling. As long as it is fair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[587]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are counting on the arbitrators to make the right decision here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]`

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Chancellor Hegel. I was inspired by your courage in confronting the Lespian and Palesian delegations today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]`

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite our differing views, I ask for your aid against our common imperialist enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`
  - -> `[600]`
  - -> `[779]`

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We may have more in common than either of us suspected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]`
  - -> `[600]`
  - -> `[779]`

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If Rizia does gain control of this valuable resource, I promise all of South Merkopa will benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[592]`
Mówca: **Narrator**
> "I paused to look at Hegel. His face didn't give anything away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]`
  - -> `[590]`
  - -> `[593]`

### Węzeł `[593]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I do not welcome your support. By necessity, Rizia must keep its distance from you and your ideologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is Valgsland with us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[595]`
Mówca: **Narrator**
> "Hegel's expression stayed the same. He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[596]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_ANSpeech_SideWith == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]`
  - -> `[598]`

### Węzeł `[597]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Morella_ANSpeech_SideWith == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Morella_ANSpeech_SideWith"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]`

### Węzeł `[598]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Morella_ANSpeech_SideWith == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Morella_ANSpeech_SideWith"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]`

### Węzeł `[599]`
Mówca: **Narrator**
> "The chancellor's expression stayed the same. He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]`

### Węzeł `[600]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Could you ever envision lending your support to a monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]`

### Węzeł `[601]`
Mówca: **Narrator**
> "Hegel let out an enormous laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]`

### Węzeł `[602]`
Mówca: **Emmerich Hegel (R)**
> ""And they call me mad!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]`

### Węzeł `[603]`
Mówca: **Emmerich Hegel (R)**
> ""Don't bother, Mr. President. I'll show myself out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]`

### Węzeł `[604]`
Mówca: **Narrator**
> "He and his aides made their way to the exit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]`

### Węzeł `[605]`
Mówca: **Emmerich Hegel (R)**
> ""Royal relics and bourgeoise gluttons scrabbling for power... Pretending to sympathize with the revolution will not protect you from it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]`

### Węzeł `[606]`
Mówca: **Narrator**
> "Next to me, Laurento's jaw was hanging open in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]`

### Węzeł `[607]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]`
  - -> `[609]`

### Węzeł `[608]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]`
  - -> `[611]`

### Węzeł `[609]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_Military_BlockDrillship == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Military_BlockDrillship"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`
  - -> `[591]`

### Węzeł `[610]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As for the blockade of the gas field by our navy, it will continue for as long as it has to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`
  - -> `[591]`

### Węzeł `[611]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, I sincerely hope we will not be forced to use the fleet that we have deployed to the field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]`
  - -> `[591]`

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For too long, we have let the superpowers wield their influence over us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`
  - -> `[619]`
  - -> `[620]`
  - -> `[623]`

### Węzeł `[613]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""President Smolak was wrong. It is not the superpowers who are tearing us apart. We are doing it to ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`
  - -> `[619]`
  - -> `[620]`
  - -> `[623]`

### Węzeł `[614]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Times have changed. I am aware that Rizia stands nearly alone as a kingdom in a sea of republics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]`
  - -> `[619]`
  - -> `[620]`
  - -> `[623]`

### Węzeł `[615]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But in the end, we are still all humans under a single God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`
  - -> `[625]`
  - -> `[626]`

### Węzeł `[616]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]`
  - -> `[618]`

### Węzeł `[617]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Religious == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]`

### Węzeł `[618]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Religious == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But our proud nation will not succumb to foreign pressure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`
  - -> `[625]`
  - -> `[626]`

### Węzeł `[620]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I hold out hope that we may find our way back to each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`
  - -> `[625]`
  - -> `[626]`

### Węzeł `[621]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will conclude with these words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`
  - -> `[612]`
  - -> `[614]`

### Węzeł `[622]`
Mówca: **Narrator**
> "President Nines motioned to the clock. My speech had gone over its run time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]`
  - -> `[673]`
  - -> `[674]`

### Węzeł `[623]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But Rizia -- and our partners in GRACE -- are prepared to demonstrate that the monarchy still has significance in this modern world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]`

### Węzeł `[624]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]`

### Węzeł `[626]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The King has spoken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[627]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both of our families have made it through bloody revolutions, because it was the people's will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`
  - -> `[634]`
  - -> `[635]`

### Węzeł `[628]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I too believe this young nation deserves a place among the international community.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`
  - -> `[629]`
  - -> `[631]`
  - -> `[633]`

### Węzeł `[629]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Both of us recognize the growing threat of Malenyevism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`
  - -> `[634]`
  - -> `[635]`

### Węzeł `[630]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My relationship with the Grand Duchy is purely a business partnership. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]`
  - -> `[629]`
  - -> `[631]`
  - -> `[633]`

### Węzeł `[631]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Neither of us wish Lespia and ATO to expand their influence further south.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`
  - -> `[634]`
  - -> `[635]`

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Certain nations have tried to turn us against each other for their own benefit. No more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`
  - -> `[637]`

### Węzeł `[633]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We both wish to end the cycle of violence started by our predecessors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]`
  - -> `[634]`
  - -> `[635]`

### Węzeł `[634]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have not forgotten our countries' past animosity. But we are glad to look to the future together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`
  - -> `[637]`

### Węzeł `[635]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Some of you may doubt that enlightened monarchies can exist in the modern age. We will prove you wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]`
  - -> `[637]`

### Węzeł `[636]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regarding the remarks by Chancellor Hegel...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]`
  - -> `[639]`
  - -> `[640]`

### Węzeł `[637]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As for the prior remarks made by the Chancellor of Valgsland, I will not dignify them with a response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[638]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just because the Valgslandian revolution failed in Pales does not delegitimize it as a country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no need to punish Duke Reinhart for his ancestors' crimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]`

### Węzeł `[640]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree that the Palesian royal family has not adequately made amends for its past. With Rizia's guidance, perhaps they may finally be able to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]`

### Węzeł `[641]`
Mówca: **Narrator**
> "Duke Reinhart dutifully applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[642]`
Mówca: **Narrator**
> "Duke Reinhart and his delegation broke into enthusiastic applause. Hegel looked displeased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[643]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have watched with concern as the Grand Duchy has grown closer to Lespia over the years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`
  - -> `[650]`
  - -> `[649]`

### Węzeł `[644]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am of course displeased that Duke Reinhart claimed sole ownership of natural gas that Rizian scientists discovered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]`
  - -> `[650]`
  - -> `[649]`

### Węzeł `[645]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Despite the past animosity between Rizia and the Grand Duchy, I still see a way forward for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]`
  - -> `[648]`
  - -> `[647]`

### Węzeł `[646]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However, after speaking with Prime Minister Alvarez of Lespia, I am convinced that harmony can be maintained between our three nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[657]`

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And in fact, after speaking with Prime Minister Alvarez of Lespia in the wake of their recent gas deal, I am convinced that harmony can be maintained between our three nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[657]`

### Węzeł `[648]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The fact that my kingdom has let go of its rightful claim on the Aureus gas field proves that we are serious about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[657]`

### Węzeł `[649]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But the fact that my kingdom was willing to let go of its rightful claim on the Aureus field shows how serious we are about wanting peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[657]`

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The fact that Pales and Lespia conspired to deprive my kingdom of the right to its own natural gas should be alarming to everyone gathered here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[653]`

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even though the fact that Pales and Lespia conspired to deprive my kingdom of the right to its own natural gas should be alarming to everyone gathered here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]`
  - -> `[657]`

### Węzeł `[652]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, it is in our interest that the sharing of exploration rights go as smoothly as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[672]`

### Węzeł `[653]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]`
  - -> `[655]`

### Węzeł `[654]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]`
  - -> `[662]`
  - -> `[660]`

### Węzeł `[655]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]`

### Węzeł `[656]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is in our interest that the sharing of exploration rights go as smoothly as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[672]`

### Węzeł `[657]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]`
  - -> `[659]`

### Węzeł `[658]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]`
  - -> `[660]`
  - -> `[663]`

### Węzeł `[659]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_GasField_25PercentDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]`

### Węzeł `[660]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is our intention that not only Rizia, but all of South Merkopa benefit from this tremendous new resource.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[672]`

### Węzeł `[661]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For all our differences, we have one thing in common: We are united against the Malenyevist menace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]`

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But wealth is the great unifier. And I am looking forward to reinvesting the profits from our share of the gas field into our region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[672]`

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wealth is the great unifier. And I am looking forward to reinvesting the profits from our share of the gas field into our region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[672]`

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not blame Pales or Lespia for looking out for their citizens' welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[672]`

### Węzeł `[665]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I do not blame Pales or Lespia for looking out for their citizens' welfare.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[672]`

### Węzeł `[666]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Regarding the remarks by Chancellor Hegel...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]`
  - -> `[667]`
  - -> `[668]`
  - -> `[816]`
  - -> `[764]`

### Węzeł `[667]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just because the Valgslandian revolution failed in Pales does not delegitimize it as a country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[668]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no need to punish Duke Reinhart for his ancestors' crimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[669]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree that the Palesian royal family has not adequately made amends for its past. Perhaps their upcoming influx of Lespian wealth would be best used for reparations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[670]`
Mówca: **Narrator**
> "Hegel applauded with raised eyebrows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]`

### Węzeł `[671]`
Mówca: **Narrator**
> "Duke Reinhart and his delegation broke into enthusiastic applause. Hegel looked displeased."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[672]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As for the prior remarks made by the Chancellor of Valgsland, I will not dignify them with a response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[673]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I won't bore you for much longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`
  - -> `[612]`
  - -> `[614]`

### Węzeł `[674]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not rush a king, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]`
  - -> `[612]`
  - -> `[614]`

### Węzeł `[675]`
Mówca: **Narrator**
> "I sat down. An aide handed me a glass of water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]`

### Węzeł `[676]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_ANSpeech_Wehlen == true && RiziaDLCIsolated.Turn04_ANSpeech_Morella == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]`
  - -> `[678]`

### Węzeł `[677]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn04_ANSpeech_Wehlen == true && RiziaDLCIsolated.Turn04_ANSpeech_Morella == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_ANSpeech_Wehlen"] == true  and  Variable["RiziaDLCIsolated.Turn04_ANSpeech_Morella"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]`
  - -> `[562]`

### Węzeł `[678]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn04_ANSpeech_Wehlen == true && RiziaDLCIsolated.Turn04_ANSpeech_Morella == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_ANSpeech_Wehlen"] == true  and  Variable["RiziaDLCIsolated.Turn04_ANSpeech_Morella"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[679]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As for the so-called 'Grand Duchy'...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]`

### Węzeł `[680]`
Mówca: **Narrator**
> "Laurento turned to me as the Morellan prime minister wrapped up her speech and returned to her seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]`

### Węzeł `[681]`
Mówca: **Laurento Esquibel**
> ""It seems the Trade Zone is going to be more of a sticking point than I thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]`
  - -> `[686]`
  - -> `[687]`
  - -> `[688]`

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's going to be fine. Alvarez and I will present a united front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[683]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]`
  - -> `[685]`

### Węzeł `[684]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]`

### Węzeł `[685]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_PromiseITZSupport == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_PromiseITZSupport"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[686]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing's going to be decided today, anyway. It's all just talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[687]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what it takes. We're keeping our gold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]`

### Węzeł `[688]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I just hope she doesn't expect me to deal with Derdia on her behalf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]`

### Węzeł `[689]`
Mówca: **Laurento Esquibel**
> ""Speaking of which...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[690]`
Mówca: **Laurento Esquibel**
> ""I'm also curious what Derdia thinks of her 'terrorist' remark. But we won't have to wait long to find out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]`

### Węzeł `[691]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Derdia AN Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[692]`
Mówca: **Narrator**
> "Supreme Wiseman Azmal made the pillar sign again as he exited the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`
  - -> `[284]`
  - -> `[285]`
  - -> `[286]`

### Węzeł `[693]`
Mówca: **Laurento Esquibel**
> ""Oh, but now it's time for the real heavy artillery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]`

### Węzeł `[694]`
Mówca: **Narrator**
> "He gestured to an aide to begin taking notes as President Nines announced Wiktor Smolak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]`

### Węzeł `[695]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Wehlen AN Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[696]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dammit. What do I do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]`

### Węzeł `[697]`
**[WYBÓR GRACZA: "Boo him."]** — Mówca: **Player_Romus_Italic**
> "I booed as he walked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[698]`
**[WYBÓR GRACZA: "Applaud politely."]** — Mówca: **Player_Romus_Italic**
> "I politely applauded as he walked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[699]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]`
  - -> `[701]`

### Węzeł `[700]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]`

### Węzeł `[701]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_WehlenHelp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[702]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looks like I was right to accept Lespia's help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[703]`
Mówca: **Laurento Esquibel**
> ""You'll have a chance to comment soon enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]`

### Węzeł `[704]`
Mówca: **Laurento Esquibel**
> ""I'll get in touch with Wehlen's foreign ministers as soon as we're back home. There may still be a way to straighten things out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]`

### Węzeł `[705]`
Mówca: **Laurento Esquibel**
> ""Now let's see if Prime Minister Alvarez has any words on the subject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[706]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Lespia AN Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[707]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]`
  - -> `[709]`

### Węzeł `[708]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]`

### Węzeł `[709]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_WehlenHelp == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]`

### Węzeł `[710]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing about Wehlen?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]`

### Węzeł `[711]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]`
  - -> `[713]`

### Węzeł `[712]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]`

### Węzeł `[713]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Pales_ANDORArbitration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]`

### Węzeł `[714]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Valgsland is certainly an active participant today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]`

### Węzeł `[715]`
Mówca: **Laurento Esquibel**
> ""Either that, or Hegel really does have a cold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[716]`
Mówca: **Laurento Esquibel**
> ""It's not in Lespia's interest to take sides on Zille. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[717]`
**[WYBÓR GRACZA: "Applaud."]** — Mówca: **Player_Romus_Italic**
> "I joined the rest of the room in applause as Alvarez left the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[718]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was expecting more commentary from Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]`

### Węzeł `[719]`
Mówca: **Laurento Esquibel**
> ""The day's not over yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[720]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was expecting more help with Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]`

### Węzeł `[721]`
Mówca: **Laurento Esquibel**
> ""It's a tough crowd to sway. In either direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]`

### Węzeł `[722]`
Mówca: **Laurento Esquibel**
> ""Looks like Pales is next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]`

### Węzeł `[723]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Pales AN Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[724]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Player AN Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[725]`
Mówca: **Laurento Esquibel**
> ""Well done, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]`
  - -> `[730]`

### Węzeł `[726]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]`
  - -> `[728]`

### Węzeł `[727]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]`

### Węzeł `[728]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[729]`
Mówca: **Laurento Esquibel**
> ""Your decision to appeal to Valgsland was... interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]`

### Węzeł `[730]`
Mówca: **Laurento Esquibel**
> ""It'll take a while to digest the ramifications. Let's update on all this once we're back in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]`

### Węzeł `[731]`
Mówca: **Narrator**
> "Filing back out of the assembly hall, I noticed the sound of the rain on the dome had stopped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]`

### Węzeł `[732]`
Mówca: **Narrator**
> "Another sunny day in Konstantium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]`

### Węzeł `[733]`
Mówca: **Laurento Esquibel**
> ""Strictly speaking, Your Majesty, Hegel no longer considers himself a Malenyevist. Vaglsandian Socialism is its own school of thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[734]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's that Malenyevist doing here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]`

### Węzeł `[735]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Laurento Esquibel");)*
- **Efekt (`userScript`):** `AddConversant("Laurento Esquibel");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[736]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Alma Saltana");)*
- **Efekt (`userScript`):** `AddConversant("Alma Saltana");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[737]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Jorga Azmal");)*
- **Efekt (`userScript`):** `AddConversant("Jorga Azmal");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[738]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Wiktor Smolak (R)");)*
- **Efekt (`userScript`):** `AddConversant("Wiktor Smolak (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[739]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Patricio Alvarez (R)");)*
- **Efekt (`userScript`):** `AddConversant("Patricio Alvarez (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[740]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Emmerich Hegel (R)");)*
- **Efekt (`userScript`):** `AddConversant("Emmerich Hegel (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[741]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Alma Saltana");
RemoveConversant("Emmerich Hegel (R)"))*
- **Efekt (`userScript`):** `RemoveConversant("Alma Saltana");
RemoveConversant("Emmerich Hegel (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]`

### Węzeł `[742]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Jorga Azmal");

// Removes the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Jorga Azmal");
-- Removes the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]`

### Węzeł `[743]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Wiktor Smolak (R)");

// Adds the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Wiktor Smolak (R)");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]`

### Węzeł `[744]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Emmerich Hegel (R)");

// Adds the conversant with the character name in database)*
- **Efekt (`userScript`):** `AddConversant("Emmerich Hegel (R)");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[745]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Emmerich Hegel (R)");

// Adds the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Emmerich Hegel (R)");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[746]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Emmerich Hegel (R)");
RemoveConversant("Patricio Alvarez (R)");)*
- **Efekt (`userScript`):** `RemoveConversant("Emmerich Hegel (R)");
RemoveConversant("Patricio Alvarez (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[747]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `RemoveConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[748]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Jorga Azmal");)*
- **Efekt (`userScript`):** `RemoveConversant("Jorga Azmal");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]`

### Węzeł `[749]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Patricio Alvarez (R)");)*
- **Efekt (`userScript`):** `RemoveConversant("Patricio Alvarez (R)");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[750]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Emmerich Hegel (R)");)*
- **Efekt (`userScript`):** `RemoveConversant("Emmerich Hegel (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[751]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]`
  - -> `[753]`

### Węzeł `[752]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Lespia_WehlenHelp == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]`

### Węzeł `[753]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Lespia_WehlenHelp == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Lespia_WehlenHelp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]`

### Węzeł `[754]`
Mówca: **Laurento Esquibel**
> ""Now let's see if Prime Minister Alvarez delivers the support he promised you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]`

### Węzeł `[755]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn04_RH_ZilleAnnouncement = true; RiziaDLCSupport.News_Turn04_G_AN_WehlenAnnouncement = true; RiziaDLCSupport.News_Turn04_G_AN_Hegel = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn04_RH_ZilleAnnouncement"] = true;
Variable["RiziaDLCSupport.News_Turn04_G_AN_WehlenAnnouncement"] = true;
Variable["RiziaDLCSupport.News_Turn04_G_AN_Hegel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]`

### Węzeł `[756]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Patricio Alvarez (R)");

// Adds the conversant with the character name in database)*
- **Efekt (`userScript`):** `RemoveConversant("Patricio Alvarez (R)");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]`
  - -> `[711]`
  - -> `[717]`

### Węzeł `[757]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[758]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]`
  - -> `[672]`

### Węzeł `[759]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]`
  - -> `[761]`

### Węzeł `[760]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]`

### Węzeł `[761]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[762]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The suggestion that the Reinhart family does not deserve their hard-earned wealth only proves how dangerous this man and his philosophy are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]`

### Węzeł `[763]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to the day when all noble families, not only Duke Reinhart's, are forced to reexamine the source of their wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]`

### Węzeł `[764]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]`
  - -> `[766]`

### Węzeł `[765]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]`

### Węzeł `[766]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[767]`
Mówca: **Laurento Esquibel**
> ""I know very little about his activities in Derdia, to be honest. His compound is shrouded in secrecy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[768]`
Mówca: **Laurento Esquibel**
> ""I admit I'm very curious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[769]`
Mówca: **Laurento Esquibel**
> ""That's probably it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[770]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]`
  - -> `[772]`

### Węzeł `[771]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[772]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[773]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]`
  - -> `[775]`

### Węzeł `[774]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[775]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[776]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]`
  - -> `[778]`

### Węzeł `[777]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]`

### Węzeł `[778]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Malenyevist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[779]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would not presume to ask for Valgsland's support. But you have my respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]`

### Węzeł `[780]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]`

### Węzeł `[781]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech = true; RiziaDLC.PersonalValue_Malenyevist += 1;
RiziaDLC.Diplomacy_Valgsland_NegotiatingPower += 1;
RiziaDLC.Diplomacy_Morella_NegotiatingPower += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Valgsland_AppealToAtANSpeech"] = true;
Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;
Variable["RiziaDLC.Diplomacy_Valgsland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Valgsland_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[782]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]`
  - -> `[625]`
  - -> `[626]`

### Węzeł `[783]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Impasse", "R_Impasse_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Impasse","R_Impasse_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]`

### Węzeł `[784]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: AddConversant("Axel Reinhart");)*
- **Efekt (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[785]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did I make a mistake? Are we going to lose the arbitration case?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]`

### Węzeł `[786]`
Mówca: **Laurento Esquibel**
> ""I believe we can win. Especially if we make a good argument today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[787]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did I make a mistake? Should we have fought harder for our half of the field?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]`

### Węzeł `[788]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]`
  - -> `[790]`

### Węzeł `[789]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[790]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCSupport.Journal_Turn04_Pales_EndGasDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[791]`
Mówca: **Narrator**
> "Duke Axel Reinhart and Patricio Alvarez entered late, deep in conversation. They nodded at each other and took seats with their respective delegations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]`
  - -> `[792]`

### Węzeł `[792]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at those two lovebirds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]`

### Węzeł `[793]`
Mówca: **Laurento Esquibel**
> ""We saved ourselves a lot of unnecessary tension. I would call that a win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[794]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wonder what they were talking about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[795]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true || RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]`
  - -> `[797]`

### Węzeł `[796]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_HostileToPales == true || RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_HostileToPales"] == true  or  Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]`

### Węzeł `[797]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_HostileToPales == true || RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HostileToPales"] == true  or  Variable["RiziaDLCSupport.Journal_Turn04_Pales_NavalWithdrawal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]`

### Węzeł `[798]`
Mówca: **Laurento Esquibel**
> ""Reinhart was not pleased with Lespia and Rizia making deals behind his back. But he had no choice but to accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[799]`
Mówca: **Laurento Esquibel**
> ""Reinhart was surprisingly happy with Lespia's offer to us. Perhaps Pales, Lespia and Rizia can exist in harmony after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[800]`
Mówca: **Laurento Esquibel**
> ""I heard similar rumors. But nothing substantiated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[801]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_NegotiatingPower -= 1; RiziaDLC.Diplomacy_Rumburg_NegotiatingPower -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Rumburg_NegotiatingPower"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[802]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]`

### Węzeł `[803]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]`

### Węzeł `[804]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy = true;
RiziaDLC.Diplomacy_Derdia_NegotiatingPower += 1;
RiziaDLC.Diplomacy_Morella_NegotiatingPower -= 1;
RiziaDLC.Diplomacy_Valgsland_NegotiatingPower -= 1;
RiziaDLC.LeaningValue_Democratic += 1;)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Derdia_ANSpeech_MakeHappy"] = true;
Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Derdia_NegotiatingPower"] + 1;
Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Morella_NegotiatingPower"] - 1;
Variable["RiziaDLC.Diplomacy_Valgsland_NegotiatingPower"] = Variable["RiziaDLC.Diplomacy_Valgsland_NegotiatingPower"] - 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]`

### Węzeł `[805]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]`
  - -> `[807]`

### Węzeł `[806]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]`

### Węzeł `[807]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_ATAActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_ATAActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]`

### Węzeł `[808]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn04_Zille_ATAProtest = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Zille_ATAProtest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]`

### Węzeł `[809]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]`
  - -> `[811]`

### Węzeł `[810]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]`

### Węzeł `[811]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Zille_SuOminaActive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`

### Węzeł `[812]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.Reports_Turn04_Zille_SOProtest = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn04_Zille_SOProtest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]`

### Węzeł `[813]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_Construction_PalesPipeline", 25);)*
- **Efekt (`userScript`):** `UpdateProgress("Progress_Construction_PalesPipeline", 25);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[814]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]`

### Węzeł `[815]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Situation_Diplomacy_AN_ThreatMitigationProtocol"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]`

### Węzeł `[816]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]`
  - -> `[818]`

### Węzeł `[817]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Pales_GasField_Buy == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]`

### Węzeł `[818]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Diplomacy_Pales_GasField_Buy == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GasField_Buy"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[819]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[820]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_Halaita += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[821]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Said_GlovuriusAxaRizia += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]`

### Węzeł `[822]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""However, I do not believe Morella needs to resort to such an extreme measure as nationalization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[823]`
**[WYBÓR GRACZA: "Don't react."]** — Mówca: **Player_Romus_Italic**
> "I didn't do or say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]`

### Węzeł `[824]`
Mówca: **Ephraim Nines (R)**
> ""I hereby welcome our esteemed delegations from the nations of South Merkopa to this special session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]`

### Węzeł `[825]`
Mówca: **Ephraim Nines (R)**
> ""We have many leaders to hear from today, so I will keep the opening remarks to a minimum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[826]`
Mówca: **Ephraim Nines (R)**
> ""ORDER!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[827]`
Mówca: **Ephraim Nines (R)**
> ""Chancellor Hegel, this is your last warning. Do not interrupt today's session again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]`

### Węzeł `[828]`
Mówca: **Emmerich Hegel (R)**
> ""Very well. I've said all I needed to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[829]`
Mówca: **Ephraim Nines (R)**
> ""Chancellor, you have been warned--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]`

### Węzeł `[830]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Addressing the Alliance of Nations", "AN Headquarters", "Kyrute");)*
- **Efekt (`userScript`):** `SetRichPresence("Addressing the Alliance of Nations","AN Headquarters","Kyrute");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]`
