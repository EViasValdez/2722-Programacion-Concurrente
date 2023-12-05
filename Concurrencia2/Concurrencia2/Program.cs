using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Threading;

namespace Concurrencia2
{
    internal class Program
    {
        public static void main(string[] args)
        {
            ext x = new ext();
            Thread H1 = new Thread(x.H1);
            H1.Start();
            Thread H2 = new Thread(x.H2);
            H2.Start();
            x.print();
        }
    }
}
    class ext
    {
        Mutex m = new Mutex();
        public int j = 10;
    public void H1()    
    {
        m.WaitOne();
        Console.WriteLine(j);
        m.ReleaseMutex();
    }
        public void H2()
        {
            m.WaitOne();
            j = 100;
            m.ReleaseMutex();
        }
        public void print()
    {
        Console.WriteLine(j);
    }
    }