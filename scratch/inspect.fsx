open System
open System.Reflection

let asm = Assembly.LoadFrom(@"H:\SteamLibrary\steamapps\common\Suzerain\MelonLoader\Il2CppAssemblies\Assembly-CSharp.dll")
for t in asm.GetTypes() do
    if t.Name.Contains("WarTileRaycaster") then
        printfn "Found type: %s" t.FullName
        for m in t.GetMembers(BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.Instance ||| BindingFlags.Static) do
            printfn "  %s %s" (m.MemberType.ToString()) m.Name
