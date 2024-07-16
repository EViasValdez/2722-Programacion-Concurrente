using System;
using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Chef1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("El primer chef atiende el menu: " + i);
            }
        }
        static void Chef2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("El segundo chef atiende el menu: " + i);
            }
        }
        static void Main(string[] args)
        {
            Thread Chef1h = new Thread(new ThreadStart(Chef1));
            Thread Chef2h = new Thread(Chef2);
        }
    }
}