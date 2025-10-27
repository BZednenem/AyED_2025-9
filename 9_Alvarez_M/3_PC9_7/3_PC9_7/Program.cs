using static System.Runtime.InteropServices.JavaScript.JSType;

int opcion;
string Nombre;
bool continuar = true;
string Saga;
int Fuerza;
string Defensa;
bool EsHéroe;
string[,] personajes = new string[25, 5];
int cantidadPersonajes = 0;


while (continuar)
{
    Console.WriteLine("--- Menú Principal ---");
    Console.WriteLine("Opción 1:  Crear nuevo personaje:");
    Console.WriteLine("Opción 2: Buscar personaje por nombre:");
    Console.WriteLine("Opción 3: Modificar atributos:");
    Console.WriteLine("Opción 4: Eliminar personaje:");
    Console.WriteLine("Opción 5: Mostrar todos los personajes:");
    Console.WriteLine("Opción 6: Salir.");
    Console.WriteLine("Seleccione una opción.");

    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.Clear();
                if (cantidadPersonajes <= 20)
                {
                    Console.Write("Ingrese el nombre del personaje: ");
                    string nombre = Console.ReadLine();

                    // Validar que no exista
                    bool existe = false;
                    for (int t = 0; t < cantidadPersonajes; t++)
                    {
                        if (personajes[t, 0].Equals(nombre, StringComparison.OrdinalIgnoreCase))
                        {
                            existe = true;
                            break;
                        }
                    }
                    if (existe)
                    {
                        Console.WriteLine("¡Ese nombre ya está registrado! No se puede crear.");
                        break;
                    }

                    personajes[cantidadPersonajes, 0] = nombre;

                    Console.Write("\nIngrese la saga/facción a la que pertenece: ");
                    personajes[cantidadPersonajes, 1] = Console.ReadLine();

                    Console.Write("\nIngrese la cantidad de fuerza del personaje: ");
                    personajes[cantidadPersonajes, 2] = Console.ReadLine();

                    Console.WriteLine("\nIngrese la cantidad de defensa del personaje:");
                    personajes[cantidadPersonajes, 3] = Console.ReadLine();

                    Console.WriteLine("\nEl personaje es un héroe? (s/n)");
                    string heroe = Console.ReadLine().ToLower();

                    bool esHeroe = (heroe == "s"); 
                    personajes[cantidadPersonajes, 4] = esHeroe.ToString();

                    cantidadPersonajes++;

                    Console.WriteLine("\n¡Personaje creado exitosamente!");
                }
                else
                {
                    Console.WriteLine("No hay más espacio. Borrá algún personaje.");
                }



                break;

            case 2:
                Console.Write("Ingrese el nombre del personaje que desea buscar: ");
                string nombreBuscado = Console.ReadLine();

                bool encontrado = false;

                for (int f = 0; f < cantidadPersonajes; f++)
                {
                    if (personajes[f, 0].Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("\n--- Personaje encontrado ---");
                        Console.WriteLine($"Nombre: {personajes[f, 0]}");
                        Console.WriteLine($"Saga/Facción: {personajes[f, 1]}");
                        Console.WriteLine($"Fuerza: {personajes[f, 2]}");
                        Console.WriteLine($"Defensa: {personajes[f, 3]}");
                        Console.WriteLine($"¿Es héroe?: {personajes[f, 4]}");
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("No se encontró ningún personaje con ese nombre.");
                }


                break;

            case 3:

                Console.Write("Ingrese el número del personaje a modificar: ");
                int npj = int.Parse(Console.ReadLine());

                // restar 1 para convertir a índice del arreglo
                int i = npj - 1;

                // validar que el número sea correcto
                if (i >= 0 && i < cantidadPersonajes)
                {
                    Console.Write("\nNueva fuerza: ");
                    personajes[i, 2] = Console.ReadLine();

                    Console.Write("\nNueva defensa: ");
                    personajes[i, 3] = Console.ReadLine();

                    Console.WriteLine("\nPersonaje modificado correctamente.");
                }
                else
                {
                    Console.WriteLine("Número de personaje inválido.");
                }
                break;

            case 4:
                Console.Write("Ingrese el número del personaje a eliminar: ");
                npj = int.Parse(Console.ReadLine());
                int h = npj - 1;

                if (h < 0 || h >= cantidadPersonajes)
                {
                    Console.WriteLine("Número inválido.");
                    break;
                }

                for (int j = h ; j < cantidadPersonajes - 1; j++)
                    for (int k = 0; k < 5; k++)
                        personajes[j, k] = personajes[j + 1, k];

                cantidadPersonajes--;
                Console.WriteLine("Personaje eliminado correctamente.");
                break;


            case 5:
                if (cantidadPersonajes == 0)
                {
                    Console.WriteLine("No hay personajes.");
                    break;
                }

                // Copiamos los nombres a un arreglo temporal
                string[] nombres = new string[cantidadPersonajes];
                for (int ñ = 0; ñ < cantidadPersonajes; ñ++)
                    nombres[ñ] = personajes[ñ, 0];

                // Ordenar los nombres alfabéticamente
                Array.Sort(nombres);

                // Mostrar personajes en orden alfabético
                Console.WriteLine("\nN°\tNombre\tSaga\tFuerza\tDefensa\tHéroe");
                int contador = 1;
                for (int n = 0; n < nombres.Length; n++)
                {
                    for (int ñ = 0; ñ < cantidadPersonajes; ñ++)
                    {
                        if (personajes[ñ, 0] == nombres[n])
                        {
                            Console.WriteLine($"{contador}\t{personajes[ñ, 0]}\t{personajes[ñ, 1]}\t{personajes[ñ, 2]}\t{personajes[ñ, 3]}\t{personajes[ñ, 4]}");
                            contador++;
                            break; // pasamos al siguiente nombre
                        }
                    }
                }
                break;

            case 6:
                continuar = false;
                Console.WriteLine("Cerrando programa...");
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