# Sordland/Turn08/ValgslandVisit_TalkWithDeivid

- **ID konwersacji:** `161`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/161_ValgslandVisit_TalkWithDeivid.md`
- **Liczba węzłów dialogowych:** 63
- **Liczba wyborów gracza:** 16

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[160] Sordland/Turn08/FPnT_ValgslandVisit** (../Turn_08/160_FPnT_ValgslandVisit.md), Węzeł `[7]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 1

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[62]` (Paskal Beniwoll): `PlaySoundEffect("BoatPort");`

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
  - -> `[6]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `160` (*Sordland/Turn08/FPnT_ValgslandVisit*), Węzeł `[7]`

### Węzeł `[3]`
**[WYBÓR GRACZA: "“Comrade Hegel.”"]** — Mówca: **Player**
> "“Comrade Hegel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[4]`
Mówca: **Deivid Wisci**
> "“It's chilly out here. I must go and try to get some sleep. I'm an old man, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Deivid Wisci**
> "“I recommend you do the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Midnight was approaching as our delegation boarded SRS Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[7]`
Mówca: **Deivid Wisci**
> "“Very well. Good night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[8]`
Mówca: **Deivid Wisci**
> "“It is sometimes good to air out one's thoughts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[34]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Good idea.”"]** — Mówca: **Player**
> "“Good idea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I will stay a little longer.”"]** — Mówca: **Player**
> "“I will stay a little longer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[11]`
Mówca: **Narrator**
> "We spent a couple of minutes watching the waves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[12]`
Mówca: **Deivid Wisci**
> "“I must go and try to sleep, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[13]`
Mówca: **Narrator**
> "The large ship was once the royal yacht of King Egmund himself. By the order of Soll, it was repurposed to serve the leaders of Sordland for state visits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[14]`
Mówca: **Deivid Wisci**
> "“Have a good night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
Mówca: **Deivid Wisci**
> "“Mr. President. I am surprised you are still up this late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[36]`
  - -> `[24]`

### Węzeł `[16]`
Mówca: **Narrator**
> "I watched the sea for some more time before going back to my compartment to sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
Mówca: **Narrator**
> "We departed from the port of Lachaven, along with a few other smaller escort boats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[18]`
Mówca: **Narrator**
> "I went back to my compartment to sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "Silently watch the horizon."]** — Mówca: **Player_Italic**
> "I silently watched the horizon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[20]`
Mówca: **Narrator**
> "The dawn arrived and our ship moored at the busy port of Wilbern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Amid the usual camera flashes, our convoy made its way to the train station."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[22]`
Mówca: **Narrator**
> "I entered the luxurious compartments reserved for heads of state. I lay down on the bed to rest my eyes before we arrived at Wilbern, a major city in Valgsland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[23]`
Mówca: **Deivid Wisci**
> "“Good point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“I could say the same thing about you.”"]** — Mówca: **Player**
> "“I could say the same thing about you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[25]`
Mówca: **Narrator**
> "After a short, uneventful ride, we arrived at the central train station of Haelm, the capital city of Valgsland. A huge crowd was already there, awaiting my arrival. They swarmed around me and took photos as I stepped out of the train."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I said it's nothing.”"]** — Mówca: **Player**
> "“I said it's nothing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[27]`
Mówca: **Narrator**
> "Our delegation met with various members of the Valgslandian cabinet before taking our cars to the Royal Palace. The flags of Valgsland and the CSP were waving next to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Deivid Wisci**
> "“Anytime, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[29]`
Mówca: **Narrator**
> "Assistants took my belongings and led me to the museum wing. It was there that I saw Chancellor Hegel. He was inspecting a very large painting on the wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`
  - -> `[31]`

### Węzeł `[30]`
Mówca: **Narrator**
> "The Markian Sea was known for its treacherous waters, but tonight's trip promised to be rather calm and quiet. Still, I couldn't sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "Clear your throat."]** — Mówca: **Player_Italic**
> "I cleared my throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Narrator**
> "I went out to the upper deck to have some fresh air. A light breeze was blowing, and I relished its briny smell. There was nobody here except Deivid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[33]`
Mówca: **Narrator**
> "He turned around. He was a man of small stature with a bald spot and a striking visage. His famous pipe was in his mouth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Are you also worried about the future all the time?”"]** — Mówca: **Player**
> "“Are you also worried about the future all the time?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[35]`
Mówca: **Deivid Wisci**
> "“Do you mind if I ask why you can't sleep?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`
  - -> `[54]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“I like taking night walks.”"]** — Mówca: **Player**
> "“I like taking night walks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Archetype_ComradeRayne == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Archetype_ComradeRayne == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
Mówca: **Deivid Wisci**
> "“As mankind, we are forever gullible. Always reaching out for what we don't have.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[41]`
Mówca: **Deivid Wisci**
> "“I used to feel that sleep was wasted time. Why spend one-third of one's life in the dark?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“Chancellor Hegel.”"]** — Mówca: **Player**
> "“Chancellor Hegel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[43]`
Mówca: **Deivid Wisci**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[44]`
Mówca: **Deivid Wisci**
> "“That includes the choices we *could've* made, and their results which will never come to pass.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`
  - -> `[55]`
  - -> `[19]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Thank you for your wisdom, Deivid.”"]** — Mówca: **Player**
> "“Thank you for your wisdom, Deivid.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[46]`
Mówca: **Deivid Wisci**
> "“That is precisely why we must be strong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[47]`
Mówca: **Deivid Wisci**
> "“There is no way out of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[48]`
Mówca: **Deivid Wisci**
> "“It doesn't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“I can't sleep.”"]** — Mówca: **Player**
> "“I can't sleep.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Deivid Wisci**
> "“Do you mind if I ask why?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[52]`
  - -> `[54]`

### Węzeł `[51]`
Mówca: **Deivid Wisci**
> "“Ah. One of my own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "“It's nothing. Don't worry about it.”"]** — Mówca: **Player**
> "“It's nothing. Don't worry about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“I do mind.”"]** — Mówca: **Player**
> "“I do mind.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“Are you also worried about the future all the time?”"]** — Mówca: **Player**
> "“Are you also worried about the future all the time?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[55]`
**[WYBÓR GRACZA: "“That doesn't help me at all.”"]** — Mówca: **Player**
> "“That doesn't help me at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Deivid Wisci**
> "“No, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[57]`
Mówca: **Deivid Wisci**
> "“What I realized in time was that worrying is simply a part of life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[58]`
Mówca: **Deivid Wisci**
> "“I'm an old man, Mr. President. I have been alive for over seventy years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Deivid Wisci**
> "“I spent most of those years worrying about various things. Endlessly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[60]`
Mówca: **Narrator**
> "My foreign minister was leaning over a railing, gazing out at the inky waves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[61]`
Mówca: **Deivid Wisci**
> "“I rather appreciate it now. But there's still something special about being awake while the rest of the world has its eyes closed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("BoatPort");)*
- **Efekt (`userScript`):** `PlaySoundEffect("BoatPort");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
