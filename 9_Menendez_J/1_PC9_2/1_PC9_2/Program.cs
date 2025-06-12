using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            float n2;
            float resultado;

            Console.Write("El número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Será dividido por: ");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 / n2;

            if (n2 == 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {


                Console.WriteLine("El resultado es: " + resultado);
            }
            
            Console.ReadKey();
        }
    }
}
