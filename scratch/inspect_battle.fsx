open System
open System.Reflection

let asm = Assembly.LoadFrom(@"H:\SteamLibrary\steamapps\common\Suzerain\MelonLoader\Il2CppAssemblies\Assembly-CSharp.dll")
let tBattle = asm.GetType("Il2Cpp.WarBattleManager")
if tBattle <> null then
    printfn "Methods in WarBattleManager:"
    for m in tBattle.GetMethods(BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.Instance ||| BindingFlags.Static) do
        printfn "  %s" m.Name
