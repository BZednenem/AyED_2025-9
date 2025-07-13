using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC9_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string nombre = "Jugador1";
            int salud = 100;
            int monedas = 50;
            int enemigosDerrotados = 0;
            bool tieneEspada = false;

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("---MENÚ---");
                Console.WriteLine("Opción 1: Mostrar estado del jugador.");
                Console.WriteLine("Opción 2: Encontrar espada mágica.");
                Console.WriteLine("Opción 3: Pelear contra un enemigo.");
                Console.WriteLine("Opción 4: Comprar poción de vida (vale 20 monedas).");
                Console.WriteLine("Opción 5: Salir del juego.");
                Console.WriteLine("Seleccione una opción.");


                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Nombre: "+nombre);
                            Console.WriteLine("Salud: "+salud);
                            Console.WriteLine("Monedas: "+monedas);
                            Console.WriteLine("Enemigos derrotados: "+enemigosDerrotados);
                            Console.WriteLine("Tiene espada: "+tieneEspada); 
                            break;

                        case 2:
                            if (tieneEspada == false)
                            {
                                tieneEspada = true;
                                Console.WriteLine("¡Encontraste la espada mágica!.");
                            }
                            else if (tieneEspada == true)
                            {
                                Console.WriteLine("Ya tenés la espada mágica.");
                            }
                            break;

                        case 3:
                            if (tieneEspada == true)
                            {
                                salud = salud - 10;
                                enemigosDerrotados = enemigosDerrotados + 1;
                                Console.WriteLine("¡Ganaste la batalla! Salud -10.");
                            }
                            else if (tieneEspada == false)
                            {
                                salud = salud - 30;
                                
                                Console.WriteLine("¡Fue una pelea dura sin espada! Salud -30.");
                            }
                            if (salud <= 0)
                            {
                                continuar = false;
                                Console.WriteLine("Moriste.");
                            }
                            break;

                        case 4:
                            if (monedas >= 20)
                            {
                                monedas = monedas - 20;
                                salud = salud + 20;
                                Console.WriteLine("Usaste una poción. +20 de salud.");
                            }
                            else if (monedas < 20)
                            {
                                Console.WriteLine("No tenés suficientes monedas.");
                            }
                            break;

                        case 5:
                            continuar = false;
                            Console.WriteLine("¡Gracias por jugar!");
                            break;
                    }



                }
                else
                {
                    Console.WriteLine("Opción inválida. Elegí una opción del 1 al 5.");
                }
            }
            Console.ReadKey();
        }
    }
}
