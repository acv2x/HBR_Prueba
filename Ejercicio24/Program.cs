using System;

namespace Ejercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clMatriz matrix = new clMatriz();
            matrix.Cargar_Datos();
            Console.WriteLine("----------------------");
            matrix.ImprimirVertic();
            Console.ReadKey();
        }
        public class clMatriz
        {
            private int[,] Matriz;

            public void Cargar_Datos()
            {
                string linea; 
                Console.WriteLine("DIGITE LA CANTIDAD DE FILAS QUE TENDRA LA MATRIZ: "); linea = Console.ReadLine();
                int filas = int.Parse(linea);
                Console.WriteLine("DIGITE LA CANTIDAD DE COLUMNAS QUE TENDRA LA MATRIZ: "); linea = Console.ReadLine();
                int columnas = int.Parse(linea);
                Matriz = new int[filas, columnas];

                for(int f = 0; f < Matriz.GetLength(0); f++)
                {
                    for(int c=0;c < Matriz.GetLength(1); c++)
                    {
                        Console.Write("DIGITE DATO PARA INGRESAR A LA MATRIZ: "); linea = Console.ReadLine();
                        Matriz[f, c] = int.Parse(linea);
                    }
                }
            }
            public void ImprimirVertic()
            {
                for(int f = 0; f < Matriz.GetLength(0); f++)
                {
                    for(int c = 0; c < Matriz.GetLength(1); c++)
                    {
                        Console.Write(Matriz[f, c]+" ");
                    }
                }
                Console.WriteLine("VERTICES SUPERIOR IZQUIERO: {0}",Matriz[0, 0]);
                Console.WriteLine("VERTICE SUPERIOR DERECHO: {0}", Matriz[0, Matriz.GetLength(1) - 1]);
                Console.WriteLine("VERTICE INFERIOR IZQUIERO: {0}", Matriz[Matriz.GetLength(0) - 1, 0]);
                Console.WriteLine("VERTICE INFERIOR DERECHO: {0}", Matriz[Matriz.GetLength(0) - 1, Matriz.GetLength(1) - 1]);
            }
        }
    }
}
