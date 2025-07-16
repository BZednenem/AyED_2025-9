using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kevin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            int opcion;
            bool sigueVivo = true;
            Random rand = new Random();


            while (sigueVivo)
            {


                Console.WriteLine("Día " + dia + " – ¿Qué querés hacer?");
                Console.WriteLine("1. Buscar comida");
                Console.WriteLine("2. Dormir");
                Console.WriteLine("3. Explorar la isla");
                Console.WriteLine("4. Ver estado del personaje");
                Console.WriteLine("5. Salir del juego");
                Console.WriteLine("Seleccione una opción.");

                if (salud <= 0 || hambre <= 0 || energia <= 0)
                {
                    Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over☠️");
                    sigueVivo = false;
                }

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                        case 1:

                                Console.Clear();

                                hambre += 20;
                                energia -= 15;

                                Console.WriteLine("Encontraste algo de comida. Hambre +20, Energía -15.");

                            int probabilidad = rand.Next(1, 101);

                                if (probabilidad <= 30)
                                {
                                    salud -= 15;
                                    Console.WriteLine("Comiste algo en mal estado. Salud -15.");
                                }

                                dia++;
                                break;

                            case 2:

                               Console.Clear();

                                energia += 30;
                                hambre -= 10;

                                Console.WriteLine("Dormiste bien. Energía +30, Hambre -10.");

                                dia++;
                                break;

                            case 3:

                               Console.Clear();

                                energia -= 20;
                                hambre -= 15;

                                int probabilidad2 = rand.Next(1, 101);

                                if (probabilidad2 <= 50)
                                {
                                    salud += 10;
                                    Console.WriteLine("¡Encontraste unas hojijas curativas! Salud +10.");
                                }

                                dia++;
                                break;

                            case 4:

                                Console.Clear();

                                Console.WriteLine("--TUS STATS--");
                                Console.WriteLine("Dia" + dia);
                                Console.WriteLine("Tu salud: " + salud);
                                Console.WriteLine("Tu hambre: " + hambre);
                                Console.WriteLine("Tu energia: " + energia);

                                break;

                            case 5:

                               Console.Clear();

                                sigueVivo = false;
                                Console.WriteLine("Gracias por jugar.");
                                Console.WriteLine("Saliendo...");
                                Console.ReadKey();

                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida. Elegí una opción del 1 al 5.");
                    }
            }
        }
    }
}
