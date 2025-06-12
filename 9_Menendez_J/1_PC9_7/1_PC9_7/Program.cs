using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int repeticiones = 10;

            Console.WriteLine("Escriba una palabra");
            palabra = Console.ReadLine();

           

            for (int i = 0; i < repeticiones; i++)
            {
                Console.WriteLine(palabra);
            }

            Console.ReadKey();

        }
    }
}
