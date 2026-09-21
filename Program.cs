using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrcicios_2_nota_creo
{
    internal class Program
    {
        static public int[] Generar_aleatorios(int n, int Valmin, int Valmax)
        {
            int[] N = new int[n];
            Random Var_Random = new Random();

            for (int i = 0; i < n; i++)
            {
                N[i] = Var_Random.Next(Valmin, Valmax + 1);
            }

            return N;
        }

        static public void escribir(int[] N)
        {
            for (int i = 0; i < N.Length; i++)
            {
                Console.WriteLine("[" + N[i] + "]\t");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos números aleatorios desea generar?");
            int n = int.Parse(Console.ReadLine());

            int[] arreglo = Generar_aleatorios(n, 0, 1000000000);

            escribir(arreglo);

            Console.ReadKey();
        }
    }
}