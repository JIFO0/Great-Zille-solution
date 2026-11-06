# Projekt: Great Zille Solution — Specyfikacja Projektowa i Fabularna (v0.3.0)

## 1. Założenia Główne

Mod wprowadza alternatywną, militarną ścieżkę rozwiązania kryzysu Zille w kampanii Rizia (DLC do gry Suzerain).
Gracz od samego początku panowania Romulusa (Tura 1) otrzymuje możliwość rozważenia i forsowania opcji siłowej wobec Wiktora Smolaka, co spotyka się z dynamiczną ewolucją nastrojów na Dworze Królewskim, wpływa na światowe sojusze geopolityczne oraz otwiera pełnoprawny teatr wojenny.

---

## 2. Zweryfikowana Chronologia Gry (Z bazy danych gry Suzerain)

Wszystkie momenty narracyjne i identyfikatory konwersacji zostały wyciągnięte bezpośrednio z bazy dialogowej gry (`database_assets_all`):

### Tura 1: Koronacja i Pierwsze Narady Sztabowe
- **Identyfikatory w silniku:**
  - `Rizia/Turn 1/SnO_SecurityMilitaryMeeting` (Spotkanie bezpieczeństwa z Lucitą Azaro, Titusem Grizem i Hugo Torasem)
  - `Rizia/Turn 1/EnT_CouncilBriefing`
- **Wstrzykiwana opcja:**
  > `[MOD] "Let me be unequivocal with my council: We will recover Zille, even if it requires force of arms."`
- **Reakcja doradców:**
  - **Hugo:** Ostrzega, że umowa króla Valero z Wehlen jest traktatem międzynarodowym, a AN natychmiast nałoży sankcje.
  - **Lucita:** Zwraca uwagę na odbudowę armii po kryzysie i zagrożenie prowokacjami ze strony Księstwa Pales na północy.
  - **Titus:** Ostrzega przed komórkami dywersyjnymi Wehlen w stolicy i na granicy Brenas.

### Tura 2: Narada Dyplomatyczna i Dzień Przyjaźni w Zille
- **Identyfikatory w silniku:**
  1. `Rizia/Turn 2/FPnT_DiplomacyBriefing` (Debata Rady Królewskiej o sytuacji międzynarodowej przed podróżą)
     - **Wstrzykiwana opcja:**
       > `[MOD] "Regarding Wehlen: I want the General Staff to draft a preemptive operational invasion plan for Zille before I meet Smolak."`
     - **Skutek:** Lucita w tajemnicy zleca oficerom rodu Azaro wstępne rozpoznanie podejść południowych. Hugo zarzuca Romusowi szaleństwo mogące zniszczyć delegację.
  2. `Rizia/Turn 2/FPnT_ZilleVisit` (Obchody Dnia Przyjaźni w Zille z Wiktorem Smolakiem)
     - **Wstrzykiwana opcja:**
       > `[MOD] "Smolak's insulting jokes and outrageous demands will not stand. Rizia's patience has limits, Wiktor."`
     - **Skutek:** Ostra wymiana zdań ze Smolakiem tuż przed zamachem bombowym.

### Tura 3: Zamach w Zille i Decyzja Kryzysowa
- **Identyfikator w silniku:**
  - `Rizia/Turn 3/SnO_ZilleSecurityDebrief` (Narada Rady Bezpieczeństwa po eksplozji na trybunie w Zille)
- **Dwie wstrzykiwane opcje:**
  1. **Opcja A (Kalkulowana Mobilizacja):**
     > `[MOD] "This bombing is Smolak's blatant false-flag. I declare heightened combat readiness along the Brenas border!"`
     - Sprawdzenie stanu dwóch frontów (`IsTwoFrontWarThreat`). Jeśli gracz szykuje się na Pales — panika doradców. Jeśli nie — Południowe Dowództwo obsadza wzgórza Brenas.
  2. **Opcja B (Samobójcza / Natychmiastowa Wojna — "Głupia opcja"):**
     > `[MOD] [SUICIDAL] "Enough talk! Order the Third and Fourth Corps across the border immediately! We take Zille by force TODAY!"`
     - **Natychmiastowa katastrofa militarna:** Wojska bez zaopatrzenia wpadają w zasadzkę Wehlen. Smolak dokonuje przełamania, prowincja Brenas zostaje anektowana przez Wehlen, a Królowa Matka Estela zostaje schwytana i stracona.

### Tura 4 & 8: Tajny Pakt z Patricio Alvarezem (Lespia)
- **Identyfikatory w silniku:** `Rizia/Turn 4/FPnT_AlvarezCall` oraz `Rizia/Turn 8/FPnT_AlvarezVisit`
- **Wybór:**
  - `Lespia_Pact_Accept`: Zobowiązanie do nieatakowania Pales. W zamian Lespia i Arcasia dostarczają dane satelitarne, ciężką amunicję i znoszą koszty energetyczne.
  - `Lespia_Pact_Refuse`: Odmowa jałmużny Lespii.

### Tura 5: Bezpośrednie Negocjacje z Wehlen
- **Identyfikator w silniku:** `Rizia/Turn 5/FPnT_WehlenNegotiations`
- **Opcja:** Otwarta presja artyleryjska na Smolaka przy stole negocjacyjnym.

### Tura 7: Wsparcie Derdii (Azmal)
- **Identyfikatory w silniku:** `Rizia/Turn 7/FPnT_DerdiaNegotiations` oraz `Rizia/Turn 7/Zille Treaty Discussion`
- **Opcja:** Porozumienie z Azmalem — przerzut nuryckich bojowników na tyły Wehlen w celu dywersji w rafineriach ropy.

### Tura 8: Ostateczny Rozłam i Wybuch Wojny
- **Identyfikatory w silniku:** `Rizia/Turn 8/FPnT_ZilleNegotiations`, `SnO_SecurityBriefAndZille`, `Zille Territory Issue`
- **Wybór Doktryny Wojennej:**
  - **Plan Alfa:** Bezpośredni szturm frontalny na miasto Zille.
  - **Plan Beta:** Manewr oskrzydlający przez hub logistyczny Wiktrany i uderzenie na port Munat.

---

## 3. Teatr Działań Wojennych — Architektura 4 Miast

Planowana siatka taktyczna Zille opiera się na 4 kluczowych punktach miejskich wykorzystujących prefaby i systemy walki z Pales:

1. **Zille (Stolica, Zachód Półwyspu):**
   - Główna baza wojskowa i administracyjna Smolaka. Silnie ufortyfikowana, osłonięta instalacjami naftowymi.
2. **Nanta (Wschód Półwyspu):**
   - Wschodnie skrzydło osłaniające Zille, rejon posterunków granicznych i magazynów paliw.
3. **Wiktrany (Środek Półwyspu):**
   - Centralny węzeł komunikacyjny i hub zaopatrzeniowy łączący północ z południem. Klucz do odcięcia garnizonu Zille.
4. **Munat (Północ Półwyspu):**
   - Głęboki port morski, przez który Wehlen otrzymuje dostawy i posiłki. Cel desantu lub blokady morskiej.

---

## 4. Scenariusze Zakończenia Wojny i Traktaty Pokojowe (5 Stanów)

Wynik końcowy kampanii wojennej o Zille zależy od kontroli nad kluczowymi ośrodkami miejskimi (miasta startowe Rizii w Brenas: Marbelas, Dapalle, Mave Nortus oraz miasta pod kontrolą Wehlen na półwyspie: Zille, Wiktrany, Munat, Nanta):

1. **Scenariusz 1: Total Fiasco (Katastrofalna Klęska):**
   - Wehlen przełamuje obronę i okupuje 3 miasta w prowincji Brenas (Marbelas, Dapalle, Mave Nortus).
   - Smolak dyktuje warunki kapitulacji bez negocjacji. Gwarantowany pucz wojskowy lub detronizacja.

2. **Scenariusz 2: Tactical Defeat (Porażka Operacyjna / Raczej Porażka):**
   - **Warunek A (Brak zdobyczy / Status Quo):** Wszystkie startowe miasta Rizii (Brenas) pozostają pod kontrolą Rizii, a wszystkie miasta Wehlen (Zille) pozostają pod kontrolą Wehlen. Mimo braku strat terytorialnych operacja odzyskania Zille kończy się politycznym i strategicznym fiaskiem — Rizia poniosła ogromne koszty i ofiary, nie osiągając celu wojennego.
   - **Warunek B (Utrata pozycji):** Strata 1 miasta w Brenas bez zrównoważenia zdobyczami w Zille.
   - **Skutek:** Wymuszone trudne negocjacje: Wehlen żąda reparacji lub koncesji, Rizia musi zrzec się roszczeń do Zille pod groźbą załamania wewnętrznego i buntu w Brenas.

3. **Scenariusz 3: Bloody Stalemate (Zwykły PAT / Impas):**
   - **Warunek A (Wymiana terytorialna):** Rizia traci jedno ze swoich startowych miast w Brenas, ale zajmuje 1 lub 2 miasta pod kontrolą Wehlen (np. Wiktrany i Nantę lub port Munat).
   - **Warunek B (Częściowy sukces):** Zdobycie części półwyspu bez pełnej kontroli nad stolicą Zille przy utrzymaniu własnych miast.
   - **Specjalna ścieżka negocjacyjna (Niepodległość Zille):**
     - W wariancie PAT gracz przy stole negocjacyjnym nie musi godzić się na powrót Zille pod but Smolaka.
     - **Można wynegocjować pełną niepodległość Zille** (jako neutralnego państwa buforowego), pod warunkiem **poczynienia drobnych koncesji na rzecz Wehlen** (np. preferencyjne umowy naftowo-handlowe, gwarancje tranzytowe lub częściowe rekompensaty finansowe dla Smolaka).

4. **Scenariusz 4: Decisive Victory (Czyste Zwycięstwo):**
   - Pełne wyzwolenie wszystkich 4 miast półwyspu Zille (Zille, Munat, Wiktrany, Nanta) przy zachowaniu miast Brenas.
   - Natychmiastowa reaneksja Zille do Korony Rizii na mocy traktatu pokojowego bez konieczności czekania na referendum AN.

5. **Scenariusz 5: Overwhelming Triumph (Totalny Triumf):**
   - Pełna kontrola nad Zille oraz rajd / zajęcie strategicznych celów w głębi Wehlen (np. Port Rotsla).
   - Wehlen płaci potężne reparacje wojenne, a region graniczny/Grodzizg zyskuje status wolnego miasta / protektoratu.

---

## 5. UI i Diagnostyka w Grze

- **Wskaźnik w rogu:** Stały indykator w prawym górnym rogu ekranu (`[ Great Zille Solution v0.3.0 | ACTIVE (F9: Menu) ]`).
- **Panel testowy F9:** Manualny wyzwalacz operacji wojennych, katastroficznej klęski Tury 3, sprawdzania rezerw i synchronizacji stanu.
