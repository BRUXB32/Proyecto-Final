#!/bin/bash
clear
ping -c 4 google.com && echo -e "\nHay conexión a internet" || echo -e "\nNo hay conexión a internet"

echo ""

read -p "Ingrese ENTER para volver" noVal
