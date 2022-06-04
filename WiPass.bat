@echo off

netsh wlan show profile


set /p profname="Introduce el nombre del SSID: "


netsh wlan show profile %profname% key=clear

timeout 100 > NUL

