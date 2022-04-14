using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            Console.WriteLine("DIGIRTE UNA LETRA: "); linea = Console.ReadLine();
            linea.ToUpper();
            switch (linea)
            {
                case "A":
                    Console.WriteLine("SE TRATA DE UNA VOCAL");
                    break;
                case "E":
                    Console.WriteLine("SE TRATA DE UNA VOCAL");
                    break;
                case "I":
                    Console.WriteLine("SE TRATA DE UNA VOCAL");
                    break;
                case "O":
                    Console.WriteLine("SE TRATA DE UNA VOCAL");
                    break;
                case "U":
                    Console.WriteLine("SE TRATA DE UNA VOCAL");
                    break;
                case "a":
                    Console.WriteLine("SE TRATA DE UNA VOCAL");
                    break;
                case "e":
                    Console.WriteLine("SE TRATA DE UNA VOCAL");
                    break;
                case "i":
                    Console.WriteLine("SE TRATA DE UNA VOCAL");
                    break;
                case "o":
                    Console.WriteLine("SE TRATA DE UNA VOCAL");
                    break;
                case "u":
                    Console.WriteLine("SE TRATA DE UNA VOCAL");
                    break;
                default:
                    Console.ReadKey();
                    break;
            }
        }
    }
}
