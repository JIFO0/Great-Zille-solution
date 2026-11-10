open System
open System.Reflection

let asm = Assembly.LoadFrom(@"H:\SteamLibrary\steamapps\common\Suzerain\MelonLoader\Il2CppAssemblies\Assembly-CSharp.dll")
let t = asm.GetType("Il2Cpp.TemplateWarObjectiveIndicator")
if t <> null then
    printfn "Type: %s" t.FullName
    for m in t.GetMembers(BindingFlags.Public ||| BindingFlags.NonPublic ||| BindingFlags.Instance ||| BindingFlags.Static) do
        printfn "  %s %s" (m.MemberType.ToString()) m.Name
