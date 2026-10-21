@echo off
set GAME_DIR=H:\SteamLibrary\steamapps\common\Suzerain

echo [LAUNCHER] Preparing Modded launch...

if exist "%GAME_DIR%\doorstop_config.ini" (
    powershell -Command "(Get-Content '%GAME_DIR%\doorstop_config.ini') -replace 'enabled=false', 'enabled=true' | Set-Content '%GAME_DIR%\doorstop_config.ini'"
)

if exist "%GAME_DIR%\winhttp.dll.modded" (
    if not exist "%GAME_DIR%\winhttp.dll" (
        ren "%GAME_DIR%\winhttp.dll.modded" "winhttp.dll"
    )
)

echo [LAUNCHER] Starting Suzerain (Great Zille Solution Active)...
start "" "%GAME_DIR%\Suzerain.exe"
