using System;
using System.Reflection;
using HarmonyLib;
using MelonLoader;

namespace GreatZilleSolution
{
    public static class DialogueHelper
    {
        private static Type _dialogueLuaType;
        private static Type _dialogueManagerType;
        private static MethodInfo _getVarMethod;
        private static MethodInfo _setVarMethod;
        private static MethodInfo _showAlertMethod;
        private static PropertyInfo _lastConvStartedProp;

        static DialogueHelper()
        {
            Init();
        }

        public static void Init()
        {
            try
            {
                _dialogueLuaType = AccessTools.TypeByName("PixelCrushers.DialogueSystem.DialogueLua");
                _dialogueManagerType = AccessTools.TypeByName("PixelCrushers.DialogueSystem.DialogueManager");

                if (_dialogueLuaType != null)
                {
                    _getVarMethod = AccessTools.Method(_dialogueLuaType, "GetVariable", new Type[] { typeof(string) });
                    _setVarMethod = AccessTools.Method(_dialogueLuaType, "SetVariable", new Type[] { typeof(string), typeof(object) });
                }

                if (_dialogueManagerType != null)
                {
                    _showAlertMethod = AccessTools.Method(_dialogueManagerType, "ShowAlert", new Type[] { typeof(string) });
                    _lastConvStartedProp = AccessTools.Property(_dialogueManagerType, "lastConversationStarted");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Warning($"[DialogueHelper] Init error: {ex.Message}");
            }
        }

        public static string GetCurrentConversationTitle()
        {
            try
            {
                if (_lastConvStartedProp != null)
                {
                    return _lastConvStartedProp.GetValue(null) as string;
                }
            }
            catch { }
            return null;
        }

        public static void ShowAlert(string message)
        {
            try
            {
                if (_showAlertMethod != null)
                {
                    _showAlertMethod.Invoke(null, new object[] { message });
                }
                else
                {
                    MelonLogger.Msg($"[ALERT] {message}");
                }
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
                if (_setVarMethod != null)
                {
                    _setVarMethod.Invoke(null, new object[] { name, value });
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
                if (_getVarMethod != null)
                {
                    object result = _getVarMethod.Invoke(null, new object[] { name });
                    if (result != null)
                    {
                        var prop = result.GetType().GetProperty("asBool") ?? result.GetType().GetProperty("AsBool");
                        if (prop != null)
                        {
                            return (bool)prop.GetValue(result);
                        }
                    }
                }
            }
            catch { }
            return false;
        }

        public static int GetIntVariable(string name)
        {
            try
            {
                if (_getVarMethod != null)
                {
                    object result = _getVarMethod.Invoke(null, new object[] { name });
                    if (result != null)
                    {
                        var prop = result.GetType().GetProperty("asInt") ?? result.GetType().GetProperty("AsInt");
                        if (prop != null)
                        {
                            return (int)prop.GetValue(result);
                        }
                    }
                }
            }
            catch { }
            return 0;
        }
    }
}
