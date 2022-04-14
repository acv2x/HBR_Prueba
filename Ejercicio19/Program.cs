using System;

namespace Ejercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matriz matrix = new Matriz();
            matrix.Cargar_Matriz();
            matrix.Imprimir();
            Console.ReadKey();

        }
        public class Matriz
        {
            private int[,] matriz;

            public void Cargar_Matriz()
            {
                matriz = new int[2, 5];
                for(int c = 0; c < 5; c++)
                {
                    for(int f = 0; f < 2; f++)
                    {
                        Console.Write("Ingrese componente " + " de la fila " + f + " y la columna " + c + " :");
                        string linea;
                        linea = Console.ReadLine();
                        matriz[f, c] = int.Parse(linea);
                        
                    }
                }
            }
            public void Imprimir()
            {
                for(int f = 0; f < 2; f++)
                {
                    for(int c = 0; c < 5; c++)
                    {
                        Console.Write(matriz[f, c] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }
        
    }
}
