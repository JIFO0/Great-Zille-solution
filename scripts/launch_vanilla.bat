@echo off
set GAME_DIR=H:\SteamLibrary\steamapps\common\Suzerain

echo [LAUNCHER] Preparing Vanilla launch...

if exist "%GAME_DIR%\doorstop_config.ini" (
    powershell -Command "(Get-Content '%GAME_DIR%\doorstop_config.ini') -replace 'enabled=true', 'enabled=false' | Set-Content '%GAME_DIR%\doorstop_config.ini'"
)

if exist "%GAME_DIR%\winhttp.dll" (
    if not exist "%GAME_DIR%\winhttp.dll.modded" (
        ren "%GAME_DIR%\winhttp.dll" "winhttp.dll.modded"
    )
)

echo [LAUNCHER] Starting Suzerain (Vanilla)...
start "" "%GAME_DIR%\Suzerain.exe"
