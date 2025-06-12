using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC9_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
            Console.WriteLine("Ingrese el primer número:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            numero2 = int.Parse(Console.ReadLine());

            resultado = numero1 % numero2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();
        }
    }
}
