using System;
using Operazioni;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il primo numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il secondo numero");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il terzo numero");
            int c = int.Parse(Console.ReadLine());

            bool r = Metodi.Uguale(a, b, c);
            Console.WriteLine(r);
            Console.ReadLine();
        }
                              
    }
}
