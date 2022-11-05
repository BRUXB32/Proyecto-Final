#!/bin/bash
clear
############ Cambios necesarios antes de iniciar el script ############

#Cambio el mensaje de "select"
PS3="Ingrese una opción: "

while [[ true ]]; do
  echo -e "Menú de respaldos\n"
    select opcion in "Respaldo completo del sistema local" "Respaldo completo de base de datos" "Volver"
  do
    case $REPLY in
      1)clear
      fecha=$(date +%Y-%m-%d-%H.%M.%S)
      mysqldump -u root -prtBd1234. kefruta > /backupbd/respaldo-"$fecha".sql
      tar -cvf /backupbd/respaldo-binario-"$fecha".tar /var/log/mariadb/*
      rsync -aAXv --exclude={/dev/*,/usr/*,/proc/*,/sys/*,/tmp/*,/run/*,/mnt/*,/media/*,/lost+found,/backup/*,/root/*} /* /backup/respaldo-"$fecha"/
      mv /backup/respaldo-"$fecha"/ /media/respaldosKefruta/
      clear
      break
      ;;
      2)clear
      fecha=$(date +%Y-%m-%d-%H.%M.%S)
      (mysqldump -u root -prtBd1234. kefruta > /backupbd/respaldo-"$fecha".sql && tar -cvf /backupbd/respaldo-binario-"$fecha".tar /var/log/mariadb/* && echo "Backup relizadó con exito") || echo "No se pudo hacer el respaldo, contacte con el adminitrador del sistema"
      read -p "asd" NaN
      sleep 10
      clear
      break
      ;;
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
