// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese un número N: ");
if (int.TryParse(Console.ReadLine(), out int N))
{
    Console.WriteLine("Números pares del 1 al " + N + ":");
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
Console.ReadKey();
