#!/bin/bash
clear
############ Cambios necesarios antes de iniciar el script ############

Cambio el mensaje de "select"
PS3="Ingrese una opción: "

while [[ true ]]; do
  echo -e "Menú de respaldos\n"
    select opcion in "Respaldo completo" "Volver"
  do
    case $REPLY in
      1)clear
      fecha=$(date +%Y-%m-%d-%H.%M.%S)

      mysqldump -u root -prtBd1234. kefruta > /backupbd/respaldo-"$fecha".sql
      tar -cvf /var/log/mariadb/* /backupbd/respaldo-binario-"$fecha"
      read -p "asd" NaN
      rsync -aAXv --exclude={/dev/*,/usr/*,/proc/*,/sys/*,/tmp/*,/run/*,/mnt/*,/media/*,/lost+found,/backup/*,/root/*} /* /backup/respaldo-"$fecha"/
      mv /backup/respaldo-"$fecha"/* /media/respaldosKefruta
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
