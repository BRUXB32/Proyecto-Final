#!/bin/bash
clear
############ Cambios necesarios antes de iniciar el script ############

#Cambio el mensaje de "select"
PS3="Ingrese una opción: "

while [[ true ]]; do
  echo -e "Menú principal del sistema\n"
    select opcion in "Usuarios conectados actualmente" "Volver"
  do
    case $REPLY in
      1)clear
      w
      echo ""
      read -p "Ingrese ENTER para volver" noVal
      clear
      break
      ;;
      2)
      exit
      ;;
      *)clear
      echo "Opción incorrecta"
      sleep 1
      clear
      break
      ;;
    esac
  done
done
