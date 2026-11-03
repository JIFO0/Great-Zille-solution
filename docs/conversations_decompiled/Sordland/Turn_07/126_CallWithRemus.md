# Sordland/Turn07/CallWithRemus

- **ID konwersacji:** `126`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/126_CallWithRemus.md`
- **Liczba węzłów dialogowych:** 62
- **Liczba wyborów gracza:** 18

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker`
- `BaseGame.YoungSords_Kill_OrsoHawker`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.YoungSords_Aids_Election`
- `BaseGame.YoungSords_Aids_Security`
- `BaseGame.YoungSords_Kill_OrsoHawker`
- `BaseGameSupport.Journal_Turn07_YoungSords_Ordered_ElectionAid`
- `BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder`
- `BaseGameSupport.Journal_Turn07_YoungSords_Ordered_SecurityAid`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[86]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[19]` (Paskal Beniwoll): `Variable["BaseGame.YoungSords_Aids_Security"] = true; Variable["BaseGameSupport.Journal_Turn07_Yo...`
- Węzeł `[20]` (Paskal Beniwoll): `Variable["BaseGame.YoungSords_Aids_Election"] = true; Variable["BaseGameSupport.Journal_Turn07_Yo...`
- Węzeł `[21]` (Paskal Beniwoll): `Variable["BaseGame.YoungSords_Kill_OrsoHawker"] = true; Variable["BaseGame.Turn07_SecretState_Kil...`

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `115` (*Sordland/Turn07/A_ResultsMeeting*), Węzeł `[86]`

### Węzeł `[3]`
Mówca: **Narrator**
> "Remus responded in a low voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[4]`
Mówca: **Remus Holstron**
> ""How may I help you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[35]`
  - -> `[10]`
  - -> `[18]`
  - -> `[22]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm already working on it, but I may require some help with getting rid of Orso Hawker. I don't trust the deep state elements inside the Forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[8]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_AttemptToKillOrsoHawker"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I may require some help with getting rid of Orso Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Security in Sordland is still concerning. I require your help with boosting our security forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[11]`
Mówca: **Remus Holstron**
> ""Who is this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's the President speaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's Anton Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your secret partner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The one who knocks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Remus Holstron**
> ""What?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Remus Holstron**
> ""Oh, Mr. President. How nice of you to call.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The elections are approaching. I require your help with our... campaign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Aids_Security = true;
BaseGameSupport.Journal_Turn07_YoungSords_Ordered_SecurityAid = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.YoungSords_Aids_Security"] = true;
Variable["BaseGameSupport.Journal_Turn07_YoungSords_Ordered_SecurityAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Aids_Election = true;
BaseGameSupport.Journal_Turn07_YoungSords_Ordered_ElectionAid = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.YoungSords_Aids_Election"] = true;
Variable["BaseGameSupport.Journal_Turn07_YoungSords_Ordered_ElectionAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Kill_OrsoHawker = true;
BaseGame.Turn07_SecretState_Kill_OrsoHawker = true;
BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.YoungSords_Kill_OrsoHawker"] = true;
Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] = true;
Variable["BaseGameSupport.Journal_Turn07_YoungSords_Ordered_OrsoHawkerMurder"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I just wanted to ask if everything was going well on your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Remus Holstron**
> ""Oh, thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Remus Holstron**
> ""Everything is running smoothly. But is there something you need from us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[10]`
  - -> `[18]`
  - -> `[25]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, thank you. Maybe another time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Remus Holstron**
> ""Uhm... Okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Remus Holstron**
> ""Well, if that was all, I'll have to go back to my work now, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Remus Holstron**
> ""Have a nice day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[29]`
Mówca: **Remus Holstron**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Remus Holstron**
> ""You are right not to trust them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Remus Holstron**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Remus Holstron**
> ""I knew this was coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Remus Holstron**
> ""Maybe we can help you with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[34]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Kill_OrsoHawker == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.YoungSords_Kill_OrsoHawker == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.YoungSords_Kill_OrsoHawker == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.YoungSords_Kill_OrsoHawker"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You are late. Why is the Chief Justice still around?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Remus Holstron**
> ""We are talking about one of the most protected men in Sordland here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Remus Holstron**
> ""Have some patience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[41]`
Mówca: **Remus Holstron**
> ""Mr. Hawker is proving to be an unreliable partner to us as well. I'm not against the idea of sending a message through him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Remus Holstron**
> ""I'll discuss this with the guys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Good. I'll be expecting the news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That settles it then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Maybe you got me wrong, Mr. Holstron. Let's just cancel this whole thing. This was a misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Remus Holstron**
> ""Oh? Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[47]`
Mówca: **Remus Holstron**
> ""We can surely help with that, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Remus Holstron**
> ""If you can persuade Ms. Graf to restructure the forces to integrate us through a separate division...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Remus Holstron**
> ""The security situation will quickly improve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Consider it done. Prove your worth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Come to think of it, maybe this isn't the best idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Remus Holstron**
> ""Oh? Okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[53]`
Mówca: **Remus Holstron**
> ""We can surely help with that, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Remus Holstron**
> ""You can count on the Young Sords to *protect* the ballots and the integrity of the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Remus Holstron**
> ""But we may ask you to transfer some funds to us in the future to be able to organize efficiently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Understood. Just tell me whenever you need the money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Come to think of it, maybe this isn't the best idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[58]`
Mówca: **Remus Holstron**
> ""Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Remus Holstron**
> ""You'll see the results whenever they're ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Remus Holstron**
> ""It was nice catching up with you, Mr. President. Take care.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[61]`
Mówca: **Remus Holstron**
> ""Is there anything else you need?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[18]`
