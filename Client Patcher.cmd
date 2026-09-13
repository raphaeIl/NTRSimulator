@echo off
where py >nul 2>nul
if %errorlevel% equ 0 (
    py -3 "%~dp0client-patcher\launcher.py"
) else (
    python "%~dp0client-patcher\launcher.py"
)
if errorlevel 1 (
    echo The patcher needs Python 3.11 or newer with Tkinter from python.org.
    pause
)
