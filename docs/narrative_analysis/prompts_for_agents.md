# Prompty dla Agentów: Ekstrakcja i Analiza Drzewek Dialogowych Suzerain

Ten dokument zawiera gotowe prompty do zlecania zadań subagentom (lub innym modelom/agentom) w celu głębokiej analizy drzew dialogowych, badania zależności politycznych oraz projektowania nowych ścieżek narracyjnych dla moda **Great Zille Solution**.

---

## Źródła danych w projekcie (dla agenta wykonawczego)

Każdy agent pracujący nad danymi gry ma dostęp do:
1. **Binarnego katalogu gry:** `H:\SteamLibrary\steamapps\common\Suzerain\Suzerain_Data\StreamingAssets\aa\StandaloneWindows64\`
   - `database_assets_all_2c5c6df453acd4d096b216389ddafa9b.bundle` — baza PixelCrushers Dialogue System (521 konwersacji, 103 aktorów, 12 828 zmiennych Lua). Teksty dialogowe znajdują się w polu `en`!
   - `defaultlocalgroup_assets_assets_database_entitytextassets.asset_ec95223fa5819b4eb4d612c0ee4914b6.bundle` — `_GameFlow` (11 tur, kroki, fragmenty), `ConversationData`, `DecisionData`, `MapTokenData`.
2. **Gotowych wyekstrahowanych plików w projekcie:**
   - `docs/narrative_analysis/game_flow_tree.md` / `game_flow_tree.json` — pełne drzewo sekwencji gry tura po turze.
   - `docs/narrative_analysis/conversations_catalog.json` — indeks 521 konwersacji (kto mówi, ile wpisów, jakie zmienne modyfikuje).
   - `docs/narrative_analysis/zille_timeline_and_dependencies.md` — chronologia wszystkich eventów związanych z Zille i Wehlen.
   - `docs/narrative_analysis/character_styles/` — 16 dedykowanych przewodników stylu wypowiedzi postaci z dosłownymi cytatami.

---

## Prompt 1: Ekstrakcja i Dekompozycja Konkretnego Drzewka Dialogowego (Deep-Dive)

> **Zastosowanie:** Gdy chcesz, aby agent wziął jedną lub kilka konkretnych rozmów (np. `Rizia/Turn 5/FPnT_WehlenNegotiations` lub `Rizia/Turn 8/FPnT_ZilleNegotiations`) i rozpisał ją na pełne drzewo decyzyjne z warunkami i wyborami gracza.

```markdown
Jesteś analitykiem systemów narracyjnych dla gry Suzerain (silnik Unity, PixelCrushers Dialogue System).
Twoim zadaniem jest pełna dekompozycja drzewa dialogowego dla wybranej konwersacji:
Target: "{CONVERSATION_TITLE}" (np. "Rizia/Turn 5/FPnT_WehlenNegotiations")

Dane wejściowe:
- Skrypt w projekcie: `tools/export_dialogues.py`
- Baza bundle: `H:\SteamLibrary\steamapps\common\Suzerain\Suzerain_Data\StreamingAssets\aa\StandaloneWindows64\database_assets_all_2c5c6df453acd4d096b216389ddafa9b.bundle`
- Pole tekstu: `en` (fallback: `Dialogue Text`)

Wymagania dla wyniku:
1. Drzewo przepływu (Flowchart / Mermaid lub ustrukturyzowany Markdown):
   - Wskaż stan początkowy (START, wpis 0/1).
   - Dla każdej kwestii podaj Aktora (kto mówi), tekst `en`, warunki widoczności (`conditionsString`) oraz skrypty wyzwalane (`userScript`).
2. Rozgałęzienia decyzyjne gracza (Menu Text / Player Choice):
   - Wylistuj wszystkie momenty, w których Romus podejmuje decyzję.
   - Jakie są konsekwencje każdego wyboru (jakie flagi `Variable["..."]` zostają ustawione)?
3. Kluczowe punkty zwrotne (Breakpoints):
   - Co sprawia, że rozmowa kończy się sukcesem, a co zerwaniem negocjacji?
   - Jakie zmienne ze wcześniejszych tur są sprawdzane (np. zachowanie na Friendship Day, postawa wobec Su Omina, śledztwo w sprawie zamachu)?
4. Raport zapisz w `docs/narrative_analysis/deep_dives/{nazwa_rozmowy}.md`.
```

---

## Prompt 2: Analiza Stylu i Generowanie Repliki dla Nowego Wydarzenia (Dialogue Stylist)

> **Zastosowanie:** Gdy piszemy nowy dialog (np. nową opcję dealu o Zille z Wiktorem Smolakiem, kłótnię w Radzie Królewskiej między Lucitą a Hugo, czy przesłuchanie zamachowców).

```markdown
Jesteś głównym scenarzystą gry Suzerain: Kingdom of Rizia, wyspecjalizowanym w dialogach politycznych i dworskich.
Twoim celem jest napisanie lub audyt sceny dialogowej dla postaci: {POSTACIE} (np. King Romus, Wiktor Smolak, Hugo Toras, Lucita Azaro).

Kontekst sceny:
{OPIS SYTUACJI, NP. NOWA PROPOZYCJA DEALU O ZILLE W TURZE 5 LUB 8}

Wytyczne stylistyczne:
1. Bazuj wyłącznie na autentycznych wzorcach z plików stylu w `docs/narrative_analysis/character_styles/`:
   - Sprawdź dokładną formę zwracania się do Romusa (np. Wiktor Smolak: "Your Majesty", "Romus", "my friend"; Hugo: "Your Majesty", "Romus" w cztery oczy; Lucita: "Your Majesty", a jeśli małżeństwo: "My King—and my husband").
   - Zachowaj charakterystyczne manieryzmy (Smolak: rubaszny humor, udawana prostoduszność maskująca groźby; Hugo: arystokratyczny chłód, cyniczny pragmatyzm i troska o Dom Toras; Lucita: żołnierska dyscyplina, duma Domu Azaro, pogarda dla słabości).
2. Format wpisów zgodny z PixelCrushers Dialogue System:
   - Każda linijka musi mieć: Mówcę (Actor), Tekst (`en`), ewentualne `conditionsString` oraz `userScript` (modyfikacja zmiennych).
   - Opcje gracza (`Player_Romus`, ID 95) muszą mieć krótki `Menu Text` (widoczny na przycisku) oraz pełny wypowiadany `Dialogue Text` (`en`).
3. Brak "sztucznych liczb": Postacie w dialogu nigdy nie mówią "+2 Budget" ani "poparcie spadło o 1". Mówią językiem politycznym, fiskalnym i militarnym ("nasz skarbiec ledwo to udźwignie", "Azaro nie wybaczą nam tego ustępstwa").
```

---

## Prompt 3: Ranking i Klasyfikacja Wpływu Dialogów na Sprawę Zille (Relevance Sieve)

> **Zastosowanie:** Przegląd wszystkich 229 rozmów Rizia i posegregowanie ich według stopnia powiązania z odzyskaniem Zille.

```markdown
Jesteś analitykiem bazy danych Suzerain.
Mamy wyindeksowane 229 konwersacji Rizia w `docs/narrative_analysis/conversations_catalog.json` oraz sekwencję w `docs/narrative_analysis/zille_timeline_and_dependencies.md`.

Twoje zadanie:
1. Przeanalizuj wszystkie konwersacje i zaklasyfikuj je do jednej z 4 kategorii:
   - Kategoria A (Kluczowe dla Zille): Bezpośrednio negocjuje, przygotowuje lub rozstrzyga los Zille (Smolak, ATA, Su Omina, śledztwo bombowe, Wehlen trade).
   - Kategoria B (Pośrednie dla Zille): Wpływa na siłę militarną, budżet, relacje z Derdią/Morellą/Lespią lub stabilność wewnętrzną, co zmienia warunki brzegowe negocjacji.
   - Kategoria C (Tło polityczne / Domowe): Sprawy dynastyczne (Vina, małżeństwa, reformy), które nie wpływają bezpośrednio na Wehlen.
   - Kategoria D (Niezależne): Pales War (jeśli izolowana ścieżka), religijne ceremonie niemające wpływu na Zille.
2. Dla każdej rozmowy z Kategorii A wskaż dokładne zmienne stanu (`Variable["RiziaDLC..."]`), które decydują o wyniku.
3. Wygeneruj przejrzystą tabelę podsumowującą w `docs/narrative_analysis/zille_relevance_matrix.md`.
```
