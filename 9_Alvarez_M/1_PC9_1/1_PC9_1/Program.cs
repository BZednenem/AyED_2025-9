using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Escriba su contraseña: ");
            string contraseña = Console.ReadLine().ToUpper();
            string contraseña1 = "santipro".ToUpper();
            if (contraseña == contraseña1)
            {
                Console.WriteLine("La contraseña es correcta.");
            }
            else
            {
                Console.WriteLine("La contraseña es incorrecta.");
            }

            Console.ReadKey();
        }
    }
}
