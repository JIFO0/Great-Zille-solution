open System
open System.Reflection

let asm = Assembly.LoadFrom(@"H:\SteamLibrary\steamapps\common\Suzerain\MelonLoader\Il2CppAssemblies\Assembly-CSharp.dll")
for typeName in [ "Il2Cpp.CameraManager"; "Il2Cpp.MapCamera" ] do
    let t = asm.GetType(typeName)
    if t <> null then
        printfn "Methods in %s:" typeName
        for m in t.GetMethods(BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.Instance ||| BindingFlags.Static) do
            printfn "  %s" m.Name
