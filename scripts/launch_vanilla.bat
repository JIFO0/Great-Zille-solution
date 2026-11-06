@echo off
setlocal enabledelayedexpansion

echo ========================================================
echo [LAUNCHER] Switching Suzerain to VANILLA Mode
echo ========================================================

REM 1. Auto-detect Game Directory
set "GAME_DIR="

if exist "%~dp0..\..\Suzerain.exe" set "GAME_DIR=%~dp0..\.."
if not defined GAME_DIR if exist "C:\Program Files (x86)\Steam\steamapps\common\Suzerain\Suzerain.exe" set "GAME_DIR=C:\Program Files (x86)\Steam\steamapps\common\Suzerain"
if not defined GAME_DIR if exist "H:\SteamLibrary\steamapps\common\Suzerain\Suzerain.exe" set "GAME_DIR=H:\SteamLibrary\steamapps\common\Suzerain"
if not defined GAME_DIR if exist "D:\SteamLibrary\steamapps\common\Suzerain\Suzerain.exe" set "GAME_DIR=D:\SteamLibrary\steamapps\common\Suzerain"
if not defined GAME_DIR if exist "E:\SteamLibrary\steamapps\common\Suzerain\Suzerain.exe" set "GAME_DIR=E:\SteamLibrary\steamapps\common\Suzerain"
if not defined GAME_DIR if exist "F:\SteamLibrary\steamapps\common\Suzerain\Suzerain.exe" set "GAME_DIR=F:\SteamLibrary\steamapps\common\Suzerain"
if not defined GAME_DIR if exist "C:\SteamLibrary\steamapps\common\Suzerain\Suzerain.exe" set "GAME_DIR=C:\SteamLibrary\steamapps\common\Suzerain"

if not defined GAME_DIR (
    for /f "usebackq delims=" %%I in (`powershell -NoProfile -ExecutionPolicy Bypass -File "%~dp0detect_game.ps1"`) do (
        set "LINE=%%I"
        if "!LINE:~0,6!"=="FOUND:" (
            set "GAME_DIR=!LINE:~7!"
        )
    )
)

if not defined GAME_DIR (
    echo [ERROR] Could not find Suzerain installation directory!
    pause
    exit /b 1
)

echo [LAUNCHER] Found game directory: %GAME_DIR%

REM 2. Disable MelonLoader
if exist "%GAME_DIR%\version.dll" (
    echo Disabling MelonLoader...
    ren "%GAME_DIR%\version.dll" "version.dll.disabled"
)

REM Disable Doorstop / BepInEx if present
if exist "%GAME_DIR%\winhttp.dll" (
    echo Disabling Doorstop...
    ren "%GAME_DIR%\winhttp.dll" "winhttp.dll.disabled"
)

if exist "%GAME_DIR%\doorstop_config.ini" (
    powershell -NoProfile -Command "(Get-Content '%GAME_DIR%\doorstop_config.ini') -replace 'enabled=true', 'enabled=false' | Set-Content '%GAME_DIR%\doorstop_config.ini'"
)

echo [LAUNCHER] Starting vanilla Suzerain...
start "" "%GAME_DIR%\Suzerain.exe"
