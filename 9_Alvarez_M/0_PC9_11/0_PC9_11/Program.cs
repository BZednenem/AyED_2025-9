using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC9_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double ancho;
            double altura;
            double perimetro;
            double area;
            double diagonal;

            Console.WriteLine("Ingresa la altura: ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el ancho: ");
            ancho = int.Parse(Console.ReadLine());

            perimetro = 2 * (ancho + altura);
            area = altura * ancho;
            diagonal = Math.Sqrt(Math.Pow(altura, 2)+Math.Pow(ancho, 2));

            Console.WriteLine("El perimetro es: " + perimetro + " El area es: " + area + " La diagonal es: " + diagonal);


            Console.ReadKey();

        }
    }
}
