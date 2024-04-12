package main

import (
	"fmt"
)

var Dolar float32
var Euro float32
var Cuenta float32

func main() {
	Cuenta = 100
	Dolar = 20
	Euro = 25

	fmt.Println("Esta es la cantidad que tiene tu cuenta")
	fmt.Println(Cuenta)

	go Ingreso()
	go Egreso()
}

func Ingreso(Dolares float32) {
	// Recibe una cantidad en dolares que es convertida a pesos y lo suma a la cuenta.
	Cuenta += Dolar + Dolares
	fmt.Println(Cuenta)
}

func Egreso(Euros float32) {
	// Recibe una cantidad en euros que es convertida a pesos y lo suma a la cuenta.
	Cuenta -= Euro + Euros
	fmt.Println(Cuenta)
}

func ActualizacionDivisa() {
	// Ambos valores son actualizados.
	fmt.Println("Los valores han sido actualizados")
}