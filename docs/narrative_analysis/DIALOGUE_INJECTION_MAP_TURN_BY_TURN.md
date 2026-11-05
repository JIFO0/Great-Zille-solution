# The Great Zille Solution: Kompletna Mapa Wstrzyknięć i Modyfikacji Dialogowych (Tura po Turze)

*Dokument projektowy narracji i inżynierii dialogów dla moda „The Great Zille Solution” do gry Suzerain: Kingdom of Rizia.*

---

## 1. Architektura Systemowa i Zasady Eliminacji Dysonansu Narracyjnego

Wojna z Wehlen o odzyskanie Zille jest inwazyjną ingerencją w rdzeń kampanii Rizia. Aby wyeliminować zjawisko **narrative dissonance** (np. dworzan dyskutujących o herbatkach i rokowaniach, podczas gdy czołgi płoną na bagnach Brenas), system modyfikacji dialogowej operuje na trzech typach wstrzyknięć:

1. **`[INTERRUPT]`**: Blokada lub zastąpienie sceny vanilla. Uruchamiane, gdy wydarzenie w grze bazowej staje się fizycznie lub logicznie niemożliwe w stanie wojny z Wehlen (np. pokojowe spotkanie handlowe ze Smolakiem, bankiet przygraniczny, bilateralne negocjacje o ekstradycję).
2. **`[BRANCH]`**: Dodanie rozbudowanej, alternatywnej odnogi dialogowej w istniejącej scenie. Scena się odbywa, ale pod warunkiem `Zille_War_Active == true` rozmówcy reagują na konflikt, spory mobilizacyjne, stan frontu i sankcje.
3. **`[FLAVOR INJECT]`**: Precyzyjne wstrzyknięcie 1–3 kwestii reakcyjnych / komentarzy postaci w ramach istniejącego grafu dialogowego, uwzględniających stan wojny na południu, straty ludzkie, braki energii lub dylemat dwufrontowy.

### Główne Flagi Systemowe Modyfikacji
* `Zille_War_Active` (`bool`): Wojna z Wehlen trwa w bieżącej turze.
* `Zille_War_Variant` (`int`: 1 = Wczesny T3/4, 2 = Środkowy T8, 3 = Późny T9).
* `Zille_War_State` (`int`: 0 = Pokój, 1 = Faza I, 2 = Faza II, 3 = Zakończona/Traktat).
* `Zille_War_Outcome` (`int`: 1 = Total Fiasco, 2 = Tactical Defeat, 3 = Stalemate, 4 = Decisive Victory, 5 = Overwhelming Triumph).
* `Zille_TwoFrontWar` (`bool`): `Zille_War_Active == true && RiziaDLC.Pales_War == true`.
* `Zille_Logistics_House` (`string`: "Azaro" | "Sazon").

---

## 2. Mapa Wstrzyknięć Tura po Turze (Prolog – Tury 1–11 – Epilog)

### Prolog
#### Plik: `docs/conversations_decompiled/Rizia/Prologue/303_Prologue.md`
* **Obecny kontekst fabularny:** Młodość Romusa, powstanie w 1926 r., utrata prowincji Zille na rzecz Wehlen przez króla Valero, traktat dzierżawny na 25 lat, śmierć żony Leny, relacje z córką Viną i wybór profilu strategicznego Romusa (wojsko, dyplomacja, ekonomia).
* **Kolizje i punkty wejścia:** W vanilla brak jakiejkolwiek wzmianki o przygotowywaniu rewizji zbrojnej traktatu o Zille. Utrata Zille traktowana jest jako trauma narodowa, lecz czysto polityczna.
* **Zadanie dla moda: `[BRANCH]`**
  - **Lokalizacja wstrzyknięcia:** W sekcji wyboru priorytetu po wstąpieniu na tron lub wspomnień z wojny 1926 r.
  - **Mechanizm:** Dodanie opcji monologu wewnętrznego Romusa: *„Ojciec ugiął kolan przed barbarzyńcą Smolakiem. Przysięgam na grób Leny, że jeśli Wehlen nie odda Zille dobrowolnie do 1954 roku, odbiorę je ogniem i mieczem.”*
  - **Efekt:** Ustawienie ukrytej flagi nastawienia `Zille_Revanchist_Intent = true`, dającej unikalne linie dialogowe w Turze 1 i 2.

---

### Tura 1
#### 1. Plik: `docs/conversations_decompiled/Rizia/Turn_01/289_EnT_CouncilBriefing.md`
* **Obecny kontekst fabularny:** Pierwsza pełna narada Rady Królewskiej po koronacji. Przedstawienie ministrów (Hugo, Lucita, Laurento, Elena), statusu królestwa, dylematu sukcesji i praw Viny.
* **Kolizje i punkty wejścia:** Dyskutowany jest stan skarbca i polityka zagraniczna. Zille wspominane jest jedynie jako formalny termin wygasający za kilka lat.
* **Zadanie dla moda: `[FLAVOR INJECT]`**
  - **Wstrzyknięcie:** Wypowiedź Romusa: *„Zille musi wrócić do macierzy. Hugo, Laurento — chcę jasnej deklaracji, że Korona nie zawaha się przed użyciem siły, jeśli Smolak zacznie mataczyć.”*
  - **Reakcje:** Hugo gani Romusa za nieostrożność (*„Traktaty to fundament monarchii, Wasza Królewska Mość, AN nałoży embargo!”*). Elena ostrzega przed kosztem zbrojeń.

#### 2. Plik: `docs/conversations_decompiled/Rizia/Turn_01/295_SnO_SecurityMilitaryMeeting.md`
* **Obecny kontekst fabularny:** Narada wojskowa z Lucitą Azaro i Titusem Grizem. Stan armii, reformy po czystkach Valero, sytuacja w Montaklar i Pales.
* **Kolizje i punkty wejścia:** Lucita skupia się wyłącznie na zagrożeniu z Pales i Lespii. Południowa granica Brenas i garnizony Wehlen w Zille są całkowicie przemilczane.
* **Zadanie dla moda: `[BRANCH]`**
  - **Wstrzyknięcie:** Odnoga dialogowa o południowym teatrze operacyjnym.
  - **Treść:** Romus pyta o gotowość Południowego Dowództwa. Lucita referuje: Wehlen utrzymuje w Zille 2 zmechanizowane brygady i fortyfikacje polowe wokół szybów naftowych; podejścia przez bagna Brenas są wąskim gardłem. Titus ostrzega przed infiltracją wywiadu Wehlen (Wehzek Secret Police) w Mave Nortus.
  - **Wybór:** Rozkaz rozpoczęcia tajnego planowania operacyjnego (*„Draw up contingency plans for the liberation of the South”* $\rightarrow$ `Zille_Staff_Planning = true`).

---

### Tura 2
#### 1. Plik: `docs/conversations_decompiled/Rizia/Turn_02/296_FPnT_DiplomacyBriefing.md`
* **Obecny kontekst fabularny:** Laurento i Hugo przygotowują Romusa do wizyty w Zille na Dniu Przyjaźni Wehzek-Rizian. Dyskutowane są gesty dyplomatyczne, uściski dłoni ze Smolakiem i relacje z Sordlandem.
* **Kolizje i punkty wejścia:** Przygotowanie do uległego lub czysto ceremonialnego spotkania. Brak opcji demonstracji siły.
* **Zadanie dla moda: `[BRANCH]`**
  - **Wstrzyknięcie:** Rozkaz postawienia III Korpusu w Brenas w stan podwyższonej gotowości pod pretekstem „ćwiczeń osłonowych wizyty”.
  - **Reakcja:** Hugo jest przerażony perspektywą prowokacji. Laurento ostrzega, że Smolak poczuje lufę przy skroni. Lucita popiera manewr z błyskiem w oku.

#### 2. Plik: `docs/conversations_decompiled/Rizia/Turn_02/298_FPnT_ZilleVisit.md`
* **Obecny kontekst fabularny:** Spotkanie ze Smolakiem w Zille, parada wojskowa, cyniczne żarty Wiktora o czołgach, przemówienia i zamach bombowy na trybunie.
* **Kolizje i punkty wejścia:** Kluczowy punkt zwrotny całej gry.
* **Zadanie dla moda: `[BRANCH]`**
  - **Wstrzyknięcie w trakcie parady:** Gdy Smolak kpi z armii Rizii, Romus może rzucić twarde ostrzeżenie: *„Keep laughing, Wiktor. Those tanks on your parade might look very different when facing Rizian artillery across the river.”*
  - **Następstwo zamachu:** Gdy bomba eksploduje, a ranny Romus wraca do Porte Drazon, odblokowuje się ścieżka natychmiastowej odpowiedzi wojennej (Wariant A).

---

### Tura 3
#### 1. Plik: `docs/conversations_decompiled/Rizia/Turn_03/304_SnO_ZilleSecurityDebrief.md`
* **Obecny kontekst fabularny:** Pilna narada po zamachu bombowym w Zille. Titus raportuje o śladach, Su Omina, Rico Torasie i oskarżeniach Smolaka.
* **Kolizje i punkty wejścia:** W vanilla gracz może jedynie wybrać śledztwo (Golden Guard vs Titus) lub oskarżenia dyplomatyczne. Brak opcji militarnej.
* **Zadanie dla moda: `[BRANCH]` & `[PUNKT ZAPALNY: WARIANT A]`**
  - **Wstrzyknięcie Główne:** Wybór strategiczny po raporcie Titusa:
    1. *Ścieżka Vanilla:* Śledztwo kryminalno-dyplomatyczne.
    2. *Wstrzyknięcie Modyfikacji — Opcja Wojenna (Wariant A):* Romus wstaje od stołu: *„Smolak zorganizował ten zamach, by unieważnić traktat. Nie pozwolę mu ukraść prowincji pod dymem bombowym. Ogłaszam mobilizację!”*
    3. *Ścieżka Samobójcza / "Głupia" (Early Disaster):* Bezpośredni rozkaz bez zaopatrzenia $\rightarrow$ Smolak kontratakuje, zajmuje Mave Nortus, katastrofa humanitarna.
  - **Rozwidlenie Doktrynalne Wariantu A:**
    - **Plan A (Surprise Blitz):** Uderzenie w Turze 4 z zaskoczenia pod pretekstem wygaśnięcia 25 lat.
    - **Plan B (AN Ultimatum):** Oficjalny protest do AN i koncentracja sił zbrojnych pod błękitną flagą wymuszenia traktatu.

#### 2. Plik: `docs/conversations_decompiled/Rizia/Turn_03/305_FPnT_QueenBeatriceVisit.md`
* **Obecny kontekst fabularny:** Wizyta królowej Beatrice z Rumburgu. Rozmowy o sojuszu GRACE, dostawach surowców i pożyczce.
* **Kolizje i punkty wejścia:** Jeśli wybrano Wariant A (wojna o Zille wisi w powietrzu), Beatrice nie może rozmawiać wyłącznie o herbatce i pożyczce.
* **Zadanie dla moda: `[BRANCH]`**
  - **Wstrzyknięcie:** Beatrice pyta wprost o ruchy wojsk w Brenas.
  - **Reakcja:** Jeśli Romus wyjaśnia, że odbiera Zille Wehlen: Beatrice wyraża chłodną aprobatę dla eliminacji lewicowego watażki, ale stawia warunek: *„Rumburg expects uninterrupted oil shipments once the wells are yours, Romus. Do not drag us into a war with United Contana.”*

#### 3. Pliki wizyt prowincjonalnych: `307_A_VisitToIza.md`, `308_A_VisitToSallabes.md`, `309_A_VisitToMontaklar.md`
* **Kolizje:** Arystokracja nie może ignorować nastrojów wojennych przy Wariancie A.
* **Zadanie dla moda: `[FLAVOR INJECT]`**
  - **W Montaklar (Lucita/Taddeus):** Ród Azaro rwie się do walki, żąda powierzenia dowództwa i obiecuje zmiażdżyć Wehzeków w 3 tygodnie.
  - **W Sallabes (Angelica Sazon):** Przerażenie stratami w ludziach, obawa przed dewastacją szlaków handlowych w Brenas.

---

### Tura 4
#### 1. Plik: `docs/conversations_decompiled/Rizia/Turn_04/314_FPnT_AlvarezCall.md`
* **Obecny kontekst fabularny:** Rozmowa telefoniczna z Patricio Alvarezem (Lespia). Pijany Alvarez poucza Romusa, domaga się ustępstw w MITZ i kpi z Rizii.
* **Kolizje i punkty wejścia:** W Wariancie A wojna już wybuchła lub siły stoją na pozycjach wyjściowych. Alvarez nienawidzi Smolaka.
* **Zadanie dla moda: `[BRANCH]` — *„Dylemat Alvareza”***
  - **Mechanizm:** Jeśli trwa wojna o Zille, to Alvarez potrzebuje Romusa!
  - **Wstrzyknięcie:** Romus przejmuje inicjatywę: *„Patricio, moje dywizje właśnie robią to, na co Lespii i Arcasii zabrakło odwagi. Albo zaoferujecie dane wywiadowcze i amunicję, albo Wehlen pozostanie u waszych granic na zawsze.”*
  - **Wybór:** Pakt z Lespią (dane satelitarne, odblokowanie desantu spadochronowego, gwarancja weta w AN w zamian za pokój z Pales).

#### 2. Plik: `docs/conversations_decompiled/Rizia/Turn_04/316_FPnT_ANSouthMerkopa.md`
* **Obecny kontekst fabularny:** Szczyt AN South Merkopa. Smolak występuje i ogłasza wstrzymanie zwrotu Zille z powodu zagrożenia terroryzmem Su Omina.
* **Kolizje i punkty wejścia:** Jeśli Romus wybrał Wariant A, Smolak w panice oskarża Rizię o otwartą agresję lub gromadzenie wojsk.
* **Zadanie dla moda: `[INTERRUPT]` / `[BRANCH]`**
  - **Wariant A:** Przemówienie Smolaka zamienia się w histeryczny apel o pomoc do CSP przeciwko „monarchistycznym najeźdźcom”. Romus prezentuje twarde ultimatum traktatowe.
  - **Wariant B/C (pokojowy na tym etapie):** Zachowanie vanilla z wstrzyknięciem zapowiedzi odwetu militarnego.

#### 3. Plik: `docs/conversations_decompiled/Rizia/Turn_04/313_A_CouncilTalkAboutPales.md`
* **Obecny kontekst fabularny:** Debata o roszczeniach do pola gazowego Aureus i księciu Reinharcie.
* **Kolizje i punkty wejścia:** Dwufrontowość! Jeśli armia walczy w Zille, Lucita i Elena muszą alarmować o braku sił na uderzenie na Pales.
* **Zadanie dla moda: `[BRANCH]`**
  - **Wstrzyknięcie:** Elena Flores bezlitośnie przedstawia stan skarbca: *„Wasza Wysokość, jeśli zaangażujemy flotę przeciw Reinhartowi, podczas gdy połowa budżetu paliwowego idzie do czołgów w Brenas, zbankrutujemy w dwa kwartały.”* Lucita przyznaje, że wojna na dwa fronty to koszmar operacyjny.

---

### Tura 5
#### 1. Plik: `docs/conversations_decompiled/Rizia/Turn_05/326_FPnT_WehlenNegotiations.md`
* **Obecny kontekst fabularny:** Oficjalne bilateralne negocjacje z Wehlen w Porte Drazon. Smolak przybywa z bezczelnymi żądaniami: prawa dla Wehzeków, krew za krew (ekstradycja Rico), oddanie praw do ropy.
* **Kolizje i punkty wejścia:** Całkowita kolizja, jeśli trwa Wariant A (aktywna wojna).
* **Zadanie dla moda: `[INTERRUPT]` (Wariant A) / `[BRANCH]` (Wariant B/C)**
  - **Dla Wariantu A:** Scena zostaje **całkowicie zastąpiona** przez *Event 4: Spór Logistyczny Azaro vs Sazon* oraz raporty z frontu. Smolak nie przyjeżdża do stolicy wroga, który bombarduje jego posterunki!
  - **Dla Wariantu B/C:** Pozostaje spotkanie, ale gracz otrzymuje wstrzykniętą opcję zerwania negocjacji z groźbą siłową: *„Every concession you demand brings our tanks one mile closer to your palace, Wiktor.”*

#### 2. Plik: `docs/conversations_decompiled/Rizia/Turn_05/322_FPnT_MITZHegelCall.md` & `323_FPnT_MorellaNegotiations.md`
* **Obecny kontekst fabularny:** Rozmowy z Morellą (Salane) i Valgslandem (Hegel) o nacjonalizacji MITZ.
* **Kolizje i punkty wejścia:** Jeśli trwa wojna o Zille, Morella boi się rozlewu konfliktu na rafinerie graniczne, a Hegel grzmi o imperialistycznej agresji.
* **Zadanie dla moda: `[FLAVOR INJECT]`**
  - **U Hegela:** Wściekłość premiera Valgslandu: *„You claim to want economic justice in MITZ, yet your soldiers are bayoneting Wehzek workers in Brenas! Contana is watching you, King Romus!”*
  - **U Salane:** Morella żąda gwarancji nienaruszalności rurociągów tranzytowych.

---

### Tura 6
#### 1. Plik: `docs/conversations_decompiled/Rizia/Turn_06/357_SnO_WarEruptionBriefing.md` / `359_SnO_Incident.md`
* **Obecny kontekst fabularny:** Incydent graniczny/morski z Pales (zestrzelenie helikoptera lub ostrzał korwety). Lucita proponuje inwazję na Pales.
* **Kolizje i punkty wejścia:** Najważniejszy punkt kolizji dwufrontowości!
* **Zadanie dla moda: `[BRANCH]`**
  - **Stan Wariantu A:** Front w Zille osiąga punkt kulminacyjny (Faza II / traktat). Jeśli gracz zdecyduje się zaatakować Pales, aktywuje się stan `Zille_TwoFrontWar = true`.
  - **Reakcja doradców:**
    - **Hugo:** Krzyczy, że to obłęd Nerona.
    - **Elena:** Zapowiada natychmiastowe załamanie gospodarki i dewaluację riziańskiego złotego.
    - **Lucita:** Podekscytowana, ale żąda natychmiastowej demobilizacji rezerw rodu Sazon i wprowadzenia racjonowania paliwa.

#### 2. Plik: `docs/conversations_decompiled/Rizia/Turn_06/372_A_PalaceBalconySpeech.md`
* **Obecny kontekst fabularny:** Romus przemawia z balkonu pałacu do zgromadzonych tłumów w Porte Drazon (w vanilli: po incydencie z Pales lub kryzysie).
* **Kolizje i punkty wejścia:** Idealne miejsce na wstrzyknięcie mowy wojennej Wariantu A.
* **Zadanie dla moda: `[BRANCH]`**
  - **Wariant A:** Przemówienie wojenne obwieszczające wyzwolenie Zille lub wzywające naród do jedności w obliczu trudów frontowych.

---

### Tura 7
#### 1. Plik: `docs/conversations_decompiled/Rizia/Turn_07/377_FPnT_DerdiaNegotiations.md`
* **Obecny kontekst fabularny:** Pielgrzymka/wizyta dyplomatyczna u Wisemana Azmala w Derdii. Negocjacje o prawach Golcondistów, handlu energią i najemnikach.
* **Kolizje i punkty wejścia:** Derdia graniczy z Wehlen i nienawidzi Smolaka za masakry religijne.
* **Zadanie dla moda: `[BRANCH]`**
  - **Wstrzyknięcie opcji operacyjnej:**
    - Romus: *„Wiseman, Wehlen is engaged in full-scale war against us. Open a western diversionary vector through Yol.”*
    - **Odpowiedź Azmala:** Golcondyjski przywódca zgadza się na pomoc logistyczną i przerzut dywersantów na tyły Wehlen (model białoruski), żądając zniesienia wszelkich podatków od świątyń w Rizii i wieczystego statusu dla nuryckich pielgrzymów.

#### 2. Pliki: `380_Fighting_Assistance_Unfriendly.md` / `381_Fighting_Assistance_Friendly.md` oraz `385_Pales_War_Update_And_Tax.md`
* **Obecny kontekst fabularny:** Raporty wojenne z Pales i podatek wojenny.
* **Kolizje i punkty wejścia:** W vanilla raporty dotyczą wyłącznie Pales.
* **Zadanie dla moda: `[FLAVOR INJECT]`**
  - Wprowadzenie kalkulacji obu teatrów: jeśli trwa wojna z Wehlen, raporty wojenne i dekrety podatkowe muszą zawierać rozbicie na straty w Wehlen i Pales oraz zużycie amunicji.

#### 3. Plik: `docs/conversations_decompiled/Rizia/Turn_07/386_Zille_Treaty_Discussion.md`
* **Obecny kontekst fabularny:** Narada o zbliżającym się terminie referendum w Zille i intrygach Smolaka.
* **Kolizje i punkty wejścia:** Przy Wariancie A Zille jest już odzyskane lub przegrane traktatem w Turze 6!
* **Zadanie dla moda: `[INTERRUPT]` (Wariant A) / `[BRANCH]` (Wariant B/C)**
  - **Dla Wariantu A:** Narada dotyczy powojennej integracji Zille (odbudowa szybów, proces kolaborantów Wehlen, koszty administracji).
  - **Dla Wariantu B:** Przygotowanie do zerwania negocjacji w Turze 8 i ostatecznego ataku zbrojnego.

---

### Tura 8
#### 1. Plik: `docs/conversations_decompiled/Rizia/Turn_08/401_FPnT_ANSession.md` & `404_Zille_Territory_Issue.md`
* **Obecny kontekst fabularny:** Globalna sesja Zgromadzenia Ogólnego AN w Kyute. Dyskutowany jest spór o Heljiland, sankcje oraz kwestia Zille.
* **Kolizje i punkty wejścia:**
  - **Jeśli Wariant A (wojna zakończona w T6):** AN debatuje nad faktem dokonanym! Contana potępia monarchię, Lespia blokuje rezolucję sankcyjną wetem, Romus broni suwerenności traktatowej.
  - **Jeśli Wariant B (wojna wybuchnie za chwilę):** Ostatnia szansa na mediację. Gdy AN zawodzi, Romus podejmuje decyzję o uderzeniu.
* **Zadanie dla moda: `[BRANCH]`**
  - Dynamiczna adaptacja przemówienia Romusa i reakcji mocarstw w zależności od stanu `Zille_War_State`.

#### 2. Plik: `docs/conversations_decompiled/Rizia/Turn_08/409_SnO_SecurityBriefAndZille.md` & `424_FPnT_ZilleNegotiations.md`
* **Obecny kontekst fabularny:** Ostatnie spotkanie ze Smolakiem w sprawie Zille. Smolak cynicznie odmawia przekazania prowincji i narzuca sfałszowane referendum.
* **Kolizje i punkty wejścia:** **Główny punkt zapalny Wariantu B (Środkowego)!**
* **Zadanie dla moda: `[BRANCH]` & `[INTERRUPT]`**
  - **Wariant B:** Po bezczelnej odmowie Smolaka, Romus wstaje, przewraca mapę i opuszcza namiot: *„There will be no referendum, Wiktor. Our guns will cast Rizia's vote tomorrow at dawn.”*
  - Odpala się natychmiast *Event 1: Zille Invasion Briefing* (`9988_WarCouncil_Briefing`) oraz autoryzacja Planu Alfa lub Planu Beta.

#### 3. Plik: `docs/conversations_decompiled/Rizia/Turn_08/423_FPnT_AlvarezVisit.md`
* **Obecny kontekst fabularny:** Oficjalna wizyta Patricio Alvareza w Porte Drazon.
* **Kolizje i punkty wejścia:** Dyskutowana jest kwestia gazu, MITZ i roszczeń.
* **Zadanie dla moda: `[BRANCH]`**
  - Jeśli trwa wojna z Wehlen lub została rozpoczęta: Alvarez oferuje wsparcie wywiadowcze w zamian za gwarancje dla interesów Lespii.

---

### Tura 9
#### 1. Pliki: `docs/conversations_decompiled/Rizia/Turn_09/448_FPnT_ZilleReferendum.md` & `441_FPnT_ZilleReferendumInterference.md`
* **Obecny kontekst fabularny:** Ogłoszenie wyników „referendum” w Zille — Smolak fałszuje wyniki, ogłaszając przyłączenie Zille do Wehlen.
* **Kolizje i punkty wejścia:**
  - **Jeśli Wariant A lub B:** Sceny te nie mają prawa się odbyć!
  - **Jeśli Wariant C:** To jest **główny punkt zapalny Wariantu C (Późnego Blitzkriegu)!**
* **Zadanie dla moda: `[INTERRUPT]` (Wariant A/B) / `[BRANCH]` (Wariant C)**
  - **Dla Wariantu A/B:** Całkowite wygaszenie eventów referendum.
  - **Dla Wariantu C:** W chwili ogłoszenia sfałszowanych wyników Romus wydaje rozkaz: *„Operation Iron Crown is active. Strike every Wehzek garrison on the peninsula immediately!”*
  - Kompresja Fazy I i II wojny w jednej turze 9 z natychmiastowym przejściem do rokowań pokojowych w Turze 10.

#### 2. Plik: `docs/conversations_decompiled/Rizia/Turn_09/434_FPnT_CallWithSmolak.md`
* **Obecny kontekst fabularny:** Romus odbiera telefon od Smolaka w Monqiz (w vanilli: Smolak proponuje podział Zille lub kpi z Pales).
* **Kolizje i punkty wejścia:** W stanie wojny telefon staje się dramatyczną wymianą ognia dyplomatycznego na linii frontu.
* **Zadanie dla moda: `[BRANCH]`**
  - Przekształcenie w *Event 5: Ostatnia Rozmowa ze Smolakiem* przed kapitulacją/traktatem.

#### 3. Plik: `docs/conversations_decompiled/Rizia/Turn_09/440_A_ZilleReturnedSpeech.md`
* **Obecny kontekst fabularny:** Przemówienie po pokojowym odzyskaniu Zille.
* **Kolizje i punkty wejścia:** Dyskutuje się o „triumfie dyplomacji”. W wariancie wojennym byłby to skrajny absurd narracyjny.
* **Zadanie dla moda: `[INTERRUPT]`**
  - Zastąpienie mową o wyzwoleniu militarnym (*„Zille Was Won in Blood, Not Hollow Signatures”*).

---

### Tura 10
#### 1. Pliki: `docs/conversations_decompiled/Rizia/Turn_10/338_CouncilMeeting.md` & `350_Birthday_Gathering.md`
* **Obecny kontekst fabularny:** Wielkie podsumowanie 10 lat rządów Romusa, bankiet urodzinowy, narada o reformie konstytucyjnej lub monarchii absolutnej, petycje rodów.
* **Kolizje i punkty wejścia:** Rezultat wojny z Wehlen (jeden z 5 Stanów Końcowych) musi zdominować dyskusję:
  - *Stan 1 (Total Fiasco):* Bankiet jest odwołany. Armia w Brenas buntuje się, Hugo wściekły oskarża króla o upadek dynastii, pucz wisi w powietrzu.
  - *Stan 4/5 (Zwycięstwo/Triumf):* Romus witany jako „Wyzwoliciel Zille” (Romus the Restorer), prestiż Korony niebotyczny, opozycja rozbita.
* **Zadanie dla moda: `[BRANCH]` & `[FLAVOR INJECT]`**
  - Wstrzyknięcie bilansu wojennego w ocenie panowania Romusa przez każdego z arystokratów i ministrów.

#### 2. Pliki rodowe i puczowe: `560_House_Azaro_Strike_Conversation.md`, `561_House_Sazon_Strike_Conversation.md`, `562_House_Toras_Strike_Conversation.md`
* **Kolizje i punkty wejścia:** Jeśli wojna z Wehlen skończyła się klęską lub Rizia straciła miasta w Brenas, Domy nie strajkują pokojowo — żądają abdykacji Romusa z bronią w ręku.
* **Zadanie dla moda: `[BRANCH]`**
  - Wstrzyknięcie unikalnych warunków puczu militarnego napędzanego przez weteranów z Brenas pod wodzą Azaro lub rozczarowanych Torasów.

---

### Tura 11 i Epilog
#### Pliki: `docs/conversations_decompiled/Rizia/Turn_11/456_Ending_Speech.md` oraz `docs/conversations_decompiled/Rizia/Epilogue/425_Epilogue.md`, `432_Continued_Reign.md`, `431_Civil_War.md`
* **Obecny kontekst fabularny:** Finałowe przemówienie Romusa, losy prowincji, tablice pamiątkowe, teksty końcowe o przyszłości Południowej Merkopy.
* **Kolizje i punkty wejścia:** Vanilla wspomina Zille tylko w wariantach dyplomatycznych / utraconych.
* **Zadanie dla moda: `[BRANCH]` & `[FLAVOR INJECT]`**
  - Dodanie pełnych wpisów epilogowych dla 5 Stanów Końcowych Wojny o Zille:
    1. *Total Fiasco:* Brenas anektowane przez Wehlen, Romus wygnany lub ścięty, Wieczny Wstyd Torasów.
    2. *Tactical Defeat:* Hańbiące reparacje, Zille na zawsze Wehzekiem, zgorzkniała dynastia.
    3. *Bloody Stalemate:* Zdemilitaryzowana strefa, tysiące mogił na bagnach, kruchy rozejm pod lufami CSP.
    4. *Decisive Victory:* Zille odrodzone jako perła Korony, powrót uchodźców, dominacja w regionie.
    5. *Overwhelming Triumph:* Upadek mitu Smolaka, Wolne Miasto Grodzizg, Rizia regionalnym hegemonem, sojusz z Derdią przypieczętowany na wieki.

---

## 3. Matryca Wstrzyknięć 6 Nowych Eventów Modyfikacji (Dla 3 Wariantów)

Poniższa tabela definiuje dokładne ID scen, krok w silniku (`Step`) oraz miejsce wstrzyknięcia dla każdego z 6 kluczowych eventów wojennych:

```
┌────────────────────────────────────────────────────────────────────────────────────────┐
│                        6 NOWYCH EVENTÓW MODA "GREAT ZILLE"                             │
│ 1. Zille Invasion Briefing (9988_WarCouncil_Briefing)                                  │
│ 2. Zille War Speech (Palace Balcony / Royal Radio)                                     │
│ 3. Narada Przednegocjacyjna & Last-Minute Calls (Alvarez, Hegel, Beatrice)             │
│ 4. Spór Logistyczny: Ród Azaro vs Ród Sazon                                            │
│ 5. Ostatnia Rozmowa ze Smolakiem (Frontline Hotline / Parley)                          │
│ 6. Traktat Pokojowy (5 Stanów Końcowych Wojny)                                         │
└────────────────────────────────────────────────────────────────────────────────────────┘
```

### Zestawienie Tabela-Plan:

| Nowy Event Modyfikacji | Wariant A (Wczesny: T3/4) | Wariant B (Środkowy: T8) | Wariant C (Późny: T9) | Plik Bazowy / Miejsce Podpięcia |
| :--- | :--- | :--- | :--- | :--- |
| **1. Zille Invasion Briefing** | **Tura 4, Krok 1** (po zamachu i debriefingu T3) | **Tura 8, Krok 2** (po fiasku rozmów w `SnO_SecurityBriefAndZille`) | **Tura 9, Krok 10** (natychmiast po ogłoszeniu sfałszowanego referendum) | `docs/conversations_decompiled/Rizia/War_Operation/9988_WarCouncil_Briefing.md` |
| **2. Zille War Speech** | **Tura 4, Krok 3** (przemówienie radiowe z pałacu) | **Tura 8, Krok 4** (orędzie do narodu po zerwaniu rokowań) | **Tura 9, Krok 11** (nadzwyczajny komunikat wojenny z Porte Drazon) | Zastępuje lub rozbudowuje `372_A_PalaceBalconySpeech` / `440_A_ZilleReturnedSpeech` |
| **3. Spór Logistyczny: Azaro vs Sazon** | **Tura 4, Krok 7** (mobilizacja w Brenas, wybór linii zaopatrzenia) | **Tura 8, Krok 6** (narada zaopatrzeniowa przed operacją w Zille) | **Tura 9, Krok 12** (szybka decyzja sztabowa przed Fazą II) | Nowy moduł podpięty pod `Turn04/Turn08/Turn09` |
| **4. Narada Przednegocjacyjna & Ostatnie Telefony** | **Tura 6, Krok 2** (przed spotkaniem ze Smolakiem) | **Tura 9, Krok 6** (w punkcie kulminacyjnym wojny) | **Tura 10, Krok 1** (przed bankietem i ostatecznym traktatem) | Nowy moduł `SnO_ZillePreNegotiationsBriefing` w gabinecie łączności |
| **5. Ostatnia Rozmowa ze Smolakiem** | **Tura 6, Krok 3** (w namiocie w Port Rotsla lub na granicy) | **Tura 9, Krok 8** (zastępuje pokojowy telefon `434_FPnT_CallWithSmolak`) | **Tura 10, Krok 2** (poddanie garnizonu lub kapitulacja w Brenas) | Zastępuje `424_FPnT_ZilleNegotiations` / `434_FPnT_CallWithSmolak` |
| **6. Traktat Pokojowy (5 Stanów)** | **Tura 6, Krok 4** (oficjalne podpisanie traktatu z Wehlen) | **Tura 9, Krok 14** (podpisanie warunków pokojowych) | **Tura 10, Krok 3** (ostateczny traktat pieczętujący los Zille) | Nowy moduł `SnO_ZillePeaceTreatyFinal` (5 wariantów traktatu) |
