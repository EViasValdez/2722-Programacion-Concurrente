package ContenidoServidor

import (
	"database/sql"
	"fmt"
	"net/http"

	_ "github.com/go-sql-driver/mysql"
)

func index(w http.ResponseWriter, r *http.Request) {
	fmt.Fprintf(w, "--o-----------\n")
	fmt.Fprintf(w, "---o----------\n")
	fmt.Fprintf(w, "----o---------\n")
	fmt.Fprintf(w, "-----o--------\n")
	fmt.Fprintf(w, "------------o-\n")
	fmt.Fprintf(w, "---o----------\n")
	fmt.Fprintf(w, "-----------o--\n")
	fmt.Fprintf(w, "-----o--------\n")

	db, err := BasedeDatos()

	if err != nil
	{
		fmt.Printf("Error obteniendo base de datos: %v", err)
		return
	}

	defer db.Close()
	err = db.Ping()

	if err != nil
	{
		fmt.Printf("Error conectando: %v", err)
		return
	}

	fmt.Printf("La base de datos esta conectada de forma correcta")

	Contactos, err := LeerTabla()
	if err != nil
	{
		fmt.Printf("Error obteniendo contactos: %v", err)
		return
	}
	for _, contacto := range Contactos {
		fmt.Printf("%v\n", contacto)
	}
}

func addHeaders(h http.Handler) http.HandlerFunc {
	return func(w http.ResponseWriter, r *http.Request) {
		w.Header().Set("Access-Control-Allow-Origin", "*")
		h.ServeHTTP(w, r)
	}
}

func BasedeDatos() (db *sql.DB, e error) {
	usuario := "root"
	pass := ""
	host := "localhost"
	NombreBasedeDatos := "EjemploUniversidad"
	db, err := sql.Open("mysql", fmt.Sprintf("%s:%s@%s/%s", usuario, pass, host, NombreBasedeDatos))

	if err != nil
	{
		return nil, err
	}

	return db, nil
}

func LeerTabla() ([]Tabla, error) {
	Tablas := []Tabla{}
	db, err := BasedeDatos()

	if err != nil
	{
		return nil, err
	}

	defer db.Close()
	Filas, err := db.Query("SELECT ID, Nombre(s), Apellidos(s), Genero, Fecha de nacimiento, Matricula FROM grupo")

	if err != nil
	{
		return nil, err
	}

	defer Filas.Close()

	ver t Tabla
	
	for Filas.Next() {
		err = Filas.Scan(&t.ID, &t.Nombre(s), &t.Apellidos(s), &t.Genero, &t.Fecha de nacimiento, &t.Matricula)

		if err != nil
		{
			return nil, err
		}

		Tablas = append(Tablas, c)
	}

	return Tablas, nil
}