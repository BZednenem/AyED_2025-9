using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC9_0
{
    class Program
    {
        static string saludo (string nombre)
        {
            return "Hola " + nombre + " bienvenido a C#.";
        }
        static void Main(string[] args)
        {
            string mensaje = saludo("Santino");
            Console.WriteLine(mensaje);

            Console.ReadKey(); 
        }
    }
}
