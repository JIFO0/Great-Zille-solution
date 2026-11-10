open System
open System.Reflection

let asm = Assembly.LoadFrom(@"H:\SteamLibrary\steamapps\common\Suzerain\MelonLoader\Il2CppAssemblies\Assembly-CSharp.dll")
let tWarFlow = asm.GetType("Il2Cpp.WarFlowManager")
if tWarFlow <> null then
    printfn "Methods in WarFlowManager:"
    for m in tWarFlow.GetMethods(BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.Instance ||| BindingFlags.Static) do
        printfn "  %s" m.Name
