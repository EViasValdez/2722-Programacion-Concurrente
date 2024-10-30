package main

import (
	"fmt"
	"github.com/shettyh/threadpool"
	"time"
	"math/rand"
)

type Individuo struct {
	var Nombres string
	var Edades int
}

func (A * Individuo) Run() {
	Aleatorio1 := rand.Int(20)
	Aleatorio2 := rand.String(20)
}

func main() {
	Tareas := threadpool.NewThreadPool(2, 10)
	task := &Run{}

	Nombres = Aleatorio1
	Edades = Aleatorio2

	fmt.Println("El nombre y la edad respectiva es esta ", Nombres, Edades);
	pool.Close()
}