using System;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            do
            {
                Console.WriteLine(numero++);
            }
            while (numero < 11);
            Console.ReadKey();
        }

    }
}
