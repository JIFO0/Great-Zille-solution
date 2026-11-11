using System;
using MelonLoader;
using Il2CppPixelCrushers.DialogueSystem;

namespace GreatZilleSolution
{
    public static class DialogueHelper
    {
        public static void Init()
        {
            MelonLogger.Msg("[DialogueHelper] Dialogue subsystem ready.");
        }

        public static string GetCurrentConversationTitle()
        {
            try
            {
                return DialogueManager.lastConversationStarted;
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[DialogueHelper] GetCurrentConversationTitle failed: {ex.Message}");
                return null;
            }
        }

        public static void ShowAlert(string message)
        {
            try
            {
                DialogueManager.ShowAlert(message);
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[DialogueHelper] ShowAlert failed: {ex.Message}");
            }
        }

        public static void SetVariable(string name, object value)
        {
            try
            {
                if (value is bool b)
                {
                    Lua.Run($"Variable[\"{name}\"] = {(b ? "true" : "false")};");
                }
                else if (value is int i)
                {
                    Lua.Run($"Variable[\"{name}\"] = {i};");
                }
                else if (value is string s)
                {
                    string escaped = s.Replace("\\", "\\\\").Replace("\"", "\\\"");
                    Lua.Run($"Variable[\"{name}\"] = \"{escaped}\";");
                }
                else if (value != null)
                {
                    Lua.Run($"Variable[\"{name}\"] = {value};");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[DialogueHelper] SetVariable '{name}' failed: {ex.Message}");
            }
        }

        public static bool GetBoolVariable(string name)
        {
            try
            {
                var v = DialogueLua.GetVariable(name);
                if (v != null && v.asBool) return true;
                if (!name.StartsWith("RiziaDLC.", StringComparison.OrdinalIgnoreCase))
                {
                    var v2 = DialogueLua.GetVariable("RiziaDLC." + name);
                    if (v2 != null && v2.asBool) return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static int GetIntVariable(string name)
        {
            try
            {
                var v = DialogueLua.GetVariable(name);
                if (v != null && v.asInt != 0) return v.asInt;
                if (!name.StartsWith("RiziaDLC.", StringComparison.OrdinalIgnoreCase))
                {
                    var v2 = DialogueLua.GetVariable("RiziaDLC." + name);
                    if (v2 != null && v2.asInt != 0) return v2.asInt;
                }
                return v != null ? v.asInt : 0;
            }
            catch
            {
                return 0;
            }
        }

        public static string GetStringVariable(string name)
        {
            try
            {
                return DialogueLua.GetVariable(name).asString ?? "";
            }
            catch
            {
                return "";
            }
        }
    }
}
