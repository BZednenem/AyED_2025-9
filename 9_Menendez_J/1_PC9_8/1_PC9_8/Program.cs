using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Introduzca su edad: ");

            edad = int.Parse(Console.ReadLine());

            for (int i = 0; i < edad; i++)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}
