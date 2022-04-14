using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;
            string linea;
            Console.WriteLine("DIGITE UN NUMERO: "); linea = Console.ReadLine();
            numero1 = int.Parse(linea);

            if(numero1 == 0)
            {
                Console.WriteLine("EL PRODUCTO DE 0 POR CUALQUIER NUMERO ES 0");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("DIGITE UN SEGUNDO NUMERO: "); linea = Console.ReadLine();
                numero2 = int.Parse(linea);

                resultado = numero1 * numero2;
                Console.WriteLine("EL RESULTADO DE MULTIPLICAR {0} POR {1} = {2}", numero1, numero2, resultado);
                Console.ReadKey();
            }
        }
    }
}
