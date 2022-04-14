using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;
            string linea;
            Console.WriteLine("DIGITE UN NUMERO: "); linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            Console.WriteLine("DIGITE UN NUMERO: "); linea = Console.ReadLine();
            numero2 = int.Parse(linea);

            resultado = numero1 % numero2;

            if(resultado == 0)
            {
                Console.WriteLine("{0} ES MULTIPLO DE {1}", numero1, numero2);
            }
            else
            {
                Console.WriteLine("{0} NO ES MULTIPLO DE {1}", numero1, numero2);
            }

        }
    }
}
