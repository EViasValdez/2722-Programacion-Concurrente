﻿using System;
using System.Threading;

namespace Concurrencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread H1 = new Thread(Sumar);
            Thread H2 = new Thread(Restar);

            H1.Start();
            H2.Start();
            Console.ReadLine();
        }
        public static long Uno = 0;
        public static void Sumar()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Uno++;
            }
            Console.WriteLine("Suma: " + Uno);
        }
        public static void Restar()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Uno--;
            }
            Console.WriteLine("Resta: " + Uno);
        }
    }
}