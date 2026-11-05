# Sordland/Turn10/NOTES

- **ID konwersacji:** `241`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/241_NOTES.md`
- **Liczba węzłów dialogowych:** 6
- **Liczba wyborów gracza:** 0

---

## 1. Uczestnicy Sceny

- *Brak bezpośrednich wypowiedzi dialogowych (scena techniczna lub logiki).*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Turn09_Military_WeakAgainstRumburg`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.RumburgWar_Performance`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

- *Brak decyzji i wyborów gracza w tej scenie (dialog liniowy lub sekwencja techniczna).*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == false"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == false)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgWar_Performance += 1;"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgWar_Performance += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RumburgWar_Performance"] = Variable["BaseGame.RumburgWar_Performance"] + 1;`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
