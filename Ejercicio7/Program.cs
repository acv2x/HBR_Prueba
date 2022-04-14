using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, valorabs;
            string linea;
            Console.WriteLine("DIGITE UN NUMERO: "); linea = Console.ReadLine();
            numero1 = int.Parse(linea);

            if (numero1 > 0)
            {
                
                Console.WriteLine("VALOR ABSOLUTO DE {0} ES {1}", numero1, numero1);
            }
            else
            {
                valorabs = numero1 * -1;
                Console.WriteLine("VALOR ABSOLUTO DE {0} ES {1}", numero1, valorabs);
            }
            Console.ReadKey();
        }
    }
}
