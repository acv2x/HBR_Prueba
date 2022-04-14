using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            string linea;
            Console.WriteLine("DIGITE UN NUMERO: "); linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            Console.WriteLine("DIGITE UN SEGUNDO NUMERO"); linea = Console.ReadLine();   
            numero2 = int.Parse(linea);

            if(numero1 < 0 & numero2 > 0)
            {
                Console.WriteLine("UNO DE LOS NUMEROS ES POSITIVO");
            }
            else if(numero1 > 0 & numero2 < 0)
            {
                Console.WriteLine("UNO DE LOS NUMEROS ES POSITIVO");
            }
            else if (numero1 > 0 & numero2 > 0)
            {
                Console.WriteLine("LOS DOS NUMEROS SON POSITIVOS");
            }
            else if(numero1<0 & numero2 < 0)
            {
                Console.WriteLine("NINGUNO DE LOS NUMEROS ES POSITIVO");
            }

            Console.ReadKey();


        }
    }
}
