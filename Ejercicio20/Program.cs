using System;

namespace Ejercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funciones funcionesobj = new Funciones();
            funcionesobj.Ingresar_Datos();
            Console.WriteLine();
            funcionesobj.Imprimir_Datos();
            Console.WriteLine();
            funcionesobj.Calcular_TempTri();
            funcionesobj.Imprimir_Trimestrales();
            Console.WriteLine();
            funcionesobj.Pais_MayorTempTrimestral();
            Console.ReadKey();
        }
        public class Funciones
        {
            private string[] Paises;
            private int[,] Temperaturas_Mensuales;
            private int[] Temperatura_Trimestral;

            public void Ingresar_Datos()
            {
                Paises = new string[4];
                Temperaturas_Mensuales = new int[4, 3];
                for(int f = 0; f < Paises.Length; f++)
                {
                    Console.WriteLine("DIGITE EL NOMBRE DE UN PAIS: ");
                    Paises[f] = Console.ReadLine();
                    for(int c = 0; c < Temperaturas_Mensuales.GetLength(1); c++)
                    {
                        Console.WriteLine("DIGITE LA TEMPERATURA MENSUAL: "); string linea = Console.ReadLine();
                        Temperaturas_Mensuales[f,c] = int.Parse(linea);
                    }
                }

            }
            public void Imprimir_Datos()
            {
                for(int f = 0; f < Paises.Length; f++)
                {
                    Console.Write(Paises[f]+" ");
                    for(int c=0; c < Temperaturas_Mensuales.GetLength(1); c++)
                    {
                        Console.Write(Temperaturas_Mensuales[f, c]+"-");
                    }
                    Console.WriteLine();
                }
            }
            public void Calcular_TempTri()
            {
                Temperatura_Trimestral = new int[4];
                for(int f=0; f < Temperaturas_Mensuales.GetLength(0); f++)
                {
                    int suma = 0;
                    for(int c=0; c < Temperaturas_Mensuales.GetLength(1); c++)
                    {
                        suma = suma + Temperaturas_Mensuales[f, c];
                    }
                    Temperatura_Trimestral[f] = suma / 3;
                }
            }
            public void Imprimir_Trimestrales()
            {
                Console.WriteLine("TEMPERATURAS TRIMESTRALES DE CADA PAIS");
                Console.WriteLine();
                for(int f=0; f < Paises.Length; f++)
                {
                    Console.WriteLine(Paises[f] +" "+ Temperatura_Trimestral[f]);
                }
            }
            public void Pais_MayorTempTrimestral()
            {
                int Mayor = Temperatura_Trimestral[0];
                string Nombre = Paises[0];
                for(int f=0; f < Paises.Length; f++)
                {
                    if (Temperatura_Trimestral[f] > Mayor)
                    {
                        Mayor = Temperatura_Trimestral[f];
                        Nombre = Paises[f];
                    }
                }
                Console.WriteLine("EL PAIS CON MAYOR TEMPRATURA TRIMESTRAL ES: {0} CON UNA TEMPERATURA DE {1}", Nombre, Mayor); 
            }
        }
    }
}
