using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;
            string linea;
            Console.WriteLine("DIGITE UN NUMERO: "); linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            Console.WriteLine("DIGITE UN SEGUNDO NUMERO: "); linea = Console.ReadLine();
            numero2 = int.Parse(linea);

            if (numero2 == 0)
            {
                Console.WriteLine("NO SE PUEDE DIVIDIR ENTRE 0");
                Console.ReadKey();
            }
            else
            {
                resultado = numero1 / numero2;
                Console.WriteLine("EL RESULTADO DE DIVIDIR {0} ENTRE {1} = {2}", numero1, numero2, resultado);
                Console.ReadKey();
            }

        }
    }
}
