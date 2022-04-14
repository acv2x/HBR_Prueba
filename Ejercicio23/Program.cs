using System;

namespace Ejercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrizobj = new Matrix();
            matrizobj.Cargar_Matriz();
            Console.WriteLine();
            matrizobj.Cambiar();
            matrizobj.Imprimir_Datos();
            Console.ReadKey();
        }
        public class Matrix
        {
            private int[,] Matriz;

            public void Cargar_Matriz()
            {
                string linea;
                Console.Write("DIGITE EL NUMERO DE FILAS DE LA MATRIZ: "); linea = Console.ReadLine();
                int filas = int.Parse(linea);
                Console.Write("DIGITE EL NUMERO DE COLUMNAS DE LA MATRIZ: "); linea = Console.ReadLine();
                int columnas = int.Parse(linea);
                Matriz = new int[filas, columnas];

                for(int f = 0; f < Matriz.GetLength(0); f++)
                {
                    for(int c = 0; c < Matriz.GetLength(1); c++)
                    {
                        Console.Write("DIGITE COMPONENTE PARA INGRESAR EN LA MATRIZ: "); linea = Console.ReadLine();
                        Matriz[f, c] = int.Parse(linea);
                    }
                }
            }
            public void Cambiar()
            {
                for(int f = 0; f < Matriz.GetLength(1); f++)
                {
                    int auxiliar = Matriz[0, f];
                    Matriz[0, f] = Matriz[1, f];
                    Matriz[1, f] = auxiliar;
                }
            }
            public void Imprimir_Datos()
            {
                for(int f = 0; f < Matriz.GetLength(0); f++)
                {
                    for(int c = 0; c < Matriz.GetLength(1); c++)
                    {
                        Console.Write(Matriz[f, c]+" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
