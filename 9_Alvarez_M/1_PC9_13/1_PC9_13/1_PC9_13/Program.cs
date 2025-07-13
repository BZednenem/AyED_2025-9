using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string nombre;
            int num1;
            int num2;
            int result;
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("---MENÚ---");
                Console.WriteLine("Opción 1: Saludar.");
                Console.WriteLine("Opción 2: Sumar dos números.");
                Console.WriteLine("Opción 3: Restar dos números");
                Console.WriteLine("Opción 4: Salir.");
                Console.WriteLine("Seleccione una opción.");



                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Escribí tu nombre: ");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Hola " + nombre);

                            break;

                        case 2:
                            Console.WriteLine("Escriba el primer número a sumar: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Escriba el segundo número: ");
                            num2 = int.Parse(Console.ReadLine());
                            result = num1 + num2;
                            Console.WriteLine("El resultado es: " + result);
                            break;

                        case 3:
                            Console.WriteLine("Escriba el primer número a restar: ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Escriba el segundo número: ");
                            num2 = int.Parse(Console.ReadLine());
                            result = num1 - num2;
                            Console.WriteLine("El resultado es: " + result);
                            break;

                        case 4:
                            continuar = false;
                            Console.WriteLine("Adiós.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no valida. Por favor, ingrese un número.");
                }
            }
            Console.ReadKey();
                
        }
    }
}
