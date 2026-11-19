# scripts/create_start_menu_shortcut.ps1
$WshShell = New-Object -ComObject WScript.Shell
$programsFolder = [System.IO.Path]::Combine([Environment]::GetFolderPath('StartMenu'), 'Programs')
$shortcutPath = Join-Path $programsFolder "Launch Modded Suzerain (Great Zille).lnk"

. "$PSScriptRoot\detect_game.ps1"
$gameDir = Find-Suzerain

$shortcut = $WshShell.CreateShortcut($shortcutPath)
$shortcut.TargetPath = (Join-Path $PSScriptRoot "launch_modded.bat")
$shortcut.WorkingDirectory = $PSScriptRoot
$shortcut.Description = "Launch Suzerain with Great Zille Solution Mod"

$modIcon = Join-Path $PSScriptRoot "..\assets\branding\great_zille.ico"
if (Test-Path $modIcon) {
    # Great Zille mod logo
    $shortcut.IconLocation = (Resolve-Path $modIcon).Path
} elseif ($gameDir -and (Test-Path (Join-Path $gameDir "Suzerain.exe"))) {
    $shortcut.IconLocation = "$gameDir\Suzerain.exe,0"
}

$shortcut.Save()
Write-Host "SHORTCUT_CREATED: $shortcutPath"
