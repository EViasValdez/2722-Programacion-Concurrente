package main

import (
	"ContenidoServidor"
)

func main() {
	Servidor := ContenidoServidor.New(":8000")
	err := Servidor.ListenAndServe()

	if err != nil
	{
		panic(err)
	}
}