using System;
using System.IO;
using System.Runtime.InteropServices;
using MelonLoader;
using UnityEngine;

namespace GreatZilleSolution
{
    /// <summary>
    /// Great Zille mod logo (branding/ in the repo, Mods/GreatZilleAssets/branding in the game).
    /// - draws the ribbon logo on the Suzerain main menu,
    /// - exposes a small icon for the mod's own windows/status bar,
    /// - on Windows sets the game window / taskbar icon to great_zille.ico.
    /// Everything is optional: if a file is missing nothing is drawn and the mod keeps working.
    /// IMGUI only (rects, no GUILayout), same as the rest of the mod UI.
    /// </summary>
    public static class ZilleBranding
    {
        private const string LogoFile = "great_zille_logo_ribbon_512.png"; // main menu (with ribbon)
        private const string IconFile = "great_zille_logo_64.png";         // small icon (no text)
        private const string IcoFile = "great_zille.ico";                  // Windows window icon

        private static Texture2D _logo;
        private static Texture2D _icon;
        private static bool _loadTried;
        private static bool _windowIconTried;
        private static bool _inMainMenu;

        /// <summary>Folder with the branding files (next to the other mod assets).</summary>
        private static string BrandingDir
        {
            get
            {
                string baseDir = ZilleMapLayoutManager.AssetsDir;
                return string.IsNullOrEmpty(baseDir) ? "" : Path.Combine(baseDir, "branding");
            }
        }

        public static Texture2D Icon { get { EnsureLoaded(); return _icon; } }

        /// <summary>Called from Core.OnSceneWasLoaded once the game scene (and DirectX) is up.</summary>
        public static void OnSceneLoaded(string sceneName)
        {
            _inMainMenu = string.Equals(sceneName, "Main Menu", StringComparison.OrdinalIgnoreCase);
            EnsureLoaded();
            if (_inMainMenu) TrySetWindowIcon();
        }

        private static void EnsureLoaded()
        {
            if (_loadTried) return;
            string dir = BrandingDir;
            if (string.IsNullOrEmpty(dir)) return; // asset dir not resolved yet, try again later
            _loadTried = true;
            try
            {
                _logo = LoadIfExists(Path.Combine(dir, LogoFile));
                _icon = LoadIfExists(Path.Combine(dir, IconFile));
                if (_logo == null && _icon == null)
                    MelonLogger.Warning("[ZilleBranding] No logo files found in " + dir + " (branding is optional).");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZilleBranding] Load failed: " + ex.Message);
            }
        }

        private static Texture2D LoadIfExists(string path)
        {
            return File.Exists(path) ? ZilleMapLayoutManager.LoadTextureFromFile(path) : null;
        }

        /// <summary>Draws the mod logo in the bottom-right corner of the Suzerain main menu.</summary>
        public static void DrawMainMenuLogo()
        {
            if (!_inMainMenu) return;
            EnsureLoaded();
            if (_logo == null) return;
            float size = Mathf.Clamp(Screen.height * 0.24f, 120f, 256f);
            float margin = 24f;
            var rect = new Rect(Screen.width - size - margin, Screen.height - size - margin, size, size);
            Color prev = GUI.color;
            GUI.color = new Color(1f, 1f, 1f, 0.95f);
            GUI.DrawTexture(rect, _logo);
            GUI.color = prev;
        }

        /// <summary>Draws the small (no text) logo into a square rect, e.g. next to a status bar or window title.</summary>
        public static void DrawIcon(Rect rect)
        {
            EnsureLoaded();
            if (_icon == null) return;
            Color prev = GUI.color;
            GUI.color = Color.white;
            GUI.DrawTexture(rect, _icon);
            GUI.color = prev;
        }

        // ------------------------------------------------------------------ window / taskbar icon (Windows only)
        [DllImport("user32.dll")] private static extern IntPtr GetActiveWindow();
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr LoadImageW(IntPtr hInst, string name, uint type, int cx, int cy, uint fuLoad);
        [DllImport("user32.dll")] private static extern IntPtr SendMessageW(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")] private static extern int GetSystemMetrics(int index);

        private static void TrySetWindowIcon()
        {
            if (_windowIconTried) return;
            _windowIconTried = true;
            try
            {
                if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
                string dir = BrandingDir;
                if (string.IsNullOrEmpty(dir)) return;
                string ico = Path.Combine(dir, IcoFile);
                if (!File.Exists(ico)) return;

                IntPtr hwnd = GetActiveWindow();
                if (hwnd == IntPtr.Zero) return;

                const uint IMAGE_ICON = 1, LR_LOADFROMFILE = 0x10;
                const uint WM_SETICON = 0x80;
                const int SM_CXICON = 11, SM_CXSMICON = 49;
                int big = GetSystemMetrics(SM_CXICON);
                int small = GetSystemMetrics(SM_CXSMICON);
                IntPtr hBig = LoadImageW(IntPtr.Zero, ico, IMAGE_ICON, big, big, LR_LOADFROMFILE);
                IntPtr hSmall = LoadImageW(IntPtr.Zero, ico, IMAGE_ICON, small, small, LR_LOADFROMFILE);
                if (hBig != IntPtr.Zero) SendMessageW(hwnd, WM_SETICON, (IntPtr)1, hBig);   // ICON_BIG (taskbar / Alt+Tab)
                if (hSmall != IntPtr.Zero) SendMessageW(hwnd, WM_SETICON, IntPtr.Zero, hSmall); // ICON_SMALL (title bar)
                MelonLogger.Msg("[ZilleBranding] Window icon set.");
            }
            catch (Exception ex)
            {
                MelonLogger.Warning("[ZilleBranding] Window icon skipped: " + ex.Message);
            }
        }
    }
}
