using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Indique sus ingresos mensuales: ");
            int ing = int.Parse(Console.ReadLine());

            if ((edad > 19) && (ing <= 100000))
            {
                Console.WriteLine("Usted puede cobrar la beca.");
            }

            if ((edad < 19) && (ing == 0))
            {
                Console.WriteLine("Usted puede cobrar la beca.");
            }

            if ((edad == 19) && (ing <= 50000))
            {
                Console.WriteLine("Usted puede cobrar la beca.");
            }

            Console.ReadKey();
        }
    }
}
