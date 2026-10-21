@echo off
set GAME_DIR=H:\SteamLibrary\steamapps\common\Suzerain

echo ========================================================
echo [LAUNCHER] Switching Suzerain to VANILLA Mode
echo ========================================================

REM Disable MelonLoader
if exist "%GAME_DIR%\version.dll" (
    echo Disabling MelonLoader (version.dll -> version.dll.disabled)...
    ren "%GAME_DIR%\version.dll" "version.dll.disabled"
)

REM Disable BepInEx / Doorstop
if exist "%GAME_DIR%\winhttp.dll" (
    echo Disabling Doorstop (winhttp.dll -> winhttp.dll.disabled)...
    ren "%GAME_DIR%\winhttp.dll" "winhttp.dll.disabled"
)
if exist "%GAME_DIR%\doorstop_config.ini" (
    powershell -Command "(Get-Content '%GAME_DIR%\doorstop_config.ini') -replace 'enabled=true', 'enabled=false' | Set-Content '%GAME_DIR%\doorstop_config.ini'"
)

echo [LAUNCHER] Starting vanilla Suzerain...
start "" "%GAME_DIR%\Suzerain.exe"
