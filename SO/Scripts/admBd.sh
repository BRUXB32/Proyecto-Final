#!/bin/bash
clear

############ Cambios necesarios antes de iniciar el script ############
PS3="Ingrese una opción: "

############ Funciones del script ################
function validarNombre() {
  #$1 = Mensaje de ingreso de datos
  exp="^[a-z?A-Z]+$"
  local nombre=""
  read -p "$1" nombre
  if [[ "$nombre" == "0" ]]; then
    echo "2"
  else
    if [[ $nombre =~ $exp ]]; then
      echo "0"
      echo "$nombre"
    else
      echo "1"
    fi
  fi
}

#################################################################################
function agruegarUsuario() {
  clear
  lugarCon="1"
  #Ingreso del nombre del nuevo usuario
  validacionNombre=$(validarNombre "Ingrese un nombre para el nuevo usuario: ")
  validacion=$(echo "$validacionNombre" | grep "[0-9]")
  nombre=$(echo "$validacionNombre" | grep "^[a-z?A-Z?]*$")

  if [[ "$validacion" == "0" ]]; then
    clear
  else
    while [[ "$validacion" != "0" ]]; do
      clear
      echo -e "¡Ingresó un nombre invalido!"
      validacionNombre=$(validarNombre "Ingrese un nombre para el nuevo usuario: ")
      validacion=$(echo "$validacionNombre" | grep "[0-9]")
      nombre=$(echo "$validacionNombre" | grep "^[a-z?A-Z?]*$")
    done
  fi
  #Ingreso de la contraseña del nuvo usuario
  read -s -p "Ingrese la contraseña del nuevo usuario: " contra
  echo ""
  read -s -p "Confirme la contraseña: " confirm

  if [[ "$contra" == "$confirm" ]]; then
    echo "Las contraseñas coinciden"
    sleep 1
  else
    while [[ "$contra" != "$confirm" ]]; do
      clear
      echo "¡Las contraseñas no coinciden!"
      read -s -p "Ingrese nuevamente la contraseña del nuevo usuario: " contra
      echo ""
      read -s -p "Confirme la contraseña: " confirm
      echo ""
      if [[ "$contra" == "$confirm" ]]; then
        echo "Las contraseñas coinciden"
        sleep 1
        break
      fi
    done
  fi
  clear
  #Desde donde se va a conectar el usuario
  while [[ "$lugarCon" == "1" ]]; do
    echo -e "¿Desde donde se puede conectar el usuario?\n"
      select opcion in "localhost" "%(equipos externos)"
    do
      case $REPLY in
        1)
        lugarCon="localhost"
        break
        ;;
        2)
        lugarCon="%"
        break
        ;;
        *)clear
        echo "Opción incorrecta"
        lugarCon="1"
        sleep 1
        clear
        break
        ;;
      esac
    done
  done

  sed -i s/"^CREATE USER '@name'@'@location' IDENTIFIED BY '@pass';$"/"CREATE USER '$nombre'@'$lugarCon' IDENTIFIED BY '$contra';"/ Sql/createUser.sql
  sed -i s/"^GRANT ALL PIVILEGES ON *.* TO '@name';$"/"GRANT ALL PRIVILEGES ON *.* TO '$nombre';"/ Sql/createUser.sql

  mysql -u root -p < Sql/createUser.sql

  echo -e "CREATE USER '@name'@'@location' IDENTIFIED BY '@pass';\nGRANT ALL PIVILEGES ON *.* TO '@name';\nFLUSH PRIVILEGES;" > Sql/createUser.sql
}


while [[ true ]]; do
  echo -e "Menú de adminitración de base de datos\n"
    select opcion in "Agruegar un administrador de BD" "Volver"
  do
    case $REPLY in
      1)
      agruegarUsuario
      clear
      break
      ;;
      2)
      exit
      clear

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
