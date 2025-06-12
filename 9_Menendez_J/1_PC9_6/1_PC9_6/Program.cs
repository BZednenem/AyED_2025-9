using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura;
            Console.WriteLine("Introduzca la temperatura del agua en grados Celsius: ");
            temperatura = int.Parse(Console.ReadLine());

            if (temperatura <= 0)
            {
                Console.WriteLine("El agua se está congelando.");
            }

            if (temperatura >= 100)
            {
                Console.WriteLine("El agua está hirviendo.");
            }
            else if (temperatura >= 1 && temperatura <= 99)
            {
                Console.WriteLine("El agua está en estado liquido.");
            }
            Console.ReadKey();
        }
    }
}
