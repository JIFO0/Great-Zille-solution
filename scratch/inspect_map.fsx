open System
open System.Reflection

let asm = Assembly.LoadFrom(@"H:\SteamLibrary\steamapps\common\Suzerain\MelonLoader\Il2CppAssemblies\Assembly-CSharp.dll")
let tMap = asm.GetType("Il2Cpp.MapManager")
if tMap <> null then
    printfn "Methods in MapManager:"
    for m in tMap.GetMethods(BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.Instance ||| BindingFlags.Static) do
        printfn "  %s" m.Name
