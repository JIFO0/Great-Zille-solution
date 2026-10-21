# Projekt: Great Zille Solution — Pełna Specyfikacja Projektowa i Fabularna

## 1. Założenia Główne

Mod wprowadza alternatywną, militarną ścieżkę rozwiązania kryzysu Zille w kampanii Rizia (DLC do gry Suzerain).
Gracz od samego początku panowania Romulusa (Turn 01) otrzymuje możliwość rozważenia i forsowania opcji siłowej wobec Wiktora Smolaka, co spotyka się z dynamiczną ewolucją nastrojów na Dworze Królewskim oraz otwiera pełnoprawny teatr wojenny.

---

## 2. Architektura Narracyjna (Ewolucja Dialogów Zille)

### Faza Początkowa (Tura 1–2): Sceptycyzm i Ostrzeżenia
- **Tura 01 (`Turn01_ZilleVisit_HostileSpeech`):**
  - Gracz otrzymuje nową opcję dialogową: *"Jeśli ten błazen nie odda naszej ziemi po dobroci, odbierzemy ją żelazem i krwią."*
  - **Reakcje:**
    - **Hugo Toras:** Kategoryczny sprzeciw. Ostrzega przed potępieniem przez Sojusz Narodów (AN), sankcjami i złamaniem traktatu z Wehlen podpisanego przez króla Valero.
    - **Lucita Azaro:** Chłodny realizm wojskowy. Zwraca uwagę, że po wojnie domowej i kryzysie sukcesyjnym armia Rizii nie jest jeszcze zreorganizowana, a zaatakowanie Wehlen bez przygotowania to ryzyko wciągnięcia się w bagna partyzanckie.
    - **Titus Griz:** Podkreśla zagrożenie asymetryczne — agenci Smolaka i komórki Wehzeków natychmiast uderzą w serce Rizia City poprzez akty dywersji.
    - **Księżniczka Vina:** Przerażenie i apel o umiar dyplomatyczny.

- **Tura 02 (`Turn02_Zille_FriendshipDayPrep`):**
  - Negocjacje wstępne ze Smolakiem. Smolak uznaje propozycje Rizii za niewystarczające, żąda ustępstw naftowych i darmowych taryf.
  - Gracz może zaproponować w Radzie rozpoczęcie tajnych prac sztabowych nad planem inwazji.
  - **Przesunięcie nastrojów:** Lucita dostrzega bezczelność Smolaka i zaczyna po cichu sporządzać plany mobilizacyjne na granicy Brenas. Arcykapłan Sal sugeruje, że odzyskanie Zille to sprawiedliwość dziejowa i obowiązek wobec Wruheca.

### Faza Eskalacji (Tura 3–7): Radykalizacja i Zamach Bombowy
- **Tura 03 (`Turn03_ZilleIncidentRespons` — Zamach w Zille):**
  - Po eksplozji Smolak oskarża Su Ominę i żąda ekstradycji oraz zamknięcia rurociągów.
  - Gracz może oskarżyć Smolaka o prowokację pod fałszywą flagą i zarządzić mobilizację sił południowych.
  - **Kluczowy warunek — Panika dwóch frontów (Pales Intent Check):**
    - Jeżeli flaga `Diplomacy_Pales_PrepareForWar` lub stan wojny z Pales jest aktywny:
      - **Wszyscy doradcy wpadają w skrajną panikę.**
      - Hugo krzyczy o szaleństwie i upadku dynastii.
      - Nawet wojownicza Lucita Azaro kategorycznie protestuje: *"Wasza Wysokość, wojna na dwa fronty to wyrok śmierci dla Korony! Nasze rezerwy pękną na pół, a Pales i Wehlen rozszarpią naszą logistykę!"*

### Faza Kulminacyjna (Tura 8): Zerwanie Rozmów i Wypowiedzenie Wojny
- **Tura 08 (`Turn08_ZilleNegotiat`):**
  - Smolak odrzuca ostateczne warunki handlowe, twierdząc, że to za mało i szykuje sfałszowane referendum.
  - Gracz wybiera rozkaz ataku: **"Dość upokorzeń. Operacja Righteous Sword. Odzyskujemy Zille orężem."**
  - Przekierowanie do silnika operacyjnego `WarOperationManager`.

---

## 3. Teatr Działań Wojennych (Mechanika i Struktura Mapy)

Nowa siatka operacyjna reprezentuje prowincję Zille, pas graniczny Brenas oraz wybrzeże północne.

```
       [ MORZE PÓŁNOCNE / ZATOKA ]  <--- (Strefa Blokady Morskiej)
                 |
      [ Port MUNAT ] ======== [ Węzeł VIKTRANY ]
            \                     /
             \                   /
              [ Miasto ZILLE ] (Główna Twierdza Smolaka)
                     |
       [ Równiny Naftowe i Rafinerie ]
                     |
       [ Pozycje Graniczne BRENAS ]  <--- (Punkt Wyjścia Wojsk Rizii)
```

### Faza 1: Operacja "Righteous Sword" (Sprawiedliwy Miecz)
Gracz na starcie operacji wybiera doktrynę uderzenia:
1. **Wariant Alfa — Szturm Frontalny na Zille:**
   - Bezpośrednie uderzenie przez pola naftowe na miasto Zille.
   - **Charakterystyka:** Błyskawiczne tempo, ale Wehzekowie są silnie okopani w miejskiej zabudowie. Wymaga ciężkiej artylerii i wsparcia pancernego. Ryzyko dużych strat w ludziach i podpalenia szybów naftowych przez cofających się żołnierzy Smolaka.
2. **Wariant Beta — Manewr Obejścia (Viktrany & Munat):**
   - Odcięcie przesmyku między Zille a Nanta.
   - Pierwszy cel: **Viktrany** — silnie ufortyfikowane miasteczko garnizonowe nazwane na cześć dyktatora.
   - Drugi cel: **Munat** — ekskluzywny kurort z głębokomorskim portem przeładunkowym zaopatrzenia dla całej armii Wehlen.
   - Zdobycie Munat całkowicie paraliżuje logistykę Wehzeków w regionie.

### Faza 2: Operacja "Total Repayment" (Całkowita Spłata)
- Ostateczne zniszczenie izolowanych garnizonów Wehlen.
- Zdobycie pałacu gubernatora w Zille, aresztowanie dowództwa okupacyjnego i wyparcie niedobitków za rzekę graniczną.

---

## 4. Zasady Specjalne i Logistyka

### A. Rozdział Jednostek (Anti-Duplication Rule)
- Bataliony piechoty, dywizje pancerne i eskadry przydzielone do frontu Pales (Faza 1 lub Faza 2) zostają **zablokowane w puli rezerw Zille**.
- Gracz dysponuje wyłącznie zasobami nieskierowanymi na Pales.
- Prowadzenie wojny na dwa fronty wymaga uprzedniej gigantycznej rozbudowy potencjału wojskowego w dekretach królewskich.

### B. Kluczowa Rola Floty i Blokady Północnej
- Półwysep Zille jest podatny na odcięcie morskie.
- Posiadanie okrętów nawodnych i okrętów podwodnych pozwala aktywować **Blokadę Morską Półwyspu**.
- Sukces blokady: Port Munat traci dostawy paliwa i amunicji z Wehlen drogą morską -> jednostki wroga w Fazie 2 otrzymują trwały debuff do zaopatrzenia (-2 Atak, -2 Obrona).

### C. Zaangażowanie Mocarstw (Lespia i Arcasia)
- Smolak jest sojusznikiem CSP (Contana/Valgsland).
- Patricio Alvarez (Lespia) i Arcasia chętnie oferują tajną pomoc:
  - Przekazanie danych satelitarnych i wywiadowczych (odkrycie ukrytych pozycji Wehzeków).
  - Dostawy nowoczesnej amunicji przeciwpancernej w zamian za późniejsze preferencje w sektorze wydobywczym Zille.

---

## 5. Konsekwencje i Scenariusze Klęski

### Scenariusz Zwycięstwa:
- Zille powraca w granice Rizii pod panowanie Korony.
- Prestiż Domu Toras sięga zenitu, autorytet króla rośnie maksymalnie.
- Smolak zostaje publicznie upokorzony, a Wehlen traci wpływy na południu.

### Mroczne Zakończenia (Dramatyczne Porażki):
1. **Tragedia Królowej Matki Esteli:**
   - W przypadku załamania frontu lub przeciągających się krwawych walk w Fazie 1/2, Królowa Matka Estela postanawia udać się w rejon walk, by odwiedzić dawną posiadłość rodzinną Torasów przed jej zniszczeniem.
   - Posiadłość zostaje otoczona przez zdemoralizowane, mściwe oddziały Wehlen.
   - Estela zostaje pojmana, a Wiktor Smolak osobiście wydaje rozkaz jej egzekucji, przesyłając Romulusowi cyniczny komunikat.
2. **Totalna Katastrofa Militarna (Utrata Prowincji Brenas):**
   - Jeśli gracz przegra operację, oddziały Wehlen przechodzą do kontrofensywy.
   - Nienasycony Wiktor Smolak anektuje nie tylko Zille na stałe, ale zajmuje **całą prowincję Brenas**, odcinając Rizję od zachodnich rubieży.
   - Bunt generalicji Azaro i natychmiastowy pucz militarny kończący rządy Romulusa.
