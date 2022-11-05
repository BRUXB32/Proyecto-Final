#!/bin/bash
clear
############ Cambios necesarios antes de iniciar el script ############

Cambio el mensaje de "select"
PS3="Ingrese una opción: "

while [[ true ]]; do
  echo -e "Menú de respaldos\n"
    select opcion in "Listar inicios del sistema" "Auditoria reciente" "Volver"
  do
    case $REPLY in
      1)clear
      journalctl --list-boots
      clear
      break
      ;;
      2)clear
      journalctl -b
      clear
      break
      3)
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
