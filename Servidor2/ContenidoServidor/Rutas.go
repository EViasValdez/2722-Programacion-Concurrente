package ContenidoServidor

import (
	"net/http"
)

const ImagesDir = "Imagenes"

func initRoutes() {
	http.Handle("/Imagenes", addHeaders(http.FileServer(http.Dir(ImagesDir))))
	http.HandleFunc("/", index)
}