# language: es
Característica: Ganar juego
	Para saber que gane
	Como un jugador
	Quiero ver un mensaje "GANASTE !!! :)"

Escenario: Ganar juego
	Dado Ingreso a la aplicación
	Y Presiono el boton nuevo juego
	Y El numero correcto es 4152
	Cuando Pruebo con 4152
	Entonces Debería ver el mensaje "GANASTE !!! el numero correcto era : 4152"
