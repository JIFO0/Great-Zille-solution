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

## 4. UI i Diagnostyka w Grze

- **Wskaźnik w rogu:** Stały indykator w prawym górnym rogu ekranu (`[ Great Zille Solution v0.3.0 | ACTIVE (F9: Menu) ]`).
- **Panel testowy F9:** Manualny wyzwalacz operacji wojennych, katastroficznej klęski Tury 3, sprawdzania rezerw i synchronizacji stanu.
