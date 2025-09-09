using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC9_3
{ 
    class Program
    {
        static int opcion;
        static string nombre;
        static bool continuar = true;
        static string codcamion;
        static int distancia;
        static string sede;
        static string asignado;
        static string[,] encargos = new string[25, 5];
        static int cantidadEncargos = 0;

        static int Opcion1(string[,] encargos, int cantidadEncargos)
        {
            Console.Clear();
            if (cantidadEncargos < 25)
            {
                Console.Write("Ingrese el código del camión: ");
                encargos[cantidadEncargos, 0] = Console.ReadLine();

                Console.Write("\nIngrese la distancia en KM: ");
                encargos[cantidadEncargos, 1] = Console.ReadLine();

                if (int.Parse(encargos[cantidadEncargos, 1]) < 0)
                {
                    Console.WriteLine("La distancia no puede ser negativa. Por favor, ingrese un valor válido.");
                    Console.Write("\nIngrese la distancia en KM (MAYOR A 0): ");
                    encargos[cantidadEncargos, 1] = Console.ReadLine();
                }

                Console.Write("\nIngrese la sede:\n1. Buenos Aires (BS.AS.).\n2. Bahía Blanca (BB).\n3. Mar del Plata (MDQ). ");
                encargos[cantidadEncargos, 2] = Console.ReadLine();

                Console.WriteLine("\nIngrese la ganancia esperada del encargo (en pesos argentinos): ");
                encargos[cantidadEncargos, 3] = Console.ReadLine();
                encargos[cantidadEncargos, 4] = "0";  // No asignado inicialmente

                cantidadEncargos++;

                Console.WriteLine("\n¡Encargo registrado con éxito!");
            }
            else
            {
                Console.WriteLine("No hay más espacio... ¡Estamos a Full!");
            }
            return cantidadEncargos;
        }

        static int Opcion2(string[,] encargos, int cantidadEncargos)
        {
            Console.Clear();
            Console.WriteLine("Encargos totales:");
            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");

            for (int i = 0; i < cantidadEncargos; i++)
            {
                Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\t{encargos[i, 4]}");
            }
            return cantidadEncargos;
        }

        static int Opcion3(string[,] encargos, int cantidadEncargos)
        {
            Console.Clear();
            Console.WriteLine("Encargos no asignados:");
            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");

            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (encargos[i, 4] == "0")
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\t{encargos[i, 4]}");
                }
            }

            Console.Write("\nIngrese el N° de encargo a asignar: ");
            int nencargo = int.Parse(Console.ReadLine()) - 1;

            if (encargos[nencargo, 4] == "0")
            {
                Console.Write("Ingrese el código del camión: ");
                string codcamion = Console.ReadLine();
                encargos[nencargo, 4] = codcamion;
                Console.WriteLine("Encargo asignado con éxito.");
            }
            else
            {
                Console.WriteLine("El encargo seleccionado ya tiene un camión asignado.\n");
            }
            return cantidadEncargos;
        }

        static int Opcion4(string[,] encargos, int cantidadEncargos)
        {
            Console.Clear();
            Console.WriteLine("Encargos asignados:");
            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");

            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (encargos[i, 4] != "0")  // Solo mostrar asignados
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\t{encargos[i, 4]}");
                }
            }
            return cantidadEncargos;
        }

        static int Opcion5(string[,] encargos, int cantidadEncargos)
        {
            Console.Clear();
            Console.WriteLine("Promedio de ganancia por sede:");

            double totalGananciasBSAS = 0, totalGananciasBB = 0, totalGananciasMDQ = 0;
            int countBSAS = 0, countBB = 0, countMDQ = 0;

            for (int i = 0; i < cantidadEncargos; i++)
            {
                string sedeActual = encargos[i, 2].ToUpper();
                double ganancia;
                bool gananciaValida = double.TryParse(encargos[i, 3], out ganancia);

                if (!gananciaValida)
                {
                    continue; // Salta encargos con datos no válidos
                }

                switch (sedeActual)
                {
                    case "1":
                    case "BS.AS.":
                        totalGananciasBSAS += ganancia;
                        countBSAS++;
                        break;

                    case "2":
                    case "BB":
                        totalGananciasBB += ganancia;
                        countBB++;
                        break;

                    case "3":
                    case "MDQ":
                        totalGananciasMDQ += ganancia;
                        countMDQ++;
                        break;
                }
            }

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"BS.AS.: {(countBSAS > 0 ? (totalGananciasBSAS / countBSAS).ToString("0.00") : "Sin datos")}");
            Console.WriteLine($"Bahía Blanca: {(countBB > 0 ? (totalGananciasBB / countBB).ToString("0.00") : "Sin datos")}");
            Console.WriteLine($"Mar del Plata: {(countMDQ > 0 ? (totalGananciasMDQ / countMDQ).ToString("0.00") : "Sin datos\n")}");
            return cantidadEncargos;
        }

        static int Opcion6(string[,] encargos, int cantidadEncargos)
        {
            Console.Clear();
            Console.WriteLine("Encargo(s) con mayor distancia:");

            if (cantidadEncargos == 0)
            {
                Console.WriteLine("No hay encargos registrados.");
                return cantidadEncargos;
            }

            int maxDistancia = int.Parse(encargos[0, 1]);

            for (int i = 1; i < cantidadEncargos; i++)
            {
                int distanciaActual = int.Parse(encargos[i, 1]);
                if (distanciaActual > maxDistancia)
                {
                    maxDistancia = distanciaActual;
                }
            }

            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");
            int cantidadMaximos = 0;
            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (int.Parse(encargos[i, 1]) == maxDistancia)
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\t{encargos[i, 4]}");
                    cantidadMaximos++;
                }
            }

            if (cantidadMaximos > 1)
            {
                Console.WriteLine($"\nSe encontraron {cantidadMaximos} encargos con la misma distancia máxima de {maxDistancia} km.");
            }
            return cantidadEncargos;
        }

        static int Opcion7(string[,] encargos, int cantidadEncargos)
        {
            Console.Clear();
            Console.Write("Ingrese el código de camión: ");
            string codigoInvestigador = Console.ReadLine();

            bool hayAsignados = false;

            Console.WriteLine($"\nEncargos asignados al camión {codigoInvestigador}:");
            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");

            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (encargos[i, 4] == codigoInvestigador)
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\t{encargos[i, 4]}\n");
                    hayAsignados = true;
                }
            }

            if (!hayAsignados)
            {
                Console.WriteLine("No hay encargos asignados a este camión.");
            }
            return cantidadEncargos;
        }

        static void Opcion8(ref bool continuar)
        {
            continuar = false;
            Console.WriteLine("Cerrando programa...");
            Console.WriteLine("Adios.");
        }

        static void Main(string[] args)
        {
            while (continuar)
            {
                Console.WriteLine("--- Menú Principal ---");
                Console.WriteLine("Opción 1:  Crear nuevo encargo");
                Console.WriteLine("Opción 2: Mostrar todos los encargos");
                Console.WriteLine("Opción 3: Asignar camión a encargo");
                Console.WriteLine("Opción 4: Mostrar todos los encargos asignados");
                Console.WriteLine("Opción 5: Promedio de ganancia por sede");
                Console.WriteLine("Opción 6: Mostrar el encargo con mayor distancia");
                Console.WriteLine("Opción 7: Filtrar encargos por código de camión");
                Console.WriteLine("Opción 8: Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            cantidadEncargos = Opcion1(encargos, cantidadEncargos);
                            break;
                        case 2:
                            cantidadEncargos = Opcion2(encargos, cantidadEncargos);
                            break;
                        case 3:
                            cantidadEncargos = Opcion3(encargos, cantidadEncargos);
                            break;
                        case 4:
                            cantidadEncargos = Opcion4(encargos, cantidadEncargos);
                            break;
                        case 5:
                            cantidadEncargos = Opcion5(encargos, cantidadEncargos);
                            break;
                        case 6:
                            cantidadEncargos = Opcion6(encargos, cantidadEncargos);
                            break;
                        case 7:
                            cantidadEncargos = Opcion7(encargos, cantidadEncargos);
                            break;
                        case 8:
                            Opcion8(ref continuar);
                            break;
                    }
                }
            }
        }
    }
}
