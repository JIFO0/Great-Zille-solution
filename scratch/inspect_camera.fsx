open System
open System.Reflection

let asm = Assembly.LoadFrom(@"H:\SteamLibrary\steamapps\common\Suzerain\MelonLoader\Il2CppAssemblies\Assembly-CSharp.dll")
for t in asm.GetTypes() do
    if t.Name.Contains("Camera") then
        printfn "Camera type: %s" t.FullName
