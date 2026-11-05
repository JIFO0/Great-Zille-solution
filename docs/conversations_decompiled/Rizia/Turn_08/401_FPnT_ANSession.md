# Rizia/Turn 8/FPnT_ANSession

- **ID konwersacji:** `401`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/401_FPnT_ANSession.md`
- **Liczba węzłów dialogowych:** 331
- **Liczba wyborów gracza:** 78

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[70]** Laurento Esquibel
- **[76]** Ephraim Nines (R)
- **[82]** Dwight Walker (R)
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[100]** Alma Saltana

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.CountryRelation_Morella_Allied`
- `RiziaDLC.CountryRelation_Sordland_Hostile`
- `RiziaDLC.CountryRelation_Sordland_Unfriendly`
- `RiziaDLC.CountryRelation_Valgsland_Unfriendly`
- `RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella`
- `RiziaDLC.Intermerkopum_Efforts`
- `RiziaDLC.MITZ_Renegotiation_Failed`
- `RiziaDLC.Morella_Pipeline_Sabotage`
- `RiziaDLC.Morella_Sabotage_Plans_Discovered`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Revolutionary_Pipeline_Sabotage`
- `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad`
- `RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Turn05_ITZVote_Nationalization`
- `RiziaDLC.ZilleReferendum_Disapproved`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLC.Zille_Destroyed_LespianEvidence`
- `RiziaDLC.Zille_Discovered_LespianInvolvement`
- `RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty`
- `RiziaDLC.Zille_Publicized_LespianInvolvement`
- `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage`
- `RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage`
- `RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO`
- `RiziaDLCText.SaltanaToPlayer`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Budget_Modifier_MITZRevenues`
- `RiziaDLC.Morella_ConfrontedWithSabotageEvidence`
- `RiziaDLC.Morella_RevealedSabotagePlot`
- `RiziaDLC.Reform_Movement_Radicalism`
- `RiziaDLC.Zille_Publicized_LespianInvolvement_Rusty`
- `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage`
- `RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage`
- `RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO`
- `RiziaDLCSupport.Journal_Turn08_AN_LespiaEvidenceReveal`
- `RiziaDLCSupport.Journal_Turn08_AN_MorellaEvidenceConfront`
- `RiziaDLCSupport.Journal_Turn08_AN_MorellaSabotageReveal`
- `RiziaDLCSupport.News_Turn08_G_LespiaEvidenceReleased`

### Skoki między-konwersacyjne:
- Węzeł `[4]` -> **[402] Rizia/Turn 8/Sanctions** (../Turn_08/402_Sanctions.md), Węzeł `[1]`
- Węzeł `[5]` -> **[403] Rizia/Turn 8/Heljiland Dispute** (../Turn_08/403_Heljiland_Dispute.md), Węzeł `[1]`
- Węzeł `[30]` -> **[404] Rizia/Turn 8/Zille Territory Issue** (../Turn_08/404_Zille_Territory_Issue.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[12]` | **""What's the worst thing that can happen?""** | `[10]` **Laurento Esquibel**: ""Here we go, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Laurento Esquibel**: ""We will see."" |
| `[13]` | **""I am confident in this session.""** | `[10]` **Laurento Esquibel**: ""Here we go, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Laurento Esquibel**: ""Let's see."" |
| `[15]` | **""These sessions bore me to death.""** | `[10]` **Laurento Esquibel**: ""Here we go, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Laurento Esquibel**: ""It should be over in a heartbeat."" |
| `[34]` | **""Oh, so *now* it's 'Your Majesty'.""** | `[33]` **Alma Saltana**: ""Your Majesty. So nice to see yo..." | `(Variable["RiziaDLCText.SaltanaToPlayer"] =="Your Majesty") == false` | *Brak zmian stanu* | `[44]` **Alma Saltana**: ""Titles are important to you Riz..." |
| `[38]` | **""Enough small talk. I know all about your sabotage plans.""** | `[33]` **Alma Saltana**: ""Your Majesty. So nice to see yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Alma Saltana**: ""Our plans?"" |
| `[39]` | **""You too, Madam Prime Minister. Despite the circumstances.""** | `[33]` **Alma Saltana**: ""Your Majesty. So nice to see yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Alma Saltana**: ""What circumstances?"" |
| `[40]` | **""You've got some nerve, showing your face in these chambers after what you did.""** | `[33]` **Alma Saltana**: ""Your Majesty. So nice to see yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Alma Saltana**: ""What I did...?"" |
| `[47]` | **""We'll talk now. Or I'll reveal your plans to sabotage our energy infrastructure t..."** | `[46]` **Alma Saltana**: ""I'm sorry, but the session's ju..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "She exhaled impatiently." |
| `[48]` | **""You can't fool me. Pretending to be Little Miss Do-Gooder while plotting to blow ..."** | `[46]` **Alma Saltana**: ""I'm sorry, but the session's ju..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "She exhaled impatiently." |
| `[49]` | **""Please, Ms. Saltana. I'm giving you a chance to explain yourself. You may not get..."** | `[46]` **Alma Saltana**: ""I'm sorry, but the session's ju..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Narrator**: "She exhaled impatiently." |
| `[50]` | **""So you wouldn't mind if I revealed your involvement to everyone at the Alliance o..."** | `[42]` **Alma Saltana**: ""Morella didn't plan anything. Y..."<br>`[208]` **Alma Saltana**: ""There's nothing to explain. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Narrator**: "She gritted her teeth. It was a ..." |
| `[51]` | **""They never would have done such a thing on their own. You and your CSP partners d..."** | `[42]` **Alma Saltana**: ""Morella didn't plan anything. Y..."<br>`[208]` **Alma Saltana**: ""There's nothing to explain. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Narrator**: "She gritted her teeth. It was a ..." |
| `[52]` | **""Cut the bullshit. We have concrete proof of your involvement.""** | `[42]` **Alma Saltana**: ""Morella didn't plan anything. Y..."<br>`[208]` **Alma Saltana**: ""There's nothing to explain. You..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Narrator**: "She gritted her teeth. It was a ..." |
| `[75]` | **""How dare Alvarez pull a stunt like this after what Lespia did to us?""** | `[65]` **Laurento Esquibel**: ""Despite the deteriorating relat..."<br>`[73]` **Laurento Esquibel**: ""He confided that Lespia is plan..." | `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  or  Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true` | *Brak zmian stanu* | `[112]` **Laurento Esquibel**: ""I'm surprised as well."" |
| `[82]` | **""How dare Hegel pull a stunt like this after what his Morellan minions did to us?""** | `[69]` **Laurento Esquibel**: ""Despite the deteriorating relat..."<br>`[74]` **Laurento Esquibel**: ""He confided that Valgsland is p..." | `Variable["RiziaDLC.Morella_Pipeline_Sabotage"] == true` | *Brak zmian stanu* | `[113]` **Laurento Esquibel**: ""I'm surprised as well."" |
| `[83]` | **""And you're sure this Deivid is a trustworthy source?""** | `[65]` **Laurento Esquibel**: ""Despite the deteriorating relat..."<br>`[69]` **Laurento Esquibel**: ""Despite the deteriorating relat..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Laurento Esquibel**: ""The man doesn't have a dishones..." |
| `[84]` | **""Well, I can't say I'm surprised to hear that.""** | `[65]` **Laurento Esquibel**: ""Despite the deteriorating relat..."<br>`[69]` **Laurento Esquibel**: ""Despite the deteriorating relat..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Laurento Esquibel**: ""If these sanctions go through, ..." |
| `[85]` | **""What? The other member states will never go along with it.""** | `[65]` **Laurento Esquibel**: ""Despite the deteriorating relat..."<br>`[73]` **Laurento Esquibel**: ""He confided that Lespia is plan..." | `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  or  Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true) == false` | *Brak zmian stanu* | `[111]` **Laurento Esquibel**: ""I should hope not."" |
| `[86]` | **""What? The other member states will never go along with it.""** | `[69]` **Laurento Esquibel**: ""Despite the deteriorating relat..."<br>`[74]` **Laurento Esquibel**: ""He confided that Valgsland is p..." | `(Variable["RiziaDLC.Morella_Pipeline_Sabotage"] == true) == false` | *Brak zmian stanu* | `[110]` **Laurento Esquibel**: ""I should hope not."" |
| `[103]` | **""I said I'd destroy the evidence our investigation had turned up. I never agreed t..."** | `[94]` **Laurento Esquibel**: ""But I don't know what you inten..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "A voice over the loudspeaker ann..." |
| `[104]` | **""Lespia must be held accountable for its crimes. It's time to shame Prime Minister..."** | `[94]` **Laurento Esquibel**: ""But I don't know what you inten..."<br>`[98]` **Laurento Esquibel**: ""If this comes to light, the oth..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "A voice over the loudspeaker ann..." |
| `[105]` | **""For now. Who knows what Smolak will try to pull at the last minute?""** | `[102]` **Laurento Esquibel**: ""But I'm not sure what good this..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "A voice over the loudspeaker ann..." |
| `[106]` | **""I haven't decided what to do yet. But it's a useful piece of leverage to have.""** | `[94]` **Laurento Esquibel**: ""But I don't know what you inten..."<br>`[98]` **Laurento Esquibel**: ""If this comes to light, the oth..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "A voice over the loudspeaker ann..." |
| `[107]` | **""This is it. Zille will be ours again.""** | `[98]` **Laurento Esquibel**: ""If this comes to light, the oth..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "A voice over the loudspeaker ann..." |
| `[118]` | **""Wow. I didn't think Rusty had it in him.""** | `[114]` **Laurento Esquibel**: ""But we do have one useful piece..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Laurento Esquibel**: ""He didn't get to where he is by..." |
| `[119]` | **""Perfect. It's time to shame Alvarez on a global stage.""** | `[114]` **Laurento Esquibel**: ""But we do have one useful piece..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Laurento Esquibel**: ""I must admit he deserves it."" |
| `[120]` | **""We can use it to stop the sanctions and get back Zille at the same time. Two vict..."** | `[114]` **Laurento Esquibel**: ""But we do have one useful piece..." | `Variable["RiziaDLC.ZilleReturn_Success"] == false` | *Brak zmian stanu* | `[124]` **Laurento Esquibel**: ""At the expense of our relations..." |
| `[127]` | **""I don't know what good that'll do.""** | `[114]` **Laurento Esquibel**: ""But we do have one useful piece..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Laurento Esquibel**: ""At the very least, it will make..." |
| `[147]` | **""The Kingdom of Rizia would like to draw this assembly's attention to the crimes p..."** | `[140]` **Ephraim Nines (R)**: ""I additionally invite all membe..." | `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true` | *Brak zmian stanu* | `[152]` **Narrator**: "One of my aides approached Presi..." |
| `[151]` | **"Stay silent."** | `[140]` **Ephraim Nines (R)**: ""I additionally invite all membe..." | `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true` | *Brak zmian stanu* | `[18]` **Ephraim Nines (R)**: ""Very well. On to the first item..." |
| `[153]` | **""I submit to you all conclusive proof that Lespia organized the Friendship Day inc..."** | `[152]` **Narrator**: "One of my aides approached Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Narrator**: "I looked across the room at Alva..." |
| `[155]` | **""An anonymous source bravely disclosed to us that Lespia has secretly been attempt..."** | `[152]` **Narrator**: "One of my aides approached Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Narrator**: "I looked across the room at Alva..." |
| `[156]` | **""Patricio Alvarez tried to buy my silence. But I hold in my hands the truth about ..."** | `[152]` **Narrator**: "One of my aides approached Presi..." | `Variable["RiziaDLC.Zille_Destroyed_LespianEvidence"] == true` | *Brak zmian stanu* | `[165]` **Narrator**: "I looked across the room at Alva..." |
| `[157]` | **""Prime Minister Alvarez will point the finger at Rizia today. He is only trying to..."** | `[152]` **Narrator**: "One of my aides approached Presi..." | `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true` | *Brak zmian stanu* | `[165]` **Narrator**: "I looked across the room at Alva..." |
| `[164]` | **""I have evidence that Lespia and its backers in ATO actively worked to destabilize..."** | `[152]` **Narrator**: "One of my aides approached Presi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_Blame...` | `[165]` **Narrator**: "I looked across the room at Alva..." |
| `[169]` | **""Fortunately, Rizia and Wehlen were able to see through the lies and reconcile our..."** | `[165]` **Narrator**: "I looked across the room at Alva..." | `(Variable["RiziaDLC.ZilleReturn_Success"] == false) == false` | `--;` | `[191]` **Narrator**: "A voice came from the back row."<br>`[174]` **Player_Romus**: ""That will be all.""<br>*(oraz 3 innych odgałęzień)* |
| `[170]` | **""We hope that the members of this assembly will keep this information in mind as t..."** | `[165]` **Narrator**: "I looked across the room at Alva..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[191]` **Narrator**: "A voice came from the back row."<br>`[174]` **Player_Romus**: ""That will be all.""<br>*(oraz 3 innych odgałęzień)* |
| `[171]` | **""This blatant meddling is proof of the deep contempt the Arcasian Treaty Organizat..."** | `[165]` **Narrator**: "I looked across the room at Alva..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_Blame...`<br>`--;` | `[191]` **Narrator**: "A voice came from the back row."<br>`[174]` **Player_Romus**: ""That will be all.""<br>*(oraz 3 innych odgałęzień)* |
| `[172]` | **""Lespia's act of terrorism killed civilians and directly impeded the return of the..."** | `[165]` **Narrator**: "I looked across the room at Alva..." | `Variable["RiziaDLC.ZilleReturn_Success"] == false` | `--;` | `[191]` **Narrator**: "A voice came from the back row."<br>`[174]` **Player_Romus**: ""That will be all.""<br>*(oraz 3 innych odgałęzień)* |
| `[173]` | **""Our neighbors to the north are jealous of our resources and our great monarchy. B..."** | `[165]` **Narrator**: "I looked across the room at Alva..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[191]` **Narrator**: "A voice came from the back row."<br>`[174]` **Player_Romus**: ""That will be all.""<br>*(oraz 3 innych odgałęzień)* |
| `[174]` | **""That will be all.""** | `[185]` **Dwight Walker (R)**: ""Let the record show Arcasia had..."<br>`[193]` **Player_Romus**: ""I highly doubt that, President ..."<br>*(oraz 6 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true) == false` | `RemoveConversant("Dwight Walker (R)");` | `[181]` **Narrator**: "A stunned silence settled around..." |
| `[175]` | **""Now, let the session begin.""** | `[185]` **Dwight Walker (R)**: ""Let the record show Arcasia had..."<br>`[193]` **Player_Romus**: ""I highly doubt that, President ..."<br>*(oraz 6 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true) == false` | `RemoveConversant("Dwight Walker (R)");` | `[181]` **Narrator**: "A stunned silence settled around..." |
| `[176]` | **""May justice prevail today.""** | `[185]` **Dwight Walker (R)**: ""Let the record show Arcasia had..."<br>`[193]` **Player_Romus**: ""I highly doubt that, President ..."<br>*(oraz 6 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true) == false` | `RemoveConversant("Dwight Walker (R)");` | `[181]` **Narrator**: "A stunned silence settled around..." |
| `[180]` | **""Thank you and God bless Rizia.""** | `[185]` **Dwight Walker (R)**: ""Let the record show Arcasia had..."<br>`[193]` **Player_Romus**: ""I highly doubt that, President ..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true`<br>`(Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true) == false` | `RemoveConversant("Dwight Walker (R)");` | `[181]` **Narrator**: "A stunned silence settled around..." |
| `[193]` | **""I highly doubt that, President Walker.""** | `[185]` **Dwight Walker (R)**: ""Let the record show Arcasia had..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[174]` **Player_Romus**: ""That will be all.""<br>`[175]` **Player_Romus**: ""Now, let the session begin.""<br>*(oraz 2 innych odgałęzień)* |
| `[194]` | **""Then I hope you discipline your member state accordingly. No nation must be allow..."** | `[185]` **Dwight Walker (R)**: ""Let the record show Arcasia had..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[174]` **Player_Romus**: ""That will be all.""<br>`[175]` **Player_Romus**: ""Now, let the session begin.""<br>*(oraz 2 innych odgałęzień)* |
| `[200]` | **""Well, shall we go inside?""** | `[196]` **Narrator**: "At the same time, I noticed Prim..."<br>`[240]` **Narrator**: "At the same time, I noticed Prim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Laurento Esquibel**: ""I suppose we had better."" |
| `[202]` | **""You go on ahead. I just need a quick word with Madam Prime Minister over there."** | `[196]` **Narrator**: "At the same time, I noticed Prim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Laurento Esquibel**: ""As you wish, Your Majesty."" |
| `[212]` | **""Don't try to lie to me. You threatened me with exactly this scenario when I didn'..."** | `[42]` **Alma Saltana**: ""Morella didn't plan anything. Y..."<br>`[208]` **Alma Saltana**: ""There's nothing to explain. You..." | `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == false` | *Brak zmian stanu* | `[213]` **Narrator**: "She gritted her teeth. It was a ..." |
| `[215]` | **""Not only that. You will vote in Rizia's best interests today.""** | `[310]` **Narrator**: "She nodded."<br>`[313]` **Alma Saltana**: ""It's too late to call them off ..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true` | *Brak zmian stanu* | `[227]` **Alma Saltana**: ""If you insist."" |
| `[222]` | **""And you'll convince your friend Hegel not to threaten us with sanctions.""** | `[310]` **Narrator**: "She nodded."<br>`[313]` **Alma Saltana**: ""It's too late to call them off ..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"]` | *Brak zmian stanu* | `[226]` **Alma Saltana**: ""It's too late for that. But I w..." |
| `[223]` | **""Very well. As long as your agents never touch Rizian soil again.""** | `[310]` **Narrator**: "She nodded."<br>`[313]` **Alma Saltana**: ""It's too late to call them off ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Alma Saltana**: ""They won't. If there's a revolu..." |
| `[225]` | **""I will decide what's best for my kingdom's workers. Not you. Do not forget that.""** | `[310]` **Narrator**: "She nodded."<br>`[313]` **Alma Saltana**: ""It's too late to call them off ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Alma Saltana**: ""Then I entreat you to make the ..." |
| `[231]` | **""Don't try to pull anything.""** | `[230]` **Alma Saltana**: ""Thank you for your understandin..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn08_AN_MorellaEviden...`<br>`RemoveConversant("Alma Saltana");`<br>*(+2 skryptów)* | `[234]` **Narrator**: "We parted ways and went to take ..." |
| `[232]` | **""Have a nice day, Madam Prime Minister.""** | `[230]` **Alma Saltana**: ""Thank you for your understandin..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn08_AN_MorellaEviden...`<br>`RemoveConversant("Alma Saltana");`<br>*(+2 skryptów)* | `[234]` **Narrator**: "We parted ways and went to take ..." |
| `[233]` | **""See you in there.""** | `[230]` **Alma Saltana**: ""Thank you for your understandin..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn08_AN_MorellaEviden...`<br>`RemoveConversant("Alma Saltana");`<br>*(+2 skryptów)* | `[234]` **Narrator**: "We parted ways and went to take ..." |
| `[241]` | **""You go on ahead. I need a quick word with Madam Prime Minister.""** | `[240]` **Narrator**: "At the same time, I noticed Prim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Laurento Esquibel**: ""Yes, of course."" |
| `[246]` | **""Changed your mind about my marriage offer?""** | `[245]` **Narrator**: "Saltana turned to face me head-o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Narrator**: "She rolled her eyes." |
| `[248]` | **""It's good to see you again, Ms. Saltana.""** | `[245]` **Narrator**: "Saltana turned to face me head-o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Alma Saltana**: ""Likewise, {RiziaDLCText.Saltana..." |
| `[253]` | **""I hope I can count on you to vote in Rizia's favor today.""** | `[245]` **Narrator**: "Saltana turned to face me head-o..." | `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true` | *Brak zmian stanu* | `[254]` **Alma Saltana**: ""You have Morella's support, {Ri..." |
| `[255]` | **""How are you?""** | `[245]` **Narrator**: "Saltana turned to face me head-o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Alma Saltana**: ""Very busy. But there's somethin..." |
| `[265]` | **""Thank you.""** | `[264]` **Alma Saltana**: ""I trust you to use this wisely."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Alma Saltana**: ""What are allies for?"" |
| `[266]` | **""I'll see to it that every individual on this list is punished to the full extent ..."** | `[264]` **Alma Saltana**: ""I trust you to use this wisely."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Alma Saltana**: ""Just be careful. You wouldn't w..." |
| `[270]` | **""I value our agreement as much as you do. We'll take quick action to prevent disas..."** | `[264]` **Alma Saltana**: ""I trust you to use this wisely."" | `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == true` | *Brak zmian stanu* | `[284]` **Alma Saltana**: ""I wouldn't expect anything less."" |
| `[271]` | **""Your 'connections' revealed this plot? Was Morella in on it?""** | `[264]` **Alma Saltana**: ""I trust you to use this wisely."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Narrator**: "She shook her head." |
| `[272]` | **""Well, this is embarrassing. Why didn't Rizian intelligence get wind of it?""** | `[264]` **Alma Saltana**: ""I trust you to use this wisely."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Alma Saltana**: ""A good question. I hope you'll ..." |
| `[285]` | **""These are rogue dissidents. They don't represent the opinion of the entire workin..."** | `[281]` **Alma Saltana**: ""I'm looking forward to hearing ..."<br>`[282]` **Alma Saltana**: ""I have to say I'm troubled that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Alma Saltana**: ""Can your Adarfo Sotelato confir..." |
| `[286]` | **""You don't have to worry. I am listening to their demands for reform and I'm plann..."** | `[281]` **Alma Saltana**: ""I'm looking forward to hearing ..."<br>`[282]` **Alma Saltana**: ""I have to say I'm troubled that..." | `Variable["RiziaDLC.Reform_Path"] == true` | *Brak zmian stanu* | `[291]` **Alma Saltana**: ""Very intriguing. I hope you'll ..." |
| `[290]` | **""I hear them just fine. But they are demanding too much.""** | `[281]` **Alma Saltana**: ""I'm looking forward to hearing ..."<br>`[282]` **Alma Saltana**: ""I have to say I'm troubled that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Alma Saltana**: ""It doesn't seem like too much t..." |
| `[293]` | **""You really don't need to concern yourself with the political situation in Rizia.""** | `[281]` **Alma Saltana**: ""I'm looking forward to hearing ..."<br>`[282]` **Alma Saltana**: ""I have to say I'm troubled that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Alma Saltana**: ""Apparently I do. Or would you p..." |
| `[298]` | **""Thanks again.""** | `[297]` **Alma Saltana**: ""I'll be taking my seat now. See..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Morella_RevealedSabotagePlot"] = true;...`<br>`RemoveConversant("Alma Saltana");` | `[234]` **Narrator**: "We parted ways and went to take ..." |
| `[299]` | **""Have a nice day, Madam Prime Minister.""** | `[297]` **Alma Saltana**: ""I'll be taking my seat now. See..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Morella_RevealedSabotagePlot"] = true;...`<br>`RemoveConversant("Alma Saltana");` | `[234]` **Narrator**: "We parted ways and went to take ..." |
| `[300]` | **""Don't forget to vote the right way.""** | `[297]` **Alma Saltana**: ""I'll be taking my seat now. See..." | `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true` | `Variable["RiziaDLC.Morella_RevealedSabotagePlot"] = true;...`<br>`RemoveConversant("Alma Saltana");` | `[234]` **Narrator**: "We parted ways and went to take ..." |
| `[306]` | **""First things first. You are to expedite our MITZ shipments from this point onward..."** | `[214]` **Alma Saltana**: ""There's no need to involve anyo..." | `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true` | *Brak zmian stanu* | `[310]` **Narrator**: "She nodded." |
| `[311]` | **""First things first. You are to honor our MITZ agreement. No matter if Rizia doesn..."** | `[214]` **Alma Saltana**: ""There's no need to involve anyo..." | `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false` | *Brak zmian stanu* | `[310]` **Narrator**: "She nodded." |
| `[312]` | **""Call off the MITZ talks. We're going back to the way things were.""** | `[214]` **Alma Saltana**: ""There's no need to involve anyo..." | `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true` | *Brak zmian stanu* | `[313]` **Alma Saltana**: ""It's too late to call them off ..." |
| `[314]` | **""Adarfo Sotelato. Is he one of yours?""** | `[214]` **Alma Saltana**: ""There's no need to involve anyo..." | `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true` | *Brak zmian stanu* | `[318]` **Alma Saltana**: ""No, of course not."" |
| `[320]` | **""How many of your people are embedded in the RPP?""** | `[214]` **Alma Saltana**: ""There's no need to involve anyo..." | `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false` | *Brak zmian stanu* | `[321]` **Alma Saltana**: ""Officially, none."" |

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
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == tru..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImag..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "The royal convoy finally arrived at the entrance to the Alliance of Nations Headquarters in Konstantium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I looked around the foyer. Of all the leaders gathered he..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "After the usual greetings, Laurento and I settled at our table in the conference hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "He leaned over and whispered in my ear."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "I looked around the foyer. Of all the leaders gathered here, we'd made the most grandiose entrance by far. I felt good about today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalIma..."*)

### Węzeł `[10]`
Mówca: **Laurento Esquibel**
> ""Here we go, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player_Romus: ""What's the worst thing that can happen?""*)
  - -> `[13]` (*Player_Romus: ""I am confident in this session.""*)
  - -> `[15]` (*Player_Romus: ""These sessions bore me to death.""*)

### Węzeł `[11]`
Mówca: **Narrator**
> "He leaned over and whispered in my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Laurento Esquibel: ""Here we go, Your Majesty.""*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the worst thing that can happen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Laurento Esquibel: ""We will see.""*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am confident in this session.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Laurento Esquibel: ""Let's see.""*)

### Węzeł `[14]`
Mówca: **Laurento Esquibel**
> ""We will see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "AddConversant("Ephraim Nines (R)");"*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These sessions bore me to death.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Laurento Esquibel: ""It should be over in a heartbeat.""*)

### Węzeł `[16]`
Mówca: **Laurento Esquibel**
> ""It should be over in a heartbeat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "AddConversant("Ephraim Nines (R)");"*)

### Węzeł `[17]`
Mówca: **Laurento Esquibel**
> ""Let's see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "AddConversant("Ephraim Nines (R)");"*)

### Węzeł `[18]`
Mówca: **Ephraim Nines (R)**
> ""Very well. On to the first item on the agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "A man that I recognized as President Nines approached the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "He sharply banged his gavel to begin the session."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false && RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == tru..."*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == t..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false && RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false  and  Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia == true && RiziaDLC.Zille_Publicized_LespianInvolvement == false && RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Lespia_SanctionsRizia"] == true  and  Variable["RiziaDLC.Zille_Publicized_LespianInvolvement"] == false  and  Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Impasse", "R_Impasse_Loop");"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && R..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true &&..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalIma..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_GlobalImage_Bad == true && RiziaDLC.CountryRelation_Valgsland_Unfriendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_GlobalImage_Bad"] == true  and  Variable["RiziaDLC.CountryRelation_Valgsland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Impasse", "R_Impasse_Loop");"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Impasse", "R_Impasse_Loop");"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Impasse", "R_Impasse_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Impasse","R_Impasse_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "The royal convoy finally arrived at the entrance to the A..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleRef..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleR..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "Prime Minister Saltana turned to face me head-on as I approached her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Alma Saltana: ""Your Majesty. So nice to see you here.""*)

### Węzeł `[33]`
Mówca: **Alma Saltana**
> ""Your Majesty. So nice to see you here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.SaltanaToPlayer == "Your Majesty""*)
  - -> `[38]` (*Player_Romus: ""Enough small talk. I know all about your sabotage plans.""*)
  - -> `[39]` (*Player_Romus: ""You too, Madam Prime Minister. Despite the circumstances.""*)
  - -> `[40]` (*Player_Romus: ""You've got some nerve, showing your face in these chambe..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, so *now* it's 'Your Majesty'.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCText.SaltanaToPlayer"] =="Your Majesty") == false`
- **Kontekst wejściowy (poprzednik):** `[33]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Alma Saltana: ""Titles are important to you Rizians, aren't they?""*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.SaltanaToPlayer == "Your Majesty"`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.SaltanaToPlayer == "Your Majesty""*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCText.SaltanaToPlayer == "Your Majesty")"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.SaltanaToPlayer == "Your Majesty"`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCText.SaltanaToPlayer"] =="Your Majesty"`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCText.SaltanaToPlayer == "Your Majesty")`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCText.SaltanaToPlayer"] =="Your Majesty") == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Oh, so *now* it's 'Your Majesty'.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough small talk. I know all about your sabotage plans.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Alma Saltana: ""Our plans?""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You too, Madam Prime Minister. Despite the circumstances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Alma Saltana: ""What circumstances?""*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've got some nerve, showing your face in these chambers after what you did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Alma Saltana: ""What I did...?""*)

### Węzeł `[41]`
Mówca: **Alma Saltana**
> ""Our plans?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Alma Saltana: ""Morella didn't plan anything. Your own people were the o..."*)

### Węzeł `[42]`
Mówca: **Alma Saltana**
> ""Morella didn't plan anything. Your own people were the ones attempting to take the Rizian energy grid into their own hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""So you wouldn't mind if I revealed your involvement to e..."*)
  - -> `[51]` (*Player_Romus: ""They never would have done such a thing on their own. Yo..."*)
  - -> `[52]` (*Player_Romus: ""Cut the bullshit. We have concrete proof of your involve..."*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == false"*)

### Węzeł `[43]`
Mówca: **Alma Saltana**
> ""What circumstances?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Alma Saltana: ""I'm sorry, but the session's just about to start. We'll ..."*)

### Węzeł `[44]`
Mówca: **Alma Saltana**
> ""Titles are important to you Rizians, aren't they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Alma Saltana: ""I'm sorry, but the session's just about to start. We'll ..."*)

### Węzeł `[45]`
Mówca: **Alma Saltana**
> ""What I did...?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Alma Saltana: ""I'm sorry, but the session's just about to start. We'll ..."*)

### Węzeł `[46]`
Mówca: **Alma Saltana**
> ""I'm sorry, but the session's just about to start. We'll talk another time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player_Romus: ""We'll talk now. Or I'll reveal your plans to sabotage ou..."*)
  - -> `[48]` (*Player_Romus: ""You can't fool me. Pretending to be Little Miss Do-Goode..."*)
  - -> `[49]` (*Player_Romus: ""Please, Ms. Saltana. I'm giving you a chance to explain ..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll talk now. Or I'll reveal your plans to sabotage our energy infrastructure to this entire assembly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "She exhaled impatiently."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can't fool me. Pretending to be Little Miss Do-Gooder while plotting to blow up our pipelines...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "She exhaled impatiently."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please, Ms. Saltana. I'm giving you a chance to explain yourself. You may not get another.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "She exhaled impatiently."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you wouldn't mind if I revealed your involvement to everyone at the Alliance of Nations?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Alma Saltana), `[208]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "She gritted her teeth. It was a moment before she spoke."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They never would have done such a thing on their own. You and your CSP partners drove them to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Alma Saltana), `[208]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "She gritted her teeth. It was a moment before she spoke."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cut the bullshit. We have concrete proof of your involvement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Alma Saltana), `[208]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "She gritted her teeth. It was a moment before she spoke."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "She exhaled impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Alma Saltana: ""Morella didn't plan anything. Your own people were the o..."*)

### Węzeł `[54]`
Mówca: **Alma Saltana**
> ""No harm has been done. And I'm willing to listen to whatever it is you want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Alma Saltana: ""There's no need to involve anyone else.""*)

### Węzeł `[55]`
Mówca: **Narrator**
> "That is, until I realized that none of the various delegations I passed were making eye contact with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "AddConversant("Laurento Esquibel");"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalIma..."*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalI..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "That is, until I realized that none of the various delega..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "AddConversant("Laurento Esquibel");"*)

### Węzeł `[59]`
Mówca: **Narrator**
> "Laurento caught up to me with quick steps. His words came in a worried whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Laurento Esquibel: ""I've just spoken to an old friend of mine. Deivid Wisci,..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "Laurento caught up to me with quick steps. His words came..."*)

### Węzeł `[61]`
Mówca: **Laurento Esquibel**
> ""I've just spoken to an old friend of mine. Deivid Wisci, the Sordish foreign minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Sordland_Hostile == true || Rizi..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Hostile == true || RiziaDLC.CountryRelation_Sordland_Unfriendly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Sordland_Hostile == true || Rizi..."*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Sordland_Hostile == true || Ri..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Sordland_Hostile == true || RiziaDLC.CountryRelation_Sordland_Unfriendly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Sordland_Hostile"] == true  or  Variable["RiziaDLC.CountryRelation_Sordland_Unfriendly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Sordland_Hostile == true || RiziaDLC.CountryRelation_Sordland_Unfriendly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Sordland_Hostile"] == true  or  Variable["RiziaDLC.CountryRelation_Sordland_Unfriendly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)

### Węzeł `[65]`
Mówca: **Laurento Esquibel**
> ""Despite the deteriorating relations between our countries, he was willing to divulge that Lespia is planning on proposing sanctions on Rizia at today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement == true || R..."*)
  - -> `[83]` (*Player_Romus: ""And you're sure this Deivid is a trustworthy source?""*)
  - -> `[84]` (*Player_Romus: ""Well, I can't say I'm surprised to hear that.""*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImag..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Laurento Esquibel: ""Despite the deteriorating relations between our countrie..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Laurento Esquibel: ""Despite the deteriorating relations between our countrie..."*)

### Węzeł `[69]`
Mówca: **Laurento Esquibel**
> ""Despite the deteriorating relations between our countries, he was willing to divulge that Valgsland is planning on proposing sanctions on Rizia at today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""And you're sure this Deivid is a trustworthy source?""*)
  - -> `[84]` (*Player_Romus: ""Well, I can't say I'm surprised to hear that.""*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_Pipeline_Sabotage == true"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImag..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Laurento Esquibel: ""He confided that Lespia is planning on proposing sanctio..."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Laurento Esquibel: ""He confided that Valgsland is planning on proposing sanc..."*)

### Węzeł `[73]`
Mówca: **Laurento Esquibel**
> ""He confided that Lespia is planning on proposing sanctions on Rizia at today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement == true || R..."*)
  - -> `[83]` (*Player_Romus: ""And you're sure this Deivid is a trustworthy source?""*)
  - -> `[84]` (*Player_Romus: ""Well, I can't say I'm surprised to hear that.""*)

### Węzeł `[74]`
Mówca: **Laurento Esquibel**
> ""He confided that Valgsland is planning on proposing sanctions on Rizia at today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""And you're sure this Deivid is a trustworthy source?""*)
  - -> `[84]` (*Player_Romus: ""Well, I can't say I'm surprised to hear that.""*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_Pipeline_Sabotage == true"*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare Alvarez pull a stunt like this after what Lespia did to us?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  or  Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true`
- **Kontekst wejściowy (poprzednik):** `[65]` (Laurento Esquibel), `[73]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Laurento Esquibel: ""I'm surprised as well.""*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement == true || RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement == true || R..."*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_Discovered_LespianInvolvement == true ||..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement == true || RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  or  Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus: ""How dare Alvarez pull a stunt like this after what Lespi..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_Discovered_LespianInvolvement == true || RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  or  Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player_Romus: ""What? The other member states will never go along with it.""*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Morella_Pipeline_Sabotage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_Pipeline_Sabotage == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Morella_Pipeline_Sabotage == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Morella_Pipeline_Sabotage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Morella_Pipeline_Sabotage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""How dare Hegel pull a stunt like this after what his Mor..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Morella_Pipeline_Sabotage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Morella_Pipeline_Sabotage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player_Romus: ""What? The other member states will never go along with it.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How dare Hegel pull a stunt like this after what his Morellan minions did to us?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Morella_Pipeline_Sabotage"] == true`
- **Kontekst wejściowy (poprzednik):** `[69]` (Laurento Esquibel), `[74]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Laurento Esquibel: ""I'm surprised as well.""*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you're sure this Deivid is a trustworthy source?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Laurento Esquibel), `[69]` (Laurento Esquibel), `[73]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Laurento Esquibel: ""The man doesn't have a dishonest bone in his body.""*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, I can't say I'm surprised to hear that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Laurento Esquibel), `[69]` (Laurento Esquibel), `[73]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Laurento Esquibel: ""If these sanctions go through, they have the potential t..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? The other member states will never go along with it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement"] == true  or  Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[65]` (Laurento Esquibel), `[73]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Laurento Esquibel: ""I should hope not.""*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? The other member states will never go along with it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Morella_Pipeline_Sabotage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[69]` (Laurento Esquibel), `[74]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Laurento Esquibel: ""I should hope not.""*)

### Węzeł `[87]`
Mówca: **Laurento Esquibel**
> ""The man doesn't have a dishonest bone in his body.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Laurento Esquibel: ""If these sanctions go through, they have the potential t..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true"*)

### Węzeł `[89]`
Mówca: **Narrator**
> "Laurento caught up to me with quick steps. I had to strain to hear his words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Laurento Esquibel: ""Rusty came through, Your Majesty. The documents he provi..."*)

### Węzeł `[90]`
Mówca: **Laurento Esquibel**
> ""Rusty came through, Your Majesty. The documents he provided indeed implicate Lespia in the Friendship Day incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Destroyed_LespianEvidence == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == t..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "Laurento caught up to me with quick steps. I had to strai..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "A voice over the loudspeaker announced that it was time t..."*)

### Węzeł `[94]`
Mówca: **Laurento Esquibel**
> ""But I don't know what you intend to do with this evidence. After all, you and Prime Minister Alvarez agreed that Lespia's involvement would be kept secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: ""I said I'd destroy the evidence our investigation had tu..."*)
  - -> `[104]` (*Player_Romus: ""Lespia must be held accountable for its crimes. It's tim..."*)
  - -> `[106]` (*Player_Romus: ""I haven't decided what to do yet. But it's a useful piec..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Destroyed_LespianEvidence == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Destroyed_LespianEvidence == true"*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_Destroyed_LespianEvidence == true)"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Destroyed_LespianEvidence == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_Destroyed_LespianEvidence"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Laurento Esquibel: ""But I don't know what you intend to do with this evidenc..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_Destroyed_LespianEvidence == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_Destroyed_LespianEvidence"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == false"*)

### Węzeł `[98]`
Mówca: **Laurento Esquibel**
> ""If this comes to light, the other AN states will never agree to Smolak's referendum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""Lespia must be held accountable for its crimes. It's tim..."*)
  - -> `[107]` (*Player_Romus: ""This is it. Zille will be ours again.""*)
  - -> `[106]` (*Player_Romus: ""I haven't decided what to do yet. But it's a useful piec..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == false"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == false)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Laurento Esquibel: ""If this comes to light, the other AN states will never a..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Laurento Esquibel: ""But I'm not sure what good this information does now. Yo..."*)

### Węzeł `[102]`
Mówca: **Laurento Esquibel**
> ""But I'm not sure what good this information does now. You've already managed to negotiate Zille's safe return, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""Lespia must be held accountable for its crimes. It's tim..."*)
  - -> `[106]` (*Player_Romus: ""I haven't decided what to do yet. But it's a useful piec..."*)
  - -> `[105]` (*Player_Romus: ""For now. Who knows what Smolak will try to pull at the l..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I said I'd destroy the evidence our investigation had turned up. I never agreed to keep Lespia's involvement a secret.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "A voice over the loudspeaker announced that it was time t..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia must be held accountable for its crimes. It's time to shame Prime Minister Alvarez on a global stage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Laurento Esquibel), `[98]` (Laurento Esquibel), `[102]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "A voice over the loudspeaker announced that it was time t..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For now. Who knows what Smolak will try to pull at the last minute?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "A voice over the loudspeaker announced that it was time t..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't decided what to do yet. But it's a useful piece of leverage to have.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Laurento Esquibel), `[98]` (Laurento Esquibel), `[102]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "A voice over the loudspeaker announced that it was time t..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is it. Zille will be ours again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "A voice over the loudspeaker announced that it was time t..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "A voice over the loudspeaker announced that it was time to take our seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_Sabotage_Plans_Discovered == true"*)

### Węzeł `[109]`
Mówca: **Laurento Esquibel**
> ""If these sanctions go through, they have the potential to severely damage our economy and our foreign standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == tru..."*)

### Węzeł `[110]`
Mówca: **Laurento Esquibel**
> ""I should hope not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Laurento Esquibel: ""If these sanctions go through, they have the potential t..."*)

### Węzeł `[111]`
Mówca: **Laurento Esquibel**
> ""I should hope not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Laurento Esquibel: ""If these sanctions go through, they have the potential t..."*)

### Węzeł `[112]`
Mówca: **Laurento Esquibel**
> ""I'm surprised as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == tru..."*)

### Węzeł `[113]`
Mówca: **Laurento Esquibel**
> ""I'm surprised as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == tru..."*)

### Węzeł `[114]`
Mówca: **Laurento Esquibel**
> ""But we do have one useful piece of leverage. Rusty came through with his evidence. We now possess conclusive proof that Lespia organized the Friendship Day bombing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus: ""Perfect. It's time to shame Alvarez on a global stage.""*)
  - -> `[118]` (*Player_Romus: ""Wow. I didn't think Rusty had it in him.""*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == false"*)
  - -> `[127]` (*Player_Romus: ""I don't know what good that'll do.""*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true && RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == tru..."*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == t..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true && RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true  and  Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Laurento Esquibel: ""But we do have one useful piece of leverage. Rusty came ..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true && RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true  and  Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Laurento Esquibel: ""But not everyone in this hall will be on our accuser's s..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wow. I didn't think Rusty had it in him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Laurento Esquibel: ""He didn't get to where he is by being bad at subterfuge.""*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. It's time to shame Alvarez on a global stage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Laurento Esquibel: ""I must admit he deserves it.""*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can use it to stop the sanctions and get back Zille at the same time. Two victories for the price of one.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.ZilleReturn_Success"] == false`
- **Kontekst wejściowy (poprzednik):** `[114]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Laurento Esquibel: ""At the expense of our relations with Lespia. But those w..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == false"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == false)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""We can use it to stop the sanctions and get back Zille a..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[124]`
Mówca: **Laurento Esquibel**
> ""At the expense of our relations with Lespia. But those were never going to recover, I fear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "A voice over the loudspeaker announced that it was time t..."*)

### Węzeł `[125]`
Mówca: **Laurento Esquibel**
> ""He didn't get to where he is by being bad at subterfuge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "A voice over the loudspeaker announced that it was time t..."*)

### Węzeł `[126]`
Mówca: **Laurento Esquibel**
> ""I must admit he deserves it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "A voice over the loudspeaker announced that it was time t..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know what good that'll do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Laurento Esquibel)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Laurento Esquibel: ""At the very least, it will make Lespia look hypocritical..."*)

### Węzeł `[128]`
Mówca: **Laurento Esquibel**
> ""At the very least, it will make Lespia look hypocritical for accusing us of wrongdoing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "A voice over the loudspeaker announced that it was time t..."*)

### Węzeł `[129]`
Mówca: **Laurento Esquibel**
> ""But not everyone in this hall will be on our accuser's side. I'm sure of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "A voice over the loudspeaker announced that it was time t..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Ephraim Nines (R)");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Ephraim Nines (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "A man that I recognized as President Nines approached the..."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "He sharply banged his gavel to begin the session."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Ephraim Nines (R): ""Good morning. I hereby open this session of the Alliance..."*)

### Węzeł `[132]`
Mówca: **Ephraim Nines (R)**
> ""Good morning. I hereby open this session of the Alliance of Nations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImag..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleRef..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleRef..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleRef..."*)
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleR..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Ephraim Nines (R): ""Today's agenda includes a proposal of sanctions on the K..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Ephraim Nines (R): ""Today's agenda includes a proposal of sanctions on the K..."*)

### Węzeł `[139]`
Mówca: **Ephraim Nines (R)**
> ""Today's agenda includes a proposal of sanctions on the Kingdom of Rizia, a vote regarding the disputed territory of Heljiland, and a discussion on the region of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ephraim Nines (R): ""I additionally invite all member states to share any oth..."*)

### Węzeł `[140]`
Mówca: **Ephraim Nines (R)**
> ""I additionally invite all member states to share any other urgent matters you believe deserve our collective attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true"*)

### Węzeł `[141]`
Mówca: **Ephraim Nines (R)**
> ""Today's agenda includes a proposal of sanctions on the Kingdom of Rizia and a vote regarding the disputed territory of Heljiland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ephraim Nines (R): ""I additionally invite all member states to share any oth..."*)

### Węzeł `[142]`
Mówca: **Ephraim Nines (R)**
> ""Today's agenda includes a vote regarding the disputed territory of Heljiland and a discussion on the region of Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ephraim Nines (R): ""I additionally invite all member states to share any oth..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleRef..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleR..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Ephraim Nines (R): ""Today's agenda includes a vote regarding the disputed te..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true || RiziaDLC.ZilleReferendum_Disapproved == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Ephraim Nines (R): ""Today's agenda includes a vote regarding the disputed te..."*)

### Węzeł `[146]`
Mówca: **Ephraim Nines (R)**
> ""Today's agenda includes a vote regarding the disputed territory of Heljiland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ephraim Nines (R): ""I additionally invite all member states to share any oth..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Kingdom of Rizia would like to draw this assembly's attention to the crimes perpetrated by the Republic of Lespia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true`
- **Kontekst wejściowy (poprzednik):** `[140]` (Ephraim Nines (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "One of my aides approached President Nines' podium with t..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == t..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player_Romus: ""The Kingdom of Rizia would like to draw this assembly's ..."*)
  - -> `[151]` (*Player_Romus_Italic: "Stay silent."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Nobody spoke."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Romus_Italic**
> "I didn't say anything."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Zille_Discovered_LespianInvolvement_Rusty"] == true`
- **Kontekst wejściowy (poprzednik):** `[140]` (Ephraim Nines (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Ephraim Nines (R): ""Very well. On to the first item on the agenda.""*)

### Węzeł `[152]`
Mówca: **Narrator**
> "One of my aides approached President Nines' podium with the evidence Rusty had given us. Gasps and animated chatter filled the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Publicized_LespianInvolvement_Rusty = true..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I submit to you all conclusive proof that Lespia organized the Friendship Day incident of 1951.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I looked across the room at Alvarez. His face was white w..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Publicized_LespianInvolvement_Rusty = true;
RiziaDLCSupport.News_Turn08_G_LespiaEvidenceReleased = true;
RiziaDLCSupport.Journal_Turn08_AN_LespiaEvidenceReveal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Zille_Publicized_LespianInvolvement_Rusty"] = true;
Variable["RiziaDLCSupport.News_Turn08_G_LespiaEvidenceReleased"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_AN_LespiaEvidenceReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player_Romus: ""I submit to you all conclusive proof that Lespia organiz..."*)
  - -> `[155]` (*Player_Romus: ""An anonymous source bravely disclosed to us that Lespia ..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Destroyed_LespianEvidence == true"*)
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)
  - -> `[164]` (*Player_Romus: ""I have evidence that Lespia and its backers in ATO activ..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An anonymous source bravely disclosed to us that Lespia has secretly been attempting to sow discord between Rizia and Wehlen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I looked across the room at Alvarez. His face was white w..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Patricio Alvarez tried to buy my silence. But I hold in my hands the truth about his misdeeds.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Zille_Destroyed_LespianEvidence"] == true`
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I looked across the room at Alvarez. His face was white w..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Prime Minister Alvarez will point the finger at Rizia today. He is only trying to divert the blame from his government's attempts to sabotage our kingdom.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true`
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I looked across the room at Alvarez. His face was white w..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Destroyed_LespianEvidence == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Zille_Destroyed_LespianEvidence == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Zille_Destroyed_LespianEvidence == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Zille_Destroyed_LespianEvidence == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Zille_Destroyed_LespianEvidence"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player_Romus: ""Patricio Alvarez tried to buy my silence. But I hold in ..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Zille_Destroyed_LespianEvidence == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Zille_Destroyed_LespianEvidence"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImag..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player_Romus: ""Prime Minister Alvarez will point the finger at Rizia to..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have evidence that Lespia and its backers in ATO actively worked to destabilize us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO = true"*)

### Węzeł `[165]`
Mówca: **Narrator**
> "I looked across the room at Alvarez. His face was white with rage, but he said nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""We hope that the members of this assembly will keep this..."*)
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == false"*)
  - -> `[171]` (*Player_Romus: ""This blatant meddling is proof of the deep contempt the ..."*)
  - -> `[173]` (*Player_Romus: ""Our neighbors to the north are jealous of our resources ..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == false"*)
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == false)"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player_Romus: ""Lespia's act of terrorism killed civilians and directly ..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""Fortunately, Rizia and Wehlen were able to see through t..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fortunately, Rizia and Wehlen were able to see through the lies and reconcile our differences. Nonetheless, our would-be saboteurs must be held to account.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.ZilleReturn_Success"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true"*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We hope that the members of this assembly will keep this information in mind as the session continues.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true"*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This blatant meddling is proof of the deep contempt the Arcasian Treaty Organization holds for the countries of South Merkopa.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO = true"*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lespia's act of terrorism killed civilians and directly impeded the return of the Zille region. They must be held to account.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.ZilleReturn_Success"] == false`
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true"*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our neighbors to the north are jealous of our resources and our great monarchy. But we will not let them tear us down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true"*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That will be all.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[185]` (Dwight Walker (R)), `[193]` (Player_Romus), `[194]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Dwight Walker (R)");"*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now, let the session begin.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[185]` (Dwight Walker (R)), `[193]` (Player_Romus), `[194]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Dwight Walker (R)");"*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May justice prevail today.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[185]` (Dwight Walker (R)), `[193]` (Player_Romus), `[194]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Dwight Walker (R)");"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player_Romus: ""Thank you and God bless Rizia.""*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you and God bless Rizia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true` AND `(Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[185]` (Dwight Walker (R)), `[193]` (Player_Romus), `[194]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Dwight Walker (R)");"*)

### Węzeł `[181]`
Mówca: **Narrator**
> "A stunned silence settled around the chamber as my words sunk in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Ephraim Nines (R): ""Thank you, King Romus. The Alliance of Nations acknowled..."*)

### Węzeł `[182]`
Mówca: **Ephraim Nines (R)**
> ""Thank you, King Romus. The Alliance of Nations acknowledges the evidence submitted by the Kingdom of Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Ephraim Nines (R): ""Now, on to the agenda...""*)

### Węzeł `[183]`
Mówca: **Ephraim Nines (R)**
> ""Now, on to the agenda...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Nobody spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Ephraim Nines (R): ""Very well. On to the first item on the agenda.""*)

### Węzeł `[185]`
Mówca: **Dwight Walker (R)**
> ""Let the record show Arcasia had no knowledge of Lespia's actions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player_Romus: ""I highly doubt that, President Walker.""*)
  - -> `[194]` (*Player_Romus: ""Then I hope you discipline your member state accordingly..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == ..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "A voice came from the back row."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I looked across the room at Alvarez. His face was white w..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_AN_LespiaEvidence_BlamedATO == true"*)

### Węzeł `[191]`
Mówca: **Narrator**
> "A voice came from the back row."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Dwight Walker (R): ""Let the record show Arcasia had no knowledge of Lespia's..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""That will be all.""*)
  - -> `[175]` (*Player_Romus: ""Now, let the session begin.""*)
  - -> `[176]` (*Player_Romus: ""May justice prevail today.""*)
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I highly doubt that, President Walker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Dwight Walker (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I hope you discipline your member state accordingly. No nation must be allowed to act outside the law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Dwight Walker (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Dwight Walker (R)");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Dwight Walker (R)");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "A stunned silence settled around the chamber as my words ..."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "At the same time, I noticed Prime Minister Alma Saltana trying to walk past me unnoticed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: ""You go on ahead. I just need a quick word with Madam Pri..."*)
  - -> `[200]` (*Player_Romus: ""Well, shall we go inside?""*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Morella_Sabotage_Plans_Discovered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_Sabotage_Plans_Discovered == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Morella_Sabotage_Plans_Discovered == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Morella_Sabotage_Plans_Discovered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "At the same time, I noticed Prime Minister Alma Saltana t..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Morella_Sabotage_Plans_Discovered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Morella_Sabotage_Plans_Discovered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Morella_Allied == true && RiziaD..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, shall we go inside?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Narrator), `[240]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Laurento Esquibel: ""I suppose we had better.""*)

### Węzeł `[201]`
Mówca: **Laurento Esquibel**
> ""I suppose we had better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "After the usual greetings, Laurento and I settled at our ..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You go on ahead. I just need a quick word with Madam Prime Minister over there."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Laurento Esquibel: ""As you wish, Your Majesty.""*)

### Węzeł `[203]`
Mówca: **Laurento Esquibel**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Laurento Esquibel: ""Looking forward to hearing what the little snake has to ..."*)

### Węzeł `[204]`
Mówca: **Laurento Esquibel**
> ""Looking forward to hearing what the little snake has to say for herself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "He bowed and walked into the chamber."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "He bowed and walked into the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Laurento Esquibel");"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "Prime Minister Saltana turned to face me head-on as I app..."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "She exhaled impatiently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Alma Saltana: ""There's nothing to explain. Your own people were the one..."*)

### Węzeł `[208]`
Mówca: **Alma Saltana**
> ""There's nothing to explain. Your own people were the ones attempting to take the Rizian energy grid into their own hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""So you wouldn't mind if I revealed your involvement to e..."*)
  - -> `[51]` (*Player_Romus: ""They never would have done such a thing on their own. Yo..."*)
  - -> `[52]` (*Player_Romus: ""Cut the bullshit. We have concrete proof of your involve..."*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == false"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_ITZVote_Nationalization == false"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_ITZVote_Nationalization == false)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_ITZVote_Nationalization == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player_Romus: ""Don't try to lie to me. You threatened me with exactly t..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_ITZVote_Nationalization == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't try to lie to me. You threatened me with exactly this scenario when I didn't go along with your nationalization plans.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_ITZVote_Nationalization"] == false`
- **Kontekst wejściowy (poprzednik):** `[42]` (Alma Saltana), `[208]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "She gritted her teeth. It was a moment before she spoke."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "She gritted her teeth. It was a moment before she spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Alma Saltana: ""No harm has been done. And I'm willing to listen to what..."*)

### Węzeł `[214]`
Mówca: **Alma Saltana**
> ""There's no need to involve anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not only that. You will vote in Rizia's best interests today.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true`
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator), `[313]` (Alma Saltana), `[319]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Alma Saltana: ""If you insist.""*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImag..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player_Romus: ""Not only that. You will vote in Rizia's best interests t..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalI..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player_Romus: ""And you'll convince your friend Hegel not to threaten us..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you'll convince your friend Hegel not to threaten us with sanctions.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"]`
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator), `[313]` (Alma Saltana), `[319]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Alma Saltana: ""It's too late for that. But I will vote in your favor, d..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. As long as your agents never touch Rizian soil again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator), `[313]` (Alma Saltana), `[319]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Alma Saltana: ""They won't. If there's a revolution in your country, it ..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"*)
  - -> `[223]` (*Player_Romus: ""Very well. As long as your agents never touch Rizian soi..."*)
  - -> `[225]` (*Player_Romus: ""I will decide what's best for my kingdom's workers. Not ..."*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will decide what's best for my kingdom's workers. Not you. Do not forget that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator), `[313]` (Alma Saltana), `[319]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Alma Saltana: ""Then I entreat you to make the right decisions. Before i..."*)

### Węzeł `[226]`
Mówca: **Alma Saltana**
> ""It's too late for that. But I will vote in your favor, despite fully agreeing with the Chancellor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Alma Saltana: ""Thank you for your understanding, Your Majesty. I'll be ..."*)

### Węzeł `[227]`
Mówca: **Alma Saltana**
> ""If you insist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Alma Saltana: ""Thank you for your understanding, Your Majesty. I'll be ..."*)

### Węzeł `[228]`
Mówca: **Alma Saltana**
> ""They won't. If there's a revolution in your country, it will be 100 percent homegrown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Alma Saltana: ""Thank you for your understanding, Your Majesty. I'll be ..."*)

### Węzeł `[229]`
Mówca: **Alma Saltana**
> ""Then I entreat you to make the right decisions. Before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Alma Saltana: ""Thank you for your understanding, Your Majesty. I'll be ..."*)

### Węzeł `[230]`
Mówca: **Alma Saltana**
> ""Thank you for your understanding, Your Majesty. I'll be taking my seat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player_Romus: ""Don't try to pull anything.""*)
  - -> `[232]` (*Player_Romus: ""Have a nice day, Madam Prime Minister.""*)
  - -> `[233]` (*Player_Romus: ""See you in there.""*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't try to pull anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_AN_MorellaEvidenceConfront..."*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have a nice day, Madam Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_AN_MorellaEvidenceConfront..."*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See you in there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_AN_MorellaEvidenceConfront..."*)

### Węzeł `[234]`
Mówca: **Narrator**
> "We parted ways and went to take our respective seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "After the usual greetings, I settled next to Laurento at ..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Alma Saltana");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Alma Saltana");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "We parted ways and went to take our respective seats."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "After the usual greetings, I settled next to Laurento at our table in the conference hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "He leaned over and whispered in my ear."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Morella_Allied == true && RiziaDLC.Revolutionary_Pipeline_Sabotage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.CountryRelation_Morella_Allied == true && RiziaD..."*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.CountryRelation_Morella_Allied == true && Rizi..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.CountryRelation_Morella_Allied == true && RiziaDLC.Revolutionary_Pipeline_Sabotage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.CountryRelation_Morella_Allied"] == true  and  Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "At the same time, I noticed Prime Minister Alma Saltana s..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.CountryRelation_Morella_Allied == true && RiziaDLC.Revolutionary_Pipeline_Sabotage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.CountryRelation_Morella_Allied"] == true  and  Variable["RiziaDLC.Revolutionary_Pipeline_Sabotage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "After the usual greetings, Laurento and I settled at our ..."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "At the same time, I noticed Prime Minister Alma Saltana standing nearby, trying to get my attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player_Romus: ""You go on ahead. I need a quick word with Madam Prime Mi..."*)
  - -> `[200]` (*Player_Romus: ""Well, shall we go inside?""*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You go on ahead. I need a quick word with Madam Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Laurento Esquibel: ""Yes, of course.""*)

### Węzeł `[242]`
Mówca: **Laurento Esquibel**
> ""Yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "He bowed and walked into the chamber."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "He bowed and walked into the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Laurento Esquibel");"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Laurento Esquibel");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Laurento Esquibel");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "Saltana turned to face me head-on as I approached her."*)

### Węzeł `[245]`
Mówca: **Narrator**
> "Saltana turned to face me head-on as I approached her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)
  - -> `[248]` (*Player_Romus: ""It's good to see you again, Ms. Saltana.""*)
  - -> `[246]` (*Player_Romus: ""Changed your mind about my marriage offer?""*)
  - -> `[255]` (*Player_Romus: ""How are you?""*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Changed your mind about my marriage offer?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[245]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "She rolled her eyes."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "She rolled her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Alma Saltana: ""I'll make this quick. Connections of mine have revealed ..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's good to see you again, Ms. Saltana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[245]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Alma Saltana: ""Likewise, {RiziaDLCText.SaltanaToPlayer}.""*)

### Węzeł `[249]`
Mówca: **Alma Saltana**
> ""Likewise, {RiziaDLCText.SaltanaToPlayer}.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Alma Saltana: ""I'll make this quick. Connections of mine have revealed ..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImag..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Player_Romus: ""I hope I can count on you to vote in Rizia's favor today.""*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope I can count on you to vote in Rizia's favor today.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true`
- **Kontekst wejściowy (poprzednik):** `[245]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Alma Saltana: ""You have Morella's support, {RiziaDLCText.SaltanaToPlaye..."*)

### Węzeł `[254]`
Mówca: **Alma Saltana**
> ""You have Morella's support, {RiziaDLCText.SaltanaToPlayer}. But that's not why I want to talk to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Alma Saltana: ""I'll make this quick. Connections of mine have revealed ..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[245]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Alma Saltana: ""Very busy. But there's something you should be aware of.""*)

### Węzeł `[256]`
Mówca: **Alma Saltana**
> ""Very busy. But there's something you should be aware of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Alma Saltana: ""I'll make this quick. Connections of mine have revealed ..."*)

### Węzeł `[257]`
Mówca: **Narrator**
> "She handed me a sheet of paper. On it was a list of names and addresses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Alma Saltana: ""I trust you to use this wisely.""*)

### Węzeł `[258]`
Mówca: **Alma Saltana**
> ""I'll make this quick. Connections of mine have revealed a potential sabotage plot by revolutionaries in your country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true"*)

### Węzeł `[259]`
Mówca: **Alma Saltana**
> ""They appear to be targeting your energy infrastructure. If they succeed, it'd be ruinous for our energy agreement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "She handed me a sheet of paper. On it was a list of names..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true"*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true)"*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Alma Saltana: ""They appear to be targeting your energy infrastructure. ..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Alma Saltana: ""They appear to be targeting your energy infrastructure.""*)

### Węzeł `[263]`
Mówca: **Alma Saltana**
> ""They appear to be targeting your energy infrastructure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "She handed me a sheet of paper. On it was a list of names..."*)

### Węzeł `[264]`
Mówca: **Alma Saltana**
> ""I trust you to use this wisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player_Romus: ""Thank you.""*)
  - -> `[266]` (*Player_Romus: ""I'll see to it that every individual on this list is pun..."*)
  - -> `[272]` (*Player_Romus: ""Well, this is embarrassing. Why didn't Rizian intelligen..."*)
  - -> `[271]` (*Player_Romus: ""Your 'connections' revealed this plot? Was Morella in on..."*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true"*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Alma Saltana: ""What are allies for?""*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see to it that every individual on this list is punished to the full extent of the law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Alma Saltana: ""Just be careful. You wouldn't want to spark a backlash.""*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true"*)
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true)"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player_Romus: ""I value our agreement as much as you do. We'll take quic..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_TradeDeal_Morella == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I value our agreement as much as you do. We'll take quick action to prevent disaster.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Diplomacy_TradeDeal_Morella"] == true`
- **Kontekst wejściowy (poprzednik):** `[264]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Alma Saltana: ""I wouldn't expect anything less.""*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'connections' revealed this plot? Was Morella in on it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Narrator: "She shook her head."*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, this is embarrassing. Why didn't Rizian intelligence get wind of it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Alma Saltana: ""A good question. I hope you'll be more attuned to this m..."*)

### Węzeł `[273]`
Mówca: **Narrator**
> "She shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Alma Saltana: ""Some of the more extreme left-wingers in my coalition ha..."*)

### Węzeł `[274]`
Mówca: **Alma Saltana**
> ""Some of the more extreme left-wingers in my coalition have had contact with Rizian anti-monarchists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[275]`
Mówca: **Alma Saltana**
> ""A good question. I hope you'll be more attuned to this movement going forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[276]`
Mówca: **Alma Saltana**
> ""What are allies for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Narrator: "She smiled wryly."*)

### Węzeł `[277]`
Mówca: **Narrator**
> "She smiled wryly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intermerkopum_Efforts == true )"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Efforts == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Efforts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Alma Saltana: ""I'm looking forward to hearing more about this inter-Mer..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intermerkopum_Efforts == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Efforts"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Alma Saltana: ""I have to say I'm troubled that a portion of your societ..."*)

### Węzeł `[281]`
Mówca: **Alma Saltana**
> ""I'm looking forward to hearing more about this inter-Merkopan alliance you're proposing. But I have to say I'm troubled that a portion of your society feels they have to resort to desperate measures to be heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player_Romus: ""These are rogue dissidents. They don't represent the opi..."*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[290]` (*Player_Romus: ""I hear them just fine. But they are demanding too much.""*)
  - -> `[293]` (*Player_Romus: ""You really don't need to concern yourself with the polit..."*)

### Węzeł `[282]`
Mówca: **Alma Saltana**
> ""I have to say I'm troubled that a portion of your society feels they have to resort to desperate measures to be heard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player_Romus: ""These are rogue dissidents. They don't represent the opi..."*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[290]` (*Player_Romus: ""I hear them just fine. But they are demanding too much.""*)
  - -> `[293]` (*Player_Romus: ""You really don't need to concern yourself with the polit..."*)

### Węzeł `[283]`
Mówca: **Alma Saltana**
> ""Just be careful. You wouldn't want to spark a backlash.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[284]`
Mówca: **Alma Saltana**
> ""I wouldn't expect anything less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Efforts == true"*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These are rogue dissidents. They don't represent the opinion of the entire working class.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Alma Saltana), `[282]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Alma Saltana: ""Can your Adarfo Sotelato confirm that?""*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have to worry. I am listening to their demands for reform and I'm planning to act.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[281]` (Alma Saltana), `[282]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Alma Saltana: ""Very intriguing. I hope you'll keep us informed.""*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Path == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Player_Romus: ""You don't have to worry. I am listening to their demands..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hear them just fine. But they are demanding too much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Alma Saltana), `[282]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Alma Saltana: ""It doesn't seem like too much to me.""*)

### Węzeł `[291]`
Mówca: **Alma Saltana**
> ""Very intriguing. I hope you'll keep us informed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "The loudspeaker voice repeated the announcement. Saltana ..."*)

### Węzeł `[292]`
Mówca: **Alma Saltana**
> ""Can your Adarfo Sotelato confirm that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "The loudspeaker voice repeated the announcement. Saltana ..."*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You really don't need to concern yourself with the political situation in Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Alma Saltana), `[282]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Alma Saltana: ""Apparently I do. Or would you prefer your pipelines expl..."*)

### Węzeł `[294]`
Mówca: **Alma Saltana**
> ""Apparently I do. Or would you prefer your pipelines exploded?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "The loudspeaker voice repeated the announcement. Saltana ..."*)

### Węzeł `[295]`
Mówca: **Alma Saltana**
> ""It doesn't seem like too much to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "The loudspeaker voice repeated the announcement. Saltana ..."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "The loudspeaker voice repeated the announcement. Saltana turned towards the conference hall doors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Alma Saltana: ""I'll be taking my seat now. See you in there.""*)

### Węzeł `[297]`
Mówca: **Alma Saltana**
> ""I'll be taking my seat now. See you in there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Player_Romus: ""Thanks again.""*)
  - -> `[299]` (*Player_Romus: ""Have a nice day, Madam Prime Minister.""*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_RevealedSabotagePlot = true; RiziaDLCSup..."*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have a nice day, Madam Prime Minister.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_RevealedSabotagePlot = true; RiziaDLCSup..."*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't forget to vote the right way.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true`
- **Kontekst wejściowy (poprzednik):** `[297]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Morella_RevealedSabotagePlot = true; RiziaDLCSup..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage ..."*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImag..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player_Romus: ""Don't forget to vote the right way.""*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage == true || RiziaDLC.ZilleReferendum_Disapproved == true || RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.ANSanctionAccusation_Lespia_GlobalImage"] == true  or  Variable["RiziaDLC.ZilleReferendum_Disapproved"] == true  or  Variable["RiziaDLCIsolated.ANSanctionAccusation_Valgsland_GlobalImage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn08_AN_MorellaEvidenceConfront = true; RiziaDLC.Morella_ConfrontedWithSabotageEvidence = true;
RiziaDLC.Reform_Movement_Radicalism -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_AN_MorellaEvidenceConfront"] = true;
Variable["RiziaDLC.Morella_ConfrontedWithSabotageEvidence"] = true;
Variable["RiziaDLC.Reform_Movement_Radicalism"] = Variable["RiziaDLC.Reform_Movement_Radicalism"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Morella_RevealedSabotagePlot = true; RiziaDLCSupport.Journal_Turn08_AN_MorellaSabotageReveal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Morella_RevealedSabotagePlot"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_AN_MorellaSabotageReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Alma Saltana");"*)

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""First things first. You are to expedite our MITZ shipments from this point onward. No more obstruction.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Kontekst wejściowy (poprzednik):** `[214]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "She nodded."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Renegotiation_Failed == true)"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Player_Romus: ""First things first. You are to expedite our MITZ shipmen..."*)
  - -> `[312]` (*Player_Romus: ""Call off the MITZ talks. We're going back to the way thi..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Renegotiation_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player_Romus: ""First things first. You are to honor our MITZ agreement...."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""First things first. You are to honor our MITZ agreement. No matter if Rizia doesn't hold up our end of the bargain.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[214]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "She nodded."*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Call off the MITZ talks. We're going back to the way things were.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Kontekst wejściowy (poprzednik):** `[214]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Alma Saltana: ""It's too late to call them off completely. But if Rizia ..."*)

### Węzeł `[313]`
Mówca: **Alma Saltana**
> ""It's too late to call them off completely. But if Rizia insists on the status quo, I will not get in your way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[314]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Adarfo Sotelato. Is he one of yours?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Kontekst wejściowy (poprzednik):** `[214]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Alma Saltana: ""No, of course not.""*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player_Romus: ""Adarfo Sotelato. Is he one of yours?""*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Player_Romus: ""How many of your people are embedded in the RPP?""*)

### Węzeł `[318]`
Mówca: **Alma Saltana**
> ""No, of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Alma Saltana: ""But in the case that any of his supporters have links to..."*)

### Węzeł `[319]`
Mówca: **Alma Saltana**
> ""But in the case that any of his supporters have links to Morella... they will cease being a problem from now on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How many of your people are embedded in the RPP?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[214]` (Alma Saltana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Alma Saltana: ""Officially, none.""*)

### Węzeł `[321]`
Mówca: **Alma Saltana**
> ""Officially, none.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Alma Saltana: ""But in the case that any of the party's supporters have ..."*)

### Węzeł `[322]`
Mówca: **Alma Saltana**
> ""But in the case that any of the party's supporters have links to Morella... they will cease being a problem from now on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.MITZ_Renegotiation_Failed == true"*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.MITZ_Renegotiation_Failed == true)"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.MITZ_Renegotiation_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella == true"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.MITZ_Renegotiation_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.MITZ_Renegotiation_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Alma Saltana");"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Budget_Modifier_MITZRevenues += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_MITZRevenues"] = Variable["RiziaDLC.Budget_Modifier_MITZRevenues"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Alma Saltana");"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella == true)"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Budget_Modifier_MITZRevenues += 1"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn03_DiplomaticEnvoy_Morella"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Budget_Modifier_MITZRevenues += 2"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Budget_Modifier_MITZRevenues += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Budget_Modifier_MITZRevenues"] = Variable["RiziaDLC.Budget_Modifier_MITZRevenues"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Alma Saltana");"*)
