// See https://aka.ms/new-console-template for more information
int cantVueltas, promedio = 0;


Console.WriteLine("Ingrese la cantidad de vueltas que completo Rayo McQueen: ");
cantVueltas = int.Parse(Console.ReadLine());

int[] tiempos = new int[cantVueltas];

for (int i = 0; i < tiempos.Length; i++)
{
    Console.WriteLine("Escriba el {0} tiempo en segundos: ", i + 1);
    int tiempitos = int.Parse(Console.ReadLine());
    tiempos[i] = tiempitos;
}

for (int i = 0; i < tiempos.Length; i++)
{
    promedio += tiempos[i];
}


double mejorTiempo = tiempos[0];
int numeroMejorVuelta = 1;

for (int i = 1; i < cantVueltas; i++)
{
    if (tiempos[i] < mejorTiempo)
    {
        mejorTiempo = tiempos[i];
        numeroMejorVuelta = i + 1;
    }
}

Console.WriteLine("El tiempo total de la carrera es: " + promedio);
Console.WriteLine("El tiempo promedio de la carrera es: " + (promedio / cantVueltas));
Console.WriteLine("La vuelta mas rapida fue la numero {0} con {1} segundos ", numeroMejorVuelta, mejorTiempo);
