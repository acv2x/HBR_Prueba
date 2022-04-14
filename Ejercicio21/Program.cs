using System;

namespace Ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matriz_Irregular matrizobj = new Matriz_Irregular();
            matrizobj.Cargar_Datos();
            Console.WriteLine("LOS DATOS INGRESADOS FUERON LOS SIGUIENTES");
            matrizobj.Imprimir_Datos();
            Console.ReadKey();
        }
        public class Matriz_Irregular
        {
            private int[][] Matriz;

            public void Cargar_Datos()
            {
                Matriz = new int[5][];
                for(int f = 0; f < Matriz.Length; f++)
                {
                    Matriz[f] = new int[f + 1];
                    for(int c = 0; c < Matriz[f].Length; c++)
                    {
                        Console.WriteLine("INGRESE UN COMPONENTE: "); string linea = Console.ReadLine();
                        Matriz[f][c] = int.Parse(linea);
                    }
                }
            }
            public void Imprimir_Datos()
            {
                for(int f = 0; f < Matriz.Length; f++)
                {
                    for(int c = 0; c < Matriz[f].Length; c++)
                    {
                        Console.WriteLine(Matriz[f][c]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
