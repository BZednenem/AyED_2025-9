using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;
            Random rand = new Random();
            int probabilidad = rand.Next(1, 101);

            while (sigueVivo)
            {
                Console.WriteLine("Día " + dia + " – ¿Qué querés hacer?");
                Console.WriteLine("1. Buscar comida.");
                Console.WriteLine("2. Dormir.");
                Console.WriteLine("3. Explorar la isla.");
                Console.WriteLine("4. Ver estado del personaje.");
                Console.WriteLine("5. Salir del juego.");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            hambre = hambre + 20;
                            energia = energia - 15;

                            if (probabilidad <= 30)
                            {
                                salud = salud - 15;
                                Console.WriteLine("Comiste algo en mal estado.Salud - 15.");
                            }

                            if (salud <= 0 || hambre <= 0 || energia <= 0)
                            {
                                Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over☠️");
                                sigueVivo = false;
                            }
                            dia = dia + 1;
                            break;

                        case 2:
                            energia = energia + 30;
                            hambre = hambre - 10;
                            Console.WriteLine("Dormiste.");
                            if (salud <= 0 || hambre <= 0 || energia <= 0)
                            {
                                Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                                sigueVivo = false;
                            }
                            dia = dia + 1;
                            break;

                        case 3:
                            energia = energia - 20;
                            hambre = hambre - 15;

                            if (probabilidad <= 50)
                            {
                                salud = salud + 10;
                                Console.WriteLine("Comiste algo en mal estado.Salud - 15.");
                            }

                            if (salud <= 0 || hambre <= 0 || energia <= 0)
                            {
                                Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over☠️");
                                sigueVivo = false;
                            }
                            dia = dia + 1;
                            break;

                        case 4:
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Hambre: " + hambre);
                            Console.WriteLine("Energía: " + energia);
                            dia = dia + 1;
                            break;

                        case 5:
                            sigueVivo = false;
                            Console.WriteLine("Adiós.");
                            break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
