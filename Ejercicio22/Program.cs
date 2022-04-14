using System;

namespace Ejercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AusenciaEmpleados ausenciaempleados_obj = new AusenciaEmpleados();
            ausenciaempleados_obj.Cargar_Datos();
            Console.WriteLine();
            ausenciaempleados_obj.ImprimirEmpAus();
            Console.WriteLine();
            ausenciaempleados_obj.EmpMenosAus();
            Console.ReadKey();
        }
        public class AusenciaEmpleados
        {
            private string[] Nombres;
            private int[][] Ausencias;

            public void Cargar_Datos()
            {
                Nombres = new string[3];
                Ausencias = new int[3][];
                
                for(int f = 0; f < Nombres.Length; f++)
                {
                    Console.WriteLine("DIGITE EL NOMBRE DEL EMPLEADO:");
                    Nombres[f] = Console.ReadLine();
                    Console.WriteLine("DIGITE LA CANTIDAD DE DIAS QUE FALTO EL EMPLEADO:");
                    string linea = Console.ReadLine();
                    int CantidadFaltas = int.Parse(linea);
                    Ausencias[f] = new int[CantidadFaltas];
                    for(int c = 0; c < Ausencias[f].Length; c++)
                    {
                        Console.Write("DIGITE EL NUMERO DEL DIA DE LA SEMANA: "); linea = Console.ReadLine();
                        Ausencias[f][c] = int.Parse(linea);
                    }
                }
            }
            public void ImprimirEmpAus()
            {
                for(int f = 0; f < Nombres.Length; f++)
                {
                    Console.WriteLine("NOMBRE DEL EMPLEADO: {0} - CANTIDAD DE AUSENCIAS: {1}", Nombres[f], Ausencias[f].Length);
                }
            }
            public void EmpMenosAus()
            {
                int ausencias = Ausencias[0].Length;
                string nombres = Nombres[0];
                for(int f = 0; f < Ausencias.Length; f++)
                {
                    if(Ausencias[f].Length < ausencias)
                    {
                        ausencias = Ausencias[f].Length;
                        nombres = Nombres[f];
                    }
                }
                Console.WriteLine("EMPLEADO QUE MENOS AUSENCIAS TIENE: {0} CON {1} FALTAS", nombres, ausencias);
            }
        }
    }
}
