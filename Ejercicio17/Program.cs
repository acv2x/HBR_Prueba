using System;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vectorobj = new Vector();
            vectorobj.Cargar_Vector();
            vectorobj.Ordenar_Vector();
            vectorobj.Mostrar_Vector();
        }
        public class Vector
        {
            private string[] Paises;
            public void Cargar_Vector()
            {
                Paises = new string[5];
                for(int fila = 0; fila < Paises.Length; fila++)
                {
                    Console.WriteLine("INGRESE UN PAIS: ");
                    Paises[fila] = Console.ReadLine();
                }
            }
            public void Ordenar_Vector()
            {
                for(int f = 0; f < 4; f++)
                {
                    for(int i = 0; i < 4 - f; i++)
                    {
                        if (Paises[i].CompareTo(Paises[i + 1]) > 0)
                        {
                            string aux;
                            aux = Paises[i];
                            Paises[i] = Paises[i + 1];
                            Paises[i + 1] = aux;
                        }
                    }
                }
            }
            public void Mostrar_Vector()
            {
                Console.WriteLine("PAISES EN ORDEN ALFABETICO: ");
                for(int f=0;f < Paises.Length; f++)
                {
                    Console.WriteLine(Paises[f]);

                }
            }

        }
    }
}
