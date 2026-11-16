@echo off
chcp 65001 >nul
title Great Zille Solution - Narrative Web Editor
echo Uruchamianie lokalnego serwera edytora na porcie 5050...
start "" "http://localhost:5050"
python server.py
pause
