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

            string password;

            password = "santipro11" .ToUpper();



            Console.WriteLine("Escriba la contraseña: ");
            if (password == Console.ReadLine().ToUpper())
            {
                Console.WriteLine("La contraseña es correcta :)");
            }
            else
            {
                Console.WriteLine("La contraseña es incorrecta :( ");
            }
            Console.ReadKey();
        }
    }
}
