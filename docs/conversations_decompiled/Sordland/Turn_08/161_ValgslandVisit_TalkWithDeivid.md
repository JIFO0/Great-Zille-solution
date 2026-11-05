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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"“Comrade Hegel.”"** | `[29]` **Narrator**: "Assistants took my belongings an..." | `Variable["BaseGame.Archetype_ComradeRayne"] == true` | *Brak zmian stanu* | `[33]` **Narrator**: "He turned around. He was a man o..." |
| `[9]` | **"“Good idea.”"** | `[5]` **Deivid Wisci**: "“I recommend you do the same.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Deivid Wisci**: "“Have a good night.”" |
| `[10]` | **"“I will stay a little longer.”"** | `[5]` **Deivid Wisci**: "“I recommend you do the same.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Deivid Wisci**: "“Very well. Good night.”" |
| `[19]` | **"Silently watch the horizon."** | `[44]` **Deivid Wisci**: "“That includes the choices we *c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Deivid Wisci**: "“I must go and try to sleep, Mr...." |
| `[24]` | **"“I could say the same thing about you.”"** | `[15]` **Deivid Wisci**: "“Mr. President. I am surprised y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Deivid Wisci**: "“Good point.”" |
| `[26]` | **"“I said it's nothing.”"** | `[8]` **Deivid Wisci**: "“It is sometimes good to air out..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Deivid Wisci**: "“Very well.”" |
| `[31]` | **"Clear your throat."** | `[29]` **Narrator**: "Assistants took my belongings an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "He turned around. He was a man o..." |
| `[34]` | **"“Are you also worried about the future all the time?”"** | `[8]` **Deivid Wisci**: "“It is sometimes good to air out..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Deivid Wisci**: "“I'm an old man, Mr. President. ..." |
| `[36]` | **"“I like taking night walks.”"** | `[15]` **Deivid Wisci**: "“Mr. President. I am surprised y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Deivid Wisci**: "“Ah. One of my own.”" |
| `[42]` | **"“Chancellor Hegel.”"** | `[29]` **Narrator**: "Assistants took my belongings an..." | `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false` | *Brak zmian stanu* | `[33]` **Narrator**: "He turned around. He was a man o..." |
| `[45]` | **"“Thank you for your wisdom, Deivid.”"** | `[44]` **Deivid Wisci**: "“That includes the choices we *c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Deivid Wisci**: "“Anytime, Mr. President.”" |
| `[49]` | **"“I can't sleep.”"** | `[15]` **Deivid Wisci**: "“Mr. President. I am surprised y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Deivid Wisci**: "“Do you mind if I ask why?”" |
| `[52]` | **"“It's nothing. Don't worry about it.”"** | `[35]` **Deivid Wisci**: "“Do you mind if I ask why you ca..."<br>`[50]` **Deivid Wisci**: "“Do you mind if I ask why?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Deivid Wisci**: "“It is sometimes good to air out..." |
| `[53]` | **"“I do mind.”"** | `[35]` **Deivid Wisci**: "“Do you mind if I ask why you ca..."<br>`[50]` **Deivid Wisci**: "“Do you mind if I ask why?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Deivid Wisci**: "“Very well.”" |
| `[54]` | **"“Are you also worried about the future all the time?”"** | `[35]` **Deivid Wisci**: "“Do you mind if I ask why you ca..."<br>`[50]` **Deivid Wisci**: "“Do you mind if I ask why?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Deivid Wisci**: "“I'm an old man, Mr. President. ..." |
| `[55]` | **"“That doesn't help me at all.”"** | `[44]` **Deivid Wisci**: "“That includes the choices we *c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Deivid Wisci**: "“No, Mr. President.”" |

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
  - -> `[6]` (*Narrator: "Midnight was approaching as our delegation boarded SRS Ho..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Deivid Wisci: "“Very well. Good night.”"*)

### Węzeł `[3]`
**[WYBÓR GRACZA: "“Comrade Hegel.”"]** — Mówca: **Player**
> "“Comrade Hegel.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "He turned around. He was a man of small stature with a ba..."*)

### Węzeł `[4]`
Mówca: **Deivid Wisci**
> "“It's chilly out here. I must go and try to get some sleep. I'm an old man, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Deivid Wisci: "“I recommend you do the same.”"*)

### Węzeł `[5]`
Mówca: **Deivid Wisci**
> "“I recommend you do the same.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "“Good idea.”"*)
  - -> `[10]` (*Player: "“I will stay a little longer.”"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Midnight was approaching as our delegation boarded SRS Holsord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "The large ship was once the royal yacht of King Egmund hi..."*)

### Węzeł `[7]`
Mówca: **Deivid Wisci**
> "“Very well. Good night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "I watched the sea for some more time before going back to..."*)

### Węzeł `[8]`
Mówca: **Deivid Wisci**
> "“It is sometimes good to air out one's thoughts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: "“I said it's nothing.”"*)
  - -> `[34]` (*Player: "“Are you also worried about the future all the time?”"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Good idea.”"]** — Mówca: **Player**
> "“Good idea.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Deivid Wisci: "“Have a good night.”"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“I will stay a little longer.”"]** — Mówca: **Player**
> "“I will stay a little longer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Deivid Wisci: "“Very well. Good night.”"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "We spent a couple of minutes watching the waves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Deivid Wisci: "“It's chilly out here. I must go and try to get some slee..."*)

### Węzeł `[12]`
Mówca: **Deivid Wisci**
> "“I must go and try to sleep, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Deivid Wisci: "“I recommend you do the same.”"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "The large ship was once the royal yacht of King Egmund himself. By the order of Soll, it was repurposed to serve the leaders of Sordland for state visits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("BoatPort");"*)

### Węzeł `[14]`
Mówca: **Deivid Wisci**
> "“Have a good night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I went back to my compartment to sleep."*)

### Węzeł `[15]`
Mówca: **Deivid Wisci**
> "“Mr. President. I am surprised you are still up this late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player: "“I can't sleep.”"*)
  - -> `[36]` (*Player: "“I like taking night walks.”"*)
  - -> `[24]` (*Player: "“I could say the same thing about you.”"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "I watched the sea for some more time before going back to my compartment to sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "The dawn arrived and our ship moored at the busy port of ..."*)

### Węzeł `[17]`
Mówca: **Narrator**
> "We departed from the port of Lachaven, along with a few other smaller escort boats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "I entered the luxurious compartments reserved for heads o..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "I went back to my compartment to sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "The dawn arrived and our ship moored at the busy port of ..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "Silently watch the horizon."]** — Mówca: **Player_Italic**
> "I silently watched the horizon."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Deivid Wisci: "“I must go and try to sleep, Mr. President.”"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "The dawn arrived and our ship moored at the busy port of Wilbern."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Amid the usual camera flashes, our convoy made its way to..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Amid the usual camera flashes, our convoy made its way to the train station."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "After a short, uneventful ride, we arrived at the central..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "I entered the luxurious compartments reserved for heads of state. I lay down on the bed to rest my eyes before we arrived at Wilbern, a major city in Valgsland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The Markian Sea was known for its treacherous waters, but..."*)

### Węzeł `[23]`
Mówca: **Deivid Wisci**
> "“Good point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Deivid Wisci: "“I used to feel that sleep was wasted time. Why spend one..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“I could say the same thing about you.”"]** — Mówca: **Player**
> "“I could say the same thing about you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Deivid Wisci: "“Good point.”"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "After a short, uneventful ride, we arrived at the central train station of Haelm, the capital city of Valgsland. A huge crowd was already there, awaiting my arrival. They swarmed around me and took photos as I stepped out of the train."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Our delegation met with various members of the Valgslandi..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I said it's nothing.”"]** — Mówca: **Player**
> "“I said it's nothing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Deivid Wisci: "“Very well.”"*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Our delegation met with various members of the Valgslandian cabinet before taking our cars to the Royal Palace. The flags of Valgsland and the CSP were waving next to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Assistants took my belongings and led me to the museum wi..."*)

### Węzeł `[28]`
Mówca: **Deivid Wisci**
> "“Anytime, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Deivid Wisci: "“It's chilly out here. I must go and try to get some slee..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "Assistants took my belongings and led me to the museum wing. It was there that I saw Chancellor Hegel. He was inspecting a very large painting on the wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[31]` (*Player_Italic: "Clear your throat."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "The Markian Sea was known for its treacherous waters, but tonight's trip promised to be rather calm and quiet. Still, I couldn't sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "I went out to the upper deck to have some fresh air. A li..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "Clear your throat."]** — Mówca: **Player_Italic**
> "I cleared my throat."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "He turned around. He was a man of small stature with a ba..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "I went out to the upper deck to have some fresh air. A light breeze was blowing, and I relished its briny smell. There was nobody here except Deivid."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "My foreign minister was leaning over a railing, gazing ou..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "He turned around. He was a man of small stature with a bald spot and a striking visage. His famous pipe was in his mouth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Are you also worried about the future all the time?”"]** — Mówca: **Player**
> "“Are you also worried about the future all the time?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Deivid Wisci: "“I'm an old man, Mr. President. I have been alive for ove..."*)

### Węzeł `[35]`
Mówca: **Deivid Wisci**
> "“Do you mind if I ask why you can't sleep?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: "“I do mind.”"*)
  - -> `[52]` (*Player: "“It's nothing. Don't worry about it.”"*)
  - -> `[54]` (*Player: "“Are you also worried about the future all the time?”"*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“I like taking night walks.”"]** — Mówca: **Player**
> "“I like taking night walks.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Deivid Wisci: "“Ah. One of my own.”"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: "“Comrade Hegel.”"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: "“Chancellor Hegel.”"*)

### Węzeł `[40]`
Mówca: **Deivid Wisci**
> "“As mankind, we are forever gullible. Always reaching out for what we don't have.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Deivid Wisci: "“That includes the choices we *could've* made, and their ..."*)

### Węzeł `[41]`
Mówca: **Deivid Wisci**
> "“I used to feel that sleep was wasted time. Why spend one-third of one's life in the dark?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Deivid Wisci: "“I rather appreciate it now. But there's still something ..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "“Chancellor Hegel.”"]** — Mówca: **Player**
> "“Chancellor Hegel.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "He turned around. He was a man of small stature with a ba..."*)

### Węzeł `[43]`
Mówca: **Deivid Wisci**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "We spent a couple of minutes watching the waves."*)

### Węzeł `[44]`
Mówca: **Deivid Wisci**
> "“That includes the choices we *could've* made, and their results which will never come to pass.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: "“Thank you for your wisdom, Deivid.”"*)
  - -> `[55]` (*Player: "“That doesn't help me at all.”"*)
  - -> `[19]` (*Player_Italic: "Silently watch the horizon."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Thank you for your wisdom, Deivid.”"]** — Mówca: **Player**
> "“Thank you for your wisdom, Deivid.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Deivid Wisci: "“Anytime, Mr. President.”"*)

### Węzeł `[46]`
Mówca: **Deivid Wisci**
> "“That is precisely why we must be strong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Deivid Wisci: "“It's chilly out here. I must go and try to get some slee..."*)

### Węzeł `[47]`
Mówca: **Deivid Wisci**
> "“There is no way out of it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Deivid Wisci: "“That is precisely why we must be strong.”"*)

### Węzeł `[48]`
Mówca: **Deivid Wisci**
> "“It doesn't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Deivid Wisci: "“There is no way out of it.”"*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "“I can't sleep.”"]** — Mówca: **Player**
> "“I can't sleep.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Deivid Wisci: "“Do you mind if I ask why?”"*)

### Węzeł `[50]`
Mówca: **Deivid Wisci**
> "“Do you mind if I ask why?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: "“I do mind.”"*)
  - -> `[52]` (*Player: "“It's nothing. Don't worry about it.”"*)
  - -> `[54]` (*Player: "“Are you also worried about the future all the time?”"*)

### Węzeł `[51]`
Mówca: **Deivid Wisci**
> "“Ah. One of my own.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Deivid Wisci: "“I used to feel that sleep was wasted time. Why spend one..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“It's nothing. Don't worry about it.”"]** — Mówca: **Player**
> "“It's nothing. Don't worry about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Deivid Wisci), `[50]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Deivid Wisci: "“It is sometimes good to air out one's thoughts.”"*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“I do mind.”"]** — Mówca: **Player**
> "“I do mind.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Deivid Wisci), `[50]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Deivid Wisci: "“Very well.”"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“Are you also worried about the future all the time?”"]** — Mówca: **Player**
> "“Are you also worried about the future all the time?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Deivid Wisci), `[50]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Deivid Wisci: "“I'm an old man, Mr. President. I have been alive for ove..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“That doesn't help me at all.”"]** — Mówca: **Player**
> "“That doesn't help me at all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Deivid Wisci: "“No, Mr. President.”"*)

### Węzeł `[56]`
Mówca: **Deivid Wisci**
> "“No, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Deivid Wisci: "“It doesn't.”"*)

### Węzeł `[57]`
Mówca: **Deivid Wisci**
> "“What I realized in time was that worrying is simply a part of life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Deivid Wisci: "“As mankind, we are forever gullible. Always reaching out..."*)

### Węzeł `[58]`
Mówca: **Deivid Wisci**
> "“I'm an old man, Mr. President. I have been alive for over seventy years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Deivid Wisci: "“I spent most of those years worrying about various thing..."*)

### Węzeł `[59]`
Mówca: **Deivid Wisci**
> "“I spent most of those years worrying about various things. Endlessly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Deivid Wisci: "“What I realized in time was that worrying is simply a pa..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "My foreign minister was leaning over a railing, gazing out at the inky waves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Deivid Wisci: "“Mr. President. I am surprised you are still up this late.”"*)

### Węzeł `[61]`
Mówca: **Deivid Wisci**
> "“I rather appreciate it now. But there's still something special about being awake while the rest of the world has its eyes closed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Deivid Wisci: "“Do you mind if I ask why you can't sleep?”"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("BoatPort");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("BoatPort");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Narrator: "We departed from the port of Lachaven, along with a few o..."*)
