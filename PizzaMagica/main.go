package main

import (
	"fmt"
	"time"
)

func main() {
	Rebanada := make(chan int)
	echo := make(chan bool)

	go func() {
		for {
			i, more := <-Rebanada

			if more {
				fmt.Println("Rebanada de pizza agarrada - ", i)
				time.Sleep(1 * time.Second)
			} else {
				fmt.Println("La pizza se ha terminado, espera un poco para que llegue mas.")
				time.Sleep(4 * time.Second)
				fmt.Println("Ha llegado mas pizza.")
				time.Sleep(4 * time.Second)
				echo <- true
				return
			}
		}
	}

	for i := 1; i <= 50; i++ {
		Rebanada <- i
	}

	close(Rebanada)
	<-echo
	defer main()
}
