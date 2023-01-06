package main

import (
	"server"
)

func main() {

	serve := server.New(":8080")

	err := serve.ListenAndServe()

	if err != nil {
		panic(err)
	}
}