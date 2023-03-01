@echo off

cls
echo User Name: %username%
echo -----------------------------

echo Disk Info:
wmic diskdrive get MediaType, Model, Caption /format:table
echo -----------------------------


echo Special Folders:
setlocal enabledelayedexpansion

	set "_Key_HKCU_Path=HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\User Shell Folders"
	set "_Folders_Refer={374DE290-123F-4565-9164-39C4925E467B},Documments,Desktop,Favorites,My Music,My Pictures,My Video,Personal,Programs,Start Menu,Startup"

	(for %%i in ("!_Folders_Refer:,=","!")do call :^) %%~i) && endlocal && goto :EOF

	:^)
	for /f tokens^=3* %%i in ('%__APPDIR__%reg.exe query "!_Key_HKCU_Path!"^|find/i "%~1"
	')do <con: set "_user_path=%%i%%j" && cmd /v/c "echo\!_user_path:REG_EXPAND_SZ=! && exit /b"

endlocal