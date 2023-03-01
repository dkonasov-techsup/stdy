@echo off
chcp 65001

cls 
echo Укажите путь к каталогу в формате: Диск:\каталог\..
set /p Path="Path: "
echo "%Path%"

dir %Path%