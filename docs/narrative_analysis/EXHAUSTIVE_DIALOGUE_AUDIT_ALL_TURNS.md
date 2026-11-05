# The Great Zille Solution: Wyczerpujący Audyt Wszystkich Konwersacji i Roli Narratora (Turn-by-Turn)

*Kompletny audyt narracyjny i techniczny 230 dekompilowanych konwersacji w dodatku Suzerain: Kingdom of Rizia. Dokumentacja wstrzyknięć, kolizji, roli Narratora oraz adaptacji dynamicznej.*

---

## 1. Głos Narratora w DLC Rizia i Standardy Narracji Wojennej

W grze *Suzerain*, a w szczególności w DLC *Kingdom of Rizia*, Narrator nie jest bezdusznym spikerem technicznym. Stanowi on **literacki pryzmat rzeczywistości**, łączący:
1. **Zmysłowy realizm historyczno-dramatyczny:** Szczegółowe opisy faktury przedmiotów, zapachów (tytoń Smolaka, woń wosku i kadzidła w kaplicy Wruheca, gryzący odór palonej ropy i prochu na bagnach Brenas).
2. **Mowę ciała i mikrogotowość emocjonalną:** Nerwowe obciąganie mankietów przez Hugona, badawcze zwężenie źrenic Lucity nad mapą sztabową, drżenie szklanki w dłoni Alvareza, chłód uścisku dłoni Beatrice.
3. **Ironię polityczną i monumentalizm państwowy:** Narrator bezlitośnie uwypukla dysonans między arystokratyczną etykietą a brutalną rzezią na froncie.

### Wytyczne dla nowych i modyfikowanych kwestii Narratora:
* **W scenach pałacowych w czasie wojny:** Pałac w Porte Drazon nie może wyglądać sielankowo. Narrator musi odnotowywać zaciemnienie okien (*blackout curtains*), odległy huk silników transportowców z bazy Terador, kurierów sztabowych w zabłoconych butach depczących perskie dywany oraz nerwowe szepty służących.
* **W scenach frontowych i polowych:** Narrator rejestruje brutalną materię wojny — lepką, czarną maź bagnisk Brenas, skwar bijący od płonących wież wiertniczych Zille, chrzęst gąsienic czołgowych i metaliczny posmak strachu.

---

## 2. Pełny Przegląd Konwersacji Turn-by-Turn

---

### PROLOG

#### `303_Prologue.md`
* **Scena vanilla:** Młodość Romusa, powstanie antyrojalistyczne 1926 r., zdrada Valero, 25-letnia dzierżawa Zille, śmierć Leny, relacje z Viną i wybór drogi życiowej.
* **Rola Narratora:** Poczucie melancholii, upadku dynastii i narodowej traumy. Zille przedstawione jest jako rana na ciele ojczyzny.
* **Kolizje ze stanem wojennym:** Vanilla narzuca fatalistyczną bezradność. Gracz nie ma możliwości określenia wojennego nastawienia do Wehlen.
* **Zadanie dla moda: `[BRANCH]`**
  - **Narrator:** *„The map of South Merkopa hung in your father’s study like an open wound. Across the southern border, the ink on the Treaty of 1929 had dried into a stain of national humiliation.”*
  - **Wybór gracza:** Złożenie cichej przysięgi zemsty i odbudowy potęgi militarnej.
  - **Zmienna:** `Zille_Revanchist_Intent = true`.

---

### TURA 1: KORONACJA I PIERWSZE DECYZJE

#### 1. `288_Start_Coronation.md` & `294_A_ReligiousCeremony.md`
* **Scena vanilla:** Ceremonia koronacji w Archisanktuarium Wruheca. Obecność arystokracji, arcykapłana Sala, rodziny królewskiej.
* **Zadanie dla moda: `[FLAVOR INJECT]`**
  - **Narrator:** Wśród zagranicznych dyplomatów Narrator zwraca uwagę na delegację Wehlen pod wodzą pułkownika w za dużym mundurze, bezczelnie żującego tytoń w uświęconych murach.
  - **Kwestia Romusa:** Możliwość zignorowania posła Smolaka lub rzucenia mu lodowatego spojrzenia podczas namaszczenia mieczem.

#### 2. `289_EnT_CouncilBriefing.md`
* **Scena vanilla:** Pierwsze oficjalne posiedzenie Rady Królewskiej po koronacji. Hugo, Lucita, Laurento i Elena prezentują stan królestwa.
* **Zadanie dla moda: `[BRANCH]`**
  - **Wstrzyknięcie:** Romus stawia sprawę jasno: *„Wehlen holds our southern territory on borrowed time. I want the Council prepared for every eventuality — including armed reclamation.”*
  - **Narrator:** *„A heavy silence dropped over the council table. Hugo froze, his quill suspended an inch above the parchment, while Lucita’s gaze sharpened like a freshly honed bayonet.”*
  - **Reakcje:** Hugo ostrzega przed złamaniem prawa międzynarodowego, Laurento przed sankcjami AN, Lucita zgłasza gotowość rodu Azaro.

#### 3. `295_SnO_SecurityMilitaryMeeting.md`
* **Scena vanilla:** Narada z Lucitą Azaro i Titusem Grizem na temat stanu sił zbrojnych i reform po czystkach Valero.
* **Kolizje:** Całkowite pominięcie południowej granicy i teatru Wehlen.
* **Zadanie dla moda: `[BRANCH]`**
  - **Nowa odnoga:** Raport o garnizonie Zille i obronie Brenas.
  - **Narrator:** *„Lucita unrolled a leather-bound strategic chart of the southern boundary. Red grease-pencil circles marked the Wehzek strongpoints ringing the Zille oil facilities.”*
  - **Wybór:** Autoryzacja tajnego studium operacyjnego przez Sztab Generalny (`Zille_Staff_Planning = true`).

---

### TURA 2: PRZYGOTOWANIA DYPLOMATYCZNE I ZAMACH W ZILLE

#### 1. `296_FPnT_DiplomacyBriefing.md`
* **Scena vanilla:** Laurento i Hugo briefują Romusa przed podróżą na Dzień Przyjaźni do Zille.
* **Zadanie dla moda: `[BRANCH]`**
  - Romus rozkazuje postawienie III Korpusu Armijnego w Brenas w stan podwyższonej gotowości pod pozorem ćwiczeń.
  - **Narrator:** *„Hugo winced as if struck across the face, his hand clutching his signet ring. 'Sire, mobilizing armored cavalry during a goodwill summit is an invitation to catastrophe!'”*

#### 2. `298_FPnT_ZilleVisit.md`
* **Scena vanilla:** Spotkanie z Wiktorem Smolakiem w Zille, parada wojskowa, trybuna honorowa, cyniczne żarty i zamach bombowy.
* **Zadanie dla moda: `[BRANCH]` & `[WAR-READY SETUP]`**
  - **Wstrzyknięcie w dialogu parady:** Romus może twardo skontrować drwiny Wiktora.
  - **Narrator podczas wybuchu:** *„The roar of the explosion tore through the festive music. Shards of burning timber and shattered concrete rained upon the royal dais. Through the acrid cordite smoke, Wiktor Smolak’s bodyguards dragged him away, leaving behind a field of screaming civilians.”*
  - Ranny Romus powraca do Porte Drazon z żądzą natychmiastowego odwetu.

---

### TURA 3: KRYZYS BOMBOWY I DECYZJA STRATEGICZNA

#### 1. `304_SnO_ZilleSecurityDebrief.md` (PUNKT ZAPALNY WARIANTU A)
* **Scena vanilla:** Debriefing bezpieczeństwa po zamachu. Titus referuje o śladach Su Omina i Rico Torasie.
* **Zadanie dla moda: `[BRANCH: WARIANT A WYBUCHU WOJNY]`**
  - **Wybór gracza:**
    1. *Ścieżka Vanilla:* Śledztwo wewnętrzne i dyplomacja.
    2. *Opcja Wojenna A (Legalistyczne Ultimatum / Plan B):* Skarga do AN i natychmiastowa koncentracja sił osłonowych pod flagą egzekucji traktatu.
    3. *Opcja Wojenna A (Surprise Blitz / Plan A):* Przełamanie kordonu z zaskoczenia w Turze 4.
    4. *Opcja Samobójcza:* Natychmiastowy, bezładny atak $\rightarrow$ klęska w Brenas, rzeź wojsk, utrata Mave Nortus.
  - **Narrator:** *„The King slammed his palm onto the mahogany table, scattering the police dossiers across the floor. 'Enough of this investigative charade! Smolak orchestrated this butchery to steal our heritage. Sound the general alarm across the Southern Command!'”*

#### 2. `305_FPnT_QueenBeatriceVisit.md`
* **Scena vanilla:** Wizyta Beatrice Livingston, herbata, rozmowy o GRACE i pożyczce.
* **Zadanie dla moda: `[BRANCH]` (Gdy aktywowano Wariant A)**
  - Beatrice zauważa mobilizację armii.
  - **Narrator:** *„Her Majesty set down her porcelain cup with deliberate slowness, her cold gaze piercing right through you. 'A little bird in Fort Ales whispers that your tank engines are purring along the Brenas line, cousin. Tell me you are not foolish enough to provoke the East while our alliance stands on the brink.'”*
  - Beatrice żąda gwarancji ropy i niewciągania GRACE w konflikt z Contaną.

#### 3. Wizyty Prowincjonalne: `307_A_VisitToIza.md`, `308_A_VisitToSallabes.md`, `309_A_VisitToMontaklar.md`
* **Zadanie dla moda: `[FLAVOR INJECT]`**
  - W Sallabes: Angelica Sazon drży o bezpieczeństwo swoich winnic i spichlerzy w Brenas.
  - W Montaklar: Ród Azaro świętuje decyzję o wojnie, wznosząc toasty za wyzwolenie Zille.

---

### TURA 4: POCZĄTEK DZIAŁAŃ WOJENNYCH (WARIANT A) LUB MANEWRY DYPLOMATYCZNE

#### 1. `314_FPnT_AlvarezCall.md`
* **Scena vanilla:** Rozmowa telefoniczna z Patricio Alvarezem. Pijany prezydent Lespii kpi z Romusa.
* **Zadanie dla moda: `[BRANCH: DYLEMAT ALVAREZA]`**
  - Jeśli trwa Wariant A: Romus przejmuje inicjatywę.
  - **Narrator:** *„Across the transatlantic wire, the clinking of ice cubes ceased abruptly. For the first time, Alvarez sounded entirely sober.”*
  - Alvarez oferuje czołgi, wywiad satelitarny (desant) i weto w AN w zamian za pokój z Pales.

#### 2. `316_FPnT_ANSouthMerkopa.md`
* **Scena vanilla:** Szczyt AN. Smolak powołuje się na protokoły bezpieczeństwa i odmawia zwrotu Zille.
* **Zadanie dla moda: `[INTERRUPT / BRANCH]`**
  - *Dla Wariantu A:* Przemówienie Smolaka to histeryczny krzyk o pomoc do United Contana i Valgslandu w obliczu przekroczenia granicy przez riziańskie dywizje.

#### 3. `313_A_CouncilTalkAboutPales.md`
* **Scena vanilla:** Spór o pole gazowe Aureus i księcia Reinharta.
* **Kolizje: Dwufrontowość!**
* **Zadanie dla moda: `[BRANCH]`**
  - Elena Flores ostrzega przed katastrofą budżetową: *„Wasza Wysokość, wydajemy 2 miliony złotych tygodniowo na paliwo dla czołgów w Brenas! Jeśli wyślemy flotę przeciwko Pales, nie wypłacimy rent wojskowych do zimy!”*

---

### TURA 5: SPÓR LOGISTYCZNY I BITWA O WIKTRANY

#### 1. `326_FPnT_WehlenNegotiations.md`
* **Scena vanilla:** Wizyta Smolaka w Porte Drazon, żądania koncesji i ekstradycji Rico.
* **Kolizje:** Absolutny dysonans przy Wariancie A!
* **Zadanie dla moda: `[INTERRUPT]` (Wariant A) / `[BRANCH]` (Wariant B/C)**
  - *Dla Wariantu A:* Scena zostaje **całkowicie zablokowana**. Zastępuje ją **Event 4: Spór Logistyczny Azaro vs Sazon**.
  - **Narrator w Sporze Logistycznym:** *„The royal war room was thick with smoke and bitter tension. On one side stood Lucita Azaro, tapping her riding crop against the map; on the other, Angelica and Manus Sazon, pale with indignation.”*
  - Gracz wybiera linię zaopatrzenia: sieć spichlerzy Sazonów (mniej korupcji, oszczędność budżetu) vs militarna mobilizacja Azaro (szybsze natarcie, potężne straty w skarbcu).

#### 2. `322_FPnT_MITZHegelCall.md` & `323_FPnT_MorellaNegotiations.md`
* **Zadanie dla moda: `[FLAVOR INJECT]`**
  - Hegel uderza pięścią w słuchawkę: *„You claim to stand for workers in MITZ, but your shells are blowing Wehzek miners to pieces in Zille!”*
  - Salane żąda gwarancji nienaruszalności rurociągów tranzytowych.

---

### TURA 6: KULMINACJA WAR. A / INCYDENT PALES (DWUFRONTOWOŚĆ)

#### 1. `357_SnO_WarEruptionBriefing.md` & `359_SnO_Incident.md`
* **Scena vanilla:** Prowokacja graniczna lub morska z Pales. Decyzja o wojnie z Reinhartem.
* **Kolizje: KRYTYCZNY DYLEMAT DWUFRONTOWOŚCI!**
* **Zadanie dla moda: `[BRANCH]`**
  - Jeśli gracz zaatakuje Pales w Wariancie A: Aktywuje się stan `Zille_TwoFrontWar = true`.
  - **Narrator:** *„Hugo sank heavily into his chair, clutching his chest. 'Two wars at once... May the saints preserve us. We are fighting Wehlen on the mud of the south and Pales on the crags of the north. This kingdom will be bled white before the year is out.'”*

#### 2. `372_A_PalaceBalconySpeech.md`
* **Zadanie dla moda: `[BRANCH]`**
  - W Wariancie A: Mowa wojenna ogłaszająca zwycięstwo i wyzwolenie Zille (Traktat Pokojowy) lub wezwanie do ofiary w obliczu ciężkich walk.

---

### TURA 7: SOJUSZ Z DERDIĄ I POWOJENNA INTEGRACJA (WAR. A)

#### 1. `377_FPnT_DerdiaNegotiations.md`
* **Scena vanilla:** Wizyta u Wisemana Azmala w Derdii.
* **Zadanie dla moda: `[BRANCH]`**
  - Opcja wstrzyknięcia wsparcia militarnego przeciw Wehlen: korytarz tranzytowy przez Yol i uderzenie dywersantów nuryckich na tyły Wehlen w zamian za zniesienie restrykcji religijnych w Rizii.

#### 2. `386_Zille_Treaty_Discussion.md`
* **Zadanie dla moda: `[INTERRUPT]` (Wariant A) / `[BRANCH]` (Wariant B/C)**
  - W Wariancie A dyskusja dotyczy odbudowy odzyskanego Zille.
  - W Wariancie B to faza ostatecznych przygotowań do uderzenia w Turze 8.

---

### TURA 8: ROZŁAM I WYBUCH WOJNY W ŚRODKOWEJ GRZE (WARIANT B)

#### 1. `401_FPnT_ANSession.md` & `404_Zille_Territory_Issue.md`
* **Scena vanilla:** Debata w Kyute o Heljilandzie i Zille.
* **Zadanie dla moda: `[BRANCH]`**
  - Adaptacja wystąpienia Romusa w zależności od stanu wojennego. Przy Wariancie B Romus stawia społeczności międzynarodowej ultimatum: jeśli AN nie wymusi ewakuacji Wehlen, Rizia zrobi to sama.

#### 2. `409_SnO_SecurityBriefAndZille.md` & `424_FPnT_ZilleNegotiations.md`
* **Scena vanilla:** Spotkanie ze Smolakiem. Wiktor odrzuca zwrot prowincji i narzuca sfałszowane referendum.
* **Zadanie dla moda: `[BRANCH: PUNKT ZAPALNY WARIANTU B]`**
  - Romus wstaje od stołu: *„Nie będzie referendum, Wiktorze. Od tej chwili przemawia nasza armia!”*
  - **Narrator:** *„Romus swept the diplomatic drafts off the table with a violent flick of his wrist. Smolak’s clownish grin vanished, replaced by an expression of cold, cornered feral hatred.”*
  - Natychmiastowe przejście do `War_Operation/9988_WarCouncil_Briefing.md` i wybór doktryny operacyjnej (Plan Alfa vs Plan Beta).

---

### TURA 9: PÓŹNY BLITZKRIEG (WARIANT C) LUB FAZA IIA/IIB (WARIANT B)

#### 1. `448_FPnT_ZilleReferendum.md` (PUNKT ZAPALNY WARIANTU C)
* **Scena vanilla:** Ogłoszenie sfałszowanych wyników referendum. Zille rzekomo głosuje za Wehlen.
* **Zadanie dla moda: `[INTERRUPT]` (Wariant B) / `[BRANCH: PUNKT ZAPALNY WAR. C]`**
  - Dla Wariantu B: Referendum jest całkowicie wykasowane (wojna już trwa!).
  - Dla Wariantu C: W chwili ogłoszenia sfałszowanych wyników odpala się natychmiastowa inwazja (*Operation Iron Crown*). Faza I i Faza II skompresowane w jednej turze 9!

#### 2. `434_FPnT_CallWithSmolak.md`
* **Scena vanilla:** Romus spędza wieczór w Monqiz i odbiera telefon od Smolaka.
* **Zadanie dla moda: `[INTERRUPT]` (Wariant B i C)**
  - Zastąpione przez **Event 5: Ostatnia Rozmowa ze Smolakiem** (gorąca linia frontowa lub parley w namiocie wojskowym).

#### 3. `440_A_ZilleReturnedSpeech.md`
* **Zadanie dla moda: `[PRZESUNIĘCIE NA TURĘ 10]`**
  - Zablokowane w Turze 9. Zostaje przesunięte na początek Tury 10 i odpalone wyłącznie po wygranym traktacie pokojowym jako mowa o triumfie militarnym.

---

### TURA 10: TRAKTAT POKOJOWY, URODZINY KRÓLOWEJ MATKI I BILANS DEKADY

#### 1. Nowy Krok 1: Podpisanie Traktatu Pokojowego (`SnO_ZillePeaceTreatyFinal`)
* **Treść:** Finał Wariantu B lub Faza III i traktat Wariantu C.
* **Narrator:** Opisuje jeden z 5 Stanów Końcowych:
  - *Stan 1 (Total Fiasco):* Prowincja Brenas pod wehzekimi flagami, płonące wsie, żołnierze rzucający broń, ucieczka Romusa do pałacu.
  - *Stan 5 (Overwhelming Triumph):* Złamany Smolak podpisujący bezwarunkowy zwrot Zille i reparacje w Port Rotsla pod lufami czołgów Azaro.

#### 2. `350_Birthday_Gathering.md` (Urodziny Królowej Matki Esteli)
* **Scena vanilla:** Bankiet urodzinowy Esteli, toasty, intrygi polityczne.
* **Zadanie dla moda: `[BRANCH]`**
  - Scena adaptuje się do wyniku traktatu podpisanego w Kroku 1.
  - Jeśli triumf: Estela wznosi toast z łzami w oczach, dziękując za ocalenie syna i odzyskanie ziemi.
  - Jeśli klęska: Grobowa atmosfera, arystokracja ostentacyjnie opuszcza salę, Hugo żąda natychmiastowej abdykacji Romusa.

#### 3. `347_Reform_ConstitutionSigning.md` & `338_CouncilMeeting.md`
* **Zadanie dla moda: `[FLAVOR INJECT]`**
  - Bilans wojenny wpływa bezpośrednio na stabilność Korony, lojalność rodów i możliwość wprowadzenia reform.

---

### TURA 11 I EPILOG: WIECZNY WERDYKT HISTORII

#### `456_Ending_Speech.md` oraz `425_Epilogue.md`, `431_Civil_War.md`, `432_Continued_Reign.md`
* **Zadanie dla moda: `[BRANCH]`**
  - Dodanie dedykowanych kart epilogowych dla 5 Stanów Końcowych Wojny o Zille:
    1. *Total Fiasco:* Brenas zaanektowane, dynastia wygnana, wieczna hańba Domu Toras.
    2. *Tactical Defeat:* Upadek gospodarczy, Wehlen kontroluje południe, zgorzkniała starość Romusa.
    3. *Bloody Stalemate:* Zdemilitaryzowane cmentarzysko w Zille, wieczne napięcie graniczne.
    4. *Decisive Victory:* Rozkwit gospodarczy, Zille diamentem w koronie, wdzięczność narodu.
    5. *Overwhelming Triumph:* Wolne Miasto Grodzizg, upadek tyranii Smolaka, hegemonia Rizii w Południowej Merkopie.
