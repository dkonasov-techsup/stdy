@echo off

cls
echo Computer Name: %computername%
echo -----------------------------

echo Disk Info:
wmic diskdrive get * /format:list
echo -----------------------------

echo System Verion: 
ver

