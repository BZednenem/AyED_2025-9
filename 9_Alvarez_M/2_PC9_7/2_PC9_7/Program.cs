// See https://aka.ms/new-console-template for more information
int npos;
int opcion;
int numbuscar;
bool continuar = true;
// Solicitar al usuario el número de posiciones del vector
Console.Write("Ingresa el número de posiciones: ");
npos = int.Parse(Console.ReadLine()!);
int[] vector = new int[npos];
Random random = new Random();
// Llenar el vector con números aleatorios


while (continuar)
{
    Console.WriteLine("---MENÚ---");
    Console.WriteLine("Opción 1: Imprimir en pantalla todos los elementos del vector.");
    Console.WriteLine("Opción 2: Buscar número en el vector.");
    Console.WriteLine("Opción 3: Ordenar vector de forma ascendente o descendente.");
    Console.WriteLine("Opción 4: Salir.");
    Console.WriteLine("Seleccione una opción.");

    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                for (int i = 0; i < npos; i++)
                {
                    vector[i] = random.Next(1, 101); 
                }
                Console.WriteLine(string.Join(", ", vector));

                break;

            case 2:
                Console.Write("Ingrese el número a buscar: ");
                numbuscar = int.Parse(Console.ReadLine()!);
                for (int i = 0; i < npos; i++)
                {
                    if (vector[i] == numbuscar)
                    {
                        Console.WriteLine($"El número {numbuscar} se encuentra en la posición {i + 1} del vector.");
                        break;
                    }
                    else if (i == npos - 1) // Si llegamos al final del vector y no encontramos el número
                    {
                        Console.WriteLine($"El número {numbuscar} no se encuentra en el vector.");
                    }
                }

                break;

            case 3:
                Console.WriteLine("Seleccione el orden de ordenamiento:");
                Console.WriteLine("1. Ascendente");
                Console.WriteLine("2. Descendente");
                int orden = int.Parse(Console.ReadLine()!);
                if (orden == 1)
                {
                    Array.Sort(vector);
                    Console.WriteLine("Vector ordenado de forma ascendente:");
                    Console.WriteLine(string.Join(", ", vector));
                }
                else if (orden == 2)
                {
                    Array.Sort(vector);
                    Array.Reverse(vector);
                    Console.WriteLine("Vector ordenado de forma descendente:");
                    Console.WriteLine(string.Join(", ", vector));
                }
                else
                {
                    Console.WriteLine("Orden no válido.");
                    break;
                }
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