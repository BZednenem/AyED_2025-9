// See https://aka.ms/new-console-template for more information
int opcion;
string nombre;
bool continuar = true;

string[,] pochidex = new string[75, 5];
int cantidadRegistrados = 0;


while (continuar)
{
    Console.WriteLine("---Menú Principal - Centro de Investigación de Pochimons---");
    Console.WriteLine("Opción 1: Registrar Pochimon .");
    Console.WriteLine("Opción 2: Asignar Investigador a Pochimon.");
    Console.WriteLine("Opción 3: Actualizar Nivel de Pochimon.");
    Console.WriteLine("Opción 4: Marcar Pochimon como Investigado.");
    Console.WriteLine("Opción 5: Mostrar Información de Pochimons.");
    Console.WriteLine("Opción 6: Buscar Pochimons por Tipo.");
    Console.WriteLine("Opción 7: Mostrar Pochimons por Investigador.");
    Console.WriteLine("Opción 8: Mostrar Pochimons Picados.");
    Console.WriteLine("Opción 9: Salir.");
    Console.WriteLine("Seleccione una opción.");



    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.Clear();
                if (cantidadRegistrados < 75)
                {
                    Console.Write("Ingrese el nombre del Pochimon: ");
                    pochidex[cantidadRegistrados, 0] = Console.ReadLine();

                    Console.Write("Ingrese el tipo del Pochimon (A/F/P): ");
                    pochidex[cantidadRegistrados, 1] = Console.ReadLine().ToUpper();

                    Console.Write("Ingrese el nivel del Pochimon: ");
                    pochidex[cantidadRegistrados, 2] = Console.ReadLine();

                    pochidex[cantidadRegistrados, 3] = "0";
                    pochidex[cantidadRegistrados, 4] = "0";

                    cantidadRegistrados++;

                    Console.WriteLine("\n¡Pochimon registrado con éxito!");
                }
                else
                {
                    Console.WriteLine("La Pochidex está llena.");
                }


                break;

            case 2:
                Console.Clear();
                Console.WriteLine("Pochimons no investigados:");
                Console.WriteLine("ID\tNombre\tTipo\tNivel");

                for (int i = 0; i < cantidadRegistrados; i++)
                {
                    if (pochidex[i, 3] == "0") 
                    {
                        Console.WriteLine($"{i + 1}\t{pochidex[i, 0]}\t{pochidex[i, 1]}\t{pochidex[i, 2]}");
                    }
                }

                Console.Write("\nIngrese el ID del Pochimon a asignar: ");
                int id = int.Parse(Console.ReadLine()) - 1;

                if (pochidex[id, 3] == "0")
                {
                    Console.Write("Ingrese el número del investigador: ");
                    string investigador = Console.ReadLine();

                    pochidex[id, 4] = investigador;
                    pochidex[id, 3] = "1"; 

                    Console.WriteLine("Investigador asignado con éxito.");
                }
                else
                {
                    Console.WriteLine("Ese Pochimon ya está siendo investigado o ya fue investigado.\n");
                }
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Pochimons registrados:");
                Console.WriteLine("ID\tNombre\tNivel");

                for (int i = 0; i < cantidadRegistrados; i++)
                {
                    Console.WriteLine($"{i + 1}\t{pochidex[i, 0]}\t{pochidex[i, 2]}");
                }

                Console.Write("\nIngrese el ID del Pochimon a actualizar: ");
                int idActualizar = int.Parse(Console.ReadLine()) - 1;

                Random random = new Random();
                int aumento = random.Next(1, 4); // entre 1 y 3

                int nivelActual = int.Parse(pochidex[idActualizar, 2]);
                int nuevoNivel = nivelActual + aumento;

                pochidex[idActualizar, 2] = nuevoNivel.ToString();

                Console.WriteLine($"\n¡Nivel actualizado! {pochidex[idActualizar, 0]} subió de nivel {nivelActual} → {nuevoNivel}");

                break;

            case 4:
                Console.Clear();
                Console.WriteLine("Pochimons en investigación:");
                Console.WriteLine("ID\tNombre\tTipo\tNivel\tInvestigador");

                bool hayEnInvestigacion = false;

                for (int i = 0; i < cantidadRegistrados; i++)
                {
                    if (pochidex[i, 3] == "1")
                    {
                        Console.WriteLine($"{i + 1}\t{pochidex[i, 0]}\t{pochidex[i, 1]}\t{pochidex[i, 2]}\t{pochidex[i, 4]}");
                        hayEnInvestigacion = true;
                    }
                }

                if (hayEnInvestigacion)
                {
                    Console.Write("\nIngrese el ID del Pochimon a marcar como investigado: ");
                    int idInvestigado = int.Parse(Console.ReadLine()) - 1;

                    if (pochidex[idInvestigado, 3] == "1")
                    {
                        pochidex[idInvestigado, 3] = "2";
                        Console.WriteLine("Pochimon marcado como investigado.");
                    }
                    else
                    {
                        Console.WriteLine("Ese Pochimon no está en investigación.");
                    }
                }
                else
                {
                    Console.WriteLine("No hay Pochimons en investigación.");
                }
                break;


            case 5:
                Console.Clear();
                if (cantidadRegistrados > 0)
                {
                    Console.WriteLine("| ID |Nombre\tTipo\tNivel\tEstado\tInvestigador |");
                    Console.WriteLine("------------------------------------------------------");

                    for (int i = 0; i < cantidadRegistrados; i++)
                    {
                        Console.WriteLine($"{i + 1}\t{pochidex[i, 0]}\t{pochidex[i, 1]}\t{pochidex[i, 2]}\t{pochidex[i, 3]}\t{pochidex[i, 4]}\n");
                    }
                }
                else
                {
                    Console.WriteLine("No hay Pochimons registrados.");
                }

                break;



            case 6:
                Console.Clear();
                Console.Write("Ingrese el tipo de Pochimon a buscar (A/F/P): ");
                string tipoBuscado = Console.ReadLine().ToUpper();

                bool encontrado = false;

                Console.WriteLine("\nPochimons del tipo " + tipoBuscado + ":");
                Console.WriteLine("ID\tNombre\tTipo\tNivel\tEstado\tInvestigador");

                for (int i = 0; i < cantidadRegistrados; i++)
                {
                    if (pochidex[i, 1] == tipoBuscado)
                    {
                        Console.WriteLine($"{i + 1}\t{pochidex[i, 0]}\t{pochidex[i, 1]}\t{pochidex[i, 2]}\t{pochidex[i, 3]}\t{pochidex[i, 4]}\n");
                        encontrado = true;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("No se encontraron Pochimons de ese tipo.\n");
                }

                break;


            case 7:
                Console.Clear();
                Console.Write("Ingrese el número del investigador: ");
                string codigoInvestigador = Console.ReadLine();

                bool hayAsignados = false;

                Console.WriteLine($"\nPochimons asignados al investigador {codigoInvestigador}:");
                Console.WriteLine("ID\tNombre\tTipo\tNivel\tEstado");

                for (int i = 0; i < cantidadRegistrados; i++)
                {
                    if (pochidex[i, 4] == codigoInvestigador)
                    {
                        Console.WriteLine($"{i + 1}\t{pochidex[i, 0]}\t{pochidex[i, 1]}\t{pochidex[i, 2]}\t{pochidex[i, 3]}");
                        hayAsignados = true;
                    }
                }

                if (!hayAsignados)
                {
                    Console.WriteLine("No hay Pochimons asignados a ese investigador.");
                }

                break;


            case 8:
                Console.Clear();
                Console.WriteLine("Pochimons Picados (nivel > 30):");
                Console.WriteLine("ID\tNombre\tTipo\tNivel");

                bool hayPicados = false;

                for (int i = 0; i < cantidadRegistrados; i++)
                {
                    int nivel = int.Parse(pochidex[i, 2]);

                    if (nivel > 30)
                    {
                        Console.WriteLine($"{i + 1}\t{pochidex[i, 0]}\t{pochidex[i, 1]}\t{pochidex[i, 2]}");
                        hayPicados = true;
                    }
                }

                if (!hayPicados)
                {
                    Console.WriteLine("No hay Pochimons picados.");
                }

                break;


            case 9:
                continuar = false;
                Console.WriteLine("Cerrando Pochidex...");
                Console.WriteLine("Adios.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Entrada no valida. Por favor, ingrese un número.");
    }
}
Console.ReadKey();