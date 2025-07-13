// See https://aka.ms/new-console-template for more information
int n;
Random random = new Random();
random.Next(1, 101); // Genera un número aleatorio entre 1 y 100


Console.WriteLine("Ingrese el número de filas y columnas (n):");
n = int.Parse(Console.ReadLine());

int[,] matriz1 = new int[n, n];

Console.WriteLine("Matriz1:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matriz1[i, j] = random.Next(1, 101);
        Console.Write(matriz1[i, j] + "\t");
    }
    Console.WriteLine();
}

int[] diagonal = new int[n];

Console.WriteLine("Diagonal principal de la matriz:");
for (int i = 0; i < n; i++)
{
    diagonal[i] = matriz1[i, i];
    Console.Write(diagonal[i] + "\t");
}
Console.WriteLine();

Console.ReadKey();