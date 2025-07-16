using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            do
            {
                Console.WriteLine("¿Desea terminar el programa?");
                palabra = Console.ReadLine();


            } while (palabra != "SI");

            {

                Console.WriteLine("¡Hasta la vista!");
                Console.ReadKey();
            }
        }
    }
}
