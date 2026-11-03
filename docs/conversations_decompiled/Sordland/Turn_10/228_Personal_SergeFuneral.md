# Sordland/Turn10/Personal_SergeFuneral

- **ID konwersacji:** `228`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/228_Personal_SergeFuneral.md`
- **Liczba węzłów dialogowych:** 95
- **Liczba wyborów gracza:** 38

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn02_Funeral_Attend`
- `BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral`
- `BaseGame.Decision_Turn09_PetrFuneral_StateFuneral`
- `BaseGame.Ending_Coup`
- `BaseGame.Relations_Serge_Acquaintance`
- `BaseGame.Relations_Serge_Friend`
- `BaseGame.Relations_Serge_GoodLuckCharm`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Serge_GoodLuckCharm`
- `BaseGameSupport.Codex_Characters_Others_SergeWolkner`
- `BaseGameSupport.Codex_Characters_Others_SergeWolkner_Killed`
- `BaseGameSupport.News_Turn10_HP_Serge_Funeral`
- `BaseGameSupport.News_Turn10_LT_Serge_Funeral`
- `BaseGameSupport.News_Turn10_ST_Serge_Funeral`
- `GameCondition.Turn10_Personal_SergeFuneral`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 8

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Serge_GoodLuckCharm`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[51]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Serge_GoodLuckCharm"] = false;`
- Węzeł `[56]` (Paskal Beniwoll): `Variable["GameCondition.Turn10_Personal_SergeFuneral"] = true;`
- Węzeł `[77]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn10_ST_Serge_Funeral"] = true; Variable["BaseGameSupport.News_T...`
- Węzeł `[78]` (Paskal Beniwoll): `Variable["BaseGameSupport.Codex_Characters_Others_SergeWolkner"] = false; Variable["BaseGameSuppo...`
- Węzeł `[79]` (Paskal Beniwoll): `DisableCollectionItem("CollectionItem_Pocketwatch");`
- Węzeł `[80]` (Paskal Beniwoll): `PlaySoundEffect("Rain");`
- Węzeł `[81]` (Paskal Beniwoll): `PlayCustomMapMusic("Map_Music_Tense"); -- Plays a custom map music after conversation is done. Th...`
- Węzeł `[82]` (Paskal Beniwoll): `End();`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA: "“I will hold my own umbrella.”"]** — Mówca: **Player**
> "“I will hold my own umbrella.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[4]`
Mówca: **Narrator**
> "It was raining as my car came to a stop by the Holsord Grand Cemetery."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[5]`
Mówca: **Narrator**
> "He offered to carry my umbrella."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[6]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "Let him carry your umbrella."]** — Mówca: **Player_Italic**
> "I let him carry my umbrella."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Under the watchful eyes of security officers, I started walking amidst the gravestones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "A small crowd of family and friends gathered around the final resting place of Serge Wolkner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Some in the media were calling him a hero: the brave driver who saved the president by sacrificing his life. It was true."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[10]`
Mówca: **Narrator**
> "I walked up to his widow, Suzan. I had never met her in person before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`
  - -> `[13]`

### Węzeł `[12]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Serge_Friend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Little Anton was crying silently next to his sister, Erica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[15]`
Mówca: **Narrator**
> "Little Georg was crying silently next to his sister, Erica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[16]`
Mówca: **Narrator**
> "They were too young to experience the pain of losing a father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Narrator**
> "I walked over to stand next to the priest, who stepped back upon my arrival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Today, we are mourning a hero of our nation.”"]** — Mówca: **Player**
> "“Today, we are mourning a hero of our nation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[19]`
Mówca: **Narrator**
> "I looked around at everyone's faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`
  - -> `[18]`
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Narrator**
> "Despite my protests, security wouldn't permit a larger funeral."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“Today, we have gathered here to mourn the man who saved my life.”"]** — Mówca: **Player**
> "“Today, we are gathered here to mourn the man who saved my life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Today, we are sending off a friend, a husband and a father.”"]** — Mówca: **Player**
> "“Today, we are sending off a friend, a husband and a father.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Serge Wolkner was a true Sord. He was honest, proud and brave.”"]** — Mówca: **Player**
> "“Serge Wolkner was a true Sord. He was honest, proud and brave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[28]`
  - -> `[26]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Serge Wolkner was more than a simple driver for me. He was a real friend.”"]** — Mówca: **Player**
> "“Serge Wolkner was more than a simple driver for me. He was a real friend.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[28]`
  - -> `[26]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Serge Wolkner was loved by many and he will be missed dearly.”"]** — Mówca: **Player**
> "“Serge Wolkner was loved by many and he will be missed dearly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[28]`
  - -> `[26]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I will always cherish the moments I spent with him.”"]** — Mówca: **Player**
> "“I will always cherish the moments I spent with him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[30]`
  - -> `[27]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“He has left us too soon.”"]** — Mówca: **Player**
> "“He has left us too soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[33]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“His memory is engraved in all of our minds and hearts. We must remember him well.”"]** — Mówca: **Player**
> "“His memory is engraved in our minds and hearts. We must remember him well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[30]`
  - -> `[27]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“I wouldn't be able to find a single person who did not enjoy his company.”"]** — Mówca: **Player**
> "“I wouldn't be able to find a single person who did not enjoy his company.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[30]`
  - -> `[27]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“I will never forget that I am standing here right now because of his sacrifice.”"]** — Mówca: **Player**
> "“I will never forget that I am standing here right now because of his sacrifice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[33]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“I will be forever burdened with the fact that this happened because of me.”"]** — Mówca: **Player**
> "“I will be forever burdened with the fact that this happened because of me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[33]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“I am granting him the title, 'Hero of Sordland'.”"]** — Mówca: **Player**
> "“I am granting him the title, 'Hero of Sordland'.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“I swear to cherish the life he has once again granted me with.”"]** — Mówca: **Player**
> "“I swear to cherish the life he has once again granted me with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[36]`
  - -> `[37]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“His death will be avenged. This, I promise.”"]** — Mówca: **Player**
> "“His death will be avenged. This, I promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[36]`
  - -> `[37]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“The family he has left behind will have the full support of the government.”"]** — Mówca: **Player**
> "“The family he has left behind will have the full support of the government.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[36]`
  - -> `[37]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“I am granting him the military rank of Major.”"]** — Mówca: **Player**
> "“I am granting him the military rank of Major.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“In these dark times, we need to come together in unity.”"]** — Mówca: **Player**
> "“In these dark times, we need to come together in unity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Farewell, brother.”"]** — Mówca: **Player**
> "“Farewell, brother.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Thank you for your service, Serge.”"]** — Mówca: **Player**
> "“Thank you for your service, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
**[WYBÓR GRACZA: "“May his memory last forever.”"]** — Mówca: **Player**
> "“May his memory last forever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Narrator**
> "The casket started to be lowered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Narrator**
> "I put my hand in my pocket and pulled out the watch Serge once gave me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_GoodLuckCharm == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_GoodLuckCharm == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Serge_GoodLuckCharm"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Serge_GoodLuckCharm == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_GoodLuckCharm"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[46]`
Mówca: **Narrator**
> "I recalled that he said it protected his father from the evil of this world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Narrator**
> "At first I didn't believe it, but now I did."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`
  - -> `[50]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "Keep the watch."]** — Mówca: **Player_Italic**
> "I kept the watch and put it back in my pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "Give the watch to Serge's son."]** — Mówca: **Player_Italic**
> "I walked over to Serge's son and gave him the watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "Place the watch on his grave."]** — Mówca: **Player_Italic**
> "I placed the watch on Serge's grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_GoodLuckCharm = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Serge_GoodLuckCharm"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[52]`
Mówca: **Narrator**
> "As the casket hit the ground, mourners sprinkled handfuls of dirt on Serge's grave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Narrator**
> "His wife and children hugged each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "I realized it was time for me to leave."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[55]`
Mówca: **Narrator**
> "It started pouring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn10_Personal_SergeFuneral = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn10_Personal_SergeFuneral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "Wipe their tears."]** — Mówca: **Player_Italic**
> "I wiped their tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`
  - -> `[66]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "Pat them on their heads."]** — Mówca: **Player_Italic**
> "I patted them on their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`
  - -> `[66]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "Give them a hug."]** — Mówca: **Player_Italic**
> "I gave them a hug."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`
  - -> `[61]`
  - -> `[66]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Your father was a great man. Don't ever forget that.”"]** — Mówca: **Player**
> "“Your father was a great man. Don't ever forget that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[61]`
**[WYBÓR GRACZA: "“It's okay to cry. Let it all out.”"]** — Mówca: **Player**
> "“It's okay to cry. Let it all out.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Ms. Wolkner. I will never forget your husband's service and his heroic sacrifice.""]** — Mówca: **Player**
> "“Ms. Wolkner. I will never forget your husband's service and his heroic sacrifice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
**[WYBÓR GRACZA: "“I am so sorry, Suzan.”"]** — Mówca: **Player**
> "“I am so sorry, Suzan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“My condolences.”"]** — Mówca: **Player**
> "“My condolences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Narrator**
> "We hugged and she cried on my shoulder. I crouched next to Serge's children."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“You must be strong.”"]** — Mówca: **Player**
> "“You must be strong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[67]`
Mówca: **Narrator**
> "As I turned my back on Serge's final resting place, I looked up at the dark clouds above."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[68]`
Mówca: **Narrator**
> "My new driver opened the door. I had forgotten his name already."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_Funeral_Attend == true && (BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true ||  BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn02_Funeral_Attend == true && (BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true ||  BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true  and  (Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true  or   Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn02_Funeral_Attend == true && (BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral == true ||  BaseGame.Decision_Turn09_PetrFuneral_StateFuneral == true)))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_Funeral_Attend"] == true  and  (Variable["BaseGame.Decision_Turn09_PetrFuneral_RegularFuneral"] == true  or   Variable["BaseGame.Decision_Turn09_PetrFuneral_StateFuneral"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[72]`
Mówca: **Narrator**
> "I was losing track of how many funerals I had attended by now."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[76]`
Mówca: **Narrator**
> "Under the watchful eyes of security officers in military uniforms, I started walking amidst the gravestones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn10_ST_Serge_Funeral = true; BaseGameSupport.News_Turn10_LT_Serge_Funeral = true; BaseGameSupport.News_Turn10_HP_Serge_Funeral = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn10_ST_Serge_Funeral"] = true;
Variable["BaseGameSupport.News_Turn10_LT_Serge_Funeral"] = true;
Variable["BaseGameSupport.News_Turn10_HP_Serge_Funeral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Others_SergeWolkner = false; BaseGameSupport.Codex_Characters_Others_SergeWolkner_Killed = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_SergeWolkner"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_SergeWolkner_Killed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DisableCollectionItem("CollectionItem_Pocketwatch"))*
- **Efekt (`userScript`):** `DisableCollectionItem("CollectionItem_Pocketwatch");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Rain");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Rain");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[83]`
Mówca: **Narrator**
> "She was wearing an elegant black dress and a beautiful diamond necklace. She thanked me for everything I'd done for her family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[89]`
  - -> `[63]`
  - -> `[62]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Friend == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Friend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Serge_Friend == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Friend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[87]`
Mówca: **Narrator**
> "She was wearing a simple but well-fitting black dress and holding a portrait of Serge in her arms. She thanked me for everything I'd done for her children."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`
  - -> `[63]`
  - -> `[62]`

### Węzeł `[88]`
Mówca: **Narrator**
> "She was wearing a simple but well-fitting black dress and holding a portrait of Serge in her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`
  - -> `[62]`
  - -> `[64]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. I'll make sure you and your children are still well cared for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Acquaintance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Serge_Acquaintance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Serge_Acquaintance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Serge_Acquaintance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Serge_Acquaintance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wish I could have done more. He deserved it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. I'll make sure the children are still well cared for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
