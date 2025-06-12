using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Escriba un número: ");

            n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
