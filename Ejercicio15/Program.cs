using System;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funciones_Vector vector = new Funciones_Vector();
            vector.Cargar_Vector();
            vector.Identificar_Menor();
            vector.Repeticion_Menor();
            Console.ReadKey();
        }
        public class Funciones_Vector
        {
            private int[] vector;
            private int Dato_Menor;
            public void Cargar_Vector()
            {
                int Numero_Elementos;
                string linea;
                Console.WriteLine("DIGITE EL NUMERO DE ELEMENTOS QUE DESEA CARGAR"); linea = Console.ReadLine();
                Numero_Elementos = int.Parse(linea);
                vector = new int[Numero_Elementos];

                for (int fila = 0; fila < vector.Length; fila++)
                {
                    Console.WriteLine("DIGITE LOS DATOS A CARGAR: "); linea = Console.ReadLine();
                    vector[fila] = int.Parse(linea);
                    
                }
                
            }
            public void Identificar_Menor()
            {
                Dato_Menor = vector[0];

                for(int fila=1; fila < vector.Length; fila++)
                {
                    if (vector[fila] < Dato_Menor)
                    {
                        Dato_Menor = vector[fila];
                    }

                }
                Console.WriteLine("EL MENOR DE LOS DATOS DEL VECTOR ES {0}", Dato_Menor);
            }
            public void Repeticion_Menor()
            {
                int Veces_Repetidas = 0;
                for(int fila = 0; fila < vector.Length; fila++)
                {
                    if (vector[fila] == Dato_Menor)
                    {
                        Veces_Repetidas++;
                    }

                }
                if (Veces_Repetidas > 1)
                {
                    Console.WriteLine("EL DATO MENOR SE REPITE {0} VECES", Veces_Repetidas);
                }
                else
                {
                    Console.WriteLine("EL DATO MENOR NO SE REPITE");
                }
            }
        }
    }
}
