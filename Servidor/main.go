package main

import (
	"fmt"
	"io"
	"net/http"
	"time"
)

func concurrente(w http.ResponseWriter, numero []string) {
	for i := 0; i < len(numero); i++ {
		io.WriteString(w, "El numero " + numero[i] + " esta seleccionado")
		fmt.Fprintf(w, "\n")
		fmt.Println("El numero " + numero[i] + " esta seleccionado")
		time.Sleep(time.Millisecond * 2000)
	}
}

func main() {
	numero := []string{"1", "2", "3", "5", "6", "7", "8", "9", "10"}

	http.HandleFunc("/index", func(w http.ResponseWriter, r *http.Request) {
		fmt.Println(numero)
		for i := 0; i < len(numero); i++ {
			io.WriteString(w, numero[i])
			fmt.Fprintf(w, "\n")
		}
	})
	http.HandleFunc("/ingresar", func(w http.ResponseWriter, r *http.Request) {
		fmt.Println("Ingrese numero")
		var eleccion string

		fmt.Scanln(&eleccion)
		registro := len(numero)
		numero = append(numero, eleccion)
		fmt.Println("Numero agregado: " + eleccion)
		time.Sleep(8 * time.Second)
		io.WriteString(w, "El dato agregado fue: " + numero[registro])
	})
	http.HandleFunc("/seleccionar", func(w http.ResponseWriter, r *http.Request) {
		for i := 0; i < len(numero); i++ {
			io.WriteString(w, "El numero " + numero[i] + " esta seleccionado")
			fmt.Fprintf(w, "\n")
			time.Sleep(8 * time.Second)
		}
		go concurrente(w, numero)
	})

	// Consola.
	fmt.Println("El servidor esta en el puerto 8000")
	fmt.Println("Esta localizado en localhost:8000")
	http.ListenAndServe(":8000", nil)
}