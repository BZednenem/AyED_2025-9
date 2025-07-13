// See https://aka.ms/new-console-template for more information

//Llenar una matriz de n×m con valores aleatorios entre un rango dado (por ejemplo, 1 a 100).

int n, m;
Random random = new Random();
random.Next(1, 101); // Genera un número aleatorio entre 1 y 100


Console.WriteLine("Ingrese el número de filas (n):");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el número de columnas (m):");
m = int.Parse(Console.ReadLine());
int[,] matriz = new int[n, m];
Console.WriteLine("Matriz llenada aleatoriamente:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matriz[i, j] = random.Next(1, 101);
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}
Console.ReadKey();
