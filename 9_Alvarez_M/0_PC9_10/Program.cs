using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC9_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double kelvin;
            double farenheit;

            Console.WriteLine("Ingresa la temperatura en grados Celsius para poder pasarlos a Kelvin y Farenheit:");
            celsius = int.Parse(Console.ReadLine());

            kelvin = celsius + 273.15;

            farenheit = celsius * 1.8 + 32;

            Console.WriteLine("La temperatura en Kelvin es: " + kelvin);
            Console.WriteLine("La temperatura en Farenheit es: " + farenheit);
            Console.ReadKey();

        }
    }
}
