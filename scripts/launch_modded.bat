@echo off
set GAME_DIR=H:\SteamLibrary\steamapps\common\Suzerain

echo ========================================================
echo [LAUNCHER] Switching Suzerain to MODDED Mode: Great Zille
echo ========================================================

REM Enable MelonLoader
if exist "%GAME_DIR%\version.dll.disabled" (
    echo Enabling MelonLoader...
    ren "%GAME_DIR%\version.dll.disabled" "version.dll"
)

REM Enable BepInEx if present
if exist "%GAME_DIR%\winhttp.dll.disabled" (
    echo Enabling Doorstop...
    ren "%GAME_DIR%\winhttp.dll.disabled" "winhttp.dll"
)

if exist "%GAME_DIR%\doorstop_config.ini" (
    powershell -Command "(Get-Content '%GAME_DIR%\doorstop_config.ini') -replace 'enabled=false', 'enabled=true' | Set-Content '%GAME_DIR%\doorstop_config.ini'"
)

echo [LAUNCHER] Starting modded Suzerain...
start "" "%GAME_DIR%\Suzerain.exe"
