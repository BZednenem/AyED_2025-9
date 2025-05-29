using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("¿Cuál es tu nombre?");
            string nombre = Console.ReadLine();

            Console.WriteLine("¿Cuantos años tenes?");
            
            string edad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + ", tu edad es: " + edad);
            Console.ReadKey();
        }
    }
}
