using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carrera = 0;
            int promedio = 0;
            Random rand = new Random();
            int vueltas = rand.Next(3, 10);

            Console.WriteLine("Vueltas del Rayo: " + vueltas);

            int[] tiempos = new int[vueltas];

            for (int i = 0; i < vueltas; i++)
            {
                tiempos[i] = rand.Next(150, 500);
                Console.WriteLine($"Tiempo de la vuelta {i + 1}: {tiempos[i]}");

                carrera += tiempos[i];
                promedio = carrera / vueltas;
            }

            double mejorTiempo = tiempos[0];
            int numeroMejorVuelta = 1;

            for (int i = 1; i < vueltas; i++)
            {
                if (tiempos[i] < mejorTiempo)
                {
                    mejorTiempo = tiempos[i];
                    numeroMejorVuelta = i + 1;
                }

            }


            Console.WriteLine($"Tiempo carrera total: {carrera}");
            Console.WriteLine($"Promedio por vuelta: {promedio}");
            Console.WriteLine($"La mejor vuelta es {numeroMejorVuelta} con un tiempo de: {mejorTiempo}");
            Console.ReadKey();  
        }
    }
}
