# PROMPT DLA AI: PEŁNA DEKOMPILACJA WSZYSTKICH KONWERSACJI GRY SUZERAIN

> **Instrukcja użycia:** Skopiuj poniższy blok promptu i wklej go do nowego agenta (np. nowego okna Antigravity, subagenta lub innego zaawansowanego modelu LLM z dostępem do narzędzi/terminala). Prompt zawiera wszystkie parametry techniczne, ścieżki, architekturę danych oraz strategię przetwarzania ponad 200 000 węzłów dialogowych.

---

```markdown
Jesteś elitarnym inżynierem inżynierii wstecznej (Reverse Engineering) oraz architektem narracyjnych baz danych w silniku Unity.
Twoim zadaniem jest **całkowita dekompilacja WSZYSTKICH 521 konwersacji** z gry Suzerain (zarówno kampanii podstawowej Sordland, jak i dodatku Kingdom of Rizia) do czytelnych, ustrukturyzowanych plików drzewek dialogowych na dysku, przygotowanych do dalszej analizy politycznej i fabularnej.

---

### 1. ŚRODOWISKO I ŹRÓDŁA DANYCH

- Środowisko: Windows / PowerShell / Python 3 z zainstalowaną biblioteką `UnityPy`.
- Ścieżka instalacji gry: `H:\SteamLibrary\steamapps\common\Suzerain`
- Pakiety AssetBundle z danymi gry:
  1. Baza dialogowa PixelCrushers:
     `H:\SteamLibrary\steamapps\common\Suzerain\Suzerain_Data\StreamingAssets\aa\StandaloneWindows64\database_assets_all_2c5c6df453acd4d096b216389ddafa9b.bundle`
  2. Baza zdarzeń i GameFlow:
     `H:\SteamLibrary\steamapps\common\Suzerain\Suzerain_Data\StreamingAssets\aa\StandaloneWindows64\defaultlocalgroup_assets_assets_database_entitytextassets.asset_ec95223fa5819b4eb4d612c0ee4914b6.bundle`
- Katalog wyjściowy projektu: `C:\Projects\Great Zille solution\docs\conversations_decompiled\`

---

### 2. SPECYFIKACJA TECHNICZNA SILNIKA DIALOGOWEGO

Baza gry opiera się na **PixelCrushers Dialogue System** wyeksportowanym z **Articy:Draft 4.1.2**:
1. **Skala danych:**
   - 521 konwersacji (229 Rizia + 292 Sordland).
   - Łącznie **201 686 węzłów dialogowych (`dialogueEntries`)**.
   - 103 zarejestrowanych Aktorów (`actors`).
   - 12 828 zmiennych stanu (`variables`).
2. **Kluczowe pułapki struktury (CRITICAL):**
   - **Tekst kwestii:** Pole `Dialogue Text` w węzłach jest niemal zawsze PUSTE. Rzeczywisty tekst w języku angielskim znajduje się w polu `en` wewnątrz listy `fields` danego wpisu!
   - **Wybory gracza:** Wpisy wypowiadane przez gracza (ID 5: `Player` w Sordlandzie lub ID 95: `Player_Romus` w Rizia) zawierają `Menu Text` (tekst widoczny na przycisku decyzji) oraz `en` (pełna kwestia wypowiadana na głos).
   - **Graf powiązań:** Każdy wpis zawiera listę `outgoingLinks` w formacie:
     `{"originConversationID": int, "originDialogueID": int, "destinationConversationID": int, "destinationDialogueID": int, "isConnector": int, "priority": int}`.
   - **Warunki i Skrypty:**
     - `conditionsString` — kod Lua sprawdzający zmienne (np. `Variable["RiziaDLC.Zille_Deal_..."] == true`).
     - `userScript` — kod Lua modyfikujący stan gry po przejściu węzła (np. `Variable["RiziaDLC.Resources_Budget"] = Variable[...] + 2;`).

---

### 3. STRATEGIA WYKONANIA (AUTOMATYZACJA WSADOWA)

Z uwagi na skalę (ponad 200 tysięcy wpisów), **BEZWZGLĘDNIE NIE PRÓBUJ** wczytywać całości tekstu do kontekstu LLM ani wypisywać go w oknie czatu.
Twoim zadaniem jest **napisać i uruchomić zoptymalizowany skrypt w Pythonie**, który przetworzy bazę danych bezpośrednio z bundle za pomocą `UnityPy` i wygeneruje uporządkowaną strukturę plików na dysku.

Struktura katalogów wyjściowych:
```
docs/conversations_decompiled/
  ├── INDEX.md (oraz index.json) -> spis wszystkich rozmów z metadanymi
  ├── Rizia/
  │     ├── Turn_01/
  │     ├── ...
  │     └── Turn_11/
  └── Sordland/
        ├── Turn_01/
        ├── ...
        └── Turn_11/
```

---

### 4. WYMAGANY FORMAT POJEDYNCZEGO PLIKU DEKOMPILACJI (.md)

Dla każdej z 521 konwersacji utwórz czytelny plik Markdown (oraz opcjonalnie plik `.json` z surowym grafem).
Plik Markdown musi zawierać:

1. **Nagłówek i Metadane:**
   - Tytuł konwersacji, ID w bazie, StoryPack (Rizia / Sordland), Tura.
   - Uczestnicy rozmowy (Aktorzy występujący w scenie).
   - Lista zmiennych Lua czytanych (`conditionsString`) i modyfikowanych (`userScript`).
2. **Struktura Grafu (Drzewo Węzłów):**
   - Punkt wejścia (START / Entry 0 / Entry 1).
   - Dla każdego węzła:
     - `[Entry ID]` **Mówca (Imię i Nazwisko)**: Treść wypowiedzi (z pola `en`).
     - Jeśli to wybór gracza: Wyraźnie oznaczony blok `[WYBÓR GRACZA: "Menu Text"]`.
     - Warunek (`Condition`): kod Lua, jeśli występuje.
     - Efekt (`Script`): modyfikacja zmiennych Lua, jeśli występuje.
     - Połączenia wychodzące (`Links to`): lista docelowych ID wpisów.
   - Oznaczenie skoków między-konwersacyjnych (jeśli `destinationConversationID != obecneID`).
3. **Wnioski i Kluczowe Odgałęzienia:**
   - Podsumowanie możliwych zakończeń sceny (sukces, porażka, zerwanie negocjacji, śmierć postaci, modyfikacja kluczowych statystyk).

---

### 5. KRYTERIA SUKCESU (DEFINITION OF DONE)

1. **100% Pokrycia:** Wszystkie 521 rozmów przetworzone bez pominięcia żadnego węzła.
2. **Poprawne mapowanie mówców:** ID aktorów zastąpione rzeczywistymi imionami (np. 10 -> Narrator, 95 -> Player_Romus, 17/77 -> Wiktor Smolak, 73 -> Lucita Azaro, 68 -> Hugo Toras).
3. **Prawidłowy tekst:** Żadnych pustych linijek z powodu pola `Dialogue Text` — pełne pobranie z pola lokalizacji `en`.
4. **Indeks nadrzędny:** `docs/conversations_decompiled/INDEX.md` umożliwiający natychmiastowe wyszukiwanie rozmów po postaciach, turach i słowach kluczowych (np. "Zille", "Smolak", "Wehlen", "War", "Gas field").

Zacznij od przygotowania i przetestowania skryptu dekompilującego na próbce, a następnie uruchom pełną ekstrakcję na całości bazy.
```
