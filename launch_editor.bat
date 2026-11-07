@echo off
chcp 65001 >nul
title Great Zille Solution - Narrative Web Editor
echo ======================================================================
echo  [GREAT ZILLE SOLUTION] Edytor Konwersacji, Eventow i Raportow (HTML)
echo  Autor: JIFO (https://jifo.dev)
echo ======================================================================
echo.
echo Uruchamianie lokalnego serwera edytora na porcie 5050...
echo Otwieranie przegladarki: http://localhost:5050
echo.

start "" "http://localhost:5050"
python editor\server.py

pause
