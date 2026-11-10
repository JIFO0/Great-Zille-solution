open System
open System.Reflection

let asm = Assembly.LoadFrom(@"H:\SteamLibrary\steamapps\common\Suzerain\MelonLoader\Il2CppAssemblies\Assembly-CSharp.dll")
let tBattle = asm.GetType("Il2Cpp.WarBattleManager")
for m in tBattle.GetMethods(BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.Instance ||| BindingFlags.Static) do
    if m.Name = "EndBattle" || m.Name = "CalculateAndFinalizeBattle" || m.Name = "EvaluateBattleCoroutine" then
        printfn "Method: %s" m.Name
        let mb = m.GetMethodBody()
        if mb <> null then
            let il = mb.GetILAsByteArray()
            printfn "  IL bytes length: %d" il.Length
