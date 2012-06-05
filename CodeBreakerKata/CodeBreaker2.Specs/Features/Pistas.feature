# language: es
Característica: Pistas
	Para saber si estoy ingresando los numeros correctos
	Como un jugador
	Quiero ver una pista

Esquema del escenario: "Intentar con un numero y ver una pista cuando el numero no es el correcto"
	Dado Ingreso a la aplicación
	Y Presiono el boton nuevo juego
	Y El numero correcto es <numero_correcto>
	Cuando Pruebo con <numero>
	Entonces Debería ver esta <pista>

	Ejemplos: 
		| numero_correcto | numero | pista      |
		| 4789            | 4123      | X |
		| 4789            | 4429      | XX |
		| 4789            | 4499      | XX |
		| 4789            | 4789      | XXXX |
		| 4789            | 1453      | _ |
		| 4789            | 1473      | __ |
		| 4789            | 9478      | ____ |
		| 4789            | 1429      | X_ |
		| 4789            | 4879      | XX__ |
		| 4789            | 4444      | X |
		| 4789            | 1235      |	|
