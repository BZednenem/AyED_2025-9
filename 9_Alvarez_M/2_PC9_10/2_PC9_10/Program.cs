// See https://aka.ms/new-console-template for more information
int n, m;
Random random = new Random();
random.Next(1, 101); // Genera un número aleatorio entre 1 y 100


Console.WriteLine("Ingrese el número de filas (n):");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el número de columnas (m):");
m = int.Parse(Console.ReadLine());

int[,] matriz1 = new int[n, m];
int[,] matriz2 = new int[n, m];
int[,] matrizsuma = new int[n, m];

Console.WriteLine("Matriz1:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matriz1[i, j] = random.Next(1, 101);
        Console.Write(matriz1[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Matriz2:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matriz2[i, j] = random.Next(1, 101);
        Console.Write(matriz2[i, j] + "\t");
    }
    Console.WriteLine();
}

// Sumar las matrices y mostrar el resultado
Console.WriteLine("\nMatriz Suma:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrizsuma[i, j] = matriz1[i, j] + matriz2[i, j];
        Console.Write(matrizsuma[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.ReadKey();

