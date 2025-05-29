using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("¿Tenes comida? (sí o no):");
                string comida = Console.ReadLine().ToLower();

                Console.WriteLine("¿Tenes refugio? (sí o no):");
                string refugio = Console.ReadLine().ToLower();

                Console.WriteLine("¿Tenes un bate? (sí o no):");
                string bate = Console.ReadLine().ToLower();

                if (comida == "sí" && refugio == "sí" && bate == "sí")
                {
                    Console.WriteLine("¡Sobrevives!");
                }
                else
                {
                    Console.WriteLine("No sobrevives.");
                }
                Console.ReadKey();
            }
        }


    }
}

