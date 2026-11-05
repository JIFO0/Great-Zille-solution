# Rizia/Turn 6/Intro Section

- **ID konwersacji:** `373`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Rizia/Turn_06/373_Intro_Section.md`
- **Liczba węzłów dialogowych:** 197
- **Liczba wyborów gracza:** 48

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[68]** Hugo Toras
- **[79]** Vina Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming`
- `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Turn06_WarSpeech_EntireFamily`
- `RiziaDLC.Turn06_WarSpeech_Estela`
- `RiziaDLC.Turn06_WarSpeech_EstelaHugo`
- `RiziaDLC.Turn06_WarSpeech_Hugo`
- `RiziaDLC.Turn06_WarSpeech_RomusAlone`
- `RiziaDLC.Turn06_WarSpeech_Vina`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[372] Rizia/Turn 6/A_PalaceBalconySpeech** (../Turn_06/372_A_PalaceBalconySpeech.md), Węzeł `[458]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""We must also remember the toll conflict takes on our people. History should recal..."** | `[4]` **Hugo Toras**: ""War is a crucible. If you can f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Estela Toras**: ""If only historians shared your ..." |
| `[6]` | **""But what if it's all too much? What if I fail?""** | `[4]` **Hugo Toras**: ""War is a crucible. If you can f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Estela Toras**: ""You won't, darling."" |
| `[7]` | **""The Lord is on our side. Our victory will not only be a testament to our strength..."** | `[4]` **Hugo Toras**: ""War is a crucible. If you can f..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[191]` **Hugo Toras**: ""Halaita."" |
| `[8]` | **""'Crucible' is a fitting word for it. I will lead our kingdom to battle with an ir..."** | `[4]` **Hugo Toras**: ""War is a crucible. If you can f..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[45]` **Estela Toras**: ""Such ferocity, son. Save some f..." |
| `[9]` | **""I hoped it would never come to this. But if we must weather the storm of war, I s..."** | `[4]` **Hugo Toras**: ""War is a crucible. If you can f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Estela Toras**: ""Just be careful not to lose you..." |
| `[64]` | **""I disagree. If we lose our moral compass, then we lose everything.""** | `[63]` **Hugo Toras**: ""Compassion is noble, but it mus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[65]` | **""Decisiveness is key. But I won't let it harden our kingdom's heart.""** | `[63]` **Hugo Toras**: ""Compassion is noble, but it mus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[66]` | **""You're right. It's up to me to make the tough but necessary decisions.""** | `[63]` **Hugo Toras**: ""Compassion is noble, but it mus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[70]` | **""Exactly. You were lucky to get out of there alive.""** | `[69]` **Hugo Toras**: ""I suspect it was always going t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[71]` | **""If anything, it was my actions that led us to this point. But now that we've set ..."** | `[69]` **Hugo Toras**: ""I suspect it was always going t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[72]` | **""There's no use lamenting what could have been. We've got to concentrate on what c..."** | `[69]` **Hugo Toras**: ""I suspect it was always going t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[80]` | **""Thank you nonetheless, Vina. I'll never turn away from the wisdom of my family an..."** | `[73]` **Hugo Toras**: ""Your solidarity is admirable, Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[81]` | **""It's all part and parcel of being king. I was born to rule alone.""** | `[73]` **Hugo Toras**: ""Your solidarity is admirable, Y..." | `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false` | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[82]` | **""Yes. For now.""** | `[73]` **Hugo Toras**: ""Your solidarity is admirable, Y..." | `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true` | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[83]` | **""Only I can protect our nation in these trying times.""** | `[73]` **Hugo Toras**: ""Your solidarity is admirable, Y..."<br>`[74]` **Hugo Toras**: ""The mantle of leadership is a s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[84]` | **""The weight of this war rests solely on me, a responsibility I must accept for Riz..."** | `[74]` **Hugo Toras**: ""The mantle of leadership is a s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[85]` | **""We need to defend our kingdom's sovereignty and future.""** | `[74]` **Hugo Toras**: ""The mantle of leadership is a s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[86]` | **""Our faith will bolster us, but our strategy against Pales will be pragmatic and c..."** | `[75]` **Hugo Toras**: ""We will not win this war withou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[87]` | **""It is Rizia's destiny to reunite with Pales. If we pray enough, we will manifest ..."** | `[75]` **Hugo Toras**: ""We will not win this war withou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[88]` | **""My head is clearer than it's ever been. I know God will show us the way forward.""** | `[75]` **Hugo Toras**: ""We will not win this war withou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[89]` | **""We seek comfort in prayer, but our decisive actions will be what protects Rizia f..."** | `[75]` **Hugo Toras**: ""We will not win this war withou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[90]` | **""The Palesians brought this on themselves. They deserve all the destruction we can..."** | `[77]` **Hugo Toras**: ""Strength is a tool, Your Highne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[91]` | **""The Palesians have given us no choice, Vina. It's now or never.""** | `[76]` **Hugo Toras**: ""For as long as I live, our fami..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[92]` | **""I swear on my own life that no harm shall befall the Toras family.""** | `[76]` **Hugo Toras**: ""For as long as I live, our fami..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[93]` | **""We aren't bound by our past as we confront Pales. We will forge a new path for Ri..."** | `[76]` **Hugo Toras**: ""For as long as I live, our fami..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[94]` | **""Our strength will be a shield, not a weapon of oppression.""** | `[77]` **Hugo Toras**: ""Strength is a tool, Your Highne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[95]` | **""I will do what I must to protect our people. No matter how painful the decision.""** | `[77]` **Hugo Toras**: ""Strength is a tool, Your Highne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[96]` | **""Our history with Pales is a guide. We'll use it to avoid repeating old errors.""** | `[79]` **Hugo Toras**: ""Facing Pales is our chance to c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[97]` | **""In war, we shall remain calm, our actions swift and decisive.""** | `[78]` **Hugo Toras**: ""Precisely, Your Highness. We do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[98]` | **""But we don't want to be seen as weaklings, either.""** | `[78]` **Hugo Toras**: ""Precisely, Your Highness. We do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[99]` | **""Controlled strength. That's what I'm aiming for in this speech.""** | `[78]` **Hugo Toras**: ""Precisely, Your Highness. We do..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[100]` | **""I know exactly what my father did wrong. I'll never fall into the same traps he d..."** | `[79]` **Hugo Toras**: ""Facing Pales is our chance to c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[101]` | **""We won't repeat history, we'll rewrite it. Starting today.""** | `[79]` **Hugo Toras**: ""Facing Pales is our chance to c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Two and a half million people h..." |
| `[122]` | **""We'll aim to pacify Pales, but not at the expense of our humanity.""** | `[119]` **Hugo Toras**: ""Pacifying the Palesian populace..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "The moment was punctuated by the..." |
| `[123]` | **""Pacification should not mean oppression. We'll ensure fairness in our approach.""** | `[119]` **Hugo Toras**: ""Pacifying the Palesian populace..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "The moment was punctuated by the..." |
| `[125]` | **""Our goal is peace, but we must be ready for resistance.""** | `[119]` **Hugo Toras**: ""Pacifying the Palesian populace..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Narrator**: "The moment was punctuated by the..." |
| `[126]` | **""I am confident that Duke Reinhart wants a swift end to the war, just as I do.""** | `[120]` **Hugo Toras**: ""The Palesians don't want peace,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Estela Toras**: ""A swift end is great, as long a..." |
| `[127]` | **""We are not going to fall into that trap. We'll choose the path of peace at all co..."** | `[120]` **Hugo Toras**: ""The Palesians don't want peace,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Estela Toras**: ""Just don't forget that less-tha..." |
| `[128]` | **""We're facing a harsh reality. We must be ready for whatever violence comes.""** | `[120]` **Hugo Toras**: ""The Palesians don't want peace,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Estela Toras**: ""As long as we don't get lost in..." |
| `[130]` | **""You're right, Mother. This speech is a call to unity, a reminder that we are stro..."** | `[124]` **Estela Toras**: ""Choose your words carefully, so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Estela Toras**: ""Glovurius axa Rizia."" |
| `[131]` | **""It's a chance to remind them what they'll be fighting for. What they'll be dying ..."** | `[124]` **Estela Toras**: ""Choose your words carefully, so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Estela Toras**: ""For king and country."" |
| `[132]` | **""I'll use this speech to lift our people's spirits. Rizia will only win this war i..."** | `[124]` **Estela Toras**: ""Choose your words carefully, so..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Estela Toras**: ""That's true. The lower the mora..." |
| `[135]` | **""You are all family. I want you by my side.""** | `[134]` **Hugo Toras**: ""Everything has been prepared fo..." | `(Variable["RiziaDLC.Vina_Hostage"] == true) == false` | *Brak zmian stanu* | `[147]` **Hugo Toras**: ""Then together, the Royal Family..." |
| `[136]` | **""Princess Vina represents the future. She should be with me.""** | `[134]` **Hugo Toras**: ""Everything has been prepared fo..." | `Variable["RiziaDLC.Vina_Hostage"] == false` | *Brak zmian stanu* | `[148]` **Vina Toras**: ""Father... I..."" |
| `[137]` | **""Our Queen Mother should be next to me to show that we survived the past tribulati..."** | `[134]` **Hugo Toras**: ""Everything has been prepared fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Hugo Toras**: ""Indeed. Queen Mother Estela sha..." |
| `[138]` | **""You should be with me, Hugo. As my uncle and my trusted second-in-command.""** | `[134]` **Hugo Toras**: ""Everything has been prepared fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Hugo Toras**: ""It would be an honor to stand b..." |
| `[150]` | **""Mother, Uncle, I want you both with me during this pivotal moment.""** | `[134]` **Hugo Toras**: ""Everything has been prepared fo..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[145]` **Hugo Toras**: ""We stand with you, Romus. Unite..." |
| `[160]` | **""This burden is mine to bear. I will make the speech alone.""** | `[134]` **Hugo Toras**: ""Everything has been prepared fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Hugo Toras**: ""We'll be with you in spirit, ev..." |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Hugo Toras: ""War is a crucible. If you can face it head-on and surviv..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The moment was punctuated by the arrival of a member of the Golden Guard. He was wearing a ceremonial breastplate that gleamed under the room's warm lights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "He relayed to Hugo that all was prepared. The time had co..."*)

### Węzeł `[4]`
Mówca: **Hugo Toras**
> ""War is a crucible. If you can face it head-on and survive, you will be unbreakable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""We must also remember the toll conflict takes on our peo..."*)
  - -> `[6]` (*Player_Romus: ""But what if it's all too much? What if I fail?""*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[9]` (*Player_Romus: ""I hoped it would never come to this. But if we must weat..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must also remember the toll conflict takes on our people. History should recall the hearts and spirits of those brave commoners sent to fight for their kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Estela Toras: ""If only historians shared your compassion, darling.""*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But what if it's all too much? What if I fail?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Estela Toras: ""You won't, darling.""*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Lord is on our side. Our victory will not only be a testament to our strength but also to our faith and righteousness.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Hugo Toras: ""Halaita.""*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Crucible' is a fitting word for it. I will lead our kingdom to battle with an iron fist. All will know Rizia's might.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Estela Toras: ""Such ferocity, son. Save some for the populace out there.""*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hoped it would never come to this. But if we must weather the storm of war, I shall do my best to steer Rizia through it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Estela Toras: ""Just be careful not to lose your own footing.""*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false && RiziaDLC.Diplomacy_Pale..."*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == false && RiziaDLC.Diplomacy_Pa..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Vina Toras: ""Still, the people need compassion now more than ever.""*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == false && RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaD..."*)

### Węzeł `[13]`
Mówca: **Vina Toras**
> ""Still, the people need compassion now more than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Hugo Toras: ""Compassion is noble, but it must not overshadow the need..."*)

### Węzeł `[14]`
Mówca: **Estela Toras**
> ""If only historians shared your compassion, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Estela Toras: ""But it's the kings they pay attention to. Their triumphs..."*)

### Węzeł `[15]`
Mówca: **Estela Toras**
> ""You won't, darling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "My mother put a firm hand on my shoulder."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostag..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Vina Toras: ""It's a heavy burden, but one that we'll share as a famil..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage..."*)

### Węzeł `[19]`
Mówca: **Estela Toras**
> ""Because you've learned from your predecessors' mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[20]`
Mówca: **Vina Toras**
> ""It's a heavy burden, but one that we'll share as a family. And as a nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Hugo Toras: ""Your solidarity is admirable, Your Highness, but there a..."*)

### Węzeł `[21]`
Mówca: **Vina Toras**
> ""It was your choice to go to war, Father. You've got to bear the burden.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Hugo Toras: ""The mantle of leadership is a solitary one. But the choi..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage..."*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hosta..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Vina Toras: ""It was your choice to go to war, Father. You've got to b..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[25]`
Mówca: **Estela Toras**
> ""But it's the kings they pay attention to. Their triumphs -- and their failures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false && RiziaDLC.Diplomacy_Pale..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaD..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && Rizi..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Vina Toras: ""I wish I could've done more to prevent this.""*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal == true && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_Vina_LeadsDeal"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[29]`
Mówca: **Vina Toras**
> ""I wish I could've done more to prevent this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""I suspect it was always going to come to this, Your High..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Next to him, my mother nodded silently. She looked troubled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player_Romus: ""The Lord is on our side. Our victory will not only be a ..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostag..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Vina Toras: ""Faith can sometimes misguide us.""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hosta..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Vina Toras: ""Prayer won't help the death we're about to unleash, Fath..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[40]`
Mówca: **Vina Toras**
> ""Faith can sometimes misguide us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Hugo Toras: ""We will not win this war without faith, Your Highness. B..."*)

### Węzeł `[41]`
Mówca: **Vina Toras**
> ""Prayer won't help the death we're about to unleash, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Hugo Toras: ""We will not win this war without faith, Your Highness. B..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""'Crucible' is a fitting word for it. I will lead our kin..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
Mówca: **Estela Toras**
> ""Such ferocity, son. Save some for the populace out there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostag..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Vina Toras: ""We shouldn't charge headlong into battle. No one will be..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage..."*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hosta..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Vina Toras: ""The iron fist has never brought good things for our peop..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[52]`
Mówca: **Vina Toras**
> ""We shouldn't charge headlong into battle. No one will be safe from the consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Hugo Toras: ""For as long as I live, our family will be safe.""*)

### Węzeł `[53]`
Mówca: **Vina Toras**
> ""The iron fist has never brought good things for our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Hugo Toras: ""Strength is a tool, Your Highness. One that can be valua..."*)

### Węzeł `[54]`
Mówca: **Estela Toras**
> ""Just be careful not to lose your own footing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostag..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Vina Toras: ""Calm and thoughtful leadership is what Rizia needs right..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage..."*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hosta..."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Vina Toras: ""All these metaphors are making me seasick. I just hope h..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[61]`
Mówca: **Vina Toras**
> ""Calm and thoughtful leadership is what Rizia needs right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Hugo Toras: ""Precisely, Your Highness. We don't want our kingdom to b..."*)

### Węzeł `[62]`
Mówca: **Vina Toras**
> ""All these metaphors are making me seasick. I just hope history doesn't repeat itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Hugo Toras: ""Facing Pales is our chance to correct past mistakes, not..."*)

### Węzeł `[63]`
Mówca: **Hugo Toras**
> ""Compassion is noble, but it must not overshadow the need for decisive action in times of war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus: ""I disagree. If we lose our moral compass, then we lose e..."*)
  - -> `[65]` (*Player_Romus: ""Decisiveness is key. But I won't let it harden our kingd..."*)
  - -> `[66]` (*Player_Romus: ""You're right. It's up to me to make the tough but necess..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. If we lose our moral compass, then we lose everything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Decisiveness is key. But I won't let it harden our kingdom's heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. It's up to me to make the tough but necessary decisions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""Two and a half million people have gathered outside. Our entire police force is deployed for their safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == false"*)

### Węzeł `[68]`
Mówca: **Hugo Toras**
> ""The Golden Guard will ensure the palace and its surroundings remain secure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Hugo Toras: ""I have been outside. The atmosphere is tense, yet there'..."*)

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""I suspect it was always going to come to this, Your Highness. You shouldn't blame yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""Exactly. You were lucky to get out of there alive.""*)
  - -> `[71]` (*Player_Romus: ""If anything, it was my actions that led us to this point..."*)
  - -> `[72]` (*Player_Romus: ""There's no use lamenting what could have been. We've got..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Exactly. You were lucky to get out of there alive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If anything, it was my actions that led us to this point. But now that we've set ourselves on this path, we can't turn back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's no use lamenting what could have been. We've got to concentrate on what comes next.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[73]`
Mówca: **Hugo Toras**
> ""Your solidarity is admirable, Your Highness, but there are some decisions your father will have to make on his own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Romus: ""Thank you nonetheless, Vina. I'll never turn away from t..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[83]` (*Player_Romus: ""Only I can protect our nation in these trying times.""*)

### Węzeł `[74]`
Mówca: **Hugo Toras**
> ""The mantle of leadership is a solitary one. But the choices you make will affect every living soul in this kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""Only I can protect our nation in these trying times.""*)
  - -> `[84]` (*Player_Romus: ""The weight of this war rests solely on me, a responsibil..."*)
  - -> `[85]` (*Player_Romus: ""We need to defend our kingdom's sovereignty and future.""*)

### Węzeł `[75]`
Mówca: **Hugo Toras**
> ""We will not win this war without faith, Your Highness. But it must be combined with clear-headed strategy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""Our faith will bolster us, but our strategy against Pale..."*)
  - -> `[87]` (*Player_Romus: ""It is Rizia's destiny to reunite with Pales. If we pray ..."*)
  - -> `[88]` (*Player_Romus: ""My head is clearer than it's ever been. I know God will ..."*)
  - -> `[89]` (*Player_Romus: ""We seek comfort in prayer, but our decisive actions will..."*)

### Węzeł `[76]`
Mówca: **Hugo Toras**
> ""For as long as I live, our family will be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""The Palesians have given us no choice, Vina. It's now or..."*)
  - -> `[92]` (*Player_Romus: ""I swear on my own life that no harm shall befall the Tor..."*)
  - -> `[93]` (*Player_Romus: ""We aren't bound by our past as we confront Pales. We wil..."*)

### Węzeł `[77]`
Mówca: **Hugo Toras**
> ""Strength is a tool, Your Highness. One that can be valuable if used judiciously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player_Romus: ""Our strength will be a shield, not a weapon of oppression.""*)
  - -> `[90]` (*Player_Romus: ""The Palesians brought this on themselves. They deserve a..."*)
  - -> `[95]` (*Player_Romus: ""I will do what I must to protect our people. No matter h..."*)

### Węzeł `[78]`
Mówca: **Hugo Toras**
> ""Precisely, Your Highness. We don't want our kingdom to be perceived as the aggressor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""In war, we shall remain calm, our actions swift and deci..."*)
  - -> `[98]` (*Player_Romus: ""But we don't want to be seen as weaklings, either.""*)
  - -> `[99]` (*Player_Romus: ""Controlled strength. That's what I'm aiming for in this ..."*)

### Węzeł `[79]`
Mówca: **Hugo Toras**
> ""Facing Pales is our chance to correct past mistakes, not repeat them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player_Romus: ""I know exactly what my father did wrong. I'll never fall..."*)
  - -> `[101]` (*Player_Romus: ""We won't repeat history, we'll rewrite it. Starting today.""*)
  - -> `[96]` (*Player_Romus: ""Our history with Pales is a guide. We'll use it to avoid..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you nonetheless, Vina. I'll never turn away from the wisdom of my family and council.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all part and parcel of being king. I was born to rule alone.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[73]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. For now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Kontekst wejściowy (poprzednik):** `[73]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only I can protect our nation in these trying times.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Hugo Toras), `[74]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The weight of this war rests solely on me, a responsibility I must accept for Rizia's safety.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to defend our kingdom's sovereignty and future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our faith will bolster us, but our strategy against Pales will be pragmatic and calculated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is Rizia's destiny to reunite with Pales. If we pray enough, we will manifest our victory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My head is clearer than it's ever been. I know God will show us the way forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We seek comfort in prayer, but our decisive actions will be what protects Rizia from the Palesian menace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Palesians brought this on themselves. They deserve all the destruction we can rain down on them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Palesians have given us no choice, Vina. It's now or never.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I swear on my own life that no harm shall befall the Toras family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We aren't bound by our past as we confront Pales. We will forge a new path for Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our strength will be a shield, not a weapon of oppression.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will do what I must to protect our people. No matter how painful the decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our history with Pales is a guide. We'll use it to avoid repeating old errors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In war, we shall remain calm, our actions swift and decisive.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But we don't want to be seen as weaklings, either.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Controlled strength. That's what I'm aiming for in this speech.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know exactly what my father did wrong. I'll never fall into the same traps he did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We won't repeat history, we'll rewrite it. Starting today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Two and a half million people have gathered outside. Our..."*)

### Węzeł `[102]`
Mówca: **Hugo Toras**
> ""I have been outside. The atmosphere is tense, yet there's an undeniable sense of solidarity among our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Estela Toras: ""I remember this feeling from all the way back in 1923. A..."*)

### Węzeł `[103]`
Mówca: **Hugo Toras**
> ""Look at how prepared we are, Madam Queen Mother. Our armies will not falter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[104]`
Mówca: **Estela Toras**
> ""I remember this feeling from all the way back in 1923. And I remember what happened next...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Estela Toras: ""Listen to me, Romus. We can't lose to Pales again.""*)

### Węzeł `[105]`
Mówca: **Estela Toras**
> ""Listen to me, Romus. We can't lose to Pales again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == tr..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == tr..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == ..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Hugo Toras: ""Look at how prepared we are, Madam Queen Mother. Our arm..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_PowerProjection_Strong == true || RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Strong"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_PowerProjection_Overwhelming"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Hugo Toras: ""We will learn and adapt from what happened back then. Ou..."*)

### Węzeł `[109]`
Mówca: **Hugo Toras**
> ""We will learn and adapt from what happened back then. Our will shall guide us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage ..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostag..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Vina Toras: ""I just hope that less blood will be spilled than during ..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage..."*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hosta..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Vina Toras: ""I just hope that we can find a peaceful resolution to th..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Estela Toras: ""Choose your words carefully, son. This speech isn't just..."*)

### Węzeł `[116]`
Mówca: **Vina Toras**
> ""I just hope that less blood will be spilled than during the Reclamation War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Hugo Toras: ""Pacifying the Palesian populace will lead to the least h..."*)

### Węzeł `[117]`
Mówca: **Vina Toras**
> ""I just hope that we can find a peaceful resolution to this. Sooner rather than later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Hugo Toras: ""The Palesians don't want peace, Your Highness. Furtherin..."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "The rhythmic cadence of countless voices echoed outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[119]`
Mówca: **Hugo Toras**
> ""Pacifying the Palesian populace will lead to the least harm. That is our goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""We'll aim to pacify Pales, but not at the expense of our..."*)
  - -> `[123]` (*Player_Romus: ""Pacification should not mean oppression. We'll ensure fa..."*)
  - -> `[125]` (*Player_Romus: ""Our goal is peace, but we must be ready for resistance.""*)

### Węzeł `[120]`
Mówca: **Hugo Toras**
> ""The Palesians don't want peace, Your Highness. Furthering the cycle of violence allows them to garner more support from their Lespian backers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player_Romus: ""I am confident that Duke Reinhart wants a swift end to t..."*)
  - -> `[127]` (*Player_Romus: ""We are not going to fall into that trap. We'll choose th..."*)
  - -> `[128]` (*Player_Romus: ""We're facing a harsh reality. We must be ready for whate..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "He relayed to Hugo that all was prepared. The time had come to address the Kingdom, to define the future of Rizia at war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Hugo Toras: ""Everything has been prepared for you. Would you like any..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll aim to pacify Pales, but not at the expense of our humanity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The moment was punctuated by the arrival of a member of t..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pacification should not mean oppression. We'll ensure fairness in our approach.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The moment was punctuated by the arrival of a member of t..."*)

### Węzeł `[124]`
Mówca: **Estela Toras**
> ""Choose your words carefully, son. This speech isn't just about the war; it's about rallying the Rizian people in the face of adversity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Romus: ""You're right, Mother. This speech is a call to unity, a ..."*)
  - -> `[131]` (*Player_Romus: ""It's a chance to remind them what they'll be fighting fo..."*)
  - -> `[132]` (*Player_Romus: ""I'll use this speech to lift our people's spirits. Rizia..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our goal is peace, but we must be ready for resistance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The moment was punctuated by the arrival of a member of t..."*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am confident that Duke Reinhart wants a swift end to the war, just as I do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Estela Toras: ""A swift end is great, as long as you're on the winning s..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are not going to fall into that trap. We'll choose the path of peace at all costs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Estela Toras: ""Just don't forget that less-than-decisive action on our ..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're facing a harsh reality. We must be ready for whatever violence comes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Estela Toras: ""As long as we don't get lost in the same darkness that V..."*)

### Węzeł `[129]`
Mówca: **Estela Toras**
> ""Just don't forget that less-than-decisive action on our part risks drawing out the conflict further and losing more lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The moment was punctuated by the arrival of a member of t..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Mother. This speech is a call to unity, a reminder that we are stronger together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Estela Toras: ""Glovurius axa Rizia.""*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a chance to remind them what they'll be fighting for. What they'll be dying for.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Estela Toras: ""For king and country.""*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll use this speech to lift our people's spirits. Rizia will only win this war if they believe we can.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Estela Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Estela Toras: ""That's true. The lower the morale, the higher the casual..."*)

### Węzeł `[133]`
Mówca: **Estela Toras**
> ""For king and country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The moment was punctuated by the arrival of a member of t..."*)

### Węzeł `[134]`
Mówca: **Hugo Toras**
> ""Everything has been prepared for you. Would you like any of us to be by your side on the balcony?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player_Romus: ""This burden is mine to bear. I will make the speech alone.""*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)
  - -> `[137]` (*Player_Romus: ""Our Queen Mother should be next to me to show that we su..."*)
  - -> `[138]` (*Player_Romus: ""You should be with me, Hugo. As my uncle and my trusted ..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are all family. I want you by my side.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Hugo Toras: ""Then together, the Royal Family shall present a united f..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Princess Vina represents the future. She should be with me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == false`
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Vina Toras: ""Father... I...""*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our Queen Mother should be next to me to show that we survived the past tribulations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Hugo Toras: ""Indeed. Queen Mother Estela shall remind the public of t..."*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You should be with me, Hugo. As my uncle and my trusted second-in-command.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Hugo Toras: ""It would be an honor to stand beside you, my nephew.""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == false)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player_Romus: ""Princess Vina represents the future. She should be with ..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player_Romus: ""Mother, Uncle, I want you both with me during this pivot..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player_Romus: ""You are all family. I want you by my side.""*)

### Węzeł `[145]`
Mówca: **Hugo Toras**
> ""We stand with you, Romus. United, as a family should be in such times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Estela Toras: ""Your father would be proud. We'll face this together, as..."*)

### Węzeł `[146]`
Mówca: **Estela Toras**
> ""*Completely* united. Right, Vina?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 1"*)

### Węzeł `[147]`
Mówca: **Hugo Toras**
> ""Then together, the Royal Family shall present a united front to the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Estela Toras: ""*Completely* united. Right, Vina?""*)

### Węzeł `[148]`
Mówca: **Vina Toras**
> ""Father... I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 1"*)

### Węzeł `[149]`
Mówca: **Hugo Toras**
> ""The entire division of the Golden Guard has been deployed, ensuring the city center is a safe zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Hugo Toras: ""I have been outside. The atmosphere is tense, yet there'..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mother, Uncle, I want you both with me during this pivotal moment.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Hugo Toras: ""We stand with you, Romus. United, as a family should be ..."*)

### Węzeł `[151]`
Mówca: **Estela Toras**
> ""Your father would be proud. We'll face this together, as we always have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras");"*)

### Węzeł `[152]`
Mówca: **Hugo Toras**
> ""It would be an honor to stand beside you, my nephew.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Estela Toras: ""If only Valero could be here to see the two of you toget..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == false"*)
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == false)"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Hugo Toras: ""The Golden Guard will ensure the palace and its surround..."*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Hugo Toras: ""The entire division of the Golden Guard has been deploye..."*)

### Węzeł `[156]`
Mówca: **Estela Toras**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The moment was punctuated by the arrival of a member of t..."*)

### Węzeł `[157]`
Mówca: **Estela Toras**
> ""That's true. The lower the morale, the higher the casualties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The moment was punctuated by the arrival of a member of t..."*)

### Węzeł `[158]`
Mówca: **Estela Toras**
> ""As long as we don't get lost in the same darkness that Valero did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The moment was punctuated by the arrival of a member of t..."*)

### Węzeł `[159]`
Mówca: **Estela Toras**
> ""A swift end is great, as long as you're on the winning side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The moment was punctuated by the arrival of a member of t..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This burden is mine to bear. I will make the speech alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Hugo Toras: ""We'll be with you in spirit, every step of the way.""*)

### Węzeł `[161]`
Mówca: **Hugo Toras**
> ""We'll be with you in spirit, every step of the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "My mother kissed me on the cheek."*)

### Węzeł `[162]`
Mówca: **Estela Toras**
> ""Good luck out there. Don't forget to enunciate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_OnCouncil..."*)

### Węzeł `[163]`
Mówca: **Vina Toras**
> ""Yes, Father. Whatever you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_EntireFamily = true"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Hugo = true"*)

### Węzeł `[165]`
Mówca: **Hugo Toras**
> ""Indeed. Queen Mother Estela shall remind the public of the history we have weathered together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Estela Toras: ""In other words, I'm old. No need to sugar-coat it, Hugo.""*)

### Węzeł `[166]`
Mówca: **Estela Toras**
> ""If only Valero could be here to see the two of you together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Estela Toras"); RemoveConversant("Vina ..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_EstelaHugo = true"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 1"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina > 1)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Vina Toras: ""Yes, of course. It's my duty and my privilege to stand w..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Vina Toras: ""Yes, Father. Whatever you say.""*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");
RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Estela Toras");
RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_RomusAlone = true"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Estela = true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_OnCouncil..."*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_OnCounc..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Vina Toras: ""Yes, good luck, Father. We'll be here if you need us.""*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == false && RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false  and  Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Estela ..."*)

### Węzeł `[176]`
Mówca: **Vina Toras**
> ""Yes, good luck, Father. We'll be here if you need us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Estela ..."*)

### Węzeł `[177]`
Mówca: **Vina Toras**
> ""Yes, of course. It's my duty and my privilege to stand with the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_EntireFamily = true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_EstelaHugo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_EstelaHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "The rhythmic cadence of countless voices echoed outside."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_RomusAlone = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_RomusAlone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "The rhythmic cadence of countless voices echoed outside."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Vina = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Vina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "The rhythmic cadence of countless voices echoed outside."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Estela = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Estela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "The rhythmic cadence of countless voices echoed outside."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_Hugo = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_Hugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "The rhythmic cadence of countless voices echoed outside."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn06_WarSpeech_EntireFamily = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn06_WarSpeech_EntireFamily"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "The rhythmic cadence of countless voices echoed outside."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");
RemoveConversant("Estela Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
RemoveConversant("Estela Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn06_WarSpeech_Vina = true"*)

### Węzeł `[185]`
Mówca: **Vina Toras**
> ""If that's what you want, so be it. I will stand with you, for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Estela ..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 1"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina > 1)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Vina Toras: ""I'll stand with you. The people need to know their princ..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina > 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Vina Toras: ""If that's what you want, so be it. I will stand with you..."*)

### Węzeł `[189]`
Mówca: **Vina Toras**
> ""I'll stand with you. The people need to know their princess is with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Estela ..."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "My mother put a firm hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Estela Toras: ""Because you've learned from your predecessors' mistakes.""*)

### Węzeł `[191]`
Mówca: **Hugo Toras**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Next to him, my mother nodded silently. She looked troubled."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""Yes. For now.""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ""It's all part and parcel of being king. I was born to ru..."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "My mother kissed me on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Estela Toras: ""Good luck out there. Don't forget to enunciate.""*)

### Węzeł `[196]`
Mówca: **Estela Toras**
> ""In other words, I'm old. No need to sugar-coat it, Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras"); RemoveConversant("Vina To..."*)
