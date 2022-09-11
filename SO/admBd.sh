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
function validacionLogica() {
  #$1 = Mensaje de ingreso de datos
  #$2 = Mensaje de respuesta erronea
  read -p "$1 [S/n] " respuesta
    if [[ "$respuesta" =~ ^s?S?*$ ]]; then
      echo "0"
    elif [[ "$respuesta" =~ ^n?N?+$ ]]; then
      echo "1"
    else
      while [[ ! "$respuesta" =~ ^s?S?*$ ]] && [[ ! "$respuesta" =~ ^n?N?+$ ]]; do
        read -p "$2 $1 [S/n]" respuesta
      done

      if [[ "$respuesta" =~ ^s?S?*$ ]]; then
        echo "0"
      elif [[ "$respuesta" =~ ^n?N?+$ ]]; then
        echo "1"
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

      if [[ "$contra" == "$confirm" ]]; then
        echo -e "\nLas contraseñas coinciden"
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
  sed -i s/"^GRANT SELECT, INSERT, UPDATE, DELETE  ON kefruta.* TO '@name'@'@location';$"/"GRANT SELECT, INSERT, UPDATE, DELETE  ON kefruta.* TO '$nombre'@'$lugarCon';"/ Sql/createUser.sql

  mysql -u root -p < Sql/createUser.sql && echo "¡Usuario creado con exito!" || echo "No se creó el usuario, error en el ingreso de contraseña."

  sleep 2

  echo -e "CREATE USER '@name'@'@location' IDENTIFIED BY '@pass';\nGRANT SELECT, INSERT, UPDATE, DELETE  ON kefruta.* TO '@name'@'@location';\nFLUSH PRIVILEGES;" > Sql/createUser.sql
}

#################################################################################
function borrarUsuario(){
  lugarCon="1"
  #Ingreso del nombre del nuevo usuario
  validacionNombre=$(validarNombre "Ingrese el nombre del usuario a eliminar: ")
  validacion=$(echo "$validacionNombre" | grep "[0-9]")
  nombre=$(echo "$validacionNombre" | grep "^[a-z?A-Z?]*$")

  if [[ "$validacion" == "0" ]]; then
    clear
  else
    while [[ "$validacion" != "0" ]]; do
      clear
      echo -e "¡Ingresó un nombre invalido!"
      validacionNombre=$(validarNombre "Ingrese el nombre del usuario a eliminar: ")
      validacion=$(echo "$validacionNombre" | grep "[0-9]")
      nombre=$(echo "$validacionNombre" | grep "^[a-z?A-Z?]*$")
    done
  fi

  mysql -u consultaUsuarios --password=consultaBd1234. < Sql/selectUser.sql > Sql/.resultado.txt

  multiCuenta=$(cat Sql/.resultado.txt | grep "^$nombre[[:blank:]]\+" | grep -n "" | grep -o "2")

  if [[ "$multiCuenta" == "2"  ]]; then
    while [[ "$lugarCon" == "1" ]]; do
      echo -e "El usuario posee una cuenta localhost y %(equipos externos), ¿cual desea borrar?"
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
  else
    lugarCon=$(cat Sql/.resultado.txt | grep "^$nombre[[:blank:]]\+" | grep -o "localhost")
    if [[ "$lugarCon" == "" ]]; then
      lugarCon=$(cat Sql/.resultado.txt | grep "^$nombre[[:blank:]]\+" | grep -o "%")
    fi
  fi

    sed -i s/"^REVOKE ALL PRIVILEGES, GRANT OPTION FROM '@name'@'@location';$"/"REVOKE ALL PRIVILEGES, GRANT OPTION FROM '$nombre'@'$lugarCon';"/ Sql/deleteUser.sql
    sed -i s/"^DROP USER '@name'@'@location';$"/"DROP USER '$nombre'@'$lugarCon';"/ Sql/deleteUser.sql

    eleccion=$(validacionLogica "¿Esta seguro que quiere eliminar al usuario: $nombre?" "Opción incorrecta")

    if [[ "$eleccion" == "0" ]]; then
      mysql -u root -p < Sql/deleteUser.sql && echo "¡Usuario eliminado con exito!" || echo "No se elimino el usuario, error en el ingreso de contraseña."
    else
      echo "No se hizo ningun cambio"
      sleep 1
      clear
    fi



    echo -e "REVOKE ALL PRIVILEGES, GRANT OPTION FROM '@name'@'@location';\nDROP USER '@name'@'@location';\nFLUSH PRIVILEGES;" > Sql/deleteUser.sql
    rm Sql/.resultado.txt
    sleep 1
    clear
}
#################################################################################
function listarUsuario(){
  clear
  echo -e "Toque enter para volver\n\n"
  mysql -u root --password=rtBd1234. -e "SELECT User,Host FROM mysql.user"
  #mysql -u consultaUsuarios < Sql/selectUser.sql > Sql/.resultado.txt
  #cat Sql/.resultado.txt
  read -p "" NaN
  #rm Sql/.resultado.txt
  clear
}
############ Menú principal ############
while [[ true ]]; do
  echo -e "Menú de adminitración de base de datos\n"
    select opcion in "Agruegar un administrador de BD" "Borrar usuario" "Listar usuarios actuales" "Volver"
  do
    case $REPLY in
      1)
      agruegarUsuario
      clear
      break
      ;;
      2)
      borrarUsuario
      clear
      break
      ;;
      3)
      listarUsuario
      clear
      break
      ;;
      4)
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
