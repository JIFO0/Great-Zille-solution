# Rizia/Turn 8/A_Reform_Manus

- **ID konwersacji:** `407`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/407_A_Reform_Manus.md`
- **Liczba węzłów dialogowych:** 870
- **Liczba wyborów gracza:** 170

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[75]** Manus Sazon
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Army_Unit_Azaro_Dead`
- `RiziaDLC.Army_Unit_Azaro_Total`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.Iza_PowerTransfer_Angelica`
- `RiziaDLC.Iza_PowerTransfer_Council_Brenas`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Pales_War`
- `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies`
- `RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality`
- `RiziaDLC.Policy_RD_Welfare_ElectoralReform`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Reform_Aggressive`
- `RiziaDLC.Reform_Diplomatic`
- `RiziaDLC.Reform_Legislative_HouseOfLords`
- `RiziaDLC.Reform_Movement_Grows`
- `RiziaDLC.Reform_Movement_Leader_Adarfo`
- `RiziaDLC.Reform_Silent`
- `RiziaDLC.Reform_TalkToAdarfo_AskedManus`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Relations_HouseSazon_AngelicaPardoned`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Manus_OverthrowMonarchy`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Rico_Arrested`
- `RiziaDLC.Rico_Deposed`
- `RiziaDLC.Rico_Extradited`
- `RiziaDLC.Rico_PoliceChief_PorteDrazon`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Turn02_Intention_NoMonarchy`
- `RiziaDLC.Unrest_Police_PulledBack`
- `RiziaDLC.Vina_DuchessOfValenqiris`
- `RiziaDLC.Vina_Engaged`
- `RiziaDLC.Vina_FullCouncilor`
- `RiziaDLC.Vina_Hostage`
- `RiziaDLC.Vina_MarriageDecision_Axel`
- `RiziaDLC.Vina_MarriageDecision_Manus`
- `RiziaDLC.Vina_MarriageDecision_Rico`
- `RiziaDLC.Vina_OnCouncil`
- `RiziaDLC.War_Control_Skipped`
- `RiziaDLC.War_Pales_Operation1_Won`
- `RiziaDLCIsolated.Reform_Threat_Azaro`
- `RiziaDLCIsolated.Reform_Threat_Azaro_Talk`
- `RiziaDLCIsolated.Reform_Threat_Toras`
- `RiziaDLCIsolated.Reform_Threat_Toras_Talk`
- `RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk`
- `RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Reform_Aggressive`
- `RiziaDLC.Reform_Diplomatic`
- `RiziaDLC.Reform_Involve_Vina`
- `RiziaDLC.Reform_Legislative_HouseOfLords`
- `RiziaDLC.Reform_Legislative_RegionalSenate`
- `RiziaDLC.Reform_Monarch_Veto`
- `RiziaDLC.Reform_Path`
- `RiziaDLC.Reform_Path_Cancelled`
- `RiziaDLC.Reform_Regions_Centralized`
- `RiziaDLC.Reform_Silent`
- `RiziaDLC.Reform_TalkToAdarfo_AskedManus`
- `RiziaDLC.Reform_UpperHouse_Advisory`
- `RiziaDLC.Reform_UpperHouse_Equal`
- `RiziaDLC.Reform_UpperHouse_Limited`
- `RiziaDLCIsolated.Reform_Intention_Judiciary_Independent`
- `RiziaDLCIsolated.Reform_Intention_Legislative_Bicameral`
- `RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral`
- `RiziaDLCIsolated.Reform_Intention_Monarch_Approval`
- `RiziaDLCIsolated.Reform_Intention_Monarch_Veto`
- `RiziaDLCIsolated.Reform_Intention_PM_Daria`
- `RiziaDLCIsolated.Reform_Threat_Azaro`
- `RiziaDLCIsolated.Reform_Threat_Azaro_Talk`
- `RiziaDLCIsolated.Reform_Threat_Toras`
- `RiziaDLCIsolated.Reform_Threat_Toras_Talk`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon`
- `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras`
- `RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **""I have no problem with that.""** | `[18]` **Manus Sazon**: ""Instead of the monarch, they wi..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[26]` **Manus Sazon**: ""We can discuss the exact detail..." |
| `[9]` | **""I agree. The monarch should act as the head of state, not the head of government.""** | `[11]` **Manus Sazon**: ""After all, a constitutional mon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Manus Sazon**: ""That's what we've been working ..." |
| `[12]` | **""I disagree. Even with an empowered parliament, the monarch should retain substant..."** | `[11]` **Manus Sazon**: ""After all, a constitutional mon..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Manus Sazon**: ""Mr. Sotelato will never budge o..."<br>`[15]` **Manus Sazon**: ""The constitution has to balance..." |
| `[13]` | **""You are not thinking radically enough, Mr. Sazon. I don't believe the monarch sho..."** | `[11]` **Manus Sazon**: ""After all, a constitutional mon..." | `Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true` | *Brak zmian stanu* | `[14]` **Manus Sazon**: ""I know we had this conversation..."<br>`[245]` **Manus Sazon**: ""This has to be a slow, gradual ..." |
| `[19]` | **""Only if their decisions are subject to the monarch's -- to *my* -- approval.""** | `[18]` **Manus Sazon**: ""Instead of the monarch, they wi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Reform_Intention_Monarch_Appro...` | `[23]` **Manus Sazon**: ""Hm... We can propose that the m..." |
| `[20]` | **""Only if the monarch holds the right to veto their decisions.""** | `[18]` **Manus Sazon**: ""Instead of the monarch, they wi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Reform_Intention_Monarch_Veto"...` | `[24]` **Manus Sazon**: ""Hm... We can propose a veto pro..." |
| `[29]` | **""I'd rather not disturb the regional system. We should respect the autonomy of the..."** | `[28]` **Manus Sazon**: ""Keeping the provinces semi-auto..."<br>`[632]` **Manus Sazon**: ""Keep in mind that the royal hou..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[644]` **Manus Sazon**: ""Respecting regional traditions ..." |
| `[30]` | **""Rizia still resembles a feudal state. We should find ways to abolish that.""** | `[28]` **Manus Sazon**: ""Keeping the provinces semi-auto..."<br>`[632]` **Manus Sazon**: ""Keep in mind that the royal hou..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Regions_Centralized"] = true;` | `[35]` **Manus Sazon**: ""I do have one concern there."" |
| `[31]` | **""In a system that already has several branches of government and many actors, a de..."** | `[28]` **Manus Sazon**: ""Keeping the provinces semi-auto..."<br>`[632]` **Manus Sazon**: ""Keep in mind that the royal hou..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Regions_Centralized"] = true;` | `[35]` **Manus Sazon**: ""I do have one concern there."" |
| `[38]` | **""The regions should have no autonomy or separate political structures. There must ..."** | `[36]` **Manus Sazon**: ""A centralized government might ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "He nodded." |
| `[39]` | **""While we should strive for each region to be represented in the House of Delegate..."** | `[36]` **Manus Sazon**: ""A centralized government might ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Narrator**: "He nodded." |
| `[40]` | **""It might be unpopular, but this is my vision for the kingdom.""** | `[36]` **Manus Sazon**: ""A centralized government might ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Manus Sazon**: ""I understand that, Your Majesty."" |
| `[41]` | **""Each region should function as a state, and be allowed to exercise autonomy withi..."** | `[37]` **Manus Sazon**: ""However, it raises questions re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Narrator**: "He nodded." |
| `[42]` | **""We should respect the historical, financial and demographical differences of the ..."** | `[37]` **Manus Sazon**: ""However, it raises questions re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Manus Sazon**: ""I'm not sure about that, Your M..."<br>`[44]` **Manus Sazon**: ""We can offer the nobility somet..." |
| `[43]` | **""I wouldn't change anything drastic. Keeping the current decentralized system will..."** | `[37]` **Manus Sazon**: ""However, it raises questions re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Manus Sazon**: ""I agree."" |
| `[50]` | **""In a federal system such as this, having a second legislative body representing t..."** | `[49]` **Manus Sazon**: ""If the regions retain a degree ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_B...` | `[66]` **Manus Sazon**: ""I see your point. A bicameral s..." |
| `[51]` | **""We need to give something to the nobility for their support. We could have an upp..."** | `[49]` **Manus Sazon**: ""If the regions retain a degree ..."<br>`[53]` **Manus Sazon**: ""Abolishing the regional power s..." | `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false` | *Brak zmian stanu* | `[651]` **Manus Sazon**: ""I see. A House of Lords, so to ..." |
| `[52]` | **""The legislative body should be unicameral. Complicating the system will only make..."** | `[49]` **Manus Sazon**: ""If the regions retain a degree ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_U...` | `[65]` **Manus Sazon**: ""I understand where you're comin..." |
| `[54]` | **""I agree. Legislative responsibility must be left to one single elected parliament.""** | `[53]` **Manus Sazon**: ""Abolishing the regional power s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[663]` **Manus Sazon**: ""That's settled, then."" |
| `[55]` | **""Yes, we already have a parliament. It'll only make the system less efficient if w..."** | `[53]` **Manus Sazon**: ""Abolishing the regional power s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_U...` | `[65]` **Manus Sazon**: ""I understand where you're comin..." |
| `[70]` | **""I agree. Judicial independence serves to safeguard the rights and privileges prov..."** | `[68]` **Manus Sazon**: ""The judiciary interprets, defen..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Reform_Intention_Judiciary_Ind...` | `[75]` **Manus Sazon**: ""Yes. The judiciary's role in de..." |
| `[71]` | **""Fine by me. The amount of respect that people have for the law is dependent upon ..."** | `[68]` **Manus Sazon**: ""The judiciary interprets, defen..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Reform_Intention_Judiciary_Ind...` | `[75]` **Manus Sazon**: ""Yes. The judiciary's role in de..." |
| `[72]` | **""The judiciary can't be too independent. There must be mechanisms to prevent their..."** | `[68]` **Manus Sazon**: ""The judiciary interprets, defen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Manus Sazon**: ""I don't disagree. But the key i..." |
| `[73]` | **""It *should* be, yes. But it is impossible to design a system without any flaws. T..."** | `[68]` **Manus Sazon**: ""The judiciary interprets, defen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Manus Sazon**: ""I don't disagree. But the key i..." |
| `[92]` | **""I can't know for sure. General Taddeus is in charge of the armed forces, and for ..."** | `[679]` **Manus Sazon**: ""With that said, General Taddeus..." | `(Variable["RiziaDLC.War_Control_Skipped"] == false) == false` | *Brak zmian stanu* | `[141]` **Manus Sazon**: ""That might become a problem."" |
| `[96]` | **""Actually, the bulk of their forces have been destroyed in the war. I don't think ..."** | `[679]` **Manus Sazon**: ""With that said, General Taddeus..." | `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0`<br>`Variable["RiziaDLC.War_Control_Skipped"] == false` | *Brak zmian stanu* | `[136]` **Manus Sazon**: ""Interesting news."" |
| `[103]` | **""Don't worry. I'm giving the orders in this war. I can make sure the Azaro troops ..."** | `[679]` **Manus Sazon**: ""With that said, General Taddeus..." | `Variable["RiziaDLC.Army_Unit_Azaro_Total"] > 0  and  Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`<br>`(Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0) == false`<br>`Variable["RiziaDLC.War_Control_Skipped"] == false` | *Brak zmian stanu* | `[137]` **Manus Sazon**: ""An interesting plan..."" |
| `[107]` | **""The war is going terribly. The Azaros and their troops will have to keep their en..."** | `[679]` **Manus Sazon**: ""With that said, General Taddeus..." | `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false` | *Brak zmian stanu* | `[140]` **Manus Sazon**: ""I understand..."" |
| `[108]` | **""We are winning the war, Manus. If Rizia emerges victorious, House Azaro will have..."** | `[679]` **Manus Sazon**: ""With that said, General Taddeus..." | `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true` | *Brak zmian stanu* | `[141]` **Manus Sazon**: ""That might become a problem."" |
| `[109]` | **""We still have to be careful. Even with a war going on, the Azaros are more than c..."** | `[679]` **Manus Sazon**: ""With that said, General Taddeus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Manus Sazon**: ""I see."" |
| `[110]` | **""I don't think they pose a threat. They can't simply go against both the will of t..."** | `[90]` **Manus Sazon**: ""Tell me your honest opinion. Wi..."<br>`[679]` **Manus Sazon**: ""With that said, General Taddeus..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Manus Sazon**: ""I hope you are right."" |
| `[111]` | **""With Lucita in prison, their ability to organize is weaker than before. But we ha..."** | `[90]` **Manus Sazon**: ""Tell me your honest opinion. Wi..." | `Variable["RiziaDLC.Lucita_Arrested"] == true` | *Brak zmian stanu* | `[130]` **Manus Sazon**: ""I agree."" |
| `[122]` | **""We won't have to worry about the police. I gave the order for our internal securi..."** | `[90]` **Manus Sazon**: ""Tell me your honest opinion. Wi..." | `Variable["RiziaDLC.Unrest_Police_PulledBack"] == true` | *Brak zmian stanu* | `[129]` **Manus Sazon**: ""Thank you, Your Majesty. Althou..." |
| `[123]` | **""I've already done a lot on that front. House Azaro no longer controls Rizia's sec..."** | `[90]` **Manus Sazon**: ""Tell me your honest opinion. Wi..." | `Variable["RiziaDLC.Council_Security_Titus"] == true` | *Brak zmian stanu* | `[128]` **Manus Sazon**: ""Great thinking, Your Majesty. A..." |
| `[127]` | **""They won't be able to raise an army against us. I made sure of that when I remove..."** | `[90]` **Manus Sazon**: ""Tell me your honest opinion. Wi..." | `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true` | *Brak zmian stanu* | `[128]` **Manus Sazon**: ""Great thinking, Your Majesty. A..." |
| `[134]` | **""I can handle Lucita. She and I have an... understanding.""** | `[90]` **Manus Sazon**: ""Tell me your honest opinion. Wi..."<br>`[679]` **Manus Sazon**: ""With that said, General Taddeus..." | `Variable["RiziaDLC.Relations_Lucita_Together"] == true` | *Brak zmian stanu* | `[138]` **Manus Sazon**: ""If you're confident you can con..." |
| `[144]` | **""My family and I are not on the best of terms as it is. They'll never accept a new..."** | `[143]` **Manus Sazon**: ""Your uncle holds incredible swa..." | `Variable["RiziaDLC.Country_HouseToras"] < 0` | `Variable["RiziaDLCIsolated.Reform_Threat_Toras"] = true;` | `[152]` **Manus Sazon**: ""That complicates things. You ca..." |
| `[148]` | **""All Hugo cares about is that the nobility of Rizia is respected. I'll find a way ..."** | `[143]` **Manus Sazon**: ""Your uncle holds incredible swa..." | `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`<br>`(Variable["RiziaDLC.Country_HouseToras"] < 0) == false` | *Brak zmian stanu* | `[151]` **Manus Sazon**: ""That's a relief."" |
| `[149]` | **""If there is anyone who can claim the throne during a crisis, that's my uncle. I d..."** | `[143]` **Manus Sazon**: ""Your uncle holds incredible swa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Reform_Threat_Toras"] = true;` | `[152]` **Manus Sazon**: ""That complicates things. You ca..." |
| `[150]` | **""Don't worry about the Toras family. They are not going to be a problem.""** | `[143]` **Manus Sazon**: ""Your uncle holds incredible swa..." | `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false` | *Brak zmian stanu* | `[151]` **Manus Sazon**: ""That's a relief."" |
| `[153]` | **""Let them try.""** | `[152]` **Manus Sazon**: ""That complicates things. You ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Manus Sazon**: ""I will not condone violence, Yo..." |
| `[154]` | **""We don't need their support. They cannot simply fight against the democratic move..."** | `[152]` **Manus Sazon**: ""That complicates things. You ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Manus Sazon**: ""I don't know about that... But ..." |
| `[155]` | **""We have to be diplomatic. I cannot reform Rizia without involving my own family.""** | `[152]` **Manus Sazon**: ""That complicates things. You ca..." | `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false` | `Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] = t...` | `[207]` **Manus Sazon**: ""I understand."" |
| `[169]` | **""I think you're too worried about all this, Manus. You should relax. I'm willing t..."** | `[164]` **Manus Sazon**: ""Any more thoughts before we ful..." | `Variable["RiziaDLC.Reform_Aggressive"] == true` | *Brak zmian stanu* | `[176]` **Manus Sazon**: ""Well... I have no power to stop..." |
| `[170]` | **""No. We've covered everything.""** | `[164]` **Manus Sazon**: ""Any more thoughts before we ful..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[819]` **Manus Sazon**: ""There is one more point I wante..."<br>`[258]` **Narrator**: "His eyes welled up slightly." |
| `[174]` | **""Be careful, Manus. My daughter's grown quite attached to you. For her sake, I don..."** | `[164]` **Manus Sazon**: ""Any more thoughts before we ful..." | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | *Brak zmian stanu* | `[175]` **Manus Sazon**: ""Don't worry, Your Majesty. You ..." |
| `[177]` | **""She is there to represent and protect the rights of the nobility. How do you plan..."** | `[166]` **Manus Sazon**: ""I don't expect her or the RNC t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[732]` **Manus Sazon**: ""Exactly. That's the problem."" |
| `[181]` | **""Thank you. We'll see each other again.""** | `[180]` **Manus Sazon**: ""I will reach out to you when it..."<br>`[222]` **Manus Sazon**: ""I will reach out to you when it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Manus Sazon**: ""It won't be long now. I promise."" |
| `[182]` | **""I greatly respect what you're doing, Manus. I hope this plan works out -- for bot..."** | `[180]` **Manus Sazon**: ""I will reach out to you when it..."<br>`[222]` **Manus Sazon**: ""I will reach out to you when it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Manus Sazon**: ""It won't be long now. I promise."" |
| `[183]` | **""I don't know how long I can keep it a secret while your movement is asking to cha..."** | `[180]` **Manus Sazon**: ""I will reach out to you when it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Manus Sazon**: ""Of course. We just have to make..." |
| `[188]` | **""Thank *you* for your devotion to the reformist cause, Manus.""** | `[62]` **Manus Sazon**: ""This will carve your name in th..." | `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true` | *Brak zmian stanu* | `[257]` **Manus Sazon**: ""It's the only way forward, as I..." |
| `[189]` | **""We're here to make plans. You don't need to butter me up.""** | `[62]` **Manus Sazon**: ""This will carve your name in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Manus Sazon**: ""I wasn't trying."" |
| `[190]` | **""I'm not doing this for reputation or legacy. A monarch who gives his power away w..."** | `[62]` **Manus Sazon**: ""This will carve your name in th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Manus Sazon**: ""If you say so, Your Majesty."" |
| `[202]` | **""I'm not as worried about Hugo as I am about my cousin Ricardus.""** | `[143]` **Manus Sazon**: ""Your uncle holds incredible swa..." | `(Variable["RiziaDLC.Rico_Deposed"] == true) == false`<br>`Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false` | `Variable["RiziaDLCIsolated.Reform_Threat_Toras"] = true;` | `[152]` **Manus Sazon**: ""That complicates things. You ca..." |
| `[203]` | **""I arrested Hugo's only son. I wouldn't be surprised if he was plotting revenge ag..."** | `[143]` **Manus Sazon**: ""Your uncle holds incredible swa..." | `(Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false) == false` | *Brak zmian stanu* | `[204]` **Narrator**: "Manus looked troubled." |
| `[223]` | **""Good job. I hope everything works according to plan. We'll see each other very so..."** | `[222]` **Manus Sazon**: ""I will reach out to you when it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Manus Sazon**: ""It won't be long now. I promise."" |
| `[224]` | **""That's a good idea. She can be instrumental in controlling the narrative. I will ..."** | `[213]` **Manus Sazon**: ""And as Lady Regent, she's very ..."<br>`[220]` **Manus Sazon**: ""And as Duchess of Valenqiris, s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Involve_Vina"] = true; Variable...` | `[229]` **Manus Sazon**: ""Great."" |
| `[225]` | **""Yes. She would be a great asset. I will involve her immediately.""** | `[213]` **Manus Sazon**: ""And as Lady Regent, she's very ..."<br>`[220]` **Manus Sazon**: ""And as Duchess of Valenqiris, s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Involve_Vina"] = true; Variable...` | `[229]` **Manus Sazon**: ""Great."" |
| `[226]` | **""Absolutely not. We're not going to involve her in this.""** | `[213]` **Manus Sazon**: ""And as Lady Regent, she's very ..."<br>`[220]` **Manus Sazon**: ""And as Duchess of Valenqiris, s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Manus Sazon**: ""If you think that's best, I und..." |
| `[234]` | **""Nobody important.""** | `[233]` **Manus Sazon**: ""Does someone else know about th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Manus Sazon**: ""All right..."" |
| `[235]` | **""Trust me. We're secure.""** | `[233]` **Manus Sazon**: ""Does someone else know about th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Manus Sazon**: ""All right..."" |
| `[236]` | **""We could be compromised. Let's make this quick.""** | `[233]` **Manus Sazon**: ""Does someone else know about th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Manus Sazon**: ""All right..."" |
| `[251]` | **""Certain household staff members. But they would never rat us out.""** | `[233]` **Manus Sazon**: ""Does someone else know about th..." | `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true` | *Brak zmian stanu* | `[237]` **Manus Sazon**: ""All right..."" |
| `[255]` | **""I wouldn't be doing this if it wasn't what Vina wanted.""** | `[62]` **Manus Sazon**: ""This will carve your name in th..." | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[542]` **Manus Sazon**: ""When the Crown Princess returns..."<br>`[256]` **Manus Sazon**: ""The Crown Princess has inspired..." |
| `[287]` | **""We've got to get at least two of the three royal Houses to approve. I don't see h..."** | `[273]` **Manus Sazon**: ""Unfortunately, we're still the ..."<br>`[286]` **Manus Sazon**: ""The problem is that not only is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[302]` **Manus Sazon**: ""I'm telling you, Your Majesty. ..." |
| `[288]` | **""If they do, we'll fight back. No one goes up against the King and lives.""** | `[273]` **Manus Sazon**: ""Unfortunately, we're still the ..."<br>`[286]` **Manus Sazon**: ""The problem is that not only is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Manus Sazon**: ""Please, Your Majesty. All our e..." |
| `[289]` | **""I'm having second thoughts about this.""** | `[273]` **Manus Sazon**: ""Unfortunately, we're still the ..."<br>`[286]` **Manus Sazon**: ""The problem is that not only is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Manus Sazon**: ""Don't worry, Your Majesty."" |
| `[290]` | **""Well, that's why we're here alone in this dark damp room, aren't we?""** | `[273]` **Manus Sazon**: ""Unfortunately, we're still the ..."<br>`[286]` **Manus Sazon**: ""The problem is that not only is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Narrator**: "He let out a short laugh." |
| `[293]` | **""We've got to get at least two of the three royal Houses on board. Otherwise, our ..."** | `[282]` **Manus Sazon**: ""As majority speaker in the Hous..."<br>`[336]` **Manus Sazon**: ""If we want a peaceful resolutio..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[300]` **Manus Sazon**: ""We can try."" |
| `[294]` | **""I don't intend to include the nobles in the reform process. We already know they ..."** | `[282]` **Manus Sazon**: ""As majority speaker in the Hous..."<br>`[336]` **Manus Sazon**: ""If we want a peaceful resolutio..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[320]` **Manus Sazon**: ""We can add some concessions to ..." |
| `[295]` | **""This is our best chance, Manus. We have to seize it.""** | `[282]` **Manus Sazon**: ""As majority speaker in the Hous..."<br>`[336]` **Manus Sazon**: ""If we want a peaceful resolutio..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Manus Sazon**: ""We will, Your Majesty."" |
| `[296]` | **""Does that imply the existence of a *non-peaceful* resolution?""** | `[282]` **Manus Sazon**: ""As majority speaker in the Hous..."<br>`[336]` **Manus Sazon**: ""If we want a peaceful resolutio..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Manus Sazon**: ""If you're referring to the use ..." |
| `[307]` | **""And how do we do it without them? After all, it's not possible to hide the fact t..."** | `[303]` **Manus Sazon**: ""Declaring our reform intentions..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Manus Sazon**: ""Of course not, Your Majesty."" |
| `[308]` | **""Then I will make sure they won't have the capacity to put their focus against us.""** | `[303]` **Manus Sazon**: ""Declaring our reform intentions..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Manus Sazon**: ""I understand what you're saying..." |
| `[309]` | **""What do you suggest, then?""** | `[303]` **Manus Sazon**: ""Declaring our reform intentions..."<br>`[306]` **Manus Sazon**: ""Please, Your Majesty. All our e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Manus Sazon**: ""There is a reason why we're mee..." |
| `[326]` | **""You're suggesting we attempt a coup.""** | `[313]` **Manus Sazon**: ""With millions of people on the ..."<br>`[330]` **Manus Sazon**: ""It would be too late for any fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[333]` **Manus Sazon**: ""Well, I wouldn't phrase it that..." |
| `[327]` | **""I like the sound of it.""** | `[313]` **Manus Sazon**: ""With millions of people on the ..."<br>`[330]` **Manus Sazon**: ""It would be too late for any fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Manus Sazon**: ""But before we start planning ho..." |
| `[328]` | **""With House Azaro's intelligence capabilities and House Toras' eyes and ears withi..."** | `[313]` **Manus Sazon**: ""With millions of people on the ..."<br>`[330]` **Manus Sazon**: ""It would be too late for any fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[334]` **Manus Sazon**: ""It won't be easy."" |
| `[329]` | **""I disagree. Even if we do this exactly the way you describe, the nobility can sti..."** | `[313]` **Manus Sazon**: ""With millions of people on the ..."<br>`[330]` **Manus Sazon**: ""It would be too late for any fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Manus Sazon**: ""Only if they themselves have en..." |
| `[355]` | **""Yes, definitely. They'll never agree to these reforms peacefully.""** | `[90]` **Manus Sazon**: ""Tell me your honest opinion. Wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Manus Sazon**: ""That's a problem."" |
| `[357]` | **""Without eyes or ears inside the house, I have no idea whether they're a threat or..."** | `[90]` **Manus Sazon**: ""Tell me your honest opinion. Wi..."<br>`[679]` **Manus Sazon**: ""With that said, General Taddeus..." | `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false` | *Brak zmian stanu* | `[135]` **Manus Sazon**: ""That's a problem."" |
| `[361]` | **""I don't know about Hugo. But I do know that my cousin Ricardus would love nothing..."** | `[143]` **Manus Sazon**: ""Your uncle holds incredible swa..." | `Variable["RiziaDLC.Rico_Deposed"] == true`<br>`Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false` | `Variable["RiziaDLCIsolated.Reform_Threat_Toras"] = true;` | `[152]` **Manus Sazon**: ""That complicates things. You ca..." |
| `[365]` | **""There is still time for me to get on their good side. But we have to make a plan ..."** | `[152]` **Manus Sazon**: ""That complicates things. You ca..." | `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false` | *Brak zmian stanu* | `[366]` **Manus Sazon**: ""Yes. I understand."" |
| `[376]` | **""All Hugo cares about is that the nobility of Rizia is respected. If we keep Valen..."** | `[143]` **Manus Sazon**: ""Your uncle holds incredible swa..." | `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`<br>`(Variable["RiziaDLC.Country_HouseToras"] < 0) == false` | *Brak zmian stanu* | `[151]` **Manus Sazon**: ""That's a relief."" |
| `[389]` | **""Are you sure that's where her loyalties truly lie? What if she's been a secret re..."** | `[387]` **Manus Sazon**: ""I will be honest. This is a set..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Manus Sazon**: ""If she were, I would know."" |
| `[390]` | **""I am the one who pardoned her. If she's truly loyal, she will support me.""** | `[387]` **Manus Sazon**: ""I will be honest. This is a set..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[397]` **Manus Sazon**: ""She is loyal to the Crown. Not ..." |
| `[391]` | **""Give it to me straight. Can you handle this yourself?""** | `[387]` **Manus Sazon**: ""I will be honest. This is a set..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Manus Sazon**: ""I can't guarantee it. All I can..." |
| `[392]` | **""If she and your kin don't fall in line, I will make them.""** | `[387]` **Manus Sazon**: ""I will be honest. This is a set..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[394]` **Narrator**: "A look of fear flashed on his face." |
| `[400]` | **""If the very institution that you'll be empowering doesn't recognize or accept the..."** | `[166]` **Manus Sazon**: ""I don't expect her or the RNC t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Manus Sazon**: ""Exactly. That is the problem."" |
| `[401]` | **""And why do we care? We're already making enemies. The RNC is the least of our wor..."** | `[166]` **Manus Sazon**: ""I don't expect her or the RNC t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[403]` **Manus Sazon**: ""They are a worry, Your Majesty...." |
| `[402]` | **""What do you mean? They are loyal to the Crown.""** | `[166]` **Manus Sazon**: ""I don't expect her or the RNC t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[732]` **Manus Sazon**: ""Exactly. That's the problem."" |
| `[474]` | **""The nobility will strike as soon as they learn we're cooperating with the revolut..."** | `[483]` **Manus Sazon**: ""But it might not be enough to s..."<br>`[506]` **Manus Sazon**: ""Then what are you thinking?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Silent"] = true;` | `[511]` **Manus Sazon**: ""I understand."" |
| `[488]` | **""I honestly don't know if I have enough sway with the Royal Houses to convince the..."** | `[468]` **Manus Sazon**: ""What do you say, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[506]` **Manus Sazon**: ""Then what are you thinking?"" |
| `[489]` | **""I agree with you, Manus. The sooner we publicize our reform intentions, the soone..."** | `[454]` **Manus Sazon**: ""What do you say, Your Majesty?""<br>`[468]` **Manus Sazon**: ""What do you say, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[508]` **Manus Sazon**: ""Then it is settled, Your Majest..." |
| `[490]` | **""I know I said I could convince the nobility. But upon further reflection, I'm not..."** | `[454]` **Manus Sazon**: ""What do you say, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[506]` **Manus Sazon**: ""Then what are you thinking?"" |
| `[491]` | **""While I'm skeptical about declaring our reform intentions immediately, I do agree..."** | `[454]` **Manus Sazon**: ""What do you say, Your Majesty?""<br>`[468]` **Manus Sazon**: ""What do you say, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Manus Sazon**: ""I understand."" |
| `[492]` | **""The nobility will strike as soon as they learn what we're trying to do. I will no..."** | `[485]` **Manus Sazon**: ""But it might not be enough to s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Silent"] = true;` | `[511]` **Manus Sazon**: ""I understand."" |
| `[493]` | **""Once we declare our intentions, the power of the reform movement will be undeniab..."** | `[483]` **Manus Sazon**: ""But it might not be enough to s..."<br>`[485]` **Manus Sazon**: ""But it might not be enough to s..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Reform_Movement_Grows"] == true` | *Brak zmian stanu* | `[501]` **Manus Sazon**: ""No chance at all?"" |
| `[494]` | **""The stakes are too high to take half measures. We must strike the houses before t..."** | `[483]` **Manus Sazon**: ""But it might not be enough to s..."<br>`[485]` **Manus Sazon**: ""But it might not be enough to s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Aggressive"] = true;` | `[769]` **Manus Sazon**: ""I see..."" |
| `[495]` | **""I agree that the nobility will strike as soon as they learn what we're trying to ..."** | `[487]` **Manus Sazon**: ""My advice would be to lay low u..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Silent"] = true;` | `[511]` **Manus Sazon**: ""I understand."" |
| `[496]` | **""The stakes are too high to take half measures. We must organize a preemptive stri..."** | `[487]` **Manus Sazon**: ""My advice would be to lay low u..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Aggressive"] = true;` | `[769]` **Manus Sazon**: ""I see..."" |
| `[497]` | **""I still think we should be open and diplomatic with the royal houses. As Rizia's ..."** | `[483]` **Manus Sazon**: ""But it might not be enough to s..."<br>`[485]` **Manus Sazon**: ""But it might not be enough to s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Diplomatic"] = true;` | `[521]` **Manus Sazon**: ""So be it, Your Majesty. Perhaps..." |
| `[503]` | **""Once the pressure has built to a significant degree, we'll invite them for negoti..."** | `[502]` **Manus Sazon**: ""Even with the populace against ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Diplomatic"] = true;` | `[519]` **Manus Sazon**: ""An interesting plan, Your Majes..." |
| `[504]` | **""If we have to, we will strike first.""** | `[502]` **Manus Sazon**: ""Even with the populace against ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Aggressive"] = true;` | `[520]` **Manus Sazon**: ""I see..."" |
| `[505]` | **""You're right. It's too risky. We should be stealthy and prepare the new constitut..."** | `[502]` **Manus Sazon**: ""Even with the populace against ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Silent"] = true;` | `[511]` **Manus Sazon**: ""I understand."" |
| `[513]` | **""My benevolence has its limits. Sotelato's people know that without my cooperation..."** | `[512]` **Manus Sazon**: ""You can't be serious, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Manus Sazon**: ""I... I understand."" |
| `[514]` | **""I am very serious, Manus. Our collaboration is over. You'd better stop representi..."** | `[512]` **Manus Sazon**: ""You can't be serious, Your Maje..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Manus Sazon**: ""I... I understand."" |
| `[515]` | **""Don't make me repeat myself. Our meeting is over.""** | `[512]` **Manus Sazon**: ""You can't be serious, Your Maje..." | `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false` | *Brak zmian stanu* | `[523]` **Manus Sazon**: ""I... I understand."" |
| `[537]` | **""Don't get too excited. All I'm trying to do is keep your party's lunatic fringe f..."** | `[62]` **Manus Sazon**: ""This will carve your name in th..." | `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false` | *Brak zmian stanu* | `[538]` **Manus Sazon**: ""But you're not going after thei..." |
| `[549]` | **""A wise man once told me that violence is justified if it helps protect the divine..."** | `[306]` **Manus Sazon**: ""Please, Your Majesty. All our e..." | `Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk"] == true  or  Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk"] == true` | *Brak zmian stanu* | `[556]` **Manus Sazon**: ""Justified? You sound like my fa..." |
| `[553]` | **""I agree that violence should only be used as a last resort. But it sounds like we..."** | `[306]` **Manus Sazon**: ""Please, Your Majesty. All our e..." | `(Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk"] == true  or  Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk"] == true) == false` | *Brak zmian stanu* | `[557]` **Manus Sazon**: ""It doesn't have to come to that..." |
| `[554]` | **""I was speaking metaphorically. We'll fight them with our *words*.""** | `[306]` **Manus Sazon**: ""Please, Your Majesty. All our e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[555]` **Manus Sazon**: ""I was just about to tell you th..." |
| `[561]` | **""It's about time. Numbers make me dizzy.""** | `[18]` **Manus Sazon**: ""Instead of the monarch, they wi..." | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true` | `--;` | `[26]` **Manus Sazon**: ""We can discuss the exact detail..." |
| `[571]` | **""Then what will I do?""** | `[570]` **Manus Sazon**: ""They will lead a cabinet of min..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[569]` **Manus Sazon**: ""You will no longer rule, Your M..." |
| `[572]` | **""That sounds like far too much power for one person.""** | `[570]` **Manus Sazon**: ""They will lead a cabinet of min..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[574]` **Manus Sazon**: ""The head of government's powers..." |
| `[573]` | **""I don't object to any of this so far.""** | `[570]` **Manus Sazon**: ""They will lead a cabinet of min..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[575]` **Manus Sazon**: ""Very good."" |
| `[576]` | **""I agree. The monarch should act as the head of state, not the head of government.""** | `[570]` **Manus Sazon**: ""They will lead a cabinet of min..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[577]` **Manus Sazon**: ""That's what we've been working ..." |
| `[582]` | **""Only if their decisions are subject to the monarch's -- to *my* -- approval.""** | `[581]` **Manus Sazon**: ""Instead of the monarch, they wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[579]` **Manus Sazon**: ""With all due respect, Your Maje..." |
| `[583]` | **""Only if the monarch holds the right to veto their decisions.""** | `[581]` **Manus Sazon**: ""Instead of the monarch, they wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[579]` **Manus Sazon**: ""With all due respect, Your Maje..." |
| `[585]` | **""I'll miss being able to sign decrees.""** | `[581]` **Manus Sazon**: ""Instead of the monarch, they wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[590]` **Manus Sazon**: ""If I were in charge of the RPP,..." |
| `[589]` | **""Perfect. Numbers make my head hurt anyway.""** | `[581]` **Manus Sazon**: ""Instead of the monarch, they wi..." | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[591]` **Manus Sazon**: ""The responsibility must be pain..." |
| `[592]` | **""That's it? I was expecting much worse.""** | `[581]` **Manus Sazon**: ""Instead of the monarch, they wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[593]` **Manus Sazon**: ""I'm not finished with the list ..." |
| `[596]` | **""That makes sense. If I don't have any power, my relatives shouldn't either.""** | `[597]` **Manus Sazon**: ""Soletato's group is asking not ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[609]` **Manus Sazon**: ""I would expect nothing less fro..." |
| `[598]` | **""That's not fair. Some of Rizia's finest politicians are nobles.""** | `[597]` **Manus Sazon**: ""Soletato's group is asking not ..." | `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false) == false` | *Brak zmian stanu* | `[607]` **Manus Sazon**: ""They can run for election, like..." |
| `[602]` | **""Finishing the job my electoral reform decree started.""** | `[597]` **Manus Sazon**: ""Soletato's group is asking not ..." | `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false` | *Brak zmian stanu* | `[608]` **Manus Sazon**: ""More than that. In a few genera..." |
| `[603]` | **""A slap in the face to Rizian tradition.""** | `[597]` **Manus Sazon**: ""Soletato's group is asking not ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[606]` **Manus Sazon**: ""It will make many people very a..." |
| `[604]` | **""But they can keep their money, right?""** | `[597]` **Manus Sazon**: ""Soletato's group is asking not ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[605]` **Manus Sazon**: ""Whatever's left of it after the..." |
| `[612]` | **""I was fine with all the other demands. But I will not put an unproven commoner in..."** | `[611]` **Manus Sazon**: ""The RPP's demand is for Adarfo ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Narrator**: "His face fell." |
| `[613]` | **""If that's what it takes to get the reforms across the finish line, then I agree t..."** | `[611]` **Manus Sazon**: ""The RPP's demand is for Adarfo ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[616]` **Narrator**: "Manus broke into an enormous, re..." |
| `[614]` | **""This is all your mistake for letting RPP get radicalized. I'm afraid I will not a..."** | `[611]` **Manus Sazon**: ""The RPP's demand is for Adarfo ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Narrator**: "His face fell." |
| `[615]` | **""With terms like these, we might as well abolish the Rizian monarchy altogether.""** | `[611]` **Manus Sazon**: ""The RPP's demand is for Adarfo ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[618]` **Manus Sazon**: ""If that is what you want, all y..." |
| `[621]` | **""I'm willing to take that risk. Get me a meeting with Sotelato. I should have been..."** | `[619]` **Manus Sazon**: ""I warn you, though, he might no..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] = true;` | `[625]` **Narrator**: "His face fell." |
| `[622]` | **""It is not my intention to abdicate, Mr. Sazon. Nor is it my intention to hand ove..."** | `[619]` **Manus Sazon**: ""I warn you, though, he might no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Narrator**: "His face fell." |
| `[623]` | **""I only meant to say that Sotelato's demands are extreme. But I'll agree to them.""** | `[619]` **Manus Sazon**: ""I warn you, though, he might no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[616]` **Narrator**: "Manus broke into an enormous, re..." |
| `[643]` | **""A governing council is working out well for Iza. The provinces should adopt the s..."** | `[632]` **Manus Sazon**: ""Keep in mind that the royal hou..." | `Variable["RiziaDLC.Iza_PowerTransfer_Council_Brenas"] == true` | `--;` | `[644]` **Manus Sazon**: ""Respecting regional traditions ..." |
| `[648]` | **""Nor will Duke Axel Reinhart. I doubt he'll agree to reunification if it means Pal..."** | `[28]` **Manus Sazon**: ""Keeping the provinces semi-auto..." | `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true` | *Brak zmian stanu* | `[650]` **Narrator**: "Manus smiled thinly." |
| `[664]` | **""Good thinking. The upper chamber will be a House of Lords.""** | `[661]` **Manus Sazon**: ""Allowing the provincial nobilit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[655]` **Manus Sazon**: ""The rest of the RPP won't like ..."<br>`[656]` **Manus Sazon**: ""We'll have a hard time getting ..." |
| `[665]` | **""No, I want a clean slate. The upper chamber will be composed of elected represent..."** | `[661]` **Manus Sazon**: ""Allowing the provincial nobilit..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[666]` **Manus Sazon**: ""A regional senate. The RPP will..." |
| `[670]` | **""From now on, your duty is to be the Crown Prince Consort. I'll handle Sotelato.""** | `[512]` **Manus Sazon**: ""You can't be serious, Your Maje..." | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | *Brak zmian stanu* | `[523]` **Manus Sazon**: ""I... I understand."" |
| `[672]` | **""Let's discuss House Azaro.""** | `[671]` **Manus Sazon**: ""I've been thinking about the be..."<br>`[151]` **Manus Sazon**: ""That's a relief.""<br>*(oraz 24 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == false` | `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats...` | `[85]` **Manus Sazon**: ""I'll be honest with you. If any..." |
| `[673]` | **""Let's talk about my relatives in House Toras.""** | `[671]` **Manus Sazon**: ""I've been thinking about the be..."<br>`[151]` **Manus Sazon**: ""That's a relief.""<br>*(oraz 24 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == false` | `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats...` | `[142]` **Manus Sazon**: ""They may not have as much firep..." |
| `[674]` | **""How do you think House Sazon will react to the reforms?""** | `[671]` **Manus Sazon**: ""I've been thinking about the be..."<br>`[151]` **Manus Sazon**: ""That's a relief.""<br>*(oraz 24 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == false` | `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats...` | `[370]` **Manus Sazon**: ""Unfortunately, my mother may be..."<br>`[715]` **Narrator**: "He smiled." |
| `[680]` | **""We don't need to worry about General Taddeus. The last time we spoke, I made sure..."** | `[679]` **Manus Sazon**: ""With that said, General Taddeus..." | `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false` | *Brak zmian stanu* | `[681]` **Manus Sazon**: ""That's not very reassuring. The..." |
| `[692]` | **""He did not dare to strike back at me even after I arrested Rico. He won't be a pr..."** | `[143]` **Manus Sazon**: ""Your uncle holds incredible swa..." | `(Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false) == false` | *Brak zmian stanu* | `[693]` **Manus Sazon**: ""If you say so... You know your ..." |
| `[697]` | **""With my daughter about to marry his son? It'll never happen.""** | `[143]` **Manus Sazon**: ""Your uncle holds incredible swa..." | `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true` | *Brak zmian stanu* | `[698]` **Manus Sazon**: ""Correct me if I'm wrong, but th..." |
| `[704]` | **""After I made his son police chief? Not a chance.""** | `[143]` **Manus Sazon**: ""Your uncle holds incredible swa..." | `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true`<br>`Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false` | *Brak zmian stanu* | `[705]` **Manus Sazon**: ""But Your Majesty... now that Du..." |
| `[706]` | **""Dammit. You're right.""** | `[705]` **Manus Sazon**: ""But Your Majesty... now that Du..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Reform_Threat_Toras"] = true;` | `[152]` **Manus Sazon**: ""That complicates things. You ca..." |
| `[707]` | **""He could, but he wouldn't dare. I've got him under my thumb.""** | `[705]` **Manus Sazon**: ""But Your Majesty... now that Du..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[693]` **Manus Sazon**: ""If you say so... You know your ..." |
| `[726]` | **""That covers the royal houses. What about Daria and the House of Delegates?""** | `[671]` **Manus Sazon**: ""I've been thinking about the be..."<br>`[151]` **Manus Sazon**: ""That's a relief.""<br>*(oraz 10 innych węzłów)* | `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`<br>`Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true` | *Brak zmian stanu* | `[159]` **Manus Sazon**: ""I'm afraid the Rizian National ..." |
| `[730]` | **""That covers the royal houses. What about your fellow Delegates?""** | `[671]` **Manus Sazon**: ""I've been thinking about the be..."<br>`[151]` **Manus Sazon**: ""That's a relief.""<br>*(oraz 10 innych węzłów)* | `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`<br>`Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true` | *Brak zmian stanu* | `[734]` **Manus Sazon**: ""The RPP is the majority party, ..." |
| `[735]` | **""It's a waste of time to talk about the houses. Let's just assume they'll never ag..."** | `[671]` **Manus Sazon**: ""I've been thinking about the be..."<br>`[151]` **Manus Sazon**: ""That's a relief.""<br>*(oraz 24 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true) == false` | *Brak zmian stanu* | `[751]` **Manus Sazon**: ""Are you sure it's not worth try..."<br>`[752]` **Manus Sazon**: ""Yes, you're probably right."" |
| `[736]` | **""No need to discuss the houses. They'll fall in line if I tell them to.""** | `[671]` **Manus Sazon**: ""I've been thinking about the be..."<br>`[151]` **Manus Sazon**: ""That's a relief.""<br>*(oraz 24 innych węzłów)* | `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true) == false` | *Brak zmian stanu* | `[737]` **Manus Sazon**: ""But Your Majesty, there is stil..."<br>`[741]` **Manus Sazon**: ""I very much hope you're right a..." |
| `[764]` | **""If being diplomatic means making concessions to the nobility in our new constitut..."** | `[468]` **Manus Sazon**: ""What do you say, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[506]` **Manus Sazon**: ""Then what are you thinking?"" |
| `[774]` | **""That's fair enough.""** | `[770]` **Manus Sazon**: ""If and when the time comes to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[779]` **Manus Sazon**: ""I agree. On paper, at least, sh..." |
| `[775]` | **""I thought you'd be gunning for the position yourself.""** | `[770]` **Manus Sazon**: ""If and when the time comes to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[777]` **Narrator**: "He reddened." |
| `[776]` | **""What does it matter? She'd only lead the country for a few months, anyway.""** | `[770]` **Manus Sazon**: ""If and when the time comes to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[780]` **Manus Sazon**: ""Rizia naming its first prime mi..." |
| `[782]` | **""Why would I do that? You're the man the people want.""** | `[781]` **Manus Sazon**: ""If we want to acknowledge the o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[784]` **Manus Sazon**: ""You're too kind, Your Majesty."" |
| `[785]` | **""Why not? It might help smooth things over.""** | `[781]` **Manus Sazon**: ""If we want to acknowledge the o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[786]` **Manus Sazon**: ""And she's unlikely to make too ..." |
| `[787]` | **""I thought you'd be gunning for the position yourself.""** | `[781]` **Manus Sazon**: ""If we want to acknowledge the o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[783]` **Narrator**: "He reddened." |
| `[792]` | **""We're not going to make any drastic moves until after the royal wedding. I want i..."** | `[164]` **Manus Sazon**: ""Any more thoughts before we ful..." | `Variable["RiziaDLC.Vina_Engaged"] == true` | *Brak zmian stanu* | `[793]` **Narrator**: "Manus nodded."<br>`[798]` **Narrator**: "Manus nodded sadly." |
| `[803]` | **""Be careful, Manus. If this goes south, we could both lose our heads.""** | `[164]` **Manus Sazon**: ""Any more thoughts before we ful..." | `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false` | *Brak zmian stanu* | `[804]` **Narrator**: "He grimaced." |
| `[806]` | **""A communist prime minister... If that isn't the nail in the coffin for our relati..."** | `[164]` **Manus Sazon**: ""Any more thoughts before we ful..." | `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true` | *Brak zmian stanu* | `[810]` **Manus Sazon**: ""The West won't like it one bit."" |
| `[812]` | **""I wonder what our neighbors will think of all this.""** | `[164]` **Manus Sazon**: ""Any more thoughts before we ful..." | `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false` | *Brak zmian stanu* | `[813]` **Manus Sazon**: ""As long as we maintain the same..." |
| `[829]` | **""This highly concerns my daughter and her future. Of course she should be informed.""** | `[828]` **Manus Sazon**: ""For the Princess' own protectio..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_Involve_Vina"] = true; Variable...` | `[227]` **Manus Sazon**: ""If you think that's best, I und..." |
| `[834]` | **""Nonsense. You're her fiance. I don't want you keeping secrets from her.""** | `[828]` **Manus Sazon**: ""For the Princess' own protectio..." | `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true` | `Variable["RiziaDLC.Reform_Involve_Vina"] = true; Variable...` | `[835]` **Manus Sazon**: ""Yes, you're right. I'll tell he..." |
| `[837]` | **""Admit it. You're worried she's going to fall for Adarfo.""** | `[828]` **Manus Sazon**: ""For the Princess' own protectio..." | `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true` | *Brak zmian stanu* | `[841]` **Manus Sazon**: ""What? No!"" |
| `[843]` | **""You may be right. I don't want to put my daughter in danger.""** | `[828]` **Manus Sazon**: ""For the Princess' own protectio..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[844]` **Narrator**: "He nodded." |
| `[862]` | **""Of course, these nobles will serve in an advisory capacity only. It will be a kin..."** | `[655]` **Manus Sazon**: ""The rest of the RPP won't like ..."<br>`[656]` **Manus Sazon**: ""We'll have a hard time getting ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] = true;`<br>`--;` | `[67]` **Narrator**: "He took some notes in his notebook." |
| `[863]` | **""We'll give them the ability to provide some checks on the lower house, but their ..."** | `[655]` **Manus Sazon**: ""The rest of the RPP won't like ..."<br>`[656]` **Manus Sazon**: ""We'll have a hard time getting ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_UpperHouse_Limited"] = true;`<br>`--;` | `[67]` **Narrator**: "He took some notes in his notebook." |
| `[864]` | **""This upper house will have equal power to the lower house. I'd like to hear the n..."** | `[655]` **Manus Sazon**: ""The rest of the RPP won't like ..."<br>`[656]` **Manus Sazon**: ""We'll have a hard time getting ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Reform_UpperHouse_Equal"] = true;`<br>`--;` | `[67]` **Narrator**: "He took some notes in his notebook." |

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
  - -> `[868]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Conspiring to bring democracy to the Kin..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was late in the evening as I made my way downstairs to meet Manus Sazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "I knew the perfect place in the palace to have this conve..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true && RiziaDLC.Pol..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "He pulled a notepad out of his breast pocket."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Manus Sazon: ""As we briefly discussed, we will need to be very strateg..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Monarch_Approval = true;
RiziaDLC.Reform_Monarch_Veto = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Monarch_Approval"] = true;
Variable["RiziaDLC.Reform_Monarch_Veto"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Manus Sazon: ""Hm... We can propose that the monarch can exercise the a..."*)

### Węzeł `[7]`
Mówca: **Manus Sazon**
> ""I want to go over the RPP's main points to get a sense of your perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Manus Sazon: ""Our main objective is to ensure the political participat..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have no problem with that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. The monarch should act as the head of state, not the head of government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Manus Sazon: ""That's what we've been working on.""*)

### Węzeł `[10]`
Mówca: **Manus Sazon**
> ""Our country is still an absolute monarchy in all but name. Your father created the House of Delegates as a symbolic parliament, but the new constitution can give it the true authority it represents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Manus Sazon: ""This would mean the head of government will be an electe..."*)

### Węzeł `[11]`
Mówca: **Manus Sazon**
> ""After all, a constitutional monarch does not rule, Your Majesty -- they merely reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""I agree. The monarch should act as the head of state, no..."*)
  - -> `[12]` (*Player_Romus: ""I disagree. Even with an empowered parliament, the monar..."*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC...."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. Even with an empowered parliament, the monarch should retain substantial powers over the government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are not thinking radically enough, Mr. Sazon. I don't believe the monarch should reign at all.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Kontekst wejściowy (poprzednik):** `[11]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_OverthrowMonarchy == true"*)

### Węzeł `[14]`
Mówca: **Manus Sazon**
> ""I know we had this conversation. But I remain convinced that Rizian society will not accept such a drastic change. Maybe someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Manus Sazon: ""For now, here is what I have in mind.""*)

### Węzeł `[15]`
Mówca: **Manus Sazon**
> ""The constitution has to balance the power structure fairly so that no branch has complete authority over the other. That includes the Royal Family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""Firstly, the constitution will define the House of Deleg..."*)

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""That's what we've been working on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""Firstly, the constitution will define the House of Deleg..."*)

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""Firstly, the constitution will define the House of Delegates as the governing legislative body in Rizia, with clearly outlined procedures and jurisdiction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Manus Sazon: ""Instead of the monarch, they will be in charge of managi..."*)

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""Instead of the monarch, they will be in charge of managing the government budget and passing laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC...."*)
  - -> `[8]` (*Player_Romus: ""I have no problem with that.""*)
  - -> `[19]` (*Player_Romus: ""Only if their decisions are subject to the monarch's -- ..."*)
  - -> `[20]` (*Player_Romus: ""Only if the monarch holds the right to veto their decisi..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only if their decisions are subject to the monarch's -- to *my* -- approval.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Monarch_Approval = true..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only if the monarch holds the right to veto their decisions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Monarch_Veto = true; Ri..."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Monarch_Veto = true;
RiziaDLC.Reform_Monarch_Veto = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Monarch_Veto"] = true;
Variable["RiziaDLC.Reform_Monarch_Veto"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Manus Sazon: ""Hm... We can propose a veto process. But it must be defi..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Manus Sazon: ""We can discuss the exact details later.""*)

### Węzeł `[23]`
Mówca: **Manus Sazon**
> ""Hm... We can propose that the monarch can exercise the act of royal assent to approve of legislature. But a procedure must be defined so that the monarch cannot block every single piece of legislature at whim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Manus Sazon: ""We can discuss the exact details later.""*)

### Węzeł `[24]`
Mówca: **Manus Sazon**
> ""Hm... We can propose a veto process. But it must be defined in a way that doesn't allow the monarch to block every single piece of legislature at whim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Manus Sazon: ""We can discuss the exact details later.""*)

### Węzeł `[25]`
Mówca: **Manus Sazon**
> ""Our main objective is to ensure the political participation of our citizens. This is only possible if the monarch's power is limited, as enshrined in the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Manus Sazon: ""Our country is still an absolute monarchy in all but nam..."*)

### Węzeł `[26]`
Mówca: **Manus Sazon**
> ""We can discuss the exact details later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Manus Sazon: ""Secondly, we must decide whether to keep the old regiona..."*)

### Węzeł `[27]`
Mówca: **Manus Sazon**
> ""Secondly, we must decide whether to keep the old regional structure in Rizia or centralize the system in Porte Drazon completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Manus Sazon: ""Keeping the provinces semi-autonomous may embolden their..."*)

### Węzeł `[28]`
Mówca: **Manus Sazon**
> ""Keeping the provinces semi-autonomous may embolden their leadership to go against the new government's laws. But the nobles in those provinces have held power for centuries. They will not easily accept centralization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""I'd rather not disturb the regional system. We should re..."*)
  - -> `[30]` (*Player_Romus: ""Rizia still resembles a feudal state. We should find way..."*)
  - -> `[31]` (*Player_Romus: ""In a system that already has several branches of governm..."*)
  - -> `[645]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd rather not disturb the regional system. We should respect the autonomy of the provinces and make sure each is represented fairly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Manus Sazon), `[632]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia still resembles a feudal state. We should find ways to abolish that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Manus Sazon), `[632]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized = true"*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In a system that already has several branches of government and many actors, a decentralized structure will only bring instability. I support centralization.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Manus Sazon), `[632]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized = true"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Manus Sazon: ""I do have one concern there.""*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Manus Sazon: ""I do have one concern there.""*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Manus Sazon: ""Respecting regional traditions would be a clever choice.""*)

### Węzeł `[35]`
Mówca: **Manus Sazon**
> ""I do have one concern there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Manus Sazon: ""A centralized government might run more efficiently, but..."*)

### Węzeł `[36]`
Mówca: **Manus Sazon**
> ""A centralized government might run more efficiently, but citizens in those provinces may see it as a slight against ancient regional traditions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: ""The regions should have no autonomy or separate politica..."*)
  - -> `[39]` (*Player_Romus: ""While we should strive for each region to be represented..."*)
  - -> `[40]` (*Player_Romus: ""It might be unpopular, but this is my vision for the kin..."*)

### Węzeł `[37]`
Mówca: **Manus Sazon**
> ""However, it raises questions regarding how the provinces should be structured in such a system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""Each region should function as a state, and be allowed t..."*)
  - -> `[42]` (*Player_Romus: ""We should respect the historical, financial and demograp..."*)
  - -> `[43]` (*Player_Romus: ""I wouldn't change anything drastic. Keeping the current ..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The regions should have no autonomy or separate political structures. There must be equality among them, and laws must be implemented in a uniform way nationwide.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "He nodded."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While we should strive for each region to be represented in the House of Delegates, the nation of Rizia must be ruled by its parliament alone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "He nodded."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It might be unpopular, but this is my vision for the kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Manus Sazon: ""I understand that, Your Majesty.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Each region should function as a state, and be allowed to exercise autonomy within a constitutionally defined framework.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "He nodded."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should respect the historical, financial and demographical differences of the regions. Especially when it comes to each province's governing House. We need their collaboration if we want to change the system.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't change anything drastic. Keeping the current decentralized system will only increase public participation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Manus Sazon: ""I agree.""*)

### Węzeł `[44]`
Mówca: **Manus Sazon**
> ""We can offer the nobility something, I'm sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Manus Sazon: ""If the regions retain a degree of autonomy, their local ..."*)

### Węzeł `[45]`
Mówca: **Manus Sazon**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Manus Sazon: ""If the regions retain a degree of autonomy, their local ..."*)

### Węzeł `[46]`
Mówca: **Manus Sazon**
> ""I understand that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Manus Sazon: ""Abolishing the regional power structure would vest all p..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Manus Sazon: ""Abolishing the regional power structure would vest all p..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Manus Sazon: ""If the regions retain a degree of autonomy, their local ..."*)

### Węzeł `[49]`
Mówca: **Manus Sazon**
> ""If the regions retain a degree of autonomy, their local governments will share power and responsibility with the central one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[50]` (*Player_Romus: ""In a federal system such as this, having a second legisl..."*)
  - -> `[52]` (*Player_Romus: ""The legislative body should be unicameral. Complicating ..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In a federal system such as this, having a second legislative body representing the provinces might be ideal. We could form an upper House.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Legislative_Bicameral =..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to give something to the nobility for their support. We could have an upper House composed exclusively of nobles.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[49]` (Manus Sazon), `[53]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Manus Sazon: ""I see. A House of Lords, so to speak.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The legislative body should be unicameral. Complicating the system will only make it less efficient.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral ..."*)

### Węzeł `[53]`
Mówca: **Manus Sazon**
> ""Abolishing the regional power structure would vest all powers in the hands of the central government. In a system such as this, I believe having a unicameral legislative body would be the best option.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""I agree. Legislative responsibility must be left to one ..."*)
  - -> `[55]` (*Player_Romus: ""Yes, we already have a parliament. It'll only make the s..."*)
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. Legislative responsibility must be left to one single elected parliament.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Manus Sazon: ""That's settled, then.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, we already have a parliament. It'll only make the system less efficient if we create a second one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral ..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "He took some notes in his notebook."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Manus Sazon: ""Now that I have an idea of your opinions, Your Majesty, ..."*)

### Węzeł `[58]`
Mówca: **Narrator**
> "I flicked a switch hidden behind the shelf of bottles. It rotated to reveal an opening in the wall, which led to a series of wooden staircases."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "The stairs creaked under our feet as we descended. The fu..."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "I knew the perfect place in the palace to have this conversation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "I'd first learned about this place from my father as a kid. He'd told me it was the only place in the palace where he could feel truly alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "At the bottom of the stairs was a cold, gloomy room with ..."*)

### Węzeł `[61]`
Mówca: **Manus Sazon**
> ""Your Majesty, thank you once again for agreeing to this meeting. I cannot overemphasize how much I respect your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Manus Sazon: ""This will carve your name in the annals of history not a..."*)

### Węzeł `[62]`
Mówca: **Manus Sazon**
> ""This will carve your name in the annals of history not as a monarch who clung to power, but as a visionary who saw beyond the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player_Romus: ""We're here to make plans. You don't need to butter me up.""*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Foc..."*)
  - -> `[190]` (*Player_Romus: ""I'm not doing this for reputation or legacy. A monarch w..."*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC...."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Manus Sazon: ""I understand where you're coming from.""*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Legislative_Bicameral = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Bicameral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Manus Sazon: ""I see your point. A bicameral structure makes sense.""*)

### Węzeł `[65]`
Mówca: **Manus Sazon**
> ""I understand where you're coming from.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[66]`
Mówca: **Manus Sazon**
> ""I see your point. A bicameral structure makes sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[67]`
Mówca: **Narrator**
> "He took some notes in his notebook."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Manus Sazon: ""To ensure that the executive and legislative branches do..."*)

### Węzeł `[68]`
Mówca: **Manus Sazon**
> ""The judiciary interprets, defends, and applies the law in the name of the state -- and thus should be independent from other branches of government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""I agree. Judicial independence serves to safeguard the r..."*)
  - -> `[71]` (*Player_Romus: ""Fine by me. The amount of respect that people have for t..."*)
  - -> `[72]` (*Player_Romus: ""The judiciary can't be too independent. There must be me..."*)
  - -> `[73]` (*Player_Romus: ""It *should* be, yes. But it is impossible to design a sy..."*)

### Węzeł `[69]`
Mówca: **Manus Sazon**
> ""To ensure that the executive and legislative branches don't go beyond the powers enshrined to them, the judiciary must be given the right to put a stop to government actions that they deem unconstitutional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Manus Sazon: ""The judiciary interprets, defends, and applies the law i..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. Judicial independence serves to safeguard the rights and privileges provided by the constitution. It should prevent the executive and legislative branches from encroaching upon those rights.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Judiciary_Independent =..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine by me. The amount of respect that people have for the law is dependent upon the judiciary's status as a politically independent entity. Politicizing it will only hurt the rule of law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Judiciary_Independent =..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The judiciary can't be too independent. There must be mechanisms to prevent their abuse of power. Judges can't lack accountability.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Manus Sazon: ""I don't disagree. But the key is to achieve equilibrium ..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It *should* be, yes. But it is impossible to design a system without any flaws. The judiciary is doomed to be politicized, and it is in the best interests of the country to ensure that those politics align with those of the ruling government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Manus Sazon: ""I don't disagree. But the key is to achieve equilibrium ..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Judiciary_Independent = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Judiciary_Independent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Manus Sazon: ""Yes. The judiciary's role in deciding the validity of th..."*)

### Węzeł `[75]`
Mówca: **Manus Sazon**
> ""Yes. The judiciary's role in deciding the validity of the elections also necessitates their independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He stopped for a moment to think and went through his notes."*)

### Węzeł `[76]`
Mówca: **Manus Sazon**
> ""I don't disagree. But the key is to achieve equilibrium between accountability and independence to ensure that justice is upheld.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He stopped for a moment to think and went through his notes."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "He stopped for a moment to think and went through his notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[78]`
Mówca: **Manus Sazon**
> ""Now that I have an idea of your opinions, Your Majesty, the RPP can start drafting the new constitution in earnest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Manus Sazon: ""But I have to warn you, it will be an uphill battle from..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true)"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player_Romus: ""With Lucita in prison, their ability to organize is weak..."*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus == true)"*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Romus: ""I've already done a lot on that front. House Azaro no lo..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[85]`
Mówca: **Manus Sazon**
> ""I'll be honest with you. If any House has the power to stop us, it's Azaro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Manus Sazon: ""Many officers of the law, as well as military personnel,..."*)

### Węzeł `[86]`
Mówca: **Manus Sazon**
> ""But I have to warn you, it will be an uphill battle from here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Manus Sazon: ""With that said, General Taddeus, Duchess Lucita and most..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Manus Sazon: ""Tell me your honest opinion. Will they be a threat?""*)

### Węzeł `[90]`
Mówca: **Manus Sazon**
> ""Tell me your honest opinion. Will they be a threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""I don't think they pose a threat. They can't simply go a..."*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[355]` (*Player_Romus: ""Yes, definitely. They'll never agree to these reforms pe..."*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_Police_PulledBack == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)

### Węzeł `[91]`
Mówca: **Manus Sazon**
> ""Many officers of the law, as well as military personnel, are sympathetic -- if not outright loyal to -- the Azaro family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't know for sure. General Taddeus is in charge of the armed forces, and for all I know he's keeping Azaro troops in reserve for exactly this kind of scenario.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Control_Skipped"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[679]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Manus Sazon: ""That might become a problem.""*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == false"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Control_Skipped == false)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Control_Skipped == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Control_Skipped"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Dead > 0"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Control_Skipped == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Control_Skipped"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Romus: ""I can't know for sure. General Taddeus is in charge of t..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, the bulk of their forces have been destroyed in the war. I don't think they'll have the capacity to strike.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0` AND `Variable["RiziaDLC.War_Control_Skipped"] == false`
- **Kontekst wejściowy (poprzednik):** `[679]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Manus Sazon: ""Interesting news.""*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Dead > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Dead > 0"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Azaro_Dead > 0)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Dead > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""Actually, the bulk of their forces have been destroyed i..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Azaro_Dead > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Total > 0 && RiziaDLC.War_Pales_..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Total > 0 && RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Army_Unit_Azaro_Total > 0 && RiziaDLC.War_Pales_..."*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Army_Unit_Azaro_Total > 0 && RiziaDLC.War_Pale..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Army_Unit_Azaro_Total > 0 && RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Army_Unit_Azaro_Total"] > 0  and  Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player_Romus: ""Don't worry. I'm giving the orders in this war. I can ma..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Army_Unit_Azaro_Total > 0 && RiziaDLC.War_Pales_Operation1_Won == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Army_Unit_Azaro_Total"] > 0  and  Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. I'm giving the orders in this war. I can make sure the Azaro troops are indisposed by the time we're ready to act.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Army_Unit_Azaro_Total"] > 0  and  Variable["RiziaDLC.War_Pales_Operation1_Won"] == true` AND `(Variable["RiziaDLC.Army_Unit_Azaro_Dead"] > 0) == false` AND `Variable["RiziaDLC.War_Control_Skipped"] == false`
- **Kontekst wejściowy (poprzednik):** `[679]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Manus Sazon: ""An interesting plan...""*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.War_Pales_Operation1_Won == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.War_Pales_Operation1_Won == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player_Romus: ""We are winning the war, Manus. If Rizia emerges victorio..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.War_Pales_Operation1_Won == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Player_Romus: ""We don't need to worry about General Taddeus. The last t..."*)
  - -> `[107]` (*Player_Romus: ""The war is going terribly. The Azaros and their troops w..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The war is going terribly. The Azaros and their troops will have to keep their entire focus on the frontlines if they want a prayer of winning.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[679]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Manus Sazon: ""I understand...""*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are winning the war, Manus. If Rizia emerges victorious, House Azaro will have both the means and the heroic reputation to contest us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.War_Pales_Operation1_Won"] == true`
- **Kontekst wejściowy (poprzednik):** `[679]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Manus Sazon: ""That might become a problem.""*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We still have to be careful. Even with a war going on, the Azaros are more than capable of a coup.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[679]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Manus Sazon: ""I see.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't think they pose a threat. They can't simply go against both the will of the people and the monarch at the same time and expect to come out on top.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Manus Sazon), `[679]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Manus Sazon: ""I hope you are right.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With Lucita in prison, their ability to organize is weaker than before. But we have to be careful about her father.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Manus Sazon: ""I agree.""*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_Police_PulledBack == false"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_Police_PulledBack == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_Police_PulledBack == false"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Unrest_Police_PulledBack == false)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_Police_PulledBack == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Unrest_Police_PulledBack"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Manus Sazon: ""Rizia's police and intelligence services are watching ou..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Unrest_Police_PulledBack == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Unrest_Police_PulledBack"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Manus Sazon: ""We have hundreds of thousands of people rallying for cha..."*)

### Węzeł `[118]`
Mówca: **Manus Sazon**
> ""Rizia's police and intelligence services are watching our every move, looking for the slightest excuse to crush the democratic movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Manus Sazon: ""I've been thinking about the best way to deal with poten..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_Police_PulledBack == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Unrest_Police_PulledBack == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Unrest_Police_PulledBack == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Unrest_Police_PulledBack == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Unrest_Police_PulledBack"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player_Romus: ""We won't have to worry about the police. I gave the orde..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Unrest_Police_PulledBack == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Unrest_Police_PulledBack"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We won't have to worry about the police. I gave the order for our internal security forces to pull their focus away from your movement.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Unrest_Police_PulledBack"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Manus Sazon: ""Thank you, Your Majesty. Although this will not stop the..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've already done a lot on that front. House Azaro no longer controls Rizia's security forces.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Manus Sazon: ""Great thinking, Your Majesty. Although the family does s..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Romus: ""They won't be able to raise an army against us. I made s..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Order_RemoveProvincialLevies == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They won't be able to raise an army against us. I made sure of that when I removed provincial levies.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Order_RemoveProvincialLevies"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Manus Sazon: ""Great thinking, Your Majesty. Although the family does s..."*)

### Węzeł `[128]`
Mówca: **Manus Sazon**
> ""Great thinking, Your Majesty. Although the family does still hold sway across the Cardesse-Montaklar province.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[129]`
Mówca: **Manus Sazon**
> ""Thank you, Your Majesty. Although this will not stop their military faction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[130]`
Mówca: **Manus Sazon**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro = true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Romus: ""I can handle Lucita. She and I have an... understanding.""*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player_Romus: ""Without eyes or ears inside the house, I have no idea wh..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can handle Lucita. She and I have an... understanding.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[90]` (Manus Sazon), `[679]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Manus Sazon: ""If you're confident you can convince her of the necessit..."*)

### Węzeł `[135]`
Mówca: **Manus Sazon**
> ""That's a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro = true"*)

### Węzeł `[136]`
Mówca: **Manus Sazon**
> ""Interesting news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[137]`
Mówca: **Manus Sazon**
> ""An interesting plan...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[138]`
Mówca: **Manus Sazon**
> ""If you're confident you can convince her of the necessity of our reforms, that's great news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro_Talk = true"*)

### Węzeł `[139]`
Mówca: **Manus Sazon**
> ""I hope you are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[140]`
Mówca: **Manus Sazon**
> ""I understand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[141]`
Mówca: **Manus Sazon**
> ""That might become a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro = true"*)

### Węzeł `[142]`
Mówca: **Manus Sazon**
> ""They may not have as much firepower as the Azaros, but they have royal authority on their side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Manus Sazon: ""Your uncle holds incredible sway in Valenqiris. Is there..."*)

### Węzeł `[143]`
Mówca: **Manus Sazon**
> ""Your uncle holds incredible sway in Valenqiris. Is there a risk he will marshall your House against you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Extradit..."*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)
  - -> `[149]` (*Player_Romus: ""If there is anyone who can claim the throne during a cri..."*)
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true"*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My family and I are not on the best of terms as it is. They'll never accept a new constitution for Rizia.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Kontekst wejściowy (poprzednik):** `[143]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Toras = true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras < 0)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player_Romus: ""My family and I are not on the best of terms as it is. T..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All Hugo cares about is that the nobility of Rizia is respected. I'll find a way to work with House Toras on this.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false` AND `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Manus Sazon: ""That's a relief.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If there is anyone who can claim the throne during a crisis, that's my uncle. I don't think I trust him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Toras = true"*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry about the Toras family. They are not going to be a problem.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Manus Sazon: ""That's a relief.""*)

### Węzeł `[151]`
Mówca: **Manus Sazon**
> ""That's a relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[152]`
Mówca: **Manus Sazon**
> ""That complicates things. You can't have them go against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player_Romus: ""Let them try.""*)
  - -> `[154]` (*Player_Romus: ""We don't need their support. They cannot simply fight ag..."*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let them try.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Manus Sazon: ""I will not condone violence, Your Majesty.""*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need their support. They cannot simply fight against the democratic movement. Besides, I'm still the monarch.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Manus Sazon: ""I don't know about that... But I want to trust you, Your..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We have to be diplomatic. I cannot reform Rizia without involving my own family.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[152]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Toras_Talk = true"*)

### Węzeł `[156]`
Mówca: **Manus Sazon**
> ""I don't know about that... But I want to trust you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[157]`
Mówca: **Manus Sazon**
> ""I will not condone violence, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Manus Sazon: ""But I'm sure there is a way to neutralize House Toras th..."*)

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""But I'm sure there is a way to neutralize House Toras that does not involve bloodshed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[159]`
Mówca: **Manus Sazon**
> ""I'm afraid the Rizian National Coalition will present quite the obstacle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[160]`
Mówca: **Manus Sazon**
> ""Baroness de Rava has tolerated the growth of the reformist movement, but she will never condone it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Manus Sazon: ""I don't expect her or the RNC to budge an inch on our re..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Manus Sazon: ""Baroness de Rava has tolerated the growth of the reformi..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Manus Sazon: ""Baroness de Rava has tolerated the presence of the refor..."*)

### Węzeł `[164]`
Mówca: **Manus Sazon**
> ""Any more thoughts before we fully commit to this plan?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[789]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Aggressive == true"*)
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[170]` (*Player_Romus: ""No. We've covered everything.""*)

### Węzeł `[165]`
Mówca: **Narrator**
> "He shut his notebook and looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true && Rizi..."*)

### Węzeł `[166]`
Mówca: **Manus Sazon**
> ""I don't expect her or the RNC to budge an inch on our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus: ""And why do we care? We're already making enemies. The RN..."*)
  - -> `[177]` (*Player_Romus: ""She is there to represent and protect the rights of the ..."*)
  - -> `[400]` (*Player_Romus: ""If the very institution that you'll be empowering doesn'..."*)
  - -> `[402]` (*Player_Romus: ""What do you mean? They are loyal to the Crown.""*)

### Węzeł `[167]`
Mówca: **Manus Sazon**
> ""This would mean the head of government will be an elected official -- who can later be officially appointed by the head of state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Manus Sazon: ""They will lead a cabinet of ministers, sit as a member o..."*)

### Węzeł `[168]`
Mówca: **Manus Sazon**
> ""They will lead a cabinet of ministers, sit as a member of the House of Delegates, and determine the direction of the Rizian government on behalf of the monarch.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Manus Sazon: ""After all, a constitutional monarch does not rule, Your ..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think you're too worried about all this, Manus. You should relax. I'm willing to consider any means necessary for democracy, but you don't have to involve yourself.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Aggressive"] == true`
- **Kontekst wejściowy (poprzednik):** `[164]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Manus Sazon: ""Well... I have no power to stop you from doing that.""*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. We've covered everything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player_Romus: ""Be careful, Manus. My daughter's grown quite attached to..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Player_Romus: ""Be careful, Manus. If this goes south, we could both los..."*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be careful, Manus. My daughter's grown quite attached to you. For her sake, I don't want anything to happen.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[164]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Manus Sazon: ""Don't worry, Your Majesty. You can trust me.""*)

### Węzeł `[175]`
Mówca: **Manus Sazon**
> ""Don't worry, Your Majesty. You can trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Manus Sazon: ""Speaking of Her Highness...""*)

### Węzeł `[176]`
Mówca: **Manus Sazon**
> ""Well... I have no power to stop you from doing that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She is there to represent and protect the rights of the nobility. How do you plan to get her on our side?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Manus Sazon: ""Exactly. That's the problem.""*)

### Węzeł `[178]`
Mówca: **Manus Sazon**
> ""Exactly. That is the problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Manus Sazon: ""As the majority, the RNC has the power to obstruct us at..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "He shut his notebook and looked at me."*)

### Węzeł `[180]`
Mówca: **Manus Sazon**
> ""I will reach out to you when it's time to act. You should not rock the boat until everything is finished and organized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player_Romus: ""I don't know how long I can keep it a secret while your ..."*)
  - -> `[182]` (*Player_Romus: ""I greatly respect what you're doing, Manus. I hope this ..."*)
  - -> `[181]` (*Player_Romus: ""Thank you. We'll see each other again.""*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. We'll see each other again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Manus Sazon), `[222]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Manus Sazon: ""It won't be long now. I promise.""*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I greatly respect what you're doing, Manus. I hope this plan works out -- for both of our sakes as well as Rizia's future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Manus Sazon), `[222]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Manus Sazon: ""It won't be long now. I promise.""*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know how long I can keep it a secret while your movement is asking to change the system. Sooner or later, I have to make my stance known to the country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Manus Sazon: ""Of course. We just have to make sure the power players c..."*)

### Węzeł `[184]`
Mówca: **Manus Sazon**
> ""Of course. We just have to make sure the power players cannot make a move against you once that happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Manus Sazon: ""It won't be long now. I promise.""*)

### Węzeł `[185]`
Mówca: **Manus Sazon**
> ""It won't be long now. I promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "He smiled and we shook hands."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "He smiled and we shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "As we ascended back into the wine cellar, I thought about..."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "At the bottom of the stairs was a cold, gloomy room with stone walls, furnished with a single table and a couple of chairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "The only spot of color was a pale blue pocket square on t..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank *you* for your devotion to the reformist cause, Manus.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Kontekst wejściowy (poprzednik):** `[62]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Manus Sazon: ""It's the only way forward, as I see it.""*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're here to make plans. You don't need to butter me up.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Manus Sazon: ""I wasn't trying.""*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not doing this for reputation or legacy. A monarch who gives his power away will not be remembered at all. You, the reformer, will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Manus Sazon: ""If you say so, Your Majesty.""*)

### Węzeł `[191]`
Mówca: **Manus Sazon**
> ""If you say so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He pulled a notepad out of his breast pocket."*)

### Węzeł `[192]`
Mówca: **Manus Sazon**
> ""I wasn't trying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He pulled a notepad out of his breast pocket."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "As we ascended back into the wine cellar, I thought about what I had gotten myself into."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "I hoped I was doing the right thing for Rizia."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "I hoped I was doing the right thing for Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[196]`
Mówca: **Manus Sazon**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro = true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro_Talk = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Extradited == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Extradit..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Extrad..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Extradited == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Deposed == true"*)
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_PoliceChief_PorteDrazon == true"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Arrested == false && RiziaDLC.Rico_Extradited == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Player_Romus: ""I arrested Hugo's only son. I wouldn't be surprised if h..."*)
  - -> `[692]` (*Player_Romus: ""He did not dare to strike back at me even after I arrest..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not as worried about Hugo as I am about my cousin Ricardus.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rico_Deposed"] == true) == false` AND `Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Toras = true"*)

### Węzeł `[203]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I arrested Hugo's only son. I wouldn't be surprised if he was plotting revenge against me as we speak.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "Manus looked troubled."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "Manus looked troubled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Toras = true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Toras = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Toras"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Manus Sazon: ""That complicates things. You can't have them go against ..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Toras_Talk = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Manus Sazon: ""I understand.""*)

### Węzeł `[207]`
Mówca: **Manus Sazon**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[208]`
Mówca: **Narrator**
> "He tapped the cover of his notepad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Manus Sazon: ""Any more thoughts before we fully commit to this plan?""*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == false )"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Manus Sazon: ""There is one more point I wanted to bring up. About Her ..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "His eyes welled up slightly."*)

### Węzeł `[213]`
Mówca: **Manus Sazon**
> ""And as Lady Regent, she's very popular with some segments of the population.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: ""That's a good idea. She can be instrumental in controlli..."*)
  - -> `[225]` (*Player_Romus: ""Yes. She would be a great asset. I will involve her imme..."*)
  - -> `[226]` (*Player_Romus: ""Absolutely not. We're not going to involve her in this.""*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FullCouncilor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FullCouncilor == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_FullCouncilor == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_FullCouncilor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_FullCouncilor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Manus Sazon: ""And as Lady Regent, she's very popular with some segment..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_FullCouncilor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_FullCouncilor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_DuchessOfValenqiris == true"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_DuchessOfValenqiris == true)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_DuchessOfValenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Manus Sazon: ""And as Duchess of Valenqiris, she's very popular within ..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_DuchessOfValenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_DuchessOfValenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""And as Crown Princess, she's very popular with some segm..."*)

### Węzeł `[220]`
Mówca: **Manus Sazon**
> ""And as Duchess of Valenqiris, she's very popular within House Toras.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: ""That's a good idea. She can be instrumental in controlli..."*)
  - -> `[225]` (*Player_Romus: ""Yes. She would be a great asset. I will involve her imme..."*)
  - -> `[226]` (*Player_Romus: ""Absolutely not. We're not going to involve her in this.""*)

### Węzeł `[221]`
Mówca: **Manus Sazon**
> ""And as Crown Princess, she's very popular with some segments of the population.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player_Romus: ""That's a good idea. She can be instrumental in controlli..."*)
  - -> `[225]` (*Player_Romus: ""Yes. She would be a great asset. I will involve her imme..."*)
  - -> `[226]` (*Player_Romus: ""Absolutely not. We're not going to involve her in this.""*)

### Węzeł `[222]`
Mówca: **Manus Sazon**
> ""I will reach out to you when it's time to act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player_Romus: ""Good job. I hope everything works according to plan. We'..."*)
  - -> `[182]` (*Player_Romus: ""I greatly respect what you're doing, Manus. I hope this ..."*)
  - -> `[181]` (*Player_Romus: ""Thank you. We'll see each other again.""*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good job. I hope everything works according to plan. We'll see each other very soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Manus Sazon: ""It won't be long now. I promise.""*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's a good idea. She can be instrumental in controlling the narrative. I will ask her if she wants to be involved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Manus Sazon), `[220]` (Manus Sazon), `[221]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Involve_Vina = true; RiziaDLCSupport.Jour..."*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. She would be a great asset. I will involve her immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Manus Sazon), `[220]` (Manus Sazon), `[221]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Involve_Vina = true; RiziaDLCSupport.Jour..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. We're not going to involve her in this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Manus Sazon), `[220]` (Manus Sazon), `[221]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Manus Sazon: ""If you think that's best, I understand.""*)

### Węzeł `[227]`
Mówca: **Manus Sazon**
> ""If you think that's best, I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Manus Sazon: ""I will reach out to you when it's time to act.""*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Involve_Vina = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Involve_Vina"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Manus Sazon: ""Great.""*)

### Węzeł `[229]`
Mówca: **Manus Sazon**
> ""Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Manus Sazon: ""I will reach out to you when it's time to act.""*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ByThePeople","R_ByThePeople_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "It was late in the evening as I made my way downstairs to..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[232]`
Mówca: **Narrator**
> "The only spot of color was a pale blue pocket square on the floor. I picked it up and noticed it was embroidered with the initials M.M."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Manus Sazon: ""Does someone else know about this location, Your Majesty?""*)

### Węzeł `[233]`
Mówca: **Manus Sazon**
> ""Does someone else know about this location, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedToPlayer == true || RiziaDL..."*)
  - -> `[234]` (*Player_Romus: ""Nobody important.""*)
  - -> `[235]` (*Player_Romus: ""Trust me. We're secure.""*)
  - -> `[236]` (*Player_Romus: ""We could be compromised. Let's make this quick.""*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody important.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Manus Sazon: ""All right...""*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me. We're secure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Manus Sazon: ""All right...""*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We could be compromised. Let's make this quick.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Manus Sazon: ""All right...""*)

### Węzeł `[237]`
Mówca: **Manus Sazon**
> ""All right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "We sat down."*)

### Węzeł `[238]`
Mówca: **Narrator**
> "We sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Manus Sazon: ""Your Majesty, thank you once again for agreeing to this ..."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC...."*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDL..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Romus: ""You are not thinking radically enough, Mr. Sazon. I don'..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn02_Intention_NoMonarchy == true || RiziaDLC.Relations_Manus_OverthrowMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] == true  or  Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_OverthrowMonarchy == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Manus_OverthrowMonarchy == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_OverthrowMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Manus Sazon: ""I know we had this conversation. But I remain convinced ..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Manus_OverthrowMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Manus Sazon: ""This has to be a slow, gradual process, Your Majesty. Er..."*)

### Węzeł `[245]`
Mówca: **Manus Sazon**
> ""This has to be a slow, gradual process, Your Majesty. Erasing the importance of the entire Royal Family will lead to societal upheaval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Manus Sazon: ""For now, here is what I have in mind.""*)

### Węzeł `[246]`
Mówca: **Manus Sazon**
> ""For now, here is what I have in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""Firstly, the constitution will define the House of Deleg..."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "The stairs creaked under our feet as we descended. The further down we went into this eerie, abandoned space, the greater the sense of detachment from the palace's luxurious interior."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "I'd first learned about this place from my father as a ki..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedToPlayer == true || RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedToPlayer == true || RiziaDL..."*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_OutedToPlayer == true || Rizia..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedToPlayer == true || RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player_Romus: ""Certain household staff members. But they would never ra..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_OutedToPlayer == true || RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Certain household staff members. But they would never rat us out.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  or  Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[233]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Manus Sazon: ""All right...""*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC...."*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDL..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Romus: ""I wouldn't be doing this if it wasn't what Vina wanted.""*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true || RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't be doing this if it wasn't what Vina wanted.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true  or  Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[62]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[256]`
Mówca: **Manus Sazon**
> ""The Crown Princess has inspired us both, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He pulled a notepad out of his breast pocket."*)

### Węzeł `[257]`
Mówca: **Manus Sazon**
> ""It's the only way forward, as I see it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He pulled a notepad out of his breast pocket."*)

### Węzeł `[258]`
Mówca: **Narrator**
> "His eyes welled up slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Manus Sazon: ""I only wish Her Highness were here to help. Perhaps she ..."*)

### Węzeł `[259]`
Mówca: **Manus Sazon**
> ""I only wish Her Highness were here to help. Perhaps she can still be of assistance when she returns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Manus Sazon: ""In any case...""*)

### Węzeł `[260]`
Mówca: **Manus Sazon**
> ""In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == false"*)

### Węzeł `[261]`
Mówca: **Manus Sazon**
> ""The RPP is ready to begin drafting the new constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Manus Sazon: ""As majority speaker in the House of Delegates and the he..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Manus Sazon: ""Unfortunately, we're still the opposition party in the H..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Manus Sazon: ""I'm in touch with my RPP colleagues and the leaders of t..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Manus Sazon: ""The RPP is ready to begin drafting the new constitution.""*)

### Węzeł `[268]`
Mówca: **Manus Sazon**
> ""I have the greenlight from Mr. Sotelato and the RPP to begin drafting the new constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Manus Sazon: ""After a series of talks, they agreed to stop their calls..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Manus Sazon: ""I have the greenlight from Mr. Sotelato and the RPP to b..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[272]`
Mówca: **Manus Sazon**
> ""I'm in touch with my RPP colleagues and the leaders of the protest movements. We have the green light to begin drafting the new constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[273]`
Mówca: **Manus Sazon**
> ""Unfortunately, we're still the opposition party in the House of Delegates. Meaning that if the nobles find out what we're doing, they'll fight tooth and nail to stop it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[274]`
Mówca: **Manus Sazon**
> ""After a series of talks, they agreed to stop their calls for the abolishment of the monarchy if the constitution meets their demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[275]`
Mówca: **Manus Sazon**
> ""As Mr. Sotelato is now the majority speaker in the House of Delegates, he's in a very strong position to negotiate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Manus Sazon: ""On the other hand, I doubt the nobility will agree to pl..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Manus Sazon: ""As Mr. Sotelato is now the majority speaker in the House..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Manus Sazon: ""However, not only does the RPP still hold a House minori..."*)

### Węzeł `[279]`
Mówca: **Manus Sazon**
> ""As we briefly discussed, we will need to be very strategic about the publication and implementation of these reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Manus Sazon: ""Especially when it comes to getting them past the noble ..."*)

### Węzeł `[280]`
Mówca: **Manus Sazon**
> ""Especially when it comes to getting them past the noble houses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[281]`
Mówca: **Manus Sazon**
> ""However, not only does the RPP still hold a House minority, but Mr. Sotelato is now branded as a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Manus Sazon: ""The second the nobles find out we're working with him, t..."*)

### Węzeł `[282]`
Mówca: **Manus Sazon**
> ""As majority speaker in the House of Delegates and the heir to House Sazon, I believe I'm in a very strong position to ensure a peaceful and diplomatic resolution with the nobles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Manus Sazon: ""As majority speaker in the House of Delegates and the he..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[286]`
Mówca: **Manus Sazon**
> ""The problem is that not only is the RPP still the opposition, I've been branded a threat. Meaning that if the nobles find out what we're doing, they'll fight tooth and nail to stop it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to get at least two of the three royal Houses to approve. I don't see how we can accomplish this otherwise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Manus Sazon), `[286]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Manus Sazon: ""I'm telling you, Your Majesty. We won't even get the cha..."*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they do, we'll fight back. No one goes up against the King and lives.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Manus Sazon), `[286]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Manus Sazon: ""Please, Your Majesty. All our efforts will be for nothin..."*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm having second thoughts about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Manus Sazon), `[286]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Manus Sazon: ""Don't worry, Your Majesty.""*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that's why we're here alone in this dark damp room, aren't we?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Manus Sazon), `[286]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "He let out a short laugh."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player_Romus: ""We've got to get at least two of the three royal Houses ..."*)
  - -> `[288]` (*Player_Romus: ""If they do, we'll fight back. No one goes up against the..."*)
  - -> `[290]` (*Player_Romus: ""Well, that's why we're here alone in this dark damp room..."*)
  - -> `[289]` (*Player_Romus: ""I'm having second thoughts about this.""*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Player_Romus: ""This is our best chance, Manus. We have to seize it.""*)
  - -> `[293]` (*Player_Romus: ""We've got to get at least two of the three royal Houses ..."*)
  - -> `[294]` (*Player_Romus: ""I don't intend to include the nobles in the reform proce..."*)
  - -> `[296]` (*Player_Romus: ""Does that imply the existence of a *non-peaceful* resolu..."*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to get at least two of the three royal Houses on board. Otherwise, our reforms will be dead in the water.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Manus Sazon), `[336]` (Manus Sazon), `[548]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Manus Sazon: ""We can try.""*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't intend to include the nobles in the reform process. We already know they will never agree to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Manus Sazon), `[336]` (Manus Sazon), `[548]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Manus Sazon: ""We can add some concessions to the nobles in these refor..."*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is our best chance, Manus. We have to seize it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Manus Sazon), `[336]` (Manus Sazon), `[548]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Manus Sazon: ""We will, Your Majesty.""*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Does that imply the existence of a *non-peaceful* resolution?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[282]` (Manus Sazon), `[336]` (Manus Sazon), `[548]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Manus Sazon: ""If you're referring to the use of violence, I would neve..."*)

### Węzeł `[297]`
Mówca: **Manus Sazon**
> ""If you're referring to the use of violence, I would never agree to go that route. I refuse to follow in my father's footsteps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Manus Sazon: ""But that doesn't mean we have to be diplomatic with the ..."*)

### Węzeł `[298]`
Mówca: **Manus Sazon**
> ""But that doesn't mean we have to be diplomatic with the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Manus Sazon: ""We don't have to include the nobles in the drafting proc..."*)

### Węzeł `[299]`
Mówca: **Manus Sazon**
> ""We don't have to include the nobles in the drafting process. There are ways to ensure they won't get wind of the reforms until the ink on the constitution has dried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Manus Sazon: ""But before we start planning how to pass our new constit..."*)

### Węzeł `[300]`
Mówca: **Manus Sazon**
> ""We can try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Manus Sazon: ""If we include the nobility in the process, they'll certa..."*)

### Węzeł `[301]`
Mówca: **Manus Sazon**
> ""We will, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Manus Sazon: ""But before we start planning how to pass our new constit..."*)

### Węzeł `[302]`
Mówca: **Manus Sazon**
> ""I'm telling you, Your Majesty. We won't even get the chance to persuade them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Manus Sazon: ""Declaring our reform intentions to them would make us a ..."*)

### Węzeł `[303]`
Mówca: **Manus Sazon**
> ""Declaring our reform intentions to them would make us a target. The Crown itself would be in peril.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Player_Romus: ""And how do we do it without them? After all, it's not po..."*)
  - -> `[308]` (*Player_Romus: ""Then I will make sure they won't have the capacity to pu..."*)
  - -> `[309]` (*Player_Romus: ""What do you suggest, then?""*)

### Węzeł `[304]`
Mówca: **Narrator**
> "He let out a short laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Manus Sazon: ""Well said, Your Majesty.""*)

### Węzeł `[305]`
Mówca: **Manus Sazon**
> ""Well said, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Manus Sazon: ""But before we start planning how to pass our new constit..."*)

### Węzeł `[306]`
Mówca: **Manus Sazon**
> ""Please, Your Majesty. All our efforts will be for nothing if they result in violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Romus: ""What do you suggest, then?""*)
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk == true..."*)
  - -> `[554]` (*Player_Romus: ""I was speaking metaphorically. We'll fight them with our..."*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how do we do it without them? After all, it's not possible to hide the fact that we're changing the political system from anybody.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Manus Sazon: ""Of course not, Your Majesty.""*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I will make sure they won't have the capacity to put their focus against us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Manus Sazon: ""I understand what you're saying, Your Majesty.""*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you suggest, then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Manus Sazon), `[306]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Manus Sazon: ""There is a reason why we're meeting here in secret.""*)

### Węzeł `[310]`
Mówca: **Manus Sazon**
> ""Of course not, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Manus Sazon: ""There is a reason why we're meeting here in secret.""*)

### Węzeł `[311]`
Mówca: **Manus Sazon**
> ""There is a reason why we're meeting here in secret.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Manus Sazon: ""If we can keep the process completely under wraps until ..."*)

### Węzeł `[312]`
Mówca: **Manus Sazon**
> ""If we can keep the process completely under wraps until the constitution's been signed, the Houses will have no choice but to accept it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Manus Sazon: ""The RPP will organize the reform movement while you make..."*)

### Węzeł `[313]`
Mówca: **Manus Sazon**
> ""With millions of people on the streets on our side, it would be too late for any force to intervene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Manus Sazon: ""With millions of people on the streets on our side, it w..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Manus Sazon: ""It would be too late for any force to intervene.""*)

### Węzeł `[317]`
Mówca: **Manus Sazon**
> ""By the time the House of Delegates proposes the constitution, everything will already be in place. You arrive at the House with the protection of the Golden Guard and sign it with the delegates, declaring it on live broadcast nationally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Player_Romus: ""You're suggesting we attempt a coup.""*)
  - -> `[327]` (*Player_Romus: ""I like the sound of it.""*)
  - -> `[328]` (*Player_Romus: ""With House Azaro's intelligence capabilities and House T..."*)
  - -> `[329]` (*Player_Romus: ""I disagree. Even if we do this exactly the way you descr..."*)

### Węzeł `[319]`
Mówca: **Manus Sazon**
> ""I understand what you're saying, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Manus Sazon: ""But before we start planning how to pass our new constit..."*)

### Węzeł `[320]`
Mówca: **Manus Sazon**
> ""We can add some concessions to the nobles in these reforms. If they're allowed to keep their titles and estates, they might be persuaded to approve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[321]`
Mówca: **Manus Sazon**
> ""If we include the nobility in the process, they'll certainly demand to keep their estates and at least some of their power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[322]`
Mówca: **Manus Sazon**
> ""But before we start planning how to pass our new constitution, I suggest we first discuss its contents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[323]`
Mówca: **Manus Sazon**
> ""Therefore, before we discuss how to pass our new constitution, we must first discuss its contents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[324]`
Mówca: **Manus Sazon**
> ""Don't worry, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Manus Sazon: ""There is a reason why we're meeting here in secret.""*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[326]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're suggesting we attempt a coup.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Manus Sazon), `[330]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Manus Sazon: ""Well, I wouldn't phrase it that way.""*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I like the sound of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Manus Sazon), `[330]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Manus Sazon: ""But before we start planning how to unveil the new const..."*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With House Azaro's intelligence capabilities and House Toras' eyes and ears within the palace, maintaining total secrecy will be impossible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Manus Sazon), `[330]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Manus Sazon: ""It won't be easy.""*)

### Węzeł `[329]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. Even if we do this exactly the way you describe, the nobility can still deem the new constitution illegitimate and oust me from power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[313]` (Manus Sazon), `[330]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Manus Sazon: ""Only if they themselves have enough power and support to..."*)

### Węzeł `[330]`
Mówca: **Manus Sazon**
> ""It would be too late for any force to intervene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[331]`
Mówca: **Manus Sazon**
> ""Only if they themselves have enough power and support to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Manus Sazon: ""But before we start planning how to unveil the new const..."*)

### Węzeł `[332]`
Mówca: **Manus Sazon**
> ""But before we start planning how to unveil the new constitution, I suggest we first discuss its contents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[333]`
Mówca: **Manus Sazon**
> ""Well, I wouldn't phrase it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Manus Sazon: ""But before we start planning how to unveil the new const..."*)

### Węzeł `[334]`
Mówca: **Manus Sazon**
> ""It won't be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Manus Sazon: ""But before we start planning how to unveil the new const..."*)

### Węzeł `[335]`
Mówca: **Manus Sazon**
> ""The RPP will organize the reform movement while you make sure the security of Porte Drazon is not compromised.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Manus Sazon: ""By the time the House of Delegates proposes the constitu..."*)

### Węzeł `[336]`
Mówca: **Manus Sazon**
> ""If we want a peaceful resolution to all this, we need to play it smart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Manus Sazon: ""However, Mr. Sotelato is not open to the idea of the nob..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Manus Sazon: ""Therefore, before we discuss how to pass our new constit..."*)

### Węzeł `[340]`
Mówca: **Manus Sazon**
> ""However, Mr. Sotelato is not open to the idea of the nobles retaining any privilege other than the royal family of the monarch, which he agreed to respect as long as they act purely as a symbolic head of state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Manus Sazon: ""Therefore, before we discuss how to pass our new constit..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Manus Sazon: ""Mr. Sotelato will never budge on this point, Your Majest..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Manus Sazon: ""The constitution has to balance the power structure fair..."*)

### Węzeł `[344]`
Mówca: **Manus Sazon**
> ""Mr. Sotelato will never budge on this point, Your Majesty. The monarch must reign in name only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""Firstly, the constitution will define the House of Deleg..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == false)"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Manus Sazon: ""I'm not sure about that, Your Majesty. I doubt the noble..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Manus Sazon: ""We can offer the nobility something, I'm sure.""*)

### Węzeł `[348]`
Mówca: **Manus Sazon**
> ""I'm not sure about that, Your Majesty. I doubt the nobles can be convinced. Nonetheless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Manus Sazon: ""If the regions retain a degree of autonomy, their local ..."*)

### Węzeł `[349]`
Mówca: **Manus Sazon**
> ""We have hundreds of thousands of people rallying for change. Although we have momentum on our side, we're still in a precarious situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Manus Sazon: ""I've been thinking about the best way to deal with poten..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Manus Sazon: ""We might have the people's support and hold a legitimate..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Manus Sazon: ""We would not only be going against the will of the noble..."*)

### Węzeł `[353]`
Mówca: **Manus Sazon**
> ""We might have the people's support and hold a legitimate majority in the House of Delegates, but given the opportunity, I do not doubt the nobles will show their true colors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Manus Sazon: ""I've been thinking about the best way to deal with poten..."*)

### Węzeł `[354]`
Mówca: **Manus Sazon**
> ""We would not only be going against the will of the nobles, but also that of Baroness de Rava and the House of Delegates. We have to be extremely careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Manus Sazon: ""I've been thinking about the best way to deal with poten..."*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, definitely. They'll never agree to these reforms peacefully.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Manus Sazon: ""That's a problem.""*)

### Węzeł `[356]`
Mówca: **Manus Sazon**
> ""That's a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro = true"*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Without eyes or ears inside the house, I have no idea whether they're a threat or not.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[90]` (Manus Sazon), `[679]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Manus Sazon: ""That's a problem.""*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Deposed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Deposed == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Deposed == true)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Deposed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Deposed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Player_Romus: ""I don't know about Hugo. But I do know that my cousin Ri..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Deposed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Deposed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Romus: ""I'm not as worried about Hugo as I am about my cousin Ri..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know about Hugo. But I do know that my cousin Ricardus would love nothing more than to see me humiliated.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rico_Deposed"] == true` AND `Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Toras = true"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == false)"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Player_Romus: ""There is still time for me to get on their good side. Bu..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Player_Romus: ""We have to be diplomatic. I cannot reform Rizia without ..."*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is still time for me to get on their good side. But we have to make a plan for the worst case scenario.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Kontekst wejściowy (poprzednik):** `[152]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Manus Sazon: ""Yes. I understand.""*)

### Węzeł `[366]`
Mówca: **Manus Sazon**
> ""Yes. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Manus Sazon: ""Unfortunately, my mother may be a problem.""*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Narrator: "He smiled."*)

### Węzeł `[370]`
Mówca: **Manus Sazon**
> ""Unfortunately, my mother may be a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Iza_PowerTransfer_Angelica == true"*)

### Węzeł `[371]`
Mówca: **Manus Sazon**
> ""As the reinstated matriarch of House Sazon, she commands more respect from our family than I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Manus Sazon: ""And frankly, she and I are of different minds.""*)

### Węzeł `[372]`
Mówca: **Manus Sazon**
> ""And frankly, she and I are of different minds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "He sighed."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords == true"*)
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Legislative_HouseOfLords == true)"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Player_Romus: ""All Hugo cares about is that the nobility of Rizia is re..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Legislative_HouseOfLords == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""All Hugo cares about is that the nobility of Rizia is re..."*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All Hugo cares about is that the nobility of Rizia is respected. If we keep Valenqiris semi-autonomous and introduce a House of Lords in parliament, he'll have nothing to complain about.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] == true` AND `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Manus Sazon: ""That's a relief.""*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true || RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true || RiziaDL..."*)
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true || Rizia..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true || RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  or  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true || RiziaDLC.HouseElections_RPPWinsSeats == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true  or  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Manus Sazon: ""She would likely not support any constitution that doesn..."*)

### Węzeł `[380]`
Mówca: **Manus Sazon**
> ""She doesn't support my movement or our demands for reform. And she'll never agree with Sotelato's proposed terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Manus Sazon: ""I will be honest. This is a setback I wasn't prepared fo..."*)

### Węzeł `[381]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Manus Sazon: ""She has taken a staunchly monarchist stance since her ar..."*)

### Węzeł `[382]`
Mówca: **Manus Sazon**
> ""She would likely not support any constitution that doesn't respect our family as a royal house.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Manus Sazon: ""So that has to be taken into account as well.""*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Manus Sazon: ""She doesn't support my movement or our demands for refor..."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Manus Sazon: ""She doesn't support my movement or our demands for refor..."*)

### Węzeł `[386]`
Mówca: **Manus Sazon**
> ""She doesn't support my movement or our demands for reform. And she won't so much as glance at the new constitution as long as Daria and the RNC are in charge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Manus Sazon: ""I will be honest. This is a setback I wasn't prepared fo..."*)

### Węzeł `[387]`
Mówca: **Manus Sazon**
> ""I will be honest. This is a setback I wasn't prepared for, and it will make my job difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Player_Romus: ""If she and your kin don't fall in line, I will make them.""*)
  - -> `[391]` (*Player_Romus: ""Give it to me straight. Can you handle this yourself?""*)
  - -> `[390]` (*Player_Romus: ""I am the one who pardoned her. If she's truly loyal, she..."*)
  - -> `[389]` (*Player_Romus: ""Are you sure that's where her loyalties truly lie? What ..."*)

### Węzeł `[388]`
Mówca: **Manus Sazon**
> ""She has taken a staunchly monarchist stance since her arrival. I fear all those years of being punished for her husband's betrayal have gotten to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true || RiziaDL..."*)

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure that's where her loyalties truly lie? What if she's been a secret reformist all this time?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[387]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Manus Sazon: ""If she were, I would know.""*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am the one who pardoned her. If she's truly loyal, she will support me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[387]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Manus Sazon: ""She is loyal to the Crown. Not to the man wearing it.""*)

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give it to me straight. Can you handle this yourself?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[387]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Manus Sazon: ""I can't guarantee it. All I can tell you is that if Hous..."*)

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If she and your kin don't fall in line, I will make them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[387]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "A look of fear flashed on his face."*)

### Węzeł `[393]`
Mówca: **Manus Sazon**
> ""So that has to be taken into account as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[394]`
Mówca: **Narrator**
> "A look of fear flashed on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Manus Sazon: ""I understand, Your Majesty.""*)

### Węzeł `[395]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[396]`
Mówca: **Manus Sazon**
> ""I can't guarantee it. All I can tell you is that if House Toras and Azaro agree to the reforms, my mother's objections will count for nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[397]`
Mówca: **Manus Sazon**
> ""She is loyal to the Crown. Not to the man wearing it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Manus Sazon: ""All I can tell you is that if House Toras or Azaro oppos..."*)

### Węzeł `[398]`
Mówca: **Manus Sazon**
> ""If she were, I would know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Manus Sazon: ""All I can tell you is that if House Toras or Azaro oppos..."*)

### Węzeł `[399]`
Mówca: **Manus Sazon**
> ""All I can tell you is that if House Toras or Azaro opposes the reforms, my mother will join forces with them to stop us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the very institution that you'll be empowering doesn't recognize or accept the transition, how will the constitution be put in place?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Manus Sazon: ""Exactly. That is the problem.""*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why do we care? We're already making enemies. The RNC is the least of our worries.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Manus Sazon: ""They are a worry, Your Majesty. As the majority, they ha..."*)

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean? They are loyal to the Crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Manus Sazon: ""Exactly. That's the problem.""*)

### Węzeł `[403]`
Mówca: **Manus Sazon**
> ""They are a worry, Your Majesty. As the majority, they have the power to obstruct us at every turn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Manus Sazon: ""If de Rava finds out about our plans while they're still..."*)

### Węzeł `[404]`
Mówca: **Manus Sazon**
> ""As the majority, the RNC has the power to obstruct us at every turn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Manus Sazon: ""If de Rava finds out about our plans while they're still..."*)

### Węzeł `[405]`
Mówca: **Manus Sazon**
> ""If de Rava finds out about our plans while they're still at this early stage, she'll crush them in their tracks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == false"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCI..."*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDL..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true  and  Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Manus Sazon: ""We've established that all three royal houses will be a ..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true && RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true  and  Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCI..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true && RiziaDLCIsolated.Reform_Threat_Toras_Talk == true && RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true && Rizi..."*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true && Ri..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true && RiziaDLCIsolated.Reform_Threat_Toras_Talk == true && RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] == true  and  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Manus Sazon: ""You said you think you can convince House Toras and Hous..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true && RiziaDLCIsolated.Reform_Threat_Toras_Talk == true && RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] == true  and  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "(RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true || Riz..."*)

### Węzeł `[412]`
Mówca: **Manus Sazon**
> ""If we assume that both House Toras and House Azaro will stop at nothing to oppose our reforms...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[413]`
Mówca: **Manus Sazon**
> ""You said you think you can convince House Toras and House Azaro to agree to the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[414]`
Mówca: **Manus Sazon**
> ""You don't believe that either House Azaro or House Toras will challenge our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC...."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCI..."*)
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDL..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Manus Sazon: ""If we assume that both House Toras and House Azaro will ..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCIsolated.Reform_Threat_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  and  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro == true || RiziaDLCI..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro == true || RiziaDLCIsolated.Reform_Threat_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro == true || RiziaDLCI..."*)
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Reform_Threat_Azaro == true || RiziaDL..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro == true || RiziaDLCIsolated.Reform_Threat_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  or  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro == true"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Reform_Threat_Azaro == true || RiziaDLCIsolated.Reform_Threat_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true  or  Variable["RiziaDLCIsolated.Reform_Threat_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Manus Sazon: ""You don't believe that either House Azaro or House Toras..."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true || RiziaDLCIsolated.Reform_Threat_Toras_Talk == true) && RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "(RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true || Riz..."*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "!((RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true || R..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true || RiziaDLCIsolated.Reform_Threat_Toras_Talk == true) && RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true  or  Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] == true)  and  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true"*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true || RiziaDLCIsolated.Reform_Threat_Toras_Talk == true) && RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true  or  Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] == true)  and  Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro == true && RiziaDLCI..."*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true"*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true)"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Manus Sazon: ""You said you thought you could convince House Azaro to a..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Reform_Threat_Azaro_Talk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro_Talk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Manus Sazon: ""You said you thought you could convince House Toras to a..."*)

### Węzeł `[427]`
Mówca: **Manus Sazon**
> ""You said you thought you could convince House Azaro to agree to the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[428]`
Mówca: **Manus Sazon**
> ""You said you thought you could convince House Toras to agree to the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Manus Sazon: ""But even in that case, you would need to get at least on..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Manus Sazon: ""If you succeed, and if House Sazon rallies behind me as ..."*)

### Węzeł `[432]`
Mówca: **Manus Sazon**
> ""With that in mind, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Manus Sazon: ""I believe taking this reform through public channels and..."*)

### Węzeł `[433]`
Mówca: **Manus Sazon**
> ""If you succeed, we'll have the two most powerful royal houses on our side. Even if my mother disagrees, there's nothing she could do about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Manus Sazon: ""With that in mind, Your Majesty...""*)

### Węzeł `[434]`
Mówca: **Manus Sazon**
> ""But even in that case, you would need to get at least one of the other royal houses on your side. And as I mentioned, my mother won't be easy to deal with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[435]`
Mówca: **Manus Sazon**
> ""If you succeed, and if House Sazon rallies behind me as I expect they will, we'd have two of the three royal houses on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Manus Sazon: ""With that in mind, Your Majesty...""*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Manus Sazon: ""If you succeed, we'll have the two most powerful royal h..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Manus Sazon: ""If you succeed, and if House Sazon rallies behind me as ..."*)

### Węzeł `[439]`
Mówca: **Manus Sazon**
> ""If you succeed, and if House Sazon rallies behind me as I expect they will, we'll have all three royal houses on our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Manus Sazon: ""With that in mind, Your Majesty...""*)

### Węzeł `[440]`
Mówca: **Manus Sazon**
> ""That being said, we still have room to bargain. If the new constitution grants concessions to the nobles, I believe we will still be able to convince them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Manus Sazon: ""I believe taking this reform through public channels and..."*)

### Węzeł `[441]`
Mówca: **Manus Sazon**
> ""We've established that all three royal houses will be a threat to our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Manus Sazon: ""That leaves us in a very dangerous position.""*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro == true"*)
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Reform_Threat_Azaro == true)"*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Azaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Manus Sazon: ""If we assume House Azaro will stop at nothing to oppose ..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Reform_Threat_Azaro == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Reform_Threat_Azaro"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Manus Sazon: ""If we assume House Toras will stop at nothing to oppose ..."*)

### Węzeł `[445]`
Mówca: **Manus Sazon**
> ""If we assume House Azaro will stop at nothing to oppose our reforms...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[446]`
Mówca: **Manus Sazon**
> ""If we assume House Toras will stop at nothing to oppose our reforms...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Manus Sazon: ""...and my mother Angelica will most certainly unite Hous..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_HouseSazon_AngelicaPardoned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Manus Sazon: ""That leaves us in a very dangerous position.""*)

### Węzeł `[450]`
Mówca: **Manus Sazon**
> ""...and my mother Angelica will most certainly unite House Sazon against us as well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Manus Sazon: ""That leaves us in a very dangerous position.""*)

### Węzeł `[451]`
Mówca: **Manus Sazon**
> ""That leaves us in a very dangerous position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC...."*)

### Węzeł `[452]`
Mówca: **Manus Sazon**
> ""I believe taking this reform through public channels and negotiating with the royal houses is the best course of action.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[453]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority and I have legitimacy as House Speaker. If you command the respect of the nobility as you say, this should be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Manus Sazon: ""What do you say, Your Majesty?""*)

### Węzeł `[454]`
Mówca: **Manus Sazon**
> ""What do you say, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Player_Romus: ""I agree with you, Manus. The sooner we publicize our ref..."*)
  - -> `[491]` (*Player_Romus: ""While I'm skeptical about declaring our reform intention..."*)
  - -> `[490]` (*Player_Romus: ""I know I said I could convince the nobility. But upon fu..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[458]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority, I have legitimacy as House Speaker and a growing movement is uniting behind us. If you command the respect of the nobility as you say, this should be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Manus Sazon: ""What do you say, Your Majesty?""*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC...."*)
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDL..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Manus Sazon: ""Despite this fact, I believe there's still a chance we c..."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[462]`
Mówca: **Manus Sazon**
> ""But with the RNC holding a majority in the House of Delegates, that doesn't matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[463]`
Mówca: **Manus Sazon**
> ""Despite this fact, I believe there's still a chance we can publicize our intention to reform and negotiate a compromise that satisfies everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC...."*)
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDL..."*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Manus Sazon: ""With that in mind, Your Majesty...""*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true && RiziaDLC.Reform_Movement_Leader_Adarfo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)

### Węzeł `[467]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority and I have legitimacy as House Speaker. Under those circumstances, bargaining with the royal houses is a definite possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Manus Sazon: ""What do you say, Your Majesty?""*)

### Węzeł `[468]`
Mówca: **Manus Sazon**
> ""What do you say, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Player_Romus: ""I agree with you, Manus. The sooner we publicize our ref..."*)
  - -> `[491]` (*Player_Romus: ""While I'm skeptical about declaring our reform intention..."*)
  - -> `[488]` (*Player_Romus: ""I honestly don't know if I have enough sway with the Roy..."*)
  - -> `[764]` (*Player_Romus: ""If being diplomatic means making concessions to the nobi..."*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Manus Sazon: ""After all, we have a parliament majority, I have legitim..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Manus Sazon: ""After all, we have a parliament majority and I have legi..."*)

### Węzeł `[472]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority, I have legitimacy as House Speaker and a growing movement is uniting behind us. Under those circumstances, swaying the royal houses won't be difficult.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Manus Sazon: ""What do you say, Your Majesty?""*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Manus Sazon: ""Much as I wish we could sit down with all parties and ha..."*)

### Węzeł `[474]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The nobility will strike as soon as they learn we're cooperating with the revolutionaries. I will not declare my intentions to the public. We must keep a low profile until the reforms are declared.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[483]` (Manus Sazon), `[506]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent = true"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Manus Sazon: ""With our current circumstances, it would be unwise to de..."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Manus Sazon: ""Mr. Sotelato's movement is approaching critical mass, Yo..."*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Manus Sazon: ""The Rizian people are openly demanding reform, Your Maje..."*)

### Węzeł `[481]`
Mówca: **Manus Sazon**
> ""Mr. Sotelato's movement is approaching critical mass, Your Majesty. If you publicly support it as well, the pressure on the nobility would be enormous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Manus Sazon: ""But it might not be enough to stop them from organizing ..."*)

### Węzeł `[482]`
Mówca: **Manus Sazon**
> ""Much as I wish we could sit down with all parties and hammer out a peaceful compromise, I fear it's just not going to happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[483]`
Mówca: **Manus Sazon**
> ""But it might not be enough to stop them from organizing against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[474]` (*Player_Romus: ""The nobility will strike as soon as they learn we're coo..."*)
  - -> `[494]` (*Player_Romus: ""The stakes are too high to take half measures. We must s..."*)
  - -> `[497]` (*Player_Romus: ""I still think we should be open and diplomatic with the ..."*)

### Węzeł `[484]`
Mówca: **Manus Sazon**
> ""The Rizian people are openly demanding reform, Your Majesty. If you publicly support it as well, the pressure on the nobility would be enormous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Manus Sazon: ""But it might not be enough to stop them from organizing ..."*)

### Węzeł `[485]`
Mówca: **Manus Sazon**
> ""But it might not be enough to stop them from organizing against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[494]` (*Player_Romus: ""The stakes are too high to take half measures. We must s..."*)
  - -> `[492]` (*Player_Romus: ""The nobility will strike as soon as they learn what we'r..."*)
  - -> `[497]` (*Player_Romus: ""I still think we should be open and diplomatic with the ..."*)

### Węzeł `[486]`
Mówca: **Manus Sazon**
> ""With our current circumstances, it would be unwise to declare your intentions to reform Rizia before the new constitution is ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Manus Sazon: ""My advice would be to lay low until the time is right.""*)

### Węzeł `[487]`
Mówca: **Manus Sazon**
> ""My advice would be to lay low until the time is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Player_Romus: ""The stakes are too high to take half measures. We must o..."*)
  - -> `[495]` (*Player_Romus: ""I agree that the nobility will strike as soon as they le..."*)
  - -> `[497]` (*Player_Romus: ""I still think we should be open and diplomatic with the ..."*)

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I honestly don't know if I have enough sway with the Royal Houses to convince them to give away their power peacefully.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[468]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Manus Sazon: ""Then what are you thinking?""*)

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree with you, Manus. The sooner we publicize our reform intentions, the sooner the transformation of Rizia can begin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[454]` (Manus Sazon), `[468]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Manus Sazon: ""Then it is settled, Your Majesty. We will seek the royal..."*)

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know I said I could convince the nobility. But upon further reflection, I'm not so confident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[454]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Manus Sazon: ""Then what are you thinking?""*)

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""While I'm skeptical about declaring our reform intentions immediately, I do agree that the nobles should have a say in the new constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[454]` (Manus Sazon), `[468]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Manus Sazon: ""I understand.""*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The nobility will strike as soon as they learn what we're trying to do. I will not declare my intentions to the public. We must keep a low profile until the reforms are ready.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[485]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent = true"*)

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Once we declare our intentions, the power of the reform movement will be undeniable. There's no chance the nobles will move against us.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Kontekst wejściowy (poprzednik):** `[483]` (Manus Sazon), `[485]` (Manus Sazon), `[506]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Manus Sazon: ""No chance at all?""*)

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The stakes are too high to take half measures. We must strike the houses before they are ready and force our relatives to comply.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[483]` (Manus Sazon), `[485]` (Manus Sazon), `[506]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Aggressive = true"*)

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree that the nobility will strike as soon as they learn what we're trying to do. We must keep a low profile.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent = true"*)

### Węzeł `[496]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The stakes are too high to take half measures. We must organize a preemptive strike against the nobility and force them to comply.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[487]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Aggressive = true"*)

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still think we should be open and diplomatic with the royal houses. As Rizia's most noble of families, they deserve a seat at the table.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[483]` (Manus Sazon), `[485]` (Manus Sazon), `[487]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic = true"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Aggressive = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Aggressive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Manus Sazon: ""I see...""*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Silent = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Silent"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Manus Sazon: ""I understand.""*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Manus Sazon: ""So be it, Your Majesty. Perhaps my fears are overblown.""*)

### Węzeł `[501]`
Mówca: **Manus Sazon**
> ""No chance at all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Manus Sazon: ""Even with the populace against them, there's still a cha..."*)

### Węzeł `[502]`
Mówca: **Manus Sazon**
> ""Even with the populace against them, there's still a chance one or more of the houses will try to strike before the constitution is signed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Player_Romus: ""If we have to, we will strike first.""*)
  - -> `[503]` (*Player_Romus: ""Once the pressure has built to a significant degree, we'..."*)
  - -> `[505]` (*Player_Romus: ""You're right. It's too risky. We should be stealthy and ..."*)

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Once the pressure has built to a significant degree, we'll invite them for negotiations. They'll fold like a second-rate poker player.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[502]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic = true"*)

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If we have to, we will strike first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[502]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Aggressive = true"*)

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. It's too risky. We should be stealthy and prepare the new constitution without raising any suspicions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[502]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent = true"*)

### Węzeł `[506]`
Mówca: **Manus Sazon**
> ""Then what are you thinking?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[474]` (*Player_Romus: ""The nobility will strike as soon as they learn we're coo..."*)
  - -> `[494]` (*Player_Romus: ""The stakes are too high to take half measures. We must s..."*)

### Węzeł `[507]`
Mówca: **Manus Sazon**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Manus Sazon: ""I will reach out to you when the time is right and we ha..."*)

### Węzeł `[508]`
Mówca: **Manus Sazon**
> ""Then it is settled, Your Majesty. We will seek the royal houses' approval on our reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Manus Sazon: ""I will reach out to you when the time is right and we ha..."*)

### Węzeł `[509]`
Mówca: **Manus Sazon**
> ""I will reach out to you when the time is right and we have a draft ready to discuss with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic = true"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "He tapped the cover of his notepad."*)

### Węzeł `[511]`
Mówca: **Manus Sazon**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Manus Sazon: ""Then I will reach out to you for our next steps.""*)

### Węzeł `[512]`
Mówca: **Manus Sazon**
> ""You can't be serious, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Player_Romus: ""My benevolence has its limits. Sotelato's people know th..."*)
  - -> `[514]` (*Player_Romus: ""I am very serious, Manus. Our collaboration is over. You..."*)
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My benevolence has its limits. Sotelato's people know that without my cooperation there would be no reforms, and yet my opinion is not respected. I won't have any of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[512]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Manus Sazon: ""I... I understand.""*)

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am very serious, Manus. Our collaboration is over. You'd better stop representing this movement before it's too late as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[512]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Manus Sazon: ""I... I understand.""*)

### Węzeł `[515]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make me repeat myself. Our meeting is over.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[512]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Manus Sazon: ""I... I understand.""*)

### Węzeł `[516]`
Mówca: **Narrator**
> "Manus' voice wavered with uncertainty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Manus Sazon: ""We'll talk about this later. I hope we can come to an ag..."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Manus Sazon: ""An interesting plan, Your Majesty.""*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Aggressive = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Aggressive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Manus Sazon: ""I see...""*)

### Węzeł `[519]`
Mówca: **Manus Sazon**
> ""An interesting plan, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Manus Sazon: ""Then I will reach out to you for our next steps.""*)

### Węzeł `[520]`
Mówca: **Manus Sazon**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Narrator: "Manus' voice wavered with uncertainty."*)

### Węzeł `[521]`
Mówca: **Manus Sazon**
> ""So be it, Your Majesty. Perhaps my fears are overblown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Manus Sazon: ""Then I will reach out to you for our next steps.""*)

### Węzeł `[522]`
Mówca: **Manus Sazon**
> ""Then I will reach out to you for our next steps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "He tapped the cover of his notepad."*)

### Węzeł `[523]`
Mówca: **Manus Sazon**
> ""I... I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "He bowed."]"*)

### Węzeł `[524]`
Mówca: **Narrator**
> "He bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Path = false; RiziaDLC.Reform_Path_Cancel..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "He bowed."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Narrator: "He bowed."*)

### Węzeł `[526]`
Mówca: **Manus Sazon**
> ""Thank you for the meeting, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Narrator: "As we ascended back into the wine cellar, I thought about..."*)

### Węzeł `[527]`
Mówca: **Narrator**
> "As we ascended back into the wine cellar, I thought about what I had gotten myself into."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_TalkToAdarfo_AskedManus == true"*)

### Węzeł `[528]`
Mówca: **Narrator**
> "I hoped that cutting ties with the reformists had been the right move."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[529]`
Mówca: **Narrator**
> "With Pabel's help, Manus managed to make it into the Palas Rezna kitchens through a service entrance. We greeted each other in hushed voices, then headed below the kitchen to the wine cellar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "I flicked a switch hidden behind the shelf of bottles. It..."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true && RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true && RiziaDLC.Pol..."*)
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true && RiziaDLC.P..."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true && RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Narrator: "With Pabel's help, Manus managed to make it into the Pala..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true && RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true  and  Variable["RiziaDLC.Policy_RD_Welfare_DecriminalizeHomosexuality"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Narrator: "With Titus' help, Manus managed to make it into the Palas..."*)

### Węzeł `[533]`
Mówca: **Narrator**
> "With Titus' help, Manus managed to make it into the Palas Rezna kitchens through a service entrance. We greeted each other in hushed voices, then headed below the kitchen to the wine cellar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "I flicked a switch hidden behind the shelf of bottles. It..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Focus_Government_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Foc..."*)
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.F..."*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Focus_Government_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player_Romus: ""Thank *you* for your devotion to the reformist cause, Ma..."*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true || RiziaDLC.Focus_Government_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Player_Romus: ""Don't get too excited. All I'm trying to do is keep your..."*)

### Węzeł `[537]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't get too excited. All I'm trying to do is keep your party's lunatic fringe from coming for my head.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[62]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Manus Sazon: ""But you're not going after theirs. That's a promising st..."*)

### Węzeł `[538]`
Mówca: **Manus Sazon**
> ""But you're not going after theirs. That's a promising start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He pulled a notepad out of his breast pocket."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Manus Sazon: ""When the Crown Princess returns, it will be to a changed..."*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Manus Sazon: ""The Crown Princess has inspired us both, Your Majesty.""*)

### Węzeł `[542]`
Mówca: **Manus Sazon**
> ""When the Crown Princess returns, it will be to a changed Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "He pulled a notepad out of his breast pocket."*)

### Węzeł `[543]`
Mówca: **Manus Sazon**
> ""On the other hand, I doubt the nobility will agree to play by his rules.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Manus Sazon: ""If we want a peaceful resolution to all this, we need to..."*)

### Węzeł `[544]`
Mówca: **Manus Sazon**
> ""The second the nobles find out we're working with him, they will try to stop us by any means necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Manus Sazon: ""If we want a peaceful resolution to all this, we need to..."*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Manus Sazon: ""The RPP may not hold a delegate majority, but as the Cro..."*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Manus Sazon: ""The problem is that not only is the RPP still the opposi..."*)

### Węzeł `[548]`
Mówca: **Manus Sazon**
> ""The RPP may not hold a delegate majority, but as the Crowd Prince Consort, I still hold some sway with the nobles. A peaceful resolution may yet be possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A wise man once told me that violence is justified if it helps protect the divine order.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk"] == true  or  Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk"] == true`
- **Kontekst wejściowy (poprzednik):** `[306]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Manus Sazon: ""Justified? You sound like my father...""*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk == true || RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk == true..."*)
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk == tr..."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk == true || RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk"] == true  or  Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Player_Romus: ""A wise man once told me that violence is justified if it..."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk == true || RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk"] == true  or  Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Player_Romus: ""I agree that violence should only be used as a last reso..."*)

### Węzeł `[553]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree that violence should only be used as a last resort. But it sounds like we're reaching that point.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_WarTalk"] == true  or  Variable["RiziaDLCIsolated.Turn06_Briefing_Religion_MurderandWarTalk"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[306]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Manus Sazon: ""It doesn't have to come to that. Listen.""*)

### Węzeł `[554]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was speaking metaphorically. We'll fight them with our *words*.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[306]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Manus Sazon: ""I was just about to tell you that we shouldn't say a wor..."*)

### Węzeł `[555]`
Mówca: **Manus Sazon**
> ""I was just about to tell you that we shouldn't say a word to the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Manus Sazon: ""If we can keep the process completely under wraps until ..."*)

### Węzeł `[556]`
Mówca: **Manus Sazon**
> ""Justified? You sound like my father...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Manus Sazon: ""I understand what you're saying, Your Majesty.""*)

### Węzeł `[557]`
Mówca: **Manus Sazon**
> ""It doesn't have to come to that. Listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Manus Sazon: ""There is a reason why we're meeting here in secret.""*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC...."*)
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDL..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Player_Romus: ""It's about time. Numbers make me dizzy.""*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[561]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's about time. Numbers make me dizzy.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[18]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Manus Sazon: ""First, I want to go over the demands of Sotelato's facti..."*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Manus Sazon: ""I want to go over the RPP's main points to get a sense o..."*)

### Węzeł `[565]`
Mówca: **Manus Sazon**
> ""First, I want to go over the demands of Sotelato's faction to get a sense of your perspective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Manus Sazon: ""He and I agree that our main objective is to ensure the ..."*)

### Węzeł `[566]`
Mówca: **Manus Sazon**
> ""He and I agree that our main objective is to ensure the political participation of our citizens. This is only possible if the monarch's power is limited, as enshrined in the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Manus Sazon: ""Our country is still an absolute monarchy in all but nam..."*)

### Węzeł `[567]`
Mówca: **Manus Sazon**
> ""Our country is still an absolute monarchy in all but name. Your father created the House of Delegates as a symbolic parliament, but the new constitution can give it the true authority it represents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Manus Sazon: ""This would mean the head of government will be an electe..."*)

### Węzeł `[568]`
Mówca: **Manus Sazon**
> ""This would mean the head of government will be an elected official -- who can later be ceremonially appointed by the head of state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Manus Sazon: ""They will lead a cabinet of ministers, sit as a member o..."*)

### Węzeł `[569]`
Mówca: **Manus Sazon**
> ""You will no longer rule, Your Majesty. But you'll reign, albeit in name only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Manus Sazon: ""Mr. Sotelato will never budge on this point.""*)

### Węzeł `[570]`
Mówca: **Manus Sazon**
> ""They will lead a cabinet of ministers, sit as a member of the House of Delegates, and determine the direction of the Rizian government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Player_Romus: ""I agree. The monarch should act as the head of state, no..."*)
  - -> `[571]` (*Player_Romus: ""Then what will I do?""*)
  - -> `[572]` (*Player_Romus: ""That sounds like far too much power for one person.""*)
  - -> `[573]` (*Player_Romus: ""I don't object to any of this so far.""*)

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then what will I do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Manus Sazon: ""You will no longer rule, Your Majesty. But you'll reign,..."*)

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds like far too much power for one person.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Manus Sazon: ""The head of government's powers would be clearly outline..."*)

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't object to any of this so far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Manus Sazon: ""Very good.""*)

### Węzeł `[574]`
Mówca: **Manus Sazon**
> ""The head of government's powers would be clearly outlined in the constitution. The goal is to balance the power structure fairly so that no branch has complete authority over the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Manus Sazon: ""The House of Delegates itself will be defined as the gov..."*)

### Węzeł `[575]`
Mówca: **Manus Sazon**
> ""Very good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Manus Sazon: ""The House of Delegates itself will be defined as the gov..."*)

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree. The monarch should act as the head of state, not the head of government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Manus Sazon: ""That's what we've been working on.""*)

### Węzeł `[577]`
Mówca: **Manus Sazon**
> ""That's what we've been working on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Manus Sazon: ""The House of Delegates itself will be defined as the gov..."*)

### Węzeł `[578]`
Mówca: **Manus Sazon**
> ""Mr. Sotelato will never budge on this point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Manus Sazon: ""The House of Delegates itself will be defined as the gov..."*)

### Węzeł `[579]`
Mówca: **Manus Sazon**
> ""With all due respect, Your Majesty, I don't think you understand what Sotelato's movement wants.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Manus Sazon: ""Unless you can accept the complete transfer of your sove..."*)

### Węzeł `[580]`
Mówca: **Manus Sazon**
> ""The House of Delegates itself will be defined as the governing legislative body in Rizia, with clearly outlined procedures and jurisdiction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Manus Sazon: ""Instead of the monarch, they will be in charge of managi..."*)

### Węzeł `[581]`
Mówca: **Manus Sazon**
> ""Instead of the monarch, they will be in charge of managing the government budget and passing laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Player_Romus: ""Only if their decisions are subject to the monarch's -- ..."*)
  - -> `[583]` (*Player_Romus: ""Only if the monarch holds the right to veto their decisi..."*)
  - -> `[585]` (*Player_Romus: ""I'll miss being able to sign decrees.""*)
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC...."*)
  - -> `[592]` (*Player_Romus: ""That's it? I was expecting much worse.""*)

### Węzeł `[582]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only if their decisions are subject to the monarch's -- to *my* -- approval.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Manus Sazon: ""With all due respect, Your Majesty, I don't think you un..."*)

### Węzeł `[583]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only if the monarch holds the right to veto their decisions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Manus Sazon: ""With all due respect, Your Majesty, I don't think you un..."*)

### Węzeł `[584]`
Mówca: **Manus Sazon**
> ""Unless you can accept the complete transfer of your sovereignty to the House of Delegates, the new constitution will never pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Manus Sazon: ""As for the other demands...""*)

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll miss being able to sign decrees.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Manus Sazon: ""If I were in charge of the RPP, I'd allow the monarch to..."*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC...."*)
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDL..."*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Player_Romus: ""Perfect. Numbers make my head hurt anyway.""*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true && RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perfect. Numbers make my head hurt anyway.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true  and  Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[581]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Manus Sazon: ""The responsibility must be painful indeed.""*)

### Węzeł `[590]`
Mówca: **Manus Sazon**
> ""If I were in charge of the RPP, I'd allow the monarch to have some sort of say in politics. Alas, I am not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Manus Sazon: ""As for the other demands...""*)

### Węzeł `[591]`
Mówca: **Manus Sazon**
> ""The responsibility must be painful indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Manus Sazon: ""As for the other demands...""*)

### Węzeł `[592]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's it? I was expecting much worse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[581]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Manus Sazon: ""I'm not finished with the list of demands.""*)

### Węzeł `[593]`
Mówca: **Manus Sazon**
> ""I'm not finished with the list of demands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Narrator: "He looked down."*)

### Węzeł `[594]`
Mówca: **Manus Sazon**
> ""As for the other demands...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Narrator: "He looked down."*)

### Węzeł `[595]`
Mówca: **Narrator**
> "He looked down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Manus Sazon: ""Soletato's group is asking not only for the removal of t..."*)

### Węzeł `[596]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That makes sense. If I don't have any power, my relatives shouldn't either.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[597]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Manus Sazon: ""I would expect nothing less from this movement. But it w..."*)

### Węzeł `[597]`
Mówca: **Manus Sazon**
> ""Soletato's group is asking not only for the removal of the monarch's sovereign powers, but for the removal of all political privileges from the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Player_Romus: ""That makes sense. If I don't have any power, my relative..."*)
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == false"*)
  - -> `[603]` (*Player_Romus: ""A slap in the face to Rizian tradition.""*)
  - -> `[604]` (*Player_Romus: ""But they can keep their money, right?""*)

### Węzeł `[598]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's not fair. Some of Rizia's finest politicians are nobles.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[597]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Manus Sazon: ""They can run for election, like anyone else.""*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_ElectoralReform == false"*)
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == false)"*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_ElectoralReform == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Player_Romus: ""Finishing the job my electoral reform decree started.""*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_ElectoralReform == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Player_Romus: ""That's not fair. Some of Rizia's finest politicians are ..."*)

### Węzeł `[602]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Finishing the job my electoral reform decree started.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_RD_Welfare_ElectoralReform"] == false`
- **Kontekst wejściowy (poprzednik):** `[597]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Manus Sazon: ""More than that. In a few generations, the names Toras, A..."*)

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A slap in the face to Rizian tradition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[597]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Manus Sazon: ""It will make many people very angry, yes.""*)

### Węzeł `[604]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But they can keep their money, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[597]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Manus Sazon: ""Whatever's left of it after the tax hikes the new govern..."*)

### Węzeł `[605]`
Mówca: **Manus Sazon**
> ""Whatever's left of it after the tax hikes the new government is planning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Manus Sazon: ""Finally... after the constitution is signed, an interim ..."*)

### Węzeł `[606]`
Mówca: **Manus Sazon**
> ""It will make many people very angry, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Manus Sazon: ""Finally... after the constitution is signed, an interim ..."*)

### Węzeł `[607]`
Mówca: **Manus Sazon**
> ""They can run for election, like anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Manus Sazon: ""Finally... after the constitution is signed, an interim ..."*)

### Węzeł `[608]`
Mówca: **Manus Sazon**
> ""More than that. In a few generations, the names Toras, Azaro and Sazon will mean next to nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Manus Sazon: ""Finally... after the constitution is signed, an interim ..."*)

### Węzeł `[609]`
Mówca: **Manus Sazon**
> ""I would expect nothing less from this movement. But it will make a good deal of people very angry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Manus Sazon: ""Finally... after the constitution is signed, an interim ..."*)

### Węzeł `[610]`
Mówca: **Manus Sazon**
> ""Finally... after the constitution is signed, an interim prime minister will have to be appointed to govern Rizia during the transitory period before the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Manus Sazon: ""The RPP's demand is for Adarfo Sotelato himself to fill ..."*)

### Węzeł `[611]`
Mówca: **Manus Sazon**
> ""The RPP's demand is for Adarfo Sotelato himself to fill that role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Player_Romus: ""I was fine with all the other demands. But I will not pu..."*)
  - -> `[614]` (*Player_Romus: ""This is all your mistake for letting RPP get radicalized..."*)
  - -> `[613]` (*Player_Romus: ""If that's what it takes to get the reforms across the fi..."*)
  - -> `[615]` (*Player_Romus: ""With terms like these, we might as well abolish the Rizi..."*)

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was fine with all the other demands. But I will not put an unproven commoner in charge of our kingdom, even temporarily. Tell the rest of your party that the plan is off.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Narrator: "His face fell."*)

### Węzeł `[613]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that's what it takes to get the reforms across the finish line, then I agree to all of the demands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Narrator: "Manus broke into an enormous, relieved smile."*)

### Węzeł `[614]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all your mistake for letting RPP get radicalized. I'm afraid I will not agree to their demands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Narrator: "His face fell."*)

### Węzeł `[615]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With terms like these, we might as well abolish the Rizian monarchy altogether.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Manus Sazon: ""If that is what you want, all you have to do is hand you..."*)

### Węzeł `[616]`
Mówca: **Narrator**
> "Manus broke into an enormous, relieved smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Manus Sazon: ""Great.""*)

### Węzeł `[617]`
Mówca: **Manus Sazon**
> ""Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Narrator: "He flipped to another page in his notepad."*)

### Węzeł `[618]`
Mówca: **Manus Sazon**
> ""If that is what you want, all you have to do is hand your crown to Adarfo Sotelato.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Narrator: "He smiled darkly."*)

### Węzeł `[619]`
Mówca: **Manus Sazon**
> ""I warn you, though, he might not accept it unless your head comes off with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Player_Romus: ""I'm willing to take that risk. Get me a meeting with Sot..."*)
  - -> `[622]` (*Player_Romus: ""It is not my intention to abdicate, Mr. Sazon. Nor is it..."*)
  - -> `[623]` (*Player_Romus: ""I only meant to say that Sotelato's demands are extreme...."*)

### Węzeł `[620]`
Mówca: **Narrator**
> "He smiled darkly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Manus Sazon: ""I warn you, though, he might not accept it unless your h..."*)

### Węzeł `[621]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm willing to take that risk. Get me a meeting with Sotelato. I should have been speaking with him this entire time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[619]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_TalkToAdarfo_AskedManus = true"*)

### Węzeł `[622]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is not my intention to abdicate, Mr. Sazon. Nor is it my intention to hand over my and my family's power to some urchin from the mines.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[619]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Narrator: "His face fell."*)

### Węzeł `[623]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I only meant to say that Sotelato's demands are extreme. But I'll agree to them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[619]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Narrator: "Manus broke into an enormous, relieved smile."*)

### Węzeł `[624]`
Mówca: **Narrator**
> "His face fell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Manus Sazon: ""You can't be serious, Your Majesty...""*)

### Węzeł `[625]`
Mówca: **Narrator**
> "His face fell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Manus Sazon: ""I... uh...""*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_TalkToAdarfo_AskedManus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Narrator: "His face fell."*)

### Węzeł `[627]`
Mówca: **Manus Sazon**
> ""I... uh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Manus Sazon: ""I'll see what I can do.""*)

### Węzeł `[628]`
Mówca: **Manus Sazon**
> ""I'll see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "He bowed."]"*)

### Węzeł `[629]`
Mówca: **Narrator**
> "He flipped to another page in his notepad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Manus Sazon: ""Now that you've agreed on the basics, there are a few mo..."*)

### Węzeł `[630]`
Mówca: **Manus Sazon**
> ""Now that you've agreed on the basics, there are a few more details we should discuss. The RPP leadership is flexible on these.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Manus Sazon: ""One significant decision is whether to keep the old regi..."*)

### Węzeł `[631]`
Mówca: **Manus Sazon**
> ""One significant decision is whether to keep the old regional structure in Rizia or centralize the system in Porte Drazon completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Manus Sazon: ""Keep in mind that the royal houses will be stripped of t..."*)

### Węzeł `[632]`
Mówca: **Manus Sazon**
> ""Keep in mind that the royal houses will be stripped of their governing power whether Rizia is centralized or not. The new provincial leadership will have to be democratically elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Iza_PowerTransfer_Council_Brenas == true"*)
  - -> `[29]` (*Player_Romus: ""I'd rather not disturb the regional system. We should re..."*)
  - -> `[30]` (*Player_Romus: ""Rizia still resembles a feudal state. We should find way..."*)
  - -> `[31]` (*Player_Romus: ""In a system that already has several branches of governm..."*)

### Węzeł `[633]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[634]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Romus: ""We need to give something to the nobility for their supp..."*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_TalkToAdarfo_AskedManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_TalkToAdarfo_AskedManus == true"*)
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_TalkToAdarfo_AskedManus == true)"*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_TalkToAdarfo_AskedManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Narrator: "I had given up the opportunity to reform Rizia. And soon,..."*)

### Węzeł `[638]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_TalkToAdarfo_AskedManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_TalkToAdarfo_AskedManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Narrator: "I hoped that cutting ties with the reformists had been th..."*)

### Węzeł `[639]`
Mówca: **Narrator**
> "I had given up the opportunity to reform Rizia. And soon, I might be about to give up my crown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Iza_PowerTransfer_Council_Brenas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Iza_PowerTransfer_Council_Brenas == true"*)
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Iza_PowerTransfer_Council_Brenas == true)"*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Iza_PowerTransfer_Council_Brenas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Iza_PowerTransfer_Council_Brenas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Player_Romus: ""A governing council is working out well for Iza. The pro..."*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Iza_PowerTransfer_Council_Brenas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Iza_PowerTransfer_Council_Brenas"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[643]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A governing council is working out well for Iza. The provinces should adopt the same system.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Iza_PowerTransfer_Council_Brenas"] == true`
- **Kontekst wejściowy (poprzednik):** `[632]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[644]`
Mówca: **Manus Sazon**
> ""Respecting regional traditions would be a clever choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Manus Sazon: ""However, it raises questions regarding how the provinces..."*)

### Węzeł `[645]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Axel == true"*)
  - -> `[647]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Axel == true)"*)

### Węzeł `[646]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Axel == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Player_Romus: ""Nor will Duke Axel Reinhart. I doubt he'll agree to reun..."*)

### Węzeł `[647]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Axel == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[648]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nor will Duke Axel Reinhart. I doubt he'll agree to reunification if it means Pales losing all of its autonomy.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Axel"] == true`
- **Kontekst wejściowy (poprzednik):** `[28]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Narrator: "Manus smiled thinly."*)

### Węzeł `[649]`
Mówca: **Manus Sazon**
> ""It would be a tragedy if the Princess' arranged marriage was for nothing. Decentralization it is, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Manus Sazon: ""However, it raises questions regarding how the provinces..."*)

### Węzeł `[650]`
Mówca: **Narrator**
> "Manus smiled thinly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Manus Sazon: ""It would be a tragedy if the Princess' arranged marriage..."*)

### Węzeł `[651]`
Mówca: **Manus Sazon**
> ""I see. A House of Lords, so to speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[652]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[653]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Manus Sazon: ""The rest of the RPP won't like it. But it's a fine compr..."*)

### Węzeł `[654]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Manus Sazon: ""We'll have a hard time getting the nobility to agree to ..."*)

### Węzeł `[655]`
Mówca: **Manus Sazon**
> ""The rest of the RPP won't like it. But it's a fine compromise in my opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords = true"*)

### Węzeł `[656]`
Mówca: **Manus Sazon**
> ""We'll have a hard time getting the nobility to agree to even that. But it's a fine compromise in my opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_HouseOfLords = true"*)

### Węzeł `[657]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_HouseOfLords = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Legislative_HouseOfLords"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[862]` (*Player_Romus: ""Of course, these nobles will serve in an advisory capaci..."*)
  - -> `[863]` (*Player_Romus: ""We'll give them the ability to provide some checks on th..."*)
  - -> `[864]` (*Player_Romus: ""This upper house will have equal power to the lower hous..."*)

### Węzeł `[658]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[660]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_RegionalSenate = true"*)

### Węzeł `[660]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Manus Sazon: ""Allowing the provincial nobility to serve in this upper ..."*)

### Węzeł `[661]`
Mówca: **Manus Sazon**
> ""Allowing the provincial nobility to serve in this upper chamber would assuage their concerns about losing power under the new system.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Player_Romus: ""Good thinking. The upper chamber will be a House of Lords.""*)
  - -> `[665]` (*Player_Romus: ""No, I want a clean slate. The upper chamber will be comp..."*)

### Węzeł `[662]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Legislative_RegionalSenate = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Legislative_RegionalSenate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[663]`
Mówca: **Manus Sazon**
> ""That's settled, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral ..."*)

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good thinking. The upper chamber will be a House of Lords.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[665]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I want a clean slate. The upper chamber will be composed of elected representatives for each region.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[661]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Manus Sazon: ""A regional senate. The RPP will like that.""*)

### Węzeł `[666]`
Mówca: **Manus Sazon**
> ""A regional senate. The RPP will like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Legislative_RegionalSenate = true"*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Player_Romus: ""From now on, your duty is to be the Crown Prince Consort..."*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Player_Romus: ""Don't make me repeat myself. Our meeting is over.""*)

### Węzeł `[670]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From now on, your duty is to be the Crown Prince Consort. I'll handle Sotelato.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[512]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Manus Sazon: ""I... I understand.""*)

### Węzeł `[671]`
Mówca: **Manus Sazon**
> ""I've been thinking about the best way to deal with potential opposition from the three houses. But I want your perspective on them as the King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "Threats From Houses"*)

### Węzeł `[672]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's discuss House Azaro.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == false`
- **Kontekst wejściowy (poprzednik):** `[671]` (Manus Sazon), `[151]` (Manus Sazon), `[156]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro = true"*)

### Węzeł `[673]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's talk about my relatives in House Toras.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == false`
- **Kontekst wejściowy (poprzednik):** `[671]` (Manus Sazon), `[151]` (Manus Sazon), `[156]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras = true"*)

### Węzeł `[674]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do you think House Sazon will react to the reforms?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == false`
- **Kontekst wejściowy (poprzednik):** `[671]` (Manus Sazon), `[151]` (Manus Sazon), `[156]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon = true"*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Threats From Houses`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == ..."*)
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == ..."*)
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == ..."*)
  - -> `[723]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == ..."*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Manus Sazon: ""I'll be honest with you. If any House has the power to s..."*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Manus Sazon: ""They may not have as much firepower as the Azaros, but t..."*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_HouseSazon_AngelicaPardoned == true"*)

### Węzeł `[679]`
Mówca: **Manus Sazon**
> ""With that said, General Taddeus, Duchess Lucita and most Rizian troops are concentrating on the war in Pales. They might be too distracted to contest or even notice our reform attempts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Control_Skipped == false"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.War_Pales_Operation1_Won == true"*)
  - -> `[109]` (*Player_Romus: ""We still have to be careful. Even with a war going on, t..."*)
  - -> `[110]` (*Player_Romus: ""I don't think they pose a threat. They can't simply go a..."*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[680]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We don't need to worry about General Taddeus. The last time we spoke, I made sure he knew his place.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.War_Pales_Operation1_Won"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[679]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Manus Sazon: ""That's not very reassuring. The General is an infamous h..."*)

### Węzeł `[681]`
Mówca: **Manus Sazon**
> ""That's not very reassuring. The General is an infamous holder of grudges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Azaro = true"*)

### Węzeł `[682]`
Mówca: **Manus Sazon**
> ""As long as it doesn't jeopardize Her Highness' survival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[685]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Manus Sazon: ""As long as it doesn't jeopardize Her Highness' survival.""*)

### Węzeł `[685]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == ..."*)
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro =..."*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Player_Romus: ""Let's discuss House Azaro.""*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == ..."*)
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras =..."*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Player_Romus: ""Let's talk about my relatives in House Toras.""*)

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[692]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He did not dare to strike back at me even after I arrested Rico. He won't be a problem.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Manus Sazon: ""If you say so... You know your relatives better than I d..."*)

### Węzeł `[693]`
Mówca: **Manus Sazon**
> ""If you say so... You know your relatives better than I do, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Rico == true"*)
  - -> `[696]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Rico == true)"*)

### Węzeł `[695]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Rico == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Player_Romus: ""With my daughter about to marry his son? It'll never hap..."*)

### Węzeł `[696]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Rico == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player_Romus: ""Don't worry about the Toras family. They are not going t..."*)

### Węzeł `[697]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With my daughter about to marry his son? It'll never happen.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Rico"] == true`
- **Kontekst wejściowy (poprzednik):** `[143]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Manus Sazon: ""Correct me if I'm wrong, but that marriage is meant to p..."*)

### Węzeł `[698]`
Mówca: **Manus Sazon**
> ""Correct me if I'm wrong, but that marriage is meant to preserve the Toras line of succession. Which will be of significantly less importance if these reforms succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Manus Sazon: ""But let's assume for now that the coming royal wedding w..."*)

### Węzeł `[699]`
Mówca: **Manus Sazon**
> ""But let's assume for now that the coming royal wedding will put Hugo and Rico in our camp.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Toras_Talk = true"*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Threats From Houses]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "Threats From Houses"*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_PoliceChief_PorteDrazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_PoliceChief_PorteDrazon == true"*)
  - -> `[703]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_PoliceChief_PorteDrazon == true)"*)

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_PoliceChief_PorteDrazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Player_Romus: ""After I made his son police chief? Not a chance.""*)

### Węzeł `[703]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_PoliceChief_PorteDrazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[704]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""After I made his son police chief? Not a chance.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rico_PoliceChief_PorteDrazon"] == true` AND `Variable["RiziaDLC.Rico_Arrested"] == false  and  Variable["RiziaDLC.Rico_Extradited"] == false`
- **Kontekst wejściowy (poprzednik):** `[143]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Manus Sazon: ""But Your Majesty... now that Duke Ricardus is in charge ..."*)

### Węzeł `[705]`
Mówca: **Manus Sazon**
> ""But Your Majesty... now that Duke Ricardus is in charge of the capital's security, he can very easily stop our reforms in their tracks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Player_Romus: ""Dammit. You're right.""*)
  - -> `[707]` (*Player_Romus: ""He could, but he wouldn't dare. I've got him under my th..."*)

### Węzeł `[706]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dammit. You're right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[705]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Threat_Toras = true"*)

### Węzeł `[707]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He could, but he wouldn't dare. I've got him under my thumb.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[705]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Manus Sazon: ""If you say so... You know your relatives better than I d..."*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == ..."*)
  - -> `[710]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon =..."*)

### Węzeł `[709]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Player_Romus: ""How do you think House Sazon will react to the reforms?""*)

### Węzeł `[710]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[711]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Iza_PowerTransfer_Angelica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Iza_PowerTransfer_Angelica == true"*)
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Iza_PowerTransfer_Angelica == true)"*)

### Węzeł `[712]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Iza_PowerTransfer_Angelica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Manus Sazon: ""As the matriarch of House Sazon and the Duchess of Iza, ..."*)

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Iza_PowerTransfer_Angelica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Iza_PowerTransfer_Angelica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Manus Sazon: ""As the reinstated matriarch of House Sazon, she commands..."*)

### Węzeł `[714]`
Mówca: **Manus Sazon**
> ""As the matriarch of House Sazon and the Duchess of Iza, she commands more respect from our family than I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Manus Sazon: ""And frankly, she and I are of different minds.""*)

### Węzeł `[715]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Manus Sazon: ""At last, an easy question.""*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[718]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Manus Sazon: ""I am House Sazon's heir and the Crown Prince Consort. No..."*)

### Węzeł `[718]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Manus Sazon: ""I am House Sazon's heir. No member of my family commands..."*)

### Węzeł `[719]`
Mówca: **Manus Sazon**
> ""At last, an easy question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)

### Węzeł `[720]`
Mówca: **Manus Sazon**
> ""I am House Sazon's heir and the Crown Prince Consort. No member of my family commands more respect than I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Manus Sazon: ""My cousin Leona is little more than a figurehead. She an..."*)

### Węzeł `[721]`
Mówca: **Manus Sazon**
> ""I am House Sazon's heir. No member of my family commands more respect than I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Manus Sazon: ""My cousin Leona is little more than a figurehead. She an..."*)

### Węzeł `[722]`
Mówca: **Manus Sazon**
> ""My cousin Leona is little more than a figurehead. She and the others will support the reforms when the time comes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[723]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == ..."*)
  - -> `[725]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro =..."*)

### Węzeł `[724]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)

### Węzeł `[725]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon == true && RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Player_Romus: ""No need to discuss the houses. They'll fall in line if I..."*)
  - -> `[735]` (*Player_Romus: ""It's a waste of time to talk about the houses. Let's jus..."*)

### Węzeł `[726]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That covers the royal houses. What about Daria and the House of Delegates?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false` AND `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true`
- **Kontekst wejściowy (poprzednik):** `[671]` (Manus Sazon), `[151]` (Manus Sazon), `[156]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Manus Sazon: ""I'm afraid the Rizian National Coalition will present qu..."*)

### Węzeł `[727]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)
  - -> `[729]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == false)"*)

### Węzeł `[728]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Player_Romus: ""That covers the royal houses. What about Daria and the H..."*)

### Węzeł `[729]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Player_Romus: ""That covers the royal houses. What about your fellow Del..."*)

### Węzeł `[730]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That covers the royal houses. What about your fellow Delegates?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false` AND `Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true`
- **Kontekst wejściowy (poprzednik):** `[671]` (Manus Sazon), `[151]` (Manus Sazon), `[156]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Manus Sazon: ""The RPP is the majority party, Your Majesty. If we all s..."*)

### Węzeł `[731]`
Mówca: **Manus Sazon**
> ""Baroness de Rava has tolerated the presence of the reformist movement in parliament, but she will never condone it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Manus Sazon: ""I don't expect her or the RNC to budge an inch on our re..."*)

### Węzeł `[732]`
Mówca: **Manus Sazon**
> ""Exactly. That's the problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Manus Sazon: ""As the majority, the RNC has the power to obstruct us at..."*)

### Węzeł `[733]`
Mówca: **Manus Sazon**
> ""As the majority, the RNC has the power to obstruct us at every turn, with the justification the new constitution is 'against the will of the people'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Manus Sazon: ""If de Rava finds out about our plans while they're still..."*)

### Węzeł `[734]`
Mówca: **Manus Sazon**
> ""The RPP is the majority party, Your Majesty. If we all support the new constitution, Daria and the RNC won't contest it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]` (*Manus Sazon: ""If we want to acknowledge the opposition, we could give ..."*)

### Węzeł `[735]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a waste of time to talk about the houses. Let's just assume they'll never agree with this plan.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[671]` (Manus Sazon), `[151]` (Manus Sazon), `[156]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[736]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to discuss the houses. They'll fall in line if I tell them to.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Azaro"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Sazon"] == true  and  Variable["RiziaDLCIsolated.Turn08_ReformTalk_HouseThreats_Toras"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[671]` (Manus Sazon), `[151]` (Manus Sazon), `[156]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)

### Węzeł `[737]`
Mówca: **Manus Sazon**
> ""But Your Majesty, there is still Daria de Rava and the Rizian National Coalition to consider.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[738]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == false)"*)

### Węzeł `[739]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Manus Sazon: ""But Your Majesty, there is still Daria de Rava and the R..."*)

### Węzeł `[740]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Manus Sazon: ""I very much hope you're right about that.""*)

### Węzeł `[741]`
Mówca: **Manus Sazon**
> ""I very much hope you're right about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Manus Sazon: ""If the new constitution gains a delegate majority in the..."*)

### Węzeł `[742]`
Mówca: **Manus Sazon**
> ""If the new constitution gains a delegate majority in the HOD -- which it will, because my party is in charge -- the nobles won't have the legal means to challenge us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true"*)

### Węzeł `[743]`
Mówca: **Manus Sazon**
> ""Then again, the Rizian nobility has been known to resort to extralegal means in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[744]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rico_Arrested == true"*)
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rico_Arrested == true)"*)

### Węzeł `[745]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rico_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rico_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Narrator: "He looked at me uneasily."*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rico_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rico_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Manus Sazon: ""Then again, the Rizian nobility has been known to resort..."*)

### Węzeł `[747]`
Mówca: **Narrator**
> "He looked at me uneasily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Manus Sazon: ""Then again, the Rizian nobility has been known to resort..."*)

### Węzeł `[748]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[750]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[749]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Manus Sazon: ""Are you sure it's not worth trying to bargain with them?""*)

### Węzeł `[750]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Manus Sazon: ""Yes, you're probably right.""*)

### Węzeł `[751]`
Mówca: **Manus Sazon**
> ""Are you sure it's not worth trying to bargain with them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Manus Sazon: ""If the new constitution gains a delegate majority in the..."*)

### Węzeł `[752]`
Mówca: **Manus Sazon**
> ""Yes, you're probably right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[753]` (*Manus Sazon: ""Even if we could get the Houses on our side, Daria de Ra..."*)

### Węzeł `[753]`
Mówca: **Manus Sazon**
> ""Even if we could get the Houses on our side, Daria de Rava and the Rizian National Coalition present a significant challenge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)

### Węzeł `[754]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[756]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[755]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Manus Sazon: ""Not to mention that Adarfo's demands leave us with littl..."*)

### Węzeł `[756]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Manus Sazon: ""That being said, we still have room to bargain. If the n..."*)

### Węzeł `[757]`
Mówca: **Manus Sazon**
> ""Not to mention that Adarfo's demands leave us with little room to negotiate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[758]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Threat_Toras_Talk = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Threat_Toras_Talk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[759]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "Jump to: [Threats From Houses]"*)

### Węzeł `[760]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == false"*)
  - -> `[762]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == false)"*)

### Węzeł `[761]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Manus Sazon: ""But with the RNC holding a majority in the House of Dele..."*)

### Węzeł `[762]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Manus Sazon: ""I maintain they'll never allow a commoner like Adarfo So..."*)

### Węzeł `[763]`
Mówca: **Manus Sazon**
> ""I maintain they'll never allow a commoner like Adarfo Sotelato to strip them of their privileges.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[764]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If being diplomatic means making concessions to the nobility in our new constitution, I would rather not do it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[468]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Manus Sazon: ""Then what are you thinking?""*)

### Węzeł `[765]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Grows == true"*)
  - -> `[767]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Grows == true)"*)

### Węzeł `[766]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Grows == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Grows"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Player_Romus: ""Once we declare our intentions, the power of the reform ..."*)

### Węzeł `[767]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Grows == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Grows"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[768]`
Mówca: **Manus Sazon**
> ""We'll talk about this later. I hope we can come to an agreement regarding such an... arrangement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "He tapped the cover of his notepad."*)

### Węzeł `[769]`
Mówca: **Manus Sazon**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Narrator: "Manus' voice wavered with uncertainty."*)

### Węzeł `[770]`
Mówca: **Manus Sazon**
> ""If and when the time comes to present her with the new constitution, she will likely expect to be named interim prime minister.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Player_Romus: ""That's fair enough.""*)
  - -> `[775]` (*Player_Romus: ""I thought you'd be gunning for the position yourself.""*)
  - -> `[776]` (*Player_Romus: ""What does it matter? She'd only lead the country for a f..."*)

### Węzeł `[771]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == false"*)
  - -> `[773]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == false)"*)

### Węzeł `[772]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Manus Sazon: ""If and when the time comes to present her with the new c..."*)

### Węzeł `[773]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[774]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's fair enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[770]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Manus Sazon: ""I agree. On paper, at least, she is the popular choice.""*)

### Węzeł `[775]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you'd be gunning for the position yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[770]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Narrator: "He reddened."*)

### Węzeł `[776]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does it matter? She'd only lead the country for a few months, anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[770]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Manus Sazon: ""Rizia naming its first prime minister will be an event w..."*)

### Węzeł `[777]`
Mówca: **Narrator**
> "He reddened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Manus Sazon: ""It would be an honor, Your Majesty, but I'm not the majo..."*)

### Węzeł `[778]`
Mówca: **Manus Sazon**
> ""It would be an honor, Your Majesty, but I'm not the majority speaker in parliament. If we're to play by the rules, Daria would be the correct choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[779]`
Mówca: **Manus Sazon**
> ""I agree. On paper, at least, she is the popular choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[780]`
Mówca: **Manus Sazon**
> ""Rizia naming its first prime minister will be an event with immense ramifications. Her name would go down in history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[781]`
Mówca: **Manus Sazon**
> ""If we want to acknowledge the opposition, we could give Daria the role of interim prime minister, letting her lead the government until the first elections are held.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]` (*Player_Romus: ""Why would I do that? You're the man the people want.""*)
  - -> `[787]` (*Player_Romus: ""I thought you'd be gunning for the position yourself.""*)
  - -> `[785]` (*Player_Romus: ""Why not? It might help smooth things over.""*)

### Węzeł `[782]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why would I do that? You're the man the people want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[781]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]` (*Manus Sazon: ""You're too kind, Your Majesty.""*)

### Węzeł `[783]`
Mówca: **Narrator**
> "He reddened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]` (*Manus Sazon: ""It would indeed be an honor, Your Majesty, but that was ..."*)

### Węzeł `[784]`
Mówca: **Manus Sazon**
> ""You're too kind, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[785]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not? It might help smooth things over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[781]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Manus Sazon: ""And she's unlikely to make too many disruptions during t..."*)

### Węzeł `[786]`
Mówca: **Manus Sazon**
> ""And she's unlikely to make too many disruptions during that time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Reform_Intention_PM_Daria = true"*)

### Węzeł `[787]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thought you'd be gunning for the position yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[781]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Narrator: "He reddened."*)

### Węzeł `[788]`
Mówca: **Manus Sazon**
> ""It would indeed be an honor, Your Majesty, but that was never why I proposed these reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[789]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Engaged == true"*)
  - -> `[791]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Engaged == true)"*)

### Węzeł `[790]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Engaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Player_Romus: ""We're not going to make any drastic moves until after th..."*)

### Węzeł `[791]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Engaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Engaged"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[792]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're not going to make any drastic moves until after the royal wedding. I want it to go off without a hitch.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Engaged"] == true`
- **Kontekst wejściowy (poprzednik):** `[164]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus"*)

### Węzeł `[793]`
Mówca: **Narrator**
> "Manus nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]` (*Manus Sazon: ""Obviously, so do I. The profile boost I'll get as Prince..."*)

### Węzeł `[794]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus"*)
  - -> `[796]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus)"*)

### Węzeł `[795]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Narrator: "Manus nodded."*)

### Węzeł `[796]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Narrator: "Manus nodded sadly."*)

### Węzeł `[797]`
Mówca: **Manus Sazon**
> ""Obviously, so do I. The profile boost I'll get as Prince Consort will be a huge help to the reformist cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)

### Węzeł `[798]`
Mówca: **Narrator**
> "Manus nodded sadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Manus Sazon: ""So do I, Your Majesty. We'll wait.""*)

### Węzeł `[799]`
Mówca: **Manus Sazon**
> ""So do I, Your Majesty. We'll wait.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)

### Węzeł `[800]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Aggressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Aggressive == true"*)
  - -> `[802]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Aggressive == true)"*)

### Węzeł `[801]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Aggressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Aggressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""I think you're too worried about all this, Manus. You sh..."*)

### Węzeł `[802]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Aggressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Aggressive"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[803]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Be careful, Manus. If this goes south, we could both lose our heads.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[164]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Narrator: "He grimaced."*)

### Węzeł `[804]`
Mówca: **Narrator**
> "He grimaced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]` (*Manus Sazon: ""Don't worry, Your Majesty. You can trust me.""*)

### Węzeł `[805]`
Mówca: **Manus Sazon**
> ""Don't worry, Your Majesty. You can trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)

### Węzeł `[806]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A communist prime minister... If that isn't the nail in the coffin for our relationship with ATO, I don't know what is.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Kontekst wejściowy (poprzednik):** `[164]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[810]` (*Manus Sazon: ""The West won't like it one bit.""*)

### Węzeł `[807]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[809]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[808]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Player_Romus: ""A communist prime minister... If that isn't the nail in ..."*)

### Węzeł `[809]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]` (*Player_Romus: ""I wonder what our neighbors will think of all this.""*)

### Węzeł `[810]`
Mówca: **Manus Sazon**
> ""The West won't like it one bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]` (*Manus Sazon: ""We -- well, Adarfo -- will have to focus on strengthenin..."*)

### Węzeł `[811]`
Mówca: **Manus Sazon**
> ""We -- well, Adarfo -- will have to focus on strengthening ties with Morella and Valgsland. It'll be a completely different landscape.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)

### Węzeł `[812]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wonder what our neighbors will think of all this.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[164]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]` (*Manus Sazon: ""As long as we maintain the same trade ties as before, I ..."*)

### Węzeł `[813]`
Mówca: **Manus Sazon**
> ""As long as we maintain the same trade ties as before, I don't see a reason why any of our international relationships would be affected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[814]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[816]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[815]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]` (*Manus Sazon: ""Of course, I'm hoping the Pales war will be far in our r..."*)

### Węzeł `[816]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)

### Węzeł `[817]`
Mówca: **Manus Sazon**
> ""Of course, I'm hoping the Pales war will be far in our rearview mirror before the reforms pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == false"*)

### Węzeł `[818]`
Mówca: **Manus Sazon**
> ""Speaking of Her Highness...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)

### Węzeł `[819]`
Mówca: **Manus Sazon**
> ""There is one more point I wanted to bring up. About Her Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)

### Węzeł `[820]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Diplomatic == true)"*)

### Węzeł `[821]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Manus Sazon: ""If we want to be diplomatic about the reform process, I ..."*)

### Węzeł `[822]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Diplomatic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]` (*Manus Sazon: ""For the Princess' own protection, I'm not sure whether s..."*)

### Węzeł `[823]`
Mówca: **Manus Sazon**
> ""If we want to be diplomatic about the reform process, I highly suggest we get Vina involved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]` (*Manus Sazon: ""This is something she's passionate about as well, after ..."*)

### Węzeł `[824]`
Mówca: **Manus Sazon**
> ""This is something she's passionate about as well, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_FullCouncilor == true"*)

### Węzeł `[825]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Silent == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Silent == false"*)
  - -> `[827]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Silent == false)"*)

### Węzeł `[826]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Silent == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Silent"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Manus Sazon: ""I will reach out to you when it's time to act.""*)

### Węzeł `[827]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Silent == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Silent"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Manus Sazon: ""I will reach out to you when it's time to act. You shoul..."*)

### Węzeł `[828]`
Mówca: **Manus Sazon**
> ""For the Princess' own protection, I'm not sure whether she should be informed about these plans until they've come to fruition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]` (*Player_Romus: ""This highly concerns my daughter and her future. Of cour..."*)
  - -> `[831]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[838]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Reform_Movem..."*)
  - -> `[843]` (*Player_Romus: ""You may be right. I don't want to put my daughter in dan..."*)

### Węzeł `[829]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This highly concerns my daughter and her future. Of course she should be informed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[828]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Involve_Vina = true; RiziaDLCSupport.Jour..."*)

### Węzeł `[830]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Involve_Vina = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Involve_Vina"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Manus Sazon: ""If you think that's best, I understand.""*)

### Węzeł `[831]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_MarriageDecision_Manus == true"*)
  - -> `[833]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_MarriageDecision_Manus == true)"*)

### Węzeł `[832]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_MarriageDecision_Manus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Player_Romus: ""Nonsense. You're her fiance. I don't want you keeping se..."*)

### Węzeł `[833]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_MarriageDecision_Manus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[834]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nonsense. You're her fiance. I don't want you keeping secrets from her.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_MarriageDecision_Manus"] == true`
- **Kontekst wejściowy (poprzednik):** `[828]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[836]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Involve_Vina = true; RiziaDLCSupport.Jour..."*)

### Węzeł `[835]`
Mówca: **Manus Sazon**
> ""Yes, you're right. I'll tell her as soon as I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Manus Sazon: ""I will reach out to you when it's time to act.""*)

### Węzeł `[836]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Involve_Vina = true;
RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Involve_Vina"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_ReformManus_IncludeVina"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]` (*Manus Sazon: ""Yes, you're right. I'll tell her as soon as I can.""*)

### Węzeł `[837]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Admit it. You're worried she's going to fall for Adarfo.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Kontekst wejściowy (poprzednik):** `[828]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]` (*Manus Sazon: ""What? No!""*)

### Węzeł `[838]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Reform_Movem..."*)
  - -> `[840]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Reform_Mov..."*)

### Węzeł `[839]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]` (*Player_Romus: ""Admit it. You're worried she's going to fall for Adarfo.""*)

### Węzeł `[840]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == false && RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == false  and  Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[841]`
Mówca: **Manus Sazon**
> ""What? No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]` (*Manus Sazon: ""In any case...""*)

### Węzeł `[842]`
Mówca: **Manus Sazon**
> ""In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Manus Sazon: ""I will reach out to you when it's time to act.""*)

### Węzeł `[843]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may be right. I don't want to put my daughter in danger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[828]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]` (*Narrator: "He nodded."*)

### Węzeł `[844]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]` (*Manus Sazon: ""She'll be told when the time is right.""*)

### Węzeł `[845]`
Mówca: **Manus Sazon**
> ""She'll be told when the time is right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]` (*Manus Sazon: ""In any case...""*)

### Węzeł `[846]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_Legislative_Unicameral"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[847]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Path = false;
RiziaDLC.Reform_Path_Cancelled = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_Path"] = false;
Variable["RiziaDLC.Reform_Path_Cancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Manus Sazon: ""Thank you for the meeting, Your Majesty.""*)

### Węzeł `[848]`
Mówca: **Manus Sazon**
> ""In the meantime, please be careful of what information you share in front of the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]` (*Manus Sazon: ""We wouldn't want Captain Gordion to leak anything to the..."*)

### Węzeł `[849]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Diplomatic == true"*)
  - -> `[851]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Diplomatic == true)"*)

### Węzeł `[850]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Diplomatic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]` (*Manus Sazon: ""In the meantime, please be careful of what information y..."*)

### Węzeł `[851]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Diplomatic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]` (*Manus Sazon: ""Please be careful of what information you share in front..."*)

### Węzeł `[852]`
Mówca: **Manus Sazon**
> ""We wouldn't want Captain Gordion to leak anything to the nobility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[853]`
Mówca: **Manus Sazon**
> ""Please be careful of what information you share in front of the Golden Guard, Your Majesty. They can turn into a threat if we're not careful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]` (*Manus Sazon: ""We wouldn't want Captain Gordion to leak anything to the..."*)

### Węzeł `[854]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[856]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[855]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]` (*Manus Sazon: ""After all, we have a parliament majority, the House Spea..."*)

### Węzeł `[856]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Manus Sazon: ""After all, we have a parliament majority, I have legitim..."*)

### Węzeł `[857]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority, the House Speaker is from the RPP and a growing movement is uniting behind us. If you command the respect of the nobility as you say, this should be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Manus Sazon: ""What do you say, Your Majesty?""*)

### Węzeł `[858]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Movement_Leader_Adarfo == true"*)
  - -> `[860]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)"*)

### Węzeł `[859]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Movement_Leader_Adarfo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Manus Sazon: ""After all, we have a parliament majority and the House S..."*)

### Węzeł `[860]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Movement_Leader_Adarfo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Movement_Leader_Adarfo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Manus Sazon: ""After all, we have a parliament majority and I have legi..."*)

### Węzeł `[861]`
Mówca: **Manus Sazon**
> ""After all, we have a parliament majority and the House Speaker is from the RPP. If you command the respect of the nobility as you say, this should be easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Manus Sazon: ""What do you say, Your Majesty?""*)

### Węzeł `[862]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course, these nobles will serve in an advisory capacity only. It will be a kind of inverse of the old system.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[655]` (Manus Sazon), `[656]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Advisory = true"*)

### Węzeł `[863]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'll give them the ability to provide some checks on the lower house, but their power will still be limited.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[655]` (Manus Sazon), `[656]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Limited = true"*)

### Węzeł `[864]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This upper house will have equal power to the lower house. I'd like to hear the nobility complain about that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[655]` (Manus Sazon), `[656]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_UpperHouse_Equal = true"*)

### Węzeł `[865]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Advisory = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Advisory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[866]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Limited = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Limited"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[867]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_UpperHouse_Equal = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Reform_UpperHouse_Equal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[868]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Conspiring to bring democracy to the Kingdom", "Wine Cellar", "Palace Rezna");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Conspiring to bring democracy to the Kingdom","Wine Cellar","Palace Rezna");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ByThePeople", "R_ByThePeople_Loop");"*)

### Węzeł `[869]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Reform_Intention_PM_Daria = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Reform_Intention_PM_Daria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "//"*)
