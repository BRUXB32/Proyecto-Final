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
    if [[ $nombre =~ $exp ]]; then
      echo "0"
      echo "$nombre"
    else
      echo 1
    fi
}

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
    fi
}

function validarRuta() {
  read -p "$1" ruta
  if [[ ! -d "$ruta" ]]; then
    echo "Hola"
  fi
}

function agruegarUsuario() {
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

  eleccion=$(validacionLogica "¿Crear directorio para el usuario(/home/*)?" "Opción incorrecta ")

  if [[ "$eleccion" == "0" ]]; then
    #statements
    echo "Se creara carpeta para el usuario, tomara el mismo nombre de usuario"
  else
    echo "No se creara carpeta para el usuario"
  fi

}

############ Menú principal ############
while [[ true ]]; do
    select opcion in "Agruegar usuario" "Eliminar usuario" "Modificar usuario" "Salir"
  do
    case $REPLY in
      1)
      agruegarUsuario
      #read -p "¿Crear directorio para el usuario? [S/n]" respuesta
      break
      ;;
      2)clear
      echo "Opcion 2"
      exp="^[a-z?A-Z]*$"
      read -p "Ingrese un nombre: " nombre
        if [[ "$nombre" =~ ^[a-z?A-Z]+$ ]]; then
          echo "Verdadero"
        else
          echo "Falso"
        fi
        if [[ "$nombre" =~ $exp ]]; then
          echo "Verdadero"
        else
          echo "Falso"
        fi
      break
      ;;
      3)clear
      validarNombre "Ingrese un nombre para el nuevo usuario: "
      echo "$nombre"
      break
      ;;
      4)exit
      ;;
      *)"Opción incorrecta"
      break
      ;;
    esac
  done
done
