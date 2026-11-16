# scripts/deploy_mod.ps1
$ErrorActionPreference = "Stop"

. "$PSScriptRoot\detect_game.ps1"
$gameDir = Find-Suzerain

if (-not $gameDir -or -not (Test-Path $gameDir)) {
    Write-Error "Nie znaleziono katalogu gry Suzerain!"
    exit 1
}

Write-Host "[DEPLOY] Znaleziono katalog gry: $gameDir"

# Ensure Mods folder exists
$modsDir = Join-Path $gameDir "Mods"
if (-not (Test-Path $modsDir)) {
    New-Item -ItemType Directory -Path $modsDir -Force | Out-Null
}

# 1. Copy DLL (prefer newer between Release and Debug)
$dllRel = Join-Path $PSScriptRoot "..\src\GreatZilleSolution\bin\Release\GreatZilleSolution.dll"
$dllDbg = Join-Path $PSScriptRoot "..\src\GreatZilleSolution\bin\Debug\GreatZilleSolution.dll"
$dllSrc = $dllDbg
if (Test-Path $dllRel) {
    if (-not (Test-Path $dllDbg) -or (Get-Item $dllRel).LastWriteTimeUtc -gt (Get-Item $dllDbg).LastWriteTimeUtc) {
        $dllSrc = $dllRel
    }
}
if (Test-Path $dllSrc) {
    Copy-Item -Path $dllSrc -Destination (Join-Path $modsDir "GreatZilleSolution.dll") -Force
    Write-Host "[DEPLOY] Skopiowano GreatZilleSolution.dll (z $dllSrc) do $modsDir"
} else {
    Write-Warning "[DEPLOY] Brak skompilowanego DLL!"
}

# 2. Copy GreatZilleAssets
$assetsDest = Join-Path $modsDir "GreatZilleAssets"
if (-not (Test-Path $assetsDest)) {
    New-Item -ItemType Directory -Path $assetsDest -Force | Out-Null
}

$assetsSrc = Join-Path $PSScriptRoot "..\assets"
if (Test-Path $assetsSrc) {
    Copy-Item -Path "$assetsSrc\*" -Destination $assetsDest -Recurse -Force
    Write-Host "[DEPLOY] Zsynchronizowano zasoby (tekstury, mapy, regiony, layout) do $assetsDest"
}

# 3. Deploy Patched Il2CppAssemblyGenerator (bypasses dumper when assemblies exist)
$genFixSrc = Join-Path $PSScriptRoot "ml_fixes\Il2CppAssemblyGenerator.dll"
$il2cppGenDir = Join-Path $gameDir "MelonLoader\Dependencies\Il2CppAssemblyGenerator"
if ((Test-Path $genFixSrc) -and (Test-Path $il2cppGenDir)) {
    Copy-Item -Path $genFixSrc -Destination (Join-Path $il2cppGenDir "Il2CppAssemblyGenerator.dll") -Force
    Write-Host "[DEPLOY] Wdrożono zoptymalizowany Il2CppAssemblyGenerator.dll (weryfikacja gotowych bibliotek)"
}

# 4. Fix MelonLoader Config & GameAssemblyHash
$gaPath = Join-Path $gameDir "GameAssembly.dll"
$cfgPath = Join-Path $il2cppGenDir "Config.cfg"

if ((Test-Path $gaPath) -and (Test-Path $il2cppGenDir)) {
    try {
        $stream = [System.IO.File]::OpenRead($gaPath)
        $sha = [System.Security.Cryptography.SHA512]::Create()
        $hashBytes = $sha.ComputeHash($stream)
        $stream.Close()
        $stream.Dispose()
        $hashHex = [System.BitConverter]::ToString($hashBytes) -replace '-'

        $cfgContent = @"
[Il2CppAssemblyGenerator]
GameAssemblyHash = "$hashHex"
UnityVersion = "6000.3.9"
DumperVersion = "2022.1.0-pre-release.21"
DumperSCRSVersion = "2022.1.0-pre-release.21"
OldFiles = [ ]
"@
        [System.IO.File]::WriteAllText($cfgPath, $cfgContent)
        Write-Host "[DEPLOY] Zaktualizowano MelonLoader Config.cfg z prawidlowym GameAssemblyHash ($($hashHex.Substring(0, 16))...)"
    } catch {
        Write-Warning "[DEPLOY] Nie udalo sie obliczyc hash GameAssembly.dll: $_"
    }
}

# 5. Remove broken Cpp2IL plugin that targets .NET 9 (causes crash on .NET 6/7)
$brokenPlugin = Join-Path $gameDir "MelonLoader\Dependencies\Il2CppAssemblyGenerator\Cpp2IL\Plugins\Cpp2IL.Plugin.StrippedCodeRegSupport.dll"
if (Test-Path $brokenPlugin) {
    Remove-Item -Path $brokenPlugin -Force -ErrorAction SilentlyContinue
    Write-Host "[DEPLOY] Usunieto niekompatybilny plugin Cpp2IL.Plugin.StrippedCodeRegSupport.dll (.NET 9 conflict)"
}

# 6. Ensure MelonLoader is enabled
$verDisabled = Join-Path $gameDir "version.dll.disabled"
$verEnabled = Join-Path $gameDir "version.dll"
if (Test-Path $verDisabled) {
    Move-Item -Path $verDisabled -Destination $verEnabled -Force
    Write-Host "[DEPLOY] Wlaczono MelonLoader (version.dll)"
}

# 7. Ensure steam_appid.txt exists for direct launching
$steamAppIdPath = Join-Path $gameDir "steam_appid.txt"
if (-not (Test-Path $steamAppIdPath)) {
    [System.IO.File]::WriteAllText($steamAppIdPath, "1207650`r`n")
    Write-Host "[DEPLOY] Utworzono steam_appid.txt (AppID 1207650)"
}

Write-Host "[DEPLOY] Gotowe! Mod Great Zille jest w pelni zainstalowany i gotowy do uruchomienia."
