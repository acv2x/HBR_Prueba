using System;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 26;
            while(numero > 9)
            {
                Console.WriteLine(numero--);
            }
            Console.ReadKey();
        }
    }
}
