using System;

namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            for (numero = 0; numero <= 50; numero++)
            {
                int residuo = numero % 3;
                if (residuo == 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadKey();
        }
    }
}
