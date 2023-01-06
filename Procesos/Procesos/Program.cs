using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Procesos
{
    // Clase para objetos de procesos
    class Proceso
    {
        public long Prioridad { get; set; }
        public string Nombre { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Proceso> procesos = new List<Proceso>();
            menu(procesos);

        }
        public static void menu(List<Proceso> procesos)
        {
            //Titulo de programa
            Console.WriteLine("*******************************************");
            Console.WriteLine("*         Programa de dos procesos        *");
            Console.WriteLine("*******************************************");
            Console.WriteLine("* 1. Con parametros definidos             *");
            Console.WriteLine("* 2. Con parametros personalizados        *");
            Console.WriteLine("* 3. Salir                                *");
            Console.WriteLine("*******************************************");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Llenar informacion
                    llenar(procesos, opcion);
                    // Funcion de ordenar
                    ordenar(procesos);
                    // Funcion para procesos
                    ejecutar(procesos);
                    break;

                case 2:
                    // Llenar informacion
                    llenar(procesos, opcion);
                    // Funcion de ordenar
                    ordenar(procesos);
                    // Funcion para procesos
                    ejecutar(procesos);
                    break;

                case 3:
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("Opcion no valida porfavor intente de nuevo");
                    Console.ReadLine();
                    Console.Clear();
                    menu(procesos);
                    break;
            }
        }
        public static void llenar(List<Proceso> procesos, int opcion)
        {
            if (opcion == 1)
            {
                procesos.Clear();
                //crear objetos
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine($"Introduzca el nombre del proceso {i}:");
                    //Leer nombre del proceso 
                    string nombre = Console.ReadLine();
                    Console.WriteLine($"Introduzca la prioridad del proceso {i}:");
                    //Leer prioridad del proceso
                    long prioridad = long.Parse(Console.ReadLine());
                    //Crear objeto con metodo constructor para añadir a lista de obj
                    procesos.Add(new Proceso()
                    {
                        //Asignacion de valores en los atributos del objeto parametros [long] [string]
                        Prioridad = prioridad,
                        Nombre = nombre,
                    });
                }
            }
            else
            {
                procesos.Clear();
                Console.WriteLine("Cuantos procesos requiere");
                int numeroProcesos = int.Parse(Console.ReadLine());
                //crear objetos
                for (int i = 1; i <= numeroProcesos; i++)
                {
                    Console.WriteLine($"Introduzca el nombre del proceso {i}:");
                    //Leer nombre del proceso 
                    string nombre = Console.ReadLine();
                    Console.WriteLine($"Introduzca la prioridad del proceso {i}:");
                    //Leer prioridad del proceso
                    long prioridad = long.Parse(Console.ReadLine());
                    //Crear objeto con metodo constructor para añadir a lista de obj
                    procesos.Add(new Proceso()
                    {
                        //Asignacion de valores en los atributos del objeto parametros [long] [string]
                        Prioridad = prioridad,
                        Nombre = nombre,
                    });
                }
            }


        }
        public static void ordenar(List<Proceso> procesos)
        {
            //Ordenar lista en longitudes
            procesos.Sort(delegate (Proceso x, Proceso y) {
                return x.Prioridad.CompareTo(y.Prioridad);
            });
            //Funcion para ver items
            /*foreach(var item in procesos)
            {
                Console.WriteLine($"Los valores son {item.Nombre} {item.Prioridad}");
            }
            Console.ReadLine();*/

        }
        public static void ejecutar(List<Proceso> procesos)
        {
            foreach (var item in procesos)
            {
                Console.WriteLine($"Proceso {item.Nombre} con prioridad {item.Prioridad} en ejecucion");
                Console.WriteLine("Espere porfavor");
                Thread.Sleep(2000);
                Console.WriteLine($"Proceso {item.Nombre} ejecutado");
                Thread.Sleep(2000);
            }
            Console.WriteLine("¿Quiere regresar al menu? ESCRIBA 'SI' o 'NO'");
            string opcion = Console.ReadLine();
            if (opcion == "SI" || opcion == "si" || opcion == "Si" || opcion == "sI")
            {
                menu(procesos);
            }
            else
            {
                Console.WriteLine("Hasta pronto");
            }
        }
    }
}