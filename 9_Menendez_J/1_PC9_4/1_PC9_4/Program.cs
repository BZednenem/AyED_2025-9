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
            int edad;
            int ingresos;

            Console.Write("¿Cuantos años tenes? ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("¿Cuantos ingresos mensuales tenes? ");
            ingresos = int.Parse(Console.ReadLine());

            if (edad > 19 && ingresos <= 100000)
            {
                Console.Write("Usted puede cobrar la beca.");
            }
            else
            {
                Console.Write("Usted no puede cobrar la beca.");
            }

            if (edad < 19 && ingresos == 0)
            {
                Console.Write("Usted puede cobrar la beca.");
            }
            else
            {
                Console.Write("Usted no puede cobrar la beca.");
            }
                
            if (edad > 19 && ingresos <= 50000)
            {
                Console.Write("Usted puede cobrar la beca.");
            }
            else
            {
                Console.Write("Usted no puede cobrar la beca.");
            }

            Console.ReadKey();
        }
    }
}
