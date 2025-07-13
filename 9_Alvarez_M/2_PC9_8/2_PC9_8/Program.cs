int n, m;


Console.WriteLine("Ingrese el número de filas (n):");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el número de columnas (m):");
m = int.Parse(Console.ReadLine());
int[,] matriz = new int[n, m];
Console.WriteLine("Matriz inicializada a cero:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}
Console.ReadKey();

