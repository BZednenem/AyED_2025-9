using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite el primer número: ");
            int numero = int.Parse(Console.ReadLine());

            int resto = numero % 2;

            if (numero == 0)
            {
                Console.WriteLine("El número es 0.");
            }
            else if (resto == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }


            


            Console.ReadKey();
        }
    }
}
