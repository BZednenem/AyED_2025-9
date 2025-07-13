Console.Write("Ingrese la cantidad de estudiantes: ");
int n = int.Parse(Console.ReadLine());

string[,] estudiantes = new string[n, 3];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\nEstudiante {i + 1}:");

    Console.Write("Nombre: ");
    estudiantes[i, 0] = Console.ReadLine();

    Console.Write("Edad: ");
    estudiantes[i, 1] = Console.ReadLine();

    Console.Write("Calificación: ");
    estudiantes[i, 2] = Console.ReadLine();
}

Console.WriteLine("\nListado de estudiantes:");
Console.WriteLine("N°\tNombre\tEdad\tCalificación");

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{i + 1}\t{estudiantes[i, 0]}\t{estudiantes[i, 1]}\t{estudiantes[i, 2]}");
}

