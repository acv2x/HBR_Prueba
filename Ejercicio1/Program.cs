using System;

namespace Ejercicio1
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

            try
            {
                resultado = numero1 / numero2;
                Console.WriteLine("EL RESULTADO DE DIVIDIR {0} ENTRE {1} = {2}", numero1, numero2, resultado);
                resultado = numero1 % numero2;
                Console.WriteLine("EL RESIDUO DE LA DIVISION DE {0} ENTRE {1} = {2}", numero1, numero2, resultado);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
