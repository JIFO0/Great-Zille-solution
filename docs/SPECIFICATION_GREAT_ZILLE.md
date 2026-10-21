# Projekt: Great Zille Solution — Pełna Specyfikacja Projektowa i Fabularna

## 1. Założenia Główne

Mod wprowadza alternatywną, militarną ścieżkę rozwiązania kryzysu Zille w kampanii Rizia (DLC do gry Suzerain).
Gracz od samego początku panowania Romulusa (Turn 01) otrzymuje możliwość rozważenia i forsowania opcji siłowej wobec Wiktora Smolaka, co spotyka się z dynamiczną ewolucją nastrojów na Dworze Królewskim, wpływa na światowe sojusze geopolityczne oraz otwiera pełnoprawny teatr wojenny.

---

## 2. Architektura Narracyjna i Ewolucja Postaw

### Faza Początkowa (Tura 1–2): Sceptycyzm i Ostrzeżenia
- **Tura 01 (`Turn01_ZilleVisit_HostileSpeech`):**
  - Opcja: *"Jeśli ten błazen nie odda naszej ziemi po dobroci, odbierzemy ją siłą i żelazem."*
  - **Hugo Toras:** Kategoryczny sprzeciw. Ostrzega przed potępieniem przez Sojusz Narodów (AN), sankcjami i złamaniem traktatu z Wehlen podpisanego przez króla Valero.
  - **Lucita Azaro:** Chłodny realizm wojskowy. Po kryzysie sukcesyjnym armia dopiero odzyskuje spójność; uderzenie teraz to samobójstwo.
  - **Titus Griz:** Podkreśla zagrożenie dywersją i terroryzmem wehzekowskim w stolicy i Brenas.
  - **Księżniczka Vina:** Przerażenie i prośba o umiar.

- **Tura 02 (`Turn02_Zille_FriendshipDayPrep`):**
  - Smolak odrzuca wstępne ustępstwa i żąda taniej ropy oraz uległości.
  - Opcja: *"Smolak posuwa się za daleko. Czas polecić sztabowi przygotowanie planu uderzenia prewencyjnego."*
  - **Przesunięcie nastrojów:** Lucita rozpoczyna tajne studia sztabowe na południu. Arcykapłan Sal ogłasza odzyskanie Zille świętym obowiązkiem wobec Wruheca.

### Faza Eskalacji (Tura 3–7): Zamach, Lespia i Panika Dwóch Frontów
- **Tura 03 (`Turn03_ZilleIncidentRespons` — Zamach w Zille):**
  - Po wybuchu bomby Romus ogłasza stan podwyższonej gotowości na granicy Brenas.
  - **Panika Dwóch Frontów (Two-Front War Check):**
    - Jeżeli Rizia szykuje się na wojnę z Pales, doradcy wpadają w skrajną panikę. Hugo krzyczy o upadku dynastii, a Lucita protestuje, że armia pęknie pod naporem dwóch wojen naraz.

- **Tura 04 / 08: Oferta Patricio Alvareza (Układ Kulisowy z Lespią):**
  - Gdy Lespia widzi determinację wojskową Rizii w regionie Pales, Alvarez osobiście wysuwa bezwzględną, pragmatyczną ofertę:
    - *"Słuchaj, Romus. Reinhard z Pales to nasz klient i przyjaciel wolnego rynku. Nie chcemy tam waszych czołgów. Ale słyszymy, że Smolak kręci wam lody w Zille. Zróbmy interes: podpisujesz ugodę z Pales, a Lespia i Arcasia dadzą wam dane satelitarne, nowoczesną broń i zielone światło na spacyfikowanie Wehlen."*
  - **Wybór gracza:**
    - **Przyjęcie oferty:** Wstrzymanie inwazji na Pales (`Diplomacy_Pales_PrepareForWar = false`), aktywacja wsparcia satelitarnego Arcasii i dostaw amunicji z Lespii. Lucita może skierować 100% armii na front Zille!
    - **Odrzucenie oferty:** Alvarez grozi, że duma Romusa zakończy się klęską na dwóch frontach.

- **Tura 05: Ostrzeżenie z Morelli (Salva i MITZ):**
  - Premier Salva w trakcie rozmów o udziałach w MITZ wyraża ostry niepokój koncentracją wojsk Rizii w Brenas, ostrzegając przed imperializmem.

- **Tura 06 / 08: Spór w Radzie Koronnej (Rico Toras vs Angelica Sazon):**
  - **Książę Rico (Su Omina):** Euforia. Żąda sformowania bojówek ochotniczych do walki z Wehzekami.
  - **Księżna Angelica Sazon:** Przerażenie o rodzinną prowincję Brenas. Żąda gwarancji, że regularna armia obroni jej posiadłości, zamiast wystawiać je na pastwę odwetu Smolaka.

### Faza Kulminacyjna (Tura 8): Wybuch Wojny
- **Tura 08 (`Turn08_ZilleNegotiat`):**
  - Smolak odrzuca ostateczne warunki handlowe.
  - Gracz wydaje rozkaz: **"Dość upokorzeń. Operacja Righteous Sword. Odzyskujemy Zille orężem!"**

---

## 3. Globalne Przesunięcia Geopolityczne

Wypowiedzenie wojny Wehlen wywołuje tektoniczne wstrząsy w układzie sił:

| Blok Geopolityczny | Państwa | Skutek eskalacji |
|---|---|---|
| **Blok Malyenkiewistyczny / Wschodni** | **Valgsland (Hegel)**, **Morella (Salva)**, **CSP** | **Drastyczny spadek relacji.** Valgsland potępia agresję feudalną, zrywa pakt i grozi blokadą. Morella usztywnia negocjacje MITZ. |
| **Blok Kapitalistyczny / Zachodni** | **Lespia (Alvarez)**, **Arcasia (Walker)**, **ATO** | **Znacząca poprawa relacji.** Alvarez dostarcza dane satelitarne i broń. Arcasia widzi w Rizii stabilizatora przeciwko pro-socjalistycznemu Wehlen. |
| **Derdia** | **Azmal** | Poprawa relacji, jeśli gracz wcześniej nie ugiął się przed Wehlen w kwestii zwalczania bojówek Nurystów. |

---

## 4. Teatr Działań Wojennych (Mechanika i Struktura Mapy)

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
- **Wariant Alfa — Szturm Frontalny na Zille:** Bezpośrednie uderzenie przez pola naftowe na miasto. Wysokie ryzyko strat i podpaleń szybów naftowych przez Wehzeków.
- **Wariant Beta — Manewr Obejścia (Viktrany & Munat):** Uderzenie w przesmyk -> zdobycie garnizonu **Viktrany** -> uderzenie na głębokowodny port **Munat**, paraliżujące zaopatrzenie wroga.

### Faza 2: Operacja "Total Repayment" (Całkowita Spłata)
- Ostateczna likwidacja okrążonych sił Wehlen i zdobycie pałacu gubernatorskiego.

### Zasady Specjalne:
1. **Anti-Duplication Rule:** Jednostki wysłane na front Pales nie mogą brać udziału w Zille.
2. **Blokada Morska Półwyspu:** Silna flota blokuje dostawy do Munat, nakładając trwały debuff na wojska Wehlen.
3. **Wsparcie Wywiadowcze Arcasii:** Dostępne po zawarciu paktu z Alvarezem.

---

## 5. Konsekwencje i Scenariusze Klęski

- **Zwycięstwo:** Odzyskanie Zille, rozbicie Smolaka, dominacja Rizii w południowej Merkopie.
- **Tragedia Królowej Matki Esteli:** Przy załamaniu frontu Estela jedzie do rodowej posiadłości w Brenas/Zille, zostaje schwytana i zamordowana z rozkazu Smolaka.
- **Totalna Klęska (Utrata Prowincji Brenas):** Smolak anektuje całe Brenas. Bunt generalicji Azaro i pucz militarny kończą panowanie Romulusa.
