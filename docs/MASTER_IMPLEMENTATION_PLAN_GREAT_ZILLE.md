# The Great Zille Solution: Gigantyczny Kompletny Plan Wdrożenia (Master Implementation Plan)

*Techniczny, architektoniczny i produkcyjny plan wdrożenia moda „The Great Zille Solution” do gry Suzerain: Kingdom of Rizia.*
*Wersja: 1.0.0-PROD | Cel: Pełna integracja z silnikiem Unity, PixelCrushers DialogueSystem i GameFlow.*

---

## SPIS TREŚCI
1. [Architektura Systemowa i Hooki Silnika (Engine & Patcher)](#1-architektura-systemowa-i-hooki-silnika-engine--patcher)
2. [Integracja Mapy Taktycznej i Mechaniki Walki (Hex War Engine)](#2-integracja-mapy-taktycznej-i-mechaniki-walki-hex-war-engine)
3. [Silnik Sterowania Przepływem Gry (GameFlow Rescheduling Engine)](#3-silnik-sterowania-przepływem-gry-gameflow-rescheduling-engine)
4. [Potok Konwersji i Wstrzykiwania Dialogów (Dialogue Pipeline)](#4-potok-konwersji-i-wstrzykiwania-dialogów-dialogue-pipeline)
5. [Specyfikacja Techniczna 6 Nowych Scen Modu](#5-specyfikacja-techniczna-6-nowych-scen-modu)
6. [Gospodarka, Zasoby i Zmienne Stanu Państwa](#6-gospodarka-zasoby-i-zmienne-stanu-państwa)
7. [System Diagnostyki, Menu F9 i Zautomatyzowane Testy QA](#7-system-diagnostyki-menu-f9-i-zautomatyzowane-testy-qa)
8. [Harmonogram Produkcyjny i Kamienie Milowe](#8-harmonogram-produkcyjny-i-kamienie-milowe)

---

## 1. Architektura Systemowa i Hooki Silnika (Engine & Patcher)

Gra *Suzerain* zbudowana jest w środowisku Unity (wersja 2021/2022) w architekturze Mono / IL2CPP. Warstwa narracyjna operuje w oparciu o silnik **PixelCrushers Dialogue System** oraz autorski automat stanów Torpor Games (`Torpor.StoryPack`, `GameFlow`, `EntityDataManager`).

### 1.1. Patcher Framework: BepInEx + HarmonyX
Modyfikacja ładowana jest jako plugin BepInEx 5.x / 6.x.
Główny punkt wejścia (`GreatZillePlugin.cs`):
```csharp
using BepInEx;
using HarmonyLib;
using PixelCrushers.DialogueSystem;
using UnityEngine;

[BepInPlugin("com.greatzille.solution", "The Great Zille Solution", "1.0.0")]
public class GreatZillePlugin : BaseUnityPlugin
{
    private Harmony harmony;

    void Awake()
    {
        harmony = new Harmony("com.greatzille.solution");
        harmony.PatchAll();
        Logger.LogInfo("[Great Zille Solution] Native Patches Injected Successfully.");
    }
}
```

### 1.2. Punkty Wstrzyknięć Harmony (Critical Patches)
1. **`DialogueManager.Awake` / `MasterDatabase`:**
   - *Cel:* Po załadowaniu oficjalnej bazy dialogowej gry, patcher wstrzykuje nowe assety konwersacji (ID 9988–9993) oraz dodaje brakujące węzły do istniejących konwersacji.
2. **`GameFlow.ExecuteStep` & `GameFlow.TriggerConversation`:**
   - *Cel:* Przechwytywanie kroków w Turze 8, 9 i 10, blokowanie scen anulowanych (`[INTERRUPT]`) oraz dynamiczne przekierowanie na zmodyfikowane eventy wojenne.
3. **`OperationManager.StartOperation`:**
   - *Cel:* Inicjalizacja operacji taktycznej Zille z dedykowanymi hexami z `wartiles_dump.json`.

---

## 2. Integracja Mapy Taktycznej i Mechaniki Walki (Hex War Engine)

Kampania o Zille wykorzystuje sprawdzony system walki z Pales (Operation Golden Shield), rozszerzając go o dedykowany teatr południowy.

### 2.1. Teatr 4 Miast Półwyspu Zille + 3 Miasta Osłonowe Brenas
Na podstawie wyekstrahowanych danych z `docs/wartiles_dump.json` oraz `docs/operation_data_dump.json`:

```
                           [PORT ROTSLA (Wehlen)]
                                     ▲
                                     │ (Zaopatrzenie morskie)
                                     ▼
                            [MUNAT (Północ)]
                                   ▲
                                   │ (Szosa Nadmorska)
                                   ▼
 [ZILLE (Twierdza Główna)] ◄──► [WIKTRANY (Węzeł Centralny)] ◄──► [NANTA (Wschód)]
                                   ▲
                          (Przełęcz i Bagna)
                                   ▼
          ─────────────────────────────────────────────────────────────
                          DEMARKACJA GRANICY BRENAS
          ─────────────────────────────────────────────────────────────
               ▲                           ▲                         ▲
               │                           │                         │
     [MARBELAS (Sazon)]           [DAPALLE (Sazon)]        [MAVE NORTUS (Sazon)]
```

### 2.2. Kafelki Operacyjne (Wartiles Mapping)
* **`Zille_City_Center` (Hex #101):** Miasto stołeczne, 3 poziomy fortyfikacji, osłona rafinerii. Wymaga okrążenia lub zmasowanego przygotowania artyleryjskiego.
* **`Wiktrany_Junction` (Hex #102):** Klucz do całego półwyspu. Przejęcie węzła odcina dostawy z Wehlen do Zille i Nanty.
* **`Munat_Deepwater_Port` (Hex #103):** Głęboki port. Cel uderzenia Planu Beta lub desantu spadochronowego z Lespii.
* **`Nanta_Redoubts` (Hex #104):** Posterunki graniczne Wehlen, magazyny amunicji.
* **`Brenas_Buffer_Marbelas/Dapalle/MaveNortus` (Hex #201-#203):** Miasta Rizii. Jeśli Smolak przełamie linię obrony i zajmie wszystkie 3 — gracz ponosi **Total Fiasco (Stan 1)**.

### 2.3. Akcje Wsparcia i Doktryny Sojusznicze
* **Wsparcie Azaro:** Koszt: 2 AP. Natychmiastowy nalot bombowy na pozycje wroga w zasięgu 2 hexów.
* **Wsparcie Sazon:** Koszt: 1 AP. Przywrócenie 1 punktu wytrzymałości i amunicji dowolnej jednostce w prowincji Brenas.
* **Desant ATO (Patricio Alvarez):** Dostępny, jeśli podpisano Pakt z Lespią. Zrzut jednostki spadochronowej na dowolny niezajęty hex za linią wroga (np. pod Munat).
* **Rajd Nurycki (Wiseman Azmal):** Dostępny, jeśli zawarto układ z Derdią. Dywersja niszcząca punkty obronne węzła Wiktrany.

---

## 3. Silnik Sterowania Przepływem Gry (GameFlow Rescheduling Engine)

### 3.1. Reorganizacja Kroków w Turze 8, 9 i 10
Poniższy algorytm patchera zarządza egzekucją kroków w zależności od aktywnego wariantu wojny:

```csharp
[HarmonyPatch(typeof(GameFlow), "ExecuteStep")]
public static class GameFlow_StepInterceptor_Patch
{
    static bool Prefix(GameFlow __instance, int stepIndex)
    {
        int turn = __instance.CurrentTurn;
        bool isZilleWar = DialogueLua.GetVariable("Zille_War_Active").asBool;
        int warVariant = DialogueLua.GetVariable("Zille_War_Variant").asInt;

        // TUR 9 INTERRUPTS & RESCHEDULING
        if (turn == 9 && isZilleWar)
        {
            // Blokada spokojnego wieczoru ze Smolakiem
            if (__instance.CurrentStepName == "Turn9_FPnT_CallWithSmolak")
            {
                __instance.TriggerConversation("9992_ZilleWar_SmolakFinalParley");
                return false; // Pomijamy vanilla step
            }

            // Blokada referendum w War. B (wojna wybuchła w T8)
            if (warVariant == 2 && (__instance.CurrentStepName == "Turn9_FPnT_ZilleReferendum" || 
                                    __instance.CurrentStepName == "Turn9_FPnT_ZilleReferendumInterference"))
            {
                // Zamiast referendum odpalamy Fazę IIb operacji wojennej
                OperationManager.Instance.LaunchPhase("Zille_Operation_Phase2B");
                return false;
            }

            // Blokada pokojowego przemówienia w T9
            if (__instance.CurrentStepName == "Turn9_A_ZilleReturnedSpeech")
            {
                // Przesunięte na Turę 10 po traktacie
                return false;
            }
        }

        // TURA 10 TRAKTAT POKOJOWY I FAZA III
        if (turn == 10 && isZilleWar && stepIndex == 1)
        {
            if (warVariant == 3) // Wariant C: Faza III szturmu
            {
                OperationManager.Instance.LaunchPhase("Zille_Operation_Phase3_FinalAssault");
            }
            else // Wariant B: Natychmiastowy Traktat Pokojowy
            {
                __instance.TriggerConversation("9993_ZilleWar_PeaceTreaty");
            }
        }

        return true; // Domyślna egzekucja
    }
}
```

---

## 4. Potok Konwersji i Wstrzykiwania Dialogów (Dialogue Pipeline)

### 4.1. Struktura Bazy PixelCrushers
W silniku `PixelCrushers.DialogueSystem.DialogueDatabase` każda konwersacja posiada unikalny identyfikator numeryczny (`Conversation.id`), węzły dialogowe (`DialogueEntry`), warunki logiczne (`ConditionsString`) oraz skrypty wyjściowe (`UserScript`).

```
                    ┌──────────────────────────────────────────┐
                    │    PixelCrushers Master Database         │
                    └─────────────────────┬────────────────────┘
                                          │
                  ┌───────────────────────┴───────────────────────┐
                  ▼                                               ▼
     ┌────────────────────────┐                      ┌────────────────────────┐
     │  Vanilla Conversations │                      │ Great Zille Mod Pack   │
     │  (ID: 1 - 599)         │                      │ (ID: 9988 - 9995)      │
     └────────────┬───────────┘                      └────────────┬───────────┘
                  │                                               │
                  ├─ [FLAVOR INJECTS] (Nowe kwestie)             ├─ 9988: War Council Briefing
                  ├─ [BRANCHES] (Nowe rozwidlenia)               ├─ 9989: War Balcony Speech
                  └─ [INTERRUPTS] (Przekierowania)               ├─ 9990: Logistics Dispute
                                                                  ├─ 9991: Pre-Negotiations
                                                                  ├─ 9992: Smolak Front Parley
                                                                  └─ 9993: Peace Treaty (5 Stanów)
```

### 4.2. Format JSON Assetu Wstrzykiwanej Konwersacji
Patcher odczytuje definicje scen z plików JSON w katalogu `mods/GreatZille/dialogues/`. Przykładowa struktura węzła:
```json
{
  "id": 9991,
  "title": "Zille/PreNegotiationsBriefing",
  "entries": [
    {
      "id": 10,
      "actor": 10,
      "conversant": 95,
      "dialogueText": "The war room in Porte Drazon was buried under a blizzard of urgent dispatches. Across the table, Elena Flores looked up, dark circles ringing her eyes.",
      "conditionsString": "Variable[\"Zille_War_Active\"] == true",
      "userScript": "",
      "outgoingLinks": [20, 21]
    }
  ]
}
```

---

## 5. Specyfikacja Techniczna 6 Nowych Scen Modu

Poniższa specyfikacja definiuje kompletne parametry rejestracyjne silnika dla 6 nowych scen:

### 1. `9988_WarCouncil_Briefing` (Zille Invasion Briefing)
* **Kiedy odpalać:**
  - Wariant A: Tura 4, Krok 1 (po debriefingu T3).
  - Wariant B: Tura 8, Krok 2 (po fiasku negocjacji w `SnO_SecurityBriefAndZille`).
  - Wariant C: Tura 9, Krok 10 (po ogłoszeniu sfałszowanego referendum).
* **Lokalizacja w grze:** `Porte Drazon Palace - War Chambers`.
* **Uczestnicy:** Narrator, Romus, Lucita Azaro, Hugo Toras, Titus Griz, Laurento Esquibel, Elena Flores.
* **Kluczowy wybór gracza:**
  - `Plan Alfa` (`Variable["Zille_War_Alfa"] = true;`): Frontalny szturm pancerny na miasto Zille.
  - `Plan Beta` (`Variable["Zille_War_Beta"] = true;`): Oskrzydlenie przez Wiktrany i desant na port Munat.
  - `Wstrzymanie inwazji` (tylko wariant B/C przed pierwszym strzałem).

### 2. `9989_ZilleWar_BalconySpeech` (Zille War Speech)
* **Kiedy odpalać:**
  - Wariant A: Tura 4, Krok 3.
  - Wariant B: Tura 8, Krok 4.
  - Wariant C: Tura 9, Krok 11.
* **Lokalizacja:** `Porte Drazon Palace - Royal Balcony & Radio Transmitter`.
* **Ton:** Orędzie do narodu, mobilizacja patriotyczna, odpowiedź na terror Wehlen.
* **Efekt skryptowy:** `RiziaDLC.Resources_Authority += 2; RiziaDLC.Country_PublicOpinion += 1;`.

### 3. `9990_ZilleWar_LogisticsDispute` (Spór Logistyczny Azaro vs Sazon)
* **Kiedy odpalać:**
  - Wariant A: Tura 4, Krok 7.
  - Wariant B: Tura 8, Krok 6.
  - Wariant C: Tura 9, Krok 12.
* **Uczestnicy:** Lucita Azaro, Angelica Sazon, Manus Sazon, Elena Flores.
* **Kluczowy wybór gracza:**
  - `Opcja Azaro`: Szybszy cooldown nalotów artyleryjskich, +1 Azaro Levy, ale `-2 Budget` (korupcja i marnotrawstwo sztabowe).
  - `Opcja Sazon`: Oparcie na spichlerzach i kupcach Brenas, redukcja drenażu energii/budżetu o 1 na turę, +1 Sazon Levy, bonus obronny miast Brenas, ale niezadowolenie Lucity Azaro (`HouseAzaro_Opinion -= 1`).

### 4. `9991_ZilleWar_PreNegotiationsBriefing` (Narada Przednegocjacyjna & Ostatnie Telefony)
* **Kiedy odpalać:**
  - Wariant A: Tura 6, Krok 2.
  - Wariant B: Tura 9, Krok 6.
  - Wariant C: Tura 10, Krok 1.
* **Zawartość:**
  - Panel A: Narada z Radą Królewską (raporty strat, kalkulacja demobilizacji, panika przed bankructwem).
  - Panel B: Gabinet łączności (3 opcjonalne telefony last-minute):
    - *Patricio Alvarez (Lespia):* Odradza kompromis, odmawia posiłków bez koncesji, Romus może go zaszantażować.
    - *Emmerich Hegel (Valgsland):* Krzyk, groźba interwencji Czerwonej Floty, oferta deeskalacji za okręty wojenne (1 Budżet za 1 Okręt Wojenny i 1 Okręt Podwodny) lub +2 Energii.
    - *Queen Beatrice (Rumburg):* Wsparcie za ropę lub chłodna reprymenda za dwufrontowość.

### 5. `9992_ZilleWar_SmolakFinalParley` (Ostatnia Rozmowa ze Smolakiem)
* **Kiedy odpalać:**
  - Wariant A: Tura 6, Krok 3.
  - Wariant B: Tura 9, Krok 8 (zastępuje `Turn9_FPnT_CallWithSmolak`).
  - Wariant C: Tura 10, Krok 2.
* **Lokalizacja:** Namiot negocjacyjny na pasie ziemi niczyjej pod Zille lub zabezpieczona polowa linia telefoniczna.
* **Dynamika:** Konfrontacja z pokonanym lub triumfującym Smolakiem przed ostatecznym podpisaniem traktatu.

### 6. `9993_ZilleWar_PeaceTreaty` (Traktat Pokojowy - 5 Stanów Końcowych)
* **Kiedy odpalać:**
  - Wariant A: Tura 6, Krok 4.
  - Wariant B: Tura 10, Krok 1.
  - Wariant C: Tura 10, Krok 3.
* **5 Wariantów Finału:**
  1. *Total Fiasco:* Wehlen okupuje Brenas, utrata Marbelas/Dapalle/Mave Nortus, `-5 Budget`, pucz gwarantowany.
  2. *Tactical Defeat:* Utrata 1 miasta Brenas, reparacje dla Wehlen, zrzeczenie się roszczeń do Zille.
  3. *Bloody Stalemate:* Częściowe zdobycze w Zille lub rajd na Port Rotsla, obustronne reparacje, demilitaryzacja.
  4. *Decisive Victory:* Pełne wyzwolenie Zille, natychmiastowa reaneksja do Korony, powrót uchodźców.
  5. *Overwhelming Triumph:* Zdobycie Zille + Port Rotsla/Grodzizg, Wehlen płaci gigantyczne reparacje (`+4 Budget, +3 Energy`), Grodzizg staje się Wolnym Miastem.

---

## 6. Gospodarka, Zasoby i Zmienne Stanu Państwa

### 6.1. Zmienne Systemowe Silnika (Data Dictionary)
Patcher rejestruje następujące zmienne w tablicy `DialogueLua`:

| Zmienna | Typ | Opis |
| :--- | :--- | :--- |
| `Zille_War_Active` | `bool` | Czy w danej turze trwają działania wojenne w Zille. |
| `Zille_War_Variant` | `int` | 1 = Wczesny (T3/4), 2 = Środkowy (T8), 3 = Późny (T9). |
| `Zille_War_Phase` | `int` | Bieżąca faza operacyjna (1, 2, 3). |
| `Zille_War_Doctrine` | `string` | `"Alfa"` (frontalny) lub `"Beta"` (oskrzydlenie Munat). |
| `Zille_War_Logistics` | `string` | `"Azaro"` (militarna) lub `"Sazon"` (spichlerze kupieckie). |
| `Zille_War_Outcome` | `int` | Wynik końcowy (1 = Fiasco, 2 = Defeat, 3 = Stalemate, 4 = Victory, 5 = Triumph). |
| `Zille_TwoFrontWar` | `bool` | Równoległa wojna z Pales i Wehlen. |
| `Zille_LespiaPact_Signed` | `bool` | Pakt z Alvarezem (dane satelitarne, desant, weto w AN). |
| `Zille_DerdiaPact_Signed` | `bool` | Korytarz tranzytowy przez Yol z Azmalem. |
| `Zille_HegelPact_Signed` | `bool` | Tajne porozumienie deeskalacyjne z Valgslandem. |

### 6.2. Koszty Operacyjne i Wpływ na Rezerwy
W każdej turze trwania wojny silnik aplikuje kalkulację kosztów:
* **Drenaż Bazowy:** `-1 Budget, -1 Energy` na turę.
* **Modyfikator Doktryny Logistycznej:**
  - Jeśli wybrano `Azaro`: `-1 dodatkowy Budget` (korupcja i luksusy oficerskie).
  - Jeśli wybrano `Sazon`: `+1 redukcja drenażu Energy i Budget` (lokalne zapasy żywności i paliwa).
* **Kara za Dwufrontowość (`Zille_TwoFrontWar == true`):**
  - Dodatkowo `-2 Budget, -2 Energy` na turę z powodu rozciągnięcia transportu morskiego i kołowego.

---

## 7. System Diagnostyki, Menu F9 i Zautomatyzowane Testy QA

### 7.1. Wbudowane Menu Deweloperskie (Klawisz F9)
Podczas gry naciśnięcie klawisza **`F9`** otwiera diagnostyczny panel ImGUI:
* **War Status Indicator:** Wyświetla stan `Zille_War_Active`, aktywny wariant, stan frontu i poziom zniszczeń.
* **Instant Outbreak Trigger:** Ręczne wywołanie inwazji w dowolnej turze (Wariant A, B lub C).
* **Outcome Force Selector:** Wymuszenie jednego z 5 Stanów Końcowych w celach testowania epilogów.
* **Variable Inspector & Editor:** Podgląd i edycja zmiennych `RiziaDLC.Resources_Budget`, `Energy`, `Authority`.

### 7.2. Automatyzacja Testów Integralności Grafu Dialogowego
W ramach potoku CI/CD skrypt testowy weryfikuje bazę danych:
1. **Broken Link Audit:** Sprawdzenie, czy każdy wychodzący link dialogowy wskazuje na istniejący węzeł.
2. **Orphan Node Check:** Wyszukiwanie węzłów, do których nie prowadzi żadna ścieżka.
3. **Deadlock / Infinite Loop Scan:** Weryfikacja braku nieskończonych cykli w hubach dyskusyjnych.
4. **Variable Type Safety:** Upewnienie się, że wszystkie zapytania w `ConditionsString` operują na istniejących zmiennych silnika.

---

## 8. Harmonogram Produkcyjny i Kamienie Milowe

```
┌────────────────────────────────────────────────────────────────────────────────────────┐
│                        HARMONOGRAM WDROŻENIA MODA "GREAT ZILLE"                        │
├────────────────────────────────────────────────────────────────────────────────────────┤
│ FAZA 1: FUNDAMENTY SILNIKA & PATCHER (Tydzień 1 - 2)                                   │
│ • Przygotowanie BepInEx patchera i biblioteki HarmonyX.                                │
│ • Rejestracja hooków w DialogueManager i MasterDatabase.                               │
│ • Implementacja struktur danych w tablicy DialogueLua.                                 │
├────────────────────────────────────────────────────────────────────────────────────────┤
│ FAZA 2: TEATR WOJENNY & KAFELKI TAKTYCZNE (Tydzień 3 - 4)                              │
│ • Wdrożenie mapy 4 miast Zille na siatce heksagonalnej z wartiles_dump.json.           │
│ • Skonfigurowanie jednostek Wehzek Republican Guards oraz riziańskich korpusów.        │
│ • Oprogramowanie wsparcia Azaro, Sazon, Lespii i Derdii.                               │
├────────────────────────────────────────────────────────────────────────────────────────┤
│ FAZA 3: DIALOGI & RESTRUKTURYZACJA KROKÓW (Tydzień 5 - 6)                              │
│ • Wstrzyknięcie 6 nowych scen (ID 9988 - 9993) do PixelCrushers.                       │
│ • Oprogramowanie GameFlow_StepInterceptor dla Tur 8, 9 i 10.                           │
│ • Wdrożenie przesunięć eventów (mowa o Zille, referendum, Beatrice).                   │
├────────────────────────────────────────────────────────────────────────────────────────┤
│ FAZA 4: POLISHING NARRACYJNY & TONE PASS (Tydzień 7)                                   │
│ • Implementacja wstrzyknięć Narratora dla wszystkich tur (Prolog - Epilog).            │
│ • Weryfikacja głosu postaci zgodnie z Character Bible v2.0.                            │
│ • Korekta 5 epilogów traktatowych.                                                     │
├────────────────────────────────────────────────────────────────────────────────────────┤
│ FAZA 5: TESTY QA, BALANS & WYDANIE (Tydzień 8)                                         │
│ • Zautomatyzowany audyt drzew dialogowych bez softlocków.                              │
│ • Balans ekonomiczny drenażu budżetowego w testach z Pales i bez Pales.                │
│ • Publiczny release v1.0.0 na NexusMods i GitHub.                                      │
└────────────────────────────────────────────────────────────────────────────────────────┘
```
