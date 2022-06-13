#/bin/bash

clear

############ Cambios necesarios antes de iniciar el script ############

#Cambio el mensaje de "select"
PS3="Ingrese una opción: "

############ Variables ############
nombreG="pepe"

############ Funciones del script ################
function validarNombre() {
  exp="^[a-z?A-Z]+$"
  read -p "$1" nombre
  echo $nombre
    if [[ "$nombre" =~ $exp ]]; then
      nombreG=$nombre
      echo 0
    else
      echo 1
    fi
}

function validacionLogica() {
  #$1 = Mensaje de ingreso de datos
  #$2 = Mensaje de respuesta positiva
  #$3 = Mensaje de respuesta negativa
  #$4 = Mensaje de respuesta erronea
  read -p "$1 [S/n]" respuesta
    if [[ "$respuesta" =~ ^s?S?*$ ]]; then
      echo "$2"
      echo "Hola"
    elif [[ "$respuesta" =~ ^n?N?+$ ]]; then
      echo "$3"
    else
      while [[ ! "$respuesta" =~ ^s?S?*$ ]] && [[ ! "$respuesta" =~ ^n?N?+$ ]]; do
        echo "$4"
        read -p "$1 [S/n]" respuesta
      done
    fi
}

function validarRuta() {
  read -p $1 ruta
  if [[ ! -d "$ruta" ]]; then
    echo "Hola"
  fi
}

function agruegarUsuario() {
  validacionNombre=$(validarNombre "Ingrese un nombre para el nuevo usuario: ")
  if [[ "$validacionNombre" == "0" ]]; then
    echo $nombreG
  else
    while [[ "$validacionNombre" != "0" ]]; do
      clear
      echo -e "¡Ingresó un nombre invalido!"
      validacionNombre=$(validarNombre "Ingrese un nombre para el nuevo usuario: ")
    done
  fi
}

############ Menú principal ############
while [[ true ]]; do
    select opcion in "Agruegar usuario" "Eliminar usuario" "Modificar usuario" "Salir"
  do
    case $REPLY in
      1)
      agruegarUsuario
      echo $nombre
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
      echo $nombre
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
