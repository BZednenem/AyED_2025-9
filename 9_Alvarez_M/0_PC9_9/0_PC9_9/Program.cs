using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC9_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double volumen;
            double superficie;
            double radio;
            Console.WriteLine("Para calcular el volumen y la superficie de una esfera, primero hay que conocer su radio. Ingreselo:");
            radio = int.Parse(Console.ReadLine());

            superficie = 4 * 3.14 * (Math.Pow(radio, 2));
            volumen = 4 * 3.14 * (Math.Pow(radio, 3)) / 3;
            Console.WriteLine("La superficie es: " + superficie);
            Console.WriteLine("El volumen es: " + volumen);

            Console.ReadKey();
        }
    }
}
