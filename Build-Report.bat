@echo off
:: Sæt terminalen til UTF-8 for at understøtte emojis og æøå
chcp 65001 >nul

title Bygger Typst Rapport...
echo =======================================================
echo  🚀 Starter Obsidian til Typst bygge-motoren...
echo =======================================================
echo.

:: Kald det nye PowerShell-script direkte med Bypass så Windows ikke blokerer det
powershell -NoProfile -ExecutionPolicy Bypass -File "%~dp0build.ps1"

echo.
echo =======================================================
echo  Tryk på en vilkårlig tast for at lukke vinduet...
echo =======================================================
pause >nul