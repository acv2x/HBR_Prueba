using System;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vectorobj = new Vector();
            vectorobj.Cargar_Vector();
            vectorobj.Ordenar_Sueldos();
            vectorobj.Mostrar_Sueldos();
            Console.ReadKey();
        }
        public class Vector
        {
            private int[] Sueldos;

            public void Cargar_Vector()
            {
                Sueldos = new int[5];
                for(int fila = 0; fila < Sueldos.Length; fila++)
                {
                    Console.WriteLine("DIGITE UN SUELDO: ");
                    string linea = Console.ReadLine();
                    Sueldos[fila] = int.Parse(linea);
                }

            }
            public void Ordenar_Sueldos()
            {
                for(int f = 0; f < 4; f++)
                {
                    for(int i = 0; i < 4 - f; i++)
                    {
                        if (Sueldos[i] > Sueldos[i + 1])
                        {
                            int aux;
                            aux = Sueldos[i];
                            Sueldos[i] = Sueldos[i + 1];
                            Sueldos[i + 1] = aux;
                        }
                    }
                }
            }
            public void Mostrar_Sueldos()
            {
                Console.WriteLine("SUELDOS ORDENADOS DE MENOR A MAYOR");
                for(int f = 0; f < Sueldos.Length; f++)
                {
                    Console.WriteLine(Sueldos[f]);
                }
                
            }
        }
    }
}
