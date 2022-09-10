#!/bin/bash

clear

############ Cambios necesarios antes de iniciar el script ############

#Cambio el mensaje de "select"
PS3="Ingrese una opción: "

############ Variables ############


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
function validarRuta() {
  read -p "$1" ruta
  if [[ ! -d "$ruta" ]]; then
    echo "Hola"
  fi
}
#################################################################################
function agruegarUsuario() {
  clear
  directorio="1"
  comentario="Sin comentario"
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

  consulta=$(cat /etc/passwd | grep ^"$nombre:" | cut -d: -f1)

  if [[ "$nombre" == "$consulta" ]]; then
    echo "Ese usuario ya existe, no se haran cambios."
    sleep 2
    clear
  else

    eleccion=$(validacionLogica "¿Crear directorio para el usuario(/home/*)?" "Opción incorrecta ")

    if [[ "$eleccion" == "0" ]]; then
      #statements
      echo "Se creara carpeta para el usuario en /home/$nombre"
      directorio="0"
    else
      echo "No se creara carpeta para el usuario"
    fi

    eleccion=$(validacionLogica "¿Agruegar comentario al usuario?" "Opción incorrecta")

    if [[ "$eleccion" == "0" ]]; then
      #statements
      read -p "Ingrese el comentario: " comentario
      echo "Se agruegara el comentario al usuario."
    else
      echo "No se agruegara un comentario al usuario."
    fi

    if [[ "$directorio" == "0" ]]; then
      sudo useradd -d "/home/$nombre" -m -c "$comentario" -s "/bin/bash" "$nombre"
      echo "Ingrese contraseña del usuario."
      sudo passwd $nombre
      sleep 2
      clear
    else
      sudo useradd -c "$comentario" -s "/bin/bash" "$nombre"
      echo "Ingrese contraseña del usuario."
      sudo passwd $nombre
      sleep 2
      clear
    fi
  fi
}
#################################################################################
function borrarUsuario(){
  clear
  read -p "Ingrese nombre de usuario a eliminar: " usuario
  consulta=$(cat /etc/passwd | grep "$usuario:" | cut -d: -f1)

  if [[ "$usuario" == "$consulta" ]]; then
    eleccion=$(validacionLogica "¿Esta seguro que quiere eliminar al usuario: $consulta?" "Opción incorrecta")

    if [[ "$eleccion" == "0" ]]; then
      sudo userdel -r -f "$consulta" 2> .temp.txt
      echo "Usuario eliminado correctamente"
      sleep 2
      clear
      rm .temp.txt
    else
      echo "No se hizo ningun cambio."
      sleep 2
      clear
    fi
  else
    echo "El usuario no existe"
    sleep 2
    clear
  fi
}
#################################################################################
function modificarUsuario(){
  clear
  #Pido el nombre actual del usuario
  clear
  read -p "Ingrese nombre de usuario a modificar: " usuario
  consulta=$(cat /etc/passwd | grep ^"$usuario:" | cut -d: -f1)

  if [[ "$usuario" == "$consulta" ]]; then
    clear
  else
    echo "Usuario no encontrado"
    sleep 1
    clear
    return
  fi

  #Menú de opciones para modificar
  while [[ true ]]; do
    select opcion in "Cambiar nombre" "Cambiar grupo primario" "Cambiar contraseña" "Salir"
    do
      case $REPLY in
        1)clear
        #Ingreso del nuevo nombre
        validacionNombre=$(validarNombre "Ingrese el nuevo nombre para el usuario: ")
        validacion=$(echo "$validacionNombre" | grep "[0-9]")
        nombre=$(echo "$validacionNombre" | grep "^[a-z?A-Z?]*$")

        if [[ "$validacion" == "0" ]]; then
          echo ""
        else
          while [[ "$validacion" != "0" ]]; do
            clear
            echo -e "¡Ingresó un nombre invalido!"
            validacionNombre=$(validarNombre "Ingrese un nombre para el nuevo usuario: ")
            validacion=$(echo "$validacionNombre" | grep "[0-9]")
            nombre=$(echo "$validacionNombre" | grep "^[a-z?A-Z?]*$")
          done
        fi

        sudo usermod -l "$nombre" "$usuario"
        echo "Nombre cambiado exitosamente"
        sleep 2
        clear
        return
        break
        ;;
        2)clear
        read -p "Ingrese el nombre del nuevo grupo primario: " grpPrimario
        grpActual=$(cat /etc/passwd | grep ^"$usuario:" | cut -d: -f4)
        nuevoGrp=$(cat /etc/group | grep ^"$grpPrimario:" | cut -d: -f3)
        consulta=$(cat /etc/group | cut -d: -f1 | grep ^"$grpPrimario"$)

        if [[ "$grpPrimario" == "$consulta" ]]; then
          if [[ "$grpActual" == "$nuevoGrp" ]]; then
            echo "El grupo es el mismo, imposible cambiarlo."
            sleep 3
            clear
            break
          else
            sudo usermod -g "$consulta" "$usuario"
            echo "Usuario cambiado de grupo exitosamente."
            sleep 3
            clear
            break
          fi
        else
          echo "El grupo no existe."
          sleep 2
          clear
          break
        fi
        ;;
        3)clear
        sudo passwd "$usuario"
        sleep 2
        clear
        break
        ;;
        4)
        #Salir de la modificación de usuario
        clear
        return
        break
        ;;
        *)echo "Opción incorrecta"
        break
        ;;
      esac
    done
  done
}



############ Menú principal ############
while [[ true ]]; do
  echo -e "Menú de administración de usuarios\n"
    select opcion in "Agruegar usuario" "Eliminar usuario" "Modificar usuario" "Salir"
  do
    case $REPLY in
      1)
      agruegarUsuario
      break
      ;;
      2)
      borrarUsuario
      break
      ;;
      3)
      modificarUsuario
      break
      ;;
      4)
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
