using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC9_2
{
    class Program
    {
        static int suma (int a, int b)
        {
            return a + b;
        }

        static int resta(int a, int b)
        {
            return a - b;
        }

        static int mult(int a, int b)
        {
            return a * b;
        }

        static int div(int a, int b)
        {
            return a / b;
        }

        static int calculadora (int c, int d)
        {
            int opcion;
            int resultado = 0;
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("---MENÚ---");
                Console.WriteLine("Opción 1: Sumar dos números.");
                Console.WriteLine("Opción 2: Restar dos números");
                Console.WriteLine("Opción 3: Multiplicar dos números");
                Console.WriteLine("Opción 4: Dividir dos números");
                Console.WriteLine("Opción 5: Salir.");
                Console.WriteLine("Seleccione una opción.");



                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        
                             
                        case 1:
                            resultado = suma(c, d);
                            Console.WriteLine("El resultado de la suma es: " + resultado);
                            break;

                        case 2:
                            resultado = resta(c, d);
                            Console.WriteLine("El resultado de la resta es: " + resultado);
                            break;

                        case 3:
                            resultado = mult(c, d);
                            Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                            break;

                        case 4:
                            resultado = div(c, d);
                            Console.WriteLine("El resultado de la división es: " + resultado);
                            break;

                        case 5:
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
            return resultado;
        }

        static void Main (string[] args)
        {
            Console.WriteLine("Introduzca el primer número: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo número: ");
            int d = int.Parse(Console.ReadLine());

            calculadora(c, d);
        }
    }
}
