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

int[,] matrizrotar = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrizrotar[j, n - 1 - i] = matriz1[i, j];
    }
}

Console.WriteLine("Matriz1 rotada 90°:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrizrotar[i, j] + "\t");
    }
    Console.WriteLine();
}


Console.ReadKey();

