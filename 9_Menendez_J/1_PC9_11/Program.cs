using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número N: ");
            if (int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("Números pares del 1 al " + N + ":");
                for (int i = 1; i <= N; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
