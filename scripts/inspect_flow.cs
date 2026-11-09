using System;
using System.IO;
using System.Linq;
using AsmResolver.DotNet;

class Program
{
    static void Main(string[] args)
    {
        string asmPath = @"C:\Program Files (x86)\Steam\steamapps\common\Suzerain\MelonLoader\Il2CppAssemblies\Assembly-CSharp.dll";
        var module = ModuleDefinition.FromFile(asmPath);

        var ut = module.GetAllTypes().FirstOrDefault(t => t.Name == "WarUnitTypeData");
        if (ut != null)
        {
            Console.WriteLine("WarUnitTypeData fields & props:");
            foreach (var f in ut.Fields) Console.WriteLine("  field: " + f.Name);
            foreach (var m in ut.Methods) if (m.Name.Contains("Org") || m.Name.Contains("Health") || m.Name.Contains("get_")) Console.WriteLine("  prop: " + m.Name);
        }
    }
}
