using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC9_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Console.Write("Digite la palabra: ");
            palabra = Console.ReadLine();

            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);

            string cadenaInvertida = new string(caracteres);

            Console.Write(cadenaInvertida);

            Console.ReadKey();
    }
    }
}
