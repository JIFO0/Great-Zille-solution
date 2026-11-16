using System;
using System.Linq;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Signatures;

class Program
{
    static void Main(string[] args)
    {
        string path = @"H:\SteamLibrary\steamapps\common\Suzerain\MelonLoader\Il2CppAssemblies\Assembly-CSharp.dll";
        var module = ModuleDefinition.FromFile(path);
        
        var panelType = module.TopLevelTypes.FirstOrDefault(x => x.Name == "WarDeploymentPanel");
        if (panelType != null)
        {
            var setupMethod = panelType.Methods.FirstOrDefault(m => m.Name == "Setup");
            if (setupMethod != null && setupMethod.CilMethodBody != null)
            {
                Console.WriteLine("=== WarDeploymentPanel.Setup CIL ===");
                foreach (var instr in setupMethod.CilMethodBody.Instructions)
                {
                    Console.WriteLine($"  {instr.OpCode} {instr.Operand}");
                }
            }
        }
    }
}
