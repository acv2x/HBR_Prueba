using System;

namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 26;
            do
            {
                Console.WriteLine(numero--);

            }
            while (numero > 9);
            Console.ReadKey();
        }

    }
}
