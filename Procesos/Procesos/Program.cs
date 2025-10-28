using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Procesos
{
    // Clase para objetos de Procesos.
    class Proceso
    {
        public long Prioridad { get; set; }
        public string Nombre { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Proceso> Procesos = new List<Proceso>();
            Menu(Procesos);
        }
        public static void Menu(List<Proceso> Procesos)
        {
            // Titulo de programa.
            Console.WriteLine("*******************************************");
            Console.WriteLine("*         Programa de dos procesos        *");
            Console.WriteLine("*******************************************");
            Console.WriteLine("* 1. Con parámetros definidos.            *");
            Console.WriteLine("* 2. Con parámetros personalizados.       *");
            Console.WriteLine("* 3. Salir.                               *");
            Console.WriteLine("*******************************************");
            Console.WriteLine("");

            int Opcion = int.Parse(Console.ReadLine());

            switch (Opcion)
            {
                case 1:
                    // Llenar información.
                    Llenar(Procesos, Opcion);
                    // Funcion para ordenar.
                    Ordenar(Procesos);
                    // Funcion para Procesos.
                    Ejecutar(Procesos);
                    break;

                case 2:
                    // Llenar información.
                    Llenar(Procesos, Opcion);
                    // Función para Ordenar.
                    Ordenar(Procesos);
                    // Función para Procesos.
                    Ejecutar(Procesos);
                    break;

                case 3:
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Opción no valida por favor intente de nuevo");
                    Console.ReadLine();
                    Console.Clear();
                    Menu(Procesos);
                    break;
            }
        }
        public static void Llenar(List<Proceso> Procesos, int Opcion)
        {
            if (Opcion == 1)
            {
                Procesos.Clear();
                // Crear objetos.
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"Introduzca el nombre del proceso {i}: ");
                    // Leer nombre del proceso .
                    string nombre = Console.ReadLine();
                    Console.WriteLine($"Introduzca la prioridad del proceso {i}: ");
                    // Leer prioridad del proceso.
                    long prioridad = long.Parse(Console.ReadLine());
                    // Crear objeto con método constructor para añadir a lista de obj.
                    Procesos.Add(new Proceso()
                    {
                        // Asignación de valores en los atributos del objeto usando parámetros [long] [string].
                        Prioridad = prioridad,
                        Nombre = nombre,
                    });
                }
            }
            else
            {
                Procesos.Clear();
                Console.WriteLine("Cuantos Procesos requiere");
                int numeroProcesos = int.Parse(Console.ReadLine());
                // Crear objetos.
                for (int i = 1; i <= numeroProcesos; i++)
                {
                    Console.WriteLine($"Introduzca el nombre del proceso {i}: ");
                    // Leer nombre del proceso.
                    string nombre = Console.ReadLine();
                    Console.WriteLine($"Introduzca la prioridad del proceso {i}: ");
                    // Leer prioridad del proceso.
                    long prioridad = long.Parse(Console.ReadLine());
                    // Crear objeto con método constructor para añadir a lista obj.
                    Procesos.Add(new Proceso()
                    {
                        // Asignación de valores en los atributos del objeto parámetros [long] [string].
                        Prioridad = prioridad,
                        Nombre = nombre,
                    });
                }
            }
        }
        public static void Ordenar(List<Proceso> Procesos)
        {
            // Ordenar lista en longitudes.
            Procesos.Sort(delegate (Proceso x, Proceso y) {
                return x.Prioridad.CompareTo(y.Prioridad);
            });
            // Función para ver items.
            /*foreach (var Item in Procesos)
            {
                Console.WriteLine($"Los valores son {Item.Nombre} {Item.Prioridad}");
            }
            Console.ReadLine();*/

        }
        public static void Ejecutar(List<Proceso> Procesos)
        {
            foreach (var Item in Procesos)
            {
                Console.WriteLine($"Proceso {Item.Nombre} con prioridad {Item.Prioridad} en ejecución");
                Console.WriteLine("Espere por favor");
                Thread.Sleep(2000);
                Console.WriteLine($"Proceso {Item.Nombre} ejecutado");
                Thread.Sleep(2000);
            }
            Console.WriteLine("¿Quiere regresar al menu? Escriba 'SI' o 'NO'");
            string Opcion = Console.ReadLine();
            
            if (Opcion == "SI" || Opcion == "si" || Opcion == "Si" || Opcion == "sI")
            {
                Menu(Procesos);
            }
            else
            {
                Console.WriteLine("Hasta pronto");
            }
        }
    }
}