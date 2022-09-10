#!/bin/bash

chmod u+x admMain.sh

PS3="Ingrese una opción: "

while [[ true ]]; do
  echo -e "Menú principal del sistema\n"
    select opcion in "Menú de administración de usuario" "Salir"
  do
    case $REPLY in
      1)
      ./admMain.sh
      clear
      break
      ;;
      2)clear
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
