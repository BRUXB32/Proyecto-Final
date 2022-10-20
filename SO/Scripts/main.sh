#!/bin/bash
clear
############ Cambios necesarios antes de iniciar el script ############

#Agrego permisos de ejecicción al resto de scripts
chmod u+x admMain.sh
chmod u+x admBd.sh

#Cambio el mensaje de "select"
PS3="Ingrese una opción: "

while [[ true ]]; do
  echo -e "Menú principal del sistema\n"
    select opcion in "Menú de administración de usuario" "Menú de administración de BD" "Menú de testeo de red y servicios" "Menú de acceso al servidor" "Menú de monitoreo"  "Salir"
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
      ./testRed.sh
      clear
      break
      ;;
      4)
      ./accesoServidor.sh
      clear
      break
      ;;
      5)
      nmon
      clear
      break
      ;;
      6)
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
