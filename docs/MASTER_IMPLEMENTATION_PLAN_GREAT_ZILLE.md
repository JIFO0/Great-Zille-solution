# The Great Zille Solution: Master Implementation Plan (Wersja 2.0)

*Techniczny, narracyjny i architektoniczny plan wdrożenia teatru militarnego wyzwolenia prowincji Zille w grze Suzerain: Kingdom of Rizia.*  
*Wersja: 2.0.0-PROD | Status: Integracja silnika Unity, PixelCrushers DialogueSystem, GameFlow Rescheduling i 3D War Table.*

---

## SPIS TREŚCI
1. [Architektura Systemowa i Hooki Silnika (Engine & Patcher)](#1-architektura-systemowa-i-hooki-silnika-engine--patcher)
2. [Typologia Planów Wojennych: Sztab vs Osobiste Dowodzenie Romulusa](#2-typologia-planów-wojennych-sztab-vs-osobiste-dowodzenie-romulusa)
   - 2.1. Plany Sztabowe (*Staff-Led*): Hawk, Sword, Ark, Spear
   - 2.2. Plany Romulusa (*Player-Controlled*): Romulus Ark & Romulus Sword (Operacja Righteous Sword)
   - 2.3. Struktura Fazowa i Zasięg Terytorialny (Zille vs Głąb Wehlen)
3. [Chronologia, GameFlow Rescheduling i Przesunięcie Referendum](#3-chronologia-gameflow-rescheduling-i-przesunięcie-referendum)
   - 3.1. Dlaczego Referendum w Turze 9 było Wąskim Gardłem?
   - 3.2. Nowy Harmonogram Referendum (Plebiscyt w Turze 7)
   - 3.3. Trzy Scenariusze Czasowe (Wczesny, Średni w T7, Zwykły w T8)
4. [Spięcie Fabularne z Kampanią Vanilla (Narrative & Lore Cohesion)](#4-spięcie-fabularne-z-kampanią-vanilla-narrative--lore-cohesion)
   - 4.1. Ewolucja Pretekstu Smolaka (Od Zamachu Bombowego do Plebiscytu AN)
   - 4.2. Konsekwencje dla Szczytu Alliance of Nations w Kyrute (Tura 8)
   - 4.3. Dylemat Wojny Dwufrontowej (Zille + Pales)
   - 4.4. Spór Logistyczny Rodów: Azaro vs Sazon
5. [Matryca Warunków Zwycięstwa i Porażki (5 Stanów Końcowych)](#5-matryca-warunków-zwycięstwa-i-porażki-5-stanów-końcowych)
   - 5.1. Ewaluacja dla Planów Sztabowych (Staff Calculation)
   - 5.2. Ewaluacja dla Planów Romulusa (Hex Capture Detection)
   - 5.3. 5 Finałów Traktatowych i Scenariusz „Niepodległe Zille”
6. [Specyfikacja Scen Dialogowych i Potok Wstrzykiwania (PixelCrushers)](#6-specyfikacja-scen-dialogowych-i-potok-wstrzykiwania-pixelcrushers)
7. [Gospodarka, Zasoby i Zmienne Stanu Państwa](#7-gospodarka-zasoby-i-zmienne-stanu-państwa)
8. [System Diagnostyki, Menu F9 i Zautomatyzowane Testy QA](#8-system-diagnostyki-menu-f9-i-zautomatyzowane-testy-qa)
9. [Harmonogram Produkcyjny i Kamienie Milowe](#9-harmonogram-produkcyjny-i-kamienie-milowe)

---

## 1. Architektura Systemowa i Hooki Silnika (Engine & Patcher)

Modyfikacja operuje w środowisku **MelonLoader 0.6+** pod silnikiem Unity 6000.3.9f1 (Il2Cpp metadata v39), integrując się bezpośrednio z logiką narracyjną PixelCrushers oraz stanami gry Torpor Games (`Torpor.StoryPack`, `GameFlow`, `EntityDataManager`).

### 1.1. Kluczowe Punkty Wstrzyknięć (Critical Patches)
1. **`DialogueManager.Awake` & `MasterDatabase`:**
   - Wstrzykiwanie zmodyfikowanych węzłów i nowych assetów konwersacji (ID `9988`–`9994`) do pamięci `DialogueDatabase`.
   - Obsługa dynamicznych branchy dialogowych z poziomu `DialogueOverrideManager.cs`.
2. **`GameFlow.ExecuteStep` & `GameFlow.TriggerConversation`:**
   - Przechwytywanie kroków w Turach 7, 8, 9 i 10.
   - Wstrzymanie vanillowych sekwencji kolidujących (`[INTERRUPT]`) oraz przekierowanie na aktywne fazy wojenne w Zille.
3. **`WarFlowManager` & `WarTable`:**
   - Ładowanie układu taktycznego Zille z `zille_tiles_layout.json`.
   - Dynamiczne przełączanie teatru: teatr Pales vs teatr Zille / Wehlen w zależności od wybranego tokena i flagi `Zille_War_Active`.
4. **`TokenInteractionPanel.Open`:**
   - Generowanie natywnych przycisków startu operacji (`Operation: Righteous Sword - Phase I`, `Phase II`, `Phase III`) po kliknięciu piona wojskowego Zille.

---

## 2. Typologia Planów Wojennych: Sztab vs Osobiste Dowodzenie Romulusa

W odpowiedzi na głębię RPG i zróżnicowane style gry wprowadzamy fundamentalny podział na **dwa tryby prowadzenia wojny**:

```
                              ┌───────────────────────────────────────────────┐
                              │      KRÓLEWSKA NARADA WOJENNA (SCENA 9988)    │
                              └───────────────────────┬───────────────────────┘
                                                      │
                       ┌──────────────────────────────┴──────────────────────────────┐
                       ▼                                                             ▼
     ┌───────────────────────────────────┐                         ┌───────────────────────────────────┐
     │       PLANY SZTABOWE              │                         │         PLANY ROMULUSA            │
     │      (General Staff-Led)          │                         │     (Player-Controlled Map)       │
     └─────────────────┬─────────────────┘                         └─────────────────┬─────────────────┘
                       │                                                             │
        ┌──────────────┼──────────────┐                               ┌──────────────┴──────────────┐
        ▼              ▼              ▼                               ▼                             ▼
   [HAWK / SWORD / ARK / SPEAR]                               [ROMULUS SWORD]                 [ROMULUS ARK]
   • Kampania rozstrzygana przez sztab                        • Teatr Zille + Morze           • Teatr Wehlen + Granica
   • Brak manualnej mapy hexowej                              • Bezpośrednie dowodzenie       • Bezpośrednie dowodzenie
   • Wpływ doktryny, budżetu i decyzji                        • 2 fazy planu podstawowego     • 2 fazy planu głębokiego
   • Płynne raporty i zdarzenia losowe                        • + 1-2 fazy drugiego etapu     • + 1-2 fazy drugiego etapu
```

### 2.1. Plany Sztabowe (*Staff-Led*): Hawk, Sword, Ark, Spear
W przypadku wyboru jednego z planów sztabowych król Romus deleguje operacyjne dowodzenie do **Sztabu Generalnego** (pod przewodnictwem Lucity Azaro, Titusa Gordiona lub generałów armii). **Gracz nie przesuwa pionów na mapie hexowej.**

* **Plan Hawk (Jastrząb):**
  - *Doktryna:* Dominacja powietrzna i zmasowane uderzenia rakietowo-artyleryjskie na węzły komunikacyjne.
  - *Wymagania:* Rozwinięte lotnictwo (baza w Teradorze, fabryka bombowców Morelli) oraz zapasy energii.
  - *Przebieg:* Sztab raportuje sukcesy w niszczeniu infrastruktury Wehlen; minimalne straty własne w ludziach, lecz ogromne zniszczenia miejskie i ryzyko ofiar cywilnych.
* **Plan Sword (Miecz Sztabowy):**
  - *Doktryna:* Klasyczny, frontalny klin pancerno-zmechanizowany prowadzony przez dywizje rodu Azaro.
  - *Wymagania:* Wysoka liczba dywizji czołgów i piechoty zmechanizowanej, poparcie Lucity.
  - *Przebieg:* Krwawe, bezpośrednie starcia o Wiktrany i Zille City. Sukces zależny od przewagi sprzętowej.
* **Plan Ark (Arka Sztabowa):**
  - *Doktryna:* Operacja połączona z naciskiem na dominację morską, blokadę zaopatrzenia z Port Rotsla i desanty przybrzeżne.
  - *Wymagania:* Silna flota królewska (okręty wojenne i podwodne) oraz współpraca z flotyllą Brenas.
  - *Przebieg:* Odcięcie posiłków Smolaka drogą morską; powolne, metodyczne duszenie garnizonu Zille.
* **Plan Spear (Włócznia):**
  - *Doktryna:* Błyskawiczny rajd komandosów, Złotej Straży i oddziałów górskich przez trudny teren w celu eliminacji dowództwa Wehlen i opanowania kluczowych mostów.
  - *Wymagania:* Rozbudowana Złota Straż Titusa, wysoki poziom wywiadu wojskowego.
  - *Przebieg:* Niezwykle ryzykowna operacja chirurgiczna o charakterze "wszystko albo nic".

*Mechanizm rozstrzygania planów sztabowych:*
W każdej fazie operacji silnik oblicza współczynnik sukcesu na podstawie:
`PowerProjection` + `Army_Equipment` + `Doctrine_Synergy` - `Wehlen_Entrenchment`. Gracz otrzymuje meldunki sytuacyjne i podejmuje kluczowe decyzje makro (np. rzucenie rezerw, zgoda na bombardowanie miast, wsparcie logistyczne Sazonów).

---

### 2.2. Plany Romulusa (*Player-Controlled*): Specyfikacja Regionów v14
Gdy Romus osobiście przypina miecz i przejmuje bezpośrednie dowodzenie nad całością sił zbrojnych, **gra otwiera w pełni interaktywną, trójwymiarową mapę wojenną Zille War Table**.

Zgodnie z zatwierdzoną specyfikacją topologiczną (**Wersja v14: `maps/zille/v14/regions/operation_regions_v14.json`**) teatry operacyjne dzielą się na ściśle zdefiniowane pule prowincji aktywnych w Fazie 1 i Fazie 2:

```
┌────────────────────────────────────────────────────────────────────────────────────────────────────────┐
│                        ZESTAWIENIE REGIONÓW OPERACYJNYCH DLA PLANÓW (WERSJA v14)                      │
├──────────────────────┬─────────────┬─────────────┬─────────────────────────────────────────────────────┤
│ Plan Operacyjny      │ Faza 1      │ Faza 2      │ Zakres Terytorialny (Aktywne Prowincje)             │
├──────────────────────┼─────────────┼─────────────┼─────────────────────────────────────────────────────┤
│ 1. Plan Sword        │ 137 kafelków│ 179 kafelków│ Faza 1: Całe Zille (60) + całe Brenas (29) +        │
│    (Righteous Sword) │ (90 ląd /   │ (122 ląd /  │ wyspa Rotsla (96) + 47 mórz (bez 10 pod Wehlen).    │
│                      │  47 morze)  │  57 morze)  │ Faza 2: Cała mapa bez Derdii (+42 kafelki: Wehlen   │
│                      │             │             │ 32, morza 10).                                      │
├──────────────────────┼─────────────┼─────────────┼─────────────────────────────────────────────────────┤
│ 2. Plan Ark          │ 130 kafelków│ 179 kafelków│ Faza 1: Całe Wehlen (33) + całe Brenas (29) +       │
│    (Standard)        │ (73 ląd /   │ (122 ląd /  │ pas 11 prowincji Zille przy Brenas + 57 mórz.       │
│                      │  57 morze)  │  57 morze)  │ Faza 2: Cała mapa bez Derdii (+49 prowincji Zille). │
├──────────────────────┼─────────────┼─────────────┼─────────────────────────────────────────────────────┤
│ 3. Plan Ark (Derdia) │ 137 kafelków│ 186 kafelków│ Faza 1: To samo co Ark + 7 kafelków Derdii (123-128 │
│    (Sojusz z Azmalem)│ (80 ląd /   │ (129 ląd /  │ oraz 129 Yol jako nieprzejezdna baza tranzytowa).   │
│                      │  57 morze)  │  57 morze)  │ Faza 2: Cała mapa łącznie z Derdią (+49 Zille).     │
└──────────────────────┴─────────────┴─────────────┴─────────────────────────────────────────────────────┘
```

#### Szczegółowy Skład Teatrów i Ograniczenia Graniczne:

##### A. Plan Sword (Operacja Righteous Sword — Półwysep Zille, Brenas & Wody Przybrzeżne)
* **Faza 1 (Wyzwolenie Zille ze Wsparciem Brenas):**
  - **Ląd (90 prowincji):** 
    - Cały Półwysep Zille (60 prowincji, w tym miasta *Zille City, Wiktrany, Munat, Nanta* oraz wyspa *3 Manes Riuz*).
    - **Całe Brenas (29 prowincji)** — baza operacyjna i terytorium domowe Rizii (*23 Mave Nortus, 40-67*). **Prowincja Brenas jest ZAWSZE aktywna** we wszystkich planach i fazach!
    - Wyspa Wehlen **`96 Rotsla`** (dostępna drogą morską przez S28 i S35).
  - **Morze (47 prowincji):** 47 akwenów morskich. Zgodnie z decyzją operacyjną wyłączono 10 wód u wybrzeży Wehlen:
    `S1 (Kreleck Sound)`, `S2 (Kratsna Waters)`, `S3 (Munat Waters)`, `S27 (Rotsla Sound)`, `S33 (Port Rotsla Waters)`, `S34 (Port Rotsla Roads)`, `S38 (Yol Waters)`, `S39 (Yol Roads)`, `S40 (Grodzizg Waters)`, `S53 (Rotsla Deep)`.
  - **Rozmieszczenie i manewr:** Wojska lądowe Korony ruszają z miast i twierdz Brenas (*Marbelas, Dapalle, Mave Nortus*) uderzając bezpośrednio przez granicę w głąb Zille, a marynarka operuje z 7 zatwierdzonych morskich pól startowych (`S26, S30, S31, S32, S37, S56, S57`).
* **Faza 2 (Przełamanie na Kontynent Wehlen):**
  - Odblokowanie **42 prowincji**: 32 prowincje lądowe kontynentalnego Wehlen oraz 10 brakujących mórz. 
  - Łącznie 179 kafelków aktywnych (cała mapa bez prowincji Derdii).

##### B. Plan Ark (Uderzenie na Granicy i w Głąb Wehlen)
* **Faza 1 (Izolacja Zille i Uderzenie na Zaplecze Smolaka):**
  - **Ląd (73 prowincje):** Wszystkie 33 prowincje Wehlen + wszystkie 29 prowincji Brenas + **pas 11 prowincji Zille** graniczących bezpośrednio z Brenas:
    `20 Venna`, `26 Ossa East`, `33 Dapalle West`, `36 Pomara Northwest`, `37 Pomara North`, `39 Celle Vaz North`, `104 Venna East`, `108 Venna Southwest`, `114 Dapalle Northwest`, `117 Pomara West`, `118 Praia Velha`.
  - **Morze (57 prowincji):** Wszystkie 57 akwenów morskich aktywnych od samego początku operacji.
  - **Zablokowane (56 prowincji):** 49 prowincji głębi Zille oraz 7 prowincji Derdii.
* **Faza 2 (Szturm Generalny i Konsolidacja):**
  - Odblokowanie pozostałych **49 prowincji Zille** (w tym *Zille City, Wiktrany, Munat, Nanta*). Łącznie 179 kafelków aktywnych.

##### C. Plan Ark z Derdią (Korytarz Północny przez Yol)
* Dostępny wyłącznie, jeśli gracz zawarł porozumienie z Najwyższym Mędrcem Azmalem (`Zille_DerdiaPact_Signed == true`).
* Odblokowuje 7 prowincji Derdii (`123 Dertea West`, `124 Merzil`, `125 Dertea`, `126 Haldesh`, `127 Qerzan South`, `128 Qerzan`) oraz `129 Yol` (widoczny kafel bazowy o statusie `impassable: true`, symbolizujący neutralne wsparcie logistyczne).
* Faza 2 obejmuje **186 kafelków** (100% zintegrowanej mapy v14).

---

### 2.3. Struktura Fazowa Kampanii Romulusa (Zasada 2 + 1-2 Fazy)
Wojna o Zille prowadzona przez gracza **liczy od 3 do 4 faz bojowych**, zapewniając pełnowymiarowy teatr wojenny:

1. **Faza I (Otwarcie Teatru Wstępnego):** 
   - W Sword: Natarcie z Brenas na pozycje Wehlen w Zille na 137 kafelkach (90 ląd, 47 morze).
   - W Ark: Walka graniczna w Brenas i uderzenie na posterunki Wehlen na 130/137 kafelkach.
2. **Faza II (Zabezpieczenie Celów Etapu 1):** 
   - Rozbicie głównych sił przeciwnika w aktywnym sektorze (zdobycie węzłów manewrowych).
3. **Faza III (Odblokowanie Całej Mapy — Etap 2):** 
   - Granice operacyjne pękają: odblokowuje się pełna mapa (179 lub 186 kafelków).
   - W Sword: Wkroczenie do Wehlen i zabezpieczenie Brenas.
   - W Ark: Wkroczenie do serca Zille City i likwidacja odciętego garnizonu Valdeza.
4. **Faza IV (Opcjonalny Finał / Rozstrzygnięcie):** 
   - Ostateczna likwidacja punktów oporu i przejście do negocjacji traktatowych (5 Stanów Końcowych).

---

### 2.4. Blokada Krawędzi Granicznych (`boundary_edges_to_disabled`)
W Fazie 1 silnik gry (`ZilleWarTable.cs`) aktywuje dynamiczne blokady krawędzi (`boundary_edges_to_disabled` z `operation_regions_v14.json`):
- Pomiędzy kafelkiem aktywnym a nieaktywnym krawędź staje się nieprzejezdna dla jednostek obu stron (brak możliwości ataku, ruchu i rozprzestrzeniania linii zaopatrzenia).
- Zapobiega to ucieczce jednostek AI Smolaka na wyłączone obszary oraz próbom ataku na zablokowane miasta przed odblokowaniem Fazy 2.

---

## 3. Chronologia, GameFlow Rescheduling i Przesunięcie Referendum

### 3.1. Dlaczego Referendum w Turze 9 było Wąskim Gardłem?
W pierwotnym zarysie Suzeraina referendum w Zille odbywa się dopiero w **Turze 9 Krok 9** (`Turn9_FPnT_ZilleReferendum`). Pozostawiało to zaledwie ułamek Tury 9 i Turę 10 na jakiekolwiek działania militarne. 
Wymuszenie **minimum 3-4 faz operacyjnych** w takim układzie doprowadziłoby do nienaturalnego stłoczenia walk i całkowitej utraty dramaturgii politycznej.

### 3.2. Nowy Harmonogram Referendum (Plebiscyt w Turze 7)
Aby stworzyć odpowiednią przestrzeń operacyjną, **plebiscyt i polityczny kryzys referendum zostają przesunięte na Turę 7**:
* **Środek Tury 7:** Gdy śledztwo w sprawie zamachu bombowego ujawnia matactwa Wehlen (lub Rizia odmawia zaspokojenia roszczeń Smolaka), Wiktor Smolak jednostronnie ogłasza organizację plebiscytu pod kontrolą swoich służb bezpieczeństwa.
* **Koniec Tury 7:** Odbywa się sfałszowane referendum. Wyniki ogłaszają rzekome "92% poparcia dla pozostania w Republice Wehlen".
* **Natychmiastowe Casus Belli:** Korona uznaje to za jawne złamanie traktatu z 1929 roku i aneksję terytorium. Zgoda na interwencję zbrojną.

---

### 3.3. Trzy Zintegrowane Scenariusze Czasowe

```
┌──────────────────────────────────────────────────────────────────────────────────────────────────┐
│                             NOWA OŚ CZASU KAMPANII WOJENNEJ O ZILLE                              │
├──────────────────────────────────────────────────────────────────────────────────────────────────┤
│ 1. SCENARIUSZ WCZESNY (Tura 3/4): ODWET PO ZAMACHU                                               │
│ • Rozpoczęcie: Koniec Tury 3 / Tura 4 (Romus uznaje zamach za casus belli i wkracza do Zille).  │
│ • Czas trwania: Tura 4 (Faza I), Tura 5 (Faza II), Tura 6 (Faza III i Traktat Pokojowy).         │
│ • Stan Pales: Całkowity spokój (przed incydentem morskim). Brak dylematu dwufrontowości.         │
├──────────────────────────────────────────────────────────────────────────────────────────────────┤
│ 2. SCENARIUSZ ŚREDNI (Koniec Tury 7): REAKCJA NA SFAŁSZOWANE REFERENDUM                          │
│ • Rozpoczęcie: Koniec Tury 7 (po ogłoszeniu sfałszowanych wyników plebiscytu).                   │
│ • Faza I: Koniec Tury 7 (Błyskawiczne uderzenie graniczne).                                      │
│ • Faza II: Tura 8 (Krok 2 - Bitwa manewrowa o węzły centralne).                                  │
│ • Faza III: Tura 9 (Krok 6 - Przełamanie obrony Zille City / Rajd w głąb Wehlen).                │
│ • Faza IV / Traktat Pokojowy: Koniec Tury 9 / Początek Tury 10.                                  │
├──────────────────────────────────────────────────────────────────────────────────────────────────┤
│ 3. SCENARIUSZ ZWYKŁY (Tura 8): ZERWANIE ROKOWAŃ I KRYZYS DYPLOMATYCZNY                           │
│ • Rozpoczęcie: Tura 8 Krok 12 (Ostateczne fiasko osobistych negocjacji ze Smolakiem).             │
│ • Faza I: Tura 8 Krok 13 (Uderzenie wyprzedzające przed aneksją).                                │
│ • Faza II: Tura 9 Krok 3 (Operacja główna).                                                      │
│ • Faza III: Tura 9 Krok 14 / Tura 10 Krok 1 (Szturm ostateczny).                                 │
│ • Traktat Pokojowy: Tura 10 Krok 2.                                                              │
└──────────────────────────────────────────────────────────────────────────────────────────────────┘
```

---

## 4. Spięcie Fabularne z Kampanią Vanilla (Narrative & Lore Cohesion)

### 4.1. Ewolucja Pretekstu Smolaka (Od Zamachu Bombowego do Plebiscytu AN)
* **Dlaczego Smolak przyspiesza referendum w Turze 7?**
  Smolak nie jest szaleńcem — jest wyrachowanym dyktatorem. Widząc, że śledztwo prowadzone przez Rizię (Złotą Straż Titusa lub wywiad Lucity) zaczyna go demaskować, a presja na arenie międzynarodowej rośnie, Smolak zdaje sobie sprawę, że karta "zamachu bombowego" się wyczerpała. 
  Wymyśla więc "demokratyczny" plebiscyt, powołując się na Kartę Praw AN o prawie narodów do samostanowienia. Gdy Rizia protestuje, Smolak przeprowadza głosowanie w ekspresowym tempie pod lufami karabinów.

### 4.2. Konsekwencje dla Szczytu Alliance of Nations w Kyrute (Tura 8 Step 15)
W vanilli sesja AN w Turze 8 jest nudnawą debatą prawną. **Po zmianach staje się jednym z najbardziej emocjonujących punktów gry:**
* **Jeśli wojna wybuchła pod koniec Tury 7:** Romus wchodzi na mównicę AN w Kyrute w blasku fleszy, podczas gdy na południu trwają walki!
  - Może przedstawić dowody fałszerstw plebiscytu i terroryzmu państwowego Wehlen.
  - **Lespia i Arcasia:** Alvarez może poprzeć Rizię i zablokować sankcje ATO przeciw Koronie.
  - **Valgsland i Contana:** Premier Hegel uderza butem w pulpit, oskarżając Rizię o monarchistyczny imperializm, lecz Romus może wykorzystać prawo międzynarodowe, by zneutralizować weto CSP.

### 4.3. Dylemat Wojny Dwufrontowej (Zille + Pales)
Jeśli gracz zdecydował się na inwazję Pales w Turze 6/7, wybuch wojny w Zille pod koniec Tury 7 lub w Turze 8 tworzy autentyczny **koszmar geostrategiczny**:
- Rezerwy poborowych muszą być dzielone między dwa teatry.
- Każda tura walk na dwóch frontach nakłada podwójną karę budżetową i energetyczną (`-2 Budget, -2 Energy`).
- Generałowie obu rodów (Lucita Azaro na froncie Pales vs generałowie sztabowi w Zille) kłócą się o dostawy amunicji i sprzętu.

### 4.4. Spór Logistyczny Rodów: Azaro vs Sazon
Wydarzenie `9990_ZilleWar_LogisticsDispute` zyskuje fundamentalne znaczenie operacyjne:
* **Linia Azaro (Sztabowo-Militarna):** Szybszy dostęp do ciężkiej artylerii i posiłków, ale kosztem korupcji sztabowej (`-2 Budget`).
* **Linia Sazon (Kupiecko-Obronna w Brenas):** Zapewnienie stabilnego zaplecza magazynowego w Brenas, zmniejszenie strat w zaopatrzeniu, ochrona miast granicznych przed kontratakiem Smolaka.

---

## 5. Matryca Warunków Zwycięstwa i Porażki (5 Stanów Końcowych)

### 5.1. Ewaluacja dla Planów Sztabowych (Staff Calculation)
Dla planów *Hawk, Sword, Ark, Spear* wynik końcowy jest kalkulowany po zakończeniu ostatniej fazy na podstawie sumy punktów operacyjnych:
* **Punkty Sukcesu Sztabu ($S$):**
  $$S = \text{PowerProjection} + \text{StaffSynergy} + \text{ResourceAllocation} - \text{WehlenResistance}$$
  - $S \le 1$: **Stan 1 (Total Fiasco)** — Załamanie ofensywy, Wehlen wkracza do Brenas.
  - $S \in [2, 3]$: **Stan 2 (Tactical Defeat)** — Front zamiera na linii demarkacyjnej, brak postępów, ogromne straty.
  - $S \in [4, 6]$: **Stan 3 (Bloody Stalemate)** — Częściowe sukcesy (np. odbicie Wiktran bez Zille City), wzajemne wykrwawienie.
  - $S \in [7, 8]$: **Stan 4 (Decisive Victory)** — Wyzwolenie całego Półwyspu Zille.
  - $S \ge 9$: **Stan 5 (Overwhelming Triumph)** — Całkowite zmiażdżenie Wehzek Republican Guards, panika w Wehlen.

---

### 5.2. Ewaluacja dla Planów Romulusa (Hex Capture Detection)
Dla kampanii prowadzonych na mapie 3D Zille War Table detektor stanu (`ZilleCampaignState`) zlicza kontrolę nad kluczowymi kafelkami miejskimi pod koniec fazy bitewnej:

| Stan Końcowy | Warunki Kontroli Kafelków (Prowincji) | Konsekwencje Polityczne i Traktatowe |
| :--- | :--- | :--- |
| **1. Total Fiasco** | Wehlen kontroluje co najmniej 2 z 3 miast Brenas (*Marbelas, Dapalle, Mave Nortus*). | Katastrofa dynastii. Wehlen okupuje Brenas, -5 Budget, natychmiastowe ryzyko puczu wojskowego. |
| **2. Tactical Defeat (Raczej Porażka)** | Rizia utrzymała Brenas, ale **nie zdobyła żadnego miasta Wehlen** (Status Quo po krwawej inwazji) LUB utraciła 1 miasto Brenas bez zysków. | Kompromitacja militarna. Smolak żąda reparacji za agresję, Rizia zrzeka się praw do Zille. |
| **3. Bloody Stalemate (Zwykły PAT)** | Rizia kontroluje 1–2 miasta Wehlen (np. *Wiktrany* lub *Nantę*), lecz nie zdobyła *Zille City* LUB utraciła 1 miasto Brenas w zamian za zdobycze w Zille. | Obustronny impas. **Opcja specjalna: Utworzenie Niepodległego Zille** jako neutralnego buforu. |
| **4. Decisive Victory** | Rizia kontroluje wszystkie 4 miasta Półwyspu Zille (*Zille, Wiktrany, Munat, Nanta*), a Brenas jest bezpieczne. | Pełny powrót prowincji Zille do Korony. Triumf wojenny Romusa, powrót uchodźców. |
| **5. Overwhelming Triumph** | Rizia kontroluje Zille + co najmniej 1 strategiczny punkt głębi Wehlen (*Port Rotsla* lub korytarz naftowy *Oktan*). | Zmiażdżenie Smolaka. Olbrzymie reparacje (+4 Budget, +3 Energy), Zille wraca, Grodzizg Wolnym Miastem. |

---

### 5.3. Finał Traktatowy i Ścieżka Kompromisowa: „Niepodległe Zille”
W przypadku **Stanu 3 (Bloody Stalemate)** Romus staje przed unikalnym dylematem podczas rozmów pokojowych:
- Zamiast ciągnąć wyniszczającą wojnę pozycyjną, Romus może zaproponować **utworzenie Wolnego i Niepodległego Państwa Zille**:
  - Zille staje się suwerenną, zdemilitaryzowaną republiką buforową pod wspólną gwarancją AN.
  - Wehlen otrzymuje preferencyjne stawki tranzytowe na ropę.
  - Rizia zyskuje bezpieczną granicę i prestiż państwa stojącego na straży pokoju bez ryzyka dalszych ofiar.

---

## 6. Specyfikacja Scen Dialogowych i Potok Wstrzykiwania (PixelCrushers)

Modyfikacja operuje na zestawie wstrzykiwanych assetów dialogowych:

```
┌──────────┬──────────────────────────────────────────┬─────────────────────────────────────────────────┐
│ ID Sceny │ Tytuł Sceny w Systemie                   │ Główna Rola Narracyjna i Wybory                 │
├──────────┼──────────────────────────────────────────┼─────────────────────────────────────────────────┤
│ 9988     │ Turn_Zille_WarBriefing                   │ Wybór Doktryny: Plany Sztabowe vs Plany Romulusa│
│ 9989     │ Turn_Zille_BalconySpeech                 │ Orędzie Wojenne do Narodu (Autorytet i morale)   │
│ 9990     │ Turn_Zille_LogisticsDispute              │ Spór o Linie Zaopatrzenia: Dom Azaro vs Sazon    │
│ 9991     │ Turn_Zille_PreNegotiationsBriefing       │ Raport Strat, Telefony: Alvarez, Hegel, Beatrice│
│ 9992     │ Turn_Zille_SmolakFinalParley             │ Ostatnia Rozmowa na Linii Frontu ze Smolakiem   │
│ 9993     │ Turn_Zille_PeaceTreaty                   │ Podpisanie Traktatu Pokojowego (5 Wyników)      │
│ 9994     │ Turn_Zille_StaffBattleReport             │ Meldunki Operacyjne dla Planów Sztabowych       │
└──────────┴──────────────────────────────────────────┴─────────────────────────────────────────────────┘
```

---

## 7. Gospodarka, Zasoby i Zmienne Stanu Państwa

### 7.1. Słownik Zmiennych Systemowych (DialogueLua)
* `Zille_War_Active` (`bool`): Flaga aktywności stanu wojny.
* `Zille_War_PlanType` (`string`): `"Staff"` lub `"Romulus"`.
* `Zille_War_StaffPlan` (`string`): `"Hawk"`, `"Sword"`, `"Ark"`, `"Spear"`.
* `Zille_War_RomulusPlan` (`string`): `"RomulusSword"` (Półwysep) lub `"RomulusArk"` (Głąb Wehlen).
* `Zille_War_Phase` (`int`): Aktualna faza operacyjna (1 do 4).
* `Zille_War_Outcome` (`int`): Rozstrzygnięcie końcowe (1 = Fiasco, 2 = Defeat, 3 = Stalemate, 4 = Victory, 5 = Triumph).
* `Zille_Independent_Buffer` (`bool`): Czy zrealizowano wariant neutralnego państwa Zille w Stanie 3.
* `Zille_TwoFrontWar` (`bool`): Aktywna równoległa wojna z Pales i Wehlen.

---

## 8. System Diagnostyki, Menu F9 i Zautomatyzowane Testy QA

* **Panel Podglądu F9:**
  - Status planu wojennego (Sztab vs Romulus).
  - Przełącznik fazy operacyjnej (Phase 1 / 2 / 3 / 4).
  - Wymuszenie rezultatu traktatowego do testów dialogów końcowych.
* **Audyt Integralności Drzewa:**
  - Walidacja węzłów i poprawności warunków `ConditionsString` w `assets/mod_dialogue_overrides.json`.

---

## 9. Harmonogram Produkcyjny i Kamienie Milowe

```
┌────────────────────────────────────────────────────────────────────────────────────────┐
│                     HARMONOGRAM WDROŻENIA MASTER PLANU (WERSJA 2.0)                    │
├────────────────────────────────────────────────────────────────────────────────────────┤
│ ETAP 1: AKTUALIZACJA SILNIKA ROZKAZÓW I PLANÓW (Obecny)                                │
│ • Wdrożenie rozróżnienia planów sztabowych (Hawk/Sword/Ark/Spear) oraz Romulusa.        │
│ • Rozbudowa sceny narady 9988 o selekcję teatrów (Righteous Sword vs Romulus Ark).      │
│ • Oprogramowanie detektora hexów w ZilleWarTable.cs dla 2 teatrów.                     │
├────────────────────────────────────────────────────────────────────────────────────────┤
│ ETAP 2: PRZESUNIĘCIE REFERENDUM & GAMEFLOW RESCHEDULING                                │
│ • Przesunięcie eventu plebiscytu na koniec Tury 7 w GameFlow_StepInterceptor.          │
│ • Aktywacja faz operacyjnych w Turach 7, 8 i 9.                                        │
│ • Wdrożenie spięcia narracyjnego z sesją AN w Turze 8.                                 │
├────────────────────────────────────────────────────────────────────────────────────────┤
│ ETAP 3: DIALOGI TRAKTATOWE I 5 STANÓW KOŃCOWYCH                                        │
│ • Implementacja sceny traktatu 9993 dla wszystkich 5 wariantów.                         │
│ • Dopisanie ścieżki "Niepodległe Zille" w Stanie 3.                                     │
│ • Dostosowanie reakcji rodziny królewskiej (Estela, Hugo, Vina).                       │
├────────────────────────────────────────────────────────────────────────────────────────┤
│ ETAP 4: BALANS, QA I SZLIF KOŃCOWY                                                     │
│ • Weryfikacja drenażu budżetowego w wojnie jedno- i dwufrontowej.                      │
│ • Testy manualne na 3D War Table w scenariuszach 3-fazowych i 4-fazowych.               │
└────────────────────────────────────────────────────────────────────────────────────────┘
```
