#!/bin/bash
clear

############ Cambios necesarios antes de iniciar el script ############

#Cambio el mensaje de "select"
PS3="Ingrese una opción: "
############ Funciones del script ################
function testServicios() {
  while [[ true ]]; do
    echo -e "Monitoreo de servicios\n"
      select opcion in "MariaDB" "Zabbix" "ClamAV" "Volver"
    do
      case $REPLY in
        1)clear
        systemctl status mariadb
        clear
        break
        ;;
        2)clear
        systemctl status zabbix
        clear
        break
        ;;
        3)clear
        systemctl status clamav
        clear
        break
        ;;
        4)clear
        return 0
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
}
############ Menú principal ############
while [[ true ]]; do
  echo -e "Menú de testeo de red y servicios\n"
    select opcion in "Testeo de red" "Funcionamiento de servicios" "Volver"
  do
    case $REPLY in
      1)clear
      ping -c 4 google.com && echo -e "\nHay conexión a internet" || echo -e "\nNo hay conexión a internet"

      echo ""

      read -p "Ingrese ENTER para volver" noVal
      clear
      break
      ;;
      2)clear
      testServicios
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
