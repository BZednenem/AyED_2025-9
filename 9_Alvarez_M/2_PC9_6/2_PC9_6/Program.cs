// See https://aka.ms/new-console-template for more information
//Una empresa de desarrollo de software está en proceso de contratar un nuevo equipo para un proyecto importante.
//Durante el proceso de selección, necesitan un programa que ordene los puntajes obtenidos en un examen de menor a mayor,
//y luego filtre aquellos puntajes que sean múltiplos de un número dado.

//1. El programa solicitará al usuario que ingrese la cantidad de candidatos que realizaron el examen.
//
//2. Luego, pedirá al usuario que ingrese los puntajes de cada candidato, uno por uno.
//
//3. Una vez ingresados todos los puntajes, el programa los ordenará de menor a mayor. Posteriormente,
//el programa solicitará al usuario que ingrese un número entero para filtrar los puntajes múltiplos de ese número.
//Finalmente, mostrará al usuario la lista de puntajes ordenados y los puntajes que son múltiplos del número especificado.

int cantidadCandidatos;
Console.Write("Ingrese la cantidad de candidatos que realizaron el examen: ");
cantidadCandidatos = int.Parse(Console.ReadLine());
int[] puntajes = new int[cantidadCandidatos];
for (int i = 0; i < cantidadCandidatos; i++)
{
    Console.Write($"Ingrese el puntaje del candidato {i + 1}: ");
    puntajes[i] = int.Parse(Console.ReadLine());
}
Console.Write("Ingrese un número entero para filtrar los puntajes múltiplos de ese número: ");
int numeroFiltro = int.Parse(Console.ReadLine());

Array.Sort(puntajes);
Console.WriteLine("Puntajes ordenados de menor a mayor:");
Console.WriteLine(string.Join(", ", puntajes));

for (int i = 0; i < cantidadCandidatos; i++)
{
    if (puntajes[i] % numeroFiltro == 0)
    {
        Console.WriteLine("Número mutiplo: "+puntajes[i]);
    }
}