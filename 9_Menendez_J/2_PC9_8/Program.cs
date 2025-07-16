using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC9_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;

            Console.WriteLine("Digite los valores de la fila de la matriz:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite los valores de la columna de la matriz:");
            m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
