# Great Zille Solution: Reddit Community Feedback, War System Architecture & The Alvarez Dilemma

*Dokumentacja analizy społecznościowej, propozycji graczy, architektury systemów wojennych oraz rozwiązania dylematu sojuszu z Lespią.*

---

## SPIS TREŚCI
1. [Gotowy Post na Reddit (Wersja ENG)](#1-gotowy-post-na-reddit-wersja-eng)
2. [Zestawienie Dyskusji i Komentarzy z Reddita](#2-zestawienie-dyskusji-i-komentarzy-z-reddita)
3. [Szczegółowa Architektura Systemu Wojny o Zille](#3-szczegółowa-architektura-systemu-wojny-o-zille)
   - 5 Stanów Końcowych Wojny (Traktaty Pokojowe)
   - 3 Punkty Zapalne (Timing Inwazji & Rozwiązanie Tury 9)
   - Spór Logistyczny: Ród Azaro vs Ród Sazon
   - Regionalne Reakcje: Derdia, Sordland, Morella, Rumburg, CSP
   - Koncepcja Broni Chemicznej / Mandatu AN (Reddit Idea)
4. [Analiza i Rozwiązanie Dylematu: „Alvarez & Sojusz z Lespią”](#4-analiza-i-rozwiązanie-dylematu-alvarez--sojusz-z-lespią)
5. [Event Przednegocjacyjny: Narada Sztabowa i Ostatnie Telefony](#5-event-przednegocjacyjny-narada-sztabowa-i-ostatnie-telefony)
6. [Ścieżka Wczesnego Ataku (Tura 3/4): 2 Plany Operacyjne](#6-ścieżka-wczesnego-ataku-tura-34-2-plany-operacyjne)
7. [Zarządzanie Czasem, Lukami i Chronologią (Early vs Late Game)](#7-zarządzanie-czasem-lukami-i-chronologią-early-vs-late-game)

---

## 1. Gotowy Post na Reddit (Wersja ENG)

```markdown
**Title:** [MOD / Rizia DLC] Working on an operational War with Wehlen / Zille Invasion system — would love your thoughts on peace treaties, CSP escalation, and regional dynamics

Hey everyone,

Like many of you, I felt that while Rizia’s diplomatic & covert paths to reclaim Zille are great, the military option was sorely missed — especially considering how much buildup Wehlen gets, the whole Brenas border tension, and Smolak being… well, Smolak.

I’m currently developing a full narrative & tactical expansion mod (**The Great Zille Solution**) that brings an actual operational theater for Zille, complete with operational phases, custom dialogue briefings, logistics disputes between the Royal Houses, and international escalations.

Before finalizing the writing and event branches, I’d really love to get the community’s input and ideas on a few specific mechanics and geopolitical angles:

---

### 1. The Peace Treaties / War Endings (5 Outcomes)
Right now, the endgame negotiations with Smolak scale depending on tactical performance:
1. **Total Fiasco:** Lose the 3 border cities in Brenas (Marbelas, Dapalle, Mave Nortus). Smolak carves out a buffer zone in Rizia, impossible to prevent a military coup / forced abdication due to reparations and humiliation.
2. **Tactical Defeat (Operational Defeat):**
   - *Status Quo / Zero Gains:* All starting cities of Rizia remain under Rizian control, but all Wehlen cities remain under Wehlen control. Since Rizia initiated military action to reclaim Zille and spent immense blood & treasure without capturing any objective, this counts as Scenario 2 (operational/political defeat).
   - *Territorial Loss:* Or losing at least one border city in Brenas without balancing gains.
   - Forced into a terrible trade deal, paying indemnities/reparations, and ceding claims on Zille to avoid total collapse.
3. **Bloody Stalemate (Standard PAT):**
   - *Territorial Exchange:* Losing 1 Rizian border city while capturing 1 or 2 Wehlen cities (e.g. Wiktrany, Nanta, Munat) OR taking part of the peninsula without securing the capital.
   - Both sides face severe attrition.
   - **Peace Treaty Special Option (Independent Zille):** In this stalemate negotiation, Romus can negotiate **Zille's complete independence** (as a neutral demilitarized buffer state) by granting moderate economic/trade concessions to Wehlen.
4. **Decisive Victory:** Full capture of the Zille peninsula. Smolak is furious but pragmatic; Zille is returned immediately by treaty without waiting for AN/referendums.
5. **Overwhelming Triumph:** Take all of Zille + at least two strategic objectives deep inside Wehlen (e.g. mainland hub / Port Rotsla). Smolak pays war reparations, Derdia is thrilled, and Grodzizg becomes a free city / demilitarized protectorate.

👉 **Question:** In Outcome #3 (Stalemate), if Romus stubbornly refuses Smolak’s compromise, the war turns into an existential quagmire (desertion waves, unrest in Mave Nortus, rebellion). But what about the **CSP (United Contana & Valgsland)**? Since Wehlen leans toward CSP, should Malenyev / Hegel step in with a naval blockade or AN ultimatum if Rizia pushes too deep without Arcasia/Lespia backing? How would you balance this?

---

### 2. When does the war trigger?
I’m planning 3 potential war triggers:
* **Turn 3/4:** Right after the Zille bombing — Romus calls Smolak’s bluff early and launches a preemptive strike.
* **Turn 8:** When Smolak breaks negotiations and pushes for the referendum.
* **Turn 9:** Direct reaction to the rigged referendum. (Since T9 is so close to the end, this would play out as a high-stakes Blitzkrieg with two operational phases compressed into the final turns).

👉 **Question:** How do you feel about early vs. late war triggers? Any specific interactions you’d expect if Romus goes to war with Wehlen while *already* at war with Pales on a two-front nightmare?

---

### 3. House Politics & Royal Logistics
We’re adding a confrontation between **House Azaro (Lucita/Taddeus)** and **House Sazon (Manus/Angelica)** over who manages war logistics:
* **Azaro Logistics:** Better military coordination, faster airstrike / artillery cooldowns, +1 Azaro Levy, but heavy budget corruption and strain.
* **Sazon Logistics:** Merchant networks and efficient grain/fuel depots, less Energy/Budget drain per turn, +1 Sazon Levy, but pisses off Lucita.

👉 **Question:** What other house dynamics or petty noble feuds would you like to see during wartime? What would Queen Mother Estela (whose roots lie close to Brenas) say if Romus turns her home province into a meat grinder?

---

### 4. Regional Powers (Sordland, Morella, Derdia, Lespia, Rumburg)
* **Derdia (Azmal):** If relations are high, Azmal can grant transit rights / opening a diversionary western flank, but makes it clear Rizia owes a massive spiritual and political debt to Nur and Derdia.
* **Lespia (Alvarez):** If you didn’t attack Pales and sided with Lespia on MITZ, Alvarez is happy to provide tanks, intelligence (granting paratrooper drops), and cash to bleed Smolak dry.
* **Reddit idea I saw recently:** If you focused on Airforce in the prologue, built bomber lines, expanded Terador Airbase + Flight School, and expanded Foreign Intel, you could expose/fabricate evidence of Smolak building chemical WMDs, taking it to the AN to gain authorization for preemptive airstrikes.

👉 **Question:** What should **Anton Rayne (Sordland)** do here? If Rayne did Operation Bear Trap with Smolak, should Sordland threaten an embargo on Rizia? And how would **Morella** react to a war so close to MITZ assets?

---

Would love to hear your thoughts, crazy ideas, lore checks, or specific dialogue interactions you'd love to see. 

Thanks for reading!
```

---

## 2. Zestawienie Dyskusji i Komentarzy z Reddita

### Wątek 1: Dylemat Sojuszu z Lespią i Alvarez
* **Elzo1993:**
  > *"I think the most hard goal is allying Lespia. Cause I have no idea how little self respect a person must have to ally with Lespia as Rizia. I didn't even finish that one playthrough."*
  > *"Also some sea zones up north feel like they are in Lespian waters."*
* **JIFO_ (Autor):**
  > *"Yeah, that's the goal for the mod - make this alliance even viable. The thing is that alliance with lespia could provide tanks and lespia could help with the supply situation, as the logistics in Brenas is not that great (that's a part of a dispute between house azaro and house Sazon in the mod). Lespia alliance would synergize with the path of providing supplies from afar (Azaro path) and if taken both could give for example +1 military action points in Zille which would make it super worth it. (Sazon path gives the player +1 to support value for every unit still standing in the brenas region which is also very important as the whole Zille border is fortified. Very valid point, I will shrink the northern provinces so they keep a safe distance from lespia's waters. If you have more feedback, I would be super happy to listen, as tomorrow I will post an updated map and some more details about the mod."*
* **Elzo1993 (Kluczowa wątpliwość):**
  > *"But you don't plan to change Alvarez and Lespia's actions outside the war? Cause honestly an action point is NOT worth the humiliation of bending over backwards to him only for him to not even blink at the whole Zille affair and then try to steal Rizia's share."*

---

### Wątek 2: Operacja Lądowa i Wyniki Wojny
* **Karl_Greiser_PolSord:**
  > *"Nur willing, Rizia shall liberate the Wehzeks from Smolak's dictatorial regime. Glovurius axa Rizia!"*
* **GigaRoman:**
  > *"It looks good, though maybe you need more tiles in Wehlen to occupy so they give up. What are the outcomes of the war btw?"*
* **JIFO_ (Autor):**
  > *Rozpisanie 5 wyników wojny (od fiaska po triumf).*

---

### Wątek 3: Pomysł z Bronią Chemiczną / Wojną w Zatoce (Gulf War Style)
* **Karl_Greiser_PolSord:**
  > *"There should be an option where if you improve airforce by choosing airforce prologue, building bomber factory/getting morellan bombers, and expanding the terador airforce base and romus toras military academy flight school, then if you expanded intelligence, you can produce incredibly believable evidence that Wehlen possesses chemical weapons and is building nukes which would allow you to go in AN and present this 'evidence' and then bomb Wehlen into oblivion."*
* **JIFO_ (Autor):**
  > *"I like the idea where you can discover chemical weapons through intel and airforce boosting, that would probably be a good way to get support from the international community for the war but I am not sure what that support could be."*
* **Karl_Greiser_PolSord:**
  > *"Gulf War in Suzerain man."*

---

### Wątek 4: Granice i Geopolityka Derdii
* **Virtual-Ad-2633:**
  > *"I actually have something. Kradną should have different shape. It should be closer to the coast instead of just kinda being next to it."*
* **JIFO_ (Autor):**
  > *"Got it, fixed! Thanks for the feedback."*
* **Wedgeslaus:**
  > *"I think going to war with Wehlen should slightly, if not more- raise Derdia/Golcondist relations. I know you probably don’t want to make the mod conflict with more of the base game but if you may humor me. When meeting with Derdia on Turn 7 maybe bring up the war with Wehlen and if the Wiseman is satisfied with you, he allows you to deploy troops in Yol for the purpose of invading via land (circumnavigating the conundrum of crossing the strait to invade)."*
* **JIFO_ (Autor):**
  > *"That's a really interesting idea, I would seriously consider it and maybe ask some more people what they think. The only thing is that Derdia probably wouldn't want to get involved. It would probably look like the Russian invasion of Ukraine through Belarus where Belarus didn't join the conflict but supported the army logistically. It would require very good relations though."*
* **Open_Huckleberry_144:**
  > *"Very cool, but lore wise I'm sure that invading Wehlen would be impossible. The game said that the coastline is super fortified. And you would be facing them on a very stretched supply line."*

---

## 3. Szczegółowa Architektura Systemu Wojny o Zille

### 5 Stanów Końcowych Wojny (Traktaty Pokojowe)
1. **Stan 1 (Total Military Fiasco):**
   - Gracz traci 3 miasta w prowincji Brenas: Marbelas, Dapalle, Mave Nortus.
   - Wehlen okupuje południowe Brenas. Smolak dyktuje warunki bez negocjacji.
   - Paraliż gospodarczy (-5 Budget, drenaż Energy). Pucz gwarantowany.
2. **Stan 2 (Bolesna Porażka Operacyjna / Raczej Porażka):**
   - **Brak zdobyczy (Status Quo):** Wszystkie startowe miasta Rizii (Brenas) pozostają pod kontrolą Rizii, a wszystkie miasta Wehlen (Zille) pod kontrolą Wehlen. Ponieważ Rizia rozpoczęła operację w celu odzyskania Zille, a po kosztach i ofiarach nie zajęła ani jednego miasta wroga, jest to liczone jako scenariusz drugi (raczej porażka polityczna i operacyjna).
   - **Utrata pozycji:** Strata co najmniej 1 miasta w Brenas bez zrównoważenia zdobyczami w Wehlen.
   - Wymuszone trudne negocjacje: reparacje dla Wehlen, zrzeczenie się roszczeń do Zille pod groźbą buntu w Brenas.
3. **Stan 3 (Zwykły PAT / Krwawy Impas):**
   - **Wymiana terytorialna:** Utrata 1 miasta Rizii w Brenas, ale zajęcie 1 lub 2 miast pod kontrolą Wehlen (np. Wiktrany, Nanta, Munat) LUB zdobycie części półwyspu bez 2 miast.
   - Obie strony ponoszą ciężkie straty. Obustronne znużenie wojną.
   - **Opcja negocjacyjna (Niepodległość Zille):** Przy stole negocjacyjnym w wariancie PAT gracz może doprowadzić do tego, że **Zille zyska pełną niepodległość** (jako neutralne państwo buforowe), jeżeli poczyni drobne koncesje na rzecz Wehlen (np. preferencje handlowo-naftowe, tranzytowe lub rekompensaty).
   - **Rola CSP:** Zerwanie rozmów aktywuje ultimatum Contany i Valgslandu (groźba blokady morskiej).
4. **Stan 4 (Czyste Zwycięstwo):**
   - Pełne wyzwolenie półwyspu Zille.
   - Smolak uznaje realia siły: Zille wraca do Korony natychmiast.
5. **Stan 5 (Triumf Totalny):**
   - Zdobycie Zille + 2 strategicznych punktów w Wehlen (Port Rotsla, Oktan/Grodzizg).
   - Smolak płaci wielkie reparacje (+4 Budget, +3 Energy).
   - Grodzizg uzyskuje status Wolnego Miasta / autonomii. Derdia zachwycona sojuszem.

### 3 Punkty Zapalne (Timing & Rozwiązanie Tury 9)
* **Tura 3/4:** Reakcja na Zille Bombing.
* **Tura 8:** Zerwanie rokowań w Zille. Standardowy dwuturowy cykl operacyjny (Tura 8 i 9).
* **Tura 9:** Błyskawiczna inwazja po sfałszowanym referendum.
  * *Rozwiązanie:* Operacja podwójna (Phase I & II w tej samej turze 9 w kolejnych krokach scenariusza), przejście do traktatu pokojowego w Turze 10.

### Spór Logistyczny: Ród Azaro vs Ród Sazon
* **House Azaro:**
  * Lepsza łączność taktyczna: szybszy cooldown nalotów/artylerii.
  * +1 Azaro Levy.
  * Większy drenaż budżetu z powodu korupcji sztabowej i luksusów oficerskich.
* **House Sazon:**
  * Wykorzystanie sieci handlowych i spichlerzy w Brenas.
  * Redukcja drenażu Energy i Budget o 1 na turę.
  * +1 Sazon Levy oraz bonus obronny dla jednostek stacjonujących w Brenas.
  * Niezadowolenie Lucity Azaro.

### Regionalne Mocarstwa
* **Derdia (Azmal):** Tranzyt przez Yol (model białoruski) w zamian za koncesje religijne i dozgonną wdzięczność.
* **Sordland (Rayne):** Jeśli Rayne brał udział w OBT – wrogość wobec Rizii, zerwanie umów na wino/whiskey. Jeśli odrzucił OBT – cichy handel i życzliwość.
* **Morella (Salane):** Obawa przed wojną blisko MITZ. Ryzyko wstrzymania rurociągów lub zbliżenia z CSP.
* **Rumburg (Beatrice):** Wsparcie sprzętowe przeciw Wehlen, ale wściekłość w przypadku wojny na dwa fronty (Pales + Zille).

---

## 4. Analiza i Rozwiązanie Dylematu: „Alvarez & Sojusz z Lespią”

### Problem postawiony przez Elzo1993:
> *"an action point is NOT worth the humiliation of bending over backwards to him only for him to not even blink at the whole Zille affair and then try to steal Rizia's share."*

Gracz ma w 100% rację w odniesieniu do **psychologii gracza w DLC Rizia**:
1. Patricio Alvarez jest w vanilli protekcjonalny, arogancki i traktuje Rizię jak bananową republikę.
2. Zmuszanie Romusa do upokarzania się przed Lespią tylko po to, by dostać "+1 punkt akcji" na mapie, sprawia, że 95% graczy woli tę ścieżkę całkowicie zignorować. Riziański monarcha ma swoje poczucie dumy.

### Jak to rozwiązać, by sojusz miał głęboki sens i dawał satysfakcję?

#### 1. Zmiana Dynamiki Sił: Rizia zyskuje Dźwignię (Leverage) nad Lespią
W świecie Suzerain **Alvarez nienawidzi Smolaka i Wehlen ponad wszystko**. Dla Lespii i bloku ATO obecność lewicowego dyktatora Smolaka na Merkopie Południowej to wrzód na ciele. W kampanii Sordlandu Alvarez zrywa rozmowy z Raynem tylko za to, że ten brał udział w operacji Smolaka.
* **Wniosek:** Gdy Rizia rozpoczyna wojnę z Wehlen, to **Alvarez zaczyna potrzebować Romusa**, a nie odwrotnie! Rizia staje się taranem niszczącym największego wroga Lespii.

#### 2. Konkretne Koncesje od Alvareza (Nie tylko "+1 AP"):
* **Dyplomatyczna tarcza w AN:** Lespia (i jej arcasiańscy sponsorzy) gwarantują weto wobec wszelkich prób nałożenia sankcji przez CSP/Contanę na Rizię za inwazję na Wehlen.
* **Pakiet Pancerno-Wywiadowczy:** Alvarez przekazuje nowoczesne czołgi Lespii oraz dane z samolotów szpiegowskich (odblokowujące jednostkę spadochroniarzy / paratrooper drop).
* **Koncesje w MITZ i Ropie:** Zamiast okradać Rizię z udziałów, Alvarez w zamian za rozbicie Wehlen zgadza się na korzystniejszy podział zysków z tranzytu ropy lub dofinansowuje odbudowę rafinerii Zille (+3 Budget w Turze 10).

#### 3. Satysfakcja Narracyjna (Możliwość utarcia nosa Alvarezowi):
W dialogach Romus nie zachowuje się jak petent, lecz jak twardy gracz geostrategiczny:
> *"Patricio, moje dywizje właśnie robią to, na co Arcasia i Lespia nie miały odwagi przez dekadę: usuwają Smolaka. Albo wyłożycie na stół czołgi, dane satelitarne i uciszycie Contanę w AN, albo podpiszę ze Smolakiem rozejm i zostawię was samych z tym bałaganem."*

Dzięki temu gracz czuje, że **rozgrywa Alvareza jak pionka**, realizując riziańskie interesy rękami i pieniędzmi Lespii, zamiast „płaszczyć się” przed pijanym prezydentem.

---

## 5. Event Przednegocjacyjny: Narada Sztabowa i Ostatnie Telefony

Ten event (`SnO_ZillePreNegotiationsBriefing`) odpala się tuż przed bezpośrednimi rokowaniami ze Smolakiem, w punkcie kulminacyjnym działań zbrojnych.

### A. Narada z Radą Królewską (The War Council)
Wszyscy doradcy bez wyjątku naciskają na **jak najszybsze zakończenie wojny**:
* **Gdy Rizia wygrywa:** Zagrożenie logistyczne. Linie zaopatrzeniowe w Zille są rozciągnięte do granic możliwości, magazyny pocisków i paliwa świecą pustkami, a dalszy marsz grozi załamaniem frontu z powodu braku zaplecza.
* **Gdy Rizia przegrywa:** Katastrofa humanitarno-moralna. W przygranicznych garnizonach szerzy się dezercja, żołnierze buntują się przeciw oficerom, a wieści o stratach wywołują panikę na ulicach Porte Drazon.

#### Ocena Ekonomiczna (Elena Flores & Laurento Esquibel):
* **Elena Flores** bezlitośnie podsumowuje drenujący wpływ wojny na budżet państwa i rezerwy energetyczne. Wskazuje graczowi dokładnie, jak głęboko w kryzysie znajduje się Królestwo i ile tur zostało do bankructwa.
* **Gdy nastąpiło Fiasko Operacyjne:** Atmosfera w sali jest grobowa. Hugo Toras traci panowanie nad sobą, rzucając oskarżeniami o zdradę i niekompetencję sztabu. Lucita jest wstrząśnięta, a Titus przygotowuje plany ewakuacji rodziny królewskiej.

#### Kluczowy Spór o Koncesje (Ograniczenie Armii jako Warunek Pokoju):
W scenariuszach impasu i porażki Wehlen żąda demilitaryzacji i limitu riziańskich sił zbrojnych:
* **Frakcja Wojskowo-Arystokratyczna (Lucita Azaro & Hugo Toras):**
  * Kategoryczny sprzeciw: *"Ograniczenie naszej armii to hańba, na którą Korona nie może przystać! Zostaniemy bezbronni wobec Pales, a ród Azaro nigdy nie wybaczy obcięcia pułków!"*
* **Frakcja Pragmatyczno-Dyplomatyczna (Elena Flores & Laurento Esquibel):**
  * Sprytna kalkulacja: *"Nasza armia i tak zachowa rdzeń weteranów. Demobilizacja nadmiaru poborowych pozwoli zaoszczędzić miliony w budżecie, a na arenie międzynarodowej zdejmie z nas łatkę barbarzyńskich agresorów (szczególnie istotne, jeśli prowadzimy wojnę na dwa fronty z Pales!)."*

---

### B. Królewskie Telefony Last-Minute (Opcjonalne Połączenia Dyplomatyczne)
Przed wejściem do namiotu negocjacyjnego Romus może udać się do gabinetu łączności i wykonać telefony do trzech przywódców:

#### 1. Telefon do Patricio Alvareza (Lespia)
* **Stanowisko Alvareza:** Alvarez kategorycznie odradza jakikolwiek kompromis z Wehlen (*"Nie podpisujcie z tym psem niczego! Zmiażdżcie go!"*). Jednak zapytany o wsparcie, natychmiast się wycofuje: Lespia nie wyśle ani jednego konwoju z zaopatrzeniem, zasłaniając się ryzykiem politycznym w parlamencie i obawą przed bezpośrednią eskalacją z CSP.
* **Ścieżki odpowiedzi Romusa:**
  1. **Paniczna / Błagalna:** Romus żebrze o pomoc $\rightarrow$ Alvarez z pogardą kończy rozmowę, traktując Rizię jak słabeusza.
  2. **Spokojna i Rzeczowa:** Romus chłodno tłumaczy wyczerpanie zapasów i realia frontu $\rightarrow$ Alvarez szanuje profesjonalizm, choć pozostaje nieugięty.
  3. **Chytra / Makiaweliczna:** *"Patricio, jeśli teraz wycofacie wsparcie, podpiszę ze Smolakiem rozejm, a Wehlen pozostanie potęgą u waszych granic. Wasz najlepszy scenariusz umrze razem z tą wojną."* $\rightarrow$ Alvarez jest wściekły, ale imponuje mu odwaga Romusa.
* **Rezultat:** Brak natychmiastowych posiłków, ale zachowanie szacunku Alvareza i zabezpieczenie powojennych relacji handlowych.

#### 2. Telefon do Emmericha Hegela (Valgsland / CSP)
* **Początek rozmowy:** Wściekły Hegel wrzeszczy do słuchawki, uderza w stół i wyzywa Romusa od feudalnych imperialistów gnębiących rewolucyjny lud Wehlen.
* **Eskalacja i Groźba:** Hegel uspokaja się na tyle, by postawić twarde ultimatum: jeśli Wehlen zostanie zniszczone, a wolny handel morski zablokowany, czerwona flota Valgslandu osobiście wpłynie do wód terytorialnych i zakończy tę wojnę.
* **Propozycja Transakcyjna (Deeskalacja za Korzyści):**
  * Jeśli Rizia wynegocjuje pokój i przywróci stabilność, Valgsland jest gotów na tajną ofertę:
    * **Wariant A (Gdy Rizia walczy z Pales):** Sprzedaż nowoczesnych jednostek nawodnych za bezcen: **1 Budget za 1 Okręt Wojenny i 1 Okręt Podwodny** (trafiają bezpośrednio do rezerw/stockpile marynarki).
    * **Wariant B (Gdy Rizia NIE walczy z Pales):** Transfer **+2 Energii** (paliwo na powojenną odbudowę obu krajów), o ile traktat pokojowy ze Smolakiem będzie zawierał klauzulę o obustronnym ograniczeniu obecności marynarki wojennej na wodach Zille.

#### 3. Telefon do Królowej Beatrice Livingston (Rumburg)
Postawa Beatrice zależy ściśle od stanu relacji i lojalności wobec GRACE:
* **Gdy Rizia opuściła GRACE lub ma złe relacje:** Beatrice jest lodowato chłodna i arogancka. Każe Romusowi natychmiast podpisać cokolwiek i zgasić pożar, bo wojna odwraca uwagę od jej północnych planów i zmusza Wehlen do niebezpiecznego zbrojenia się.
* **Gdy Rizia jest lojalnym członkiem GRACE:** Beatrice jest serdeczna i protekcjonalna. Obiecuje, że w chwili zniesienia stanu wojennego Rumburg natychmiast podpisze gigantyczny kontrakt na import ropy z Rizii, zapewniając stały napływ dewiz do skarbca.

---

## 6. Ścieżka Wczesnego Ataku (Tura 3/4): 2 Plany Operacyjne

Po zamachu bombowym w Zille (Dzień Przyjaźni w Turze 2/3) Romus ma możliwość natychmiastowego odrzucenia gierek Smolaka. Inwazja wczesna dzieli się na dwa zasadnicze warianty doktrynalne:

```
                     ┌──────────────────────────────────────────┐
                     │     ZAMACH W ZILLE (KONIEC TURY 2/3)     │
                     └────────────────────┬─────────────────────┘
                                          │
                  ┌───────────────────────┴───────────────────────┐
                  ▼                                               ▼
     ┌────────────────────────┐                      ┌────────────────────────┐
     │        PLAN A:         │                      │        PLAN B:         │
     │   Atak z Zaskoczenia   │                      │ Legalistyczne Ultimatum│
     │      (Blitzkrieg)      │                      │     & Presja na AN     │
     └────────────┬───────────┘                      └────────────┬───────────┘
                  │                                               │
     ├─ Zille należy się po 25               ├─ Odrzucenie przedłużenia umowy
     │  latach automatycznie                 ├─ Skarga do AN o terroryzm Wehlen
     ├─ Smolak NIEPRZYGOTOWANY               ├─ Cyniczne "zabezpieczenie traktatu"
     ├─ Armia Rizii w pośpiechu              └─ Rozgrzane dywizje pancerne
     └─ Narracja: "Obrona przed                 gotowe do szturmu na granicy
        prowokacją i terrorem"
```

### Plan A: Błyskawiczny Atak z Zaskoczenia (Preemptive Surprise Blitz)
* **Podstawa prawno-polityczna:** 25-letni traktat króla Valero właśnie dobiegł końca w dniu obchodów. Zille wraca do Korony z mocy prawa. Zamach bombowy był sfingowaną prowokacją Wehlen (false-flag), mającą dać pretekst do kradzieży złóż naftowych. Rizia nie będzie negocjować z terrorystami.
* **Realia Pola Walki:**
  * **Element zaskoczenia:** Smolak nie zdążył zaminować dróg ani obsadzić garnizonów pełnymi siłami Wehzek Guards.
  * **Cena pośpiechu:** Riziańska armia również nie miała czasu na pełną mobilizację logistyczną. Brakujące zapasy amunicji zmuszają do agresywnego parcia naprzód.
* **Komunikat Propagandowy:** *"Siły Zbrojne Królestwa wkroczyły do Zille w celu ochrony ludności cywilnej przed zbrodniczą prowokacją reżimu Wehlen. Przywracamy prawowity porządek."*

### Plan B: Legalistyczne Ultimatum i Zabezpieczenie Mandatu AN (The "Peacekeeping" Armor)
* **Podstawa prawno-polityczna:** Gdy Smolak ogłasza, że "ze względów bezpieczeństwa i trwającego śledztwa nie przekaże Zille w terminie", Romus występuje na arenie międzynarodowej.
* **Retoryka:** Umowy międzynarodowe nie podlegają jednostronnemu widzimisię dyktatora. Rizia składa oficjalny protest do AN i żąda natychmiastowej rezolucji nakazującej ewakuację Wehlen.
* **Cynizm Operacyjny:** Oficjalnie wojska Rizii przekraczają granicę pod błękitną flagą "misji pokojowego zabezpieczenia wykonania traktatu z 1929 roku". W rzeczywistości na granicy stoją skoncentrowane szpice pancerne rodu Azaro z bezwzględnym rozkazem zmiecenia każdego posterunku Wehlen, który odmówi złożenia broni w ciągu 15 minut.

---

## 7. Zarządzanie Czasem, Lukami i Chronologią (Early vs Late Game)

Ponieważ wojna może wybuchnąć w **3 różnych momentach**, system eventów i flag musi dynamicznie adaptować się do osi czasu:

| Moment Wybuchu | Czas Trwania Wojny | Status Wojny z Pales | Sytuacja z AN / MITZ | Finał Działań |
| :--- | :--- | :--- | :--- | :--- |
| **Wczesny (Tura 3/4)** | Tury 4–6 | Pales jest POKOJOWE (incydent na morzu dopiero nadchodzi w Turze 5/6) | Sesja AN w Turze 8 ocenia już FAKT DOKONANY wojny w Zille | Negocjacje pokojowe w Turze 6 |
| **Środkowy (Tura 8)** | Tury 8–9 | Wojna z Pales MOŻE TRWAĆ równolegle (Wojna na 2 fronty!) | AN debatuje o Zille tuż przed uderzeniem | Negocjacje pokojowe w Turze 9/10 |
| **Późny (Tura 9)** | Tura 9 (Faza I & II) | Finał wojny z Pales lub Pales wchłonięte/pokojowe | Po sfałszowanym referendum | Negocjacje pokojowe w Turze 10 |

### Jak uniknąć niespójności fabularnych?
1. **Separacja Zmiennej Pales:** 
   W dialogach z Alvarezem, Hegelem i doradcami sprawdzana jest flaga `RiziaDLC.Pales_War == true`. Jeśli wojna z Pales trwa, doradcy histeryzują o braku rezerw. Jeśli nie trwa – Rizia ma wolną rękę na południu.
2. **Dynamiczne Teksty w Sesji AN (Tura 8):**
   Jeśli gracz wybrał **Ścieżkę Wczesnego Ataku (Tura 3/4)** i wojna zakończyła się w Turze 6, przemówienie Romusa w AN w Turze 8 (`FPnT_ANSession`) zmienia się z: *"Smolak nie chce oddać Zille"* na: *"Rizia obroniła swoje prawa i wyzwoliła Zille z rąk dyktatora, a Wehlen musi zapłacić odszkodowania"*.
3. **Kompresja Operacyjna Tury 9:**
   Dla inwazji w Turze 9 silnik odpala dwie fazy bitewne w jednym ciągu turowym, dzięki czemu traktat pokojowy i rozmowy przednegocjacyjne idealnie zbiegają się z wielkim finałem kampanii w Turze 10.

