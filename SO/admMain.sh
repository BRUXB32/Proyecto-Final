#!/bin/bash

clear

PS3="Ingrese una opción: "

while [ true ]
do
select opcion in "Agruegar usuario" "Eliminar usuario" "Modificar usuario" "Salir"
do
	case $REPLY in
		1)read -p "Ingrese nombre del nuevo usuario: " usuario
		read -p "¿Crear directorio para el usuario? [S/n]" respuesta
			if [ "respuesta" == "" ] then
				
		break
		;;
		2)read -p "Ingrese nombre de usuario a borrar: " usuario
		echo "$usuario"
		break
		;;
		3)read -p "Ingrese el nombre del usuario a modificar: " usuario
		echo "$usuario"
		break
		;;
		4)exit
		;;
		*)echo "Opción incorrecta"
		break
		;;
	esac

done
done
