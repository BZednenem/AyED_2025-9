using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC9_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int invitados;
            int comida;

            Console.WriteLine("Solo posible valores entre 1 y 100");

       
            while (true)
            {
                Console.WriteLine("Ingrese el número de invitados:");
                invitados = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el número de comidas:");
                comida = int.Parse(Console.ReadLine());

                Console.Clear();

                if (invitados > 0 && invitados <= 100 && comida > 0 && comida <= 100)
                {
                    int promedio = comida / invitados;
                    Console.WriteLine("El promedio de comida por invitado es: " + promedio);
                    break;
                }
                else
                {
                    Console.WriteLine("Los valores ingresados deben estar entre 1 y 100. Intente nuevamente.");
                }
            }

            Console.ReadKey();
        }
    }
}
