using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC9_1
{
    class Program
    {
        static int suma (int a, int b)
        {

            return a + b;
        }
        static void Main(string[] args)
        {
            int resultado = suma(4, 5);
            Console.WriteLine("El resultado de la suma es: " + resultado);
            Console.ReadKey();

        }
    }
}
