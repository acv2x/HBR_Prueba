using System;

namespace Ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vectorobj = new Vector();
            vectorobj.Cargar_Vectores();
            Console.WriteLine();
            vectorobj.OrdenarPorAlfabeto();
            Console.WriteLine("ORDENADOS POR ALFABETO");
            vectorobj.Imprimir();
            Console.WriteLine();
            vectorobj.OrdenarPorHabitantes();
            Console.WriteLine("ORDENADOS POR NUMERO DE HABITANTES");
            vectorobj.Imprimir();
            Console.ReadKey();
        }
        public class Vector
        {
            private string[] paises;
            private int[] habitantes;

            public void Cargar_Vectores()
            {
                paises = new string[5];
                habitantes = new int[5];
                for(int f=0; f<paises.Length; f++)
                {
                    Console.WriteLine("INGRESAR PAIS: ");
                    paises[f] = Console.ReadLine();
                    Console.WriteLine("INGRESAR NUMERO DE HABITANTES: ");
                    habitantes[f] = int.Parse(Console.ReadLine());
                }
            }
            public void OrdenarPorAlfabeto()
            {
                for(int f = 0; f < paises.Length; f++)
                {
                    for(int i =0; i < paises.Length - 1 - f; i++)
                    {
                        if (paises[i].CompareTo(paises[i + 1]) > 0)
                        {
                            string auxpais;
                            auxpais = paises[i];
                            paises[i] = paises[i + 1];
                            paises[i + 1] = auxpais;
                            int auxhabitantes;
                            auxhabitantes = habitantes[i];
                            habitantes[i] = habitantes[i + 1];
                            habitantes[i + 1] = auxhabitantes;

                        }
                    }
                }
            }
            public void OrdenarPorHabitantes()
            {
                for(int f = 0; f < paises.Length; f++)
                {
                    for(int i = 0; i < paises.Length - 1 -f; i++)
                    {
                        if (habitantes[i] < habitantes[i + 1])
                        {
                            string auxpais;
                            auxpais = paises[i];
                            paises[i] = paises[i + 1];
                            paises[i + 1] = auxpais;
                            int auxhabitantes;
                            auxhabitantes = habitantes[i];
                            habitantes[i] = habitantes[i + 1];
                            habitantes[i + 1] = auxhabitantes;
                        }
                    }
                }
            }
            public void Imprimir()
            {
                for(int f = 0; f < paises.Length; f++)
                {
                    Console.WriteLine(paises[f] + "-" + habitantes[f]);
                }
            }
        }
    }
}
