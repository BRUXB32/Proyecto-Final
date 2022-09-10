#!/bin/bash

############ Cambios necesarios antes de iniciar el script ############

#Agrego permisos de ejecicción al resto de scripts
chmod u+x admMain.sh
chmod u+x admBd.sh

#Cambio el mensaje de "select"
PS3="Ingrese una opción: "

while [[ true ]]; do
  echo -e "Menú principal del sistema\n"
    select opcion in "Menú de administración de usuario" "Menú de administración de BD" "Salir"
  do
    case $REPLY in
      1)
      ./admMain.sh
      clear
      break
      ;;
      2)
      ./admBd.sh
      clear
      break
      ;;
      3)
      clear
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
