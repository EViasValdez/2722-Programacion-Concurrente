package main

import (
	"api/mypackage"
	"fmt"
)

func main() {
	var student1 my.Student

	student1.Name = "Pedro"
	student1.Age = 22
	fmt.Println(student1)

}
