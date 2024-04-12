package main

import (
	"Server"
)

func main() {

	serve := Server.New(":8080")

	err := serve.ListenAndServe()

	if err != nil {
		panic(err)
	}
}