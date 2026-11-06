# detect_game.ps1
function Find-Suzerain {
    param()
    # 1. Direct candidates
    $candidates = @(
        'C:\Program Files (x86)\Steam\steamapps\common\Suzerain',
        'H:\SteamLibrary\steamapps\common\Suzerain',
        'D:\SteamLibrary\steamapps\common\Suzerain',
        'E:\SteamLibrary\steamapps\common\Suzerain',
        'F:\SteamLibrary\steamapps\common\Suzerain',
        'G:\SteamLibrary\steamapps\common\Suzerain',
        'C:\SteamLibrary\steamapps\common\Suzerain'
    )
    foreach ($c in $candidates) {
        if (Test-Path -Path (Join-Path $c 'Suzerain.exe')) {
            return $c
        }
    }

    # 2. Check Steam Registry
    $regPaths = @(
        'HKCU:\Software\Valve\Steam',
        'HKLM:\SOFTWARE\WOW6432Node\Valve\Steam',
        'HKLM:\SOFTWARE\Valve\Steam'
    )
    foreach ($rp in $regPaths) {
        if (Test-Path $rp) {
            $sp = (Get-ItemProperty -Path $rp -ErrorAction SilentlyContinue).SteamPath
            if (-not $sp) {
                $sp = (Get-ItemProperty -Path $rp -ErrorAction SilentlyContinue).InstallPath
            }
            if ($sp) {
                $direct = Join-Path $sp 'steamapps\common\Suzerain'
                if (Test-Path (Join-Path $direct 'Suzerain.exe')) { return $direct }

                $vdf = Join-Path $sp 'steamapps\libraryfolders.vdf'
                if (Test-Path $vdf) {
                    $lines = Get-Content $vdf
                    foreach ($line in $lines) {
                        if ($line -match '"path"\s+"([^"]+)"') {
                            $libPath = $matches[1] -replace '\\\\', '\'
                            $gameInLib = Join-Path $libPath 'steamapps\common\Suzerain'
                            if (Test-Path (Join-Path $gameInLib 'Suzerain.exe')) {
                                return $gameInLib
                            }
                        }
                    }
                }
            }
        }
    }
    return $null
}

$found = Find-Suzerain
Write-Host "FOUND: $found"
